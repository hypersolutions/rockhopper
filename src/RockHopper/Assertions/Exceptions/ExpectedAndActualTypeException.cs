using System.Text;

namespace RockHopper.Assertions.Exceptions;

public sealed class ExpectedAndActualTypeException : AssertExceptionBase
{
    public ExpectedAndActualTypeException(Type expected, Type actual, string? customErrorMessage = null)
    {
        var message = new StringBuilder();

        if (customErrorMessage is not null)
            message.AppendLine(customErrorMessage);
        
        message.AppendLine($"The actual type {actual.FullName} does not match the expected type {expected.FullName}.");
        
        Message = message.ToString();
    }

    public override string Message { get; }
}