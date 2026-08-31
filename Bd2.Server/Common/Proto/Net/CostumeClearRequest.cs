using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CostumeClearRequest : IMessage<CostumeClearRequest>, IMessage, IEquatable<CostumeClearRequest>, IDeepCloneable<CostumeClearRequest>, IBufferMessage
{
	private static readonly MessageParser<CostumeClearRequest> _parser = new MessageParser<CostumeClearRequest>(() => new CostumeClearRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int CostumeIndexFieldNumber = 2;

	private long costumeIndex_;

	public const int CharIndexFieldNumber = 3;

	private long charIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CostumeClearRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumeClearRequestReflection.Descriptor.MessageTypes[0];

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
	public long CostumeIndex
	{
		get
		{
			return costumeIndex_;
		}
		set
		{
			costumeIndex_ = value;
		}
	}

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeClearRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeClearRequest(CostumeClearRequest other)
		: this()
	{
		seq_ = other.seq_;
		costumeIndex_ = other.costumeIndex_;
		charIndex_ = other.charIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeClearRequest Clone()
	{
		return new CostumeClearRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeClearRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumeClearRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && CostumeIndex == other.CostumeIndex && CharIndex == other.CharIndex)
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
		if (CostumeIndex != 0L)
		{
			num ^= CostumeIndex.GetHashCode();
		}
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
		if (CostumeIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(CostumeIndex);
		}
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
		if (CostumeIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CostumeIndex);
		}
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
	public void MergeFrom(CostumeClearRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.CostumeIndex != 0L)
			{
				CostumeIndex = other.CostumeIndex;
			}
			if (other.CharIndex != 0L)
			{
				CharIndex = other.CharIndex;
			}
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
			case 24u:
				CharIndex = input.ReadInt64();
				break;
			case 16u:
				CostumeIndex = input.ReadInt64();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
