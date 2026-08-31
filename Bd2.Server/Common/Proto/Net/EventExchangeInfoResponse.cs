using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventExchangeInfoResponse : IMessage<EventExchangeInfoResponse>, IMessage, IEquatable<EventExchangeInfoResponse>, IDeepCloneable<EventExchangeInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EventExchangeInfoResponse> _parser = new MessageParser<EventExchangeInfoResponse>(() => new EventExchangeInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int EventExchangeInfoFieldNumber = 1;

	private static readonly FieldCodec<EventExchangeDBInfo> _repeated_eventExchangeInfo_codec = FieldCodec.ForMessage(10u, EventExchangeDBInfo.Parser);

	private readonly RepeatedField<EventExchangeDBInfo> eventExchangeInfo_ = new RepeatedField<EventExchangeDBInfo>();

	public const int EventExchangeRewardInfoFieldNumber = 2;

	private static readonly FieldCodec<EventExchangeRewardDBInfo> _repeated_eventExchangeRewardInfo_codec = FieldCodec.ForMessage(18u, EventExchangeRewardDBInfo.Parser);

	private readonly RepeatedField<EventExchangeRewardDBInfo> eventExchangeRewardInfo_ = new RepeatedField<EventExchangeRewardDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EventExchangeInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventExchangeInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EventExchangeDBInfo> EventExchangeInfo => eventExchangeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EventExchangeRewardDBInfo> EventExchangeRewardInfo => eventExchangeRewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeInfoResponse(EventExchangeInfoResponse other)
		: this()
	{
		eventExchangeInfo_ = other.eventExchangeInfo_.Clone();
		eventExchangeRewardInfo_ = other.eventExchangeRewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeInfoResponse Clone()
	{
		return new EventExchangeInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventExchangeInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventExchangeInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (eventExchangeInfo_.Equals(other.eventExchangeInfo_) && eventExchangeRewardInfo_.Equals(other.eventExchangeRewardInfo_))
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
		num ^= eventExchangeInfo_.GetHashCode();
		num ^= eventExchangeRewardInfo_.GetHashCode();
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
		eventExchangeInfo_.WriteTo(ref output, _repeated_eventExchangeInfo_codec);
		eventExchangeRewardInfo_.WriteTo(ref output, _repeated_eventExchangeRewardInfo_codec);
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
		num += eventExchangeInfo_.CalculateSize(_repeated_eventExchangeInfo_codec);
		num += eventExchangeRewardInfo_.CalculateSize(_repeated_eventExchangeRewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventExchangeInfoResponse other)
	{
		if (other != null)
		{
			eventExchangeInfo_.Add(other.eventExchangeInfo_);
			eventExchangeRewardInfo_.Add(other.eventExchangeRewardInfo_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				eventExchangeRewardInfo_.AddEntriesFrom(ref input, _repeated_eventExchangeRewardInfo_codec);
				break;
			case 10u:
				eventExchangeInfo_.AddEntriesFrom(ref input, _repeated_eventExchangeInfo_codec);
				break;
			}
		}
	}
}
