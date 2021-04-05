using System;
using System.Collections.Generic;

class Item : BaseClass
{
	public string name {get; set;}

	public string description {get; set;}
	public float price {get; set;}
	public List<string> tags {get; set;}

	public Item(string name = "Item", string description, float price = 0.00f, List<string> tags)
	{
		this.name = name;
		this.description = description;
		if (price < 0.00f)
		{
			Console.Writeline("price cannot be below 0. Setting to 0 (free) by default.");
			price = 0.00f;
		}
		this.price = Math.Round(price, 2);
		this.tags = tags;
	}
}
