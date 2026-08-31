using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestMaxClearDBInfo : IMessage<QuestMaxClearDBInfo>, IMessage, IEquatable<QuestMaxClearDBInfo>, IDeepCloneable<QuestMaxClearDBInfo>, IBufferMessage
{
	private static readonly MessageParser<QuestMaxClearDBInfo> _parser = new MessageParser<QuestMaxClearDBInfo>(() => new QuestMaxClearDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int PackIdFieldNumber = 1;

	private int packId_;

	public const int MaxClearIdFieldNumber = 2;

	private int maxClearId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestMaxClearDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestMaxClearDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int MaxClearId
	{
		get
		{
			return maxClearId_;
		}
		set
		{
			maxClearId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestMaxClearDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestMaxClearDBInfo(QuestMaxClearDBInfo other)
		: this()
	{
		packId_ = other.packId_;
		maxClearId_ = other.maxClearId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestMaxClearDBInfo Clone()
	{
		return new QuestMaxClearDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestMaxClearDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestMaxClearDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PackId == other.PackId && MaxClearId == other.MaxClearId)
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
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (MaxClearId != 0)
		{
			num ^= MaxClearId.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (PackId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PackId);
		}
		if (MaxClearId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MaxClearId);
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (MaxClearId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxClearId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestMaxClearDBInfo other)
	{
		if (other != null)
		{
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.MaxClearId != 0)
			{
				MaxClearId = other.MaxClearId;
			}
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
				MaxClearId = input.ReadInt32();
				break;
			case 8u:
				PackId = input.ReadInt32();
				break;
			}
		}
	}
}
