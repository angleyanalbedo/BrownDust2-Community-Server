using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class AttendanceAlwaysRewardTable : IMessage<AttendanceAlwaysRewardTable>, IMessage, IEquatable<AttendanceAlwaysRewardTable>, IDeepCloneable<AttendanceAlwaysRewardTable>, IBufferMessage
{
	private static readonly MessageParser<AttendanceAlwaysRewardTable> _parser = new MessageParser<AttendanceAlwaysRewardTable>(() => new AttendanceAlwaysRewardTable());

	private UnknownFieldSet _unknownFields;

	public const int AttendanceCountFieldNumber = 1;

	private int attendanceCount_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int RewardCountFieldNumber = 4;

	private int rewardCount_;

	public const int RewardIdFieldNumber = 5;

	private int rewardId_;

	public const int RewardTypeFieldNumber = 6;

	private int rewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AttendanceAlwaysRewardTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AttendanceAlwaysRewardTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttendanceCount
	{
		get
		{
			return attendanceCount_;
		}
		set
		{
			attendanceCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardCount
	{
		get
		{
			return rewardCount_;
		}
		set
		{
			rewardCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardType
	{
		get
		{
			return rewardType_;
		}
		set
		{
			rewardType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysRewardTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysRewardTable(AttendanceAlwaysRewardTable other)
		: this()
	{
		attendanceCount_ = other.attendanceCount_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		rewardCount_ = other.rewardCount_;
		rewardId_ = other.rewardId_;
		rewardType_ = other.rewardType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysRewardTable Clone()
	{
		return new AttendanceAlwaysRewardTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AttendanceAlwaysRewardTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AttendanceAlwaysRewardTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AttendanceCount == other.AttendanceCount && GroupId == other.GroupId && Id == other.Id && RewardCount == other.RewardCount && RewardId == other.RewardId && RewardType == other.RewardType)
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
		if (AttendanceCount != 0)
		{
			num ^= AttendanceCount.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RewardCount != 0)
		{
			num ^= RewardCount.GetHashCode();
		}
		if (RewardId != 0)
		{
			num ^= RewardId.GetHashCode();
		}
		if (RewardType != 0)
		{
			num ^= RewardType.GetHashCode();
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
		if (AttendanceCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AttendanceCount);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (RewardCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RewardCount);
		}
		if (RewardId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(RewardId);
		}
		if (RewardType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RewardType);
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
		if (AttendanceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttendanceCount);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RewardCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardCount);
		}
		if (RewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardId);
		}
		if (RewardType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AttendanceAlwaysRewardTable other)
	{
		if (other != null)
		{
			if (other.AttendanceCount != 0)
			{
				AttendanceCount = other.AttendanceCount;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RewardCount != 0)
			{
				RewardCount = other.RewardCount;
			}
			if (other.RewardId != 0)
			{
				RewardId = other.RewardId;
			}
			if (other.RewardType != 0)
			{
				RewardType = other.RewardType;
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
				AttendanceCount = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				RewardCount = input.ReadInt32();
				break;
			case 40u:
				RewardId = input.ReadInt32();
				break;
			case 48u:
				RewardType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
