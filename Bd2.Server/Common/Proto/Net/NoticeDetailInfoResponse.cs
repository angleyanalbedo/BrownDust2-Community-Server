using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class NoticeDetailInfoResponse : IMessage<NoticeDetailInfoResponse>, IMessage, IEquatable<NoticeDetailInfoResponse>, IDeepCloneable<NoticeDetailInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<NoticeDetailInfoResponse> _parser = new MessageParser<NoticeDetailInfoResponse>(() => new NoticeDetailInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int NoticeInfoFieldNumber = 1;

	private NoticeDBInfo noticeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<NoticeDetailInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => NoticeDetailInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NoticeDBInfo NoticeInfo
	{
		get
		{
			return noticeInfo_;
		}
		set
		{
			noticeInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NoticeDetailInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NoticeDetailInfoResponse(NoticeDetailInfoResponse other)
		: this()
	{
		noticeInfo_ = ((other.noticeInfo_ != null) ? other.noticeInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NoticeDetailInfoResponse Clone()
	{
		return new NoticeDetailInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NoticeDetailInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(NoticeDetailInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(NoticeInfo, other.NoticeInfo))
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
		if (noticeInfo_ != null)
		{
			num ^= NoticeInfo.GetHashCode();
		}
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
		if (noticeInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(NoticeInfo);
		}
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
		if (noticeInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NoticeInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NoticeDetailInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.noticeInfo_ != null)
		{
			if (noticeInfo_ == null)
			{
				NoticeInfo = new NoticeDBInfo();
			}
			NoticeInfo.MergeFrom(other.NoticeInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				continue;
			}
			if (noticeInfo_ == null)
			{
				NoticeInfo = new NoticeDBInfo();
			}
			input.ReadMessage(NoticeInfo);
		}
	}
}
