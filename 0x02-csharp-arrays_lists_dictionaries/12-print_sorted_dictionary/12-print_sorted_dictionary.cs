using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> sorter = myDict.Keys.ToList();
        sorter.Sort();
        foreach (string key in sorter)
            Console.WriteLine($"{key}: {myDict[key]}");
    }
}
