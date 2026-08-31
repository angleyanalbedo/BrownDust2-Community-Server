using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MissionSectionRewardTable : IMessage<MissionSectionRewardTable>, IMessage, IEquatable<MissionSectionRewardTable>, IDeepCloneable<MissionSectionRewardTable>, IBufferMessage
{
	private static readonly MessageParser<MissionSectionRewardTable> _parser = new MessageParser<MissionSectionRewardTable>(() => new MissionSectionRewardTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupTypeFieldNumber = 1;

	private int groupType_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int RewardCountFieldNumber = 3;

	private int rewardCount_;

	public const int RewardIdFieldNumber = 4;

	private int rewardId_;

	public const int RewardTypeFieldNumber = 5;

	private int rewardType_;

	public const int SectionValueFieldNumber = 6;

	private int sectionValue_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MissionSectionRewardTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionSectionRewardTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GroupType
	{
		get
		{
			return groupType_;
		}
		set
		{
			groupType_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SectionValue
	{
		get
		{
			return sectionValue_;
		}
		set
		{
			sectionValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSectionRewardTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSectionRewardTable(MissionSectionRewardTable other)
		: this()
	{
		groupType_ = other.groupType_;
		id_ = other.id_;
		rewardCount_ = other.rewardCount_;
		rewardId_ = other.rewardId_;
		rewardType_ = other.rewardType_;
		sectionValue_ = other.sectionValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSectionRewardTable Clone()
	{
		return new MissionSectionRewardTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MissionSectionRewardTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionSectionRewardTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupType == other.GroupType && Id == other.Id && RewardCount == other.RewardCount && RewardId == other.RewardId && RewardType == other.RewardType && SectionValue == other.SectionValue)
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
		if (GroupType != 0)
		{
			num ^= GroupType.GetHashCode();
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
		if (SectionValue != 0)
		{
			num ^= SectionValue.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (GroupType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (RewardCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RewardCount);
		}
		if (RewardId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RewardId);
		}
		if (RewardType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(RewardType);
		}
		if (SectionValue != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SectionValue);
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
		if (GroupType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupType);
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
		if (SectionValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SectionValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MissionSectionRewardTable other)
	{
		if (other != null)
		{
			if (other.GroupType != 0)
			{
				GroupType = other.GroupType;
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
			if (other.SectionValue != 0)
			{
				SectionValue = other.SectionValue;
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
				GroupType = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				RewardCount = input.ReadInt32();
				break;
			case 32u:
				RewardId = input.ReadInt32();
				break;
			case 40u:
				RewardType = input.ReadInt32();
				break;
			case 48u:
				SectionValue = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
