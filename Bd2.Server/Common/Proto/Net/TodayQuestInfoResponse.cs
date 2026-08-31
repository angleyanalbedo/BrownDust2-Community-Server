using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TodayQuestInfoResponse : IMessage<TodayQuestInfoResponse>, IMessage, IEquatable<TodayQuestInfoResponse>, IDeepCloneable<TodayQuestInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<TodayQuestInfoResponse> _parser = new MessageParser<TodayQuestInfoResponse>(() => new TodayQuestInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int QuestInfoFieldNumber = 1;

	private static readonly FieldCodec<QuestDBInfo> _repeated_questInfo_codec = FieldCodec.ForMessage(10u, QuestDBInfo.Parser);

	private readonly RepeatedField<QuestDBInfo> questInfo_ = new RepeatedField<QuestDBInfo>();

	public const int ClearQuestIdsFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_clearQuestIds_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> clearQuestIds_ = new RepeatedField<int>();

	public const int TodayEndTimeFieldNumber = 3;

	private long todayEndTime_;

	public const int TodayQuestIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_todayQuestId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> todayQuestId_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TodayQuestInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TodayQuestInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<QuestDBInfo> QuestInfo => questInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ClearQuestIds => clearQuestIds_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TodayEndTime
	{
		get
		{
			return todayEndTime_;
		}
		set
		{
			todayEndTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> TodayQuestId => todayQuestId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TodayQuestInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TodayQuestInfoResponse(TodayQuestInfoResponse other)
		: this()
	{
		questInfo_ = other.questInfo_.Clone();
		clearQuestIds_ = other.clearQuestIds_.Clone();
		todayEndTime_ = other.todayEndTime_;
		todayQuestId_ = other.todayQuestId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TodayQuestInfoResponse Clone()
	{
		return new TodayQuestInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TodayQuestInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TodayQuestInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (questInfo_.Equals(other.questInfo_) && clearQuestIds_.Equals(other.clearQuestIds_) && TodayEndTime == other.TodayEndTime && todayQuestId_.Equals(other.todayQuestId_))
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
		if (TodayEndTime != 0L)
		{
			num ^= TodayEndTime.GetHashCode();
		}
		num ^= todayQuestId_.GetHashCode();
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
		if (TodayEndTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(TodayEndTime);
		}
		todayQuestId_.WriteTo(ref output, _repeated_todayQuestId_codec);
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
		num += questInfo_.CalculateSize(_repeated_questInfo_codec);
		num += clearQuestIds_.CalculateSize(_repeated_clearQuestIds_codec);
		if (TodayEndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(TodayEndTime);
		}
		num += todayQuestId_.CalculateSize(_repeated_todayQuestId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TodayQuestInfoResponse other)
	{
		if (other != null)
		{
			questInfo_.Add(other.questInfo_);
			clearQuestIds_.Add(other.clearQuestIds_);
			if (other.TodayEndTime != 0L)
			{
				TodayEndTime = other.TodayEndTime;
			}
			todayQuestId_.Add(other.todayQuestId_);
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
			case 10u:
				questInfo_.AddEntriesFrom(ref input, _repeated_questInfo_codec);
				break;
			case 16u:
			case 18u:
				clearQuestIds_.AddEntriesFrom(ref input, _repeated_clearQuestIds_codec);
				break;
			case 24u:
				TodayEndTime = input.ReadInt64();
				break;
			case 32u:
			case 34u:
				todayQuestId_.AddEntriesFrom(ref input, _repeated_todayQuestId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
