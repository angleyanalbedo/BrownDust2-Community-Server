using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleResetResponse : IMessage<PvpBattleResetResponse>, IMessage, IEquatable<PvpBattleResetResponse>, IDeepCloneable<PvpBattleResetResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleResetResponse> _parser = new MessageParser<PvpBattleResetResponse>(() => new PvpBattleResetResponse());

	private UnknownFieldSet _unknownFields;

	public const int DeckSeasonAttackResetDateFieldNumber = 1;

	private long deckSeasonAttackResetDate_;

	public const int DeckSeasonDefenseResetDateFieldNumber = 2;

	private long deckSeasonDefenseResetDate_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleResetResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleResetResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DeckSeasonAttackResetDate
	{
		get
		{
			return deckSeasonAttackResetDate_;
		}
		set
		{
			deckSeasonAttackResetDate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long DeckSeasonDefenseResetDate
	{
		get
		{
			return deckSeasonDefenseResetDate_;
		}
		set
		{
			deckSeasonDefenseResetDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleResetResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleResetResponse(PvpBattleResetResponse other)
		: this()
	{
		deckSeasonAttackResetDate_ = other.deckSeasonAttackResetDate_;
		deckSeasonDefenseResetDate_ = other.deckSeasonDefenseResetDate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleResetResponse Clone()
	{
		return new PvpBattleResetResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleResetResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleResetResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DeckSeasonAttackResetDate == other.DeckSeasonAttackResetDate && DeckSeasonDefenseResetDate == other.DeckSeasonDefenseResetDate)
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
		if (DeckSeasonAttackResetDate != 0L)
		{
			num ^= DeckSeasonAttackResetDate.GetHashCode();
		}
		if (DeckSeasonDefenseResetDate != 0L)
		{
			num ^= DeckSeasonDefenseResetDate.GetHashCode();
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
		if (DeckSeasonAttackResetDate != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(DeckSeasonAttackResetDate);
		}
		if (DeckSeasonDefenseResetDate != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(DeckSeasonDefenseResetDate);
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
		if (DeckSeasonAttackResetDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DeckSeasonAttackResetDate);
		}
		if (DeckSeasonDefenseResetDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DeckSeasonDefenseResetDate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleResetResponse other)
	{
		if (other != null)
		{
			if (other.DeckSeasonAttackResetDate != 0L)
			{
				DeckSeasonAttackResetDate = other.DeckSeasonAttackResetDate;
			}
			if (other.DeckSeasonDefenseResetDate != 0L)
			{
				DeckSeasonDefenseResetDate = other.DeckSeasonDefenseResetDate;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				DeckSeasonDefenseResetDate = input.ReadInt64();
				break;
			case 8u:
				DeckSeasonAttackResetDate = input.ReadInt64();
				break;
			}
		}
	}
}
