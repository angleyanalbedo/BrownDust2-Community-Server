using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleTowerInfoResponse : IMessage<EvilCastleTowerInfoResponse>, IMessage, IEquatable<EvilCastleTowerInfoResponse>, IDeepCloneable<EvilCastleTowerInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleTowerInfoResponse> _parser = new MessageParser<EvilCastleTowerInfoResponse>(() => new EvilCastleTowerInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int InfoFieldNumber = 1;

	private static readonly FieldCodec<EvilCastleTowerDBInfo> _repeated_info_codec = FieldCodec.ForMessage(10u, EvilCastleTowerDBInfo.Parser);

	private readonly RepeatedField<EvilCastleTowerDBInfo> info_ = new RepeatedField<EvilCastleTowerDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleTowerInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleTowerInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EvilCastleTowerDBInfo> Info => info_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTowerInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTowerInfoResponse(EvilCastleTowerInfoResponse other)
		: this()
	{
		info_ = other.info_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTowerInfoResponse Clone()
	{
		return new EvilCastleTowerInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleTowerInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EvilCastleTowerInfoResponse other)
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
		info_.WriteTo(ref output, _repeated_info_codec);
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
		num += info_.CalculateSize(_repeated_info_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleTowerInfoResponse other)
	{
		if (other != null)
		{
			info_.Add(other.info_);
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
				info_.AddEntriesFrom(ref input, _repeated_info_codec);
			}
		}
	}
}
