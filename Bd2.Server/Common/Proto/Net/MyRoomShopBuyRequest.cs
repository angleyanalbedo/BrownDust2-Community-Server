using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MyRoomShopBuyRequest : IMessage<MyRoomShopBuyRequest>, IMessage, IEquatable<MyRoomShopBuyRequest>, IDeepCloneable<MyRoomShopBuyRequest>, IBufferMessage
{
	private static readonly MessageParser<MyRoomShopBuyRequest> _parser = new MessageParser<MyRoomShopBuyRequest>(() => new MyRoomShopBuyRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int ItemCountFieldNumber = 3;

	private int itemCount_;

	public const int UseItemInfoFieldNumber = 4;

	private static readonly FieldCodec<ItemDBInfo> _repeated_useItemInfo_codec = FieldCodec.ForMessage(34u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> useItemInfo_ = new RepeatedField<ItemDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomShopBuyRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MyRoomShopBuyRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int ItemCount
	{
		get
		{
			return itemCount_;
		}
		set
		{
			itemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> UseItemInfo => useItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomShopBuyRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomShopBuyRequest(MyRoomShopBuyRequest other)
		: this()
	{
		seq_ = other.seq_;
		id_ = other.id_;
		itemCount_ = other.itemCount_;
		useItemInfo_ = other.useItemInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomShopBuyRequest Clone()
	{
		return new MyRoomShopBuyRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomShopBuyRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MyRoomShopBuyRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && Id == other.Id && ItemCount == other.ItemCount && useItemInfo_.Equals(other.useItemInfo_))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ItemCount != 0)
		{
			num ^= ItemCount.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (ItemCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ItemCount);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemCount);
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
	public void MergeFrom(MyRoomShopBuyRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemCount != 0)
			{
				ItemCount = other.ItemCount;
			}
			useItemInfo_.Add(other.useItemInfo_);
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				ItemCount = input.ReadInt32();
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
