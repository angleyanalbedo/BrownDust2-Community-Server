using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class DeckDBInfo : IMessage<DeckDBInfo>, IMessage, IEquatable<DeckDBInfo>, IDeepCloneable<DeckDBInfo>, IBufferMessage
{
	private static readonly MessageParser<DeckDBInfo> _parser = new MessageParser<DeckDBInfo>(() => new DeckDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int CharInvenIndexFieldNumber = 1;

	private long charInvenIndex_;

	public const int PositionFieldNumber = 2;

	private int position_;

	public const int SequenceFieldNumber = 3;

	private int sequence_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DeckDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DeckDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharInvenIndex
	{
		get
		{
			return charInvenIndex_;
		}
		set
		{
			charInvenIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Sequence
	{
		get
		{
			return sequence_;
		}
		set
		{
			sequence_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckDBInfo(DeckDBInfo other)
		: this()
	{
		charInvenIndex_ = other.charInvenIndex_;
		position_ = other.position_;
		sequence_ = other.sequence_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DeckDBInfo Clone()
	{
		return new DeckDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DeckDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DeckDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CharInvenIndex == other.CharInvenIndex && Position == other.Position && Sequence == other.Sequence)
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
		if (CharInvenIndex != 0L)
		{
			num ^= CharInvenIndex.GetHashCode();
		}
		if (Position != 0)
		{
			num ^= Position.GetHashCode();
		}
		if (Sequence != 0)
		{
			num ^= Sequence.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (CharInvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(CharInvenIndex);
		}
		if (Position != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Position);
		}
		if (Sequence != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Sequence);
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
		if (CharInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CharInvenIndex);
		}
		if (Position != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Position);
		}
		if (Sequence != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Sequence);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DeckDBInfo other)
	{
		if (other != null)
		{
			if (other.CharInvenIndex != 0L)
			{
				CharInvenIndex = other.CharInvenIndex;
			}
			if (other.Position != 0)
			{
				Position = other.Position;
			}
			if (other.Sequence != 0)
			{
				Sequence = other.Sequence;
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
				Sequence = input.ReadInt32();
				break;
			case 16u:
				Position = input.ReadInt32();
				break;
			case 8u:
				CharInvenIndex = input.ReadInt64();
				break;
			}
		}
	}
}
