using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class OverwhelmMonsterInfo : IMessage<OverwhelmMonsterInfo>, IMessage, IEquatable<OverwhelmMonsterInfo>, IDeepCloneable<OverwhelmMonsterInfo>, IBufferMessage
{
	private static readonly MessageParser<OverwhelmMonsterInfo> _parser = new MessageParser<OverwhelmMonsterInfo>(() => new OverwhelmMonsterInfo());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int MonsterIdFieldNumber = 2;

	private int monsterId_;

	public const int BattleDeckFieldNumber = 3;

	private int battleDeck_;

	public const int BattleModeFieldNumber = 4;

	private int battleMode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OverwhelmMonsterInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OverwhelmRequestReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleDeck
	{
		get
		{
			return battleDeck_;
		}
		set
		{
			battleDeck_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleMode
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
	public OverwhelmMonsterInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmMonsterInfo(OverwhelmMonsterInfo other)
		: this()
	{
		groupId_ = other.groupId_;
		monsterId_ = other.monsterId_;
		battleDeck_ = other.battleDeck_;
		battleMode_ = other.battleMode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmMonsterInfo Clone()
	{
		return new OverwhelmMonsterInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as OverwhelmMonsterInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(OverwhelmMonsterInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && MonsterId == other.MonsterId && BattleDeck == other.BattleDeck && BattleMode == other.BattleMode)
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
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (BattleDeck != 0)
		{
			num ^= BattleDeck.GetHashCode();
		}
		if (BattleMode != 0)
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MonsterId);
		}
		if (BattleDeck != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleDeck);
		}
		if (BattleMode != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BattleMode);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterId);
		}
		if (BattleDeck != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDeck);
		}
		if (BattleMode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleMode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OverwhelmMonsterInfo other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.BattleDeck != 0)
			{
				BattleDeck = other.BattleDeck;
			}
			if (other.BattleMode != 0)
			{
				BattleMode = other.BattleMode;
			}
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
				MonsterId = input.ReadInt32();
				break;
			case 24u:
				BattleDeck = input.ReadInt32();
				break;
			case 32u:
				BattleMode = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
