using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharAwakeInfoResponse : IMessage<CharAwakeInfoResponse>, IMessage, IEquatable<CharAwakeInfoResponse>, IDeepCloneable<CharAwakeInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<CharAwakeInfoResponse> _parser = new MessageParser<CharAwakeInfoResponse>(() => new CharAwakeInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharAwakeInfoFieldNumber = 1;

	private static readonly FieldCodec<CharAwakeDBInfo> _repeated_charAwakeInfo_codec = FieldCodec.ForMessage(10u, CharAwakeDBInfo.Parser);

	private readonly RepeatedField<CharAwakeDBInfo> charAwakeInfo_ = new RepeatedField<CharAwakeDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharAwakeInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharAwakeInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharAwakeDBInfo> CharAwakeInfo => charAwakeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharAwakeInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharAwakeInfoResponse(CharAwakeInfoResponse other)
		: this()
	{
		charAwakeInfo_ = other.charAwakeInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharAwakeInfoResponse Clone()
	{
		return new CharAwakeInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CharAwakeInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharAwakeInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charAwakeInfo_.Equals(other.charAwakeInfo_))
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
		num ^= charAwakeInfo_.GetHashCode();
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
		charAwakeInfo_.WriteTo(ref output, _repeated_charAwakeInfo_codec);
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
		num += charAwakeInfo_.CalculateSize(_repeated_charAwakeInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharAwakeInfoResponse other)
	{
		if (other != null)
		{
			charAwakeInfo_.Add(other.charAwakeInfo_);
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
				charAwakeInfo_.AddEntriesFrom(ref input, _repeated_charAwakeInfo_codec);
			}
		}
	}
}
