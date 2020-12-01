using System;

namespace _1_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int number = rndm.Next(-10000, 10000);
            int final = number % 10; // Make a variable because the number is used multiple times
            Console.Write($"The last digit of {number} is {final} ");
            if (final > 5)
            {
                Console.WriteLine("and is greater than 5");
            }
            else if (final == 0)
            {
                Console.WriteLine("and is 0");
            }
            else
            {
                Console.WriteLine("and is less than 6 and not 0");
            }
        }
    }
}
