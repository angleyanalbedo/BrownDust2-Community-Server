using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EquipmentGradeTable : IMessage<EquipmentGradeTable>, IMessage, IEquatable<EquipmentGradeTable>, IDeepCloneable<EquipmentGradeTable>, IBufferMessage
{
	private static readonly MessageParser<EquipmentGradeTable> _parser = new MessageParser<EquipmentGradeTable>(() => new EquipmentGradeTable());

	private UnknownFieldSet _unknownFields;

	public const int EquipGradeLocalTextIdFieldNumber = 1;

	private int equipGradeLocalTextId_;

	public const int IconSpriteNameFieldNumber = 2;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 3;

	private int id_;

	public const int RankSmeltItemCountFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_rankSmeltItemCount_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> rankSmeltItemCount_ = new RepeatedField<int>();

	public const int RankSmeltItemIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_rankSmeltItemId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> rankSmeltItemId_ = new RepeatedField<int>();

	public const int RankSmeltItemTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_rankSmeltItemType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> rankSmeltItemType_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EquipmentGradeTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipmentGradeTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EquipGradeLocalTextId
	{
		get
		{
			return equipGradeLocalTextId_;
		}
		set
		{
			equipGradeLocalTextId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RankSmeltItemCount => rankSmeltItemCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RankSmeltItemId => rankSmeltItemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RankSmeltItemType => rankSmeltItemType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentGradeTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipmentGradeTable(EquipmentGradeTable other)
		: this()
	{
		equipGradeLocalTextId_ = other.equipGradeLocalTextId_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		rankSmeltItemCount_ = other.rankSmeltItemCount_.Clone();
		rankSmeltItemId_ = other.rankSmeltItemId_.Clone();
		rankSmeltItemType_ = other.rankSmeltItemType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipmentGradeTable Clone()
	{
		return new EquipmentGradeTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentGradeTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipmentGradeTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EquipGradeLocalTextId == other.EquipGradeLocalTextId && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && rankSmeltItemCount_.Equals(other.rankSmeltItemCount_) && rankSmeltItemId_.Equals(other.rankSmeltItemId_) && rankSmeltItemType_.Equals(other.rankSmeltItemType_))
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
		if (EquipGradeLocalTextId != 0)
		{
			num ^= EquipGradeLocalTextId.GetHashCode();
		}
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= rankSmeltItemCount_.GetHashCode();
		num ^= rankSmeltItemId_.GetHashCode();
		num ^= rankSmeltItemType_.GetHashCode();
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
		if (EquipGradeLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EquipGradeLocalTextId);
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
		rankSmeltItemCount_.WriteTo(ref output, _repeated_rankSmeltItemCount_codec);
		rankSmeltItemId_.WriteTo(ref output, _repeated_rankSmeltItemId_codec);
		rankSmeltItemType_.WriteTo(ref output, _repeated_rankSmeltItemType_codec);
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
		if (EquipGradeLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipGradeLocalTextId);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += rankSmeltItemCount_.CalculateSize(_repeated_rankSmeltItemCount_codec);
		num += rankSmeltItemId_.CalculateSize(_repeated_rankSmeltItemId_codec);
		num += rankSmeltItemType_.CalculateSize(_repeated_rankSmeltItemType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipmentGradeTable other)
	{
		if (other != null)
		{
			if (other.EquipGradeLocalTextId != 0)
			{
				EquipGradeLocalTextId = other.EquipGradeLocalTextId;
			}
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			rankSmeltItemCount_.Add(other.rankSmeltItemCount_);
			rankSmeltItemId_.Add(other.rankSmeltItemId_);
			rankSmeltItemType_.Add(other.rankSmeltItemType_);
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
			case 48u:
			case 50u:
				rankSmeltItemType_.AddEntriesFrom(ref input, _repeated_rankSmeltItemType_codec);
				break;
			case 40u:
			case 42u:
				rankSmeltItemId_.AddEntriesFrom(ref input, _repeated_rankSmeltItemId_codec);
				break;
			case 8u:
				EquipGradeLocalTextId = input.ReadInt32();
				break;
			case 18u:
				IconSpriteName = input.ReadString();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 32u:
			case 34u:
				rankSmeltItemCount_.AddEntriesFrom(ref input, _repeated_rankSmeltItemCount_codec);
				break;
			}
		}
	}
}
