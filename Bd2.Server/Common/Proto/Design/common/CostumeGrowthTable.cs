using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CostumeGrowthTable : IMessage<CostumeGrowthTable>, IMessage, IEquatable<CostumeGrowthTable>, IDeepCloneable<CostumeGrowthTable>, IBufferMessage
{
	private static readonly MessageParser<CostumeGrowthTable> _parser = new MessageParser<CostumeGrowthTable>(() => new CostumeGrowthTable());

	private UnknownFieldSet _unknownFields;

	public const int GetExchangeItemCountFieldNumber = 1;

	private int getExchangeItemCount_;

	public const int GetExchangeItemIdFieldNumber = 2;

	private int getExchangeItemId_;

	public const int GetExchangeItemTypeFieldNumber = 3;

	private int getExchangeItemType_;

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int GrowthItemCountFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_growthItemCount_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> growthItemCount_ = new RepeatedField<int>();

	public const int GrowthItemIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_growthItemId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> growthItemId_ = new RepeatedField<int>();

	public const int GrowthItemTypeFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_growthItemType_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> growthItemType_ = new RepeatedField<int>();

	public const int IdFieldNumber = 8;

	private int id_;

	public const int MileageItemCountFieldNumber = 9;

	private int mileageItemCount_;

	public const int MileageItemIdFieldNumber = 10;

	private int mileageItemId_;

	public const int MileageItemTypeFieldNumber = 11;

	private int mileageItemType_;

	public const int OverExchangeCountFieldNumber = 12;

	private int overExchangeCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CostumeGrowthTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumeGrowthTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GetExchangeItemCount
	{
		get
		{
			return getExchangeItemCount_;
		}
		set
		{
			getExchangeItemCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GetExchangeItemId
	{
		get
		{
			return getExchangeItemId_;
		}
		set
		{
			getExchangeItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GetExchangeItemType
	{
		get
		{
			return getExchangeItemType_;
		}
		set
		{
			getExchangeItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GrowthItemCount => growthItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GrowthItemId => growthItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GrowthItemType => growthItemType_;

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
	public int MileageItemCount
	{
		get
		{
			return mileageItemCount_;
		}
		set
		{
			mileageItemCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MileageItemId
	{
		get
		{
			return mileageItemId_;
		}
		set
		{
			mileageItemId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MileageItemType
	{
		get
		{
			return mileageItemType_;
		}
		set
		{
			mileageItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OverExchangeCount
	{
		get
		{
			return overExchangeCount_;
		}
		set
		{
			overExchangeCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeGrowthTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeGrowthTable(CostumeGrowthTable other)
		: this()
	{
		getExchangeItemCount_ = other.getExchangeItemCount_;
		getExchangeItemId_ = other.getExchangeItemId_;
		getExchangeItemType_ = other.getExchangeItemType_;
		groupId_ = other.groupId_;
		growthItemCount_ = other.growthItemCount_.Clone();
		growthItemId_ = other.growthItemId_.Clone();
		growthItemType_ = other.growthItemType_.Clone();
		id_ = other.id_;
		mileageItemCount_ = other.mileageItemCount_;
		mileageItemId_ = other.mileageItemId_;
		mileageItemType_ = other.mileageItemType_;
		overExchangeCount_ = other.overExchangeCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeGrowthTable Clone()
	{
		return new CostumeGrowthTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeGrowthTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CostumeGrowthTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GetExchangeItemCount == other.GetExchangeItemCount && GetExchangeItemId == other.GetExchangeItemId && GetExchangeItemType == other.GetExchangeItemType && GroupId == other.GroupId && growthItemCount_.Equals(other.growthItemCount_) && growthItemId_.Equals(other.growthItemId_) && growthItemType_.Equals(other.growthItemType_) && Id == other.Id && MileageItemCount == other.MileageItemCount && MileageItemId == other.MileageItemId && MileageItemType == other.MileageItemType && OverExchangeCount == other.OverExchangeCount)
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
		if (GetExchangeItemCount != 0)
		{
			num ^= GetExchangeItemCount.GetHashCode();
		}
		if (GetExchangeItemId != 0)
		{
			num ^= GetExchangeItemId.GetHashCode();
		}
		if (GetExchangeItemType != 0)
		{
			num ^= GetExchangeItemType.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= growthItemCount_.GetHashCode();
		num ^= growthItemId_.GetHashCode();
		num ^= growthItemType_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MileageItemCount != 0)
		{
			num ^= MileageItemCount.GetHashCode();
		}
		if (MileageItemId != 0)
		{
			num ^= MileageItemId.GetHashCode();
		}
		if (MileageItemType != 0)
		{
			num ^= MileageItemType.GetHashCode();
		}
		if (OverExchangeCount != 0)
		{
			num ^= OverExchangeCount.GetHashCode();
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
		if (GetExchangeItemCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GetExchangeItemCount);
		}
		if (GetExchangeItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GetExchangeItemId);
		}
		if (GetExchangeItemType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GetExchangeItemType);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		growthItemCount_.WriteTo(ref output, _repeated_growthItemCount_codec);
		growthItemId_.WriteTo(ref output, _repeated_growthItemId_codec);
		growthItemType_.WriteTo(ref output, _repeated_growthItemType_codec);
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (MileageItemCount != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MileageItemCount);
		}
		if (MileageItemId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MileageItemId);
		}
		if (MileageItemType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(MileageItemType);
		}
		if (OverExchangeCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(OverExchangeCount);
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
		if (GetExchangeItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GetExchangeItemCount);
		}
		if (GetExchangeItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GetExchangeItemId);
		}
		if (GetExchangeItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GetExchangeItemType);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		num += growthItemCount_.CalculateSize(_repeated_growthItemCount_codec);
		num += growthItemId_.CalculateSize(_repeated_growthItemId_codec);
		num += growthItemType_.CalculateSize(_repeated_growthItemType_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MileageItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MileageItemCount);
		}
		if (MileageItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MileageItemId);
		}
		if (MileageItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MileageItemType);
		}
		if (OverExchangeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OverExchangeCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CostumeGrowthTable other)
	{
		if (other != null)
		{
			if (other.GetExchangeItemCount != 0)
			{
				GetExchangeItemCount = other.GetExchangeItemCount;
			}
			if (other.GetExchangeItemId != 0)
			{
				GetExchangeItemId = other.GetExchangeItemId;
			}
			if (other.GetExchangeItemType != 0)
			{
				GetExchangeItemType = other.GetExchangeItemType;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			growthItemCount_.Add(other.growthItemCount_);
			growthItemId_.Add(other.growthItemId_);
			growthItemType_.Add(other.growthItemType_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MileageItemCount != 0)
			{
				MileageItemCount = other.MileageItemCount;
			}
			if (other.MileageItemId != 0)
			{
				MileageItemId = other.MileageItemId;
			}
			if (other.MileageItemType != 0)
			{
				MileageItemType = other.MileageItemType;
			}
			if (other.OverExchangeCount != 0)
			{
				OverExchangeCount = other.OverExchangeCount;
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
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				growthItemCount_.AddEntriesFrom(ref input, _repeated_growthItemCount_codec);
				break;
			case 8u:
				GetExchangeItemCount = input.ReadInt32();
				break;
			case 16u:
				GetExchangeItemId = input.ReadInt32();
				break;
			case 24u:
				GetExchangeItemType = input.ReadInt32();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				growthItemType_.AddEntriesFrom(ref input, _repeated_growthItemType_codec);
				break;
			case 72u:
				MileageItemCount = input.ReadInt32();
				break;
			case 80u:
				MileageItemId = input.ReadInt32();
				break;
			case 88u:
				MileageItemType = input.ReadInt32();
				break;
			case 96u:
				OverExchangeCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 48u:
			case 50u:
				growthItemId_.AddEntriesFrom(ref input, _repeated_growthItemId_codec);
				break;
			}
		}
	}
}
