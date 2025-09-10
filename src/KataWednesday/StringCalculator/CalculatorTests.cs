

namespace StringCalculator;
public class CalculatorTests
{
    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("1\n2, 3", 6)]
    [InlineData("8\n8, 10", 26)]
    public void EmptyStringReturnsZero(string numbers, int actualNumber)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(actualNumber, result);
    }
}
