using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntingGroundInfoListResponse : IMessage<HuntingGroundInfoListResponse>, IMessage, IEquatable<HuntingGroundInfoListResponse>, IDeepCloneable<HuntingGroundInfoListResponse>, IBufferMessage
{
	private static readonly MessageParser<HuntingGroundInfoListResponse> _parser = new MessageParser<HuntingGroundInfoListResponse>(() => new HuntingGroundInfoListResponse());

	private UnknownFieldSet _unknownFields;

	public const int HuntingGroundInfoFieldNumber = 1;

	private static readonly FieldCodec<HuntingGroundDBInfo> _repeated_huntingGroundInfo_codec = FieldCodec.ForMessage(10u, HuntingGroundDBInfo.Parser);

	private readonly RepeatedField<HuntingGroundDBInfo> huntingGroundInfo_ = new RepeatedField<HuntingGroundDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HuntingGroundInfoListResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => HuntingGroundInfoListResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HuntingGroundDBInfo> HuntingGroundInfo => huntingGroundInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntingGroundInfoListResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundInfoListResponse(HuntingGroundInfoListResponse other)
		: this()
	{
		huntingGroundInfo_ = other.huntingGroundInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntingGroundInfoListResponse Clone()
	{
		return new HuntingGroundInfoListResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntingGroundInfoListResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HuntingGroundInfoListResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (huntingGroundInfo_.Equals(other.huntingGroundInfo_))
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
		num ^= huntingGroundInfo_.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		huntingGroundInfo_.WriteTo(ref output, _repeated_huntingGroundInfo_codec);
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
		num += huntingGroundInfo_.CalculateSize(_repeated_huntingGroundInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HuntingGroundInfoListResponse other)
	{
		if (other != null)
		{
			huntingGroundInfo_.Add(other.huntingGroundInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			case 10u:
				huntingGroundInfo_.AddEntriesFrom(ref input, _repeated_huntingGroundInfo_codec);
				break;
			}
		}
	}
}
