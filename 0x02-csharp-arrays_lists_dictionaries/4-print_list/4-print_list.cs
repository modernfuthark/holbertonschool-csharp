using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> res = new List<int>();

        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i}{(i != size - 1 ? " " : "")}");
            res.Add(i);
        }
        Console.Write("\n");
        return res;
    }
}
