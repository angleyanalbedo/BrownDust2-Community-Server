using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildSupporterInfoResponse : IMessage<GuildSupporterInfoResponse>, IMessage, IEquatable<GuildSupporterInfoResponse>, IDeepCloneable<GuildSupporterInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildSupporterInfoResponse> _parser = new MessageParser<GuildSupporterInfoResponse>(() => new GuildSupporterInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int SupporterInfoFieldNumber = 1;

	private GuildSupporterInfo supporterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildSupporterInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildSupporterInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfo SupporterInfo
	{
		get
		{
			return supporterInfo_;
		}
		set
		{
			supporterInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildSupporterInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildSupporterInfoResponse(GuildSupporterInfoResponse other)
		: this()
	{
		supporterInfo_ = ((other.supporterInfo_ != null) ? other.supporterInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfoResponse Clone()
	{
		return new GuildSupporterInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildSupporterInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildSupporterInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(SupporterInfo, other.SupporterInfo))
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
		if (supporterInfo_ != null)
		{
			num ^= SupporterInfo.GetHashCode();
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
		if (supporterInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(SupporterInfo);
		}
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
		if (supporterInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SupporterInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildSupporterInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.supporterInfo_ != null)
		{
			if (supporterInfo_ == null)
			{
				SupporterInfo = new GuildSupporterInfo();
			}
			SupporterInfo.MergeFrom(other.SupporterInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				continue;
			}
			if (supporterInfo_ == null)
			{
				SupporterInfo = new GuildSupporterInfo();
			}
			input.ReadMessage(SupporterInfo);
		}
	}
}
