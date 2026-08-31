using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CharTable : IMessage<CharTable>, IMessage, IEquatable<CharTable>, IDeepCloneable<CharTable>, IBufferMessage
{
	private static readonly MessageParser<CharTable> _parser = new MessageParser<CharTable>(() => new CharTable());

	private UnknownFieldSet _unknownFields;

	public const int CharGrowthIdFieldNumber = 1;

	private int charGrowthId_;

	public const int CharNameTextIdFieldNumber = 2;

	private int charNameTextId_;

	public const int CriticalChanceValueFieldNumber = 3;

	private double criticalChanceValue_;

	public const int CriticalDamageRateValueFieldNumber = 4;

	private double criticalDamageRateValue_;

	public const int DefaultCostumeIdFieldNumber = 5;

	private int defaultCostumeId_;

	public const int ElementFieldNumber = 6;

	private int element_;

	public const int ElementDefenseValueFieldNumber = 7;

	private double elementDefenseValue_;

	public const int ElementPowerValueFieldNumber = 8;

	private double elementPowerValue_;

	public const int GradeFieldNumber = 9;

	private int grade_;

	public const int GrowthgradeFieldNumber = 10;

	private int growthgrade_;

	public const int HealthValueFieldNumber = 11;

	private double healthValue_;

	public const int IdFieldNumber = 12;

	private int id_;

	public const int MagicDefenseValueFieldNumber = 13;

	private double magicDefenseValue_;

	public const int MagicPowerValueFieldNumber = 14;

	private double magicPowerValue_;

	public const int NextCharIdFieldNumber = 15;

	private int nextCharId_;

	public const int PhysicalDefenseValueFieldNumber = 16;

	private double physicalDefenseValue_;

	public const int PhysicalPowerValueFieldNumber = 17;

	private double physicalPowerValue_;

	public const int TalentIdFieldNumber = 18;

	private int talentId_;

	public const int TypeFieldNumber = 19;

	private int type_;

	public const int UniqueCharIdFieldNumber = 20;

	private int uniqueCharId_;

	public const int UsePackTemporaryFieldNumber = 21;

	private int usePackTemporary_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CharTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CharGrowthId
	{
		get
		{
			return charGrowthId_;
		}
		set
		{
			charGrowthId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CharNameTextId
	{
		get
		{
			return charNameTextId_;
		}
		set
		{
			charNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double CriticalChanceValue
	{
		get
		{
			return criticalChanceValue_;
		}
		set
		{
			criticalChanceValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double CriticalDamageRateValue
	{
		get
		{
			return criticalDamageRateValue_;
		}
		set
		{
			criticalDamageRateValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DefaultCostumeId
	{
		get
		{
			return defaultCostumeId_;
		}
		set
		{
			defaultCostumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Element
	{
		get
		{
			return element_;
		}
		set
		{
			element_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int Grade
	{
		get
		{
			return grade_;
		}
		set
		{
			grade_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Growthgrade
	{
		get
		{
			return growthgrade_;
		}
		set
		{
			growthgrade_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double HealthValue
	{
		get
		{
			return healthValue_;
		}
		set
		{
			healthValue_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double MagicDefenseValue
	{
		get
		{
			return magicDefenseValue_;
		}
		set
		{
			magicDefenseValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MagicPowerValue
	{
		get
		{
			return magicPowerValue_;
		}
		set
		{
			magicPowerValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NextCharId
	{
		get
		{
			return nextCharId_;
		}
		set
		{
			nextCharId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double PhysicalDefenseValue
	{
		get
		{
			return physicalDefenseValue_;
		}
		set
		{
			physicalDefenseValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double PhysicalPowerValue
	{
		get
		{
			return physicalPowerValue_;
		}
		set
		{
			physicalPowerValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TalentId
	{
		get
		{
			return talentId_;
		}
		set
		{
			talentId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int UniqueCharId
	{
		get
		{
			return uniqueCharId_;
		}
		set
		{
			uniqueCharId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UsePackTemporary
	{
		get
		{
			return usePackTemporary_;
		}
		set
		{
			usePackTemporary_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharTable(CharTable other)
		: this()
	{
		charGrowthId_ = other.charGrowthId_;
		charNameTextId_ = other.charNameTextId_;
		criticalChanceValue_ = other.criticalChanceValue_;
		criticalDamageRateValue_ = other.criticalDamageRateValue_;
		defaultCostumeId_ = other.defaultCostumeId_;
		element_ = other.element_;
		elementDefenseValue_ = other.elementDefenseValue_;
		elementPowerValue_ = other.elementPowerValue_;
		grade_ = other.grade_;
		growthgrade_ = other.growthgrade_;
		healthValue_ = other.healthValue_;
		id_ = other.id_;
		magicDefenseValue_ = other.magicDefenseValue_;
		magicPowerValue_ = other.magicPowerValue_;
		nextCharId_ = other.nextCharId_;
		physicalDefenseValue_ = other.physicalDefenseValue_;
		physicalPowerValue_ = other.physicalPowerValue_;
		talentId_ = other.talentId_;
		type_ = other.type_;
		uniqueCharId_ = other.uniqueCharId_;
		usePackTemporary_ = other.usePackTemporary_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharTable Clone()
	{
		return new CharTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CharTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CharGrowthId == other.CharGrowthId && CharNameTextId == other.CharNameTextId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriticalChanceValue, other.CriticalChanceValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriticalDamageRateValue, other.CriticalDamageRateValue) && DefaultCostumeId == other.DefaultCostumeId && Element == other.Element && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ElementDefenseValue, other.ElementDefenseValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ElementPowerValue, other.ElementPowerValue) && Grade == other.Grade && Growthgrade == other.Growthgrade && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HealthValue, other.HealthValue) && Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MagicDefenseValue, other.MagicDefenseValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MagicPowerValue, other.MagicPowerValue) && NextCharId == other.NextCharId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PhysicalDefenseValue, other.PhysicalDefenseValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PhysicalPowerValue, other.PhysicalPowerValue) && TalentId == other.TalentId && Type == other.Type && UniqueCharId == other.UniqueCharId && UsePackTemporary == other.UsePackTemporary)
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
		if (CharGrowthId != 0)
		{
			num ^= CharGrowthId.GetHashCode();
		}
		if (CharNameTextId != 0)
		{
			num ^= CharNameTextId.GetHashCode();
		}
		if (CriticalChanceValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriticalChanceValue);
		}
		if (CriticalDamageRateValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriticalDamageRateValue);
		}
		if (DefaultCostumeId != 0)
		{
			num ^= DefaultCostumeId.GetHashCode();
		}
		if (Element != 0)
		{
			num ^= Element.GetHashCode();
		}
		if (ElementDefenseValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ElementDefenseValue);
		}
		if (ElementPowerValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ElementPowerValue);
		}
		if (Grade != 0)
		{
			num ^= Grade.GetHashCode();
		}
		if (Growthgrade != 0)
		{
			num ^= Growthgrade.GetHashCode();
		}
		if (HealthValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HealthValue);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MagicDefenseValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MagicDefenseValue);
		}
		if (MagicPowerValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MagicPowerValue);
		}
		if (NextCharId != 0)
		{
			num ^= NextCharId.GetHashCode();
		}
		if (PhysicalDefenseValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PhysicalDefenseValue);
		}
		if (PhysicalPowerValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PhysicalPowerValue);
		}
		if (TalentId != 0)
		{
			num ^= TalentId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (UniqueCharId != 0)
		{
			num ^= UniqueCharId.GetHashCode();
		}
		if (UsePackTemporary != 0)
		{
			num ^= UsePackTemporary.GetHashCode();
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
		if (CharGrowthId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CharGrowthId);
		}
		if (CharNameTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CharNameTextId);
		}
		if (CriticalChanceValue != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(CriticalChanceValue);
		}
		if (CriticalDamageRateValue != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(CriticalDamageRateValue);
		}
		if (DefaultCostumeId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DefaultCostumeId);
		}
		if (Element != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Element);
		}
		if (ElementDefenseValue != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(ElementDefenseValue);
		}
		if (ElementPowerValue != 0.0)
		{
			output.WriteRawTag(65);
			output.WriteDouble(ElementPowerValue);
		}
		if (Grade != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Grade);
		}
		if (Growthgrade != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Growthgrade);
		}
		if (HealthValue != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(HealthValue);
		}
		if (Id != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Id);
		}
		if (MagicDefenseValue != 0.0)
		{
			output.WriteRawTag(105);
			output.WriteDouble(MagicDefenseValue);
		}
		if (MagicPowerValue != 0.0)
		{
			output.WriteRawTag(113);
			output.WriteDouble(MagicPowerValue);
		}
		if (NextCharId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(NextCharId);
		}
		if (PhysicalDefenseValue != 0.0)
		{
			output.WriteRawTag(129, 1);
			output.WriteDouble(PhysicalDefenseValue);
		}
		if (PhysicalPowerValue != 0.0)
		{
			output.WriteRawTag(137, 1);
			output.WriteDouble(PhysicalPowerValue);
		}
		if (TalentId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(TalentId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(Type);
		}
		if (UniqueCharId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(UniqueCharId);
		}
		if (UsePackTemporary != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(UsePackTemporary);
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
		if (CharGrowthId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharGrowthId);
		}
		if (CharNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharNameTextId);
		}
		if (CriticalChanceValue != 0.0)
		{
			num += 9;
		}
		if (CriticalDamageRateValue != 0.0)
		{
			num += 9;
		}
		if (DefaultCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultCostumeId);
		}
		if (Element != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Element);
		}
		if (ElementDefenseValue != 0.0)
		{
			num += 9;
		}
		if (ElementPowerValue != 0.0)
		{
			num += 9;
		}
		if (Grade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Grade);
		}
		if (Growthgrade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Growthgrade);
		}
		if (HealthValue != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MagicDefenseValue != 0.0)
		{
			num += 9;
		}
		if (MagicPowerValue != 0.0)
		{
			num += 9;
		}
		if (NextCharId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextCharId);
		}
		if (PhysicalDefenseValue != 0.0)
		{
			num += 10;
		}
		if (PhysicalPowerValue != 0.0)
		{
			num += 10;
		}
		if (TalentId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TalentId);
		}
		if (Type != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (UniqueCharId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UniqueCharId);
		}
		if (UsePackTemporary != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UsePackTemporary);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharTable other)
	{
		if (other != null)
		{
			if (other.CharGrowthId != 0)
			{
				CharGrowthId = other.CharGrowthId;
			}
			if (other.CharNameTextId != 0)
			{
				CharNameTextId = other.CharNameTextId;
			}
			if (other.CriticalChanceValue != 0.0)
			{
				CriticalChanceValue = other.CriticalChanceValue;
			}
			if (other.CriticalDamageRateValue != 0.0)
			{
				CriticalDamageRateValue = other.CriticalDamageRateValue;
			}
			if (other.DefaultCostumeId != 0)
			{
				DefaultCostumeId = other.DefaultCostumeId;
			}
			if (other.Element != 0)
			{
				Element = other.Element;
			}
			if (other.ElementDefenseValue != 0.0)
			{
				ElementDefenseValue = other.ElementDefenseValue;
			}
			if (other.ElementPowerValue != 0.0)
			{
				ElementPowerValue = other.ElementPowerValue;
			}
			if (other.Grade != 0)
			{
				Grade = other.Grade;
			}
			if (other.Growthgrade != 0)
			{
				Growthgrade = other.Growthgrade;
			}
			if (other.HealthValue != 0.0)
			{
				HealthValue = other.HealthValue;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MagicDefenseValue != 0.0)
			{
				MagicDefenseValue = other.MagicDefenseValue;
			}
			if (other.MagicPowerValue != 0.0)
			{
				MagicPowerValue = other.MagicPowerValue;
			}
			if (other.NextCharId != 0)
			{
				NextCharId = other.NextCharId;
			}
			if (other.PhysicalDefenseValue != 0.0)
			{
				PhysicalDefenseValue = other.PhysicalDefenseValue;
			}
			if (other.PhysicalPowerValue != 0.0)
			{
				PhysicalPowerValue = other.PhysicalPowerValue;
			}
			if (other.TalentId != 0)
			{
				TalentId = other.TalentId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.UniqueCharId != 0)
			{
				UniqueCharId = other.UniqueCharId;
			}
			if (other.UsePackTemporary != 0)
			{
				UsePackTemporary = other.UsePackTemporary;
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
				CharGrowthId = input.ReadInt32();
				break;
			case 16u:
				CharNameTextId = input.ReadInt32();
				break;
			case 25u:
				CriticalChanceValue = input.ReadDouble();
				break;
			case 33u:
				CriticalDamageRateValue = input.ReadDouble();
				break;
			case 40u:
				DefaultCostumeId = input.ReadInt32();
				break;
			case 48u:
				Element = input.ReadInt32();
				break;
			case 57u:
				ElementDefenseValue = input.ReadDouble();
				break;
			case 65u:
				ElementPowerValue = input.ReadDouble();
				break;
			case 72u:
				Grade = input.ReadInt32();
				break;
			case 80u:
				Growthgrade = input.ReadInt32();
				break;
			case 89u:
				HealthValue = input.ReadDouble();
				break;
			case 96u:
				Id = input.ReadInt32();
				break;
			case 105u:
				MagicDefenseValue = input.ReadDouble();
				break;
			case 113u:
				MagicPowerValue = input.ReadDouble();
				break;
			case 120u:
				NextCharId = input.ReadInt32();
				break;
			case 129u:
				PhysicalDefenseValue = input.ReadDouble();
				break;
			case 137u:
				PhysicalPowerValue = input.ReadDouble();
				break;
			case 144u:
				TalentId = input.ReadInt32();
				break;
			case 152u:
				Type = input.ReadInt32();
				break;
			case 160u:
				UniqueCharId = input.ReadInt32();
				break;
			case 168u:
				UsePackTemporary = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
