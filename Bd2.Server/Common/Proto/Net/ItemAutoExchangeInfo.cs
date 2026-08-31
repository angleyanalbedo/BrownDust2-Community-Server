using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ItemAutoExchangeInfo : IMessage<ItemAutoExchangeInfo>, IMessage, IEquatable<ItemAutoExchangeInfo>, IDeepCloneable<ItemAutoExchangeInfo>, IBufferMessage
{
	private static readonly MessageParser<ItemAutoExchangeInfo> _parser = new MessageParser<ItemAutoExchangeInfo>(() => new ItemAutoExchangeInfo());

	private UnknownFieldSet _unknownFields;

	public const int OriginalItemTypeFieldNumber = 1;

	private int originalItemType_;

	public const int OriginalItemIdFieldNumber = 2;

	private int originalItemId_;

	public const int OriginalItemCountFieldNumber = 3;

	private int originalItemCount_;

	public const int ExchangeItemTypeFieldNumber = 4;

	private int exchangeItemType_;

	public const int ExchangeItemIdFieldNumber = 5;

	private int exchangeItemId_;

	public const int ExchangeItemCountFieldNumber = 6;

	private int exchangeItemCount_;

	public const int SortIdFieldNumber = 7;

	private int sortId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ItemAutoExchangeInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ItemAutoExchangeInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OriginalItemType
	{
		get
		{
			return originalItemType_;
		}
		set
		{
			originalItemType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OriginalItemId
	{
		get
		{
			return originalItemId_;
		}
		set
		{
			originalItemId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OriginalItemCount
	{
		get
		{
			return originalItemCount_;
		}
		set
		{
			originalItemCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ExchangeItemType
	{
		get
		{
			return exchangeItemType_;
		}
		set
		{
			exchangeItemType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ExchangeItemId
	{
		get
		{
			return exchangeItemId_;
		}
		set
		{
			exchangeItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ExchangeItemCount
	{
		get
		{
			return exchangeItemCount_;
		}
		set
		{
			exchangeItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ItemAutoExchangeInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ItemAutoExchangeInfo(ItemAutoExchangeInfo other)
		: this()
	{
		originalItemType_ = other.originalItemType_;
		originalItemId_ = other.originalItemId_;
		originalItemCount_ = other.originalItemCount_;
		exchangeItemType_ = other.exchangeItemType_;
		exchangeItemId_ = other.exchangeItemId_;
		exchangeItemCount_ = other.exchangeItemCount_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ItemAutoExchangeInfo Clone()
	{
		return new ItemAutoExchangeInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ItemAutoExchangeInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ItemAutoExchangeInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OriginalItemType == other.OriginalItemType && OriginalItemId == other.OriginalItemId && OriginalItemCount == other.OriginalItemCount && ExchangeItemType == other.ExchangeItemType && ExchangeItemId == other.ExchangeItemId && ExchangeItemCount == other.ExchangeItemCount && SortId == other.SortId)
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (OriginalItemType != 0)
		{
			num ^= OriginalItemType.GetHashCode();
		}
		if (OriginalItemId != 0)
		{
			num ^= OriginalItemId.GetHashCode();
		}
		if (OriginalItemCount != 0)
		{
			num ^= OriginalItemCount.GetHashCode();
		}
		if (ExchangeItemType != 0)
		{
			num ^= ExchangeItemType.GetHashCode();
		}
		if (ExchangeItemId != 0)
		{
			num ^= ExchangeItemId.GetHashCode();
		}
		if (ExchangeItemCount != 0)
		{
			num ^= ExchangeItemCount.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
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
		if (OriginalItemType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(OriginalItemType);
		}
		if (OriginalItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OriginalItemId);
		}
		if (OriginalItemCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(OriginalItemCount);
		}
		if (ExchangeItemType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ExchangeItemType);
		}
		if (ExchangeItemId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ExchangeItemId);
		}
		if (ExchangeItemCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ExchangeItemCount);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SortId);
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
		if (OriginalItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OriginalItemType);
		}
		if (OriginalItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OriginalItemId);
		}
		if (OriginalItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OriginalItemCount);
		}
		if (ExchangeItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExchangeItemType);
		}
		if (ExchangeItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExchangeItemId);
		}
		if (ExchangeItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExchangeItemCount);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ItemAutoExchangeInfo other)
	{
		if (other != null)
		{
			if (other.OriginalItemType != 0)
			{
				OriginalItemType = other.OriginalItemType;
			}
			if (other.OriginalItemId != 0)
			{
				OriginalItemId = other.OriginalItemId;
			}
			if (other.OriginalItemCount != 0)
			{
				OriginalItemCount = other.OriginalItemCount;
			}
			if (other.ExchangeItemType != 0)
			{
				ExchangeItemType = other.ExchangeItemType;
			}
			if (other.ExchangeItemId != 0)
			{
				ExchangeItemId = other.ExchangeItemId;
			}
			if (other.ExchangeItemCount != 0)
			{
				ExchangeItemCount = other.ExchangeItemCount;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
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
				OriginalItemType = input.ReadInt32();
				break;
			case 16u:
				OriginalItemId = input.ReadInt32();
				break;
			case 24u:
				OriginalItemCount = input.ReadInt32();
				break;
			case 32u:
				ExchangeItemType = input.ReadInt32();
				break;
			case 40u:
				ExchangeItemId = input.ReadInt32();
				break;
			case 48u:
				ExchangeItemCount = input.ReadInt32();
				break;
			case 56u:
				SortId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
