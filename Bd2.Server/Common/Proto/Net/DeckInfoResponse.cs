using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class DeckInfoResponse : IMessage<DeckInfoResponse>, IMessage, IEquatable<DeckInfoResponse>, IDeepCloneable<DeckInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<DeckInfoResponse> _parser = new MessageParser<DeckInfoResponse>(() => new DeckInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int DeckInfoFieldNumber = 1;

	private static readonly FieldCodec<DeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(10u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> deckInfo_ = new RepeatedField<DeckDBInfo>();

	public const int TalentSlotInfoFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_talentSlotInfo_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> talentSlotInfo_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DeckInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DeckInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DeckDBInfo> DeckInfo => deckInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> TalentSlotInfo => talentSlotInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckInfoResponse(DeckInfoResponse other)
		: this()
	{
		deckInfo_ = other.deckInfo_.Clone();
		talentSlotInfo_ = other.talentSlotInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckInfoResponse Clone()
	{
		return new DeckInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DeckInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DeckInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (deckInfo_.Equals(other.deckInfo_) && talentSlotInfo_.Equals(other.talentSlotInfo_))
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
		num ^= deckInfo_.GetHashCode();
		num ^= talentSlotInfo_.GetHashCode();
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
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		talentSlotInfo_.WriteTo(ref output, _repeated_talentSlotInfo_codec);
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
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		num += talentSlotInfo_.CalculateSize(_repeated_talentSlotInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DeckInfoResponse other)
	{
		if (other != null)
		{
			deckInfo_.Add(other.deckInfo_);
			talentSlotInfo_.Add(other.talentSlotInfo_);
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
			case 16u:
			case 18u:
				talentSlotInfo_.AddEntriesFrom(ref input, _repeated_talentSlotInfo_codec);
				break;
			case 10u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			}
		}
	}
}
