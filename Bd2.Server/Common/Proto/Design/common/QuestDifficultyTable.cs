using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class QuestDifficultyTable : IMessage<QuestDifficultyTable>, IMessage, IEquatable<QuestDifficultyTable>, IDeepCloneable<QuestDifficultyTable>, IBufferMessage
{
	private static readonly MessageParser<QuestDifficultyTable> _parser = new MessageParser<QuestDifficultyTable>(() => new QuestDifficultyTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int LimitTypeFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_limitType_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> limitType_ = new RepeatedField<int>();

	public const int LimitTypeLocalTextIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_limitTypeLocalTextId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> limitTypeLocalTextId_ = new RepeatedField<int>();

	public const int LimitTypeValueFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_limitTypeValue_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> limitTypeValue_ = new RepeatedField<int>();

	public const int LimitimmortalTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_limitimmortalType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> limitimmortalType_ = new RepeatedField<int>();

	public const int LimitimmortalTypeLocalTextIdFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_limitimmortalTypeLocalTextId_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> limitimmortalTypeLocalTextId_ = new RepeatedField<int>();

	public const int LimitimmortalTypeValueFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_limitimmortalTypeValue_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> limitimmortalTypeValue_ = new RepeatedField<int>();

	public const int RecommendGrowthPointFieldNumber = 9;

	private int recommendGrowthPoint_;

	public const int RewardCountFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestDifficultyTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestDifficultyTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<int> LimitType => limitType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> LimitTypeLocalTextId => limitTypeLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> LimitTypeValue => limitTypeValue_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> LimitimmortalType => limitimmortalType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> LimitimmortalTypeLocalTextId => limitimmortalTypeLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> LimitimmortalTypeValue => limitimmortalTypeValue_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RecommendGrowthPoint
	{
		get
		{
			return recommendGrowthPoint_;
		}
		set
		{
			recommendGrowthPoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardCount => rewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardId => rewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardType => rewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestDifficultyTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestDifficultyTable(QuestDifficultyTable other)
		: this()
	{
		groupId_ = other.groupId_;
		id_ = other.id_;
		limitType_ = other.limitType_.Clone();
		limitTypeLocalTextId_ = other.limitTypeLocalTextId_.Clone();
		limitTypeValue_ = other.limitTypeValue_.Clone();
		limitimmortalType_ = other.limitimmortalType_.Clone();
		limitimmortalTypeLocalTextId_ = other.limitimmortalTypeLocalTextId_.Clone();
		limitimmortalTypeValue_ = other.limitimmortalTypeValue_.Clone();
		recommendGrowthPoint_ = other.recommendGrowthPoint_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestDifficultyTable Clone()
	{
		return new QuestDifficultyTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestDifficultyTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestDifficultyTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && Id == other.Id && limitType_.Equals(other.limitType_) && limitTypeLocalTextId_.Equals(other.limitTypeLocalTextId_) && limitTypeValue_.Equals(other.limitTypeValue_) && limitimmortalType_.Equals(other.limitimmortalType_) && limitimmortalTypeLocalTextId_.Equals(other.limitimmortalTypeLocalTextId_) && limitimmortalTypeValue_.Equals(other.limitimmortalTypeValue_) && RecommendGrowthPoint == other.RecommendGrowthPoint && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_))
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= limitType_.GetHashCode();
		num ^= limitTypeLocalTextId_.GetHashCode();
		num ^= limitTypeValue_.GetHashCode();
		num ^= limitimmortalType_.GetHashCode();
		num ^= limitimmortalTypeLocalTextId_.GetHashCode();
		num ^= limitimmortalTypeValue_.GetHashCode();
		if (RecommendGrowthPoint != 0)
		{
			num ^= RecommendGrowthPoint.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		limitType_.WriteTo(ref output, _repeated_limitType_codec);
		limitTypeLocalTextId_.WriteTo(ref output, _repeated_limitTypeLocalTextId_codec);
		limitTypeValue_.WriteTo(ref output, _repeated_limitTypeValue_codec);
		limitimmortalType_.WriteTo(ref output, _repeated_limitimmortalType_codec);
		limitimmortalTypeLocalTextId_.WriteTo(ref output, _repeated_limitimmortalTypeLocalTextId_codec);
		limitimmortalTypeValue_.WriteTo(ref output, _repeated_limitimmortalTypeValue_codec);
		if (RecommendGrowthPoint != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(RecommendGrowthPoint);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += limitType_.CalculateSize(_repeated_limitType_codec);
		num += limitTypeLocalTextId_.CalculateSize(_repeated_limitTypeLocalTextId_codec);
		num += limitTypeValue_.CalculateSize(_repeated_limitTypeValue_codec);
		num += limitimmortalType_.CalculateSize(_repeated_limitimmortalType_codec);
		num += limitimmortalTypeLocalTextId_.CalculateSize(_repeated_limitimmortalTypeLocalTextId_codec);
		num += limitimmortalTypeValue_.CalculateSize(_repeated_limitimmortalTypeValue_codec);
		if (RecommendGrowthPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RecommendGrowthPoint);
		}
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(QuestDifficultyTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			limitType_.Add(other.limitType_);
			limitTypeLocalTextId_.Add(other.limitTypeLocalTextId_);
			limitTypeValue_.Add(other.limitTypeValue_);
			limitimmortalType_.Add(other.limitimmortalType_);
			limitimmortalTypeLocalTextId_.Add(other.limitimmortalTypeLocalTextId_);
			limitimmortalTypeValue_.Add(other.limitimmortalTypeValue_);
			if (other.RecommendGrowthPoint != 0)
			{
				RecommendGrowthPoint = other.RecommendGrowthPoint;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
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
			case 50u:
				limitimmortalType_.AddEntriesFrom(ref input, _repeated_limitimmortalType_codec);
				break;
			case 40u:
			case 42u:
				limitTypeValue_.AddEntriesFrom(ref input, _repeated_limitTypeValue_codec);
				break;
			case 8u:
				GroupId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				limitType_.AddEntriesFrom(ref input, _repeated_limitType_codec);
				break;
			case 32u:
			case 34u:
				limitTypeLocalTextId_.AddEntriesFrom(ref input, _repeated_limitTypeLocalTextId_codec);
				break;
			case 80u:
			case 82u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 96u:
			case 98u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			case 88u:
			case 90u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 56u:
			case 58u:
				limitimmortalTypeLocalTextId_.AddEntriesFrom(ref input, _repeated_limitimmortalTypeLocalTextId_codec);
				break;
			case 64u:
			case 66u:
				limitimmortalTypeValue_.AddEntriesFrom(ref input, _repeated_limitimmortalTypeValue_codec);
				break;
			case 72u:
				RecommendGrowthPoint = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
