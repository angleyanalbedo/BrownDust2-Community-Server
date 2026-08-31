using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CashProductTable : IMessage<CashProductTable>, IMessage, IEquatable<CashProductTable>, IDeepCloneable<CashProductTable>, IBufferMessage
{
	private static readonly MessageParser<CashProductTable> _parser = new MessageParser<CashProductTable>(() => new CashProductTable());

	private UnknownFieldSet _unknownFields;

	public const int AppleInAppIdFieldNumber = 1;

	private string appleInAppId_ = "";

	public const int BonusRandomboxIdFieldNumber = 2;

	private int bonusRandomboxId_;

	public const int GoogleInAppIdFieldNumber = 3;

	private string googleInAppId_ = "";

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int PriceCountFieldNumber = 6;

	private int priceCount_;

	public const int PriceIdFieldNumber = 7;

	private int priceId_;

	public const int PriceTypeFieldNumber = 8;

	private int priceType_;

	public const int PriorityFieldNumber = 9;

	private int priority_;

	public const int ProductLocalTextIdFieldNumber = 10;

	private int productLocalTextId_;

	public const int PurchaseLimitCountFieldNumber = 11;

	private int purchaseLimitCount_;

	public const int PurchaseLimitTypeFieldNumber = 12;

	private int purchaseLimitType_;

	public const int RandomboxIdFieldNumber = 13;

	private int randomboxId_;

	public const int SaleGroupFieldNumber = 14;

	private int saleGroup_;

	public const int TimeLimitTypeFieldNumber = 15;

	private int timeLimitType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CashProductTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CashProductTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AppleInAppId
	{
		get
		{
			return appleInAppId_;
		}
		set
		{
			appleInAppId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BonusRandomboxId
	{
		get
		{
			return bonusRandomboxId_;
		}
		set
		{
			bonusRandomboxId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GoogleInAppId
	{
		get
		{
			return googleInAppId_;
		}
		set
		{
			googleInAppId_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ProductLocalTextId
	{
		get
		{
			return productLocalTextId_;
		}
		set
		{
			productLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PurchaseLimitCount
	{
		get
		{
			return purchaseLimitCount_;
		}
		set
		{
			purchaseLimitCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PurchaseLimitType
	{
		get
		{
			return purchaseLimitType_;
		}
		set
		{
			purchaseLimitType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RandomboxId
	{
		get
		{
			return randomboxId_;
		}
		set
		{
			randomboxId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SaleGroup
	{
		get
		{
			return saleGroup_;
		}
		set
		{
			saleGroup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TimeLimitType
	{
		get
		{
			return timeLimitType_;
		}
		set
		{
			timeLimitType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashProductTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashProductTable(CashProductTable other)
		: this()
	{
		appleInAppId_ = other.appleInAppId_;
		bonusRandomboxId_ = other.bonusRandomboxId_;
		googleInAppId_ = other.googleInAppId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		priceCount_ = other.priceCount_;
		priceId_ = other.priceId_;
		priceType_ = other.priceType_;
		priority_ = other.priority_;
		productLocalTextId_ = other.productLocalTextId_;
		purchaseLimitCount_ = other.purchaseLimitCount_;
		purchaseLimitType_ = other.purchaseLimitType_;
		randomboxId_ = other.randomboxId_;
		saleGroup_ = other.saleGroup_;
		timeLimitType_ = other.timeLimitType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashProductTable Clone()
	{
		return new CashProductTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CashProductTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CashProductTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(AppleInAppId != other.AppleInAppId) && BonusRandomboxId == other.BonusRandomboxId && !(GoogleInAppId != other.GoogleInAppId) && GroupId == other.GroupId && Id == other.Id && PriceCount == other.PriceCount && PriceId == other.PriceId && PriceType == other.PriceType && Priority == other.Priority && ProductLocalTextId == other.ProductLocalTextId && PurchaseLimitCount == other.PurchaseLimitCount && PurchaseLimitType == other.PurchaseLimitType && RandomboxId == other.RandomboxId && SaleGroup == other.SaleGroup && TimeLimitType == other.TimeLimitType)
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
		if (AppleInAppId.Length != 0)
		{
			num ^= AppleInAppId.GetHashCode();
		}
		if (BonusRandomboxId != 0)
		{
			num ^= BonusRandomboxId.GetHashCode();
		}
		if (GoogleInAppId.Length != 0)
		{
			num ^= GoogleInAppId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
		}
		if (ProductLocalTextId != 0)
		{
			num ^= ProductLocalTextId.GetHashCode();
		}
		if (PurchaseLimitCount != 0)
		{
			num ^= PurchaseLimitCount.GetHashCode();
		}
		if (PurchaseLimitType != 0)
		{
			num ^= PurchaseLimitType.GetHashCode();
		}
		if (RandomboxId != 0)
		{
			num ^= RandomboxId.GetHashCode();
		}
		if (SaleGroup != 0)
		{
			num ^= SaleGroup.GetHashCode();
		}
		if (TimeLimitType != 0)
		{
			num ^= TimeLimitType.GetHashCode();
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
		if (AppleInAppId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AppleInAppId);
		}
		if (BonusRandomboxId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BonusRandomboxId);
		}
		if (GoogleInAppId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(GoogleInAppId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (PriceCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PriceCount);
		}
		if (PriceId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(PriceId);
		}
		if (PriceType != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PriceType);
		}
		if (Priority != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Priority);
		}
		if (ProductLocalTextId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ProductLocalTextId);
		}
		if (PurchaseLimitCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(PurchaseLimitCount);
		}
		if (PurchaseLimitType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(PurchaseLimitType);
		}
		if (RandomboxId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(RandomboxId);
		}
		if (SaleGroup != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(SaleGroup);
		}
		if (TimeLimitType != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(TimeLimitType);
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
		if (AppleInAppId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AppleInAppId);
		}
		if (BonusRandomboxId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BonusRandomboxId);
		}
		if (GoogleInAppId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GoogleInAppId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
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
		if (Priority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Priority);
		}
		if (ProductLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProductLocalTextId);
		}
		if (PurchaseLimitCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PurchaseLimitCount);
		}
		if (PurchaseLimitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PurchaseLimitType);
		}
		if (RandomboxId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RandomboxId);
		}
		if (SaleGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SaleGroup);
		}
		if (TimeLimitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TimeLimitType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CashProductTable other)
	{
		if (other != null)
		{
			if (other.AppleInAppId.Length != 0)
			{
				AppleInAppId = other.AppleInAppId;
			}
			if (other.BonusRandomboxId != 0)
			{
				BonusRandomboxId = other.BonusRandomboxId;
			}
			if (other.GoogleInAppId.Length != 0)
			{
				GoogleInAppId = other.GoogleInAppId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			if (other.Priority != 0)
			{
				Priority = other.Priority;
			}
			if (other.ProductLocalTextId != 0)
			{
				ProductLocalTextId = other.ProductLocalTextId;
			}
			if (other.PurchaseLimitCount != 0)
			{
				PurchaseLimitCount = other.PurchaseLimitCount;
			}
			if (other.PurchaseLimitType != 0)
			{
				PurchaseLimitType = other.PurchaseLimitType;
			}
			if (other.RandomboxId != 0)
			{
				RandomboxId = other.RandomboxId;
			}
			if (other.SaleGroup != 0)
			{
				SaleGroup = other.SaleGroup;
			}
			if (other.TimeLimitType != 0)
			{
				TimeLimitType = other.TimeLimitType;
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
			case 10u:
				AppleInAppId = input.ReadString();
				break;
			case 16u:
				BonusRandomboxId = input.ReadInt32();
				break;
			case 26u:
				GoogleInAppId = input.ReadString();
				break;
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				PriceCount = input.ReadInt32();
				break;
			case 56u:
				PriceId = input.ReadInt32();
				break;
			case 64u:
				PriceType = input.ReadInt32();
				break;
			case 72u:
				Priority = input.ReadInt32();
				break;
			case 80u:
				ProductLocalTextId = input.ReadInt32();
				break;
			case 88u:
				PurchaseLimitCount = input.ReadInt32();
				break;
			case 96u:
				PurchaseLimitType = input.ReadInt32();
				break;
			case 104u:
				RandomboxId = input.ReadInt32();
				break;
			case 112u:
				SaleGroup = input.ReadInt32();
				break;
			case 120u:
				TimeLimitType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
