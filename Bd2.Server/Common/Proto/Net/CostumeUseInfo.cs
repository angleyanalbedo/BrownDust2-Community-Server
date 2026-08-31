using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CostumeUseInfo : IMessage<CostumeUseInfo>, IMessage, IEquatable<CostumeUseInfo>, IDeepCloneable<CostumeUseInfo>, IBufferMessage
{
	private static readonly MessageParser<CostumeUseInfo> _parser = new MessageParser<CostumeUseInfo>(() => new CostumeUseInfo());

	private UnknownFieldSet _unknownFields;

	public const int CostumeIndexFieldNumber = 1;

	private long costumeIndex_;

	public const int CharIndexFieldNumber = 2;

	private long charIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CostumeUseInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumeUseRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CostumeIndex
	{
		get
		{
			return costumeIndex_;
		}
		set
		{
			costumeIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharIndex
	{
		get
		{
			return charIndex_;
		}
		set
		{
			charIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumeUseInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumeUseInfo(CostumeUseInfo other)
		: this()
	{
		costumeIndex_ = other.costumeIndex_;
		charIndex_ = other.charIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeUseInfo Clone()
	{
		return new CostumeUseInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeUseInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CostumeUseInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CostumeIndex == other.CostumeIndex && CharIndex == other.CharIndex)
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
		if (CostumeIndex != 0L)
		{
			num ^= CostumeIndex.GetHashCode();
		}
		if (CharIndex != 0L)
		{
			num ^= CharIndex.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (CostumeIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(CostumeIndex);
		}
		if (CharIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(CharIndex);
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
		if (CostumeIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CostumeIndex);
		}
		if (CharIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CharIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CostumeUseInfo other)
	{
		if (other != null)
		{
			if (other.CostumeIndex != 0L)
			{
				CostumeIndex = other.CostumeIndex;
			}
			if (other.CharIndex != 0L)
			{
				CharIndex = other.CharIndex;
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
			case 16u:
				CharIndex = input.ReadInt64();
				break;
			case 8u:
				CostumeIndex = input.ReadInt64();
				break;
			}
		}
	}
}
