using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> results = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> v in myDict)
            results.Add(v.Key, v.Value * 2);
        return results;
    }
}
