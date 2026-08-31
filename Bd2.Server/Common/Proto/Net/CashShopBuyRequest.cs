using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CashShopBuyRequest : IMessage<CashShopBuyRequest>, IMessage, IEquatable<CashShopBuyRequest>, IDeepCloneable<CashShopBuyRequest>, IBufferMessage
{
	private static readonly MessageParser<CashShopBuyRequest> _parser = new MessageParser<CashShopBuyRequest>(() => new CashShopBuyRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int ProductIdFieldNumber = 3;

	private int productId_;

	public const int SaleGroupFieldNumber = 4;

	private int saleGroup_;

	public const int PayIdFieldNumber = 5;

	private string payId_ = "";

	public const int PurchaseReceiptFieldNumber = 6;

	private string purchaseReceipt_ = "";

	public const int EnvInfoFieldNumber = 7;

	private EnvInfo envInfo_;

	public const int PriceInfoFieldNumber = 8;

	private PriceInfo priceInfo_;

	public const int UseItemInfoFieldNumber = 9;

	private static readonly FieldCodec<ItemDBInfo> _repeated_useItemInfo_codec = FieldCodec.ForMessage(74u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> useItemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int BuyCountFieldNumber = 10;

	private int buyCount_;

	public const int EventScheduleIdFieldNumber = 11;

	private int eventScheduleId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CashShopBuyRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CashShopBuyRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
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
	public int ProductId
	{
		get
		{
			return productId_;
		}
		set
		{
			productId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public string PayId
	{
		get
		{
			return payId_;
		}
		set
		{
			payId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PurchaseReceipt
	{
		get
		{
			return purchaseReceipt_;
		}
		set
		{
			purchaseReceipt_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EnvInfo EnvInfo
	{
		get
		{
			return envInfo_;
		}
		set
		{
			envInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PriceInfo PriceInfo
	{
		get
		{
			return priceInfo_;
		}
		set
		{
			priceInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> UseItemInfo => useItemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuyCount
	{
		get
		{
			return buyCount_;
		}
		set
		{
			buyCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventScheduleId
	{
		get
		{
			return eventScheduleId_;
		}
		set
		{
			eventScheduleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashShopBuyRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashShopBuyRequest(CashShopBuyRequest other)
		: this()
	{
		seq_ = other.seq_;
		groupId_ = other.groupId_;
		productId_ = other.productId_;
		saleGroup_ = other.saleGroup_;
		payId_ = other.payId_;
		purchaseReceipt_ = other.purchaseReceipt_;
		envInfo_ = ((other.envInfo_ != null) ? other.envInfo_.Clone() : null);
		priceInfo_ = ((other.priceInfo_ != null) ? other.priceInfo_.Clone() : null);
		useItemInfo_ = other.useItemInfo_.Clone();
		buyCount_ = other.buyCount_;
		eventScheduleId_ = other.eventScheduleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashShopBuyRequest Clone()
	{
		return new CashShopBuyRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CashShopBuyRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CashShopBuyRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && GroupId == other.GroupId && ProductId == other.ProductId && SaleGroup == other.SaleGroup && !(PayId != other.PayId) && !(PurchaseReceipt != other.PurchaseReceipt) && object.Equals(EnvInfo, other.EnvInfo) && object.Equals(PriceInfo, other.PriceInfo) && useItemInfo_.Equals(other.useItemInfo_) && BuyCount == other.BuyCount && EventScheduleId == other.EventScheduleId)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (ProductId != 0)
		{
			num ^= ProductId.GetHashCode();
		}
		if (SaleGroup != 0)
		{
			num ^= SaleGroup.GetHashCode();
		}
		if (PayId.Length != 0)
		{
			num ^= PayId.GetHashCode();
		}
		if (PurchaseReceipt.Length != 0)
		{
			num ^= PurchaseReceipt.GetHashCode();
		}
		if (envInfo_ != null)
		{
			num ^= EnvInfo.GetHashCode();
		}
		if (priceInfo_ != null)
		{
			num ^= PriceInfo.GetHashCode();
		}
		num ^= useItemInfo_.GetHashCode();
		if (BuyCount != 0)
		{
			num ^= BuyCount.GetHashCode();
		}
		if (EventScheduleId != 0)
		{
			num ^= EventScheduleId.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (ProductId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ProductId);
		}
		if (SaleGroup != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SaleGroup);
		}
		if (PayId.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PayId);
		}
		if (PurchaseReceipt.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(PurchaseReceipt);
		}
		if (envInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(EnvInfo);
		}
		if (priceInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(PriceInfo);
		}
		useItemInfo_.WriteTo(ref output, _repeated_useItemInfo_codec);
		if (BuyCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(BuyCount);
		}
		if (EventScheduleId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(EventScheduleId);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (ProductId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProductId);
		}
		if (SaleGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SaleGroup);
		}
		if (PayId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PayId);
		}
		if (PurchaseReceipt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PurchaseReceipt);
		}
		if (envInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnvInfo);
		}
		if (priceInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PriceInfo);
		}
		num += useItemInfo_.CalculateSize(_repeated_useItemInfo_codec);
		if (BuyCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyCount);
		}
		if (EventScheduleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventScheduleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CashShopBuyRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Seq != 0)
		{
			Seq = other.Seq;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.ProductId != 0)
		{
			ProductId = other.ProductId;
		}
		if (other.SaleGroup != 0)
		{
			SaleGroup = other.SaleGroup;
		}
		if (other.PayId.Length != 0)
		{
			PayId = other.PayId;
		}
		if (other.PurchaseReceipt.Length != 0)
		{
			PurchaseReceipt = other.PurchaseReceipt;
		}
		if (other.envInfo_ != null)
		{
			if (envInfo_ == null)
			{
				EnvInfo = new EnvInfo();
			}
			EnvInfo.MergeFrom(other.EnvInfo);
		}
		if (other.priceInfo_ != null)
		{
			if (priceInfo_ == null)
			{
				PriceInfo = new PriceInfo();
			}
			PriceInfo.MergeFrom(other.PriceInfo);
		}
		useItemInfo_.Add(other.useItemInfo_);
		if (other.BuyCount != 0)
		{
			BuyCount = other.BuyCount;
		}
		if (other.EventScheduleId != 0)
		{
			EventScheduleId = other.EventScheduleId;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				ProductId = input.ReadInt32();
				break;
			case 32u:
				SaleGroup = input.ReadInt32();
				break;
			case 42u:
				PayId = input.ReadString();
				break;
			case 50u:
				PurchaseReceipt = input.ReadString();
				break;
			case 58u:
				if (envInfo_ == null)
				{
					EnvInfo = new EnvInfo();
				}
				input.ReadMessage(EnvInfo);
				break;
			case 66u:
				if (priceInfo_ == null)
				{
					PriceInfo = new PriceInfo();
				}
				input.ReadMessage(PriceInfo);
				break;
			case 74u:
				useItemInfo_.AddEntriesFrom(ref input, _repeated_useItemInfo_codec);
				break;
			case 80u:
				BuyCount = input.ReadInt32();
				break;
			case 88u:
				EventScheduleId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
