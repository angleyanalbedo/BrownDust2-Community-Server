using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleStageRankingInfoResponse : IMessage<EvilCastleStageRankingInfoResponse>, IMessage, IEquatable<EvilCastleStageRankingInfoResponse>, IDeepCloneable<EvilCastleStageRankingInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleStageRankingInfoResponse> _parser = new MessageParser<EvilCastleStageRankingInfoResponse>(() => new EvilCastleStageRankingInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int RankFieldNumber = 1;

	private int rank_;

	public const int PointFieldNumber = 2;

	private int point_;

	public const int TotalRankFieldNumber = 3;

	private int totalRank_;

	public const int TotalPointFieldNumber = 4;

	private int totalPoint_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleStageRankingInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleStageRankingInfoResponseReflection.Descriptor.MessageTypes[0];

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
	public int TotalRank
	{
		get
		{
			return totalRank_;
		}
		set
		{
			totalRank_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalPoint
	{
		get
		{
			return totalPoint_;
		}
		set
		{
			totalPoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleStageRankingInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleStageRankingInfoResponse(EvilCastleStageRankingInfoResponse other)
		: this()
	{
		rank_ = other.rank_;
		point_ = other.point_;
		totalRank_ = other.totalRank_;
		totalPoint_ = other.totalPoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleStageRankingInfoResponse Clone()
	{
		return new EvilCastleStageRankingInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleStageRankingInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EvilCastleStageRankingInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Rank == other.Rank && Point == other.Point && TotalRank == other.TotalRank && TotalPoint == other.TotalPoint)
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
		if (Point != 0)
		{
			num ^= Point.GetHashCode();
		}
		if (TotalRank != 0)
		{
			num ^= TotalRank.GetHashCode();
		}
		if (TotalPoint != 0)
		{
			num ^= TotalPoint.GetHashCode();
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
		if (Point != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Point);
		}
		if (TotalRank != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TotalRank);
		}
		if (TotalPoint != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TotalPoint);
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
		if (Point != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Point);
		}
		if (TotalRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalRank);
		}
		if (TotalPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalPoint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleStageRankingInfoResponse other)
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
			if (other.TotalRank != 0)
			{
				TotalRank = other.TotalRank;
			}
			if (other.TotalPoint != 0)
			{
				TotalPoint = other.TotalPoint;
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
				TotalRank = input.ReadInt32();
				break;
			case 32u:
				TotalPoint = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
