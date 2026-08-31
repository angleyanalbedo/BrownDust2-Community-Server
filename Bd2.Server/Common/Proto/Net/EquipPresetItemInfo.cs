using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipPresetItemInfo : IMessage<EquipPresetItemInfo>, IMessage, IEquatable<EquipPresetItemInfo>, IDeepCloneable<EquipPresetItemInfo>, IBufferMessage
{
	private static readonly MessageParser<EquipPresetItemInfo> _parser = new MessageParser<EquipPresetItemInfo>(() => new EquipPresetItemInfo());

	private UnknownFieldSet _unknownFields;

	public const int EquipTypeFieldNumber = 1;

	private int equipType_;

	public const int EquipInvenIndexFieldNumber = 2;

	private long equipInvenIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EquipPresetItemInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipPresetItemInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EquipType
	{
		get
		{
			return equipType_;
		}
		set
		{
			equipType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long EquipInvenIndex
	{
		get
		{
			return equipInvenIndex_;
		}
		set
		{
			equipInvenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipPresetItemInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipPresetItemInfo(EquipPresetItemInfo other)
		: this()
	{
		equipType_ = other.equipType_;
		equipInvenIndex_ = other.equipInvenIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipPresetItemInfo Clone()
	{
		return new EquipPresetItemInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipPresetItemInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipPresetItemInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EquipType == other.EquipType && EquipInvenIndex == other.EquipInvenIndex)
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
		if (EquipType != 0)
		{
			num ^= EquipType.GetHashCode();
		}
		if (EquipInvenIndex != 0L)
		{
			num ^= EquipInvenIndex.GetHashCode();
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
		if (EquipType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EquipType);
		}
		if (EquipInvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(EquipInvenIndex);
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
		if (EquipType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipType);
		}
		if (EquipInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EquipInvenIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipPresetItemInfo other)
	{
		if (other != null)
		{
			if (other.EquipType != 0)
			{
				EquipType = other.EquipType;
			}
			if (other.EquipInvenIndex != 0L)
			{
				EquipInvenIndex = other.EquipInvenIndex;
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
				EquipInvenIndex = input.ReadInt64();
				break;
			case 8u:
				EquipType = input.ReadInt32();
				break;
			}
		}
	}
}
