using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventRewardHistoryResponse : IMessage<EventRewardHistoryResponse>, IMessage, IEquatable<EventRewardHistoryResponse>, IDeepCloneable<EventRewardHistoryResponse>, IBufferMessage
{
	private static readonly MessageParser<EventRewardHistoryResponse> _parser = new MessageParser<EventRewardHistoryResponse>(() => new EventRewardHistoryResponse());

	private UnknownFieldSet _unknownFields;

	public const int HistoryInfoFieldNumber = 1;

	private static readonly FieldCodec<EventRewardHistoryDBInfo> _repeated_historyInfo_codec = FieldCodec.ForMessage(10u, EventRewardHistoryDBInfo.Parser);

	private readonly RepeatedField<EventRewardHistoryDBInfo> historyInfo_ = new RepeatedField<EventRewardHistoryDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EventRewardHistoryResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventRewardHistoryResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EventRewardHistoryDBInfo> HistoryInfo => historyInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventRewardHistoryResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventRewardHistoryResponse(EventRewardHistoryResponse other)
		: this()
	{
		historyInfo_ = other.historyInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventRewardHistoryResponse Clone()
	{
		return new EventRewardHistoryResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventRewardHistoryResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EventRewardHistoryResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (historyInfo_.Equals(other.historyInfo_))
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
		num ^= historyInfo_.GetHashCode();
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
		historyInfo_.WriteTo(ref output, _repeated_historyInfo_codec);
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
		num += historyInfo_.CalculateSize(_repeated_historyInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EventRewardHistoryResponse other)
	{
		if (other != null)
		{
			historyInfo_.Add(other.historyInfo_);
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
				historyInfo_.AddEntriesFrom(ref input, _repeated_historyInfo_codec);
			}
		}
	}
}
