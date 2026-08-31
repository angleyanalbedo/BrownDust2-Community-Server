using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectRespawnDBInfo : IMessage<FieldObjectRespawnDBInfo>, IMessage, IEquatable<FieldObjectRespawnDBInfo>, IDeepCloneable<FieldObjectRespawnDBInfo>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectRespawnDBInfo> _parser = new MessageParser<FieldObjectRespawnDBInfo>(() => new FieldObjectRespawnDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int FieldObjectGroupIdFieldNumber = 1;

	private int fieldObjectGroupId_;

	public const int RespawnTimeFieldNumber = 2;

	private long respawnTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldObjectRespawnDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldObjectRespawnDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public long RespawnTime
	{
		get
		{
			return respawnTime_;
		}
		set
		{
			respawnTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectRespawnDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectRespawnDBInfo(FieldObjectRespawnDBInfo other)
		: this()
	{
		fieldObjectGroupId_ = other.fieldObjectGroupId_;
		respawnTime_ = other.respawnTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldObjectRespawnDBInfo Clone()
	{
		return new FieldObjectRespawnDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectRespawnDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldObjectRespawnDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (FieldObjectGroupId == other.FieldObjectGroupId && RespawnTime == other.RespawnTime)
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
		if (FieldObjectGroupId != 0)
		{
			num ^= FieldObjectGroupId.GetHashCode();
		}
		if (RespawnTime != 0L)
		{
			num ^= RespawnTime.GetHashCode();
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
		if (FieldObjectGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FieldObjectGroupId);
		}
		if (RespawnTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(RespawnTime);
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
		if (FieldObjectGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldObjectGroupId);
		}
		if (RespawnTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(RespawnTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldObjectRespawnDBInfo other)
	{
		if (other != null)
		{
			if (other.FieldObjectGroupId != 0)
			{
				FieldObjectGroupId = other.FieldObjectGroupId;
			}
			if (other.RespawnTime != 0L)
			{
				RespawnTime = other.RespawnTime;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				RespawnTime = input.ReadInt64();
				break;
			case 8u:
				FieldObjectGroupId = input.ReadInt32();
				break;
			}
		}
	}
}
