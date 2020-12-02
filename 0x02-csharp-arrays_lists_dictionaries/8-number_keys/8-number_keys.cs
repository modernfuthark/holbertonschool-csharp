using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        List<string> _keys = new List<string>();
        foreach (KeyValuePair<string, string> v in myDict)
        {
            if (!_keys.Contains(v.Key))
                _keys.Add(v.Key);
        }
        return _keys.Count;
    }
}
