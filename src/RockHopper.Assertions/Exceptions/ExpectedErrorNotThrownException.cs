using System.Text;

namespace RockHopper.Assertions.Exceptions;

public sealed class ExpectedErrorNotThrownException<TException> : AssertExceptionBase where TException : Exception
{
    public ExpectedErrorNotThrownException(string? customErrorMessage = null)
    {
        var message = new StringBuilder();

        if (customErrorMessage is not null)
            message.AppendLine(customErrorMessage);
        
        message.AppendLine($"The expected exception {nameof(TException)} was not thrown.");
        
        Message = message.ToString();
    }

    public override string Message { get; }
}