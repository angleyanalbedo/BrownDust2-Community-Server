using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntDispatchRequest : IMessage<HuntDispatchRequest>, IMessage, IEquatable<HuntDispatchRequest>, IDeepCloneable<HuntDispatchRequest>, IBufferMessage
{
	private static readonly MessageParser<HuntDispatchRequest> _parser = new MessageParser<HuntDispatchRequest>(() => new HuntDispatchRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int HuntDispatchGroupIdFieldNumber = 2;

	private int huntDispatchGroupId_;

	public const int HuntDispatchIdFieldNumber = 3;

	private int huntDispatchId_;

	public const int CountFieldNumber = 4;

	private int count_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HuntDispatchRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => HuntDispatchRequestReflection.Descriptor.MessageTypes[0];

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
	public int HuntDispatchGroupId
	{
		get
		{
			return huntDispatchGroupId_;
		}
		set
		{
			huntDispatchGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HuntDispatchId
	{
		get
		{
			return huntDispatchId_;
		}
		set
		{
			huntDispatchId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntDispatchRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntDispatchRequest(HuntDispatchRequest other)
		: this()
	{
		seq_ = other.seq_;
		huntDispatchGroupId_ = other.huntDispatchGroupId_;
		huntDispatchId_ = other.huntDispatchId_;
		count_ = other.count_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchRequest Clone()
	{
		return new HuntDispatchRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntDispatchRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HuntDispatchRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && HuntDispatchGroupId == other.HuntDispatchGroupId && HuntDispatchId == other.HuntDispatchId && Count == other.Count)
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
		if (HuntDispatchGroupId != 0)
		{
			num ^= HuntDispatchGroupId.GetHashCode();
		}
		if (HuntDispatchId != 0)
		{
			num ^= HuntDispatchId.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
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
		if (HuntDispatchGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(HuntDispatchGroupId);
		}
		if (HuntDispatchId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(HuntDispatchId);
		}
		if (Count != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Count);
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
		if (HuntDispatchGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HuntDispatchGroupId);
		}
		if (HuntDispatchId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HuntDispatchId);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Count);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HuntDispatchRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.HuntDispatchGroupId != 0)
			{
				HuntDispatchGroupId = other.HuntDispatchGroupId;
			}
			if (other.HuntDispatchId != 0)
			{
				HuntDispatchId = other.HuntDispatchId;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
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
			case 16u:
				HuntDispatchGroupId = input.ReadInt32();
				break;
			case 24u:
				HuntDispatchId = input.ReadInt32();
				break;
			case 32u:
				Count = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
