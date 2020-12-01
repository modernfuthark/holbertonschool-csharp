using System;

namespace _12_fizzbuzz
{
    class Program
    {
		static void Main(string[] args)
        {
            // Trying a different approach than normal, using a string variable!
            for (int i = 1; i <= 100; i++)
            {
                string res = "";
                if (i % 3 == 0)
                    res += "Fizz";
                if (i % 5 == 0)
                    res += "Buzz";

                Console.Write($"{(res != "" ? res : i.ToString())}{(i != 100 ? " " : "\n")}");
            }
        }
    }
}