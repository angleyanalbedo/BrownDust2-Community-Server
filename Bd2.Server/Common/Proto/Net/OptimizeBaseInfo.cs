using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class OptimizeBaseInfo : IMessage<OptimizeBaseInfo>, IMessage, IEquatable<OptimizeBaseInfo>, IDeepCloneable<OptimizeBaseInfo>, IBufferMessage
{
	private static readonly MessageParser<OptimizeBaseInfo> _parser = new MessageParser<OptimizeBaseInfo>(() => new OptimizeBaseInfo());

	private UnknownFieldSet _unknownFields;

	public const int OptimizeIndexFieldNumber = 1;

	private int optimizeIndex_;

	public const int OptimizeValueFieldNumber = 2;

	private bool optimizeValue_;

	public const int OptimizePropertyFieldNumber = 3;

	private string optimizeProperty_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OptimizeBaseInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => OptimizeBaseInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OptimizeIndex
	{
		get
		{
			return optimizeIndex_;
		}
		set
		{
			optimizeIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OptimizeValue
	{
		get
		{
			return optimizeValue_;
		}
		set
		{
			optimizeValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string OptimizeProperty
	{
		get
		{
			return optimizeProperty_;
		}
		set
		{
			optimizeProperty_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OptimizeBaseInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OptimizeBaseInfo(OptimizeBaseInfo other)
		: this()
	{
		optimizeIndex_ = other.optimizeIndex_;
		optimizeValue_ = other.optimizeValue_;
		optimizeProperty_ = other.optimizeProperty_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OptimizeBaseInfo Clone()
	{
		return new OptimizeBaseInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OptimizeBaseInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OptimizeBaseInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OptimizeIndex == other.OptimizeIndex && OptimizeValue == other.OptimizeValue && !(OptimizeProperty != other.OptimizeProperty))
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
		if (OptimizeIndex != 0)
		{
			num ^= OptimizeIndex.GetHashCode();
		}
		if (OptimizeValue)
		{
			num ^= OptimizeValue.GetHashCode();
		}
		if (OptimizeProperty.Length != 0)
		{
			num ^= OptimizeProperty.GetHashCode();
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
		if (OptimizeIndex != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(OptimizeIndex);
		}
		if (OptimizeValue)
		{
			output.WriteRawTag(16);
			output.WriteBool(OptimizeValue);
		}
		if (OptimizeProperty.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(OptimizeProperty);
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
		if (OptimizeIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OptimizeIndex);
		}
		if (OptimizeValue)
		{
			num += 2;
		}
		if (OptimizeProperty.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OptimizeProperty);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OptimizeBaseInfo other)
	{
		if (other != null)
		{
			if (other.OptimizeIndex != 0)
			{
				OptimizeIndex = other.OptimizeIndex;
			}
			if (other.OptimizeValue)
			{
				OptimizeValue = other.OptimizeValue;
			}
			if (other.OptimizeProperty.Length != 0)
			{
				OptimizeProperty = other.OptimizeProperty;
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
			case 26u:
				OptimizeProperty = input.ReadString();
				break;
			case 16u:
				OptimizeValue = input.ReadBool();
				break;
			case 8u:
				OptimizeIndex = input.ReadInt32();
				break;
			}
		}
	}
}
