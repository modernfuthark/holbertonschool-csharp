using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array?.Length > 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
            Console.Write($"{array[i]}{(i != array.Length - 1 ? " " : "")}");
            }
        }
        Console.Write("\n");
    }
}
