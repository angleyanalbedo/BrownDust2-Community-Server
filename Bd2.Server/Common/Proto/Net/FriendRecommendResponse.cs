using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FriendRecommendResponse : IMessage<FriendRecommendResponse>, IMessage, IEquatable<FriendRecommendResponse>, IDeepCloneable<FriendRecommendResponse>, IBufferMessage
{
	private static readonly MessageParser<FriendRecommendResponse> _parser = new MessageParser<FriendRecommendResponse>(() => new FriendRecommendResponse());

	private UnknownFieldSet _unknownFields;

	public const int FriendInfoFieldNumber = 1;

	private static readonly FieldCodec<FriendDBInfo> _repeated_friendInfo_codec = FieldCodec.ForMessage(10u, FriendDBInfo.Parser);

	private readonly RepeatedField<FriendDBInfo> friendInfo_ = new RepeatedField<FriendDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendRecommendResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FriendRecommendResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FriendDBInfo> FriendInfo => friendInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendRecommendResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendRecommendResponse(FriendRecommendResponse other)
		: this()
	{
		friendInfo_ = other.friendInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendRecommendResponse Clone()
	{
		return new FriendRecommendResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FriendRecommendResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendRecommendResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (friendInfo_.Equals(other.friendInfo_))
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
		num ^= friendInfo_.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		friendInfo_.WriteTo(ref output, _repeated_friendInfo_codec);
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
		num += friendInfo_.CalculateSize(_repeated_friendInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendRecommendResponse other)
	{
		if (other != null)
		{
			friendInfo_.Add(other.friendInfo_);
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
				friendInfo_.AddEntriesFrom(ref input, _repeated_friendInfo_codec);
			}
		}
	}
}
