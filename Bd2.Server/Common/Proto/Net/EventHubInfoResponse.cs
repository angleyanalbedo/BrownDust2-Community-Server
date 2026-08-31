using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventHubInfoResponse : IMessage<EventHubInfoResponse>, IMessage, IEquatable<EventHubInfoResponse>, IDeepCloneable<EventHubInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EventHubInfoResponse> _parser = new MessageParser<EventHubInfoResponse>(() => new EventHubInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int EventHubInfoFieldNumber = 1;

	private static readonly FieldCodec<EventHubDBInfo> _repeated_eventHubInfo_codec = FieldCodec.ForMessage(10u, EventHubDBInfo.Parser);

	private readonly RepeatedField<EventHubDBInfo> eventHubInfo_ = new RepeatedField<EventHubDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventHubInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventHubInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EventHubDBInfo> EventHubInfo => eventHubInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventHubInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventHubInfoResponse(EventHubInfoResponse other)
		: this()
	{
		eventHubInfo_ = other.eventHubInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventHubInfoResponse Clone()
	{
		return new EventHubInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventHubInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventHubInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (eventHubInfo_.Equals(other.eventHubInfo_))
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
		num ^= eventHubInfo_.GetHashCode();
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
		eventHubInfo_.WriteTo(ref output, _repeated_eventHubInfo_codec);
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
		num += eventHubInfo_.CalculateSize(_repeated_eventHubInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventHubInfoResponse other)
	{
		if (other != null)
		{
			eventHubInfo_.Add(other.eventHubInfo_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				eventHubInfo_.AddEntriesFrom(ref input, _repeated_eventHubInfo_codec);
			}
		}
	}
}
