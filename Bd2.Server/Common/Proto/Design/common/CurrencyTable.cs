using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CurrencyTable : IMessage<CurrencyTable>, IMessage, IEquatable<CurrencyTable>, IDeepCloneable<CurrencyTable>, IBufferMessage
{
	private static readonly MessageParser<CurrencyTable> _parser = new MessageParser<CurrencyTable>(() => new CurrencyTable());

	private UnknownFieldSet _unknownFields;

	public const int IconSpriteNameLargeFieldNumber = 1;

	private string iconSpriteNameLarge_ = "";

	public const int IconSpriteNameSmallFieldNumber = 2;

	private string iconSpriteNameSmall_ = "";

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ItemDescNameTextIdFieldNumber = 4;

	private int itemDescNameTextId_;

	public const int ItemNameTextIdFieldNumber = 5;

	private int itemNameTextId_;

	public const int TargetItemIdFieldNumber = 6;

	private int targetItemId_;

	public const int TargetItemTypeFieldNumber = 7;

	private int targetItemType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CurrencyTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CurrencyTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IconSpriteNameLarge
	{
		get
		{
			return iconSpriteNameLarge_;
		}
		set
		{
			iconSpriteNameLarge_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IconSpriteNameSmall
	{
		get
		{
			return iconSpriteNameSmall_;
		}
		set
		{
			iconSpriteNameSmall_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TargetItemId
	{
		get
		{
			return targetItemId_;
		}
		set
		{
			targetItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TargetItemType
	{
		get
		{
			return targetItemType_;
		}
		set
		{
			targetItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurrencyTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurrencyTable(CurrencyTable other)
		: this()
	{
		iconSpriteNameLarge_ = other.iconSpriteNameLarge_;
		iconSpriteNameSmall_ = other.iconSpriteNameSmall_;
		id_ = other.id_;
		itemDescNameTextId_ = other.itemDescNameTextId_;
		itemNameTextId_ = other.itemNameTextId_;
		targetItemId_ = other.targetItemId_;
		targetItemType_ = other.targetItemType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurrencyTable Clone()
	{
		return new CurrencyTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CurrencyTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CurrencyTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(IconSpriteNameLarge != other.IconSpriteNameLarge) && !(IconSpriteNameSmall != other.IconSpriteNameSmall) && Id == other.Id && ItemDescNameTextId == other.ItemDescNameTextId && ItemNameTextId == other.ItemNameTextId && TargetItemId == other.TargetItemId && TargetItemType == other.TargetItemType)
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
		if (IconSpriteNameLarge.Length != 0)
		{
			num ^= IconSpriteNameLarge.GetHashCode();
		}
		if (IconSpriteNameSmall.Length != 0)
		{
			num ^= IconSpriteNameSmall.GetHashCode();
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
		if (TargetItemId != 0)
		{
			num ^= TargetItemId.GetHashCode();
		}
		if (TargetItemType != 0)
		{
			num ^= TargetItemType.GetHashCode();
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
		if (IconSpriteNameLarge.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(IconSpriteNameLarge);
		}
		if (IconSpriteNameSmall.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(IconSpriteNameSmall);
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
		if (TargetItemId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TargetItemId);
		}
		if (TargetItemType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TargetItemType);
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
		if (IconSpriteNameLarge.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteNameLarge);
		}
		if (IconSpriteNameSmall.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteNameSmall);
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
		if (TargetItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetItemId);
		}
		if (TargetItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetItemType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CurrencyTable other)
	{
		if (other != null)
		{
			if (other.IconSpriteNameLarge.Length != 0)
			{
				IconSpriteNameLarge = other.IconSpriteNameLarge;
			}
			if (other.IconSpriteNameSmall.Length != 0)
			{
				IconSpriteNameSmall = other.IconSpriteNameSmall;
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
			if (other.TargetItemId != 0)
			{
				TargetItemId = other.TargetItemId;
			}
			if (other.TargetItemType != 0)
			{
				TargetItemType = other.TargetItemType;
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
			case 10u:
				IconSpriteNameLarge = input.ReadString();
				break;
			case 18u:
				IconSpriteNameSmall = input.ReadString();
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
				TargetItemId = input.ReadInt32();
				break;
			case 56u:
				TargetItemType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
