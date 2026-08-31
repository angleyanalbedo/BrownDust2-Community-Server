using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleDeckInfoResponse : IMessage<PvpBattleDeckInfoResponse>, IMessage, IEquatable<PvpBattleDeckInfoResponse>, IDeepCloneable<PvpBattleDeckInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleDeckInfoResponse> _parser = new MessageParser<PvpBattleDeckInfoResponse>(() => new PvpBattleDeckInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int AttackDeckInfoFieldNumber = 1;

	private static readonly FieldCodec<PvpBattleUserDeckInfo> _repeated_attackDeckInfo_codec = FieldCodec.ForMessage(10u, PvpBattleUserDeckInfo.Parser);

	private readonly RepeatedField<PvpBattleUserDeckInfo> attackDeckInfo_ = new RepeatedField<PvpBattleUserDeckInfo>();

	public const int DefenseDeckInfoFieldNumber = 2;

	private static readonly FieldCodec<PvpBattleUserDeckInfo> _repeated_defenseDeckInfo_codec = FieldCodec.ForMessage(18u, PvpBattleUserDeckInfo.Parser);

	private readonly RepeatedField<PvpBattleUserDeckInfo> defenseDeckInfo_ = new RepeatedField<PvpBattleUserDeckInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpBattleDeckInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleDeckInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PvpBattleUserDeckInfo> AttackDeckInfo => attackDeckInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PvpBattleUserDeckInfo> DefenseDeckInfo => defenseDeckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleDeckInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleDeckInfoResponse(PvpBattleDeckInfoResponse other)
		: this()
	{
		attackDeckInfo_ = other.attackDeckInfo_.Clone();
		defenseDeckInfo_ = other.defenseDeckInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleDeckInfoResponse Clone()
	{
		return new PvpBattleDeckInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleDeckInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PvpBattleDeckInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (attackDeckInfo_.Equals(other.attackDeckInfo_) && defenseDeckInfo_.Equals(other.defenseDeckInfo_))
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
		num ^= attackDeckInfo_.GetHashCode();
		num ^= defenseDeckInfo_.GetHashCode();
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
		attackDeckInfo_.WriteTo(ref output, _repeated_attackDeckInfo_codec);
		defenseDeckInfo_.WriteTo(ref output, _repeated_defenseDeckInfo_codec);
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
		num += attackDeckInfo_.CalculateSize(_repeated_attackDeckInfo_codec);
		num += defenseDeckInfo_.CalculateSize(_repeated_defenseDeckInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleDeckInfoResponse other)
	{
		if (other != null)
		{
			attackDeckInfo_.Add(other.attackDeckInfo_);
			defenseDeckInfo_.Add(other.defenseDeckInfo_);
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
			case 18u:
				defenseDeckInfo_.AddEntriesFrom(ref input, _repeated_defenseDeckInfo_codec);
				break;
			case 10u:
				attackDeckInfo_.AddEntriesFrom(ref input, _repeated_attackDeckInfo_codec);
				break;
			}
		}
	}
}
