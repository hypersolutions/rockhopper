namespace RockHopper.TestSupport.Processing;

public sealed class CleanAndLowerStep : IProcessStep
{
    public string Process(string text) => text.ToLower().Trim();
}