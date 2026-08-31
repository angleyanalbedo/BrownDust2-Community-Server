using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class OverwhelmQuestUpdateInfo : IMessage<OverwhelmQuestUpdateInfo>, IMessage, IEquatable<OverwhelmQuestUpdateInfo>, IDeepCloneable<OverwhelmQuestUpdateInfo>, IBufferMessage
{
	private static readonly MessageParser<OverwhelmQuestUpdateInfo> _parser = new MessageParser<OverwhelmQuestUpdateInfo>(() => new OverwhelmQuestUpdateInfo());

	private UnknownFieldSet _unknownFields;

	public const int QuestIdFieldNumber = 1;

	private int questId_;

	public const int PackIdFieldNumber = 2;

	private int packId_;

	public const int QuestValueFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_questValue_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> questValue_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OverwhelmQuestUpdateInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => OverwhelmRequestReflection.Descriptor.MessageTypes[0];

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> QuestValue => questValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OverwhelmQuestUpdateInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmQuestUpdateInfo(OverwhelmQuestUpdateInfo other)
		: this()
	{
		questId_ = other.questId_;
		packId_ = other.packId_;
		questValue_ = other.questValue_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OverwhelmQuestUpdateInfo Clone()
	{
		return new OverwhelmQuestUpdateInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OverwhelmQuestUpdateInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OverwhelmQuestUpdateInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (QuestId == other.QuestId && PackId == other.PackId && questValue_.Equals(other.questValue_))
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
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		num ^= questValue_.GetHashCode();
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
		if (QuestId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(QuestId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PackId);
		}
		questValue_.WriteTo(ref output, _repeated_questValue_codec);
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		num += questValue_.CalculateSize(_repeated_questValue_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OverwhelmQuestUpdateInfo other)
	{
		if (other != null)
		{
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			questValue_.Add(other.questValue_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			case 16u:
				PackId = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				questValue_.AddEntriesFrom(ref input, _repeated_questValue_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
