using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldDeckInfoResponse : IMessage<FieldDeckInfoResponse>, IMessage, IEquatable<FieldDeckInfoResponse>, IDeepCloneable<FieldDeckInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<FieldDeckInfoResponse> _parser = new MessageParser<FieldDeckInfoResponse>(() => new FieldDeckInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int FieldDeckInfoFieldNumber = 1;

	private static readonly FieldCodec<FieldDeckDBInfo> _repeated_fieldDeckInfo_codec = FieldCodec.ForMessage(10u, FieldDeckDBInfo.Parser);

	private readonly RepeatedField<FieldDeckDBInfo> fieldDeckInfo_ = new RepeatedField<FieldDeckDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FieldDeckInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldDeckInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FieldDeckDBInfo> FieldDeckInfo => fieldDeckInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldDeckInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldDeckInfoResponse(FieldDeckInfoResponse other)
		: this()
	{
		fieldDeckInfo_ = other.fieldDeckInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldDeckInfoResponse Clone()
	{
		return new FieldDeckInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldDeckInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldDeckInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (fieldDeckInfo_.Equals(other.fieldDeckInfo_))
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
		num ^= fieldDeckInfo_.GetHashCode();
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
		fieldDeckInfo_.WriteTo(ref output, _repeated_fieldDeckInfo_codec);
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
		num += fieldDeckInfo_.CalculateSize(_repeated_fieldDeckInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldDeckInfoResponse other)
	{
		if (other != null)
		{
			fieldDeckInfo_.Add(other.fieldDeckInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
				fieldDeckInfo_.AddEntriesFrom(ref input, _repeated_fieldDeckInfo_codec);
			}
		}
	}
}
