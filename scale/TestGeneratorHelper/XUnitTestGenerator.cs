using System.Text;

namespace TestGeneratorHelper;

public static class XUnitTestGenerator
{
    private const string TargetNamespace = "XUnitScaleTest";
    
    public static void GenerateAddPositive(int classCount, int testMethodCount, int testCount)
    {
        var testClassCodeBuilder = new StringBuilder();

        testClassCodeBuilder.AppendLine("using Xunit;");
        testClassCodeBuilder.AppendLine("using Shouldly;");
        testClassCodeBuilder.AppendLine("using NSubstitute;");
        testClassCodeBuilder.AppendLine("using ClassLibrary1SourceProject;");
        testClassCodeBuilder.AppendLine();
        testClassCodeBuilder.AppendLine($"namespace {TargetNamespace};");
        testClassCodeBuilder.AppendLine();

        for (var a = 1; a <= classCount; a++)
        {
            testClassCodeBuilder.AppendLine($"public class AddPositiveNumbersTests{a}");
            testClassCodeBuilder.AppendLine("{");
            testClassCodeBuilder.AppendLine(
                "    private readonly CalculatorService _calculatorService;");
            testClassCodeBuilder.AppendLine(
                "    private readonly ICalculator _calculator;");
            testClassCodeBuilder.AppendLine();
            
            testClassCodeBuilder.AppendLine($"    public AddPositiveNumbersTests{a}()");
            testClassCodeBuilder.AppendLine("     {");
            testClassCodeBuilder.AppendLine("         _calculator = Substitute.For<ICalculator>();");
            testClassCodeBuilder.AppendLine("         _calculatorService = new CalculatorService(_calculator);");
            testClassCodeBuilder.AppendLine("     }");
            testClassCodeBuilder.AppendLine();
            
            for (var b = 1; b <= testMethodCount; b++)
            {
                testClassCodeBuilder.AppendLine("    [Theory]");
                
                for (var c = 0; c < testCount; c++)
                {
                    var x = c;
                    var y = c + 2;
                    var r = x + y;

                    testClassCodeBuilder.AppendLine($"    [InlineData({x}, {y}, {r})]");
                }

                testClassCodeBuilder.AppendLine(
                    $"    public void TwoPositiveNumbers{b}_AddNumbers_ReturnSum(int x, int y, int r)");
                testClassCodeBuilder.AppendLine("    {");
                testClassCodeBuilder.AppendLine("        _calculator.Add(x, y).Returns(r);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        var result = _calculatorService.AddNumbers(x, y);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        result.ShouldBe(r);");
                testClassCodeBuilder.AppendLine("    }");
            }

            testClassCodeBuilder.AppendLine("}");
        }

        File.WriteAllText("AddPositiveNumbersTests.cs", testClassCodeBuilder.ToString());
    }
    
    public static void GenerateAddNegative(int classCount, int testMethodCount, int testCount)
    {
        var testClassCodeBuilder = new StringBuilder();

        testClassCodeBuilder.AppendLine("using Xunit;");
        testClassCodeBuilder.AppendLine("using Shouldly;");
        testClassCodeBuilder.AppendLine("using NSubstitute;");
        testClassCodeBuilder.AppendLine("using ClassLibrary1SourceProject;");
        testClassCodeBuilder.AppendLine();
        testClassCodeBuilder.AppendLine($"namespace {TargetNamespace};");
        testClassCodeBuilder.AppendLine();

        for (var a = 1; a <= classCount; a++)
        {
            testClassCodeBuilder.AppendLine($"public class AddNegativeNumbersTests{a}");
            testClassCodeBuilder.AppendLine("{");
            testClassCodeBuilder.AppendLine(
                "    private readonly CalculatorService _calculatorService;");
            testClassCodeBuilder.AppendLine(
                "    private readonly ICalculator _calculator;");
            testClassCodeBuilder.AppendLine();
            
            testClassCodeBuilder.AppendLine($"    public AddNegativeNumbersTests{a}()");
            testClassCodeBuilder.AppendLine("     {");
            testClassCodeBuilder.AppendLine("         _calculator = Substitute.For<ICalculator>();");
            testClassCodeBuilder.AppendLine("         _calculatorService = new CalculatorService(_calculator);");
            testClassCodeBuilder.AppendLine("     }");
            testClassCodeBuilder.AppendLine();
            
            for (var b = 1; b <= testMethodCount; b++)
            {
                testClassCodeBuilder.AppendLine("    [Theory]");
                
                for (var c = 0; c < testCount; c++)
                {
                    var x = -c;
                    var y = -c - 2;
                    var r = x + y;

                    testClassCodeBuilder.AppendLine($"    [InlineData({x}, {y}, {r})]");
                }

                testClassCodeBuilder.AppendLine(
                    $"    public void TwoNegativeNumbers{b}_AddNumbers_ReturnSum(int x, int y, int r)");
                testClassCodeBuilder.AppendLine("    {");
                testClassCodeBuilder.AppendLine("        _calculator.Add(x, y).Returns(r);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        var result = _calculatorService.AddNumbers(x, y);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        result.ShouldBe(r);");
                testClassCodeBuilder.AppendLine("    }");
            }

            testClassCodeBuilder.AppendLine("}");
        }

        File.WriteAllText("AddNegativeNumbersTests.cs", testClassCodeBuilder.ToString());
    }
    
    public static void GenerateSubtractPositive(int classCount, int testMethodCount, int testCount)
    {
        var testClassCodeBuilder = new StringBuilder();

        testClassCodeBuilder.AppendLine("using Xunit;");
        testClassCodeBuilder.AppendLine("using Shouldly;");
        testClassCodeBuilder.AppendLine("using NSubstitute;");
        testClassCodeBuilder.AppendLine("using ClassLibrary1SourceProject;");
        testClassCodeBuilder.AppendLine();
        testClassCodeBuilder.AppendLine($"namespace {TargetNamespace};");
        testClassCodeBuilder.AppendLine();

        for (var a = 1; a <= classCount; a++)
        {
            testClassCodeBuilder.AppendLine($"public class SubtractPositiveNumbersTests{a}");
            testClassCodeBuilder.AppendLine("{");
            testClassCodeBuilder.AppendLine(
                "    private readonly CalculatorService _calculatorService;");
            testClassCodeBuilder.AppendLine(
                "    private readonly ICalculator _calculator;");
            testClassCodeBuilder.AppendLine();
            
            testClassCodeBuilder.AppendLine($"    public SubtractPositiveNumbersTests{a}()");
            testClassCodeBuilder.AppendLine("     {");
            testClassCodeBuilder.AppendLine("         _calculator = Substitute.For<ICalculator>();");
            testClassCodeBuilder.AppendLine("         _calculatorService = new CalculatorService(_calculator);");
            testClassCodeBuilder.AppendLine("     }");
            testClassCodeBuilder.AppendLine();
            
            for (var b = 1; b <= testMethodCount; b++)
            {
                testClassCodeBuilder.AppendLine("    [Theory]");
                
                for (var c = testCount; c > 0; c--)
                {
                    var x = c;
                    var y = c - 1;
                    var r = x - y;

                    testClassCodeBuilder.AppendLine($"    [InlineData({x}, {y}, {r})]");
                }

                testClassCodeBuilder.AppendLine(
                    $"    public void SubtractPositiveNumbers{b}_SubtractNumbers_ReturnDifference(int x, int y, int r)");
                testClassCodeBuilder.AppendLine("    {");
                testClassCodeBuilder.AppendLine("        _calculator.Subtract(x, y).Returns(r);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        var result = _calculatorService.SubtractNumbers(x, y);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        result.ShouldBe(r);");
                testClassCodeBuilder.AppendLine("    }");
            }

            testClassCodeBuilder.AppendLine("}");
        }

        File.WriteAllText("SubtractPositiveNumbersTests.cs", testClassCodeBuilder.ToString());
    }
    
    public static void GenerateSubtractNegative(int classCount, int testMethodCount, int testCount)
    {
        var testClassCodeBuilder = new StringBuilder();

        testClassCodeBuilder.AppendLine("using Xunit;");
        testClassCodeBuilder.AppendLine("using Shouldly;");
        testClassCodeBuilder.AppendLine("using NSubstitute;");
        testClassCodeBuilder.AppendLine("using ClassLibrary1SourceProject;");
        testClassCodeBuilder.AppendLine();
        testClassCodeBuilder.AppendLine($"namespace {TargetNamespace};");
        testClassCodeBuilder.AppendLine();

        for (var a = 1; a <= classCount; a++)
        {
            testClassCodeBuilder.AppendLine($"public class SubtractNegativeNumbersTests{a}");
            testClassCodeBuilder.AppendLine("{");
            testClassCodeBuilder.AppendLine(
                "    private readonly CalculatorService _calculatorService;");
            testClassCodeBuilder.AppendLine(
                "    private readonly ICalculator _calculator;");
            testClassCodeBuilder.AppendLine();
            
            testClassCodeBuilder.AppendLine($"    public SubtractNegativeNumbersTests{a}()");
            testClassCodeBuilder.AppendLine("     {");
            testClassCodeBuilder.AppendLine("         _calculator = Substitute.For<ICalculator>();");
            testClassCodeBuilder.AppendLine("        _calculatorService = new CalculatorService(_calculator);");
            testClassCodeBuilder.AppendLine("     }");
            testClassCodeBuilder.AppendLine();
            
            for (var b = 1; b <= testMethodCount; b++)
            {
                testClassCodeBuilder.AppendLine("    [Theory]");
                
                for (var c = testCount; c > 0; c--)
                {
                    var x = -c;
                    var y = c - 1;
                    var r = x - y;

                    testClassCodeBuilder.AppendLine($"    [InlineData({x}, {y}, {r})]");
                }

                testClassCodeBuilder.AppendLine(
                    $"    public void SubtractPositiveNumbers{b}_SubtractNumbers_ReturnDifference(int x, int y, int r)");
                testClassCodeBuilder.AppendLine("    {");
                testClassCodeBuilder.AppendLine("        _calculator.Subtract(x, y).Returns(r);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        var result = _calculatorService.SubtractNumbers(x, y);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        result.ShouldBe(r);");
                testClassCodeBuilder.AppendLine("    }");
            }

            testClassCodeBuilder.AppendLine("}");
        }

        File.WriteAllText("SubtractNegativeNumbersTests.cs", testClassCodeBuilder.ToString());
    }
}