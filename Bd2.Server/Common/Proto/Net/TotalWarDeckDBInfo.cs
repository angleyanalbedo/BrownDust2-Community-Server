using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TotalWarDeckDBInfo : IMessage<TotalWarDeckDBInfo>, IMessage, IEquatable<TotalWarDeckDBInfo>, IDeepCloneable<TotalWarDeckDBInfo>, IBufferMessage
{
	private static readonly MessageParser<TotalWarDeckDBInfo> _parser = new MessageParser<TotalWarDeckDBInfo>(() => new TotalWarDeckDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int PlayTypeFieldNumber = 1;

	private int playType_;

	public const int InvenIndexFieldNumber = 2;

	private long invenIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TotalWarDeckDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TotalWarDeckDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PlayType
	{
		get
		{
			return playType_;
		}
		set
		{
			playType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long InvenIndex
	{
		get
		{
			return invenIndex_;
		}
		set
		{
			invenIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TotalWarDeckDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TotalWarDeckDBInfo(TotalWarDeckDBInfo other)
		: this()
	{
		playType_ = other.playType_;
		invenIndex_ = other.invenIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarDeckDBInfo Clone()
	{
		return new TotalWarDeckDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarDeckDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TotalWarDeckDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PlayType == other.PlayType && InvenIndex == other.InvenIndex)
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
		if (PlayType != 0)
		{
			num ^= PlayType.GetHashCode();
		}
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
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
		if (PlayType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PlayType);
		}
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(InvenIndex);
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
		if (PlayType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayType);
		}
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TotalWarDeckDBInfo other)
	{
		if (other != null)
		{
			if (other.PlayType != 0)
			{
				PlayType = other.PlayType;
			}
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
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
				InvenIndex = input.ReadInt64();
				break;
			case 8u:
				PlayType = input.ReadInt32();
				break;
			}
		}
	}
}
