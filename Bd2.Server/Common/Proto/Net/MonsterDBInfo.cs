using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterDBInfo : IMessage<MonsterDBInfo>, IMessage, IEquatable<MonsterDBInfo>, IDeepCloneable<MonsterDBInfo>, IBufferMessage
{
	private static readonly MessageParser<MonsterDBInfo> _parser = new MessageParser<MonsterDBInfo>(() => new MonsterDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int MonsterIdFieldNumber = 1;

	private int monsterId_;

	public const int BattleDeckFieldNumber = 2;

	private int battleDeck_;

	public const int RespawnTimeFieldNumber = 3;

	private long respawnTime_;

	public const int LifeEndTimeFieldNumber = 4;

	private long lifeEndTime_;

	public const int GroupIdFieldNumber = 5;

	private int groupId_;

	public const int ActiveFlagFieldNumber = 6;

	private bool activeFlag_;

	public long BuffRemainTick;

	public DateTime buffEndTime;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleDeck
	{
		get
		{
			return battleDeck_;
		}
		set
		{
			battleDeck_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long RespawnTime
	{
		get
		{
			return respawnTime_;
		}
		set
		{
			respawnTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LifeEndTime
	{
		get
		{
			return lifeEndTime_;
		}
		set
		{
			lifeEndTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ActiveFlag
	{
		get
		{
			return activeFlag_;
		}
		set
		{
			activeFlag_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterDBInfo(MonsterDBInfo other)
		: this()
	{
		monsterId_ = other.monsterId_;
		battleDeck_ = other.battleDeck_;
		respawnTime_ = other.respawnTime_;
		lifeEndTime_ = other.lifeEndTime_;
		groupId_ = other.groupId_;
		activeFlag_ = other.activeFlag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterDBInfo Clone()
	{
		return new MonsterDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MonsterDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (MonsterId == other.MonsterId && BattleDeck == other.BattleDeck && RespawnTime == other.RespawnTime && LifeEndTime == other.LifeEndTime && GroupId == other.GroupId && ActiveFlag == other.ActiveFlag)
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
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (BattleDeck != 0)
		{
			num ^= BattleDeck.GetHashCode();
		}
		if (RespawnTime != 0L)
		{
			num ^= RespawnTime.GetHashCode();
		}
		if (LifeEndTime != 0L)
		{
			num ^= LifeEndTime.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (ActiveFlag)
		{
			num ^= ActiveFlag.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (MonsterId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MonsterId);
		}
		if (BattleDeck != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleDeck);
		}
		if (RespawnTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(RespawnTime);
		}
		if (LifeEndTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(LifeEndTime);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GroupId);
		}
		if (ActiveFlag)
		{
			output.WriteRawTag(48);
			output.WriteBool(ActiveFlag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterId);
		}
		if (BattleDeck != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDeck);
		}
		if (RespawnTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(RespawnTime);
		}
		if (LifeEndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LifeEndTime);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (ActiveFlag)
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
	public void MergeFrom(MonsterDBInfo other)
	{
		if (other != null)
		{
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.BattleDeck != 0)
			{
				BattleDeck = other.BattleDeck;
			}
			if (other.RespawnTime != 0L)
			{
				RespawnTime = other.RespawnTime;
			}
			if (other.LifeEndTime != 0L)
			{
				LifeEndTime = other.LifeEndTime;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.ActiveFlag)
			{
				ActiveFlag = other.ActiveFlag;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
				MonsterId = input.ReadInt32();
				break;
			case 16u:
				BattleDeck = input.ReadInt32();
				break;
			case 24u:
				RespawnTime = input.ReadInt64();
				break;
			case 32u:
				LifeEndTime = input.ReadInt64();
				break;
			case 40u:
				GroupId = input.ReadInt32();
				break;
			case 48u:
				ActiveFlag = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
