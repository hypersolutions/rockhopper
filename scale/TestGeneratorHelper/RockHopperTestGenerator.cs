using System.Text;

namespace TestGeneratorHelper;

public static class RockHopperTestGenerator
{
    private const string TargetNamespace = "RockHopperScaleTest";
    
    public static void GenerateAddPositive(int classCount, int testMethodCount, int testCount)
    {
        var testClassCodeBuilder = new StringBuilder();

        testClassCodeBuilder.AppendLine("using RockHopper;");
        testClassCodeBuilder.AppendLine("using RockHopper.Assertions;");
        testClassCodeBuilder.AppendLine("using RockHopper.Mocking;");
        testClassCodeBuilder.AppendLine("using ClassLibrary1SourceProject;");
        testClassCodeBuilder.AppendLine();
        testClassCodeBuilder.AppendLine($"namespace {TargetNamespace};");
        testClassCodeBuilder.AppendLine();

        for (var a = 1; a <= classCount; a++)
        {
            testClassCodeBuilder.AppendLine($"public class AddPositiveNumbersTests{a}");
            testClassCodeBuilder.AppendLine("{");
            testClassCodeBuilder.AppendLine(
                "    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();");
            testClassCodeBuilder.AppendLine(
                "    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();");
            testClassCodeBuilder.AppendLine();

            for (var b = 1; b <= testMethodCount; b++)
            {
                for (var c = 0; c < testCount; c++)
                {
                    var x = c;
                    var y = c + 2;
                    var r = x + y;

                    testClassCodeBuilder.AppendLine($"    [Test(InlineArgs = [{x}, {y}, {r}])]");
                }

                testClassCodeBuilder.AppendLine(
                    $"    public void TwoPositiveNumbers{b}_AddNumbers_ReturnSum(int x, int y, int r)");
                testClassCodeBuilder.AppendLine("    {");
                testClassCodeBuilder.AppendLine("        _calculator.Setup(c => c.Add(x, y)).Returns(r);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        var result = _calculatorService.AddNumbers(x, y);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        result.ShouldBe(r);");
                testClassCodeBuilder.AppendLine("    }");
                testClassCodeBuilder.AppendLine();
            }

            testClassCodeBuilder.AppendLine("}");
        }

        File.WriteAllText("AddPositiveNumbersTests.cs", testClassCodeBuilder.ToString());
    }
    
    public static void GenerateAddNegative(int classCount, int testMethodCount, int testCount)
    {
        var testClassCodeBuilder = new StringBuilder();

        testClassCodeBuilder.AppendLine("using RockHopper;");
        testClassCodeBuilder.AppendLine("using RockHopper.Assertions;");
        testClassCodeBuilder.AppendLine("using RockHopper.Mocking;");
        testClassCodeBuilder.AppendLine("using ClassLibrary1SourceProject;");
        testClassCodeBuilder.AppendLine();
        testClassCodeBuilder.AppendLine($"namespace {TargetNamespace};");
        testClassCodeBuilder.AppendLine();

        for (var a = 1; a <= classCount; a++)
        {
            testClassCodeBuilder.AppendLine($"public class AddNegativeNumbersTests{a}");
            testClassCodeBuilder.AppendLine("{");
            testClassCodeBuilder.AppendLine(
                "    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();");
            testClassCodeBuilder.AppendLine(
                "    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();");
            testClassCodeBuilder.AppendLine();

            for (var b = 1; b <= testMethodCount; b++)
            {
                for (var c = 0; c < testCount; c++)
                {
                    var x = -c;
                    var y = -c - 2;
                    var r = x + y;

                    testClassCodeBuilder.AppendLine($"    [Test(InlineArgs = [{x}, {y}, {r}])]");
                }

                testClassCodeBuilder.AppendLine(
                    $"    public void TwoNegativeNumbers{b}_AddNumbers_ReturnSum(int x, int y, int r)");
                testClassCodeBuilder.AppendLine("    {");
                testClassCodeBuilder.AppendLine("        _calculator.Setup(c => c.Add(x, y)).Returns(r);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        var result = _calculatorService.AddNumbers(x, y);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        result.ShouldBe(r);");
                testClassCodeBuilder.AppendLine("    }");
                testClassCodeBuilder.AppendLine();
            }

            testClassCodeBuilder.AppendLine("}");
        }

        File.WriteAllText("AddNegativeNumbersTests.cs", testClassCodeBuilder.ToString());
    }
    
    public static void GenerateSubtractPositive(int classCount, int testMethodCount, int testCount)
    {
        var testClassCodeBuilder = new StringBuilder();

        testClassCodeBuilder.AppendLine("using RockHopper;");
        testClassCodeBuilder.AppendLine("using RockHopper.Assertions;");
        testClassCodeBuilder.AppendLine("using RockHopper.Mocking;");
        testClassCodeBuilder.AppendLine("using ClassLibrary1SourceProject;");
        testClassCodeBuilder.AppendLine();
        testClassCodeBuilder.AppendLine($"namespace {TargetNamespace};");
        testClassCodeBuilder.AppendLine();

        for (var a = 1; a <= classCount; a++)
        {
            testClassCodeBuilder.AppendLine($"public class SubtractPositiveNumbersTests{a}");
            testClassCodeBuilder.AppendLine("{");
            testClassCodeBuilder.AppendLine(
                "    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();");
            testClassCodeBuilder.AppendLine(
                "    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();");
            testClassCodeBuilder.AppendLine();

            for (var b = 1; b <= testMethodCount; b++)
            {
                for (var c = testCount; c > 0; c--)
                {
                    var x = c;
                    var y = c - 1;
                    var r = x - y;

                    testClassCodeBuilder.AppendLine($"    [Test(InlineArgs = [{x}, {y}, {r}])]");
                }

                testClassCodeBuilder.AppendLine(
                    $"    public void SubtractPositiveNumbers{b}_SubtractNumbers_ReturnDifference(int x, int y, int r)");
                testClassCodeBuilder.AppendLine("    {");
                testClassCodeBuilder.AppendLine("        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        var result = _calculatorService.SubtractNumbers(x, y);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        result.ShouldBe(r);");
                testClassCodeBuilder.AppendLine("    }");
                testClassCodeBuilder.AppendLine();
            }

            testClassCodeBuilder.AppendLine("}");
        }

        File.WriteAllText("SubtractPositiveNumbersTests.cs", testClassCodeBuilder.ToString());
    }
    
    public static void GenerateSubtractNegative(int classCount, int testMethodCount, int testCount)
    {
        var testClassCodeBuilder = new StringBuilder();

        testClassCodeBuilder.AppendLine("using RockHopper;");
        testClassCodeBuilder.AppendLine("using RockHopper.Assertions;");
        testClassCodeBuilder.AppendLine("using RockHopper.Mocking;");
        testClassCodeBuilder.AppendLine("using ClassLibrary1SourceProject;");
        testClassCodeBuilder.AppendLine();
        testClassCodeBuilder.AppendLine($"namespace {TargetNamespace};");
        testClassCodeBuilder.AppendLine();

        for (var a = 1; a <= classCount; a++)
        {
            testClassCodeBuilder.AppendLine($"public class SubtractNegativeNumbersTests{a}");
            testClassCodeBuilder.AppendLine("{");
            testClassCodeBuilder.AppendLine(
                "    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();");
            testClassCodeBuilder.AppendLine(
                "    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();");
            testClassCodeBuilder.AppendLine();

            for (var b = 1; b <= testMethodCount; b++)
            {
                for (var c = testCount; c > 0; c--)
                {
                    var x = -c;
                    var y = c - 1;
                    var r = x - y;

                    testClassCodeBuilder.AppendLine($"    [Test(InlineArgs = [{x}, {y}, {r}])]");
                }

                testClassCodeBuilder.AppendLine(
                    $"    public void SubtractPositiveNumbers{b}_SubtractNumbers_ReturnDifference(int x, int y, int r)");
                testClassCodeBuilder.AppendLine("    {");
                testClassCodeBuilder.AppendLine("        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        var result = _calculatorService.SubtractNumbers(x, y);");
                testClassCodeBuilder.AppendLine("");
                testClassCodeBuilder.AppendLine("        result.ShouldBe(r);");
                testClassCodeBuilder.AppendLine("    }");
                testClassCodeBuilder.AppendLine();
            }

            testClassCodeBuilder.AppendLine("}");
        }

        File.WriteAllText("SubtractNegativeNumbersTests.cs", testClassCodeBuilder.ToString());
    }
}