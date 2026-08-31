using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackClearRewardRequest : IMessage<PackClearRewardRequest>, IMessage, IEquatable<PackClearRewardRequest>, IDeepCloneable<PackClearRewardRequest>, IBufferMessage
{
	private static readonly MessageParser<PackClearRewardRequest> _parser = new MessageParser<PackClearRewardRequest>(() => new PackClearRewardRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int ClearInfoFieldNumber = 2;

	private PackClearRewardDBInfo clearInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackClearRewardRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackClearRewardRequestReflection.Descriptor.MessageTypes[0];

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
	public PackClearRewardDBInfo ClearInfo
	{
		get
		{
			return clearInfo_;
		}
		set
		{
			clearInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackClearRewardRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackClearRewardRequest(PackClearRewardRequest other)
		: this()
	{
		seq_ = other.seq_;
		clearInfo_ = ((other.clearInfo_ != null) ? other.clearInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackClearRewardRequest Clone()
	{
		return new PackClearRewardRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackClearRewardRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackClearRewardRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && object.Equals(ClearInfo, other.ClearInfo))
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
		if (clearInfo_ != null)
		{
			num ^= ClearInfo.GetHashCode();
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
		if (clearInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ClearInfo);
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
		if (clearInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ClearInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackClearRewardRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Seq != 0)
		{
			Seq = other.Seq;
		}
		if (other.clearInfo_ != null)
		{
			if (clearInfo_ == null)
			{
				ClearInfo = new PackClearRewardDBInfo();
			}
			ClearInfo.MergeFrom(other.ClearInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (clearInfo_ == null)
				{
					ClearInfo = new PackClearRewardDBInfo();
				}
				input.ReadMessage(ClearInfo);
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
