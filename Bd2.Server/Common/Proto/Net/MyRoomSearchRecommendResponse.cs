using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MyRoomSearchRecommendResponse : IMessage<MyRoomSearchRecommendResponse>, IMessage, IEquatable<MyRoomSearchRecommendResponse>, IDeepCloneable<MyRoomSearchRecommendResponse>, IBufferMessage
{
	private static readonly MessageParser<MyRoomSearchRecommendResponse> _parser = new MessageParser<MyRoomSearchRecommendResponse>(() => new MyRoomSearchRecommendResponse());

	private UnknownFieldSet _unknownFields;

	public const int RoomInfoFieldNumber = 1;

	private static readonly FieldCodec<MyRoomUserInfo> _repeated_roomInfo_codec = FieldCodec.ForMessage(10u, MyRoomUserInfo.Parser);

	private readonly RepeatedField<MyRoomUserInfo> roomInfo_ = new RepeatedField<MyRoomUserInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomSearchRecommendResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MyRoomSearchRecommendResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MyRoomUserInfo> RoomInfo => roomInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomSearchRecommendResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomSearchRecommendResponse(MyRoomSearchRecommendResponse other)
		: this()
	{
		roomInfo_ = other.roomInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomSearchRecommendResponse Clone()
	{
		return new MyRoomSearchRecommendResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomSearchRecommendResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MyRoomSearchRecommendResponse other)
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public void MergeFrom(MyRoomSearchRecommendResponse other)
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
