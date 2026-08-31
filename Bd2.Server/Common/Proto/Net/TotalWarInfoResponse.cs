using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TotalWarInfoResponse : IMessage<TotalWarInfoResponse>, IMessage, IEquatable<TotalWarInfoResponse>, IDeepCloneable<TotalWarInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<TotalWarInfoResponse> _parser = new MessageParser<TotalWarInfoResponse>(() => new TotalWarInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int ScoreInfoFieldNumber = 1;

	private static readonly FieldCodec<BattleDamageDBInfo> _repeated_scoreInfo_codec = FieldCodec.ForMessage(10u, BattleDamageDBInfo.Parser);

	private readonly RepeatedField<BattleDamageDBInfo> scoreInfo_ = new RepeatedField<BattleDamageDBInfo>();

	public const int TopPercentFieldNumber = 2;

	private double topPercent_;

	public const int TopRankerScoreFieldNumber = 3;

	private long topRankerScore_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TotalWarInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TotalWarInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleDamageDBInfo> ScoreInfo => scoreInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double TopPercent
	{
		get
		{
			return topPercent_;
		}
		set
		{
			topPercent_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TopRankerScore
	{
		get
		{
			return topRankerScore_;
		}
		set
		{
			topRankerScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarInfoResponse(TotalWarInfoResponse other)
		: this()
	{
		scoreInfo_ = other.scoreInfo_.Clone();
		topPercent_ = other.topPercent_;
		topRankerScore_ = other.topRankerScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TotalWarInfoResponse Clone()
	{
		return new TotalWarInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TotalWarInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (scoreInfo_.Equals(other.scoreInfo_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TopPercent, other.TopPercent) && TopRankerScore == other.TopRankerScore)
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
		num ^= scoreInfo_.GetHashCode();
		if (TopPercent != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TopPercent);
		}
		if (TopRankerScore != 0L)
		{
			num ^= TopRankerScore.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		scoreInfo_.WriteTo(ref output, _repeated_scoreInfo_codec);
		if (TopPercent != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(TopPercent);
		}
		if (TopRankerScore != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(TopRankerScore);
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
		num += scoreInfo_.CalculateSize(_repeated_scoreInfo_codec);
		if (TopPercent != 0.0)
		{
			num += 9;
		}
		if (TopRankerScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(TopRankerScore);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TotalWarInfoResponse other)
	{
		if (other != null)
		{
			scoreInfo_.Add(other.scoreInfo_);
			if (other.TopPercent != 0.0)
			{
				TopPercent = other.TopPercent;
			}
			if (other.TopRankerScore != 0L)
			{
				TopRankerScore = other.TopRankerScore;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				TopRankerScore = input.ReadInt64();
				break;
			case 17u:
				TopPercent = input.ReadDouble();
				break;
			case 10u:
				scoreInfo_.AddEntriesFrom(ref input, _repeated_scoreInfo_codec);
				break;
			}
		}
	}
}
