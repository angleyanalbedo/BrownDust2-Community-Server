using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MyRoomItemTable : IMessage<MyRoomItemTable>, IMessage, IEquatable<MyRoomItemTable>, IDeepCloneable<MyRoomItemTable>, IBufferMessage
{
	private static readonly MessageParser<MyRoomItemTable> _parser = new MessageParser<MyRoomItemTable>(() => new MyRoomItemTable());

	private UnknownFieldSet _unknownFields;

	public const int CanRotateFieldNumber = 1;

	private int canRotate_;

	public const int CharInteractFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_charInteract_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> charInteract_ = new RepeatedField<int>();

	public const int DodgePrefabNameFieldNumber = 3;

	private string dodgePrefabName_ = "";

	public const int EnumCountIdFieldNumber = 4;

	private int enumCountId_;

	public const int FilterIdFieldNumber = 5;

	private int filterId_;

	public const int FilterNameTextIdFieldNumber = 6;

	private int filterNameTextId_;

	public const int IdFieldNumber = 7;

	private int id_;

	public const int ItemAcquireIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_itemAcquireId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> itemAcquireId_ = new RepeatedField<int>();

	public const int ItemAnimationFieldNumber = 9;

	private int itemAnimation_;

	public const int ItemInteractFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_itemInteract_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> itemInteract_ = new RepeatedField<int>();

	public const int ItemSpriteNameFieldNumber = 11;

	private string itemSpriteName_ = "";

	public const int ItemUnlockLocalTextIdFieldNumber = 12;

	private int itemUnlockLocalTextId_;

	public const int LocationFieldNumber = 13;

	private int location_;

	public const int MaxCountFieldNumber = 14;

	private int maxCount_;

	public const int ObjectDescNameTextIdFieldNumber = 15;

	private int objectDescNameTextId_;

	public const int ObjectNameTextIdFieldNumber = 16;

	private int objectNameTextId_;

	public const int ObjectTypeFieldNumber = 17;

	private int objectType_;

	public const int PackIdFieldNumber = 18;

	private int packId_;

	public const int PrefabNameFieldNumber = 19;

	private string prefabName_ = "";

	public const int QuestLevelFieldNumber = 20;

	private int questLevel_;

	public const int RoomItemTypeFieldNumber = 21;

	private int roomItemType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomItemTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MyRoomItemTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CanRotate
	{
		get
		{
			return canRotate_;
		}
		set
		{
			canRotate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CharInteract => charInteract_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string DodgePrefabName
	{
		get
		{
			return dodgePrefabName_;
		}
		set
		{
			dodgePrefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EnumCountId
	{
		get
		{
			return enumCountId_;
		}
		set
		{
			enumCountId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FilterId
	{
		get
		{
			return filterId_;
		}
		set
		{
			filterId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FilterNameTextId
	{
		get
		{
			return filterNameTextId_;
		}
		set
		{
			filterNameTextId_ = value;
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
	public RepeatedField<int> ItemAcquireId => itemAcquireId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemAnimation
	{
		get
		{
			return itemAnimation_;
		}
		set
		{
			itemAnimation_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ItemInteract => itemInteract_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int ItemUnlockLocalTextId
	{
		get
		{
			return itemUnlockLocalTextId_;
		}
		set
		{
			itemUnlockLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Location
	{
		get
		{
			return location_;
		}
		set
		{
			location_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxCount
	{
		get
		{
			return maxCount_;
		}
		set
		{
			maxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectDescNameTextId
	{
		get
		{
			return objectDescNameTextId_;
		}
		set
		{
			objectDescNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectNameTextId
	{
		get
		{
			return objectNameTextId_;
		}
		set
		{
			objectNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectType
	{
		get
		{
			return objectType_;
		}
		set
		{
			objectType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public string PrefabName
	{
		get
		{
			return prefabName_;
		}
		set
		{
			prefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestLevel
	{
		get
		{
			return questLevel_;
		}
		set
		{
			questLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RoomItemType
	{
		get
		{
			return roomItemType_;
		}
		set
		{
			roomItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemTable(MyRoomItemTable other)
		: this()
	{
		canRotate_ = other.canRotate_;
		charInteract_ = other.charInteract_.Clone();
		dodgePrefabName_ = other.dodgePrefabName_;
		enumCountId_ = other.enumCountId_;
		filterId_ = other.filterId_;
		filterNameTextId_ = other.filterNameTextId_;
		id_ = other.id_;
		itemAcquireId_ = other.itemAcquireId_.Clone();
		itemAnimation_ = other.itemAnimation_;
		itemInteract_ = other.itemInteract_.Clone();
		itemSpriteName_ = other.itemSpriteName_;
		itemUnlockLocalTextId_ = other.itemUnlockLocalTextId_;
		location_ = other.location_;
		maxCount_ = other.maxCount_;
		objectDescNameTextId_ = other.objectDescNameTextId_;
		objectNameTextId_ = other.objectNameTextId_;
		objectType_ = other.objectType_;
		packId_ = other.packId_;
		prefabName_ = other.prefabName_;
		questLevel_ = other.questLevel_;
		roomItemType_ = other.roomItemType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemTable Clone()
	{
		return new MyRoomItemTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomItemTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MyRoomItemTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CanRotate == other.CanRotate && charInteract_.Equals(other.charInteract_) && !(DodgePrefabName != other.DodgePrefabName) && EnumCountId == other.EnumCountId && FilterId == other.FilterId && FilterNameTextId == other.FilterNameTextId && Id == other.Id && itemAcquireId_.Equals(other.itemAcquireId_) && ItemAnimation == other.ItemAnimation && itemInteract_.Equals(other.itemInteract_) && !(ItemSpriteName != other.ItemSpriteName) && ItemUnlockLocalTextId == other.ItemUnlockLocalTextId && Location == other.Location && MaxCount == other.MaxCount && ObjectDescNameTextId == other.ObjectDescNameTextId && ObjectNameTextId == other.ObjectNameTextId && ObjectType == other.ObjectType && PackId == other.PackId && !(PrefabName != other.PrefabName) && QuestLevel == other.QuestLevel && RoomItemType == other.RoomItemType)
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
		if (CanRotate != 0)
		{
			num ^= CanRotate.GetHashCode();
		}
		num ^= charInteract_.GetHashCode();
		if (DodgePrefabName.Length != 0)
		{
			num ^= DodgePrefabName.GetHashCode();
		}
		if (EnumCountId != 0)
		{
			num ^= EnumCountId.GetHashCode();
		}
		if (FilterId != 0)
		{
			num ^= FilterId.GetHashCode();
		}
		if (FilterNameTextId != 0)
		{
			num ^= FilterNameTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= itemAcquireId_.GetHashCode();
		if (ItemAnimation != 0)
		{
			num ^= ItemAnimation.GetHashCode();
		}
		num ^= itemInteract_.GetHashCode();
		if (ItemSpriteName.Length != 0)
		{
			num ^= ItemSpriteName.GetHashCode();
		}
		if (ItemUnlockLocalTextId != 0)
		{
			num ^= ItemUnlockLocalTextId.GetHashCode();
		}
		if (Location != 0)
		{
			num ^= Location.GetHashCode();
		}
		if (MaxCount != 0)
		{
			num ^= MaxCount.GetHashCode();
		}
		if (ObjectDescNameTextId != 0)
		{
			num ^= ObjectDescNameTextId.GetHashCode();
		}
		if (ObjectNameTextId != 0)
		{
			num ^= ObjectNameTextId.GetHashCode();
		}
		if (ObjectType != 0)
		{
			num ^= ObjectType.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (PrefabName.Length != 0)
		{
			num ^= PrefabName.GetHashCode();
		}
		if (QuestLevel != 0)
		{
			num ^= QuestLevel.GetHashCode();
		}
		if (RoomItemType != 0)
		{
			num ^= RoomItemType.GetHashCode();
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
		if (CanRotate != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CanRotate);
		}
		charInteract_.WriteTo(ref output, _repeated_charInteract_codec);
		if (DodgePrefabName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DodgePrefabName);
		}
		if (EnumCountId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EnumCountId);
		}
		if (FilterId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(FilterId);
		}
		if (FilterNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(FilterNameTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		itemAcquireId_.WriteTo(ref output, _repeated_itemAcquireId_codec);
		if (ItemAnimation != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ItemAnimation);
		}
		itemInteract_.WriteTo(ref output, _repeated_itemInteract_codec);
		if (ItemSpriteName.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(ItemSpriteName);
		}
		if (ItemUnlockLocalTextId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(ItemUnlockLocalTextId);
		}
		if (Location != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(Location);
		}
		if (MaxCount != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(MaxCount);
		}
		if (ObjectDescNameTextId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ObjectDescNameTextId);
		}
		if (ObjectNameTextId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(ObjectNameTextId);
		}
		if (ObjectType != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(ObjectType);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(PackId);
		}
		if (PrefabName.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(PrefabName);
		}
		if (QuestLevel != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(QuestLevel);
		}
		if (RoomItemType != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(RoomItemType);
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
		if (CanRotate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CanRotate);
		}
		num += charInteract_.CalculateSize(_repeated_charInteract_codec);
		if (DodgePrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DodgePrefabName);
		}
		if (EnumCountId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EnumCountId);
		}
		if (FilterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FilterId);
		}
		if (FilterNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FilterNameTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += itemAcquireId_.CalculateSize(_repeated_itemAcquireId_codec);
		if (ItemAnimation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemAnimation);
		}
		num += itemInteract_.CalculateSize(_repeated_itemInteract_codec);
		if (ItemSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ItemSpriteName);
		}
		if (ItemUnlockLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemUnlockLocalTextId);
		}
		if (Location != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Location);
		}
		if (MaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxCount);
		}
		if (ObjectDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObjectDescNameTextId);
		}
		if (ObjectNameTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ObjectNameTextId);
		}
		if (ObjectType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ObjectType);
		}
		if (PackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (PrefabName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PrefabName);
		}
		if (QuestLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QuestLevel);
		}
		if (RoomItemType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RoomItemType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MyRoomItemTable other)
	{
		if (other != null)
		{
			if (other.CanRotate != 0)
			{
				CanRotate = other.CanRotate;
			}
			charInteract_.Add(other.charInteract_);
			if (other.DodgePrefabName.Length != 0)
			{
				DodgePrefabName = other.DodgePrefabName;
			}
			if (other.EnumCountId != 0)
			{
				EnumCountId = other.EnumCountId;
			}
			if (other.FilterId != 0)
			{
				FilterId = other.FilterId;
			}
			if (other.FilterNameTextId != 0)
			{
				FilterNameTextId = other.FilterNameTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			itemAcquireId_.Add(other.itemAcquireId_);
			if (other.ItemAnimation != 0)
			{
				ItemAnimation = other.ItemAnimation;
			}
			itemInteract_.Add(other.itemInteract_);
			if (other.ItemSpriteName.Length != 0)
			{
				ItemSpriteName = other.ItemSpriteName;
			}
			if (other.ItemUnlockLocalTextId != 0)
			{
				ItemUnlockLocalTextId = other.ItemUnlockLocalTextId;
			}
			if (other.Location != 0)
			{
				Location = other.Location;
			}
			if (other.MaxCount != 0)
			{
				MaxCount = other.MaxCount;
			}
			if (other.ObjectDescNameTextId != 0)
			{
				ObjectDescNameTextId = other.ObjectDescNameTextId;
			}
			if (other.ObjectNameTextId != 0)
			{
				ObjectNameTextId = other.ObjectNameTextId;
			}
			if (other.ObjectType != 0)
			{
				ObjectType = other.ObjectType;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.PrefabName.Length != 0)
			{
				PrefabName = other.PrefabName;
			}
			if (other.QuestLevel != 0)
			{
				QuestLevel = other.QuestLevel;
			}
			if (other.RoomItemType != 0)
			{
				RoomItemType = other.RoomItemType;
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
			case 48u:
				FilterNameTextId = input.ReadInt32();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 72u:
				ItemAnimation = input.ReadInt32();
				break;
			case 64u:
			case 66u:
				itemAcquireId_.AddEntriesFrom(ref input, _repeated_itemAcquireId_codec);
				break;
			case 8u:
				CanRotate = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				charInteract_.AddEntriesFrom(ref input, _repeated_charInteract_codec);
				break;
			case 26u:
				DodgePrefabName = input.ReadString();
				break;
			case 32u:
				EnumCountId = input.ReadInt32();
				break;
			case 40u:
				FilterId = input.ReadInt32();
				break;
			case 90u:
				ItemSpriteName = input.ReadString();
				break;
			case 96u:
				ItemUnlockLocalTextId = input.ReadInt32();
				break;
			case 104u:
				Location = input.ReadInt32();
				break;
			case 112u:
				MaxCount = input.ReadInt32();
				break;
			case 120u:
				ObjectDescNameTextId = input.ReadInt32();
				break;
			case 128u:
				ObjectNameTextId = input.ReadInt32();
				break;
			case 136u:
				ObjectType = input.ReadInt32();
				break;
			case 144u:
				PackId = input.ReadInt32();
				break;
			case 154u:
				PrefabName = input.ReadString();
				break;
			case 160u:
				QuestLevel = input.ReadInt32();
				break;
			case 168u:
				RoomItemType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 80u:
			case 82u:
				itemInteract_.AddEntriesFrom(ref input, _repeated_itemInteract_codec);
				break;
			}
		}
	}
}
