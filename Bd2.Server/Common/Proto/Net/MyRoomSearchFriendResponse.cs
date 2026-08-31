using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MyRoomSearchFriendResponse : IMessage<MyRoomSearchFriendResponse>, IMessage, IEquatable<MyRoomSearchFriendResponse>, IDeepCloneable<MyRoomSearchFriendResponse>, IBufferMessage
{
	private static readonly MessageParser<MyRoomSearchFriendResponse> _parser = new MessageParser<MyRoomSearchFriendResponse>(() => new MyRoomSearchFriendResponse());

	private UnknownFieldSet _unknownFields;

	public const int RoomInfoFieldNumber = 1;

	private static readonly FieldCodec<MyRoomUserInfo> _repeated_roomInfo_codec = FieldCodec.ForMessage(10u, MyRoomUserInfo.Parser);

	private readonly RepeatedField<MyRoomUserInfo> roomInfo_ = new RepeatedField<MyRoomUserInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomSearchFriendResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MyRoomSearchFriendResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MyRoomUserInfo> RoomInfo => roomInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomSearchFriendResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomSearchFriendResponse(MyRoomSearchFriendResponse other)
		: this()
	{
		roomInfo_ = other.roomInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomSearchFriendResponse Clone()
	{
		return new MyRoomSearchFriendResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomSearchFriendResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MyRoomSearchFriendResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (roomInfo_.Equals(other.roomInfo_))
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
		num ^= roomInfo_.GetHashCode();
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
		roomInfo_.WriteTo(ref output, _repeated_roomInfo_codec);
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
		num += roomInfo_.CalculateSize(_repeated_roomInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MyRoomSearchFriendResponse other)
	{
		if (other != null)
		{
			roomInfo_.Add(other.roomInfo_);
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
				roomInfo_.AddEntriesFrom(ref input, _repeated_roomInfo_codec);
			}
		}
	}
}
