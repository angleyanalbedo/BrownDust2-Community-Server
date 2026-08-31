using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;

namespace Bd2.Server.Common.Managers;

public class CostumeManager
{
	private static List<CostumeTable> _costumeTables;

	static CostumeManager()
	{
		try
		{
			_costumeTables = (from x in DesignDbHelper.LoadFromCommon("CostumeTable", CostumeTable.Parser)
				where x.MaxLevel != 0
				select x).ToList();
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			throw;
		}
	}

	public static CostumeTable GetCostume(int id)
	{
		return _costumeTables?.FirstOrDefault((CostumeTable x) => x.Id == id);
	}

	public static IReadOnlyList<CostumeTable> GetAll() => _costumeTables;

	public static List<CostumeTable> GetCostumeList(int count)
	{
		List<CostumeTable> list = new List<CostumeTable>();
		for (int i = 0; i < count; i++)
		{
			list.Add(GetRandomCostume());
		}
		return list;
	}

	private static CostumeTable? GetRandomCostume()
	{
		return _costumeTables?.ElementAt(new Random().Next(0, _costumeTables.Count));
	}
}
