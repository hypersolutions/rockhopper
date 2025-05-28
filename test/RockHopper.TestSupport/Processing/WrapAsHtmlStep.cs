namespace RockHopper.TestSupport.Processing;

public sealed class WrapAsHtmlStep : IProcessStep
{
    public string Process(string text) => $"<{text}/>";
}