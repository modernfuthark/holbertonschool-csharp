using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

class JSONStorage
{
	IDictionary<string, object> objectDictionary = new Dictionary<string, object>();

	public IDictionary<string, object> All()
	{
		return objects;
	}

	public void New(object obj)
	{
		objectDictionary.Add(new KeyValuePair<string, object>(key, obj));
	}

	public void Save()
	{
		string jsonString = JsonSerializer.Serialize(objectDictionary);
		File.WriteAllText(storage/inventory_manager.json, jsonString);
	}

	public void Load()
	{
		string jsonString = File.ReadAllText(storage/inventory_manager.json);
		objectDictionary = JsonSerializer.Deserialize<JSONStorage>(jsonString);
	}
}
