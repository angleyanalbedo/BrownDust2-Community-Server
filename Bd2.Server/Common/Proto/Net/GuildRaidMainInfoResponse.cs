using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidMainInfoResponse : IMessage<GuildRaidMainInfoResponse>, IMessage, IEquatable<GuildRaidMainInfoResponse>, IDeepCloneable<GuildRaidMainInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidMainInfoResponse> _parser = new MessageParser<GuildRaidMainInfoResponse>(() => new GuildRaidMainInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int SeasonFieldNumber = 1;

	private int season_;

	public const int RaidDayFieldNumber = 2;

	private int raidDay_;

	public const int TodayNormalBattleCountFieldNumber = 3;

	private int todayNormalBattleCount_;

	public const int UserScoreFieldNumber = 4;

	private long userScore_;

	public const int LastScoreRewardIdFieldNumber = 5;

	private int lastScoreRewardId_;

	public const int GuildTotalScoreFieldNumber = 6;

	private long guildTotalScore_;

	public const int GuildTopPercentFieldNumber = 7;

	private double guildTopPercent_;

	public const int GolemLevelFieldNumber = 8;

	private int golemLevel_;

	public const int GolemExpFieldNumber = 9;

	private int golemExp_;

	public const int ObtainableSeasonRewardFieldNumber = 10;

	private bool obtainableSeasonReward_;

	public const int TodaySupporterUseCountFieldNumber = 11;

	private int todaySupporterUseCount_;

	public const int TotalSupporterRentalCountFieldNumber = 12;

	private int totalSupporterRentalCount_;

	public const int TopGuildScoreFieldNumber = 13;

	private long topGuildScore_;

	public const int PlayDayFieldNumber = 14;

	private static readonly FieldCodec<bool> _repeated_playDay_codec = FieldCodec.ForBool(114u);

	private readonly RepeatedField<bool> playDay_ = new RepeatedField<bool>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRaidMainInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidMainInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RaidDay
	{
		get
		{
			return raidDay_;
		}
		set
		{
			raidDay_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TodayNormalBattleCount
	{
		get
		{
			return todayNormalBattleCount_;
		}
		set
		{
			todayNormalBattleCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UserScore
	{
		get
		{
			return userScore_;
		}
		set
		{
			userScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastScoreRewardId
	{
		get
		{
			return lastScoreRewardId_;
		}
		set
		{
			lastScoreRewardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long GuildTotalScore
	{
		get
		{
			return guildTotalScore_;
		}
		set
		{
			guildTotalScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double GuildTopPercent
	{
		get
		{
			return guildTopPercent_;
		}
		set
		{
			guildTopPercent_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GolemLevel
	{
		get
		{
			return golemLevel_;
		}
		set
		{
			golemLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GolemExp
	{
		get
		{
			return golemExp_;
		}
		set
		{
			golemExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ObtainableSeasonReward
	{
		get
		{
			return obtainableSeasonReward_;
		}
		set
		{
			obtainableSeasonReward_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TodaySupporterUseCount
	{
		get
		{
			return todaySupporterUseCount_;
		}
		set
		{
			todaySupporterUseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TotalSupporterRentalCount
	{
		get
		{
			return totalSupporterRentalCount_;
		}
		set
		{
			totalSupporterRentalCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TopGuildScore
	{
		get
		{
			return topGuildScore_;
		}
		set
		{
			topGuildScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<bool> PlayDay => playDay_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidMainInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidMainInfoResponse(GuildRaidMainInfoResponse other)
		: this()
	{
		season_ = other.season_;
		raidDay_ = other.raidDay_;
		todayNormalBattleCount_ = other.todayNormalBattleCount_;
		userScore_ = other.userScore_;
		lastScoreRewardId_ = other.lastScoreRewardId_;
		guildTotalScore_ = other.guildTotalScore_;
		guildTopPercent_ = other.guildTopPercent_;
		golemLevel_ = other.golemLevel_;
		golemExp_ = other.golemExp_;
		obtainableSeasonReward_ = other.obtainableSeasonReward_;
		todaySupporterUseCount_ = other.todaySupporterUseCount_;
		totalSupporterRentalCount_ = other.totalSupporterRentalCount_;
		topGuildScore_ = other.topGuildScore_;
		playDay_ = other.playDay_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidMainInfoResponse Clone()
	{
		return new GuildRaidMainInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidMainInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRaidMainInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Season == other.Season && RaidDay == other.RaidDay && TodayNormalBattleCount == other.TodayNormalBattleCount && UserScore == other.UserScore && LastScoreRewardId == other.LastScoreRewardId && GuildTotalScore == other.GuildTotalScore && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GuildTopPercent, other.GuildTopPercent) && GolemLevel == other.GolemLevel && GolemExp == other.GolemExp && ObtainableSeasonReward == other.ObtainableSeasonReward && TodaySupporterUseCount == other.TodaySupporterUseCount && TotalSupporterRentalCount == other.TotalSupporterRentalCount && TopGuildScore == other.TopGuildScore && playDay_.Equals(other.playDay_))
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
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (RaidDay != 0)
		{
			num ^= RaidDay.GetHashCode();
		}
		if (TodayNormalBattleCount != 0)
		{
			num ^= TodayNormalBattleCount.GetHashCode();
		}
		if (UserScore != 0L)
		{
			num ^= UserScore.GetHashCode();
		}
		if (LastScoreRewardId != 0)
		{
			num ^= LastScoreRewardId.GetHashCode();
		}
		if (GuildTotalScore != 0L)
		{
			num ^= GuildTotalScore.GetHashCode();
		}
		if (GuildTopPercent != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GuildTopPercent);
		}
		if (GolemLevel != 0)
		{
			num ^= GolemLevel.GetHashCode();
		}
		if (GolemExp != 0)
		{
			num ^= GolemExp.GetHashCode();
		}
		if (ObtainableSeasonReward)
		{
			num ^= ObtainableSeasonReward.GetHashCode();
		}
		if (TodaySupporterUseCount != 0)
		{
			num ^= TodaySupporterUseCount.GetHashCode();
		}
		if (TotalSupporterRentalCount != 0)
		{
			num ^= TotalSupporterRentalCount.GetHashCode();
		}
		if (TopGuildScore != 0L)
		{
			num ^= TopGuildScore.GetHashCode();
		}
		num ^= playDay_.GetHashCode();
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
		if (Season != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Season);
		}
		if (RaidDay != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RaidDay);
		}
		if (TodayNormalBattleCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TodayNormalBattleCount);
		}
		if (UserScore != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(UserScore);
		}
		if (LastScoreRewardId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(LastScoreRewardId);
		}
		if (GuildTotalScore != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(GuildTotalScore);
		}
		if (GuildTopPercent != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(GuildTopPercent);
		}
		if (GolemLevel != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(GolemLevel);
		}
		if (GolemExp != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(GolemExp);
		}
		if (ObtainableSeasonReward)
		{
			output.WriteRawTag(80);
			output.WriteBool(ObtainableSeasonReward);
		}
		if (TodaySupporterUseCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(TodaySupporterUseCount);
		}
		if (TotalSupporterRentalCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(TotalSupporterRentalCount);
		}
		if (TopGuildScore != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(TopGuildScore);
		}
		playDay_.WriteTo(ref output, _repeated_playDay_codec);
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
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Season);
		}
		if (RaidDay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RaidDay);
		}
		if (TodayNormalBattleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TodayNormalBattleCount);
		}
		if (UserScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UserScore);
		}
		if (LastScoreRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastScoreRewardId);
		}
		if (GuildTotalScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(GuildTotalScore);
		}
		if (GuildTopPercent != 0.0)
		{
			num += 9;
		}
		if (GolemLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GolemLevel);
		}
		if (GolemExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GolemExp);
		}
		if (ObtainableSeasonReward)
		{
			num += 2;
		}
		if (TodaySupporterUseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TodaySupporterUseCount);
		}
		if (TotalSupporterRentalCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalSupporterRentalCount);
		}
		if (TopGuildScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(TopGuildScore);
		}
		num += playDay_.CalculateSize(_repeated_playDay_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildRaidMainInfoResponse other)
	{
		if (other != null)
		{
			if (other.Season != 0)
			{
				Season = other.Season;
			}
			if (other.RaidDay != 0)
			{
				RaidDay = other.RaidDay;
			}
			if (other.TodayNormalBattleCount != 0)
			{
				TodayNormalBattleCount = other.TodayNormalBattleCount;
			}
			if (other.UserScore != 0L)
			{
				UserScore = other.UserScore;
			}
			if (other.LastScoreRewardId != 0)
			{
				LastScoreRewardId = other.LastScoreRewardId;
			}
			if (other.GuildTotalScore != 0L)
			{
				GuildTotalScore = other.GuildTotalScore;
			}
			if (other.GuildTopPercent != 0.0)
			{
				GuildTopPercent = other.GuildTopPercent;
			}
			if (other.GolemLevel != 0)
			{
				GolemLevel = other.GolemLevel;
			}
			if (other.GolemExp != 0)
			{
				GolemExp = other.GolemExp;
			}
			if (other.ObtainableSeasonReward)
			{
				ObtainableSeasonReward = other.ObtainableSeasonReward;
			}
			if (other.TodaySupporterUseCount != 0)
			{
				TodaySupporterUseCount = other.TodaySupporterUseCount;
			}
			if (other.TotalSupporterRentalCount != 0)
			{
				TotalSupporterRentalCount = other.TotalSupporterRentalCount;
			}
			if (other.TopGuildScore != 0L)
			{
				TopGuildScore = other.TopGuildScore;
			}
			playDay_.Add(other.playDay_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				Season = input.ReadInt32();
				break;
			case 16u:
				RaidDay = input.ReadInt32();
				break;
			case 24u:
				TodayNormalBattleCount = input.ReadInt32();
				break;
			case 32u:
				UserScore = input.ReadInt64();
				break;
			case 40u:
				LastScoreRewardId = input.ReadInt32();
				break;
			case 48u:
				GuildTotalScore = input.ReadInt64();
				break;
			case 57u:
				GuildTopPercent = input.ReadDouble();
				break;
			case 64u:
				GolemLevel = input.ReadInt32();
				break;
			case 72u:
				GolemExp = input.ReadInt32();
				break;
			case 80u:
				ObtainableSeasonReward = input.ReadBool();
				break;
			case 88u:
				TodaySupporterUseCount = input.ReadInt32();
				break;
			case 96u:
				TotalSupporterRentalCount = input.ReadInt32();
				break;
			case 104u:
				TopGuildScore = input.ReadInt64();
				break;
			case 112u:
			case 114u:
				playDay_.AddEntriesFrom(ref input, _repeated_playDay_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
