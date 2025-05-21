using System.Collections.Concurrent;
using System.Collections.Frozen;
using RockHopper.Builder;
using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper;

/// <summary>
/// Factory to create the test subject and its mock dependencies.
/// </summary>
public static class TestSubject
{
    private static readonly ConcurrentDictionary<object, TestSubjectInfo> _testSubjectAndMocks = new();
    private static bool _exit;
    
    static TestSubject()
    {
        InitCleanupThread();
    }
    
    /// <summary>
    /// Create the subject info and mock dependency information.
    /// </summary>
    /// <param name="builderFlags">How to construct the subject</param>
    /// <param name="constructorSelector">How to choose the constructor - defaults to the first constructor</param>
    /// <returns>Test subject</returns>
    public static TSubject Create<TSubject>(
        SubjectBuilderFlags builderFlags = SubjectBuilderFlags.Constructor, 
        IConstructorSelector? constructorSelector = null) where TSubject : notnull
    {
        constructorSelector ??= new DefaultConstructorSelector();
        var testSubjectCache = TestSubjectCache.Get<TSubject>(constructorSelector, builderFlags);
        var parameterMocks = testSubjectCache.BuildParameterMocks();
        var propertyMocks = testSubjectCache.BuildPropertyMocks();

        var subject = testSubjectCache.CreateSubject<TSubject>(parameterMocks, propertyMocks);
        var mocks = testSubjectCache.MergeMocks(parameterMocks, propertyMocks);
        Track(subject, mocks);
        return subject;
    }
    
    /// <summary>
    /// Find a mock dependency injected into the subject instance.
    /// </summary>
    /// <typeparam name="TMock">Mock type</typeparam>
    /// <returns>Mock instance if found</returns>
    /// <exception cref="TestException">Unable to find the mock type</exception>
    public static Mock<TMock> GetMock<TMock>(this object testSubject) where TMock : class
    {
        var testSubjectInfo = GetTestSubjectInfo(testSubject);
        var mock = testSubjectInfo.Mocks.FirstOrDefault(m => m.GetInstance() is TMock) 
                   ?? throw new TestException($"Unable to find a mock for {typeof(TMock)}.");
        return (Mock<TMock>)mock;
    }
    
    /// <summary>
    /// Verifies all the mocks have had the setups called as per strict mock behaviour. This will also reset the visit
    /// counts and any return/exception sequences, allowing you to reuse during the test.
    /// </summary>
    public static void VerifyAll(this object testSubject)
    {
        var testSubjectInfo = GetTestSubjectInfo(testSubject);
        testSubjectInfo.Mocks.ForEach(m => m.VerifyAll());
    }

    private static void Track<TSubject>(TSubject subject, List<Mock> mocks) where TSubject : notnull
    {
        _testSubjectAndMocks.AddOrUpdate(
            subject, 
            _ => new TestSubjectInfo(subject, mocks), 
            (_, _) => new TestSubjectInfo(subject, mocks));
    }
    
    private static TestSubjectInfo GetTestSubjectInfo(object testSubject)
    {
        if (!_testSubjectAndMocks.TryGetValue(testSubject, out var testSubjectInfo))
            throw new TestException("Unable to find the test subject information for the test instance.");

        return testSubjectInfo;
    }

    private static void InitCleanupThread()
    {
        // This mechanism allows for some releasing of objects that are no longer being used.
        // Any test subject instances no longer referenced (null) will also need the mocks removing to the GC can collect
        // those objects too. It uses a weak reference on the test subject to check against. This will help keep the 
        // memory under control - might not be perfect but allows the API to work nicely being extensions of the test
        // subject instance.
        
        AppDomain.CurrentDomain.ProcessExit += (_, _) => _exit = true;
        var backgroundThread = new Thread(CheckForUnreferencedTestSubjects)
        {
            IsBackground = true
        };

        backgroundThread.Start();
    }

    private static void CheckForUnreferencedTestSubjects()
    {
        const int waitUntilNextCheckMilliSeconds = 1000;
        
        while (!_exit)
        {
            var unreferencedTestSubjects = _testSubjectAndMocks.Where(m => m.Value.IsUnreferenced).ToFrozenDictionary();
                
            foreach (var testSubject in unreferencedTestSubjects)
            {
                _testSubjectAndMocks.TryRemove(testSubject);
            }
                
            Thread.Sleep(waitUntilNextCheckMilliSeconds);
        }
    }

    private class TestSubjectInfo
    {
        private readonly WeakReference _weakReference;
        
        public TestSubjectInfo(object testSubject, List<Mock> mocks)
        {
            _weakReference = new WeakReference(testSubject);
            Mocks = mocks;
        }
        
        public List<Mock> Mocks { get; }
        
        public bool IsUnreferenced => !_weakReference.IsAlive;
    }
}