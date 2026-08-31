using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLShopTable : IMessage<RLShopTable>, IMessage, IEquatable<RLShopTable>, IDeepCloneable<RLShopTable>, IBufferMessage
{
	private static readonly MessageParser<RLShopTable> _parser = new MessageParser<RLShopTable>(() => new RLShopTable());

	private UnknownFieldSet _unknownFields;

	public const int HaveCharCostumeSlotOptionFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_haveCharCostumeSlotOption_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> haveCharCostumeSlotOption_ = new RepeatedField<int>();

	public const int IdFieldNumber = 2;

	private int id_;

	public const int RerollExpensiveFieldNumber = 3;

	private int rerollExpensive_;

	public const int RerollNameTextIdFieldNumber = 4;

	private int rerollNameTextId_;

	public const int RerollPriceFieldNumber = 5;

	private int rerollPrice_;

	public const int SellRelicChoiceTableIdFieldNumber = 6;

	private int sellRelicChoiceTableId_;

	public const int SellRelicCountFieldNumber = 7;

	private int sellRelicCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RLShopTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => RLShopTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> HaveCharCostumeSlotOption => haveCharCostumeSlotOption_;

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
	public int RerollExpensive
	{
		get
		{
			return rerollExpensive_;
		}
		set
		{
			rerollExpensive_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RerollNameTextId
	{
		get
		{
			return rerollNameTextId_;
		}
		set
		{
			rerollNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RerollPrice
	{
		get
		{
			return rerollPrice_;
		}
		set
		{
			rerollPrice_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SellRelicChoiceTableId
	{
		get
		{
			return sellRelicChoiceTableId_;
		}
		set
		{
			sellRelicChoiceTableId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SellRelicCount
	{
		get
		{
			return sellRelicCount_;
		}
		set
		{
			sellRelicCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLShopTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLShopTable(RLShopTable other)
		: this()
	{
		haveCharCostumeSlotOption_ = other.haveCharCostumeSlotOption_.Clone();
		id_ = other.id_;
		rerollExpensive_ = other.rerollExpensive_;
		rerollNameTextId_ = other.rerollNameTextId_;
		rerollPrice_ = other.rerollPrice_;
		sellRelicChoiceTableId_ = other.sellRelicChoiceTableId_;
		sellRelicCount_ = other.sellRelicCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLShopTable Clone()
	{
		return new RLShopTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLShopTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RLShopTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (haveCharCostumeSlotOption_.Equals(other.haveCharCostumeSlotOption_) && Id == other.Id && RerollExpensive == other.RerollExpensive && RerollNameTextId == other.RerollNameTextId && RerollPrice == other.RerollPrice && SellRelicChoiceTableId == other.SellRelicChoiceTableId && SellRelicCount == other.SellRelicCount)
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
		num ^= haveCharCostumeSlotOption_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RerollExpensive != 0)
		{
			num ^= RerollExpensive.GetHashCode();
		}
		if (RerollNameTextId != 0)
		{
			num ^= RerollNameTextId.GetHashCode();
		}
		if (RerollPrice != 0)
		{
			num ^= RerollPrice.GetHashCode();
		}
		if (SellRelicChoiceTableId != 0)
		{
			num ^= SellRelicChoiceTableId.GetHashCode();
		}
		if (SellRelicCount != 0)
		{
			num ^= SellRelicCount.GetHashCode();
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
		haveCharCostumeSlotOption_.WriteTo(ref output, _repeated_haveCharCostumeSlotOption_codec);
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (RerollExpensive != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RerollExpensive);
		}
		if (RerollNameTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RerollNameTextId);
		}
		if (RerollPrice != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(RerollPrice);
		}
		if (SellRelicChoiceTableId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SellRelicChoiceTableId);
		}
		if (SellRelicCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SellRelicCount);
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
		num += haveCharCostumeSlotOption_.CalculateSize(_repeated_haveCharCostumeSlotOption_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RerollExpensive != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RerollExpensive);
		}
		if (RerollNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RerollNameTextId);
		}
		if (RerollPrice != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RerollPrice);
		}
		if (SellRelicChoiceTableId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SellRelicChoiceTableId);
		}
		if (SellRelicCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SellRelicCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RLShopTable other)
	{
		if (other != null)
		{
			haveCharCostumeSlotOption_.Add(other.haveCharCostumeSlotOption_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RerollExpensive != 0)
			{
				RerollExpensive = other.RerollExpensive;
			}
			if (other.RerollNameTextId != 0)
			{
				RerollNameTextId = other.RerollNameTextId;
			}
			if (other.RerollPrice != 0)
			{
				RerollPrice = other.RerollPrice;
			}
			if (other.SellRelicChoiceTableId != 0)
			{
				SellRelicChoiceTableId = other.SellRelicChoiceTableId;
			}
			if (other.SellRelicCount != 0)
			{
				SellRelicCount = other.SellRelicCount;
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
			case 10u:
				haveCharCostumeSlotOption_.AddEntriesFrom(ref input, _repeated_haveCharCostumeSlotOption_codec);
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				RerollExpensive = input.ReadInt32();
				break;
			case 32u:
				RerollNameTextId = input.ReadInt32();
				break;
			case 40u:
				RerollPrice = input.ReadInt32();
				break;
			case 48u:
				SellRelicChoiceTableId = input.ReadInt32();
				break;
			case 56u:
				SellRelicCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
