using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharPartnerInfoResponse : IMessage<CharPartnerInfoResponse>, IMessage, IEquatable<CharPartnerInfoResponse>, IDeepCloneable<CharPartnerInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<CharPartnerInfoResponse> _parser = new MessageParser<CharPartnerInfoResponse>(() => new CharPartnerInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharPartnerInfoFieldNumber = 1;

	private static readonly FieldCodec<CharPartnerDBInfo> _repeated_charPartnerInfo_codec = FieldCodec.ForMessage(10u, CharPartnerDBInfo.Parser);

	private readonly RepeatedField<CharPartnerDBInfo> charPartnerInfo_ = new RepeatedField<CharPartnerDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharPartnerInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CharPartnerInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharPartnerDBInfo> CharPartnerInfo => charPartnerInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharPartnerInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharPartnerInfoResponse(CharPartnerInfoResponse other)
		: this()
	{
		charPartnerInfo_ = other.charPartnerInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharPartnerInfoResponse Clone()
	{
		return new CharPartnerInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CharPartnerInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharPartnerInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charPartnerInfo_.Equals(other.charPartnerInfo_))
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
		num ^= charPartnerInfo_.GetHashCode();
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
		charPartnerInfo_.WriteTo(ref output, _repeated_charPartnerInfo_codec);
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
		num += charPartnerInfo_.CalculateSize(_repeated_charPartnerInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharPartnerInfoResponse other)
	{
		if (other != null)
		{
			charPartnerInfo_.Add(other.charPartnerInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
				charPartnerInfo_.AddEntriesFrom(ref input, _repeated_charPartnerInfo_codec);
			}
		}
	}
}
