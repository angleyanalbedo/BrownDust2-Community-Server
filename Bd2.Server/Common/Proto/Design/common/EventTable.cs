using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EventTable : IMessage<EventTable>, IMessage, IEquatable<EventTable>, IDeepCloneable<EventTable>, IBufferMessage
{
	private static readonly MessageParser<EventTable> _parser = new MessageParser<EventTable>(() => new EventTable());

	private UnknownFieldSet _unknownFields;

	public const int BannerFontLocalTextIdFieldNumber = 1;

	private int bannerFontLocalTextId_;

	public const int BannerResouceNameFieldNumber = 2;

	private string bannerResouceName_ = "";

	public const int CategoryBannerFieldNumber = 3;

	private string categoryBanner_ = "";

	public const int EventIdFieldNumber = 4;

	private int eventId_;

	public const int EventNameTextIdFieldNumber = 5;

	private int eventNameTextId_;

	public const int EventTypeFieldNumber = 6;

	private int eventType_;

	public const int IdFieldNumber = 7;

	private int id_;

	public const int IsActiveOnEnterFieldNumber = 8;

	private int isActiveOnEnter_;

	public const int SortIdFieldNumber = 9;

	private int sortId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EventTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BannerFontLocalTextId
	{
		get
		{
			return bannerFontLocalTextId_;
		}
		set
		{
			bannerFontLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BannerResouceName
	{
		get
		{
			return bannerResouceName_;
		}
		set
		{
			bannerResouceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CategoryBanner
	{
		get
		{
			return categoryBanner_;
		}
		set
		{
			categoryBanner_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventNameTextId
	{
		get
		{
			return eventNameTextId_;
		}
		set
		{
			eventNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventType
	{
		get
		{
			return eventType_;
		}
		set
		{
			eventType_ = value;
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
	public int IsActiveOnEnter
	{
		get
		{
			return isActiveOnEnter_;
		}
		set
		{
			isActiveOnEnter_ = value;
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
	public EventTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventTable(EventTable other)
		: this()
	{
		bannerFontLocalTextId_ = other.bannerFontLocalTextId_;
		bannerResouceName_ = other.bannerResouceName_;
		categoryBanner_ = other.categoryBanner_;
		eventId_ = other.eventId_;
		eventNameTextId_ = other.eventNameTextId_;
		eventType_ = other.eventType_;
		id_ = other.id_;
		isActiveOnEnter_ = other.isActiveOnEnter_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventTable Clone()
	{
		return new EventTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BannerFontLocalTextId == other.BannerFontLocalTextId && !(BannerResouceName != other.BannerResouceName) && !(CategoryBanner != other.CategoryBanner) && EventId == other.EventId && EventNameTextId == other.EventNameTextId && EventType == other.EventType && Id == other.Id && IsActiveOnEnter == other.IsActiveOnEnter && SortId == other.SortId)
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
		if (BannerFontLocalTextId != 0)
		{
			num ^= BannerFontLocalTextId.GetHashCode();
		}
		if (BannerResouceName.Length != 0)
		{
			num ^= BannerResouceName.GetHashCode();
		}
		if (CategoryBanner.Length != 0)
		{
			num ^= CategoryBanner.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (EventNameTextId != 0)
		{
			num ^= EventNameTextId.GetHashCode();
		}
		if (EventType != 0)
		{
			num ^= EventType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsActiveOnEnter != 0)
		{
			num ^= IsActiveOnEnter.GetHashCode();
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
		if (BannerFontLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BannerFontLocalTextId);
		}
		if (BannerResouceName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BannerResouceName);
		}
		if (CategoryBanner.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(CategoryBanner);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EventId);
		}
		if (EventNameTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EventNameTextId);
		}
		if (EventType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EventType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		if (IsActiveOnEnter != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(IsActiveOnEnter);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(72);
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
		if (BannerFontLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BannerFontLocalTextId);
		}
		if (BannerResouceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BannerResouceName);
		}
		if (CategoryBanner.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CategoryBanner);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (EventNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventNameTextId);
		}
		if (EventType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsActiveOnEnter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsActiveOnEnter);
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EventTable other)
	{
		if (other != null)
		{
			if (other.BannerFontLocalTextId != 0)
			{
				BannerFontLocalTextId = other.BannerFontLocalTextId;
			}
			if (other.BannerResouceName.Length != 0)
			{
				BannerResouceName = other.BannerResouceName;
			}
			if (other.CategoryBanner.Length != 0)
			{
				CategoryBanner = other.CategoryBanner;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.EventNameTextId != 0)
			{
				EventNameTextId = other.EventNameTextId;
			}
			if (other.EventType != 0)
			{
				EventType = other.EventType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsActiveOnEnter != 0)
			{
				IsActiveOnEnter = other.IsActiveOnEnter;
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
				BannerFontLocalTextId = input.ReadInt32();
				break;
			case 18u:
				BannerResouceName = input.ReadString();
				break;
			case 26u:
				CategoryBanner = input.ReadString();
				break;
			case 32u:
				EventId = input.ReadInt32();
				break;
			case 40u:
				EventNameTextId = input.ReadInt32();
				break;
			case 48u:
				EventType = input.ReadInt32();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 64u:
				IsActiveOnEnter = input.ReadInt32();
				break;
			case 72u:
				SortId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
