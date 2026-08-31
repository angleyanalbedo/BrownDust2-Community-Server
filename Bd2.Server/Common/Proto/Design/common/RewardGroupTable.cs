using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RewardGroupTable : IMessage<RewardGroupTable>, IMessage, IEquatable<RewardGroupTable>, IDeepCloneable<RewardGroupTable>, IBufferMessage
{
	private static readonly MessageParser<RewardGroupTable> _parser = new MessageParser<RewardGroupTable>(() => new RewardGroupTable());

	private UnknownFieldSet _unknownFields;

	public const int DropCountFieldNumber = 1;

	private int dropCount_;

	public const int DropTypeFieldNumber = 2;

	private int dropType_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ItemCountFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_itemCount_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> itemCount_ = new RepeatedField<int>();

	public const int ItemIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_itemId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> itemId_ = new RepeatedField<int>();

	public const int ItemTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_itemType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> itemType_ = new RepeatedField<int>();

	public const int MailIdFieldNumber = 7;

	private int mailId_;

	public const int RatioFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_ratio_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> ratio_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RewardGroupTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RewardGroupTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DropCount
	{
		get
		{
			return dropCount_;
		}
		set
		{
			dropCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DropType
	{
		get
		{
			return dropType_;
		}
		set
		{
			dropType_ = value;
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
	public RepeatedField<int> ItemCount => itemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ItemId => itemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ItemType => itemType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MailId
	{
		get
		{
			return mailId_;
		}
		set
		{
			mailId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Ratio => ratio_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardGroupTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardGroupTable(RewardGroupTable other)
		: this()
	{
		dropCount_ = other.dropCount_;
		dropType_ = other.dropType_;
		id_ = other.id_;
		itemCount_ = other.itemCount_.Clone();
		itemId_ = other.itemId_.Clone();
		itemType_ = other.itemType_.Clone();
		mailId_ = other.mailId_;
		ratio_ = other.ratio_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardGroupTable Clone()
	{
		return new RewardGroupTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as RewardGroupTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RewardGroupTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DropCount == other.DropCount && DropType == other.DropType && Id == other.Id && itemCount_.Equals(other.itemCount_) && itemId_.Equals(other.itemId_) && itemType_.Equals(other.itemType_) && MailId == other.MailId && ratio_.Equals(other.ratio_))
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
		if (DropCount != 0)
		{
			num ^= DropCount.GetHashCode();
		}
		if (DropType != 0)
		{
			num ^= DropType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= itemCount_.GetHashCode();
		num ^= itemId_.GetHashCode();
		num ^= itemType_.GetHashCode();
		if (MailId != 0)
		{
			num ^= MailId.GetHashCode();
		}
		num ^= ratio_.GetHashCode();
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
		if (DropCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DropCount);
		}
		if (DropType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DropType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		itemCount_.WriteTo(ref output, _repeated_itemCount_codec);
		itemId_.WriteTo(ref output, _repeated_itemId_codec);
		itemType_.WriteTo(ref output, _repeated_itemType_codec);
		if (MailId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(MailId);
		}
		ratio_.WriteTo(ref output, _repeated_ratio_codec);
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
		if (DropCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropCount);
		}
		if (DropType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += itemCount_.CalculateSize(_repeated_itemCount_codec);
		num += itemId_.CalculateSize(_repeated_itemId_codec);
		num += itemType_.CalculateSize(_repeated_itemType_codec);
		if (MailId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MailId);
		}
		num += ratio_.CalculateSize(_repeated_ratio_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RewardGroupTable other)
	{
		if (other != null)
		{
			if (other.DropCount != 0)
			{
				DropCount = other.DropCount;
			}
			if (other.DropType != 0)
			{
				DropType = other.DropType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			itemCount_.Add(other.itemCount_);
			itemId_.Add(other.itemId_);
			itemType_.Add(other.itemType_);
			if (other.MailId != 0)
			{
				MailId = other.MailId;
			}
			ratio_.Add(other.ratio_);
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
				DropCount = input.ReadInt32();
				break;
			case 16u:
				DropType = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				itemCount_.AddEntriesFrom(ref input, _repeated_itemCount_codec);
				break;
			case 48u:
			case 50u:
				itemType_.AddEntriesFrom(ref input, _repeated_itemType_codec);
				break;
			case 56u:
				MailId = input.ReadInt32();
				break;
			case 64u:
			case 66u:
				ratio_.AddEntriesFrom(ref input, _repeated_ratio_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 40u:
			case 42u:
				itemId_.AddEntriesFrom(ref input, _repeated_itemId_codec);
				break;
			}
		}
	}
}
