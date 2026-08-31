using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class NoticeInfoResponse : IMessage<NoticeInfoResponse>, IMessage, IEquatable<NoticeInfoResponse>, IDeepCloneable<NoticeInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<NoticeInfoResponse> _parser = new MessageParser<NoticeInfoResponse>(() => new NoticeInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int NoticeInfoFieldNumber = 1;

	private static readonly FieldCodec<NoticeDBInfo> _repeated_noticeInfo_codec = FieldCodec.ForMessage(10u, NoticeDBInfo.Parser);

	private readonly RepeatedField<NoticeDBInfo> noticeInfo_ = new RepeatedField<NoticeDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NoticeInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NoticeInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NoticeDBInfo> NoticeInfo => noticeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NoticeInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NoticeInfoResponse(NoticeInfoResponse other)
		: this()
	{
		noticeInfo_ = other.noticeInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NoticeInfoResponse Clone()
	{
		return new NoticeInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as NoticeInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(NoticeInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (noticeInfo_.Equals(other.noticeInfo_))
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
		num ^= noticeInfo_.GetHashCode();
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
		noticeInfo_.WriteTo(ref output, _repeated_noticeInfo_codec);
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
		num += noticeInfo_.CalculateSize(_repeated_noticeInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(NoticeInfoResponse other)
	{
		if (other != null)
		{
			noticeInfo_.Add(other.noticeInfo_);
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
				noticeInfo_.AddEntriesFrom(ref input, _repeated_noticeInfo_codec);
			}
		}
	}
}
