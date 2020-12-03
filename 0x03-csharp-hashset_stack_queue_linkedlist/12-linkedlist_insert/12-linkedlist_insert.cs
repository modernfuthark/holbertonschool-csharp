using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newnode = new LinkedListNode<int>(n);
        if (myLList != null)
        {
            if (myLList.Count == 0)
                myLList.AddFirst(newnode);
            else
            {
                LinkedListNode<int> cur = myLList.First;
                while (cur.Next != null)
                {
                    if (cur.Value >= n)
                    {
                        myLList.AddBefore(cur, newnode);
                        return newnode;
                    }
                    cur = cur.Next;
                }
                if (cur.Value >= n)
                    myLList.AddBefore(cur, newnode);
                else
                    myLList.AddLast(newnode);
            }
        }
        return newnode;
    }
}
