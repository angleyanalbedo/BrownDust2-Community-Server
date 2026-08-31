using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventScheduleDBInfo : IMessage<EventScheduleDBInfo>, IMessage, IEquatable<EventScheduleDBInfo>, IDeepCloneable<EventScheduleDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EventScheduleDBInfo> _parser = new MessageParser<EventScheduleDBInfo>(() => new EventScheduleDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int EventTypeFieldNumber = 2;

	private Define_EventType eventType_;

	public const int EventIdFieldNumber = 3;

	private int eventId_;

	public const int EventSubIdFieldNumber = 4;

	private int eventSubId_;

	public const int StartDateFieldNumber = 5;

	private long startDate_;

	public const int EndDateFieldNumber = 6;

	private long endDate_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventScheduleDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventScheduleDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public Define_EventType EventType
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
	public int EventSubId
	{
		get
		{
			return eventSubId_;
		}
		set
		{
			eventSubId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long StartDate
	{
		get
		{
			return startDate_;
		}
		set
		{
			startDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndDate
	{
		get
		{
			return endDate_;
		}
		set
		{
			endDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventScheduleDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventScheduleDBInfo(EventScheduleDBInfo other)
		: this()
	{
		id_ = other.id_;
		eventType_ = other.eventType_;
		eventId_ = other.eventId_;
		eventSubId_ = other.eventSubId_;
		startDate_ = other.startDate_;
		endDate_ = other.endDate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventScheduleDBInfo Clone()
	{
		return new EventScheduleDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventScheduleDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventScheduleDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && EventType == other.EventType && EventId == other.EventId && EventSubId == other.EventSubId && StartDate == other.StartDate && EndDate == other.EndDate)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (EventType != Define_EventType.EventAlwaysAttendance)
		{
			num ^= EventType.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (EventSubId != 0)
		{
			num ^= EventSubId.GetHashCode();
		}
		if (StartDate != 0L)
		{
			num ^= StartDate.GetHashCode();
		}
		if (EndDate != 0L)
		{
			num ^= EndDate.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (EventType != Define_EventType.EventAlwaysAttendance)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EventType);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EventId);
		}
		if (EventSubId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EventSubId);
		}
		if (StartDate != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(StartDate);
		}
		if (EndDate != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(EndDate);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (EventType != Define_EventType.EventAlwaysAttendance)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EventType);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (EventSubId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventSubId);
		}
		if (StartDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StartDate);
		}
		if (EndDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndDate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventScheduleDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.EventType != Define_EventType.EventAlwaysAttendance)
			{
				EventType = other.EventType;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.EventSubId != 0)
			{
				EventSubId = other.EventSubId;
			}
			if (other.StartDate != 0L)
			{
				StartDate = other.StartDate;
			}
			if (other.EndDate != 0L)
			{
				EndDate = other.EndDate;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				EventType = (Define_EventType)input.ReadEnum();
				break;
			case 24u:
				EventId = input.ReadInt32();
				break;
			case 32u:
				EventSubId = input.ReadInt32();
				break;
			case 40u:
				StartDate = input.ReadInt64();
				break;
			case 48u:
				EndDate = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
