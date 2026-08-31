using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class BingoLineRewardGroupTable : IMessage<BingoLineRewardGroupTable>, IMessage, IEquatable<BingoLineRewardGroupTable>, IDeepCloneable<BingoLineRewardGroupTable>, IBufferMessage
{
	private static readonly MessageParser<BingoLineRewardGroupTable> _parser = new MessageParser<BingoLineRewardGroupTable>(() => new BingoLineRewardGroupTable());

	private UnknownFieldSet _unknownFields;

	public const int ClearCountFieldNumber = 1;

	private int clearCount_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int LineIndexFieldNumber = 4;

	private int lineIndex_;

	public const int LineTypeFieldNumber = 5;

	private int lineType_;

	public const int RewardCountFieldNumber = 6;

	private int rewardCount_;

	public const int RewardIdFieldNumber = 7;

	private int rewardId_;

	public const int RewardTypeFieldNumber = 8;

	private int rewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BingoLineRewardGroupTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BingoLineRewardGroupTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClearCount
	{
		get
		{
			return clearCount_;
		}
		set
		{
			clearCount_ = value;
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
	public int LineIndex
	{
		get
		{
			return lineIndex_;
		}
		set
		{
			lineIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LineType
	{
		get
		{
			return lineType_;
		}
		set
		{
			lineType_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BingoLineRewardGroupTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BingoLineRewardGroupTable(BingoLineRewardGroupTable other)
		: this()
	{
		clearCount_ = other.clearCount_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		lineIndex_ = other.lineIndex_;
		lineType_ = other.lineType_;
		rewardCount_ = other.rewardCount_;
		rewardId_ = other.rewardId_;
		rewardType_ = other.rewardType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BingoLineRewardGroupTable Clone()
	{
		return new BingoLineRewardGroupTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BingoLineRewardGroupTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BingoLineRewardGroupTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ClearCount == other.ClearCount && GroupId == other.GroupId && Id == other.Id && LineIndex == other.LineIndex && LineType == other.LineType && RewardCount == other.RewardCount && RewardId == other.RewardId && RewardType == other.RewardType)
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
		if (ClearCount != 0)
		{
			num ^= ClearCount.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LineIndex != 0)
		{
			num ^= LineIndex.GetHashCode();
		}
		if (LineType != 0)
		{
			num ^= LineType.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (ClearCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ClearCount);
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
		if (LineIndex != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LineIndex);
		}
		if (LineType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(LineType);
		}
		if (RewardCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RewardCount);
		}
		if (RewardId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(RewardId);
		}
		if (RewardType != 0)
		{
			output.WriteRawTag(64);
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
		if (ClearCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearCount);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LineIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LineIndex);
		}
		if (LineType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LineType);
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
	public void MergeFrom(BingoLineRewardGroupTable other)
	{
		if (other != null)
		{
			if (other.ClearCount != 0)
			{
				ClearCount = other.ClearCount;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LineIndex != 0)
			{
				LineIndex = other.LineIndex;
			}
			if (other.LineType != 0)
			{
				LineType = other.LineType;
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
				ClearCount = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				LineIndex = input.ReadInt32();
				break;
			case 40u:
				LineType = input.ReadInt32();
				break;
			case 48u:
				RewardCount = input.ReadInt32();
				break;
			case 56u:
				RewardId = input.ReadInt32();
				break;
			case 64u:
				RewardType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
