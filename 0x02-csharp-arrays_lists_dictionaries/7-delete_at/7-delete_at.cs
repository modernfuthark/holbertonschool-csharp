using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= myList.Count || index < 0)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        for (int i = index; i < myList.Count; i++)
        {
            if (i + 1 < myList.Count) // Check if next element exists
                myList[i] = myList[i + 1];
        }
        myList.RemoveRange(myList.Count - 1, 1);
        return myList;
    }
}
