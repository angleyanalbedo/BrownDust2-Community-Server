using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ItemPictorialBookTable : IMessage<ItemPictorialBookTable>, IMessage, IEquatable<ItemPictorialBookTable>, IDeepCloneable<ItemPictorialBookTable>, IBufferMessage
{
	private static readonly MessageParser<ItemPictorialBookTable> _parser = new MessageParser<ItemPictorialBookTable>(() => new ItemPictorialBookTable());

	private UnknownFieldSet _unknownFields;

	public const int CategoryFieldNumber = 1;

	private int category_;

	public const int CollectionBuffIdFieldNumber = 2;

	private int collectionBuffId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ItemIdFieldNumber = 4;

	private int itemId_;

	public const int PackIdFieldNumber = 5;

	private int packId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ItemPictorialBookTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ItemPictorialBookTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemPictorialBookTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemPictorialBookTable(ItemPictorialBookTable other)
		: this()
	{
		category_ = other.category_;
		collectionBuffId_ = other.collectionBuffId_;
		id_ = other.id_;
		itemId_ = other.itemId_;
		packId_ = other.packId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ItemPictorialBookTable Clone()
	{
		return new ItemPictorialBookTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ItemPictorialBookTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ItemPictorialBookTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Category == other.Category && CollectionBuffId == other.CollectionBuffId && Id == other.Id && ItemId == other.ItemId && PackId == other.PackId)
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
		if (Category != 0)
		{
			num ^= Category.GetHashCode();
		}
		if (CollectionBuffId != 0)
		{
			num ^= CollectionBuffId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ItemId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PackId);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ItemPictorialBookTable other)
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
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
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
				Id = input.ReadInt32();
				break;
			case 32u:
				ItemId = input.ReadInt32();
				break;
			case 40u:
				PackId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
