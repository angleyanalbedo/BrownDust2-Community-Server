using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLDefaultTable : IMessage<RLDefaultTable>, IMessage, IEquatable<RLDefaultTable>, IDeepCloneable<RLDefaultTable>, IBufferMessage
{
	private static readonly MessageParser<RLDefaultTable> _parser = new MessageParser<RLDefaultTable>(() => new RLDefaultTable());

	private UnknownFieldSet _unknownFields;

	public const int BossRoomFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_bossRoom_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> bossRoom_ = new RepeatedField<int>();

	public const int CharGrowthFieldNumber = 2;

	private int charGrowth_;

	public const int CharLevelFieldNumber = 3;

	private int charLevel_;

	public const int CostumeSlot1OptionFieldNumber = 4;

	private int costumeSlot1Option_;

	public const int CostumeSlot2OptionFieldNumber = 5;

	private int costumeSlot2Option_;

	public const int CostumeSlot3OptionFieldNumber = 6;

	private int costumeSlot3Option_;

	public const int CostumeSlot4OptionFieldNumber = 7;

	private int costumeSlot4Option_;

	public const int EnemyStatusRateFieldNumber = 8;

	private double enemyStatusRate_;

	public const int EntryBuyPriceFieldNumber = 9;

	private int entryBuyPrice_;

	public const int FloorCountFieldNumber = 10;

	private int floorCount_;

	public const int FloorIdFieldNumber = 11;

	private int floorId_;

	public const int GiveUpPenaltyFieldNumber = 12;

	private double giveUpPenalty_;

	public const int IdFieldNumber = 13;

	private int id_;

	public const int InterestFieldNumber = 14;

	private double interest_;

	public const int MemberChangeSPFieldNumber = 15;

	private int memberChangeSP_;

	public const int ObsidianChangeRateFieldNumber = 16;

	private double obsidianChangeRate_;

	public const int RoguelikeApCountFieldNumber = 17;

	private int roguelikeApCount_;

	public const int RoguelikeCurrencyFieldNumber = 18;

	private int roguelikeCurrency_;

	public const int RoguelikeGrowthCurrencyFieldNumber = 19;

	private int roguelikeGrowthCurrency_;

	public const int RoomRatioFieldNumber = 20;

	private int roomRatio_;

	public const int SeasonDefaultLostGoldFieldNumber = 21;

	private int seasonDefaultLostGold_;

	public const int SeasonDefaultObsidianFieldNumber = 22;

	private int seasonDefaultObsidian_;

	public const int ShopCharCostumePriceFieldNumber = 23;

	private int shopCharCostumePrice_;

	public const int ShopDiscountRateFieldNumber = 24;

	private double shopDiscountRate_;

	public const int ShopHealPriceFieldNumber = 25;

	private int shopHealPrice_;

	public const int ShopHealRateFieldNumber = 26;

	private int shopHealRate_;

	public const int ShopRerollExpensiveFieldNumber = 27;

	private int shopRerollExpensive_;

	public const int ShopRerollPriceFieldNumber = 28;

	private int shopRerollPrice_;

	public const int StartCostumeCountFieldNumber = 29;

	private int startCostumeCount_;

	public const int StartGoldFieldNumber = 30;

	private int startGold_;

	public const int StartRerollFieldNumber = 31;

	private int startReroll_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RLDefaultTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RLDefaultTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BossRoom => bossRoom_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CharGrowth
	{
		get
		{
			return charGrowth_;
		}
		set
		{
			charGrowth_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CharLevel
	{
		get
		{
			return charLevel_;
		}
		set
		{
			charLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeSlot1Option
	{
		get
		{
			return costumeSlot1Option_;
		}
		set
		{
			costumeSlot1Option_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeSlot2Option
	{
		get
		{
			return costumeSlot2Option_;
		}
		set
		{
			costumeSlot2Option_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CostumeSlot3Option
	{
		get
		{
			return costumeSlot3Option_;
		}
		set
		{
			costumeSlot3Option_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeSlot4Option
	{
		get
		{
			return costumeSlot4Option_;
		}
		set
		{
			costumeSlot4Option_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double EnemyStatusRate
	{
		get
		{
			return enemyStatusRate_;
		}
		set
		{
			enemyStatusRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EntryBuyPrice
	{
		get
		{
			return entryBuyPrice_;
		}
		set
		{
			entryBuyPrice_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FloorCount
	{
		get
		{
			return floorCount_;
		}
		set
		{
			floorCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double GiveUpPenalty
	{
		get
		{
			return giveUpPenalty_;
		}
		set
		{
			giveUpPenalty_ = value;
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
	public double Interest
	{
		get
		{
			return interest_;
		}
		set
		{
			interest_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MemberChangeSP
	{
		get
		{
			return memberChangeSP_;
		}
		set
		{
			memberChangeSP_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double ObsidianChangeRate
	{
		get
		{
			return obsidianChangeRate_;
		}
		set
		{
			obsidianChangeRate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RoguelikeApCount
	{
		get
		{
			return roguelikeApCount_;
		}
		set
		{
			roguelikeApCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RoguelikeCurrency
	{
		get
		{
			return roguelikeCurrency_;
		}
		set
		{
			roguelikeCurrency_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RoguelikeGrowthCurrency
	{
		get
		{
			return roguelikeGrowthCurrency_;
		}
		set
		{
			roguelikeGrowthCurrency_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RoomRatio
	{
		get
		{
			return roomRatio_;
		}
		set
		{
			roomRatio_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SeasonDefaultLostGold
	{
		get
		{
			return seasonDefaultLostGold_;
		}
		set
		{
			seasonDefaultLostGold_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SeasonDefaultObsidian
	{
		get
		{
			return seasonDefaultObsidian_;
		}
		set
		{
			seasonDefaultObsidian_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShopCharCostumePrice
	{
		get
		{
			return shopCharCostumePrice_;
		}
		set
		{
			shopCharCostumePrice_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ShopDiscountRate
	{
		get
		{
			return shopDiscountRate_;
		}
		set
		{
			shopDiscountRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShopHealPrice
	{
		get
		{
			return shopHealPrice_;
		}
		set
		{
			shopHealPrice_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShopHealRate
	{
		get
		{
			return shopHealRate_;
		}
		set
		{
			shopHealRate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ShopRerollExpensive
	{
		get
		{
			return shopRerollExpensive_;
		}
		set
		{
			shopRerollExpensive_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ShopRerollPrice
	{
		get
		{
			return shopRerollPrice_;
		}
		set
		{
			shopRerollPrice_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StartCostumeCount
	{
		get
		{
			return startCostumeCount_;
		}
		set
		{
			startCostumeCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StartGold
	{
		get
		{
			return startGold_;
		}
		set
		{
			startGold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StartReroll
	{
		get
		{
			return startReroll_;
		}
		set
		{
			startReroll_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLDefaultTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLDefaultTable(RLDefaultTable other)
		: this()
	{
		bossRoom_ = other.bossRoom_.Clone();
		charGrowth_ = other.charGrowth_;
		charLevel_ = other.charLevel_;
		costumeSlot1Option_ = other.costumeSlot1Option_;
		costumeSlot2Option_ = other.costumeSlot2Option_;
		costumeSlot3Option_ = other.costumeSlot3Option_;
		costumeSlot4Option_ = other.costumeSlot4Option_;
		enemyStatusRate_ = other.enemyStatusRate_;
		entryBuyPrice_ = other.entryBuyPrice_;
		floorCount_ = other.floorCount_;
		floorId_ = other.floorId_;
		giveUpPenalty_ = other.giveUpPenalty_;
		id_ = other.id_;
		interest_ = other.interest_;
		memberChangeSP_ = other.memberChangeSP_;
		obsidianChangeRate_ = other.obsidianChangeRate_;
		roguelikeApCount_ = other.roguelikeApCount_;
		roguelikeCurrency_ = other.roguelikeCurrency_;
		roguelikeGrowthCurrency_ = other.roguelikeGrowthCurrency_;
		roomRatio_ = other.roomRatio_;
		seasonDefaultLostGold_ = other.seasonDefaultLostGold_;
		seasonDefaultObsidian_ = other.seasonDefaultObsidian_;
		shopCharCostumePrice_ = other.shopCharCostumePrice_;
		shopDiscountRate_ = other.shopDiscountRate_;
		shopHealPrice_ = other.shopHealPrice_;
		shopHealRate_ = other.shopHealRate_;
		shopRerollExpensive_ = other.shopRerollExpensive_;
		shopRerollPrice_ = other.shopRerollPrice_;
		startCostumeCount_ = other.startCostumeCount_;
		startGold_ = other.startGold_;
		startReroll_ = other.startReroll_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLDefaultTable Clone()
	{
		return new RLDefaultTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as RLDefaultTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RLDefaultTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (bossRoom_.Equals(other.bossRoom_) && CharGrowth == other.CharGrowth && CharLevel == other.CharLevel && CostumeSlot1Option == other.CostumeSlot1Option && CostumeSlot2Option == other.CostumeSlot2Option && CostumeSlot3Option == other.CostumeSlot3Option && CostumeSlot4Option == other.CostumeSlot4Option && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(EnemyStatusRate, other.EnemyStatusRate) && EntryBuyPrice == other.EntryBuyPrice && FloorCount == other.FloorCount && FloorId == other.FloorId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GiveUpPenalty, other.GiveUpPenalty) && Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Interest, other.Interest) && MemberChangeSP == other.MemberChangeSP && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ObsidianChangeRate, other.ObsidianChangeRate) && RoguelikeApCount == other.RoguelikeApCount && RoguelikeCurrency == other.RoguelikeCurrency && RoguelikeGrowthCurrency == other.RoguelikeGrowthCurrency && RoomRatio == other.RoomRatio && SeasonDefaultLostGold == other.SeasonDefaultLostGold && SeasonDefaultObsidian == other.SeasonDefaultObsidian && ShopCharCostumePrice == other.ShopCharCostumePrice && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ShopDiscountRate, other.ShopDiscountRate) && ShopHealPrice == other.ShopHealPrice && ShopHealRate == other.ShopHealRate && ShopRerollExpensive == other.ShopRerollExpensive && ShopRerollPrice == other.ShopRerollPrice && StartCostumeCount == other.StartCostumeCount && StartGold == other.StartGold && StartReroll == other.StartReroll)
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
		num ^= bossRoom_.GetHashCode();
		if (CharGrowth != 0)
		{
			num ^= CharGrowth.GetHashCode();
		}
		if (CharLevel != 0)
		{
			num ^= CharLevel.GetHashCode();
		}
		if (CostumeSlot1Option != 0)
		{
			num ^= CostumeSlot1Option.GetHashCode();
		}
		if (CostumeSlot2Option != 0)
		{
			num ^= CostumeSlot2Option.GetHashCode();
		}
		if (CostumeSlot3Option != 0)
		{
			num ^= CostumeSlot3Option.GetHashCode();
		}
		if (CostumeSlot4Option != 0)
		{
			num ^= CostumeSlot4Option.GetHashCode();
		}
		if (EnemyStatusRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(EnemyStatusRate);
		}
		if (EntryBuyPrice != 0)
		{
			num ^= EntryBuyPrice.GetHashCode();
		}
		if (FloorCount != 0)
		{
			num ^= FloorCount.GetHashCode();
		}
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		if (GiveUpPenalty != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GiveUpPenalty);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Interest != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Interest);
		}
		if (MemberChangeSP != 0)
		{
			num ^= MemberChangeSP.GetHashCode();
		}
		if (ObsidianChangeRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ObsidianChangeRate);
		}
		if (RoguelikeApCount != 0)
		{
			num ^= RoguelikeApCount.GetHashCode();
		}
		if (RoguelikeCurrency != 0)
		{
			num ^= RoguelikeCurrency.GetHashCode();
		}
		if (RoguelikeGrowthCurrency != 0)
		{
			num ^= RoguelikeGrowthCurrency.GetHashCode();
		}
		if (RoomRatio != 0)
		{
			num ^= RoomRatio.GetHashCode();
		}
		if (SeasonDefaultLostGold != 0)
		{
			num ^= SeasonDefaultLostGold.GetHashCode();
		}
		if (SeasonDefaultObsidian != 0)
		{
			num ^= SeasonDefaultObsidian.GetHashCode();
		}
		if (ShopCharCostumePrice != 0)
		{
			num ^= ShopCharCostumePrice.GetHashCode();
		}
		if (ShopDiscountRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ShopDiscountRate);
		}
		if (ShopHealPrice != 0)
		{
			num ^= ShopHealPrice.GetHashCode();
		}
		if (ShopHealRate != 0)
		{
			num ^= ShopHealRate.GetHashCode();
		}
		if (ShopRerollExpensive != 0)
		{
			num ^= ShopRerollExpensive.GetHashCode();
		}
		if (ShopRerollPrice != 0)
		{
			num ^= ShopRerollPrice.GetHashCode();
		}
		if (StartCostumeCount != 0)
		{
			num ^= StartCostumeCount.GetHashCode();
		}
		if (StartGold != 0)
		{
			num ^= StartGold.GetHashCode();
		}
		if (StartReroll != 0)
		{
			num ^= StartReroll.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		bossRoom_.WriteTo(ref output, _repeated_bossRoom_codec);
		if (CharGrowth != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CharGrowth);
		}
		if (CharLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CharLevel);
		}
		if (CostumeSlot1Option != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CostumeSlot1Option);
		}
		if (CostumeSlot2Option != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CostumeSlot2Option);
		}
		if (CostumeSlot3Option != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CostumeSlot3Option);
		}
		if (CostumeSlot4Option != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CostumeSlot4Option);
		}
		if (EnemyStatusRate != 0.0)
		{
			output.WriteRawTag(65);
			output.WriteDouble(EnemyStatusRate);
		}
		if (EntryBuyPrice != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(EntryBuyPrice);
		}
		if (FloorCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(FloorCount);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(FloorId);
		}
		if (GiveUpPenalty != 0.0)
		{
			output.WriteRawTag(97);
			output.WriteDouble(GiveUpPenalty);
		}
		if (Id != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(Id);
		}
		if (Interest != 0.0)
		{
			output.WriteRawTag(113);
			output.WriteDouble(Interest);
		}
		if (MemberChangeSP != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(MemberChangeSP);
		}
		if (ObsidianChangeRate != 0.0)
		{
			output.WriteRawTag(129, 1);
			output.WriteDouble(ObsidianChangeRate);
		}
		if (RoguelikeApCount != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(RoguelikeApCount);
		}
		if (RoguelikeCurrency != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(RoguelikeCurrency);
		}
		if (RoguelikeGrowthCurrency != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(RoguelikeGrowthCurrency);
		}
		if (RoomRatio != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(RoomRatio);
		}
		if (SeasonDefaultLostGold != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(SeasonDefaultLostGold);
		}
		if (SeasonDefaultObsidian != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(SeasonDefaultObsidian);
		}
		if (ShopCharCostumePrice != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(ShopCharCostumePrice);
		}
		if (ShopDiscountRate != 0.0)
		{
			output.WriteRawTag(193, 1);
			output.WriteDouble(ShopDiscountRate);
		}
		if (ShopHealPrice != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(ShopHealPrice);
		}
		if (ShopHealRate != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(ShopHealRate);
		}
		if (ShopRerollExpensive != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(ShopRerollExpensive);
		}
		if (ShopRerollPrice != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(ShopRerollPrice);
		}
		if (StartCostumeCount != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(StartCostumeCount);
		}
		if (StartGold != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(StartGold);
		}
		if (StartReroll != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(StartReroll);
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
		num += bossRoom_.CalculateSize(_repeated_bossRoom_codec);
		if (CharGrowth != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharGrowth);
		}
		if (CharLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharLevel);
		}
		if (CostumeSlot1Option != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeSlot1Option);
		}
		if (CostumeSlot2Option != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeSlot2Option);
		}
		if (CostumeSlot3Option != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeSlot3Option);
		}
		if (CostumeSlot4Option != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeSlot4Option);
		}
		if (EnemyStatusRate != 0.0)
		{
			num += 9;
		}
		if (EntryBuyPrice != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EntryBuyPrice);
		}
		if (FloorCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FloorCount);
		}
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FloorId);
		}
		if (GiveUpPenalty != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Interest != 0.0)
		{
			num += 9;
		}
		if (MemberChangeSP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MemberChangeSP);
		}
		if (ObsidianChangeRate != 0.0)
		{
			num += 10;
		}
		if (RoguelikeApCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RoguelikeApCount);
		}
		if (RoguelikeCurrency != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RoguelikeCurrency);
		}
		if (RoguelikeGrowthCurrency != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RoguelikeGrowthCurrency);
		}
		if (RoomRatio != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RoomRatio);
		}
		if (SeasonDefaultLostGold != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SeasonDefaultLostGold);
		}
		if (SeasonDefaultObsidian != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SeasonDefaultObsidian);
		}
		if (ShopCharCostumePrice != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShopCharCostumePrice);
		}
		if (ShopDiscountRate != 0.0)
		{
			num += 10;
		}
		if (ShopHealPrice != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShopHealPrice);
		}
		if (ShopHealRate != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShopHealRate);
		}
		if (ShopRerollExpensive != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShopRerollExpensive);
		}
		if (ShopRerollPrice != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShopRerollPrice);
		}
		if (StartCostumeCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StartCostumeCount);
		}
		if (StartGold != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StartGold);
		}
		if (StartReroll != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StartReroll);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RLDefaultTable other)
	{
		if (other != null)
		{
			bossRoom_.Add(other.bossRoom_);
			if (other.CharGrowth != 0)
			{
				CharGrowth = other.CharGrowth;
			}
			if (other.CharLevel != 0)
			{
				CharLevel = other.CharLevel;
			}
			if (other.CostumeSlot1Option != 0)
			{
				CostumeSlot1Option = other.CostumeSlot1Option;
			}
			if (other.CostumeSlot2Option != 0)
			{
				CostumeSlot2Option = other.CostumeSlot2Option;
			}
			if (other.CostumeSlot3Option != 0)
			{
				CostumeSlot3Option = other.CostumeSlot3Option;
			}
			if (other.CostumeSlot4Option != 0)
			{
				CostumeSlot4Option = other.CostumeSlot4Option;
			}
			if (other.EnemyStatusRate != 0.0)
			{
				EnemyStatusRate = other.EnemyStatusRate;
			}
			if (other.EntryBuyPrice != 0)
			{
				EntryBuyPrice = other.EntryBuyPrice;
			}
			if (other.FloorCount != 0)
			{
				FloorCount = other.FloorCount;
			}
			if (other.FloorId != 0)
			{
				FloorId = other.FloorId;
			}
			if (other.GiveUpPenalty != 0.0)
			{
				GiveUpPenalty = other.GiveUpPenalty;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Interest != 0.0)
			{
				Interest = other.Interest;
			}
			if (other.MemberChangeSP != 0)
			{
				MemberChangeSP = other.MemberChangeSP;
			}
			if (other.ObsidianChangeRate != 0.0)
			{
				ObsidianChangeRate = other.ObsidianChangeRate;
			}
			if (other.RoguelikeApCount != 0)
			{
				RoguelikeApCount = other.RoguelikeApCount;
			}
			if (other.RoguelikeCurrency != 0)
			{
				RoguelikeCurrency = other.RoguelikeCurrency;
			}
			if (other.RoguelikeGrowthCurrency != 0)
			{
				RoguelikeGrowthCurrency = other.RoguelikeGrowthCurrency;
			}
			if (other.RoomRatio != 0)
			{
				RoomRatio = other.RoomRatio;
			}
			if (other.SeasonDefaultLostGold != 0)
			{
				SeasonDefaultLostGold = other.SeasonDefaultLostGold;
			}
			if (other.SeasonDefaultObsidian != 0)
			{
				SeasonDefaultObsidian = other.SeasonDefaultObsidian;
			}
			if (other.ShopCharCostumePrice != 0)
			{
				ShopCharCostumePrice = other.ShopCharCostumePrice;
			}
			if (other.ShopDiscountRate != 0.0)
			{
				ShopDiscountRate = other.ShopDiscountRate;
			}
			if (other.ShopHealPrice != 0)
			{
				ShopHealPrice = other.ShopHealPrice;
			}
			if (other.ShopHealRate != 0)
			{
				ShopHealRate = other.ShopHealRate;
			}
			if (other.ShopRerollExpensive != 0)
			{
				ShopRerollExpensive = other.ShopRerollExpensive;
			}
			if (other.ShopRerollPrice != 0)
			{
				ShopRerollPrice = other.ShopRerollPrice;
			}
			if (other.StartCostumeCount != 0)
			{
				StartCostumeCount = other.StartCostumeCount;
			}
			if (other.StartGold != 0)
			{
				StartGold = other.StartGold;
			}
			if (other.StartReroll != 0)
			{
				StartReroll = other.StartReroll;
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
			case 10u:
				bossRoom_.AddEntriesFrom(ref input, _repeated_bossRoom_codec);
				break;
			case 16u:
				CharGrowth = input.ReadInt32();
				break;
			case 24u:
				CharLevel = input.ReadInt32();
				break;
			case 32u:
				CostumeSlot1Option = input.ReadInt32();
				break;
			case 40u:
				CostumeSlot2Option = input.ReadInt32();
				break;
			case 48u:
				CostumeSlot3Option = input.ReadInt32();
				break;
			case 56u:
				CostumeSlot4Option = input.ReadInt32();
				break;
			case 65u:
				EnemyStatusRate = input.ReadDouble();
				break;
			case 72u:
				EntryBuyPrice = input.ReadInt32();
				break;
			case 80u:
				FloorCount = input.ReadInt32();
				break;
			case 88u:
				FloorId = input.ReadInt32();
				break;
			case 97u:
				GiveUpPenalty = input.ReadDouble();
				break;
			case 104u:
				Id = input.ReadInt32();
				break;
			case 113u:
				Interest = input.ReadDouble();
				break;
			case 120u:
				MemberChangeSP = input.ReadInt32();
				break;
			case 129u:
				ObsidianChangeRate = input.ReadDouble();
				break;
			case 136u:
				RoguelikeApCount = input.ReadInt32();
				break;
			case 144u:
				RoguelikeCurrency = input.ReadInt32();
				break;
			case 152u:
				RoguelikeGrowthCurrency = input.ReadInt32();
				break;
			case 160u:
				RoomRatio = input.ReadInt32();
				break;
			case 168u:
				SeasonDefaultLostGold = input.ReadInt32();
				break;
			case 176u:
				SeasonDefaultObsidian = input.ReadInt32();
				break;
			case 184u:
				ShopCharCostumePrice = input.ReadInt32();
				break;
			case 193u:
				ShopDiscountRate = input.ReadDouble();
				break;
			case 200u:
				ShopHealPrice = input.ReadInt32();
				break;
			case 208u:
				ShopHealRate = input.ReadInt32();
				break;
			case 216u:
				ShopRerollExpensive = input.ReadInt32();
				break;
			case 224u:
				ShopRerollPrice = input.ReadInt32();
				break;
			case 232u:
				StartCostumeCount = input.ReadInt32();
				break;
			case 240u:
				StartGold = input.ReadInt32();
				break;
			case 248u:
				StartReroll = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
