using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLGrowthTable : IMessage<RLGrowthTable>, IMessage, IEquatable<RLGrowthTable>, IDeepCloneable<RLGrowthTable>, IBufferMessage
{
	private static readonly MessageParser<RLGrowthTable> _parser = new MessageParser<RLGrowthTable>(() => new RLGrowthTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int GrowthDescLocalTextIdFieldNumber = 2;

	private int growthDescLocalTextId_;

	public const int GrowthIconFieldNumber = 3;

	private string growthIcon_ = "";

	public const int GrowthNameLocalTextIdFieldNumber = 4;

	private int growthNameLocalTextId_;

	public const int GrowthTypeFieldNumber = 5;

	private int growthType_;

	public const int GrowthValueFieldNumber = 6;

	private double growthValue_;

	public const int IdFieldNumber = 7;

	private int id_;

	public const int PriceCountFieldNumber = 8;

	private int priceCount_;

	public const int PriceIdFieldNumber = 9;

	private int priceId_;

	public const int PriceTypeFieldNumber = 10;

	private int priceType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RLGrowthTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RLGrowthTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GrowthDescLocalTextId
	{
		get
		{
			return growthDescLocalTextId_;
		}
		set
		{
			growthDescLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GrowthIcon
	{
		get
		{
			return growthIcon_;
		}
		set
		{
			growthIcon_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GrowthNameLocalTextId
	{
		get
		{
			return growthNameLocalTextId_;
		}
		set
		{
			growthNameLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GrowthType
	{
		get
		{
			return growthType_;
		}
		set
		{
			growthType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double GrowthValue
	{
		get
		{
			return growthValue_;
		}
		set
		{
			growthValue_ = value;
		}
	}

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PriceCount
	{
		get
		{
			return priceCount_;
		}
		set
		{
			priceCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PriceId
	{
		get
		{
			return priceId_;
		}
		set
		{
			priceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PriceType
	{
		get
		{
			return priceType_;
		}
		set
		{
			priceType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLGrowthTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLGrowthTable(RLGrowthTable other)
		: this()
	{
		groupId_ = other.groupId_;
		growthDescLocalTextId_ = other.growthDescLocalTextId_;
		growthIcon_ = other.growthIcon_;
		growthNameLocalTextId_ = other.growthNameLocalTextId_;
		growthType_ = other.growthType_;
		growthValue_ = other.growthValue_;
		id_ = other.id_;
		priceCount_ = other.priceCount_;
		priceId_ = other.priceId_;
		priceType_ = other.priceType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLGrowthTable Clone()
	{
		return new RLGrowthTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLGrowthTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RLGrowthTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && GrowthDescLocalTextId == other.GrowthDescLocalTextId && !(GrowthIcon != other.GrowthIcon) && GrowthNameLocalTextId == other.GrowthNameLocalTextId && GrowthType == other.GrowthType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GrowthValue, other.GrowthValue) && Id == other.Id && PriceCount == other.PriceCount && PriceId == other.PriceId && PriceType == other.PriceType)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (GrowthDescLocalTextId != 0)
		{
			num ^= GrowthDescLocalTextId.GetHashCode();
		}
		if (GrowthIcon.Length != 0)
		{
			num ^= GrowthIcon.GetHashCode();
		}
		if (GrowthNameLocalTextId != 0)
		{
			num ^= GrowthNameLocalTextId.GetHashCode();
		}
		if (GrowthType != 0)
		{
			num ^= GrowthType.GetHashCode();
		}
		if (GrowthValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GrowthValue);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PriceCount != 0)
		{
			num ^= PriceCount.GetHashCode();
		}
		if (PriceId != 0)
		{
			num ^= PriceId.GetHashCode();
		}
		if (PriceType != 0)
		{
			num ^= PriceType.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (GrowthDescLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GrowthDescLocalTextId);
		}
		if (GrowthIcon.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(GrowthIcon);
		}
		if (GrowthNameLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GrowthNameLocalTextId);
		}
		if (GrowthType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GrowthType);
		}
		if (GrowthValue != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(GrowthValue);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		if (PriceCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PriceCount);
		}
		if (PriceId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PriceId);
		}
		if (PriceType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PriceType);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (GrowthDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GrowthDescLocalTextId);
		}
		if (GrowthIcon.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GrowthIcon);
		}
		if (GrowthNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GrowthNameLocalTextId);
		}
		if (GrowthType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GrowthType);
		}
		if (GrowthValue != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PriceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceCount);
		}
		if (PriceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceId);
		}
		if (PriceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(RLGrowthTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GrowthDescLocalTextId != 0)
			{
				GrowthDescLocalTextId = other.GrowthDescLocalTextId;
			}
			if (other.GrowthIcon.Length != 0)
			{
				GrowthIcon = other.GrowthIcon;
			}
			if (other.GrowthNameLocalTextId != 0)
			{
				GrowthNameLocalTextId = other.GrowthNameLocalTextId;
			}
			if (other.GrowthType != 0)
			{
				GrowthType = other.GrowthType;
			}
			if (other.GrowthValue != 0.0)
			{
				GrowthValue = other.GrowthValue;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PriceCount != 0)
			{
				PriceCount = other.PriceCount;
			}
			if (other.PriceId != 0)
			{
				PriceId = other.PriceId;
			}
			if (other.PriceType != 0)
			{
				PriceType = other.PriceType;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
				GrowthDescLocalTextId = input.ReadInt32();
				break;
			case 26u:
				GrowthIcon = input.ReadString();
				break;
			case 32u:
				GrowthNameLocalTextId = input.ReadInt32();
				break;
			case 40u:
				GrowthType = input.ReadInt32();
				break;
			case 49u:
				GrowthValue = input.ReadDouble();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 64u:
				PriceCount = input.ReadInt32();
				break;
			case 72u:
				PriceId = input.ReadInt32();
				break;
			case 80u:
				PriceType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
