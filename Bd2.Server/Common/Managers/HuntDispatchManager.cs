using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;

namespace Bd2.Server.Common.Managers;

public class HuntDispatchManager
{
	private static readonly List<HuntDispatchTable> _dispatchTables;

	static HuntDispatchManager()
	{
		try
		{
			_dispatchTables = DesignDbHelper.LoadFromCommon("HuntDispatchTable", HuntDispatchTable.Parser);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			throw;
		}
	}

	public static List<ItemDBInfo> GetRewardByHuntDispatch(int groupId, int id, int count)
	{
		HuntDispatchTable huntDispatchTable = _dispatchTables.Single((HuntDispatchTable x) => x.GroupId == groupId && x.Id == id);
		int count2 = huntDispatchTable.VisualItemId.Count;
		int num = huntDispatchTable.RewardGrowthRate / 100 + 1;
		List<ItemDBInfo> list = new List<ItemDBInfo>();
		for (int num2 = 0; num2 < count2; num2++)
		{
			int num3 = new Random().Next(1, 10) * num;
			if (huntDispatchTable.VisualItemType[num2] <= 4)
			{
				num3 *= 5000;
			}
			list.Add(new ItemDBInfo
			{
				Id = huntDispatchTable.VisualItemId[num2],
				Count = num3 * count,
				Type = huntDispatchTable.VisualItemType[num2]
			});
		}
		Shuffle(list);
		return list.Take(new Random().Next(1, list.Count)).ToList();
	}

	private static void Shuffle<T>(List<T> list)
	{
		Random random = new Random();
		int num = list.Count;
		while (num > 1)
		{
			num--;
			int num2 = random.Next(num + 1);
			int index = num2;
			int index2 = num;
			T value = list[num];
			T value2 = list[num2];
			list[index] = value;
			list[index2] = value2;
		}
	}
}
