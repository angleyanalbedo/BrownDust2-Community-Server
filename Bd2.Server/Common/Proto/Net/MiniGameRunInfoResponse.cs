using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameRunInfoResponse : IMessage<MiniGameRunInfoResponse>, IMessage, IEquatable<MiniGameRunInfoResponse>, IDeepCloneable<MiniGameRunInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameRunInfoResponse> _parser = new MessageParser<MiniGameRunInfoResponse>(() => new MiniGameRunInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int InfoFieldNumber = 1;

	private static readonly FieldCodec<MiniGameDBInfo> _repeated_info_codec = FieldCodec.ForMessage(10u, MiniGameDBInfo.Parser);

	private readonly RepeatedField<MiniGameDBInfo> info_ = new RepeatedField<MiniGameDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameRunInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameRunInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MiniGameDBInfo> Info => info_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameRunInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameRunInfoResponse(MiniGameRunInfoResponse other)
		: this()
	{
		info_ = other.info_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameRunInfoResponse Clone()
	{
		return new MiniGameRunInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameRunInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameRunInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (info_.Equals(other.info_))
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
		num ^= info_.GetHashCode();
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
		info_.WriteTo(ref output, _repeated_info_codec);
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
		num += info_.CalculateSize(_repeated_info_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameRunInfoResponse other)
	{
		if (other != null)
		{
			info_.Add(other.info_);
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
				info_.AddEntriesFrom(ref input, _repeated_info_codec);
			}
		}
	}
}
