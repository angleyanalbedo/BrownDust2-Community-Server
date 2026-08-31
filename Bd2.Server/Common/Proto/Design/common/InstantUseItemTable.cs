using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class InstantUseItemTable : IMessage<InstantUseItemTable>, IMessage, IEquatable<InstantUseItemTable>, IDeepCloneable<InstantUseItemTable>, IBufferMessage
{
	private static readonly MessageParser<InstantUseItemTable> _parser = new MessageParser<InstantUseItemTable>(() => new InstantUseItemTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int ItemDescNameTextIdFieldNumber = 2;

	private int itemDescNameTextId_;

	public const int ItemNameTextIdFieldNumber = 3;

	private int itemNameTextId_;

	public const int ItemSpriteNameFieldNumber = 4;

	private string itemSpriteName_ = "";

	public const int ItemSubNameTextIdFieldNumber = 5;

	private int itemSubNameTextId_;

	public const int TypeFieldNumber = 6;

	private int type_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<InstantUseItemTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => InstantUseItemTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string ItemSpriteName
	{
		get
		{
			return itemSpriteName_;
		}
		set
		{
			itemSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InstantUseItemTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InstantUseItemTable(InstantUseItemTable other)
		: this()
	{
		id_ = other.id_;
		itemDescNameTextId_ = other.itemDescNameTextId_;
		itemNameTextId_ = other.itemNameTextId_;
		itemSpriteName_ = other.itemSpriteName_;
		itemSubNameTextId_ = other.itemSubNameTextId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InstantUseItemTable Clone()
	{
		return new InstantUseItemTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as InstantUseItemTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InstantUseItemTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && ItemDescNameTextId == other.ItemDescNameTextId && ItemNameTextId == other.ItemNameTextId && !(ItemSpriteName != other.ItemSpriteName) && ItemSubNameTextId == other.ItemSubNameTextId && Type == other.Type)
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
		if (ItemSpriteName.Length != 0)
		{
			num ^= ItemSpriteName.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ItemDescNameTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemDescNameTextId);
		}
		if (ItemNameTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ItemNameTextId);
		}
		if (ItemSpriteName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ItemSpriteName);
		}
		if (ItemSubNameTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ItemSubNameTextId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(48);
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
		if (ItemSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ItemSpriteName);
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
	public void MergeFrom(InstantUseItemTable other)
	{
		if (other != null)
		{
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
			if (other.ItemSpriteName.Length != 0)
			{
				ItemSpriteName = other.ItemSpriteName;
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
				ItemDescNameTextId = input.ReadInt32();
				break;
			case 24u:
				ItemNameTextId = input.ReadInt32();
				break;
			case 34u:
				ItemSpriteName = input.ReadString();
				break;
			case 40u:
				ItemSubNameTextId = input.ReadInt32();
				break;
			case 48u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
