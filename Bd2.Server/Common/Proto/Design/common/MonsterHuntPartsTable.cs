using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MonsterHuntPartsTable : IMessage<MonsterHuntPartsTable>, IMessage, IEquatable<MonsterHuntPartsTable>, IDeepCloneable<MonsterHuntPartsTable>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntPartsTable> _parser = new MessageParser<MonsterHuntPartsTable>(() => new MonsterHuntPartsTable());

	private UnknownFieldSet _unknownFields;

	public const int BossBodyPositionFieldNumber = 1;

	private int bossBodyPosition_;

	public const int BossPartIcon1FieldNumber = 2;

	private string bossPartIcon1_ = "";

	public const int BossPartIcon2FieldNumber = 3;

	private string bossPartIcon2_ = "";

	public const int ConditionIdFieldNumber = 4;

	private int conditionId_;

	public const int GroupIdFieldNumber = 5;

	private int groupId_;

	public const int IdFieldNumber = 6;

	private int id_;

	public const int ParentCharIdFieldNumber = 7;

	private int parentCharId_;

	public const int PartLocalTextIdFieldNumber = 8;

	private int partLocalTextId_;

	public const int TypeFieldNumber = 9;

	private int type_;

	public const int UseCostumeFieldNumber = 10;

	private int useCostume_;

	public const int WeakDmgValueFieldNumber = 11;

	private double weakDmgValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntPartsTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterHuntPartsTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BossBodyPosition
	{
		get
		{
			return bossBodyPosition_;
		}
		set
		{
			bossBodyPosition_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BossPartIcon1
	{
		get
		{
			return bossPartIcon1_;
		}
		set
		{
			bossPartIcon1_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BossPartIcon2
	{
		get
		{
			return bossPartIcon2_;
		}
		set
		{
			bossPartIcon2_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int ParentCharId
	{
		get
		{
			return parentCharId_;
		}
		set
		{
			parentCharId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartLocalTextId
	{
		get
		{
			return partLocalTextId_;
		}
		set
		{
			partLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseCostume
	{
		get
		{
			return useCostume_;
		}
		set
		{
			useCostume_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double WeakDmgValue
	{
		get
		{
			return weakDmgValue_;
		}
		set
		{
			weakDmgValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntPartsTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntPartsTable(MonsterHuntPartsTable other)
		: this()
	{
		bossBodyPosition_ = other.bossBodyPosition_;
		bossPartIcon1_ = other.bossPartIcon1_;
		bossPartIcon2_ = other.bossPartIcon2_;
		conditionId_ = other.conditionId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		parentCharId_ = other.parentCharId_;
		partLocalTextId_ = other.partLocalTextId_;
		type_ = other.type_;
		useCostume_ = other.useCostume_;
		weakDmgValue_ = other.weakDmgValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntPartsTable Clone()
	{
		return new MonsterHuntPartsTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntPartsTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntPartsTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BossBodyPosition == other.BossBodyPosition && !(BossPartIcon1 != other.BossPartIcon1) && !(BossPartIcon2 != other.BossPartIcon2) && ConditionId == other.ConditionId && GroupId == other.GroupId && Id == other.Id && ParentCharId == other.ParentCharId && PartLocalTextId == other.PartLocalTextId && Type == other.Type && UseCostume == other.UseCostume && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(WeakDmgValue, other.WeakDmgValue))
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
		if (BossBodyPosition != 0)
		{
			num ^= BossBodyPosition.GetHashCode();
		}
		if (BossPartIcon1.Length != 0)
		{
			num ^= BossPartIcon1.GetHashCode();
		}
		if (BossPartIcon2.Length != 0)
		{
			num ^= BossPartIcon2.GetHashCode();
		}
		if (ConditionId != 0)
		{
			num ^= ConditionId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ParentCharId != 0)
		{
			num ^= ParentCharId.GetHashCode();
		}
		if (PartLocalTextId != 0)
		{
			num ^= PartLocalTextId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (UseCostume != 0)
		{
			num ^= UseCostume.GetHashCode();
		}
		if (WeakDmgValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(WeakDmgValue);
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
		if (BossBodyPosition != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BossBodyPosition);
		}
		if (BossPartIcon1.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BossPartIcon1);
		}
		if (BossPartIcon2.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BossPartIcon2);
		}
		if (ConditionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ConditionId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (ParentCharId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ParentCharId);
		}
		if (PartLocalTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PartLocalTextId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Type);
		}
		if (UseCostume != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(UseCostume);
		}
		if (WeakDmgValue != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(WeakDmgValue);
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
		if (BossBodyPosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossBodyPosition);
		}
		if (BossPartIcon1.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BossPartIcon1);
		}
		if (BossPartIcon2.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BossPartIcon2);
		}
		if (ConditionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ParentCharId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ParentCharId);
		}
		if (PartLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PartLocalTextId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (UseCostume != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseCostume);
		}
		if (WeakDmgValue != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntPartsTable other)
	{
		if (other != null)
		{
			if (other.BossBodyPosition != 0)
			{
				BossBodyPosition = other.BossBodyPosition;
			}
			if (other.BossPartIcon1.Length != 0)
			{
				BossPartIcon1 = other.BossPartIcon1;
			}
			if (other.BossPartIcon2.Length != 0)
			{
				BossPartIcon2 = other.BossPartIcon2;
			}
			if (other.ConditionId != 0)
			{
				ConditionId = other.ConditionId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ParentCharId != 0)
			{
				ParentCharId = other.ParentCharId;
			}
			if (other.PartLocalTextId != 0)
			{
				PartLocalTextId = other.PartLocalTextId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.UseCostume != 0)
			{
				UseCostume = other.UseCostume;
			}
			if (other.WeakDmgValue != 0.0)
			{
				WeakDmgValue = other.WeakDmgValue;
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
				BossBodyPosition = input.ReadInt32();
				break;
			case 18u:
				BossPartIcon1 = input.ReadString();
				break;
			case 26u:
				BossPartIcon2 = input.ReadString();
				break;
			case 32u:
				ConditionId = input.ReadInt32();
				break;
			case 40u:
				GroupId = input.ReadInt32();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 56u:
				ParentCharId = input.ReadInt32();
				break;
			case 64u:
				PartLocalTextId = input.ReadInt32();
				break;
			case 72u:
				Type = input.ReadInt32();
				break;
			case 80u:
				UseCostume = input.ReadInt32();
				break;
			case 89u:
				WeakDmgValue = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
