using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidBattleScoreInfo : IMessage<GuildRaidBattleScoreInfo>, IMessage, IEquatable<GuildRaidBattleScoreInfo>, IDeepCloneable<GuildRaidBattleScoreInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidBattleScoreInfo> _parser = new MessageParser<GuildRaidBattleScoreInfo>(() => new GuildRaidBattleScoreInfo());

	private UnknownFieldSet _unknownFields;

	public const int DefaultScoreFieldNumber = 1;

	private int defaultScore_;

	public const int TurnBonusScoreFieldNumber = 2;

	private int turnBonusScore_;

	public const int GolemLevelBonusScoreFieldNumber = 3;

	private int golemLevelBonusScore_;

	public const int GuildTotalScoreFieldNumber = 4;

	private long guildTotalScore_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRaidBattleScoreInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidBattleScoreInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DefaultScore
	{
		get
		{
			return defaultScore_;
		}
		set
		{
			defaultScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TurnBonusScore
	{
		get
		{
			return turnBonusScore_;
		}
		set
		{
			turnBonusScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GolemLevelBonusScore
	{
		get
		{
			return golemLevelBonusScore_;
		}
		set
		{
			golemLevelBonusScore_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public GuildRaidBattleScoreInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidBattleScoreInfo(GuildRaidBattleScoreInfo other)
		: this()
	{
		defaultScore_ = other.defaultScore_;
		turnBonusScore_ = other.turnBonusScore_;
		golemLevelBonusScore_ = other.golemLevelBonusScore_;
		guildTotalScore_ = other.guildTotalScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidBattleScoreInfo Clone()
	{
		return new GuildRaidBattleScoreInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidBattleScoreInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRaidBattleScoreInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DefaultScore == other.DefaultScore && TurnBonusScore == other.TurnBonusScore && GolemLevelBonusScore == other.GolemLevelBonusScore && GuildTotalScore == other.GuildTotalScore)
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
		if (DefaultScore != 0)
		{
			num ^= DefaultScore.GetHashCode();
		}
		if (TurnBonusScore != 0)
		{
			num ^= TurnBonusScore.GetHashCode();
		}
		if (GolemLevelBonusScore != 0)
		{
			num ^= GolemLevelBonusScore.GetHashCode();
		}
		if (GuildTotalScore != 0L)
		{
			num ^= GuildTotalScore.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (DefaultScore != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DefaultScore);
		}
		if (TurnBonusScore != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TurnBonusScore);
		}
		if (GolemLevelBonusScore != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GolemLevelBonusScore);
		}
		if (GuildTotalScore != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(GuildTotalScore);
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
		if (DefaultScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultScore);
		}
		if (TurnBonusScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TurnBonusScore);
		}
		if (GolemLevelBonusScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GolemLevelBonusScore);
		}
		if (GuildTotalScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(GuildTotalScore);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRaidBattleScoreInfo other)
	{
		if (other != null)
		{
			if (other.DefaultScore != 0)
			{
				DefaultScore = other.DefaultScore;
			}
			if (other.TurnBonusScore != 0)
			{
				TurnBonusScore = other.TurnBonusScore;
			}
			if (other.GolemLevelBonusScore != 0)
			{
				GolemLevelBonusScore = other.GolemLevelBonusScore;
			}
			if (other.GuildTotalScore != 0L)
			{
				GuildTotalScore = other.GuildTotalScore;
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
				DefaultScore = input.ReadInt32();
				break;
			case 16u:
				TurnBonusScore = input.ReadInt32();
				break;
			case 24u:
				GolemLevelBonusScore = input.ReadInt32();
				break;
			case 32u:
				GuildTotalScore = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
