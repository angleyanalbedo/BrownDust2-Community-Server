using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FriendSearchResponse : IMessage<FriendSearchResponse>, IMessage, IEquatable<FriendSearchResponse>, IDeepCloneable<FriendSearchResponse>, IBufferMessage
{
	private static readonly MessageParser<FriendSearchResponse> _parser = new MessageParser<FriendSearchResponse>(() => new FriendSearchResponse());

	private UnknownFieldSet _unknownFields;

	public const int FriendInfoFieldNumber = 1;

	private FriendDBInfo friendInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendSearchResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FriendSearchResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendDBInfo FriendInfo
	{
		get
		{
			return friendInfo_;
		}
		set
		{
			friendInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSearchResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSearchResponse(FriendSearchResponse other)
		: this()
	{
		friendInfo_ = ((other.friendInfo_ != null) ? other.friendInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendSearchResponse Clone()
	{
		return new FriendSearchResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FriendSearchResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendSearchResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(FriendInfo, other.FriendInfo))
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
		if (friendInfo_ != null)
		{
			num ^= FriendInfo.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (friendInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FriendInfo);
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
		if (friendInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FriendInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendSearchResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.friendInfo_ != null)
		{
			if (friendInfo_ == null)
			{
				FriendInfo = new FriendDBInfo();
			}
			FriendInfo.MergeFrom(other.FriendInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				continue;
			}
			if (friendInfo_ == null)
			{
				FriendInfo = new FriendDBInfo();
			}
			input.ReadMessage(FriendInfo);
		}
	}
}
