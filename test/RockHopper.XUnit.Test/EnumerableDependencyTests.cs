using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport.Processing;

namespace RockHopper.XUnit.Test;

public class EnumerableDependencyTests
{
    [Fact]
    public void UsingNonMockedEnumerableSteps_Process_ReturnsProcessedTag()
    {
        var textToTag = TestSubject.Create<TextToTag>();
        var processSteps = textToTag.GetMock<IEnumerable<IProcessStep>>();
        List<IProcessStep> stepList = [new CleanAndLowerStep(), new WrapAsHtmlStep()];
        processSteps.Function(s => s.GetEnumerator()).Returns(stepList.GetEnumerator());

        var result = textToTag.Process("HEAD");
        
        result.ShouldBe("<head/>");
    }
    
    [Fact]
    public void UsingMockedEnumerableSteps_Process_ReturnsProcessedTag()
    {
        var textToTag = TestSubject.Create<TextToTag>();
        var processSteps = textToTag.GetMock<IEnumerable<IProcessStep>>();
        var step1 = new Mock<IProcessStep>();
        step1.Function(f => f.Process("HEAD")).Returns("head");
        var step2 = new Mock<IProcessStep>();
        step2.Function(f => f.Process("head")).Returns("<head/>");
        List<IProcessStep> stepList = [step1.Value, step2.Value];
        processSteps.Function(s => s.GetEnumerator()).Returns(stepList.GetEnumerator());

        var result = textToTag.Process("HEAD");
        
        result.ShouldBe("<head/>");
    }
}