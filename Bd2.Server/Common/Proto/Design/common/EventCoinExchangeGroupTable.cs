using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EventCoinExchangeGroupTable : IMessage<EventCoinExchangeGroupTable>, IMessage, IEquatable<EventCoinExchangeGroupTable>, IDeepCloneable<EventCoinExchangeGroupTable>, IBufferMessage
{
	private static readonly MessageParser<EventCoinExchangeGroupTable> _parser = new MessageParser<EventCoinExchangeGroupTable>(() => new EventCoinExchangeGroupTable());

	private UnknownFieldSet _unknownFields;

	public const int EndPageIdFieldNumber = 1;

	private int endPageId_;

	public const int EventNameLocalTextIdFieldNumber = 2;

	private int eventNameLocalTextId_;

	public const int FirstButtonCountFieldNumber = 3;

	private int firstButtonCount_;

	public const int GuideDescLocalTextIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_guideDescLocalTextId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> guideDescLocalTextId_ = new RepeatedField<int>();

	public const int GuideTitleLocalTextIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_guideTitleLocalTextId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> guideTitleLocalTextId_ = new RepeatedField<int>();

	public const int IdFieldNumber = 6;

	private int id_;

	public const int IsRepeatableRewardFieldNumber = 7;

	private int isRepeatableReward_;

	public const int ItemCountFieldNumber = 8;

	private int itemCount_;

	public const int ItemIdFieldNumber = 9;

	private int itemId_;

	public const int ItemTypeFieldNumber = 10;

	private int itemType_;

	public const int RatioWebLinkFieldNumber = 11;

	private int ratioWebLink_;

	public const int SecondButtonCountFieldNumber = 12;

	private int secondButtonCount_;

	public const int StartPageIdFieldNumber = 13;

	private int startPageId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventCoinExchangeGroupTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventCoinExchangeGroupTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EndPageId
	{
		get
		{
			return endPageId_;
		}
		set
		{
			endPageId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventNameLocalTextId
	{
		get
		{
			return eventNameLocalTextId_;
		}
		set
		{
			eventNameLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstButtonCount
	{
		get
		{
			return firstButtonCount_;
		}
		set
		{
			firstButtonCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GuideDescLocalTextId => guideDescLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GuideTitleLocalTextId => guideTitleLocalTextId_;

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
	public int IsRepeatableReward
	{
		get
		{
			return isRepeatableReward_;
		}
		set
		{
			isRepeatableReward_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemType
	{
		get
		{
			return itemType_;
		}
		set
		{
			itemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RatioWebLink
	{
		get
		{
			return ratioWebLink_;
		}
		set
		{
			ratioWebLink_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SecondButtonCount
	{
		get
		{
			return secondButtonCount_;
		}
		set
		{
			secondButtonCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StartPageId
	{
		get
		{
			return startPageId_;
		}
		set
		{
			startPageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventCoinExchangeGroupTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventCoinExchangeGroupTable(EventCoinExchangeGroupTable other)
		: this()
	{
		endPageId_ = other.endPageId_;
		eventNameLocalTextId_ = other.eventNameLocalTextId_;
		firstButtonCount_ = other.firstButtonCount_;
		guideDescLocalTextId_ = other.guideDescLocalTextId_.Clone();
		guideTitleLocalTextId_ = other.guideTitleLocalTextId_.Clone();
		id_ = other.id_;
		isRepeatableReward_ = other.isRepeatableReward_;
		itemCount_ = other.itemCount_;
		itemId_ = other.itemId_;
		itemType_ = other.itemType_;
		ratioWebLink_ = other.ratioWebLink_;
		secondButtonCount_ = other.secondButtonCount_;
		startPageId_ = other.startPageId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventCoinExchangeGroupTable Clone()
	{
		return new EventCoinExchangeGroupTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventCoinExchangeGroupTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EventCoinExchangeGroupTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EndPageId == other.EndPageId && EventNameLocalTextId == other.EventNameLocalTextId && FirstButtonCount == other.FirstButtonCount && guideDescLocalTextId_.Equals(other.guideDescLocalTextId_) && guideTitleLocalTextId_.Equals(other.guideTitleLocalTextId_) && Id == other.Id && IsRepeatableReward == other.IsRepeatableReward && ItemCount == other.ItemCount && ItemId == other.ItemId && ItemType == other.ItemType && RatioWebLink == other.RatioWebLink && SecondButtonCount == other.SecondButtonCount && StartPageId == other.StartPageId)
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
		if (EndPageId != 0)
		{
			num ^= EndPageId.GetHashCode();
		}
		if (EventNameLocalTextId != 0)
		{
			num ^= EventNameLocalTextId.GetHashCode();
		}
		if (FirstButtonCount != 0)
		{
			num ^= FirstButtonCount.GetHashCode();
		}
		num ^= guideDescLocalTextId_.GetHashCode();
		num ^= guideTitleLocalTextId_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsRepeatableReward != 0)
		{
			num ^= IsRepeatableReward.GetHashCode();
		}
		if (ItemCount != 0)
		{
			num ^= ItemCount.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (ItemType != 0)
		{
			num ^= ItemType.GetHashCode();
		}
		if (RatioWebLink != 0)
		{
			num ^= RatioWebLink.GetHashCode();
		}
		if (SecondButtonCount != 0)
		{
			num ^= SecondButtonCount.GetHashCode();
		}
		if (StartPageId != 0)
		{
			num ^= StartPageId.GetHashCode();
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
		if (EndPageId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EndPageId);
		}
		if (EventNameLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventNameLocalTextId);
		}
		if (FirstButtonCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(FirstButtonCount);
		}
		guideDescLocalTextId_.WriteTo(ref output, _repeated_guideDescLocalTextId_codec);
		guideTitleLocalTextId_.WriteTo(ref output, _repeated_guideTitleLocalTextId_codec);
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (IsRepeatableReward != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(IsRepeatableReward);
		}
		if (ItemCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ItemCount);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ItemId);
		}
		if (ItemType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ItemType);
		}
		if (RatioWebLink != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(RatioWebLink);
		}
		if (SecondButtonCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(SecondButtonCount);
		}
		if (StartPageId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(StartPageId);
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
		if (EndPageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndPageId);
		}
		if (EventNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventNameLocalTextId);
		}
		if (FirstButtonCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FirstButtonCount);
		}
		num += guideDescLocalTextId_.CalculateSize(_repeated_guideDescLocalTextId_codec);
		num += guideTitleLocalTextId_.CalculateSize(_repeated_guideTitleLocalTextId_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsRepeatableReward != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsRepeatableReward);
		}
		if (ItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemCount);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (ItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemType);
		}
		if (RatioWebLink != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RatioWebLink);
		}
		if (SecondButtonCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SecondButtonCount);
		}
		if (StartPageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StartPageId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EventCoinExchangeGroupTable other)
	{
		if (other != null)
		{
			if (other.EndPageId != 0)
			{
				EndPageId = other.EndPageId;
			}
			if (other.EventNameLocalTextId != 0)
			{
				EventNameLocalTextId = other.EventNameLocalTextId;
			}
			if (other.FirstButtonCount != 0)
			{
				FirstButtonCount = other.FirstButtonCount;
			}
			guideDescLocalTextId_.Add(other.guideDescLocalTextId_);
			guideTitleLocalTextId_.Add(other.guideTitleLocalTextId_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsRepeatableReward != 0)
			{
				IsRepeatableReward = other.IsRepeatableReward;
			}
			if (other.ItemCount != 0)
			{
				ItemCount = other.ItemCount;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.ItemType != 0)
			{
				ItemType = other.ItemType;
			}
			if (other.RatioWebLink != 0)
			{
				RatioWebLink = other.RatioWebLink;
			}
			if (other.SecondButtonCount != 0)
			{
				SecondButtonCount = other.SecondButtonCount;
			}
			if (other.StartPageId != 0)
			{
				StartPageId = other.StartPageId;
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
				EndPageId = input.ReadInt32();
				break;
			case 16u:
				EventNameLocalTextId = input.ReadInt32();
				break;
			case 24u:
				FirstButtonCount = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				guideDescLocalTextId_.AddEntriesFrom(ref input, _repeated_guideDescLocalTextId_codec);
				break;
			case 40u:
			case 42u:
				guideTitleLocalTextId_.AddEntriesFrom(ref input, _repeated_guideTitleLocalTextId_codec);
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 56u:
				IsRepeatableReward = input.ReadInt32();
				break;
			case 64u:
				ItemCount = input.ReadInt32();
				break;
			case 72u:
				ItemId = input.ReadInt32();
				break;
			case 80u:
				ItemType = input.ReadInt32();
				break;
			case 88u:
				RatioWebLink = input.ReadInt32();
				break;
			case 96u:
				SecondButtonCount = input.ReadInt32();
				break;
			case 104u:
				StartPageId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
