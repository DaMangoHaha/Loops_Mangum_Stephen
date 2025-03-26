namespace Loops_Mangum_Stephen
{
    using System;

    class Program
    {
        // Method to count the spaces in a string inputted by user
        static int CountSpaces(string input)
        {
            int spaceCount = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount;
        }

        // Method to sum the digits of a number inputted by user
        static int SumDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // Input for counting spaces inside of a sentence inputted by user
            Console.Write("pls giv wurds: ");
            string inputString = Console.ReadLine();
            int spaces = CountSpaces(inputString);
            Console.WriteLine($"The string is: \"{inputString}\"");
            Console.WriteLine($"The number of spaces in the string: {spaces}");

            // Input for summing digits
            Console.Write("giv nambr BEEG: ");
            int number = int.Parse(Console.ReadLine());
            int digitSum = SumDigits(number);
            Console.WriteLine($"The number is: {number}");
            Console.WriteLine($"The sum of its digits is: {digitSum}");
        }
    }
}