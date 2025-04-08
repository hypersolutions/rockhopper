using System.Text;

namespace RockHopper.Assertions.Exceptions;

public sealed class ActualNullStateException<T> : AssertExceptionBase
{
    public ActualNullStateException(T? actual, bool expectingNull, string? customErrorMessage = null)
    {
        var message = new StringBuilder();

        if (customErrorMessage is not null)
            message.AppendLine(customErrorMessage);
        
        if (actual is not null && expectingNull)
        {
            message.AppendLine("The expected state was null but got a not null actual value.");
        }
        else if (actual is null && !expectingNull)
        {
            message.AppendLine("The expected state was not null but got a null actual value.");
        }

        Message = message.ToString();
    }

    public override string Message { get; }
}