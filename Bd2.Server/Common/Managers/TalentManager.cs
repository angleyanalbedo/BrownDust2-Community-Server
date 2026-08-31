using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;
using Google.Protobuf;

namespace Bd2.Server.Common.Managers;

public class TalentManager
{
	private static List<TalentTable> _talentList;

	private static List<TalentSkillTable> _talentSkillList;

	private static List<TalentGrowthTable> _talentGrowthList;

	private static readonly Lazy<List<AlchemyTable>> _alchemyTables = new(() =>
		DesignDbHelper.LoadFromCommon("AlchemyTable", AlchemyTable.Parser));

	static TalentManager()
	{
		try
		{
			_talentList = LoadTalentTables();
			_talentSkillList = LoadTalentSkillTables();
			_talentGrowthList = DesignDbHelper.LoadFromCommon("TalentGrowthTable", TalentGrowthTable.Parser);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			throw;
		}
	}

	public static TalentTable GetTalent(int id)
	{
		return _talentList.Single((TalentTable x) => x.Id == id);
	}

	public static TalentSkillTable GetTalentSkill(int groupId, int level)
	{
		return _talentSkillList.Single((TalentSkillTable x) => x.Id == level && x.GroupId == groupId);
	}

	public static TalentGrowthTable GetTalentGrowth(int groupId, int level)
	{
		return _talentGrowthList.Single((TalentGrowthTable x) => x.Id == level && x.GroupId == groupId);
	}

	public static AlchemyTable GetAlchemyTableById(int id)
	{
		return _alchemyTables.Value.Single((AlchemyTable x) => x.Id == id);
	}

	private static List<TalentTable> LoadTalentTables()
	{
		var result = new List<TalentTable>();
		using var connection = OpenCommonDb();
		using var command = new SQLiteCommand("SELECT id, talentSkillGroupId, ProtoBuf FROM TalentTable", connection);
		using var reader = command.ExecuteReader();
		while (reader.Read())
		{
			var row = new TalentTable
			{
				Id = Convert.ToInt32(reader["id"]),
				TalentSkillGroupId = Convert.ToInt32(reader["talentSkillGroupId"])
			};
			ReadTalentBlob((byte[])reader["ProtoBuf"], row);
			result.Add(row);
		}
		return result;
	}

	private static List<TalentSkillTable> LoadTalentSkillTables()
	{
		var result = new List<TalentSkillTable>();
		using var connection = OpenCommonDb();
		using var command = new SQLiteCommand("SELECT groupId, id, classType, ProtoBuf FROM TalentSkillTable", connection);
		using var reader = command.ExecuteReader();
		while (reader.Read())
		{
			var row = new TalentSkillTable
			{
				GroupId = Convert.ToInt32(reader["groupId"]),
				Id = Convert.ToInt32(reader["id"]),
				ClassType = Convert.ToInt32(reader["classType"])
			};
			ReadTalentSkillBlob((byte[])reader["ProtoBuf"], row);
			result.Add(row);
		}
		return result;
	}

	private static SQLiteConnection OpenCommonDb()
	{
		var connection = new SQLiteConnection($"Data Source={DesignDbHelper.GetCommonDbPath()};Version=3;Read Only=True;");
		connection.Open();
		return connection;
	}

	private static void ReadTalentBlob(byte[] bytes, TalentTable row)
	{
		using var input = new CodedInputStream(bytes);
		while (!input.IsAtEnd)
		{
			uint tag = input.ReadTag();
			switch (tag)
			{
				case 40: // growthGroupId, field 5 in the current design DB
					row.GrowthGroupId = input.ReadInt32();
					break;
				default:
					input.SkipLastField();
					break;
			}
		}
	}

	private static void ReadTalentSkillBlob(byte[] bytes, TalentSkillTable row)
	{
		using var input = new CodedInputStream(bytes);
		while (!input.IsAtEnd)
		{
			uint tag = input.ReadTag();
			switch (tag)
			{
				case 40: // getExp, field 5
					row.GetExp = input.ReadInt32();
					break;
				case 114: // packed float valueList, field 14
					ByteString packed = input.ReadBytes();
					using (var values = new CodedInputStream(packed.ToByteArray()))
					{
						while (!values.IsAtEnd)
							row.ValueList.Add(values.ReadFloat());
					}
					break;
				default:
					input.SkipLastField();
					break;
			}
		}
	}
}
