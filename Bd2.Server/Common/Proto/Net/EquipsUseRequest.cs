using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipsUseRequest : IMessage<EquipsUseRequest>, IMessage, IEquatable<EquipsUseRequest>, IDeepCloneable<EquipsUseRequest>, IBufferMessage
{
	private static readonly MessageParser<EquipsUseRequest> _parser = new MessageParser<EquipsUseRequest>(() => new EquipsUseRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int EquipIndexFieldNumber = 2;

	private static readonly FieldCodec<long> _repeated_equipIndex_codec = FieldCodec.ForInt64(18u);

	private readonly RepeatedField<long> equipIndex_ = new RepeatedField<long>();

	public const int CharIndexFieldNumber = 3;

	private long charIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipsUseRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipsUseRequestReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<long> EquipIndex => equipIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharIndex
	{
		get
		{
			return charIndex_;
		}
		set
		{
			charIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipsUseRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipsUseRequest(EquipsUseRequest other)
		: this()
	{
		seq_ = other.seq_;
		equipIndex_ = other.equipIndex_.Clone();
		charIndex_ = other.charIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipsUseRequest Clone()
	{
		return new EquipsUseRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipsUseRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipsUseRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && equipIndex_.Equals(other.equipIndex_) && CharIndex == other.CharIndex)
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
		num ^= equipIndex_.GetHashCode();
		if (CharIndex != 0L)
		{
			num ^= CharIndex.GetHashCode();
		}
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		equipIndex_.WriteTo(ref output, _repeated_equipIndex_codec);
		if (CharIndex != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(CharIndex);
		}
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
		num += equipIndex_.CalculateSize(_repeated_equipIndex_codec);
		if (CharIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CharIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipsUseRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			equipIndex_.Add(other.equipIndex_);
			if (other.CharIndex != 0L)
			{
				CharIndex = other.CharIndex;
			}
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
			case 8u:
				Seq = input.ReadInt32();
				break;
			case 24u:
				CharIndex = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				equipIndex_.AddEntriesFrom(ref input, _repeated_equipIndex_codec);
				break;
			}
		}
	}
}
