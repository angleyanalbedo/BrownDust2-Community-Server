using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectInfoResponse : IMessage<FieldObjectInfoResponse>, IMessage, IEquatable<FieldObjectInfoResponse>, IDeepCloneable<FieldObjectInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectInfoResponse> _parser = new MessageParser<FieldObjectInfoResponse>(() => new FieldObjectInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int FieldRewardObtainInfoFieldNumber = 1;

	private static readonly FieldCodec<FieldObjectDBInfo> _repeated_fieldRewardObtainInfo_codec = FieldCodec.ForMessage(10u, FieldObjectDBInfo.Parser);

	private readonly RepeatedField<FieldObjectDBInfo> fieldRewardObtainInfo_ = new RepeatedField<FieldObjectDBInfo>();

	public const int FieldActionObjectInfoFieldNumber = 2;

	private static readonly FieldCodec<FieldObjectDBInfo> _repeated_fieldActionObjectInfo_codec = FieldCodec.ForMessage(18u, FieldObjectDBInfo.Parser);

	private readonly RepeatedField<FieldObjectDBInfo> fieldActionObjectInfo_ = new RepeatedField<FieldObjectDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FieldObjectInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldObjectInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldObjectDBInfo> FieldRewardObtainInfo => fieldRewardObtainInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FieldObjectDBInfo> FieldActionObjectInfo => fieldActionObjectInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectInfoResponse(FieldObjectInfoResponse other)
		: this()
	{
		fieldRewardObtainInfo_ = other.fieldRewardObtainInfo_.Clone();
		fieldActionObjectInfo_ = other.fieldActionObjectInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectInfoResponse Clone()
	{
		return new FieldObjectInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldObjectInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (fieldRewardObtainInfo_.Equals(other.fieldRewardObtainInfo_) && fieldActionObjectInfo_.Equals(other.fieldActionObjectInfo_))
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
		num ^= fieldRewardObtainInfo_.GetHashCode();
		num ^= fieldActionObjectInfo_.GetHashCode();
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
		fieldRewardObtainInfo_.WriteTo(ref output, _repeated_fieldRewardObtainInfo_codec);
		fieldActionObjectInfo_.WriteTo(ref output, _repeated_fieldActionObjectInfo_codec);
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
		num += fieldRewardObtainInfo_.CalculateSize(_repeated_fieldRewardObtainInfo_codec);
		num += fieldActionObjectInfo_.CalculateSize(_repeated_fieldActionObjectInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldObjectInfoResponse other)
	{
		if (other != null)
		{
			fieldRewardObtainInfo_.Add(other.fieldRewardObtainInfo_);
			fieldActionObjectInfo_.Add(other.fieldActionObjectInfo_);
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
			case 18u:
				fieldActionObjectInfo_.AddEntriesFrom(ref input, _repeated_fieldActionObjectInfo_codec);
				break;
			case 10u:
				fieldRewardObtainInfo_.AddEntriesFrom(ref input, _repeated_fieldRewardObtainInfo_codec);
				break;
			}
		}
	}
}
