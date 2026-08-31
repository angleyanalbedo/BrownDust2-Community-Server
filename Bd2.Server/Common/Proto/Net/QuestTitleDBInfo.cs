using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestTitleDBInfo : IMessage<QuestTitleDBInfo>, IMessage, IEquatable<QuestTitleDBInfo>, IDeepCloneable<QuestTitleDBInfo>, IBufferMessage
{
	private static readonly MessageParser<QuestTitleDBInfo> _parser = new MessageParser<QuestTitleDBInfo>(() => new QuestTitleDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int TitleIdFieldNumber = 1;

	private int titleId_;

	public const int MaxClearIdFieldNumber = 2;

	private int maxClearId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestTitleDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => QuestTitleDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TitleId
	{
		get
		{
			return titleId_;
		}
		set
		{
			titleId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public QuestTitleDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestTitleDBInfo(QuestTitleDBInfo other)
		: this()
	{
		titleId_ = other.titleId_;
		maxClearId_ = other.maxClearId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestTitleDBInfo Clone()
	{
		return new QuestTitleDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestTitleDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestTitleDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (TitleId == other.TitleId && MaxClearId == other.MaxClearId)
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
		if (TitleId != 0)
		{
			num ^= TitleId.GetHashCode();
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
		if (TitleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TitleId);
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
		if (TitleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleId);
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
	public void MergeFrom(QuestTitleDBInfo other)
	{
		if (other != null)
		{
			if (other.TitleId != 0)
			{
				TitleId = other.TitleId;
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
			case 16u:
				MaxClearId = input.ReadInt32();
				break;
			case 8u:
				TitleId = input.ReadInt32();
				break;
			}
		}
	}
}
