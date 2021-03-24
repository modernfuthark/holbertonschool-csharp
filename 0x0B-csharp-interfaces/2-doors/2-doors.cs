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
/// Door class
/// </summary>
public class Door : Base, IInteractive
{
	/// <summary>
	/// Property constructor
	/// </summary>
	public Door(string _name = "Door")
	{
		name = _name;
	}

	/// <summary>
	/// Interact method
	/// </summary>
	public void Interact()
	{
		Console.WriteLine($"You try to open the {name}. It's locked.");
	}
}