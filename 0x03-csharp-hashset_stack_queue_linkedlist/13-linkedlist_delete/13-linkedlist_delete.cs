using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int counter = 0;
        foreach (int element in myLList)
        {
            if (counter == index)
            {
                myLList.Remove(element);
                break;
            }
            counter++;
        }
    }
}
