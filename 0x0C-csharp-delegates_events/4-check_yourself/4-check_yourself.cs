using System;

/// <summary>
/// Damage modifiers enum
/// </summary>
public enum Modifier
{
	/// <summary>
	/// Weak modifier (N/2)
	/// </summary>
	Weak,
	/// <summary>
	/// Base modifier (N)
	/// </summary>
	Base,
	/// <summary>
	/// Strong modifier (N*2)
	/// </summary>
	Strong
}

/// <summary>
/// CalculateModifier delegate
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Player class
/// </summary>
public class Player
{
	private string name { get; set; }
	private float maxHp { get; set; }
	private float hp { get; set; }

	event EventHandler<CurrentHPArgs> HPCheck;

	private string status {get; set;}

	/// <summary>
	/// Class constructor
	/// </summary>
	public Player(string name = "Player", float maxHp = 100f)
	{
		if (maxHp <= 0)
		{
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
			maxHp = 100f;
		}
		this.maxHp = maxHp;
		this.name = name;
		this.hp = this.maxHp;
		this.status = $"{name} is ready to go!";
		HPCheck += CheckStatus;
	}

	/// <summary>
	/// Method to print health of instance
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
	}

	delegate void CalculateHealth(float dmg);

    /// <summary>
    /// TakeDamage method
    /// </summary>
	public void TakeDamage(float damage)
	{
		if (damage <= 0)
		{
			damage = 0;
		}
		Console.WriteLine($"{this.name} takes {damage} damage!");
		ValidateHP(this.hp - damage);
	}

    /// <summary>
    /// HealDamage method
    /// </summary>
	public void HealDamage(float heal)
	{
		if (heal <= 0)
		{
			heal = 0;
		}
		Console.WriteLine($"{this.name} heals {heal} HP!");
		ValidateHP(this.hp + heal);
	}

	/// <summary>
	/// ValidateHP method
	/// </summary>
	public void ValidateHP(float newHp)
	{
		if (newHp <= 0) {
			this.hp = 0;
		} else if (newHp >= this.maxHp) {
			this.hp = this.maxHp;
		} else {
			this.hp = newHp;
		}
		HPCheck.Invoke(this, new CurrentHPArgs(hp));
	}

	/// <summary>
	/// ApplyModifier method
	/// Applies a modifier based on an enum to a base value
	/// </summary>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak) {
			return (baseValue / 2);
		} else if (modifier == Modifier.Strong) {
			return (baseValue * 1.5f);
		}
		return (baseValue);
	}

	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == this.maxHp) {
			Console.WriteLine($"{this.name} is in perfect health!");
		} else if (e.currentHp >= this.maxHp / 2 && e.currentHp != this.maxHp) { // Between 1/2 and max
			Console.WriteLine($"{this.name} is doing well!");
		} else if (e.currentHp >= this.maxHp / 4 && e.currentHp <= this.maxHp / 2) { // Between 1/4 and 1/2
			Console.WriteLine($"{this.name} isn't doing too great...");
		} else if (e.currentHp > 0 && e.currentHp < this.maxHp / 4) { // Between 1/4 and 0
			Console.WriteLine($"{this.name} needs help!");
		} else { // At 0
			Console.WriteLine($"{this.name} is knocked out!");
		}
	}
}

class CurrentHPArgs : EventArgs
{
	public float currentHp {get;}

	public CurrentHPArgs(float newHp)
	{
		this.currentHp = newHp;
	}
}
