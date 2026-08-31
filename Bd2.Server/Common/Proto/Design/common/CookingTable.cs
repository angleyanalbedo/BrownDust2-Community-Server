using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CookingTable : IMessage<CookingTable>, IMessage, IEquatable<CookingTable>, IDeepCloneable<CookingTable>, IBufferMessage
{
	private static readonly MessageParser<CookingTable> _parser = new MessageParser<CookingTable>(() => new CookingTable());

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

	public const int ItemSubNameTextIdFieldNumber = 6;

	private int itemSubNameTextId_;

	public const int MaterialItemCountFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_materialItemCount_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> materialItemCount_ = new RepeatedField<int>();

	public const int MaterialItemIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_materialItemId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> materialItemId_ = new RepeatedField<int>();

	public const int NotTrashFieldNumber = 9;

	private int notTrash_;

	public const int PackIdFieldNumber = 10;

	private int packId_;

	public const int RecipeNameTextIdFieldNumber = 11;

	private int recipeNameTextId_;

	public const int ResultItemCountFieldNumber = 12;

	private int resultItemCount_;

	public const int ResultItemIdFieldNumber = 13;

	private int resultItemId_;

	public const int StackCountFieldNumber = 14;

	private int stackCount_;

	public const int TalentLevelFieldNumber = 15;

	private int talentLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CookingTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CookingTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public RepeatedField<int> MaterialItemCount => materialItemCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MaterialItemId => materialItemId_;

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
	public int RecipeNameTextId
	{
		get
		{
			return recipeNameTextId_;
		}
		set
		{
			recipeNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResultItemCount
	{
		get
		{
			return resultItemCount_;
		}
		set
		{
			resultItemCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ResultItemId
	{
		get
		{
			return resultItemId_;
		}
		set
		{
			resultItemId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TalentLevel
	{
		get
		{
			return talentLevel_;
		}
		set
		{
			talentLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CookingTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingTable(CookingTable other)
		: this()
	{
		grade_ = other.grade_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		itemAcquireId_ = other.itemAcquireId_.Clone();
		itemDescNameTextId_ = other.itemDescNameTextId_;
		itemSubNameTextId_ = other.itemSubNameTextId_;
		materialItemCount_ = other.materialItemCount_.Clone();
		materialItemId_ = other.materialItemId_.Clone();
		notTrash_ = other.notTrash_;
		packId_ = other.packId_;
		recipeNameTextId_ = other.recipeNameTextId_;
		resultItemCount_ = other.resultItemCount_;
		resultItemId_ = other.resultItemId_;
		stackCount_ = other.stackCount_;
		talentLevel_ = other.talentLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingTable Clone()
	{
		return new CookingTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CookingTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CookingTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Grade == other.Grade && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && itemAcquireId_.Equals(other.itemAcquireId_) && ItemDescNameTextId == other.ItemDescNameTextId && ItemSubNameTextId == other.ItemSubNameTextId && materialItemCount_.Equals(other.materialItemCount_) && materialItemId_.Equals(other.materialItemId_) && NotTrash == other.NotTrash && PackId == other.PackId && RecipeNameTextId == other.RecipeNameTextId && ResultItemCount == other.ResultItemCount && ResultItemId == other.ResultItemId && StackCount == other.StackCount && TalentLevel == other.TalentLevel)
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
		if (ItemSubNameTextId != 0)
		{
			num ^= ItemSubNameTextId.GetHashCode();
		}
		num ^= materialItemCount_.GetHashCode();
		num ^= materialItemId_.GetHashCode();
		if (NotTrash != 0)
		{
			num ^= NotTrash.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (RecipeNameTextId != 0)
		{
			num ^= RecipeNameTextId.GetHashCode();
		}
		if (ResultItemCount != 0)
		{
			num ^= ResultItemCount.GetHashCode();
		}
		if (ResultItemId != 0)
		{
			num ^= ResultItemId.GetHashCode();
		}
		if (StackCount != 0)
		{
			num ^= StackCount.GetHashCode();
		}
		if (TalentLevel != 0)
		{
			num ^= TalentLevel.GetHashCode();
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
		if (ItemSubNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ItemSubNameTextId);
		}
		materialItemCount_.WriteTo(ref output, _repeated_materialItemCount_codec);
		materialItemId_.WriteTo(ref output, _repeated_materialItemId_codec);
		if (NotTrash != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(NotTrash);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PackId);
		}
		if (RecipeNameTextId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(RecipeNameTextId);
		}
		if (ResultItemCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(ResultItemCount);
		}
		if (ResultItemId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(ResultItemId);
		}
		if (StackCount != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(StackCount);
		}
		if (TalentLevel != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(TalentLevel);
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
		if (ItemSubNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemSubNameTextId);
		}
		num += materialItemCount_.CalculateSize(_repeated_materialItemCount_codec);
		num += materialItemId_.CalculateSize(_repeated_materialItemId_codec);
		if (NotTrash != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotTrash);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (RecipeNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecipeNameTextId);
		}
		if (ResultItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResultItemCount);
		}
		if (ResultItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResultItemId);
		}
		if (StackCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StackCount);
		}
		if (TalentLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CookingTable other)
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
			if (other.ItemSubNameTextId != 0)
			{
				ItemSubNameTextId = other.ItemSubNameTextId;
			}
			materialItemCount_.Add(other.materialItemCount_);
			materialItemId_.Add(other.materialItemId_);
			if (other.NotTrash != 0)
			{
				NotTrash = other.NotTrash;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.RecipeNameTextId != 0)
			{
				RecipeNameTextId = other.RecipeNameTextId;
			}
			if (other.ResultItemCount != 0)
			{
				ResultItemCount = other.ResultItemCount;
			}
			if (other.ResultItemId != 0)
			{
				ResultItemId = other.ResultItemId;
			}
			if (other.StackCount != 0)
			{
				StackCount = other.StackCount;
			}
			if (other.TalentLevel != 0)
			{
				TalentLevel = other.TalentLevel;
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
				Grade = input.ReadInt32();
				break;
			case 18u:
				IconSpriteName = input.ReadString();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 40u:
				ItemDescNameTextId = input.ReadInt32();
				break;
			case 48u:
				ItemSubNameTextId = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				materialItemCount_.AddEntriesFrom(ref input, _repeated_materialItemCount_codec);
				break;
			case 32u:
			case 34u:
				itemAcquireId_.AddEntriesFrom(ref input, _repeated_itemAcquireId_codec);
				break;
			case 64u:
			case 66u:
				materialItemId_.AddEntriesFrom(ref input, _repeated_materialItemId_codec);
				break;
			case 72u:
				NotTrash = input.ReadInt32();
				break;
			case 80u:
				PackId = input.ReadInt32();
				break;
			case 88u:
				RecipeNameTextId = input.ReadInt32();
				break;
			case 96u:
				ResultItemCount = input.ReadInt32();
				break;
			case 104u:
				ResultItemId = input.ReadInt32();
				break;
			case 112u:
				StackCount = input.ReadInt32();
				break;
			case 120u:
				TalentLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
