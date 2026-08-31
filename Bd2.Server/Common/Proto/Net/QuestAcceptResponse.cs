using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestAcceptResponse : IMessage<QuestAcceptResponse>, IMessage, IEquatable<QuestAcceptResponse>, IDeepCloneable<QuestAcceptResponse>, IBufferMessage
{
	private static readonly MessageParser<QuestAcceptResponse> _parser = new MessageParser<QuestAcceptResponse>(() => new QuestAcceptResponse());

	private UnknownFieldSet _unknownFields;

	public const int QuestInfoFieldNumber = 1;

	private QuestDBInfo questInfo_;

	public const int CharInfoFieldNumber = 2;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(18u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int DeckInfoFieldNumber = 3;

	private static readonly FieldCodec<DeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(26u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> deckInfo_ = new RepeatedField<DeckDBInfo>();

	public const int GiveQuestItemFieldNumber = 4;

	private static readonly FieldCodec<ItemDBInfo> _repeated_giveQuestItem_codec = FieldCodec.ForMessage(34u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> giveQuestItem_ = new RepeatedField<ItemDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestAcceptResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestAcceptResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestDBInfo QuestInfo
	{
		get
		{
			return questInfo_;
		}
		set
		{
			questInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DeckDBInfo> DeckInfo => deckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> GiveQuestItem => giveQuestItem_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestAcceptResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestAcceptResponse(QuestAcceptResponse other)
		: this()
	{
		questInfo_ = ((other.questInfo_ != null) ? other.questInfo_.Clone() : null);
		charInfo_ = other.charInfo_.Clone();
		deckInfo_ = other.deckInfo_.Clone();
		giveQuestItem_ = other.giveQuestItem_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestAcceptResponse Clone()
	{
		return new QuestAcceptResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestAcceptResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestAcceptResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(QuestInfo, other.QuestInfo) && charInfo_.Equals(other.charInfo_) && deckInfo_.Equals(other.deckInfo_) && giveQuestItem_.Equals(other.giveQuestItem_))
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
		if (questInfo_ != null)
		{
			num ^= QuestInfo.GetHashCode();
		}
		num ^= charInfo_.GetHashCode();
		num ^= deckInfo_.GetHashCode();
		num ^= giveQuestItem_.GetHashCode();
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
		if (questInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(QuestInfo);
		}
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		giveQuestItem_.WriteTo(ref output, _repeated_giveQuestItem_codec);
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
		if (questInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QuestInfo);
		}
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		num += giveQuestItem_.CalculateSize(_repeated_giveQuestItem_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestAcceptResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.questInfo_ != null)
		{
			if (questInfo_ == null)
			{
				QuestInfo = new QuestDBInfo();
			}
			QuestInfo.MergeFrom(other.QuestInfo);
		}
		charInfo_.Add(other.charInfo_);
		deckInfo_.Add(other.deckInfo_);
		giveQuestItem_.Add(other.giveQuestItem_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (questInfo_ == null)
				{
					QuestInfo = new QuestDBInfo();
				}
				input.ReadMessage(QuestInfo);
				break;
			case 18u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 26u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 34u:
				giveQuestItem_.AddEntriesFrom(ref input, _repeated_giveQuestItem_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
