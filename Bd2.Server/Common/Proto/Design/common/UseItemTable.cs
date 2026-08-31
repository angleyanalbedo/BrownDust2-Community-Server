using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class UseItemTable : IMessage<UseItemTable>, IMessage, IEquatable<UseItemTable>, IDeepCloneable<UseItemTable>, IBufferMessage
{
	private static readonly MessageParser<UseItemTable> _parser = new MessageParser<UseItemTable>(() => new UseItemTable());

	private UnknownFieldSet _unknownFields;

	public const int GradeFieldNumber = 1;

	private int grade_;

	public const int IconSpriteNameFieldNumber = 2;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ItemAcquireIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_itemAcquireId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> itemAcquireId_ = new RepeatedField<int>();

	public const int ItemDescNameTextIdFieldNumber = 5;

	private int itemDescNameTextId_;

	public const int ItemNameTextIdFieldNumber = 6;

	private int itemNameTextId_;

	public const int ItemSubNameTextIdFieldNumber = 7;

	private int itemSubNameTextId_;

	public const int NotTrashFieldNumber = 8;

	private int notTrash_;

	public const int SortTypeFieldNumber = 9;

	private int sortType_;

	public const int StackCountFieldNumber = 10;

	private int stackCount_;

	public const int UseItemTypeFieldNumber = 11;

	private int useItemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<UseItemTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => UseItemTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int UseItemType
	{
		get
		{
			return useItemType_;
		}
		set
		{
			useItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemTable(UseItemTable other)
		: this()
	{
		grade_ = other.grade_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		itemAcquireId_ = other.itemAcquireId_.Clone();
		itemDescNameTextId_ = other.itemDescNameTextId_;
		itemNameTextId_ = other.itemNameTextId_;
		itemSubNameTextId_ = other.itemSubNameTextId_;
		notTrash_ = other.notTrash_;
		sortType_ = other.sortType_;
		stackCount_ = other.stackCount_;
		useItemType_ = other.useItemType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemTable Clone()
	{
		return new UseItemTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UseItemTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UseItemTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Grade == other.Grade && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && itemAcquireId_.Equals(other.itemAcquireId_) && ItemDescNameTextId == other.ItemDescNameTextId && ItemNameTextId == other.ItemNameTextId && ItemSubNameTextId == other.ItemSubNameTextId && NotTrash == other.NotTrash && SortType == other.SortType && StackCount == other.StackCount && UseItemType == other.UseItemType)
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
		if (UseItemType != 0)
		{
			num ^= UseItemType.GetHashCode();
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
		if (Grade != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Grade);
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
		itemAcquireId_.WriteTo(ref output, _repeated_itemAcquireId_codec);
		if (ItemDescNameTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ItemDescNameTextId);
		}
		if (ItemNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ItemNameTextId);
		}
		if (ItemSubNameTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ItemSubNameTextId);
		}
		if (NotTrash != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(NotTrash);
		}
		if (SortType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(SortType);
		}
		if (StackCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(StackCount);
		}
		if (UseItemType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(UseItemType);
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
		if (Grade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Grade);
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
		if (UseItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseItemType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UseItemTable other)
	{
		if (other != null)
		{
			if (other.Grade != 0)
			{
				Grade = other.Grade;
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
			if (other.UseItemType != 0)
			{
				UseItemType = other.UseItemType;
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
				Grade = input.ReadInt32();
				break;
			case 18u:
				IconSpriteName = input.ReadString();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				itemAcquireId_.AddEntriesFrom(ref input, _repeated_itemAcquireId_codec);
				break;
			case 40u:
				ItemDescNameTextId = input.ReadInt32();
				break;
			case 48u:
				ItemNameTextId = input.ReadInt32();
				break;
			case 56u:
				ItemSubNameTextId = input.ReadInt32();
				break;
			case 64u:
				NotTrash = input.ReadInt32();
				break;
			case 72u:
				SortType = input.ReadInt32();
				break;
			case 80u:
				StackCount = input.ReadInt32();
				break;
			case 88u:
				UseItemType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
