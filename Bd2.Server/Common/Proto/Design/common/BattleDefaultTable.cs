using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class BattleDefaultTable : IMessage<BattleDefaultTable>, IMessage, IEquatable<BattleDefaultTable>, IDeepCloneable<BattleDefaultTable>, IBufferMessage
{
	private static readonly MessageParser<BattleDefaultTable> _parser = new MessageParser<BattleDefaultTable>(() => new BattleDefaultTable());

	private UnknownFieldSet _unknownFields;

	public const int AtkMaxFieldNumber = 1;

	private int atkMax_;

	public const int AtkMinFieldNumber = 2;

	private int atkMin_;

	public const int CriDMaxFieldNumber = 3;

	private double criDMax_;

	public const int CriDMinFieldNumber = 4;

	private double criDMin_;

	public const int CriMaxFieldNumber = 5;

	private double criMax_;

	public const int CriMinFieldNumber = 6;

	private double criMin_;

	public const int DefMaxFieldNumber = 7;

	private double defMax_;

	public const int DefMinFieldNumber = 8;

	private double defMin_;

	public const int FieldObjectBattleRearrangeEffectTimeFieldNumber = 9;

	private int fieldObjectBattleRearrangeEffectTime_;

	public const int FieldObjectBattleRearrangeTimeFieldNumber = 10;

	private int fieldObjectBattleRearrangeTime_;

	public const int HpMaxLimitFieldNumber = 11;

	private int hpMaxLimit_;

	public const int BattleContinueCostItemCountFieldNumber = 12;

	private int battleContinueCostItemCount_;

	public const int BattleContinueCostItemIdFieldNumber = 13;

	private int battleContinueCostItemId_;

	public const int BattleContinueCostItemTypeFieldNumber = 14;

	private int battleContinueCostItemType_;

	public const int BattleContinueMaxCountFieldNumber = 15;

	private int battleContinueMaxCount_;

	public const int BattlePowerConstFieldNumber = 16;

	private int battlePowerConst_;

	public const int ChainDamageValueFieldNumber = 17;

	private double chainDamageValue_;

	public const int ChainMaxCountFieldNumber = 18;

	private int chainMaxCount_;

	public const int DeathTimeBuffIdFieldNumber = 19;

	private int deathTimeBuffId_;

	public const int DeathTimeStartTurnPvPFieldNumber = 20;

	private int deathTimeStartTurnPvP_;

	public const int FrontMoveSecFieldNumber = 21;

	private double frontMoveSec_;

	public const int IdFieldNumber = 22;

	private int id_;

	public const int MinAttackDamageFieldNumber = 23;

	private int minAttackDamage_;

	public const int SideMoveSecFieldNumber = 24;

	private double sideMoveSec_;

	public const int SpMaxCountFieldNumber = 25;

	private int spMaxCount_;

	public const int SpStartHunterCountFieldNumber = 26;

	private int spStartHunterCount_;

	public const int SpStartPvECountFieldNumber = 27;

	private int spStartPvECount_;

	public const int SpStartPvPBLUECountFieldNumber = 28;

	private int spStartPvPBLUECount_;

	public const int SpStartPvPREDCountFieldNumber = 29;

	private int spStartPvPREDCount_;

	public const int SpTurnAddHunterCountFieldNumber = 30;

	private int spTurnAddHunterCount_;

	public const int SpTurnAddPvECountFieldNumber = 31;

	private int spTurnAddPvECount_;

	public const int SpTurnAddPvPCountFieldNumber = 32;

	private int spTurnAddPvPCount_;

	public const int StrongElementEffectFieldNumber = 33;

	private double strongElementEffect_;

	public const int TurnPassSecFieldNumber = 34;

	private double turnPassSec_;

	public const int WeakElementEffectFieldNumber = 35;

	private double weakElementEffect_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleDefaultTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => BattleDefaultTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AtkMax
	{
		get
		{
			return atkMax_;
		}
		set
		{
			atkMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AtkMin
	{
		get
		{
			return atkMin_;
		}
		set
		{
			atkMin_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double CriDMax
	{
		get
		{
			return criDMax_;
		}
		set
		{
			criDMax_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double CriDMin
	{
		get
		{
			return criDMin_;
		}
		set
		{
			criDMin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double CriMax
	{
		get
		{
			return criMax_;
		}
		set
		{
			criMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double CriMin
	{
		get
		{
			return criMin_;
		}
		set
		{
			criMin_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double DefMax
	{
		get
		{
			return defMax_;
		}
		set
		{
			defMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DefMin
	{
		get
		{
			return defMin_;
		}
		set
		{
			defMin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FieldObjectBattleRearrangeEffectTime
	{
		get
		{
			return fieldObjectBattleRearrangeEffectTime_;
		}
		set
		{
			fieldObjectBattleRearrangeEffectTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FieldObjectBattleRearrangeTime
	{
		get
		{
			return fieldObjectBattleRearrangeTime_;
		}
		set
		{
			fieldObjectBattleRearrangeTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HpMaxLimit
	{
		get
		{
			return hpMaxLimit_;
		}
		set
		{
			hpMaxLimit_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleContinueCostItemCount
	{
		get
		{
			return battleContinueCostItemCount_;
		}
		set
		{
			battleContinueCostItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleContinueCostItemId
	{
		get
		{
			return battleContinueCostItemId_;
		}
		set
		{
			battleContinueCostItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleContinueCostItemType
	{
		get
		{
			return battleContinueCostItemType_;
		}
		set
		{
			battleContinueCostItemType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleContinueMaxCount
	{
		get
		{
			return battleContinueMaxCount_;
		}
		set
		{
			battleContinueMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattlePowerConst
	{
		get
		{
			return battlePowerConst_;
		}
		set
		{
			battlePowerConst_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double ChainDamageValue
	{
		get
		{
			return chainDamageValue_;
		}
		set
		{
			chainDamageValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChainMaxCount
	{
		get
		{
			return chainMaxCount_;
		}
		set
		{
			chainMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DeathTimeBuffId
	{
		get
		{
			return deathTimeBuffId_;
		}
		set
		{
			deathTimeBuffId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DeathTimeStartTurnPvP
	{
		get
		{
			return deathTimeStartTurnPvP_;
		}
		set
		{
			deathTimeStartTurnPvP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double FrontMoveSec
	{
		get
		{
			return frontMoveSec_;
		}
		set
		{
			frontMoveSec_ = value;
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
	public int MinAttackDamage
	{
		get
		{
			return minAttackDamage_;
		}
		set
		{
			minAttackDamage_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double SideMoveSec
	{
		get
		{
			return sideMoveSec_;
		}
		set
		{
			sideMoveSec_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpMaxCount
	{
		get
		{
			return spMaxCount_;
		}
		set
		{
			spMaxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpStartHunterCount
	{
		get
		{
			return spStartHunterCount_;
		}
		set
		{
			spStartHunterCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpStartPvECount
	{
		get
		{
			return spStartPvECount_;
		}
		set
		{
			spStartPvECount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpStartPvPBLUECount
	{
		get
		{
			return spStartPvPBLUECount_;
		}
		set
		{
			spStartPvPBLUECount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpStartPvPREDCount
	{
		get
		{
			return spStartPvPREDCount_;
		}
		set
		{
			spStartPvPREDCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpTurnAddHunterCount
	{
		get
		{
			return spTurnAddHunterCount_;
		}
		set
		{
			spTurnAddHunterCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpTurnAddPvECount
	{
		get
		{
			return spTurnAddPvECount_;
		}
		set
		{
			spTurnAddPvECount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpTurnAddPvPCount
	{
		get
		{
			return spTurnAddPvPCount_;
		}
		set
		{
			spTurnAddPvPCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double StrongElementEffect
	{
		get
		{
			return strongElementEffect_;
		}
		set
		{
			strongElementEffect_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double TurnPassSec
	{
		get
		{
			return turnPassSec_;
		}
		set
		{
			turnPassSec_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double WeakElementEffect
	{
		get
		{
			return weakElementEffect_;
		}
		set
		{
			weakElementEffect_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleDefaultTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleDefaultTable(BattleDefaultTable other)
		: this()
	{
		atkMax_ = other.atkMax_;
		atkMin_ = other.atkMin_;
		criDMax_ = other.criDMax_;
		criDMin_ = other.criDMin_;
		criMax_ = other.criMax_;
		criMin_ = other.criMin_;
		defMax_ = other.defMax_;
		defMin_ = other.defMin_;
		fieldObjectBattleRearrangeEffectTime_ = other.fieldObjectBattleRearrangeEffectTime_;
		fieldObjectBattleRearrangeTime_ = other.fieldObjectBattleRearrangeTime_;
		hpMaxLimit_ = other.hpMaxLimit_;
		battleContinueCostItemCount_ = other.battleContinueCostItemCount_;
		battleContinueCostItemId_ = other.battleContinueCostItemId_;
		battleContinueCostItemType_ = other.battleContinueCostItemType_;
		battleContinueMaxCount_ = other.battleContinueMaxCount_;
		battlePowerConst_ = other.battlePowerConst_;
		chainDamageValue_ = other.chainDamageValue_;
		chainMaxCount_ = other.chainMaxCount_;
		deathTimeBuffId_ = other.deathTimeBuffId_;
		deathTimeStartTurnPvP_ = other.deathTimeStartTurnPvP_;
		frontMoveSec_ = other.frontMoveSec_;
		id_ = other.id_;
		minAttackDamage_ = other.minAttackDamage_;
		sideMoveSec_ = other.sideMoveSec_;
		spMaxCount_ = other.spMaxCount_;
		spStartHunterCount_ = other.spStartHunterCount_;
		spStartPvECount_ = other.spStartPvECount_;
		spStartPvPBLUECount_ = other.spStartPvPBLUECount_;
		spStartPvPREDCount_ = other.spStartPvPREDCount_;
		spTurnAddHunterCount_ = other.spTurnAddHunterCount_;
		spTurnAddPvECount_ = other.spTurnAddPvECount_;
		spTurnAddPvPCount_ = other.spTurnAddPvPCount_;
		strongElementEffect_ = other.strongElementEffect_;
		turnPassSec_ = other.turnPassSec_;
		weakElementEffect_ = other.weakElementEffect_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleDefaultTable Clone()
	{
		return new BattleDefaultTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleDefaultTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleDefaultTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AtkMax == other.AtkMax && AtkMin == other.AtkMin && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriDMax, other.CriDMax) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriDMin, other.CriDMin) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriMax, other.CriMax) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CriMin, other.CriMin) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DefMax, other.DefMax) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DefMin, other.DefMin) && FieldObjectBattleRearrangeEffectTime == other.FieldObjectBattleRearrangeEffectTime && FieldObjectBattleRearrangeTime == other.FieldObjectBattleRearrangeTime && HpMaxLimit == other.HpMaxLimit && BattleContinueCostItemCount == other.BattleContinueCostItemCount && BattleContinueCostItemId == other.BattleContinueCostItemId && BattleContinueCostItemType == other.BattleContinueCostItemType && BattleContinueMaxCount == other.BattleContinueMaxCount && BattlePowerConst == other.BattlePowerConst && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ChainDamageValue, other.ChainDamageValue) && ChainMaxCount == other.ChainMaxCount && DeathTimeBuffId == other.DeathTimeBuffId && DeathTimeStartTurnPvP == other.DeathTimeStartTurnPvP && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FrontMoveSec, other.FrontMoveSec) && Id == other.Id && MinAttackDamage == other.MinAttackDamage && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SideMoveSec, other.SideMoveSec) && SpMaxCount == other.SpMaxCount && SpStartHunterCount == other.SpStartHunterCount && SpStartPvECount == other.SpStartPvECount && SpStartPvPBLUECount == other.SpStartPvPBLUECount && SpStartPvPREDCount == other.SpStartPvPREDCount && SpTurnAddHunterCount == other.SpTurnAddHunterCount && SpTurnAddPvECount == other.SpTurnAddPvECount && SpTurnAddPvPCount == other.SpTurnAddPvPCount && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(StrongElementEffect, other.StrongElementEffect) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TurnPassSec, other.TurnPassSec) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(WeakElementEffect, other.WeakElementEffect))
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
		if (AtkMax != 0)
		{
			num ^= AtkMax.GetHashCode();
		}
		if (AtkMin != 0)
		{
			num ^= AtkMin.GetHashCode();
		}
		if (CriDMax != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriDMax);
		}
		if (CriDMin != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriDMin);
		}
		if (CriMax != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriMax);
		}
		if (CriMin != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CriMin);
		}
		if (DefMax != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DefMax);
		}
		if (DefMin != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DefMin);
		}
		if (FieldObjectBattleRearrangeEffectTime != 0)
		{
			num ^= FieldObjectBattleRearrangeEffectTime.GetHashCode();
		}
		if (FieldObjectBattleRearrangeTime != 0)
		{
			num ^= FieldObjectBattleRearrangeTime.GetHashCode();
		}
		if (HpMaxLimit != 0)
		{
			num ^= HpMaxLimit.GetHashCode();
		}
		if (BattleContinueCostItemCount != 0)
		{
			num ^= BattleContinueCostItemCount.GetHashCode();
		}
		if (BattleContinueCostItemId != 0)
		{
			num ^= BattleContinueCostItemId.GetHashCode();
		}
		if (BattleContinueCostItemType != 0)
		{
			num ^= BattleContinueCostItemType.GetHashCode();
		}
		if (BattleContinueMaxCount != 0)
		{
			num ^= BattleContinueMaxCount.GetHashCode();
		}
		if (BattlePowerConst != 0)
		{
			num ^= BattlePowerConst.GetHashCode();
		}
		if (ChainDamageValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ChainDamageValue);
		}
		if (ChainMaxCount != 0)
		{
			num ^= ChainMaxCount.GetHashCode();
		}
		if (DeathTimeBuffId != 0)
		{
			num ^= DeathTimeBuffId.GetHashCode();
		}
		if (DeathTimeStartTurnPvP != 0)
		{
			num ^= DeathTimeStartTurnPvP.GetHashCode();
		}
		if (FrontMoveSec != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FrontMoveSec);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MinAttackDamage != 0)
		{
			num ^= MinAttackDamage.GetHashCode();
		}
		if (SideMoveSec != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SideMoveSec);
		}
		if (SpMaxCount != 0)
		{
			num ^= SpMaxCount.GetHashCode();
		}
		if (SpStartHunterCount != 0)
		{
			num ^= SpStartHunterCount.GetHashCode();
		}
		if (SpStartPvECount != 0)
		{
			num ^= SpStartPvECount.GetHashCode();
		}
		if (SpStartPvPBLUECount != 0)
		{
			num ^= SpStartPvPBLUECount.GetHashCode();
		}
		if (SpStartPvPREDCount != 0)
		{
			num ^= SpStartPvPREDCount.GetHashCode();
		}
		if (SpTurnAddHunterCount != 0)
		{
			num ^= SpTurnAddHunterCount.GetHashCode();
		}
		if (SpTurnAddPvECount != 0)
		{
			num ^= SpTurnAddPvECount.GetHashCode();
		}
		if (SpTurnAddPvPCount != 0)
		{
			num ^= SpTurnAddPvPCount.GetHashCode();
		}
		if (StrongElementEffect != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(StrongElementEffect);
		}
		if (TurnPassSec != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TurnPassSec);
		}
		if (WeakElementEffect != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(WeakElementEffect);
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
		if (AtkMax != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AtkMax);
		}
		if (AtkMin != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AtkMin);
		}
		if (CriDMax != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(CriDMax);
		}
		if (CriDMin != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(CriDMin);
		}
		if (CriMax != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(CriMax);
		}
		if (CriMin != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(CriMin);
		}
		if (DefMax != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(DefMax);
		}
		if (DefMin != 0.0)
		{
			output.WriteRawTag(65);
			output.WriteDouble(DefMin);
		}
		if (FieldObjectBattleRearrangeEffectTime != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(FieldObjectBattleRearrangeEffectTime);
		}
		if (FieldObjectBattleRearrangeTime != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(FieldObjectBattleRearrangeTime);
		}
		if (HpMaxLimit != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(HpMaxLimit);
		}
		if (BattleContinueCostItemCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(BattleContinueCostItemCount);
		}
		if (BattleContinueCostItemId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(BattleContinueCostItemId);
		}
		if (BattleContinueCostItemType != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(BattleContinueCostItemType);
		}
		if (BattleContinueMaxCount != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(BattleContinueMaxCount);
		}
		if (BattlePowerConst != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(BattlePowerConst);
		}
		if (ChainDamageValue != 0.0)
		{
			output.WriteRawTag(137, 1);
			output.WriteDouble(ChainDamageValue);
		}
		if (ChainMaxCount != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(ChainMaxCount);
		}
		if (DeathTimeBuffId != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(DeathTimeBuffId);
		}
		if (DeathTimeStartTurnPvP != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(DeathTimeStartTurnPvP);
		}
		if (FrontMoveSec != 0.0)
		{
			output.WriteRawTag(169, 1);
			output.WriteDouble(FrontMoveSec);
		}
		if (Id != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(Id);
		}
		if (MinAttackDamage != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(MinAttackDamage);
		}
		if (SideMoveSec != 0.0)
		{
			output.WriteRawTag(193, 1);
			output.WriteDouble(SideMoveSec);
		}
		if (SpMaxCount != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(SpMaxCount);
		}
		if (SpStartHunterCount != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(SpStartHunterCount);
		}
		if (SpStartPvECount != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(SpStartPvECount);
		}
		if (SpStartPvPBLUECount != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(SpStartPvPBLUECount);
		}
		if (SpStartPvPREDCount != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(SpStartPvPREDCount);
		}
		if (SpTurnAddHunterCount != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(SpTurnAddHunterCount);
		}
		if (SpTurnAddPvECount != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(SpTurnAddPvECount);
		}
		if (SpTurnAddPvPCount != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(SpTurnAddPvPCount);
		}
		if (StrongElementEffect != 0.0)
		{
			output.WriteRawTag(137, 2);
			output.WriteDouble(StrongElementEffect);
		}
		if (TurnPassSec != 0.0)
		{
			output.WriteRawTag(145, 2);
			output.WriteDouble(TurnPassSec);
		}
		if (WeakElementEffect != 0.0)
		{
			output.WriteRawTag(153, 2);
			output.WriteDouble(WeakElementEffect);
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
		if (AtkMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AtkMax);
		}
		if (AtkMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AtkMin);
		}
		if (CriDMax != 0.0)
		{
			num += 9;
		}
		if (CriDMin != 0.0)
		{
			num += 9;
		}
		if (CriMax != 0.0)
		{
			num += 9;
		}
		if (CriMin != 0.0)
		{
			num += 9;
		}
		if (DefMax != 0.0)
		{
			num += 9;
		}
		if (DefMin != 0.0)
		{
			num += 9;
		}
		if (FieldObjectBattleRearrangeEffectTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldObjectBattleRearrangeEffectTime);
		}
		if (FieldObjectBattleRearrangeTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldObjectBattleRearrangeTime);
		}
		if (HpMaxLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HpMaxLimit);
		}
		if (BattleContinueCostItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleContinueCostItemCount);
		}
		if (BattleContinueCostItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleContinueCostItemId);
		}
		if (BattleContinueCostItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleContinueCostItemType);
		}
		if (BattleContinueMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleContinueMaxCount);
		}
		if (BattlePowerConst != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BattlePowerConst);
		}
		if (ChainDamageValue != 0.0)
		{
			num += 10;
		}
		if (ChainMaxCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ChainMaxCount);
		}
		if (DeathTimeBuffId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DeathTimeBuffId);
		}
		if (DeathTimeStartTurnPvP != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DeathTimeStartTurnPvP);
		}
		if (FrontMoveSec != 0.0)
		{
			num += 10;
		}
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MinAttackDamage != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MinAttackDamage);
		}
		if (SideMoveSec != 0.0)
		{
			num += 10;
		}
		if (SpMaxCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpMaxCount);
		}
		if (SpStartHunterCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpStartHunterCount);
		}
		if (SpStartPvECount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpStartPvECount);
		}
		if (SpStartPvPBLUECount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpStartPvPBLUECount);
		}
		if (SpStartPvPREDCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpStartPvPREDCount);
		}
		if (SpTurnAddHunterCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpTurnAddHunterCount);
		}
		if (SpTurnAddPvECount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpTurnAddPvECount);
		}
		if (SpTurnAddPvPCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpTurnAddPvPCount);
		}
		if (StrongElementEffect != 0.0)
		{
			num += 10;
		}
		if (TurnPassSec != 0.0)
		{
			num += 10;
		}
		if (WeakElementEffect != 0.0)
		{
			num += 10;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleDefaultTable other)
	{
		if (other != null)
		{
			if (other.AtkMax != 0)
			{
				AtkMax = other.AtkMax;
			}
			if (other.AtkMin != 0)
			{
				AtkMin = other.AtkMin;
			}
			if (other.CriDMax != 0.0)
			{
				CriDMax = other.CriDMax;
			}
			if (other.CriDMin != 0.0)
			{
				CriDMin = other.CriDMin;
			}
			if (other.CriMax != 0.0)
			{
				CriMax = other.CriMax;
			}
			if (other.CriMin != 0.0)
			{
				CriMin = other.CriMin;
			}
			if (other.DefMax != 0.0)
			{
				DefMax = other.DefMax;
			}
			if (other.DefMin != 0.0)
			{
				DefMin = other.DefMin;
			}
			if (other.FieldObjectBattleRearrangeEffectTime != 0)
			{
				FieldObjectBattleRearrangeEffectTime = other.FieldObjectBattleRearrangeEffectTime;
			}
			if (other.FieldObjectBattleRearrangeTime != 0)
			{
				FieldObjectBattleRearrangeTime = other.FieldObjectBattleRearrangeTime;
			}
			if (other.HpMaxLimit != 0)
			{
				HpMaxLimit = other.HpMaxLimit;
			}
			if (other.BattleContinueCostItemCount != 0)
			{
				BattleContinueCostItemCount = other.BattleContinueCostItemCount;
			}
			if (other.BattleContinueCostItemId != 0)
			{
				BattleContinueCostItemId = other.BattleContinueCostItemId;
			}
			if (other.BattleContinueCostItemType != 0)
			{
				BattleContinueCostItemType = other.BattleContinueCostItemType;
			}
			if (other.BattleContinueMaxCount != 0)
			{
				BattleContinueMaxCount = other.BattleContinueMaxCount;
			}
			if (other.BattlePowerConst != 0)
			{
				BattlePowerConst = other.BattlePowerConst;
			}
			if (other.ChainDamageValue != 0.0)
			{
				ChainDamageValue = other.ChainDamageValue;
			}
			if (other.ChainMaxCount != 0)
			{
				ChainMaxCount = other.ChainMaxCount;
			}
			if (other.DeathTimeBuffId != 0)
			{
				DeathTimeBuffId = other.DeathTimeBuffId;
			}
			if (other.DeathTimeStartTurnPvP != 0)
			{
				DeathTimeStartTurnPvP = other.DeathTimeStartTurnPvP;
			}
			if (other.FrontMoveSec != 0.0)
			{
				FrontMoveSec = other.FrontMoveSec;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MinAttackDamage != 0)
			{
				MinAttackDamage = other.MinAttackDamage;
			}
			if (other.SideMoveSec != 0.0)
			{
				SideMoveSec = other.SideMoveSec;
			}
			if (other.SpMaxCount != 0)
			{
				SpMaxCount = other.SpMaxCount;
			}
			if (other.SpStartHunterCount != 0)
			{
				SpStartHunterCount = other.SpStartHunterCount;
			}
			if (other.SpStartPvECount != 0)
			{
				SpStartPvECount = other.SpStartPvECount;
			}
			if (other.SpStartPvPBLUECount != 0)
			{
				SpStartPvPBLUECount = other.SpStartPvPBLUECount;
			}
			if (other.SpStartPvPREDCount != 0)
			{
				SpStartPvPREDCount = other.SpStartPvPREDCount;
			}
			if (other.SpTurnAddHunterCount != 0)
			{
				SpTurnAddHunterCount = other.SpTurnAddHunterCount;
			}
			if (other.SpTurnAddPvECount != 0)
			{
				SpTurnAddPvECount = other.SpTurnAddPvECount;
			}
			if (other.SpTurnAddPvPCount != 0)
			{
				SpTurnAddPvPCount = other.SpTurnAddPvPCount;
			}
			if (other.StrongElementEffect != 0.0)
			{
				StrongElementEffect = other.StrongElementEffect;
			}
			if (other.TurnPassSec != 0.0)
			{
				TurnPassSec = other.TurnPassSec;
			}
			if (other.WeakElementEffect != 0.0)
			{
				WeakElementEffect = other.WeakElementEffect;
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
				AtkMax = input.ReadInt32();
				break;
			case 16u:
				AtkMin = input.ReadInt32();
				break;
			case 25u:
				CriDMax = input.ReadDouble();
				break;
			case 33u:
				CriDMin = input.ReadDouble();
				break;
			case 41u:
				CriMax = input.ReadDouble();
				break;
			case 49u:
				CriMin = input.ReadDouble();
				break;
			case 57u:
				DefMax = input.ReadDouble();
				break;
			case 65u:
				DefMin = input.ReadDouble();
				break;
			case 72u:
				FieldObjectBattleRearrangeEffectTime = input.ReadInt32();
				break;
			case 80u:
				FieldObjectBattleRearrangeTime = input.ReadInt32();
				break;
			case 88u:
				HpMaxLimit = input.ReadInt32();
				break;
			case 96u:
				BattleContinueCostItemCount = input.ReadInt32();
				break;
			case 104u:
				BattleContinueCostItemId = input.ReadInt32();
				break;
			case 112u:
				BattleContinueCostItemType = input.ReadInt32();
				break;
			case 120u:
				BattleContinueMaxCount = input.ReadInt32();
				break;
			case 128u:
				BattlePowerConst = input.ReadInt32();
				break;
			case 137u:
				ChainDamageValue = input.ReadDouble();
				break;
			case 144u:
				ChainMaxCount = input.ReadInt32();
				break;
			case 152u:
				DeathTimeBuffId = input.ReadInt32();
				break;
			case 160u:
				DeathTimeStartTurnPvP = input.ReadInt32();
				break;
			case 169u:
				FrontMoveSec = input.ReadDouble();
				break;
			case 176u:
				Id = input.ReadInt32();
				break;
			case 184u:
				MinAttackDamage = input.ReadInt32();
				break;
			case 193u:
				SideMoveSec = input.ReadDouble();
				break;
			case 200u:
				SpMaxCount = input.ReadInt32();
				break;
			case 208u:
				SpStartHunterCount = input.ReadInt32();
				break;
			case 216u:
				SpStartPvECount = input.ReadInt32();
				break;
			case 224u:
				SpStartPvPBLUECount = input.ReadInt32();
				break;
			case 232u:
				SpStartPvPREDCount = input.ReadInt32();
				break;
			case 240u:
				SpTurnAddHunterCount = input.ReadInt32();
				break;
			case 248u:
				SpTurnAddPvECount = input.ReadInt32();
				break;
			case 256u:
				SpTurnAddPvPCount = input.ReadInt32();
				break;
			case 265u:
				StrongElementEffect = input.ReadDouble();
				break;
			case 273u:
				TurnPassSec = input.ReadDouble();
				break;
			case 281u:
				WeakElementEffect = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
