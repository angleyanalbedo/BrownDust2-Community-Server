using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidBossBattleInfoResponse : IMessage<GuildRaidBossBattleInfoResponse>, IMessage, IEquatable<GuildRaidBossBattleInfoResponse>, IDeepCloneable<GuildRaidBossBattleInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidBossBattleInfoResponse> _parser = new MessageParser<GuildRaidBossBattleInfoResponse>(() => new GuildRaidBossBattleInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int GuildTotalScoreFieldNumber = 1;

	private long guildTotalScore_;

	public const int GuildTopPercentFieldNumber = 2;

	private double guildTopPercent_;

	public const int HighestLevelFieldNumber = 3;

	private int highestLevel_;

	public const int HighestScoreFieldNumber = 4;

	private long highestScore_;

	public const int TodayHighestLevelFieldNumber = 5;

	private int todayHighestLevel_;

	public const int TodayHighestScoreFieldNumber = 6;

	private long todayHighestScore_;

	public const int IsPossibleQuickBattleFieldNumber = 7;

	private bool isPossibleQuickBattle_;

	public const int TopMemberOwnerIndexFieldNumber = 8;

	private long topMemberOwnerIndex_;

	public const int TopMemberUserIdFieldNumber = 9;

	private string topMemberUserId_ = "";

	public const int TopMemberScoreFieldNumber = 10;

	private int topMemberScore_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRaidBossBattleInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildRaidBossBattleInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HighestLevel
	{
		get
		{
			return highestLevel_;
		}
		set
		{
			highestLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long HighestScore
	{
		get
		{
			return highestScore_;
		}
		set
		{
			highestScore_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TodayHighestLevel
	{
		get
		{
			return todayHighestLevel_;
		}
		set
		{
			todayHighestLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TodayHighestScore
	{
		get
		{
			return todayHighestScore_;
		}
		set
		{
			todayHighestScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsPossibleQuickBattle
	{
		get
		{
			return isPossibleQuickBattle_;
		}
		set
		{
			isPossibleQuickBattle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TopMemberOwnerIndex
	{
		get
		{
			return topMemberOwnerIndex_;
		}
		set
		{
			topMemberOwnerIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TopMemberUserId
	{
		get
		{
			return topMemberUserId_;
		}
		set
		{
			topMemberUserId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TopMemberScore
	{
		get
		{
			return topMemberScore_;
		}
		set
		{
			topMemberScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidBossBattleInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidBossBattleInfoResponse(GuildRaidBossBattleInfoResponse other)
		: this()
	{
		guildTotalScore_ = other.guildTotalScore_;
		guildTopPercent_ = other.guildTopPercent_;
		highestLevel_ = other.highestLevel_;
		highestScore_ = other.highestScore_;
		todayHighestLevel_ = other.todayHighestLevel_;
		todayHighestScore_ = other.todayHighestScore_;
		isPossibleQuickBattle_ = other.isPossibleQuickBattle_;
		topMemberOwnerIndex_ = other.topMemberOwnerIndex_;
		topMemberUserId_ = other.topMemberUserId_;
		topMemberScore_ = other.topMemberScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidBossBattleInfoResponse Clone()
	{
		return new GuildRaidBossBattleInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidBossBattleInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRaidBossBattleInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GuildTotalScore == other.GuildTotalScore && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GuildTopPercent, other.GuildTopPercent) && HighestLevel == other.HighestLevel && HighestScore == other.HighestScore && TodayHighestLevel == other.TodayHighestLevel && TodayHighestScore == other.TodayHighestScore && IsPossibleQuickBattle == other.IsPossibleQuickBattle && TopMemberOwnerIndex == other.TopMemberOwnerIndex && !(TopMemberUserId != other.TopMemberUserId) && TopMemberScore == other.TopMemberScore)
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
		if (GuildTotalScore != 0L)
		{
			num ^= GuildTotalScore.GetHashCode();
		}
		if (GuildTopPercent != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GuildTopPercent);
		}
		if (HighestLevel != 0)
		{
			num ^= HighestLevel.GetHashCode();
		}
		if (HighestScore != 0L)
		{
			num ^= HighestScore.GetHashCode();
		}
		if (TodayHighestLevel != 0)
		{
			num ^= TodayHighestLevel.GetHashCode();
		}
		if (TodayHighestScore != 0L)
		{
			num ^= TodayHighestScore.GetHashCode();
		}
		if (IsPossibleQuickBattle)
		{
			num ^= IsPossibleQuickBattle.GetHashCode();
		}
		if (TopMemberOwnerIndex != 0L)
		{
			num ^= TopMemberOwnerIndex.GetHashCode();
		}
		if (TopMemberUserId.Length != 0)
		{
			num ^= TopMemberUserId.GetHashCode();
		}
		if (TopMemberScore != 0)
		{
			num ^= TopMemberScore.GetHashCode();
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
		if (GuildTotalScore != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(GuildTotalScore);
		}
		if (GuildTopPercent != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(GuildTopPercent);
		}
		if (HighestLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(HighestLevel);
		}
		if (HighestScore != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(HighestScore);
		}
		if (TodayHighestLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TodayHighestLevel);
		}
		if (TodayHighestScore != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(TodayHighestScore);
		}
		if (IsPossibleQuickBattle)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsPossibleQuickBattle);
		}
		if (TopMemberOwnerIndex != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(TopMemberOwnerIndex);
		}
		if (TopMemberUserId.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(TopMemberUserId);
		}
		if (TopMemberScore != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TopMemberScore);
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
		if (GuildTotalScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(GuildTotalScore);
		}
		if (GuildTopPercent != 0.0)
		{
			num += 9;
		}
		if (HighestLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HighestLevel);
		}
		if (HighestScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(HighestScore);
		}
		if (TodayHighestLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TodayHighestLevel);
		}
		if (TodayHighestScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(TodayHighestScore);
		}
		if (IsPossibleQuickBattle)
		{
			num += 2;
		}
		if (TopMemberOwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(TopMemberOwnerIndex);
		}
		if (TopMemberUserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TopMemberUserId);
		}
		if (TopMemberScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TopMemberScore);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRaidBossBattleInfoResponse other)
	{
		if (other != null)
		{
			if (other.GuildTotalScore != 0L)
			{
				GuildTotalScore = other.GuildTotalScore;
			}
			if (other.GuildTopPercent != 0.0)
			{
				GuildTopPercent = other.GuildTopPercent;
			}
			if (other.HighestLevel != 0)
			{
				HighestLevel = other.HighestLevel;
			}
			if (other.HighestScore != 0L)
			{
				HighestScore = other.HighestScore;
			}
			if (other.TodayHighestLevel != 0)
			{
				TodayHighestLevel = other.TodayHighestLevel;
			}
			if (other.TodayHighestScore != 0L)
			{
				TodayHighestScore = other.TodayHighestScore;
			}
			if (other.IsPossibleQuickBattle)
			{
				IsPossibleQuickBattle = other.IsPossibleQuickBattle;
			}
			if (other.TopMemberOwnerIndex != 0L)
			{
				TopMemberOwnerIndex = other.TopMemberOwnerIndex;
			}
			if (other.TopMemberUserId.Length != 0)
			{
				TopMemberUserId = other.TopMemberUserId;
			}
			if (other.TopMemberScore != 0)
			{
				TopMemberScore = other.TopMemberScore;
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
				GuildTotalScore = input.ReadInt64();
				break;
			case 17u:
				GuildTopPercent = input.ReadDouble();
				break;
			case 24u:
				HighestLevel = input.ReadInt32();
				break;
			case 32u:
				HighestScore = input.ReadInt64();
				break;
			case 40u:
				TodayHighestLevel = input.ReadInt32();
				break;
			case 48u:
				TodayHighestScore = input.ReadInt64();
				break;
			case 56u:
				IsPossibleQuickBattle = input.ReadBool();
				break;
			case 64u:
				TopMemberOwnerIndex = input.ReadInt64();
				break;
			case 74u:
				TopMemberUserId = input.ReadString();
				break;
			case 80u:
				TopMemberScore = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
