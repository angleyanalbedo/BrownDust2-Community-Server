using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class AchievementTable : IMessage<AchievementTable>, IMessage, IEquatable<AchievementTable>, IDeepCloneable<AchievementTable>, IBufferMessage
{
	private static readonly MessageParser<AchievementTable> _parser = new MessageParser<AchievementTable>(() => new AchievementTable());

	private UnknownFieldSet _unknownFields;

	public const int ConditionSubTypeFieldNumber = 1;

	private int conditionSubType_;

	public const int ConditionTypeFieldNumber = 2;

	private int conditionType_;

	public const int ConditionValueFieldNumber = 3;

	private double conditionValue_;

	public const int ContentsGroupFieldNumber = 4;

	private int contentsGroup_;

	public const int DescLocalTextIdFieldNumber = 5;

	private int descLocalTextId_;

	public const int EventIdFieldNumber = 6;

	private int eventId_;

	public const int EventTypeFieldNumber = 7;

	private int eventType_;

	public const int ExpFieldNumber = 8;

	private int exp_;

	public const int GroupIdFieldNumber = 9;

	private int groupId_;

	public const int IconNameFieldNumber = 10;

	private string iconName_ = "";

	public const int IdFieldNumber = 11;

	private int id_;

	public const int RewardItemCountFieldNumber = 12;

	private int rewardItemCount_;

	public const int RewardItemIdFieldNumber = 13;

	private int rewardItemId_;

	public const int RewardItemTypeFieldNumber = 14;

	private int rewardItemType_;

	public const int ShortCutIdFieldNumber = 15;

	private int shortCutId_;

	public const int TabTypeFieldNumber = 16;

	private int tabType_;

	public const int TitleLocalTextIdFieldNumber = 17;

	private int titleLocalTextId_;

	public const int UseBlindFieldNumber = 18;

	private int useBlind_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AchievementTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AchievementTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public double ConditionValue
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContentsGroup
	{
		get
		{
			return contentsGroup_;
		}
		set
		{
			contentsGroup_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventType
	{
		get
		{
			return eventType_;
		}
		set
		{
			eventType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IconName
	{
		get
		{
			return iconName_;
		}
		set
		{
			iconName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TabType
	{
		get
		{
			return tabType_;
		}
		set
		{
			tabType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int UseBlind
	{
		get
		{
			return useBlind_;
		}
		set
		{
			useBlind_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AchievementTable(AchievementTable other)
		: this()
	{
		conditionSubType_ = other.conditionSubType_;
		conditionType_ = other.conditionType_;
		conditionValue_ = other.conditionValue_;
		contentsGroup_ = other.contentsGroup_;
		descLocalTextId_ = other.descLocalTextId_;
		eventId_ = other.eventId_;
		eventType_ = other.eventType_;
		exp_ = other.exp_;
		groupId_ = other.groupId_;
		iconName_ = other.iconName_;
		id_ = other.id_;
		rewardItemCount_ = other.rewardItemCount_;
		rewardItemId_ = other.rewardItemId_;
		rewardItemType_ = other.rewardItemType_;
		shortCutId_ = other.shortCutId_;
		tabType_ = other.tabType_;
		titleLocalTextId_ = other.titleLocalTextId_;
		useBlind_ = other.useBlind_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AchievementTable Clone()
	{
		return new AchievementTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as AchievementTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AchievementTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ConditionSubType == other.ConditionSubType && ConditionType == other.ConditionType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ConditionValue, other.ConditionValue) && ContentsGroup == other.ContentsGroup && DescLocalTextId == other.DescLocalTextId && EventId == other.EventId && EventType == other.EventType && Exp == other.Exp && GroupId == other.GroupId && !(IconName != other.IconName) && Id == other.Id && RewardItemCount == other.RewardItemCount && RewardItemId == other.RewardItemId && RewardItemType == other.RewardItemType && ShortCutId == other.ShortCutId && TabType == other.TabType && TitleLocalTextId == other.TitleLocalTextId && UseBlind == other.UseBlind)
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
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (ConditionValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ConditionValue);
		}
		if (ContentsGroup != 0)
		{
			num ^= ContentsGroup.GetHashCode();
		}
		if (DescLocalTextId != 0)
		{
			num ^= DescLocalTextId.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (EventType != 0)
		{
			num ^= EventType.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (IconName.Length != 0)
		{
			num ^= IconName.GetHashCode();
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
		if (ShortCutId != 0)
		{
			num ^= ShortCutId.GetHashCode();
		}
		if (TabType != 0)
		{
			num ^= TabType.GetHashCode();
		}
		if (TitleLocalTextId != 0)
		{
			num ^= TitleLocalTextId.GetHashCode();
		}
		if (UseBlind != 0)
		{
			num ^= UseBlind.GetHashCode();
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
		if (ConditionSubType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionSubType);
		}
		if (ConditionType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ConditionType);
		}
		if (ConditionValue != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(ConditionValue);
		}
		if (ContentsGroup != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ContentsGroup);
		}
		if (DescLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DescLocalTextId);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EventId);
		}
		if (EventType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(EventType);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Exp);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(GroupId);
		}
		if (IconName.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(IconName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Id);
		}
		if (RewardItemCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(RewardItemCount);
		}
		if (RewardItemId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(RewardItemId);
		}
		if (RewardItemType != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(RewardItemType);
		}
		if (ShortCutId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ShortCutId);
		}
		if (TabType != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(TabType);
		}
		if (TitleLocalTextId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(TitleLocalTextId);
		}
		if (UseBlind != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(UseBlind);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (ConditionSubType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionSubType);
		}
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (ConditionValue != 0.0)
		{
			num += 9;
		}
		if (ContentsGroup != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentsGroup);
		}
		if (DescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DescLocalTextId);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (EventType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventType);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Exp);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (IconName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconName);
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
		if (ShortCutId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShortCutId);
		}
		if (TabType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TabType);
		}
		if (TitleLocalTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TitleLocalTextId);
		}
		if (UseBlind != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseBlind);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AchievementTable other)
	{
		if (other != null)
		{
			if (other.ConditionSubType != 0)
			{
				ConditionSubType = other.ConditionSubType;
			}
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.ConditionValue != 0.0)
			{
				ConditionValue = other.ConditionValue;
			}
			if (other.ContentsGroup != 0)
			{
				ContentsGroup = other.ContentsGroup;
			}
			if (other.DescLocalTextId != 0)
			{
				DescLocalTextId = other.DescLocalTextId;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.EventType != 0)
			{
				EventType = other.EventType;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.IconName.Length != 0)
			{
				IconName = other.IconName;
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
			if (other.ShortCutId != 0)
			{
				ShortCutId = other.ShortCutId;
			}
			if (other.TabType != 0)
			{
				TabType = other.TabType;
			}
			if (other.TitleLocalTextId != 0)
			{
				TitleLocalTextId = other.TitleLocalTextId;
			}
			if (other.UseBlind != 0)
			{
				UseBlind = other.UseBlind;
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
			case 16u:
				ConditionType = input.ReadInt32();
				break;
			case 25u:
				ConditionValue = input.ReadDouble();
				break;
			case 32u:
				ContentsGroup = input.ReadInt32();
				break;
			case 40u:
				DescLocalTextId = input.ReadInt32();
				break;
			case 48u:
				EventId = input.ReadInt32();
				break;
			case 56u:
				EventType = input.ReadInt32();
				break;
			case 64u:
				Exp = input.ReadInt32();
				break;
			case 72u:
				GroupId = input.ReadInt32();
				break;
			case 82u:
				IconName = input.ReadString();
				break;
			case 88u:
				Id = input.ReadInt32();
				break;
			case 96u:
				RewardItemCount = input.ReadInt32();
				break;
			case 104u:
				RewardItemId = input.ReadInt32();
				break;
			case 112u:
				RewardItemType = input.ReadInt32();
				break;
			case 120u:
				ShortCutId = input.ReadInt32();
				break;
			case 128u:
				TabType = input.ReadInt32();
				break;
			case 136u:
				TitleLocalTextId = input.ReadInt32();
				break;
			case 144u:
				UseBlind = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
