using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidBossBattleHistoryResponse : IMessage<GuildRaidBossBattleHistoryResponse>, IMessage, IEquatable<GuildRaidBossBattleHistoryResponse>, IDeepCloneable<GuildRaidBossBattleHistoryResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidBossBattleHistoryResponse> _parser = new MessageParser<GuildRaidBossBattleHistoryResponse>(() => new GuildRaidBossBattleHistoryResponse());

	private UnknownFieldSet _unknownFields;

	public const int TodayHighestLevelFieldNumber = 1;

	private int todayHighestLevel_;

	public const int TodayHighestScoreFieldNumber = 2;

	private long todayHighestScore_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRaidBossBattleHistoryResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildRaidBossBattleHistoryResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public GuildRaidBossBattleHistoryResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidBossBattleHistoryResponse(GuildRaidBossBattleHistoryResponse other)
		: this()
	{
		todayHighestLevel_ = other.todayHighestLevel_;
		todayHighestScore_ = other.todayHighestScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidBossBattleHistoryResponse Clone()
	{
		return new GuildRaidBossBattleHistoryResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidBossBattleHistoryResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRaidBossBattleHistoryResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (TodayHighestLevel == other.TodayHighestLevel && TodayHighestScore == other.TodayHighestScore)
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
		if (TodayHighestLevel != 0)
		{
			num ^= TodayHighestLevel.GetHashCode();
		}
		if (TodayHighestScore != 0L)
		{
			num ^= TodayHighestScore.GetHashCode();
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
		if (TodayHighestLevel != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TodayHighestLevel);
		}
		if (TodayHighestScore != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(TodayHighestScore);
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
		if (TodayHighestLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TodayHighestLevel);
		}
		if (TodayHighestScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(TodayHighestScore);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRaidBossBattleHistoryResponse other)
	{
		if (other != null)
		{
			if (other.TodayHighestLevel != 0)
			{
				TodayHighestLevel = other.TodayHighestLevel;
			}
			if (other.TodayHighestScore != 0L)
			{
				TodayHighestScore = other.TodayHighestScore;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				TodayHighestScore = input.ReadInt64();
				break;
			case 8u:
				TodayHighestLevel = input.ReadInt32();
				break;
			}
		}
	}
}
