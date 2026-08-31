using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestGiveUpResponse : IMessage<QuestGiveUpResponse>, IMessage, IEquatable<QuestGiveUpResponse>, IDeepCloneable<QuestGiveUpResponse>, IBufferMessage
{
	private static readonly MessageParser<QuestGiveUpResponse> _parser = new MessageParser<QuestGiveUpResponse>(() => new QuestGiveUpResponse());

	private UnknownFieldSet _unknownFields;

	public const int QuestIdFieldNumber = 1;

	private int questId_;

	public const int DeckInfoFieldNumber = 2;

	private static readonly FieldCodec<DeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(18u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> deckInfo_ = new RepeatedField<DeckDBInfo>();

	public const int RemoveQuestItemFieldNumber = 3;

	private static readonly FieldCodec<ItemDBInfo> _repeated_removeQuestItem_codec = FieldCodec.ForMessage(26u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> removeQuestItem_ = new RepeatedField<ItemDBInfo>();

	public const int DeleteCharInvenIndexFieldNumber = 4;

	private static readonly FieldCodec<long> _repeated_deleteCharInvenIndex_codec = FieldCodec.ForInt64(34u);

	private readonly RepeatedField<long> deleteCharInvenIndex_ = new RepeatedField<long>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestGiveUpResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => QuestGiveUpResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestId
	{
		get
		{
			return questId_;
		}
		set
		{
			questId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DeckDBInfo> DeckInfo => deckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> RemoveQuestItem => removeQuestItem_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> DeleteCharInvenIndex => deleteCharInvenIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestGiveUpResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestGiveUpResponse(QuestGiveUpResponse other)
		: this()
	{
		questId_ = other.questId_;
		deckInfo_ = other.deckInfo_.Clone();
		removeQuestItem_ = other.removeQuestItem_.Clone();
		deleteCharInvenIndex_ = other.deleteCharInvenIndex_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestGiveUpResponse Clone()
	{
		return new QuestGiveUpResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestGiveUpResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestGiveUpResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (QuestId == other.QuestId && deckInfo_.Equals(other.deckInfo_) && removeQuestItem_.Equals(other.removeQuestItem_) && deleteCharInvenIndex_.Equals(other.deleteCharInvenIndex_))
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
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
		}
		num ^= deckInfo_.GetHashCode();
		num ^= removeQuestItem_.GetHashCode();
		num ^= deleteCharInvenIndex_.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (QuestId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(QuestId);
		}
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		removeQuestItem_.WriteTo(ref output, _repeated_removeQuestItem_codec);
		deleteCharInvenIndex_.WriteTo(ref output, _repeated_deleteCharInvenIndex_codec);
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
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestId);
		}
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		num += removeQuestItem_.CalculateSize(_repeated_removeQuestItem_codec);
		num += deleteCharInvenIndex_.CalculateSize(_repeated_deleteCharInvenIndex_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestGiveUpResponse other)
	{
		if (other != null)
		{
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			deckInfo_.Add(other.deckInfo_);
			removeQuestItem_.Add(other.removeQuestItem_);
			deleteCharInvenIndex_.Add(other.deleteCharInvenIndex_);
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
			case 8u:
				QuestId = input.ReadInt32();
				break;
			case 18u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 26u:
				removeQuestItem_.AddEntriesFrom(ref input, _repeated_removeQuestItem_codec);
				break;
			case 32u:
			case 34u:
				deleteCharInvenIndex_.AddEntriesFrom(ref input, _repeated_deleteCharInvenIndex_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
