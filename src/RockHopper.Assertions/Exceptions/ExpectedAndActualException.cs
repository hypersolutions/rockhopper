using System.Text;

namespace RockHopper.Assertions.Exceptions;

public sealed class ExpectedAndActualException<T> : AssertExceptionBase
{
    public ExpectedAndActualException(T? expected, T? actual, string? customErrorMessage = null)
    {
        var message = new StringBuilder();

        if (customErrorMessage is not null)
            message.AppendLine(customErrorMessage);
        
        if (expected is null && actual is not null)
        {
            message.AppendLine($"The expected value was null but got {actual}.");
        }
        else if (expected is not null && actual is null)
        {
            message.AppendLine($"The expected value was {expected} but got null.");
        }
        else
        {
            message.AppendLine($"The expected value was {expected} but got {actual}.");
        }

        Message = message.ToString();
    }

    public override string Message { get; }
}