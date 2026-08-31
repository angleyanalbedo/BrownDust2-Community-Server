using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectRespawnRequest : IMessage<FieldObjectRespawnRequest>, IMessage, IEquatable<FieldObjectRespawnRequest>, IDeepCloneable<FieldObjectRespawnRequest>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectRespawnRequest> _parser = new MessageParser<FieldObjectRespawnRequest>(() => new FieldObjectRespawnRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PackIdFieldNumber = 2;

	private int packId_;

	public const int FieldObjectGroupIdFieldNumber = 3;

	private int fieldObjectGroupId_;

	public const int FieldObjectTypeFieldNumber = 4;

	private int fieldObjectType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FieldObjectRespawnRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldObjectRespawnRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FieldObjectType
	{
		get
		{
			return fieldObjectType_;
		}
		set
		{
			fieldObjectType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectRespawnRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectRespawnRequest(FieldObjectRespawnRequest other)
		: this()
	{
		seq_ = other.seq_;
		packId_ = other.packId_;
		fieldObjectGroupId_ = other.fieldObjectGroupId_;
		fieldObjectType_ = other.fieldObjectType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectRespawnRequest Clone()
	{
		return new FieldObjectRespawnRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectRespawnRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FieldObjectRespawnRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && PackId == other.PackId && FieldObjectGroupId == other.FieldObjectGroupId && FieldObjectType == other.FieldObjectType)
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
		if (FieldObjectType != 0)
		{
			num ^= FieldObjectType.GetHashCode();
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
		if (FieldObjectType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(FieldObjectType);
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
		if (FieldObjectType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldObjectType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldObjectRespawnRequest other)
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
			if (other.FieldObjectType != 0)
			{
				FieldObjectType = other.FieldObjectType;
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
				FieldObjectType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
