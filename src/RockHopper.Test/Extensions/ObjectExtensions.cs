namespace RockHopper.Test.Extensions;

internal static class ObjectExtensions
{
    internal static async Task Dispose(this object obj)
    {
        switch (obj)
        {
            case IDisposable disposeObj:
                disposeObj.Dispose();
                break;
            case IAsyncDisposable asyncDisposeObj:
                await asyncDisposeObj.DisposeAsync();
                break;
        }
    }
}