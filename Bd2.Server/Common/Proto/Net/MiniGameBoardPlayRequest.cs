using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameBoardPlayRequest : IMessage<MiniGameBoardPlayRequest>, IMessage, IEquatable<MiniGameBoardPlayRequest>, IDeepCloneable<MiniGameBoardPlayRequest>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBoardPlayRequest> _parser = new MessageParser<MiniGameBoardPlayRequest>(() => new MiniGameBoardPlayRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int EventScheduleIdFieldNumber = 2;

	private int eventScheduleId_;

	public const int ConsumeItemFieldNumber = 3;

	private static readonly FieldCodec<ItemDBInfo> _repeated_consumeItem_codec = FieldCodec.ForMessage(26u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> consumeItem_ = new RepeatedField<ItemDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameBoardPlayRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameBoardPlayRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventScheduleId
	{
		get
		{
			return eventScheduleId_;
		}
		set
		{
			eventScheduleId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> ConsumeItem => consumeItem_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBoardPlayRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBoardPlayRequest(MiniGameBoardPlayRequest other)
		: this()
	{
		seq_ = other.seq_;
		eventScheduleId_ = other.eventScheduleId_;
		consumeItem_ = other.consumeItem_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardPlayRequest Clone()
	{
		return new MiniGameBoardPlayRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBoardPlayRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameBoardPlayRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && EventScheduleId == other.EventScheduleId && consumeItem_.Equals(other.consumeItem_))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (EventScheduleId != 0)
		{
			num ^= EventScheduleId.GetHashCode();
		}
		num ^= consumeItem_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (EventScheduleId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventScheduleId);
		}
		consumeItem_.WriteTo(ref output, _repeated_consumeItem_codec);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (EventScheduleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventScheduleId);
		}
		num += consumeItem_.CalculateSize(_repeated_consumeItem_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameBoardPlayRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.EventScheduleId != 0)
			{
				EventScheduleId = other.EventScheduleId;
			}
			consumeItem_.Add(other.consumeItem_);
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
			case 26u:
				consumeItem_.AddEntriesFrom(ref input, _repeated_consumeItem_codec);
				break;
			case 16u:
				EventScheduleId = input.ReadInt32();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
