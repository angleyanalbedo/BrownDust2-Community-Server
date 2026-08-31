using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MyRoomShopInfoResponse : IMessage<MyRoomShopInfoResponse>, IMessage, IEquatable<MyRoomShopInfoResponse>, IDeepCloneable<MyRoomShopInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MyRoomShopInfoResponse> _parser = new MessageParser<MyRoomShopInfoResponse>(() => new MyRoomShopInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int ShopBuyInfoFieldNumber = 1;

	private static readonly FieldCodec<MyRoomShopDBInfo> _repeated_shopBuyInfo_codec = FieldCodec.ForMessage(10u, MyRoomShopDBInfo.Parser);

	private readonly RepeatedField<MyRoomShopDBInfo> shopBuyInfo_ = new RepeatedField<MyRoomShopDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomShopInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MyRoomShopInfoResponseReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MyRoomShopDBInfo> ShopBuyInfo => shopBuyInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomShopInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomShopInfoResponse(MyRoomShopInfoResponse other)
		: this()
	{
		shopBuyInfo_ = other.shopBuyInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomShopInfoResponse Clone()
	{
		return new MyRoomShopInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomShopInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MyRoomShopInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (shopBuyInfo_.Equals(other.shopBuyInfo_))
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
		num ^= shopBuyInfo_.GetHashCode();
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
		shopBuyInfo_.WriteTo(ref output, _repeated_shopBuyInfo_codec);
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
		num += shopBuyInfo_.CalculateSize(_repeated_shopBuyInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MyRoomShopInfoResponse other)
	{
		if (other != null)
		{
			shopBuyInfo_.Add(other.shopBuyInfo_);
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
				shopBuyInfo_.AddEntriesFrom(ref input, _repeated_shopBuyInfo_codec);
			}
		}
	}
}
