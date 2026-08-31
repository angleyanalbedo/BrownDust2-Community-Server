using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ShopBuyRequest : IMessage<ShopBuyRequest>, IMessage, IEquatable<ShopBuyRequest>, IDeepCloneable<ShopBuyRequest>, IBufferMessage
{
	private static readonly MessageParser<ShopBuyRequest> _parser = new MessageParser<ShopBuyRequest>(() => new ShopBuyRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int ShopIdFieldNumber = 2;

	private int shopId_;

	public const int ItemInfoFieldNumber = 3;

	private ShopItemDBInfo itemInfo_;

	public const int UseItemInfoFieldNumber = 4;

	private static readonly FieldCodec<ItemDBInfo> _repeated_useItemInfo_codec = FieldCodec.ForMessage(34u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> useItemInfo_ = new RepeatedField<ItemDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShopBuyRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ShopBuyRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopItemDBInfo ItemInfo
	{
		get
		{
			return itemInfo_;
		}
		set
		{
			itemInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> UseItemInfo => useItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShopBuyRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopBuyRequest(ShopBuyRequest other)
		: this()
	{
		seq_ = other.seq_;
		shopId_ = other.shopId_;
		itemInfo_ = ((other.itemInfo_ != null) ? other.itemInfo_.Clone() : null);
		useItemInfo_ = other.useItemInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopBuyRequest Clone()
	{
		return new ShopBuyRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ShopBuyRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShopBuyRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && ShopId == other.ShopId && object.Equals(ItemInfo, other.ItemInfo) && useItemInfo_.Equals(other.useItemInfo_))
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
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
		}
		if (itemInfo_ != null)
		{
			num ^= ItemInfo.GetHashCode();
		}
		num ^= useItemInfo_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (ShopId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ShopId);
		}
		if (itemInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ItemInfo);
		}
		useItemInfo_.WriteTo(ref output, _repeated_useItemInfo_codec);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopId);
		}
		if (itemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemInfo);
		}
		num += useItemInfo_.CalculateSize(_repeated_useItemInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShopBuyRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Seq != 0)
		{
			Seq = other.Seq;
		}
		if (other.ShopId != 0)
		{
			ShopId = other.ShopId;
		}
		if (other.itemInfo_ != null)
		{
			if (itemInfo_ == null)
			{
				ItemInfo = new ShopItemDBInfo();
			}
			ItemInfo.MergeFrom(other.ItemInfo);
		}
		useItemInfo_.Add(other.useItemInfo_);
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
				ShopId = input.ReadInt32();
				break;
			case 26u:
				if (itemInfo_ == null)
				{
					ItemInfo = new ShopItemDBInfo();
				}
				input.ReadMessage(ItemInfo);
				break;
			case 34u:
				useItemInfo_.AddEntriesFrom(ref input, _repeated_useItemInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
