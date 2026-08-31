using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PvpDefaultTable : IMessage<PvpDefaultTable>, IMessage, IEquatable<PvpDefaultTable>, IDeepCloneable<PvpDefaultTable>, IBufferMessage
{
	private static readonly MessageParser<PvpDefaultTable> _parser = new MessageParser<PvpDefaultTable>(() => new PvpDefaultTable());

	private UnknownFieldSet _unknownFields;

	public const int BattleBGMFieldNumber = 1;

	private string battleBGM_ = "";

	public const int VPMinFieldNumber = 2;

	private int vPMin_;

	public const int BattleEndTurnFieldNumber = 3;

	private int battleEndTurn_;

	public const int BattleHistoryHourFieldNumber = 4;

	private int battleHistoryHour_;

	public const int BattleHistoryLimitCountFieldNumber = 5;

	private int battleHistoryLimitCount_;

	public const int BattleHistoryRefreshCoolTimeFieldNumber = 6;

	private int battleHistoryRefreshCoolTime_;

	public const int BattlePenaltyRatioFieldNumber = 7;

	private int battlePenaltyRatio_;

	public const int BattlePenaltyRoundFieldNumber = 8;

	private int battlePenaltyRound_;

	public const int BattleReadyTimeFieldNumber = 9;

	private int battleReadyTime_;

	public const int BattleSkipWaitTurnFieldNumber = 10;

	private int battleSkipWaitTurn_;

	public const int CareCountFieldNumber = 11;

	private int careCount_;

	public const int CareLoseFieldNumber = 12;

	private int careLose_;

	public const int CarePointMaxFieldNumber = 13;

	private int carePointMax_;

	public const int CareWinFieldNumber = 14;

	private int careWin_;

	public const int CorrectionFactorFieldNumber = 15;

	private int correctionFactor_;

	public const int IdFieldNumber = 16;

	private int id_;

	public const int MatchCountFieldNumber = 17;

	private int matchCount_;

	public const int MatchExcludeCountFieldNumber = 18;

	private int matchExcludeCount_;

	public const int MatchVpRangeFieldNumber = 19;

	private static readonly FieldCodec<int> _repeated_matchVpRange_codec = FieldCodec.ForInt32(154u);

	private readonly RepeatedField<int> matchVpRange_ = new RepeatedField<int>();

	public const int NewbieCareFieldNumber = 20;

	private int newbieCare_;

	public const int PopularCostumeMinRankGroupIdFieldNumber = 21;

	private int popularCostumeMinRankGroupId_;

	public const int PvpUseCoinCountFieldNumber = 22;

	private int pvpUseCoinCount_;

	public const int RepeatBattleIntervalFieldNumber = 23;

	private int repeatBattleInterval_;

	public const int SearchingPoolCountFieldNumber = 24;

	private int searchingPoolCount_;

	public const int StartVPFieldNumber = 25;

	private int startVP_;

	public const int TopRankBoundaryFieldNumber = 26;

	private int topRankBoundary_;

	public const int TopRankMatchVpRangeFieldNumber = 27;

	private static readonly FieldCodec<int> _repeated_topRankMatchVpRange_codec = FieldCodec.ForInt32(218u);

	private readonly RepeatedField<int> topRankMatchVpRange_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpDefaultTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpDefaultTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BattleBGM
	{
		get
		{
			return battleBGM_;
		}
		set
		{
			battleBGM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int VPMin
	{
		get
		{
			return vPMin_;
		}
		set
		{
			vPMin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleEndTurn
	{
		get
		{
			return battleEndTurn_;
		}
		set
		{
			battleEndTurn_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleHistoryHour
	{
		get
		{
			return battleHistoryHour_;
		}
		set
		{
			battleHistoryHour_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleHistoryLimitCount
	{
		get
		{
			return battleHistoryLimitCount_;
		}
		set
		{
			battleHistoryLimitCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleHistoryRefreshCoolTime
	{
		get
		{
			return battleHistoryRefreshCoolTime_;
		}
		set
		{
			battleHistoryRefreshCoolTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattlePenaltyRatio
	{
		get
		{
			return battlePenaltyRatio_;
		}
		set
		{
			battlePenaltyRatio_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattlePenaltyRound
	{
		get
		{
			return battlePenaltyRound_;
		}
		set
		{
			battlePenaltyRound_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleReadyTime
	{
		get
		{
			return battleReadyTime_;
		}
		set
		{
			battleReadyTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleSkipWaitTurn
	{
		get
		{
			return battleSkipWaitTurn_;
		}
		set
		{
			battleSkipWaitTurn_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CareCount
	{
		get
		{
			return careCount_;
		}
		set
		{
			careCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CareLose
	{
		get
		{
			return careLose_;
		}
		set
		{
			careLose_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CarePointMax
	{
		get
		{
			return carePointMax_;
		}
		set
		{
			carePointMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CareWin
	{
		get
		{
			return careWin_;
		}
		set
		{
			careWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CorrectionFactor
	{
		get
		{
			return correctionFactor_;
		}
		set
		{
			correctionFactor_ = value;
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
	public int MatchCount
	{
		get
		{
			return matchCount_;
		}
		set
		{
			matchCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MatchExcludeCount
	{
		get
		{
			return matchExcludeCount_;
		}
		set
		{
			matchExcludeCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MatchVpRange => matchVpRange_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NewbieCare
	{
		get
		{
			return newbieCare_;
		}
		set
		{
			newbieCare_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PopularCostumeMinRankGroupId
	{
		get
		{
			return popularCostumeMinRankGroupId_;
		}
		set
		{
			popularCostumeMinRankGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PvpUseCoinCount
	{
		get
		{
			return pvpUseCoinCount_;
		}
		set
		{
			pvpUseCoinCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RepeatBattleInterval
	{
		get
		{
			return repeatBattleInterval_;
		}
		set
		{
			repeatBattleInterval_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SearchingPoolCount
	{
		get
		{
			return searchingPoolCount_;
		}
		set
		{
			searchingPoolCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StartVP
	{
		get
		{
			return startVP_;
		}
		set
		{
			startVP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TopRankBoundary
	{
		get
		{
			return topRankBoundary_;
		}
		set
		{
			topRankBoundary_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> TopRankMatchVpRange => topRankMatchVpRange_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpDefaultTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpDefaultTable(PvpDefaultTable other)
		: this()
	{
		battleBGM_ = other.battleBGM_;
		vPMin_ = other.vPMin_;
		battleEndTurn_ = other.battleEndTurn_;
		battleHistoryHour_ = other.battleHistoryHour_;
		battleHistoryLimitCount_ = other.battleHistoryLimitCount_;
		battleHistoryRefreshCoolTime_ = other.battleHistoryRefreshCoolTime_;
		battlePenaltyRatio_ = other.battlePenaltyRatio_;
		battlePenaltyRound_ = other.battlePenaltyRound_;
		battleReadyTime_ = other.battleReadyTime_;
		battleSkipWaitTurn_ = other.battleSkipWaitTurn_;
		careCount_ = other.careCount_;
		careLose_ = other.careLose_;
		carePointMax_ = other.carePointMax_;
		careWin_ = other.careWin_;
		correctionFactor_ = other.correctionFactor_;
		id_ = other.id_;
		matchCount_ = other.matchCount_;
		matchExcludeCount_ = other.matchExcludeCount_;
		matchVpRange_ = other.matchVpRange_.Clone();
		newbieCare_ = other.newbieCare_;
		popularCostumeMinRankGroupId_ = other.popularCostumeMinRankGroupId_;
		pvpUseCoinCount_ = other.pvpUseCoinCount_;
		repeatBattleInterval_ = other.repeatBattleInterval_;
		searchingPoolCount_ = other.searchingPoolCount_;
		startVP_ = other.startVP_;
		topRankBoundary_ = other.topRankBoundary_;
		topRankMatchVpRange_ = other.topRankMatchVpRange_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpDefaultTable Clone()
	{
		return new PvpDefaultTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpDefaultTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpDefaultTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(BattleBGM != other.BattleBGM) && VPMin == other.VPMin && BattleEndTurn == other.BattleEndTurn && BattleHistoryHour == other.BattleHistoryHour && BattleHistoryLimitCount == other.BattleHistoryLimitCount && BattleHistoryRefreshCoolTime == other.BattleHistoryRefreshCoolTime && BattlePenaltyRatio == other.BattlePenaltyRatio && BattlePenaltyRound == other.BattlePenaltyRound && BattleReadyTime == other.BattleReadyTime && BattleSkipWaitTurn == other.BattleSkipWaitTurn && CareCount == other.CareCount && CareLose == other.CareLose && CarePointMax == other.CarePointMax && CareWin == other.CareWin && CorrectionFactor == other.CorrectionFactor && Id == other.Id && MatchCount == other.MatchCount && MatchExcludeCount == other.MatchExcludeCount && matchVpRange_.Equals(other.matchVpRange_) && NewbieCare == other.NewbieCare && PopularCostumeMinRankGroupId == other.PopularCostumeMinRankGroupId && PvpUseCoinCount == other.PvpUseCoinCount && RepeatBattleInterval == other.RepeatBattleInterval && SearchingPoolCount == other.SearchingPoolCount && StartVP == other.StartVP && TopRankBoundary == other.TopRankBoundary && topRankMatchVpRange_.Equals(other.topRankMatchVpRange_))
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
		if (BattleBGM.Length != 0)
		{
			num ^= BattleBGM.GetHashCode();
		}
		if (VPMin != 0)
		{
			num ^= VPMin.GetHashCode();
		}
		if (BattleEndTurn != 0)
		{
			num ^= BattleEndTurn.GetHashCode();
		}
		if (BattleHistoryHour != 0)
		{
			num ^= BattleHistoryHour.GetHashCode();
		}
		if (BattleHistoryLimitCount != 0)
		{
			num ^= BattleHistoryLimitCount.GetHashCode();
		}
		if (BattleHistoryRefreshCoolTime != 0)
		{
			num ^= BattleHistoryRefreshCoolTime.GetHashCode();
		}
		if (BattlePenaltyRatio != 0)
		{
			num ^= BattlePenaltyRatio.GetHashCode();
		}
		if (BattlePenaltyRound != 0)
		{
			num ^= BattlePenaltyRound.GetHashCode();
		}
		if (BattleReadyTime != 0)
		{
			num ^= BattleReadyTime.GetHashCode();
		}
		if (BattleSkipWaitTurn != 0)
		{
			num ^= BattleSkipWaitTurn.GetHashCode();
		}
		if (CareCount != 0)
		{
			num ^= CareCount.GetHashCode();
		}
		if (CareLose != 0)
		{
			num ^= CareLose.GetHashCode();
		}
		if (CarePointMax != 0)
		{
			num ^= CarePointMax.GetHashCode();
		}
		if (CareWin != 0)
		{
			num ^= CareWin.GetHashCode();
		}
		if (CorrectionFactor != 0)
		{
			num ^= CorrectionFactor.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MatchCount != 0)
		{
			num ^= MatchCount.GetHashCode();
		}
		if (MatchExcludeCount != 0)
		{
			num ^= MatchExcludeCount.GetHashCode();
		}
		num ^= matchVpRange_.GetHashCode();
		if (NewbieCare != 0)
		{
			num ^= NewbieCare.GetHashCode();
		}
		if (PopularCostumeMinRankGroupId != 0)
		{
			num ^= PopularCostumeMinRankGroupId.GetHashCode();
		}
		if (PvpUseCoinCount != 0)
		{
			num ^= PvpUseCoinCount.GetHashCode();
		}
		if (RepeatBattleInterval != 0)
		{
			num ^= RepeatBattleInterval.GetHashCode();
		}
		if (SearchingPoolCount != 0)
		{
			num ^= SearchingPoolCount.GetHashCode();
		}
		if (StartVP != 0)
		{
			num ^= StartVP.GetHashCode();
		}
		if (TopRankBoundary != 0)
		{
			num ^= TopRankBoundary.GetHashCode();
		}
		num ^= topRankMatchVpRange_.GetHashCode();
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
		if (BattleBGM.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BattleBGM);
		}
		if (VPMin != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(VPMin);
		}
		if (BattleEndTurn != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleEndTurn);
		}
		if (BattleHistoryHour != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BattleHistoryHour);
		}
		if (BattleHistoryLimitCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BattleHistoryLimitCount);
		}
		if (BattleHistoryRefreshCoolTime != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BattleHistoryRefreshCoolTime);
		}
		if (BattlePenaltyRatio != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(BattlePenaltyRatio);
		}
		if (BattlePenaltyRound != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(BattlePenaltyRound);
		}
		if (BattleReadyTime != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(BattleReadyTime);
		}
		if (BattleSkipWaitTurn != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(BattleSkipWaitTurn);
		}
		if (CareCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(CareCount);
		}
		if (CareLose != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(CareLose);
		}
		if (CarePointMax != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(CarePointMax);
		}
		if (CareWin != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(CareWin);
		}
		if (CorrectionFactor != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(CorrectionFactor);
		}
		if (Id != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(Id);
		}
		if (MatchCount != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(MatchCount);
		}
		if (MatchExcludeCount != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(MatchExcludeCount);
		}
		matchVpRange_.WriteTo(ref output, _repeated_matchVpRange_codec);
		if (NewbieCare != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(NewbieCare);
		}
		if (PopularCostumeMinRankGroupId != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(PopularCostumeMinRankGroupId);
		}
		if (PvpUseCoinCount != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(PvpUseCoinCount);
		}
		if (RepeatBattleInterval != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(RepeatBattleInterval);
		}
		if (SearchingPoolCount != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(SearchingPoolCount);
		}
		if (StartVP != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(StartVP);
		}
		if (TopRankBoundary != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(TopRankBoundary);
		}
		topRankMatchVpRange_.WriteTo(ref output, _repeated_topRankMatchVpRange_codec);
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
		if (BattleBGM.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BattleBGM);
		}
		if (VPMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VPMin);
		}
		if (BattleEndTurn != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleEndTurn);
		}
		if (BattleHistoryHour != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleHistoryHour);
		}
		if (BattleHistoryLimitCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleHistoryLimitCount);
		}
		if (BattleHistoryRefreshCoolTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleHistoryRefreshCoolTime);
		}
		if (BattlePenaltyRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattlePenaltyRatio);
		}
		if (BattlePenaltyRound != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattlePenaltyRound);
		}
		if (BattleReadyTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleReadyTime);
		}
		if (BattleSkipWaitTurn != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleSkipWaitTurn);
		}
		if (CareCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CareCount);
		}
		if (CareLose != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CareLose);
		}
		if (CarePointMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CarePointMax);
		}
		if (CareWin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CareWin);
		}
		if (CorrectionFactor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CorrectionFactor);
		}
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MatchCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MatchCount);
		}
		if (MatchExcludeCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MatchExcludeCount);
		}
		num += matchVpRange_.CalculateSize(_repeated_matchVpRange_codec);
		if (NewbieCare != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NewbieCare);
		}
		if (PopularCostumeMinRankGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PopularCostumeMinRankGroupId);
		}
		if (PvpUseCoinCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PvpUseCoinCount);
		}
		if (RepeatBattleInterval != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RepeatBattleInterval);
		}
		if (SearchingPoolCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SearchingPoolCount);
		}
		if (StartVP != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StartVP);
		}
		if (TopRankBoundary != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TopRankBoundary);
		}
		num += topRankMatchVpRange_.CalculateSize(_repeated_topRankMatchVpRange_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpDefaultTable other)
	{
		if (other != null)
		{
			if (other.BattleBGM.Length != 0)
			{
				BattleBGM = other.BattleBGM;
			}
			if (other.VPMin != 0)
			{
				VPMin = other.VPMin;
			}
			if (other.BattleEndTurn != 0)
			{
				BattleEndTurn = other.BattleEndTurn;
			}
			if (other.BattleHistoryHour != 0)
			{
				BattleHistoryHour = other.BattleHistoryHour;
			}
			if (other.BattleHistoryLimitCount != 0)
			{
				BattleHistoryLimitCount = other.BattleHistoryLimitCount;
			}
			if (other.BattleHistoryRefreshCoolTime != 0)
			{
				BattleHistoryRefreshCoolTime = other.BattleHistoryRefreshCoolTime;
			}
			if (other.BattlePenaltyRatio != 0)
			{
				BattlePenaltyRatio = other.BattlePenaltyRatio;
			}
			if (other.BattlePenaltyRound != 0)
			{
				BattlePenaltyRound = other.BattlePenaltyRound;
			}
			if (other.BattleReadyTime != 0)
			{
				BattleReadyTime = other.BattleReadyTime;
			}
			if (other.BattleSkipWaitTurn != 0)
			{
				BattleSkipWaitTurn = other.BattleSkipWaitTurn;
			}
			if (other.CareCount != 0)
			{
				CareCount = other.CareCount;
			}
			if (other.CareLose != 0)
			{
				CareLose = other.CareLose;
			}
			if (other.CarePointMax != 0)
			{
				CarePointMax = other.CarePointMax;
			}
			if (other.CareWin != 0)
			{
				CareWin = other.CareWin;
			}
			if (other.CorrectionFactor != 0)
			{
				CorrectionFactor = other.CorrectionFactor;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MatchCount != 0)
			{
				MatchCount = other.MatchCount;
			}
			if (other.MatchExcludeCount != 0)
			{
				MatchExcludeCount = other.MatchExcludeCount;
			}
			matchVpRange_.Add(other.matchVpRange_);
			if (other.NewbieCare != 0)
			{
				NewbieCare = other.NewbieCare;
			}
			if (other.PopularCostumeMinRankGroupId != 0)
			{
				PopularCostumeMinRankGroupId = other.PopularCostumeMinRankGroupId;
			}
			if (other.PvpUseCoinCount != 0)
			{
				PvpUseCoinCount = other.PvpUseCoinCount;
			}
			if (other.RepeatBattleInterval != 0)
			{
				RepeatBattleInterval = other.RepeatBattleInterval;
			}
			if (other.SearchingPoolCount != 0)
			{
				SearchingPoolCount = other.SearchingPoolCount;
			}
			if (other.StartVP != 0)
			{
				StartVP = other.StartVP;
			}
			if (other.TopRankBoundary != 0)
			{
				TopRankBoundary = other.TopRankBoundary;
			}
			topRankMatchVpRange_.Add(other.topRankMatchVpRange_);
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
				BattleBGM = input.ReadString();
				break;
			case 16u:
				VPMin = input.ReadInt32();
				break;
			case 24u:
				BattleEndTurn = input.ReadInt32();
				break;
			case 32u:
				BattleHistoryHour = input.ReadInt32();
				break;
			case 40u:
				BattleHistoryLimitCount = input.ReadInt32();
				break;
			case 48u:
				BattleHistoryRefreshCoolTime = input.ReadInt32();
				break;
			case 56u:
				BattlePenaltyRatio = input.ReadInt32();
				break;
			case 64u:
				BattlePenaltyRound = input.ReadInt32();
				break;
			case 72u:
				BattleReadyTime = input.ReadInt32();
				break;
			case 80u:
				BattleSkipWaitTurn = input.ReadInt32();
				break;
			case 88u:
				CareCount = input.ReadInt32();
				break;
			case 96u:
				CareLose = input.ReadInt32();
				break;
			case 104u:
				CarePointMax = input.ReadInt32();
				break;
			case 112u:
				CareWin = input.ReadInt32();
				break;
			case 144u:
				MatchExcludeCount = input.ReadInt32();
				break;
			case 160u:
				NewbieCare = input.ReadInt32();
				break;
			case 152u:
			case 154u:
				matchVpRange_.AddEntriesFrom(ref input, _repeated_matchVpRange_codec);
				break;
			case 120u:
				CorrectionFactor = input.ReadInt32();
				break;
			case 128u:
				Id = input.ReadInt32();
				break;
			case 136u:
				MatchCount = input.ReadInt32();
				break;
			case 168u:
				PopularCostumeMinRankGroupId = input.ReadInt32();
				break;
			case 176u:
				PvpUseCoinCount = input.ReadInt32();
				break;
			case 184u:
				RepeatBattleInterval = input.ReadInt32();
				break;
			case 192u:
				SearchingPoolCount = input.ReadInt32();
				break;
			case 200u:
				StartVP = input.ReadInt32();
				break;
			case 208u:
				TopRankBoundary = input.ReadInt32();
				break;
			case 216u:
			case 218u:
				topRankMatchVpRange_.AddEntriesFrom(ref input, _repeated_topRankMatchVpRange_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
