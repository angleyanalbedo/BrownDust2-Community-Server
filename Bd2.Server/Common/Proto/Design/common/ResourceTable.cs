using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ResourceTable : IMessage<ResourceTable>, IMessage, IEquatable<ResourceTable>, IDeepCloneable<ResourceTable>, IBufferMessage
{
	private static readonly MessageParser<ResourceTable> _parser = new MessageParser<ResourceTable>(() => new ResourceTable());

	private UnknownFieldSet _unknownFields;

	public const int GradeFieldNumber = 1;

	private int grade_;

	public const int IconBackgroundNameFieldNumber = 2;

	private string iconBackgroundName_ = "";

	public const int IconSpriteNameFieldNumber = 3;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 4;

	private int id_;

	public const int ItemAcquireIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_itemAcquireId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> itemAcquireId_ = new RepeatedField<int>();

	public const int ItemDescNameTextIdFieldNumber = 6;

	private int itemDescNameTextId_;

	public const int ItemNameTextIdFieldNumber = 7;

	private int itemNameTextId_;

	public const int ItemSubNameTextIdFieldNumber = 8;

	private int itemSubNameTextId_;

	public const int MagicValueFieldNumber = 9;

	private int magicValue_;

	public const int NotTrashFieldNumber = 10;

	private int notTrash_;

	public const int SortTypeFieldNumber = 11;

	private int sortType_;

	public const int StackCountFieldNumber = 12;

	private int stackCount_;

	public const int TypeFieldNumber = 13;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ResourceTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ResourceTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Grade
	{
		get
		{
			return grade_;
		}
		set
		{
			grade_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string IconBackgroundName
	{
		get
		{
			return iconBackgroundName_;
		}
		set
		{
			iconBackgroundName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public RepeatedField<int> ItemAcquireId => itemAcquireId_;

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
	public int MagicValue
	{
		get
		{
			return magicValue_;
		}
		set
		{
			magicValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NotTrash
	{
		get
		{
			return notTrash_;
		}
		set
		{
			notTrash_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SortType
	{
		get
		{
			return sortType_;
		}
		set
		{
			sortType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StackCount
	{
		get
		{
			return stackCount_;
		}
		set
		{
			stackCount_ = value;
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
	public ResourceTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ResourceTable(ResourceTable other)
		: this()
	{
		grade_ = other.grade_;
		iconBackgroundName_ = other.iconBackgroundName_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		itemAcquireId_ = other.itemAcquireId_.Clone();
		itemDescNameTextId_ = other.itemDescNameTextId_;
		itemNameTextId_ = other.itemNameTextId_;
		itemSubNameTextId_ = other.itemSubNameTextId_;
		magicValue_ = other.magicValue_;
		notTrash_ = other.notTrash_;
		sortType_ = other.sortType_;
		stackCount_ = other.stackCount_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResourceTable Clone()
	{
		return new ResourceTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ResourceTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ResourceTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Grade == other.Grade && !(IconBackgroundName != other.IconBackgroundName) && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && itemAcquireId_.Equals(other.itemAcquireId_) && ItemDescNameTextId == other.ItemDescNameTextId && ItemNameTextId == other.ItemNameTextId && ItemSubNameTextId == other.ItemSubNameTextId && MagicValue == other.MagicValue && NotTrash == other.NotTrash && SortType == other.SortType && StackCount == other.StackCount && Type == other.Type)
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
		if (Grade != 0)
		{
			num ^= Grade.GetHashCode();
		}
		if (IconBackgroundName.Length != 0)
		{
			num ^= IconBackgroundName.GetHashCode();
		}
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= itemAcquireId_.GetHashCode();
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
		if (MagicValue != 0)
		{
			num ^= MagicValue.GetHashCode();
		}
		if (NotTrash != 0)
		{
			num ^= NotTrash.GetHashCode();
		}
		if (SortType != 0)
		{
			num ^= SortType.GetHashCode();
		}
		if (StackCount != 0)
		{
			num ^= StackCount.GetHashCode();
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
		if (Grade != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Grade);
		}
		if (IconBackgroundName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(IconBackgroundName);
		}
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		itemAcquireId_.WriteTo(ref output, _repeated_itemAcquireId_codec);
		if (ItemDescNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ItemDescNameTextId);
		}
		if (ItemNameTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ItemNameTextId);
		}
		if (ItemSubNameTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ItemSubNameTextId);
		}
		if (MagicValue != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MagicValue);
		}
		if (NotTrash != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(NotTrash);
		}
		if (SortType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(SortType);
		}
		if (StackCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(StackCount);
		}
		if (Type != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(Type);
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
		if (Grade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Grade);
		}
		if (IconBackgroundName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconBackgroundName);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += itemAcquireId_.CalculateSize(_repeated_itemAcquireId_codec);
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
		if (MagicValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MagicValue);
		}
		if (NotTrash != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotTrash);
		}
		if (SortType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortType);
		}
		if (StackCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StackCount);
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
	public void MergeFrom(ResourceTable other)
	{
		if (other != null)
		{
			if (other.Grade != 0)
			{
				Grade = other.Grade;
			}
			if (other.IconBackgroundName.Length != 0)
			{
				IconBackgroundName = other.IconBackgroundName;
			}
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			itemAcquireId_.Add(other.itemAcquireId_);
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
			if (other.MagicValue != 0)
			{
				MagicValue = other.MagicValue;
			}
			if (other.NotTrash != 0)
			{
				NotTrash = other.NotTrash;
			}
			if (other.SortType != 0)
			{
				SortType = other.SortType;
			}
			if (other.StackCount != 0)
			{
				StackCount = other.StackCount;
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
			case 32u:
				Id = input.ReadInt32();
				break;
			case 48u:
				ItemDescNameTextId = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				itemAcquireId_.AddEntriesFrom(ref input, _repeated_itemAcquireId_codec);
				break;
			case 8u:
				Grade = input.ReadInt32();
				break;
			case 18u:
				IconBackgroundName = input.ReadString();
				break;
			case 26u:
				IconSpriteName = input.ReadString();
				break;
			case 56u:
				ItemNameTextId = input.ReadInt32();
				break;
			case 64u:
				ItemSubNameTextId = input.ReadInt32();
				break;
			case 72u:
				MagicValue = input.ReadInt32();
				break;
			case 80u:
				NotTrash = input.ReadInt32();
				break;
			case 88u:
				SortType = input.ReadInt32();
				break;
			case 96u:
				StackCount = input.ReadInt32();
				break;
			case 104u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
