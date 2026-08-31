using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventExchangeRewardRequest : IMessage<EventExchangeRewardRequest>, IMessage, IEquatable<EventExchangeRewardRequest>, IDeepCloneable<EventExchangeRewardRequest>, IBufferMessage
{
	private static readonly MessageParser<EventExchangeRewardRequest> _parser = new MessageParser<EventExchangeRewardRequest>(() => new EventExchangeRewardRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int EventUidFieldNumber = 2;

	private int eventUid_;

	public const int ExchangeCountFieldNumber = 3;

	private int exchangeCount_;

	public const int UseItemInfoFieldNumber = 4;

	private static readonly FieldCodec<ItemDBInfo> _repeated_useItemInfo_codec = FieldCodec.ForMessage(34u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> useItemInfo_ = new RepeatedField<ItemDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EventExchangeRewardRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EventExchangeRewardRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventUid
	{
		get
		{
			return eventUid_;
		}
		set
		{
			eventUid_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ExchangeCount
	{
		get
		{
			return exchangeCount_;
		}
		set
		{
			exchangeCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> UseItemInfo => useItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventExchangeRewardRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventExchangeRewardRequest(EventExchangeRewardRequest other)
		: this()
	{
		seq_ = other.seq_;
		eventUid_ = other.eventUid_;
		exchangeCount_ = other.exchangeCount_;
		useItemInfo_ = other.useItemInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventExchangeRewardRequest Clone()
	{
		return new EventExchangeRewardRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventExchangeRewardRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EventExchangeRewardRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && EventUid == other.EventUid && ExchangeCount == other.ExchangeCount && useItemInfo_.Equals(other.useItemInfo_))
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
		if (EventUid != 0)
		{
			num ^= EventUid.GetHashCode();
		}
		if (ExchangeCount != 0)
		{
			num ^= ExchangeCount.GetHashCode();
		}
		num ^= useItemInfo_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (EventUid != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventUid);
		}
		if (ExchangeCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ExchangeCount);
		}
		useItemInfo_.WriteTo(ref output, _repeated_useItemInfo_codec);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (EventUid != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventUid);
		}
		if (ExchangeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExchangeCount);
		}
		num += useItemInfo_.CalculateSize(_repeated_useItemInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventExchangeRewardRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.EventUid != 0)
			{
				EventUid = other.EventUid;
			}
			if (other.ExchangeCount != 0)
			{
				ExchangeCount = other.ExchangeCount;
			}
			useItemInfo_.Add(other.useItemInfo_);
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
			case 8u:
				Seq = input.ReadInt32();
				break;
			case 16u:
				EventUid = input.ReadInt32();
				break;
			case 24u:
				ExchangeCount = input.ReadInt32();
				break;
			case 34u:
				useItemInfo_.AddEntriesFrom(ref input, _repeated_useItemInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
