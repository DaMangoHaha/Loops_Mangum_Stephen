namespace Loops_Mangum_Stephen
{
    using System;

    class Program
    {
        // Method to count the spaces in a string inputted by user
        static int CountSpace(string input)
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

        // Method to add the digits of a number inputted by user
        static int DigitsSum(int number)
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
            Console.Write("pls giv wurd(s): ");
            string inputString = Console.ReadLine();
            int spaces = CountSpace(inputString);
            Console.WriteLine($"The string is: \"{inputString}\"");
            Console.WriteLine($"The number of spaces in the string: {spaces}");

            // Input for summing digits of a sentence in
            Console.Write("giv nambr. need BEEG: ");
            int number = int.Parse(Console.ReadLine());
            int digitSum = DigitsSum(number);
            Console.WriteLine($"The number is: {number}");
            Console.WriteLine($"The sum of its digits is: {digitSum}");
        }
    }
}