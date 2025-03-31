using System.Collections;
using System.Reflection;
using RockHopper.Engine.TestNodes;

namespace RockHopper.Engine;

internal static class TestNodeFactory
{
    internal static IList<PlatformTestNode> Create(params Assembly[] assemblies)
    {
        const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
        var testNodes = new List<PlatformTestNode>();
        
        foreach (var testType in assemblies.SelectMany(a => a.GetTypes()))
        {
            foreach (var method in testType.GetMethods(flags))
            {
                var testAttrs = method.GetCustomAttributes<TestAttribute>();

                foreach (var testAttr in testAttrs)
                {
                    if (testAttr.InlineArgs?.Length > 0)
                    {
                        testNodes.Add(PlatformTestNode.Create(testType, method, testAttr)); 
                    }
                    
                    if (testAttr.ClassArgs is not null)
                    {
                        AppendClassArgs(testNodes, testType, method, testAttr);
                    }
                    
                    if (testAttr.MemberArgs is not null)
                    {
                        AppendMemberArgs(testNodes, testType, method, testAttr);
                    }

                    if (testAttr.HasNoArgs)
                    {
                        testNodes.Add(PlatformTestNode.Create(testType, method, testAttr));
                    }
                }
            }
        }

        return testNodes;
    }

    private static void AppendClassArgs(
        List<PlatformTestNode> testNodes, 
        Type testType, 
        MethodInfo method, 
        TestAttribute testAttr)
    {
        var classArgs = Activator.CreateInstance(testAttr.ClassArgs!);

        if (classArgs is not IEnumerable enumerable)
        {
            var skippedTestNode = PlatformTestNode.Create(
                testType, method, testAttr, skipOverride: "Unable to get enumerable for class data.");
            testNodes.Add(skippedTestNode);
            return;
        }

        AppendEnumerableArgs(testNodes, testType, method, testAttr, enumerable);
    }

    private static void AppendMemberArgs(
        List<PlatformTestNode> testNodes, 
        Type testType, 
        MethodInfo method, 
        TestAttribute testAttr)
    {
        var memberProperty = testType.GetProperty(testAttr.MemberArgs!, BindingFlags.Public | BindingFlags.Static);

        if (memberProperty is null)
        {
            var skippedTestNode = PlatformTestNode.Create(
                testType, method, testAttr, skipOverride: "Unable to get property for member data.");
            testNodes.Add(skippedTestNode);
            return;
        }
        
        var value = memberProperty.GetValue(null);

        if (value is not IEnumerable enumerable)
        {
            var skippedTestNode = PlatformTestNode.Create(
                testType, method, testAttr, skipOverride: "Unable to get enumerable for member data.");
            testNodes.Add(skippedTestNode);
            return;
        }
        
        AppendEnumerableArgs(testNodes, testType, method, testAttr, enumerable);
    }

    private static void AppendEnumerableArgs(
        List<PlatformTestNode> testNodes, 
        Type testType, 
        MethodInfo method, 
        TestAttribute testAttr, 
        IEnumerable enumerable)
    {
        var enumerator = enumerable.GetEnumerator();
        using var disposable = enumerator as IDisposable;
        
        while (enumerator.MoveNext() && enumerator.Current is not null)
        {
            if (TestArgsMatch(method, enumerator.Current))
            {
                var testArgs = enumerator.Current.GetType().GetFields()
                    .Where(p => p.Name.StartsWith("Item"))
                    .Select(p => p.GetValue(enumerator.Current))
                    .ToArray();
                testNodes.Add(PlatformTestNode.Create(testType, method, testAttr, testArgs));
            }
            else
            {
                var skippedTestNode = PlatformTestNode.Create(
                    testType, method, testAttr, skipOverride: "Unable to match the data argument types with the test method.");
                testNodes.Add(skippedTestNode);
            }
        }
    }

    private static bool TestArgsMatch(MethodInfo method, object testArgs)
    {
        var fields = testArgs.GetType().GetFields().Where(p => p.Name.StartsWith("Item")).ToArray();
        var parameters = method.GetParameters();
        return fields.Length == parameters.Length &&
               !fields.Where((t, i) => t.FieldType != parameters[i].ParameterType).Any();
    }
}