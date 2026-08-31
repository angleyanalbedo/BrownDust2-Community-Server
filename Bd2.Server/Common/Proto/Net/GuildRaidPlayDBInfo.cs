using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidPlayDBInfo : IMessage<GuildRaidPlayDBInfo>, IMessage, IEquatable<GuildRaidPlayDBInfo>, IDeepCloneable<GuildRaidPlayDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidPlayDBInfo> _parser = new MessageParser<GuildRaidPlayDBInfo>(() => new GuildRaidPlayDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int BossScoreFieldNumber = 1;

	private long bossScore_;

	public const int TotalScoreFieldNumber = 2;

	private int totalScore_;

	public const int TopPercentFieldNumber = 3;

	private double topPercent_;

	public const int IsPlayRaidTodayFieldNumber = 4;

	private bool isPlayRaidToday_;

	public const int IsNormalBattlePlayFieldNumber = 5;

	private bool isNormalBattlePlay_;

	public const int BattleModeFieldNumber = 6;

	private Define_BattleModeType battleMode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRaidPlayDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidPlayDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long BossScore
	{
		get
		{
			return bossScore_;
		}
		set
		{
			bossScore_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalScore
	{
		get
		{
			return totalScore_;
		}
		set
		{
			totalScore_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double TopPercent
	{
		get
		{
			return topPercent_;
		}
		set
		{
			topPercent_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsPlayRaidToday
	{
		get
		{
			return isPlayRaidToday_;
		}
		set
		{
			isPlayRaidToday_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsNormalBattlePlay
	{
		get
		{
			return isNormalBattlePlay_;
		}
		set
		{
			isNormalBattlePlay_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_BattleModeType BattleMode
	{
		get
		{
			return battleMode_;
		}
		set
		{
			battleMode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidPlayDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidPlayDBInfo(GuildRaidPlayDBInfo other)
		: this()
	{
		bossScore_ = other.bossScore_;
		totalScore_ = other.totalScore_;
		topPercent_ = other.topPercent_;
		isPlayRaidToday_ = other.isPlayRaidToday_;
		isNormalBattlePlay_ = other.isNormalBattlePlay_;
		battleMode_ = other.battleMode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidPlayDBInfo Clone()
	{
		return new GuildRaidPlayDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidPlayDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRaidPlayDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BossScore == other.BossScore && TotalScore == other.TotalScore && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TopPercent, other.TopPercent) && IsPlayRaidToday == other.IsPlayRaidToday && IsNormalBattlePlay == other.IsNormalBattlePlay && BattleMode == other.BattleMode)
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
		if (BossScore != 0L)
		{
			num ^= BossScore.GetHashCode();
		}
		if (TotalScore != 0)
		{
			num ^= TotalScore.GetHashCode();
		}
		if (TopPercent != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TopPercent);
		}
		if (IsPlayRaidToday)
		{
			num ^= IsPlayRaidToday.GetHashCode();
		}
		if (IsNormalBattlePlay)
		{
			num ^= IsNormalBattlePlay.GetHashCode();
		}
		if (BattleMode != Define_BattleModeType.None)
		{
			num ^= BattleMode.GetHashCode();
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
		if (BossScore != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(BossScore);
		}
		if (TotalScore != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TotalScore);
		}
		if (TopPercent != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(TopPercent);
		}
		if (IsPlayRaidToday)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsPlayRaidToday);
		}
		if (IsNormalBattlePlay)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsNormalBattlePlay);
		}
		if (BattleMode != Define_BattleModeType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)BattleMode);
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
		if (BossScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BossScore);
		}
		if (TotalScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalScore);
		}
		if (TopPercent != 0.0)
		{
			num += 9;
		}
		if (IsPlayRaidToday)
		{
			num += 2;
		}
		if (IsNormalBattlePlay)
		{
			num += 2;
		}
		if (BattleMode != Define_BattleModeType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BattleMode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRaidPlayDBInfo other)
	{
		if (other != null)
		{
			if (other.BossScore != 0L)
			{
				BossScore = other.BossScore;
			}
			if (other.TotalScore != 0)
			{
				TotalScore = other.TotalScore;
			}
			if (other.TopPercent != 0.0)
			{
				TopPercent = other.TopPercent;
			}
			if (other.IsPlayRaidToday)
			{
				IsPlayRaidToday = other.IsPlayRaidToday;
			}
			if (other.IsNormalBattlePlay)
			{
				IsNormalBattlePlay = other.IsNormalBattlePlay;
			}
			if (other.BattleMode != Define_BattleModeType.None)
			{
				BattleMode = other.BattleMode;
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
				BossScore = input.ReadInt64();
				break;
			case 16u:
				TotalScore = input.ReadInt32();
				break;
			case 25u:
				TopPercent = input.ReadDouble();
				break;
			case 32u:
				IsPlayRaidToday = input.ReadBool();
				break;
			case 40u:
				IsNormalBattlePlay = input.ReadBool();
				break;
			case 48u:
				BattleMode = (Define_BattleModeType)input.ReadEnum();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
