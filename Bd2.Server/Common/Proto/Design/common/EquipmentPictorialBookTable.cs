using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EquipmentPictorialBookTable : IMessage<EquipmentPictorialBookTable>, IMessage, IEquatable<EquipmentPictorialBookTable>, IDeepCloneable<EquipmentPictorialBookTable>, IBufferMessage
{
	private static readonly MessageParser<EquipmentPictorialBookTable> _parser = new MessageParser<EquipmentPictorialBookTable>(() => new EquipmentPictorialBookTable());

	private UnknownFieldSet _unknownFields;

	public const int CategoryFieldNumber = 1;

	private int category_;

	public const int CollectionBuffIdFieldNumber = 2;

	private int collectionBuffId_;

	public const int EquipmentGroupIdFieldNumber = 3;

	private int equipmentGroupId_;

	public const int EquipmentIdFieldNumber = 4;

	private int equipmentId_;

	public const int IdFieldNumber = 5;

	private int id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipmentPictorialBookTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipmentPictorialBookTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Category
	{
		get
		{
			return category_;
		}
		set
		{
			category_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CollectionBuffId
	{
		get
		{
			return collectionBuffId_;
		}
		set
		{
			collectionBuffId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EquipmentGroupId
	{
		get
		{
			return equipmentGroupId_;
		}
		set
		{
			equipmentGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EquipmentId
	{
		get
		{
			return equipmentId_;
		}
		set
		{
			equipmentId_ = value;
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
	public EquipmentPictorialBookTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentPictorialBookTable(EquipmentPictorialBookTable other)
		: this()
	{
		category_ = other.category_;
		collectionBuffId_ = other.collectionBuffId_;
		equipmentGroupId_ = other.equipmentGroupId_;
		equipmentId_ = other.equipmentId_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentPictorialBookTable Clone()
	{
		return new EquipmentPictorialBookTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentPictorialBookTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipmentPictorialBookTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Category == other.Category && CollectionBuffId == other.CollectionBuffId && EquipmentGroupId == other.EquipmentGroupId && EquipmentId == other.EquipmentId && Id == other.Id)
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
		if (Category != 0)
		{
			num ^= Category.GetHashCode();
		}
		if (CollectionBuffId != 0)
		{
			num ^= CollectionBuffId.GetHashCode();
		}
		if (EquipmentGroupId != 0)
		{
			num ^= EquipmentGroupId.GetHashCode();
		}
		if (EquipmentId != 0)
		{
			num ^= EquipmentId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (Category != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Category);
		}
		if (CollectionBuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CollectionBuffId);
		}
		if (EquipmentGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EquipmentGroupId);
		}
		if (EquipmentId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EquipmentId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
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
		if (Category != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Category);
		}
		if (CollectionBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectionBuffId);
		}
		if (EquipmentGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipmentGroupId);
		}
		if (EquipmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipmentId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EquipmentPictorialBookTable other)
	{
		if (other != null)
		{
			if (other.Category != 0)
			{
				Category = other.Category;
			}
			if (other.CollectionBuffId != 0)
			{
				CollectionBuffId = other.CollectionBuffId;
			}
			if (other.EquipmentGroupId != 0)
			{
				EquipmentGroupId = other.EquipmentGroupId;
			}
			if (other.EquipmentId != 0)
			{
				EquipmentId = other.EquipmentId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
				Category = input.ReadInt32();
				break;
			case 16u:
				CollectionBuffId = input.ReadInt32();
				break;
			case 24u:
				EquipmentGroupId = input.ReadInt32();
				break;
			case 32u:
				EquipmentId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
