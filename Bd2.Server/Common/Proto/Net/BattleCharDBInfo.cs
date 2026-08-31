using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleCharDBInfo : IMessage<BattleCharDBInfo>, IMessage, IEquatable<BattleCharDBInfo>, IDeepCloneable<BattleCharDBInfo>, IBufferMessage
{
	private static readonly MessageParser<BattleCharDBInfo> _parser = new MessageParser<BattleCharDBInfo>(() => new BattleCharDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIndexFieldNumber = 1;

	private int uniqueIndex_;

	public const int InvenIndexFieldNumber = 2;

	private long invenIndex_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int HpFieldNumber = 4;

	private long hp_;

	public const int LevelFieldNumber = 5;

	private int level_;

	public const int CostumeInvenIndexFieldNumber = 6;

	private long costumeInvenIndex_;

	public const int CostumeIdFieldNumber = 7;

	private int costumeId_;

	public const int CostumeLevelFieldNumber = 8;

	private int costumeLevel_;

	public const int GridIndexFieldNumber = 9;

	private int gridIndex_;

	public const int ReserveCostumeIdFieldNumber = 10;

	private int reserveCostumeId_;

	public const int IsActiveSubSkillUseFieldNumber = 11;

	private bool isActiveSubSkillUse_;

	public const int EquipIndexFieldNumber = 12;

	private static readonly FieldCodec<long> _repeated_equipIndex_codec = FieldCodec.ForInt64(98u);

	private readonly RepeatedField<long> equipIndex_ = new RepeatedField<long>();

	public const int BuffListFieldNumber = 13;

	private static readonly FieldCodec<ServerBuffList> _repeated_buffList_codec = FieldCodec.ForMessage(106u, ServerBuffList.Parser);

	private readonly RepeatedField<ServerBuffList> buffList_ = new RepeatedField<ServerBuffList>();

	public const int DodgeFieldNumber = 14;

	private static readonly FieldCodec<ServerDodge> _repeated_dodge_codec = FieldCodec.ForMessage(114u, ServerDodge.Parser);

	private readonly RepeatedField<ServerDodge> dodge_ = new RepeatedField<ServerDodge>();

	public const int RevivalFieldNumber = 15;

	private static readonly FieldCodec<ServerRevival> _repeated_revival_codec = FieldCodec.ForMessage(122u, ServerRevival.Parser);

	private readonly RepeatedField<ServerRevival> revival_ = new RepeatedField<ServerRevival>();

	public const int BarrierBuffFieldNumber = 16;

	private static readonly FieldCodec<ServerBarrierBuff> _repeated_barrierBuff_codec = FieldCodec.ForMessage(130u, ServerBarrierBuff.Parser);

	private readonly RepeatedField<ServerBarrierBuff> barrierBuff_ = new RepeatedField<ServerBarrierBuff>();

	public const int ElementBuffFieldNumber = 17;

	private static readonly FieldCodec<ServerElementBuff> _repeated_elementBuff_codec = FieldCodec.ForMessage(138u, ServerElementBuff.Parser);

	private readonly RepeatedField<ServerElementBuff> elementBuff_ = new RepeatedField<ServerElementBuff>();

	public const int EnergyGuardFieldNumber = 18;

	private static readonly FieldCodec<ServerEnergyGuard> _repeated_energyGuard_codec = FieldCodec.ForMessage(146u, ServerEnergyGuard.Parser);

	private readonly RepeatedField<ServerEnergyGuard> energyGuard_ = new RepeatedField<ServerEnergyGuard>();

	public const int WoundedAddBuffFieldNumber = 19;

	private static readonly FieldCodec<ServerWoundedAddBuff> _repeated_woundedAddBuff_codec = FieldCodec.ForMessage(154u, ServerWoundedAddBuff.Parser);

	private readonly RepeatedField<ServerWoundedAddBuff> woundedAddBuff_ = new RepeatedField<ServerWoundedAddBuff>();

	public const int VulnerableBuffFieldNumber = 20;

	private static readonly FieldCodec<ServerVulnerableBuff> _repeated_vulnerableBuff_codec = FieldCodec.ForMessage(162u, ServerVulnerableBuff.Parser);

	private readonly RepeatedField<ServerVulnerableBuff> vulnerableBuff_ = new RepeatedField<ServerVulnerableBuff>();

	public const int AuraFieldNumber = 21;

	private static readonly FieldCodec<ServerAuraBuff> _repeated_aura_codec = FieldCodec.ForMessage(170u, ServerAuraBuff.Parser);

	private readonly RepeatedField<ServerAuraBuff> aura_ = new RepeatedField<ServerAuraBuff>();

	public const int TransformationFieldNumber = 22;

	private static readonly FieldCodec<ServerTransformation> _repeated_transformation_codec = FieldCodec.ForMessage(178u, ServerTransformation.Parser);

	private readonly RepeatedField<ServerTransformation> transformation_ = new RepeatedField<ServerTransformation>();

	public const int ChainBuffFieldNumber = 23;

	private static readonly FieldCodec<ServerChainBuff> _repeated_chainBuff_codec = FieldCodec.ForMessage(186u, ServerChainBuff.Parser);

	private readonly RepeatedField<ServerChainBuff> chainBuff_ = new RepeatedField<ServerChainBuff>();

	public const int BuffPlusStatFieldNumber = 24;

	private ServerBattleCharStat buffPlusStat_;

	public const int BuffMultipleStatFieldNumber = 25;

	private ServerBattleCharStat buffMultipleStat_;

	public const int AttackDamageFieldNumber = 26;

	private long attackDamage_;

	public const int BattlePowerFieldNumber = 27;

	private int battlePower_;

	public const int TotalWarPlayTypeFieldNumber = 28;

	private int totalWarPlayType_;

	public const int ConnectPotentialCostumeFieldNumber = 29;

	private int connectPotentialCostume_;

	public const int PotentialCostumeIdFieldNumber = 30;

	private static readonly FieldCodec<int> _repeated_potentialCostumeId_codec = FieldCodec.ForInt32(242u);

	private readonly RepeatedField<int> potentialCostumeId_ = new RepeatedField<int>();

	public const int PrioritySkillCostumeInvenIndexFieldNumber = 31;

	private static readonly FieldCodec<long> _repeated_prioritySkillCostumeInvenIndex_codec = FieldCodec.ForInt64(250u);

	private readonly RepeatedField<long> prioritySkillCostumeInvenIndex_ = new RepeatedField<long>();

	public const int SkillTurnDicFieldNumber = 32;

	private static readonly MapField<int, int>.Codec _map_skillTurnDic_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8u, 0), FieldCodec.ForInt32(16u, 0), 258u);

	private readonly MapField<int, int> skillTurnDic_ = new MapField<int, int>();

	public const int TargetingCountFieldNumber = 33;

	private int targetingCount_;

	public const int ChainBonusBuffFieldNumber = 34;

	private static readonly FieldCodec<ServerChainBonusBuff> _repeated_chainBonusBuff_codec = FieldCodec.ForMessage(274u, ServerChainBonusBuff.Parser);

	private readonly RepeatedField<ServerChainBonusBuff> chainBonusBuff_ = new RepeatedField<ServerChainBonusBuff>();

	public const int ChainLimitFieldNumber = 35;

	private static readonly FieldCodec<ServerChainLimit> _repeated_chainLimit_codec = FieldCodec.ForMessage(282u, ServerChainLimit.Parser);

	private readonly RepeatedField<ServerChainLimit> chainLimit_ = new RepeatedField<ServerChainLimit>();

	public const int EnhancedDamageFieldNumber = 36;

	private static readonly FieldCodec<ServerEnhancedDamage> _repeated_enhancedDamage_codec = FieldCodec.ForMessage(290u, ServerEnhancedDamage.Parser);

	private readonly RepeatedField<ServerEnhancedDamage> enhancedDamage_ = new RepeatedField<ServerEnhancedDamage>();

	public const int ImmuneFieldNumber = 37;

	private static readonly FieldCodec<ServerImmune> _repeated_immune_codec = FieldCodec.ForMessage(298u, ServerImmune.Parser);

	private readonly RepeatedField<ServerImmune> immune_ = new RepeatedField<ServerImmune>();

	public const int SupporterOwnerIndexFieldNumber = 38;

	private long supporterOwnerIndex_;

	public const int SupporterSlotIndexFieldNumber = 39;

	private int supporterSlotIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleCharDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => BattleCharDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueIndex
	{
		get
		{
			return uniqueIndex_;
		}
		set
		{
			uniqueIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long InvenIndex
	{
		get
		{
			return invenIndex_;
		}
		set
		{
			invenIndex_ = value;
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
	public long Hp
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public long CostumeInvenIndex
	{
		get
		{
			return costumeInvenIndex_;
		}
		set
		{
			costumeInvenIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeId
	{
		get
		{
			return costumeId_;
		}
		set
		{
			costumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeLevel
	{
		get
		{
			return costumeLevel_;
		}
		set
		{
			costumeLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GridIndex
	{
		get
		{
			return gridIndex_;
		}
		set
		{
			gridIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ReserveCostumeId
	{
		get
		{
			return reserveCostumeId_;
		}
		set
		{
			reserveCostumeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsActiveSubSkillUse
	{
		get
		{
			return isActiveSubSkillUse_;
		}
		set
		{
			isActiveSubSkillUse_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> EquipIndex => equipIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ServerBuffList> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerDodge> Dodge => dodge_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerRevival> Revival => revival_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerBarrierBuff> BarrierBuff => barrierBuff_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ServerElementBuff> ElementBuff => elementBuff_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerEnergyGuard> EnergyGuard => energyGuard_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ServerWoundedAddBuff> WoundedAddBuff => woundedAddBuff_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerVulnerableBuff> VulnerableBuff => vulnerableBuff_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ServerAuraBuff> Aura => aura_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerTransformation> Transformation => transformation_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerChainBuff> ChainBuff => chainBuff_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerBattleCharStat BuffPlusStat
	{
		get
		{
			return buffPlusStat_;
		}
		set
		{
			buffPlusStat_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerBattleCharStat BuffMultipleStat
	{
		get
		{
			return buffMultipleStat_;
		}
		set
		{
			buffMultipleStat_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long AttackDamage
	{
		get
		{
			return attackDamage_;
		}
		set
		{
			attackDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattlePower
	{
		get
		{
			return battlePower_;
		}
		set
		{
			battlePower_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalWarPlayType
	{
		get
		{
			return totalWarPlayType_;
		}
		set
		{
			totalWarPlayType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ConnectPotentialCostume
	{
		get
		{
			return connectPotentialCostume_;
		}
		set
		{
			connectPotentialCostume_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PotentialCostumeId => potentialCostumeId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> PrioritySkillCostumeInvenIndex => prioritySkillCostumeInvenIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MapField<int, int> SkillTurnDic => skillTurnDic_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TargetingCount
	{
		get
		{
			return targetingCount_;
		}
		set
		{
			targetingCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerChainBonusBuff> ChainBonusBuff => chainBonusBuff_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServerChainLimit> ChainLimit => chainLimit_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ServerEnhancedDamage> EnhancedDamage => enhancedDamage_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ServerImmune> Immune => immune_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long SupporterOwnerIndex
	{
		get
		{
			return supporterOwnerIndex_;
		}
		set
		{
			supporterOwnerIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SupporterSlotIndex
	{
		get
		{
			return supporterSlotIndex_;
		}
		set
		{
			supporterSlotIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleCharDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleCharDBInfo(BattleCharDBInfo other)
		: this()
	{
		uniqueIndex_ = other.uniqueIndex_;
		invenIndex_ = other.invenIndex_;
		id_ = other.id_;
		hp_ = other.hp_;
		level_ = other.level_;
		costumeInvenIndex_ = other.costumeInvenIndex_;
		costumeId_ = other.costumeId_;
		costumeLevel_ = other.costumeLevel_;
		gridIndex_ = other.gridIndex_;
		reserveCostumeId_ = other.reserveCostumeId_;
		isActiveSubSkillUse_ = other.isActiveSubSkillUse_;
		equipIndex_ = other.equipIndex_.Clone();
		buffList_ = other.buffList_.Clone();
		dodge_ = other.dodge_.Clone();
		revival_ = other.revival_.Clone();
		barrierBuff_ = other.barrierBuff_.Clone();
		elementBuff_ = other.elementBuff_.Clone();
		energyGuard_ = other.energyGuard_.Clone();
		woundedAddBuff_ = other.woundedAddBuff_.Clone();
		vulnerableBuff_ = other.vulnerableBuff_.Clone();
		aura_ = other.aura_.Clone();
		transformation_ = other.transformation_.Clone();
		chainBuff_ = other.chainBuff_.Clone();
		buffPlusStat_ = ((other.buffPlusStat_ != null) ? other.buffPlusStat_.Clone() : null);
		buffMultipleStat_ = ((other.buffMultipleStat_ != null) ? other.buffMultipleStat_.Clone() : null);
		attackDamage_ = other.attackDamage_;
		battlePower_ = other.battlePower_;
		totalWarPlayType_ = other.totalWarPlayType_;
		connectPotentialCostume_ = other.connectPotentialCostume_;
		potentialCostumeId_ = other.potentialCostumeId_.Clone();
		prioritySkillCostumeInvenIndex_ = other.prioritySkillCostumeInvenIndex_.Clone();
		skillTurnDic_ = other.skillTurnDic_.Clone();
		targetingCount_ = other.targetingCount_;
		chainBonusBuff_ = other.chainBonusBuff_.Clone();
		chainLimit_ = other.chainLimit_.Clone();
		enhancedDamage_ = other.enhancedDamage_.Clone();
		immune_ = other.immune_.Clone();
		supporterOwnerIndex_ = other.supporterOwnerIndex_;
		supporterSlotIndex_ = other.supporterSlotIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleCharDBInfo Clone()
	{
		return new BattleCharDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleCharDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleCharDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (UniqueIndex == other.UniqueIndex && InvenIndex == other.InvenIndex && Id == other.Id && Hp == other.Hp && Level == other.Level && CostumeInvenIndex == other.CostumeInvenIndex && CostumeId == other.CostumeId && CostumeLevel == other.CostumeLevel && GridIndex == other.GridIndex && ReserveCostumeId == other.ReserveCostumeId && IsActiveSubSkillUse == other.IsActiveSubSkillUse && equipIndex_.Equals(other.equipIndex_) && buffList_.Equals(other.buffList_) && dodge_.Equals(other.dodge_) && revival_.Equals(other.revival_) && barrierBuff_.Equals(other.barrierBuff_) && elementBuff_.Equals(other.elementBuff_) && energyGuard_.Equals(other.energyGuard_) && woundedAddBuff_.Equals(other.woundedAddBuff_) && vulnerableBuff_.Equals(other.vulnerableBuff_) && aura_.Equals(other.aura_) && transformation_.Equals(other.transformation_) && chainBuff_.Equals(other.chainBuff_) && object.Equals(BuffPlusStat, other.BuffPlusStat) && object.Equals(BuffMultipleStat, other.BuffMultipleStat) && AttackDamage == other.AttackDamage && BattlePower == other.BattlePower && TotalWarPlayType == other.TotalWarPlayType && ConnectPotentialCostume == other.ConnectPotentialCostume && potentialCostumeId_.Equals(other.potentialCostumeId_) && prioritySkillCostumeInvenIndex_.Equals(other.prioritySkillCostumeInvenIndex_) && SkillTurnDic.Equals(other.SkillTurnDic) && TargetingCount == other.TargetingCount && chainBonusBuff_.Equals(other.chainBonusBuff_) && chainLimit_.Equals(other.chainLimit_) && enhancedDamage_.Equals(other.enhancedDamage_) && immune_.Equals(other.immune_) && SupporterOwnerIndex == other.SupporterOwnerIndex && SupporterSlotIndex == other.SupporterSlotIndex)
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (UniqueIndex != 0)
		{
			num ^= UniqueIndex.GetHashCode();
		}
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Hp != 0L)
		{
			num ^= Hp.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (CostumeInvenIndex != 0L)
		{
			num ^= CostumeInvenIndex.GetHashCode();
		}
		if (CostumeId != 0)
		{
			num ^= CostumeId.GetHashCode();
		}
		if (CostumeLevel != 0)
		{
			num ^= CostumeLevel.GetHashCode();
		}
		if (GridIndex != 0)
		{
			num ^= GridIndex.GetHashCode();
		}
		if (ReserveCostumeId != 0)
		{
			num ^= ReserveCostumeId.GetHashCode();
		}
		if (IsActiveSubSkillUse)
		{
			num ^= IsActiveSubSkillUse.GetHashCode();
		}
		num ^= equipIndex_.GetHashCode();
		num ^= buffList_.GetHashCode();
		num ^= dodge_.GetHashCode();
		num ^= revival_.GetHashCode();
		num ^= barrierBuff_.GetHashCode();
		num ^= elementBuff_.GetHashCode();
		num ^= energyGuard_.GetHashCode();
		num ^= woundedAddBuff_.GetHashCode();
		num ^= vulnerableBuff_.GetHashCode();
		num ^= aura_.GetHashCode();
		num ^= transformation_.GetHashCode();
		num ^= chainBuff_.GetHashCode();
		if (buffPlusStat_ != null)
		{
			num ^= BuffPlusStat.GetHashCode();
		}
		if (buffMultipleStat_ != null)
		{
			num ^= BuffMultipleStat.GetHashCode();
		}
		if (AttackDamage != 0L)
		{
			num ^= AttackDamage.GetHashCode();
		}
		if (BattlePower != 0)
		{
			num ^= BattlePower.GetHashCode();
		}
		if (TotalWarPlayType != 0)
		{
			num ^= TotalWarPlayType.GetHashCode();
		}
		if (ConnectPotentialCostume != 0)
		{
			num ^= ConnectPotentialCostume.GetHashCode();
		}
		num ^= potentialCostumeId_.GetHashCode();
		num ^= prioritySkillCostumeInvenIndex_.GetHashCode();
		num ^= SkillTurnDic.GetHashCode();
		if (TargetingCount != 0)
		{
			num ^= TargetingCount.GetHashCode();
		}
		num ^= chainBonusBuff_.GetHashCode();
		num ^= chainLimit_.GetHashCode();
		num ^= enhancedDamage_.GetHashCode();
		num ^= immune_.GetHashCode();
		if (SupporterOwnerIndex != 0L)
		{
			num ^= SupporterOwnerIndex.GetHashCode();
		}
		if (SupporterSlotIndex != 0)
		{
			num ^= SupporterSlotIndex.GetHashCode();
		}
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (UniqueIndex != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UniqueIndex);
		}
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(InvenIndex);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (Hp != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(Hp);
		}
		if (Level != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Level);
		}
		if (CostumeInvenIndex != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(CostumeInvenIndex);
		}
		if (CostumeId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CostumeId);
		}
		if (CostumeLevel != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(CostumeLevel);
		}
		if (GridIndex != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(GridIndex);
		}
		if (ReserveCostumeId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ReserveCostumeId);
		}
		if (IsActiveSubSkillUse)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsActiveSubSkillUse);
		}
		equipIndex_.WriteTo(ref output, _repeated_equipIndex_codec);
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		dodge_.WriteTo(ref output, _repeated_dodge_codec);
		revival_.WriteTo(ref output, _repeated_revival_codec);
		barrierBuff_.WriteTo(ref output, _repeated_barrierBuff_codec);
		elementBuff_.WriteTo(ref output, _repeated_elementBuff_codec);
		energyGuard_.WriteTo(ref output, _repeated_energyGuard_codec);
		woundedAddBuff_.WriteTo(ref output, _repeated_woundedAddBuff_codec);
		vulnerableBuff_.WriteTo(ref output, _repeated_vulnerableBuff_codec);
		aura_.WriteTo(ref output, _repeated_aura_codec);
		transformation_.WriteTo(ref output, _repeated_transformation_codec);
		chainBuff_.WriteTo(ref output, _repeated_chainBuff_codec);
		if (buffPlusStat_ != null)
		{
			output.WriteRawTag(194, 1);
			output.WriteMessage(BuffPlusStat);
		}
		if (buffMultipleStat_ != null)
		{
			output.WriteRawTag(202, 1);
			output.WriteMessage(BuffMultipleStat);
		}
		if (AttackDamage != 0L)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt64(AttackDamage);
		}
		if (BattlePower != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(BattlePower);
		}
		if (TotalWarPlayType != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(TotalWarPlayType);
		}
		if (ConnectPotentialCostume != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(ConnectPotentialCostume);
		}
		potentialCostumeId_.WriteTo(ref output, _repeated_potentialCostumeId_codec);
		prioritySkillCostumeInvenIndex_.WriteTo(ref output, _repeated_prioritySkillCostumeInvenIndex_codec);
		skillTurnDic_.WriteTo(ref output, _map_skillTurnDic_codec);
		if (TargetingCount != 0)
		{
			output.WriteRawTag(136, 2);
			output.WriteInt32(TargetingCount);
		}
		chainBonusBuff_.WriteTo(ref output, _repeated_chainBonusBuff_codec);
		chainLimit_.WriteTo(ref output, _repeated_chainLimit_codec);
		enhancedDamage_.WriteTo(ref output, _repeated_enhancedDamage_codec);
		immune_.WriteTo(ref output, _repeated_immune_codec);
		if (SupporterOwnerIndex != 0L)
		{
			output.WriteRawTag(176, 2);
			output.WriteInt64(SupporterOwnerIndex);
		}
		if (SupporterSlotIndex != 0)
		{
			output.WriteRawTag(184, 2);
			output.WriteInt32(SupporterSlotIndex);
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
		if (UniqueIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueIndex);
		}
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Hp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Hp);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (CostumeInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CostumeInvenIndex);
		}
		if (CostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeId);
		}
		if (CostumeLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeLevel);
		}
		if (GridIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GridIndex);
		}
		if (ReserveCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReserveCostumeId);
		}
		if (IsActiveSubSkillUse)
		{
			num += 2;
		}
		num += equipIndex_.CalculateSize(_repeated_equipIndex_codec);
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		num += dodge_.CalculateSize(_repeated_dodge_codec);
		num += revival_.CalculateSize(_repeated_revival_codec);
		num += barrierBuff_.CalculateSize(_repeated_barrierBuff_codec);
		num += elementBuff_.CalculateSize(_repeated_elementBuff_codec);
		num += energyGuard_.CalculateSize(_repeated_energyGuard_codec);
		num += woundedAddBuff_.CalculateSize(_repeated_woundedAddBuff_codec);
		num += vulnerableBuff_.CalculateSize(_repeated_vulnerableBuff_codec);
		num += aura_.CalculateSize(_repeated_aura_codec);
		num += transformation_.CalculateSize(_repeated_transformation_codec);
		num += chainBuff_.CalculateSize(_repeated_chainBuff_codec);
		if (buffPlusStat_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BuffPlusStat);
		}
		if (buffMultipleStat_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BuffMultipleStat);
		}
		if (AttackDamage != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(AttackDamage);
		}
		if (BattlePower != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BattlePower);
		}
		if (TotalWarPlayType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TotalWarPlayType);
		}
		if (ConnectPotentialCostume != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ConnectPotentialCostume);
		}
		num += potentialCostumeId_.CalculateSize(_repeated_potentialCostumeId_codec);
		num += prioritySkillCostumeInvenIndex_.CalculateSize(_repeated_prioritySkillCostumeInvenIndex_codec);
		num += skillTurnDic_.CalculateSize(_map_skillTurnDic_codec);
		if (TargetingCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TargetingCount);
		}
		num += chainBonusBuff_.CalculateSize(_repeated_chainBonusBuff_codec);
		num += chainLimit_.CalculateSize(_repeated_chainLimit_codec);
		num += enhancedDamage_.CalculateSize(_repeated_enhancedDamage_codec);
		num += immune_.CalculateSize(_repeated_immune_codec);
		if (SupporterOwnerIndex != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(SupporterOwnerIndex);
		}
		if (SupporterSlotIndex != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SupporterSlotIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleCharDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueIndex != 0)
		{
			UniqueIndex = other.UniqueIndex;
		}
		if (other.InvenIndex != 0L)
		{
			InvenIndex = other.InvenIndex;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Hp != 0L)
		{
			Hp = other.Hp;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.CostumeInvenIndex != 0L)
		{
			CostumeInvenIndex = other.CostumeInvenIndex;
		}
		if (other.CostumeId != 0)
		{
			CostumeId = other.CostumeId;
		}
		if (other.CostumeLevel != 0)
		{
			CostumeLevel = other.CostumeLevel;
		}
		if (other.GridIndex != 0)
		{
			GridIndex = other.GridIndex;
		}
		if (other.ReserveCostumeId != 0)
		{
			ReserveCostumeId = other.ReserveCostumeId;
		}
		if (other.IsActiveSubSkillUse)
		{
			IsActiveSubSkillUse = other.IsActiveSubSkillUse;
		}
		equipIndex_.Add(other.equipIndex_);
		buffList_.Add(other.buffList_);
		dodge_.Add(other.dodge_);
		revival_.Add(other.revival_);
		barrierBuff_.Add(other.barrierBuff_);
		elementBuff_.Add(other.elementBuff_);
		energyGuard_.Add(other.energyGuard_);
		woundedAddBuff_.Add(other.woundedAddBuff_);
		vulnerableBuff_.Add(other.vulnerableBuff_);
		aura_.Add(other.aura_);
		transformation_.Add(other.transformation_);
		chainBuff_.Add(other.chainBuff_);
		if (other.buffPlusStat_ != null)
		{
			if (buffPlusStat_ == null)
			{
				BuffPlusStat = new ServerBattleCharStat();
			}
			BuffPlusStat.MergeFrom(other.BuffPlusStat);
		}
		if (other.buffMultipleStat_ != null)
		{
			if (buffMultipleStat_ == null)
			{
				BuffMultipleStat = new ServerBattleCharStat();
			}
			BuffMultipleStat.MergeFrom(other.BuffMultipleStat);
		}
		if (other.AttackDamage != 0L)
		{
			AttackDamage = other.AttackDamage;
		}
		if (other.BattlePower != 0)
		{
			BattlePower = other.BattlePower;
		}
		if (other.TotalWarPlayType != 0)
		{
			TotalWarPlayType = other.TotalWarPlayType;
		}
		if (other.ConnectPotentialCostume != 0)
		{
			ConnectPotentialCostume = other.ConnectPotentialCostume;
		}
		potentialCostumeId_.Add(other.potentialCostumeId_);
		prioritySkillCostumeInvenIndex_.Add(other.prioritySkillCostumeInvenIndex_);
		skillTurnDic_.Add(other.skillTurnDic_);
		if (other.TargetingCount != 0)
		{
			TargetingCount = other.TargetingCount;
		}
		chainBonusBuff_.Add(other.chainBonusBuff_);
		chainLimit_.Add(other.chainLimit_);
		enhancedDamage_.Add(other.enhancedDamage_);
		immune_.Add(other.immune_);
		if (other.SupporterOwnerIndex != 0L)
		{
			SupporterOwnerIndex = other.SupporterOwnerIndex;
		}
		if (other.SupporterSlotIndex != 0)
		{
			SupporterSlotIndex = other.SupporterSlotIndex;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 170u:
				aura_.AddEntriesFrom(ref input, _repeated_aura_codec);
				break;
			case 178u:
				transformation_.AddEntriesFrom(ref input, _repeated_transformation_codec);
				break;
			case 186u:
				chainBuff_.AddEntriesFrom(ref input, _repeated_chainBuff_codec);
				break;
			case 194u:
				if (buffPlusStat_ == null)
				{
					BuffPlusStat = new ServerBattleCharStat();
				}
				input.ReadMessage(BuffPlusStat);
				break;
			case 202u:
				if (buffMultipleStat_ == null)
				{
					BuffMultipleStat = new ServerBattleCharStat();
				}
				input.ReadMessage(BuffMultipleStat);
				break;
			case 208u:
				AttackDamage = input.ReadInt64();
				break;
			case 216u:
				BattlePower = input.ReadInt32();
				break;
			case 224u:
				TotalWarPlayType = input.ReadInt32();
				break;
			case 232u:
				ConnectPotentialCostume = input.ReadInt32();
				break;
			case 258u:
				skillTurnDic_.AddEntriesFrom(ref input, _map_skillTurnDic_codec);
				break;
			case 264u:
				TargetingCount = input.ReadInt32();
				break;
			case 248u:
			case 250u:
				prioritySkillCostumeInvenIndex_.AddEntriesFrom(ref input, _repeated_prioritySkillCostumeInvenIndex_codec);
				break;
			case 274u:
				chainBonusBuff_.AddEntriesFrom(ref input, _repeated_chainBonusBuff_codec);
				break;
			case 282u:
				chainLimit_.AddEntriesFrom(ref input, _repeated_chainLimit_codec);
				break;
			case 290u:
				enhancedDamage_.AddEntriesFrom(ref input, _repeated_enhancedDamage_codec);
				break;
			case 298u:
				immune_.AddEntriesFrom(ref input, _repeated_immune_codec);
				break;
			case 304u:
				SupporterOwnerIndex = input.ReadInt64();
				break;
			case 312u:
				SupporterSlotIndex = input.ReadInt32();
				break;
			case 240u:
			case 242u:
				potentialCostumeId_.AddEntriesFrom(ref input, _repeated_potentialCostumeId_codec);
				break;
			case 8u:
				UniqueIndex = input.ReadInt32();
				break;
			case 16u:
				InvenIndex = input.ReadInt64();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				Hp = input.ReadInt64();
				break;
			case 40u:
				Level = input.ReadInt32();
				break;
			case 48u:
				CostumeInvenIndex = input.ReadInt64();
				break;
			case 56u:
				CostumeId = input.ReadInt32();
				break;
			case 64u:
				CostumeLevel = input.ReadInt32();
				break;
			case 72u:
				GridIndex = input.ReadInt32();
				break;
			case 80u:
				ReserveCostumeId = input.ReadInt32();
				break;
			case 88u:
				IsActiveSubSkillUse = input.ReadBool();
				break;
			case 106u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 114u:
				dodge_.AddEntriesFrom(ref input, _repeated_dodge_codec);
				break;
			case 96u:
			case 98u:
				equipIndex_.AddEntriesFrom(ref input, _repeated_equipIndex_codec);
				break;
			case 122u:
				revival_.AddEntriesFrom(ref input, _repeated_revival_codec);
				break;
			case 130u:
				barrierBuff_.AddEntriesFrom(ref input, _repeated_barrierBuff_codec);
				break;
			case 138u:
				elementBuff_.AddEntriesFrom(ref input, _repeated_elementBuff_codec);
				break;
			case 146u:
				energyGuard_.AddEntriesFrom(ref input, _repeated_energyGuard_codec);
				break;
			case 154u:
				woundedAddBuff_.AddEntriesFrom(ref input, _repeated_woundedAddBuff_codec);
				break;
			case 162u:
				vulnerableBuff_.AddEntriesFrom(ref input, _repeated_vulnerableBuff_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
