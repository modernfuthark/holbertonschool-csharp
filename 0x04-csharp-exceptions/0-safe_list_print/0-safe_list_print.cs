using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int print_counter = 0;
        try
        {
            for (int i = 0; i < n; i++, print_counter++)
                Console.WriteLine(myList[i]);
        }
        catch
        {
            return print_counter;
        }
        return print_counter;
    }
}
