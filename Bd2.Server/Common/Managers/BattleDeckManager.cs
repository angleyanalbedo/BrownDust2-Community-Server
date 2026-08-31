using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Design.pack;
using Bd2.Server.Common.Proto.Net;
using Google.Protobuf.Collections;

namespace Bd2.Server.Common.Managers;

public class BattleDeckManager
{
	private static Dictionary<int, List<BattleDeckTable>> _dictionary;

	private static Dictionary<int, List<FieldMonsterTable>> _monsterDictionary;

	private static readonly int[] PackIds;

	static BattleDeckManager()
	{
		_dictionary = new Dictionary<int, List<BattleDeckTable>>();
		_monsterDictionary = new Dictionary<int, List<FieldMonsterTable>>();
		PackIds = new int[71]
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
			11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
			21, 22,
			1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010,
			2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009,
			3001, 3002, 3003, 3004, 3005, 3006,
			10001, 10004, 10006,
			11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010,
			12001, 12002, 12003, 12004, 12005, 12006, 12007, 12008, 12009,
			13007, 20000
		};
		try
		{
			int[] packIds = PackIds;
			for (int i = 0; i < packIds.Length; i++)
			{
				int key = packIds[i];
				try
				{
					List<BattleDeckTable> value = DesignDbHelper.LoadFromPack(key, "BattleDeckTable", BattleDeckTable.Parser);
					_dictionary.Add(key, value);
				}
				catch (Exception ex)
				{
					Console.WriteLine($"[BattleDeckManager] No BattleDeckTable for pack {key}: {ex.Message}");
				}
				try
				{
					List<FieldMonsterTable> value2 = DesignDbHelper.LoadFromPack(key, "FieldMonsterTable", FieldMonsterTable.Parser);
					_monsterDictionary.Add(key, value2);
				}
				catch (Exception ex)
				{
					Console.WriteLine($"[BattleDeckManager] No FieldMonsterTable for pack {key}: {ex.Message}");
				}
			}
		}
		catch (Exception value3)
		{
			Console.WriteLine(value3);
			throw;
		}
	}

	public static BattleDeckTable GetBattleDeckTable(int packId, int id)
	{
		return _dictionary[packId].FirstOrDefault((BattleDeckTable x) => x.Id == id);
	}

	public static List<MonsterDBInfo> GetMonsterInfoListByGroupIds(int packId, int[] groupId)
	{
		List<MonsterDBInfo> list = new List<MonsterDBInfo>();
		List<FieldMonsterTable> source = _monsterDictionary[packId];
		foreach (int id in groupId)
		{
			foreach (FieldMonsterTable item in source.Where((FieldMonsterTable x) => x.RegenId == id).ToList())
			{
				if (item.BattleDeckId.Count == 0 && item.QuestRange.Count == 0)
				{
					list.Add(new MonsterDBInfo
					{
						ActiveFlag = true,
						GroupId = id,
						MonsterId = item.Id
					});
				}
			}
		}
		return list;
	}

	public static List<MonsterDBInfo> GetMonsterInfoListByPackId(int packId)
	{
		List<MonsterDBInfo> list = new List<MonsterDBInfo>();
		foreach (FieldMonsterTable item in _monsterDictionary[packId])
		{
			if (item.BattleDeckId.Count > 0)
			{
				RepeatedField<int> questRange = item.QuestRange;
				if (questRange != null && questRange.Count == 1 && questRange[0] == 0)
				{
					list.Add(new MonsterDBInfo
					{
						ActiveFlag = true,
						BattleDeck = item.BattleDeckId[0],
						GroupId = item.RegenId,
						MonsterId = item.Id
					});
				}
			}
		}
		return list;
	}
}
