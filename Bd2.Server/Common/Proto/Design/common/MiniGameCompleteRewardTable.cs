using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MiniGameCompleteRewardTable : IMessage<MiniGameCompleteRewardTable>, IMessage, IEquatable<MiniGameCompleteRewardTable>, IDeepCloneable<MiniGameCompleteRewardTable>, IBufferMessage
{
	private static readonly MessageParser<MiniGameCompleteRewardTable> _parser = new MessageParser<MiniGameCompleteRewardTable>(() => new MiniGameCompleteRewardTable());

	private UnknownFieldSet _unknownFields;

	public const int CompleteCountFieldNumber = 1;

	private int completeCount_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int RewardItemCountFieldNumber = 4;

	private int rewardItemCount_;

	public const int RewardItemIdFieldNumber = 5;

	private int rewardItemId_;

	public const int RewardItemTypeFieldNumber = 6;

	private int rewardItemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameCompleteRewardTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameCompleteRewardTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CompleteCount
	{
		get
		{
			return completeCount_;
		}
		set
		{
			completeCount_ = value;
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
	public int RewardItemCount
	{
		get
		{
			return rewardItemCount_;
		}
		set
		{
			rewardItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardItemId
	{
		get
		{
			return rewardItemId_;
		}
		set
		{
			rewardItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardItemType
	{
		get
		{
			return rewardItemType_;
		}
		set
		{
			rewardItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameCompleteRewardTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameCompleteRewardTable(MiniGameCompleteRewardTable other)
		: this()
	{
		completeCount_ = other.completeCount_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		rewardItemCount_ = other.rewardItemCount_;
		rewardItemId_ = other.rewardItemId_;
		rewardItemType_ = other.rewardItemType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameCompleteRewardTable Clone()
	{
		return new MiniGameCompleteRewardTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameCompleteRewardTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameCompleteRewardTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CompleteCount == other.CompleteCount && GroupId == other.GroupId && Id == other.Id && RewardItemCount == other.RewardItemCount && RewardItemId == other.RewardItemId && RewardItemType == other.RewardItemType)
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
		if (CompleteCount != 0)
		{
			num ^= CompleteCount.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RewardItemCount != 0)
		{
			num ^= RewardItemCount.GetHashCode();
		}
		if (RewardItemId != 0)
		{
			num ^= RewardItemId.GetHashCode();
		}
		if (RewardItemType != 0)
		{
			num ^= RewardItemType.GetHashCode();
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
		if (CompleteCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CompleteCount);
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
		if (RewardItemCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RewardItemCount);
		}
		if (RewardItemId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(RewardItemId);
		}
		if (RewardItemType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RewardItemType);
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
		if (CompleteCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompleteCount);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RewardItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemCount);
		}
		if (RewardItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemId);
		}
		if (RewardItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameCompleteRewardTable other)
	{
		if (other != null)
		{
			if (other.CompleteCount != 0)
			{
				CompleteCount = other.CompleteCount;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RewardItemCount != 0)
			{
				RewardItemCount = other.RewardItemCount;
			}
			if (other.RewardItemId != 0)
			{
				RewardItemId = other.RewardItemId;
			}
			if (other.RewardItemType != 0)
			{
				RewardItemType = other.RewardItemType;
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
				CompleteCount = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				RewardItemCount = input.ReadInt32();
				break;
			case 40u:
				RewardItemId = input.ReadInt32();
				break;
			case 48u:
				RewardItemType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
