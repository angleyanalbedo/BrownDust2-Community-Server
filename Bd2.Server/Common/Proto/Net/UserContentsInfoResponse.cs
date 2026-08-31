using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class UserContentsInfoResponse : IMessage<UserContentsInfoResponse>, IMessage, IEquatable<UserContentsInfoResponse>, IDeepCloneable<UserContentsInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<UserContentsInfoResponse> _parser = new MessageParser<UserContentsInfoResponse>(() => new UserContentsInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int OwnerIndexFieldNumber = 1;

	private long ownerIndex_;

	public const int UserIdFieldNumber = 2;

	private string userId_ = "";

	public const int TitleIdFieldNumber = 3;

	private int titleId_;

	public const int PortraitCostumeIdFieldNumber = 4;

	private int portraitCostumeId_;

	public const int GreetingFieldNumber = 5;

	private string greeting_ = "";

	public const int PvpSeasonFieldNumber = 6;

	private int pvpSeason_;

	public const int PvpVpFieldNumber = 7;

	private int pvpVp_;

	public const int PvpRankFieldNumber = 8;

	private int pvpRank_;

	public const int EvilcastleRankFieldNumber = 9;

	private int evilcastleRank_;

	public const int MonsterhuntRankFieldNumber = 10;

	private int monsterhuntRank_;

	public const int LikeCountFieldNumber = 11;

	private int likeCount_;

	public const int IsAllPrivateFieldNumber = 12;

	private bool isAllPrivate_;

	public const int OptionsFieldNumber = 13;

	private static readonly FieldCodec<int> _repeated_options_codec = FieldCodec.ForInt32(106u);

	private readonly RepeatedField<int> options_ = new RepeatedField<int>();

	public const int IsFriendFieldNumber = 14;

	private bool isFriend_;

	public const int RoomInfoFieldNumber = 15;

	private MyRoomUserInfo roomInfo_;

	public const int TotalWarScoreFieldNumber = 16;

	private long totalWarScore_;

	public const int TotalBattlePowerFieldNumber = 17;

	private int totalBattlePower_;

	public const int GuildBaseInfoFieldNumber = 18;

	private GuildBaseDBInfo guildBaseInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UserContentsInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UserContentsInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TitleId
	{
		get
		{
			return titleId_;
		}
		set
		{
			titleId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Greeting
	{
		get
		{
			return greeting_;
		}
		set
		{
			greeting_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PvpSeason
	{
		get
		{
			return pvpSeason_;
		}
		set
		{
			pvpSeason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PvpVp
	{
		get
		{
			return pvpVp_;
		}
		set
		{
			pvpVp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PvpRank
	{
		get
		{
			return pvpRank_;
		}
		set
		{
			pvpRank_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EvilcastleRank
	{
		get
		{
			return evilcastleRank_;
		}
		set
		{
			evilcastleRank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MonsterhuntRank
	{
		get
		{
			return monsterhuntRank_;
		}
		set
		{
			monsterhuntRank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LikeCount
	{
		get
		{
			return likeCount_;
		}
		set
		{
			likeCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsAllPrivate
	{
		get
		{
			return isAllPrivate_;
		}
		set
		{
			isAllPrivate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Options => options_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsFriend
	{
		get
		{
			return isFriend_;
		}
		set
		{
			isFriend_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomUserInfo RoomInfo
	{
		get
		{
			return roomInfo_;
		}
		set
		{
			roomInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TotalWarScore
	{
		get
		{
			return totalWarScore_;
		}
		set
		{
			totalWarScore_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalBattlePower
	{
		get
		{
			return totalBattlePower_;
		}
		set
		{
			totalBattlePower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBaseDBInfo GuildBaseInfo
	{
		get
		{
			return guildBaseInfo_;
		}
		set
		{
			guildBaseInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserContentsInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UserContentsInfoResponse(UserContentsInfoResponse other)
		: this()
	{
		ownerIndex_ = other.ownerIndex_;
		userId_ = other.userId_;
		titleId_ = other.titleId_;
		portraitCostumeId_ = other.portraitCostumeId_;
		greeting_ = other.greeting_;
		pvpSeason_ = other.pvpSeason_;
		pvpVp_ = other.pvpVp_;
		pvpRank_ = other.pvpRank_;
		evilcastleRank_ = other.evilcastleRank_;
		monsterhuntRank_ = other.monsterhuntRank_;
		likeCount_ = other.likeCount_;
		isAllPrivate_ = other.isAllPrivate_;
		options_ = other.options_.Clone();
		isFriend_ = other.isFriend_;
		roomInfo_ = ((other.roomInfo_ != null) ? other.roomInfo_.Clone() : null);
		totalWarScore_ = other.totalWarScore_;
		totalBattlePower_ = other.totalBattlePower_;
		guildBaseInfo_ = ((other.guildBaseInfo_ != null) ? other.guildBaseInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserContentsInfoResponse Clone()
	{
		return new UserContentsInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UserContentsInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(UserContentsInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OwnerIndex == other.OwnerIndex && !(UserId != other.UserId) && TitleId == other.TitleId && PortraitCostumeId == other.PortraitCostumeId && !(Greeting != other.Greeting) && PvpSeason == other.PvpSeason && PvpVp == other.PvpVp && PvpRank == other.PvpRank && EvilcastleRank == other.EvilcastleRank && MonsterhuntRank == other.MonsterhuntRank && LikeCount == other.LikeCount && IsAllPrivate == other.IsAllPrivate && options_.Equals(other.options_) && IsFriend == other.IsFriend && object.Equals(RoomInfo, other.RoomInfo) && TotalWarScore == other.TotalWarScore && TotalBattlePower == other.TotalBattlePower && object.Equals(GuildBaseInfo, other.GuildBaseInfo))
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
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (UserId.Length != 0)
		{
			num ^= UserId.GetHashCode();
		}
		if (TitleId != 0)
		{
			num ^= TitleId.GetHashCode();
		}
		if (PortraitCostumeId != 0)
		{
			num ^= PortraitCostumeId.GetHashCode();
		}
		if (Greeting.Length != 0)
		{
			num ^= Greeting.GetHashCode();
		}
		if (PvpSeason != 0)
		{
			num ^= PvpSeason.GetHashCode();
		}
		if (PvpVp != 0)
		{
			num ^= PvpVp.GetHashCode();
		}
		if (PvpRank != 0)
		{
			num ^= PvpRank.GetHashCode();
		}
		if (EvilcastleRank != 0)
		{
			num ^= EvilcastleRank.GetHashCode();
		}
		if (MonsterhuntRank != 0)
		{
			num ^= MonsterhuntRank.GetHashCode();
		}
		if (LikeCount != 0)
		{
			num ^= LikeCount.GetHashCode();
		}
		if (IsAllPrivate)
		{
			num ^= IsAllPrivate.GetHashCode();
		}
		num ^= options_.GetHashCode();
		if (IsFriend)
		{
			num ^= IsFriend.GetHashCode();
		}
		if (roomInfo_ != null)
		{
			num ^= RoomInfo.GetHashCode();
		}
		if (TotalWarScore != 0L)
		{
			num ^= TotalWarScore.GetHashCode();
		}
		if (TotalBattlePower != 0)
		{
			num ^= TotalBattlePower.GetHashCode();
		}
		if (guildBaseInfo_ != null)
		{
			num ^= GuildBaseInfo.GetHashCode();
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
		if (TitleId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TitleId);
		}
		if (PortraitCostumeId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PortraitCostumeId);
		}
		if (Greeting.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Greeting);
		}
		if (PvpSeason != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PvpSeason);
		}
		if (PvpVp != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(PvpVp);
		}
		if (PvpRank != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PvpRank);
		}
		if (EvilcastleRank != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(EvilcastleRank);
		}
		if (MonsterhuntRank != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MonsterhuntRank);
		}
		if (LikeCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(LikeCount);
		}
		if (IsAllPrivate)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsAllPrivate);
		}
		options_.WriteTo(ref output, _repeated_options_codec);
		if (IsFriend)
		{
			output.WriteRawTag(112);
			output.WriteBool(IsFriend);
		}
		if (roomInfo_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(RoomInfo);
		}
		if (TotalWarScore != 0L)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt64(TotalWarScore);
		}
		if (TotalBattlePower != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(TotalBattlePower);
		}
		if (guildBaseInfo_ != null)
		{
			output.WriteRawTag(146, 1);
			output.WriteMessage(GuildBaseInfo);
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
		if (TitleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleId);
		}
		if (PortraitCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PortraitCostumeId);
		}
		if (Greeting.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Greeting);
		}
		if (PvpSeason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PvpSeason);
		}
		if (PvpVp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PvpVp);
		}
		if (PvpRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PvpRank);
		}
		if (EvilcastleRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EvilcastleRank);
		}
		if (MonsterhuntRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterhuntRank);
		}
		if (LikeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LikeCount);
		}
		if (IsAllPrivate)
		{
			num += 2;
		}
		num += options_.CalculateSize(_repeated_options_codec);
		if (IsFriend)
		{
			num += 2;
		}
		if (roomInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoomInfo);
		}
		if (TotalWarScore != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(TotalWarScore);
		}
		if (TotalBattlePower != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TotalBattlePower);
		}
		if (guildBaseInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GuildBaseInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UserContentsInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OwnerIndex != 0L)
		{
			OwnerIndex = other.OwnerIndex;
		}
		if (other.UserId.Length != 0)
		{
			UserId = other.UserId;
		}
		if (other.TitleId != 0)
		{
			TitleId = other.TitleId;
		}
		if (other.PortraitCostumeId != 0)
		{
			PortraitCostumeId = other.PortraitCostumeId;
		}
		if (other.Greeting.Length != 0)
		{
			Greeting = other.Greeting;
		}
		if (other.PvpSeason != 0)
		{
			PvpSeason = other.PvpSeason;
		}
		if (other.PvpVp != 0)
		{
			PvpVp = other.PvpVp;
		}
		if (other.PvpRank != 0)
		{
			PvpRank = other.PvpRank;
		}
		if (other.EvilcastleRank != 0)
		{
			EvilcastleRank = other.EvilcastleRank;
		}
		if (other.MonsterhuntRank != 0)
		{
			MonsterhuntRank = other.MonsterhuntRank;
		}
		if (other.LikeCount != 0)
		{
			LikeCount = other.LikeCount;
		}
		if (other.IsAllPrivate)
		{
			IsAllPrivate = other.IsAllPrivate;
		}
		options_.Add(other.options_);
		if (other.IsFriend)
		{
			IsFriend = other.IsFriend;
		}
		if (other.roomInfo_ != null)
		{
			if (roomInfo_ == null)
			{
				RoomInfo = new MyRoomUserInfo();
			}
			RoomInfo.MergeFrom(other.RoomInfo);
		}
		if (other.TotalWarScore != 0L)
		{
			TotalWarScore = other.TotalWarScore;
		}
		if (other.TotalBattlePower != 0)
		{
			TotalBattlePower = other.TotalBattlePower;
		}
		if (other.guildBaseInfo_ != null)
		{
			if (guildBaseInfo_ == null)
			{
				GuildBaseInfo = new GuildBaseDBInfo();
			}
			GuildBaseInfo.MergeFrom(other.GuildBaseInfo);
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
				OwnerIndex = input.ReadInt64();
				break;
			case 18u:
				UserId = input.ReadString();
				break;
			case 24u:
				TitleId = input.ReadInt32();
				break;
			case 32u:
				PortraitCostumeId = input.ReadInt32();
				break;
			case 42u:
				Greeting = input.ReadString();
				break;
			case 48u:
				PvpSeason = input.ReadInt32();
				break;
			case 56u:
				PvpVp = input.ReadInt32();
				break;
			case 64u:
				PvpRank = input.ReadInt32();
				break;
			case 72u:
				EvilcastleRank = input.ReadInt32();
				break;
			case 80u:
				MonsterhuntRank = input.ReadInt32();
				break;
			case 88u:
				LikeCount = input.ReadInt32();
				break;
			case 96u:
				IsAllPrivate = input.ReadBool();
				break;
			case 104u:
			case 106u:
				options_.AddEntriesFrom(ref input, _repeated_options_codec);
				break;
			case 112u:
				IsFriend = input.ReadBool();
				break;
			case 122u:
				if (roomInfo_ == null)
				{
					RoomInfo = new MyRoomUserInfo();
				}
				input.ReadMessage(RoomInfo);
				break;
			case 128u:
				TotalWarScore = input.ReadInt64();
				break;
			case 136u:
				TotalBattlePower = input.ReadInt32();
				break;
			case 146u:
				if (guildBaseInfo_ == null)
				{
					GuildBaseInfo = new GuildBaseDBInfo();
				}
				input.ReadMessage(GuildBaseInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
