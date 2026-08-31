using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackRewardObjectCountRequest : IMessage<PackRewardObjectCountRequest>, IMessage, IEquatable<PackRewardObjectCountRequest>, IDeepCloneable<PackRewardObjectCountRequest>, IBufferMessage
{
	private static readonly MessageParser<PackRewardObjectCountRequest> _parser = new MessageParser<PackRewardObjectCountRequest>(() => new PackRewardObjectCountRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PackIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_packId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> packId_ = new RepeatedField<int>();

	public const int CountTypeFieldNumber = 3;

	private static readonly FieldCodec<Define_PackRewardObjectCountType> _repeated_countType_codec = FieldCodec.ForEnum(26u, (Define_PackRewardObjectCountType x) => (int)x, (int x) => (Define_PackRewardObjectCountType)x);

	private readonly RepeatedField<Define_PackRewardObjectCountType> countType_ = new RepeatedField<Define_PackRewardObjectCountType>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackRewardObjectCountRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackRewardObjectCountRequestReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<int> PackId => packId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Define_PackRewardObjectCountType> CountType => countType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackRewardObjectCountRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackRewardObjectCountRequest(PackRewardObjectCountRequest other)
		: this()
	{
		seq_ = other.seq_;
		packId_ = other.packId_.Clone();
		countType_ = other.countType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackRewardObjectCountRequest Clone()
	{
		return new PackRewardObjectCountRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackRewardObjectCountRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackRewardObjectCountRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && packId_.Equals(other.packId_) && countType_.Equals(other.countType_))
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
		num ^= packId_.GetHashCode();
		num ^= countType_.GetHashCode();
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
		packId_.WriteTo(ref output, _repeated_packId_codec);
		countType_.WriteTo(ref output, _repeated_countType_codec);
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
		num += packId_.CalculateSize(_repeated_packId_codec);
		num += countType_.CalculateSize(_repeated_countType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackRewardObjectCountRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			packId_.Add(other.packId_);
			countType_.Add(other.countType_);
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
			case 24u:
			case 26u:
				countType_.AddEntriesFrom(ref input, _repeated_countType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				packId_.AddEntriesFrom(ref input, _repeated_packId_codec);
				break;
			}
		}
	}
}
