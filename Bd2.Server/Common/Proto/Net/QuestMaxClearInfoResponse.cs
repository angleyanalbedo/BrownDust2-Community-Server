using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestMaxClearInfoResponse : IMessage<QuestMaxClearInfoResponse>, IMessage, IEquatable<QuestMaxClearInfoResponse>, IDeepCloneable<QuestMaxClearInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<QuestMaxClearInfoResponse> _parser = new MessageParser<QuestMaxClearInfoResponse>(() => new QuestMaxClearInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MaxClearInfoFieldNumber = 1;

	private static readonly FieldCodec<QuestMaxClearDBInfo> _repeated_maxClearInfo_codec = FieldCodec.ForMessage(10u, QuestMaxClearDBInfo.Parser);

	private readonly RepeatedField<QuestMaxClearDBInfo> maxClearInfo_ = new RepeatedField<QuestMaxClearDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestMaxClearInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestMaxClearInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<QuestMaxClearDBInfo> MaxClearInfo => maxClearInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestMaxClearInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestMaxClearInfoResponse(QuestMaxClearInfoResponse other)
		: this()
	{
		maxClearInfo_ = other.maxClearInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestMaxClearInfoResponse Clone()
	{
		return new QuestMaxClearInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as QuestMaxClearInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestMaxClearInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (maxClearInfo_.Equals(other.maxClearInfo_))
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
		num ^= maxClearInfo_.GetHashCode();
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
		maxClearInfo_.WriteTo(ref output, _repeated_maxClearInfo_codec);
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
		num += maxClearInfo_.CalculateSize(_repeated_maxClearInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestMaxClearInfoResponse other)
	{
		if (other != null)
		{
			maxClearInfo_.Add(other.maxClearInfo_);
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
				maxClearInfo_.AddEntriesFrom(ref input, _repeated_maxClearInfo_codec);
			}
		}
	}
}
