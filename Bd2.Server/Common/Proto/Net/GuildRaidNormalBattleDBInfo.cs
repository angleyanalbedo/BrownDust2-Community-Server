using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidNormalBattleDBInfo : IMessage<GuildRaidNormalBattleDBInfo>, IMessage, IEquatable<GuildRaidNormalBattleDBInfo>, IDeepCloneable<GuildRaidNormalBattleDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidNormalBattleDBInfo> _parser = new MessageParser<GuildRaidNormalBattleDBInfo>(() => new GuildRaidNormalBattleDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int LevelFieldNumber = 3;

	private int level_;

	public const int CompleteWinCountFieldNumber = 4;

	private int completeWinCount_;

	public const int BattleChallengeIndexFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_battleChallengeIndex_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> battleChallengeIndex_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRaidNormalBattleDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidNormalBattleDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int CompleteWinCount
	{
		get
		{
			return completeWinCount_;
		}
		set
		{
			completeWinCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BattleChallengeIndex => battleChallengeIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidNormalBattleDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidNormalBattleDBInfo(GuildRaidNormalBattleDBInfo other)
		: this()
	{
		groupId_ = other.groupId_;
		id_ = other.id_;
		level_ = other.level_;
		completeWinCount_ = other.completeWinCount_;
		battleChallengeIndex_ = other.battleChallengeIndex_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidNormalBattleDBInfo Clone()
	{
		return new GuildRaidNormalBattleDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidNormalBattleDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRaidNormalBattleDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && Id == other.Id && Level == other.Level && CompleteWinCount == other.CompleteWinCount && battleChallengeIndex_.Equals(other.battleChallengeIndex_))
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (CompleteWinCount != 0)
		{
			num ^= CompleteWinCount.GetHashCode();
		}
		num ^= battleChallengeIndex_.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Level);
		}
		if (CompleteWinCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CompleteWinCount);
		}
		battleChallengeIndex_.WriteTo(ref output, _repeated_battleChallengeIndex_codec);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (CompleteWinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompleteWinCount);
		}
		num += battleChallengeIndex_.CalculateSize(_repeated_battleChallengeIndex_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRaidNormalBattleDBInfo other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.CompleteWinCount != 0)
			{
				CompleteWinCount = other.CompleteWinCount;
			}
			battleChallengeIndex_.Add(other.battleChallengeIndex_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				GroupId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				Level = input.ReadInt32();
				break;
			case 32u:
				CompleteWinCount = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				battleChallengeIndex_.AddEntriesFrom(ref input, _repeated_battleChallengeIndex_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
