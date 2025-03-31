using System.Text;
using Microsoft.Testing.Platform.Extensions.Messages;

#pragma warning disable TPEXP

namespace RockHopper;

internal sealed class TestOutput : ITestOutput
{
    public StringBuilder Output { get; } = new();

    public void WriteLine(string message) => Output.AppendLine(message);

    internal void AppendToTestNode(TestNode testNode)
    {
        if (Output.Length > 0)
        {
            testNode.Properties.Add(new StandardOutputProperty(Output.ToString()));
        }
    }
}