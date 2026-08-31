using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ServerBattleCharStat : IMessage<ServerBattleCharStat>, IMessage, IEquatable<ServerBattleCharStat>, IDeepCloneable<ServerBattleCharStat>, IBufferMessage
{
	private static readonly MessageParser<ServerBattleCharStat> _parser = new MessageParser<ServerBattleCharStat>(() => new ServerBattleCharStat());

	private UnknownFieldSet _unknownFields;

	public const int MaxHealthFieldNumber = 1;

	private double maxHealth_;

	public const int CurrentHealthFieldNumber = 2;

	private double currentHealth_;

	public const int AgilityValueFieldNumber = 3;

	private double agilityValue_;

	public const int PhysicalPowerValueFieldNumber = 4;

	private double physicalPowerValue_;

	public const int MagicPowerValueFieldNumber = 5;

	private double magicPowerValue_;

	public const int PhysicalDefenseValueFieldNumber = 6;

	private double physicalDefenseValue_;

	public const int MagicDefenseValueFieldNumber = 7;

	private double magicDefenseValue_;

	public const int CriticalChanceValueFieldNumber = 8;

	private double criticalChanceValue_;

	public const int CriticalDamageRateValueFieldNumber = 9;

	private double criticalDamageRateValue_;

	public const int ElementDamageValueFieldNumber = 10;

	private double elementDamageValue_;

	public const int ElementResistanceValueFieldNumber = 11;

	private double elementResistanceValue_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ServerBattleCharStat> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuffListInfoReflection.Descriptor.MessageTypes[7];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MaxHealth
	{
		get
		{
			return maxHealth_;
		}
		set
		{
			maxHealth_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double CurrentHealth
	{
		get
		{
			return currentHealth_;
		}
		set
		{
			currentHealth_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double AgilityValue
	{
		get
		{
			return agilityValue_;
		}
		set
		{
			agilityValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public double ElementDamageValue
	{
		get
		{
			return elementDamageValue_;
		}
		set
		{
			elementDamageValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ElementResistanceValue
	{
		get
		{
			return elementResistanceValue_;
		}
		set
		{
			elementResistanceValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerBattleCharStat()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerBattleCharStat(ServerBattleCharStat other)
		: this()
	{
		maxHealth_ = other.maxHealth_;
		currentHealth_ = other.currentHealth_;
		agilityValue_ = other.agilityValue_;
		physicalPowerValue_ = other.physicalPowerValue_;
		magicPowerValue_ = other.magicPowerValue_;
		physicalDefenseValue_ = other.physicalDefenseValue_;
		magicDefenseValue_ = other.magicDefenseValue_;
		criticalChanceValue_ = other.criticalChanceValue_;
		criticalDamageRateValue_ = other.criticalDamageRateValue_;
		elementDamageValue_ = other.elementDamageValue_;
		elementResistanceValue_ = other.elementResistanceValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerBattleCharStat Clone()
	{
		return new ServerBattleCharStat(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ServerBattleCharStat);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerBattleCharStat other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxHealth, other.MaxHealth) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CurrentHealth, other.CurrentHealth) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AgilityValue, other.AgilityValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PhysicalPowerValue, other.PhysicalPowerValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MagicPowerValue, other.MagicPowerValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PhysicalDefenseValue, other.PhysicalDefenseValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MagicDefenseValue, other.MagicDefenseValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriticalChanceValue, other.CriticalChanceValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriticalDamageRateValue, other.CriticalDamageRateValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ElementDamageValue, other.ElementDamageValue) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ElementResistanceValue, other.ElementResistanceValue))
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
		if (MaxHealth != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxHealth);
		}
		if (CurrentHealth != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CurrentHealth);
		}
		if (AgilityValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AgilityValue);
		}
		if (PhysicalPowerValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PhysicalPowerValue);
		}
		if (MagicPowerValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MagicPowerValue);
		}
		if (PhysicalDefenseValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PhysicalDefenseValue);
		}
		if (MagicDefenseValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MagicDefenseValue);
		}
		if (CriticalChanceValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriticalChanceValue);
		}
		if (CriticalDamageRateValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriticalDamageRateValue);
		}
		if (ElementDamageValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ElementDamageValue);
		}
		if (ElementResistanceValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ElementResistanceValue);
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
		if (MaxHealth != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(MaxHealth);
		}
		if (CurrentHealth != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(CurrentHealth);
		}
		if (AgilityValue != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(AgilityValue);
		}
		if (PhysicalPowerValue != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(PhysicalPowerValue);
		}
		if (MagicPowerValue != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(MagicPowerValue);
		}
		if (PhysicalDefenseValue != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(PhysicalDefenseValue);
		}
		if (MagicDefenseValue != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(MagicDefenseValue);
		}
		if (CriticalChanceValue != 0.0)
		{
			output.WriteRawTag(65);
			output.WriteDouble(CriticalChanceValue);
		}
		if (CriticalDamageRateValue != 0.0)
		{
			output.WriteRawTag(73);
			output.WriteDouble(CriticalDamageRateValue);
		}
		if (ElementDamageValue != 0.0)
		{
			output.WriteRawTag(81);
			output.WriteDouble(ElementDamageValue);
		}
		if (ElementResistanceValue != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(ElementResistanceValue);
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
		if (MaxHealth != 0.0)
		{
			num += 9;
		}
		if (CurrentHealth != 0.0)
		{
			num += 9;
		}
		if (AgilityValue != 0.0)
		{
			num += 9;
		}
		if (PhysicalPowerValue != 0.0)
		{
			num += 9;
		}
		if (MagicPowerValue != 0.0)
		{
			num += 9;
		}
		if (PhysicalDefenseValue != 0.0)
		{
			num += 9;
		}
		if (MagicDefenseValue != 0.0)
		{
			num += 9;
		}
		if (CriticalChanceValue != 0.0)
		{
			num += 9;
		}
		if (CriticalDamageRateValue != 0.0)
		{
			num += 9;
		}
		if (ElementDamageValue != 0.0)
		{
			num += 9;
		}
		if (ElementResistanceValue != 0.0)
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
	public void MergeFrom(ServerBattleCharStat other)
	{
		if (other != null)
		{
			if (other.MaxHealth != 0.0)
			{
				MaxHealth = other.MaxHealth;
			}
			if (other.CurrentHealth != 0.0)
			{
				CurrentHealth = other.CurrentHealth;
			}
			if (other.AgilityValue != 0.0)
			{
				AgilityValue = other.AgilityValue;
			}
			if (other.PhysicalPowerValue != 0.0)
			{
				PhysicalPowerValue = other.PhysicalPowerValue;
			}
			if (other.MagicPowerValue != 0.0)
			{
				MagicPowerValue = other.MagicPowerValue;
			}
			if (other.PhysicalDefenseValue != 0.0)
			{
				PhysicalDefenseValue = other.PhysicalDefenseValue;
			}
			if (other.MagicDefenseValue != 0.0)
			{
				MagicDefenseValue = other.MagicDefenseValue;
			}
			if (other.CriticalChanceValue != 0.0)
			{
				CriticalChanceValue = other.CriticalChanceValue;
			}
			if (other.CriticalDamageRateValue != 0.0)
			{
				CriticalDamageRateValue = other.CriticalDamageRateValue;
			}
			if (other.ElementDamageValue != 0.0)
			{
				ElementDamageValue = other.ElementDamageValue;
			}
			if (other.ElementResistanceValue != 0.0)
			{
				ElementResistanceValue = other.ElementResistanceValue;
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
			case 9u:
				MaxHealth = input.ReadDouble();
				break;
			case 17u:
				CurrentHealth = input.ReadDouble();
				break;
			case 25u:
				AgilityValue = input.ReadDouble();
				break;
			case 33u:
				PhysicalPowerValue = input.ReadDouble();
				break;
			case 41u:
				MagicPowerValue = input.ReadDouble();
				break;
			case 49u:
				PhysicalDefenseValue = input.ReadDouble();
				break;
			case 57u:
				MagicDefenseValue = input.ReadDouble();
				break;
			case 65u:
				CriticalChanceValue = input.ReadDouble();
				break;
			case 73u:
				CriticalDamageRateValue = input.ReadDouble();
				break;
			case 81u:
				ElementDamageValue = input.ReadDouble();
				break;
			case 89u:
				ElementResistanceValue = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
