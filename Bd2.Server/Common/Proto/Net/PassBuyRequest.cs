using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PassBuyRequest : IMessage<PassBuyRequest>, IMessage, IEquatable<PassBuyRequest>, IDeepCloneable<PassBuyRequest>, IBufferMessage
{
	private static readonly MessageParser<PassBuyRequest> _parser = new MessageParser<PassBuyRequest>(() => new PassBuyRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PassIdFieldNumber = 2;

	private int passId_;

	public const int PassBuyTypeFieldNumber = 3;

	private Define_PassBuyType passBuyType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PassBuyRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PassBuyRequestReflection.Descriptor.MessageTypes[0];

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
	public int PassId
	{
		get
		{
			return passId_;
		}
		set
		{
			passId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_PassBuyType PassBuyType
	{
		get
		{
			return passBuyType_;
		}
		set
		{
			passBuyType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassBuyRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PassBuyRequest(PassBuyRequest other)
		: this()
	{
		seq_ = other.seq_;
		passId_ = other.passId_;
		passBuyType_ = other.passBuyType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassBuyRequest Clone()
	{
		return new PassBuyRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PassBuyRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PassBuyRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && PassId == other.PassId && PassBuyType == other.PassBuyType)
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
		if (PassId != 0)
		{
			num ^= PassId.GetHashCode();
		}
		if (PassBuyType != Define_PassBuyType.PbLevel)
		{
			num ^= PassBuyType.GetHashCode();
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
		if (PassId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PassId);
		}
		if (PassBuyType != Define_PassBuyType.PbLevel)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)PassBuyType);
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
		if (PassId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassId);
		}
		if (PassBuyType != Define_PassBuyType.PbLevel)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PassBuyType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PassBuyRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.PassId != 0)
			{
				PassId = other.PassId;
			}
			if (other.PassBuyType != Define_PassBuyType.PbLevel)
			{
				PassBuyType = other.PassBuyType;
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
			case 24u:
				PassBuyType = (Define_PassBuyType)input.ReadEnum();
				break;
			case 16u:
				PassId = input.ReadInt32();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
