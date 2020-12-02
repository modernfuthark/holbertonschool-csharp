using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] result = new int[size];
        if (size == 0)
        {
            Console.Write("\n");
            return result;
        }
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i}{(i != size - 1 ? " " : "\n")}");
            result[i] = i;
        }
        return result;
    }
}
