using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ContentTicketTable : IMessage<ContentTicketTable>, IMessage, IEquatable<ContentTicketTable>, IDeepCloneable<ContentTicketTable>, IBufferMessage
{
	private static readonly MessageParser<ContentTicketTable> _parser = new MessageParser<ContentTicketTable>(() => new ContentTicketTable());

	private UnknownFieldSet _unknownFields;

	public const int DescLocalTextIdFieldNumber = 1;

	private int descLocalTextId_;

	public const int IconSpriteNameFieldNumber = 2;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ItemDescNameTextIdFieldNumber = 4;

	private int itemDescNameTextId_;

	public const int ItemNameTextIdFieldNumber = 5;

	private int itemNameTextId_;

	public const int ItemSubNameTextIdFieldNumber = 6;

	private int itemSubNameTextId_;

	public const int TypeFieldNumber = 7;

	private int type_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContentTicketTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ContentTicketTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DescLocalTextId
	{
		get
		{
			return descLocalTextId_;
		}
		set
		{
			descLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IconSpriteName
	{
		get
		{
			return iconSpriteName_;
		}
		set
		{
			iconSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public int ItemDescNameTextId
	{
		get
		{
			return itemDescNameTextId_;
		}
		set
		{
			itemDescNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemNameTextId
	{
		get
		{
			return itemNameTextId_;
		}
		set
		{
			itemNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ItemSubNameTextId
	{
		get
		{
			return itemSubNameTextId_;
		}
		set
		{
			itemSubNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Type
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
	public ContentTicketTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContentTicketTable(ContentTicketTable other)
		: this()
	{
		descLocalTextId_ = other.descLocalTextId_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		itemDescNameTextId_ = other.itemDescNameTextId_;
		itemNameTextId_ = other.itemNameTextId_;
		itemSubNameTextId_ = other.itemSubNameTextId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContentTicketTable Clone()
	{
		return new ContentTicketTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ContentTicketTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContentTicketTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DescLocalTextId == other.DescLocalTextId && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && ItemDescNameTextId == other.ItemDescNameTextId && ItemNameTextId == other.ItemNameTextId && ItemSubNameTextId == other.ItemSubNameTextId && Type == other.Type)
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
		if (DescLocalTextId != 0)
		{
			num ^= DescLocalTextId.GetHashCode();
		}
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ItemDescNameTextId != 0)
		{
			num ^= ItemDescNameTextId.GetHashCode();
		}
		if (ItemNameTextId != 0)
		{
			num ^= ItemNameTextId.GetHashCode();
		}
		if (ItemSubNameTextId != 0)
		{
			num ^= ItemSubNameTextId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (DescLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DescLocalTextId);
		}
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (ItemDescNameTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ItemDescNameTextId);
		}
		if (ItemNameTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ItemNameTextId);
		}
		if (ItemSubNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ItemSubNameTextId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Type);
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
		if (DescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DescLocalTextId);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ItemDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemDescNameTextId);
		}
		if (ItemNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemNameTextId);
		}
		if (ItemSubNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemSubNameTextId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContentTicketTable other)
	{
		if (other != null)
		{
			if (other.DescLocalTextId != 0)
			{
				DescLocalTextId = other.DescLocalTextId;
			}
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemDescNameTextId != 0)
			{
				ItemDescNameTextId = other.ItemDescNameTextId;
			}
			if (other.ItemNameTextId != 0)
			{
				ItemNameTextId = other.ItemNameTextId;
			}
			if (other.ItemSubNameTextId != 0)
			{
				ItemSubNameTextId = other.ItemSubNameTextId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
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
				DescLocalTextId = input.ReadInt32();
				break;
			case 18u:
				IconSpriteName = input.ReadString();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				ItemDescNameTextId = input.ReadInt32();
				break;
			case 40u:
				ItemNameTextId = input.ReadInt32();
				break;
			case 48u:
				ItemSubNameTextId = input.ReadInt32();
				break;
			case 56u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
