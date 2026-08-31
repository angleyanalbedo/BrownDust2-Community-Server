using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;

namespace Bd2.Server.Common.Managers;

public class QuestManager
{
	private static Dictionary<int, List<QuestTable1>> _dictionary;

	private static readonly int[] PackIds;

	static QuestManager()
	{
		_dictionary = new Dictionary<int, List<QuestTable1>>();
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
				List<QuestTable1> value = DesignDbHelper.LoadFromCommon("QuestTable" + key, QuestTable1.Parser);
				_dictionary.Add(key, value);
			}
		}
		catch (Exception value2)
		{
			Console.WriteLine(value2);
			throw;
		}
	}

	public static QuestTable1 GetQuestTable(int packId, int questId)
	{
		return _dictionary[packId].FirstOrDefault((QuestTable1 x) => x.Id == questId);
	}

	public static int[] GetAllPackIds()
	{
		return PackIds;
	}
}
