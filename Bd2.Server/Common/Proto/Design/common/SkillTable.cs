using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SkillTable : IMessage<SkillTable>, IMessage, IEquatable<SkillTable>, IDeepCloneable<SkillTable>, IBufferMessage
{
	private static readonly MessageParser<SkillTable> _parser = new MessageParser<SkillTable>(() => new SkillTable());

	private UnknownFieldSet _unknownFields;

	public const int AttackMoveTypeFieldNumber = 1;

	private int attackMoveType_;

	public const int AttackRangeFieldNumber = 2;

	private int attackRange_;

	public const int AttackRangeCountFieldNumber = 3;

	private int attackRangeCount_;

	public const int AttackTypeFieldNumber = 4;

	private int attackType_;

	public const int BuffIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_buffId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> buffId_ = new RepeatedField<int>();

	public const int CooldownFieldNumber = 6;

	private int cooldown_;

	public const int GroupIdFieldNumber = 7;

	private int groupId_;

	public const int IdFieldNumber = 8;

	private int id_;

	public const int MainTargetTypeFieldNumber = 9;

	private int mainTargetType_;

	public const int MainTargetValueFieldNumber = 10;

	private int mainTargetValue_;

	public const int RepeatCountFieldNumber = 11;

	private int repeatCount_;

	public const int SkillDescSkillTextIdFieldNumber = 12;

	private int skillDescSkillTextId_;

	public const int SkillDesignIdFieldNumber = 13;

	private int skillDesignId_;

	public const int SkillNameSkillTextIdFieldNumber = 14;

	private int skillNameSkillTextId_;

	public const int SkillUseRateFieldNumber = 15;

	private double skillUseRate_;

	public const int SpReqCountFieldNumber = 16;

	private int spReqCount_;

	public const int TargetTypeFieldNumber = 17;

	private int targetType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SkillTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SkillTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AttackMoveType
	{
		get
		{
			return attackMoveType_;
		}
		set
		{
			attackMoveType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackRange
	{
		get
		{
			return attackRange_;
		}
		set
		{
			attackRange_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackRangeCount
	{
		get
		{
			return attackRangeCount_;
		}
		set
		{
			attackRangeCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackType
	{
		get
		{
			return attackType_;
		}
		set
		{
			attackType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BuffId => buffId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Cooldown
	{
		get
		{
			return cooldown_;
		}
		set
		{
			cooldown_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int MainTargetType
	{
		get
		{
			return mainTargetType_;
		}
		set
		{
			mainTargetType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MainTargetValue
	{
		get
		{
			return mainTargetValue_;
		}
		set
		{
			mainTargetValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RepeatCount
	{
		get
		{
			return repeatCount_;
		}
		set
		{
			repeatCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillDescSkillTextId
	{
		get
		{
			return skillDescSkillTextId_;
		}
		set
		{
			skillDescSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillDesignId
	{
		get
		{
			return skillDesignId_;
		}
		set
		{
			skillDesignId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillNameSkillTextId
	{
		get
		{
			return skillNameSkillTextId_;
		}
		set
		{
			skillNameSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double SkillUseRate
	{
		get
		{
			return skillUseRate_;
		}
		set
		{
			skillUseRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpReqCount
	{
		get
		{
			return spReqCount_;
		}
		set
		{
			spReqCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TargetType
	{
		get
		{
			return targetType_;
		}
		set
		{
			targetType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SkillTable(SkillTable other)
		: this()
	{
		attackMoveType_ = other.attackMoveType_;
		attackRange_ = other.attackRange_;
		attackRangeCount_ = other.attackRangeCount_;
		attackType_ = other.attackType_;
		buffId_ = other.buffId_.Clone();
		cooldown_ = other.cooldown_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		mainTargetType_ = other.mainTargetType_;
		mainTargetValue_ = other.mainTargetValue_;
		repeatCount_ = other.repeatCount_;
		skillDescSkillTextId_ = other.skillDescSkillTextId_;
		skillDesignId_ = other.skillDesignId_;
		skillNameSkillTextId_ = other.skillNameSkillTextId_;
		skillUseRate_ = other.skillUseRate_;
		spReqCount_ = other.spReqCount_;
		targetType_ = other.targetType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkillTable Clone()
	{
		return new SkillTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SkillTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SkillTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AttackMoveType == other.AttackMoveType && AttackRange == other.AttackRange && AttackRangeCount == other.AttackRangeCount && AttackType == other.AttackType && buffId_.Equals(other.buffId_) && Cooldown == other.Cooldown && GroupId == other.GroupId && Id == other.Id && MainTargetType == other.MainTargetType && MainTargetValue == other.MainTargetValue && RepeatCount == other.RepeatCount && SkillDescSkillTextId == other.SkillDescSkillTextId && SkillDesignId == other.SkillDesignId && SkillNameSkillTextId == other.SkillNameSkillTextId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SkillUseRate, other.SkillUseRate) && SpReqCount == other.SpReqCount && TargetType == other.TargetType)
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (AttackMoveType != 0)
		{
			num ^= AttackMoveType.GetHashCode();
		}
		if (AttackRange != 0)
		{
			num ^= AttackRange.GetHashCode();
		}
		if (AttackRangeCount != 0)
		{
			num ^= AttackRangeCount.GetHashCode();
		}
		if (AttackType != 0)
		{
			num ^= AttackType.GetHashCode();
		}
		num ^= buffId_.GetHashCode();
		if (Cooldown != 0)
		{
			num ^= Cooldown.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MainTargetType != 0)
		{
			num ^= MainTargetType.GetHashCode();
		}
		if (MainTargetValue != 0)
		{
			num ^= MainTargetValue.GetHashCode();
		}
		if (RepeatCount != 0)
		{
			num ^= RepeatCount.GetHashCode();
		}
		if (SkillDescSkillTextId != 0)
		{
			num ^= SkillDescSkillTextId.GetHashCode();
		}
		if (SkillDesignId != 0)
		{
			num ^= SkillDesignId.GetHashCode();
		}
		if (SkillNameSkillTextId != 0)
		{
			num ^= SkillNameSkillTextId.GetHashCode();
		}
		if (SkillUseRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SkillUseRate);
		}
		if (SpReqCount != 0)
		{
			num ^= SpReqCount.GetHashCode();
		}
		if (TargetType != 0)
		{
			num ^= TargetType.GetHashCode();
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
		if (AttackMoveType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AttackMoveType);
		}
		if (AttackRange != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttackRange);
		}
		if (AttackRangeCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AttackRangeCount);
		}
		if (AttackType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AttackType);
		}
		buffId_.WriteTo(ref output, _repeated_buffId_codec);
		if (Cooldown != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Cooldown);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (MainTargetType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MainTargetType);
		}
		if (MainTargetValue != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MainTargetValue);
		}
		if (RepeatCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(RepeatCount);
		}
		if (SkillDescSkillTextId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(SkillDescSkillTextId);
		}
		if (SkillDesignId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(SkillDesignId);
		}
		if (SkillNameSkillTextId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(SkillNameSkillTextId);
		}
		if (SkillUseRate != 0.0)
		{
			output.WriteRawTag(121);
			output.WriteDouble(SkillUseRate);
		}
		if (SpReqCount != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(SpReqCount);
		}
		if (TargetType != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(TargetType);
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
		if (AttackMoveType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackMoveType);
		}
		if (AttackRange != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackRange);
		}
		if (AttackRangeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackRangeCount);
		}
		if (AttackType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackType);
		}
		num += buffId_.CalculateSize(_repeated_buffId_codec);
		if (Cooldown != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Cooldown);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MainTargetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MainTargetType);
		}
		if (MainTargetValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MainTargetValue);
		}
		if (RepeatCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RepeatCount);
		}
		if (SkillDescSkillTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillDescSkillTextId);
		}
		if (SkillDesignId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillDesignId);
		}
		if (SkillNameSkillTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillNameSkillTextId);
		}
		if (SkillUseRate != 0.0)
		{
			num += 9;
		}
		if (SpReqCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpReqCount);
		}
		if (TargetType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TargetType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SkillTable other)
	{
		if (other != null)
		{
			if (other.AttackMoveType != 0)
			{
				AttackMoveType = other.AttackMoveType;
			}
			if (other.AttackRange != 0)
			{
				AttackRange = other.AttackRange;
			}
			if (other.AttackRangeCount != 0)
			{
				AttackRangeCount = other.AttackRangeCount;
			}
			if (other.AttackType != 0)
			{
				AttackType = other.AttackType;
			}
			buffId_.Add(other.buffId_);
			if (other.Cooldown != 0)
			{
				Cooldown = other.Cooldown;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MainTargetType != 0)
			{
				MainTargetType = other.MainTargetType;
			}
			if (other.MainTargetValue != 0)
			{
				MainTargetValue = other.MainTargetValue;
			}
			if (other.RepeatCount != 0)
			{
				RepeatCount = other.RepeatCount;
			}
			if (other.SkillDescSkillTextId != 0)
			{
				SkillDescSkillTextId = other.SkillDescSkillTextId;
			}
			if (other.SkillDesignId != 0)
			{
				SkillDesignId = other.SkillDesignId;
			}
			if (other.SkillNameSkillTextId != 0)
			{
				SkillNameSkillTextId = other.SkillNameSkillTextId;
			}
			if (other.SkillUseRate != 0.0)
			{
				SkillUseRate = other.SkillUseRate;
			}
			if (other.SpReqCount != 0)
			{
				SpReqCount = other.SpReqCount;
			}
			if (other.TargetType != 0)
			{
				TargetType = other.TargetType;
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
				AttackMoveType = input.ReadInt32();
				break;
			case 16u:
				AttackRange = input.ReadInt32();
				break;
			case 24u:
				AttackRangeCount = input.ReadInt32();
				break;
			case 32u:
				AttackType = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				buffId_.AddEntriesFrom(ref input, _repeated_buffId_codec);
				break;
			case 48u:
				Cooldown = input.ReadInt32();
				break;
			case 56u:
				GroupId = input.ReadInt32();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 72u:
				MainTargetType = input.ReadInt32();
				break;
			case 80u:
				MainTargetValue = input.ReadInt32();
				break;
			case 88u:
				RepeatCount = input.ReadInt32();
				break;
			case 96u:
				SkillDescSkillTextId = input.ReadInt32();
				break;
			case 104u:
				SkillDesignId = input.ReadInt32();
				break;
			case 112u:
				SkillNameSkillTextId = input.ReadInt32();
				break;
			case 121u:
				SkillUseRate = input.ReadDouble();
				break;
			case 128u:
				SpReqCount = input.ReadInt32();
				break;
			case 136u:
				TargetType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
