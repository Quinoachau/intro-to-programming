
using System.Runtime.ConstrainedExecution;
using Castle.Core.Logging;
using Xunit.Sdk;

public class Calculator(ILogger logger)
{
    public int Add(string numbers)
    {
        if (numbers == "" || numbers.Length == 0)
        {
            return 0;
        }
        string delimiters = ",\n";


        if (numbers.StartsWith("//"))
        {
            int delimiterEndIndex = numbers.IndexOf('\n');
            string customDelimiter = numbers.Substring(2, delimiterEndIndex - 2);
            delimiters += customDelimiter;

            numbers = numbers.Substring(delimiterEndIndex + 1);
        }

        string[] numbersArray = numbers.Split(delimiters.ToCharArray());

        var parsedNumbers = numbersArray.Select(int.Parse);

        if (parsedNumbers.Any(num => num < 0))
        {
            throw new InvalidNegativeNumberFound();
        }

        int final = parsedNumbers.Sum();
        logger.LogCalculation(final);
        return final;
    }
}

public class InvalidNegativeNumberFound : ArgumentOutOfRangeException;

public interface ILogger
{
    void LogCalculation(int final);
}
