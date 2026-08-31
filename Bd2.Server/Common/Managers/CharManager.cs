using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.DAO.Game;

namespace Bd2.Server.Common.Managers;

public class CharManager
{
	private static List<CharTable> _charTables;

	private static List<CharLevelTable> _charLevelTables;

	static CharManager()
	{
		try
		{
			_charTables = DesignDbHelper.LoadFromCommon("CharTable", CharTable.Parser);
			_charLevelTables = DesignDbHelper.LoadFromCommon("CharLevelTable", CharLevelTable.Parser);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			throw;
		}
	}

	public static CharTable GetCharData(int id)
	{
		return _charTables.FirstOrDefault((CharTable x) => x.Id == id);
	}

	public static IReadOnlyList<CharTable> GetAll() => _charTables;

	public static string GetDisplayName(CharTable table, string language = "zh-CN")
	{
		return NameTextManager.GetText(table.CharNameTextId, language);
	}

	public static CharTable GetBaseCharData(int id)
	{
		return _charTables.FirstOrDefault((CharTable x) => x.UniqueCharId == id && x.Growthgrade == 1);
	}

	public static CharInfoDao CharLevelUp(CharInfoDao cha, int groupId, int exp)
	{
		List<CharLevelTable> list = (from x in _charLevelTables
			where x.GroupId == groupId
			orderby x.Id
			select x).ToList();
		int num = cha.Level;
		int num2 = exp + cha.Exp;
		double num3 = 0.0;
		while (num2 >= list[num - 1].LevelupExp)
		{
			num2 -= list[num - 1].LevelupExp;
			num3 += list[num - 1].Health;
			num++;
			if (num >= list.Count)
			{
				num = list[list.Count - 1].Id;
				num2 = 0;
				break;
			}
		}
		cha.Hp += (int)Math.Round(num3 * 8.0);
		cha.Level = num;
		cha.Exp = num2;
		return cha;
	}
}
