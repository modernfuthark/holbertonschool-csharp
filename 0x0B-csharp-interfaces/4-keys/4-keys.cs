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
		this.name = _name;
	}

	/// <summary>
	/// Interact method
	/// </summary>
	public void Interact()
	{
		Console.WriteLine($"You try to open the {name}. It's locked.");
	}
}

/// <summary>
/// Decoration class
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
	/// <summary>
	/// isQuestItem property
	/// </summary>
	public bool isQuestItem {get; set;}
	/// <summary>
	/// durability property
	///</summary>
	public int durability {get; set;}

	/// <summary>
	/// Decoration class constructor
	/// </summary>
	public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
		if (durability <= 0) {
			throw new Exception("Durability must be greater than 0");
		} else {
			this.durability = durability;
			this.name = name;
			this.isQuestItem = isQuestItem;
		}
	}

	/// <summary>
	/// Interact method
	/// </summary>
	public void Interact()
	{
		if (durability <= 0) {
			Console.WriteLine($"The {name} has been broken.");
		} else if (isQuestItem) {
			Console.WriteLine($"You look at the {name}. There's a key inside.");
		} else {
			Console.WriteLine($"You look at the {name}. Not much to see here.");
		}
	}

	/// <summary>
	/// Break method
	/// </summary>
	public void Break()
	{
		durability--;
		if (durability > 0) {
			Console.WriteLine($"You hit the {name}. It cracks.");
		} else if (durability == 0) {
			Console.WriteLine($"You smash the {name}. What a mess.");
		} else {
			Console.WriteLine($"The {name} is already broken.");
		}
	}
}

/// <summary>
/// Key class
/// </summary>
public class Key : Base, ICollectable
{
	/// <summary>
	/// isCollected property
	/// </summary>
	public bool isCollected {get; set;}

	/// <summary>
	/// Key class constructor
	/// </summary>
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}

	/// <summary>
	/// Collect method
	/// </summary>
	public void Collect()
	{
		if (!isCollected) {
			isCollected = true;
			Console.WriteLine($"You picked up the {name}.");
		} else {
			Console.WriteLine($"You already picked up the {name}.");
		}
	}
}
