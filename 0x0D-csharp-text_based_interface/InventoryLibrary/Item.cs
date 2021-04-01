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
		this.price = Math.Round(price, 2);
		this.tags = tags;
	}
}
