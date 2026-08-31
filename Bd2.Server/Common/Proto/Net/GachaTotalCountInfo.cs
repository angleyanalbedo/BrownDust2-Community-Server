using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaTotalCountInfo : IMessage<GachaTotalCountInfo>, IMessage, IEquatable<GachaTotalCountInfo>, IDeepCloneable<GachaTotalCountInfo>, IBufferMessage
{
	private static readonly MessageParser<GachaTotalCountInfo> _parser = new MessageParser<GachaTotalCountInfo>(() => new GachaTotalCountInfo());

	private UnknownFieldSet _unknownFields;

	public const int GachaLogTypeFieldNumber = 1;

	private Define_GachaLogType gachaLogType_;

	public const int Char5PickUpCostumeFieldNumber = 2;

	private int char5PickUpCostume_;

	public const int Char5CostumeFieldNumber = 3;

	private int char5Costume_;

	public const int Char4CostumeFieldNumber = 4;

	private int char4Costume_;

	public const int Char3CostumeFieldNumber = 5;

	private int char3Costume_;

	public const int Char5PickUpEquip4FieldNumber = 6;

	private int char5PickUpEquip4_;

	public const int Char5Equip4FieldNumber = 7;

	private int char5Equip4_;

	public const int Char5Equip3FieldNumber = 8;

	private int char5Equip3_;

	public const int Char4Equip4FieldNumber = 9;

	private int char4Equip4_;

	public const int Char4Equip3FieldNumber = 10;

	private int char4Equip3_;

	public const int Char4Equip2FieldNumber = 11;

	private int char4Equip2_;

	public const int Char3Equip4FieldNumber = 12;

	private int char3Equip4_;

	public const int Char3Equip3FieldNumber = 13;

	private int char3Equip3_;

	public const int Char3Equip2FieldNumber = 14;

	private int char3Equip2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaTotalCountInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaLogDBInfoReflection.Descriptor.MessageTypes[1];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_GachaLogType GachaLogType
	{
		get
		{
			return gachaLogType_;
		}
		set
		{
			gachaLogType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Char5PickUpCostume
	{
		get
		{
			return char5PickUpCostume_;
		}
		set
		{
			char5PickUpCostume_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Char5Costume
	{
		get
		{
			return char5Costume_;
		}
		set
		{
			char5Costume_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Char4Costume
	{
		get
		{
			return char4Costume_;
		}
		set
		{
			char4Costume_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Char3Costume
	{
		get
		{
			return char3Costume_;
		}
		set
		{
			char3Costume_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Char5PickUpEquip4
	{
		get
		{
			return char5PickUpEquip4_;
		}
		set
		{
			char5PickUpEquip4_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Char5Equip4
	{
		get
		{
			return char5Equip4_;
		}
		set
		{
			char5Equip4_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Char5Equip3
	{
		get
		{
			return char5Equip3_;
		}
		set
		{
			char5Equip3_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Char4Equip4
	{
		get
		{
			return char4Equip4_;
		}
		set
		{
			char4Equip4_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Char4Equip3
	{
		get
		{
			return char4Equip3_;
		}
		set
		{
			char4Equip3_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Char4Equip2
	{
		get
		{
			return char4Equip2_;
		}
		set
		{
			char4Equip2_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Char3Equip4
	{
		get
		{
			return char3Equip4_;
		}
		set
		{
			char3Equip4_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Char3Equip3
	{
		get
		{
			return char3Equip3_;
		}
		set
		{
			char3Equip3_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Char3Equip2
	{
		get
		{
			return char3Equip2_;
		}
		set
		{
			char3Equip2_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaTotalCountInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaTotalCountInfo(GachaTotalCountInfo other)
		: this()
	{
		gachaLogType_ = other.gachaLogType_;
		char5PickUpCostume_ = other.char5PickUpCostume_;
		char5Costume_ = other.char5Costume_;
		char4Costume_ = other.char4Costume_;
		char3Costume_ = other.char3Costume_;
		char5PickUpEquip4_ = other.char5PickUpEquip4_;
		char5Equip4_ = other.char5Equip4_;
		char5Equip3_ = other.char5Equip3_;
		char4Equip4_ = other.char4Equip4_;
		char4Equip3_ = other.char4Equip3_;
		char4Equip2_ = other.char4Equip2_;
		char3Equip4_ = other.char3Equip4_;
		char3Equip3_ = other.char3Equip3_;
		char3Equip2_ = other.char3Equip2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaTotalCountInfo Clone()
	{
		return new GachaTotalCountInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaTotalCountInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaTotalCountInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GachaLogType == other.GachaLogType && Char5PickUpCostume == other.Char5PickUpCostume && Char5Costume == other.Char5Costume && Char4Costume == other.Char4Costume && Char3Costume == other.Char3Costume && Char5PickUpEquip4 == other.Char5PickUpEquip4 && Char5Equip4 == other.Char5Equip4 && Char5Equip3 == other.Char5Equip3 && Char4Equip4 == other.Char4Equip4 && Char4Equip3 == other.Char4Equip3 && Char4Equip2 == other.Char4Equip2 && Char3Equip4 == other.Char3Equip4 && Char3Equip3 == other.Char3Equip3 && Char3Equip2 == other.Char3Equip2)
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
		if (GachaLogType != Define_GachaLogType.GachaLogCostumePickUp)
		{
			num ^= GachaLogType.GetHashCode();
		}
		if (Char5PickUpCostume != 0)
		{
			num ^= Char5PickUpCostume.GetHashCode();
		}
		if (Char5Costume != 0)
		{
			num ^= Char5Costume.GetHashCode();
		}
		if (Char4Costume != 0)
		{
			num ^= Char4Costume.GetHashCode();
		}
		if (Char3Costume != 0)
		{
			num ^= Char3Costume.GetHashCode();
		}
		if (Char5PickUpEquip4 != 0)
		{
			num ^= Char5PickUpEquip4.GetHashCode();
		}
		if (Char5Equip4 != 0)
		{
			num ^= Char5Equip4.GetHashCode();
		}
		if (Char5Equip3 != 0)
		{
			num ^= Char5Equip3.GetHashCode();
		}
		if (Char4Equip4 != 0)
		{
			num ^= Char4Equip4.GetHashCode();
		}
		if (Char4Equip3 != 0)
		{
			num ^= Char4Equip3.GetHashCode();
		}
		if (Char4Equip2 != 0)
		{
			num ^= Char4Equip2.GetHashCode();
		}
		if (Char3Equip4 != 0)
		{
			num ^= Char3Equip4.GetHashCode();
		}
		if (Char3Equip3 != 0)
		{
			num ^= Char3Equip3.GetHashCode();
		}
		if (Char3Equip2 != 0)
		{
			num ^= Char3Equip2.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (GachaLogType != Define_GachaLogType.GachaLogCostumePickUp)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)GachaLogType);
		}
		if (Char5PickUpCostume != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Char5PickUpCostume);
		}
		if (Char5Costume != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Char5Costume);
		}
		if (Char4Costume != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Char4Costume);
		}
		if (Char3Costume != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Char3Costume);
		}
		if (Char5PickUpEquip4 != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Char5PickUpEquip4);
		}
		if (Char5Equip4 != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Char5Equip4);
		}
		if (Char5Equip3 != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Char5Equip3);
		}
		if (Char4Equip4 != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Char4Equip4);
		}
		if (Char4Equip3 != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Char4Equip3);
		}
		if (Char4Equip2 != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Char4Equip2);
		}
		if (Char3Equip4 != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Char3Equip4);
		}
		if (Char3Equip3 != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(Char3Equip3);
		}
		if (Char3Equip2 != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(Char3Equip2);
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
		if (GachaLogType != Define_GachaLogType.GachaLogCostumePickUp)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GachaLogType);
		}
		if (Char5PickUpCostume != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char5PickUpCostume);
		}
		if (Char5Costume != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char5Costume);
		}
		if (Char4Costume != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char4Costume);
		}
		if (Char3Costume != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char3Costume);
		}
		if (Char5PickUpEquip4 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char5PickUpEquip4);
		}
		if (Char5Equip4 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char5Equip4);
		}
		if (Char5Equip3 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char5Equip3);
		}
		if (Char4Equip4 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char4Equip4);
		}
		if (Char4Equip3 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char4Equip3);
		}
		if (Char4Equip2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char4Equip2);
		}
		if (Char3Equip4 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char3Equip4);
		}
		if (Char3Equip3 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char3Equip3);
		}
		if (Char3Equip2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Char3Equip2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaTotalCountInfo other)
	{
		if (other != null)
		{
			if (other.GachaLogType != Define_GachaLogType.GachaLogCostumePickUp)
			{
				GachaLogType = other.GachaLogType;
			}
			if (other.Char5PickUpCostume != 0)
			{
				Char5PickUpCostume = other.Char5PickUpCostume;
			}
			if (other.Char5Costume != 0)
			{
				Char5Costume = other.Char5Costume;
			}
			if (other.Char4Costume != 0)
			{
				Char4Costume = other.Char4Costume;
			}
			if (other.Char3Costume != 0)
			{
				Char3Costume = other.Char3Costume;
			}
			if (other.Char5PickUpEquip4 != 0)
			{
				Char5PickUpEquip4 = other.Char5PickUpEquip4;
			}
			if (other.Char5Equip4 != 0)
			{
				Char5Equip4 = other.Char5Equip4;
			}
			if (other.Char5Equip3 != 0)
			{
				Char5Equip3 = other.Char5Equip3;
			}
			if (other.Char4Equip4 != 0)
			{
				Char4Equip4 = other.Char4Equip4;
			}
			if (other.Char4Equip3 != 0)
			{
				Char4Equip3 = other.Char4Equip3;
			}
			if (other.Char4Equip2 != 0)
			{
				Char4Equip2 = other.Char4Equip2;
			}
			if (other.Char3Equip4 != 0)
			{
				Char3Equip4 = other.Char3Equip4;
			}
			if (other.Char3Equip3 != 0)
			{
				Char3Equip3 = other.Char3Equip3;
			}
			if (other.Char3Equip2 != 0)
			{
				Char3Equip2 = other.Char3Equip2;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 8u:
				GachaLogType = (Define_GachaLogType)input.ReadEnum();
				break;
			case 16u:
				Char5PickUpCostume = input.ReadInt32();
				break;
			case 24u:
				Char5Costume = input.ReadInt32();
				break;
			case 32u:
				Char4Costume = input.ReadInt32();
				break;
			case 40u:
				Char3Costume = input.ReadInt32();
				break;
			case 48u:
				Char5PickUpEquip4 = input.ReadInt32();
				break;
			case 56u:
				Char5Equip4 = input.ReadInt32();
				break;
			case 64u:
				Char5Equip3 = input.ReadInt32();
				break;
			case 72u:
				Char4Equip4 = input.ReadInt32();
				break;
			case 80u:
				Char4Equip3 = input.ReadInt32();
				break;
			case 88u:
				Char4Equip2 = input.ReadInt32();
				break;
			case 96u:
				Char3Equip4 = input.ReadInt32();
				break;
			case 104u:
				Char3Equip3 = input.ReadInt32();
				break;
			case 112u:
				Char3Equip2 = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
