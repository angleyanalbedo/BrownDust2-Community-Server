using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidDeckInfoResponse : IMessage<GuildRaidDeckInfoResponse>, IMessage, IEquatable<GuildRaidDeckInfoResponse>, IDeepCloneable<GuildRaidDeckInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidDeckInfoResponse> _parser = new MessageParser<GuildRaidDeckInfoResponse>(() => new GuildRaidDeckInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int DeckInfoFieldNumber = 1;

	private static readonly FieldCodec<DeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(10u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> deckInfo_ = new RepeatedField<DeckDBInfo>();

	public const int SupporterDeckInfoFieldNumber = 2;

	private static readonly FieldCodec<GuildRaidSupporterDeckDBInfo> _repeated_supporterDeckInfo_codec = FieldCodec.ForMessage(18u, GuildRaidSupporterDeckDBInfo.Parser);

	private readonly RepeatedField<GuildRaidSupporterDeckDBInfo> supporterDeckInfo_ = new RepeatedField<GuildRaidSupporterDeckDBInfo>();

	public const int IsSupporterDeckUpdateFieldNumber = 3;

	private bool isSupporterDeckUpdate_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRaidDeckInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidDeckInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<DeckDBInfo> DeckInfo => deckInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GuildRaidSupporterDeckDBInfo> SupporterDeckInfo => supporterDeckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsSupporterDeckUpdate
	{
		get
		{
			return isSupporterDeckUpdate_;
		}
		set
		{
			isSupporterDeckUpdate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidDeckInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidDeckInfoResponse(GuildRaidDeckInfoResponse other)
		: this()
	{
		deckInfo_ = other.deckInfo_.Clone();
		supporterDeckInfo_ = other.supporterDeckInfo_.Clone();
		isSupporterDeckUpdate_ = other.isSupporterDeckUpdate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidDeckInfoResponse Clone()
	{
		return new GuildRaidDeckInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidDeckInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRaidDeckInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (deckInfo_.Equals(other.deckInfo_) && supporterDeckInfo_.Equals(other.supporterDeckInfo_) && IsSupporterDeckUpdate == other.IsSupporterDeckUpdate)
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
		num ^= supporterDeckInfo_.GetHashCode();
		if (IsSupporterDeckUpdate)
		{
			num ^= IsSupporterDeckUpdate.GetHashCode();
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
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		supporterDeckInfo_.WriteTo(ref output, _repeated_supporterDeckInfo_codec);
		if (IsSupporterDeckUpdate)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsSupporterDeckUpdate);
		}
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
		num += supporterDeckInfo_.CalculateSize(_repeated_supporterDeckInfo_codec);
		if (IsSupporterDeckUpdate)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildRaidDeckInfoResponse other)
	{
		if (other != null)
		{
			deckInfo_.Add(other.deckInfo_);
			supporterDeckInfo_.Add(other.supporterDeckInfo_);
			if (other.IsSupporterDeckUpdate)
			{
				IsSupporterDeckUpdate = other.IsSupporterDeckUpdate;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				IsSupporterDeckUpdate = input.ReadBool();
				break;
			case 18u:
				supporterDeckInfo_.AddEntriesFrom(ref input, _repeated_supporterDeckInfo_codec);
				break;
			case 10u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			}
		}
	}
}
