using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CommunityRewardInfoResponse : IMessage<CommunityRewardInfoResponse>, IMessage, IEquatable<CommunityRewardInfoResponse>, IDeepCloneable<CommunityRewardInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<CommunityRewardInfoResponse> _parser = new MessageParser<CommunityRewardInfoResponse>(() => new CommunityRewardInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int CommunityRewardInfoFieldNumber = 1;

	private static readonly FieldCodec<CommunityRewardDBInfo> _repeated_communityRewardInfo_codec = FieldCodec.ForMessage(10u, CommunityRewardDBInfo.Parser);

	private readonly RepeatedField<CommunityRewardDBInfo> communityRewardInfo_ = new RepeatedField<CommunityRewardDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CommunityRewardInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CommunityRewardInfoResponseReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CommunityRewardDBInfo> CommunityRewardInfo => communityRewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommunityRewardInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CommunityRewardInfoResponse(CommunityRewardInfoResponse other)
		: this()
	{
		communityRewardInfo_ = other.communityRewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommunityRewardInfoResponse Clone()
	{
		return new CommunityRewardInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CommunityRewardInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CommunityRewardInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (communityRewardInfo_.Equals(other.communityRewardInfo_))
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
		num ^= communityRewardInfo_.GetHashCode();
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
		communityRewardInfo_.WriteTo(ref output, _repeated_communityRewardInfo_codec);
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
		num += communityRewardInfo_.CalculateSize(_repeated_communityRewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CommunityRewardInfoResponse other)
	{
		if (other != null)
		{
			communityRewardInfo_.Add(other.communityRewardInfo_);
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
				communityRewardInfo_.AddEntriesFrom(ref input, _repeated_communityRewardInfo_codec);
			}
		}
	}
}
