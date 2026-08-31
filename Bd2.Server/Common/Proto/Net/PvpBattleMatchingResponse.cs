using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleMatchingResponse : IMessage<PvpBattleMatchingResponse>, IMessage, IEquatable<PvpBattleMatchingResponse>, IDeepCloneable<PvpBattleMatchingResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleMatchingResponse> _parser = new MessageParser<PvpBattleMatchingResponse>(() => new PvpBattleMatchingResponse());

	private UnknownFieldSet _unknownFields;

	public const int UserVpFieldNumber = 1;

	private int userVp_;

	public const int UserRankFieldNumber = 2;

	private int userRank_;

	public const int UserBuffStatInfoFieldNumber = 3;

	private static readonly FieldCodec<PictorialBuffStatDBInfo> _repeated_userBuffStatInfo_codec = FieldCodec.ForMessage(26u, PictorialBuffStatDBInfo.Parser);

	private readonly RepeatedField<PictorialBuffStatDBInfo> userBuffStatInfo_ = new RepeatedField<PictorialBuffStatDBInfo>();

	public const int EnemyOwnerIndexFieldNumber = 4;

	private long enemyOwnerIndex_;

	public const int EnemyUserIdFieldNumber = 5;

	private string enemyUserId_ = "";

	public const int EnemyExpFieldNumber = 6;

	private int enemyExp_;

	public const int EnemyVpFieldNumber = 7;

	private int enemyVp_;

	public const int EnemyRankFieldNumber = 8;

	private int enemyRank_;

	public const int EnemyGuildBaseInfoFieldNumber = 9;

	private GuildBaseDBInfo enemyGuildBaseInfo_;

	public const int EnemyPortraitCostumeIdFieldNumber = 10;

	private int enemyPortraitCostumeId_;

	public const int EnemyDeckInfoFieldNumber = 11;

	private static readonly FieldCodec<PvpBattleUserDeckInfo> _repeated_enemyDeckInfo_codec = FieldCodec.ForMessage(90u, PvpBattleUserDeckInfo.Parser);

	private readonly RepeatedField<PvpBattleUserDeckInfo> enemyDeckInfo_ = new RepeatedField<PvpBattleUserDeckInfo>();

	public const int EnemyCharInfoFieldNumber = 12;

	private static readonly FieldCodec<CharDBInfo> _repeated_enemyCharInfo_codec = FieldCodec.ForMessage(98u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> enemyCharInfo_ = new RepeatedField<CharDBInfo>();

	public const int EnemyCostumeInfoFieldNumber = 13;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_enemyCostumeInfo_codec = FieldCodec.ForMessage(106u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> enemyCostumeInfo_ = new RepeatedField<CostumeDBInfo>();

	public const int EnemyEquipInfoFieldNumber = 14;

	private static readonly FieldCodec<EquipDBInfo> _repeated_enemyEquipInfo_codec = FieldCodec.ForMessage(114u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> enemyEquipInfo_ = new RepeatedField<EquipDBInfo>();

	public const int BattleRandomSeedFieldNumber = 15;

	private int battleRandomSeed_;

	public const int EventScheduleInfoFieldNumber = 16;

	private EventScheduleDBInfo eventScheduleInfo_;

	public const int EnemyBuffStatInfoFieldNumber = 17;

	private static readonly FieldCodec<PictorialBuffStatDBInfo> _repeated_enemyBuffStatInfo_codec = FieldCodec.ForMessage(138u, PictorialBuffStatDBInfo.Parser);

	private readonly RepeatedField<PictorialBuffStatDBInfo> enemyBuffStatInfo_ = new RepeatedField<PictorialBuffStatDBInfo>();

	public const int EnemyAwakeInfoFieldNumber = 18;

	private static readonly FieldCodec<CharAwakeDBInfo> _repeated_enemyAwakeInfo_codec = FieldCodec.ForMessage(146u, CharAwakeDBInfo.Parser);

	private readonly RepeatedField<CharAwakeDBInfo> enemyAwakeInfo_ = new RepeatedField<CharAwakeDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpBattleMatchingResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PvpBattleMatchingResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UserVp
	{
		get
		{
			return userVp_;
		}
		set
		{
			userVp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UserRank
	{
		get
		{
			return userRank_;
		}
		set
		{
			userRank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PictorialBuffStatDBInfo> UserBuffStatInfo => userBuffStatInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long EnemyOwnerIndex
	{
		get
		{
			return enemyOwnerIndex_;
		}
		set
		{
			enemyOwnerIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string EnemyUserId
	{
		get
		{
			return enemyUserId_;
		}
		set
		{
			enemyUserId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EnemyExp
	{
		get
		{
			return enemyExp_;
		}
		set
		{
			enemyExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EnemyVp
	{
		get
		{
			return enemyVp_;
		}
		set
		{
			enemyVp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EnemyRank
	{
		get
		{
			return enemyRank_;
		}
		set
		{
			enemyRank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBaseDBInfo EnemyGuildBaseInfo
	{
		get
		{
			return enemyGuildBaseInfo_;
		}
		set
		{
			enemyGuildBaseInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EnemyPortraitCostumeId
	{
		get
		{
			return enemyPortraitCostumeId_;
		}
		set
		{
			enemyPortraitCostumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PvpBattleUserDeckInfo> EnemyDeckInfo => enemyDeckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> EnemyCharInfo => enemyCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CostumeDBInfo> EnemyCostumeInfo => enemyCostumeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EquipDBInfo> EnemyEquipInfo => enemyEquipInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleRandomSeed
	{
		get
		{
			return battleRandomSeed_;
		}
		set
		{
			battleRandomSeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventScheduleDBInfo EventScheduleInfo
	{
		get
		{
			return eventScheduleInfo_;
		}
		set
		{
			eventScheduleInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PictorialBuffStatDBInfo> EnemyBuffStatInfo => enemyBuffStatInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharAwakeDBInfo> EnemyAwakeInfo => enemyAwakeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleMatchingResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleMatchingResponse(PvpBattleMatchingResponse other)
		: this()
	{
		userVp_ = other.userVp_;
		userRank_ = other.userRank_;
		userBuffStatInfo_ = other.userBuffStatInfo_.Clone();
		enemyOwnerIndex_ = other.enemyOwnerIndex_;
		enemyUserId_ = other.enemyUserId_;
		enemyExp_ = other.enemyExp_;
		enemyVp_ = other.enemyVp_;
		enemyRank_ = other.enemyRank_;
		enemyGuildBaseInfo_ = ((other.enemyGuildBaseInfo_ != null) ? other.enemyGuildBaseInfo_.Clone() : null);
		enemyPortraitCostumeId_ = other.enemyPortraitCostumeId_;
		enemyDeckInfo_ = other.enemyDeckInfo_.Clone();
		enemyCharInfo_ = other.enemyCharInfo_.Clone();
		enemyCostumeInfo_ = other.enemyCostumeInfo_.Clone();
		enemyEquipInfo_ = other.enemyEquipInfo_.Clone();
		battleRandomSeed_ = other.battleRandomSeed_;
		eventScheduleInfo_ = ((other.eventScheduleInfo_ != null) ? other.eventScheduleInfo_.Clone() : null);
		enemyBuffStatInfo_ = other.enemyBuffStatInfo_.Clone();
		enemyAwakeInfo_ = other.enemyAwakeInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleMatchingResponse Clone()
	{
		return new PvpBattleMatchingResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleMatchingResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleMatchingResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (UserVp == other.UserVp && UserRank == other.UserRank && userBuffStatInfo_.Equals(other.userBuffStatInfo_) && EnemyOwnerIndex == other.EnemyOwnerIndex && !(EnemyUserId != other.EnemyUserId) && EnemyExp == other.EnemyExp && EnemyVp == other.EnemyVp && EnemyRank == other.EnemyRank && object.Equals(EnemyGuildBaseInfo, other.EnemyGuildBaseInfo) && EnemyPortraitCostumeId == other.EnemyPortraitCostumeId && enemyDeckInfo_.Equals(other.enemyDeckInfo_) && enemyCharInfo_.Equals(other.enemyCharInfo_) && enemyCostumeInfo_.Equals(other.enemyCostumeInfo_) && enemyEquipInfo_.Equals(other.enemyEquipInfo_) && BattleRandomSeed == other.BattleRandomSeed && object.Equals(EventScheduleInfo, other.EventScheduleInfo) && enemyBuffStatInfo_.Equals(other.enemyBuffStatInfo_) && enemyAwakeInfo_.Equals(other.enemyAwakeInfo_))
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
		if (UserVp != 0)
		{
			num ^= UserVp.GetHashCode();
		}
		if (UserRank != 0)
		{
			num ^= UserRank.GetHashCode();
		}
		num ^= userBuffStatInfo_.GetHashCode();
		if (EnemyOwnerIndex != 0L)
		{
			num ^= EnemyOwnerIndex.GetHashCode();
		}
		if (EnemyUserId.Length != 0)
		{
			num ^= EnemyUserId.GetHashCode();
		}
		if (EnemyExp != 0)
		{
			num ^= EnemyExp.GetHashCode();
		}
		if (EnemyVp != 0)
		{
			num ^= EnemyVp.GetHashCode();
		}
		if (EnemyRank != 0)
		{
			num ^= EnemyRank.GetHashCode();
		}
		if (enemyGuildBaseInfo_ != null)
		{
			num ^= EnemyGuildBaseInfo.GetHashCode();
		}
		if (EnemyPortraitCostumeId != 0)
		{
			num ^= EnemyPortraitCostumeId.GetHashCode();
		}
		num ^= enemyDeckInfo_.GetHashCode();
		num ^= enemyCharInfo_.GetHashCode();
		num ^= enemyCostumeInfo_.GetHashCode();
		num ^= enemyEquipInfo_.GetHashCode();
		if (BattleRandomSeed != 0)
		{
			num ^= BattleRandomSeed.GetHashCode();
		}
		if (eventScheduleInfo_ != null)
		{
			num ^= EventScheduleInfo.GetHashCode();
		}
		num ^= enemyBuffStatInfo_.GetHashCode();
		num ^= enemyAwakeInfo_.GetHashCode();
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
		if (UserVp != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UserVp);
		}
		if (UserRank != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UserRank);
		}
		userBuffStatInfo_.WriteTo(ref output, _repeated_userBuffStatInfo_codec);
		if (EnemyOwnerIndex != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(EnemyOwnerIndex);
		}
		if (EnemyUserId.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(EnemyUserId);
		}
		if (EnemyExp != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EnemyExp);
		}
		if (EnemyVp != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(EnemyVp);
		}
		if (EnemyRank != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(EnemyRank);
		}
		if (enemyGuildBaseInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(EnemyGuildBaseInfo);
		}
		if (EnemyPortraitCostumeId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(EnemyPortraitCostumeId);
		}
		enemyDeckInfo_.WriteTo(ref output, _repeated_enemyDeckInfo_codec);
		enemyCharInfo_.WriteTo(ref output, _repeated_enemyCharInfo_codec);
		enemyCostumeInfo_.WriteTo(ref output, _repeated_enemyCostumeInfo_codec);
		enemyEquipInfo_.WriteTo(ref output, _repeated_enemyEquipInfo_codec);
		if (BattleRandomSeed != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(BattleRandomSeed);
		}
		if (eventScheduleInfo_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(EventScheduleInfo);
		}
		enemyBuffStatInfo_.WriteTo(ref output, _repeated_enemyBuffStatInfo_codec);
		enemyAwakeInfo_.WriteTo(ref output, _repeated_enemyAwakeInfo_codec);
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
		if (UserVp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UserVp);
		}
		if (UserRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UserRank);
		}
		num += userBuffStatInfo_.CalculateSize(_repeated_userBuffStatInfo_codec);
		if (EnemyOwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EnemyOwnerIndex);
		}
		if (EnemyUserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnemyUserId);
		}
		if (EnemyExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EnemyExp);
		}
		if (EnemyVp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EnemyVp);
		}
		if (EnemyRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EnemyRank);
		}
		if (enemyGuildBaseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnemyGuildBaseInfo);
		}
		if (EnemyPortraitCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EnemyPortraitCostumeId);
		}
		num += enemyDeckInfo_.CalculateSize(_repeated_enemyDeckInfo_codec);
		num += enemyCharInfo_.CalculateSize(_repeated_enemyCharInfo_codec);
		num += enemyCostumeInfo_.CalculateSize(_repeated_enemyCostumeInfo_codec);
		num += enemyEquipInfo_.CalculateSize(_repeated_enemyEquipInfo_codec);
		if (BattleRandomSeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleRandomSeed);
		}
		if (eventScheduleInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EventScheduleInfo);
		}
		num += enemyBuffStatInfo_.CalculateSize(_repeated_enemyBuffStatInfo_codec);
		num += enemyAwakeInfo_.CalculateSize(_repeated_enemyAwakeInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PvpBattleMatchingResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UserVp != 0)
		{
			UserVp = other.UserVp;
		}
		if (other.UserRank != 0)
		{
			UserRank = other.UserRank;
		}
		userBuffStatInfo_.Add(other.userBuffStatInfo_);
		if (other.EnemyOwnerIndex != 0L)
		{
			EnemyOwnerIndex = other.EnemyOwnerIndex;
		}
		if (other.EnemyUserId.Length != 0)
		{
			EnemyUserId = other.EnemyUserId;
		}
		if (other.EnemyExp != 0)
		{
			EnemyExp = other.EnemyExp;
		}
		if (other.EnemyVp != 0)
		{
			EnemyVp = other.EnemyVp;
		}
		if (other.EnemyRank != 0)
		{
			EnemyRank = other.EnemyRank;
		}
		if (other.enemyGuildBaseInfo_ != null)
		{
			if (enemyGuildBaseInfo_ == null)
			{
				EnemyGuildBaseInfo = new GuildBaseDBInfo();
			}
			EnemyGuildBaseInfo.MergeFrom(other.EnemyGuildBaseInfo);
		}
		if (other.EnemyPortraitCostumeId != 0)
		{
			EnemyPortraitCostumeId = other.EnemyPortraitCostumeId;
		}
		enemyDeckInfo_.Add(other.enemyDeckInfo_);
		enemyCharInfo_.Add(other.enemyCharInfo_);
		enemyCostumeInfo_.Add(other.enemyCostumeInfo_);
		enemyEquipInfo_.Add(other.enemyEquipInfo_);
		if (other.BattleRandomSeed != 0)
		{
			BattleRandomSeed = other.BattleRandomSeed;
		}
		if (other.eventScheduleInfo_ != null)
		{
			if (eventScheduleInfo_ == null)
			{
				EventScheduleInfo = new EventScheduleDBInfo();
			}
			EventScheduleInfo.MergeFrom(other.EventScheduleInfo);
		}
		enemyBuffStatInfo_.Add(other.enemyBuffStatInfo_);
		enemyAwakeInfo_.Add(other.enemyAwakeInfo_);
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
			case 8u:
				UserVp = input.ReadInt32();
				break;
			case 16u:
				UserRank = input.ReadInt32();
				break;
			case 26u:
				userBuffStatInfo_.AddEntriesFrom(ref input, _repeated_userBuffStatInfo_codec);
				break;
			case 32u:
				EnemyOwnerIndex = input.ReadInt64();
				break;
			case 42u:
				EnemyUserId = input.ReadString();
				break;
			case 48u:
				EnemyExp = input.ReadInt32();
				break;
			case 56u:
				EnemyVp = input.ReadInt32();
				break;
			case 64u:
				EnemyRank = input.ReadInt32();
				break;
			case 74u:
				if (enemyGuildBaseInfo_ == null)
				{
					EnemyGuildBaseInfo = new GuildBaseDBInfo();
				}
				input.ReadMessage(EnemyGuildBaseInfo);
				break;
			case 80u:
				EnemyPortraitCostumeId = input.ReadInt32();
				break;
			case 90u:
				enemyDeckInfo_.AddEntriesFrom(ref input, _repeated_enemyDeckInfo_codec);
				break;
			case 98u:
				enemyCharInfo_.AddEntriesFrom(ref input, _repeated_enemyCharInfo_codec);
				break;
			case 106u:
				enemyCostumeInfo_.AddEntriesFrom(ref input, _repeated_enemyCostumeInfo_codec);
				break;
			case 114u:
				enemyEquipInfo_.AddEntriesFrom(ref input, _repeated_enemyEquipInfo_codec);
				break;
			case 120u:
				BattleRandomSeed = input.ReadInt32();
				break;
			case 130u:
				if (eventScheduleInfo_ == null)
				{
					EventScheduleInfo = new EventScheduleDBInfo();
				}
				input.ReadMessage(EventScheduleInfo);
				break;
			case 138u:
				enemyBuffStatInfo_.AddEntriesFrom(ref input, _repeated_enemyBuffStatInfo_codec);
				break;
			case 146u:
				enemyAwakeInfo_.AddEntriesFrom(ref input, _repeated_enemyAwakeInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
