using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FriendInfoListResponse : IMessage<FriendInfoListResponse>, IMessage, IEquatable<FriendInfoListResponse>, IDeepCloneable<FriendInfoListResponse>, IBufferMessage
{
	private static readonly MessageParser<FriendInfoListResponse> _parser = new MessageParser<FriendInfoListResponse>(() => new FriendInfoListResponse());

	private UnknownFieldSet _unknownFields;

	public const int FriendInfoFieldNumber = 1;

	private static readonly FieldCodec<FriendDBInfo> _repeated_friendInfo_codec = FieldCodec.ForMessage(10u, FriendDBInfo.Parser);

	private readonly RepeatedField<FriendDBInfo> friendInfo_ = new RepeatedField<FriendDBInfo>();

	public const int FriendRecvFieldNumber = 2;

	private static readonly FieldCodec<FriendDBInfo> _repeated_friendRecv_codec = FieldCodec.ForMessage(18u, FriendDBInfo.Parser);

	private readonly RepeatedField<FriendDBInfo> friendRecv_ = new RepeatedField<FriendDBInfo>();

	public const int FriendSendFieldNumber = 3;

	private static readonly FieldCodec<FriendDBInfo> _repeated_friendSend_codec = FieldCodec.ForMessage(26u, FriendDBInfo.Parser);

	private readonly RepeatedField<FriendDBInfo> friendSend_ = new RepeatedField<FriendDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendInfoListResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FriendInfoListResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FriendDBInfo> FriendInfo => friendInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FriendDBInfo> FriendRecv => friendRecv_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FriendDBInfo> FriendSend => friendSend_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendInfoListResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendInfoListResponse(FriendInfoListResponse other)
		: this()
	{
		friendInfo_ = other.friendInfo_.Clone();
		friendRecv_ = other.friendRecv_.Clone();
		friendSend_ = other.friendSend_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendInfoListResponse Clone()
	{
		return new FriendInfoListResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FriendInfoListResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendInfoListResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (friendInfo_.Equals(other.friendInfo_) && friendRecv_.Equals(other.friendRecv_) && friendSend_.Equals(other.friendSend_))
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
		num ^= friendRecv_.GetHashCode();
		num ^= friendSend_.GetHashCode();
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
		friendInfo_.WriteTo(ref output, _repeated_friendInfo_codec);
		friendRecv_.WriteTo(ref output, _repeated_friendRecv_codec);
		friendSend_.WriteTo(ref output, _repeated_friendSend_codec);
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
		num += friendRecv_.CalculateSize(_repeated_friendRecv_codec);
		num += friendSend_.CalculateSize(_repeated_friendSend_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendInfoListResponse other)
	{
		if (other != null)
		{
			friendInfo_.Add(other.friendInfo_);
			friendRecv_.Add(other.friendRecv_);
			friendSend_.Add(other.friendSend_);
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
			case 26u:
				friendSend_.AddEntriesFrom(ref input, _repeated_friendSend_codec);
				break;
			case 18u:
				friendRecv_.AddEntriesFrom(ref input, _repeated_friendRecv_codec);
				break;
			case 10u:
				friendInfo_.AddEntriesFrom(ref input, _repeated_friendInfo_codec);
				break;
			}
		}
	}
}
