using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList?.Count <= 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int max = myList[0]; // Start at index 0
        foreach (int v in myList)
            if (v > max)
                max = v;
        return max;
    }
}
