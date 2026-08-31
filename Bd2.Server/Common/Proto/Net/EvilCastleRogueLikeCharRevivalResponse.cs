using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeCharRevivalResponse : IMessage<EvilCastleRogueLikeCharRevivalResponse>, IMessage, IEquatable<EvilCastleRogueLikeCharRevivalResponse>, IDeepCloneable<EvilCastleRogueLikeCharRevivalResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeCharRevivalResponse> _parser = new MessageParser<EvilCastleRogueLikeCharRevivalResponse>(() => new EvilCastleRogueLikeCharRevivalResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(10u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeCharRevivalResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeCharRevivalResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeCharRevivalResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeCharRevivalResponse(EvilCastleRogueLikeCharRevivalResponse other)
		: this()
	{
		charInfo_ = other.charInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeCharRevivalResponse Clone()
	{
		return new EvilCastleRogueLikeCharRevivalResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeCharRevivalResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeCharRevivalResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charInfo_.Equals(other.charInfo_))
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
		num ^= charInfo_.GetHashCode();
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
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
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
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeCharRevivalResponse other)
	{
		if (other != null)
		{
			charInfo_.Add(other.charInfo_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
			}
		}
	}
}
