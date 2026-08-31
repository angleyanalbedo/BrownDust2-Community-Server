using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackRewardObjectCountInfo : IMessage<PackRewardObjectCountInfo>, IMessage, IEquatable<PackRewardObjectCountInfo>, IDeepCloneable<PackRewardObjectCountInfo>, IBufferMessage
{
	private static readonly MessageParser<PackRewardObjectCountInfo> _parser = new MessageParser<PackRewardObjectCountInfo>(() => new PackRewardObjectCountInfo());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private Define_PackRewardObjectCountType type_;

	public const int PackIdFieldNumber = 2;

	private int packId_;

	public const int CountFieldNumber = 3;

	private int count_;

	public const int MaxCountFieldNumber = 4;

	private int maxCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackRewardObjectCountInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackRewardObjectCountResponseReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_PackRewardObjectCountType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxCount
	{
		get
		{
			return maxCount_;
		}
		set
		{
			maxCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackRewardObjectCountInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackRewardObjectCountInfo(PackRewardObjectCountInfo other)
		: this()
	{
		type_ = other.type_;
		packId_ = other.packId_;
		count_ = other.count_;
		maxCount_ = other.maxCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackRewardObjectCountInfo Clone()
	{
		return new PackRewardObjectCountInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PackRewardObjectCountInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackRewardObjectCountInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Type == other.Type && PackId == other.PackId && Count == other.Count && MaxCount == other.MaxCount)
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
		if (Type != Define_PackRewardObjectCountType.ProctNone)
		{
			num ^= Type.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (MaxCount != 0)
		{
			num ^= MaxCount.GetHashCode();
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
		if (Type != Define_PackRewardObjectCountType.ProctNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PackId);
		}
		if (Count != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Count);
		}
		if (MaxCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MaxCount);
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
		if (Type != Define_PackRewardObjectCountType.ProctNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Count);
		}
		if (MaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackRewardObjectCountInfo other)
	{
		if (other != null)
		{
			if (other.Type != Define_PackRewardObjectCountType.ProctNone)
			{
				Type = other.Type;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.MaxCount != 0)
			{
				MaxCount = other.MaxCount;
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
			case 8u:
				Type = (Define_PackRewardObjectCountType)input.ReadEnum();
				break;
			case 16u:
				PackId = input.ReadInt32();
				break;
			case 24u:
				Count = input.ReadInt32();
				break;
			case 32u:
				MaxCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
