using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array?.Length > 0)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
            Console.Write($"{array[i]}{(i != 0 ? " " : "")}");
            }
        }
        Console.Write("\n");
    }
}
