using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleStartResponse : IMessage<BattleStartResponse>, IMessage, IEquatable<BattleStartResponse>, IDeepCloneable<BattleStartResponse>, IBufferMessage
{
	private static readonly MessageParser<BattleStartResponse> _parser = new MessageParser<BattleStartResponse>(() => new BattleStartResponse());

	private UnknownFieldSet _unknownFields;

	public const int RedCharInfoFieldNumber = 1;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_redCharInfo_codec = FieldCodec.ForMessage(10u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> redCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int BlueCharInfoFieldNumber = 2;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_blueCharInfo_codec = FieldCodec.ForMessage(18u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> blueCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int BattleRandomSeedFieldNumber = 3;

	private int battleRandomSeed_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleStartResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleStartResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> RedCharInfo => redCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> BlueCharInfo => blueCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleRandomSeed
	{
		get
		{
			return battleRandomSeed_;
		}
		set
		{
			battleRandomSeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStartResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStartResponse(BattleStartResponse other)
		: this()
	{
		redCharInfo_ = other.redCharInfo_.Clone();
		blueCharInfo_ = other.blueCharInfo_.Clone();
		battleRandomSeed_ = other.battleRandomSeed_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStartResponse Clone()
	{
		return new BattleStartResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as BattleStartResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleStartResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (redCharInfo_.Equals(other.redCharInfo_) && blueCharInfo_.Equals(other.blueCharInfo_) && BattleRandomSeed == other.BattleRandomSeed)
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
		num ^= redCharInfo_.GetHashCode();
		num ^= blueCharInfo_.GetHashCode();
		if (BattleRandomSeed != 0)
		{
			num ^= BattleRandomSeed.GetHashCode();
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
		redCharInfo_.WriteTo(ref output, _repeated_redCharInfo_codec);
		blueCharInfo_.WriteTo(ref output, _repeated_blueCharInfo_codec);
		if (BattleRandomSeed != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleRandomSeed);
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
		num += redCharInfo_.CalculateSize(_repeated_redCharInfo_codec);
		num += blueCharInfo_.CalculateSize(_repeated_blueCharInfo_codec);
		if (BattleRandomSeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleRandomSeed);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleStartResponse other)
	{
		if (other != null)
		{
			redCharInfo_.Add(other.redCharInfo_);
			blueCharInfo_.Add(other.blueCharInfo_);
			if (other.BattleRandomSeed != 0)
			{
				BattleRandomSeed = other.BattleRandomSeed;
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
				BattleRandomSeed = input.ReadInt32();
				break;
			case 18u:
				blueCharInfo_.AddEntriesFrom(ref input, _repeated_blueCharInfo_codec);
				break;
			case 10u:
				redCharInfo_.AddEntriesFrom(ref input, _repeated_redCharInfo_codec);
				break;
			}
		}
	}
}
