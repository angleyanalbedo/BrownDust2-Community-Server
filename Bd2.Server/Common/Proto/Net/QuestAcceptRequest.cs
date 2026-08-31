using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestAcceptRequest : IMessage<QuestAcceptRequest>, IMessage, IEquatable<QuestAcceptRequest>, IDeepCloneable<QuestAcceptRequest>, IBufferMessage
{
	private static readonly MessageParser<QuestAcceptRequest> _parser = new MessageParser<QuestAcceptRequest>(() => new QuestAcceptRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int QuestIdFieldNumber = 2;

	private int questId_;

	public const int PackIdFieldNumber = 3;

	private int packId_;

	public const int QuestLevelFieldNumber = 4;

	private int questLevel_;

	public const int QuestOptFieldNumber = 5;

	private int questOpt_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestAcceptRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestAcceptRequestReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public QuestAcceptRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestAcceptRequest(QuestAcceptRequest other)
		: this()
	{
		seq_ = other.seq_;
		questId_ = other.questId_;
		packId_ = other.packId_;
		questLevel_ = other.questLevel_;
		questOpt_ = other.questOpt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestAcceptRequest Clone()
	{
		return new QuestAcceptRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestAcceptRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestAcceptRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && QuestId == other.QuestId && PackId == other.PackId && QuestLevel == other.QuestLevel && QuestOpt == other.QuestOpt)
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
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
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
		if (QuestId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(QuestId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PackId);
		}
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestId);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
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
	public void MergeFrom(QuestAcceptRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				QuestId = input.ReadInt32();
				break;
			case 24u:
				PackId = input.ReadInt32();
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
			}
		}
	}
}
