using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MissionTable : IMessage<MissionTable>, IMessage, IEquatable<MissionTable>, IDeepCloneable<MissionTable>, IBufferMessage
{
	private static readonly MessageParser<MissionTable> _parser = new MessageParser<MissionTable>(() => new MissionTable());

	private UnknownFieldSet _unknownFields;

	public const int ConditionSubTypeFieldNumber = 1;

	private int conditionSubType_;

	public const int ConditionSubTypeParamsFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_conditionSubTypeParams_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> conditionSubTypeParams_ = new RepeatedField<int>();

	public const int ConditionTypeFieldNumber = 3;

	private int conditionType_;

	public const int ConditionValueFieldNumber = 4;

	private int conditionValue_;

	public const int DescLocalTextIdFieldNumber = 5;

	private int descLocalTextId_;

	public const int GroupIdFieldNumber = 6;

	private int groupId_;

	public const int GroupTypeFieldNumber = 7;

	private int groupType_;

	public const int IdFieldNumber = 8;

	private int id_;

	public const int IsConditionSubTypeMoreCheckFieldNumber = 9;

	private int isConditionSubTypeMoreCheck_;

	public const int IsHighlightFieldNumber = 10;

	private int isHighlight_;

	public const int LockLocalTextIdFieldNumber = 11;

	private int lockLocalTextId_;

	public const int PassExpFieldNumber = 12;

	private int passExp_;

	public const int RewardCountFieldNumber = 13;

	private int rewardCount_;

	public const int RewardIdFieldNumber = 14;

	private int rewardId_;

	public const int RewardTypeFieldNumber = 15;

	private int rewardType_;

	public const int ShortCutIdFieldNumber = 16;

	private int shortCutId_;

	public const int SortIdFieldNumber = 17;

	private int sortId_;

	public const int TitleLocalTextIdFieldNumber = 18;

	private int titleLocalTextId_;

	public const int UnlockPackIdFieldNumber = 19;

	private int unlockPackId_;

	public const int UnlockQuestIdFieldNumber = 20;

	private int unlockQuestId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ConditionSubType
	{
		get
		{
			return conditionSubType_;
		}
		set
		{
			conditionSubType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ConditionSubTypeParams => conditionSubTypeParams_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionValue
	{
		get
		{
			return conditionValue_;
		}
		set
		{
			conditionValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DescLocalTextId
	{
		get
		{
			return descLocalTextId_;
		}
		set
		{
			descLocalTextId_ = value;
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
	public int IsConditionSubTypeMoreCheck
	{
		get
		{
			return isConditionSubTypeMoreCheck_;
		}
		set
		{
			isConditionSubTypeMoreCheck_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IsHighlight
	{
		get
		{
			return isHighlight_;
		}
		set
		{
			isHighlight_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LockLocalTextId
	{
		get
		{
			return lockLocalTextId_;
		}
		set
		{
			lockLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PassExp
	{
		get
		{
			return passExp_;
		}
		set
		{
			passExp_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int ShortCutId
	{
		get
		{
			return shortCutId_;
		}
		set
		{
			shortCutId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TitleLocalTextId
	{
		get
		{
			return titleLocalTextId_;
		}
		set
		{
			titleLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UnlockPackId
	{
		get
		{
			return unlockPackId_;
		}
		set
		{
			unlockPackId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UnlockQuestId
	{
		get
		{
			return unlockQuestId_;
		}
		set
		{
			unlockQuestId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionTable(MissionTable other)
		: this()
	{
		conditionSubType_ = other.conditionSubType_;
		conditionSubTypeParams_ = other.conditionSubTypeParams_.Clone();
		conditionType_ = other.conditionType_;
		conditionValue_ = other.conditionValue_;
		descLocalTextId_ = other.descLocalTextId_;
		groupId_ = other.groupId_;
		groupType_ = other.groupType_;
		id_ = other.id_;
		isConditionSubTypeMoreCheck_ = other.isConditionSubTypeMoreCheck_;
		isHighlight_ = other.isHighlight_;
		lockLocalTextId_ = other.lockLocalTextId_;
		passExp_ = other.passExp_;
		rewardCount_ = other.rewardCount_;
		rewardId_ = other.rewardId_;
		rewardType_ = other.rewardType_;
		shortCutId_ = other.shortCutId_;
		sortId_ = other.sortId_;
		titleLocalTextId_ = other.titleLocalTextId_;
		unlockPackId_ = other.unlockPackId_;
		unlockQuestId_ = other.unlockQuestId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionTable Clone()
	{
		return new MissionTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ConditionSubType == other.ConditionSubType && conditionSubTypeParams_.Equals(other.conditionSubTypeParams_) && ConditionType == other.ConditionType && ConditionValue == other.ConditionValue && DescLocalTextId == other.DescLocalTextId && GroupId == other.GroupId && GroupType == other.GroupType && Id == other.Id && IsConditionSubTypeMoreCheck == other.IsConditionSubTypeMoreCheck && IsHighlight == other.IsHighlight && LockLocalTextId == other.LockLocalTextId && PassExp == other.PassExp && RewardCount == other.RewardCount && RewardId == other.RewardId && RewardType == other.RewardType && ShortCutId == other.ShortCutId && SortId == other.SortId && TitleLocalTextId == other.TitleLocalTextId && UnlockPackId == other.UnlockPackId && UnlockQuestId == other.UnlockQuestId)
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
		if (ConditionSubType != 0)
		{
			num ^= ConditionSubType.GetHashCode();
		}
		num ^= conditionSubTypeParams_.GetHashCode();
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (ConditionValue != 0)
		{
			num ^= ConditionValue.GetHashCode();
		}
		if (DescLocalTextId != 0)
		{
			num ^= DescLocalTextId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (GroupType != 0)
		{
			num ^= GroupType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsConditionSubTypeMoreCheck != 0)
		{
			num ^= IsConditionSubTypeMoreCheck.GetHashCode();
		}
		if (IsHighlight != 0)
		{
			num ^= IsHighlight.GetHashCode();
		}
		if (LockLocalTextId != 0)
		{
			num ^= LockLocalTextId.GetHashCode();
		}
		if (PassExp != 0)
		{
			num ^= PassExp.GetHashCode();
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
		if (ShortCutId != 0)
		{
			num ^= ShortCutId.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (TitleLocalTextId != 0)
		{
			num ^= TitleLocalTextId.GetHashCode();
		}
		if (UnlockPackId != 0)
		{
			num ^= UnlockPackId.GetHashCode();
		}
		if (UnlockQuestId != 0)
		{
			num ^= UnlockQuestId.GetHashCode();
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
		if (ConditionSubType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionSubType);
		}
		conditionSubTypeParams_.WriteTo(ref output, _repeated_conditionSubTypeParams_codec);
		if (ConditionType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ConditionType);
		}
		if (ConditionValue != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ConditionValue);
		}
		if (DescLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DescLocalTextId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(GroupId);
		}
		if (GroupType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GroupType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (IsConditionSubTypeMoreCheck != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(IsConditionSubTypeMoreCheck);
		}
		if (IsHighlight != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(IsHighlight);
		}
		if (LockLocalTextId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(LockLocalTextId);
		}
		if (PassExp != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(PassExp);
		}
		if (RewardCount != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(RewardCount);
		}
		if (RewardId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(RewardId);
		}
		if (RewardType != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(RewardType);
		}
		if (ShortCutId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(ShortCutId);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(SortId);
		}
		if (TitleLocalTextId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(TitleLocalTextId);
		}
		if (UnlockPackId != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(UnlockPackId);
		}
		if (UnlockQuestId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(UnlockQuestId);
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
		if (ConditionSubType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionSubType);
		}
		num += conditionSubTypeParams_.CalculateSize(_repeated_conditionSubTypeParams_codec);
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (ConditionValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionValue);
		}
		if (DescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DescLocalTextId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (GroupType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsConditionSubTypeMoreCheck != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsConditionSubTypeMoreCheck);
		}
		if (IsHighlight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsHighlight);
		}
		if (LockLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LockLocalTextId);
		}
		if (PassExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PassExp);
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
		if (ShortCutId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShortCutId);
		}
		if (SortId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (TitleLocalTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TitleLocalTextId);
		}
		if (UnlockPackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UnlockPackId);
		}
		if (UnlockQuestId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UnlockQuestId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MissionTable other)
	{
		if (other != null)
		{
			if (other.ConditionSubType != 0)
			{
				ConditionSubType = other.ConditionSubType;
			}
			conditionSubTypeParams_.Add(other.conditionSubTypeParams_);
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.ConditionValue != 0)
			{
				ConditionValue = other.ConditionValue;
			}
			if (other.DescLocalTextId != 0)
			{
				DescLocalTextId = other.DescLocalTextId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GroupType != 0)
			{
				GroupType = other.GroupType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsConditionSubTypeMoreCheck != 0)
			{
				IsConditionSubTypeMoreCheck = other.IsConditionSubTypeMoreCheck;
			}
			if (other.IsHighlight != 0)
			{
				IsHighlight = other.IsHighlight;
			}
			if (other.LockLocalTextId != 0)
			{
				LockLocalTextId = other.LockLocalTextId;
			}
			if (other.PassExp != 0)
			{
				PassExp = other.PassExp;
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
			if (other.ShortCutId != 0)
			{
				ShortCutId = other.ShortCutId;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.TitleLocalTextId != 0)
			{
				TitleLocalTextId = other.TitleLocalTextId;
			}
			if (other.UnlockPackId != 0)
			{
				UnlockPackId = other.UnlockPackId;
			}
			if (other.UnlockQuestId != 0)
			{
				UnlockQuestId = other.UnlockQuestId;
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
				ConditionSubType = input.ReadInt32();
				break;
			case 24u:
				ConditionType = input.ReadInt32();
				break;
			case 32u:
				ConditionValue = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				conditionSubTypeParams_.AddEntriesFrom(ref input, _repeated_conditionSubTypeParams_codec);
				break;
			case 40u:
				DescLocalTextId = input.ReadInt32();
				break;
			case 48u:
				GroupId = input.ReadInt32();
				break;
			case 56u:
				GroupType = input.ReadInt32();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 72u:
				IsConditionSubTypeMoreCheck = input.ReadInt32();
				break;
			case 80u:
				IsHighlight = input.ReadInt32();
				break;
			case 88u:
				LockLocalTextId = input.ReadInt32();
				break;
			case 96u:
				PassExp = input.ReadInt32();
				break;
			case 104u:
				RewardCount = input.ReadInt32();
				break;
			case 112u:
				RewardId = input.ReadInt32();
				break;
			case 120u:
				RewardType = input.ReadInt32();
				break;
			case 128u:
				ShortCutId = input.ReadInt32();
				break;
			case 136u:
				SortId = input.ReadInt32();
				break;
			case 144u:
				TitleLocalTextId = input.ReadInt32();
				break;
			case 152u:
				UnlockPackId = input.ReadInt32();
				break;
			case 160u:
				UnlockQuestId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
