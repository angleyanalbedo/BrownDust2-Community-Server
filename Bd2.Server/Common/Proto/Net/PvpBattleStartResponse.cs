using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleStartResponse : IMessage<PvpBattleStartResponse>, IMessage, IEquatable<PvpBattleStartResponse>, IDeepCloneable<PvpBattleStartResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleStartResponse> _parser = new MessageParser<PvpBattleStartResponse>(() => new PvpBattleStartResponse());

	private UnknownFieldSet _unknownFields;

	public const int BattleRandomSeedFieldNumber = 1;

	private int battleRandomSeed_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleStartResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleStartResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleStartResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleStartResponse(PvpBattleStartResponse other)
		: this()
	{
		battleRandomSeed_ = other.battleRandomSeed_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleStartResponse Clone()
	{
		return new PvpBattleStartResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleStartResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleStartResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleRandomSeed == other.BattleRandomSeed)
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
		if (BattleRandomSeed != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleRandomSeed);
		}
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PvpBattleStartResponse other)
	{
		if (other != null)
		{
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BattleRandomSeed = input.ReadInt32();
			}
		}
	}
}
