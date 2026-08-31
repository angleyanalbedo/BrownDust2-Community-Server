using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventScheduleInfoResponse : IMessage<EventScheduleInfoResponse>, IMessage, IEquatable<EventScheduleInfoResponse>, IDeepCloneable<EventScheduleInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EventScheduleInfoResponse> _parser = new MessageParser<EventScheduleInfoResponse>(() => new EventScheduleInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int EventScheduleInfoFieldNumber = 1;

	private static readonly FieldCodec<EventScheduleDBInfo> _repeated_eventScheduleInfo_codec = FieldCodec.ForMessage(10u, EventScheduleDBInfo.Parser);

	private readonly RepeatedField<EventScheduleDBInfo> eventScheduleInfo_ = new RepeatedField<EventScheduleDBInfo>();

	public const int DelayedVisibilityScheduleInfoFieldNumber = 2;

	private static readonly FieldCodec<DelayedVisibilityScheduleDBInfo> _repeated_delayedVisibilityScheduleInfo_codec = FieldCodec.ForMessage(18u, DelayedVisibilityScheduleDBInfo.Parser);

	private readonly RepeatedField<DelayedVisibilityScheduleDBInfo> delayedVisibilityScheduleInfo_ = new RepeatedField<DelayedVisibilityScheduleDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventScheduleInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventScheduleInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EventScheduleDBInfo> EventScheduleInfo => eventScheduleInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<DelayedVisibilityScheduleDBInfo> DelayedVisibilityScheduleInfo => delayedVisibilityScheduleInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventScheduleInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventScheduleInfoResponse(EventScheduleInfoResponse other)
		: this()
	{
		eventScheduleInfo_ = other.eventScheduleInfo_.Clone();
		delayedVisibilityScheduleInfo_ = other.delayedVisibilityScheduleInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventScheduleInfoResponse Clone()
	{
		return new EventScheduleInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventScheduleInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventScheduleInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (eventScheduleInfo_.Equals(other.eventScheduleInfo_) && delayedVisibilityScheduleInfo_.Equals(other.delayedVisibilityScheduleInfo_))
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
		num ^= eventScheduleInfo_.GetHashCode();
		num ^= delayedVisibilityScheduleInfo_.GetHashCode();
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
		eventScheduleInfo_.WriteTo(ref output, _repeated_eventScheduleInfo_codec);
		delayedVisibilityScheduleInfo_.WriteTo(ref output, _repeated_delayedVisibilityScheduleInfo_codec);
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
		num += eventScheduleInfo_.CalculateSize(_repeated_eventScheduleInfo_codec);
		num += delayedVisibilityScheduleInfo_.CalculateSize(_repeated_delayedVisibilityScheduleInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EventScheduleInfoResponse other)
	{
		if (other != null)
		{
			eventScheduleInfo_.Add(other.eventScheduleInfo_);
			delayedVisibilityScheduleInfo_.Add(other.delayedVisibilityScheduleInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				delayedVisibilityScheduleInfo_.AddEntriesFrom(ref input, _repeated_delayedVisibilityScheduleInfo_codec);
				break;
			case 10u:
				eventScheduleInfo_.AddEntriesFrom(ref input, _repeated_eventScheduleInfo_codec);
				break;
			}
		}
	}
}
