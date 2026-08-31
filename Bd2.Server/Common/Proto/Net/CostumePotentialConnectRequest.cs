using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CostumePotentialConnectRequest : IMessage<CostumePotentialConnectRequest>, IMessage, IEquatable<CostumePotentialConnectRequest>, IDeepCloneable<CostumePotentialConnectRequest>, IBufferMessage
{
	private static readonly MessageParser<CostumePotentialConnectRequest> _parser = new MessageParser<CostumePotentialConnectRequest>(() => new CostumePotentialConnectRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int CostumePotentialConnectInfoFieldNumber = 2;

	private static readonly FieldCodec<CostumePotentialConnectInfo> _repeated_costumePotentialConnectInfo_codec = FieldCodec.ForMessage(18u, Bd2.Server.Common.Proto.Net.CostumePotentialConnectInfo.Parser);

	private readonly RepeatedField<CostumePotentialConnectInfo> costumePotentialConnectInfo_ = new RepeatedField<CostumePotentialConnectInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CostumePotentialConnectRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumePotentialConnectRequestReflection.Descriptor.MessageTypes[1];

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
	public RepeatedField<CostumePotentialConnectInfo> CostumePotentialConnectInfo => costumePotentialConnectInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumePotentialConnectRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumePotentialConnectRequest(CostumePotentialConnectRequest other)
		: this()
	{
		seq_ = other.seq_;
		costumePotentialConnectInfo_ = other.costumePotentialConnectInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumePotentialConnectRequest Clone()
	{
		return new CostumePotentialConnectRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CostumePotentialConnectRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumePotentialConnectRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && costumePotentialConnectInfo_.Equals(other.costumePotentialConnectInfo_))
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
		num ^= costumePotentialConnectInfo_.GetHashCode();
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
		costumePotentialConnectInfo_.WriteTo(ref output, _repeated_costumePotentialConnectInfo_codec);
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
		num += costumePotentialConnectInfo_.CalculateSize(_repeated_costumePotentialConnectInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CostumePotentialConnectRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			costumePotentialConnectInfo_.Add(other.costumePotentialConnectInfo_);
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
			case 18u:
				costumePotentialConnectInfo_.AddEntriesFrom(ref input, _repeated_costumePotentialConnectInfo_codec);
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
