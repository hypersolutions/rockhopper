using System.Reflection;

namespace RockHopper.Mocking.Extensions;

internal static class MethodInfoExtensions
{
    private const string GetUnderscore = "get_";
    private const string SetUnderscore = "set_";
    private const string GetIndexer = "get_Item";
    private const string SetIndexer = "set_Item";
    private const string Indexer = "Indexer";
    
    internal static void CheckMethodIsOverridable(this MethodInfo method)
    {
        if (!(method.IsAbstract || method.IsVirtual))
        {
            var methodName = method.Name;

            if (methodName.StartsWith(GetUnderscore))
            {
                methodName = methodName.Replace(GetUnderscore, string.Empty);
            }
            else if (methodName.StartsWith(SetUnderscore))
            {
                methodName = methodName.Replace(SetUnderscore, string.Empty);
            }
            else if (methodName is GetIndexer or SetIndexer)
            {
                methodName = Indexer;
            }
            
            throw new ArgumentException($"Provided method or property {methodName} is not virtual or abstract.");
        }
    }
}