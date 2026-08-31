using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EquipmentGrowthTable : IMessage<EquipmentGrowthTable>, IMessage, IEquatable<EquipmentGrowthTable>, IDeepCloneable<EquipmentGrowthTable>, IBufferMessage
{
	private static readonly MessageParser<EquipmentGrowthTable> _parser = new MessageParser<EquipmentGrowthTable>(() => new EquipmentGrowthTable());

	private UnknownFieldSet _unknownFields;

	public const int BreakResultItemCountFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_breakResultItemCount_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> breakResultItemCount_ = new RepeatedField<int>();

	public const int BreakResultItemIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_breakResultItemId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> breakResultItemId_ = new RepeatedField<int>();

	public const int BreakResultItemTypeFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_breakResultItemType_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> breakResultItemType_ = new RepeatedField<int>();

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int GrowthPointFieldNumber = 5;

	private int growthPoint_;

	public const int IdFieldNumber = 6;

	private int id_;

	public const int UpgradeItemCountFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_upgradeItemCount_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> upgradeItemCount_ = new RepeatedField<int>();

	public const int UpgradeItemIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_upgradeItemId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> upgradeItemId_ = new RepeatedField<int>();

	public const int UpgradeItemTypeFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_upgradeItemType_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> upgradeItemType_ = new RepeatedField<int>();

	public const int UpgradeSuccessRatioFieldNumber = 10;

	private double upgradeSuccessRatio_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EquipmentGrowthTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipmentGrowthTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BreakResultItemCount => breakResultItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BreakResultItemId => breakResultItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BreakResultItemType => breakResultItemType_;

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
	public int GrowthPoint
	{
		get
		{
			return growthPoint_;
		}
		set
		{
			growthPoint_ = value;
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
	public RepeatedField<int> UpgradeItemCount => upgradeItemCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> UpgradeItemId => upgradeItemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> UpgradeItemType => upgradeItemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double UpgradeSuccessRatio
	{
		get
		{
			return upgradeSuccessRatio_;
		}
		set
		{
			upgradeSuccessRatio_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentGrowthTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentGrowthTable(EquipmentGrowthTable other)
		: this()
	{
		breakResultItemCount_ = other.breakResultItemCount_.Clone();
		breakResultItemId_ = other.breakResultItemId_.Clone();
		breakResultItemType_ = other.breakResultItemType_.Clone();
		groupId_ = other.groupId_;
		growthPoint_ = other.growthPoint_;
		id_ = other.id_;
		upgradeItemCount_ = other.upgradeItemCount_.Clone();
		upgradeItemId_ = other.upgradeItemId_.Clone();
		upgradeItemType_ = other.upgradeItemType_.Clone();
		upgradeSuccessRatio_ = other.upgradeSuccessRatio_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentGrowthTable Clone()
	{
		return new EquipmentGrowthTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentGrowthTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipmentGrowthTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (breakResultItemCount_.Equals(other.breakResultItemCount_) && breakResultItemId_.Equals(other.breakResultItemId_) && breakResultItemType_.Equals(other.breakResultItemType_) && GroupId == other.GroupId && GrowthPoint == other.GrowthPoint && Id == other.Id && upgradeItemCount_.Equals(other.upgradeItemCount_) && upgradeItemId_.Equals(other.upgradeItemId_) && upgradeItemType_.Equals(other.upgradeItemType_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UpgradeSuccessRatio, other.UpgradeSuccessRatio))
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
		num ^= breakResultItemCount_.GetHashCode();
		num ^= breakResultItemId_.GetHashCode();
		num ^= breakResultItemType_.GetHashCode();
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (GrowthPoint != 0)
		{
			num ^= GrowthPoint.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= upgradeItemCount_.GetHashCode();
		num ^= upgradeItemId_.GetHashCode();
		num ^= upgradeItemType_.GetHashCode();
		if (UpgradeSuccessRatio != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UpgradeSuccessRatio);
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
		breakResultItemCount_.WriteTo(ref output, _repeated_breakResultItemCount_codec);
		breakResultItemId_.WriteTo(ref output, _repeated_breakResultItemId_codec);
		breakResultItemType_.WriteTo(ref output, _repeated_breakResultItemType_codec);
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (GrowthPoint != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GrowthPoint);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		upgradeItemCount_.WriteTo(ref output, _repeated_upgradeItemCount_codec);
		upgradeItemId_.WriteTo(ref output, _repeated_upgradeItemId_codec);
		upgradeItemType_.WriteTo(ref output, _repeated_upgradeItemType_codec);
		if (UpgradeSuccessRatio != 0.0)
		{
			output.WriteRawTag(81);
			output.WriteDouble(UpgradeSuccessRatio);
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
		num += breakResultItemCount_.CalculateSize(_repeated_breakResultItemCount_codec);
		num += breakResultItemId_.CalculateSize(_repeated_breakResultItemId_codec);
		num += breakResultItemType_.CalculateSize(_repeated_breakResultItemType_codec);
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (GrowthPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GrowthPoint);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += upgradeItemCount_.CalculateSize(_repeated_upgradeItemCount_codec);
		num += upgradeItemId_.CalculateSize(_repeated_upgradeItemId_codec);
		num += upgradeItemType_.CalculateSize(_repeated_upgradeItemType_codec);
		if (UpgradeSuccessRatio != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipmentGrowthTable other)
	{
		if (other != null)
		{
			breakResultItemCount_.Add(other.breakResultItemCount_);
			breakResultItemId_.Add(other.breakResultItemId_);
			breakResultItemType_.Add(other.breakResultItemType_);
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GrowthPoint != 0)
			{
				GrowthPoint = other.GrowthPoint;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			upgradeItemCount_.Add(other.upgradeItemCount_);
			upgradeItemId_.Add(other.upgradeItemId_);
			upgradeItemType_.Add(other.upgradeItemType_);
			if (other.UpgradeSuccessRatio != 0.0)
			{
				UpgradeSuccessRatio = other.UpgradeSuccessRatio;
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
			case 48u:
				Id = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				upgradeItemCount_.AddEntriesFrom(ref input, _repeated_upgradeItemCount_codec);
				break;
			case 81u:
				UpgradeSuccessRatio = input.ReadDouble();
				break;
			case 72u:
			case 74u:
				upgradeItemType_.AddEntriesFrom(ref input, _repeated_upgradeItemType_codec);
				break;
			case 64u:
			case 66u:
				upgradeItemId_.AddEntriesFrom(ref input, _repeated_upgradeItemId_codec);
				break;
			case 8u:
			case 10u:
				breakResultItemCount_.AddEntriesFrom(ref input, _repeated_breakResultItemCount_codec);
				break;
			case 16u:
			case 18u:
				breakResultItemId_.AddEntriesFrom(ref input, _repeated_breakResultItemId_codec);
				break;
			case 24u:
			case 26u:
				breakResultItemType_.AddEntriesFrom(ref input, _repeated_breakResultItemType_codec);
				break;
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 40u:
				GrowthPoint = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
