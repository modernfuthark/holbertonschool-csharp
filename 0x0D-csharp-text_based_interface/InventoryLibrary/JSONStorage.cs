using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

class JSONStorage
{
	Dictionary<T> objects {get; set;}

	public Dictionary<string, object> All()
	{
		return this.objects;
	}

	public void New(object obj)
	{
		string key = $"{obj.GetType()}.{obj.id}";
		this.objects.Add(new KeyValuePair<string, object>(key, obj));
	}

	public void Save()
	{
		List<string> JsonOutput;
		foreach (object o in this.objects)
		{
			string jsonString = JsonSerializer.Serialize(o);
			JsonOutput.Add(jsonString); // ???
		}
	}
}
