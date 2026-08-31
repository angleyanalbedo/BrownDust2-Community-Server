using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;

namespace Bd2.Server.Common.Utils;

public static class RandomUtil
{
	private static int Random(int min, int max)
	{
		return new Random().Next(min, max);
	}

	private static int GetWeightedRandomIndex(int[] ratios)
	{
		int[] array = new int[ratios.Length];
		int max = ratios.Sum();
		array[0] = ratios[0];
		for (int i = 1; i < ratios.Length; i++)
		{
			array[i] = array[i - 1] + ratios[i];
		}
		int num = Random(0, max);
		for (int j = 0; j < array.Length; j++)
		{
			if (num <= array[j])
			{
				return j;
			}
		}
		return array.Length - 1;
	}

	public static int[] EquipSmeltingRandom()
	{
		int[] array = new int[3];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Random(1, 5);
		}
		return array;
	}

	public static bool EquipUpgradeRandom(int level)
	{
		return (9 - level) * 5 > new Random().Next(0, 100);
	}

	public static List<EquipmentTable> GetRandomEquipmentList(RewardGroupTable rewardGroupTable, int count)
	{
		List<EquipmentTable> list = new List<EquipmentTable>();
		for (int i = 0; i < count; i++)
		{
			int weightedRandomIndex = GetWeightedRandomIndex(rewardGroupTable.Ratio.ToArray());
			list.Add(EquipmentManager.GetEquipmentById(rewardGroupTable.ItemId[weightedRandomIndex]));
		}
		return list;
	}

	public static List<ItemDBInfo> GetRollItemList(RewardGroupTable rewardGroupTable, int count)
	{
		List<ItemDBInfo> list = new List<ItemDBInfo>();
		for (int i = 0; i < count; i++)
		{
			int weightedRandomIndex = GetWeightedRandomIndex(rewardGroupTable.Ratio.ToArray());
			list.Add(new ItemDBInfo
			{
				Id = rewardGroupTable.ItemId[weightedRandomIndex],
				Type = rewardGroupTable.ItemType[weightedRandomIndex],
				Count = rewardGroupTable.ItemCount[weightedRandomIndex]
			});
		}
		return (from x in list
			group x by x.Id into grouping
			select new ItemDBInfo
			{
				Id = grouping.Key,
				Type = grouping.First().Type,
				Count = grouping.Sum((ItemDBInfo x) => x.Count)
			}).ToList();
	}

	public static List<ItemDBInfo> GetAllItemList(RewardGroupTable rewardGroupTable, int count)
	{
		List<ItemDBInfo> list = new List<ItemDBInfo>();
		for (int i = 0; i < rewardGroupTable.ItemId.Count; i++)
		{
			ItemDBInfo item = new ItemDBInfo
			{
				Id = rewardGroupTable.ItemId[i],
				Type = rewardGroupTable.ItemType[i],
				Count = rewardGroupTable.ItemCount[i] * count
			};
			list.Add(item);
		}
		return (from x in list
			group x by x.Id into grouping
			select new ItemDBInfo
			{
				Id = grouping.Key,
				Type = grouping.First().Type,
				Count = grouping.Sum((ItemDBInfo x) => x.Count)
			}).ToList();
	}
}
