using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PopularEquipDBInfo : IMessage<PopularEquipDBInfo>, IMessage, IEquatable<PopularEquipDBInfo>, IDeepCloneable<PopularEquipDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PopularEquipDBInfo> _parser = new MessageParser<PopularEquipDBInfo>(() => new PopularEquipDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int UniqueCharIdFieldNumber = 1;

	private int uniqueCharId_;

	public const int SlotTypeFieldNumber = 2;

	private int slotType_;

	public const int UniqueEquipIdFieldNumber = 3;

	private int uniqueEquipId_;

	public const int UseCountFieldNumber = 4;

	private long useCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PopularEquipDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PopularEquipDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueCharId
	{
		get
		{
			return uniqueCharId_;
		}
		set
		{
			uniqueCharId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SlotType
	{
		get
		{
			return slotType_;
		}
		set
		{
			slotType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueEquipId
	{
		get
		{
			return uniqueEquipId_;
		}
		set
		{
			uniqueEquipId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long UseCount
	{
		get
		{
			return useCount_;
		}
		set
		{
			useCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularEquipDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularEquipDBInfo(PopularEquipDBInfo other)
		: this()
	{
		uniqueCharId_ = other.uniqueCharId_;
		slotType_ = other.slotType_;
		uniqueEquipId_ = other.uniqueEquipId_;
		useCount_ = other.useCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopularEquipDBInfo Clone()
	{
		return new PopularEquipDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PopularEquipDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PopularEquipDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (UniqueCharId == other.UniqueCharId && SlotType == other.SlotType && UniqueEquipId == other.UniqueEquipId && UseCount == other.UseCount)
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
		if (UniqueCharId != 0)
		{
			num ^= UniqueCharId.GetHashCode();
		}
		if (SlotType != 0)
		{
			num ^= SlotType.GetHashCode();
		}
		if (UniqueEquipId != 0)
		{
			num ^= UniqueEquipId.GetHashCode();
		}
		if (UseCount != 0L)
		{
			num ^= UseCount.GetHashCode();
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
		if (UniqueCharId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UniqueCharId);
		}
		if (SlotType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SlotType);
		}
		if (UniqueEquipId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UniqueEquipId);
		}
		if (UseCount != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(UseCount);
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
		if (UniqueCharId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueCharId);
		}
		if (SlotType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SlotType);
		}
		if (UniqueEquipId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueEquipId);
		}
		if (UseCount != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UseCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PopularEquipDBInfo other)
	{
		if (other != null)
		{
			if (other.UniqueCharId != 0)
			{
				UniqueCharId = other.UniqueCharId;
			}
			if (other.SlotType != 0)
			{
				SlotType = other.SlotType;
			}
			if (other.UniqueEquipId != 0)
			{
				UniqueEquipId = other.UniqueEquipId;
			}
			if (other.UseCount != 0L)
			{
				UseCount = other.UseCount;
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
				UniqueCharId = input.ReadInt32();
				break;
			case 16u:
				SlotType = input.ReadInt32();
				break;
			case 24u:
				UniqueEquipId = input.ReadInt32();
				break;
			case 32u:
				UseCount = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
