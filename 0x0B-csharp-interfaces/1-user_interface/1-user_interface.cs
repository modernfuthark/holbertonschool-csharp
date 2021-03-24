using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base
{
    public string name {get; set;}

    /// <summary>
    /// ToString override
    /// </summary>
	public override string ToString()
	{
		return $"{name} is a {this.GetType()}";
	}
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public int durability {get; set;}
	public bool isCollected {get; set;}

	public void Interact()
	{
		throw new NotImplementedException();
	}

	public void Break()
	{
		throw new NotImplementedException();
	}

	public void Collect()
	{
		throw new NotImplementedException();
	}
}

/// <summary>
/// Interactive interface
/// </summary>
public interface IInteractive
{
	/// <summary>
	/// Interact method
	/// </summary>
	void Interact();
}

/// <summary>
/// Breakable interface
/// </summary>
public interface IBreakable
{
	/// <summary>
	/// Durability property
	/// </summary>
	int durability {get; set;}

	/// <summary>
	/// Break method
	/// </summary>
	void Break();
}

/// <summary>
/// Collectable interface
/// </summary>
public interface ICollectable
{
	/// <summary>
	/// isCollected property
	/// </summary>
	bool isCollected {get; set;}

	/// <summary>
	/// Collect method
	/// </summary>
	void Collect();
}