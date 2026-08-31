using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestInfoResponse : IMessage<QuestInfoResponse>, IMessage, IEquatable<QuestInfoResponse>, IDeepCloneable<QuestInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<QuestInfoResponse> _parser = new MessageParser<QuestInfoResponse>(() => new QuestInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int QuestInfoFieldNumber = 1;

	private static readonly FieldCodec<QuestDBInfo> _repeated_questInfo_codec = FieldCodec.ForMessage(10u, QuestDBInfo.Parser);

	private readonly RepeatedField<QuestDBInfo> questInfo_ = new RepeatedField<QuestDBInfo>();

	public const int ClearQuestIdsFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_clearQuestIds_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> clearQuestIds_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<QuestDBInfo> QuestInfo => questInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ClearQuestIds => clearQuestIds_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestInfoResponse(QuestInfoResponse other)
		: this()
	{
		questInfo_ = other.questInfo_.Clone();
		clearQuestIds_ = other.clearQuestIds_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestInfoResponse Clone()
	{
		return new QuestInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (questInfo_.Equals(other.questInfo_) && clearQuestIds_.Equals(other.clearQuestIds_))
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
		num ^= questInfo_.GetHashCode();
		num ^= clearQuestIds_.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		questInfo_.WriteTo(ref output, _repeated_questInfo_codec);
		clearQuestIds_.WriteTo(ref output, _repeated_clearQuestIds_codec);
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
		num += questInfo_.CalculateSize(_repeated_questInfo_codec);
		num += clearQuestIds_.CalculateSize(_repeated_clearQuestIds_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestInfoResponse other)
	{
		if (other != null)
		{
			questInfo_.Add(other.questInfo_);
			clearQuestIds_.Add(other.clearQuestIds_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				clearQuestIds_.AddEntriesFrom(ref input, _repeated_clearQuestIds_codec);
				break;
			case 10u:
				questInfo_.AddEntriesFrom(ref input, _repeated_questInfo_codec);
				break;
			}
		}
	}
}
