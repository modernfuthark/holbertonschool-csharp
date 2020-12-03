using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;
        foreach (int ele in myLList)
        {
            if (index == n)
                return ele;
            index++;
        }
        return 0;
    }
}
