using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class BattleDeckTable : IMessage<BattleDeckTable>, IMessage, IEquatable<BattleDeckTable>, IDeepCloneable<BattleDeckTable>, IBufferMessage
{
	private static readonly MessageParser<BattleDeckTable> _parser = new MessageParser<BattleDeckTable>(() => new BattleDeckTable());

	private UnknownFieldSet _unknownFields;

	public const int BattleClearLocalTextIdFieldNumber = 1;

	private int battleClearLocalTextId_;

	public const int BattleFailLocalTextIdFieldNumber = 2;

	private int battleFailLocalTextId_;

	public const int BattleFieldBuffFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_battleFieldBuff_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> battleFieldBuff_ = new RepeatedField<int>();

	public const int BonusEvilCastlePointFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_bonusEvilCastlePoint_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> bonusEvilCastlePoint_ = new RepeatedField<int>();

	public const int BonusPointLocalTextIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_bonusPointLocalTextId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> bonusPointLocalTextId_ = new RepeatedField<int>();

	public const int BonusPointThumnailLocalTextIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_bonusPointThumnailLocalTextId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> bonusPointThumnailLocalTextId_ = new RepeatedField<int>();

	public const int BonusPointTypeFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_bonusPointType_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> bonusPointType_ = new RepeatedField<int>();

	public const int BonusPointValue1FieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_bonusPointValue1_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> bonusPointValue1_ = new RepeatedField<int>();

	public const int BonusPointValue2FieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_bonusPointValue2_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> bonusPointValue2_ = new RepeatedField<int>();

	public const int BonusRewardCountFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_bonusRewardCount_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> bonusRewardCount_ = new RepeatedField<int>();

	public const int BonusRewardIdFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_bonusRewardId_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> bonusRewardId_ = new RepeatedField<int>();

	public const int BonusRewardTypeFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_bonusRewardType_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> bonusRewardType_ = new RepeatedField<int>();

	public const int ChallengeTypeFieldNumber = 13;

	private int challengeType_;

	public const int CharIdFieldNumber = 14;

	private static readonly FieldCodec<int> _repeated_charId_codec = FieldCodec.ForInt32(114u);

	private readonly RepeatedField<int> charId_ = new RepeatedField<int>();

	public const int ClearTimeFieldNumber = 15;

	private int clearTime_;

	public const int ClearTypeFieldNumber = 16;

	private int clearType_;

	public const int ClearTypeValueFieldNumber = 17;

	private int clearTypeValue_;

	public const int CommonSoundIdFieldNumber = 18;

	private int commonSoundId_;

	public const int CostumeIdFieldNumber = 19;

	private static readonly FieldCodec<int> _repeated_costumeId_codec = FieldCodec.ForInt32(154u);

	private readonly RepeatedField<int> costumeId_ = new RepeatedField<int>();

	public const int CostumeId2FieldNumber = 20;

	private static readonly FieldCodec<int> _repeated_costumeId2_codec = FieldCodec.ForInt32(162u);

	private readonly RepeatedField<int> costumeId2_ = new RepeatedField<int>();

	public const int CostumeUseTypeFieldNumber = 21;

	private int costumeUseType_;

	public const int DamageRateFieldNumber = 22;

	private double damageRate_;

	public const int DeathTimeStartTurnPvEFieldNumber = 23;

	private int deathTimeStartTurnPvE_;

	public const int DifficultyIdFieldNumber = 24;

	private int difficultyId_;

	public const int ExpFieldNumber = 25;

	private int exp_;

	public const int FailWayPointIdFieldNumber = 26;

	private int failWayPointId_;

	public const int GuideTutorialGroupIdFieldNumber = 27;

	private int guideTutorialGroupId_;

	public const int HealthRateFieldNumber = 28;

	private double healthRate_;

	public const int IdFieldNumber = 29;

	private int id_;

	public const int LevelFieldNumber = 30;

	private static readonly FieldCodec<int> _repeated_level_codec = FieldCodec.ForInt32(242u);

	private readonly RepeatedField<int> level_ = new RepeatedField<int>();

	public const int MapScenePathFieldNumber = 31;

	private string mapScenePath_ = "";

	public const int PositionFieldNumber = 32;

	private static readonly FieldCodec<int> _repeated_position_codec = FieldCodec.ForInt32(258u);

	private readonly RepeatedField<int> position_ = new RepeatedField<int>();

	public const int RewardCountFieldNumber = 33;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(266u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 34;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(274u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardSupplyTypeFieldNumber = 35;

	private int rewardSupplyType_;

	public const int RewardTypeFieldNumber = 36;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(290u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int SequenceFieldNumber = 37;

	private static readonly FieldCodec<int> _repeated_sequence_codec = FieldCodec.ForInt32(298u);

	private readonly RepeatedField<int> sequence_ = new RepeatedField<int>();

	public const int SimpleTalkGroupIdFieldNumber = 38;

	private int simpleTalkGroupId_;

	public const int SolutionTipTextIdFieldNumber = 39;

	private int solutionTipTextId_;

	public const int TutorialIdFieldNumber = 40;

	private int tutorialId_;

	public const int UseBattleContinueFieldNumber = 41;

	private int useBattleContinue_;

	public const int WorldBuffOnOffFieldNumber = 42;

	private int worldBuffOnOff_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BattleDeckTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleDeckTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleClearLocalTextId
	{
		get
		{
			return battleClearLocalTextId_;
		}
		set
		{
			battleClearLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleFailLocalTextId
	{
		get
		{
			return battleFailLocalTextId_;
		}
		set
		{
			battleFailLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BattleFieldBuff => battleFieldBuff_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BonusEvilCastlePoint => bonusEvilCastlePoint_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BonusPointLocalTextId => bonusPointLocalTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BonusPointThumnailLocalTextId => bonusPointThumnailLocalTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BonusPointType => bonusPointType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BonusPointValue1 => bonusPointValue1_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BonusPointValue2 => bonusPointValue2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BonusRewardCount => bonusRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BonusRewardId => bonusRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BonusRewardType => bonusRewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChallengeType
	{
		get
		{
			return challengeType_;
		}
		set
		{
			challengeType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CharId => charId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int ClearType
	{
		get
		{
			return clearType_;
		}
		set
		{
			clearType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ClearTypeValue
	{
		get
		{
			return clearTypeValue_;
		}
		set
		{
			clearTypeValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CommonSoundId
	{
		get
		{
			return commonSoundId_;
		}
		set
		{
			commonSoundId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CostumeId => costumeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CostumeId2 => costumeId2_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeUseType
	{
		get
		{
			return costumeUseType_;
		}
		set
		{
			costumeUseType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double DamageRate
	{
		get
		{
			return damageRate_;
		}
		set
		{
			damageRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DeathTimeStartTurnPvE
	{
		get
		{
			return deathTimeStartTurnPvE_;
		}
		set
		{
			deathTimeStartTurnPvE_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DifficultyId
	{
		get
		{
			return difficultyId_;
		}
		set
		{
			difficultyId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int FailWayPointId
	{
		get
		{
			return failWayPointId_;
		}
		set
		{
			failWayPointId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuideTutorialGroupId
	{
		get
		{
			return guideTutorialGroupId_;
		}
		set
		{
			guideTutorialGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double HealthRate
	{
		get
		{
			return healthRate_;
		}
		set
		{
			healthRate_ = value;
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
	public RepeatedField<int> Level => level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MapScenePath
	{
		get
		{
			return mapScenePath_;
		}
		set
		{
			mapScenePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Position => position_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCount => rewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId => rewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardSupplyType
	{
		get
		{
			return rewardSupplyType_;
		}
		set
		{
			rewardSupplyType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardType => rewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Sequence => sequence_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SimpleTalkGroupId
	{
		get
		{
			return simpleTalkGroupId_;
		}
		set
		{
			simpleTalkGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SolutionTipTextId
	{
		get
		{
			return solutionTipTextId_;
		}
		set
		{
			solutionTipTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TutorialId
	{
		get
		{
			return tutorialId_;
		}
		set
		{
			tutorialId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UseBattleContinue
	{
		get
		{
			return useBattleContinue_;
		}
		set
		{
			useBattleContinue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WorldBuffOnOff
	{
		get
		{
			return worldBuffOnOff_;
		}
		set
		{
			worldBuffOnOff_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleDeckTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleDeckTable(BattleDeckTable other)
		: this()
	{
		battleClearLocalTextId_ = other.battleClearLocalTextId_;
		battleFailLocalTextId_ = other.battleFailLocalTextId_;
		battleFieldBuff_ = other.battleFieldBuff_.Clone();
		bonusEvilCastlePoint_ = other.bonusEvilCastlePoint_.Clone();
		bonusPointLocalTextId_ = other.bonusPointLocalTextId_.Clone();
		bonusPointThumnailLocalTextId_ = other.bonusPointThumnailLocalTextId_.Clone();
		bonusPointType_ = other.bonusPointType_.Clone();
		bonusPointValue1_ = other.bonusPointValue1_.Clone();
		bonusPointValue2_ = other.bonusPointValue2_.Clone();
		bonusRewardCount_ = other.bonusRewardCount_.Clone();
		bonusRewardId_ = other.bonusRewardId_.Clone();
		bonusRewardType_ = other.bonusRewardType_.Clone();
		challengeType_ = other.challengeType_;
		charId_ = other.charId_.Clone();
		clearTime_ = other.clearTime_;
		clearType_ = other.clearType_;
		clearTypeValue_ = other.clearTypeValue_;
		commonSoundId_ = other.commonSoundId_;
		costumeId_ = other.costumeId_.Clone();
		costumeId2_ = other.costumeId2_.Clone();
		costumeUseType_ = other.costumeUseType_;
		damageRate_ = other.damageRate_;
		deathTimeStartTurnPvE_ = other.deathTimeStartTurnPvE_;
		difficultyId_ = other.difficultyId_;
		exp_ = other.exp_;
		failWayPointId_ = other.failWayPointId_;
		guideTutorialGroupId_ = other.guideTutorialGroupId_;
		healthRate_ = other.healthRate_;
		id_ = other.id_;
		level_ = other.level_.Clone();
		mapScenePath_ = other.mapScenePath_;
		position_ = other.position_.Clone();
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardSupplyType_ = other.rewardSupplyType_;
		rewardType_ = other.rewardType_.Clone();
		sequence_ = other.sequence_.Clone();
		simpleTalkGroupId_ = other.simpleTalkGroupId_;
		solutionTipTextId_ = other.solutionTipTextId_;
		tutorialId_ = other.tutorialId_;
		useBattleContinue_ = other.useBattleContinue_;
		worldBuffOnOff_ = other.worldBuffOnOff_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleDeckTable Clone()
	{
		return new BattleDeckTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleDeckTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleDeckTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleClearLocalTextId == other.BattleClearLocalTextId && BattleFailLocalTextId == other.BattleFailLocalTextId && battleFieldBuff_.Equals(other.battleFieldBuff_) && bonusEvilCastlePoint_.Equals(other.bonusEvilCastlePoint_) && bonusPointLocalTextId_.Equals(other.bonusPointLocalTextId_) && bonusPointThumnailLocalTextId_.Equals(other.bonusPointThumnailLocalTextId_) && bonusPointType_.Equals(other.bonusPointType_) && bonusPointValue1_.Equals(other.bonusPointValue1_) && bonusPointValue2_.Equals(other.bonusPointValue2_) && bonusRewardCount_.Equals(other.bonusRewardCount_) && bonusRewardId_.Equals(other.bonusRewardId_) && bonusRewardType_.Equals(other.bonusRewardType_) && ChallengeType == other.ChallengeType && charId_.Equals(other.charId_) && ClearTime == other.ClearTime && ClearType == other.ClearType && ClearTypeValue == other.ClearTypeValue && CommonSoundId == other.CommonSoundId && costumeId_.Equals(other.costumeId_) && costumeId2_.Equals(other.costumeId2_) && CostumeUseType == other.CostumeUseType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DamageRate, other.DamageRate) && DeathTimeStartTurnPvE == other.DeathTimeStartTurnPvE && DifficultyId == other.DifficultyId && Exp == other.Exp && FailWayPointId == other.FailWayPointId && GuideTutorialGroupId == other.GuideTutorialGroupId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HealthRate, other.HealthRate) && Id == other.Id && level_.Equals(other.level_) && !(MapScenePath != other.MapScenePath) && position_.Equals(other.position_) && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && RewardSupplyType == other.RewardSupplyType && rewardType_.Equals(other.rewardType_) && sequence_.Equals(other.sequence_) && SimpleTalkGroupId == other.SimpleTalkGroupId && SolutionTipTextId == other.SolutionTipTextId && TutorialId == other.TutorialId && UseBattleContinue == other.UseBattleContinue && WorldBuffOnOff == other.WorldBuffOnOff)
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
		if (BattleClearLocalTextId != 0)
		{
			num ^= BattleClearLocalTextId.GetHashCode();
		}
		if (BattleFailLocalTextId != 0)
		{
			num ^= BattleFailLocalTextId.GetHashCode();
		}
		num ^= battleFieldBuff_.GetHashCode();
		num ^= bonusEvilCastlePoint_.GetHashCode();
		num ^= bonusPointLocalTextId_.GetHashCode();
		num ^= bonusPointThumnailLocalTextId_.GetHashCode();
		num ^= bonusPointType_.GetHashCode();
		num ^= bonusPointValue1_.GetHashCode();
		num ^= bonusPointValue2_.GetHashCode();
		num ^= bonusRewardCount_.GetHashCode();
		num ^= bonusRewardId_.GetHashCode();
		num ^= bonusRewardType_.GetHashCode();
		if (ChallengeType != 0)
		{
			num ^= ChallengeType.GetHashCode();
		}
		num ^= charId_.GetHashCode();
		if (ClearTime != 0)
		{
			num ^= ClearTime.GetHashCode();
		}
		if (ClearType != 0)
		{
			num ^= ClearType.GetHashCode();
		}
		if (ClearTypeValue != 0)
		{
			num ^= ClearTypeValue.GetHashCode();
		}
		if (CommonSoundId != 0)
		{
			num ^= CommonSoundId.GetHashCode();
		}
		num ^= costumeId_.GetHashCode();
		num ^= costumeId2_.GetHashCode();
		if (CostumeUseType != 0)
		{
			num ^= CostumeUseType.GetHashCode();
		}
		if (DamageRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DamageRate);
		}
		if (DeathTimeStartTurnPvE != 0)
		{
			num ^= DeathTimeStartTurnPvE.GetHashCode();
		}
		if (DifficultyId != 0)
		{
			num ^= DifficultyId.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (FailWayPointId != 0)
		{
			num ^= FailWayPointId.GetHashCode();
		}
		if (GuideTutorialGroupId != 0)
		{
			num ^= GuideTutorialGroupId.GetHashCode();
		}
		if (HealthRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HealthRate);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= level_.GetHashCode();
		if (MapScenePath.Length != 0)
		{
			num ^= MapScenePath.GetHashCode();
		}
		num ^= position_.GetHashCode();
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		if (RewardSupplyType != 0)
		{
			num ^= RewardSupplyType.GetHashCode();
		}
		num ^= rewardType_.GetHashCode();
		num ^= sequence_.GetHashCode();
		if (SimpleTalkGroupId != 0)
		{
			num ^= SimpleTalkGroupId.GetHashCode();
		}
		if (SolutionTipTextId != 0)
		{
			num ^= SolutionTipTextId.GetHashCode();
		}
		if (TutorialId != 0)
		{
			num ^= TutorialId.GetHashCode();
		}
		if (UseBattleContinue != 0)
		{
			num ^= UseBattleContinue.GetHashCode();
		}
		if (WorldBuffOnOff != 0)
		{
			num ^= WorldBuffOnOff.GetHashCode();
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
		if (BattleClearLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleClearLocalTextId);
		}
		if (BattleFailLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleFailLocalTextId);
		}
		battleFieldBuff_.WriteTo(ref output, _repeated_battleFieldBuff_codec);
		bonusEvilCastlePoint_.WriteTo(ref output, _repeated_bonusEvilCastlePoint_codec);
		bonusPointLocalTextId_.WriteTo(ref output, _repeated_bonusPointLocalTextId_codec);
		bonusPointThumnailLocalTextId_.WriteTo(ref output, _repeated_bonusPointThumnailLocalTextId_codec);
		bonusPointType_.WriteTo(ref output, _repeated_bonusPointType_codec);
		bonusPointValue1_.WriteTo(ref output, _repeated_bonusPointValue1_codec);
		bonusPointValue2_.WriteTo(ref output, _repeated_bonusPointValue2_codec);
		bonusRewardCount_.WriteTo(ref output, _repeated_bonusRewardCount_codec);
		bonusRewardId_.WriteTo(ref output, _repeated_bonusRewardId_codec);
		bonusRewardType_.WriteTo(ref output, _repeated_bonusRewardType_codec);
		if (ChallengeType != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(ChallengeType);
		}
		charId_.WriteTo(ref output, _repeated_charId_codec);
		if (ClearTime != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ClearTime);
		}
		if (ClearType != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(ClearType);
		}
		if (ClearTypeValue != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(ClearTypeValue);
		}
		if (CommonSoundId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(CommonSoundId);
		}
		costumeId_.WriteTo(ref output, _repeated_costumeId_codec);
		costumeId2_.WriteTo(ref output, _repeated_costumeId2_codec);
		if (CostumeUseType != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(CostumeUseType);
		}
		if (DamageRate != 0.0)
		{
			output.WriteRawTag(177, 1);
			output.WriteDouble(DamageRate);
		}
		if (DeathTimeStartTurnPvE != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(DeathTimeStartTurnPvE);
		}
		if (DifficultyId != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(DifficultyId);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(Exp);
		}
		if (FailWayPointId != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(FailWayPointId);
		}
		if (GuideTutorialGroupId != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(GuideTutorialGroupId);
		}
		if (HealthRate != 0.0)
		{
			output.WriteRawTag(225, 1);
			output.WriteDouble(HealthRate);
		}
		if (Id != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(Id);
		}
		level_.WriteTo(ref output, _repeated_level_codec);
		if (MapScenePath.Length != 0)
		{
			output.WriteRawTag(250, 1);
			output.WriteString(MapScenePath);
		}
		position_.WriteTo(ref output, _repeated_position_codec);
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		if (RewardSupplyType != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteInt32(RewardSupplyType);
		}
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		sequence_.WriteTo(ref output, _repeated_sequence_codec);
		if (SimpleTalkGroupId != 0)
		{
			output.WriteRawTag(176, 2);
			output.WriteInt32(SimpleTalkGroupId);
		}
		if (SolutionTipTextId != 0)
		{
			output.WriteRawTag(184, 2);
			output.WriteInt32(SolutionTipTextId);
		}
		if (TutorialId != 0)
		{
			output.WriteRawTag(192, 2);
			output.WriteInt32(TutorialId);
		}
		if (UseBattleContinue != 0)
		{
			output.WriteRawTag(200, 2);
			output.WriteInt32(UseBattleContinue);
		}
		if (WorldBuffOnOff != 0)
		{
			output.WriteRawTag(208, 2);
			output.WriteInt32(WorldBuffOnOff);
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
		if (BattleClearLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleClearLocalTextId);
		}
		if (BattleFailLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleFailLocalTextId);
		}
		num += battleFieldBuff_.CalculateSize(_repeated_battleFieldBuff_codec);
		num += bonusEvilCastlePoint_.CalculateSize(_repeated_bonusEvilCastlePoint_codec);
		num += bonusPointLocalTextId_.CalculateSize(_repeated_bonusPointLocalTextId_codec);
		num += bonusPointThumnailLocalTextId_.CalculateSize(_repeated_bonusPointThumnailLocalTextId_codec);
		num += bonusPointType_.CalculateSize(_repeated_bonusPointType_codec);
		num += bonusPointValue1_.CalculateSize(_repeated_bonusPointValue1_codec);
		num += bonusPointValue2_.CalculateSize(_repeated_bonusPointValue2_codec);
		num += bonusRewardCount_.CalculateSize(_repeated_bonusRewardCount_codec);
		num += bonusRewardId_.CalculateSize(_repeated_bonusRewardId_codec);
		num += bonusRewardType_.CalculateSize(_repeated_bonusRewardType_codec);
		if (ChallengeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChallengeType);
		}
		num += charId_.CalculateSize(_repeated_charId_codec);
		if (ClearTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearTime);
		}
		if (ClearType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ClearType);
		}
		if (ClearTypeValue != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ClearTypeValue);
		}
		if (CommonSoundId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CommonSoundId);
		}
		num += costumeId_.CalculateSize(_repeated_costumeId_codec);
		num += costumeId2_.CalculateSize(_repeated_costumeId2_codec);
		if (CostumeUseType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CostumeUseType);
		}
		if (DamageRate != 0.0)
		{
			num += 10;
		}
		if (DeathTimeStartTurnPvE != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DeathTimeStartTurnPvE);
		}
		if (DifficultyId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DifficultyId);
		}
		if (Exp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Exp);
		}
		if (FailWayPointId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FailWayPointId);
		}
		if (GuideTutorialGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GuideTutorialGroupId);
		}
		if (HealthRate != 0.0)
		{
			num += 10;
		}
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += level_.CalculateSize(_repeated_level_codec);
		if (MapScenePath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MapScenePath);
		}
		num += position_.CalculateSize(_repeated_position_codec);
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		if (RewardSupplyType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RewardSupplyType);
		}
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		num += sequence_.CalculateSize(_repeated_sequence_codec);
		if (SimpleTalkGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SimpleTalkGroupId);
		}
		if (SolutionTipTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SolutionTipTextId);
		}
		if (TutorialId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TutorialId);
		}
		if (UseBattleContinue != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseBattleContinue);
		}
		if (WorldBuffOnOff != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WorldBuffOnOff);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleDeckTable other)
	{
		if (other != null)
		{
			if (other.BattleClearLocalTextId != 0)
			{
				BattleClearLocalTextId = other.BattleClearLocalTextId;
			}
			if (other.BattleFailLocalTextId != 0)
			{
				BattleFailLocalTextId = other.BattleFailLocalTextId;
			}
			battleFieldBuff_.Add(other.battleFieldBuff_);
			bonusEvilCastlePoint_.Add(other.bonusEvilCastlePoint_);
			bonusPointLocalTextId_.Add(other.bonusPointLocalTextId_);
			bonusPointThumnailLocalTextId_.Add(other.bonusPointThumnailLocalTextId_);
			bonusPointType_.Add(other.bonusPointType_);
			bonusPointValue1_.Add(other.bonusPointValue1_);
			bonusPointValue2_.Add(other.bonusPointValue2_);
			bonusRewardCount_.Add(other.bonusRewardCount_);
			bonusRewardId_.Add(other.bonusRewardId_);
			bonusRewardType_.Add(other.bonusRewardType_);
			if (other.ChallengeType != 0)
			{
				ChallengeType = other.ChallengeType;
			}
			charId_.Add(other.charId_);
			if (other.ClearTime != 0)
			{
				ClearTime = other.ClearTime;
			}
			if (other.ClearType != 0)
			{
				ClearType = other.ClearType;
			}
			if (other.ClearTypeValue != 0)
			{
				ClearTypeValue = other.ClearTypeValue;
			}
			if (other.CommonSoundId != 0)
			{
				CommonSoundId = other.CommonSoundId;
			}
			costumeId_.Add(other.costumeId_);
			costumeId2_.Add(other.costumeId2_);
			if (other.CostumeUseType != 0)
			{
				CostumeUseType = other.CostumeUseType;
			}
			if (other.DamageRate != 0.0)
			{
				DamageRate = other.DamageRate;
			}
			if (other.DeathTimeStartTurnPvE != 0)
			{
				DeathTimeStartTurnPvE = other.DeathTimeStartTurnPvE;
			}
			if (other.DifficultyId != 0)
			{
				DifficultyId = other.DifficultyId;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.FailWayPointId != 0)
			{
				FailWayPointId = other.FailWayPointId;
			}
			if (other.GuideTutorialGroupId != 0)
			{
				GuideTutorialGroupId = other.GuideTutorialGroupId;
			}
			if (other.HealthRate != 0.0)
			{
				HealthRate = other.HealthRate;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			level_.Add(other.level_);
			if (other.MapScenePath.Length != 0)
			{
				MapScenePath = other.MapScenePath;
			}
			position_.Add(other.position_);
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			if (other.RewardSupplyType != 0)
			{
				RewardSupplyType = other.RewardSupplyType;
			}
			rewardType_.Add(other.rewardType_);
			sequence_.Add(other.sequence_);
			if (other.SimpleTalkGroupId != 0)
			{
				SimpleTalkGroupId = other.SimpleTalkGroupId;
			}
			if (other.SolutionTipTextId != 0)
			{
				SolutionTipTextId = other.SolutionTipTextId;
			}
			if (other.TutorialId != 0)
			{
				TutorialId = other.TutorialId;
			}
			if (other.UseBattleContinue != 0)
			{
				UseBattleContinue = other.UseBattleContinue;
			}
			if (other.WorldBuffOnOff != 0)
			{
				WorldBuffOnOff = other.WorldBuffOnOff;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			case 32u:
			case 34u:
				bonusEvilCastlePoint_.AddEntriesFrom(ref input, _repeated_bonusEvilCastlePoint_codec);
				break;
			case 8u:
				BattleClearLocalTextId = input.ReadInt32();
				break;
			case 16u:
				BattleFailLocalTextId = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				battleFieldBuff_.AddEntriesFrom(ref input, _repeated_battleFieldBuff_codec);
				break;
			case 48u:
			case 50u:
				bonusPointThumnailLocalTextId_.AddEntriesFrom(ref input, _repeated_bonusPointThumnailLocalTextId_codec);
				break;
			case 64u:
			case 66u:
				bonusPointValue1_.AddEntriesFrom(ref input, _repeated_bonusPointValue1_codec);
				break;
			case 56u:
			case 58u:
				bonusPointType_.AddEntriesFrom(ref input, _repeated_bonusPointType_codec);
				break;
			case 40u:
			case 42u:
				bonusPointLocalTextId_.AddEntriesFrom(ref input, _repeated_bonusPointLocalTextId_codec);
				break;
			case 80u:
			case 82u:
				bonusRewardCount_.AddEntriesFrom(ref input, _repeated_bonusRewardCount_codec);
				break;
			case 88u:
			case 90u:
				bonusRewardId_.AddEntriesFrom(ref input, _repeated_bonusRewardId_codec);
				break;
			case 96u:
			case 98u:
				bonusRewardType_.AddEntriesFrom(ref input, _repeated_bonusRewardType_codec);
				break;
			case 104u:
				ChallengeType = input.ReadInt32();
				break;
			case 120u:
				ClearTime = input.ReadInt32();
				break;
			case 112u:
			case 114u:
				charId_.AddEntriesFrom(ref input, _repeated_charId_codec);
				break;
			case 128u:
				ClearType = input.ReadInt32();
				break;
			case 136u:
				ClearTypeValue = input.ReadInt32();
				break;
			case 144u:
				CommonSoundId = input.ReadInt32();
				break;
			case 72u:
			case 74u:
				bonusPointValue2_.AddEntriesFrom(ref input, _repeated_bonusPointValue2_codec);
				break;
			case 256u:
			case 258u:
				position_.AddEntriesFrom(ref input, _repeated_position_codec);
				break;
			case 264u:
			case 266u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 272u:
			case 274u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 280u:
				RewardSupplyType = input.ReadInt32();
				break;
			case 304u:
				SimpleTalkGroupId = input.ReadInt32();
				break;
			case 296u:
			case 298u:
				sequence_.AddEntriesFrom(ref input, _repeated_sequence_codec);
				break;
			case 312u:
				SolutionTipTextId = input.ReadInt32();
				break;
			case 320u:
				TutorialId = input.ReadInt32();
				break;
			case 328u:
				UseBattleContinue = input.ReadInt32();
				break;
			case 336u:
				WorldBuffOnOff = input.ReadInt32();
				break;
			case 288u:
			case 290u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			case 160u:
			case 162u:
				costumeId2_.AddEntriesFrom(ref input, _repeated_costumeId2_codec);
				break;
			case 168u:
				CostumeUseType = input.ReadInt32();
				break;
			case 177u:
				DamageRate = input.ReadDouble();
				break;
			case 184u:
				DeathTimeStartTurnPvE = input.ReadInt32();
				break;
			case 192u:
				DifficultyId = input.ReadInt32();
				break;
			case 232u:
				Id = input.ReadInt32();
				break;
			case 250u:
				MapScenePath = input.ReadString();
				break;
			case 240u:
			case 242u:
				level_.AddEntriesFrom(ref input, _repeated_level_codec);
				break;
			case 200u:
				Exp = input.ReadInt32();
				break;
			case 208u:
				FailWayPointId = input.ReadInt32();
				break;
			case 216u:
				GuideTutorialGroupId = input.ReadInt32();
				break;
			case 225u:
				HealthRate = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 152u:
			case 154u:
				costumeId_.AddEntriesFrom(ref input, _repeated_costumeId_codec);
				break;
			}
		}
	}
}
