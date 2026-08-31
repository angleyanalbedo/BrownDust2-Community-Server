using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class AttendanceLimitInfo : IMessage<AttendanceLimitInfo>, IMessage, IEquatable<AttendanceLimitInfo>, IDeepCloneable<AttendanceLimitInfo>, IBufferMessage
{
	private static readonly MessageParser<AttendanceLimitInfo> _parser = new MessageParser<AttendanceLimitInfo>(() => new AttendanceLimitInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int RewardIdFieldNumber = 2;

	private int rewardId_;

	public const int RewardDateFieldNumber = 3;

	private string rewardDate_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AttendanceLimitInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AttendanceEventInfoReflection.Descriptor.MessageTypes[2];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardId
	{
		get
		{
			return rewardId_;
		}
		set
		{
			rewardId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RewardDate
	{
		get
		{
			return rewardDate_;
		}
		set
		{
			rewardDate_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AttendanceLimitInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AttendanceLimitInfo(AttendanceLimitInfo other)
		: this()
	{
		id_ = other.id_;
		rewardId_ = other.rewardId_;
		rewardDate_ = other.rewardDate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceLimitInfo Clone()
	{
		return new AttendanceLimitInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AttendanceLimitInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AttendanceLimitInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && RewardId == other.RewardId && !(RewardDate != other.RewardDate))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RewardId != 0)
		{
			num ^= RewardId.GetHashCode();
		}
		if (RewardDate.Length != 0)
		{
			num ^= RewardDate.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (RewardId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RewardId);
		}
		if (RewardDate.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(RewardDate);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardId);
		}
		if (RewardDate.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RewardDate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AttendanceLimitInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RewardId != 0)
			{
				RewardId = other.RewardId;
			}
			if (other.RewardDate.Length != 0)
			{
				RewardDate = other.RewardDate;
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
			case 26u:
				RewardDate = input.ReadString();
				break;
			case 16u:
				RewardId = input.ReadInt32();
				break;
			case 8u:
				Id = input.ReadInt32();
				break;
			}
		}
	}
}
