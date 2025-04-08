using System.Text;

namespace RockHopper.Assertions.Exceptions;

public sealed class ExpectedErrorThrownException<TException> : AssertExceptionBase where TException : Exception
{
    public ExpectedErrorThrownException(string? customErrorMessage = null)
    {
        var message = new StringBuilder();

        if (customErrorMessage is not null)
            message.AppendLine(customErrorMessage);
        
        message.AppendLine($"The expected exception {nameof(TException)} was thrown.");
        
        Message = message.ToString();
    }

    public override string Message { get; }
}