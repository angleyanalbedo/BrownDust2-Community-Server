using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PictorialBuffStatDBInfo : IMessage<PictorialBuffStatDBInfo>, IMessage, IEquatable<PictorialBuffStatDBInfo>, IDeepCloneable<PictorialBuffStatDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PictorialBuffStatDBInfo> _parser = new MessageParser<PictorialBuffStatDBInfo>(() => new PictorialBuffStatDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int StatTypeFieldNumber = 1;

	private Define_CharStatOption statType_;

	public const int StatValueFieldNumber = 2;

	private double statValue_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PictorialBuffStatDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PictorialBuffStatDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_CharStatOption StatType
	{
		get
		{
			return statType_;
		}
		set
		{
			statType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double StatValue
	{
		get
		{
			return statValue_;
		}
		set
		{
			statValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PictorialBuffStatDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PictorialBuffStatDBInfo(PictorialBuffStatDBInfo other)
		: this()
	{
		statType_ = other.statType_;
		statValue_ = other.statValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PictorialBuffStatDBInfo Clone()
	{
		return new PictorialBuffStatDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PictorialBuffStatDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PictorialBuffStatDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (StatType == other.StatType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(StatValue, other.StatValue))
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
		if (StatType != Define_CharStatOption.NoneStat)
		{
			num ^= StatType.GetHashCode();
		}
		if (StatValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(StatValue);
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (StatType != Define_CharStatOption.NoneStat)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)StatType);
		}
		if (StatValue != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(StatValue);
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
		if (StatType != Define_CharStatOption.NoneStat)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)StatType);
		}
		if (StatValue != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PictorialBuffStatDBInfo other)
	{
		if (other != null)
		{
			if (other.StatType != Define_CharStatOption.NoneStat)
			{
				StatType = other.StatType;
			}
			if (other.StatValue != 0.0)
			{
				StatValue = other.StatValue;
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
			case 17u:
				StatValue = input.ReadDouble();
				break;
			case 8u:
				StatType = (Define_CharStatOption)input.ReadEnum();
				break;
			}
		}
	}
}
