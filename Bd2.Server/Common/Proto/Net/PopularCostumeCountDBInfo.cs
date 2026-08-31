using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PopularCostumeCountDBInfo : IMessage<PopularCostumeCountDBInfo>, IMessage, IEquatable<PopularCostumeCountDBInfo>, IDeepCloneable<PopularCostumeCountDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PopularCostumeCountDBInfo> _parser = new MessageParser<PopularCostumeCountDBInfo>(() => new PopularCostumeCountDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int CountType0FieldNumber = 2;

	private long countType0_;

	public const int CountType1FieldNumber = 3;

	private long countType1_;

	public const int CountType2FieldNumber = 4;

	private long countType2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PopularCostumeCountDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PopularCostumeCountDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public long CountType0
	{
		get
		{
			return countType0_;
		}
		set
		{
			countType0_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CountType1
	{
		get
		{
			return countType1_;
		}
		set
		{
			countType1_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CountType2
	{
		get
		{
			return countType2_;
		}
		set
		{
			countType2_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularCostumeCountDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularCostumeCountDBInfo(PopularCostumeCountDBInfo other)
		: this()
	{
		id_ = other.id_;
		countType0_ = other.countType0_;
		countType1_ = other.countType1_;
		countType2_ = other.countType2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularCostumeCountDBInfo Clone()
	{
		return new PopularCostumeCountDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PopularCostumeCountDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PopularCostumeCountDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && CountType0 == other.CountType0 && CountType1 == other.CountType1 && CountType2 == other.CountType2)
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
		if (CountType0 != 0L)
		{
			num ^= CountType0.GetHashCode();
		}
		if (CountType1 != 0L)
		{
			num ^= CountType1.GetHashCode();
		}
		if (CountType2 != 0L)
		{
			num ^= CountType2.GetHashCode();
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
		if (CountType0 != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(CountType0);
		}
		if (CountType1 != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(CountType1);
		}
		if (CountType2 != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(CountType2);
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
		if (CountType0 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CountType0);
		}
		if (CountType1 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CountType1);
		}
		if (CountType2 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CountType2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PopularCostumeCountDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.CountType0 != 0L)
			{
				CountType0 = other.CountType0;
			}
			if (other.CountType1 != 0L)
			{
				CountType1 = other.CountType1;
			}
			if (other.CountType2 != 0L)
			{
				CountType2 = other.CountType2;
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
				CountType0 = input.ReadInt64();
				break;
			case 24u:
				CountType1 = input.ReadInt64();
				break;
			case 32u:
				CountType2 = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
