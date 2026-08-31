using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TotalWarBattleEndResponse : IMessage<TotalWarBattleEndResponse>, IMessage, IEquatable<TotalWarBattleEndResponse>, IDeepCloneable<TotalWarBattleEndResponse>, IBufferMessage
{
	private static readonly MessageParser<TotalWarBattleEndResponse> _parser = new MessageParser<TotalWarBattleEndResponse>(() => new TotalWarBattleEndResponse());

	private UnknownFieldSet _unknownFields;

	public const int ScoreInfoFieldNumber = 1;

	private static readonly FieldCodec<BattleDamageDBInfo> _repeated_scoreInfo_codec = FieldCodec.ForMessage(10u, BattleDamageDBInfo.Parser);

	private readonly RepeatedField<BattleDamageDBInfo> scoreInfo_ = new RepeatedField<BattleDamageDBInfo>();

	public const int TopPercentFieldNumber = 2;

	private double topPercent_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TotalWarBattleEndResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TotalWarBattleEndResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleDamageDBInfo> ScoreInfo => scoreInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarBattleEndResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarBattleEndResponse(TotalWarBattleEndResponse other)
		: this()
	{
		scoreInfo_ = other.scoreInfo_.Clone();
		topPercent_ = other.topPercent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarBattleEndResponse Clone()
	{
		return new TotalWarBattleEndResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarBattleEndResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TotalWarBattleEndResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (scoreInfo_.Equals(other.scoreInfo_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TopPercent, other.TopPercent))
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
		scoreInfo_.WriteTo(ref output, _repeated_scoreInfo_codec);
		if (TopPercent != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(TopPercent);
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TotalWarBattleEndResponse other)
	{
		if (other != null)
		{
			scoreInfo_.Add(other.scoreInfo_);
			if (other.TopPercent != 0.0)
			{
				TopPercent = other.TopPercent;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
