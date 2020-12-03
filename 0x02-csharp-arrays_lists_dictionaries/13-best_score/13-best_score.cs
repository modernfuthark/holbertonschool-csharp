using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count < 1)
            return "None";

        string top = null;

        foreach (KeyValuePair<string, int> v in myList)
        {
            top = top ?? v.Key;
            if (v.Value > myList[top])
            {
                top = v.Key;
            }
        }

        return top;
    }
}
