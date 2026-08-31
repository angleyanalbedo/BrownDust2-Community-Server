using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleHistoryResponse : IMessage<PvpBattleHistoryResponse>, IMessage, IEquatable<PvpBattleHistoryResponse>, IDeepCloneable<PvpBattleHistoryResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleHistoryResponse> _parser = new MessageParser<PvpBattleHistoryResponse>(() => new PvpBattleHistoryResponse());

	private UnknownFieldSet _unknownFields;

	public const int AttackHistoryInfoFieldNumber = 1;

	private static readonly FieldCodec<PvpBattleHistoryInfo> _repeated_attackHistoryInfo_codec = FieldCodec.ForMessage(10u, PvpBattleHistoryInfo.Parser);

	private readonly RepeatedField<PvpBattleHistoryInfo> attackHistoryInfo_ = new RepeatedField<PvpBattleHistoryInfo>();

	public const int DefenseHistoryInfoFieldNumber = 2;

	private static readonly FieldCodec<PvpBattleHistoryInfo> _repeated_defenseHistoryInfo_codec = FieldCodec.ForMessage(18u, PvpBattleHistoryInfo.Parser);

	private readonly RepeatedField<PvpBattleHistoryInfo> defenseHistoryInfo_ = new RepeatedField<PvpBattleHistoryInfo>();

	public const int SeasonWinCountFieldNumber = 3;

	private int seasonWinCount_;

	public const int SeasonLoseCountFieldNumber = 4;

	private int seasonLoseCount_;

	public const int SeasonAttackWinCountFieldNumber = 5;

	private int seasonAttackWinCount_;

	public const int SeasonAttackLoseCountFieldNumber = 6;

	private int seasonAttackLoseCount_;

	public const int SeasonDefenseWinCountFieldNumber = 7;

	private int seasonDefenseWinCount_;

	public const int SeasonDefenseLoseCountFieldNumber = 8;

	private int seasonDefenseLoseCount_;

	public const int PrevSeasonAttackWinCountFieldNumber = 9;

	private int prevSeasonAttackWinCount_;

	public const int PrevSeasonAttackLoseCountFieldNumber = 10;

	private int prevSeasonAttackLoseCount_;

	public const int PrevSeasonDefenseWinCountFieldNumber = 11;

	private int prevSeasonDefenseWinCount_;

	public const int PrevSeasonDefenseLoseCountFieldNumber = 12;

	private int prevSeasonDefenseLoseCount_;

	public const int DeckSeasonAttackWinCountFieldNumber = 13;

	private int deckSeasonAttackWinCount_;

	public const int DeckSeasonAttackLoseCountFieldNumber = 14;

	private int deckSeasonAttackLoseCount_;

	public const int DeckSeasonDefenseWinCountFieldNumber = 15;

	private int deckSeasonDefenseWinCount_;

	public const int DeckSeasonDefenseLoseCountFieldNumber = 16;

	private int deckSeasonDefenseLoseCount_;

	public const int DeckSeasonAttackResetDateFieldNumber = 17;

	private long deckSeasonAttackResetDate_;

	public const int DeckSeasonDefenseResetDateFieldNumber = 18;

	private long deckSeasonDefenseResetDate_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpBattleHistoryResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleHistoryResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PvpBattleHistoryInfo> AttackHistoryInfo => attackHistoryInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PvpBattleHistoryInfo> DefenseHistoryInfo => defenseHistoryInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SeasonWinCount
	{
		get
		{
			return seasonWinCount_;
		}
		set
		{
			seasonWinCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SeasonLoseCount
	{
		get
		{
			return seasonLoseCount_;
		}
		set
		{
			seasonLoseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SeasonAttackWinCount
	{
		get
		{
			return seasonAttackWinCount_;
		}
		set
		{
			seasonAttackWinCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SeasonAttackLoseCount
	{
		get
		{
			return seasonAttackLoseCount_;
		}
		set
		{
			seasonAttackLoseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SeasonDefenseWinCount
	{
		get
		{
			return seasonDefenseWinCount_;
		}
		set
		{
			seasonDefenseWinCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SeasonDefenseLoseCount
	{
		get
		{
			return seasonDefenseLoseCount_;
		}
		set
		{
			seasonDefenseLoseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PrevSeasonAttackWinCount
	{
		get
		{
			return prevSeasonAttackWinCount_;
		}
		set
		{
			prevSeasonAttackWinCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PrevSeasonAttackLoseCount
	{
		get
		{
			return prevSeasonAttackLoseCount_;
		}
		set
		{
			prevSeasonAttackLoseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PrevSeasonDefenseWinCount
	{
		get
		{
			return prevSeasonDefenseWinCount_;
		}
		set
		{
			prevSeasonDefenseWinCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PrevSeasonDefenseLoseCount
	{
		get
		{
			return prevSeasonDefenseLoseCount_;
		}
		set
		{
			prevSeasonDefenseLoseCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DeckSeasonAttackWinCount
	{
		get
		{
			return deckSeasonAttackWinCount_;
		}
		set
		{
			deckSeasonAttackWinCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DeckSeasonAttackLoseCount
	{
		get
		{
			return deckSeasonAttackLoseCount_;
		}
		set
		{
			deckSeasonAttackLoseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DeckSeasonDefenseWinCount
	{
		get
		{
			return deckSeasonDefenseWinCount_;
		}
		set
		{
			deckSeasonDefenseWinCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DeckSeasonDefenseLoseCount
	{
		get
		{
			return deckSeasonDefenseLoseCount_;
		}
		set
		{
			deckSeasonDefenseLoseCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DeckSeasonAttackResetDate
	{
		get
		{
			return deckSeasonAttackResetDate_;
		}
		set
		{
			deckSeasonAttackResetDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DeckSeasonDefenseResetDate
	{
		get
		{
			return deckSeasonDefenseResetDate_;
		}
		set
		{
			deckSeasonDefenseResetDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleHistoryResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleHistoryResponse(PvpBattleHistoryResponse other)
		: this()
	{
		attackHistoryInfo_ = other.attackHistoryInfo_.Clone();
		defenseHistoryInfo_ = other.defenseHistoryInfo_.Clone();
		seasonWinCount_ = other.seasonWinCount_;
		seasonLoseCount_ = other.seasonLoseCount_;
		seasonAttackWinCount_ = other.seasonAttackWinCount_;
		seasonAttackLoseCount_ = other.seasonAttackLoseCount_;
		seasonDefenseWinCount_ = other.seasonDefenseWinCount_;
		seasonDefenseLoseCount_ = other.seasonDefenseLoseCount_;
		prevSeasonAttackWinCount_ = other.prevSeasonAttackWinCount_;
		prevSeasonAttackLoseCount_ = other.prevSeasonAttackLoseCount_;
		prevSeasonDefenseWinCount_ = other.prevSeasonDefenseWinCount_;
		prevSeasonDefenseLoseCount_ = other.prevSeasonDefenseLoseCount_;
		deckSeasonAttackWinCount_ = other.deckSeasonAttackWinCount_;
		deckSeasonAttackLoseCount_ = other.deckSeasonAttackLoseCount_;
		deckSeasonDefenseWinCount_ = other.deckSeasonDefenseWinCount_;
		deckSeasonDefenseLoseCount_ = other.deckSeasonDefenseLoseCount_;
		deckSeasonAttackResetDate_ = other.deckSeasonAttackResetDate_;
		deckSeasonDefenseResetDate_ = other.deckSeasonDefenseResetDate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleHistoryResponse Clone()
	{
		return new PvpBattleHistoryResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleHistoryResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PvpBattleHistoryResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (attackHistoryInfo_.Equals(other.attackHistoryInfo_) && defenseHistoryInfo_.Equals(other.defenseHistoryInfo_) && SeasonWinCount == other.SeasonWinCount && SeasonLoseCount == other.SeasonLoseCount && SeasonAttackWinCount == other.SeasonAttackWinCount && SeasonAttackLoseCount == other.SeasonAttackLoseCount && SeasonDefenseWinCount == other.SeasonDefenseWinCount && SeasonDefenseLoseCount == other.SeasonDefenseLoseCount && PrevSeasonAttackWinCount == other.PrevSeasonAttackWinCount && PrevSeasonAttackLoseCount == other.PrevSeasonAttackLoseCount && PrevSeasonDefenseWinCount == other.PrevSeasonDefenseWinCount && PrevSeasonDefenseLoseCount == other.PrevSeasonDefenseLoseCount && DeckSeasonAttackWinCount == other.DeckSeasonAttackWinCount && DeckSeasonAttackLoseCount == other.DeckSeasonAttackLoseCount && DeckSeasonDefenseWinCount == other.DeckSeasonDefenseWinCount && DeckSeasonDefenseLoseCount == other.DeckSeasonDefenseLoseCount && DeckSeasonAttackResetDate == other.DeckSeasonAttackResetDate && DeckSeasonDefenseResetDate == other.DeckSeasonDefenseResetDate)
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
		num ^= attackHistoryInfo_.GetHashCode();
		num ^= defenseHistoryInfo_.GetHashCode();
		if (SeasonWinCount != 0)
		{
			num ^= SeasonWinCount.GetHashCode();
		}
		if (SeasonLoseCount != 0)
		{
			num ^= SeasonLoseCount.GetHashCode();
		}
		if (SeasonAttackWinCount != 0)
		{
			num ^= SeasonAttackWinCount.GetHashCode();
		}
		if (SeasonAttackLoseCount != 0)
		{
			num ^= SeasonAttackLoseCount.GetHashCode();
		}
		if (SeasonDefenseWinCount != 0)
		{
			num ^= SeasonDefenseWinCount.GetHashCode();
		}
		if (SeasonDefenseLoseCount != 0)
		{
			num ^= SeasonDefenseLoseCount.GetHashCode();
		}
		if (PrevSeasonAttackWinCount != 0)
		{
			num ^= PrevSeasonAttackWinCount.GetHashCode();
		}
		if (PrevSeasonAttackLoseCount != 0)
		{
			num ^= PrevSeasonAttackLoseCount.GetHashCode();
		}
		if (PrevSeasonDefenseWinCount != 0)
		{
			num ^= PrevSeasonDefenseWinCount.GetHashCode();
		}
		if (PrevSeasonDefenseLoseCount != 0)
		{
			num ^= PrevSeasonDefenseLoseCount.GetHashCode();
		}
		if (DeckSeasonAttackWinCount != 0)
		{
			num ^= DeckSeasonAttackWinCount.GetHashCode();
		}
		if (DeckSeasonAttackLoseCount != 0)
		{
			num ^= DeckSeasonAttackLoseCount.GetHashCode();
		}
		if (DeckSeasonDefenseWinCount != 0)
		{
			num ^= DeckSeasonDefenseWinCount.GetHashCode();
		}
		if (DeckSeasonDefenseLoseCount != 0)
		{
			num ^= DeckSeasonDefenseLoseCount.GetHashCode();
		}
		if (DeckSeasonAttackResetDate != 0L)
		{
			num ^= DeckSeasonAttackResetDate.GetHashCode();
		}
		if (DeckSeasonDefenseResetDate != 0L)
		{
			num ^= DeckSeasonDefenseResetDate.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		attackHistoryInfo_.WriteTo(ref output, _repeated_attackHistoryInfo_codec);
		defenseHistoryInfo_.WriteTo(ref output, _repeated_defenseHistoryInfo_codec);
		if (SeasonWinCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SeasonWinCount);
		}
		if (SeasonLoseCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SeasonLoseCount);
		}
		if (SeasonAttackWinCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SeasonAttackWinCount);
		}
		if (SeasonAttackLoseCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SeasonAttackLoseCount);
		}
		if (SeasonDefenseWinCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SeasonDefenseWinCount);
		}
		if (SeasonDefenseLoseCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SeasonDefenseLoseCount);
		}
		if (PrevSeasonAttackWinCount != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PrevSeasonAttackWinCount);
		}
		if (PrevSeasonAttackLoseCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PrevSeasonAttackLoseCount);
		}
		if (PrevSeasonDefenseWinCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(PrevSeasonDefenseWinCount);
		}
		if (PrevSeasonDefenseLoseCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(PrevSeasonDefenseLoseCount);
		}
		if (DeckSeasonAttackWinCount != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(DeckSeasonAttackWinCount);
		}
		if (DeckSeasonAttackLoseCount != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(DeckSeasonAttackLoseCount);
		}
		if (DeckSeasonDefenseWinCount != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(DeckSeasonDefenseWinCount);
		}
		if (DeckSeasonDefenseLoseCount != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(DeckSeasonDefenseLoseCount);
		}
		if (DeckSeasonAttackResetDate != 0L)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt64(DeckSeasonAttackResetDate);
		}
		if (DeckSeasonDefenseResetDate != 0L)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt64(DeckSeasonDefenseResetDate);
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
		num += attackHistoryInfo_.CalculateSize(_repeated_attackHistoryInfo_codec);
		num += defenseHistoryInfo_.CalculateSize(_repeated_defenseHistoryInfo_codec);
		if (SeasonWinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeasonWinCount);
		}
		if (SeasonLoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeasonLoseCount);
		}
		if (SeasonAttackWinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeasonAttackWinCount);
		}
		if (SeasonAttackLoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeasonAttackLoseCount);
		}
		if (SeasonDefenseWinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeasonDefenseWinCount);
		}
		if (SeasonDefenseLoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeasonDefenseLoseCount);
		}
		if (PrevSeasonAttackWinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PrevSeasonAttackWinCount);
		}
		if (PrevSeasonAttackLoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PrevSeasonAttackLoseCount);
		}
		if (PrevSeasonDefenseWinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PrevSeasonDefenseWinCount);
		}
		if (PrevSeasonDefenseLoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PrevSeasonDefenseLoseCount);
		}
		if (DeckSeasonAttackWinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DeckSeasonAttackWinCount);
		}
		if (DeckSeasonAttackLoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DeckSeasonAttackLoseCount);
		}
		if (DeckSeasonDefenseWinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DeckSeasonDefenseWinCount);
		}
		if (DeckSeasonDefenseLoseCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DeckSeasonDefenseLoseCount);
		}
		if (DeckSeasonAttackResetDate != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(DeckSeasonAttackResetDate);
		}
		if (DeckSeasonDefenseResetDate != 0L)
		{
			num += 2 + CodedOutputStream.ComputeInt64Size(DeckSeasonDefenseResetDate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleHistoryResponse other)
	{
		if (other != null)
		{
			attackHistoryInfo_.Add(other.attackHistoryInfo_);
			defenseHistoryInfo_.Add(other.defenseHistoryInfo_);
			if (other.SeasonWinCount != 0)
			{
				SeasonWinCount = other.SeasonWinCount;
			}
			if (other.SeasonLoseCount != 0)
			{
				SeasonLoseCount = other.SeasonLoseCount;
			}
			if (other.SeasonAttackWinCount != 0)
			{
				SeasonAttackWinCount = other.SeasonAttackWinCount;
			}
			if (other.SeasonAttackLoseCount != 0)
			{
				SeasonAttackLoseCount = other.SeasonAttackLoseCount;
			}
			if (other.SeasonDefenseWinCount != 0)
			{
				SeasonDefenseWinCount = other.SeasonDefenseWinCount;
			}
			if (other.SeasonDefenseLoseCount != 0)
			{
				SeasonDefenseLoseCount = other.SeasonDefenseLoseCount;
			}
			if (other.PrevSeasonAttackWinCount != 0)
			{
				PrevSeasonAttackWinCount = other.PrevSeasonAttackWinCount;
			}
			if (other.PrevSeasonAttackLoseCount != 0)
			{
				PrevSeasonAttackLoseCount = other.PrevSeasonAttackLoseCount;
			}
			if (other.PrevSeasonDefenseWinCount != 0)
			{
				PrevSeasonDefenseWinCount = other.PrevSeasonDefenseWinCount;
			}
			if (other.PrevSeasonDefenseLoseCount != 0)
			{
				PrevSeasonDefenseLoseCount = other.PrevSeasonDefenseLoseCount;
			}
			if (other.DeckSeasonAttackWinCount != 0)
			{
				DeckSeasonAttackWinCount = other.DeckSeasonAttackWinCount;
			}
			if (other.DeckSeasonAttackLoseCount != 0)
			{
				DeckSeasonAttackLoseCount = other.DeckSeasonAttackLoseCount;
			}
			if (other.DeckSeasonDefenseWinCount != 0)
			{
				DeckSeasonDefenseWinCount = other.DeckSeasonDefenseWinCount;
			}
			if (other.DeckSeasonDefenseLoseCount != 0)
			{
				DeckSeasonDefenseLoseCount = other.DeckSeasonDefenseLoseCount;
			}
			if (other.DeckSeasonAttackResetDate != 0L)
			{
				DeckSeasonAttackResetDate = other.DeckSeasonAttackResetDate;
			}
			if (other.DeckSeasonDefenseResetDate != 0L)
			{
				DeckSeasonDefenseResetDate = other.DeckSeasonDefenseResetDate;
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
			case 10u:
				attackHistoryInfo_.AddEntriesFrom(ref input, _repeated_attackHistoryInfo_codec);
				break;
			case 18u:
				defenseHistoryInfo_.AddEntriesFrom(ref input, _repeated_defenseHistoryInfo_codec);
				break;
			case 24u:
				SeasonWinCount = input.ReadInt32();
				break;
			case 32u:
				SeasonLoseCount = input.ReadInt32();
				break;
			case 40u:
				SeasonAttackWinCount = input.ReadInt32();
				break;
			case 48u:
				SeasonAttackLoseCount = input.ReadInt32();
				break;
			case 56u:
				SeasonDefenseWinCount = input.ReadInt32();
				break;
			case 64u:
				SeasonDefenseLoseCount = input.ReadInt32();
				break;
			case 72u:
				PrevSeasonAttackWinCount = input.ReadInt32();
				break;
			case 80u:
				PrevSeasonAttackLoseCount = input.ReadInt32();
				break;
			case 88u:
				PrevSeasonDefenseWinCount = input.ReadInt32();
				break;
			case 96u:
				PrevSeasonDefenseLoseCount = input.ReadInt32();
				break;
			case 104u:
				DeckSeasonAttackWinCount = input.ReadInt32();
				break;
			case 112u:
				DeckSeasonAttackLoseCount = input.ReadInt32();
				break;
			case 120u:
				DeckSeasonDefenseWinCount = input.ReadInt32();
				break;
			case 128u:
				DeckSeasonDefenseLoseCount = input.ReadInt32();
				break;
			case 136u:
				DeckSeasonAttackResetDate = input.ReadInt64();
				break;
			case 144u:
				DeckSeasonDefenseResetDate = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
