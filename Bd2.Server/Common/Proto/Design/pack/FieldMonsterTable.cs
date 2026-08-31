using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.pack;

public sealed class FieldMonsterTable : IMessage<FieldMonsterTable>, IMessage, IEquatable<FieldMonsterTable>, IDeepCloneable<FieldMonsterTable>, IBufferMessage
{
	private static readonly MessageParser<FieldMonsterTable> _parser = new MessageParser<FieldMonsterTable>(() => new FieldMonsterTable());

	private UnknownFieldSet _unknownFields;

	public const int AnimatorTypeFieldNumber = 1;

	private int animatorType_;

	public const int BattleDeckIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_battleDeckId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> battleDeckId_ = new RepeatedField<int>();

	public const int BundleTypeFieldNumber = 3;

	private int bundleType_;

	public const int DamagedEffectFieldNumber = 4;

	private string damagedEffect_ = "";

	public const int DirectionTypeFieldNumber = 5;

	private int directionType_;

	public const int FieldBuffIdFieldNumber = 6;

	private int fieldBuffId_;

	public const int FieldMonsterAIIdFieldNumber = 7;

	private int fieldMonsterAIId_;

	public const int FieldPointPosIdFieldNumber = 8;

	private int fieldPointPosId_;

	public const int HpFieldNumber = 9;

	private int hp_;

	public const int IdFieldNumber = 10;

	private int id_;

	public const int IdleEffectFieldNumber = 11;

	private string idleEffect_ = "";

	public const int InteractionLocalTextIdFieldNumber = 12;

	private int interactionLocalTextId_;

	public const int InteractionSpriteNameFieldNumber = 13;

	private string interactionSpriteName_ = "";

	public const int IsAutoInteractionFieldNumber = 14;

	private int isAutoInteraction_;

	public const int MonsterCrashTypeFieldNumber = 15;

	private int monsterCrashType_;

	public const int MonsterIllustNameFieldNumber = 16;

	private string monsterIllustName_ = "";

	public const int MonsterNameTextIdFieldNumber = 17;

	private int monsterNameTextId_;

	public const int MonsterSizeFieldNumber = 18;

	private int monsterSize_;

	public const int MonsterTalkStoryTextIdFieldNumber = 19;

	private int monsterTalkStoryTextId_;

	public const int MonsterTimeLineFieldNumber = 20;

	private string monsterTimeLine_ = "";

	public const int QuestRangeFieldNumber = 21;

	private static readonly FieldCodec<int> _repeated_questRange_codec = FieldCodec.ForInt32(170u);

	private readonly RepeatedField<int> questRange_ = new RepeatedField<int>();

	public const int RangeTypeFieldNumber = 22;

	private int rangeType_;

	public const int RegenIdFieldNumber = 23;

	private int regenId_;

	public const int ResourceNameFieldNumber = 24;

	private string resourceName_ = "";

	public const int ResourceTypeFieldNumber = 25;

	private int resourceType_;

	public const int RewardCountFieldNumber = 26;

	private int rewardCount_;

	public const int RewardIdFieldNumber = 27;

	private int rewardId_;

	public const int RewardTypeFieldNumber = 28;

	private int rewardType_;

	public const int TypeFieldNumber = 29;

	private int type_;

	public const int UseBattleSkipFieldNumber = 30;

	private int useBattleSkip_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FieldMonsterTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldMonsterTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AnimatorType
	{
		get
		{
			return animatorType_;
		}
		set
		{
			animatorType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BattleDeckId => battleDeckId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BundleType
	{
		get
		{
			return bundleType_;
		}
		set
		{
			bundleType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DamagedEffect
	{
		get
		{
			return damagedEffect_;
		}
		set
		{
			damagedEffect_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DirectionType
	{
		get
		{
			return directionType_;
		}
		set
		{
			directionType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FieldBuffId
	{
		get
		{
			return fieldBuffId_;
		}
		set
		{
			fieldBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FieldMonsterAIId
	{
		get
		{
			return fieldMonsterAIId_;
		}
		set
		{
			fieldMonsterAIId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FieldPointPosId
	{
		get
		{
			return fieldPointPosId_;
		}
		set
		{
			fieldPointPosId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
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
	public string IdleEffect
	{
		get
		{
			return idleEffect_;
		}
		set
		{
			idleEffect_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InteractionLocalTextId
	{
		get
		{
			return interactionLocalTextId_;
		}
		set
		{
			interactionLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string InteractionSpriteName
	{
		get
		{
			return interactionSpriteName_;
		}
		set
		{
			interactionSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IsAutoInteraction
	{
		get
		{
			return isAutoInteraction_;
		}
		set
		{
			isAutoInteraction_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MonsterCrashType
	{
		get
		{
			return monsterCrashType_;
		}
		set
		{
			monsterCrashType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MonsterIllustName
	{
		get
		{
			return monsterIllustName_;
		}
		set
		{
			monsterIllustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MonsterNameTextId
	{
		get
		{
			return monsterNameTextId_;
		}
		set
		{
			monsterNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MonsterSize
	{
		get
		{
			return monsterSize_;
		}
		set
		{
			monsterSize_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MonsterTalkStoryTextId
	{
		get
		{
			return monsterTalkStoryTextId_;
		}
		set
		{
			monsterTalkStoryTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MonsterTimeLine
	{
		get
		{
			return monsterTimeLine_;
		}
		set
		{
			monsterTimeLine_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> QuestRange => questRange_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RangeType
	{
		get
		{
			return rangeType_;
		}
		set
		{
			rangeType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RegenId
	{
		get
		{
			return regenId_;
		}
		set
		{
			regenId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string ResourceName
	{
		get
		{
			return resourceName_;
		}
		set
		{
			resourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResourceType
	{
		get
		{
			return resourceType_;
		}
		set
		{
			resourceType_ = value;
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
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UseBattleSkip
	{
		get
		{
			return useBattleSkip_;
		}
		set
		{
			useBattleSkip_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldMonsterTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldMonsterTable(FieldMonsterTable other)
		: this()
	{
		animatorType_ = other.animatorType_;
		battleDeckId_ = other.battleDeckId_.Clone();
		bundleType_ = other.bundleType_;
		damagedEffect_ = other.damagedEffect_;
		directionType_ = other.directionType_;
		fieldBuffId_ = other.fieldBuffId_;
		fieldMonsterAIId_ = other.fieldMonsterAIId_;
		fieldPointPosId_ = other.fieldPointPosId_;
		hp_ = other.hp_;
		id_ = other.id_;
		idleEffect_ = other.idleEffect_;
		interactionLocalTextId_ = other.interactionLocalTextId_;
		interactionSpriteName_ = other.interactionSpriteName_;
		isAutoInteraction_ = other.isAutoInteraction_;
		monsterCrashType_ = other.monsterCrashType_;
		monsterIllustName_ = other.monsterIllustName_;
		monsterNameTextId_ = other.monsterNameTextId_;
		monsterSize_ = other.monsterSize_;
		monsterTalkStoryTextId_ = other.monsterTalkStoryTextId_;
		monsterTimeLine_ = other.monsterTimeLine_;
		questRange_ = other.questRange_.Clone();
		rangeType_ = other.rangeType_;
		regenId_ = other.regenId_;
		resourceName_ = other.resourceName_;
		resourceType_ = other.resourceType_;
		rewardCount_ = other.rewardCount_;
		rewardId_ = other.rewardId_;
		rewardType_ = other.rewardType_;
		type_ = other.type_;
		useBattleSkip_ = other.useBattleSkip_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldMonsterTable Clone()
	{
		return new FieldMonsterTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldMonsterTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldMonsterTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AnimatorType == other.AnimatorType && battleDeckId_.Equals(other.battleDeckId_) && BundleType == other.BundleType && !(DamagedEffect != other.DamagedEffect) && DirectionType == other.DirectionType && FieldBuffId == other.FieldBuffId && FieldMonsterAIId == other.FieldMonsterAIId && FieldPointPosId == other.FieldPointPosId && Hp == other.Hp && Id == other.Id && !(IdleEffect != other.IdleEffect) && InteractionLocalTextId == other.InteractionLocalTextId && !(InteractionSpriteName != other.InteractionSpriteName) && IsAutoInteraction == other.IsAutoInteraction && MonsterCrashType == other.MonsterCrashType && !(MonsterIllustName != other.MonsterIllustName) && MonsterNameTextId == other.MonsterNameTextId && MonsterSize == other.MonsterSize && MonsterTalkStoryTextId == other.MonsterTalkStoryTextId && !(MonsterTimeLine != other.MonsterTimeLine) && questRange_.Equals(other.questRange_) && RangeType == other.RangeType && RegenId == other.RegenId && !(ResourceName != other.ResourceName) && ResourceType == other.ResourceType && RewardCount == other.RewardCount && RewardId == other.RewardId && RewardType == other.RewardType && Type == other.Type && UseBattleSkip == other.UseBattleSkip)
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
		if (AnimatorType != 0)
		{
			num ^= AnimatorType.GetHashCode();
		}
		num ^= battleDeckId_.GetHashCode();
		if (BundleType != 0)
		{
			num ^= BundleType.GetHashCode();
		}
		if (DamagedEffect.Length != 0)
		{
			num ^= DamagedEffect.GetHashCode();
		}
		if (DirectionType != 0)
		{
			num ^= DirectionType.GetHashCode();
		}
		if (FieldBuffId != 0)
		{
			num ^= FieldBuffId.GetHashCode();
		}
		if (FieldMonsterAIId != 0)
		{
			num ^= FieldMonsterAIId.GetHashCode();
		}
		if (FieldPointPosId != 0)
		{
			num ^= FieldPointPosId.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IdleEffect.Length != 0)
		{
			num ^= IdleEffect.GetHashCode();
		}
		if (InteractionLocalTextId != 0)
		{
			num ^= InteractionLocalTextId.GetHashCode();
		}
		if (InteractionSpriteName.Length != 0)
		{
			num ^= InteractionSpriteName.GetHashCode();
		}
		if (IsAutoInteraction != 0)
		{
			num ^= IsAutoInteraction.GetHashCode();
		}
		if (MonsterCrashType != 0)
		{
			num ^= MonsterCrashType.GetHashCode();
		}
		if (MonsterIllustName.Length != 0)
		{
			num ^= MonsterIllustName.GetHashCode();
		}
		if (MonsterNameTextId != 0)
		{
			num ^= MonsterNameTextId.GetHashCode();
		}
		if (MonsterSize != 0)
		{
			num ^= MonsterSize.GetHashCode();
		}
		if (MonsterTalkStoryTextId != 0)
		{
			num ^= MonsterTalkStoryTextId.GetHashCode();
		}
		if (MonsterTimeLine.Length != 0)
		{
			num ^= MonsterTimeLine.GetHashCode();
		}
		num ^= questRange_.GetHashCode();
		if (RangeType != 0)
		{
			num ^= RangeType.GetHashCode();
		}
		if (RegenId != 0)
		{
			num ^= RegenId.GetHashCode();
		}
		if (ResourceName.Length != 0)
		{
			num ^= ResourceName.GetHashCode();
		}
		if (ResourceType != 0)
		{
			num ^= ResourceType.GetHashCode();
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
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (UseBattleSkip != 0)
		{
			num ^= UseBattleSkip.GetHashCode();
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
		if (AnimatorType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AnimatorType);
		}
		battleDeckId_.WriteTo(ref output, _repeated_battleDeckId_codec);
		if (BundleType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BundleType);
		}
		if (DamagedEffect.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DamagedEffect);
		}
		if (DirectionType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DirectionType);
		}
		if (FieldBuffId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(FieldBuffId);
		}
		if (FieldMonsterAIId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(FieldMonsterAIId);
		}
		if (FieldPointPosId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(FieldPointPosId);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Hp);
		}
		if (Id != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Id);
		}
		if (IdleEffect.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(IdleEffect);
		}
		if (InteractionLocalTextId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(InteractionLocalTextId);
		}
		if (InteractionSpriteName.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(InteractionSpriteName);
		}
		if (IsAutoInteraction != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(IsAutoInteraction);
		}
		if (MonsterCrashType != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(MonsterCrashType);
		}
		if (MonsterIllustName.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(MonsterIllustName);
		}
		if (MonsterNameTextId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(MonsterNameTextId);
		}
		if (MonsterSize != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(MonsterSize);
		}
		if (MonsterTalkStoryTextId != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(MonsterTalkStoryTextId);
		}
		if (MonsterTimeLine.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(MonsterTimeLine);
		}
		questRange_.WriteTo(ref output, _repeated_questRange_codec);
		if (RangeType != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(RangeType);
		}
		if (RegenId != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(RegenId);
		}
		if (ResourceName.Length != 0)
		{
			output.WriteRawTag(194, 1);
			output.WriteString(ResourceName);
		}
		if (ResourceType != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(ResourceType);
		}
		if (RewardCount != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(RewardCount);
		}
		if (RewardId != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(RewardId);
		}
		if (RewardType != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(RewardType);
		}
		if (Type != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(Type);
		}
		if (UseBattleSkip != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(UseBattleSkip);
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
		if (AnimatorType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AnimatorType);
		}
		num += battleDeckId_.CalculateSize(_repeated_battleDeckId_codec);
		if (BundleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BundleType);
		}
		if (DamagedEffect.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DamagedEffect);
		}
		if (DirectionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DirectionType);
		}
		if (FieldBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldBuffId);
		}
		if (FieldMonsterAIId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldMonsterAIId);
		}
		if (FieldPointPosId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldPointPosId);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Hp);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IdleEffect.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IdleEffect);
		}
		if (InteractionLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractionLocalTextId);
		}
		if (InteractionSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InteractionSpriteName);
		}
		if (IsAutoInteraction != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsAutoInteraction);
		}
		if (MonsterCrashType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterCrashType);
		}
		if (MonsterIllustName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MonsterIllustName);
		}
		if (MonsterNameTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MonsterNameTextId);
		}
		if (MonsterSize != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MonsterSize);
		}
		if (MonsterTalkStoryTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MonsterTalkStoryTextId);
		}
		if (MonsterTimeLine.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MonsterTimeLine);
		}
		num += questRange_.CalculateSize(_repeated_questRange_codec);
		if (RangeType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RangeType);
		}
		if (RegenId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RegenId);
		}
		if (ResourceName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ResourceName);
		}
		if (ResourceType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ResourceType);
		}
		if (RewardCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RewardCount);
		}
		if (RewardId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RewardId);
		}
		if (RewardType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RewardType);
		}
		if (Type != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (UseBattleSkip != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseBattleSkip);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldMonsterTable other)
	{
		if (other != null)
		{
			if (other.AnimatorType != 0)
			{
				AnimatorType = other.AnimatorType;
			}
			battleDeckId_.Add(other.battleDeckId_);
			if (other.BundleType != 0)
			{
				BundleType = other.BundleType;
			}
			if (other.DamagedEffect.Length != 0)
			{
				DamagedEffect = other.DamagedEffect;
			}
			if (other.DirectionType != 0)
			{
				DirectionType = other.DirectionType;
			}
			if (other.FieldBuffId != 0)
			{
				FieldBuffId = other.FieldBuffId;
			}
			if (other.FieldMonsterAIId != 0)
			{
				FieldMonsterAIId = other.FieldMonsterAIId;
			}
			if (other.FieldPointPosId != 0)
			{
				FieldPointPosId = other.FieldPointPosId;
			}
			if (other.Hp != 0)
			{
				Hp = other.Hp;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IdleEffect.Length != 0)
			{
				IdleEffect = other.IdleEffect;
			}
			if (other.InteractionLocalTextId != 0)
			{
				InteractionLocalTextId = other.InteractionLocalTextId;
			}
			if (other.InteractionSpriteName.Length != 0)
			{
				InteractionSpriteName = other.InteractionSpriteName;
			}
			if (other.IsAutoInteraction != 0)
			{
				IsAutoInteraction = other.IsAutoInteraction;
			}
			if (other.MonsterCrashType != 0)
			{
				MonsterCrashType = other.MonsterCrashType;
			}
			if (other.MonsterIllustName.Length != 0)
			{
				MonsterIllustName = other.MonsterIllustName;
			}
			if (other.MonsterNameTextId != 0)
			{
				MonsterNameTextId = other.MonsterNameTextId;
			}
			if (other.MonsterSize != 0)
			{
				MonsterSize = other.MonsterSize;
			}
			if (other.MonsterTalkStoryTextId != 0)
			{
				MonsterTalkStoryTextId = other.MonsterTalkStoryTextId;
			}
			if (other.MonsterTimeLine.Length != 0)
			{
				MonsterTimeLine = other.MonsterTimeLine;
			}
			questRange_.Add(other.questRange_);
			if (other.RangeType != 0)
			{
				RangeType = other.RangeType;
			}
			if (other.RegenId != 0)
			{
				RegenId = other.RegenId;
			}
			if (other.ResourceName.Length != 0)
			{
				ResourceName = other.ResourceName;
			}
			if (other.ResourceType != 0)
			{
				ResourceType = other.ResourceType;
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
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.UseBattleSkip != 0)
			{
				UseBattleSkip = other.UseBattleSkip;
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
				AnimatorType = input.ReadInt32();
				break;
			case 24u:
				BundleType = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				battleDeckId_.AddEntriesFrom(ref input, _repeated_battleDeckId_codec);
				break;
			case 34u:
				DamagedEffect = input.ReadString();
				break;
			case 40u:
				DirectionType = input.ReadInt32();
				break;
			case 48u:
				FieldBuffId = input.ReadInt32();
				break;
			case 56u:
				FieldMonsterAIId = input.ReadInt32();
				break;
			case 64u:
				FieldPointPosId = input.ReadInt32();
				break;
			case 72u:
				Hp = input.ReadInt32();
				break;
			case 80u:
				Id = input.ReadInt32();
				break;
			case 90u:
				IdleEffect = input.ReadString();
				break;
			case 96u:
				InteractionLocalTextId = input.ReadInt32();
				break;
			case 106u:
				InteractionSpriteName = input.ReadString();
				break;
			case 112u:
				IsAutoInteraction = input.ReadInt32();
				break;
			case 120u:
				MonsterCrashType = input.ReadInt32();
				break;
			case 162u:
				MonsterTimeLine = input.ReadString();
				break;
			case 176u:
				RangeType = input.ReadInt32();
				break;
			case 168u:
			case 170u:
				questRange_.AddEntriesFrom(ref input, _repeated_questRange_codec);
				break;
			case 130u:
				MonsterIllustName = input.ReadString();
				break;
			case 136u:
				MonsterNameTextId = input.ReadInt32();
				break;
			case 144u:
				MonsterSize = input.ReadInt32();
				break;
			case 152u:
				MonsterTalkStoryTextId = input.ReadInt32();
				break;
			case 184u:
				RegenId = input.ReadInt32();
				break;
			case 194u:
				ResourceName = input.ReadString();
				break;
			case 200u:
				ResourceType = input.ReadInt32();
				break;
			case 208u:
				RewardCount = input.ReadInt32();
				break;
			case 216u:
				RewardId = input.ReadInt32();
				break;
			case 224u:
				RewardType = input.ReadInt32();
				break;
			case 232u:
				Type = input.ReadInt32();
				break;
			case 240u:
				UseBattleSkip = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
