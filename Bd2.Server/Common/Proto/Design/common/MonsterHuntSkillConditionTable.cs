using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MonsterHuntSkillConditionTable : IMessage<MonsterHuntSkillConditionTable>, IMessage, IEquatable<MonsterHuntSkillConditionTable>, IDeepCloneable<MonsterHuntSkillConditionTable>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntSkillConditionTable> _parser = new MessageParser<MonsterHuntSkillConditionTable>(() => new MonsterHuntSkillConditionTable());

	private UnknownFieldSet _unknownFields;

	public const int ConditionLocalTextIdFieldNumber = 1;

	private int conditionLocalTextId_;

	public const int ConditionTargetFieldNumber = 2;

	private int conditionTarget_;

	public const int ConditionTypeFieldNumber = 3;

	private int conditionType_;

	public const int ConditionValueFieldNumber = 4;

	private double conditionValue_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int LimitLocalTextIdFieldNumber = 6;

	private int limitLocalTextId_;

	public const int LimitTypeFieldNumber = 7;

	private int limitType_;

	public const int LimitValueFieldNumber = 8;

	private int limitValue_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MonsterHuntSkillConditionTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MonsterHuntSkillConditionTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionLocalTextId
	{
		get
		{
			return conditionLocalTextId_;
		}
		set
		{
			conditionLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ConditionTarget
	{
		get
		{
			return conditionTarget_;
		}
		set
		{
			conditionTarget_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double ConditionValue
	{
		get
		{
			return conditionValue_;
		}
		set
		{
			conditionValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LimitLocalTextId
	{
		get
		{
			return limitLocalTextId_;
		}
		set
		{
			limitLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LimitType
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LimitValue
	{
		get
		{
			return limitValue_;
		}
		set
		{
			limitValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntSkillConditionTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntSkillConditionTable(MonsterHuntSkillConditionTable other)
		: this()
	{
		conditionLocalTextId_ = other.conditionLocalTextId_;
		conditionTarget_ = other.conditionTarget_;
		conditionType_ = other.conditionType_;
		conditionValue_ = other.conditionValue_;
		id_ = other.id_;
		limitLocalTextId_ = other.limitLocalTextId_;
		limitType_ = other.limitType_;
		limitValue_ = other.limitValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntSkillConditionTable Clone()
	{
		return new MonsterHuntSkillConditionTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntSkillConditionTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntSkillConditionTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ConditionLocalTextId == other.ConditionLocalTextId && ConditionTarget == other.ConditionTarget && ConditionType == other.ConditionType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ConditionValue, other.ConditionValue) && Id == other.Id && LimitLocalTextId == other.LimitLocalTextId && LimitType == other.LimitType && LimitValue == other.LimitValue)
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
		if (ConditionLocalTextId != 0)
		{
			num ^= ConditionLocalTextId.GetHashCode();
		}
		if (ConditionTarget != 0)
		{
			num ^= ConditionTarget.GetHashCode();
		}
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (ConditionValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ConditionValue);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LimitLocalTextId != 0)
		{
			num ^= LimitLocalTextId.GetHashCode();
		}
		if (LimitType != 0)
		{
			num ^= LimitType.GetHashCode();
		}
		if (LimitValue != 0)
		{
			num ^= LimitValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
		if (ConditionLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionLocalTextId);
		}
		if (ConditionTarget != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ConditionTarget);
		}
		if (ConditionType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ConditionType);
		}
		if (ConditionValue != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(ConditionValue);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (LimitLocalTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LimitLocalTextId);
		}
		if (LimitType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LimitType);
		}
		if (LimitValue != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LimitValue);
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
		if (ConditionLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionLocalTextId);
		}
		if (ConditionTarget != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionTarget);
		}
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (ConditionValue != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LimitLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitLocalTextId);
		}
		if (LimitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitType);
		}
		if (LimitValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntSkillConditionTable other)
	{
		if (other != null)
		{
			if (other.ConditionLocalTextId != 0)
			{
				ConditionLocalTextId = other.ConditionLocalTextId;
			}
			if (other.ConditionTarget != 0)
			{
				ConditionTarget = other.ConditionTarget;
			}
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.ConditionValue != 0.0)
			{
				ConditionValue = other.ConditionValue;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LimitLocalTextId != 0)
			{
				LimitLocalTextId = other.LimitLocalTextId;
			}
			if (other.LimitType != 0)
			{
				LimitType = other.LimitType;
			}
			if (other.LimitValue != 0)
			{
				LimitValue = other.LimitValue;
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
				ConditionLocalTextId = input.ReadInt32();
				break;
			case 16u:
				ConditionTarget = input.ReadInt32();
				break;
			case 24u:
				ConditionType = input.ReadInt32();
				break;
			case 33u:
				ConditionValue = input.ReadDouble();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				LimitLocalTextId = input.ReadInt32();
				break;
			case 56u:
				LimitType = input.ReadInt32();
				break;
			case 64u:
				LimitValue = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
