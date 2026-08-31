using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectRewardRequest : IMessage<FieldObjectRewardRequest>, IMessage, IEquatable<FieldObjectRewardRequest>, IDeepCloneable<FieldObjectRewardRequest>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectRewardRequest> _parser = new MessageParser<FieldObjectRewardRequest>(() => new FieldObjectRewardRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PackIdFieldNumber = 2;

	private int packId_;

	public const int FieldObjectGroupIdFieldNumber = 3;

	private int fieldObjectGroupId_;

	public const int FieldObjectIdFieldNumber = 4;

	private int fieldObjectId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldObjectRewardRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldObjectRewardRequestReflection.Descriptor.MessageTypes[0];

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
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FieldObjectGroupId
	{
		get
		{
			return fieldObjectGroupId_;
		}
		set
		{
			fieldObjectGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FieldObjectId
	{
		get
		{
			return fieldObjectId_;
		}
		set
		{
			fieldObjectId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectRewardRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectRewardRequest(FieldObjectRewardRequest other)
		: this()
	{
		seq_ = other.seq_;
		packId_ = other.packId_;
		fieldObjectGroupId_ = other.fieldObjectGroupId_;
		fieldObjectId_ = other.fieldObjectId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectRewardRequest Clone()
	{
		return new FieldObjectRewardRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectRewardRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FieldObjectRewardRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && PackId == other.PackId && FieldObjectGroupId == other.FieldObjectGroupId && FieldObjectId == other.FieldObjectId)
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
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (FieldObjectGroupId != 0)
		{
			num ^= FieldObjectGroupId.GetHashCode();
		}
		if (FieldObjectId != 0)
		{
			num ^= FieldObjectId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PackId);
		}
		if (FieldObjectGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(FieldObjectGroupId);
		}
		if (FieldObjectId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(FieldObjectId);
		}
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (FieldObjectGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldObjectGroupId);
		}
		if (FieldObjectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldObjectId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldObjectRewardRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.FieldObjectGroupId != 0)
			{
				FieldObjectGroupId = other.FieldObjectGroupId;
			}
			if (other.FieldObjectId != 0)
			{
				FieldObjectId = other.FieldObjectId;
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
			case 16u:
				PackId = input.ReadInt32();
				break;
			case 24u:
				FieldObjectGroupId = input.ReadInt32();
				break;
			case 32u:
				FieldObjectId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
