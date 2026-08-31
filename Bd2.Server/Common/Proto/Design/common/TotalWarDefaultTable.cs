using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TotalWarDefaultTable : IMessage<TotalWarDefaultTable>, IMessage, IEquatable<TotalWarDefaultTable>, IDeepCloneable<TotalWarDefaultTable>, IBufferMessage
{
	private static readonly MessageParser<TotalWarDefaultTable> _parser = new MessageParser<TotalWarDefaultTable>(() => new TotalWarDefaultTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int IdleChangeDamageFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_idleChangeDamage_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> idleChangeDamage_ = new RepeatedField<int>();

	public const int RewardObjectIdFieldNumber = 3;

	private int rewardObjectId_;

	public const int RewardObjectInteractionLocalTextIdFieldNumber = 4;

	private int rewardObjectInteractionLocalTextId_;

	public const int RewardObjectPrefabNameFieldNumber = 5;

	private string rewardObjectPrefabName_ = "";

	public const int TotalWarPresetBaseCountFieldNumber = 6;

	private int totalWarPresetBaseCount_;

	public const int TotalWarPresetBuyCountFieldNumber = 7;

	private int totalWarPresetBuyCount_;

	public const int TotalWarPresetBuyIdFieldNumber = 8;

	private int totalWarPresetBuyId_;

	public const int TotalWarPresetBuyTypeFieldNumber = 9;

	private int totalWarPresetBuyType_;

	public const int TotalWarPresetMaxCountFieldNumber = 10;

	private int totalWarPresetMaxCount_;

	public const int TotalWarStartBuffIdFieldNumber = 11;

	private int totalWarStartBuffId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TotalWarDefaultTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TotalWarDefaultTableReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> IdleChangeDamage => idleChangeDamage_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardObjectId
	{
		get
		{
			return rewardObjectId_;
		}
		set
		{
			rewardObjectId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardObjectInteractionLocalTextId
	{
		get
		{
			return rewardObjectInteractionLocalTextId_;
		}
		set
		{
			rewardObjectInteractionLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RewardObjectPrefabName
	{
		get
		{
			return rewardObjectPrefabName_;
		}
		set
		{
			rewardObjectPrefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalWarPresetBaseCount
	{
		get
		{
			return totalWarPresetBaseCount_;
		}
		set
		{
			totalWarPresetBaseCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalWarPresetBuyCount
	{
		get
		{
			return totalWarPresetBuyCount_;
		}
		set
		{
			totalWarPresetBuyCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalWarPresetBuyId
	{
		get
		{
			return totalWarPresetBuyId_;
		}
		set
		{
			totalWarPresetBuyId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalWarPresetBuyType
	{
		get
		{
			return totalWarPresetBuyType_;
		}
		set
		{
			totalWarPresetBuyType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalWarPresetMaxCount
	{
		get
		{
			return totalWarPresetMaxCount_;
		}
		set
		{
			totalWarPresetMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalWarStartBuffId
	{
		get
		{
			return totalWarStartBuffId_;
		}
		set
		{
			totalWarStartBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarDefaultTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarDefaultTable(TotalWarDefaultTable other)
		: this()
	{
		id_ = other.id_;
		idleChangeDamage_ = other.idleChangeDamage_.Clone();
		rewardObjectId_ = other.rewardObjectId_;
		rewardObjectInteractionLocalTextId_ = other.rewardObjectInteractionLocalTextId_;
		rewardObjectPrefabName_ = other.rewardObjectPrefabName_;
		totalWarPresetBaseCount_ = other.totalWarPresetBaseCount_;
		totalWarPresetBuyCount_ = other.totalWarPresetBuyCount_;
		totalWarPresetBuyId_ = other.totalWarPresetBuyId_;
		totalWarPresetBuyType_ = other.totalWarPresetBuyType_;
		totalWarPresetMaxCount_ = other.totalWarPresetMaxCount_;
		totalWarStartBuffId_ = other.totalWarStartBuffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarDefaultTable Clone()
	{
		return new TotalWarDefaultTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarDefaultTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TotalWarDefaultTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && idleChangeDamage_.Equals(other.idleChangeDamage_) && RewardObjectId == other.RewardObjectId && RewardObjectInteractionLocalTextId == other.RewardObjectInteractionLocalTextId && !(RewardObjectPrefabName != other.RewardObjectPrefabName) && TotalWarPresetBaseCount == other.TotalWarPresetBaseCount && TotalWarPresetBuyCount == other.TotalWarPresetBuyCount && TotalWarPresetBuyId == other.TotalWarPresetBuyId && TotalWarPresetBuyType == other.TotalWarPresetBuyType && TotalWarPresetMaxCount == other.TotalWarPresetMaxCount && TotalWarStartBuffId == other.TotalWarStartBuffId)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= idleChangeDamage_.GetHashCode();
		if (RewardObjectId != 0)
		{
			num ^= RewardObjectId.GetHashCode();
		}
		if (RewardObjectInteractionLocalTextId != 0)
		{
			num ^= RewardObjectInteractionLocalTextId.GetHashCode();
		}
		if (RewardObjectPrefabName.Length != 0)
		{
			num ^= RewardObjectPrefabName.GetHashCode();
		}
		if (TotalWarPresetBaseCount != 0)
		{
			num ^= TotalWarPresetBaseCount.GetHashCode();
		}
		if (TotalWarPresetBuyCount != 0)
		{
			num ^= TotalWarPresetBuyCount.GetHashCode();
		}
		if (TotalWarPresetBuyId != 0)
		{
			num ^= TotalWarPresetBuyId.GetHashCode();
		}
		if (TotalWarPresetBuyType != 0)
		{
			num ^= TotalWarPresetBuyType.GetHashCode();
		}
		if (TotalWarPresetMaxCount != 0)
		{
			num ^= TotalWarPresetMaxCount.GetHashCode();
		}
		if (TotalWarStartBuffId != 0)
		{
			num ^= TotalWarStartBuffId.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		idleChangeDamage_.WriteTo(ref output, _repeated_idleChangeDamage_codec);
		if (RewardObjectId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RewardObjectId);
		}
		if (RewardObjectInteractionLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RewardObjectInteractionLocalTextId);
		}
		if (RewardObjectPrefabName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(RewardObjectPrefabName);
		}
		if (TotalWarPresetBaseCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TotalWarPresetBaseCount);
		}
		if (TotalWarPresetBuyCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TotalWarPresetBuyCount);
		}
		if (TotalWarPresetBuyId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TotalWarPresetBuyId);
		}
		if (TotalWarPresetBuyType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(TotalWarPresetBuyType);
		}
		if (TotalWarPresetMaxCount != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TotalWarPresetMaxCount);
		}
		if (TotalWarStartBuffId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(TotalWarStartBuffId);
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
		num += idleChangeDamage_.CalculateSize(_repeated_idleChangeDamage_codec);
		if (RewardObjectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardObjectId);
		}
		if (RewardObjectInteractionLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardObjectInteractionLocalTextId);
		}
		if (RewardObjectPrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RewardObjectPrefabName);
		}
		if (TotalWarPresetBaseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalWarPresetBaseCount);
		}
		if (TotalWarPresetBuyCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalWarPresetBuyCount);
		}
		if (TotalWarPresetBuyId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalWarPresetBuyId);
		}
		if (TotalWarPresetBuyType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalWarPresetBuyType);
		}
		if (TotalWarPresetMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalWarPresetMaxCount);
		}
		if (TotalWarStartBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalWarStartBuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TotalWarDefaultTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			idleChangeDamage_.Add(other.idleChangeDamage_);
			if (other.RewardObjectId != 0)
			{
				RewardObjectId = other.RewardObjectId;
			}
			if (other.RewardObjectInteractionLocalTextId != 0)
			{
				RewardObjectInteractionLocalTextId = other.RewardObjectInteractionLocalTextId;
			}
			if (other.RewardObjectPrefabName.Length != 0)
			{
				RewardObjectPrefabName = other.RewardObjectPrefabName;
			}
			if (other.TotalWarPresetBaseCount != 0)
			{
				TotalWarPresetBaseCount = other.TotalWarPresetBaseCount;
			}
			if (other.TotalWarPresetBuyCount != 0)
			{
				TotalWarPresetBuyCount = other.TotalWarPresetBuyCount;
			}
			if (other.TotalWarPresetBuyId != 0)
			{
				TotalWarPresetBuyId = other.TotalWarPresetBuyId;
			}
			if (other.TotalWarPresetBuyType != 0)
			{
				TotalWarPresetBuyType = other.TotalWarPresetBuyType;
			}
			if (other.TotalWarPresetMaxCount != 0)
			{
				TotalWarPresetMaxCount = other.TotalWarPresetMaxCount;
			}
			if (other.TotalWarStartBuffId != 0)
			{
				TotalWarStartBuffId = other.TotalWarStartBuffId;
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
				Id = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				idleChangeDamage_.AddEntriesFrom(ref input, _repeated_idleChangeDamage_codec);
				break;
			case 24u:
				RewardObjectId = input.ReadInt32();
				break;
			case 32u:
				RewardObjectInteractionLocalTextId = input.ReadInt32();
				break;
			case 42u:
				RewardObjectPrefabName = input.ReadString();
				break;
			case 48u:
				TotalWarPresetBaseCount = input.ReadInt32();
				break;
			case 56u:
				TotalWarPresetBuyCount = input.ReadInt32();
				break;
			case 64u:
				TotalWarPresetBuyId = input.ReadInt32();
				break;
			case 72u:
				TotalWarPresetBuyType = input.ReadInt32();
				break;
			case 80u:
				TotalWarPresetMaxCount = input.ReadInt32();
				break;
			case 88u:
				TotalWarStartBuffId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
