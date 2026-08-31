using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleStartRequest : IMessage<PvpBattleStartRequest>, IMessage, IEquatable<PvpBattleStartRequest>, IDeepCloneable<PvpBattleStartRequest>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleStartRequest> _parser = new MessageParser<PvpBattleStartRequest>(() => new PvpBattleStartRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int DeckInfoFieldNumber = 2;

	private static readonly FieldCodec<PvpBattleUserDeckInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(18u, PvpBattleUserDeckInfo.Parser);

	private readonly RepeatedField<PvpBattleUserDeckInfo> deckInfo_ = new RepeatedField<PvpBattleUserDeckInfo>();

	public const int RedCharInfoFieldNumber = 3;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_redCharInfo_codec = FieldCodec.ForMessage(26u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> redCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int BlueCharInfoFieldNumber = 4;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_blueCharInfo_codec = FieldCodec.ForMessage(34u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> blueCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleStartRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PvpBattleStartRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public RepeatedField<PvpBattleUserDeckInfo> DeckInfo => deckInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BattleCharDBInfo> RedCharInfo => redCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<BattleCharDBInfo> BlueCharInfo => blueCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleStartRequest()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleStartRequest(PvpBattleStartRequest other)
		: this()
	{
		seq_ = other.seq_;
		deckInfo_ = other.deckInfo_.Clone();
		redCharInfo_ = other.redCharInfo_.Clone();
		blueCharInfo_ = other.blueCharInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleStartRequest Clone()
	{
		return new PvpBattleStartRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleStartRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PvpBattleStartRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && deckInfo_.Equals(other.deckInfo_) && redCharInfo_.Equals(other.redCharInfo_) && blueCharInfo_.Equals(other.blueCharInfo_))
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
		num ^= deckInfo_.GetHashCode();
		num ^= redCharInfo_.GetHashCode();
		num ^= blueCharInfo_.GetHashCode();
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
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		redCharInfo_.WriteTo(ref output, _repeated_redCharInfo_codec);
		blueCharInfo_.WriteTo(ref output, _repeated_blueCharInfo_codec);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		num += redCharInfo_.CalculateSize(_repeated_redCharInfo_codec);
		num += blueCharInfo_.CalculateSize(_repeated_blueCharInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PvpBattleStartRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			deckInfo_.Add(other.deckInfo_);
			redCharInfo_.Add(other.redCharInfo_);
			blueCharInfo_.Add(other.blueCharInfo_);
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
			case 18u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 26u:
				redCharInfo_.AddEntriesFrom(ref input, _repeated_redCharInfo_codec);
				break;
			case 34u:
				blueCharInfo_.AddEntriesFrom(ref input, _repeated_blueCharInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
