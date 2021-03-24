using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
	/// <summary>
	/// Name of class
	/// </summary>
    public string name {get; set;}

    /// <summary>
    /// ToString override
    /// </summary>
	public override string ToString()
	{
		return $"{name} is a {this.GetType()}";
	}
}
// Interactive interface
interface IInteractive
{
	// Interact method
	void Interact();
}

// Breakable interface
interface IBreakable
{
	// Durability amount
	int durability {get; set;}

	// Break method
	void Break();
}

// Collectable interface
interface ICollectable
{
	// Collected bool
	bool isCollected {get; set;}

	// Collect method
	void Collect();
}

/// <summary>
/// TestObject class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	/// <summary>
	/// Durability property
	/// </summary>
	public int durability {get; set;}
	/// <summary>
	/// isCollected durability
	/// </summary>
	public bool isCollected {get; set;}

	/// <summary>
	/// Interact method
	/// </summary>
	public void Interact()
	{

	}

	/// <summary>
	/// Break method
	/// </summary>
	public void Break()
	{

	}

	/// <summary>
	/// Collect method
	/// </summary>
	public void Collect()
	{

	}
}
