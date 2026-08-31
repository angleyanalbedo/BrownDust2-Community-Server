using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PvpRankTable : IMessage<PvpRankTable>, IMessage, IEquatable<PvpRankTable>, IDeepCloneable<PvpRankTable>, IBufferMessage
{
	private static readonly MessageParser<PvpRankTable> _parser = new MessageParser<PvpRankTable>(() => new PvpRankTable());

	private UnknownFieldSet _unknownFields;

	public const int BattleLoseRewardCountFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_battleLoseRewardCount_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> battleLoseRewardCount_ = new RepeatedField<int>();

	public const int BattleLoseRewardIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_battleLoseRewardId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> battleLoseRewardId_ = new RepeatedField<int>();

	public const int BattleLoseRewardTypeFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_battleLoseRewardType_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> battleLoseRewardType_ = new RepeatedField<int>();

	public const int BattleWinRewardCountFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_battleWinRewardCount_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> battleWinRewardCount_ = new RepeatedField<int>();

	public const int BattleWinRewardIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_battleWinRewardId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> battleWinRewardId_ = new RepeatedField<int>();

	public const int BattleWinRewardTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_battleWinRewardType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> battleWinRewardType_ = new RepeatedField<int>();

	public const int GroupIdFieldNumber = 7;

	private int groupId_;

	public const int IconSpriteNameFieldNumber = 8;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 9;

	private int id_;

	public const int IsELOFieldNumber = 10;

	private int isELO_;

	public const int LosePointFieldNumber = 11;

	private int losePoint_;

	public const int PromotionRewardRandomBoxIdFieldNumber = 12;

	private int promotionRewardRandomBoxId_;

	public const int PvpRankingFieldNumber = 13;

	private int pvpRanking_;

	public const int RankGroupIdFieldNumber = 14;

	private int rankGroupId_;

	public const int RankGroupLocalTextIdFieldNumber = 15;

	private int rankGroupLocalTextId_;

	public const int RankNameLocalTextIdFieldNumber = 16;

	private int rankNameLocalTextId_;

	public const int SeasonRewardCountFieldNumber = 17;

	private static readonly FieldCodec<int> _repeated_seasonRewardCount_codec = FieldCodec.ForInt32(138u);

	private readonly RepeatedField<int> seasonRewardCount_ = new RepeatedField<int>();

	public const int SeasonRewardIdFieldNumber = 18;

	private static readonly FieldCodec<int> _repeated_seasonRewardId_codec = FieldCodec.ForInt32(146u);

	private readonly RepeatedField<int> seasonRewardId_ = new RepeatedField<int>();

	public const int SeasonRewardTypeFieldNumber = 19;

	private static readonly FieldCodec<int> _repeated_seasonRewardType_codec = FieldCodec.ForInt32(154u);

	private readonly RepeatedField<int> seasonRewardType_ = new RepeatedField<int>();

	public const int SeasonStartVPFieldNumber = 20;

	private int seasonStartVP_;

	public const int VpFieldNumber = 21;

	private int vp_;

	public const int WinPointFieldNumber = 22;

	private int winPoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpRankTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PvpRankTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleLoseRewardCount => battleLoseRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleLoseRewardId => battleLoseRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleLoseRewardType => battleLoseRewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleWinRewardCount => battleWinRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleWinRewardId => battleWinRewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BattleWinRewardType => battleWinRewardType_;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string IconSpriteName
	{
		get
		{
			return iconSpriteName_;
		}
		set
		{
			iconSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IsELO
	{
		get
		{
			return isELO_;
		}
		set
		{
			isELO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LosePoint
	{
		get
		{
			return losePoint_;
		}
		set
		{
			losePoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PromotionRewardRandomBoxId
	{
		get
		{
			return promotionRewardRandomBoxId_;
		}
		set
		{
			promotionRewardRandomBoxId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PvpRanking
	{
		get
		{
			return pvpRanking_;
		}
		set
		{
			pvpRanking_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RankGroupId
	{
		get
		{
			return rankGroupId_;
		}
		set
		{
			rankGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankGroupLocalTextId
	{
		get
		{
			return rankGroupLocalTextId_;
		}
		set
		{
			rankGroupLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankNameLocalTextId
	{
		get
		{
			return rankNameLocalTextId_;
		}
		set
		{
			rankNameLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SeasonRewardCount => seasonRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SeasonRewardId => seasonRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SeasonRewardType => seasonRewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SeasonStartVP
	{
		get
		{
			return seasonStartVP_;
		}
		set
		{
			seasonStartVP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Vp
	{
		get
		{
			return vp_;
		}
		set
		{
			vp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WinPoint
	{
		get
		{
			return winPoint_;
		}
		set
		{
			winPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpRankTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpRankTable(PvpRankTable other)
		: this()
	{
		battleLoseRewardCount_ = other.battleLoseRewardCount_.Clone();
		battleLoseRewardId_ = other.battleLoseRewardId_.Clone();
		battleLoseRewardType_ = other.battleLoseRewardType_.Clone();
		battleWinRewardCount_ = other.battleWinRewardCount_.Clone();
		battleWinRewardId_ = other.battleWinRewardId_.Clone();
		battleWinRewardType_ = other.battleWinRewardType_.Clone();
		groupId_ = other.groupId_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		isELO_ = other.isELO_;
		losePoint_ = other.losePoint_;
		promotionRewardRandomBoxId_ = other.promotionRewardRandomBoxId_;
		pvpRanking_ = other.pvpRanking_;
		rankGroupId_ = other.rankGroupId_;
		rankGroupLocalTextId_ = other.rankGroupLocalTextId_;
		rankNameLocalTextId_ = other.rankNameLocalTextId_;
		seasonRewardCount_ = other.seasonRewardCount_.Clone();
		seasonRewardId_ = other.seasonRewardId_.Clone();
		seasonRewardType_ = other.seasonRewardType_.Clone();
		seasonStartVP_ = other.seasonStartVP_;
		vp_ = other.vp_;
		winPoint_ = other.winPoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpRankTable Clone()
	{
		return new PvpRankTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpRankTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpRankTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (battleLoseRewardCount_.Equals(other.battleLoseRewardCount_) && battleLoseRewardId_.Equals(other.battleLoseRewardId_) && battleLoseRewardType_.Equals(other.battleLoseRewardType_) && battleWinRewardCount_.Equals(other.battleWinRewardCount_) && battleWinRewardId_.Equals(other.battleWinRewardId_) && battleWinRewardType_.Equals(other.battleWinRewardType_) && GroupId == other.GroupId && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && IsELO == other.IsELO && LosePoint == other.LosePoint && PromotionRewardRandomBoxId == other.PromotionRewardRandomBoxId && PvpRanking == other.PvpRanking && RankGroupId == other.RankGroupId && RankGroupLocalTextId == other.RankGroupLocalTextId && RankNameLocalTextId == other.RankNameLocalTextId && seasonRewardCount_.Equals(other.seasonRewardCount_) && seasonRewardId_.Equals(other.seasonRewardId_) && seasonRewardType_.Equals(other.seasonRewardType_) && SeasonStartVP == other.SeasonStartVP && Vp == other.Vp && WinPoint == other.WinPoint)
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
		num ^= battleLoseRewardCount_.GetHashCode();
		num ^= battleLoseRewardId_.GetHashCode();
		num ^= battleLoseRewardType_.GetHashCode();
		num ^= battleWinRewardCount_.GetHashCode();
		num ^= battleWinRewardId_.GetHashCode();
		num ^= battleWinRewardType_.GetHashCode();
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsELO != 0)
		{
			num ^= IsELO.GetHashCode();
		}
		if (LosePoint != 0)
		{
			num ^= LosePoint.GetHashCode();
		}
		if (PromotionRewardRandomBoxId != 0)
		{
			num ^= PromotionRewardRandomBoxId.GetHashCode();
		}
		if (PvpRanking != 0)
		{
			num ^= PvpRanking.GetHashCode();
		}
		if (RankGroupId != 0)
		{
			num ^= RankGroupId.GetHashCode();
		}
		if (RankGroupLocalTextId != 0)
		{
			num ^= RankGroupLocalTextId.GetHashCode();
		}
		if (RankNameLocalTextId != 0)
		{
			num ^= RankNameLocalTextId.GetHashCode();
		}
		num ^= seasonRewardCount_.GetHashCode();
		num ^= seasonRewardId_.GetHashCode();
		num ^= seasonRewardType_.GetHashCode();
		if (SeasonStartVP != 0)
		{
			num ^= SeasonStartVP.GetHashCode();
		}
		if (Vp != 0)
		{
			num ^= Vp.GetHashCode();
		}
		if (WinPoint != 0)
		{
			num ^= WinPoint.GetHashCode();
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
		battleLoseRewardCount_.WriteTo(ref output, _repeated_battleLoseRewardCount_codec);
		battleLoseRewardId_.WriteTo(ref output, _repeated_battleLoseRewardId_codec);
		battleLoseRewardType_.WriteTo(ref output, _repeated_battleLoseRewardType_codec);
		battleWinRewardCount_.WriteTo(ref output, _repeated_battleWinRewardCount_codec);
		battleWinRewardId_.WriteTo(ref output, _repeated_battleWinRewardId_codec);
		battleWinRewardType_.WriteTo(ref output, _repeated_battleWinRewardType_codec);
		if (GroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GroupId);
		}
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Id);
		}
		if (IsELO != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(IsELO);
		}
		if (LosePoint != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(LosePoint);
		}
		if (PromotionRewardRandomBoxId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(PromotionRewardRandomBoxId);
		}
		if (PvpRanking != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PvpRanking);
		}
		if (RankGroupId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(RankGroupId);
		}
		if (RankGroupLocalTextId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(RankGroupLocalTextId);
		}
		if (RankNameLocalTextId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(RankNameLocalTextId);
		}
		seasonRewardCount_.WriteTo(ref output, _repeated_seasonRewardCount_codec);
		seasonRewardId_.WriteTo(ref output, _repeated_seasonRewardId_codec);
		seasonRewardType_.WriteTo(ref output, _repeated_seasonRewardType_codec);
		if (SeasonStartVP != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(SeasonStartVP);
		}
		if (Vp != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(Vp);
		}
		if (WinPoint != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(WinPoint);
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
		num += battleLoseRewardCount_.CalculateSize(_repeated_battleLoseRewardCount_codec);
		num += battleLoseRewardId_.CalculateSize(_repeated_battleLoseRewardId_codec);
		num += battleLoseRewardType_.CalculateSize(_repeated_battleLoseRewardType_codec);
		num += battleWinRewardCount_.CalculateSize(_repeated_battleWinRewardCount_codec);
		num += battleWinRewardId_.CalculateSize(_repeated_battleWinRewardId_codec);
		num += battleWinRewardType_.CalculateSize(_repeated_battleWinRewardType_codec);
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsELO != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsELO);
		}
		if (LosePoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LosePoint);
		}
		if (PromotionRewardRandomBoxId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PromotionRewardRandomBoxId);
		}
		if (PvpRanking != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PvpRanking);
		}
		if (RankGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RankGroupId);
		}
		if (RankGroupLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RankGroupLocalTextId);
		}
		if (RankNameLocalTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RankNameLocalTextId);
		}
		num += seasonRewardCount_.CalculateSize(_repeated_seasonRewardCount_codec);
		num += seasonRewardId_.CalculateSize(_repeated_seasonRewardId_codec);
		num += seasonRewardType_.CalculateSize(_repeated_seasonRewardType_codec);
		if (SeasonStartVP != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SeasonStartVP);
		}
		if (Vp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Vp);
		}
		if (WinPoint != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WinPoint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PvpRankTable other)
	{
		if (other != null)
		{
			battleLoseRewardCount_.Add(other.battleLoseRewardCount_);
			battleLoseRewardId_.Add(other.battleLoseRewardId_);
			battleLoseRewardType_.Add(other.battleLoseRewardType_);
			battleWinRewardCount_.Add(other.battleWinRewardCount_);
			battleWinRewardId_.Add(other.battleWinRewardId_);
			battleWinRewardType_.Add(other.battleWinRewardType_);
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsELO != 0)
			{
				IsELO = other.IsELO;
			}
			if (other.LosePoint != 0)
			{
				LosePoint = other.LosePoint;
			}
			if (other.PromotionRewardRandomBoxId != 0)
			{
				PromotionRewardRandomBoxId = other.PromotionRewardRandomBoxId;
			}
			if (other.PvpRanking != 0)
			{
				PvpRanking = other.PvpRanking;
			}
			if (other.RankGroupId != 0)
			{
				RankGroupId = other.RankGroupId;
			}
			if (other.RankGroupLocalTextId != 0)
			{
				RankGroupLocalTextId = other.RankGroupLocalTextId;
			}
			if (other.RankNameLocalTextId != 0)
			{
				RankNameLocalTextId = other.RankNameLocalTextId;
			}
			seasonRewardCount_.Add(other.seasonRewardCount_);
			seasonRewardId_.Add(other.seasonRewardId_);
			seasonRewardType_.Add(other.seasonRewardType_);
			if (other.SeasonStartVP != 0)
			{
				SeasonStartVP = other.SeasonStartVP;
			}
			if (other.Vp != 0)
			{
				Vp = other.Vp;
			}
			if (other.WinPoint != 0)
			{
				WinPoint = other.WinPoint;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 24u:
			case 26u:
				battleLoseRewardType_.AddEntriesFrom(ref input, _repeated_battleLoseRewardType_codec);
				break;
			case 8u:
			case 10u:
				battleLoseRewardCount_.AddEntriesFrom(ref input, _repeated_battleLoseRewardCount_codec);
				break;
			case 16u:
			case 18u:
				battleLoseRewardId_.AddEntriesFrom(ref input, _repeated_battleLoseRewardId_codec);
				break;
			case 40u:
			case 42u:
				battleWinRewardId_.AddEntriesFrom(ref input, _repeated_battleWinRewardId_codec);
				break;
			case 56u:
				GroupId = input.ReadInt32();
				break;
			case 66u:
				IconSpriteName = input.ReadString();
				break;
			case 72u:
				Id = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				battleWinRewardType_.AddEntriesFrom(ref input, _repeated_battleWinRewardType_codec);
				break;
			case 32u:
			case 34u:
				battleWinRewardCount_.AddEntriesFrom(ref input, _repeated_battleWinRewardCount_codec);
				break;
			case 144u:
			case 146u:
				seasonRewardId_.AddEntriesFrom(ref input, _repeated_seasonRewardId_codec);
				break;
			case 160u:
				SeasonStartVP = input.ReadInt32();
				break;
			case 168u:
				Vp = input.ReadInt32();
				break;
			case 176u:
				WinPoint = input.ReadInt32();
				break;
			case 152u:
			case 154u:
				seasonRewardType_.AddEntriesFrom(ref input, _repeated_seasonRewardType_codec);
				break;
			case 80u:
				IsELO = input.ReadInt32();
				break;
			case 88u:
				LosePoint = input.ReadInt32();
				break;
			case 96u:
				PromotionRewardRandomBoxId = input.ReadInt32();
				break;
			case 104u:
				PvpRanking = input.ReadInt32();
				break;
			case 112u:
				RankGroupId = input.ReadInt32();
				break;
			case 120u:
				RankGroupLocalTextId = input.ReadInt32();
				break;
			case 128u:
				RankNameLocalTextId = input.ReadInt32();
				break;
			case 136u:
			case 138u:
				seasonRewardCount_.AddEntriesFrom(ref input, _repeated_seasonRewardCount_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
