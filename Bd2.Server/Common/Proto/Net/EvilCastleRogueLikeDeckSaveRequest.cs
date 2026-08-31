using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeDeckSaveRequest : IMessage<EvilCastleRogueLikeDeckSaveRequest>, IMessage, IEquatable<EvilCastleRogueLikeDeckSaveRequest>, IDeepCloneable<EvilCastleRogueLikeDeckSaveRequest>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeDeckSaveRequest> _parser = new MessageParser<EvilCastleRogueLikeDeckSaveRequest>(() => new EvilCastleRogueLikeDeckSaveRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int DeckInfoFieldNumber = 2;

	private static readonly FieldCodec<DeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(18u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> deckInfo_ = new RepeatedField<DeckDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeDeckSaveRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeDeckSaveRequestReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<DeckDBInfo> DeckInfo => deckInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeDeckSaveRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeDeckSaveRequest(EvilCastleRogueLikeDeckSaveRequest other)
		: this()
	{
		seq_ = other.seq_;
		deckInfo_ = other.deckInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeDeckSaveRequest Clone()
	{
		return new EvilCastleRogueLikeDeckSaveRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeDeckSaveRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeDeckSaveRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && deckInfo_.Equals(other.deckInfo_))
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
		num ^= deckInfo_.GetHashCode();
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeDeckSaveRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			deckInfo_.Add(other.deckInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
