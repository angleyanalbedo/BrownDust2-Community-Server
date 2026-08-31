using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleEndSeasonTotalDBInfo : IMessage<EvilCastleEndSeasonTotalDBInfo>, IMessage, IEquatable<EvilCastleEndSeasonTotalDBInfo>, IDeepCloneable<EvilCastleEndSeasonTotalDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleEndSeasonTotalDBInfo> _parser = new MessageParser<EvilCastleEndSeasonTotalDBInfo>(() => new EvilCastleEndSeasonTotalDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int RankFieldNumber = 1;

	private int rank_;

	public const int PointFieldNumber = 2;

	private int point_;

	public const int IsRewardedFieldNumber = 3;

	private bool isRewarded_;

	public const int RewardInfoFieldNumber = 4;

	private static readonly FieldCodec<RewardDBInfo> _repeated_rewardInfo_codec = FieldCodec.ForMessage(34u, RewardDBInfo.Parser);

	private readonly RepeatedField<RewardDBInfo> rewardInfo_ = new RepeatedField<RewardDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleEndSeasonTotalDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleEndSeasonTotalDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RewardDBInfo> RewardInfo => rewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleEndSeasonTotalDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleEndSeasonTotalDBInfo(EvilCastleEndSeasonTotalDBInfo other)
		: this()
	{
		rank_ = other.rank_;
		point_ = other.point_;
		isRewarded_ = other.isRewarded_;
		rewardInfo_ = other.rewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleEndSeasonTotalDBInfo Clone()
	{
		return new EvilCastleEndSeasonTotalDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleEndSeasonTotalDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleEndSeasonTotalDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Rank == other.Rank && Point == other.Point && IsRewarded == other.IsRewarded && rewardInfo_.Equals(other.rewardInfo_))
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
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
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
		if (Point != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Point);
		}
		if (IsRewarded)
		{
			output.WriteRawTag(24);
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
	public void MergeFrom(EvilCastleEndSeasonTotalDBInfo other)
	{
		if (other != null)
		{
			if (other.Rank != 0)
			{
				Rank = other.Rank;
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
				Rank = input.ReadInt32();
				break;
			case 16u:
				Point = input.ReadInt32();
				break;
			case 24u:
				IsRewarded = input.ReadBool();
				break;
			case 34u:
				rewardInfo_.AddEntriesFrom(ref input, _repeated_rewardInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
