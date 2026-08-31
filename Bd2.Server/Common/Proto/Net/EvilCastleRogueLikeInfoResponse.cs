using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeInfoResponse : IMessage<EvilCastleRogueLikeInfoResponse>, IMessage, IEquatable<EvilCastleRogueLikeInfoResponse>, IDeepCloneable<EvilCastleRogueLikeInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeInfoResponse> _parser = new MessageParser<EvilCastleRogueLikeInfoResponse>(() => new EvilCastleRogueLikeInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int StateInfoFieldNumber = 1;

	private EvilCastleRogueLikeStateInfo stateInfo_;

	public const int LevelFieldNumber = 2;

	private int level_;

	public const int FloorInfoFieldNumber = 3;

	private static readonly FieldCodec<EvilCastleRogueLikeFloorInfo> _repeated_floorInfo_codec = FieldCodec.ForMessage(26u, EvilCastleRogueLikeFloorInfo.Parser);

	private readonly RepeatedField<EvilCastleRogueLikeFloorInfo> floorInfo_ = new RepeatedField<EvilCastleRogueLikeFloorInfo>();

	public const int DeckInfoFieldNumber = 4;

	private static readonly FieldCodec<DeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(34u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> deckInfo_ = new RepeatedField<DeckDBInfo>();

	public const int CharInfoFieldNumber = 5;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(42u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int CostumeInfoFieldNumber = 6;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_costumeInfo_codec = FieldCodec.ForMessage(50u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> costumeInfo_ = new RepeatedField<CostumeDBInfo>();

	public const int RelicInfoFieldNumber = 7;

	private static readonly FieldCodec<RelicDBInfo> _repeated_relicInfo_codec = FieldCodec.ForMessage(58u, RelicDBInfo.Parser);

	private readonly RepeatedField<RelicDBInfo> relicInfo_ = new RepeatedField<RelicDBInfo>();

	public const int ChoiceInfoFieldNumber = 8;

	private EvilCastleRogueLikeChoiceInfo choiceInfo_;

	public const int ReRollFieldNumber = 9;

	private int reRoll_;

	public const int GroupIdFieldNumber = 10;

	private int groupId_;

	public const int IdFieldNumber = 11;

	private int id_;

	public const int GrowthInfoFieldNumber = 12;

	private static readonly FieldCodec<EvilCastleRogueLikeGrowthDBInfo> _repeated_growthInfo_codec = FieldCodec.ForMessage(98u, EvilCastleRogueLikeGrowthDBInfo.Parser);

	private readonly RepeatedField<EvilCastleRogueLikeGrowthDBInfo> growthInfo_ = new RepeatedField<EvilCastleRogueLikeGrowthDBInfo>();

	public const int EventInfoFieldNumber = 13;

	private EvilCastleRogueLikeEventInfo eventInfo_;

	public const int ShopInfoFieldNumber = 14;

	private EvilCastleRogueLikeShopDBInfo shopInfo_;

	public const int BattleLevelFieldNumber = 15;

	private int battleLevel_;

	public const int MaxTryLevelFieldNumber = 16;

	private int maxTryLevel_;

	public const int ObsidianFieldNumber = 17;

	private int obsidian_;

	public const int RogueLikeGoldFieldNumber = 18;

	private int rogueLikeGold_;

	public const int SeasonFieldNumber = 19;

	private int season_;

	public const int RegularSeasonFieldNumber = 20;

	private int regularSeason_;

	public const int SeasonRewardFieldNumber = 21;

	private bool seasonReward_;

	public const int MaxRewardLevelFieldNumber = 22;

	private int maxRewardLevel_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleRogueLikeInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeStateInfo StateInfo
	{
		get
		{
			return stateInfo_;
		}
		set
		{
			stateInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public RepeatedField<EvilCastleRogueLikeFloorInfo> FloorInfo => floorInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<DeckDBInfo> DeckInfo => deckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CostumeDBInfo> CostumeInfo => costumeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RelicDBInfo> RelicInfo => relicInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeChoiceInfo ChoiceInfo
	{
		get
		{
			return choiceInfo_;
		}
		set
		{
			choiceInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReRoll
	{
		get
		{
			return reRoll_;
		}
		set
		{
			reRoll_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public RepeatedField<EvilCastleRogueLikeGrowthDBInfo> GrowthInfo => growthInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeEventInfo EventInfo
	{
		get
		{
			return eventInfo_;
		}
		set
		{
			eventInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeShopDBInfo ShopInfo
	{
		get
		{
			return shopInfo_;
		}
		set
		{
			shopInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleLevel
	{
		get
		{
			return battleLevel_;
		}
		set
		{
			battleLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxTryLevel
	{
		get
		{
			return maxTryLevel_;
		}
		set
		{
			maxTryLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Obsidian
	{
		get
		{
			return obsidian_;
		}
		set
		{
			obsidian_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RegularSeason
	{
		get
		{
			return regularSeason_;
		}
		set
		{
			regularSeason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool SeasonReward
	{
		get
		{
			return seasonReward_;
		}
		set
		{
			seasonReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxRewardLevel
	{
		get
		{
			return maxRewardLevel_;
		}
		set
		{
			maxRewardLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeInfoResponse(EvilCastleRogueLikeInfoResponse other)
		: this()
	{
		stateInfo_ = ((other.stateInfo_ != null) ? other.stateInfo_.Clone() : null);
		level_ = other.level_;
		floorInfo_ = other.floorInfo_.Clone();
		deckInfo_ = other.deckInfo_.Clone();
		charInfo_ = other.charInfo_.Clone();
		costumeInfo_ = other.costumeInfo_.Clone();
		relicInfo_ = other.relicInfo_.Clone();
		choiceInfo_ = ((other.choiceInfo_ != null) ? other.choiceInfo_.Clone() : null);
		reRoll_ = other.reRoll_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		growthInfo_ = other.growthInfo_.Clone();
		eventInfo_ = ((other.eventInfo_ != null) ? other.eventInfo_.Clone() : null);
		shopInfo_ = ((other.shopInfo_ != null) ? other.shopInfo_.Clone() : null);
		battleLevel_ = other.battleLevel_;
		maxTryLevel_ = other.maxTryLevel_;
		obsidian_ = other.obsidian_;
		rogueLikeGold_ = other.rogueLikeGold_;
		season_ = other.season_;
		regularSeason_ = other.regularSeason_;
		seasonReward_ = other.seasonReward_;
		maxRewardLevel_ = other.maxRewardLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeInfoResponse Clone()
	{
		return new EvilCastleRogueLikeInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(StateInfo, other.StateInfo) && Level == other.Level && floorInfo_.Equals(other.floorInfo_) && deckInfo_.Equals(other.deckInfo_) && charInfo_.Equals(other.charInfo_) && costumeInfo_.Equals(other.costumeInfo_) && relicInfo_.Equals(other.relicInfo_) && object.Equals(ChoiceInfo, other.ChoiceInfo) && ReRoll == other.ReRoll && GroupId == other.GroupId && Id == other.Id && growthInfo_.Equals(other.growthInfo_) && object.Equals(EventInfo, other.EventInfo) && object.Equals(ShopInfo, other.ShopInfo) && BattleLevel == other.BattleLevel && MaxTryLevel == other.MaxTryLevel && Obsidian == other.Obsidian && RogueLikeGold == other.RogueLikeGold && Season == other.Season && RegularSeason == other.RegularSeason && SeasonReward == other.SeasonReward && MaxRewardLevel == other.MaxRewardLevel)
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
		if (stateInfo_ != null)
		{
			num ^= StateInfo.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= floorInfo_.GetHashCode();
		num ^= deckInfo_.GetHashCode();
		num ^= charInfo_.GetHashCode();
		num ^= costumeInfo_.GetHashCode();
		num ^= relicInfo_.GetHashCode();
		if (choiceInfo_ != null)
		{
			num ^= ChoiceInfo.GetHashCode();
		}
		if (ReRoll != 0)
		{
			num ^= ReRoll.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= growthInfo_.GetHashCode();
		if (eventInfo_ != null)
		{
			num ^= EventInfo.GetHashCode();
		}
		if (shopInfo_ != null)
		{
			num ^= ShopInfo.GetHashCode();
		}
		if (BattleLevel != 0)
		{
			num ^= BattleLevel.GetHashCode();
		}
		if (MaxTryLevel != 0)
		{
			num ^= MaxTryLevel.GetHashCode();
		}
		if (Obsidian != 0)
		{
			num ^= Obsidian.GetHashCode();
		}
		if (RogueLikeGold != 0)
		{
			num ^= RogueLikeGold.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (RegularSeason != 0)
		{
			num ^= RegularSeason.GetHashCode();
		}
		if (SeasonReward)
		{
			num ^= SeasonReward.GetHashCode();
		}
		if (MaxRewardLevel != 0)
		{
			num ^= MaxRewardLevel.GetHashCode();
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
		if (stateInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(StateInfo);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Level);
		}
		floorInfo_.WriteTo(ref output, _repeated_floorInfo_codec);
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		costumeInfo_.WriteTo(ref output, _repeated_costumeInfo_codec);
		relicInfo_.WriteTo(ref output, _repeated_relicInfo_codec);
		if (choiceInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ChoiceInfo);
		}
		if (ReRoll != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ReRoll);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Id);
		}
		growthInfo_.WriteTo(ref output, _repeated_growthInfo_codec);
		if (eventInfo_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EventInfo);
		}
		if (shopInfo_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(ShopInfo);
		}
		if (BattleLevel != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(BattleLevel);
		}
		if (MaxTryLevel != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(MaxTryLevel);
		}
		if (Obsidian != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(Obsidian);
		}
		if (RogueLikeGold != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(RogueLikeGold);
		}
		if (Season != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(Season);
		}
		if (RegularSeason != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(RegularSeason);
		}
		if (SeasonReward)
		{
			output.WriteRawTag(168, 1);
			output.WriteBool(SeasonReward);
		}
		if (MaxRewardLevel != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(MaxRewardLevel);
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
		if (stateInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StateInfo);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		num += floorInfo_.CalculateSize(_repeated_floorInfo_codec);
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += costumeInfo_.CalculateSize(_repeated_costumeInfo_codec);
		num += relicInfo_.CalculateSize(_repeated_relicInfo_codec);
		if (choiceInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChoiceInfo);
		}
		if (ReRoll != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReRoll);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += growthInfo_.CalculateSize(_repeated_growthInfo_codec);
		if (eventInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EventInfo);
		}
		if (shopInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShopInfo);
		}
		if (BattleLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleLevel);
		}
		if (MaxTryLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxTryLevel);
		}
		if (Obsidian != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Obsidian);
		}
		if (RogueLikeGold != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RogueLikeGold);
		}
		if (Season != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Season);
		}
		if (RegularSeason != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RegularSeason);
		}
		if (SeasonReward)
		{
			num += 3;
		}
		if (MaxRewardLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MaxRewardLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.stateInfo_ != null)
		{
			if (stateInfo_ == null)
			{
				StateInfo = new EvilCastleRogueLikeStateInfo();
			}
			StateInfo.MergeFrom(other.StateInfo);
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		floorInfo_.Add(other.floorInfo_);
		deckInfo_.Add(other.deckInfo_);
		charInfo_.Add(other.charInfo_);
		costumeInfo_.Add(other.costumeInfo_);
		relicInfo_.Add(other.relicInfo_);
		if (other.choiceInfo_ != null)
		{
			if (choiceInfo_ == null)
			{
				ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
			}
			ChoiceInfo.MergeFrom(other.ChoiceInfo);
		}
		if (other.ReRoll != 0)
		{
			ReRoll = other.ReRoll;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		growthInfo_.Add(other.growthInfo_);
		if (other.eventInfo_ != null)
		{
			if (eventInfo_ == null)
			{
				EventInfo = new EvilCastleRogueLikeEventInfo();
			}
			EventInfo.MergeFrom(other.EventInfo);
		}
		if (other.shopInfo_ != null)
		{
			if (shopInfo_ == null)
			{
				ShopInfo = new EvilCastleRogueLikeShopDBInfo();
			}
			ShopInfo.MergeFrom(other.ShopInfo);
		}
		if (other.BattleLevel != 0)
		{
			BattleLevel = other.BattleLevel;
		}
		if (other.MaxTryLevel != 0)
		{
			MaxTryLevel = other.MaxTryLevel;
		}
		if (other.Obsidian != 0)
		{
			Obsidian = other.Obsidian;
		}
		if (other.RogueLikeGold != 0)
		{
			RogueLikeGold = other.RogueLikeGold;
		}
		if (other.Season != 0)
		{
			Season = other.Season;
		}
		if (other.RegularSeason != 0)
		{
			RegularSeason = other.RegularSeason;
		}
		if (other.SeasonReward)
		{
			SeasonReward = other.SeasonReward;
		}
		if (other.MaxRewardLevel != 0)
		{
			MaxRewardLevel = other.MaxRewardLevel;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (stateInfo_ == null)
				{
					StateInfo = new EvilCastleRogueLikeStateInfo();
				}
				input.ReadMessage(StateInfo);
				break;
			case 16u:
				Level = input.ReadInt32();
				break;
			case 26u:
				floorInfo_.AddEntriesFrom(ref input, _repeated_floorInfo_codec);
				break;
			case 34u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 42u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 50u:
				costumeInfo_.AddEntriesFrom(ref input, _repeated_costumeInfo_codec);
				break;
			case 58u:
				relicInfo_.AddEntriesFrom(ref input, _repeated_relicInfo_codec);
				break;
			case 66u:
				if (choiceInfo_ == null)
				{
					ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
				}
				input.ReadMessage(ChoiceInfo);
				break;
			case 72u:
				ReRoll = input.ReadInt32();
				break;
			case 80u:
				GroupId = input.ReadInt32();
				break;
			case 88u:
				Id = input.ReadInt32();
				break;
			case 98u:
				growthInfo_.AddEntriesFrom(ref input, _repeated_growthInfo_codec);
				break;
			case 106u:
				if (eventInfo_ == null)
				{
					EventInfo = new EvilCastleRogueLikeEventInfo();
				}
				input.ReadMessage(EventInfo);
				break;
			case 114u:
				if (shopInfo_ == null)
				{
					ShopInfo = new EvilCastleRogueLikeShopDBInfo();
				}
				input.ReadMessage(ShopInfo);
				break;
			case 120u:
				BattleLevel = input.ReadInt32();
				break;
			case 128u:
				MaxTryLevel = input.ReadInt32();
				break;
			case 136u:
				Obsidian = input.ReadInt32();
				break;
			case 144u:
				RogueLikeGold = input.ReadInt32();
				break;
			case 152u:
				Season = input.ReadInt32();
				break;
			case 160u:
				RegularSeason = input.ReadInt32();
				break;
			case 168u:
				SeasonReward = input.ReadBool();
				break;
			case 176u:
				MaxRewardLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
