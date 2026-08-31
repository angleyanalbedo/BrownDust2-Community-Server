using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CostumeUseRequest : IMessage<CostumeUseRequest>, IMessage, IEquatable<CostumeUseRequest>, IDeepCloneable<CostumeUseRequest>, IBufferMessage
{
	private static readonly MessageParser<CostumeUseRequest> _parser = new MessageParser<CostumeUseRequest>(() => new CostumeUseRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int CostumeUseInfoFieldNumber = 2;

	private static readonly FieldCodec<CostumeUseInfo> _repeated_costumeUseInfo_codec = FieldCodec.ForMessage(18u, Bd2.Server.Common.Proto.Net.CostumeUseInfo.Parser);

	private readonly RepeatedField<CostumeUseInfo> costumeUseInfo_ = new RepeatedField<CostumeUseInfo>();

	public const int BattleModeFieldNumber = 3;

	private int battleMode_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CostumeUseRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CostumeUseRequestReflection.Descriptor.MessageTypes[1];

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
	public RepeatedField<CostumeUseInfo> CostumeUseInfo => costumeUseInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleMode
	{
		get
		{
			return battleMode_;
		}
		set
		{
			battleMode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeUseRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeUseRequest(CostumeUseRequest other)
		: this()
	{
		seq_ = other.seq_;
		costumeUseInfo_ = other.costumeUseInfo_.Clone();
		battleMode_ = other.battleMode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumeUseRequest Clone()
	{
		return new CostumeUseRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeUseRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumeUseRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && costumeUseInfo_.Equals(other.costumeUseInfo_) && BattleMode == other.BattleMode)
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
		num ^= costumeUseInfo_.GetHashCode();
		if (BattleMode != 0)
		{
			num ^= BattleMode.GetHashCode();
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		costumeUseInfo_.WriteTo(ref output, _repeated_costumeUseInfo_codec);
		if (BattleMode != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleMode);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		num += costumeUseInfo_.CalculateSize(_repeated_costumeUseInfo_codec);
		if (BattleMode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleMode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CostumeUseRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			costumeUseInfo_.Add(other.costumeUseInfo_);
			if (other.BattleMode != 0)
			{
				BattleMode = other.BattleMode;
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
				BattleMode = input.ReadInt32();
				break;
			case 18u:
				costumeUseInfo_.AddEntriesFrom(ref input, _repeated_costumeUseInfo_codec);
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
