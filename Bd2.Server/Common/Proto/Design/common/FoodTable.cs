using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class FoodTable : IMessage<FoodTable>, IMessage, IEquatable<FoodTable>, IDeepCloneable<FoodTable>, IBufferMessage
{
	private static readonly MessageParser<FoodTable> _parser = new MessageParser<FoodTable>(() => new FoodTable());

	private UnknownFieldSet _unknownFields;

	public const int FavoriteRecoveryPointFieldNumber = 1;

	private int favoriteRecoveryPoint_;

	public const int FavoriteUniqueCharIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_favoriteUniqueCharId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> favoriteUniqueCharId_ = new RepeatedField<int>();

	public const int FoodBuffIdFieldNumber = 3;

	private int foodBuffId_;

	public const int FoodTypeFieldNumber = 4;

	private int foodType_;

	public const int GradeFieldNumber = 5;

	private int grade_;

	public const int IconSpriteNameFieldNumber = 6;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 7;

	private int id_;

	public const int ItemAcquireIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_itemAcquireId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> itemAcquireId_ = new RepeatedField<int>();

	public const int ItemDescNameTextIdFieldNumber = 9;

	private int itemDescNameTextId_;

	public const int ItemNameTextIdFieldNumber = 10;

	private int itemNameTextId_;

	public const int NotTrashFieldNumber = 11;

	private int notTrash_;

	public const int PackIdFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_packId_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> packId_ = new RepeatedField<int>();

	public const int RecoveryPointFieldNumber = 13;

	private int recoveryPoint_;

	public const int RecoveryTypeFieldNumber = 14;

	private int recoveryType_;

	public const int SortTypeFieldNumber = 15;

	private int sortType_;

	public const int StackCountFieldNumber = 16;

	private int stackCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FoodTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FoodTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FavoriteRecoveryPoint
	{
		get
		{
			return favoriteRecoveryPoint_;
		}
		set
		{
			favoriteRecoveryPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> FavoriteUniqueCharId => favoriteUniqueCharId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FoodBuffId
	{
		get
		{
			return foodBuffId_;
		}
		set
		{
			foodBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FoodType
	{
		get
		{
			return foodType_;
		}
		set
		{
			foodType_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PackId => packId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RecoveryPoint
	{
		get
		{
			return recoveryPoint_;
		}
		set
		{
			recoveryPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RecoveryType
	{
		get
		{
			return recoveryType_;
		}
		set
		{
			recoveryType_ = value;
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
	public FoodTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FoodTable(FoodTable other)
		: this()
	{
		favoriteRecoveryPoint_ = other.favoriteRecoveryPoint_;
		favoriteUniqueCharId_ = other.favoriteUniqueCharId_.Clone();
		foodBuffId_ = other.foodBuffId_;
		foodType_ = other.foodType_;
		grade_ = other.grade_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		itemAcquireId_ = other.itemAcquireId_.Clone();
		itemDescNameTextId_ = other.itemDescNameTextId_;
		itemNameTextId_ = other.itemNameTextId_;
		notTrash_ = other.notTrash_;
		packId_ = other.packId_.Clone();
		recoveryPoint_ = other.recoveryPoint_;
		recoveryType_ = other.recoveryType_;
		sortType_ = other.sortType_;
		stackCount_ = other.stackCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FoodTable Clone()
	{
		return new FoodTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FoodTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FoodTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (FavoriteRecoveryPoint == other.FavoriteRecoveryPoint && favoriteUniqueCharId_.Equals(other.favoriteUniqueCharId_) && FoodBuffId == other.FoodBuffId && FoodType == other.FoodType && Grade == other.Grade && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && itemAcquireId_.Equals(other.itemAcquireId_) && ItemDescNameTextId == other.ItemDescNameTextId && ItemNameTextId == other.ItemNameTextId && NotTrash == other.NotTrash && packId_.Equals(other.packId_) && RecoveryPoint == other.RecoveryPoint && RecoveryType == other.RecoveryType && SortType == other.SortType && StackCount == other.StackCount)
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
		if (FavoriteRecoveryPoint != 0)
		{
			num ^= FavoriteRecoveryPoint.GetHashCode();
		}
		num ^= favoriteUniqueCharId_.GetHashCode();
		if (FoodBuffId != 0)
		{
			num ^= FoodBuffId.GetHashCode();
		}
		if (FoodType != 0)
		{
			num ^= FoodType.GetHashCode();
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
		if (ItemDescNameTextId != 0)
		{
			num ^= ItemDescNameTextId.GetHashCode();
		}
		if (ItemNameTextId != 0)
		{
			num ^= ItemNameTextId.GetHashCode();
		}
		if (NotTrash != 0)
		{
			num ^= NotTrash.GetHashCode();
		}
		num ^= packId_.GetHashCode();
		if (RecoveryPoint != 0)
		{
			num ^= RecoveryPoint.GetHashCode();
		}
		if (RecoveryType != 0)
		{
			num ^= RecoveryType.GetHashCode();
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
		if (FavoriteRecoveryPoint != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FavoriteRecoveryPoint);
		}
		favoriteUniqueCharId_.WriteTo(ref output, _repeated_favoriteUniqueCharId_codec);
		if (FoodBuffId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(FoodBuffId);
		}
		if (FoodType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(FoodType);
		}
		if (Grade != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Grade);
		}
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		itemAcquireId_.WriteTo(ref output, _repeated_itemAcquireId_codec);
		if (ItemDescNameTextId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ItemDescNameTextId);
		}
		if (ItemNameTextId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ItemNameTextId);
		}
		if (NotTrash != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(NotTrash);
		}
		packId_.WriteTo(ref output, _repeated_packId_codec);
		if (RecoveryPoint != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(RecoveryPoint);
		}
		if (RecoveryType != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(RecoveryType);
		}
		if (SortType != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(SortType);
		}
		if (StackCount != 0)
		{
			output.WriteRawTag(128, 1);
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
		if (FavoriteRecoveryPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FavoriteRecoveryPoint);
		}
		num += favoriteUniqueCharId_.CalculateSize(_repeated_favoriteUniqueCharId_codec);
		if (FoodBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FoodBuffId);
		}
		if (FoodType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FoodType);
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
		if (ItemDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemDescNameTextId);
		}
		if (ItemNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemNameTextId);
		}
		if (NotTrash != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotTrash);
		}
		num += packId_.CalculateSize(_repeated_packId_codec);
		if (RecoveryPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecoveryPoint);
		}
		if (RecoveryType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecoveryType);
		}
		if (SortType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortType);
		}
		if (StackCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StackCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FoodTable other)
	{
		if (other != null)
		{
			if (other.FavoriteRecoveryPoint != 0)
			{
				FavoriteRecoveryPoint = other.FavoriteRecoveryPoint;
			}
			favoriteUniqueCharId_.Add(other.favoriteUniqueCharId_);
			if (other.FoodBuffId != 0)
			{
				FoodBuffId = other.FoodBuffId;
			}
			if (other.FoodType != 0)
			{
				FoodType = other.FoodType;
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
			if (other.ItemDescNameTextId != 0)
			{
				ItemDescNameTextId = other.ItemDescNameTextId;
			}
			if (other.ItemNameTextId != 0)
			{
				ItemNameTextId = other.ItemNameTextId;
			}
			if (other.NotTrash != 0)
			{
				NotTrash = other.NotTrash;
			}
			packId_.Add(other.packId_);
			if (other.RecoveryPoint != 0)
			{
				RecoveryPoint = other.RecoveryPoint;
			}
			if (other.RecoveryType != 0)
			{
				RecoveryType = other.RecoveryType;
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
			case 72u:
				ItemDescNameTextId = input.ReadInt32();
				break;
			case 80u:
				ItemNameTextId = input.ReadInt32();
				break;
			case 88u:
				NotTrash = input.ReadInt32();
				break;
			case 104u:
				RecoveryPoint = input.ReadInt32();
				break;
			case 112u:
				RecoveryType = input.ReadInt32();
				break;
			case 120u:
				SortType = input.ReadInt32();
				break;
			case 128u:
				StackCount = input.ReadInt32();
				break;
			case 96u:
			case 98u:
				packId_.AddEntriesFrom(ref input, _repeated_packId_codec);
				break;
			case 8u:
				FavoriteRecoveryPoint = input.ReadInt32();
				break;
			case 24u:
				FoodBuffId = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				favoriteUniqueCharId_.AddEntriesFrom(ref input, _repeated_favoriteUniqueCharId_codec);
				break;
			case 32u:
				FoodType = input.ReadInt32();
				break;
			case 40u:
				Grade = input.ReadInt32();
				break;
			case 50u:
				IconSpriteName = input.ReadString();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 64u:
			case 66u:
				itemAcquireId_.AddEntriesFrom(ref input, _repeated_itemAcquireId_codec);
				break;
			}
		}
	}
}
