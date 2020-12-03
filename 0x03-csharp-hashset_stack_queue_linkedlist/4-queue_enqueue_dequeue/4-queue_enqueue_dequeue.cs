using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		Console.WriteLine($"Number of items: {aQueue.Count}");

		if (aQueue.Count > 0)
			Console.WriteLine($"First item: {aQueue.Peek()}");
		else
			Console.WriteLine("Queue is empty");

		bool hasItem = aQueue.Contains(search);
		Console.WriteLine($"Queue contains \"{search}\": {hasItem}");

		if (hasItem)
			while (aQueue.Contains(search))
				aQueue.Dequeue();

        aQueue.Enqueue(newItem);
        return aQueue;
	}
}
