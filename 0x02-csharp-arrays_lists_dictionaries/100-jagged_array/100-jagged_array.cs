using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = {
                new int[] {0, 1, 2, 3},
                new int[] {0, 1, 2, 3, 4, 5, 6},
                new int[] {0, 1}
            };

            for (int i = 0; i < jagged.Length; i++)
           {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]}{(j != jagged[i].Length - 1 ? " " : "\n")}");
                }
            }
        }
    }
}
