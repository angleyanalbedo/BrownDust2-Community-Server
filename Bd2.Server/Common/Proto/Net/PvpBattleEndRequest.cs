using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleEndRequest : IMessage<PvpBattleEndRequest>, IMessage, IEquatable<PvpBattleEndRequest>, IDeepCloneable<PvpBattleEndRequest>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleEndRequest> _parser = new MessageParser<PvpBattleEndRequest>(() => new PvpBattleEndRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int BattleResultFieldNumber = 2;

	private int battleResult_;

	public const int EndInvenIndexFieldNumber = 3;

	private static readonly FieldCodec<long> _repeated_endInvenIndex_codec = FieldCodec.ForInt64(26u);

	private readonly RepeatedField<long> endInvenIndex_ = new RepeatedField<long>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpBattleEndRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleEndRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleResult
	{
		get
		{
			return battleResult_;
		}
		set
		{
			battleResult_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> EndInvenIndex => endInvenIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleEndRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleEndRequest(PvpBattleEndRequest other)
		: this()
	{
		seq_ = other.seq_;
		battleResult_ = other.battleResult_;
		endInvenIndex_ = other.endInvenIndex_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleEndRequest Clone()
	{
		return new PvpBattleEndRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleEndRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleEndRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && BattleResult == other.BattleResult && endInvenIndex_.Equals(other.endInvenIndex_))
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
		if (BattleResult != 0)
		{
			num ^= BattleResult.GetHashCode();
		}
		num ^= endInvenIndex_.GetHashCode();
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
		if (BattleResult != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleResult);
		}
		endInvenIndex_.WriteTo(ref output, _repeated_endInvenIndex_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (BattleResult != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleResult);
		}
		num += endInvenIndex_.CalculateSize(_repeated_endInvenIndex_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleEndRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.BattleResult != 0)
			{
				BattleResult = other.BattleResult;
			}
			endInvenIndex_.Add(other.endInvenIndex_);
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
				BattleResult = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				endInvenIndex_.AddEntriesFrom(ref input, _repeated_endInvenIndex_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
