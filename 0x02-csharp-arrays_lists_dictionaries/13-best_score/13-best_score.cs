using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> top = new KeyValuePair<string, int>("None", 0);

        foreach (KeyValuePair<string, int> v in myList)
        {
            if (v.Value > top.Value)
            {
                top = v;
            }
        }

        return top.Key;
    }
}
