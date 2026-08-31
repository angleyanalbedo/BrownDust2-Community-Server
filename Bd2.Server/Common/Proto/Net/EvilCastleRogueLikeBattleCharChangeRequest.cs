using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeBattleCharChangeRequest : IMessage<EvilCastleRogueLikeBattleCharChangeRequest>, IMessage, IEquatable<EvilCastleRogueLikeBattleCharChangeRequest>, IDeepCloneable<EvilCastleRogueLikeBattleCharChangeRequest>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeBattleCharChangeRequest> _parser = new MessageParser<EvilCastleRogueLikeBattleCharChangeRequest>(() => new EvilCastleRogueLikeBattleCharChangeRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int DeckInCharIndexFieldNumber = 2;

	private long deckInCharIndex_;

	public const int DeckOutCharIndexFieldNumber = 3;

	private long deckOutCharIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeBattleCharChangeRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeBattleCharChangeRequestReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DeckInCharIndex
	{
		get
		{
			return deckInCharIndex_;
		}
		set
		{
			deckInCharIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DeckOutCharIndex
	{
		get
		{
			return deckOutCharIndex_;
		}
		set
		{
			deckOutCharIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeBattleCharChangeRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeBattleCharChangeRequest(EvilCastleRogueLikeBattleCharChangeRequest other)
		: this()
	{
		seq_ = other.seq_;
		deckInCharIndex_ = other.deckInCharIndex_;
		deckOutCharIndex_ = other.deckOutCharIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeBattleCharChangeRequest Clone()
	{
		return new EvilCastleRogueLikeBattleCharChangeRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeBattleCharChangeRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EvilCastleRogueLikeBattleCharChangeRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && DeckInCharIndex == other.DeckInCharIndex && DeckOutCharIndex == other.DeckOutCharIndex)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (DeckInCharIndex != 0L)
		{
			num ^= DeckInCharIndex.GetHashCode();
		}
		if (DeckOutCharIndex != 0L)
		{
			num ^= DeckOutCharIndex.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (DeckInCharIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(DeckInCharIndex);
		}
		if (DeckOutCharIndex != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(DeckOutCharIndex);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (DeckInCharIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DeckInCharIndex);
		}
		if (DeckOutCharIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DeckOutCharIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeBattleCharChangeRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.DeckInCharIndex != 0L)
			{
				DeckInCharIndex = other.DeckInCharIndex;
			}
			if (other.DeckOutCharIndex != 0L)
			{
				DeckOutCharIndex = other.DeckOutCharIndex;
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
				DeckOutCharIndex = input.ReadInt64();
				break;
			case 16u:
				DeckInCharIndex = input.ReadInt64();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
