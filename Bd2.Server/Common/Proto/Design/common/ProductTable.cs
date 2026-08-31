using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ProductTable : IMessage<ProductTable>, IMessage, IEquatable<ProductTable>, IDeepCloneable<ProductTable>, IBufferMessage
{
	private static readonly MessageParser<ProductTable> _parser = new MessageParser<ProductTable>(() => new ProductTable());

	private UnknownFieldSet _unknownFields;

	public const int BuyMaxCountFieldNumber = 1;

	private int buyMaxCount_;

	public const int DiscountRateFieldNumber = 2;

	private int discountRate_;

	public const int ElementCountFieldNumber = 3;

	private int elementCount_;

	public const int ElementIdFieldNumber = 4;

	private int elementId_;

	public const int ElementTypeFieldNumber = 5;

	private int elementType_;

	public const int GroupIdFieldNumber = 6;

	private int groupId_;

	public const int IdFieldNumber = 7;

	private int id_;

	public const int NoBargainFieldNumber = 8;

	private int noBargain_;

	public const int PremiumRateFieldNumber = 9;

	private int premiumRate_;

	public const int PriceCountFieldNumber = 10;

	private int priceCount_;

	public const int PriceIdFieldNumber = 11;

	private int priceId_;

	public const int PriceTypeFieldNumber = 12;

	private int priceType_;

	public const int ReputationTypeFieldNumber = 13;

	private int reputationType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ProductTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ProductTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuyMaxCount
	{
		get
		{
			return buyMaxCount_;
		}
		set
		{
			buyMaxCount_ = value;
		}
	}

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NoBargain
	{
		get
		{
			return noBargain_;
		}
		set
		{
			noBargain_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int ReputationType
	{
		get
		{
			return reputationType_;
		}
		set
		{
			reputationType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ProductTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ProductTable(ProductTable other)
		: this()
	{
		buyMaxCount_ = other.buyMaxCount_;
		discountRate_ = other.discountRate_;
		elementCount_ = other.elementCount_;
		elementId_ = other.elementId_;
		elementType_ = other.elementType_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		noBargain_ = other.noBargain_;
		premiumRate_ = other.premiumRate_;
		priceCount_ = other.priceCount_;
		priceId_ = other.priceId_;
		priceType_ = other.priceType_;
		reputationType_ = other.reputationType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ProductTable Clone()
	{
		return new ProductTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ProductTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ProductTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BuyMaxCount == other.BuyMaxCount && DiscountRate == other.DiscountRate && ElementCount == other.ElementCount && ElementId == other.ElementId && ElementType == other.ElementType && GroupId == other.GroupId && Id == other.Id && NoBargain == other.NoBargain && PremiumRate == other.PremiumRate && PriceCount == other.PriceCount && PriceId == other.PriceId && PriceType == other.PriceType && ReputationType == other.ReputationType)
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
		if (BuyMaxCount != 0)
		{
			num ^= BuyMaxCount.GetHashCode();
		}
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NoBargain != 0)
		{
			num ^= NoBargain.GetHashCode();
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
		if (ReputationType != 0)
		{
			num ^= ReputationType.GetHashCode();
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
		if (BuyMaxCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuyMaxCount);
		}
		if (DiscountRate != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DiscountRate);
		}
		if (ElementCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ElementCount);
		}
		if (ElementId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ElementId);
		}
		if (ElementType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ElementType);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		if (NoBargain != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(NoBargain);
		}
		if (PremiumRate != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PremiumRate);
		}
		if (PriceCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PriceCount);
		}
		if (PriceId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(PriceId);
		}
		if (PriceType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(PriceType);
		}
		if (ReputationType != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(ReputationType);
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
		if (BuyMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyMaxCount);
		}
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NoBargain != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NoBargain);
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
		if (ReputationType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReputationType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ProductTable other)
	{
		if (other != null)
		{
			if (other.BuyMaxCount != 0)
			{
				BuyMaxCount = other.BuyMaxCount;
			}
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
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NoBargain != 0)
			{
				NoBargain = other.NoBargain;
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
			if (other.ReputationType != 0)
			{
				ReputationType = other.ReputationType;
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
				BuyMaxCount = input.ReadInt32();
				break;
			case 16u:
				DiscountRate = input.ReadInt32();
				break;
			case 24u:
				ElementCount = input.ReadInt32();
				break;
			case 32u:
				ElementId = input.ReadInt32();
				break;
			case 40u:
				ElementType = input.ReadInt32();
				break;
			case 48u:
				GroupId = input.ReadInt32();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 64u:
				NoBargain = input.ReadInt32();
				break;
			case 72u:
				PremiumRate = input.ReadInt32();
				break;
			case 80u:
				PriceCount = input.ReadInt32();
				break;
			case 88u:
				PriceId = input.ReadInt32();
				break;
			case 96u:
				PriceType = input.ReadInt32();
				break;
			case 104u:
				ReputationType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
