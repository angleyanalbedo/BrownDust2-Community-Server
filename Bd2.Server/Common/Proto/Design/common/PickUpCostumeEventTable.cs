using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PickUpCostumeEventTable : IMessage<PickUpCostumeEventTable>, IMessage, IEquatable<PickUpCostumeEventTable>, IDeepCloneable<PickUpCostumeEventTable>, IBufferMessage
{
	private static readonly MessageParser<PickUpCostumeEventTable> _parser = new MessageParser<PickUpCostumeEventTable>(() => new PickUpCostumeEventTable());

	private UnknownFieldSet _unknownFields;

	public const int AddBonusRateFieldNumber = 1;

	private static readonly FieldCodec<float> _repeated_addBonusRate_codec = FieldCodec.ForFloat(10u);

	private readonly RepeatedField<float> addBonusRate_ = new RepeatedField<float>();

	public const int CostumeIdFieldNumber = 2;

	private int costumeId_;

	public const int GroupIdFieldNumber = 3;

	private int groupId_;

	public const int IdFieldNumber = 4;

	private int id_;

	public const int TargetRewardIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_targetRewardId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> targetRewardId_ = new RepeatedField<int>();

	public const int TargetRewardTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_targetRewardType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> targetRewardType_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PickUpCostumeEventTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PickUpCostumeEventTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<float> AddBonusRate => addBonusRate_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeId
	{
		get
		{
			return costumeId_;
		}
		set
		{
			costumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public RepeatedField<int> TargetRewardId => targetRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> TargetRewardType => targetRewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PickUpCostumeEventTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PickUpCostumeEventTable(PickUpCostumeEventTable other)
		: this()
	{
		addBonusRate_ = other.addBonusRate_.Clone();
		costumeId_ = other.costumeId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		targetRewardId_ = other.targetRewardId_.Clone();
		targetRewardType_ = other.targetRewardType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PickUpCostumeEventTable Clone()
	{
		return new PickUpCostumeEventTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PickUpCostumeEventTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PickUpCostumeEventTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (addBonusRate_.Equals(other.addBonusRate_) && CostumeId == other.CostumeId && GroupId == other.GroupId && Id == other.Id && targetRewardId_.Equals(other.targetRewardId_) && targetRewardType_.Equals(other.targetRewardType_))
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
		num ^= addBonusRate_.GetHashCode();
		if (CostumeId != 0)
		{
			num ^= CostumeId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= targetRewardId_.GetHashCode();
		num ^= targetRewardType_.GetHashCode();
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
		addBonusRate_.WriteTo(ref output, _repeated_addBonusRate_codec);
		if (CostumeId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CostumeId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		targetRewardId_.WriteTo(ref output, _repeated_targetRewardId_codec);
		targetRewardType_.WriteTo(ref output, _repeated_targetRewardType_codec);
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
		num += addBonusRate_.CalculateSize(_repeated_addBonusRate_codec);
		if (CostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += targetRewardId_.CalculateSize(_repeated_targetRewardId_codec);
		num += targetRewardType_.CalculateSize(_repeated_targetRewardType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PickUpCostumeEventTable other)
	{
		if (other != null)
		{
			addBonusRate_.Add(other.addBonusRate_);
			if (other.CostumeId != 0)
			{
				CostumeId = other.CostumeId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			targetRewardId_.Add(other.targetRewardId_);
			targetRewardType_.Add(other.targetRewardType_);
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
			case 32u:
				Id = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				targetRewardType_.AddEntriesFrom(ref input, _repeated_targetRewardType_codec);
				break;
			case 40u:
			case 42u:
				targetRewardId_.AddEntriesFrom(ref input, _repeated_targetRewardId_codec);
				break;
			case 10u:
			case 13u:
				addBonusRate_.AddEntriesFrom(ref input, _repeated_addBonusRate_codec);
				break;
			case 16u:
				CostumeId = input.ReadInt32();
				break;
			case 24u:
				GroupId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
