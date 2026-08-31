using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FriendAcceptResponse : IMessage<FriendAcceptResponse>, IMessage, IEquatable<FriendAcceptResponse>, IDeepCloneable<FriendAcceptResponse>, IBufferMessage
{
	private static readonly MessageParser<FriendAcceptResponse> _parser = new MessageParser<FriendAcceptResponse>(() => new FriendAcceptResponse());

	private UnknownFieldSet _unknownFields;

	public const int FriendInfoFieldNumber = 1;

	private FriendDBInfo friendInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendAcceptResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FriendAcceptResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendAcceptResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendAcceptResponse(FriendAcceptResponse other)
		: this()
	{
		friendInfo_ = ((other.friendInfo_ != null) ? other.friendInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAcceptResponse Clone()
	{
		return new FriendAcceptResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FriendAcceptResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendAcceptResponse other)
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FriendAcceptResponse other)
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
			if (friendInfo_ == null)
			{
				FriendInfo = new FriendDBInfo();
			}
			input.ReadMessage(FriendInfo);
		}
	}
}
