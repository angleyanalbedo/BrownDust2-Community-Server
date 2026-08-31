using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleEndSeasonDBInfo : IMessage<EvilCastleEndSeasonDBInfo>, IMessage, IEquatable<EvilCastleEndSeasonDBInfo>, IDeepCloneable<EvilCastleEndSeasonDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleEndSeasonDBInfo> _parser = new MessageParser<EvilCastleEndSeasonDBInfo>(() => new EvilCastleEndSeasonDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int RankFieldNumber = 1;

	private int rank_;

	public const int StageIndexFieldNumber = 2;

	private int stageIndex_;

	public const int PointFieldNumber = 3;

	private int point_;

	public const int IsRewardedFieldNumber = 4;

	private bool isRewarded_;

	public const int RewardInfoFieldNumber = 5;

	private static readonly FieldCodec<RewardDBInfo> _repeated_rewardInfo_codec = FieldCodec.ForMessage(42u, RewardDBInfo.Parser);

	private readonly RepeatedField<RewardDBInfo> rewardInfo_ = new RepeatedField<RewardDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleEndSeasonDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleEndSeasonDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StageIndex
	{
		get
		{
			return stageIndex_;
		}
		set
		{
			stageIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Point
	{
		get
		{
			return point_;
		}
		set
		{
			point_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsRewarded
	{
		get
		{
			return isRewarded_;
		}
		set
		{
			isRewarded_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<RewardDBInfo> RewardInfo => rewardInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleEndSeasonDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleEndSeasonDBInfo(EvilCastleEndSeasonDBInfo other)
		: this()
	{
		rank_ = other.rank_;
		stageIndex_ = other.stageIndex_;
		point_ = other.point_;
		isRewarded_ = other.isRewarded_;
		rewardInfo_ = other.rewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleEndSeasonDBInfo Clone()
	{
		return new EvilCastleEndSeasonDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleEndSeasonDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleEndSeasonDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Rank == other.Rank && StageIndex == other.StageIndex && Point == other.Point && IsRewarded == other.IsRewarded && rewardInfo_.Equals(other.rewardInfo_))
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
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (StageIndex != 0)
		{
			num ^= StageIndex.GetHashCode();
		}
		if (Point != 0)
		{
			num ^= Point.GetHashCode();
		}
		if (IsRewarded)
		{
			num ^= IsRewarded.GetHashCode();
		}
		num ^= rewardInfo_.GetHashCode();
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
		if (Rank != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Rank);
		}
		if (StageIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(StageIndex);
		}
		if (Point != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Point);
		}
		if (IsRewarded)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsRewarded);
		}
		rewardInfo_.WriteTo(ref output, _repeated_rewardInfo_codec);
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
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (StageIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageIndex);
		}
		if (Point != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Point);
		}
		if (IsRewarded)
		{
			num += 2;
		}
		num += rewardInfo_.CalculateSize(_repeated_rewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleEndSeasonDBInfo other)
	{
		if (other != null)
		{
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.StageIndex != 0)
			{
				StageIndex = other.StageIndex;
			}
			if (other.Point != 0)
			{
				Point = other.Point;
			}
			if (other.IsRewarded)
			{
				IsRewarded = other.IsRewarded;
			}
			rewardInfo_.Add(other.rewardInfo_);
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
				Rank = input.ReadInt32();
				break;
			case 16u:
				StageIndex = input.ReadInt32();
				break;
			case 24u:
				Point = input.ReadInt32();
				break;
			case 32u:
				IsRewarded = input.ReadBool();
				break;
			case 42u:
				rewardInfo_.AddEntriesFrom(ref input, _repeated_rewardInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
