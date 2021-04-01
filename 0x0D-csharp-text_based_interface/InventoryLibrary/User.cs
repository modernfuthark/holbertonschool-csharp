using System;

class User : BaseClass
{
	public string name {get; set;}

	public User(string name = "User")
	{
		this.name = name;
	}
}