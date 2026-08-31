using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class QuestTable12002 : IMessage<QuestTable12002>, IMessage, IEquatable<QuestTable12002>, IDeepCloneable<QuestTable12002>, IBufferMessage
{
	private static readonly MessageParser<QuestTable12002> _parser = new MessageParser<QuestTable12002>(() => new QuestTable12002());

	private UnknownFieldSet _unknownFields;

	public const int AcceptCinemaNameFieldNumber = 1;

	private string acceptCinemaName_ = "";

	public const int AcceptNpcIdFieldNumber = 2;

	private int acceptNpcId_;

	public const int AcceptTutorialIdFieldNumber = 3;

	private int acceptTutorialId_;

	public const int CharGroupIdFieldNumber = 4;

	private int charGroupId_;

	public const int ClearTimeFieldNumber = 5;

	private int clearTime_;

	public const int CollectionIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_collectionId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> collectionId_ = new RepeatedField<int>();

	public const int CompleteCinemaNameFieldNumber = 7;

	private string completeCinemaName_ = "";

	public const int CompleteNpcIdFieldNumber = 8;

	private int completeNpcId_;

	public const int CompleteTutorialIdFieldNumber = 9;

	private int completeTutorialId_;

	public const int ConditionCountFieldNumber = 10;

	private int conditionCount_;

	public const int ConditionTypeFieldNumber = 11;

	private int conditionType_;

	public const int DeckListFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_deckList_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> deckList_ = new RepeatedField<int>();

	public const int DisplayMapIdFieldNumber = 13;

	private int displayMapId_;

	public const int DisplayRewardCountFieldNumber = 14;

	private static readonly FieldCodec<int> _repeated_displayRewardCount_codec = FieldCodec.ForInt32(114u);

	private readonly RepeatedField<int> displayRewardCount_ = new RepeatedField<int>();

	public const int DisplayRewardCount1FieldNumber = 15;

	private static readonly FieldCodec<int> _repeated_displayRewardCount1_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> displayRewardCount1_ = new RepeatedField<int>();

	public const int DisplayRewardCount2FieldNumber = 16;

	private static readonly FieldCodec<int> _repeated_displayRewardCount2_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> displayRewardCount2_ = new RepeatedField<int>();

	public const int DisplayRewardCount3FieldNumber = 17;

	private static readonly FieldCodec<int> _repeated_displayRewardCount3_codec = FieldCodec.ForInt32(138u);

	private readonly RepeatedField<int> displayRewardCount3_ = new RepeatedField<int>();

	public const int DisplayRewardCount4FieldNumber = 18;

	private static readonly FieldCodec<int> _repeated_displayRewardCount4_codec = FieldCodec.ForInt32(146u);

	private readonly RepeatedField<int> displayRewardCount4_ = new RepeatedField<int>();

	public const int DisplayRewardIdFieldNumber = 19;

	private static readonly FieldCodec<int> _repeated_displayRewardId_codec = FieldCodec.ForInt32(154u);

	private readonly RepeatedField<int> displayRewardId_ = new RepeatedField<int>();

	public const int DisplayRewardId1FieldNumber = 20;

	private static readonly FieldCodec<int> _repeated_displayRewardId1_codec = FieldCodec.ForInt32(162u);

	private readonly RepeatedField<int> displayRewardId1_ = new RepeatedField<int>();

	public const int DisplayRewardId2FieldNumber = 21;

	private static readonly FieldCodec<int> _repeated_displayRewardId2_codec = FieldCodec.ForInt32(170u);

	private readonly RepeatedField<int> displayRewardId2_ = new RepeatedField<int>();

	public const int DisplayRewardId3FieldNumber = 22;

	private static readonly FieldCodec<int> _repeated_displayRewardId3_codec = FieldCodec.ForInt32(178u);

	private readonly RepeatedField<int> displayRewardId3_ = new RepeatedField<int>();

	public const int DisplayRewardId4FieldNumber = 23;

	private static readonly FieldCodec<int> _repeated_displayRewardId4_codec = FieldCodec.ForInt32(186u);

	private readonly RepeatedField<int> displayRewardId4_ = new RepeatedField<int>();

	public const int DisplayRewardTypeFieldNumber = 24;

	private static readonly FieldCodec<int> _repeated_displayRewardType_codec = FieldCodec.ForInt32(194u);

	private readonly RepeatedField<int> displayRewardType_ = new RepeatedField<int>();

	public const int DisplayRewardType1FieldNumber = 25;

	private static readonly FieldCodec<int> _repeated_displayRewardType1_codec = FieldCodec.ForInt32(202u);

	private readonly RepeatedField<int> displayRewardType1_ = new RepeatedField<int>();

	public const int DisplayRewardType2FieldNumber = 26;

	private static readonly FieldCodec<int> _repeated_displayRewardType2_codec = FieldCodec.ForInt32(210u);

	private readonly RepeatedField<int> displayRewardType2_ = new RepeatedField<int>();

	public const int DisplayRewardType3FieldNumber = 27;

	private static readonly FieldCodec<int> _repeated_displayRewardType3_codec = FieldCodec.ForInt32(218u);

	private readonly RepeatedField<int> displayRewardType3_ = new RepeatedField<int>();

	public const int DisplayRewardType4FieldNumber = 28;

	private static readonly FieldCodec<int> _repeated_displayRewardType4_codec = FieldCodec.ForInt32(226u);

	private readonly RepeatedField<int> displayRewardType4_ = new RepeatedField<int>();

	public const int GiveQuestItemIdFieldNumber = 29;

	private static readonly FieldCodec<int> _repeated_giveQuestItemId_codec = FieldCodec.ForInt32(234u);

	private readonly RepeatedField<int> giveQuestItemId_ = new RepeatedField<int>();

	public const int IdFieldNumber = 30;

	private int id_;

	public const int IsDisableInteractionFieldNumber = 31;

	private int isDisableInteraction_;

	public const int IsDisableQuestMarkFieldNumber = 32;

	private int isDisableQuestMark_;

	public const int MagicValueFieldNumber = 33;

	private static readonly FieldCodec<int> _repeated_magicValue_codec = FieldCodec.ForInt32(266u);

	private readonly RepeatedField<int> magicValue_ = new RepeatedField<int>();

	public const int MapIdFieldNumber = 34;

	private int mapId_;

	public const int NextQuestIdFieldNumber = 35;

	private int nextQuestId_;

	public const int PackIdFieldNumber = 36;

	private int packId_;

	public const int PriorQuestIdFieldNumber = 37;

	private int priorQuestId_;

	public const int PrologSkipQuestTextIdFieldNumber = 38;

	private int prologSkipQuestTextId_;

	public const int QuestConditionQuestTextIdFieldNumber = 39;

	private int questConditionQuestTextId_;

	public const int QuestDescQuestTextIdFieldNumber = 40;

	private int questDescQuestTextId_;

	public const int QuestNameQuestTextIdFieldNumber = 41;

	private int questNameQuestTextId_;

	public const int QuestSkipQuestTextIdFieldNumber = 42;

	private int questSkipQuestTextId_;

	public const int ReputationCompleteIdFieldNumber = 43;

	private int reputationCompleteId_;

	public const int RewardCountFieldNumber = 44;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(354u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardCount1FieldNumber = 45;

	private static readonly FieldCodec<int> _repeated_rewardCount1_codec = FieldCodec.ForInt32(362u);

	private readonly RepeatedField<int> rewardCount1_ = new RepeatedField<int>();

	public const int RewardCount2FieldNumber = 46;

	private static readonly FieldCodec<int> _repeated_rewardCount2_codec = FieldCodec.ForInt32(370u);

	private readonly RepeatedField<int> rewardCount2_ = new RepeatedField<int>();

	public const int RewardCount3FieldNumber = 47;

	private static readonly FieldCodec<int> _repeated_rewardCount3_codec = FieldCodec.ForInt32(378u);

	private readonly RepeatedField<int> rewardCount3_ = new RepeatedField<int>();

	public const int RewardCount4FieldNumber = 48;

	private static readonly FieldCodec<int> _repeated_rewardCount4_codec = FieldCodec.ForInt32(386u);

	private readonly RepeatedField<int> rewardCount4_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 49;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(394u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardId1FieldNumber = 50;

	private static readonly FieldCodec<int> _repeated_rewardId1_codec = FieldCodec.ForInt32(402u);

	private readonly RepeatedField<int> rewardId1_ = new RepeatedField<int>();

	public const int RewardId2FieldNumber = 51;

	private static readonly FieldCodec<int> _repeated_rewardId2_codec = FieldCodec.ForInt32(410u);

	private readonly RepeatedField<int> rewardId2_ = new RepeatedField<int>();

	public const int RewardId3FieldNumber = 52;

	private static readonly FieldCodec<int> _repeated_rewardId3_codec = FieldCodec.ForInt32(418u);

	private readonly RepeatedField<int> rewardId3_ = new RepeatedField<int>();

	public const int RewardId4FieldNumber = 53;

	private static readonly FieldCodec<int> _repeated_rewardId4_codec = FieldCodec.ForInt32(426u);

	private readonly RepeatedField<int> rewardId4_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 54;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(434u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int RewardType1FieldNumber = 55;

	private static readonly FieldCodec<int> _repeated_rewardType1_codec = FieldCodec.ForInt32(442u);

	private readonly RepeatedField<int> rewardType1_ = new RepeatedField<int>();

	public const int RewardType2FieldNumber = 56;

	private static readonly FieldCodec<int> _repeated_rewardType2_codec = FieldCodec.ForInt32(450u);

	private readonly RepeatedField<int> rewardType2_ = new RepeatedField<int>();

	public const int RewardType3FieldNumber = 57;

	private static readonly FieldCodec<int> _repeated_rewardType3_codec = FieldCodec.ForInt32(458u);

	private readonly RepeatedField<int> rewardType3_ = new RepeatedField<int>();

	public const int RewardType4FieldNumber = 58;

	private static readonly FieldCodec<int> _repeated_rewardType4_codec = FieldCodec.ForInt32(466u);

	private readonly RepeatedField<int> rewardType4_ = new RepeatedField<int>();

	public const int TimelineStartMapIdFieldNumber = 59;

	private int timelineStartMapId_;

	public const int TypeFieldNumber = 60;

	private int type_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestTable12002> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => QuestTable12002Reflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AcceptCinemaName
	{
		get
		{
			return acceptCinemaName_;
		}
		set
		{
			acceptCinemaName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AcceptNpcId
	{
		get
		{
			return acceptNpcId_;
		}
		set
		{
			acceptNpcId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AcceptTutorialId
	{
		get
		{
			return acceptTutorialId_;
		}
		set
		{
			acceptTutorialId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CharGroupId
	{
		get
		{
			return charGroupId_;
		}
		set
		{
			charGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClearTime
	{
		get
		{
			return clearTime_;
		}
		set
		{
			clearTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CollectionId => collectionId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string CompleteCinemaName
	{
		get
		{
			return completeCinemaName_;
		}
		set
		{
			completeCinemaName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CompleteNpcId
	{
		get
		{
			return completeNpcId_;
		}
		set
		{
			completeNpcId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CompleteTutorialId
	{
		get
		{
			return completeTutorialId_;
		}
		set
		{
			completeTutorialId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionCount
	{
		get
		{
			return conditionCount_;
		}
		set
		{
			conditionCount_ = value;
		}
	}

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
	public RepeatedField<int> DeckList => deckList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DisplayMapId
	{
		get
		{
			return displayMapId_;
		}
		set
		{
			displayMapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DisplayRewardCount => displayRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DisplayRewardCount1 => displayRewardCount1_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardCount2 => displayRewardCount2_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardCount3 => displayRewardCount3_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardCount4 => displayRewardCount4_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardId => displayRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DisplayRewardId1 => displayRewardId1_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardId2 => displayRewardId2_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardId3 => displayRewardId3_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardId4 => displayRewardId4_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardType => displayRewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardType1 => displayRewardType1_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardType2 => displayRewardType2_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardType3 => displayRewardType3_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardType4 => displayRewardType4_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GiveQuestItemId => giveQuestItemId_;

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
	public int IsDisableInteraction
	{
		get
		{
			return isDisableInteraction_;
		}
		set
		{
			isDisableInteraction_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int IsDisableQuestMark
	{
		get
		{
			return isDisableQuestMark_;
		}
		set
		{
			isDisableQuestMark_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MagicValue => magicValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NextQuestId
	{
		get
		{
			return nextQuestId_;
		}
		set
		{
			nextQuestId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PriorQuestId
	{
		get
		{
			return priorQuestId_;
		}
		set
		{
			priorQuestId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PrologSkipQuestTextId
	{
		get
		{
			return prologSkipQuestTextId_;
		}
		set
		{
			prologSkipQuestTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestConditionQuestTextId
	{
		get
		{
			return questConditionQuestTextId_;
		}
		set
		{
			questConditionQuestTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestDescQuestTextId
	{
		get
		{
			return questDescQuestTextId_;
		}
		set
		{
			questDescQuestTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestNameQuestTextId
	{
		get
		{
			return questNameQuestTextId_;
		}
		set
		{
			questNameQuestTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestSkipQuestTextId
	{
		get
		{
			return questSkipQuestTextId_;
		}
		set
		{
			questSkipQuestTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ReputationCompleteId
	{
		get
		{
			return reputationCompleteId_;
		}
		set
		{
			reputationCompleteId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardCount => rewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCount1 => rewardCount1_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCount2 => rewardCount2_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCount3 => rewardCount3_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardCount4 => rewardCount4_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId => rewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId1 => rewardId1_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardId2 => rewardId2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId3 => rewardId3_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId4 => rewardId4_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardType => rewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardType1 => rewardType1_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardType2 => rewardType2_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardType3 => rewardType3_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardType4 => rewardType4_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TimelineStartMapId
	{
		get
		{
			return timelineStartMapId_;
		}
		set
		{
			timelineStartMapId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestTable12002()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestTable12002(QuestTable12002 other)
		: this()
	{
		acceptCinemaName_ = other.acceptCinemaName_;
		acceptNpcId_ = other.acceptNpcId_;
		acceptTutorialId_ = other.acceptTutorialId_;
		charGroupId_ = other.charGroupId_;
		clearTime_ = other.clearTime_;
		collectionId_ = other.collectionId_.Clone();
		completeCinemaName_ = other.completeCinemaName_;
		completeNpcId_ = other.completeNpcId_;
		completeTutorialId_ = other.completeTutorialId_;
		conditionCount_ = other.conditionCount_;
		conditionType_ = other.conditionType_;
		deckList_ = other.deckList_.Clone();
		displayMapId_ = other.displayMapId_;
		displayRewardCount_ = other.displayRewardCount_.Clone();
		displayRewardCount1_ = other.displayRewardCount1_.Clone();
		displayRewardCount2_ = other.displayRewardCount2_.Clone();
		displayRewardCount3_ = other.displayRewardCount3_.Clone();
		displayRewardCount4_ = other.displayRewardCount4_.Clone();
		displayRewardId_ = other.displayRewardId_.Clone();
		displayRewardId1_ = other.displayRewardId1_.Clone();
		displayRewardId2_ = other.displayRewardId2_.Clone();
		displayRewardId3_ = other.displayRewardId3_.Clone();
		displayRewardId4_ = other.displayRewardId4_.Clone();
		displayRewardType_ = other.displayRewardType_.Clone();
		displayRewardType1_ = other.displayRewardType1_.Clone();
		displayRewardType2_ = other.displayRewardType2_.Clone();
		displayRewardType3_ = other.displayRewardType3_.Clone();
		displayRewardType4_ = other.displayRewardType4_.Clone();
		giveQuestItemId_ = other.giveQuestItemId_.Clone();
		id_ = other.id_;
		isDisableInteraction_ = other.isDisableInteraction_;
		isDisableQuestMark_ = other.isDisableQuestMark_;
		magicValue_ = other.magicValue_.Clone();
		mapId_ = other.mapId_;
		nextQuestId_ = other.nextQuestId_;
		packId_ = other.packId_;
		priorQuestId_ = other.priorQuestId_;
		prologSkipQuestTextId_ = other.prologSkipQuestTextId_;
		questConditionQuestTextId_ = other.questConditionQuestTextId_;
		questDescQuestTextId_ = other.questDescQuestTextId_;
		questNameQuestTextId_ = other.questNameQuestTextId_;
		questSkipQuestTextId_ = other.questSkipQuestTextId_;
		reputationCompleteId_ = other.reputationCompleteId_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardCount1_ = other.rewardCount1_.Clone();
		rewardCount2_ = other.rewardCount2_.Clone();
		rewardCount3_ = other.rewardCount3_.Clone();
		rewardCount4_ = other.rewardCount4_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardId1_ = other.rewardId1_.Clone();
		rewardId2_ = other.rewardId2_.Clone();
		rewardId3_ = other.rewardId3_.Clone();
		rewardId4_ = other.rewardId4_.Clone();
		rewardType_ = other.rewardType_.Clone();
		rewardType1_ = other.rewardType1_.Clone();
		rewardType2_ = other.rewardType2_.Clone();
		rewardType3_ = other.rewardType3_.Clone();
		rewardType4_ = other.rewardType4_.Clone();
		timelineStartMapId_ = other.timelineStartMapId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestTable12002 Clone()
	{
		return new QuestTable12002(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestTable12002);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestTable12002 other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(AcceptCinemaName != other.AcceptCinemaName) && AcceptNpcId == other.AcceptNpcId && AcceptTutorialId == other.AcceptTutorialId && CharGroupId == other.CharGroupId && ClearTime == other.ClearTime && collectionId_.Equals(other.collectionId_) && !(CompleteCinemaName != other.CompleteCinemaName) && CompleteNpcId == other.CompleteNpcId && CompleteTutorialId == other.CompleteTutorialId && ConditionCount == other.ConditionCount && ConditionType == other.ConditionType && deckList_.Equals(other.deckList_) && DisplayMapId == other.DisplayMapId && displayRewardCount_.Equals(other.displayRewardCount_) && displayRewardCount1_.Equals(other.displayRewardCount1_) && displayRewardCount2_.Equals(other.displayRewardCount2_) && displayRewardCount3_.Equals(other.displayRewardCount3_) && displayRewardCount4_.Equals(other.displayRewardCount4_) && displayRewardId_.Equals(other.displayRewardId_) && displayRewardId1_.Equals(other.displayRewardId1_) && displayRewardId2_.Equals(other.displayRewardId2_) && displayRewardId3_.Equals(other.displayRewardId3_) && displayRewardId4_.Equals(other.displayRewardId4_) && displayRewardType_.Equals(other.displayRewardType_) && displayRewardType1_.Equals(other.displayRewardType1_) && displayRewardType2_.Equals(other.displayRewardType2_) && displayRewardType3_.Equals(other.displayRewardType3_) && displayRewardType4_.Equals(other.displayRewardType4_) && giveQuestItemId_.Equals(other.giveQuestItemId_) && Id == other.Id && IsDisableInteraction == other.IsDisableInteraction && IsDisableQuestMark == other.IsDisableQuestMark && magicValue_.Equals(other.magicValue_) && MapId == other.MapId && NextQuestId == other.NextQuestId && PackId == other.PackId && PriorQuestId == other.PriorQuestId && PrologSkipQuestTextId == other.PrologSkipQuestTextId && QuestConditionQuestTextId == other.QuestConditionQuestTextId && QuestDescQuestTextId == other.QuestDescQuestTextId && QuestNameQuestTextId == other.QuestNameQuestTextId && QuestSkipQuestTextId == other.QuestSkipQuestTextId && ReputationCompleteId == other.ReputationCompleteId && rewardCount_.Equals(other.rewardCount_) && rewardCount1_.Equals(other.rewardCount1_) && rewardCount2_.Equals(other.rewardCount2_) && rewardCount3_.Equals(other.rewardCount3_) && rewardCount4_.Equals(other.rewardCount4_) && rewardId_.Equals(other.rewardId_) && rewardId1_.Equals(other.rewardId1_) && rewardId2_.Equals(other.rewardId2_) && rewardId3_.Equals(other.rewardId3_) && rewardId4_.Equals(other.rewardId4_) && rewardType_.Equals(other.rewardType_) && rewardType1_.Equals(other.rewardType1_) && rewardType2_.Equals(other.rewardType2_) && rewardType3_.Equals(other.rewardType3_) && rewardType4_.Equals(other.rewardType4_) && TimelineStartMapId == other.TimelineStartMapId && Type == other.Type)
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
		if (AcceptCinemaName.Length != 0)
		{
			num ^= AcceptCinemaName.GetHashCode();
		}
		if (AcceptNpcId != 0)
		{
			num ^= AcceptNpcId.GetHashCode();
		}
		if (AcceptTutorialId != 0)
		{
			num ^= AcceptTutorialId.GetHashCode();
		}
		if (CharGroupId != 0)
		{
			num ^= CharGroupId.GetHashCode();
		}
		if (ClearTime != 0)
		{
			num ^= ClearTime.GetHashCode();
		}
		num ^= collectionId_.GetHashCode();
		if (CompleteCinemaName.Length != 0)
		{
			num ^= CompleteCinemaName.GetHashCode();
		}
		if (CompleteNpcId != 0)
		{
			num ^= CompleteNpcId.GetHashCode();
		}
		if (CompleteTutorialId != 0)
		{
			num ^= CompleteTutorialId.GetHashCode();
		}
		if (ConditionCount != 0)
		{
			num ^= ConditionCount.GetHashCode();
		}
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		num ^= deckList_.GetHashCode();
		if (DisplayMapId != 0)
		{
			num ^= DisplayMapId.GetHashCode();
		}
		num ^= displayRewardCount_.GetHashCode();
		num ^= displayRewardCount1_.GetHashCode();
		num ^= displayRewardCount2_.GetHashCode();
		num ^= displayRewardCount3_.GetHashCode();
		num ^= displayRewardCount4_.GetHashCode();
		num ^= displayRewardId_.GetHashCode();
		num ^= displayRewardId1_.GetHashCode();
		num ^= displayRewardId2_.GetHashCode();
		num ^= displayRewardId3_.GetHashCode();
		num ^= displayRewardId4_.GetHashCode();
		num ^= displayRewardType_.GetHashCode();
		num ^= displayRewardType1_.GetHashCode();
		num ^= displayRewardType2_.GetHashCode();
		num ^= displayRewardType3_.GetHashCode();
		num ^= displayRewardType4_.GetHashCode();
		num ^= giveQuestItemId_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsDisableInteraction != 0)
		{
			num ^= IsDisableInteraction.GetHashCode();
		}
		if (IsDisableQuestMark != 0)
		{
			num ^= IsDisableQuestMark.GetHashCode();
		}
		num ^= magicValue_.GetHashCode();
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (NextQuestId != 0)
		{
			num ^= NextQuestId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (PriorQuestId != 0)
		{
			num ^= PriorQuestId.GetHashCode();
		}
		if (PrologSkipQuestTextId != 0)
		{
			num ^= PrologSkipQuestTextId.GetHashCode();
		}
		if (QuestConditionQuestTextId != 0)
		{
			num ^= QuestConditionQuestTextId.GetHashCode();
		}
		if (QuestDescQuestTextId != 0)
		{
			num ^= QuestDescQuestTextId.GetHashCode();
		}
		if (QuestNameQuestTextId != 0)
		{
			num ^= QuestNameQuestTextId.GetHashCode();
		}
		if (QuestSkipQuestTextId != 0)
		{
			num ^= QuestSkipQuestTextId.GetHashCode();
		}
		if (ReputationCompleteId != 0)
		{
			num ^= ReputationCompleteId.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardCount1_.GetHashCode();
		num ^= rewardCount2_.GetHashCode();
		num ^= rewardCount3_.GetHashCode();
		num ^= rewardCount4_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardId1_.GetHashCode();
		num ^= rewardId2_.GetHashCode();
		num ^= rewardId3_.GetHashCode();
		num ^= rewardId4_.GetHashCode();
		num ^= rewardType_.GetHashCode();
		num ^= rewardType1_.GetHashCode();
		num ^= rewardType2_.GetHashCode();
		num ^= rewardType3_.GetHashCode();
		num ^= rewardType4_.GetHashCode();
		if (TimelineStartMapId != 0)
		{
			num ^= TimelineStartMapId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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
		if (AcceptCinemaName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AcceptCinemaName);
		}
		if (AcceptNpcId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AcceptNpcId);
		}
		if (AcceptTutorialId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AcceptTutorialId);
		}
		if (CharGroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CharGroupId);
		}
		if (ClearTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ClearTime);
		}
		collectionId_.WriteTo(ref output, _repeated_collectionId_codec);
		if (CompleteCinemaName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(CompleteCinemaName);
		}
		if (CompleteNpcId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(CompleteNpcId);
		}
		if (CompleteTutorialId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(CompleteTutorialId);
		}
		if (ConditionCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ConditionCount);
		}
		if (ConditionType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ConditionType);
		}
		deckList_.WriteTo(ref output, _repeated_deckList_codec);
		if (DisplayMapId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(DisplayMapId);
		}
		displayRewardCount_.WriteTo(ref output, _repeated_displayRewardCount_codec);
		displayRewardCount1_.WriteTo(ref output, _repeated_displayRewardCount1_codec);
		displayRewardCount2_.WriteTo(ref output, _repeated_displayRewardCount2_codec);
		displayRewardCount3_.WriteTo(ref output, _repeated_displayRewardCount3_codec);
		displayRewardCount4_.WriteTo(ref output, _repeated_displayRewardCount4_codec);
		displayRewardId_.WriteTo(ref output, _repeated_displayRewardId_codec);
		displayRewardId1_.WriteTo(ref output, _repeated_displayRewardId1_codec);
		displayRewardId2_.WriteTo(ref output, _repeated_displayRewardId2_codec);
		displayRewardId3_.WriteTo(ref output, _repeated_displayRewardId3_codec);
		displayRewardId4_.WriteTo(ref output, _repeated_displayRewardId4_codec);
		displayRewardType_.WriteTo(ref output, _repeated_displayRewardType_codec);
		displayRewardType1_.WriteTo(ref output, _repeated_displayRewardType1_codec);
		displayRewardType2_.WriteTo(ref output, _repeated_displayRewardType2_codec);
		displayRewardType3_.WriteTo(ref output, _repeated_displayRewardType3_codec);
		displayRewardType4_.WriteTo(ref output, _repeated_displayRewardType4_codec);
		giveQuestItemId_.WriteTo(ref output, _repeated_giveQuestItemId_codec);
		if (Id != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(Id);
		}
		if (IsDisableInteraction != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(IsDisableInteraction);
		}
		if (IsDisableQuestMark != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(IsDisableQuestMark);
		}
		magicValue_.WriteTo(ref output, _repeated_magicValue_codec);
		if (MapId != 0)
		{
			output.WriteRawTag(144, 2);
			output.WriteInt32(MapId);
		}
		if (NextQuestId != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteInt32(NextQuestId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(160, 2);
			output.WriteInt32(PackId);
		}
		if (PriorQuestId != 0)
		{
			output.WriteRawTag(168, 2);
			output.WriteInt32(PriorQuestId);
		}
		if (PrologSkipQuestTextId != 0)
		{
			output.WriteRawTag(176, 2);
			output.WriteInt32(PrologSkipQuestTextId);
		}
		if (QuestConditionQuestTextId != 0)
		{
			output.WriteRawTag(184, 2);
			output.WriteInt32(QuestConditionQuestTextId);
		}
		if (QuestDescQuestTextId != 0)
		{
			output.WriteRawTag(192, 2);
			output.WriteInt32(QuestDescQuestTextId);
		}
		if (QuestNameQuestTextId != 0)
		{
			output.WriteRawTag(200, 2);
			output.WriteInt32(QuestNameQuestTextId);
		}
		if (QuestSkipQuestTextId != 0)
		{
			output.WriteRawTag(208, 2);
			output.WriteInt32(QuestSkipQuestTextId);
		}
		if (ReputationCompleteId != 0)
		{
			output.WriteRawTag(216, 2);
			output.WriteInt32(ReputationCompleteId);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardCount1_.WriteTo(ref output, _repeated_rewardCount1_codec);
		rewardCount2_.WriteTo(ref output, _repeated_rewardCount2_codec);
		rewardCount3_.WriteTo(ref output, _repeated_rewardCount3_codec);
		rewardCount4_.WriteTo(ref output, _repeated_rewardCount4_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardId1_.WriteTo(ref output, _repeated_rewardId1_codec);
		rewardId2_.WriteTo(ref output, _repeated_rewardId2_codec);
		rewardId3_.WriteTo(ref output, _repeated_rewardId3_codec);
		rewardId4_.WriteTo(ref output, _repeated_rewardId4_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		rewardType1_.WriteTo(ref output, _repeated_rewardType1_codec);
		rewardType2_.WriteTo(ref output, _repeated_rewardType2_codec);
		rewardType3_.WriteTo(ref output, _repeated_rewardType3_codec);
		rewardType4_.WriteTo(ref output, _repeated_rewardType4_codec);
		if (TimelineStartMapId != 0)
		{
			output.WriteRawTag(216, 3);
			output.WriteInt32(TimelineStartMapId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(224, 3);
			output.WriteInt32(Type);
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
		if (AcceptCinemaName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AcceptCinemaName);
		}
		if (AcceptNpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AcceptNpcId);
		}
		if (AcceptTutorialId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AcceptTutorialId);
		}
		if (CharGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharGroupId);
		}
		if (ClearTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearTime);
		}
		num += collectionId_.CalculateSize(_repeated_collectionId_codec);
		if (CompleteCinemaName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CompleteCinemaName);
		}
		if (CompleteNpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompleteNpcId);
		}
		if (CompleteTutorialId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompleteTutorialId);
		}
		if (ConditionCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionCount);
		}
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		num += deckList_.CalculateSize(_repeated_deckList_codec);
		if (DisplayMapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DisplayMapId);
		}
		num += displayRewardCount_.CalculateSize(_repeated_displayRewardCount_codec);
		num += displayRewardCount1_.CalculateSize(_repeated_displayRewardCount1_codec);
		num += displayRewardCount2_.CalculateSize(_repeated_displayRewardCount2_codec);
		num += displayRewardCount3_.CalculateSize(_repeated_displayRewardCount3_codec);
		num += displayRewardCount4_.CalculateSize(_repeated_displayRewardCount4_codec);
		num += displayRewardId_.CalculateSize(_repeated_displayRewardId_codec);
		num += displayRewardId1_.CalculateSize(_repeated_displayRewardId1_codec);
		num += displayRewardId2_.CalculateSize(_repeated_displayRewardId2_codec);
		num += displayRewardId3_.CalculateSize(_repeated_displayRewardId3_codec);
		num += displayRewardId4_.CalculateSize(_repeated_displayRewardId4_codec);
		num += displayRewardType_.CalculateSize(_repeated_displayRewardType_codec);
		num += displayRewardType1_.CalculateSize(_repeated_displayRewardType1_codec);
		num += displayRewardType2_.CalculateSize(_repeated_displayRewardType2_codec);
		num += displayRewardType3_.CalculateSize(_repeated_displayRewardType3_codec);
		num += displayRewardType4_.CalculateSize(_repeated_displayRewardType4_codec);
		num += giveQuestItemId_.CalculateSize(_repeated_giveQuestItemId_codec);
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsDisableInteraction != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IsDisableInteraction);
		}
		if (IsDisableQuestMark != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IsDisableQuestMark);
		}
		num += magicValue_.CalculateSize(_repeated_magicValue_codec);
		if (MapId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (NextQuestId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NextQuestId);
		}
		if (PackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (PriorQuestId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PriorQuestId);
		}
		if (PrologSkipQuestTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PrologSkipQuestTextId);
		}
		if (QuestConditionQuestTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QuestConditionQuestTextId);
		}
		if (QuestDescQuestTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QuestDescQuestTextId);
		}
		if (QuestNameQuestTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QuestNameQuestTextId);
		}
		if (QuestSkipQuestTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QuestSkipQuestTextId);
		}
		if (ReputationCompleteId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReputationCompleteId);
		}
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardCount1_.CalculateSize(_repeated_rewardCount1_codec);
		num += rewardCount2_.CalculateSize(_repeated_rewardCount2_codec);
		num += rewardCount3_.CalculateSize(_repeated_rewardCount3_codec);
		num += rewardCount4_.CalculateSize(_repeated_rewardCount4_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardId1_.CalculateSize(_repeated_rewardId1_codec);
		num += rewardId2_.CalculateSize(_repeated_rewardId2_codec);
		num += rewardId3_.CalculateSize(_repeated_rewardId3_codec);
		num += rewardId4_.CalculateSize(_repeated_rewardId4_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		num += rewardType1_.CalculateSize(_repeated_rewardType1_codec);
		num += rewardType2_.CalculateSize(_repeated_rewardType2_codec);
		num += rewardType3_.CalculateSize(_repeated_rewardType3_codec);
		num += rewardType4_.CalculateSize(_repeated_rewardType4_codec);
		if (TimelineStartMapId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TimelineStartMapId);
		}
		if (Type != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestTable12002 other)
	{
		if (other != null)
		{
			if (other.AcceptCinemaName.Length != 0)
			{
				AcceptCinemaName = other.AcceptCinemaName;
			}
			if (other.AcceptNpcId != 0)
			{
				AcceptNpcId = other.AcceptNpcId;
			}
			if (other.AcceptTutorialId != 0)
			{
				AcceptTutorialId = other.AcceptTutorialId;
			}
			if (other.CharGroupId != 0)
			{
				CharGroupId = other.CharGroupId;
			}
			if (other.ClearTime != 0)
			{
				ClearTime = other.ClearTime;
			}
			collectionId_.Add(other.collectionId_);
			if (other.CompleteCinemaName.Length != 0)
			{
				CompleteCinemaName = other.CompleteCinemaName;
			}
			if (other.CompleteNpcId != 0)
			{
				CompleteNpcId = other.CompleteNpcId;
			}
			if (other.CompleteTutorialId != 0)
			{
				CompleteTutorialId = other.CompleteTutorialId;
			}
			if (other.ConditionCount != 0)
			{
				ConditionCount = other.ConditionCount;
			}
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			deckList_.Add(other.deckList_);
			if (other.DisplayMapId != 0)
			{
				DisplayMapId = other.DisplayMapId;
			}
			displayRewardCount_.Add(other.displayRewardCount_);
			displayRewardCount1_.Add(other.displayRewardCount1_);
			displayRewardCount2_.Add(other.displayRewardCount2_);
			displayRewardCount3_.Add(other.displayRewardCount3_);
			displayRewardCount4_.Add(other.displayRewardCount4_);
			displayRewardId_.Add(other.displayRewardId_);
			displayRewardId1_.Add(other.displayRewardId1_);
			displayRewardId2_.Add(other.displayRewardId2_);
			displayRewardId3_.Add(other.displayRewardId3_);
			displayRewardId4_.Add(other.displayRewardId4_);
			displayRewardType_.Add(other.displayRewardType_);
			displayRewardType1_.Add(other.displayRewardType1_);
			displayRewardType2_.Add(other.displayRewardType2_);
			displayRewardType3_.Add(other.displayRewardType3_);
			displayRewardType4_.Add(other.displayRewardType4_);
			giveQuestItemId_.Add(other.giveQuestItemId_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsDisableInteraction != 0)
			{
				IsDisableInteraction = other.IsDisableInteraction;
			}
			if (other.IsDisableQuestMark != 0)
			{
				IsDisableQuestMark = other.IsDisableQuestMark;
			}
			magicValue_.Add(other.magicValue_);
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.NextQuestId != 0)
			{
				NextQuestId = other.NextQuestId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.PriorQuestId != 0)
			{
				PriorQuestId = other.PriorQuestId;
			}
			if (other.PrologSkipQuestTextId != 0)
			{
				PrologSkipQuestTextId = other.PrologSkipQuestTextId;
			}
			if (other.QuestConditionQuestTextId != 0)
			{
				QuestConditionQuestTextId = other.QuestConditionQuestTextId;
			}
			if (other.QuestDescQuestTextId != 0)
			{
				QuestDescQuestTextId = other.QuestDescQuestTextId;
			}
			if (other.QuestNameQuestTextId != 0)
			{
				QuestNameQuestTextId = other.QuestNameQuestTextId;
			}
			if (other.QuestSkipQuestTextId != 0)
			{
				QuestSkipQuestTextId = other.QuestSkipQuestTextId;
			}
			if (other.ReputationCompleteId != 0)
			{
				ReputationCompleteId = other.ReputationCompleteId;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardCount1_.Add(other.rewardCount1_);
			rewardCount2_.Add(other.rewardCount2_);
			rewardCount3_.Add(other.rewardCount3_);
			rewardCount4_.Add(other.rewardCount4_);
			rewardId_.Add(other.rewardId_);
			rewardId1_.Add(other.rewardId1_);
			rewardId2_.Add(other.rewardId2_);
			rewardId3_.Add(other.rewardId3_);
			rewardId4_.Add(other.rewardId4_);
			rewardType_.Add(other.rewardType_);
			rewardType1_.Add(other.rewardType1_);
			rewardType2_.Add(other.rewardType2_);
			rewardType3_.Add(other.rewardType3_);
			rewardType4_.Add(other.rewardType4_);
			if (other.TimelineStartMapId != 0)
			{
				TimelineStartMapId = other.TimelineStartMapId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
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
				AcceptCinemaName = input.ReadString();
				break;
			case 16u:
				AcceptNpcId = input.ReadInt32();
				break;
			case 24u:
				AcceptTutorialId = input.ReadInt32();
				break;
			case 32u:
				CharGroupId = input.ReadInt32();
				break;
			case 40u:
				ClearTime = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				collectionId_.AddEntriesFrom(ref input, _repeated_collectionId_codec);
				break;
			case 58u:
				CompleteCinemaName = input.ReadString();
				break;
			case 64u:
				CompleteNpcId = input.ReadInt32();
				break;
			case 72u:
				CompleteTutorialId = input.ReadInt32();
				break;
			case 80u:
				ConditionCount = input.ReadInt32();
				break;
			case 120u:
			case 122u:
				displayRewardCount1_.AddEntriesFrom(ref input, _repeated_displayRewardCount1_codec);
				break;
			case 136u:
			case 138u:
				displayRewardCount3_.AddEntriesFrom(ref input, _repeated_displayRewardCount3_codec);
				break;
			case 128u:
			case 130u:
				displayRewardCount2_.AddEntriesFrom(ref input, _repeated_displayRewardCount2_codec);
				break;
			case 88u:
				ConditionType = input.ReadInt32();
				break;
			case 96u:
			case 98u:
				deckList_.AddEntriesFrom(ref input, _repeated_deckList_codec);
				break;
			case 104u:
				DisplayMapId = input.ReadInt32();
				break;
			case 112u:
			case 114u:
				displayRewardCount_.AddEntriesFrom(ref input, _repeated_displayRewardCount_codec);
				break;
			case 144u:
			case 146u:
				displayRewardCount4_.AddEntriesFrom(ref input, _repeated_displayRewardCount4_codec);
				break;
			case 160u:
			case 162u:
				displayRewardId1_.AddEntriesFrom(ref input, _repeated_displayRewardId1_codec);
				break;
			case 152u:
			case 154u:
				displayRewardId_.AddEntriesFrom(ref input, _repeated_displayRewardId_codec);
				break;
			case 168u:
			case 170u:
				displayRewardId2_.AddEntriesFrom(ref input, _repeated_displayRewardId2_codec);
				break;
			case 184u:
			case 186u:
				displayRewardId4_.AddEntriesFrom(ref input, _repeated_displayRewardId4_codec);
				break;
			case 176u:
			case 178u:
				displayRewardId3_.AddEntriesFrom(ref input, _repeated_displayRewardId3_codec);
				break;
			case 192u:
			case 194u:
				displayRewardType_.AddEntriesFrom(ref input, _repeated_displayRewardType_codec);
				break;
			case 208u:
			case 210u:
				displayRewardType2_.AddEntriesFrom(ref input, _repeated_displayRewardType2_codec);
				break;
			case 200u:
			case 202u:
				displayRewardType1_.AddEntriesFrom(ref input, _repeated_displayRewardType1_codec);
				break;
			case 216u:
			case 218u:
				displayRewardType3_.AddEntriesFrom(ref input, _repeated_displayRewardType3_codec);
				break;
			case 232u:
			case 234u:
				giveQuestItemId_.AddEntriesFrom(ref input, _repeated_giveQuestItemId_codec);
				break;
			case 224u:
			case 226u:
				displayRewardType4_.AddEntriesFrom(ref input, _repeated_displayRewardType4_codec);
				break;
			case 240u:
				Id = input.ReadInt32();
				break;
			case 248u:
				IsDisableInteraction = input.ReadInt32();
				break;
			case 256u:
				IsDisableQuestMark = input.ReadInt32();
				break;
			case 264u:
			case 266u:
				magicValue_.AddEntriesFrom(ref input, _repeated_magicValue_codec);
				break;
			case 272u:
				MapId = input.ReadInt32();
				break;
			case 280u:
				NextQuestId = input.ReadInt32();
				break;
			case 288u:
				PackId = input.ReadInt32();
				break;
			case 296u:
				PriorQuestId = input.ReadInt32();
				break;
			case 304u:
				PrologSkipQuestTextId = input.ReadInt32();
				break;
			case 312u:
				QuestConditionQuestTextId = input.ReadInt32();
				break;
			case 360u:
			case 362u:
				rewardCount1_.AddEntriesFrom(ref input, _repeated_rewardCount1_codec);
				break;
			case 376u:
			case 378u:
				rewardCount3_.AddEntriesFrom(ref input, _repeated_rewardCount3_codec);
				break;
			case 368u:
			case 370u:
				rewardCount2_.AddEntriesFrom(ref input, _repeated_rewardCount2_codec);
				break;
			case 320u:
				QuestDescQuestTextId = input.ReadInt32();
				break;
			case 328u:
				QuestNameQuestTextId = input.ReadInt32();
				break;
			case 336u:
				QuestSkipQuestTextId = input.ReadInt32();
				break;
			case 344u:
				ReputationCompleteId = input.ReadInt32();
				break;
			case 352u:
			case 354u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 384u:
			case 386u:
				rewardCount4_.AddEntriesFrom(ref input, _repeated_rewardCount4_codec);
				break;
			case 400u:
			case 402u:
				rewardId1_.AddEntriesFrom(ref input, _repeated_rewardId1_codec);
				break;
			case 392u:
			case 394u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 408u:
			case 410u:
				rewardId2_.AddEntriesFrom(ref input, _repeated_rewardId2_codec);
				break;
			case 424u:
			case 426u:
				rewardId4_.AddEntriesFrom(ref input, _repeated_rewardId4_codec);
				break;
			case 416u:
			case 418u:
				rewardId3_.AddEntriesFrom(ref input, _repeated_rewardId3_codec);
				break;
			case 432u:
			case 434u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			case 448u:
			case 450u:
				rewardType2_.AddEntriesFrom(ref input, _repeated_rewardType2_codec);
				break;
			case 440u:
			case 442u:
				rewardType1_.AddEntriesFrom(ref input, _repeated_rewardType1_codec);
				break;
			case 456u:
			case 458u:
				rewardType3_.AddEntriesFrom(ref input, _repeated_rewardType3_codec);
				break;
			case 472u:
				TimelineStartMapId = input.ReadInt32();
				break;
			case 480u:
				Type = input.ReadInt32();
				break;
			case 464u:
			case 466u:
				rewardType4_.AddEntriesFrom(ref input, _repeated_rewardType4_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
