using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntDispatchRewardPreviewRequest : IMessage<HuntDispatchRewardPreviewRequest>, IMessage, IEquatable<HuntDispatchRewardPreviewRequest>, IDeepCloneable<HuntDispatchRewardPreviewRequest>, IBufferMessage
{
	private static readonly MessageParser<HuntDispatchRewardPreviewRequest> _parser = new MessageParser<HuntDispatchRewardPreviewRequest>(() => new HuntDispatchRewardPreviewRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int HuntDispatchGroupIdFieldNumber = 2;

	private int huntDispatchGroupId_;

	public const int HuntDispatchIdFieldNumber = 3;

	private int huntDispatchId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HuntDispatchRewardPreviewRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HuntDispatchRewardPreviewRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public HuntDispatchRewardPreviewRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchRewardPreviewRequest(HuntDispatchRewardPreviewRequest other)
		: this()
	{
		seq_ = other.seq_;
		huntDispatchGroupId_ = other.huntDispatchGroupId_;
		huntDispatchId_ = other.huntDispatchId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntDispatchRewardPreviewRequest Clone()
	{
		return new HuntDispatchRewardPreviewRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as HuntDispatchRewardPreviewRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HuntDispatchRewardPreviewRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && HuntDispatchGroupId == other.HuntDispatchGroupId && HuntDispatchId == other.HuntDispatchId)
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
		if (HuntDispatchGroupId != 0)
		{
			num ^= HuntDispatchGroupId.GetHashCode();
		}
		if (HuntDispatchId != 0)
		{
			num ^= HuntDispatchId.GetHashCode();
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HuntDispatchRewardPreviewRequest other)
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
				HuntDispatchId = input.ReadInt32();
				break;
			case 16u:
				HuntDispatchGroupId = input.ReadInt32();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
