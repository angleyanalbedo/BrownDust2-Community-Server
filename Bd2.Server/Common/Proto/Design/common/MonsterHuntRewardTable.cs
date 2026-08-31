using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MonsterHuntRewardTable : IMessage<MonsterHuntRewardTable>, IMessage, IEquatable<MonsterHuntRewardTable>, IDeepCloneable<MonsterHuntRewardTable>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntRewardTable> _parser = new MessageParser<MonsterHuntRewardTable>(() => new MonsterHuntRewardTable());

	private UnknownFieldSet _unknownFields;

	public const int DailyRewardCountFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_dailyRewardCount_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> dailyRewardCount_ = new RepeatedField<int>();

	public const int DailyRewardIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_dailyRewardId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> dailyRewardId_ = new RepeatedField<int>();

	public const int DailyRewardTypeFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_dailyRewardType_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> dailyRewardType_ = new RepeatedField<int>();

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int LevelFieldNumber = 5;

	private int level_;

	public const int RewardCountFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntRewardTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterHuntRewardTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DailyRewardCount => dailyRewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DailyRewardId => dailyRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DailyRewardType => dailyRewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCount => rewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId => rewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardType => rewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntRewardTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntRewardTable(MonsterHuntRewardTable other)
		: this()
	{
		dailyRewardCount_ = other.dailyRewardCount_.Clone();
		dailyRewardId_ = other.dailyRewardId_.Clone();
		dailyRewardType_ = other.dailyRewardType_.Clone();
		groupId_ = other.groupId_;
		level_ = other.level_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntRewardTable Clone()
	{
		return new MonsterHuntRewardTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntRewardTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntRewardTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (dailyRewardCount_.Equals(other.dailyRewardCount_) && dailyRewardId_.Equals(other.dailyRewardId_) && dailyRewardType_.Equals(other.dailyRewardType_) && GroupId == other.GroupId && Level == other.Level && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_))
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
		num ^= dailyRewardCount_.GetHashCode();
		num ^= dailyRewardId_.GetHashCode();
		num ^= dailyRewardType_.GetHashCode();
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
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
		dailyRewardCount_.WriteTo(ref output, _repeated_dailyRewardCount_codec);
		dailyRewardId_.WriteTo(ref output, _repeated_dailyRewardId_codec);
		dailyRewardType_.WriteTo(ref output, _repeated_dailyRewardType_codec);
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (Level != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Level);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
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
		num += dailyRewardCount_.CalculateSize(_repeated_dailyRewardCount_codec);
		num += dailyRewardId_.CalculateSize(_repeated_dailyRewardId_codec);
		num += dailyRewardType_.CalculateSize(_repeated_dailyRewardType_codec);
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntRewardTable other)
	{
		if (other != null)
		{
			dailyRewardCount_.Add(other.dailyRewardCount_);
			dailyRewardId_.Add(other.dailyRewardId_);
			dailyRewardType_.Add(other.dailyRewardType_);
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
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
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				dailyRewardType_.AddEntriesFrom(ref input, _repeated_dailyRewardType_codec);
				break;
			case 8u:
			case 10u:
				dailyRewardCount_.AddEntriesFrom(ref input, _repeated_dailyRewardCount_codec);
				break;
			case 16u:
			case 18u:
				dailyRewardId_.AddEntriesFrom(ref input, _repeated_dailyRewardId_codec);
				break;
			case 40u:
				Level = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 56u:
			case 58u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 64u:
			case 66u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
