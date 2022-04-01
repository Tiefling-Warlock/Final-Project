using System;

public class Program
{
    public static void Main()
    {
        checked
        {
            int n = int.MaxValue;
            n = n + 1;
            System.Console.WriteLine(n);
        }
        int number = unchecked(int.MaxValue + 1);
        Console.WriteLine(number);
    }
}

public sealed class TextNumberParser
{
    public static int Parse(string textDigit)
    {
        string[] digitTexts =
            { "zero", "one", "two", "three", "four",
              "five", "six", "seven", "eight", "nine" };

        int result = Array.IndexOf(
            digitTexts,
            (textDigit ??
              throw new ArgumentNullException(nameof(textDigit))
            ).ToLower());

        if (result < 0)
        {
            throw new ArgumentException(
                "The argument did not represent a digit",
                nameof(textDigit));
        }

        return result;
    }
}