namespace RockHopper.TestSupport.Processing;

public class TextToTag
{
    private readonly IEnumerable<IProcessStep> _processSteps;

    public TextToTag(IEnumerable<IProcessStep> processSteps)
    {
        _processSteps = processSteps;
    }
    
    public string Process(string text)
    {
        return _processSteps.Aggregate(text, (current, step) => step.Process(current));
    }    
}