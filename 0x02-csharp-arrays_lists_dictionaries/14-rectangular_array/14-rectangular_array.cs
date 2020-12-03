using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] _new = new int[5,5];
            _new[2,2] = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write($"{_new[i, j]}{(j != 4 ? " " : "\n")}");
            }
        }
    }
}
