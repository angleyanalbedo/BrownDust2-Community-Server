using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharAwakeActiveRequest : IMessage<CharAwakeActiveRequest>, IMessage, IEquatable<CharAwakeActiveRequest>, IDeepCloneable<CharAwakeActiveRequest>, IBufferMessage
{
	private static readonly MessageParser<CharAwakeActiveRequest> _parser = new MessageParser<CharAwakeActiveRequest>(() => new CharAwakeActiveRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int CharInvenIndexFieldNumber = 2;

	private long charInvenIndex_;

	public const int ItemInfoFieldNumber = 3;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(26u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharAwakeActiveRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CharAwakeActiveRequestReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharInvenIndex
	{
		get
		{
			return charInvenIndex_;
		}
		set
		{
			charInvenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharAwakeActiveRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharAwakeActiveRequest(CharAwakeActiveRequest other)
		: this()
	{
		seq_ = other.seq_;
		charInvenIndex_ = other.charInvenIndex_;
		itemInfo_ = other.itemInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharAwakeActiveRequest Clone()
	{
		return new CharAwakeActiveRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharAwakeActiveRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharAwakeActiveRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && CharInvenIndex == other.CharInvenIndex && itemInfo_.Equals(other.itemInfo_))
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
		if (CharInvenIndex != 0L)
		{
			num ^= CharInvenIndex.GetHashCode();
		}
		num ^= itemInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (CharInvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(CharInvenIndex);
		}
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
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
		if (CharInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CharInvenIndex);
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
	public void MergeFrom(CharAwakeActiveRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.CharInvenIndex != 0L)
			{
				CharInvenIndex = other.CharInvenIndex;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			case 16u:
				CharInvenIndex = input.ReadInt64();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
