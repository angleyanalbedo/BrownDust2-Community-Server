using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleDBInfo : IMessage<EvilCastleDBInfo>, IMessage, IEquatable<EvilCastleDBInfo>, IDeepCloneable<EvilCastleDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleDBInfo> _parser = new MessageParser<EvilCastleDBInfo>(() => new EvilCastleDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int RankFieldNumber = 1;

	private int rank_;

	public const int StageIndexFieldNumber = 2;

	private int stageIndex_;

	public const int RetryFieldNumber = 3;

	private int retry_;

	public const int PointFieldNumber = 4;

	private int point_;

	public const int SeasonHighestPointFieldNumber = 5;

	private int seasonHighestPoint_;

	public const int IsRewardedFieldNumber = 6;

	private bool isRewarded_;

	public const int StageClearTimeFieldNumber = 7;

	private int stageClearTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleDBInfoReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Retry
	{
		get
		{
			return retry_;
		}
		set
		{
			retry_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int SeasonHighestPoint
	{
		get
		{
			return seasonHighestPoint_;
		}
		set
		{
			seasonHighestPoint_ = value;
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
	public int StageClearTime
	{
		get
		{
			return stageClearTime_;
		}
		set
		{
			stageClearTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleDBInfo(EvilCastleDBInfo other)
		: this()
	{
		rank_ = other.rank_;
		stageIndex_ = other.stageIndex_;
		retry_ = other.retry_;
		point_ = other.point_;
		seasonHighestPoint_ = other.seasonHighestPoint_;
		isRewarded_ = other.isRewarded_;
		stageClearTime_ = other.stageClearTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleDBInfo Clone()
	{
		return new EvilCastleDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Rank == other.Rank && StageIndex == other.StageIndex && Retry == other.Retry && Point == other.Point && SeasonHighestPoint == other.SeasonHighestPoint && IsRewarded == other.IsRewarded && StageClearTime == other.StageClearTime)
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
		if (StageIndex != 0)
		{
			num ^= StageIndex.GetHashCode();
		}
		if (Retry != 0)
		{
			num ^= Retry.GetHashCode();
		}
		if (Point != 0)
		{
			num ^= Point.GetHashCode();
		}
		if (SeasonHighestPoint != 0)
		{
			num ^= SeasonHighestPoint.GetHashCode();
		}
		if (IsRewarded)
		{
			num ^= IsRewarded.GetHashCode();
		}
		if (StageClearTime != 0)
		{
			num ^= StageClearTime.GetHashCode();
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
		if (Retry != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Retry);
		}
		if (Point != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Point);
		}
		if (SeasonHighestPoint != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SeasonHighestPoint);
		}
		if (IsRewarded)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsRewarded);
		}
		if (StageClearTime != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(StageClearTime);
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
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (StageIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageIndex);
		}
		if (Retry != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Retry);
		}
		if (Point != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Point);
		}
		if (SeasonHighestPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeasonHighestPoint);
		}
		if (IsRewarded)
		{
			num += 2;
		}
		if (StageClearTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageClearTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleDBInfo other)
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
			if (other.Retry != 0)
			{
				Retry = other.Retry;
			}
			if (other.Point != 0)
			{
				Point = other.Point;
			}
			if (other.SeasonHighestPoint != 0)
			{
				SeasonHighestPoint = other.SeasonHighestPoint;
			}
			if (other.IsRewarded)
			{
				IsRewarded = other.IsRewarded;
			}
			if (other.StageClearTime != 0)
			{
				StageClearTime = other.StageClearTime;
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
				Rank = input.ReadInt32();
				break;
			case 16u:
				StageIndex = input.ReadInt32();
				break;
			case 24u:
				Retry = input.ReadInt32();
				break;
			case 32u:
				Point = input.ReadInt32();
				break;
			case 40u:
				SeasonHighestPoint = input.ReadInt32();
				break;
			case 48u:
				IsRewarded = input.ReadBool();
				break;
			case 56u:
				StageClearTime = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
