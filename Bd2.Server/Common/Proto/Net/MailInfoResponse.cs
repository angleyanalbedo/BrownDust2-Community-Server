using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MailInfoResponse : IMessage<MailInfoResponse>, IMessage, IEquatable<MailInfoResponse>, IDeepCloneable<MailInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MailInfoResponse> _parser = new MessageParser<MailInfoResponse>(() => new MailInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MailInfoFieldNumber = 1;

	private static readonly FieldCodec<MailDBInfo> _repeated_mailInfo_codec = FieldCodec.ForMessage(10u, MailDBInfo.Parser);

	private readonly RepeatedField<MailDBInfo> mailInfo_ = new RepeatedField<MailDBInfo>();

	public const int TotalCountFieldNumber = 2;

	private int totalCount_;

	public const int MaxInvenIndexFieldNumber = 3;

	private long maxInvenIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MailInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MailInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MailDBInfo> MailInfo => mailInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TotalCount
	{
		get
		{
			return totalCount_;
		}
		set
		{
			totalCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MaxInvenIndex
	{
		get
		{
			return maxInvenIndex_;
		}
		set
		{
			maxInvenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MailInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MailInfoResponse(MailInfoResponse other)
		: this()
	{
		mailInfo_ = other.mailInfo_.Clone();
		totalCount_ = other.totalCount_;
		maxInvenIndex_ = other.maxInvenIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MailInfoResponse Clone()
	{
		return new MailInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MailInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MailInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (mailInfo_.Equals(other.mailInfo_) && TotalCount == other.TotalCount && MaxInvenIndex == other.MaxInvenIndex)
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
		num ^= mailInfo_.GetHashCode();
		if (TotalCount != 0)
		{
			num ^= TotalCount.GetHashCode();
		}
		if (MaxInvenIndex != 0L)
		{
			num ^= MaxInvenIndex.GetHashCode();
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
		mailInfo_.WriteTo(ref output, _repeated_mailInfo_codec);
		if (TotalCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TotalCount);
		}
		if (MaxInvenIndex != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(MaxInvenIndex);
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
		num += mailInfo_.CalculateSize(_repeated_mailInfo_codec);
		if (TotalCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalCount);
		}
		if (MaxInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(MaxInvenIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MailInfoResponse other)
	{
		if (other != null)
		{
			mailInfo_.Add(other.mailInfo_);
			if (other.TotalCount != 0)
			{
				TotalCount = other.TotalCount;
			}
			if (other.MaxInvenIndex != 0L)
			{
				MaxInvenIndex = other.MaxInvenIndex;
			}
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				MaxInvenIndex = input.ReadInt64();
				break;
			case 16u:
				TotalCount = input.ReadInt32();
				break;
			case 10u:
				mailInfo_.AddEntriesFrom(ref input, _repeated_mailInfo_codec);
				break;
			}
		}
	}
}
