using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class LikabilityPartnerTable : IMessage<LikabilityPartnerTable>, IMessage, IEquatable<LikabilityPartnerTable>, IDeepCloneable<LikabilityPartnerTable>, IBufferMessage
{
	private static readonly MessageParser<LikabilityPartnerTable> _parser = new MessageParser<LikabilityPartnerTable>(() => new LikabilityPartnerTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int MainCharacterPointWeightFieldNumber = 2;

	private double mainCharacterPointWeight_;

	public const int PartnerUniqueIdsFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_partnerUniqueIds_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> partnerUniqueIds_ = new RepeatedField<int>();

	public const int RewardCountFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int StoryIdFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_storyId_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> storyId_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<LikabilityPartnerTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => LikabilityPartnerTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public double MainCharacterPointWeight
	{
		get
		{
			return mainCharacterPointWeight_;
		}
		set
		{
			mainCharacterPointWeight_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PartnerUniqueIds => partnerUniqueIds_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCount => rewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardId => rewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardType => rewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> StoryId => storyId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LikabilityPartnerTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LikabilityPartnerTable(LikabilityPartnerTable other)
		: this()
	{
		id_ = other.id_;
		mainCharacterPointWeight_ = other.mainCharacterPointWeight_;
		partnerUniqueIds_ = other.partnerUniqueIds_.Clone();
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		storyId_ = other.storyId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LikabilityPartnerTable Clone()
	{
		return new LikabilityPartnerTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LikabilityPartnerTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LikabilityPartnerTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MainCharacterPointWeight, other.MainCharacterPointWeight) && partnerUniqueIds_.Equals(other.partnerUniqueIds_) && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_) && storyId_.Equals(other.storyId_))
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
		if (MainCharacterPointWeight != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MainCharacterPointWeight);
		}
		num ^= partnerUniqueIds_.GetHashCode();
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
		num ^= storyId_.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (MainCharacterPointWeight != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(MainCharacterPointWeight);
		}
		partnerUniqueIds_.WriteTo(ref output, _repeated_partnerUniqueIds_codec);
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		storyId_.WriteTo(ref output, _repeated_storyId_codec);
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
		if (MainCharacterPointWeight != 0.0)
		{
			num += 9;
		}
		num += partnerUniqueIds_.CalculateSize(_repeated_partnerUniqueIds_codec);
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		num += storyId_.CalculateSize(_repeated_storyId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LikabilityPartnerTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MainCharacterPointWeight != 0.0)
			{
				MainCharacterPointWeight = other.MainCharacterPointWeight;
			}
			partnerUniqueIds_.Add(other.partnerUniqueIds_);
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
			storyId_.Add(other.storyId_);
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
			case 17u:
				MainCharacterPointWeight = input.ReadDouble();
				break;
			case 32u:
			case 34u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 24u:
			case 26u:
				partnerUniqueIds_.AddEntriesFrom(ref input, _repeated_partnerUniqueIds_codec);
				break;
			case 40u:
			case 42u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 56u:
			case 58u:
				storyId_.AddEntriesFrom(ref input, _repeated_storyId_codec);
				break;
			case 48u:
			case 50u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
