using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PassRewardDBInfo : IMessage<PassRewardDBInfo>, IMessage, IEquatable<PassRewardDBInfo>, IDeepCloneable<PassRewardDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PassRewardDBInfo> _parser = new MessageParser<PassRewardDBInfo>(() => new PassRewardDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int PassIdFieldNumber = 1;

	private int passId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int BasicFieldNumber = 3;

	private bool basic_;

	public const int Premium1FieldNumber = 4;

	private bool premium1_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PassRewardDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PassRewardDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Basic
	{
		get
		{
			return basic_;
		}
		set
		{
			basic_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Premium1
	{
		get
		{
			return premium1_;
		}
		set
		{
			premium1_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PassRewardDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassRewardDBInfo(PassRewardDBInfo other)
		: this()
	{
		passId_ = other.passId_;
		id_ = other.id_;
		basic_ = other.basic_;
		premium1_ = other.premium1_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassRewardDBInfo Clone()
	{
		return new PassRewardDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PassRewardDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PassRewardDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PassId == other.PassId && Id == other.Id && Basic == other.Basic && Premium1 == other.Premium1)
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
		if (PassId != 0)
		{
			num ^= PassId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Basic)
		{
			num ^= Basic.GetHashCode();
		}
		if (Premium1)
		{
			num ^= Premium1.GetHashCode();
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
		if (PassId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PassId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (Basic)
		{
			output.WriteRawTag(24);
			output.WriteBool(Basic);
		}
		if (Premium1)
		{
			output.WriteRawTag(32);
			output.WriteBool(Premium1);
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
		if (PassId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Basic)
		{
			num += 2;
		}
		if (Premium1)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PassRewardDBInfo other)
	{
		if (other != null)
		{
			if (other.PassId != 0)
			{
				PassId = other.PassId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Basic)
			{
				Basic = other.Basic;
			}
			if (other.Premium1)
			{
				Premium1 = other.Premium1;
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
			case 8u:
				PassId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				Basic = input.ReadBool();
				break;
			case 32u:
				Premium1 = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
