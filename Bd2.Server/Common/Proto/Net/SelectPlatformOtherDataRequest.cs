using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SelectPlatformOtherDataRequest : IMessage<SelectPlatformOtherDataRequest>, IMessage, IEquatable<SelectPlatformOtherDataRequest>, IDeepCloneable<SelectPlatformOtherDataRequest>, IBufferMessage
{
	private static readonly MessageParser<SelectPlatformOtherDataRequest> _parser = new MessageParser<SelectPlatformOtherDataRequest>(() => new SelectPlatformOtherDataRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int MemberIdFieldNumber = 2;

	private string memberId_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectPlatformOtherDataRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectPlatformOtherDataRequestReflection.Descriptor.MessageTypes[0];

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
	public string MemberId
	{
		get
		{
			return memberId_;
		}
		set
		{
			memberId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPlatformOtherDataRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SelectPlatformOtherDataRequest(SelectPlatformOtherDataRequest other)
		: this()
	{
		seq_ = other.seq_;
		memberId_ = other.memberId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPlatformOtherDataRequest Clone()
	{
		return new SelectPlatformOtherDataRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SelectPlatformOtherDataRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectPlatformOtherDataRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && !(MemberId != other.MemberId))
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (MemberId.Length != 0)
		{
			num ^= MemberId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (MemberId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MemberId);
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
		if (MemberId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MemberId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelectPlatformOtherDataRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.MemberId.Length != 0)
			{
				MemberId = other.MemberId;
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
			case 18u:
				MemberId = input.ReadString();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
