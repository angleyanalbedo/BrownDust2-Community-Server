using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleStartRequest : IMessage<BattleStartRequest>, IMessage, IEquatable<BattleStartRequest>, IDeepCloneable<BattleStartRequest>, IBufferMessage
{
	private static readonly MessageParser<BattleStartRequest> _parser = new MessageParser<BattleStartRequest>(() => new BattleStartRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int BattleIndexFieldNumber = 2;

	private int battleIndex_;

	public const int BattleDeckFieldNumber = 3;

	private static readonly FieldCodec<DeckDBInfo> _repeated_battleDeck_codec = FieldCodec.ForMessage(26u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> battleDeck_ = new RepeatedField<DeckDBInfo>();

	public const int RedCharInfoFieldNumber = 4;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_redCharInfo_codec = FieldCodec.ForMessage(34u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> redCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int BlueCharInfoFieldNumber = 5;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_blueCharInfo_codec = FieldCodec.ForMessage(42u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> blueCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int GolemInfoFieldNumber = 6;

	private BattleGolemDBInfo golemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleStartRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleStartRequestReflection.Descriptor.MessageTypes[0];

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
	public int BattleIndex
	{
		get
		{
			return battleIndex_;
		}
		set
		{
			battleIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<DeckDBInfo> BattleDeck => battleDeck_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BattleCharDBInfo> RedCharInfo => redCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BattleCharDBInfo> BlueCharInfo => blueCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGolemDBInfo GolemInfo
	{
		get
		{
			return golemInfo_;
		}
		set
		{
			golemInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleStartRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleStartRequest(BattleStartRequest other)
		: this()
	{
		seq_ = other.seq_;
		battleIndex_ = other.battleIndex_;
		battleDeck_ = other.battleDeck_.Clone();
		redCharInfo_ = other.redCharInfo_.Clone();
		blueCharInfo_ = other.blueCharInfo_.Clone();
		golemInfo_ = ((other.golemInfo_ != null) ? other.golemInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleStartRequest Clone()
	{
		return new BattleStartRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleStartRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleStartRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && BattleIndex == other.BattleIndex && battleDeck_.Equals(other.battleDeck_) && redCharInfo_.Equals(other.redCharInfo_) && blueCharInfo_.Equals(other.blueCharInfo_) && object.Equals(GolemInfo, other.GolemInfo))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (BattleIndex != 0)
		{
			num ^= BattleIndex.GetHashCode();
		}
		num ^= battleDeck_.GetHashCode();
		num ^= redCharInfo_.GetHashCode();
		num ^= blueCharInfo_.GetHashCode();
		if (golemInfo_ != null)
		{
			num ^= GolemInfo.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (BattleIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleIndex);
		}
		battleDeck_.WriteTo(ref output, _repeated_battleDeck_codec);
		redCharInfo_.WriteTo(ref output, _repeated_redCharInfo_codec);
		blueCharInfo_.WriteTo(ref output, _repeated_blueCharInfo_codec);
		if (golemInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(GolemInfo);
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
		if (BattleIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleIndex);
		}
		num += battleDeck_.CalculateSize(_repeated_battleDeck_codec);
		num += redCharInfo_.CalculateSize(_repeated_redCharInfo_codec);
		num += blueCharInfo_.CalculateSize(_repeated_blueCharInfo_codec);
		if (golemInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GolemInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleStartRequest other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Seq != 0)
		{
			Seq = other.Seq;
		}
		if (other.BattleIndex != 0)
		{
			BattleIndex = other.BattleIndex;
		}
		battleDeck_.Add(other.battleDeck_);
		redCharInfo_.Add(other.redCharInfo_);
		blueCharInfo_.Add(other.blueCharInfo_);
		if (other.golemInfo_ != null)
		{
			if (golemInfo_ == null)
			{
				GolemInfo = new BattleGolemDBInfo();
			}
			GolemInfo.MergeFrom(other.GolemInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				BattleIndex = input.ReadInt32();
				break;
			case 26u:
				battleDeck_.AddEntriesFrom(ref input, _repeated_battleDeck_codec);
				break;
			case 34u:
				redCharInfo_.AddEntriesFrom(ref input, _repeated_redCharInfo_codec);
				break;
			case 42u:
				blueCharInfo_.AddEntriesFrom(ref input, _repeated_blueCharInfo_codec);
				break;
			case 50u:
				if (golemInfo_ == null)
				{
					GolemInfo = new BattleGolemDBInfo();
				}
				input.ReadMessage(GolemInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
