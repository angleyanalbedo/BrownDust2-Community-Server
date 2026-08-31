using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TotalWarRewardTable : IMessage<TotalWarRewardTable>, IMessage, IEquatable<TotalWarRewardTable>, IDeepCloneable<TotalWarRewardTable>, IBufferMessage
{
	private static readonly MessageParser<TotalWarRewardTable> _parser = new MessageParser<TotalWarRewardTable>(() => new TotalWarRewardTable());

	private UnknownFieldSet _unknownFields;

	public const int BossIdleAnimFieldNumber = 1;

	private string bossIdleAnim_ = "";

	public const int IdFieldNumber = 2;

	private int id_;

	public const int RewardCountFieldNumber = 3;

	private int rewardCount_;

	public const int RewardIdFieldNumber = 4;

	private int rewardId_;

	public const int RewardTypeFieldNumber = 5;

	private int rewardType_;

	public const int ScoreFieldNumber = 6;

	private int score_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TotalWarRewardTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TotalWarRewardTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BossIdleAnim
	{
		get
		{
			return bossIdleAnim_;
		}
		set
		{
			bossIdleAnim_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public int Score
	{
		get
		{
			return score_;
		}
		set
		{
			score_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarRewardTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarRewardTable(TotalWarRewardTable other)
		: this()
	{
		bossIdleAnim_ = other.bossIdleAnim_;
		id_ = other.id_;
		rewardCount_ = other.rewardCount_;
		rewardId_ = other.rewardId_;
		rewardType_ = other.rewardType_;
		score_ = other.score_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarRewardTable Clone()
	{
		return new TotalWarRewardTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarRewardTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TotalWarRewardTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(BossIdleAnim != other.BossIdleAnim) && Id == other.Id && RewardCount == other.RewardCount && RewardId == other.RewardId && RewardType == other.RewardType && Score == other.Score)
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
		if (BossIdleAnim.Length != 0)
		{
			num ^= BossIdleAnim.GetHashCode();
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
		if (Score != 0)
		{
			num ^= Score.GetHashCode();
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
		if (BossIdleAnim.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BossIdleAnim);
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
		if (Score != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Score);
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
		if (BossIdleAnim.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BossIdleAnim);
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
		if (Score != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Score);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TotalWarRewardTable other)
	{
		if (other != null)
		{
			if (other.BossIdleAnim.Length != 0)
			{
				BossIdleAnim = other.BossIdleAnim;
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
			if (other.Score != 0)
			{
				Score = other.Score;
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
			case 10u:
				BossIdleAnim = input.ReadString();
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
				Score = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
