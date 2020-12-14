using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> Results = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                try
                {
                    Results.Insert(i, list1[i] / list2[i]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    Results.Insert(i, 0);
                }
            }
        }
        catch
        {
            Console.WriteLine("Out of range");
        }
        return Results;
    }
}
