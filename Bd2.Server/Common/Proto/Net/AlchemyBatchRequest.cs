using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class AlchemyBatchRequest : IMessage<AlchemyBatchRequest>, IMessage, IEquatable<AlchemyBatchRequest>, IDeepCloneable<AlchemyBatchRequest>, IBufferMessage
{
	private static readonly MessageParser<AlchemyBatchRequest> _parser = new MessageParser<AlchemyBatchRequest>(() => new AlchemyBatchRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int InvenIndexFieldNumber = 2;

	private long invenIndex_;

	public const int AlchemyIdFieldNumber = 3;

	private int alchemyId_;

	public const int AlchemyCountFieldNumber = 4;

	private int alchemyCount_;

	public const int ItemInfoFieldNumber = 5;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(42u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlchemyBatchRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => AlchemyBatchRequestReflection.Descriptor.MessageTypes[0];

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
	public long InvenIndex
	{
		get
		{
			return invenIndex_;
		}
		set
		{
			invenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AlchemyId
	{
		get
		{
			return alchemyId_;
		}
		set
		{
			alchemyId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AlchemyCount
	{
		get
		{
			return alchemyCount_;
		}
		set
		{
			alchemyCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlchemyBatchRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlchemyBatchRequest(AlchemyBatchRequest other)
		: this()
	{
		seq_ = other.seq_;
		invenIndex_ = other.invenIndex_;
		alchemyId_ = other.alchemyId_;
		alchemyCount_ = other.alchemyCount_;
		itemInfo_ = other.itemInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlchemyBatchRequest Clone()
	{
		return new AlchemyBatchRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as AlchemyBatchRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AlchemyBatchRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && InvenIndex == other.InvenIndex && AlchemyId == other.AlchemyId && AlchemyCount == other.AlchemyCount && itemInfo_.Equals(other.itemInfo_))
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
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (AlchemyId != 0)
		{
			num ^= AlchemyId.GetHashCode();
		}
		if (AlchemyCount != 0)
		{
			num ^= AlchemyCount.GetHashCode();
		}
		num ^= itemInfo_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(InvenIndex);
		}
		if (AlchemyId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AlchemyId);
		}
		if (AlchemyCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AlchemyCount);
		}
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
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
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (AlchemyId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AlchemyId);
		}
		if (AlchemyCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AlchemyCount);
		}
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlchemyBatchRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.AlchemyId != 0)
			{
				AlchemyId = other.AlchemyId;
			}
			if (other.AlchemyCount != 0)
			{
				AlchemyCount = other.AlchemyCount;
			}
			itemInfo_.Add(other.itemInfo_);
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				InvenIndex = input.ReadInt64();
				break;
			case 24u:
				AlchemyId = input.ReadInt32();
				break;
			case 32u:
				AlchemyCount = input.ReadInt32();
				break;
			case 42u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
