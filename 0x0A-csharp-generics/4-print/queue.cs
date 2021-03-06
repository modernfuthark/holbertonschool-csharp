using System;

/// <summary>
/// Queue class
/// </summary>
class Queue<T>
{
	public Node head { get; set; } = null;
	public Node tail { get; set; } = null;
	public int count { get; set; } = 0;
	/// <summary>
	/// Returns the type of instance
	/// </summary>
	public Type CheckType()
	{
		return typeof(T);
	}

	/// <summary>
	/// Node class
	/// </summary>
	public class Node
	{
		public T value;
		public Node next { get; set; } = null;
		public Node(T val)
		{
			value = val;
		}
	}

	/// <summary>
	/// Adds a node to the queue
	/// </summary>
	public void Enqueue(T val)
	{
		Node newNode = new Node(val);

		if (head == null)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			tail.next = newNode;
			tail = newNode;
		}

		count++;
	}

	/// <summary>
	/// Removes a node from the queue
	/// </summary>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{

			T heldValue = head.value;
			if (head == tail) { tail = null; }
			head = head.next;
			count--;
			return heldValue;
		}
	}

	/// <summary>
	/// Returns number of nodes
	/// </summary>
	public int Count()
	{
		return count;
	}

	/// <summary>
	/// Returns the value of the first node
	/// </summary>
	public T Peek()
	{
		if (head != null) { return head.value; }
		Console.WriteLine("Queue is empty");
		return default(T);
	}

	/// <summary>
	/// Prints the queue
	/// </summary>
	public void Print()
	{
		if (count == 0) { Console.WriteLine("Queue is empty"); }
		else {
			Node temp = head;
			while (temp != null)
			{
				Console.WriteLine(temp.value);
				temp = temp.next;
			}
		}
	}
}
