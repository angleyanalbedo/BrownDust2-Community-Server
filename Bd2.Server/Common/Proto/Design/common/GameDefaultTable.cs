using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GameDefaultTable : IMessage<GameDefaultTable>, IMessage, IEquatable<GameDefaultTable>, IDeepCloneable<GameDefaultTable>, IBufferMessage
{
	private static readonly MessageParser<GameDefaultTable> _parser = new MessageParser<GameDefaultTable>(() => new GameDefaultTable());

	private UnknownFieldSet _unknownFields;

	public const int DefaultEquipmentUpgradeCostFieldNumber = 1;

	private int defaultEquipmentUpgradeCost_;

	public const int MaxEquipmentDismentleCountFieldNumber = 2;

	private int maxEquipmentDismentleCount_;

	public const int MaxEquipmentUpgradeCountFieldNumber = 3;

	private int maxEquipmentUpgradeCount_;

	public const int AddEquipInvenPriceCountFieldNumber = 4;

	private int addEquipInvenPriceCount_;

	public const int AddEquipInvenPriceTypeFieldNumber = 5;

	private int addEquipInvenPriceType_;

	public const int AddEquipStoragePriceCountFieldNumber = 6;

	private int addEquipStoragePriceCount_;

	public const int AddEquipStoragePriceTypeFieldNumber = 7;

	private int addEquipStoragePriceType_;

	public const int AddInvenPriceCountFieldNumber = 8;

	private int addInvenPriceCount_;

	public const int AddInvenPriceTypeFieldNumber = 9;

	private int addInvenPriceType_;

	public const int AddStoragePriceCountFieldNumber = 10;

	private int addStoragePriceCount_;

	public const int AddStoragePriceTypeFieldNumber = 11;

	private int addStoragePriceType_;

	public const int ChargeTimePerPvpTicketFieldNumber = 12;

	private int chargeTimePerPvpTicket_;

	public const int CheckActiveOnEnterCompletePackIdFieldNumber = 13;

	private static readonly FieldCodec<int> _repeated_checkActiveOnEnterCompletePackId_codec = FieldCodec.ForInt32(106u);

	private readonly RepeatedField<int> checkActiveOnEnterCompletePackId_ = new RepeatedField<int>();

	public const int CheckActiveOnEnterCompleteTutorialIdFieldNumber = 14;

	private int checkActiveOnEnterCompleteTutorialId_;

	public const int DailyResetTimeFieldNumber = 15;

	private string dailyResetTime_ = "";

	public const int DashCooltimeFieldNumber = 16;

	private double dashCooltime_;

	public const int DashCountFieldNumber = 17;

	private int dashCount_;

	public const int DashSpeedFieldNumber = 18;

	private double dashSpeed_;

	public const int DashTimeFieldNumber = 19;

	private double dashTime_;

	public const int DefaultCharGroupIdFieldNumber = 20;

	private int defaultCharGroupId_;

	public const int DefaultCostumeIdFieldNumber = 21;

	private int defaultCostumeId_;

	public const int DefaultEquipInvenSlotCountFieldNumber = 22;

	private int defaultEquipInvenSlotCount_;

	public const int DefaultEquipStorageSlotCountFieldNumber = 23;

	private int defaultEquipStorageSlotCount_;

	public const int DefaultInvenSlotCountFieldNumber = 24;

	private int defaultInvenSlotCount_;

	public const int DefaultStorageSlotCountFieldNumber = 25;

	private int defaultStorageSlotCount_;

	public const int DefaultTalkCharCostumeIdFieldNumber = 26;

	private int defaultTalkCharCostumeId_;

	public const int EquipmentPresetBaseCountFieldNumber = 27;

	private int equipmentPresetBaseCount_;

	public const int EventApMaxFieldNumber = 28;

	private int eventApMax_;

	public const int FieldQuestUsableTalentSkillFieldNumber = 29;

	private static readonly FieldCodec<int> _repeated_fieldQuestUsableTalentSkill_codec = FieldCodec.ForInt32(234u);

	private readonly RepeatedField<int> fieldQuestUsableTalentSkill_ = new RepeatedField<int>();

	public const int FirstLimitGachaIdFieldNumber = 30;

	private int firstLimitGachaId_;

	public const int GachaEventAddDailyPayGachaCountFieldNumber = 31;

	private int gachaEventAddDailyPayGachaCount_;

	public const int GachaEventAddFreeCountFieldNumber = 32;

	private int gachaEventAddFreeCount_;

	public const int GachaPointEndMailIdFieldNumber = 33;

	private int gachaPointEndMailId_;

	public const int GiveRecipeMaxSkillLevelFieldNumber = 34;

	private int giveRecipeMaxSkillLevel_;

	public const int GrowUpGuideAchieveLevelFieldNumber = 35;

	private int growUpGuideAchieveLevel_;

	public const int HuntDispatchLimitCountFieldNumber = 36;

	private int huntDispatchLimitCount_;

	public const int HuntingApMaxFieldNumber = 37;

	private int huntingApMax_;

	public const int IdFieldNumber = 38;

	private int id_;

	public const int InitPackIdFieldNumber = 39;

	private int initPackId_;

	public const int LinkFeedbackUrlCnFieldNumber = 40;

	private string linkFeedbackUrlCn_ = "";

	public const int LinkFeedbackUrlEnFieldNumber = 41;

	private string linkFeedbackUrlEn_ = "";

	public const int LinkFeedbackUrlJpFieldNumber = 42;

	private string linkFeedbackUrlJp_ = "";

	public const int LinkFeedbackUrlKrFieldNumber = 43;

	private string linkFeedbackUrlKr_ = "";

	public const int LinkFeedbackUrlTwFieldNumber = 44;

	private string linkFeedbackUrlTw_ = "";

	public const int LoseLikabilityPointFieldNumber = 45;

	private int loseLikabilityPoint_;

	public const int MailHistoryPeriodDateFieldNumber = 46;

	private int mailHistoryPeriodDate_;

	public const int MailViewLimitCountFieldNumber = 47;

	private int mailViewLimitCount_;

	public const int MaxAtkCollectionBuffFieldNumber = 48;

	private double maxAtkCollectionBuff_;

	public const int MaxDeckNormalTypeCountFieldNumber = 49;

	private int maxDeckNormalTypeCount_;

	public const int MaxDeckTempTypeCountFieldNumber = 50;

	private int maxDeckTempTypeCount_;

	public const int MaxEquipInvenSlotCountFieldNumber = 51;

	private int maxEquipInvenSlotCount_;

	public const int MaxEquipStorageSlotCountFieldNumber = 52;

	private int maxEquipStorageSlotCount_;

	public const int MaxFreePvpTicketFieldNumber = 53;

	private int maxFreePvpTicket_;

	public const int MaxHpCollectionBuffFieldNumber = 54;

	private double maxHpCollectionBuff_;

	public const int MaxInvenCostFieldNumber = 55;

	private int maxInvenCost_;

	public const int MaxInvenSlotCountFieldNumber = 56;

	private int maxInvenSlotCount_;

	public const int MaxMgAtkCollectionBuffFieldNumber = 57;

	private double maxMgAtkCollectionBuff_;

	public const int MaxStorageSlotCountFieldNumber = 58;

	private int maxStorageSlotCount_;

	public const int MoreSixteenUnderTwentyBillingLimitFieldNumber = 59;

	private int moreSixteenUnderTwentyBillingLimit_;

	public const int PartnerLikabilityMaxFieldNumber = 60;

	private int partnerLikabilityMax_;

	public const int PopularEquipConditionPvpRankingFieldNumber = 61;

	private int popularEquipConditionPvpRanking_;

	public const int PopularEquipValidityFieldNumber = 62;

	private int popularEquipValidity_;

	public const int PopupDisabledDurationFieldNumber = 63;

	private int popupDisabledDuration_;

	public const int PresetBaseCountFieldNumber = 64;

	private int presetBaseCount_;

	public const int PresetBuyCountFieldNumber = 65;

	private int presetBuyCount_;

	public const int PresetBuyIdFieldNumber = 66;

	private int presetBuyId_;

	public const int PresetBuyTypeFieldNumber = 67;

	private int presetBuyType_;

	public const int PresetMaxCountFieldNumber = 68;

	private int presetMaxCount_;

	public const int ReturnDayCountFieldNumber = 69;

	private int returnDayCount_;

	public const int ReturnUserPeriodFieldNumber = 70;

	private int returnUserPeriod_;

	public const int ReviewPopupConditionPackIdFieldNumber = 71;

	private int reviewPopupConditionPackId_;

	public const int ReviewPopupConditionQuestIdFieldNumber = 72;

	private int reviewPopupConditionQuestId_;

	public const int RoguelikeApMaxFieldNumber = 73;

	private int roguelikeApMax_;

	public const int ShopBuyMaxCountFieldNumber = 74;

	private int shopBuyMaxCount_;

	public const int SpeechBubbleGapTimeFieldNumber = 75;

	private int speechBubbleGapTime_;

	public const int SpeechBubbleRemindFieldNumber = 76;

	private int speechBubbleRemind_;

	public const int TalentSkillMakingDevideValueFieldNumber = 77;

	private int talentSkillMakingDevideValue_;

	public const int TalentSkillPinMaxCountFieldNumber = 78;

	private int talentSkillPinMaxCount_;

	public const int TodayQuestLimitCountFieldNumber = 79;

	private int todayQuestLimitCount_;

	public const int TodayQuestPackPostCountFieldNumber = 80;

	private int todayQuestPackPostCount_;

	public const int TorchLightApMaxFieldNumber = 81;

	private int torchLightApMax_;

	public const int UnableInnReputationFieldNumber = 82;

	private int unableInnReputation_;

	public const int UnableShopReputationFieldNumber = 83;

	private int unableShopReputation_;

	public const int UnableTalentReputationFieldNumber = 84;

	private int unableTalentReputation_;

	public const int UnderSixteenBillingLimitFieldNumber = 85;

	private int underSixteenBillingLimit_;

	public const int UseBossHuntingApFieldNumber = 86;

	private int useBossHuntingAp_;

	public const int UseNormalHuntingApFieldNumber = 87;

	private int useNormalHuntingAp_;

	public const int WinLikabilityPointFieldNumber = 88;

	private int winLikabilityPoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameDefaultTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GameDefaultTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DefaultEquipmentUpgradeCost
	{
		get
		{
			return defaultEquipmentUpgradeCost_;
		}
		set
		{
			defaultEquipmentUpgradeCost_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxEquipmentDismentleCount
	{
		get
		{
			return maxEquipmentDismentleCount_;
		}
		set
		{
			maxEquipmentDismentleCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxEquipmentUpgradeCount
	{
		get
		{
			return maxEquipmentUpgradeCount_;
		}
		set
		{
			maxEquipmentUpgradeCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddEquipInvenPriceCount
	{
		get
		{
			return addEquipInvenPriceCount_;
		}
		set
		{
			addEquipInvenPriceCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddEquipInvenPriceType
	{
		get
		{
			return addEquipInvenPriceType_;
		}
		set
		{
			addEquipInvenPriceType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddEquipStoragePriceCount
	{
		get
		{
			return addEquipStoragePriceCount_;
		}
		set
		{
			addEquipStoragePriceCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddEquipStoragePriceType
	{
		get
		{
			return addEquipStoragePriceType_;
		}
		set
		{
			addEquipStoragePriceType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddInvenPriceCount
	{
		get
		{
			return addInvenPriceCount_;
		}
		set
		{
			addInvenPriceCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AddInvenPriceType
	{
		get
		{
			return addInvenPriceType_;
		}
		set
		{
			addInvenPriceType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddStoragePriceCount
	{
		get
		{
			return addStoragePriceCount_;
		}
		set
		{
			addStoragePriceCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddStoragePriceType
	{
		get
		{
			return addStoragePriceType_;
		}
		set
		{
			addStoragePriceType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChargeTimePerPvpTicket
	{
		get
		{
			return chargeTimePerPvpTicket_;
		}
		set
		{
			chargeTimePerPvpTicket_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CheckActiveOnEnterCompletePackId => checkActiveOnEnterCompletePackId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CheckActiveOnEnterCompleteTutorialId
	{
		get
		{
			return checkActiveOnEnterCompleteTutorialId_;
		}
		set
		{
			checkActiveOnEnterCompleteTutorialId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DailyResetTime
	{
		get
		{
			return dailyResetTime_;
		}
		set
		{
			dailyResetTime_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DashCooltime
	{
		get
		{
			return dashCooltime_;
		}
		set
		{
			dashCooltime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DashCount
	{
		get
		{
			return dashCount_;
		}
		set
		{
			dashCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double DashSpeed
	{
		get
		{
			return dashSpeed_;
		}
		set
		{
			dashSpeed_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double DashTime
	{
		get
		{
			return dashTime_;
		}
		set
		{
			dashTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DefaultCharGroupId
	{
		get
		{
			return defaultCharGroupId_;
		}
		set
		{
			defaultCharGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DefaultCostumeId
	{
		get
		{
			return defaultCostumeId_;
		}
		set
		{
			defaultCostumeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DefaultEquipInvenSlotCount
	{
		get
		{
			return defaultEquipInvenSlotCount_;
		}
		set
		{
			defaultEquipInvenSlotCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DefaultEquipStorageSlotCount
	{
		get
		{
			return defaultEquipStorageSlotCount_;
		}
		set
		{
			defaultEquipStorageSlotCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DefaultInvenSlotCount
	{
		get
		{
			return defaultInvenSlotCount_;
		}
		set
		{
			defaultInvenSlotCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DefaultStorageSlotCount
	{
		get
		{
			return defaultStorageSlotCount_;
		}
		set
		{
			defaultStorageSlotCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DefaultTalkCharCostumeId
	{
		get
		{
			return defaultTalkCharCostumeId_;
		}
		set
		{
			defaultTalkCharCostumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EquipmentPresetBaseCount
	{
		get
		{
			return equipmentPresetBaseCount_;
		}
		set
		{
			equipmentPresetBaseCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventApMax
	{
		get
		{
			return eventApMax_;
		}
		set
		{
			eventApMax_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> FieldQuestUsableTalentSkill => fieldQuestUsableTalentSkill_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FirstLimitGachaId
	{
		get
		{
			return firstLimitGachaId_;
		}
		set
		{
			firstLimitGachaId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GachaEventAddDailyPayGachaCount
	{
		get
		{
			return gachaEventAddDailyPayGachaCount_;
		}
		set
		{
			gachaEventAddDailyPayGachaCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GachaEventAddFreeCount
	{
		get
		{
			return gachaEventAddFreeCount_;
		}
		set
		{
			gachaEventAddFreeCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GachaPointEndMailId
	{
		get
		{
			return gachaPointEndMailId_;
		}
		set
		{
			gachaPointEndMailId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GiveRecipeMaxSkillLevel
	{
		get
		{
			return giveRecipeMaxSkillLevel_;
		}
		set
		{
			giveRecipeMaxSkillLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GrowUpGuideAchieveLevel
	{
		get
		{
			return growUpGuideAchieveLevel_;
		}
		set
		{
			growUpGuideAchieveLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HuntDispatchLimitCount
	{
		get
		{
			return huntDispatchLimitCount_;
		}
		set
		{
			huntDispatchLimitCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HuntingApMax
	{
		get
		{
			return huntingApMax_;
		}
		set
		{
			huntingApMax_ = value;
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
	public int InitPackId
	{
		get
		{
			return initPackId_;
		}
		set
		{
			initPackId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkFeedbackUrlCn
	{
		get
		{
			return linkFeedbackUrlCn_;
		}
		set
		{
			linkFeedbackUrlCn_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LinkFeedbackUrlEn
	{
		get
		{
			return linkFeedbackUrlEn_;
		}
		set
		{
			linkFeedbackUrlEn_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkFeedbackUrlJp
	{
		get
		{
			return linkFeedbackUrlJp_;
		}
		set
		{
			linkFeedbackUrlJp_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkFeedbackUrlKr
	{
		get
		{
			return linkFeedbackUrlKr_;
		}
		set
		{
			linkFeedbackUrlKr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LinkFeedbackUrlTw
	{
		get
		{
			return linkFeedbackUrlTw_;
		}
		set
		{
			linkFeedbackUrlTw_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LoseLikabilityPoint
	{
		get
		{
			return loseLikabilityPoint_;
		}
		set
		{
			loseLikabilityPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MailHistoryPeriodDate
	{
		get
		{
			return mailHistoryPeriodDate_;
		}
		set
		{
			mailHistoryPeriodDate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MailViewLimitCount
	{
		get
		{
			return mailViewLimitCount_;
		}
		set
		{
			mailViewLimitCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MaxAtkCollectionBuff
	{
		get
		{
			return maxAtkCollectionBuff_;
		}
		set
		{
			maxAtkCollectionBuff_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxDeckNormalTypeCount
	{
		get
		{
			return maxDeckNormalTypeCount_;
		}
		set
		{
			maxDeckNormalTypeCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxDeckTempTypeCount
	{
		get
		{
			return maxDeckTempTypeCount_;
		}
		set
		{
			maxDeckTempTypeCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxEquipInvenSlotCount
	{
		get
		{
			return maxEquipInvenSlotCount_;
		}
		set
		{
			maxEquipInvenSlotCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxEquipStorageSlotCount
	{
		get
		{
			return maxEquipStorageSlotCount_;
		}
		set
		{
			maxEquipStorageSlotCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxFreePvpTicket
	{
		get
		{
			return maxFreePvpTicket_;
		}
		set
		{
			maxFreePvpTicket_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MaxHpCollectionBuff
	{
		get
		{
			return maxHpCollectionBuff_;
		}
		set
		{
			maxHpCollectionBuff_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxInvenCost
	{
		get
		{
			return maxInvenCost_;
		}
		set
		{
			maxInvenCost_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxInvenSlotCount
	{
		get
		{
			return maxInvenSlotCount_;
		}
		set
		{
			maxInvenSlotCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MaxMgAtkCollectionBuff
	{
		get
		{
			return maxMgAtkCollectionBuff_;
		}
		set
		{
			maxMgAtkCollectionBuff_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxStorageSlotCount
	{
		get
		{
			return maxStorageSlotCount_;
		}
		set
		{
			maxStorageSlotCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MoreSixteenUnderTwentyBillingLimit
	{
		get
		{
			return moreSixteenUnderTwentyBillingLimit_;
		}
		set
		{
			moreSixteenUnderTwentyBillingLimit_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PartnerLikabilityMax
	{
		get
		{
			return partnerLikabilityMax_;
		}
		set
		{
			partnerLikabilityMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PopularEquipConditionPvpRanking
	{
		get
		{
			return popularEquipConditionPvpRanking_;
		}
		set
		{
			popularEquipConditionPvpRanking_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PopularEquipValidity
	{
		get
		{
			return popularEquipValidity_;
		}
		set
		{
			popularEquipValidity_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PopupDisabledDuration
	{
		get
		{
			return popupDisabledDuration_;
		}
		set
		{
			popupDisabledDuration_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PresetBaseCount
	{
		get
		{
			return presetBaseCount_;
		}
		set
		{
			presetBaseCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PresetBuyCount
	{
		get
		{
			return presetBuyCount_;
		}
		set
		{
			presetBuyCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PresetBuyId
	{
		get
		{
			return presetBuyId_;
		}
		set
		{
			presetBuyId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PresetBuyType
	{
		get
		{
			return presetBuyType_;
		}
		set
		{
			presetBuyType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PresetMaxCount
	{
		get
		{
			return presetMaxCount_;
		}
		set
		{
			presetMaxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReturnDayCount
	{
		get
		{
			return returnDayCount_;
		}
		set
		{
			returnDayCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReturnUserPeriod
	{
		get
		{
			return returnUserPeriod_;
		}
		set
		{
			returnUserPeriod_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReviewPopupConditionPackId
	{
		get
		{
			return reviewPopupConditionPackId_;
		}
		set
		{
			reviewPopupConditionPackId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReviewPopupConditionQuestId
	{
		get
		{
			return reviewPopupConditionQuestId_;
		}
		set
		{
			reviewPopupConditionQuestId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RoguelikeApMax
	{
		get
		{
			return roguelikeApMax_;
		}
		set
		{
			roguelikeApMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShopBuyMaxCount
	{
		get
		{
			return shopBuyMaxCount_;
		}
		set
		{
			shopBuyMaxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpeechBubbleGapTime
	{
		get
		{
			return speechBubbleGapTime_;
		}
		set
		{
			speechBubbleGapTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpeechBubbleRemind
	{
		get
		{
			return speechBubbleRemind_;
		}
		set
		{
			speechBubbleRemind_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TalentSkillMakingDevideValue
	{
		get
		{
			return talentSkillMakingDevideValue_;
		}
		set
		{
			talentSkillMakingDevideValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TalentSkillPinMaxCount
	{
		get
		{
			return talentSkillPinMaxCount_;
		}
		set
		{
			talentSkillPinMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TodayQuestLimitCount
	{
		get
		{
			return todayQuestLimitCount_;
		}
		set
		{
			todayQuestLimitCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TodayQuestPackPostCount
	{
		get
		{
			return todayQuestPackPostCount_;
		}
		set
		{
			todayQuestPackPostCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TorchLightApMax
	{
		get
		{
			return torchLightApMax_;
		}
		set
		{
			torchLightApMax_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UnableInnReputation
	{
		get
		{
			return unableInnReputation_;
		}
		set
		{
			unableInnReputation_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UnableShopReputation
	{
		get
		{
			return unableShopReputation_;
		}
		set
		{
			unableShopReputation_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UnableTalentReputation
	{
		get
		{
			return unableTalentReputation_;
		}
		set
		{
			unableTalentReputation_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UnderSixteenBillingLimit
	{
		get
		{
			return underSixteenBillingLimit_;
		}
		set
		{
			underSixteenBillingLimit_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UseBossHuntingAp
	{
		get
		{
			return useBossHuntingAp_;
		}
		set
		{
			useBossHuntingAp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseNormalHuntingAp
	{
		get
		{
			return useNormalHuntingAp_;
		}
		set
		{
			useNormalHuntingAp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int WinLikabilityPoint
	{
		get
		{
			return winLikabilityPoint_;
		}
		set
		{
			winLikabilityPoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameDefaultTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GameDefaultTable(GameDefaultTable other)
		: this()
	{
		defaultEquipmentUpgradeCost_ = other.defaultEquipmentUpgradeCost_;
		maxEquipmentDismentleCount_ = other.maxEquipmentDismentleCount_;
		maxEquipmentUpgradeCount_ = other.maxEquipmentUpgradeCount_;
		addEquipInvenPriceCount_ = other.addEquipInvenPriceCount_;
		addEquipInvenPriceType_ = other.addEquipInvenPriceType_;
		addEquipStoragePriceCount_ = other.addEquipStoragePriceCount_;
		addEquipStoragePriceType_ = other.addEquipStoragePriceType_;
		addInvenPriceCount_ = other.addInvenPriceCount_;
		addInvenPriceType_ = other.addInvenPriceType_;
		addStoragePriceCount_ = other.addStoragePriceCount_;
		addStoragePriceType_ = other.addStoragePriceType_;
		chargeTimePerPvpTicket_ = other.chargeTimePerPvpTicket_;
		checkActiveOnEnterCompletePackId_ = other.checkActiveOnEnterCompletePackId_.Clone();
		checkActiveOnEnterCompleteTutorialId_ = other.checkActiveOnEnterCompleteTutorialId_;
		dailyResetTime_ = other.dailyResetTime_;
		dashCooltime_ = other.dashCooltime_;
		dashCount_ = other.dashCount_;
		dashSpeed_ = other.dashSpeed_;
		dashTime_ = other.dashTime_;
		defaultCharGroupId_ = other.defaultCharGroupId_;
		defaultCostumeId_ = other.defaultCostumeId_;
		defaultEquipInvenSlotCount_ = other.defaultEquipInvenSlotCount_;
		defaultEquipStorageSlotCount_ = other.defaultEquipStorageSlotCount_;
		defaultInvenSlotCount_ = other.defaultInvenSlotCount_;
		defaultStorageSlotCount_ = other.defaultStorageSlotCount_;
		defaultTalkCharCostumeId_ = other.defaultTalkCharCostumeId_;
		equipmentPresetBaseCount_ = other.equipmentPresetBaseCount_;
		eventApMax_ = other.eventApMax_;
		fieldQuestUsableTalentSkill_ = other.fieldQuestUsableTalentSkill_.Clone();
		firstLimitGachaId_ = other.firstLimitGachaId_;
		gachaEventAddDailyPayGachaCount_ = other.gachaEventAddDailyPayGachaCount_;
		gachaEventAddFreeCount_ = other.gachaEventAddFreeCount_;
		gachaPointEndMailId_ = other.gachaPointEndMailId_;
		giveRecipeMaxSkillLevel_ = other.giveRecipeMaxSkillLevel_;
		growUpGuideAchieveLevel_ = other.growUpGuideAchieveLevel_;
		huntDispatchLimitCount_ = other.huntDispatchLimitCount_;
		huntingApMax_ = other.huntingApMax_;
		id_ = other.id_;
		initPackId_ = other.initPackId_;
		linkFeedbackUrlCn_ = other.linkFeedbackUrlCn_;
		linkFeedbackUrlEn_ = other.linkFeedbackUrlEn_;
		linkFeedbackUrlJp_ = other.linkFeedbackUrlJp_;
		linkFeedbackUrlKr_ = other.linkFeedbackUrlKr_;
		linkFeedbackUrlTw_ = other.linkFeedbackUrlTw_;
		loseLikabilityPoint_ = other.loseLikabilityPoint_;
		mailHistoryPeriodDate_ = other.mailHistoryPeriodDate_;
		mailViewLimitCount_ = other.mailViewLimitCount_;
		maxAtkCollectionBuff_ = other.maxAtkCollectionBuff_;
		maxDeckNormalTypeCount_ = other.maxDeckNormalTypeCount_;
		maxDeckTempTypeCount_ = other.maxDeckTempTypeCount_;
		maxEquipInvenSlotCount_ = other.maxEquipInvenSlotCount_;
		maxEquipStorageSlotCount_ = other.maxEquipStorageSlotCount_;
		maxFreePvpTicket_ = other.maxFreePvpTicket_;
		maxHpCollectionBuff_ = other.maxHpCollectionBuff_;
		maxInvenCost_ = other.maxInvenCost_;
		maxInvenSlotCount_ = other.maxInvenSlotCount_;
		maxMgAtkCollectionBuff_ = other.maxMgAtkCollectionBuff_;
		maxStorageSlotCount_ = other.maxStorageSlotCount_;
		moreSixteenUnderTwentyBillingLimit_ = other.moreSixteenUnderTwentyBillingLimit_;
		partnerLikabilityMax_ = other.partnerLikabilityMax_;
		popularEquipConditionPvpRanking_ = other.popularEquipConditionPvpRanking_;
		popularEquipValidity_ = other.popularEquipValidity_;
		popupDisabledDuration_ = other.popupDisabledDuration_;
		presetBaseCount_ = other.presetBaseCount_;
		presetBuyCount_ = other.presetBuyCount_;
		presetBuyId_ = other.presetBuyId_;
		presetBuyType_ = other.presetBuyType_;
		presetMaxCount_ = other.presetMaxCount_;
		returnDayCount_ = other.returnDayCount_;
		returnUserPeriod_ = other.returnUserPeriod_;
		reviewPopupConditionPackId_ = other.reviewPopupConditionPackId_;
		reviewPopupConditionQuestId_ = other.reviewPopupConditionQuestId_;
		roguelikeApMax_ = other.roguelikeApMax_;
		shopBuyMaxCount_ = other.shopBuyMaxCount_;
		speechBubbleGapTime_ = other.speechBubbleGapTime_;
		speechBubbleRemind_ = other.speechBubbleRemind_;
		talentSkillMakingDevideValue_ = other.talentSkillMakingDevideValue_;
		talentSkillPinMaxCount_ = other.talentSkillPinMaxCount_;
		todayQuestLimitCount_ = other.todayQuestLimitCount_;
		todayQuestPackPostCount_ = other.todayQuestPackPostCount_;
		torchLightApMax_ = other.torchLightApMax_;
		unableInnReputation_ = other.unableInnReputation_;
		unableShopReputation_ = other.unableShopReputation_;
		unableTalentReputation_ = other.unableTalentReputation_;
		underSixteenBillingLimit_ = other.underSixteenBillingLimit_;
		useBossHuntingAp_ = other.useBossHuntingAp_;
		useNormalHuntingAp_ = other.useNormalHuntingAp_;
		winLikabilityPoint_ = other.winLikabilityPoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GameDefaultTable Clone()
	{
		return new GameDefaultTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GameDefaultTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameDefaultTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DefaultEquipmentUpgradeCost == other.DefaultEquipmentUpgradeCost && MaxEquipmentDismentleCount == other.MaxEquipmentDismentleCount && MaxEquipmentUpgradeCount == other.MaxEquipmentUpgradeCount && AddEquipInvenPriceCount == other.AddEquipInvenPriceCount && AddEquipInvenPriceType == other.AddEquipInvenPriceType && AddEquipStoragePriceCount == other.AddEquipStoragePriceCount && AddEquipStoragePriceType == other.AddEquipStoragePriceType && AddInvenPriceCount == other.AddInvenPriceCount && AddInvenPriceType == other.AddInvenPriceType && AddStoragePriceCount == other.AddStoragePriceCount && AddStoragePriceType == other.AddStoragePriceType && ChargeTimePerPvpTicket == other.ChargeTimePerPvpTicket && checkActiveOnEnterCompletePackId_.Equals(other.checkActiveOnEnterCompletePackId_) && CheckActiveOnEnterCompleteTutorialId == other.CheckActiveOnEnterCompleteTutorialId && !(DailyResetTime != other.DailyResetTime) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DashCooltime, other.DashCooltime) && DashCount == other.DashCount && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DashSpeed, other.DashSpeed) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DashTime, other.DashTime) && DefaultCharGroupId == other.DefaultCharGroupId && DefaultCostumeId == other.DefaultCostumeId && DefaultEquipInvenSlotCount == other.DefaultEquipInvenSlotCount && DefaultEquipStorageSlotCount == other.DefaultEquipStorageSlotCount && DefaultInvenSlotCount == other.DefaultInvenSlotCount && DefaultStorageSlotCount == other.DefaultStorageSlotCount && DefaultTalkCharCostumeId == other.DefaultTalkCharCostumeId && EquipmentPresetBaseCount == other.EquipmentPresetBaseCount && EventApMax == other.EventApMax && fieldQuestUsableTalentSkill_.Equals(other.fieldQuestUsableTalentSkill_) && FirstLimitGachaId == other.FirstLimitGachaId && GachaEventAddDailyPayGachaCount == other.GachaEventAddDailyPayGachaCount && GachaEventAddFreeCount == other.GachaEventAddFreeCount && GachaPointEndMailId == other.GachaPointEndMailId && GiveRecipeMaxSkillLevel == other.GiveRecipeMaxSkillLevel && GrowUpGuideAchieveLevel == other.GrowUpGuideAchieveLevel && HuntDispatchLimitCount == other.HuntDispatchLimitCount && HuntingApMax == other.HuntingApMax && Id == other.Id && InitPackId == other.InitPackId && !(LinkFeedbackUrlCn != other.LinkFeedbackUrlCn) && !(LinkFeedbackUrlEn != other.LinkFeedbackUrlEn) && !(LinkFeedbackUrlJp != other.LinkFeedbackUrlJp) && !(LinkFeedbackUrlKr != other.LinkFeedbackUrlKr) && !(LinkFeedbackUrlTw != other.LinkFeedbackUrlTw) && LoseLikabilityPoint == other.LoseLikabilityPoint && MailHistoryPeriodDate == other.MailHistoryPeriodDate && MailViewLimitCount == other.MailViewLimitCount && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxAtkCollectionBuff, other.MaxAtkCollectionBuff) && MaxDeckNormalTypeCount == other.MaxDeckNormalTypeCount && MaxDeckTempTypeCount == other.MaxDeckTempTypeCount && MaxEquipInvenSlotCount == other.MaxEquipInvenSlotCount && MaxEquipStorageSlotCount == other.MaxEquipStorageSlotCount && MaxFreePvpTicket == other.MaxFreePvpTicket && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxHpCollectionBuff, other.MaxHpCollectionBuff) && MaxInvenCost == other.MaxInvenCost && MaxInvenSlotCount == other.MaxInvenSlotCount && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxMgAtkCollectionBuff, other.MaxMgAtkCollectionBuff) && MaxStorageSlotCount == other.MaxStorageSlotCount && MoreSixteenUnderTwentyBillingLimit == other.MoreSixteenUnderTwentyBillingLimit && PartnerLikabilityMax == other.PartnerLikabilityMax && PopularEquipConditionPvpRanking == other.PopularEquipConditionPvpRanking && PopularEquipValidity == other.PopularEquipValidity && PopupDisabledDuration == other.PopupDisabledDuration && PresetBaseCount == other.PresetBaseCount && PresetBuyCount == other.PresetBuyCount && PresetBuyId == other.PresetBuyId && PresetBuyType == other.PresetBuyType && PresetMaxCount == other.PresetMaxCount && ReturnDayCount == other.ReturnDayCount && ReturnUserPeriod == other.ReturnUserPeriod && ReviewPopupConditionPackId == other.ReviewPopupConditionPackId && ReviewPopupConditionQuestId == other.ReviewPopupConditionQuestId && RoguelikeApMax == other.RoguelikeApMax && ShopBuyMaxCount == other.ShopBuyMaxCount && SpeechBubbleGapTime == other.SpeechBubbleGapTime && SpeechBubbleRemind == other.SpeechBubbleRemind && TalentSkillMakingDevideValue == other.TalentSkillMakingDevideValue && TalentSkillPinMaxCount == other.TalentSkillPinMaxCount && TodayQuestLimitCount == other.TodayQuestLimitCount && TodayQuestPackPostCount == other.TodayQuestPackPostCount && TorchLightApMax == other.TorchLightApMax && UnableInnReputation == other.UnableInnReputation && UnableShopReputation == other.UnableShopReputation && UnableTalentReputation == other.UnableTalentReputation && UnderSixteenBillingLimit == other.UnderSixteenBillingLimit && UseBossHuntingAp == other.UseBossHuntingAp && UseNormalHuntingAp == other.UseNormalHuntingAp && WinLikabilityPoint == other.WinLikabilityPoint)
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
		if (DefaultEquipmentUpgradeCost != 0)
		{
			num ^= DefaultEquipmentUpgradeCost.GetHashCode();
		}
		if (MaxEquipmentDismentleCount != 0)
		{
			num ^= MaxEquipmentDismentleCount.GetHashCode();
		}
		if (MaxEquipmentUpgradeCount != 0)
		{
			num ^= MaxEquipmentUpgradeCount.GetHashCode();
		}
		if (AddEquipInvenPriceCount != 0)
		{
			num ^= AddEquipInvenPriceCount.GetHashCode();
		}
		if (AddEquipInvenPriceType != 0)
		{
			num ^= AddEquipInvenPriceType.GetHashCode();
		}
		if (AddEquipStoragePriceCount != 0)
		{
			num ^= AddEquipStoragePriceCount.GetHashCode();
		}
		if (AddEquipStoragePriceType != 0)
		{
			num ^= AddEquipStoragePriceType.GetHashCode();
		}
		if (AddInvenPriceCount != 0)
		{
			num ^= AddInvenPriceCount.GetHashCode();
		}
		if (AddInvenPriceType != 0)
		{
			num ^= AddInvenPriceType.GetHashCode();
		}
		if (AddStoragePriceCount != 0)
		{
			num ^= AddStoragePriceCount.GetHashCode();
		}
		if (AddStoragePriceType != 0)
		{
			num ^= AddStoragePriceType.GetHashCode();
		}
		if (ChargeTimePerPvpTicket != 0)
		{
			num ^= ChargeTimePerPvpTicket.GetHashCode();
		}
		num ^= checkActiveOnEnterCompletePackId_.GetHashCode();
		if (CheckActiveOnEnterCompleteTutorialId != 0)
		{
			num ^= CheckActiveOnEnterCompleteTutorialId.GetHashCode();
		}
		if (DailyResetTime.Length != 0)
		{
			num ^= DailyResetTime.GetHashCode();
		}
		if (DashCooltime != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DashCooltime);
		}
		if (DashCount != 0)
		{
			num ^= DashCount.GetHashCode();
		}
		if (DashSpeed != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DashSpeed);
		}
		if (DashTime != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DashTime);
		}
		if (DefaultCharGroupId != 0)
		{
			num ^= DefaultCharGroupId.GetHashCode();
		}
		if (DefaultCostumeId != 0)
		{
			num ^= DefaultCostumeId.GetHashCode();
		}
		if (DefaultEquipInvenSlotCount != 0)
		{
			num ^= DefaultEquipInvenSlotCount.GetHashCode();
		}
		if (DefaultEquipStorageSlotCount != 0)
		{
			num ^= DefaultEquipStorageSlotCount.GetHashCode();
		}
		if (DefaultInvenSlotCount != 0)
		{
			num ^= DefaultInvenSlotCount.GetHashCode();
		}
		if (DefaultStorageSlotCount != 0)
		{
			num ^= DefaultStorageSlotCount.GetHashCode();
		}
		if (DefaultTalkCharCostumeId != 0)
		{
			num ^= DefaultTalkCharCostumeId.GetHashCode();
		}
		if (EquipmentPresetBaseCount != 0)
		{
			num ^= EquipmentPresetBaseCount.GetHashCode();
		}
		if (EventApMax != 0)
		{
			num ^= EventApMax.GetHashCode();
		}
		num ^= fieldQuestUsableTalentSkill_.GetHashCode();
		if (FirstLimitGachaId != 0)
		{
			num ^= FirstLimitGachaId.GetHashCode();
		}
		if (GachaEventAddDailyPayGachaCount != 0)
		{
			num ^= GachaEventAddDailyPayGachaCount.GetHashCode();
		}
		if (GachaEventAddFreeCount != 0)
		{
			num ^= GachaEventAddFreeCount.GetHashCode();
		}
		if (GachaPointEndMailId != 0)
		{
			num ^= GachaPointEndMailId.GetHashCode();
		}
		if (GiveRecipeMaxSkillLevel != 0)
		{
			num ^= GiveRecipeMaxSkillLevel.GetHashCode();
		}
		if (GrowUpGuideAchieveLevel != 0)
		{
			num ^= GrowUpGuideAchieveLevel.GetHashCode();
		}
		if (HuntDispatchLimitCount != 0)
		{
			num ^= HuntDispatchLimitCount.GetHashCode();
		}
		if (HuntingApMax != 0)
		{
			num ^= HuntingApMax.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (InitPackId != 0)
		{
			num ^= InitPackId.GetHashCode();
		}
		if (LinkFeedbackUrlCn.Length != 0)
		{
			num ^= LinkFeedbackUrlCn.GetHashCode();
		}
		if (LinkFeedbackUrlEn.Length != 0)
		{
			num ^= LinkFeedbackUrlEn.GetHashCode();
		}
		if (LinkFeedbackUrlJp.Length != 0)
		{
			num ^= LinkFeedbackUrlJp.GetHashCode();
		}
		if (LinkFeedbackUrlKr.Length != 0)
		{
			num ^= LinkFeedbackUrlKr.GetHashCode();
		}
		if (LinkFeedbackUrlTw.Length != 0)
		{
			num ^= LinkFeedbackUrlTw.GetHashCode();
		}
		if (LoseLikabilityPoint != 0)
		{
			num ^= LoseLikabilityPoint.GetHashCode();
		}
		if (MailHistoryPeriodDate != 0)
		{
			num ^= MailHistoryPeriodDate.GetHashCode();
		}
		if (MailViewLimitCount != 0)
		{
			num ^= MailViewLimitCount.GetHashCode();
		}
		if (MaxAtkCollectionBuff != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxAtkCollectionBuff);
		}
		if (MaxDeckNormalTypeCount != 0)
		{
			num ^= MaxDeckNormalTypeCount.GetHashCode();
		}
		if (MaxDeckTempTypeCount != 0)
		{
			num ^= MaxDeckTempTypeCount.GetHashCode();
		}
		if (MaxEquipInvenSlotCount != 0)
		{
			num ^= MaxEquipInvenSlotCount.GetHashCode();
		}
		if (MaxEquipStorageSlotCount != 0)
		{
			num ^= MaxEquipStorageSlotCount.GetHashCode();
		}
		if (MaxFreePvpTicket != 0)
		{
			num ^= MaxFreePvpTicket.GetHashCode();
		}
		if (MaxHpCollectionBuff != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxHpCollectionBuff);
		}
		if (MaxInvenCost != 0)
		{
			num ^= MaxInvenCost.GetHashCode();
		}
		if (MaxInvenSlotCount != 0)
		{
			num ^= MaxInvenSlotCount.GetHashCode();
		}
		if (MaxMgAtkCollectionBuff != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxMgAtkCollectionBuff);
		}
		if (MaxStorageSlotCount != 0)
		{
			num ^= MaxStorageSlotCount.GetHashCode();
		}
		if (MoreSixteenUnderTwentyBillingLimit != 0)
		{
			num ^= MoreSixteenUnderTwentyBillingLimit.GetHashCode();
		}
		if (PartnerLikabilityMax != 0)
		{
			num ^= PartnerLikabilityMax.GetHashCode();
		}
		if (PopularEquipConditionPvpRanking != 0)
		{
			num ^= PopularEquipConditionPvpRanking.GetHashCode();
		}
		if (PopularEquipValidity != 0)
		{
			num ^= PopularEquipValidity.GetHashCode();
		}
		if (PopupDisabledDuration != 0)
		{
			num ^= PopupDisabledDuration.GetHashCode();
		}
		if (PresetBaseCount != 0)
		{
			num ^= PresetBaseCount.GetHashCode();
		}
		if (PresetBuyCount != 0)
		{
			num ^= PresetBuyCount.GetHashCode();
		}
		if (PresetBuyId != 0)
		{
			num ^= PresetBuyId.GetHashCode();
		}
		if (PresetBuyType != 0)
		{
			num ^= PresetBuyType.GetHashCode();
		}
		if (PresetMaxCount != 0)
		{
			num ^= PresetMaxCount.GetHashCode();
		}
		if (ReturnDayCount != 0)
		{
			num ^= ReturnDayCount.GetHashCode();
		}
		if (ReturnUserPeriod != 0)
		{
			num ^= ReturnUserPeriod.GetHashCode();
		}
		if (ReviewPopupConditionPackId != 0)
		{
			num ^= ReviewPopupConditionPackId.GetHashCode();
		}
		if (ReviewPopupConditionQuestId != 0)
		{
			num ^= ReviewPopupConditionQuestId.GetHashCode();
		}
		if (RoguelikeApMax != 0)
		{
			num ^= RoguelikeApMax.GetHashCode();
		}
		if (ShopBuyMaxCount != 0)
		{
			num ^= ShopBuyMaxCount.GetHashCode();
		}
		if (SpeechBubbleGapTime != 0)
		{
			num ^= SpeechBubbleGapTime.GetHashCode();
		}
		if (SpeechBubbleRemind != 0)
		{
			num ^= SpeechBubbleRemind.GetHashCode();
		}
		if (TalentSkillMakingDevideValue != 0)
		{
			num ^= TalentSkillMakingDevideValue.GetHashCode();
		}
		if (TalentSkillPinMaxCount != 0)
		{
			num ^= TalentSkillPinMaxCount.GetHashCode();
		}
		if (TodayQuestLimitCount != 0)
		{
			num ^= TodayQuestLimitCount.GetHashCode();
		}
		if (TodayQuestPackPostCount != 0)
		{
			num ^= TodayQuestPackPostCount.GetHashCode();
		}
		if (TorchLightApMax != 0)
		{
			num ^= TorchLightApMax.GetHashCode();
		}
		if (UnableInnReputation != 0)
		{
			num ^= UnableInnReputation.GetHashCode();
		}
		if (UnableShopReputation != 0)
		{
			num ^= UnableShopReputation.GetHashCode();
		}
		if (UnableTalentReputation != 0)
		{
			num ^= UnableTalentReputation.GetHashCode();
		}
		if (UnderSixteenBillingLimit != 0)
		{
			num ^= UnderSixteenBillingLimit.GetHashCode();
		}
		if (UseBossHuntingAp != 0)
		{
			num ^= UseBossHuntingAp.GetHashCode();
		}
		if (UseNormalHuntingAp != 0)
		{
			num ^= UseNormalHuntingAp.GetHashCode();
		}
		if (WinLikabilityPoint != 0)
		{
			num ^= WinLikabilityPoint.GetHashCode();
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
		if (DefaultEquipmentUpgradeCost != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DefaultEquipmentUpgradeCost);
		}
		if (MaxEquipmentDismentleCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MaxEquipmentDismentleCount);
		}
		if (MaxEquipmentUpgradeCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MaxEquipmentUpgradeCount);
		}
		if (AddEquipInvenPriceCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AddEquipInvenPriceCount);
		}
		if (AddEquipInvenPriceType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(AddEquipInvenPriceType);
		}
		if (AddEquipStoragePriceCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(AddEquipStoragePriceCount);
		}
		if (AddEquipStoragePriceType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(AddEquipStoragePriceType);
		}
		if (AddInvenPriceCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(AddInvenPriceCount);
		}
		if (AddInvenPriceType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(AddInvenPriceType);
		}
		if (AddStoragePriceCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(AddStoragePriceCount);
		}
		if (AddStoragePriceType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(AddStoragePriceType);
		}
		if (ChargeTimePerPvpTicket != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(ChargeTimePerPvpTicket);
		}
		checkActiveOnEnterCompletePackId_.WriteTo(ref output, _repeated_checkActiveOnEnterCompletePackId_codec);
		if (CheckActiveOnEnterCompleteTutorialId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(CheckActiveOnEnterCompleteTutorialId);
		}
		if (DailyResetTime.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(DailyResetTime);
		}
		if (DashCooltime != 0.0)
		{
			output.WriteRawTag(129, 1);
			output.WriteDouble(DashCooltime);
		}
		if (DashCount != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(DashCount);
		}
		if (DashSpeed != 0.0)
		{
			output.WriteRawTag(145, 1);
			output.WriteDouble(DashSpeed);
		}
		if (DashTime != 0.0)
		{
			output.WriteRawTag(153, 1);
			output.WriteDouble(DashTime);
		}
		if (DefaultCharGroupId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(DefaultCharGroupId);
		}
		if (DefaultCostumeId != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(DefaultCostumeId);
		}
		if (DefaultEquipInvenSlotCount != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(DefaultEquipInvenSlotCount);
		}
		if (DefaultEquipStorageSlotCount != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(DefaultEquipStorageSlotCount);
		}
		if (DefaultInvenSlotCount != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(DefaultInvenSlotCount);
		}
		if (DefaultStorageSlotCount != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(DefaultStorageSlotCount);
		}
		if (DefaultTalkCharCostumeId != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(DefaultTalkCharCostumeId);
		}
		if (EquipmentPresetBaseCount != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(EquipmentPresetBaseCount);
		}
		if (EventApMax != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(EventApMax);
		}
		fieldQuestUsableTalentSkill_.WriteTo(ref output, _repeated_fieldQuestUsableTalentSkill_codec);
		if (FirstLimitGachaId != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(FirstLimitGachaId);
		}
		if (GachaEventAddDailyPayGachaCount != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(GachaEventAddDailyPayGachaCount);
		}
		if (GachaEventAddFreeCount != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(GachaEventAddFreeCount);
		}
		if (GachaPointEndMailId != 0)
		{
			output.WriteRawTag(136, 2);
			output.WriteInt32(GachaPointEndMailId);
		}
		if (GiveRecipeMaxSkillLevel != 0)
		{
			output.WriteRawTag(144, 2);
			output.WriteInt32(GiveRecipeMaxSkillLevel);
		}
		if (GrowUpGuideAchieveLevel != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteInt32(GrowUpGuideAchieveLevel);
		}
		if (HuntDispatchLimitCount != 0)
		{
			output.WriteRawTag(160, 2);
			output.WriteInt32(HuntDispatchLimitCount);
		}
		if (HuntingApMax != 0)
		{
			output.WriteRawTag(168, 2);
			output.WriteInt32(HuntingApMax);
		}
		if (Id != 0)
		{
			output.WriteRawTag(176, 2);
			output.WriteInt32(Id);
		}
		if (InitPackId != 0)
		{
			output.WriteRawTag(184, 2);
			output.WriteInt32(InitPackId);
		}
		if (LinkFeedbackUrlCn.Length != 0)
		{
			output.WriteRawTag(194, 2);
			output.WriteString(LinkFeedbackUrlCn);
		}
		if (LinkFeedbackUrlEn.Length != 0)
		{
			output.WriteRawTag(202, 2);
			output.WriteString(LinkFeedbackUrlEn);
		}
		if (LinkFeedbackUrlJp.Length != 0)
		{
			output.WriteRawTag(210, 2);
			output.WriteString(LinkFeedbackUrlJp);
		}
		if (LinkFeedbackUrlKr.Length != 0)
		{
			output.WriteRawTag(218, 2);
			output.WriteString(LinkFeedbackUrlKr);
		}
		if (LinkFeedbackUrlTw.Length != 0)
		{
			output.WriteRawTag(226, 2);
			output.WriteString(LinkFeedbackUrlTw);
		}
		if (LoseLikabilityPoint != 0)
		{
			output.WriteRawTag(232, 2);
			output.WriteInt32(LoseLikabilityPoint);
		}
		if (MailHistoryPeriodDate != 0)
		{
			output.WriteRawTag(240, 2);
			output.WriteInt32(MailHistoryPeriodDate);
		}
		if (MailViewLimitCount != 0)
		{
			output.WriteRawTag(248, 2);
			output.WriteInt32(MailViewLimitCount);
		}
		if (MaxAtkCollectionBuff != 0.0)
		{
			output.WriteRawTag(129, 3);
			output.WriteDouble(MaxAtkCollectionBuff);
		}
		if (MaxDeckNormalTypeCount != 0)
		{
			output.WriteRawTag(136, 3);
			output.WriteInt32(MaxDeckNormalTypeCount);
		}
		if (MaxDeckTempTypeCount != 0)
		{
			output.WriteRawTag(144, 3);
			output.WriteInt32(MaxDeckTempTypeCount);
		}
		if (MaxEquipInvenSlotCount != 0)
		{
			output.WriteRawTag(152, 3);
			output.WriteInt32(MaxEquipInvenSlotCount);
		}
		if (MaxEquipStorageSlotCount != 0)
		{
			output.WriteRawTag(160, 3);
			output.WriteInt32(MaxEquipStorageSlotCount);
		}
		if (MaxFreePvpTicket != 0)
		{
			output.WriteRawTag(168, 3);
			output.WriteInt32(MaxFreePvpTicket);
		}
		if (MaxHpCollectionBuff != 0.0)
		{
			output.WriteRawTag(177, 3);
			output.WriteDouble(MaxHpCollectionBuff);
		}
		if (MaxInvenCost != 0)
		{
			output.WriteRawTag(184, 3);
			output.WriteInt32(MaxInvenCost);
		}
		if (MaxInvenSlotCount != 0)
		{
			output.WriteRawTag(192, 3);
			output.WriteInt32(MaxInvenSlotCount);
		}
		if (MaxMgAtkCollectionBuff != 0.0)
		{
			output.WriteRawTag(201, 3);
			output.WriteDouble(MaxMgAtkCollectionBuff);
		}
		if (MaxStorageSlotCount != 0)
		{
			output.WriteRawTag(208, 3);
			output.WriteInt32(MaxStorageSlotCount);
		}
		if (MoreSixteenUnderTwentyBillingLimit != 0)
		{
			output.WriteRawTag(216, 3);
			output.WriteInt32(MoreSixteenUnderTwentyBillingLimit);
		}
		if (PartnerLikabilityMax != 0)
		{
			output.WriteRawTag(224, 3);
			output.WriteInt32(PartnerLikabilityMax);
		}
		if (PopularEquipConditionPvpRanking != 0)
		{
			output.WriteRawTag(232, 3);
			output.WriteInt32(PopularEquipConditionPvpRanking);
		}
		if (PopularEquipValidity != 0)
		{
			output.WriteRawTag(240, 3);
			output.WriteInt32(PopularEquipValidity);
		}
		if (PopupDisabledDuration != 0)
		{
			output.WriteRawTag(248, 3);
			output.WriteInt32(PopupDisabledDuration);
		}
		if (PresetBaseCount != 0)
		{
			output.WriteRawTag(128, 4);
			output.WriteInt32(PresetBaseCount);
		}
		if (PresetBuyCount != 0)
		{
			output.WriteRawTag(136, 4);
			output.WriteInt32(PresetBuyCount);
		}
		if (PresetBuyId != 0)
		{
			output.WriteRawTag(144, 4);
			output.WriteInt32(PresetBuyId);
		}
		if (PresetBuyType != 0)
		{
			output.WriteRawTag(152, 4);
			output.WriteInt32(PresetBuyType);
		}
		if (PresetMaxCount != 0)
		{
			output.WriteRawTag(160, 4);
			output.WriteInt32(PresetMaxCount);
		}
		if (ReturnDayCount != 0)
		{
			output.WriteRawTag(168, 4);
			output.WriteInt32(ReturnDayCount);
		}
		if (ReturnUserPeriod != 0)
		{
			output.WriteRawTag(176, 4);
			output.WriteInt32(ReturnUserPeriod);
		}
		if (ReviewPopupConditionPackId != 0)
		{
			output.WriteRawTag(184, 4);
			output.WriteInt32(ReviewPopupConditionPackId);
		}
		if (ReviewPopupConditionQuestId != 0)
		{
			output.WriteRawTag(192, 4);
			output.WriteInt32(ReviewPopupConditionQuestId);
		}
		if (RoguelikeApMax != 0)
		{
			output.WriteRawTag(200, 4);
			output.WriteInt32(RoguelikeApMax);
		}
		if (ShopBuyMaxCount != 0)
		{
			output.WriteRawTag(208, 4);
			output.WriteInt32(ShopBuyMaxCount);
		}
		if (SpeechBubbleGapTime != 0)
		{
			output.WriteRawTag(216, 4);
			output.WriteInt32(SpeechBubbleGapTime);
		}
		if (SpeechBubbleRemind != 0)
		{
			output.WriteRawTag(224, 4);
			output.WriteInt32(SpeechBubbleRemind);
		}
		if (TalentSkillMakingDevideValue != 0)
		{
			output.WriteRawTag(232, 4);
			output.WriteInt32(TalentSkillMakingDevideValue);
		}
		if (TalentSkillPinMaxCount != 0)
		{
			output.WriteRawTag(240, 4);
			output.WriteInt32(TalentSkillPinMaxCount);
		}
		if (TodayQuestLimitCount != 0)
		{
			output.WriteRawTag(248, 4);
			output.WriteInt32(TodayQuestLimitCount);
		}
		if (TodayQuestPackPostCount != 0)
		{
			output.WriteRawTag(128, 5);
			output.WriteInt32(TodayQuestPackPostCount);
		}
		if (TorchLightApMax != 0)
		{
			output.WriteRawTag(136, 5);
			output.WriteInt32(TorchLightApMax);
		}
		if (UnableInnReputation != 0)
		{
			output.WriteRawTag(144, 5);
			output.WriteInt32(UnableInnReputation);
		}
		if (UnableShopReputation != 0)
		{
			output.WriteRawTag(152, 5);
			output.WriteInt32(UnableShopReputation);
		}
		if (UnableTalentReputation != 0)
		{
			output.WriteRawTag(160, 5);
			output.WriteInt32(UnableTalentReputation);
		}
		if (UnderSixteenBillingLimit != 0)
		{
			output.WriteRawTag(168, 5);
			output.WriteInt32(UnderSixteenBillingLimit);
		}
		if (UseBossHuntingAp != 0)
		{
			output.WriteRawTag(176, 5);
			output.WriteInt32(UseBossHuntingAp);
		}
		if (UseNormalHuntingAp != 0)
		{
			output.WriteRawTag(184, 5);
			output.WriteInt32(UseNormalHuntingAp);
		}
		if (WinLikabilityPoint != 0)
		{
			output.WriteRawTag(192, 5);
			output.WriteInt32(WinLikabilityPoint);
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
		if (DefaultEquipmentUpgradeCost != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultEquipmentUpgradeCost);
		}
		if (MaxEquipmentDismentleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxEquipmentDismentleCount);
		}
		if (MaxEquipmentUpgradeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxEquipmentUpgradeCount);
		}
		if (AddEquipInvenPriceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddEquipInvenPriceCount);
		}
		if (AddEquipInvenPriceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddEquipInvenPriceType);
		}
		if (AddEquipStoragePriceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddEquipStoragePriceCount);
		}
		if (AddEquipStoragePriceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddEquipStoragePriceType);
		}
		if (AddInvenPriceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddInvenPriceCount);
		}
		if (AddInvenPriceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddInvenPriceType);
		}
		if (AddStoragePriceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddStoragePriceCount);
		}
		if (AddStoragePriceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddStoragePriceType);
		}
		if (ChargeTimePerPvpTicket != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChargeTimePerPvpTicket);
		}
		num += checkActiveOnEnterCompletePackId_.CalculateSize(_repeated_checkActiveOnEnterCompletePackId_codec);
		if (CheckActiveOnEnterCompleteTutorialId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CheckActiveOnEnterCompleteTutorialId);
		}
		if (DailyResetTime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DailyResetTime);
		}
		if (DashCooltime != 0.0)
		{
			num += 10;
		}
		if (DashCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DashCount);
		}
		if (DashSpeed != 0.0)
		{
			num += 10;
		}
		if (DashTime != 0.0)
		{
			num += 10;
		}
		if (DefaultCharGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultCharGroupId);
		}
		if (DefaultCostumeId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultCostumeId);
		}
		if (DefaultEquipInvenSlotCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultEquipInvenSlotCount);
		}
		if (DefaultEquipStorageSlotCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultEquipStorageSlotCount);
		}
		if (DefaultInvenSlotCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultInvenSlotCount);
		}
		if (DefaultStorageSlotCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultStorageSlotCount);
		}
		if (DefaultTalkCharCostumeId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultTalkCharCostumeId);
		}
		if (EquipmentPresetBaseCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EquipmentPresetBaseCount);
		}
		if (EventApMax != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EventApMax);
		}
		num += fieldQuestUsableTalentSkill_.CalculateSize(_repeated_fieldQuestUsableTalentSkill_codec);
		if (FirstLimitGachaId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FirstLimitGachaId);
		}
		if (GachaEventAddDailyPayGachaCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GachaEventAddDailyPayGachaCount);
		}
		if (GachaEventAddFreeCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GachaEventAddFreeCount);
		}
		if (GachaPointEndMailId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GachaPointEndMailId);
		}
		if (GiveRecipeMaxSkillLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GiveRecipeMaxSkillLevel);
		}
		if (GrowUpGuideAchieveLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GrowUpGuideAchieveLevel);
		}
		if (HuntDispatchLimitCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HuntDispatchLimitCount);
		}
		if (HuntingApMax != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HuntingApMax);
		}
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (InitPackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(InitPackId);
		}
		if (LinkFeedbackUrlCn.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkFeedbackUrlCn);
		}
		if (LinkFeedbackUrlEn.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkFeedbackUrlEn);
		}
		if (LinkFeedbackUrlJp.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkFeedbackUrlJp);
		}
		if (LinkFeedbackUrlKr.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkFeedbackUrlKr);
		}
		if (LinkFeedbackUrlTw.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LinkFeedbackUrlTw);
		}
		if (LoseLikabilityPoint != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LoseLikabilityPoint);
		}
		if (MailHistoryPeriodDate != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MailHistoryPeriodDate);
		}
		if (MailViewLimitCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MailViewLimitCount);
		}
		if (MaxAtkCollectionBuff != 0.0)
		{
			num += 10;
		}
		if (MaxDeckNormalTypeCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxDeckNormalTypeCount);
		}
		if (MaxDeckTempTypeCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxDeckTempTypeCount);
		}
		if (MaxEquipInvenSlotCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxEquipInvenSlotCount);
		}
		if (MaxEquipStorageSlotCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxEquipStorageSlotCount);
		}
		if (MaxFreePvpTicket != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxFreePvpTicket);
		}
		if (MaxHpCollectionBuff != 0.0)
		{
			num += 10;
		}
		if (MaxInvenCost != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxInvenCost);
		}
		if (MaxInvenSlotCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxInvenSlotCount);
		}
		if (MaxMgAtkCollectionBuff != 0.0)
		{
			num += 10;
		}
		if (MaxStorageSlotCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxStorageSlotCount);
		}
		if (MoreSixteenUnderTwentyBillingLimit != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MoreSixteenUnderTwentyBillingLimit);
		}
		if (PartnerLikabilityMax != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PartnerLikabilityMax);
		}
		if (PopularEquipConditionPvpRanking != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PopularEquipConditionPvpRanking);
		}
		if (PopularEquipValidity != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PopularEquipValidity);
		}
		if (PopupDisabledDuration != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PopupDisabledDuration);
		}
		if (PresetBaseCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PresetBaseCount);
		}
		if (PresetBuyCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PresetBuyCount);
		}
		if (PresetBuyId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PresetBuyId);
		}
		if (PresetBuyType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PresetBuyType);
		}
		if (PresetMaxCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PresetMaxCount);
		}
		if (ReturnDayCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReturnDayCount);
		}
		if (ReturnUserPeriod != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReturnUserPeriod);
		}
		if (ReviewPopupConditionPackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReviewPopupConditionPackId);
		}
		if (ReviewPopupConditionQuestId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReviewPopupConditionQuestId);
		}
		if (RoguelikeApMax != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RoguelikeApMax);
		}
		if (ShopBuyMaxCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShopBuyMaxCount);
		}
		if (SpeechBubbleGapTime != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpeechBubbleGapTime);
		}
		if (SpeechBubbleRemind != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpeechBubbleRemind);
		}
		if (TalentSkillMakingDevideValue != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TalentSkillMakingDevideValue);
		}
		if (TalentSkillPinMaxCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TalentSkillPinMaxCount);
		}
		if (TodayQuestLimitCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TodayQuestLimitCount);
		}
		if (TodayQuestPackPostCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TodayQuestPackPostCount);
		}
		if (TorchLightApMax != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TorchLightApMax);
		}
		if (UnableInnReputation != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UnableInnReputation);
		}
		if (UnableShopReputation != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UnableShopReputation);
		}
		if (UnableTalentReputation != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UnableTalentReputation);
		}
		if (UnderSixteenBillingLimit != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UnderSixteenBillingLimit);
		}
		if (UseBossHuntingAp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseBossHuntingAp);
		}
		if (UseNormalHuntingAp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseNormalHuntingAp);
		}
		if (WinLikabilityPoint != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WinLikabilityPoint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameDefaultTable other)
	{
		if (other != null)
		{
			if (other.DefaultEquipmentUpgradeCost != 0)
			{
				DefaultEquipmentUpgradeCost = other.DefaultEquipmentUpgradeCost;
			}
			if (other.MaxEquipmentDismentleCount != 0)
			{
				MaxEquipmentDismentleCount = other.MaxEquipmentDismentleCount;
			}
			if (other.MaxEquipmentUpgradeCount != 0)
			{
				MaxEquipmentUpgradeCount = other.MaxEquipmentUpgradeCount;
			}
			if (other.AddEquipInvenPriceCount != 0)
			{
				AddEquipInvenPriceCount = other.AddEquipInvenPriceCount;
			}
			if (other.AddEquipInvenPriceType != 0)
			{
				AddEquipInvenPriceType = other.AddEquipInvenPriceType;
			}
			if (other.AddEquipStoragePriceCount != 0)
			{
				AddEquipStoragePriceCount = other.AddEquipStoragePriceCount;
			}
			if (other.AddEquipStoragePriceType != 0)
			{
				AddEquipStoragePriceType = other.AddEquipStoragePriceType;
			}
			if (other.AddInvenPriceCount != 0)
			{
				AddInvenPriceCount = other.AddInvenPriceCount;
			}
			if (other.AddInvenPriceType != 0)
			{
				AddInvenPriceType = other.AddInvenPriceType;
			}
			if (other.AddStoragePriceCount != 0)
			{
				AddStoragePriceCount = other.AddStoragePriceCount;
			}
			if (other.AddStoragePriceType != 0)
			{
				AddStoragePriceType = other.AddStoragePriceType;
			}
			if (other.ChargeTimePerPvpTicket != 0)
			{
				ChargeTimePerPvpTicket = other.ChargeTimePerPvpTicket;
			}
			checkActiveOnEnterCompletePackId_.Add(other.checkActiveOnEnterCompletePackId_);
			if (other.CheckActiveOnEnterCompleteTutorialId != 0)
			{
				CheckActiveOnEnterCompleteTutorialId = other.CheckActiveOnEnterCompleteTutorialId;
			}
			if (other.DailyResetTime.Length != 0)
			{
				DailyResetTime = other.DailyResetTime;
			}
			if (other.DashCooltime != 0.0)
			{
				DashCooltime = other.DashCooltime;
			}
			if (other.DashCount != 0)
			{
				DashCount = other.DashCount;
			}
			if (other.DashSpeed != 0.0)
			{
				DashSpeed = other.DashSpeed;
			}
			if (other.DashTime != 0.0)
			{
				DashTime = other.DashTime;
			}
			if (other.DefaultCharGroupId != 0)
			{
				DefaultCharGroupId = other.DefaultCharGroupId;
			}
			if (other.DefaultCostumeId != 0)
			{
				DefaultCostumeId = other.DefaultCostumeId;
			}
			if (other.DefaultEquipInvenSlotCount != 0)
			{
				DefaultEquipInvenSlotCount = other.DefaultEquipInvenSlotCount;
			}
			if (other.DefaultEquipStorageSlotCount != 0)
			{
				DefaultEquipStorageSlotCount = other.DefaultEquipStorageSlotCount;
			}
			if (other.DefaultInvenSlotCount != 0)
			{
				DefaultInvenSlotCount = other.DefaultInvenSlotCount;
			}
			if (other.DefaultStorageSlotCount != 0)
			{
				DefaultStorageSlotCount = other.DefaultStorageSlotCount;
			}
			if (other.DefaultTalkCharCostumeId != 0)
			{
				DefaultTalkCharCostumeId = other.DefaultTalkCharCostumeId;
			}
			if (other.EquipmentPresetBaseCount != 0)
			{
				EquipmentPresetBaseCount = other.EquipmentPresetBaseCount;
			}
			if (other.EventApMax != 0)
			{
				EventApMax = other.EventApMax;
			}
			fieldQuestUsableTalentSkill_.Add(other.fieldQuestUsableTalentSkill_);
			if (other.FirstLimitGachaId != 0)
			{
				FirstLimitGachaId = other.FirstLimitGachaId;
			}
			if (other.GachaEventAddDailyPayGachaCount != 0)
			{
				GachaEventAddDailyPayGachaCount = other.GachaEventAddDailyPayGachaCount;
			}
			if (other.GachaEventAddFreeCount != 0)
			{
				GachaEventAddFreeCount = other.GachaEventAddFreeCount;
			}
			if (other.GachaPointEndMailId != 0)
			{
				GachaPointEndMailId = other.GachaPointEndMailId;
			}
			if (other.GiveRecipeMaxSkillLevel != 0)
			{
				GiveRecipeMaxSkillLevel = other.GiveRecipeMaxSkillLevel;
			}
			if (other.GrowUpGuideAchieveLevel != 0)
			{
				GrowUpGuideAchieveLevel = other.GrowUpGuideAchieveLevel;
			}
			if (other.HuntDispatchLimitCount != 0)
			{
				HuntDispatchLimitCount = other.HuntDispatchLimitCount;
			}
			if (other.HuntingApMax != 0)
			{
				HuntingApMax = other.HuntingApMax;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.InitPackId != 0)
			{
				InitPackId = other.InitPackId;
			}
			if (other.LinkFeedbackUrlCn.Length != 0)
			{
				LinkFeedbackUrlCn = other.LinkFeedbackUrlCn;
			}
			if (other.LinkFeedbackUrlEn.Length != 0)
			{
				LinkFeedbackUrlEn = other.LinkFeedbackUrlEn;
			}
			if (other.LinkFeedbackUrlJp.Length != 0)
			{
				LinkFeedbackUrlJp = other.LinkFeedbackUrlJp;
			}
			if (other.LinkFeedbackUrlKr.Length != 0)
			{
				LinkFeedbackUrlKr = other.LinkFeedbackUrlKr;
			}
			if (other.LinkFeedbackUrlTw.Length != 0)
			{
				LinkFeedbackUrlTw = other.LinkFeedbackUrlTw;
			}
			if (other.LoseLikabilityPoint != 0)
			{
				LoseLikabilityPoint = other.LoseLikabilityPoint;
			}
			if (other.MailHistoryPeriodDate != 0)
			{
				MailHistoryPeriodDate = other.MailHistoryPeriodDate;
			}
			if (other.MailViewLimitCount != 0)
			{
				MailViewLimitCount = other.MailViewLimitCount;
			}
			if (other.MaxAtkCollectionBuff != 0.0)
			{
				MaxAtkCollectionBuff = other.MaxAtkCollectionBuff;
			}
			if (other.MaxDeckNormalTypeCount != 0)
			{
				MaxDeckNormalTypeCount = other.MaxDeckNormalTypeCount;
			}
			if (other.MaxDeckTempTypeCount != 0)
			{
				MaxDeckTempTypeCount = other.MaxDeckTempTypeCount;
			}
			if (other.MaxEquipInvenSlotCount != 0)
			{
				MaxEquipInvenSlotCount = other.MaxEquipInvenSlotCount;
			}
			if (other.MaxEquipStorageSlotCount != 0)
			{
				MaxEquipStorageSlotCount = other.MaxEquipStorageSlotCount;
			}
			if (other.MaxFreePvpTicket != 0)
			{
				MaxFreePvpTicket = other.MaxFreePvpTicket;
			}
			if (other.MaxHpCollectionBuff != 0.0)
			{
				MaxHpCollectionBuff = other.MaxHpCollectionBuff;
			}
			if (other.MaxInvenCost != 0)
			{
				MaxInvenCost = other.MaxInvenCost;
			}
			if (other.MaxInvenSlotCount != 0)
			{
				MaxInvenSlotCount = other.MaxInvenSlotCount;
			}
			if (other.MaxMgAtkCollectionBuff != 0.0)
			{
				MaxMgAtkCollectionBuff = other.MaxMgAtkCollectionBuff;
			}
			if (other.MaxStorageSlotCount != 0)
			{
				MaxStorageSlotCount = other.MaxStorageSlotCount;
			}
			if (other.MoreSixteenUnderTwentyBillingLimit != 0)
			{
				MoreSixteenUnderTwentyBillingLimit = other.MoreSixteenUnderTwentyBillingLimit;
			}
			if (other.PartnerLikabilityMax != 0)
			{
				PartnerLikabilityMax = other.PartnerLikabilityMax;
			}
			if (other.PopularEquipConditionPvpRanking != 0)
			{
				PopularEquipConditionPvpRanking = other.PopularEquipConditionPvpRanking;
			}
			if (other.PopularEquipValidity != 0)
			{
				PopularEquipValidity = other.PopularEquipValidity;
			}
			if (other.PopupDisabledDuration != 0)
			{
				PopupDisabledDuration = other.PopupDisabledDuration;
			}
			if (other.PresetBaseCount != 0)
			{
				PresetBaseCount = other.PresetBaseCount;
			}
			if (other.PresetBuyCount != 0)
			{
				PresetBuyCount = other.PresetBuyCount;
			}
			if (other.PresetBuyId != 0)
			{
				PresetBuyId = other.PresetBuyId;
			}
			if (other.PresetBuyType != 0)
			{
				PresetBuyType = other.PresetBuyType;
			}
			if (other.PresetMaxCount != 0)
			{
				PresetMaxCount = other.PresetMaxCount;
			}
			if (other.ReturnDayCount != 0)
			{
				ReturnDayCount = other.ReturnDayCount;
			}
			if (other.ReturnUserPeriod != 0)
			{
				ReturnUserPeriod = other.ReturnUserPeriod;
			}
			if (other.ReviewPopupConditionPackId != 0)
			{
				ReviewPopupConditionPackId = other.ReviewPopupConditionPackId;
			}
			if (other.ReviewPopupConditionQuestId != 0)
			{
				ReviewPopupConditionQuestId = other.ReviewPopupConditionQuestId;
			}
			if (other.RoguelikeApMax != 0)
			{
				RoguelikeApMax = other.RoguelikeApMax;
			}
			if (other.ShopBuyMaxCount != 0)
			{
				ShopBuyMaxCount = other.ShopBuyMaxCount;
			}
			if (other.SpeechBubbleGapTime != 0)
			{
				SpeechBubbleGapTime = other.SpeechBubbleGapTime;
			}
			if (other.SpeechBubbleRemind != 0)
			{
				SpeechBubbleRemind = other.SpeechBubbleRemind;
			}
			if (other.TalentSkillMakingDevideValue != 0)
			{
				TalentSkillMakingDevideValue = other.TalentSkillMakingDevideValue;
			}
			if (other.TalentSkillPinMaxCount != 0)
			{
				TalentSkillPinMaxCount = other.TalentSkillPinMaxCount;
			}
			if (other.TodayQuestLimitCount != 0)
			{
				TodayQuestLimitCount = other.TodayQuestLimitCount;
			}
			if (other.TodayQuestPackPostCount != 0)
			{
				TodayQuestPackPostCount = other.TodayQuestPackPostCount;
			}
			if (other.TorchLightApMax != 0)
			{
				TorchLightApMax = other.TorchLightApMax;
			}
			if (other.UnableInnReputation != 0)
			{
				UnableInnReputation = other.UnableInnReputation;
			}
			if (other.UnableShopReputation != 0)
			{
				UnableShopReputation = other.UnableShopReputation;
			}
			if (other.UnableTalentReputation != 0)
			{
				UnableTalentReputation = other.UnableTalentReputation;
			}
			if (other.UnderSixteenBillingLimit != 0)
			{
				UnderSixteenBillingLimit = other.UnderSixteenBillingLimit;
			}
			if (other.UseBossHuntingAp != 0)
			{
				UseBossHuntingAp = other.UseBossHuntingAp;
			}
			if (other.UseNormalHuntingAp != 0)
			{
				UseNormalHuntingAp = other.UseNormalHuntingAp;
			}
			if (other.WinLikabilityPoint != 0)
			{
				WinLikabilityPoint = other.WinLikabilityPoint;
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
				DefaultEquipmentUpgradeCost = input.ReadInt32();
				break;
			case 16u:
				MaxEquipmentDismentleCount = input.ReadInt32();
				break;
			case 24u:
				MaxEquipmentUpgradeCount = input.ReadInt32();
				break;
			case 32u:
				AddEquipInvenPriceCount = input.ReadInt32();
				break;
			case 40u:
				AddEquipInvenPriceType = input.ReadInt32();
				break;
			case 48u:
				AddEquipStoragePriceCount = input.ReadInt32();
				break;
			case 56u:
				AddEquipStoragePriceType = input.ReadInt32();
				break;
			case 64u:
				AddInvenPriceCount = input.ReadInt32();
				break;
			case 72u:
				AddInvenPriceType = input.ReadInt32();
				break;
			case 80u:
				AddStoragePriceCount = input.ReadInt32();
				break;
			case 88u:
				AddStoragePriceType = input.ReadInt32();
				break;
			case 96u:
				ChargeTimePerPvpTicket = input.ReadInt32();
				break;
			case 112u:
				CheckActiveOnEnterCompleteTutorialId = input.ReadInt32();
				break;
			case 122u:
				DailyResetTime = input.ReadString();
				break;
			case 104u:
			case 106u:
				checkActiveOnEnterCompletePackId_.AddEntriesFrom(ref input, _repeated_checkActiveOnEnterCompletePackId_codec);
				break;
			case 129u:
				DashCooltime = input.ReadDouble();
				break;
			case 136u:
				DashCount = input.ReadInt32();
				break;
			case 145u:
				DashSpeed = input.ReadDouble();
				break;
			case 153u:
				DashTime = input.ReadDouble();
				break;
			case 160u:
				DefaultCharGroupId = input.ReadInt32();
				break;
			case 168u:
				DefaultCostumeId = input.ReadInt32();
				break;
			case 216u:
				EquipmentPresetBaseCount = input.ReadInt32();
				break;
			case 224u:
				EventApMax = input.ReadInt32();
				break;
			case 240u:
				FirstLimitGachaId = input.ReadInt32();
				break;
			case 248u:
				GachaEventAddDailyPayGachaCount = input.ReadInt32();
				break;
			case 232u:
			case 234u:
				fieldQuestUsableTalentSkill_.AddEntriesFrom(ref input, _repeated_fieldQuestUsableTalentSkill_codec);
				break;
			case 176u:
				DefaultEquipInvenSlotCount = input.ReadInt32();
				break;
			case 184u:
				DefaultEquipStorageSlotCount = input.ReadInt32();
				break;
			case 192u:
				DefaultInvenSlotCount = input.ReadInt32();
				break;
			case 200u:
				DefaultStorageSlotCount = input.ReadInt32();
				break;
			case 208u:
				DefaultTalkCharCostumeId = input.ReadInt32();
				break;
			case 256u:
				GachaEventAddFreeCount = input.ReadInt32();
				break;
			case 264u:
				GachaPointEndMailId = input.ReadInt32();
				break;
			case 272u:
				GiveRecipeMaxSkillLevel = input.ReadInt32();
				break;
			case 280u:
				GrowUpGuideAchieveLevel = input.ReadInt32();
				break;
			case 288u:
				HuntDispatchLimitCount = input.ReadInt32();
				break;
			case 296u:
				HuntingApMax = input.ReadInt32();
				break;
			case 304u:
				Id = input.ReadInt32();
				break;
			case 312u:
				InitPackId = input.ReadInt32();
				break;
			case 322u:
				LinkFeedbackUrlCn = input.ReadString();
				break;
			case 330u:
				LinkFeedbackUrlEn = input.ReadString();
				break;
			case 338u:
				LinkFeedbackUrlJp = input.ReadString();
				break;
			case 346u:
				LinkFeedbackUrlKr = input.ReadString();
				break;
			case 354u:
				LinkFeedbackUrlTw = input.ReadString();
				break;
			case 360u:
				LoseLikabilityPoint = input.ReadInt32();
				break;
			case 368u:
				MailHistoryPeriodDate = input.ReadInt32();
				break;
			case 376u:
				MailViewLimitCount = input.ReadInt32();
				break;
			case 385u:
				MaxAtkCollectionBuff = input.ReadDouble();
				break;
			case 392u:
				MaxDeckNormalTypeCount = input.ReadInt32();
				break;
			case 400u:
				MaxDeckTempTypeCount = input.ReadInt32();
				break;
			case 408u:
				MaxEquipInvenSlotCount = input.ReadInt32();
				break;
			case 416u:
				MaxEquipStorageSlotCount = input.ReadInt32();
				break;
			case 424u:
				MaxFreePvpTicket = input.ReadInt32();
				break;
			case 433u:
				MaxHpCollectionBuff = input.ReadDouble();
				break;
			case 440u:
				MaxInvenCost = input.ReadInt32();
				break;
			case 448u:
				MaxInvenSlotCount = input.ReadInt32();
				break;
			case 457u:
				MaxMgAtkCollectionBuff = input.ReadDouble();
				break;
			case 464u:
				MaxStorageSlotCount = input.ReadInt32();
				break;
			case 472u:
				MoreSixteenUnderTwentyBillingLimit = input.ReadInt32();
				break;
			case 480u:
				PartnerLikabilityMax = input.ReadInt32();
				break;
			case 488u:
				PopularEquipConditionPvpRanking = input.ReadInt32();
				break;
			case 496u:
				PopularEquipValidity = input.ReadInt32();
				break;
			case 504u:
				PopupDisabledDuration = input.ReadInt32();
				break;
			case 512u:
				PresetBaseCount = input.ReadInt32();
				break;
			case 520u:
				PresetBuyCount = input.ReadInt32();
				break;
			case 528u:
				PresetBuyId = input.ReadInt32();
				break;
			case 536u:
				PresetBuyType = input.ReadInt32();
				break;
			case 544u:
				PresetMaxCount = input.ReadInt32();
				break;
			case 552u:
				ReturnDayCount = input.ReadInt32();
				break;
			case 560u:
				ReturnUserPeriod = input.ReadInt32();
				break;
			case 568u:
				ReviewPopupConditionPackId = input.ReadInt32();
				break;
			case 576u:
				ReviewPopupConditionQuestId = input.ReadInt32();
				break;
			case 584u:
				RoguelikeApMax = input.ReadInt32();
				break;
			case 592u:
				ShopBuyMaxCount = input.ReadInt32();
				break;
			case 600u:
				SpeechBubbleGapTime = input.ReadInt32();
				break;
			case 608u:
				SpeechBubbleRemind = input.ReadInt32();
				break;
			case 616u:
				TalentSkillMakingDevideValue = input.ReadInt32();
				break;
			case 624u:
				TalentSkillPinMaxCount = input.ReadInt32();
				break;
			case 632u:
				TodayQuestLimitCount = input.ReadInt32();
				break;
			case 640u:
				TodayQuestPackPostCount = input.ReadInt32();
				break;
			case 648u:
				TorchLightApMax = input.ReadInt32();
				break;
			case 656u:
				UnableInnReputation = input.ReadInt32();
				break;
			case 664u:
				UnableShopReputation = input.ReadInt32();
				break;
			case 672u:
				UnableTalentReputation = input.ReadInt32();
				break;
			case 680u:
				UnderSixteenBillingLimit = input.ReadInt32();
				break;
			case 688u:
				UseBossHuntingAp = input.ReadInt32();
				break;
			case 696u:
				UseNormalHuntingAp = input.ReadInt32();
				break;
			case 704u:
				WinLikabilityPoint = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
