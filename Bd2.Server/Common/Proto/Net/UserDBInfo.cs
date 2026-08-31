using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class UserDBInfo : IMessage<UserDBInfo>, IMessage, IEquatable<UserDBInfo>, IDeepCloneable<UserDBInfo>, IBufferMessage
{
	private static readonly MessageParser<UserDBInfo> _parser = new MessageParser<UserDBInfo>(() => new UserDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int OwnerIndexFieldNumber = 1;

	private long ownerIndex_;

	public const int UserIdFieldNumber = 2;

	private string userId_ = "";

	public const int UserKeyFieldNumber = 3;

	private string userKey_ = "";

	public const int LastPlayPackIdFieldNumber = 4;

	private int lastPlayPackId_;

	public const int InvenSlotFieldNumber = 5;

	private int invenSlot_;

	public const int StorageSlotFieldNumber = 6;

	private int storageSlot_;

	public const int GoldFieldNumber = 7;

	private long gold_;

	public const int FreeJewelryFieldNumber = 8;

	private long freeJewelry_;

	public const int JewelryFieldNumber = 9;

	private long jewelry_;

	public const int EquipSlotFieldNumber = 10;

	private int equipSlot_;

	public const int CatalystFieldNumber = 11;

	private long catalyst_;

	public const int ExpFieldNumber = 12;

	private int exp_;

	public const int LevelRewardFieldNumber = 13;

	private int levelReward_;

	public const int PortraitCostumeIdFieldNumber = 14;

	private int portraitCostumeId_;

	public const int EquipStorageSlotFieldNumber = 15;

	private int equipStorageSlot_;

	public const int PvpTicketFieldNumber = 16;

	private int pvpTicket_;

	public const int MedalFieldNumber = 17;

	private int medal_;

	public const int EvilCastleCoinFieldNumber = 18;

	private int evilCastleCoin_;

	public const int UserTypeFieldNumber = 19;

	private int userType_;

	public const int FreeHuntingApFieldNumber = 20;

	private int freeHuntingAp_;

	public const int BonusHuntingApFieldNumber = 21;

	private int bonusHuntingAp_;

	public const int PvpTicketStackFieldNumber = 22;

	private int pvpTicketStack_;

	public const int MileageFieldNumber = 23;

	private int mileage_;

	public const int HopePowderFieldNumber = 24;

	private int hopePowder_;

	public const int UnregDateFieldNumber = 25;

	private long unregDate_;

	public const int PurchaseCountInfoFieldNumber = 26;

	private static readonly FieldCodec<PurchaseCountDBInfo> _repeated_purchaseCountInfo_codec = FieldCodec.ForMessage(210u, PurchaseCountDBInfo.Parser);

	private readonly RepeatedField<PurchaseCountDBInfo> purchaseCountInfo_ = new RepeatedField<PurchaseCountDBInfo>();

	public const int IsFirstGachaFieldNumber = 27;

	private bool isFirstGacha_;

	public const int PresetSlotFieldNumber = 28;

	private int presetSlot_;

	public const int OptimizeInfoFieldNumber = 29;

	private static readonly FieldCodec<OptimizeBaseInfo> _repeated_optimizeInfo_codec = FieldCodec.ForMessage(234u, OptimizeBaseInfo.Parser);

	private readonly RepeatedField<OptimizeBaseInfo> optimizeInfo_ = new RepeatedField<OptimizeBaseInfo>();

	public const int BlockDateFieldNumber = 30;

	private long blockDate_;

	public const int ReturnStatusEndTimeFieldNumber = 31;

	private long returnStatusEndTime_;

	public const int MyRoomSlotFieldNumber = 32;

	private int myRoomSlot_;

	public const int TotalWarPresetSlotFieldNumber = 33;

	private int totalWarPresetSlot_;

	public const int EventApFreeFieldNumber = 34;

	private int eventApFree_;

	public const int EventApStackFieldNumber = 35;

	private int eventApStack_;

	public const int FreeTorchLightApFieldNumber = 36;

	private int freeTorchLightAp_;

	public const int TorchLightApFieldNumber = 37;

	private int torchLightAp_;

	public const int JoinTimeFieldNumber = 38;

	private long joinTime_;

	public const int NewbiePassStepFieldNumber = 39;

	private int newbiePassStep_;

	public const int BlockReasonFieldNumber = 40;

	private Define_UserBlockReason blockReason_;

	public const int RogueLikeApFieldNumber = 41;

	private int rogueLikeAp_;

	public const int RogueLikeApStackFieldNumber = 42;

	private int rogueLikeApStack_;

	public const int LoginDateFieldNumber = 43;

	private long loginDate_;

	public const int GuildCoinFieldNumber = 44;

	private long guildCoin_;

	public PvpBattleUserBaseInfo PvpBattleUserInfo;

	public int Season;

	public int SeasonRewardRankId;

	public string GuildName => "";

	public int UserExpToLevel { get; private set; }

	public bool IsJoinUser { get; set; }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UserDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UserDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OwnerIndex
	{
		get
		{
			return ownerIndex_;
		}
		set
		{
			ownerIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string UserId
	{
		get
		{
			return userId_;
		}
		set
		{
			userId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string UserKey
	{
		get
		{
			return userKey_;
		}
		set
		{
			userKey_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LastPlayPackId
	{
		get
		{
			return lastPlayPackId_;
		}
		set
		{
			lastPlayPackId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int InvenSlot
	{
		get
		{
			return invenSlot_;
		}
		set
		{
			invenSlot_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StorageSlot
	{
		get
		{
			return storageSlot_;
		}
		set
		{
			storageSlot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Gold
	{
		get
		{
			return gold_;
		}
		set
		{
			gold_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long FreeJewelry
	{
		get
		{
			return freeJewelry_;
		}
		set
		{
			freeJewelry_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Jewelry
	{
		get
		{
			return jewelry_;
		}
		set
		{
			jewelry_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EquipSlot
	{
		get
		{
			return equipSlot_;
		}
		set
		{
			equipSlot_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Catalyst
	{
		get
		{
			return catalyst_;
		}
		set
		{
			catalyst_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LevelReward
	{
		get
		{
			return levelReward_;
		}
		set
		{
			levelReward_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PortraitCostumeId
	{
		get
		{
			return portraitCostumeId_;
		}
		set
		{
			portraitCostumeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EquipStorageSlot
	{
		get
		{
			return equipStorageSlot_;
		}
		set
		{
			equipStorageSlot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PvpTicket
	{
		get
		{
			return pvpTicket_;
		}
		set
		{
			pvpTicket_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Medal
	{
		get
		{
			return medal_;
		}
		set
		{
			medal_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EvilCastleCoin
	{
		get
		{
			return evilCastleCoin_;
		}
		set
		{
			evilCastleCoin_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UserType
	{
		get
		{
			return userType_;
		}
		set
		{
			userType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FreeHuntingAp
	{
		get
		{
			return freeHuntingAp_;
		}
		set
		{
			freeHuntingAp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BonusHuntingAp
	{
		get
		{
			return bonusHuntingAp_;
		}
		set
		{
			bonusHuntingAp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PvpTicketStack
	{
		get
		{
			return pvpTicketStack_;
		}
		set
		{
			pvpTicketStack_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Mileage
	{
		get
		{
			return mileage_;
		}
		set
		{
			mileage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HopePowder
	{
		get
		{
			return hopePowder_;
		}
		set
		{
			hopePowder_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UnregDate
	{
		get
		{
			return unregDate_;
		}
		set
		{
			unregDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PurchaseCountDBInfo> PurchaseCountInfo => purchaseCountInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsFirstGacha
	{
		get
		{
			return isFirstGacha_;
		}
		set
		{
			isFirstGacha_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PresetSlot
	{
		get
		{
			return presetSlot_;
		}
		set
		{
			presetSlot_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<OptimizeBaseInfo> OptimizeInfo => optimizeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BlockDate
	{
		get
		{
			return blockDate_;
		}
		set
		{
			blockDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ReturnStatusEndTime
	{
		get
		{
			return returnStatusEndTime_;
		}
		set
		{
			returnStatusEndTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MyRoomSlot
	{
		get
		{
			return myRoomSlot_;
		}
		set
		{
			myRoomSlot_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalWarPresetSlot
	{
		get
		{
			return totalWarPresetSlot_;
		}
		set
		{
			totalWarPresetSlot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventApFree
	{
		get
		{
			return eventApFree_;
		}
		set
		{
			eventApFree_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventApStack
	{
		get
		{
			return eventApStack_;
		}
		set
		{
			eventApStack_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FreeTorchLightAp
	{
		get
		{
			return freeTorchLightAp_;
		}
		set
		{
			freeTorchLightAp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TorchLightAp
	{
		get
		{
			return torchLightAp_;
		}
		set
		{
			torchLightAp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long JoinTime
	{
		get
		{
			return joinTime_;
		}
		set
		{
			joinTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NewbiePassStep
	{
		get
		{
			return newbiePassStep_;
		}
		set
		{
			newbiePassStep_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_UserBlockReason BlockReason
	{
		get
		{
			return blockReason_;
		}
		set
		{
			blockReason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RogueLikeAp
	{
		get
		{
			return rogueLikeAp_;
		}
		set
		{
			rogueLikeAp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RogueLikeApStack
	{
		get
		{
			return rogueLikeApStack_;
		}
		set
		{
			rogueLikeApStack_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long LoginDate
	{
		get
		{
			return loginDate_;
		}
		set
		{
			loginDate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long GuildCoin
	{
		get
		{
			return guildCoin_;
		}
		set
		{
			guildCoin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserDBInfo(UserDBInfo other)
		: this()
	{
		ownerIndex_ = other.ownerIndex_;
		userId_ = other.userId_;
		userKey_ = other.userKey_;
		lastPlayPackId_ = other.lastPlayPackId_;
		invenSlot_ = other.invenSlot_;
		storageSlot_ = other.storageSlot_;
		gold_ = other.gold_;
		freeJewelry_ = other.freeJewelry_;
		jewelry_ = other.jewelry_;
		equipSlot_ = other.equipSlot_;
		catalyst_ = other.catalyst_;
		exp_ = other.exp_;
		levelReward_ = other.levelReward_;
		portraitCostumeId_ = other.portraitCostumeId_;
		equipStorageSlot_ = other.equipStorageSlot_;
		pvpTicket_ = other.pvpTicket_;
		medal_ = other.medal_;
		evilCastleCoin_ = other.evilCastleCoin_;
		userType_ = other.userType_;
		freeHuntingAp_ = other.freeHuntingAp_;
		bonusHuntingAp_ = other.bonusHuntingAp_;
		pvpTicketStack_ = other.pvpTicketStack_;
		mileage_ = other.mileage_;
		hopePowder_ = other.hopePowder_;
		unregDate_ = other.unregDate_;
		purchaseCountInfo_ = other.purchaseCountInfo_.Clone();
		isFirstGacha_ = other.isFirstGacha_;
		presetSlot_ = other.presetSlot_;
		optimizeInfo_ = other.optimizeInfo_.Clone();
		blockDate_ = other.blockDate_;
		returnStatusEndTime_ = other.returnStatusEndTime_;
		myRoomSlot_ = other.myRoomSlot_;
		totalWarPresetSlot_ = other.totalWarPresetSlot_;
		eventApFree_ = other.eventApFree_;
		eventApStack_ = other.eventApStack_;
		freeTorchLightAp_ = other.freeTorchLightAp_;
		torchLightAp_ = other.torchLightAp_;
		joinTime_ = other.joinTime_;
		newbiePassStep_ = other.newbiePassStep_;
		blockReason_ = other.blockReason_;
		rogueLikeAp_ = other.rogueLikeAp_;
		rogueLikeApStack_ = other.rogueLikeApStack_;
		loginDate_ = other.loginDate_;
		guildCoin_ = other.guildCoin_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserDBInfo Clone()
	{
		return new UserDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UserDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UserDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OwnerIndex == other.OwnerIndex && !(UserId != other.UserId) && !(UserKey != other.UserKey) && LastPlayPackId == other.LastPlayPackId && InvenSlot == other.InvenSlot && StorageSlot == other.StorageSlot && Gold == other.Gold && FreeJewelry == other.FreeJewelry && Jewelry == other.Jewelry && EquipSlot == other.EquipSlot && Catalyst == other.Catalyst && Exp == other.Exp && LevelReward == other.LevelReward && PortraitCostumeId == other.PortraitCostumeId && EquipStorageSlot == other.EquipStorageSlot && PvpTicket == other.PvpTicket && Medal == other.Medal && EvilCastleCoin == other.EvilCastleCoin && UserType == other.UserType && FreeHuntingAp == other.FreeHuntingAp && BonusHuntingAp == other.BonusHuntingAp && PvpTicketStack == other.PvpTicketStack && Mileage == other.Mileage && HopePowder == other.HopePowder && UnregDate == other.UnregDate && purchaseCountInfo_.Equals(other.purchaseCountInfo_) && IsFirstGacha == other.IsFirstGacha && PresetSlot == other.PresetSlot && optimizeInfo_.Equals(other.optimizeInfo_) && BlockDate == other.BlockDate && ReturnStatusEndTime == other.ReturnStatusEndTime && MyRoomSlot == other.MyRoomSlot && TotalWarPresetSlot == other.TotalWarPresetSlot && EventApFree == other.EventApFree && EventApStack == other.EventApStack && FreeTorchLightAp == other.FreeTorchLightAp && TorchLightAp == other.TorchLightAp && JoinTime == other.JoinTime && NewbiePassStep == other.NewbiePassStep && BlockReason == other.BlockReason && RogueLikeAp == other.RogueLikeAp && RogueLikeApStack == other.RogueLikeApStack && LoginDate == other.LoginDate && GuildCoin == other.GuildCoin)
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
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (UserId.Length != 0)
		{
			num ^= UserId.GetHashCode();
		}
		if (UserKey.Length != 0)
		{
			num ^= UserKey.GetHashCode();
		}
		if (LastPlayPackId != 0)
		{
			num ^= LastPlayPackId.GetHashCode();
		}
		if (InvenSlot != 0)
		{
			num ^= InvenSlot.GetHashCode();
		}
		if (StorageSlot != 0)
		{
			num ^= StorageSlot.GetHashCode();
		}
		if (Gold != 0L)
		{
			num ^= Gold.GetHashCode();
		}
		if (FreeJewelry != 0L)
		{
			num ^= FreeJewelry.GetHashCode();
		}
		if (Jewelry != 0L)
		{
			num ^= Jewelry.GetHashCode();
		}
		if (EquipSlot != 0)
		{
			num ^= EquipSlot.GetHashCode();
		}
		if (Catalyst != 0L)
		{
			num ^= Catalyst.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (LevelReward != 0)
		{
			num ^= LevelReward.GetHashCode();
		}
		if (PortraitCostumeId != 0)
		{
			num ^= PortraitCostumeId.GetHashCode();
		}
		if (EquipStorageSlot != 0)
		{
			num ^= EquipStorageSlot.GetHashCode();
		}
		if (PvpTicket != 0)
		{
			num ^= PvpTicket.GetHashCode();
		}
		if (Medal != 0)
		{
			num ^= Medal.GetHashCode();
		}
		if (EvilCastleCoin != 0)
		{
			num ^= EvilCastleCoin.GetHashCode();
		}
		if (UserType != 0)
		{
			num ^= UserType.GetHashCode();
		}
		if (FreeHuntingAp != 0)
		{
			num ^= FreeHuntingAp.GetHashCode();
		}
		if (BonusHuntingAp != 0)
		{
			num ^= BonusHuntingAp.GetHashCode();
		}
		if (PvpTicketStack != 0)
		{
			num ^= PvpTicketStack.GetHashCode();
		}
		if (Mileage != 0)
		{
			num ^= Mileage.GetHashCode();
		}
		if (HopePowder != 0)
		{
			num ^= HopePowder.GetHashCode();
		}
		if (UnregDate != 0L)
		{
			num ^= UnregDate.GetHashCode();
		}
		num ^= purchaseCountInfo_.GetHashCode();
		if (IsFirstGacha)
		{
			num ^= IsFirstGacha.GetHashCode();
		}
		if (PresetSlot != 0)
		{
			num ^= PresetSlot.GetHashCode();
		}
		num ^= optimizeInfo_.GetHashCode();
		if (BlockDate != 0L)
		{
			num ^= BlockDate.GetHashCode();
		}
		if (ReturnStatusEndTime != 0L)
		{
			num ^= ReturnStatusEndTime.GetHashCode();
		}
		if (MyRoomSlot != 0)
		{
			num ^= MyRoomSlot.GetHashCode();
		}
		if (TotalWarPresetSlot != 0)
		{
			num ^= TotalWarPresetSlot.GetHashCode();
		}
		if (EventApFree != 0)
		{
			num ^= EventApFree.GetHashCode();
		}
		if (EventApStack != 0)
		{
			num ^= EventApStack.GetHashCode();
		}
		if (FreeTorchLightAp != 0)
		{
			num ^= FreeTorchLightAp.GetHashCode();
		}
		if (TorchLightAp != 0)
		{
			num ^= TorchLightAp.GetHashCode();
		}
		if (JoinTime != 0L)
		{
			num ^= JoinTime.GetHashCode();
		}
		if (NewbiePassStep != 0)
		{
			num ^= NewbiePassStep.GetHashCode();
		}
		if (BlockReason != Define_UserBlockReason.UserBlockReasonNone)
		{
			num ^= BlockReason.GetHashCode();
		}
		if (RogueLikeAp != 0)
		{
			num ^= RogueLikeAp.GetHashCode();
		}
		if (RogueLikeApStack != 0)
		{
			num ^= RogueLikeApStack.GetHashCode();
		}
		if (LoginDate != 0L)
		{
			num ^= LoginDate.GetHashCode();
		}
		if (GuildCoin != 0L)
		{
			num ^= GuildCoin.GetHashCode();
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
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UserId);
		}
		if (UserKey.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(UserKey);
		}
		if (LastPlayPackId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LastPlayPackId);
		}
		if (InvenSlot != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(InvenSlot);
		}
		if (StorageSlot != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(StorageSlot);
		}
		if (Gold != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(Gold);
		}
		if (FreeJewelry != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(FreeJewelry);
		}
		if (Jewelry != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(Jewelry);
		}
		if (EquipSlot != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(EquipSlot);
		}
		if (Catalyst != 0L)
		{
			output.WriteRawTag(88);
			output.WriteInt64(Catalyst);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Exp);
		}
		if (LevelReward != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(LevelReward);
		}
		if (PortraitCostumeId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(PortraitCostumeId);
		}
		if (EquipStorageSlot != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(EquipStorageSlot);
		}
		if (PvpTicket != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(PvpTicket);
		}
		if (Medal != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(Medal);
		}
		if (EvilCastleCoin != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(EvilCastleCoin);
		}
		if (UserType != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(UserType);
		}
		if (FreeHuntingAp != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(FreeHuntingAp);
		}
		if (BonusHuntingAp != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(BonusHuntingAp);
		}
		if (PvpTicketStack != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(PvpTicketStack);
		}
		if (Mileage != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(Mileage);
		}
		if (HopePowder != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(HopePowder);
		}
		if (UnregDate != 0L)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt64(UnregDate);
		}
		purchaseCountInfo_.WriteTo(ref output, _repeated_purchaseCountInfo_codec);
		if (IsFirstGacha)
		{
			output.WriteRawTag(216, 1);
			output.WriteBool(IsFirstGacha);
		}
		if (PresetSlot != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(PresetSlot);
		}
		optimizeInfo_.WriteTo(ref output, _repeated_optimizeInfo_codec);
		if (BlockDate != 0L)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt64(BlockDate);
		}
		if (ReturnStatusEndTime != 0L)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt64(ReturnStatusEndTime);
		}
		if (MyRoomSlot != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(MyRoomSlot);
		}
		if (TotalWarPresetSlot != 0)
		{
			output.WriteRawTag(136, 2);
			output.WriteInt32(TotalWarPresetSlot);
		}
		if (EventApFree != 0)
		{
			output.WriteRawTag(144, 2);
			output.WriteInt32(EventApFree);
		}
		if (EventApStack != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteInt32(EventApStack);
		}
		if (FreeTorchLightAp != 0)
		{
			output.WriteRawTag(160, 2);
			output.WriteInt32(FreeTorchLightAp);
		}
		if (TorchLightAp != 0)
		{
			output.WriteRawTag(168, 2);
			output.WriteInt32(TorchLightAp);
		}
		if (JoinTime != 0L)
		{
			output.WriteRawTag(176, 2);
			output.WriteInt64(JoinTime);
		}
		if (NewbiePassStep != 0)
		{
			output.WriteRawTag(184, 2);
			output.WriteInt32(NewbiePassStep);
		}
		if (BlockReason != Define_UserBlockReason.UserBlockReasonNone)
		{
			output.WriteRawTag(192, 2);
			output.WriteEnum((int)BlockReason);
		}
		if (RogueLikeAp != 0)
		{
			output.WriteRawTag(200, 2);
			output.WriteInt32(RogueLikeAp);
		}
		if (RogueLikeApStack != 0)
		{
			output.WriteRawTag(208, 2);
			output.WriteInt32(RogueLikeApStack);
		}
		if (LoginDate != 0L)
		{
			output.WriteRawTag(216, 2);
			output.WriteInt64(LoginDate);
		}
		if (GuildCoin != 0L)
		{
			output.WriteRawTag(224, 2);
			output.WriteInt64(GuildCoin);
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
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (UserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserId);
		}
		if (UserKey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserKey);
		}
		if (LastPlayPackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastPlayPackId);
		}
		if (InvenSlot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InvenSlot);
		}
		if (StorageSlot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StorageSlot);
		}
		if (Gold != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Gold);
		}
		if (FreeJewelry != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(FreeJewelry);
		}
		if (Jewelry != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Jewelry);
		}
		if (EquipSlot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipSlot);
		}
		if (Catalyst != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Catalyst);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Exp);
		}
		if (LevelReward != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelReward);
		}
		if (PortraitCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PortraitCostumeId);
		}
		if (EquipStorageSlot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipStorageSlot);
		}
		if (PvpTicket != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PvpTicket);
		}
		if (Medal != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Medal);
		}
		if (EvilCastleCoin != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EvilCastleCoin);
		}
		if (UserType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UserType);
		}
		if (FreeHuntingAp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FreeHuntingAp);
		}
		if (BonusHuntingAp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BonusHuntingAp);
		}
		if (PvpTicketStack != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PvpTicketStack);
		}
		if (Mileage != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Mileage);
		}
		if (HopePowder != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HopePowder);
		}
		if (UnregDate != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(UnregDate);
		}
		num += purchaseCountInfo_.CalculateSize(_repeated_purchaseCountInfo_codec);
		if (IsFirstGacha)
		{
			num += 3;
		}
		if (PresetSlot != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PresetSlot);
		}
		num += optimizeInfo_.CalculateSize(_repeated_optimizeInfo_codec);
		if (BlockDate != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(BlockDate);
		}
		if (ReturnStatusEndTime != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(ReturnStatusEndTime);
		}
		if (MyRoomSlot != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MyRoomSlot);
		}
		if (TotalWarPresetSlot != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TotalWarPresetSlot);
		}
		if (EventApFree != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EventApFree);
		}
		if (EventApStack != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EventApStack);
		}
		if (FreeTorchLightAp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(FreeTorchLightAp);
		}
		if (TorchLightAp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TorchLightAp);
		}
		if (JoinTime != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(JoinTime);
		}
		if (NewbiePassStep != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NewbiePassStep);
		}
		if (BlockReason != Define_UserBlockReason.UserBlockReasonNone)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BlockReason);
		}
		if (RogueLikeAp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RogueLikeAp);
		}
		if (RogueLikeApStack != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RogueLikeApStack);
		}
		if (LoginDate != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(LoginDate);
		}
		if (GuildCoin != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(GuildCoin);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UserDBInfo other)
	{
		if (other != null)
		{
			if (other.OwnerIndex != 0L)
			{
				OwnerIndex = other.OwnerIndex;
			}
			if (other.UserId.Length != 0)
			{
				UserId = other.UserId;
			}
			if (other.UserKey.Length != 0)
			{
				UserKey = other.UserKey;
			}
			if (other.LastPlayPackId != 0)
			{
				LastPlayPackId = other.LastPlayPackId;
			}
			if (other.InvenSlot != 0)
			{
				InvenSlot = other.InvenSlot;
			}
			if (other.StorageSlot != 0)
			{
				StorageSlot = other.StorageSlot;
			}
			if (other.Gold != 0L)
			{
				Gold = other.Gold;
			}
			if (other.FreeJewelry != 0L)
			{
				FreeJewelry = other.FreeJewelry;
			}
			if (other.Jewelry != 0L)
			{
				Jewelry = other.Jewelry;
			}
			if (other.EquipSlot != 0)
			{
				EquipSlot = other.EquipSlot;
			}
			if (other.Catalyst != 0L)
			{
				Catalyst = other.Catalyst;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.LevelReward != 0)
			{
				LevelReward = other.LevelReward;
			}
			if (other.PortraitCostumeId != 0)
			{
				PortraitCostumeId = other.PortraitCostumeId;
			}
			if (other.EquipStorageSlot != 0)
			{
				EquipStorageSlot = other.EquipStorageSlot;
			}
			if (other.PvpTicket != 0)
			{
				PvpTicket = other.PvpTicket;
			}
			if (other.Medal != 0)
			{
				Medal = other.Medal;
			}
			if (other.EvilCastleCoin != 0)
			{
				EvilCastleCoin = other.EvilCastleCoin;
			}
			if (other.UserType != 0)
			{
				UserType = other.UserType;
			}
			if (other.FreeHuntingAp != 0)
			{
				FreeHuntingAp = other.FreeHuntingAp;
			}
			if (other.BonusHuntingAp != 0)
			{
				BonusHuntingAp = other.BonusHuntingAp;
			}
			if (other.PvpTicketStack != 0)
			{
				PvpTicketStack = other.PvpTicketStack;
			}
			if (other.Mileage != 0)
			{
				Mileage = other.Mileage;
			}
			if (other.HopePowder != 0)
			{
				HopePowder = other.HopePowder;
			}
			if (other.UnregDate != 0L)
			{
				UnregDate = other.UnregDate;
			}
			purchaseCountInfo_.Add(other.purchaseCountInfo_);
			if (other.IsFirstGacha)
			{
				IsFirstGacha = other.IsFirstGacha;
			}
			if (other.PresetSlot != 0)
			{
				PresetSlot = other.PresetSlot;
			}
			optimizeInfo_.Add(other.optimizeInfo_);
			if (other.BlockDate != 0L)
			{
				BlockDate = other.BlockDate;
			}
			if (other.ReturnStatusEndTime != 0L)
			{
				ReturnStatusEndTime = other.ReturnStatusEndTime;
			}
			if (other.MyRoomSlot != 0)
			{
				MyRoomSlot = other.MyRoomSlot;
			}
			if (other.TotalWarPresetSlot != 0)
			{
				TotalWarPresetSlot = other.TotalWarPresetSlot;
			}
			if (other.EventApFree != 0)
			{
				EventApFree = other.EventApFree;
			}
			if (other.EventApStack != 0)
			{
				EventApStack = other.EventApStack;
			}
			if (other.FreeTorchLightAp != 0)
			{
				FreeTorchLightAp = other.FreeTorchLightAp;
			}
			if (other.TorchLightAp != 0)
			{
				TorchLightAp = other.TorchLightAp;
			}
			if (other.JoinTime != 0L)
			{
				JoinTime = other.JoinTime;
			}
			if (other.NewbiePassStep != 0)
			{
				NewbiePassStep = other.NewbiePassStep;
			}
			if (other.BlockReason != Define_UserBlockReason.UserBlockReasonNone)
			{
				BlockReason = other.BlockReason;
			}
			if (other.RogueLikeAp != 0)
			{
				RogueLikeAp = other.RogueLikeAp;
			}
			if (other.RogueLikeApStack != 0)
			{
				RogueLikeApStack = other.RogueLikeApStack;
			}
			if (other.LoginDate != 0L)
			{
				LoginDate = other.LoginDate;
			}
			if (other.GuildCoin != 0L)
			{
				GuildCoin = other.GuildCoin;
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
				OwnerIndex = input.ReadInt64();
				break;
			case 18u:
				UserId = input.ReadString();
				break;
			case 26u:
				UserKey = input.ReadString();
				break;
			case 32u:
				LastPlayPackId = input.ReadInt32();
				break;
			case 40u:
				InvenSlot = input.ReadInt32();
				break;
			case 48u:
				StorageSlot = input.ReadInt32();
				break;
			case 56u:
				Gold = input.ReadInt64();
				break;
			case 64u:
				FreeJewelry = input.ReadInt64();
				break;
			case 72u:
				Jewelry = input.ReadInt64();
				break;
			case 80u:
				EquipSlot = input.ReadInt32();
				break;
			case 88u:
				Catalyst = input.ReadInt64();
				break;
			case 96u:
				Exp = input.ReadInt32();
				break;
			case 104u:
				LevelReward = input.ReadInt32();
				break;
			case 112u:
				PortraitCostumeId = input.ReadInt32();
				break;
			case 120u:
				EquipStorageSlot = input.ReadInt32();
				break;
			case 128u:
				PvpTicket = input.ReadInt32();
				break;
			case 136u:
				Medal = input.ReadInt32();
				break;
			case 144u:
				EvilCastleCoin = input.ReadInt32();
				break;
			case 152u:
				UserType = input.ReadInt32();
				break;
			case 160u:
				FreeHuntingAp = input.ReadInt32();
				break;
			case 168u:
				BonusHuntingAp = input.ReadInt32();
				break;
			case 176u:
				PvpTicketStack = input.ReadInt32();
				break;
			case 184u:
				Mileage = input.ReadInt32();
				break;
			case 192u:
				HopePowder = input.ReadInt32();
				break;
			case 200u:
				UnregDate = input.ReadInt64();
				break;
			case 210u:
				purchaseCountInfo_.AddEntriesFrom(ref input, _repeated_purchaseCountInfo_codec);
				break;
			case 216u:
				IsFirstGacha = input.ReadBool();
				break;
			case 224u:
				PresetSlot = input.ReadInt32();
				break;
			case 234u:
				optimizeInfo_.AddEntriesFrom(ref input, _repeated_optimizeInfo_codec);
				break;
			case 240u:
				BlockDate = input.ReadInt64();
				break;
			case 248u:
				ReturnStatusEndTime = input.ReadInt64();
				break;
			case 256u:
				MyRoomSlot = input.ReadInt32();
				break;
			case 264u:
				TotalWarPresetSlot = input.ReadInt32();
				break;
			case 272u:
				EventApFree = input.ReadInt32();
				break;
			case 280u:
				EventApStack = input.ReadInt32();
				break;
			case 288u:
				FreeTorchLightAp = input.ReadInt32();
				break;
			case 296u:
				TorchLightAp = input.ReadInt32();
				break;
			case 304u:
				JoinTime = input.ReadInt64();
				break;
			case 312u:
				NewbiePassStep = input.ReadInt32();
				break;
			case 320u:
				BlockReason = (Define_UserBlockReason)input.ReadEnum();
				break;
			case 328u:
				RogueLikeAp = input.ReadInt32();
				break;
			case 336u:
				RogueLikeApStack = input.ReadInt32();
				break;
			case 344u:
				LoginDate = input.ReadInt64();
				break;
			case 352u:
				GuildCoin = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
