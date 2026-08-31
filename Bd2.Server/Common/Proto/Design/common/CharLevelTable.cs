using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CharLevelTable : IMessage<CharLevelTable>, IMessage, IEquatable<CharLevelTable>, IDeepCloneable<CharLevelTable>, IBufferMessage
{
	private static readonly MessageParser<CharLevelTable> _parser = new MessageParser<CharLevelTable>(() => new CharLevelTable());

	private UnknownFieldSet _unknownFields;

	public const int CriticalChanceFieldNumber = 1;

	private double criticalChance_;

	public const int CriticalDamageRateFieldNumber = 2;

	private double criticalDamageRate_;

	public const int ElementDefenseValueFieldNumber = 3;

	private double elementDefenseValue_;

	public const int ElementPowerValueFieldNumber = 4;

	private double elementPowerValue_;

	public const int GroupIdFieldNumber = 5;

	private int groupId_;

	public const int HealthFieldNumber = 6;

	private double health_;

	public const int IdFieldNumber = 7;

	private int id_;

	public const int LevelupExpFieldNumber = 8;

	private int levelupExp_;

	public const int MagicDefenseFieldNumber = 9;

	private double magicDefense_;

	public const int MagicPowerFieldNumber = 10;

	private double magicPower_;

	public const int PhysicalDefenseFieldNumber = 11;

	private double physicalDefense_;

	public const int PhysicalPowerFieldNumber = 12;

	private double physicalPower_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharLevelTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CharLevelTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double CriticalChance
	{
		get
		{
			return criticalChance_;
		}
		set
		{
			criticalChance_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double CriticalDamageRate
	{
		get
		{
			return criticalDamageRate_;
		}
		set
		{
			criticalDamageRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ElementDefenseValue
	{
		get
		{
			return elementDefenseValue_;
		}
		set
		{
			elementDefenseValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ElementPowerValue
	{
		get
		{
			return elementPowerValue_;
		}
		set
		{
			elementPowerValue_ = value;
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
	public double Health
	{
		get
		{
			return health_;
		}
		set
		{
			health_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LevelupExp
	{
		get
		{
			return levelupExp_;
		}
		set
		{
			levelupExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MagicDefense
	{
		get
		{
			return magicDefense_;
		}
		set
		{
			magicDefense_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MagicPower
	{
		get
		{
			return magicPower_;
		}
		set
		{
			magicPower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double PhysicalDefense
	{
		get
		{
			return physicalDefense_;
		}
		set
		{
			physicalDefense_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double PhysicalPower
	{
		get
		{
			return physicalPower_;
		}
		set
		{
			physicalPower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharLevelTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharLevelTable(CharLevelTable other)
		: this()
	{
		criticalChance_ = other.criticalChance_;
		criticalDamageRate_ = other.criticalDamageRate_;
		elementDefenseValue_ = other.elementDefenseValue_;
		elementPowerValue_ = other.elementPowerValue_;
		groupId_ = other.groupId_;
		health_ = other.health_;
		id_ = other.id_;
		levelupExp_ = other.levelupExp_;
		magicDefense_ = other.magicDefense_;
		magicPower_ = other.magicPower_;
		physicalDefense_ = other.physicalDefense_;
		physicalPower_ = other.physicalPower_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharLevelTable Clone()
	{
		return new CharLevelTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharLevelTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharLevelTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriticalChance, other.CriticalChance) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriticalDamageRate, other.CriticalDamageRate) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ElementDefenseValue, other.ElementDefenseValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ElementPowerValue, other.ElementPowerValue) && GroupId == other.GroupId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Health, other.Health) && Id == other.Id && LevelupExp == other.LevelupExp && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MagicDefense, other.MagicDefense) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MagicPower, other.MagicPower) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PhysicalDefense, other.PhysicalDefense) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PhysicalPower, other.PhysicalPower))
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
		if (CriticalChance != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriticalChance);
		}
		if (CriticalDamageRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriticalDamageRate);
		}
		if (ElementDefenseValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ElementDefenseValue);
		}
		if (ElementPowerValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ElementPowerValue);
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Health != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Health);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LevelupExp != 0)
		{
			num ^= LevelupExp.GetHashCode();
		}
		if (MagicDefense != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MagicDefense);
		}
		if (MagicPower != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MagicPower);
		}
		if (PhysicalDefense != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PhysicalDefense);
		}
		if (PhysicalPower != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PhysicalPower);
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
		if (CriticalChance != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(CriticalChance);
		}
		if (CriticalDamageRate != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(CriticalDamageRate);
		}
		if (ElementDefenseValue != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(ElementDefenseValue);
		}
		if (ElementPowerValue != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(ElementPowerValue);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GroupId);
		}
		if (Health != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(Health);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		if (LevelupExp != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LevelupExp);
		}
		if (MagicDefense != 0.0)
		{
			output.WriteRawTag(73);
			output.WriteDouble(MagicDefense);
		}
		if (MagicPower != 0.0)
		{
			output.WriteRawTag(81);
			output.WriteDouble(MagicPower);
		}
		if (PhysicalDefense != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(PhysicalDefense);
		}
		if (PhysicalPower != 0.0)
		{
			output.WriteRawTag(97);
			output.WriteDouble(PhysicalPower);
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
		if (CriticalChance != 0.0)
		{
			num += 9;
		}
		if (CriticalDamageRate != 0.0)
		{
			num += 9;
		}
		if (ElementDefenseValue != 0.0)
		{
			num += 9;
		}
		if (ElementPowerValue != 0.0)
		{
			num += 9;
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Health != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LevelupExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelupExp);
		}
		if (MagicDefense != 0.0)
		{
			num += 9;
		}
		if (MagicPower != 0.0)
		{
			num += 9;
		}
		if (PhysicalDefense != 0.0)
		{
			num += 9;
		}
		if (PhysicalPower != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharLevelTable other)
	{
		if (other != null)
		{
			if (other.CriticalChance != 0.0)
			{
				CriticalChance = other.CriticalChance;
			}
			if (other.CriticalDamageRate != 0.0)
			{
				CriticalDamageRate = other.CriticalDamageRate;
			}
			if (other.ElementDefenseValue != 0.0)
			{
				ElementDefenseValue = other.ElementDefenseValue;
			}
			if (other.ElementPowerValue != 0.0)
			{
				ElementPowerValue = other.ElementPowerValue;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Health != 0.0)
			{
				Health = other.Health;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LevelupExp != 0)
			{
				LevelupExp = other.LevelupExp;
			}
			if (other.MagicDefense != 0.0)
			{
				MagicDefense = other.MagicDefense;
			}
			if (other.MagicPower != 0.0)
			{
				MagicPower = other.MagicPower;
			}
			if (other.PhysicalDefense != 0.0)
			{
				PhysicalDefense = other.PhysicalDefense;
			}
			if (other.PhysicalPower != 0.0)
			{
				PhysicalPower = other.PhysicalPower;
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
			case 9u:
				CriticalChance = input.ReadDouble();
				break;
			case 17u:
				CriticalDamageRate = input.ReadDouble();
				break;
			case 25u:
				ElementDefenseValue = input.ReadDouble();
				break;
			case 33u:
				ElementPowerValue = input.ReadDouble();
				break;
			case 40u:
				GroupId = input.ReadInt32();
				break;
			case 49u:
				Health = input.ReadDouble();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 64u:
				LevelupExp = input.ReadInt32();
				break;
			case 73u:
				MagicDefense = input.ReadDouble();
				break;
			case 81u:
				MagicPower = input.ReadDouble();
				break;
			case 89u:
				PhysicalDefense = input.ReadDouble();
				break;
			case 97u:
				PhysicalPower = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
