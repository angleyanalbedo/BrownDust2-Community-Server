using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class FieldObjectRespawnResponse : IMessage<FieldObjectRespawnResponse>, IMessage, IEquatable<FieldObjectRespawnResponse>, IDeepCloneable<FieldObjectRespawnResponse>, IBufferMessage
{
	private static readonly MessageParser<FieldObjectRespawnResponse> _parser = new MessageParser<FieldObjectRespawnResponse>(() => new FieldObjectRespawnResponse());

	private UnknownFieldSet _unknownFields;

	public const int FieldObjectInfoFieldNumber = 1;

	private static readonly FieldCodec<FieldObjectDBInfo> _repeated_fieldObjectInfo_codec = FieldCodec.ForMessage(10u, FieldObjectDBInfo.Parser);

	private readonly RepeatedField<FieldObjectDBInfo> fieldObjectInfo_ = new RepeatedField<FieldObjectDBInfo>();

	public const int FieldObjectRespawnInfoFieldNumber = 2;

	private static readonly FieldCodec<FieldObjectRespawnDBInfo> _repeated_fieldObjectRespawnInfo_codec = FieldCodec.ForMessage(18u, FieldObjectRespawnDBInfo.Parser);

	private readonly RepeatedField<FieldObjectRespawnDBInfo> fieldObjectRespawnInfo_ = new RepeatedField<FieldObjectRespawnDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldObjectRespawnResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FieldObjectRespawnResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldObjectDBInfo> FieldObjectInfo => fieldObjectInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FieldObjectRespawnDBInfo> FieldObjectRespawnInfo => fieldObjectRespawnInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectRespawnResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectRespawnResponse(FieldObjectRespawnResponse other)
		: this()
	{
		fieldObjectInfo_ = other.fieldObjectInfo_.Clone();
		fieldObjectRespawnInfo_ = other.fieldObjectRespawnInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FieldObjectRespawnResponse Clone()
	{
		return new FieldObjectRespawnResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as FieldObjectRespawnResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FieldObjectRespawnResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (fieldObjectInfo_.Equals(other.fieldObjectInfo_) && fieldObjectRespawnInfo_.Equals(other.fieldObjectRespawnInfo_))
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
		num ^= fieldObjectInfo_.GetHashCode();
		num ^= fieldObjectRespawnInfo_.GetHashCode();
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
		fieldObjectInfo_.WriteTo(ref output, _repeated_fieldObjectInfo_codec);
		fieldObjectRespawnInfo_.WriteTo(ref output, _repeated_fieldObjectRespawnInfo_codec);
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
		num += fieldObjectInfo_.CalculateSize(_repeated_fieldObjectInfo_codec);
		num += fieldObjectRespawnInfo_.CalculateSize(_repeated_fieldObjectRespawnInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FieldObjectRespawnResponse other)
	{
		if (other != null)
		{
			fieldObjectInfo_.Add(other.fieldObjectInfo_);
			fieldObjectRespawnInfo_.Add(other.fieldObjectRespawnInfo_);
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
			case 18u:
				fieldObjectRespawnInfo_.AddEntriesFrom(ref input, _repeated_fieldObjectRespawnInfo_codec);
				break;
			case 10u:
				fieldObjectInfo_.AddEntriesFrom(ref input, _repeated_fieldObjectInfo_codec);
				break;
			}
		}
	}
}
