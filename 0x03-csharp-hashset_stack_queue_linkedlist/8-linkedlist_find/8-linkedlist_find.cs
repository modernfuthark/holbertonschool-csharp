using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        foreach (int ele in myLList)
        {
            if (ele == value)
               break;
            index++;
        }

        return (index < myLList.Count ? index : -1);
    }
}
