using System.Text;
using Microsoft.Testing.Platform.Extensions.Messages;

#pragma warning disable TPEXP

namespace RockHopper.Test;

internal sealed class TestOutput : ITestOutput
{
    private readonly StringBuilder _output = new();
    
    public void WriteLine(string message) => _output.AppendLine(message);

    internal void AppendToTestNode(TestNode testNode)
    {
        if (_output.Length > 0)
        {
            testNode.Properties.Add(new StandardOutputProperty(_output.ToString()));
        }
    }
}