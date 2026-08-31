using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntSkillData : IMessage<MonsterHuntSkillData>, IMessage, IEquatable<MonsterHuntSkillData>, IDeepCloneable<MonsterHuntSkillData>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntSkillData> _parser = new MessageParser<MonsterHuntSkillData>(() => new MonsterHuntSkillData());

	private UnknownFieldSet _unknownFields;

	public const int CostumeIdFieldNumber = 1;

	private int costumeId_;

	public const int UseCountFieldNumber = 2;

	private int useCount_;

	public const int ConditionIdFieldNumber = 3;

	private int conditionId_;

	public const int PartsTableIdFieldNumber = 4;

	private int partsTableId_;

	public const int LimitTypeFieldNumber = 5;

	private Define_EMonsterHuntSkillLimits limitType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MonsterHuntSkillData> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => BattleRetryPreviousTurnResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CostumeId
	{
		get
		{
			return costumeId_;
		}
		set
		{
			costumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseCount
	{
		get
		{
			return useCount_;
		}
		set
		{
			useCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionId
	{
		get
		{
			return conditionId_;
		}
		set
		{
			conditionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartsTableId
	{
		get
		{
			return partsTableId_;
		}
		set
		{
			partsTableId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Define_EMonsterHuntSkillLimits LimitType
	{
		get
		{
			return limitType_;
		}
		set
		{
			limitType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntSkillData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntSkillData(MonsterHuntSkillData other)
		: this()
	{
		costumeId_ = other.costumeId_;
		useCount_ = other.useCount_;
		conditionId_ = other.conditionId_;
		partsTableId_ = other.partsTableId_;
		limitType_ = other.limitType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntSkillData Clone()
	{
		return new MonsterHuntSkillData(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntSkillData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntSkillData other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CostumeId == other.CostumeId && UseCount == other.UseCount && ConditionId == other.ConditionId && PartsTableId == other.PartsTableId && LimitType == other.LimitType)
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
		if (CostumeId != 0)
		{
			num ^= CostumeId.GetHashCode();
		}
		if (UseCount != 0)
		{
			num ^= UseCount.GetHashCode();
		}
		if (ConditionId != 0)
		{
			num ^= ConditionId.GetHashCode();
		}
		if (PartsTableId != 0)
		{
			num ^= PartsTableId.GetHashCode();
		}
		if (LimitType != Define_EMonsterHuntSkillLimits.None)
		{
			num ^= LimitType.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (CostumeId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CostumeId);
		}
		if (UseCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UseCount);
		}
		if (ConditionId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ConditionId);
		}
		if (PartsTableId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PartsTableId);
		}
		if (LimitType != Define_EMonsterHuntSkillLimits.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)LimitType);
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
		if (CostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeId);
		}
		if (UseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseCount);
		}
		if (ConditionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionId);
		}
		if (PartsTableId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartsTableId);
		}
		if (LimitType != Define_EMonsterHuntSkillLimits.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LimitType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntSkillData other)
	{
		if (other != null)
		{
			if (other.CostumeId != 0)
			{
				CostumeId = other.CostumeId;
			}
			if (other.UseCount != 0)
			{
				UseCount = other.UseCount;
			}
			if (other.ConditionId != 0)
			{
				ConditionId = other.ConditionId;
			}
			if (other.PartsTableId != 0)
			{
				PartsTableId = other.PartsTableId;
			}
			if (other.LimitType != Define_EMonsterHuntSkillLimits.None)
			{
				LimitType = other.LimitType;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 8u:
				CostumeId = input.ReadInt32();
				break;
			case 16u:
				UseCount = input.ReadInt32();
				break;
			case 24u:
				ConditionId = input.ReadInt32();
				break;
			case 32u:
				PartsTableId = input.ReadInt32();
				break;
			case 40u:
				LimitType = (Define_EMonsterHuntSkillLimits)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
