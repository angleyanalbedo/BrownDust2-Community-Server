using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EquipmentTable : IMessage<EquipmentTable>, IMessage, IEquatable<EquipmentTable>, IDeepCloneable<EquipmentTable>, IBufferMessage
{
	private static readonly MessageParser<EquipmentTable> _parser = new MessageParser<EquipmentTable>(() => new EquipmentTable());

	private UnknownFieldSet _unknownFields;

	public const int GradeFieldNumber = 1;

	private int grade_;

	public const int GrowthGroupIdFieldNumber = 2;

	private int growthGroupId_;

	public const int IconSpriteNameFieldNumber = 3;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 4;

	private int id_;

	public const int IsMonsterHuntFieldNumber = 5;

	private int isMonsterHunt_;

	public const int ItemAcquireIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_itemAcquireId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> itemAcquireId_ = new RepeatedField<int>();

	public const int ItemDescNameTextIdFieldNumber = 7;

	private int itemDescNameTextId_;

	public const int ItemNameTextIdFieldNumber = 8;

	private int itemNameTextId_;

	public const int ItemSubDescLocalTextIdFieldNumber = 9;

	private int itemSubDescLocalTextId_;

	public const int MainOptionGroupIdFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_mainOptionGroupId_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> mainOptionGroupId_ = new RepeatedField<int>();

	public const int MaxLevelFieldNumber = 11;

	private int maxLevel_;

	public const int NotTrashFieldNumber = 12;

	private int notTrash_;

	public const int OptionRerollIdFieldNumber = 13;

	private int optionRerollId_;

	public const int PrivateUniqueCharIdFieldNumber = 14;

	private int privateUniqueCharId_;

	public const int PrivateUniqueOptionGroupIdFieldNumber = 15;

	private static readonly FieldCodec<int> _repeated_privateUniqueOptionGroupId_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> privateUniqueOptionGroupId_ = new RepeatedField<int>();

	public const int QualityTypeFieldNumber = 16;

	private int qualityType_;

	public const int RankGroupIdFieldNumber = 17;

	private int rankGroupId_;

	public const int SlotTypeFieldNumber = 18;

	private int slotType_;

	public const int SubOptionGroupIdFieldNumber = 19;

	private static readonly FieldCodec<int> _repeated_subOptionGroupId_codec = FieldCodec.ForInt32(154u);

	private readonly RepeatedField<int> subOptionGroupId_ = new RepeatedField<int>();

	public const int UniqueEquipIdFieldNumber = 20;

	private int uniqueEquipId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EquipmentTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipmentTableReflection.Descriptor.MessageTypes[0];

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
	public int GrowthGroupId
	{
		get
		{
			return growthGroupId_;
		}
		set
		{
			growthGroupId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int IsMonsterHunt
	{
		get
		{
			return isMonsterHunt_;
		}
		set
		{
			isMonsterHunt_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemSubDescLocalTextId
	{
		get
		{
			return itemSubDescLocalTextId_;
		}
		set
		{
			itemSubDescLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainOptionGroupId => mainOptionGroupId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxLevel
	{
		get
		{
			return maxLevel_;
		}
		set
		{
			maxLevel_ = value;
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
	public int OptionRerollId
	{
		get
		{
			return optionRerollId_;
		}
		set
		{
			optionRerollId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PrivateUniqueCharId
	{
		get
		{
			return privateUniqueCharId_;
		}
		set
		{
			privateUniqueCharId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PrivateUniqueOptionGroupId => privateUniqueOptionGroupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QualityType
	{
		get
		{
			return qualityType_;
		}
		set
		{
			qualityType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RankGroupId
	{
		get
		{
			return rankGroupId_;
		}
		set
		{
			rankGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SlotType
	{
		get
		{
			return slotType_;
		}
		set
		{
			slotType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> SubOptionGroupId => subOptionGroupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueEquipId
	{
		get
		{
			return uniqueEquipId_;
		}
		set
		{
			uniqueEquipId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipmentTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipmentTable(EquipmentTable other)
		: this()
	{
		grade_ = other.grade_;
		growthGroupId_ = other.growthGroupId_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		isMonsterHunt_ = other.isMonsterHunt_;
		itemAcquireId_ = other.itemAcquireId_.Clone();
		itemDescNameTextId_ = other.itemDescNameTextId_;
		itemNameTextId_ = other.itemNameTextId_;
		itemSubDescLocalTextId_ = other.itemSubDescLocalTextId_;
		mainOptionGroupId_ = other.mainOptionGroupId_.Clone();
		maxLevel_ = other.maxLevel_;
		notTrash_ = other.notTrash_;
		optionRerollId_ = other.optionRerollId_;
		privateUniqueCharId_ = other.privateUniqueCharId_;
		privateUniqueOptionGroupId_ = other.privateUniqueOptionGroupId_.Clone();
		qualityType_ = other.qualityType_;
		rankGroupId_ = other.rankGroupId_;
		slotType_ = other.slotType_;
		subOptionGroupId_ = other.subOptionGroupId_.Clone();
		uniqueEquipId_ = other.uniqueEquipId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipmentTable Clone()
	{
		return new EquipmentTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipmentTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Grade == other.Grade && GrowthGroupId == other.GrowthGroupId && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && IsMonsterHunt == other.IsMonsterHunt && itemAcquireId_.Equals(other.itemAcquireId_) && ItemDescNameTextId == other.ItemDescNameTextId && ItemNameTextId == other.ItemNameTextId && ItemSubDescLocalTextId == other.ItemSubDescLocalTextId && mainOptionGroupId_.Equals(other.mainOptionGroupId_) && MaxLevel == other.MaxLevel && NotTrash == other.NotTrash && OptionRerollId == other.OptionRerollId && PrivateUniqueCharId == other.PrivateUniqueCharId && privateUniqueOptionGroupId_.Equals(other.privateUniqueOptionGroupId_) && QualityType == other.QualityType && RankGroupId == other.RankGroupId && SlotType == other.SlotType && subOptionGroupId_.Equals(other.subOptionGroupId_) && UniqueEquipId == other.UniqueEquipId)
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
		if (GrowthGroupId != 0)
		{
			num ^= GrowthGroupId.GetHashCode();
		}
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsMonsterHunt != 0)
		{
			num ^= IsMonsterHunt.GetHashCode();
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
		if (ItemSubDescLocalTextId != 0)
		{
			num ^= ItemSubDescLocalTextId.GetHashCode();
		}
		num ^= mainOptionGroupId_.GetHashCode();
		if (MaxLevel != 0)
		{
			num ^= MaxLevel.GetHashCode();
		}
		if (NotTrash != 0)
		{
			num ^= NotTrash.GetHashCode();
		}
		if (OptionRerollId != 0)
		{
			num ^= OptionRerollId.GetHashCode();
		}
		if (PrivateUniqueCharId != 0)
		{
			num ^= PrivateUniqueCharId.GetHashCode();
		}
		num ^= privateUniqueOptionGroupId_.GetHashCode();
		if (QualityType != 0)
		{
			num ^= QualityType.GetHashCode();
		}
		if (RankGroupId != 0)
		{
			num ^= RankGroupId.GetHashCode();
		}
		if (SlotType != 0)
		{
			num ^= SlotType.GetHashCode();
		}
		num ^= subOptionGroupId_.GetHashCode();
		if (UniqueEquipId != 0)
		{
			num ^= UniqueEquipId.GetHashCode();
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
		if (Grade != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Grade);
		}
		if (GrowthGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GrowthGroupId);
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
		if (IsMonsterHunt != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(IsMonsterHunt);
		}
		itemAcquireId_.WriteTo(ref output, _repeated_itemAcquireId_codec);
		if (ItemDescNameTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ItemDescNameTextId);
		}
		if (ItemNameTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ItemNameTextId);
		}
		if (ItemSubDescLocalTextId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ItemSubDescLocalTextId);
		}
		mainOptionGroupId_.WriteTo(ref output, _repeated_mainOptionGroupId_codec);
		if (MaxLevel != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(MaxLevel);
		}
		if (NotTrash != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(NotTrash);
		}
		if (OptionRerollId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(OptionRerollId);
		}
		if (PrivateUniqueCharId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(PrivateUniqueCharId);
		}
		privateUniqueOptionGroupId_.WriteTo(ref output, _repeated_privateUniqueOptionGroupId_codec);
		if (QualityType != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(QualityType);
		}
		if (RankGroupId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(RankGroupId);
		}
		if (SlotType != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(SlotType);
		}
		subOptionGroupId_.WriteTo(ref output, _repeated_subOptionGroupId_codec);
		if (UniqueEquipId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(UniqueEquipId);
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
		if (GrowthGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GrowthGroupId);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsMonsterHunt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsMonsterHunt);
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
		if (ItemSubDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemSubDescLocalTextId);
		}
		num += mainOptionGroupId_.CalculateSize(_repeated_mainOptionGroupId_codec);
		if (MaxLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxLevel);
		}
		if (NotTrash != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotTrash);
		}
		if (OptionRerollId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OptionRerollId);
		}
		if (PrivateUniqueCharId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PrivateUniqueCharId);
		}
		num += privateUniqueOptionGroupId_.CalculateSize(_repeated_privateUniqueOptionGroupId_codec);
		if (QualityType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QualityType);
		}
		if (RankGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RankGroupId);
		}
		if (SlotType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SlotType);
		}
		num += subOptionGroupId_.CalculateSize(_repeated_subOptionGroupId_codec);
		if (UniqueEquipId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UniqueEquipId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipmentTable other)
	{
		if (other != null)
		{
			if (other.Grade != 0)
			{
				Grade = other.Grade;
			}
			if (other.GrowthGroupId != 0)
			{
				GrowthGroupId = other.GrowthGroupId;
			}
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsMonsterHunt != 0)
			{
				IsMonsterHunt = other.IsMonsterHunt;
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
			if (other.ItemSubDescLocalTextId != 0)
			{
				ItemSubDescLocalTextId = other.ItemSubDescLocalTextId;
			}
			mainOptionGroupId_.Add(other.mainOptionGroupId_);
			if (other.MaxLevel != 0)
			{
				MaxLevel = other.MaxLevel;
			}
			if (other.NotTrash != 0)
			{
				NotTrash = other.NotTrash;
			}
			if (other.OptionRerollId != 0)
			{
				OptionRerollId = other.OptionRerollId;
			}
			if (other.PrivateUniqueCharId != 0)
			{
				PrivateUniqueCharId = other.PrivateUniqueCharId;
			}
			privateUniqueOptionGroupId_.Add(other.privateUniqueOptionGroupId_);
			if (other.QualityType != 0)
			{
				QualityType = other.QualityType;
			}
			if (other.RankGroupId != 0)
			{
				RankGroupId = other.RankGroupId;
			}
			if (other.SlotType != 0)
			{
				SlotType = other.SlotType;
			}
			subOptionGroupId_.Add(other.subOptionGroupId_);
			if (other.UniqueEquipId != 0)
			{
				UniqueEquipId = other.UniqueEquipId;
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
				Grade = input.ReadInt32();
				break;
			case 16u:
				GrowthGroupId = input.ReadInt32();
				break;
			case 26u:
				IconSpriteName = input.ReadString();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
				IsMonsterHunt = input.ReadInt32();
				break;
			case 56u:
				ItemDescNameTextId = input.ReadInt32();
				break;
			case 64u:
				ItemNameTextId = input.ReadInt32();
				break;
			case 72u:
				ItemSubDescLocalTextId = input.ReadInt32();
				break;
			case 80u:
			case 82u:
				mainOptionGroupId_.AddEntriesFrom(ref input, _repeated_mainOptionGroupId_codec);
				break;
			case 48u:
			case 50u:
				itemAcquireId_.AddEntriesFrom(ref input, _repeated_itemAcquireId_codec);
				break;
			case 88u:
				MaxLevel = input.ReadInt32();
				break;
			case 96u:
				NotTrash = input.ReadInt32();
				break;
			case 104u:
				OptionRerollId = input.ReadInt32();
				break;
			case 112u:
				PrivateUniqueCharId = input.ReadInt32();
				break;
			case 120u:
			case 122u:
				privateUniqueOptionGroupId_.AddEntriesFrom(ref input, _repeated_privateUniqueOptionGroupId_codec);
				break;
			case 128u:
				QualityType = input.ReadInt32();
				break;
			case 136u:
				RankGroupId = input.ReadInt32();
				break;
			case 144u:
				SlotType = input.ReadInt32();
				break;
			case 152u:
			case 154u:
				subOptionGroupId_.AddEntriesFrom(ref input, _repeated_subOptionGroupId_codec);
				break;
			case 160u:
				UniqueEquipId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
