using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class BuffTable : IMessage<BuffTable>, IMessage, IEquatable<BuffTable>, IDeepCloneable<BuffTable>, IBufferMessage
{
	private static readonly MessageParser<BuffTable> _parser = new MessageParser<BuffTable>(() => new BuffTable());

	private UnknownFieldSet _unknownFields;

	public const int AddBuffIdFieldNumber = 1;

	private int addBuffId_;

	public const int BuffApplyTypeFieldNumber = 2;

	private int buffApplyType_;

	public const int BuffConditionIdFieldNumber = 3;

	private int buffConditionId_;

	public const int BuffCountTypeFieldNumber = 4;

	private int buffCountType_;

	public const int BuffDescSkillTextIdFieldNumber = 5;

	private int buffDescSkillTextId_;

	public const int BuffDisplayTypeFieldNumber = 6;

	private int buffDisplayType_;

	public const int BuffDisplayValueFieldNumber = 7;

	private int buffDisplayValue_;

	public const int BuffGroupFieldNumber = 8;

	private int buffGroup_;

	public const int BuffIconSpriteNameFieldNumber = 9;

	private string buffIconSpriteName_ = "";

	public const int BuffSkillTextIdFieldNumber = 10;

	private int buffSkillTextId_;

	public const int BuffTurnFieldNumber = 11;

	private int buffTurn_;

	public const int BuffTypeFieldNumber = 12;

	private int buffType_;

	public const int BuffValueFieldNumber = 13;

	private double buffValue_;

	public const int ClassTypeFieldNumber = 14;

	private string classType_ = "";

	public const int ConditionAddBuffIdFieldNumber = 15;

	private int conditionAddBuffId_;

	public const int EffectPrefabNameFieldNumber = 16;

	private string effectPrefabName_ = "";

	public const int IdFieldNumber = 17;

	private int id_;

	public const int MagicValueFieldNumber = 18;

	private double magicValue_;

	public const int OwnerTypeFieldNumber = 19;

	private int ownerType_;

	public const int SpecialEffectPrefabNameFieldNumber = 20;

	private string specialEffectPrefabName_ = "";

	public const int StatTypeFieldNumber = 21;

	private int statType_;

	public const int SubTypeFieldNumber = 22;

	private int subType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BuffTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuffTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AddBuffId
	{
		get
		{
			return addBuffId_;
		}
		set
		{
			addBuffId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffApplyType
	{
		get
		{
			return buffApplyType_;
		}
		set
		{
			buffApplyType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffConditionId
	{
		get
		{
			return buffConditionId_;
		}
		set
		{
			buffConditionId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffCountType
	{
		get
		{
			return buffCountType_;
		}
		set
		{
			buffCountType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffDescSkillTextId
	{
		get
		{
			return buffDescSkillTextId_;
		}
		set
		{
			buffDescSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffDisplayType
	{
		get
		{
			return buffDisplayType_;
		}
		set
		{
			buffDisplayType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffDisplayValue
	{
		get
		{
			return buffDisplayValue_;
		}
		set
		{
			buffDisplayValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffGroup
	{
		get
		{
			return buffGroup_;
		}
		set
		{
			buffGroup_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BuffIconSpriteName
	{
		get
		{
			return buffIconSpriteName_;
		}
		set
		{
			buffIconSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffSkillTextId
	{
		get
		{
			return buffSkillTextId_;
		}
		set
		{
			buffSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffTurn
	{
		get
		{
			return buffTurn_;
		}
		set
		{
			buffTurn_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffType
	{
		get
		{
			return buffType_;
		}
		set
		{
			buffType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double BuffValue
	{
		get
		{
			return buffValue_;
		}
		set
		{
			buffValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ClassType
	{
		get
		{
			return classType_;
		}
		set
		{
			classType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionAddBuffId
	{
		get
		{
			return conditionAddBuffId_;
		}
		set
		{
			conditionAddBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EffectPrefabName
	{
		get
		{
			return effectPrefabName_;
		}
		set
		{
			effectPrefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public double MagicValue
	{
		get
		{
			return magicValue_;
		}
		set
		{
			magicValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OwnerType
	{
		get
		{
			return ownerType_;
		}
		set
		{
			ownerType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string SpecialEffectPrefabName
	{
		get
		{
			return specialEffectPrefabName_;
		}
		set
		{
			specialEffectPrefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StatType
	{
		get
		{
			return statType_;
		}
		set
		{
			statType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubType
	{
		get
		{
			return subType_;
		}
		set
		{
			subType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BuffTable(BuffTable other)
		: this()
	{
		addBuffId_ = other.addBuffId_;
		buffApplyType_ = other.buffApplyType_;
		buffConditionId_ = other.buffConditionId_;
		buffCountType_ = other.buffCountType_;
		buffDescSkillTextId_ = other.buffDescSkillTextId_;
		buffDisplayType_ = other.buffDisplayType_;
		buffDisplayValue_ = other.buffDisplayValue_;
		buffGroup_ = other.buffGroup_;
		buffIconSpriteName_ = other.buffIconSpriteName_;
		buffSkillTextId_ = other.buffSkillTextId_;
		buffTurn_ = other.buffTurn_;
		buffType_ = other.buffType_;
		buffValue_ = other.buffValue_;
		classType_ = other.classType_;
		conditionAddBuffId_ = other.conditionAddBuffId_;
		effectPrefabName_ = other.effectPrefabName_;
		id_ = other.id_;
		magicValue_ = other.magicValue_;
		ownerType_ = other.ownerType_;
		specialEffectPrefabName_ = other.specialEffectPrefabName_;
		statType_ = other.statType_;
		subType_ = other.subType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffTable Clone()
	{
		return new BuffTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuffTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuffTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AddBuffId == other.AddBuffId && BuffApplyType == other.BuffApplyType && BuffConditionId == other.BuffConditionId && BuffCountType == other.BuffCountType && BuffDescSkillTextId == other.BuffDescSkillTextId && BuffDisplayType == other.BuffDisplayType && BuffDisplayValue == other.BuffDisplayValue && BuffGroup == other.BuffGroup && !(BuffIconSpriteName != other.BuffIconSpriteName) && BuffSkillTextId == other.BuffSkillTextId && BuffTurn == other.BuffTurn && BuffType == other.BuffType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BuffValue, other.BuffValue) && !(ClassType != other.ClassType) && ConditionAddBuffId == other.ConditionAddBuffId && !(EffectPrefabName != other.EffectPrefabName) && Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MagicValue, other.MagicValue) && OwnerType == other.OwnerType && !(SpecialEffectPrefabName != other.SpecialEffectPrefabName) && StatType == other.StatType && SubType == other.SubType)
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
		if (AddBuffId != 0)
		{
			num ^= AddBuffId.GetHashCode();
		}
		if (BuffApplyType != 0)
		{
			num ^= BuffApplyType.GetHashCode();
		}
		if (BuffConditionId != 0)
		{
			num ^= BuffConditionId.GetHashCode();
		}
		if (BuffCountType != 0)
		{
			num ^= BuffCountType.GetHashCode();
		}
		if (BuffDescSkillTextId != 0)
		{
			num ^= BuffDescSkillTextId.GetHashCode();
		}
		if (BuffDisplayType != 0)
		{
			num ^= BuffDisplayType.GetHashCode();
		}
		if (BuffDisplayValue != 0)
		{
			num ^= BuffDisplayValue.GetHashCode();
		}
		if (BuffGroup != 0)
		{
			num ^= BuffGroup.GetHashCode();
		}
		if (BuffIconSpriteName.Length != 0)
		{
			num ^= BuffIconSpriteName.GetHashCode();
		}
		if (BuffSkillTextId != 0)
		{
			num ^= BuffSkillTextId.GetHashCode();
		}
		if (BuffTurn != 0)
		{
			num ^= BuffTurn.GetHashCode();
		}
		if (BuffType != 0)
		{
			num ^= BuffType.GetHashCode();
		}
		if (BuffValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BuffValue);
		}
		if (ClassType.Length != 0)
		{
			num ^= ClassType.GetHashCode();
		}
		if (ConditionAddBuffId != 0)
		{
			num ^= ConditionAddBuffId.GetHashCode();
		}
		if (EffectPrefabName.Length != 0)
		{
			num ^= EffectPrefabName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MagicValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MagicValue);
		}
		if (OwnerType != 0)
		{
			num ^= OwnerType.GetHashCode();
		}
		if (SpecialEffectPrefabName.Length != 0)
		{
			num ^= SpecialEffectPrefabName.GetHashCode();
		}
		if (StatType != 0)
		{
			num ^= StatType.GetHashCode();
		}
		if (SubType != 0)
		{
			num ^= SubType.GetHashCode();
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
		if (AddBuffId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AddBuffId);
		}
		if (BuffApplyType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffApplyType);
		}
		if (BuffConditionId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuffConditionId);
		}
		if (BuffCountType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BuffCountType);
		}
		if (BuffDescSkillTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BuffDescSkillTextId);
		}
		if (BuffDisplayType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BuffDisplayType);
		}
		if (BuffDisplayValue != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(BuffDisplayValue);
		}
		if (BuffGroup != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(BuffGroup);
		}
		if (BuffIconSpriteName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(BuffIconSpriteName);
		}
		if (BuffSkillTextId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(BuffSkillTextId);
		}
		if (BuffTurn != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(BuffTurn);
		}
		if (BuffType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(BuffType);
		}
		if (BuffValue != 0.0)
		{
			output.WriteRawTag(105);
			output.WriteDouble(BuffValue);
		}
		if (ClassType.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(ClassType);
		}
		if (ConditionAddBuffId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ConditionAddBuffId);
		}
		if (EffectPrefabName.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(EffectPrefabName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(Id);
		}
		if (MagicValue != 0.0)
		{
			output.WriteRawTag(145, 1);
			output.WriteDouble(MagicValue);
		}
		if (OwnerType != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(OwnerType);
		}
		if (SpecialEffectPrefabName.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(SpecialEffectPrefabName);
		}
		if (StatType != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(StatType);
		}
		if (SubType != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(SubType);
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
		if (AddBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddBuffId);
		}
		if (BuffApplyType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffApplyType);
		}
		if (BuffConditionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffConditionId);
		}
		if (BuffCountType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffCountType);
		}
		if (BuffDescSkillTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffDescSkillTextId);
		}
		if (BuffDisplayType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffDisplayType);
		}
		if (BuffDisplayValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffDisplayValue);
		}
		if (BuffGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffGroup);
		}
		if (BuffIconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuffIconSpriteName);
		}
		if (BuffSkillTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffSkillTextId);
		}
		if (BuffTurn != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffTurn);
		}
		if (BuffType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffType);
		}
		if (BuffValue != 0.0)
		{
			num += 9;
		}
		if (ClassType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ClassType);
		}
		if (ConditionAddBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionAddBuffId);
		}
		if (EffectPrefabName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(EffectPrefabName);
		}
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MagicValue != 0.0)
		{
			num += 10;
		}
		if (OwnerType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(OwnerType);
		}
		if (SpecialEffectPrefabName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SpecialEffectPrefabName);
		}
		if (StatType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StatType);
		}
		if (SubType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SubType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BuffTable other)
	{
		if (other != null)
		{
			if (other.AddBuffId != 0)
			{
				AddBuffId = other.AddBuffId;
			}
			if (other.BuffApplyType != 0)
			{
				BuffApplyType = other.BuffApplyType;
			}
			if (other.BuffConditionId != 0)
			{
				BuffConditionId = other.BuffConditionId;
			}
			if (other.BuffCountType != 0)
			{
				BuffCountType = other.BuffCountType;
			}
			if (other.BuffDescSkillTextId != 0)
			{
				BuffDescSkillTextId = other.BuffDescSkillTextId;
			}
			if (other.BuffDisplayType != 0)
			{
				BuffDisplayType = other.BuffDisplayType;
			}
			if (other.BuffDisplayValue != 0)
			{
				BuffDisplayValue = other.BuffDisplayValue;
			}
			if (other.BuffGroup != 0)
			{
				BuffGroup = other.BuffGroup;
			}
			if (other.BuffIconSpriteName.Length != 0)
			{
				BuffIconSpriteName = other.BuffIconSpriteName;
			}
			if (other.BuffSkillTextId != 0)
			{
				BuffSkillTextId = other.BuffSkillTextId;
			}
			if (other.BuffTurn != 0)
			{
				BuffTurn = other.BuffTurn;
			}
			if (other.BuffType != 0)
			{
				BuffType = other.BuffType;
			}
			if (other.BuffValue != 0.0)
			{
				BuffValue = other.BuffValue;
			}
			if (other.ClassType.Length != 0)
			{
				ClassType = other.ClassType;
			}
			if (other.ConditionAddBuffId != 0)
			{
				ConditionAddBuffId = other.ConditionAddBuffId;
			}
			if (other.EffectPrefabName.Length != 0)
			{
				EffectPrefabName = other.EffectPrefabName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MagicValue != 0.0)
			{
				MagicValue = other.MagicValue;
			}
			if (other.OwnerType != 0)
			{
				OwnerType = other.OwnerType;
			}
			if (other.SpecialEffectPrefabName.Length != 0)
			{
				SpecialEffectPrefabName = other.SpecialEffectPrefabName;
			}
			if (other.StatType != 0)
			{
				StatType = other.StatType;
			}
			if (other.SubType != 0)
			{
				SubType = other.SubType;
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
				AddBuffId = input.ReadInt32();
				break;
			case 16u:
				BuffApplyType = input.ReadInt32();
				break;
			case 24u:
				BuffConditionId = input.ReadInt32();
				break;
			case 32u:
				BuffCountType = input.ReadInt32();
				break;
			case 40u:
				BuffDescSkillTextId = input.ReadInt32();
				break;
			case 48u:
				BuffDisplayType = input.ReadInt32();
				break;
			case 56u:
				BuffDisplayValue = input.ReadInt32();
				break;
			case 64u:
				BuffGroup = input.ReadInt32();
				break;
			case 74u:
				BuffIconSpriteName = input.ReadString();
				break;
			case 80u:
				BuffSkillTextId = input.ReadInt32();
				break;
			case 88u:
				BuffTurn = input.ReadInt32();
				break;
			case 96u:
				BuffType = input.ReadInt32();
				break;
			case 105u:
				BuffValue = input.ReadDouble();
				break;
			case 114u:
				ClassType = input.ReadString();
				break;
			case 120u:
				ConditionAddBuffId = input.ReadInt32();
				break;
			case 130u:
				EffectPrefabName = input.ReadString();
				break;
			case 136u:
				Id = input.ReadInt32();
				break;
			case 145u:
				MagicValue = input.ReadDouble();
				break;
			case 152u:
				OwnerType = input.ReadInt32();
				break;
			case 162u:
				SpecialEffectPrefabName = input.ReadString();
				break;
			case 168u:
				StatType = input.ReadInt32();
				break;
			case 176u:
				SubType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
