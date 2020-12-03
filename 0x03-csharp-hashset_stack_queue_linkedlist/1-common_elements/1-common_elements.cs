using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> common = new List<int>();

        foreach (int n in list1)
        {
            if (list2.Contains(n))
                common.Add(n);
        }
        common.Sort();
        return common;
    }
}
