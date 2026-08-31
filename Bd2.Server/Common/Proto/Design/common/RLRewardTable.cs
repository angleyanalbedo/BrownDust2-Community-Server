using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLRewardTable : IMessage<RLRewardTable>, IMessage, IEquatable<RLRewardTable>, IDeepCloneable<RLRewardTable>, IBufferMessage
{
	private static readonly MessageParser<RLRewardTable> _parser = new MessageParser<RLRewardTable>(() => new RLRewardTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int RewardCountFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int ScoreFieldNumber = 5;

	private int score_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RLRewardTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => RLRewardTableReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<int> RewardCount => rewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardId => rewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardType => rewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Score
	{
		get
		{
			return score_;
		}
		set
		{
			score_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLRewardTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLRewardTable(RLRewardTable other)
		: this()
	{
		id_ = other.id_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		score_ = other.score_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLRewardTable Clone()
	{
		return new RLRewardTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as RLRewardTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RLRewardTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_) && Score == other.Score)
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
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
		if (Score != 0)
		{
			num ^= Score.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		if (Score != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Score);
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
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		if (Score != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Score);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RLRewardTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
			if (other.Score != 0)
			{
				Score = other.Score;
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
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 40u:
				Score = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			}
		}
	}
}
