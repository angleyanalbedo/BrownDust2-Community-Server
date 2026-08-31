using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SpeechBubbleTable : IMessage<SpeechBubbleTable>, IMessage, IEquatable<SpeechBubbleTable>, IDeepCloneable<SpeechBubbleTable>, IBufferMessage
{
	private static readonly MessageParser<SpeechBubbleTable> _parser = new MessageParser<SpeechBubbleTable>(() => new SpeechBubbleTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int LocalTextFieldNumber = 2;

	private int localText_;

	public const int RemindTypeFieldNumber = 3;

	private int remindType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpeechBubbleTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SpeechBubbleTableReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LocalText
	{
		get
		{
			return localText_;
		}
		set
		{
			localText_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RemindType
	{
		get
		{
			return remindType_;
		}
		set
		{
			remindType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpeechBubbleTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpeechBubbleTable(SpeechBubbleTable other)
		: this()
	{
		id_ = other.id_;
		localText_ = other.localText_;
		remindType_ = other.remindType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpeechBubbleTable Clone()
	{
		return new SpeechBubbleTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpeechBubbleTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SpeechBubbleTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && LocalText == other.LocalText && RemindType == other.RemindType)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LocalText != 0)
		{
			num ^= LocalText.GetHashCode();
		}
		if (RemindType != 0)
		{
			num ^= RemindType.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (LocalText != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LocalText);
		}
		if (RemindType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RemindType);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LocalText != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalText);
		}
		if (RemindType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RemindType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpeechBubbleTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LocalText != 0)
			{
				LocalText = other.LocalText;
			}
			if (other.RemindType != 0)
			{
				RemindType = other.RemindType;
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
			case 24u:
				RemindType = input.ReadInt32();
				break;
			case 16u:
				LocalText = input.ReadInt32();
				break;
			case 8u:
				Id = input.ReadInt32();
				break;
			}
		}
	}
}
