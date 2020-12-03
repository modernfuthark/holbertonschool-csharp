using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine($"Stack is empty");

        bool hasItem = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {hasItem}");

        if (hasItem)
        {
            bool memory = false;
            for (int i = 0; i < aStack.Count; i++)
            {
                if (aStack.ElementAt(i) == search)
                    memory = true;

                aStack.Pop();
                i--; // Element popped, go down 1 index

                if (memory)
                    break;
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
