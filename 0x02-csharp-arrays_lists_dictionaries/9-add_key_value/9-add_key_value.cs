using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict.ContainsKey(key))
        {
            myDict[key] = value;
            return myDict;
        }
        // Key doesn't exist, create.
        myDict.Add(key, value);
        return myDict;
    }
}
