using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldTrapInfoResponse : IMessage<FieldTrapInfoResponse>, IMessage, IEquatable<FieldTrapInfoResponse>, IDeepCloneable<FieldTrapInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<FieldTrapInfoResponse> _parser = new MessageParser<FieldTrapInfoResponse>(() => new FieldTrapInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int FieldTrapDbInfoFieldNumber = 1;

	private static readonly FieldCodec<FieldTrapDBInfo> _repeated_fieldTrapDbInfo_codec = FieldCodec.ForMessage(10u, FieldTrapDBInfo.Parser);

	private readonly RepeatedField<FieldTrapDBInfo> fieldTrapDbInfo_ = new RepeatedField<FieldTrapDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FieldTrapInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldTrapInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FieldTrapDBInfo> FieldTrapDbInfo => fieldTrapDbInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldTrapInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldTrapInfoResponse(FieldTrapInfoResponse other)
		: this()
	{
		fieldTrapDbInfo_ = other.fieldTrapDbInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldTrapInfoResponse Clone()
	{
		return new FieldTrapInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldTrapInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldTrapInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (fieldTrapDbInfo_.Equals(other.fieldTrapDbInfo_))
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
		num ^= fieldTrapDbInfo_.GetHashCode();
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
		fieldTrapDbInfo_.WriteTo(ref output, _repeated_fieldTrapDbInfo_codec);
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
		num += fieldTrapDbInfo_.CalculateSize(_repeated_fieldTrapDbInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldTrapInfoResponse other)
	{
		if (other != null)
		{
			fieldTrapDbInfo_.Add(other.fieldTrapDbInfo_);
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
				fieldTrapDbInfo_.AddEntriesFrom(ref input, _repeated_fieldTrapDbInfo_codec);
			}
		}
	}
}
