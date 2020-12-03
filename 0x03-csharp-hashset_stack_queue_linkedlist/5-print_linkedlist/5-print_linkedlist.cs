using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
       LinkedList<int> llist = new LinkedList<int>();

       for (int i = 0; i < size; i++)
       {
           Console.WriteLine(i);
           llist.AddLast(i);
       }

       return llist;
    }
}
