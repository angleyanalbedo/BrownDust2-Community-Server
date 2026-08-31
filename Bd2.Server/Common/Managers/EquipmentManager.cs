using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.DAO.Game;
using Newtonsoft.Json;

namespace Bd2.Server.Common.Managers;

public class EquipmentManager
{
	private static List<EquipmentTable> _equipmentTables;

	private static List<EquipmentTable> _privateEquipmentTables;

	private static List<EquipmentOptionTable> _equipmentOptionTables;

	private static List<EquipmentMakingTable> _equipmentMakingTables;

	static EquipmentManager()
	{
		try
		{
			_equipmentTables = DesignDbHelper.LoadFromCommon("EquipmentTable", EquipmentTable.Parser);
			_privateEquipmentTables = _equipmentTables.Where((EquipmentTable x) => x.PrivateUniqueCharId != 0).ToList();
			_equipmentOptionTables = DesignDbHelper.LoadFromCommon("EquipmentOptionTable", EquipmentOptionTable.Parser);
			_equipmentMakingTables = DesignDbHelper.LoadFromCommon("EquipmentMakingTable", EquipmentMakingTable.Parser);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			throw;
		}
	}

	public static EquipmentMakingTable GetEquipmentMakingTableById(int makingId)
	{
		return _equipmentMakingTables.Single((EquipmentMakingTable x) => x.Id == makingId);
	}

	public static EquipmentOptionTable GetRandomEquipmentOptions(int groupId)
	{
		List<EquipmentOptionTable> list = _equipmentOptionTables.Where((EquipmentOptionTable x) => x.GroupId == groupId).ToList();
		return list[new Random().Next(list.Count)];
	}

	public static EquipmentTable GetEquipmentById(int id)
	{
		return _equipmentTables.Single((EquipmentTable x) => x.Id == id);
	}

	public static List<EquipmentTable> GetEquipmentRandomList(int count)
	{
		List<EquipmentTable> list = new List<EquipmentTable>();
		for (int i = 0; i < count; i++)
		{
			list.Add(GetRandomEquipment());
		}
		return list;
	}

	private static EquipmentTable? GetRandomEquipment()
	{
		return _privateEquipmentTables?.ElementAt(new Random().Next(0, _privateEquipmentTables.Count));
	}

	public static List<EquipDBInfo> ConvertEquipDbInfo(List<EquipInfoDao> dao)
	{
		return dao.Select(ConvertEquipDbInfo).ToList();
	}

	public static EquipDBInfo ConvertEquipDbInfo(EquipInfoDao dao)
	{
		EquipBaseInfo equipBaseInfo = new EquipBaseInfo
		{
			Id = dao.Id,
			Level = dao.Level
		};
		equipBaseInfo.PrivateOption = ((dao.PrivateOption != null) ? JsonConvert.DeserializeObject<EquipOptionInfo>(dao.PrivateOption) : new EquipOptionInfo());
		if (dao.MainOption != null)
		{
			equipBaseInfo.MainOption.AddRange(JsonConvert.DeserializeObject<List<EquipOptionInfo>>(dao.MainOption));
		}
		if (dao.SubOption != null)
		{
			equipBaseInfo.SubOption.AddRange(JsonConvert.DeserializeObject<List<EquipOptionInfo>>(dao.SubOption));
		}
		equipBaseInfo.Rank.AddRange(JsonConvert.DeserializeObject<int[]>(dao.Rank));
		EquipDBInfo equipDBInfo = new EquipDBInfo
		{
			InvenIndex = dao.InvenIndex,
			KeepFlag = dao.KeepFlag,
			LockFlag = dao.LockFlag,
			BaseInfo = equipBaseInfo
		};
		if (dao.UseChar != 0L)
		{
			equipDBInfo.UseChar = dao.UseChar;
		}
		return equipDBInfo;
	}
}
