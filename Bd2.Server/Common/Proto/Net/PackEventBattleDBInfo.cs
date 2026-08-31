using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackEventBattleDBInfo : IMessage<PackEventBattleDBInfo>, IMessage, IEquatable<PackEventBattleDBInfo>, IDeepCloneable<PackEventBattleDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PackEventBattleDBInfo> _parser = new MessageParser<PackEventBattleDBInfo>(() => new PackEventBattleDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int EventUidFieldNumber = 1;

	private int eventUid_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int BattleChallengeIndexFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_battleChallengeIndex_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> battleChallengeIndex_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackEventBattleDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackEventBattleDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventUid
	{
		get
		{
			return eventUid_;
		}
		set
		{
			eventUid_ = value;
		}
	}

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
	public RepeatedField<int> BattleChallengeIndex => battleChallengeIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventBattleDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventBattleDBInfo(PackEventBattleDBInfo other)
		: this()
	{
		eventUid_ = other.eventUid_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		battleChallengeIndex_ = other.battleChallengeIndex_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventBattleDBInfo Clone()
	{
		return new PackEventBattleDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackEventBattleDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PackEventBattleDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventUid == other.EventUid && GroupId == other.GroupId && Id == other.Id && battleChallengeIndex_.Equals(other.battleChallengeIndex_))
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
		if (EventUid != 0)
		{
			num ^= EventUid.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (EventUid != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventUid);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
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
		if (EventUid != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventUid);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
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
	public void MergeFrom(PackEventBattleDBInfo other)
	{
		if (other != null)
		{
			if (other.EventUid != 0)
			{
				EventUid = other.EventUid;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
				EventUid = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				battleChallengeIndex_.AddEntriesFrom(ref input, _repeated_battleChallengeIndex_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
