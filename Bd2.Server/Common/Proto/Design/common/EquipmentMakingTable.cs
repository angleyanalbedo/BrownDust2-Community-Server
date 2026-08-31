using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EquipmentMakingTable : IMessage<EquipmentMakingTable>, IMessage, IEquatable<EquipmentMakingTable>, IDeepCloneable<EquipmentMakingTable>, IBufferMessage
{
	private static readonly MessageParser<EquipmentMakingTable> _parser = new MessageParser<EquipmentMakingTable>(() => new EquipmentMakingTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int ItemDesLocalTextIdFieldNumber = 2;

	private int itemDesLocalTextId_;

	public const int ItemNameLocalTextIdFieldNumber = 3;

	private int itemNameLocalTextId_;

	public const int MaterialItemCountFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_materialItemCount_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> materialItemCount_ = new RepeatedField<int>();

	public const int MaterialItemIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_materialItemId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> materialItemId_ = new RepeatedField<int>();

	public const int MaterialItemTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_materialItemType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> materialItemType_ = new RepeatedField<int>();

	public const int ResultItemCountFieldNumber = 7;

	private int resultItemCount_;

	public const int ResultItemIdFieldNumber = 8;

	private int resultItemId_;

	public const int ResultItemTypeFieldNumber = 9;

	private int resultItemType_;

	public const int SortOrderFieldNumber = 10;

	private int sortOrder_;

	public const int TalentLevelFieldNumber = 11;

	private int talentLevel_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EquipmentMakingTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipmentMakingTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int ItemDesLocalTextId
	{
		get
		{
			return itemDesLocalTextId_;
		}
		set
		{
			itemDesLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ItemNameLocalTextId
	{
		get
		{
			return itemNameLocalTextId_;
		}
		set
		{
			itemNameLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MaterialItemCount => materialItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MaterialItemId => materialItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MaterialItemType => materialItemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ResultItemType
	{
		get
		{
			return resultItemType_;
		}
		set
		{
			resultItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SortOrder
	{
		get
		{
			return sortOrder_;
		}
		set
		{
			sortOrder_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentMakingTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentMakingTable(EquipmentMakingTable other)
		: this()
	{
		id_ = other.id_;
		itemDesLocalTextId_ = other.itemDesLocalTextId_;
		itemNameLocalTextId_ = other.itemNameLocalTextId_;
		materialItemCount_ = other.materialItemCount_.Clone();
		materialItemId_ = other.materialItemId_.Clone();
		materialItemType_ = other.materialItemType_.Clone();
		resultItemCount_ = other.resultItemCount_;
		resultItemId_ = other.resultItemId_;
		resultItemType_ = other.resultItemType_;
		sortOrder_ = other.sortOrder_;
		talentLevel_ = other.talentLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentMakingTable Clone()
	{
		return new EquipmentMakingTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentMakingTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipmentMakingTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && ItemDesLocalTextId == other.ItemDesLocalTextId && ItemNameLocalTextId == other.ItemNameLocalTextId && materialItemCount_.Equals(other.materialItemCount_) && materialItemId_.Equals(other.materialItemId_) && materialItemType_.Equals(other.materialItemType_) && ResultItemCount == other.ResultItemCount && ResultItemId == other.ResultItemId && ResultItemType == other.ResultItemType && SortOrder == other.SortOrder && TalentLevel == other.TalentLevel)
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ItemDesLocalTextId != 0)
		{
			num ^= ItemDesLocalTextId.GetHashCode();
		}
		if (ItemNameLocalTextId != 0)
		{
			num ^= ItemNameLocalTextId.GetHashCode();
		}
		num ^= materialItemCount_.GetHashCode();
		num ^= materialItemId_.GetHashCode();
		num ^= materialItemType_.GetHashCode();
		if (ResultItemCount != 0)
		{
			num ^= ResultItemCount.GetHashCode();
		}
		if (ResultItemId != 0)
		{
			num ^= ResultItemId.GetHashCode();
		}
		if (ResultItemType != 0)
		{
			num ^= ResultItemType.GetHashCode();
		}
		if (SortOrder != 0)
		{
			num ^= SortOrder.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ItemDesLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemDesLocalTextId);
		}
		if (ItemNameLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ItemNameLocalTextId);
		}
		materialItemCount_.WriteTo(ref output, _repeated_materialItemCount_codec);
		materialItemId_.WriteTo(ref output, _repeated_materialItemId_codec);
		materialItemType_.WriteTo(ref output, _repeated_materialItemType_codec);
		if (ResultItemCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ResultItemCount);
		}
		if (ResultItemId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ResultItemId);
		}
		if (ResultItemType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ResultItemType);
		}
		if (SortOrder != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(SortOrder);
		}
		if (TalentLevel != 0)
		{
			output.WriteRawTag(88);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ItemDesLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemDesLocalTextId);
		}
		if (ItemNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemNameLocalTextId);
		}
		num += materialItemCount_.CalculateSize(_repeated_materialItemCount_codec);
		num += materialItemId_.CalculateSize(_repeated_materialItemId_codec);
		num += materialItemType_.CalculateSize(_repeated_materialItemType_codec);
		if (ResultItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResultItemCount);
		}
		if (ResultItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResultItemId);
		}
		if (ResultItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResultItemType);
		}
		if (SortOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortOrder);
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
	public void MergeFrom(EquipmentMakingTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemDesLocalTextId != 0)
			{
				ItemDesLocalTextId = other.ItemDesLocalTextId;
			}
			if (other.ItemNameLocalTextId != 0)
			{
				ItemNameLocalTextId = other.ItemNameLocalTextId;
			}
			materialItemCount_.Add(other.materialItemCount_);
			materialItemId_.Add(other.materialItemId_);
			materialItemType_.Add(other.materialItemType_);
			if (other.ResultItemCount != 0)
			{
				ResultItemCount = other.ResultItemCount;
			}
			if (other.ResultItemId != 0)
			{
				ResultItemId = other.ResultItemId;
			}
			if (other.ResultItemType != 0)
			{
				ResultItemType = other.ResultItemType;
			}
			if (other.SortOrder != 0)
			{
				SortOrder = other.SortOrder;
			}
			if (other.TalentLevel != 0)
			{
				TalentLevel = other.TalentLevel;
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
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
				ItemDesLocalTextId = input.ReadInt32();
				break;
			case 24u:
				ItemNameLocalTextId = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				materialItemCount_.AddEntriesFrom(ref input, _repeated_materialItemCount_codec);
				break;
			case 40u:
			case 42u:
				materialItemId_.AddEntriesFrom(ref input, _repeated_materialItemId_codec);
				break;
			case 48u:
			case 50u:
				materialItemType_.AddEntriesFrom(ref input, _repeated_materialItemType_codec);
				break;
			case 56u:
				ResultItemCount = input.ReadInt32();
				break;
			case 64u:
				ResultItemId = input.ReadInt32();
				break;
			case 72u:
				ResultItemType = input.ReadInt32();
				break;
			case 80u:
				SortOrder = input.ReadInt32();
				break;
			case 88u:
				TalentLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
