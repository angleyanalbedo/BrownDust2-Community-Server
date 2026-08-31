using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class DispatchInfoResponse : IMessage<DispatchInfoResponse>, IMessage, IEquatable<DispatchInfoResponse>, IDeepCloneable<DispatchInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<DispatchInfoResponse> _parser = new MessageParser<DispatchInfoResponse>(() => new DispatchInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int DispatchInfoFieldNumber = 1;

	private static readonly FieldCodec<DispatchDBInfo> _repeated_dispatchInfo_codec = FieldCodec.ForMessage(10u, DispatchDBInfo.Parser);

	private readonly RepeatedField<DispatchDBInfo> dispatchInfo_ = new RepeatedField<DispatchDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DispatchInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DispatchInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<DispatchDBInfo> DispatchInfo => dispatchInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DispatchInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DispatchInfoResponse(DispatchInfoResponse other)
		: this()
	{
		dispatchInfo_ = other.dispatchInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DispatchInfoResponse Clone()
	{
		return new DispatchInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as DispatchInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DispatchInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (dispatchInfo_.Equals(other.dispatchInfo_))
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
		num ^= dispatchInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		dispatchInfo_.WriteTo(ref output, _repeated_dispatchInfo_codec);
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
		num += dispatchInfo_.CalculateSize(_repeated_dispatchInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DispatchInfoResponse other)
	{
		if (other != null)
		{
			dispatchInfo_.Add(other.dispatchInfo_);
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
				dispatchInfo_.AddEntriesFrom(ref input, _repeated_dispatchInfo_codec);
			}
		}
	}
}
