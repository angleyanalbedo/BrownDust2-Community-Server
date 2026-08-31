using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bd2.Server.DAO.Config;

public class StringArrayConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(string);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		if (jToken.Type == JTokenType.Array)
		{
			return jToken.ToString(Formatting.None);
		}
		return null;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
	}
}
