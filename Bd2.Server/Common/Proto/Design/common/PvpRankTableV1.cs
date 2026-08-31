using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PvpRankTableV1 : IMessage<PvpRankTableV1>, IMessage, IEquatable<PvpRankTableV1>, IDeepCloneable<PvpRankTableV1>, IBufferMessage
{
	private static readonly MessageParser<PvpRankTableV1> _parser = new MessageParser<PvpRankTableV1>(() => new PvpRankTableV1());

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

	public const int IconSpriteNameFieldNumber = 7;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 8;

	private int id_;

	public const int LosePointFieldNumber = 9;

	private int losePoint_;

	public const int PromotionRewardCountFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_promotionRewardCount_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> promotionRewardCount_ = new RepeatedField<int>();

	public const int PromotionRewardIdFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_promotionRewardId_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> promotionRewardId_ = new RepeatedField<int>();

	public const int PromotionRewardTypeFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_promotionRewardType_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> promotionRewardType_ = new RepeatedField<int>();

	public const int PvpRankingFieldNumber = 13;

	private int pvpRanking_;

	public const int RankNameLocalTextIdFieldNumber = 14;

	private int rankNameLocalTextId_;

	public const int SeasonRewardCountFieldNumber = 15;

	private static readonly FieldCodec<int> _repeated_seasonRewardCount_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> seasonRewardCount_ = new RepeatedField<int>();

	public const int SeasonRewardIdFieldNumber = 16;

	private static readonly FieldCodec<int> _repeated_seasonRewardId_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> seasonRewardId_ = new RepeatedField<int>();

	public const int SeasonRewardTypeFieldNumber = 17;

	private static readonly FieldCodec<int> _repeated_seasonRewardType_codec = FieldCodec.ForInt32(138u);

	private readonly RepeatedField<int> seasonRewardType_ = new RepeatedField<int>();

	public const int SeasonStartVPFieldNumber = 18;

	private int seasonStartVP_;

	public const int VpFieldNumber = 19;

	private int vp_;

	public const int WinPointFieldNumber = 20;

	private int winPoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpRankTableV1> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpRankTableV1Reflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleLoseRewardCount => battleLoseRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleLoseRewardId => battleLoseRewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BattleLoseRewardType => battleLoseRewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BattleWinRewardCount => battleWinRewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BattleWinRewardId => battleWinRewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BattleWinRewardType => battleWinRewardType_;

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
	public RepeatedField<int> PromotionRewardCount => promotionRewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PromotionRewardId => promotionRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> PromotionRewardType => promotionRewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SeasonRewardType => seasonRewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpRankTableV1()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpRankTableV1(PvpRankTableV1 other)
		: this()
	{
		battleLoseRewardCount_ = other.battleLoseRewardCount_.Clone();
		battleLoseRewardId_ = other.battleLoseRewardId_.Clone();
		battleLoseRewardType_ = other.battleLoseRewardType_.Clone();
		battleWinRewardCount_ = other.battleWinRewardCount_.Clone();
		battleWinRewardId_ = other.battleWinRewardId_.Clone();
		battleWinRewardType_ = other.battleWinRewardType_.Clone();
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		losePoint_ = other.losePoint_;
		promotionRewardCount_ = other.promotionRewardCount_.Clone();
		promotionRewardId_ = other.promotionRewardId_.Clone();
		promotionRewardType_ = other.promotionRewardType_.Clone();
		pvpRanking_ = other.pvpRanking_;
		rankNameLocalTextId_ = other.rankNameLocalTextId_;
		seasonRewardCount_ = other.seasonRewardCount_.Clone();
		seasonRewardId_ = other.seasonRewardId_.Clone();
		seasonRewardType_ = other.seasonRewardType_.Clone();
		seasonStartVP_ = other.seasonStartVP_;
		vp_ = other.vp_;
		winPoint_ = other.winPoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpRankTableV1 Clone()
	{
		return new PvpRankTableV1(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpRankTableV1);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpRankTableV1 other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (battleLoseRewardCount_.Equals(other.battleLoseRewardCount_) && battleLoseRewardId_.Equals(other.battleLoseRewardId_) && battleLoseRewardType_.Equals(other.battleLoseRewardType_) && battleWinRewardCount_.Equals(other.battleWinRewardCount_) && battleWinRewardId_.Equals(other.battleWinRewardId_) && battleWinRewardType_.Equals(other.battleWinRewardType_) && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && LosePoint == other.LosePoint && promotionRewardCount_.Equals(other.promotionRewardCount_) && promotionRewardId_.Equals(other.promotionRewardId_) && promotionRewardType_.Equals(other.promotionRewardType_) && PvpRanking == other.PvpRanking && RankNameLocalTextId == other.RankNameLocalTextId && seasonRewardCount_.Equals(other.seasonRewardCount_) && seasonRewardId_.Equals(other.seasonRewardId_) && seasonRewardType_.Equals(other.seasonRewardType_) && SeasonStartVP == other.SeasonStartVP && Vp == other.Vp && WinPoint == other.WinPoint)
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
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LosePoint != 0)
		{
			num ^= LosePoint.GetHashCode();
		}
		num ^= promotionRewardCount_.GetHashCode();
		num ^= promotionRewardId_.GetHashCode();
		num ^= promotionRewardType_.GetHashCode();
		if (PvpRanking != 0)
		{
			num ^= PvpRanking.GetHashCode();
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
		battleLoseRewardCount_.WriteTo(ref output, _repeated_battleLoseRewardCount_codec);
		battleLoseRewardId_.WriteTo(ref output, _repeated_battleLoseRewardId_codec);
		battleLoseRewardType_.WriteTo(ref output, _repeated_battleLoseRewardType_codec);
		battleWinRewardCount_.WriteTo(ref output, _repeated_battleWinRewardCount_codec);
		battleWinRewardId_.WriteTo(ref output, _repeated_battleWinRewardId_codec);
		battleWinRewardType_.WriteTo(ref output, _repeated_battleWinRewardType_codec);
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (LosePoint != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(LosePoint);
		}
		promotionRewardCount_.WriteTo(ref output, _repeated_promotionRewardCount_codec);
		promotionRewardId_.WriteTo(ref output, _repeated_promotionRewardId_codec);
		promotionRewardType_.WriteTo(ref output, _repeated_promotionRewardType_codec);
		if (PvpRanking != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PvpRanking);
		}
		if (RankNameLocalTextId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(RankNameLocalTextId);
		}
		seasonRewardCount_.WriteTo(ref output, _repeated_seasonRewardCount_codec);
		seasonRewardId_.WriteTo(ref output, _repeated_seasonRewardId_codec);
		seasonRewardType_.WriteTo(ref output, _repeated_seasonRewardType_codec);
		if (SeasonStartVP != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(SeasonStartVP);
		}
		if (Vp != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(Vp);
		}
		if (WinPoint != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(WinPoint);
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
		num += battleLoseRewardCount_.CalculateSize(_repeated_battleLoseRewardCount_codec);
		num += battleLoseRewardId_.CalculateSize(_repeated_battleLoseRewardId_codec);
		num += battleLoseRewardType_.CalculateSize(_repeated_battleLoseRewardType_codec);
		num += battleWinRewardCount_.CalculateSize(_repeated_battleWinRewardCount_codec);
		num += battleWinRewardId_.CalculateSize(_repeated_battleWinRewardId_codec);
		num += battleWinRewardType_.CalculateSize(_repeated_battleWinRewardType_codec);
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LosePoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LosePoint);
		}
		num += promotionRewardCount_.CalculateSize(_repeated_promotionRewardCount_codec);
		num += promotionRewardId_.CalculateSize(_repeated_promotionRewardId_codec);
		num += promotionRewardType_.CalculateSize(_repeated_promotionRewardType_codec);
		if (PvpRanking != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PvpRanking);
		}
		if (RankNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RankNameLocalTextId);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpRankTableV1 other)
	{
		if (other != null)
		{
			battleLoseRewardCount_.Add(other.battleLoseRewardCount_);
			battleLoseRewardId_.Add(other.battleLoseRewardId_);
			battleLoseRewardType_.Add(other.battleLoseRewardType_);
			battleWinRewardCount_.Add(other.battleWinRewardCount_);
			battleWinRewardId_.Add(other.battleWinRewardId_);
			battleWinRewardType_.Add(other.battleWinRewardType_);
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LosePoint != 0)
			{
				LosePoint = other.LosePoint;
			}
			promotionRewardCount_.Add(other.promotionRewardCount_);
			promotionRewardId_.Add(other.promotionRewardId_);
			promotionRewardType_.Add(other.promotionRewardType_);
			if (other.PvpRanking != 0)
			{
				PvpRanking = other.PvpRanking;
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
			case 88u:
			case 90u:
				promotionRewardId_.AddEntriesFrom(ref input, _repeated_promotionRewardId_codec);
				break;
			case 104u:
				PvpRanking = input.ReadInt32();
				break;
			case 112u:
				RankNameLocalTextId = input.ReadInt32();
				break;
			case 96u:
			case 98u:
				promotionRewardType_.AddEntriesFrom(ref input, _repeated_promotionRewardType_codec);
				break;
			case 128u:
			case 130u:
				seasonRewardId_.AddEntriesFrom(ref input, _repeated_seasonRewardId_codec);
				break;
			case 144u:
				SeasonStartVP = input.ReadInt32();
				break;
			case 152u:
				Vp = input.ReadInt32();
				break;
			case 160u:
				WinPoint = input.ReadInt32();
				break;
			case 136u:
			case 138u:
				seasonRewardType_.AddEntriesFrom(ref input, _repeated_seasonRewardType_codec);
				break;
			case 120u:
			case 122u:
				seasonRewardCount_.AddEntriesFrom(ref input, _repeated_seasonRewardCount_codec);
				break;
			case 8u:
			case 10u:
				battleLoseRewardCount_.AddEntriesFrom(ref input, _repeated_battleLoseRewardCount_codec);
				break;
			case 16u:
			case 18u:
				battleLoseRewardId_.AddEntriesFrom(ref input, _repeated_battleLoseRewardId_codec);
				break;
			case 24u:
			case 26u:
				battleLoseRewardType_.AddEntriesFrom(ref input, _repeated_battleLoseRewardType_codec);
				break;
			case 32u:
			case 34u:
				battleWinRewardCount_.AddEntriesFrom(ref input, _repeated_battleWinRewardCount_codec);
				break;
			case 40u:
			case 42u:
				battleWinRewardId_.AddEntriesFrom(ref input, _repeated_battleWinRewardId_codec);
				break;
			case 48u:
			case 50u:
				battleWinRewardType_.AddEntriesFrom(ref input, _repeated_battleWinRewardType_codec);
				break;
			case 58u:
				IconSpriteName = input.ReadString();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 72u:
				LosePoint = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 80u:
			case 82u:
				promotionRewardCount_.AddEntriesFrom(ref input, _repeated_promotionRewardCount_codec);
				break;
			}
		}
	}
}
