using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MyRoomDefaultTable : IMessage<MyRoomDefaultTable>, IMessage, IEquatable<MyRoomDefaultTable>, IDeepCloneable<MyRoomDefaultTable>, IBufferMessage
{
	private static readonly MessageParser<MyRoomDefaultTable> _parser = new MessageParser<MyRoomDefaultTable>(() => new MyRoomDefaultTable());

	private UnknownFieldSet _unknownFields;

	public const int CarpetLimitCountFieldNumber = 1;

	private int carpetLimitCount_;

	public const int CharLimitCountFieldNumber = 2;

	private int charLimitCount_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ObjectLimitCountFieldNumber = 4;

	private int objectLimitCount_;

	public const int OtherPlayerListCountFieldNumber = 5;

	private int otherPlayerListCount_;

	public const int PresetMaxSlotCountFieldNumber = 6;

	private int presetMaxSlotCount_;

	public const int PresetSlotCountFieldNumber = 7;

	private int presetSlotCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MyRoomDefaultTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MyRoomDefaultTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CarpetLimitCount
	{
		get
		{
			return carpetLimitCount_;
		}
		set
		{
			carpetLimitCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CharLimitCount
	{
		get
		{
			return charLimitCount_;
		}
		set
		{
			charLimitCount_ = value;
		}
	}

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
	public int ObjectLimitCount
	{
		get
		{
			return objectLimitCount_;
		}
		set
		{
			objectLimitCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OtherPlayerListCount
	{
		get
		{
			return otherPlayerListCount_;
		}
		set
		{
			otherPlayerListCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PresetMaxSlotCount
	{
		get
		{
			return presetMaxSlotCount_;
		}
		set
		{
			presetMaxSlotCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PresetSlotCount
	{
		get
		{
			return presetSlotCount_;
		}
		set
		{
			presetSlotCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomDefaultTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomDefaultTable(MyRoomDefaultTable other)
		: this()
	{
		carpetLimitCount_ = other.carpetLimitCount_;
		charLimitCount_ = other.charLimitCount_;
		id_ = other.id_;
		objectLimitCount_ = other.objectLimitCount_;
		otherPlayerListCount_ = other.otherPlayerListCount_;
		presetMaxSlotCount_ = other.presetMaxSlotCount_;
		presetSlotCount_ = other.presetSlotCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomDefaultTable Clone()
	{
		return new MyRoomDefaultTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomDefaultTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MyRoomDefaultTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CarpetLimitCount == other.CarpetLimitCount && CharLimitCount == other.CharLimitCount && Id == other.Id && ObjectLimitCount == other.ObjectLimitCount && OtherPlayerListCount == other.OtherPlayerListCount && PresetMaxSlotCount == other.PresetMaxSlotCount && PresetSlotCount == other.PresetSlotCount)
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
		if (CarpetLimitCount != 0)
		{
			num ^= CarpetLimitCount.GetHashCode();
		}
		if (CharLimitCount != 0)
		{
			num ^= CharLimitCount.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ObjectLimitCount != 0)
		{
			num ^= ObjectLimitCount.GetHashCode();
		}
		if (OtherPlayerListCount != 0)
		{
			num ^= OtherPlayerListCount.GetHashCode();
		}
		if (PresetMaxSlotCount != 0)
		{
			num ^= PresetMaxSlotCount.GetHashCode();
		}
		if (PresetSlotCount != 0)
		{
			num ^= PresetSlotCount.GetHashCode();
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
		if (CarpetLimitCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CarpetLimitCount);
		}
		if (CharLimitCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CharLimitCount);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (ObjectLimitCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ObjectLimitCount);
		}
		if (OtherPlayerListCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(OtherPlayerListCount);
		}
		if (PresetMaxSlotCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PresetMaxSlotCount);
		}
		if (PresetSlotCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(PresetSlotCount);
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
		if (CarpetLimitCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CarpetLimitCount);
		}
		if (CharLimitCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharLimitCount);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ObjectLimitCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObjectLimitCount);
		}
		if (OtherPlayerListCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OtherPlayerListCount);
		}
		if (PresetMaxSlotCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PresetMaxSlotCount);
		}
		if (PresetSlotCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PresetSlotCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MyRoomDefaultTable other)
	{
		if (other != null)
		{
			if (other.CarpetLimitCount != 0)
			{
				CarpetLimitCount = other.CarpetLimitCount;
			}
			if (other.CharLimitCount != 0)
			{
				CharLimitCount = other.CharLimitCount;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ObjectLimitCount != 0)
			{
				ObjectLimitCount = other.ObjectLimitCount;
			}
			if (other.OtherPlayerListCount != 0)
			{
				OtherPlayerListCount = other.OtherPlayerListCount;
			}
			if (other.PresetMaxSlotCount != 0)
			{
				PresetMaxSlotCount = other.PresetMaxSlotCount;
			}
			if (other.PresetSlotCount != 0)
			{
				PresetSlotCount = other.PresetSlotCount;
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
				CarpetLimitCount = input.ReadInt32();
				break;
			case 16u:
				CharLimitCount = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				ObjectLimitCount = input.ReadInt32();
				break;
			case 40u:
				OtherPlayerListCount = input.ReadInt32();
				break;
			case 48u:
				PresetMaxSlotCount = input.ReadInt32();
				break;
			case 56u:
				PresetSlotCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
