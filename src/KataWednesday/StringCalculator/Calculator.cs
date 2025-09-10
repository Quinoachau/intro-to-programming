
using Xunit.Sdk;

public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "" || numbers.Length == 0)
        {
            return 0;
        }
        else if (numbers.Length == 1) 
        {
            return int.Parse(numbers);
        }
        else
        {
            string[] numbersArray = numbers.Split(',','\n');
            var parsedNumbers = numbersArray.Select(int.Parse);
            if (parsedNumbers.Any(num => num < 0))
            {
                throw new ArgumentException("Negative numbers are not allowed.");
            }
            int sum = parsedNumbers.Sum();

            return sum;
        }
    }
}
