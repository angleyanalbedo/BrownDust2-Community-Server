using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleEndResponse : IMessage<BattleEndResponse>, IMessage, IEquatable<BattleEndResponse>, IDeepCloneable<BattleEndResponse>, IBufferMessage
{
	private static readonly MessageParser<BattleEndResponse> _parser = new MessageParser<BattleEndResponse>(() => new BattleEndResponse());

	private UnknownFieldSet _unknownFields;

	public const int BattleResultFieldNumber = 1;

	private int battleResult_;

	public const int UserLevelExpFieldNumber = 2;

	private int userLevelExp_;

	public const int CharInfoFieldNumber = 3;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(26u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int MonsterInfoFieldNumber = 4;

	private static readonly FieldCodec<MonsterDBInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage(34u, MonsterDBInfo.Parser);

	private readonly RepeatedField<MonsterDBInfo> monsterInfo_ = new RepeatedField<MonsterDBInfo>();

	public const int RewardBundleFieldNumber = 5;

	private RewardDBInfoBundle rewardBundle_;

	public const int BonusRewardBundleFieldNumber = 6;

	private RewardDBInfoBundle bonusRewardBundle_;

	public const int MonsterHuntRewardBundleFieldNumber = 7;

	private RewardDBInfoBundle monsterHuntRewardBundle_;

	public const int MonsterHuntDailyRewardBundleFieldNumber = 8;

	private RewardDBInfoBundle monsterHuntDailyRewardBundle_;

	public const int CharPartnerInfoFieldNumber = 9;

	private static readonly FieldCodec<CharPartnerDBInfo> _repeated_charPartnerInfo_codec = FieldCodec.ForMessage(74u, CharPartnerDBInfo.Parser);

	private readonly RepeatedField<CharPartnerDBInfo> charPartnerInfo_ = new RepeatedField<CharPartnerDBInfo>();

	public const int EvilCastleInfoFieldNumber = 10;

	private EvilCastleDBInfo evilCastleInfo_;

	public const int EvilCastleTotalInfoFieldNumber = 11;

	private EvilCastleTotalDBInfo evilCastleTotalInfo_;

	public const int EvaluationFieldNumber = 12;

	private int evaluation_;

	public const int MonsterHuntUserInfoFieldNumber = 13;

	private MonsterHuntUserDBInfo monsterHuntUserInfo_;

	public const int RankFieldNumber = 14;

	private int rank_;

	public const int EvilCastleTowerInfoFieldNumber = 15;

	private EvilCastleTowerDBInfo evilCastleTowerInfo_;

	public const int PackEventBattleInfoFieldNumber = 16;

	private PackEventBattleDBInfo packEventBattleInfo_;

	public const int EvileCastleRogueLikeStateInfoFieldNumber = 17;

	private EvilCastleRogueLikeStateInfo evileCastleRogueLikeStateInfo_;

	public const int EvileCastleRogueLikeChoiceInfoFieldNumber = 18;

	private EvilCastleRogueLikeChoiceInfo evileCastleRogueLikeChoiceInfo_;

	public const int EvileCastleRogueLikeReRollFieldNumber = 19;

	private int evileCastleRogueLikeReRoll_;

	public const int EventRewardInfoFieldNumber = 20;

	private EvilCastleRogueLikeEventReward eventRewardInfo_;

	public const int RogueLikeGoldFieldNumber = 21;

	private int rogueLikeGold_;

	public const int EvilCastleRogueLikeScoreInfoFieldNumber = 22;

	private EvilCastleRogueLikeScoreInfo evilCastleRogueLikeScoreInfo_;

	public const int ClearFloorFieldNumber = 23;

	private int clearFloor_;

	public const int ClearRoomInfoFieldNumber = 24;

	private EvilCastleRogueLikeRoomInfo clearRoomInfo_;

	public const int GuildRaidNormalBattleInfoFieldNumber = 25;

	private GuildRaidNormalBattleDBInfo guildRaidNormalBattleInfo_;

	public const int GuildRaidGolemInfoFieldNumber = 26;

	private GuildRaidBattleGolemInfo guildRaidGolemInfo_;

	public const int GuildRaidScoreInfoFieldNumber = 27;

	private GuildRaidBattleScoreInfo guildRaidScoreInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleEndResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleEndResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleResult
	{
		get
		{
			return battleResult_;
		}
		set
		{
			battleResult_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UserLevelExp
	{
		get
		{
			return userLevelExp_;
		}
		set
		{
			userLevelExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterDBInfo> MonsterInfo => monsterInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle RewardBundle
	{
		get
		{
			return rewardBundle_;
		}
		set
		{
			rewardBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle BonusRewardBundle
	{
		get
		{
			return bonusRewardBundle_;
		}
		set
		{
			bonusRewardBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle MonsterHuntRewardBundle
	{
		get
		{
			return monsterHuntRewardBundle_;
		}
		set
		{
			monsterHuntRewardBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle MonsterHuntDailyRewardBundle
	{
		get
		{
			return monsterHuntDailyRewardBundle_;
		}
		set
		{
			monsterHuntDailyRewardBundle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharPartnerDBInfo> CharPartnerInfo => charPartnerInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleDBInfo EvilCastleInfo
	{
		get
		{
			return evilCastleInfo_;
		}
		set
		{
			evilCastleInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleTotalDBInfo EvilCastleTotalInfo
	{
		get
		{
			return evilCastleTotalInfo_;
		}
		set
		{
			evilCastleTotalInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Evaluation
	{
		get
		{
			return evaluation_;
		}
		set
		{
			evaluation_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntUserDBInfo MonsterHuntUserInfo
	{
		get
		{
			return monsterHuntUserInfo_;
		}
		set
		{
			monsterHuntUserInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTowerDBInfo EvilCastleTowerInfo
	{
		get
		{
			return evilCastleTowerInfo_;
		}
		set
		{
			evilCastleTowerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventBattleDBInfo PackEventBattleInfo
	{
		get
		{
			return packEventBattleInfo_;
		}
		set
		{
			packEventBattleInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeStateInfo EvileCastleRogueLikeStateInfo
	{
		get
		{
			return evileCastleRogueLikeStateInfo_;
		}
		set
		{
			evileCastleRogueLikeStateInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeChoiceInfo EvileCastleRogueLikeChoiceInfo
	{
		get
		{
			return evileCastleRogueLikeChoiceInfo_;
		}
		set
		{
			evileCastleRogueLikeChoiceInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EvileCastleRogueLikeReRoll
	{
		get
		{
			return evileCastleRogueLikeReRoll_;
		}
		set
		{
			evileCastleRogueLikeReRoll_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeEventReward EventRewardInfo
	{
		get
		{
			return eventRewardInfo_;
		}
		set
		{
			eventRewardInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RogueLikeGold
	{
		get
		{
			return rogueLikeGold_;
		}
		set
		{
			rogueLikeGold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeScoreInfo EvilCastleRogueLikeScoreInfo
	{
		get
		{
			return evilCastleRogueLikeScoreInfo_;
		}
		set
		{
			evilCastleRogueLikeScoreInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ClearFloor
	{
		get
		{
			return clearFloor_;
		}
		set
		{
			clearFloor_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeRoomInfo ClearRoomInfo
	{
		get
		{
			return clearRoomInfo_;
		}
		set
		{
			clearRoomInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidNormalBattleDBInfo GuildRaidNormalBattleInfo
	{
		get
		{
			return guildRaidNormalBattleInfo_;
		}
		set
		{
			guildRaidNormalBattleInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidBattleGolemInfo GuildRaidGolemInfo
	{
		get
		{
			return guildRaidGolemInfo_;
		}
		set
		{
			guildRaidGolemInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidBattleScoreInfo GuildRaidScoreInfo
	{
		get
		{
			return guildRaidScoreInfo_;
		}
		set
		{
			guildRaidScoreInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEndResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEndResponse(BattleEndResponse other)
		: this()
	{
		battleResult_ = other.battleResult_;
		userLevelExp_ = other.userLevelExp_;
		charInfo_ = other.charInfo_.Clone();
		monsterInfo_ = other.monsterInfo_.Clone();
		rewardBundle_ = ((other.rewardBundle_ != null) ? other.rewardBundle_.Clone() : null);
		bonusRewardBundle_ = ((other.bonusRewardBundle_ != null) ? other.bonusRewardBundle_.Clone() : null);
		monsterHuntRewardBundle_ = ((other.monsterHuntRewardBundle_ != null) ? other.monsterHuntRewardBundle_.Clone() : null);
		monsterHuntDailyRewardBundle_ = ((other.monsterHuntDailyRewardBundle_ != null) ? other.monsterHuntDailyRewardBundle_.Clone() : null);
		charPartnerInfo_ = other.charPartnerInfo_.Clone();
		evilCastleInfo_ = ((other.evilCastleInfo_ != null) ? other.evilCastleInfo_.Clone() : null);
		evilCastleTotalInfo_ = ((other.evilCastleTotalInfo_ != null) ? other.evilCastleTotalInfo_.Clone() : null);
		evaluation_ = other.evaluation_;
		monsterHuntUserInfo_ = ((other.monsterHuntUserInfo_ != null) ? other.monsterHuntUserInfo_.Clone() : null);
		rank_ = other.rank_;
		evilCastleTowerInfo_ = ((other.evilCastleTowerInfo_ != null) ? other.evilCastleTowerInfo_.Clone() : null);
		packEventBattleInfo_ = ((other.packEventBattleInfo_ != null) ? other.packEventBattleInfo_.Clone() : null);
		evileCastleRogueLikeStateInfo_ = ((other.evileCastleRogueLikeStateInfo_ != null) ? other.evileCastleRogueLikeStateInfo_.Clone() : null);
		evileCastleRogueLikeChoiceInfo_ = ((other.evileCastleRogueLikeChoiceInfo_ != null) ? other.evileCastleRogueLikeChoiceInfo_.Clone() : null);
		evileCastleRogueLikeReRoll_ = other.evileCastleRogueLikeReRoll_;
		eventRewardInfo_ = ((other.eventRewardInfo_ != null) ? other.eventRewardInfo_.Clone() : null);
		rogueLikeGold_ = other.rogueLikeGold_;
		evilCastleRogueLikeScoreInfo_ = ((other.evilCastleRogueLikeScoreInfo_ != null) ? other.evilCastleRogueLikeScoreInfo_.Clone() : null);
		clearFloor_ = other.clearFloor_;
		clearRoomInfo_ = ((other.clearRoomInfo_ != null) ? other.clearRoomInfo_.Clone() : null);
		guildRaidNormalBattleInfo_ = ((other.guildRaidNormalBattleInfo_ != null) ? other.guildRaidNormalBattleInfo_.Clone() : null);
		guildRaidGolemInfo_ = ((other.guildRaidGolemInfo_ != null) ? other.guildRaidGolemInfo_.Clone() : null);
		guildRaidScoreInfo_ = ((other.guildRaidScoreInfo_ != null) ? other.guildRaidScoreInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleEndResponse Clone()
	{
		return new BattleEndResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as BattleEndResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleEndResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleResult == other.BattleResult && UserLevelExp == other.UserLevelExp && charInfo_.Equals(other.charInfo_) && monsterInfo_.Equals(other.monsterInfo_) && object.Equals(RewardBundle, other.RewardBundle) && object.Equals(BonusRewardBundle, other.BonusRewardBundle) && object.Equals(MonsterHuntRewardBundle, other.MonsterHuntRewardBundle) && object.Equals(MonsterHuntDailyRewardBundle, other.MonsterHuntDailyRewardBundle) && charPartnerInfo_.Equals(other.charPartnerInfo_) && object.Equals(EvilCastleInfo, other.EvilCastleInfo) && object.Equals(EvilCastleTotalInfo, other.EvilCastleTotalInfo) && Evaluation == other.Evaluation && object.Equals(MonsterHuntUserInfo, other.MonsterHuntUserInfo) && Rank == other.Rank && object.Equals(EvilCastleTowerInfo, other.EvilCastleTowerInfo) && object.Equals(PackEventBattleInfo, other.PackEventBattleInfo) && object.Equals(EvileCastleRogueLikeStateInfo, other.EvileCastleRogueLikeStateInfo) && object.Equals(EvileCastleRogueLikeChoiceInfo, other.EvileCastleRogueLikeChoiceInfo) && EvileCastleRogueLikeReRoll == other.EvileCastleRogueLikeReRoll && object.Equals(EventRewardInfo, other.EventRewardInfo) && RogueLikeGold == other.RogueLikeGold && object.Equals(EvilCastleRogueLikeScoreInfo, other.EvilCastleRogueLikeScoreInfo) && ClearFloor == other.ClearFloor && object.Equals(ClearRoomInfo, other.ClearRoomInfo) && object.Equals(GuildRaidNormalBattleInfo, other.GuildRaidNormalBattleInfo) && object.Equals(GuildRaidGolemInfo, other.GuildRaidGolemInfo) && object.Equals(GuildRaidScoreInfo, other.GuildRaidScoreInfo))
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
		if (BattleResult != 0)
		{
			num ^= BattleResult.GetHashCode();
		}
		if (UserLevelExp != 0)
		{
			num ^= UserLevelExp.GetHashCode();
		}
		num ^= charInfo_.GetHashCode();
		num ^= monsterInfo_.GetHashCode();
		if (rewardBundle_ != null)
		{
			num ^= RewardBundle.GetHashCode();
		}
		if (bonusRewardBundle_ != null)
		{
			num ^= BonusRewardBundle.GetHashCode();
		}
		if (monsterHuntRewardBundle_ != null)
		{
			num ^= MonsterHuntRewardBundle.GetHashCode();
		}
		if (monsterHuntDailyRewardBundle_ != null)
		{
			num ^= MonsterHuntDailyRewardBundle.GetHashCode();
		}
		num ^= charPartnerInfo_.GetHashCode();
		if (evilCastleInfo_ != null)
		{
			num ^= EvilCastleInfo.GetHashCode();
		}
		if (evilCastleTotalInfo_ != null)
		{
			num ^= EvilCastleTotalInfo.GetHashCode();
		}
		if (Evaluation != 0)
		{
			num ^= Evaluation.GetHashCode();
		}
		if (monsterHuntUserInfo_ != null)
		{
			num ^= MonsterHuntUserInfo.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (evilCastleTowerInfo_ != null)
		{
			num ^= EvilCastleTowerInfo.GetHashCode();
		}
		if (packEventBattleInfo_ != null)
		{
			num ^= PackEventBattleInfo.GetHashCode();
		}
		if (evileCastleRogueLikeStateInfo_ != null)
		{
			num ^= EvileCastleRogueLikeStateInfo.GetHashCode();
		}
		if (evileCastleRogueLikeChoiceInfo_ != null)
		{
			num ^= EvileCastleRogueLikeChoiceInfo.GetHashCode();
		}
		if (EvileCastleRogueLikeReRoll != 0)
		{
			num ^= EvileCastleRogueLikeReRoll.GetHashCode();
		}
		if (eventRewardInfo_ != null)
		{
			num ^= EventRewardInfo.GetHashCode();
		}
		if (RogueLikeGold != 0)
		{
			num ^= RogueLikeGold.GetHashCode();
		}
		if (evilCastleRogueLikeScoreInfo_ != null)
		{
			num ^= EvilCastleRogueLikeScoreInfo.GetHashCode();
		}
		if (ClearFloor != 0)
		{
			num ^= ClearFloor.GetHashCode();
		}
		if (clearRoomInfo_ != null)
		{
			num ^= ClearRoomInfo.GetHashCode();
		}
		if (guildRaidNormalBattleInfo_ != null)
		{
			num ^= GuildRaidNormalBattleInfo.GetHashCode();
		}
		if (guildRaidGolemInfo_ != null)
		{
			num ^= GuildRaidGolemInfo.GetHashCode();
		}
		if (guildRaidScoreInfo_ != null)
		{
			num ^= GuildRaidScoreInfo.GetHashCode();
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
		if (BattleResult != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleResult);
		}
		if (UserLevelExp != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UserLevelExp);
		}
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		monsterInfo_.WriteTo(ref output, _repeated_monsterInfo_codec);
		if (rewardBundle_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(RewardBundle);
		}
		if (bonusRewardBundle_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BonusRewardBundle);
		}
		if (monsterHuntRewardBundle_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(MonsterHuntRewardBundle);
		}
		if (monsterHuntDailyRewardBundle_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(MonsterHuntDailyRewardBundle);
		}
		charPartnerInfo_.WriteTo(ref output, _repeated_charPartnerInfo_codec);
		if (evilCastleInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(EvilCastleInfo);
		}
		if (evilCastleTotalInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(EvilCastleTotalInfo);
		}
		if (Evaluation != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Evaluation);
		}
		if (monsterHuntUserInfo_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(MonsterHuntUserInfo);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(Rank);
		}
		if (evilCastleTowerInfo_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(EvilCastleTowerInfo);
		}
		if (packEventBattleInfo_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(PackEventBattleInfo);
		}
		if (evileCastleRogueLikeStateInfo_ != null)
		{
			output.WriteRawTag(138, 1);
			output.WriteMessage(EvileCastleRogueLikeStateInfo);
		}
		if (evileCastleRogueLikeChoiceInfo_ != null)
		{
			output.WriteRawTag(146, 1);
			output.WriteMessage(EvileCastleRogueLikeChoiceInfo);
		}
		if (EvileCastleRogueLikeReRoll != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(EvileCastleRogueLikeReRoll);
		}
		if (eventRewardInfo_ != null)
		{
			output.WriteRawTag(162, 1);
			output.WriteMessage(EventRewardInfo);
		}
		if (RogueLikeGold != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(RogueLikeGold);
		}
		if (evilCastleRogueLikeScoreInfo_ != null)
		{
			output.WriteRawTag(178, 1);
			output.WriteMessage(EvilCastleRogueLikeScoreInfo);
		}
		if (ClearFloor != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(ClearFloor);
		}
		if (clearRoomInfo_ != null)
		{
			output.WriteRawTag(194, 1);
			output.WriteMessage(ClearRoomInfo);
		}
		if (guildRaidNormalBattleInfo_ != null)
		{
			output.WriteRawTag(202, 1);
			output.WriteMessage(GuildRaidNormalBattleInfo);
		}
		if (guildRaidGolemInfo_ != null)
		{
			output.WriteRawTag(210, 1);
			output.WriteMessage(GuildRaidGolemInfo);
		}
		if (guildRaidScoreInfo_ != null)
		{
			output.WriteRawTag(218, 1);
			output.WriteMessage(GuildRaidScoreInfo);
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
		if (BattleResult != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleResult);
		}
		if (UserLevelExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UserLevelExp);
		}
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += monsterInfo_.CalculateSize(_repeated_monsterInfo_codec);
		if (rewardBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardBundle);
		}
		if (bonusRewardBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BonusRewardBundle);
		}
		if (monsterHuntRewardBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntRewardBundle);
		}
		if (monsterHuntDailyRewardBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntDailyRewardBundle);
		}
		num += charPartnerInfo_.CalculateSize(_repeated_charPartnerInfo_codec);
		if (evilCastleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EvilCastleInfo);
		}
		if (evilCastleTotalInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EvilCastleTotalInfo);
		}
		if (Evaluation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Evaluation);
		}
		if (monsterHuntUserInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntUserInfo);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (evilCastleTowerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EvilCastleTowerInfo);
		}
		if (packEventBattleInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PackEventBattleInfo);
		}
		if (evileCastleRogueLikeStateInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EvileCastleRogueLikeStateInfo);
		}
		if (evileCastleRogueLikeChoiceInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EvileCastleRogueLikeChoiceInfo);
		}
		if (EvileCastleRogueLikeReRoll != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EvileCastleRogueLikeReRoll);
		}
		if (eventRewardInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EventRewardInfo);
		}
		if (RogueLikeGold != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RogueLikeGold);
		}
		if (evilCastleRogueLikeScoreInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EvilCastleRogueLikeScoreInfo);
		}
		if (ClearFloor != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ClearFloor);
		}
		if (clearRoomInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ClearRoomInfo);
		}
		if (guildRaidNormalBattleInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GuildRaidNormalBattleInfo);
		}
		if (guildRaidGolemInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GuildRaidGolemInfo);
		}
		if (guildRaidScoreInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GuildRaidScoreInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleEndResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BattleResult != 0)
		{
			BattleResult = other.BattleResult;
		}
		if (other.UserLevelExp != 0)
		{
			UserLevelExp = other.UserLevelExp;
		}
		charInfo_.Add(other.charInfo_);
		monsterInfo_.Add(other.monsterInfo_);
		if (other.rewardBundle_ != null)
		{
			if (rewardBundle_ == null)
			{
				RewardBundle = new RewardDBInfoBundle();
			}
			RewardBundle.MergeFrom(other.RewardBundle);
		}
		if (other.bonusRewardBundle_ != null)
		{
			if (bonusRewardBundle_ == null)
			{
				BonusRewardBundle = new RewardDBInfoBundle();
			}
			BonusRewardBundle.MergeFrom(other.BonusRewardBundle);
		}
		if (other.monsterHuntRewardBundle_ != null)
		{
			if (monsterHuntRewardBundle_ == null)
			{
				MonsterHuntRewardBundle = new RewardDBInfoBundle();
			}
			MonsterHuntRewardBundle.MergeFrom(other.MonsterHuntRewardBundle);
		}
		if (other.monsterHuntDailyRewardBundle_ != null)
		{
			if (monsterHuntDailyRewardBundle_ == null)
			{
				MonsterHuntDailyRewardBundle = new RewardDBInfoBundle();
			}
			MonsterHuntDailyRewardBundle.MergeFrom(other.MonsterHuntDailyRewardBundle);
		}
		charPartnerInfo_.Add(other.charPartnerInfo_);
		if (other.evilCastleInfo_ != null)
		{
			if (evilCastleInfo_ == null)
			{
				EvilCastleInfo = new EvilCastleDBInfo();
			}
			EvilCastleInfo.MergeFrom(other.EvilCastleInfo);
		}
		if (other.evilCastleTotalInfo_ != null)
		{
			if (evilCastleTotalInfo_ == null)
			{
				EvilCastleTotalInfo = new EvilCastleTotalDBInfo();
			}
			EvilCastleTotalInfo.MergeFrom(other.EvilCastleTotalInfo);
		}
		if (other.Evaluation != 0)
		{
			Evaluation = other.Evaluation;
		}
		if (other.monsterHuntUserInfo_ != null)
		{
			if (monsterHuntUserInfo_ == null)
			{
				MonsterHuntUserInfo = new MonsterHuntUserDBInfo();
			}
			MonsterHuntUserInfo.MergeFrom(other.MonsterHuntUserInfo);
		}
		if (other.Rank != 0)
		{
			Rank = other.Rank;
		}
		if (other.evilCastleTowerInfo_ != null)
		{
			if (evilCastleTowerInfo_ == null)
			{
				EvilCastleTowerInfo = new EvilCastleTowerDBInfo();
			}
			EvilCastleTowerInfo.MergeFrom(other.EvilCastleTowerInfo);
		}
		if (other.packEventBattleInfo_ != null)
		{
			if (packEventBattleInfo_ == null)
			{
				PackEventBattleInfo = new PackEventBattleDBInfo();
			}
			PackEventBattleInfo.MergeFrom(other.PackEventBattleInfo);
		}
		if (other.evileCastleRogueLikeStateInfo_ != null)
		{
			if (evileCastleRogueLikeStateInfo_ == null)
			{
				EvileCastleRogueLikeStateInfo = new EvilCastleRogueLikeStateInfo();
			}
			EvileCastleRogueLikeStateInfo.MergeFrom(other.EvileCastleRogueLikeStateInfo);
		}
		if (other.evileCastleRogueLikeChoiceInfo_ != null)
		{
			if (evileCastleRogueLikeChoiceInfo_ == null)
			{
				EvileCastleRogueLikeChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
			}
			EvileCastleRogueLikeChoiceInfo.MergeFrom(other.EvileCastleRogueLikeChoiceInfo);
		}
		if (other.EvileCastleRogueLikeReRoll != 0)
		{
			EvileCastleRogueLikeReRoll = other.EvileCastleRogueLikeReRoll;
		}
		if (other.eventRewardInfo_ != null)
		{
			if (eventRewardInfo_ == null)
			{
				EventRewardInfo = new EvilCastleRogueLikeEventReward();
			}
			EventRewardInfo.MergeFrom(other.EventRewardInfo);
		}
		if (other.RogueLikeGold != 0)
		{
			RogueLikeGold = other.RogueLikeGold;
		}
		if (other.evilCastleRogueLikeScoreInfo_ != null)
		{
			if (evilCastleRogueLikeScoreInfo_ == null)
			{
				EvilCastleRogueLikeScoreInfo = new EvilCastleRogueLikeScoreInfo();
			}
			EvilCastleRogueLikeScoreInfo.MergeFrom(other.EvilCastleRogueLikeScoreInfo);
		}
		if (other.ClearFloor != 0)
		{
			ClearFloor = other.ClearFloor;
		}
		if (other.clearRoomInfo_ != null)
		{
			if (clearRoomInfo_ == null)
			{
				ClearRoomInfo = new EvilCastleRogueLikeRoomInfo();
			}
			ClearRoomInfo.MergeFrom(other.ClearRoomInfo);
		}
		if (other.guildRaidNormalBattleInfo_ != null)
		{
			if (guildRaidNormalBattleInfo_ == null)
			{
				GuildRaidNormalBattleInfo = new GuildRaidNormalBattleDBInfo();
			}
			GuildRaidNormalBattleInfo.MergeFrom(other.GuildRaidNormalBattleInfo);
		}
		if (other.guildRaidGolemInfo_ != null)
		{
			if (guildRaidGolemInfo_ == null)
			{
				GuildRaidGolemInfo = new GuildRaidBattleGolemInfo();
			}
			GuildRaidGolemInfo.MergeFrom(other.GuildRaidGolemInfo);
		}
		if (other.guildRaidScoreInfo_ != null)
		{
			if (guildRaidScoreInfo_ == null)
			{
				GuildRaidScoreInfo = new GuildRaidBattleScoreInfo();
			}
			GuildRaidScoreInfo.MergeFrom(other.GuildRaidScoreInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
				BattleResult = input.ReadInt32();
				break;
			case 16u:
				UserLevelExp = input.ReadInt32();
				break;
			case 26u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 34u:
				monsterInfo_.AddEntriesFrom(ref input, _repeated_monsterInfo_codec);
				break;
			case 42u:
				if (rewardBundle_ == null)
				{
					RewardBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardBundle);
				break;
			case 50u:
				if (bonusRewardBundle_ == null)
				{
					BonusRewardBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(BonusRewardBundle);
				break;
			case 58u:
				if (monsterHuntRewardBundle_ == null)
				{
					MonsterHuntRewardBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(MonsterHuntRewardBundle);
				break;
			case 66u:
				if (monsterHuntDailyRewardBundle_ == null)
				{
					MonsterHuntDailyRewardBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(MonsterHuntDailyRewardBundle);
				break;
			case 74u:
				charPartnerInfo_.AddEntriesFrom(ref input, _repeated_charPartnerInfo_codec);
				break;
			case 82u:
				if (evilCastleInfo_ == null)
				{
					EvilCastleInfo = new EvilCastleDBInfo();
				}
				input.ReadMessage(EvilCastleInfo);
				break;
			case 90u:
				if (evilCastleTotalInfo_ == null)
				{
					EvilCastleTotalInfo = new EvilCastleTotalDBInfo();
				}
				input.ReadMessage(EvilCastleTotalInfo);
				break;
			case 96u:
				Evaluation = input.ReadInt32();
				break;
			case 106u:
				if (monsterHuntUserInfo_ == null)
				{
					MonsterHuntUserInfo = new MonsterHuntUserDBInfo();
				}
				input.ReadMessage(MonsterHuntUserInfo);
				break;
			case 112u:
				Rank = input.ReadInt32();
				break;
			case 122u:
				if (evilCastleTowerInfo_ == null)
				{
					EvilCastleTowerInfo = new EvilCastleTowerDBInfo();
				}
				input.ReadMessage(EvilCastleTowerInfo);
				break;
			case 130u:
				if (packEventBattleInfo_ == null)
				{
					PackEventBattleInfo = new PackEventBattleDBInfo();
				}
				input.ReadMessage(PackEventBattleInfo);
				break;
			case 138u:
				if (evileCastleRogueLikeStateInfo_ == null)
				{
					EvileCastleRogueLikeStateInfo = new EvilCastleRogueLikeStateInfo();
				}
				input.ReadMessage(EvileCastleRogueLikeStateInfo);
				break;
			case 146u:
				if (evileCastleRogueLikeChoiceInfo_ == null)
				{
					EvileCastleRogueLikeChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
				}
				input.ReadMessage(EvileCastleRogueLikeChoiceInfo);
				break;
			case 152u:
				EvileCastleRogueLikeReRoll = input.ReadInt32();
				break;
			case 162u:
				if (eventRewardInfo_ == null)
				{
					EventRewardInfo = new EvilCastleRogueLikeEventReward();
				}
				input.ReadMessage(EventRewardInfo);
				break;
			case 168u:
				RogueLikeGold = input.ReadInt32();
				break;
			case 178u:
				if (evilCastleRogueLikeScoreInfo_ == null)
				{
					EvilCastleRogueLikeScoreInfo = new EvilCastleRogueLikeScoreInfo();
				}
				input.ReadMessage(EvilCastleRogueLikeScoreInfo);
				break;
			case 184u:
				ClearFloor = input.ReadInt32();
				break;
			case 194u:
				if (clearRoomInfo_ == null)
				{
					ClearRoomInfo = new EvilCastleRogueLikeRoomInfo();
				}
				input.ReadMessage(ClearRoomInfo);
				break;
			case 202u:
				if (guildRaidNormalBattleInfo_ == null)
				{
					GuildRaidNormalBattleInfo = new GuildRaidNormalBattleDBInfo();
				}
				input.ReadMessage(GuildRaidNormalBattleInfo);
				break;
			case 210u:
				if (guildRaidGolemInfo_ == null)
				{
					GuildRaidGolemInfo = new GuildRaidBattleGolemInfo();
				}
				input.ReadMessage(GuildRaidGolemInfo);
				break;
			case 218u:
				if (guildRaidScoreInfo_ == null)
				{
					GuildRaidScoreInfo = new GuildRaidBattleScoreInfo();
				}
				input.ReadMessage(GuildRaidScoreInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
