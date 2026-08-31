using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharAllRevivalResponse : IMessage<CharAllRevivalResponse>, IMessage, IEquatable<CharAllRevivalResponse>, IDeepCloneable<CharAllRevivalResponse>, IBufferMessage
{
	private static readonly MessageParser<CharAllRevivalResponse> _parser = new MessageParser<CharAllRevivalResponse>(() => new CharAllRevivalResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(10u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharAllRevivalResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharAllRevivalResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharAllRevivalResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharAllRevivalResponse(CharAllRevivalResponse other)
		: this()
	{
		charInfo_ = other.charInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharAllRevivalResponse Clone()
	{
		return new CharAllRevivalResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharAllRevivalResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharAllRevivalResponse other)
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
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
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
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharAllRevivalResponse other)
	{
		if (other != null)
		{
			charInfo_.Add(other.charInfo_);
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
