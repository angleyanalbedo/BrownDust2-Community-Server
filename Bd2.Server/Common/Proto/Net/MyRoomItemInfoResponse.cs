using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MyRoomItemInfoResponse : IMessage<MyRoomItemInfoResponse>, IMessage, IEquatable<MyRoomItemInfoResponse>, IDeepCloneable<MyRoomItemInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MyRoomItemInfoResponse> _parser = new MessageParser<MyRoomItemInfoResponse>(() => new MyRoomItemInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int TrophyInfoFieldNumber = 1;

	private static readonly FieldCodec<MyRoomTrophyDBInfo> _repeated_trophyInfo_codec = FieldCodec.ForMessage(10u, MyRoomTrophyDBInfo.Parser);

	private readonly RepeatedField<MyRoomTrophyDBInfo> trophyInfo_ = new RepeatedField<MyRoomTrophyDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MyRoomItemInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MyRoomItemInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MyRoomTrophyDBInfo> TrophyInfo => trophyInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemInfoResponse(MyRoomItemInfoResponse other)
		: this()
	{
		trophyInfo_ = other.trophyInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemInfoResponse Clone()
	{
		return new MyRoomItemInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomItemInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MyRoomItemInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (trophyInfo_.Equals(other.trophyInfo_))
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
		num ^= trophyInfo_.GetHashCode();
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
		trophyInfo_.WriteTo(ref output, _repeated_trophyInfo_codec);
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
		num += trophyInfo_.CalculateSize(_repeated_trophyInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MyRoomItemInfoResponse other)
	{
		if (other != null)
		{
			trophyInfo_.Add(other.trophyInfo_);
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
				trophyInfo_.AddEntriesFrom(ref input, _repeated_trophyInfo_codec);
			}
		}
	}
}
