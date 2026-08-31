using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleUserDeckInfo : IMessage<PvpBattleUserDeckInfo>, IMessage, IEquatable<PvpBattleUserDeckInfo>, IDeepCloneable<PvpBattleUserDeckInfo>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleUserDeckInfo> _parser = new MessageParser<PvpBattleUserDeckInfo>(() => new PvpBattleUserDeckInfo());

	private UnknownFieldSet _unknownFields;

	public const int CharInvenIndexFieldNumber = 1;

	private long charInvenIndex_;

	public const int PositionFieldNumber = 2;

	private int position_;

	public const int SequenceFieldNumber = 3;

	private int sequence_;

	public const int CostumeInvenIndexFieldNumber = 4;

	private long costumeInvenIndex_;

	public const int CostumeInvenIndexSeqFieldNumber = 5;

	private static readonly FieldCodec<long> _repeated_costumeInvenIndexSeq_codec = FieldCodec.ForInt64(42u);

	private readonly RepeatedField<long> costumeInvenIndexSeq_ = new RepeatedField<long>();

	public const int PrioritySkillCostumeInvenIndexFieldNumber = 6;

	private static readonly FieldCodec<long> _repeated_prioritySkillCostumeInvenIndex_codec = FieldCodec.ForInt64(50u);

	private readonly RepeatedField<long> prioritySkillCostumeInvenIndex_ = new RepeatedField<long>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleUserDeckInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleUserDeckInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharInvenIndex
	{
		get
		{
			return charInvenIndex_;
		}
		set
		{
			charInvenIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Sequence
	{
		get
		{
			return sequence_;
		}
		set
		{
			sequence_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CostumeInvenIndex
	{
		get
		{
			return costumeInvenIndex_;
		}
		set
		{
			costumeInvenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> CostumeInvenIndexSeq => costumeInvenIndexSeq_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> PrioritySkillCostumeInvenIndex => prioritySkillCostumeInvenIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserDeckInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserDeckInfo(PvpBattleUserDeckInfo other)
		: this()
	{
		charInvenIndex_ = other.charInvenIndex_;
		position_ = other.position_;
		sequence_ = other.sequence_;
		costumeInvenIndex_ = other.costumeInvenIndex_;
		costumeInvenIndexSeq_ = other.costumeInvenIndexSeq_.Clone();
		prioritySkillCostumeInvenIndex_ = other.prioritySkillCostumeInvenIndex_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleUserDeckInfo Clone()
	{
		return new PvpBattleUserDeckInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleUserDeckInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleUserDeckInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CharInvenIndex == other.CharInvenIndex && Position == other.Position && Sequence == other.Sequence && CostumeInvenIndex == other.CostumeInvenIndex && costumeInvenIndexSeq_.Equals(other.costumeInvenIndexSeq_) && prioritySkillCostumeInvenIndex_.Equals(other.prioritySkillCostumeInvenIndex_))
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
		if (CharInvenIndex != 0L)
		{
			num ^= CharInvenIndex.GetHashCode();
		}
		if (Position != 0)
		{
			num ^= Position.GetHashCode();
		}
		if (Sequence != 0)
		{
			num ^= Sequence.GetHashCode();
		}
		if (CostumeInvenIndex != 0L)
		{
			num ^= CostumeInvenIndex.GetHashCode();
		}
		num ^= costumeInvenIndexSeq_.GetHashCode();
		num ^= prioritySkillCostumeInvenIndex_.GetHashCode();
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
		if (CharInvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(CharInvenIndex);
		}
		if (Position != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Position);
		}
		if (Sequence != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Sequence);
		}
		if (CostumeInvenIndex != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(CostumeInvenIndex);
		}
		costumeInvenIndexSeq_.WriteTo(ref output, _repeated_costumeInvenIndexSeq_codec);
		prioritySkillCostumeInvenIndex_.WriteTo(ref output, _repeated_prioritySkillCostumeInvenIndex_codec);
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
		if (CharInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CharInvenIndex);
		}
		if (Position != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Position);
		}
		if (Sequence != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Sequence);
		}
		if (CostumeInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CostumeInvenIndex);
		}
		num += costumeInvenIndexSeq_.CalculateSize(_repeated_costumeInvenIndexSeq_codec);
		num += prioritySkillCostumeInvenIndex_.CalculateSize(_repeated_prioritySkillCostumeInvenIndex_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleUserDeckInfo other)
	{
		if (other != null)
		{
			if (other.CharInvenIndex != 0L)
			{
				CharInvenIndex = other.CharInvenIndex;
			}
			if (other.Position != 0)
			{
				Position = other.Position;
			}
			if (other.Sequence != 0)
			{
				Sequence = other.Sequence;
			}
			if (other.CostumeInvenIndex != 0L)
			{
				CostumeInvenIndex = other.CostumeInvenIndex;
			}
			costumeInvenIndexSeq_.Add(other.costumeInvenIndexSeq_);
			prioritySkillCostumeInvenIndex_.Add(other.prioritySkillCostumeInvenIndex_);
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
				CharInvenIndex = input.ReadInt64();
				break;
			case 16u:
				Position = input.ReadInt32();
				break;
			case 24u:
				Sequence = input.ReadInt32();
				break;
			case 32u:
				CostumeInvenIndex = input.ReadInt64();
				break;
			case 40u:
			case 42u:
				costumeInvenIndexSeq_.AddEntriesFrom(ref input, _repeated_costumeInvenIndexSeq_codec);
				break;
			case 48u:
			case 50u:
				prioritySkillCostumeInvenIndex_.AddEntriesFrom(ref input, _repeated_prioritySkillCostumeInvenIndex_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
