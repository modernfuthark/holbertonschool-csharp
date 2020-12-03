using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        foreach (int n in myList.Distinct().ToList())
        {
            sum += n;
        }
        return sum;
    }
}
