using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleEnterRequest : IMessage<BattleEnterRequest>, IMessage, IEquatable<BattleEnterRequest>, IDeepCloneable<BattleEnterRequest>, IBufferMessage
{
	private static readonly MessageParser<BattleEnterRequest> _parser = new MessageParser<BattleEnterRequest>(() => new BattleEnterRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int MonsterIdFieldNumber = 3;

	private int monsterId_;

	public const int BattleDeckFieldNumber = 4;

	private int battleDeck_;

	public const int BattleModeFieldNumber = 5;

	private int battleMode_;

	public const int MonsterHuntIdFieldNumber = 6;

	private int monsterHuntId_;

	public const int IsContinueFieldNumber = 7;

	private bool isContinue_;

	public const int StageMagicGroupIdFieldNumber = 8;

	private int stageMagicGroupId_;

	public const int StageMagicIdFieldNumber = 9;

	private int stageMagicId_;

	public const int StageMagicLevelFieldNumber = 10;

	private int stageMagicLevel_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BattleEnterRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => BattleEnterRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int MonsterHuntId
	{
		get
		{
			return monsterHuntId_;
		}
		set
		{
			monsterHuntId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsContinue
	{
		get
		{
			return isContinue_;
		}
		set
		{
			isContinue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StageMagicGroupId
	{
		get
		{
			return stageMagicGroupId_;
		}
		set
		{
			stageMagicGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StageMagicId
	{
		get
		{
			return stageMagicId_;
		}
		set
		{
			stageMagicId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StageMagicLevel
	{
		get
		{
			return stageMagicLevel_;
		}
		set
		{
			stageMagicLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEnterRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEnterRequest(BattleEnterRequest other)
		: this()
	{
		seq_ = other.seq_;
		groupId_ = other.groupId_;
		monsterId_ = other.monsterId_;
		battleDeck_ = other.battleDeck_;
		battleMode_ = other.battleMode_;
		monsterHuntId_ = other.monsterHuntId_;
		isContinue_ = other.isContinue_;
		stageMagicGroupId_ = other.stageMagicGroupId_;
		stageMagicId_ = other.stageMagicId_;
		stageMagicLevel_ = other.stageMagicLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleEnterRequest Clone()
	{
		return new BattleEnterRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleEnterRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleEnterRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && GroupId == other.GroupId && MonsterId == other.MonsterId && BattleDeck == other.BattleDeck && BattleMode == other.BattleMode && MonsterHuntId == other.MonsterHuntId && IsContinue == other.IsContinue && StageMagicGroupId == other.StageMagicGroupId && StageMagicId == other.StageMagicId && StageMagicLevel == other.StageMagicLevel)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
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
		if (MonsterHuntId != 0)
		{
			num ^= MonsterHuntId.GetHashCode();
		}
		if (IsContinue)
		{
			num ^= IsContinue.GetHashCode();
		}
		if (StageMagicGroupId != 0)
		{
			num ^= StageMagicGroupId.GetHashCode();
		}
		if (StageMagicId != 0)
		{
			num ^= StageMagicId.GetHashCode();
		}
		if (StageMagicLevel != 0)
		{
			num ^= StageMagicLevel.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MonsterId);
		}
		if (BattleDeck != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BattleDeck);
		}
		if (BattleMode != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BattleMode);
		}
		if (MonsterHuntId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MonsterHuntId);
		}
		if (IsContinue)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsContinue);
		}
		if (StageMagicGroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(StageMagicGroupId);
		}
		if (StageMagicId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(StageMagicId);
		}
		if (StageMagicLevel != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(StageMagicLevel);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
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
		if (MonsterHuntId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterHuntId);
		}
		if (IsContinue)
		{
			num += 2;
		}
		if (StageMagicGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageMagicGroupId);
		}
		if (StageMagicId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageMagicId);
		}
		if (StageMagicLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageMagicLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BattleEnterRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
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
			if (other.MonsterHuntId != 0)
			{
				MonsterHuntId = other.MonsterHuntId;
			}
			if (other.IsContinue)
			{
				IsContinue = other.IsContinue;
			}
			if (other.StageMagicGroupId != 0)
			{
				StageMagicGroupId = other.StageMagicGroupId;
			}
			if (other.StageMagicId != 0)
			{
				StageMagicId = other.StageMagicId;
			}
			if (other.StageMagicLevel != 0)
			{
				StageMagicLevel = other.StageMagicLevel;
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				MonsterId = input.ReadInt32();
				break;
			case 32u:
				BattleDeck = input.ReadInt32();
				break;
			case 40u:
				BattleMode = input.ReadInt32();
				break;
			case 48u:
				MonsterHuntId = input.ReadInt32();
				break;
			case 56u:
				IsContinue = input.ReadBool();
				break;
			case 64u:
				StageMagicGroupId = input.ReadInt32();
				break;
			case 72u:
				StageMagicId = input.ReadInt32();
				break;
			case 80u:
				StageMagicLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
