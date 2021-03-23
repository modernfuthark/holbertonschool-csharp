using System;

/// <summary>
/// Queue class
/// </summary>
class Queue<T>
{
    /// <summary>
    /// Returns the type of instance
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
