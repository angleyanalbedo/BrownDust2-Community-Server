using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MyRoomItemShopTable : IMessage<MyRoomItemShopTable>, IMessage, IEquatable<MyRoomItemShopTable>, IDeepCloneable<MyRoomItemShopTable>, IBufferMessage
{
	private static readonly MessageParser<MyRoomItemShopTable> _parser = new MessageParser<MyRoomItemShopTable>(() => new MyRoomItemShopTable());

	private UnknownFieldSet _unknownFields;

	public const int BuyMaxCountFieldNumber = 1;

	private int buyMaxCount_;

	public const int ElementCountFieldNumber = 2;

	private int elementCount_;

	public const int ElementIdFieldNumber = 3;

	private int elementId_;

	public const int ElementTypeFieldNumber = 4;

	private int elementType_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int PriceCountFieldNumber = 6;

	private int priceCount_;

	public const int PriceIdFieldNumber = 7;

	private int priceId_;

	public const int PriceTypeFieldNumber = 8;

	private int priceType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomItemShopTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MyRoomItemShopTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public MyRoomItemShopTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemShopTable(MyRoomItemShopTable other)
		: this()
	{
		buyMaxCount_ = other.buyMaxCount_;
		elementCount_ = other.elementCount_;
		elementId_ = other.elementId_;
		elementType_ = other.elementType_;
		id_ = other.id_;
		priceCount_ = other.priceCount_;
		priceId_ = other.priceId_;
		priceType_ = other.priceType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomItemShopTable Clone()
	{
		return new MyRoomItemShopTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomItemShopTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MyRoomItemShopTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BuyMaxCount == other.BuyMaxCount && ElementCount == other.ElementCount && ElementId == other.ElementId && ElementType == other.ElementType && Id == other.Id && PriceCount == other.PriceCount && PriceId == other.PriceId && PriceType == other.PriceType)
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (BuyMaxCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuyMaxCount);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MyRoomItemShopTable other)
	{
		if (other != null)
		{
			if (other.BuyMaxCount != 0)
			{
				BuyMaxCount = other.BuyMaxCount;
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
				PriceCount = input.ReadInt32();
				break;
			case 56u:
				PriceId = input.ReadInt32();
				break;
			case 64u:
				PriceType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
