using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleEndRequest : IMessage<BattleEndRequest>, IMessage, IEquatable<BattleEndRequest>, IDeepCloneable<BattleEndRequest>, IBufferMessage
{
	private static readonly MessageParser<BattleEndRequest> _parser = new MessageParser<BattleEndRequest>(() => new BattleEndRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int BattleResultFieldNumber = 2;

	private int battleResult_;

	public const int CharInfoFieldNumber = 3;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(26u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int PackIdFieldNumber = 4;

	private int packId_;

	public const int AchieveIndexFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_achieveIndex_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> achieveIndex_ = new RepeatedField<int>();

	public const int EndInvenIndexFieldNumber = 6;

	private static readonly FieldCodec<long> _repeated_endInvenIndex_codec = FieldCodec.ForInt64(50u);

	private readonly RepeatedField<long> endInvenIndex_ = new RepeatedField<long>();

	public const int MonsterHuntHpFieldNumber = 7;

	private long monsterHuntHp_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BattleEndRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => BattleEndRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int BattleResult
	{
		get
		{
			return battleResult_;
		}
		set
		{
			battleResult_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> AchieveIndex => achieveIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> EndInvenIndex => endInvenIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MonsterHuntHp
	{
		get
		{
			return monsterHuntHp_;
		}
		set
		{
			monsterHuntHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEndRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleEndRequest(BattleEndRequest other)
		: this()
	{
		seq_ = other.seq_;
		battleResult_ = other.battleResult_;
		charInfo_ = other.charInfo_.Clone();
		packId_ = other.packId_;
		achieveIndex_ = other.achieveIndex_.Clone();
		endInvenIndex_ = other.endInvenIndex_.Clone();
		monsterHuntHp_ = other.monsterHuntHp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEndRequest Clone()
	{
		return new BattleEndRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleEndRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleEndRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && BattleResult == other.BattleResult && charInfo_.Equals(other.charInfo_) && PackId == other.PackId && achieveIndex_.Equals(other.achieveIndex_) && endInvenIndex_.Equals(other.endInvenIndex_) && MonsterHuntHp == other.MonsterHuntHp)
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
		if (BattleResult != 0)
		{
			num ^= BattleResult.GetHashCode();
		}
		num ^= charInfo_.GetHashCode();
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		num ^= achieveIndex_.GetHashCode();
		num ^= endInvenIndex_.GetHashCode();
		if (MonsterHuntHp != 0L)
		{
			num ^= MonsterHuntHp.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (BattleResult != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleResult);
		}
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		if (PackId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PackId);
		}
		achieveIndex_.WriteTo(ref output, _repeated_achieveIndex_codec);
		endInvenIndex_.WriteTo(ref output, _repeated_endInvenIndex_codec);
		if (MonsterHuntHp != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(MonsterHuntHp);
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
		if (BattleResult != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleResult);
		}
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		num += achieveIndex_.CalculateSize(_repeated_achieveIndex_codec);
		num += endInvenIndex_.CalculateSize(_repeated_endInvenIndex_codec);
		if (MonsterHuntHp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(MonsterHuntHp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleEndRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.BattleResult != 0)
			{
				BattleResult = other.BattleResult;
			}
			charInfo_.Add(other.charInfo_);
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			achieveIndex_.Add(other.achieveIndex_);
			endInvenIndex_.Add(other.endInvenIndex_);
			if (other.MonsterHuntHp != 0L)
			{
				MonsterHuntHp = other.MonsterHuntHp;
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
			case 8u:
				Seq = input.ReadInt32();
				break;
			case 16u:
				BattleResult = input.ReadInt32();
				break;
			case 26u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 32u:
				PackId = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				achieveIndex_.AddEntriesFrom(ref input, _repeated_achieveIndex_codec);
				break;
			case 48u:
			case 50u:
				endInvenIndex_.AddEntriesFrom(ref input, _repeated_endInvenIndex_codec);
				break;
			case 56u:
				MonsterHuntHp = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
