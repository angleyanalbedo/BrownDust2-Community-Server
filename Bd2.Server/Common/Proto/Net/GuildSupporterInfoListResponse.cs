using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildSupporterInfoListResponse : IMessage<GuildSupporterInfoListResponse>, IMessage, IEquatable<GuildSupporterInfoListResponse>, IDeepCloneable<GuildSupporterInfoListResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildSupporterInfoListResponse> _parser = new MessageParser<GuildSupporterInfoListResponse>(() => new GuildSupporterInfoListResponse());

	private UnknownFieldSet _unknownFields;

	public const int SupporterInfoFieldNumber = 1;

	private static readonly FieldCodec<GuildSupporterInfo> _repeated_supporterInfo_codec = FieldCodec.ForMessage(10u, GuildSupporterInfo.Parser);

	private readonly RepeatedField<GuildSupporterInfo> supporterInfo_ = new RepeatedField<GuildSupporterInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildSupporterInfoListResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildSupporterInfoListResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GuildSupporterInfo> SupporterInfo => supporterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfoListResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfoListResponse(GuildSupporterInfoListResponse other)
		: this()
	{
		supporterInfo_ = other.supporterInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildSupporterInfoListResponse Clone()
	{
		return new GuildSupporterInfoListResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildSupporterInfoListResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildSupporterInfoListResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (supporterInfo_.Equals(other.supporterInfo_))
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
		num ^= supporterInfo_.GetHashCode();
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
		supporterInfo_.WriteTo(ref output, _repeated_supporterInfo_codec);
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
		num += supporterInfo_.CalculateSize(_repeated_supporterInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildSupporterInfoListResponse other)
	{
		if (other != null)
		{
			supporterInfo_.Add(other.supporterInfo_);
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
				supporterInfo_.AddEntriesFrom(ref input, _repeated_supporterInfo_codec);
			}
		}
	}
}
