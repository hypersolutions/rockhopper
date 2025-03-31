using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace RockHopper.Analyzer;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class UnusedMethodAnalyzer : DiagnosticAnalyzer
{
    private static readonly LocalizableString _title = GetResource(nameof(Resources.RH001Title));
    private static readonly LocalizableString _messageFormat = GetResource(nameof(Resources.RH001MessageFormat));
    private static readonly LocalizableString _description = GetResource(nameof(Resources.RH001Description));
    private static readonly DiagnosticDescriptor _diagnosticDescriptor = GetDiagnosticDescriptor();
    private const string DiagnosticId = "RH001";
    private const string Category = "CodeQuality";
    private const string TestAttributeName = "TestAttribute";

    public override System.Collections.Immutable.ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics 
        => System.Collections.Immutable.ImmutableArray.Create(_diagnosticDescriptor);

    public override void Initialize(AnalysisContext context)
    {
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        context.EnableConcurrentExecution();
        context.RegisterSymbolAction(AnalyzeSymbol, SymbolKind.Method);
    }

    private static void AnalyzeSymbol(SymbolAnalysisContext context)
    {
        var methodSymbol = (IMethodSymbol)context.Symbol;

        if (methodSymbol.DeclaredAccessibility != Accessibility.Public) return;
        
        var testAttribute = methodSymbol.GetAttributes().FirstOrDefault(attr => attr.AttributeClass?.Name == TestAttributeName);
        
        if (testAttribute is null)
        {
            var diagnostic = Diagnostic.Create(_diagnosticDescriptor, methodSymbol.Locations[0], methodSymbol.Name);
            context.ReportDiagnostic(diagnostic);
        }
    }

    private static LocalizableString GetResource(string resourceName)
    {
        return new LocalizableResourceString(resourceName, Resources.ResourceManager, typeof(Resources));
    }

    private static DiagnosticDescriptor GetDiagnosticDescriptor()
    {
        return new DiagnosticDescriptor(
            DiagnosticId, 
            _title, 
            _messageFormat, 
            Category, 
            DiagnosticSeverity.Warning, 
            isEnabledByDefault: true, 
            description: _description);
    }
}
