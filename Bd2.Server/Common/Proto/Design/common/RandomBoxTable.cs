using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RandomBoxTable : IMessage<RandomBoxTable>, IMessage, IEquatable<RandomBoxTable>, IDeepCloneable<RandomBoxTable>, IBufferMessage
{
	private static readonly MessageParser<RandomBoxTable> _parser = new MessageParser<RandomBoxTable>(() => new RandomBoxTable());

	private UnknownFieldSet _unknownFields;

	public const int DropTypeFieldNumber = 1;

	private int dropType_;

	public const int GradeFieldNumber = 2;

	private int grade_;

	public const int IconSpriteNameFieldNumber = 3;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 4;

	private int id_;

	public const int ItemAcquireIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_itemAcquireId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> itemAcquireId_ = new RepeatedField<int>();

	public const int ItemDescRandomBoxTextIdFieldNumber = 6;

	private int itemDescRandomBoxTextId_;

	public const int ItemNameRandomBoxTextIdFieldNumber = 7;

	private int itemNameRandomBoxTextId_;

	public const int NotTrashFieldNumber = 8;

	private int notTrash_;

	public const int RewardGroupIdFieldNumber = 9;

	private int rewardGroupId_;

	public const int SortTypeFieldNumber = 10;

	private int sortType_;

	public const int StackCountFieldNumber = 11;

	private int stackCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RandomBoxTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => RandomBoxTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DropType
	{
		get
		{
			return dropType_;
		}
		set
		{
			dropType_ = value;
		}
	}

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
	public RepeatedField<int> ItemAcquireId => itemAcquireId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemDescRandomBoxTextId
	{
		get
		{
			return itemDescRandomBoxTextId_;
		}
		set
		{
			itemDescRandomBoxTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ItemNameRandomBoxTextId
	{
		get
		{
			return itemNameRandomBoxTextId_;
		}
		set
		{
			itemNameRandomBoxTextId_ = value;
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
	public int RewardGroupId
	{
		get
		{
			return rewardGroupId_;
		}
		set
		{
			rewardGroupId_ = value;
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
	public RandomBoxTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RandomBoxTable(RandomBoxTable other)
		: this()
	{
		dropType_ = other.dropType_;
		grade_ = other.grade_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		itemAcquireId_ = other.itemAcquireId_.Clone();
		itemDescRandomBoxTextId_ = other.itemDescRandomBoxTextId_;
		itemNameRandomBoxTextId_ = other.itemNameRandomBoxTextId_;
		notTrash_ = other.notTrash_;
		rewardGroupId_ = other.rewardGroupId_;
		sortType_ = other.sortType_;
		stackCount_ = other.stackCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RandomBoxTable Clone()
	{
		return new RandomBoxTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RandomBoxTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RandomBoxTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DropType == other.DropType && Grade == other.Grade && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && itemAcquireId_.Equals(other.itemAcquireId_) && ItemDescRandomBoxTextId == other.ItemDescRandomBoxTextId && ItemNameRandomBoxTextId == other.ItemNameRandomBoxTextId && NotTrash == other.NotTrash && RewardGroupId == other.RewardGroupId && SortType == other.SortType && StackCount == other.StackCount)
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
		if (DropType != 0)
		{
			num ^= DropType.GetHashCode();
		}
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
		if (ItemDescRandomBoxTextId != 0)
		{
			num ^= ItemDescRandomBoxTextId.GetHashCode();
		}
		if (ItemNameRandomBoxTextId != 0)
		{
			num ^= ItemNameRandomBoxTextId.GetHashCode();
		}
		if (NotTrash != 0)
		{
			num ^= NotTrash.GetHashCode();
		}
		if (RewardGroupId != 0)
		{
			num ^= RewardGroupId.GetHashCode();
		}
		if (SortType != 0)
		{
			num ^= SortType.GetHashCode();
		}
		if (StackCount != 0)
		{
			num ^= StackCount.GetHashCode();
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
		if (DropType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DropType);
		}
		if (Grade != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Grade);
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
		if (ItemDescRandomBoxTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ItemDescRandomBoxTextId);
		}
		if (ItemNameRandomBoxTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ItemNameRandomBoxTextId);
		}
		if (NotTrash != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(NotTrash);
		}
		if (RewardGroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(RewardGroupId);
		}
		if (SortType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(SortType);
		}
		if (StackCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(StackCount);
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
		if (DropType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropType);
		}
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
		if (ItemDescRandomBoxTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemDescRandomBoxTextId);
		}
		if (ItemNameRandomBoxTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemNameRandomBoxTextId);
		}
		if (NotTrash != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotTrash);
		}
		if (RewardGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardGroupId);
		}
		if (SortType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortType);
		}
		if (StackCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StackCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RandomBoxTable other)
	{
		if (other != null)
		{
			if (other.DropType != 0)
			{
				DropType = other.DropType;
			}
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
			if (other.ItemDescRandomBoxTextId != 0)
			{
				ItemDescRandomBoxTextId = other.ItemDescRandomBoxTextId;
			}
			if (other.ItemNameRandomBoxTextId != 0)
			{
				ItemNameRandomBoxTextId = other.ItemNameRandomBoxTextId;
			}
			if (other.NotTrash != 0)
			{
				NotTrash = other.NotTrash;
			}
			if (other.RewardGroupId != 0)
			{
				RewardGroupId = other.RewardGroupId;
			}
			if (other.SortType != 0)
			{
				SortType = other.SortType;
			}
			if (other.StackCount != 0)
			{
				StackCount = other.StackCount;
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
				DropType = input.ReadInt32();
				break;
			case 16u:
				Grade = input.ReadInt32();
				break;
			case 26u:
				IconSpriteName = input.ReadString();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				itemAcquireId_.AddEntriesFrom(ref input, _repeated_itemAcquireId_codec);
				break;
			case 48u:
				ItemDescRandomBoxTextId = input.ReadInt32();
				break;
			case 56u:
				ItemNameRandomBoxTextId = input.ReadInt32();
				break;
			case 64u:
				NotTrash = input.ReadInt32();
				break;
			case 72u:
				RewardGroupId = input.ReadInt32();
				break;
			case 80u:
				SortType = input.ReadInt32();
				break;
			case 88u:
				StackCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
