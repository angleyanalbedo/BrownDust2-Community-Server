using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SellItemTable : IMessage<SellItemTable>, IMessage, IEquatable<SellItemTable>, IDeepCloneable<SellItemTable>, IBufferMessage
{
	private static readonly MessageParser<SellItemTable> _parser = new MessageParser<SellItemTable>(() => new SellItemTable());

	private UnknownFieldSet _unknownFields;

	public const int DiscountRateFieldNumber = 1;

	private int discountRate_;

	public const int ElementCountFieldNumber = 2;

	private int elementCount_;

	public const int ElementIdFieldNumber = 3;

	private int elementId_;

	public const int ElementTypeFieldNumber = 4;

	private int elementType_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int PremiumRateFieldNumber = 6;

	private int premiumRate_;

	public const int PriceCountFieldNumber = 7;

	private int priceCount_;

	public const int PriceIdFieldNumber = 8;

	private int priceId_;

	public const int PriceTypeFieldNumber = 9;

	private int priceType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SellItemTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SellItemTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DiscountRate
	{
		get
		{
			return discountRate_;
		}
		set
		{
			discountRate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ElementCount
	{
		get
		{
			return elementCount_;
		}
		set
		{
			elementCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ElementId
	{
		get
		{
			return elementId_;
		}
		set
		{
			elementId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ElementType
	{
		get
		{
			return elementType_;
		}
		set
		{
			elementType_ = value;
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
	public int PremiumRate
	{
		get
		{
			return premiumRate_;
		}
		set
		{
			premiumRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PriceCount
	{
		get
		{
			return priceCount_;
		}
		set
		{
			priceCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PriceId
	{
		get
		{
			return priceId_;
		}
		set
		{
			priceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PriceType
	{
		get
		{
			return priceType_;
		}
		set
		{
			priceType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SellItemTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SellItemTable(SellItemTable other)
		: this()
	{
		discountRate_ = other.discountRate_;
		elementCount_ = other.elementCount_;
		elementId_ = other.elementId_;
		elementType_ = other.elementType_;
		id_ = other.id_;
		premiumRate_ = other.premiumRate_;
		priceCount_ = other.priceCount_;
		priceId_ = other.priceId_;
		priceType_ = other.priceType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SellItemTable Clone()
	{
		return new SellItemTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SellItemTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SellItemTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DiscountRate == other.DiscountRate && ElementCount == other.ElementCount && ElementId == other.ElementId && ElementType == other.ElementType && Id == other.Id && PremiumRate == other.PremiumRate && PriceCount == other.PriceCount && PriceId == other.PriceId && PriceType == other.PriceType)
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
		if (DiscountRate != 0)
		{
			num ^= DiscountRate.GetHashCode();
		}
		if (ElementCount != 0)
		{
			num ^= ElementCount.GetHashCode();
		}
		if (ElementId != 0)
		{
			num ^= ElementId.GetHashCode();
		}
		if (ElementType != 0)
		{
			num ^= ElementType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PremiumRate != 0)
		{
			num ^= PremiumRate.GetHashCode();
		}
		if (PriceCount != 0)
		{
			num ^= PriceCount.GetHashCode();
		}
		if (PriceId != 0)
		{
			num ^= PriceId.GetHashCode();
		}
		if (PriceType != 0)
		{
			num ^= PriceType.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (DiscountRate != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DiscountRate);
		}
		if (ElementCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ElementCount);
		}
		if (ElementId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ElementId);
		}
		if (ElementType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ElementType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (PremiumRate != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PremiumRate);
		}
		if (PriceCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(PriceCount);
		}
		if (PriceId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PriceId);
		}
		if (PriceType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PriceType);
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
		if (DiscountRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DiscountRate);
		}
		if (ElementCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ElementCount);
		}
		if (ElementId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ElementId);
		}
		if (ElementType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ElementType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PremiumRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PremiumRate);
		}
		if (PriceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceCount);
		}
		if (PriceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceId);
		}
		if (PriceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SellItemTable other)
	{
		if (other != null)
		{
			if (other.DiscountRate != 0)
			{
				DiscountRate = other.DiscountRate;
			}
			if (other.ElementCount != 0)
			{
				ElementCount = other.ElementCount;
			}
			if (other.ElementId != 0)
			{
				ElementId = other.ElementId;
			}
			if (other.ElementType != 0)
			{
				ElementType = other.ElementType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PremiumRate != 0)
			{
				PremiumRate = other.PremiumRate;
			}
			if (other.PriceCount != 0)
			{
				PriceCount = other.PriceCount;
			}
			if (other.PriceId != 0)
			{
				PriceId = other.PriceId;
			}
			if (other.PriceType != 0)
			{
				PriceType = other.PriceType;
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
				DiscountRate = input.ReadInt32();
				break;
			case 16u:
				ElementCount = input.ReadInt32();
				break;
			case 24u:
				ElementId = input.ReadInt32();
				break;
			case 32u:
				ElementType = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				PremiumRate = input.ReadInt32();
				break;
			case 56u:
				PriceCount = input.ReadInt32();
				break;
			case 64u:
				PriceId = input.ReadInt32();
				break;
			case 72u:
				PriceType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
