using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleRankUserDetail : IMessage<PvpBattleRankUserDetail>, IMessage, IEquatable<PvpBattleRankUserDetail>, IDeepCloneable<PvpBattleRankUserDetail>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleRankUserDetail> _parser = new MessageParser<PvpBattleRankUserDetail>(() => new PvpBattleRankUserDetail());

	private UnknownFieldSet _unknownFields;

	public const int VpFieldNumber = 1;

	private int vp_;

	public const int RankFieldNumber = 2;

	private int rank_;

	public const int WinCountFieldNumber = 3;

	private int winCount_;

	public const int LoseCountFieldNumber = 4;

	private int loseCount_;

	public const int DeckInfoFieldNumber = 5;

	private static readonly FieldCodec<PvpBattleUserDeckInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(42u, PvpBattleUserDeckInfo.Parser);

	private readonly RepeatedField<PvpBattleUserDeckInfo> deckInfo_ = new RepeatedField<PvpBattleUserDeckInfo>();

	public const int CharInfoFieldNumber = 6;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(50u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int CostumeInfoFieldNumber = 7;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_costumeInfo_codec = FieldCodec.ForMessage(58u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> costumeInfo_ = new RepeatedField<CostumeDBInfo>();

	public const int EquipInfoFieldNumber = 8;

	private static readonly FieldCodec<EquipDBInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage(66u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> equipInfo_ = new RepeatedField<EquipDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleRankUserDetail> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleRankUserDetailReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Vp
	{
		get
		{
			return vp_;
		}
		set
		{
			vp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WinCount
	{
		get
		{
			return winCount_;
		}
		set
		{
			winCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LoseCount
	{
		get
		{
			return loseCount_;
		}
		set
		{
			loseCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PvpBattleUserDeckInfo> DeckInfo => deckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CostumeDBInfo> CostumeInfo => costumeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EquipDBInfo> EquipInfo => equipInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankUserDetail()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankUserDetail(PvpBattleRankUserDetail other)
		: this()
	{
		vp_ = other.vp_;
		rank_ = other.rank_;
		winCount_ = other.winCount_;
		loseCount_ = other.loseCount_;
		deckInfo_ = other.deckInfo_.Clone();
		charInfo_ = other.charInfo_.Clone();
		costumeInfo_ = other.costumeInfo_.Clone();
		equipInfo_ = other.equipInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankUserDetail Clone()
	{
		return new PvpBattleRankUserDetail(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleRankUserDetail);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PvpBattleRankUserDetail other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Vp == other.Vp && Rank == other.Rank && WinCount == other.WinCount && LoseCount == other.LoseCount && deckInfo_.Equals(other.deckInfo_) && charInfo_.Equals(other.charInfo_) && costumeInfo_.Equals(other.costumeInfo_) && equipInfo_.Equals(other.equipInfo_))
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
		if (Vp != 0)
		{
			num ^= Vp.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (WinCount != 0)
		{
			num ^= WinCount.GetHashCode();
		}
		if (LoseCount != 0)
		{
			num ^= LoseCount.GetHashCode();
		}
		num ^= deckInfo_.GetHashCode();
		num ^= charInfo_.GetHashCode();
		num ^= costumeInfo_.GetHashCode();
		num ^= equipInfo_.GetHashCode();
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
		if (Vp != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Vp);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Rank);
		}
		if (WinCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(WinCount);
		}
		if (LoseCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LoseCount);
		}
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		costumeInfo_.WriteTo(ref output, _repeated_costumeInfo_codec);
		equipInfo_.WriteTo(ref output, _repeated_equipInfo_codec);
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
		if (Vp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Vp);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (WinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WinCount);
		}
		if (LoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LoseCount);
		}
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += costumeInfo_.CalculateSize(_repeated_costumeInfo_codec);
		num += equipInfo_.CalculateSize(_repeated_equipInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleRankUserDetail other)
	{
		if (other != null)
		{
			if (other.Vp != 0)
			{
				Vp = other.Vp;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.WinCount != 0)
			{
				WinCount = other.WinCount;
			}
			if (other.LoseCount != 0)
			{
				LoseCount = other.LoseCount;
			}
			deckInfo_.Add(other.deckInfo_);
			charInfo_.Add(other.charInfo_);
			costumeInfo_.Add(other.costumeInfo_);
			equipInfo_.Add(other.equipInfo_);
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
				Vp = input.ReadInt32();
				break;
			case 16u:
				Rank = input.ReadInt32();
				break;
			case 24u:
				WinCount = input.ReadInt32();
				break;
			case 32u:
				LoseCount = input.ReadInt32();
				break;
			case 42u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 50u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 58u:
				costumeInfo_.AddEntriesFrom(ref input, _repeated_costumeInfo_codec);
				break;
			case 66u:
				equipInfo_.AddEntriesFrom(ref input, _repeated_equipInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
