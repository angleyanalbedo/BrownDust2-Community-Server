using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntUserDBInfo : IMessage<MonsterHuntUserDBInfo>, IMessage, IEquatable<MonsterHuntUserDBInfo>, IDeepCloneable<MonsterHuntUserDBInfo>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntUserDBInfo> _parser = new MessageParser<MonsterHuntUserDBInfo>(() => new MonsterHuntUserDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int SeasonFieldNumber = 1;

	private int season_;

	public const int MonsterHuntIdFieldNumber = 2;

	private int monsterHuntId_;

	public const int LevelFieldNumber = 3;

	private int level_;

	public const int StartHpFieldNumber = 4;

	private long startHp_;

	public const int HighestFirstTurnDamageFieldNumber = 5;

	private int highestFirstTurnDamage_;

	public const int HighestHpFieldNumber = 6;

	private long highestHp_;

	public const int HighestHpDateFieldNumber = 7;

	private long highestHpDate_;

	public const int CurrentLevelHighestDamageFieldNumber = 8;

	private long currentLevelHighestDamage_;

	public const int DailyHighestDamageFieldNumber = 9;

	private long dailyHighestDamage_;

	public const int SeasonRewardFieldNumber = 10;

	private bool seasonReward_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MonsterHuntUserDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MonsterHuntUserDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MonsterHuntId
	{
		get
		{
			return monsterHuntId_;
		}
		set
		{
			monsterHuntId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long StartHp
	{
		get
		{
			return startHp_;
		}
		set
		{
			startHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HighestFirstTurnDamage
	{
		get
		{
			return highestFirstTurnDamage_;
		}
		set
		{
			highestFirstTurnDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long HighestHp
	{
		get
		{
			return highestHp_;
		}
		set
		{
			highestHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long HighestHpDate
	{
		get
		{
			return highestHpDate_;
		}
		set
		{
			highestHpDate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CurrentLevelHighestDamage
	{
		get
		{
			return currentLevelHighestDamage_;
		}
		set
		{
			currentLevelHighestDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DailyHighestDamage
	{
		get
		{
			return dailyHighestDamage_;
		}
		set
		{
			dailyHighestDamage_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool SeasonReward
	{
		get
		{
			return seasonReward_;
		}
		set
		{
			seasonReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntUserDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntUserDBInfo(MonsterHuntUserDBInfo other)
		: this()
	{
		season_ = other.season_;
		monsterHuntId_ = other.monsterHuntId_;
		level_ = other.level_;
		startHp_ = other.startHp_;
		highestFirstTurnDamage_ = other.highestFirstTurnDamage_;
		highestHp_ = other.highestHp_;
		highestHpDate_ = other.highestHpDate_;
		currentLevelHighestDamage_ = other.currentLevelHighestDamage_;
		dailyHighestDamage_ = other.dailyHighestDamage_;
		seasonReward_ = other.seasonReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntUserDBInfo Clone()
	{
		return new MonsterHuntUserDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntUserDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntUserDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Season == other.Season && MonsterHuntId == other.MonsterHuntId && Level == other.Level && StartHp == other.StartHp && HighestFirstTurnDamage == other.HighestFirstTurnDamage && HighestHp == other.HighestHp && HighestHpDate == other.HighestHpDate && CurrentLevelHighestDamage == other.CurrentLevelHighestDamage && DailyHighestDamage == other.DailyHighestDamage && SeasonReward == other.SeasonReward)
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (MonsterHuntId != 0)
		{
			num ^= MonsterHuntId.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (StartHp != 0L)
		{
			num ^= StartHp.GetHashCode();
		}
		if (HighestFirstTurnDamage != 0)
		{
			num ^= HighestFirstTurnDamage.GetHashCode();
		}
		if (HighestHp != 0L)
		{
			num ^= HighestHp.GetHashCode();
		}
		if (HighestHpDate != 0L)
		{
			num ^= HighestHpDate.GetHashCode();
		}
		if (CurrentLevelHighestDamage != 0L)
		{
			num ^= CurrentLevelHighestDamage.GetHashCode();
		}
		if (DailyHighestDamage != 0L)
		{
			num ^= DailyHighestDamage.GetHashCode();
		}
		if (SeasonReward)
		{
			num ^= SeasonReward.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Season != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Season);
		}
		if (MonsterHuntId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MonsterHuntId);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Level);
		}
		if (StartHp != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(StartHp);
		}
		if (HighestFirstTurnDamage != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(HighestFirstTurnDamage);
		}
		if (HighestHp != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(HighestHp);
		}
		if (HighestHpDate != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(HighestHpDate);
		}
		if (CurrentLevelHighestDamage != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(CurrentLevelHighestDamage);
		}
		if (DailyHighestDamage != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(DailyHighestDamage);
		}
		if (SeasonReward)
		{
			output.WriteRawTag(80);
			output.WriteBool(SeasonReward);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Season);
		}
		if (MonsterHuntId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterHuntId);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (StartHp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StartHp);
		}
		if (HighestFirstTurnDamage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HighestFirstTurnDamage);
		}
		if (HighestHp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(HighestHp);
		}
		if (HighestHpDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(HighestHpDate);
		}
		if (CurrentLevelHighestDamage != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CurrentLevelHighestDamage);
		}
		if (DailyHighestDamage != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DailyHighestDamage);
		}
		if (SeasonReward)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntUserDBInfo other)
	{
		if (other != null)
		{
			if (other.Season != 0)
			{
				Season = other.Season;
			}
			if (other.MonsterHuntId != 0)
			{
				MonsterHuntId = other.MonsterHuntId;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.StartHp != 0L)
			{
				StartHp = other.StartHp;
			}
			if (other.HighestFirstTurnDamage != 0)
			{
				HighestFirstTurnDamage = other.HighestFirstTurnDamage;
			}
			if (other.HighestHp != 0L)
			{
				HighestHp = other.HighestHp;
			}
			if (other.HighestHpDate != 0L)
			{
				HighestHpDate = other.HighestHpDate;
			}
			if (other.CurrentLevelHighestDamage != 0L)
			{
				CurrentLevelHighestDamage = other.CurrentLevelHighestDamage;
			}
			if (other.DailyHighestDamage != 0L)
			{
				DailyHighestDamage = other.DailyHighestDamage;
			}
			if (other.SeasonReward)
			{
				SeasonReward = other.SeasonReward;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 8u:
				Season = input.ReadInt32();
				break;
			case 16u:
				MonsterHuntId = input.ReadInt32();
				break;
			case 24u:
				Level = input.ReadInt32();
				break;
			case 32u:
				StartHp = input.ReadInt64();
				break;
			case 40u:
				HighestFirstTurnDamage = input.ReadInt32();
				break;
			case 48u:
				HighestHp = input.ReadInt64();
				break;
			case 56u:
				HighestHpDate = input.ReadInt64();
				break;
			case 64u:
				CurrentLevelHighestDamage = input.ReadInt64();
				break;
			case 72u:
				DailyHighestDamage = input.ReadInt64();
				break;
			case 80u:
				SeasonReward = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
