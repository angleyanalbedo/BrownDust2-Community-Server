using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;

namespace Bd2.Server.Common.Managers;

public class NameTextManager
{
	private static Dictionary<int, NameTextTable> _dictionary;

	static NameTextManager()
	{
		try
		{
			var list = DesignDbHelper.LoadFromCommon("NameTextTable", NameTextTable.Parser);
			_dictionary = list.ToDictionary(x => x.Id, x => x);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex);
			_dictionary = new Dictionary<int, NameTextTable>();
		}
	}

	public static string GetText(int textId)
	{
		return GetText(textId, "zh-CN");
	}

	public static string GetText(int textId, string language)
	{
		if (_dictionary.TryGetValue(textId, out var table))
		{
			var localized = language?.ToLowerInvariant() switch
			{
				"ko" or "kr" or "ko-kr" => table.Text,
				"en" or "en-us" or "en-gb" => table.TextEn,
				"ja" or "jp" or "ja-jp" => table.TextJp,
				"zh-tw" or "tw" => table.TextTw,
				_ => table.TextCn
			};
			if (!string.IsNullOrEmpty(localized)) return localized;
			if (!string.IsNullOrEmpty(table.TextCn)) return table.TextCn;
			if (!string.IsNullOrEmpty(table.TextEn)) return table.TextEn;
			if (!string.IsNullOrEmpty(table.Text)) return table.Text;
		}
		return $"#{textId}";
	}

	public static IEnumerable<(int Id, string Name)> Search(string query, int limit, string language = "zh-CN")
	{
		return _dictionary.Values
			.Select(x => (x.Id, Name: GetText(x.Id, language)))
			.Where(x => !string.IsNullOrEmpty(x.Name) && x.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
			.Take(Math.Max(0, limit));
	}
}
