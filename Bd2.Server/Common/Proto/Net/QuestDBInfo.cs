using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestDBInfo : IMessage<QuestDBInfo>, IMessage, IEquatable<QuestDBInfo>, IDeepCloneable<QuestDBInfo>, IBufferMessage
{
	private static readonly MessageParser<QuestDBInfo> _parser = new MessageParser<QuestDBInfo>(() => new QuestDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int ValueFieldNumber = 2;

	private int value_;

	public const int ObjectIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_objectId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> objectId_ = new RepeatedField<int>();

	public const int QuestLevelFieldNumber = 4;

	private int questLevel_;

	public const int QuestOptFieldNumber = 5;

	private int questOpt_;

	public bool IsDisplayQuest { get; set; } = true;

	public int QuestNum { get; set; } = 1;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ObjectId => objectId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestLevel
	{
		get
		{
			return questLevel_;
		}
		set
		{
			questLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestOpt
	{
		get
		{
			return questOpt_;
		}
		set
		{
			questOpt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestDBInfo(QuestDBInfo other)
		: this()
	{
		id_ = other.id_;
		value_ = other.value_;
		objectId_ = other.objectId_.Clone();
		questLevel_ = other.questLevel_;
		questOpt_ = other.questOpt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestDBInfo Clone()
	{
		return new QuestDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && Value == other.Value && objectId_.Equals(other.objectId_) && QuestLevel == other.QuestLevel && QuestOpt == other.QuestOpt)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Value != 0)
		{
			num ^= Value.GetHashCode();
		}
		num ^= objectId_.GetHashCode();
		if (QuestLevel != 0)
		{
			num ^= QuestLevel.GetHashCode();
		}
		if (QuestOpt != 0)
		{
			num ^= QuestOpt.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Value != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Value);
		}
		objectId_.WriteTo(ref output, _repeated_objectId_codec);
		if (QuestLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(QuestLevel);
		}
		if (QuestOpt != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(QuestOpt);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Value != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Value);
		}
		num += objectId_.CalculateSize(_repeated_objectId_codec);
		if (QuestLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestLevel);
		}
		if (QuestOpt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestOpt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Value != 0)
			{
				Value = other.Value;
			}
			objectId_.Add(other.objectId_);
			if (other.QuestLevel != 0)
			{
				QuestLevel = other.QuestLevel;
			}
			if (other.QuestOpt != 0)
			{
				QuestOpt = other.QuestOpt;
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
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
				Value = input.ReadInt32();
				break;
			case 32u:
				QuestLevel = input.ReadInt32();
				break;
			case 40u:
				QuestOpt = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				objectId_.AddEntriesFrom(ref input, _repeated_objectId_codec);
				break;
			}
		}
	}
}
