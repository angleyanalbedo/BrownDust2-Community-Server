using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TotalWarBattleStartRequest : IMessage<TotalWarBattleStartRequest>, IMessage, IEquatable<TotalWarBattleStartRequest>, IDeepCloneable<TotalWarBattleStartRequest>, IBufferMessage
{
	private static readonly MessageParser<TotalWarBattleStartRequest> _parser = new MessageParser<TotalWarBattleStartRequest>(() => new TotalWarBattleStartRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int BattleIndexFieldNumber = 2;

	private int battleIndex_;

	public const int BlueCharInfoFieldNumber = 3;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_blueCharInfo_codec = FieldCodec.ForMessage(26u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> blueCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int RedCharInfoFieldNumber = 4;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_redCharInfo_codec = FieldCodec.ForMessage(34u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> redCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TotalWarBattleStartRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TotalWarBattleStartRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleIndex
	{
		get
		{
			return battleIndex_;
		}
		set
		{
			battleIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> BlueCharInfo => blueCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> RedCharInfo => redCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarBattleStartRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarBattleStartRequest(TotalWarBattleStartRequest other)
		: this()
	{
		seq_ = other.seq_;
		battleIndex_ = other.battleIndex_;
		blueCharInfo_ = other.blueCharInfo_.Clone();
		redCharInfo_ = other.redCharInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarBattleStartRequest Clone()
	{
		return new TotalWarBattleStartRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarBattleStartRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TotalWarBattleStartRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && BattleIndex == other.BattleIndex && blueCharInfo_.Equals(other.blueCharInfo_) && redCharInfo_.Equals(other.redCharInfo_))
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (BattleIndex != 0)
		{
			num ^= BattleIndex.GetHashCode();
		}
		num ^= blueCharInfo_.GetHashCode();
		num ^= redCharInfo_.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (BattleIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleIndex);
		}
		blueCharInfo_.WriteTo(ref output, _repeated_blueCharInfo_codec);
		redCharInfo_.WriteTo(ref output, _repeated_redCharInfo_codec);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (BattleIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleIndex);
		}
		num += blueCharInfo_.CalculateSize(_repeated_blueCharInfo_codec);
		num += redCharInfo_.CalculateSize(_repeated_redCharInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TotalWarBattleStartRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.BattleIndex != 0)
			{
				BattleIndex = other.BattleIndex;
			}
			blueCharInfo_.Add(other.blueCharInfo_);
			redCharInfo_.Add(other.redCharInfo_);
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
				Seq = input.ReadInt32();
				break;
			case 16u:
				BattleIndex = input.ReadInt32();
				break;
			case 26u:
				blueCharInfo_.AddEntriesFrom(ref input, _repeated_blueCharInfo_codec);
				break;
			case 34u:
				redCharInfo_.AddEntriesFrom(ref input, _repeated_redCharInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
