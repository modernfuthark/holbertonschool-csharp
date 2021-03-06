using System;
using System.Collections.Generic;
using System.Collections;

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
class Key : Base, ICollectable
{
	// isCollected property
	public bool isCollected {get; set;}

	// Key class constructor
	public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
		this.isCollected = isCollected;
	}

	// Collect method
	public void Collect()
	{
		if (!isCollected) {
			isCollected = true;
			Console.WriteLine($"You pick up the {name}.");
		} else {
			Console.WriteLine($"You have already picked up the {name}.");
		}
	}
}

/// <summary>
/// Generic object iterator class, provides a collection of an object
/// that can be iterated through using foreach
/// </summary>
class Objs<T> : IEnumerable<T>
{
	// collection property
	List<T> collection = new List<T>();

	// Add method, add to collection
	public void Add(T addition)
	{
		collection.Add(addition);
	}

	// Returns object in collection one by one
	public IEnumerator<T> GetEnumerator()
	{
		foreach (var v in collection)
		{
			if (v == null) { break; }
			yield return v;
		}
	}

	// Required or dotnet will yell at me :(
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}
}