using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastlePingRequest : IMessage<EvilCastlePingRequest>, IMessage, IEquatable<EvilCastlePingRequest>, IDeepCloneable<EvilCastlePingRequest>, IBufferMessage
{
	private static readonly MessageParser<EvilCastlePingRequest> _parser = new MessageParser<EvilCastlePingRequest>(() => new EvilCastlePingRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int StageIndexFieldNumber = 2;

	private int stageIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastlePingRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastlePingRequestReflection.Descriptor.MessageTypes[0];

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
	public int StageIndex
	{
		get
		{
			return stageIndex_;
		}
		set
		{
			stageIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastlePingRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastlePingRequest(EvilCastlePingRequest other)
		: this()
	{
		seq_ = other.seq_;
		stageIndex_ = other.stageIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastlePingRequest Clone()
	{
		return new EvilCastlePingRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastlePingRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EvilCastlePingRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && StageIndex == other.StageIndex)
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
		if (StageIndex != 0)
		{
			num ^= StageIndex.GetHashCode();
		}
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
		if (StageIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(StageIndex);
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
		if (StageIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastlePingRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.StageIndex != 0)
			{
				StageIndex = other.StageIndex;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				StageIndex = input.ReadInt32();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
