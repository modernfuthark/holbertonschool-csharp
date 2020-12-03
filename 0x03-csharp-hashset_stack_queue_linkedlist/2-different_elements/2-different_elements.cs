using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> diff = new List<int>();

        foreach (int n in list1)
            if (!list2.Contains(n))
                diff.Add(n);

        foreach (int n in list2)
            if (!list1.Contains(n))
                diff.Add(n);

        diff.Sort();
        return diff;
    }
}
