using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class AlchemyTable : IMessage<AlchemyTable>, IMessage, IEquatable<AlchemyTable>, IDeepCloneable<AlchemyTable>, IBufferMessage
{
	private static readonly MessageParser<AlchemyTable> _parser = new MessageParser<AlchemyTable>(() => new AlchemyTable());

	private UnknownFieldSet _unknownFields;

	public const int AlchemyCategoryFieldNumber = 1;

	private int alchemyCategory_;

	public const int DisplayGroupIdFieldNumber = 2;

	private int displayGroupId_;

	public const int GroupLocalTextIdFieldNumber = 3;

	private int groupLocalTextId_;

	public const int IdFieldNumber = 4;

	private int id_;

	public const int MaterialItemCountFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_materialItemCount_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> materialItemCount_ = new RepeatedField<int>();

	public const int MaterialItemIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_materialItemId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> materialItemId_ = new RepeatedField<int>();

	public const int MaterialItemTypeFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_materialItemType_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> materialItemType_ = new RepeatedField<int>();

	public const int PackIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_packId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> packId_ = new RepeatedField<int>();

	public const int ResultItemCountFieldNumber = 9;

	private int resultItemCount_;

	public const int ResultItemIdFieldNumber = 10;

	private int resultItemId_;

	public const int ResultItemTypeFieldNumber = 11;

	private int resultItemType_;

	public const int TalentLevelFieldNumber = 12;

	private int talentLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlchemyTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => AlchemyTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AlchemyCategory
	{
		get
		{
			return alchemyCategory_;
		}
		set
		{
			alchemyCategory_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DisplayGroupId
	{
		get
		{
			return displayGroupId_;
		}
		set
		{
			displayGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GroupLocalTextId
	{
		get
		{
			return groupLocalTextId_;
		}
		set
		{
			groupLocalTextId_ = value;
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
	public RepeatedField<int> MaterialItemCount => materialItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MaterialItemId => materialItemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MaterialItemType => materialItemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PackId => packId_;

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
	public AlchemyTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlchemyTable(AlchemyTable other)
		: this()
	{
		alchemyCategory_ = other.alchemyCategory_;
		displayGroupId_ = other.displayGroupId_;
		groupLocalTextId_ = other.groupLocalTextId_;
		id_ = other.id_;
		materialItemCount_ = other.materialItemCount_.Clone();
		materialItemId_ = other.materialItemId_.Clone();
		materialItemType_ = other.materialItemType_.Clone();
		packId_ = other.packId_.Clone();
		resultItemCount_ = other.resultItemCount_;
		resultItemId_ = other.resultItemId_;
		resultItemType_ = other.resultItemType_;
		talentLevel_ = other.talentLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AlchemyTable Clone()
	{
		return new AlchemyTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as AlchemyTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AlchemyTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AlchemyCategory == other.AlchemyCategory && DisplayGroupId == other.DisplayGroupId && GroupLocalTextId == other.GroupLocalTextId && Id == other.Id && materialItemCount_.Equals(other.materialItemCount_) && materialItemId_.Equals(other.materialItemId_) && materialItemType_.Equals(other.materialItemType_) && packId_.Equals(other.packId_) && ResultItemCount == other.ResultItemCount && ResultItemId == other.ResultItemId && ResultItemType == other.ResultItemType && TalentLevel == other.TalentLevel)
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
		if (AlchemyCategory != 0)
		{
			num ^= AlchemyCategory.GetHashCode();
		}
		if (DisplayGroupId != 0)
		{
			num ^= DisplayGroupId.GetHashCode();
		}
		if (GroupLocalTextId != 0)
		{
			num ^= GroupLocalTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= materialItemCount_.GetHashCode();
		num ^= materialItemId_.GetHashCode();
		num ^= materialItemType_.GetHashCode();
		num ^= packId_.GetHashCode();
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
		if (AlchemyCategory != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AlchemyCategory);
		}
		if (DisplayGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DisplayGroupId);
		}
		if (GroupLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupLocalTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		materialItemCount_.WriteTo(ref output, _repeated_materialItemCount_codec);
		materialItemId_.WriteTo(ref output, _repeated_materialItemId_codec);
		materialItemType_.WriteTo(ref output, _repeated_materialItemType_codec);
		packId_.WriteTo(ref output, _repeated_packId_codec);
		if (ResultItemCount != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ResultItemCount);
		}
		if (ResultItemId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ResultItemId);
		}
		if (ResultItemType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ResultItemType);
		}
		if (TalentLevel != 0)
		{
			output.WriteRawTag(96);
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
		if (AlchemyCategory != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AlchemyCategory);
		}
		if (DisplayGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DisplayGroupId);
		}
		if (GroupLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupLocalTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += materialItemCount_.CalculateSize(_repeated_materialItemCount_codec);
		num += materialItemId_.CalculateSize(_repeated_materialItemId_codec);
		num += materialItemType_.CalculateSize(_repeated_materialItemType_codec);
		num += packId_.CalculateSize(_repeated_packId_codec);
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
	public void MergeFrom(AlchemyTable other)
	{
		if (other != null)
		{
			if (other.AlchemyCategory != 0)
			{
				AlchemyCategory = other.AlchemyCategory;
			}
			if (other.DisplayGroupId != 0)
			{
				DisplayGroupId = other.DisplayGroupId;
			}
			if (other.GroupLocalTextId != 0)
			{
				GroupLocalTextId = other.GroupLocalTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			materialItemCount_.Add(other.materialItemCount_);
			materialItemId_.Add(other.materialItemId_);
			materialItemType_.Add(other.materialItemType_);
			packId_.Add(other.packId_);
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
				AlchemyCategory = input.ReadInt32();
				break;
			case 16u:
				DisplayGroupId = input.ReadInt32();
				break;
			case 24u:
				GroupLocalTextId = input.ReadInt32();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				materialItemCount_.AddEntriesFrom(ref input, _repeated_materialItemCount_codec);
				break;
			case 48u:
			case 50u:
				materialItemId_.AddEntriesFrom(ref input, _repeated_materialItemId_codec);
				break;
			case 56u:
			case 58u:
				materialItemType_.AddEntriesFrom(ref input, _repeated_materialItemType_codec);
				break;
			case 64u:
			case 66u:
				packId_.AddEntriesFrom(ref input, _repeated_packId_codec);
				break;
			case 72u:
				ResultItemCount = input.ReadInt32();
				break;
			case 80u:
				ResultItemId = input.ReadInt32();
				break;
			case 88u:
				ResultItemType = input.ReadInt32();
				break;
			case 96u:
				TalentLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
