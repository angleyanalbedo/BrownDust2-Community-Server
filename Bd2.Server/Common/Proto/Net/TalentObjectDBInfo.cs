using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TalentObjectDBInfo : IMessage<TalentObjectDBInfo>, IMessage, IEquatable<TalentObjectDBInfo>, IDeepCloneable<TalentObjectDBInfo>, IBufferMessage
{
	private static readonly MessageParser<TalentObjectDBInfo> _parser = new MessageParser<TalentObjectDBInfo>(() => new TalentObjectDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int TalentTypeFieldNumber = 1;

	private int talentType_;

	public const int ObjectIdFieldNumber = 2;

	private int objectId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TalentObjectDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TalentObjectDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TalentType
	{
		get
		{
			return talentType_;
		}
		set
		{
			talentType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectId
	{
		get
		{
			return objectId_;
		}
		set
		{
			objectId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentObjectDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentObjectDBInfo(TalentObjectDBInfo other)
		: this()
	{
		talentType_ = other.talentType_;
		objectId_ = other.objectId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentObjectDBInfo Clone()
	{
		return new TalentObjectDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TalentObjectDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TalentObjectDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (TalentType == other.TalentType && ObjectId == other.ObjectId)
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
		if (TalentType != 0)
		{
			num ^= TalentType.GetHashCode();
		}
		if (ObjectId != 0)
		{
			num ^= ObjectId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (TalentType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TalentType);
		}
		if (ObjectId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ObjectId);
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
		if (TalentType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentType);
		}
		if (ObjectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObjectId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TalentObjectDBInfo other)
	{
		if (other != null)
		{
			if (other.TalentType != 0)
			{
				TalentType = other.TalentType;
			}
			if (other.ObjectId != 0)
			{
				ObjectId = other.ObjectId;
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
				ObjectId = input.ReadInt32();
				break;
			case 8u:
				TalentType = input.ReadInt32();
				break;
			}
		}
	}
}
