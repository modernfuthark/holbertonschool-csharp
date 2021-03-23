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
        T value;
        public Node next {get; set;} = null;
        public Node(T val)
        {
            value = val;
        }
    }

    /// <summary>
    /// Adds an instance to the queue
    /// </summary>
    public void Enqueue(T val)
    {
        Node newNode = new Node(val);

        if (head ==  null) {
            head = newNode;
            tail = newNode;
        } else {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>
    /// Returns number of nodes
    /// </summary>
    public int Count()
    {
        return count;
    }
}
