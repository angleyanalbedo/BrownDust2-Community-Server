using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharLevelUpRequest : IMessage<CharLevelUpRequest>, IMessage, IEquatable<CharLevelUpRequest>, IDeepCloneable<CharLevelUpRequest>, IBufferMessage
{
	private static readonly MessageParser<CharLevelUpRequest> _parser = new MessageParser<CharLevelUpRequest>(() => new CharLevelUpRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int InvenIndexFieldNumber = 2;

	private long invenIndex_;

	public const int HolyWaterInfoFieldNumber = 3;

	private static readonly FieldCodec<ItemDBInfo> _repeated_holyWaterInfo_codec = FieldCodec.ForMessage(26u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> holyWaterInfo_ = new RepeatedField<ItemDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharLevelUpRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharLevelUpRequestReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<ItemDBInfo> HolyWaterInfo => holyWaterInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharLevelUpRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharLevelUpRequest(CharLevelUpRequest other)
		: this()
	{
		seq_ = other.seq_;
		invenIndex_ = other.invenIndex_;
		holyWaterInfo_ = other.holyWaterInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharLevelUpRequest Clone()
	{
		return new CharLevelUpRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharLevelUpRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharLevelUpRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && InvenIndex == other.InvenIndex && holyWaterInfo_.Equals(other.holyWaterInfo_))
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
		num ^= holyWaterInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
		holyWaterInfo_.WriteTo(ref output, _repeated_holyWaterInfo_codec);
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
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		num += holyWaterInfo_.CalculateSize(_repeated_holyWaterInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharLevelUpRequest other)
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
			holyWaterInfo_.Add(other.holyWaterInfo_);
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
				holyWaterInfo_.AddEntriesFrom(ref input, _repeated_holyWaterInfo_codec);
				break;
			case 16u:
				InvenIndex = input.ReadInt64();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
