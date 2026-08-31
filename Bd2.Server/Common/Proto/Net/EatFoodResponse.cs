using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EatFoodResponse : IMessage<EatFoodResponse>, IMessage, IEquatable<EatFoodResponse>, IDeepCloneable<EatFoodResponse>, IBufferMessage
{
	private static readonly MessageParser<EatFoodResponse> _parser = new MessageParser<EatFoodResponse>(() => new EatFoodResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(10u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int FieldBuffInfoFieldNumber = 2;

	private static readonly FieldCodec<FieldBuffDBInfo> _repeated_fieldBuffInfo_codec = FieldCodec.ForMessage(18u, FieldBuffDBInfo.Parser);

	private readonly RepeatedField<FieldBuffDBInfo> fieldBuffInfo_ = new RepeatedField<FieldBuffDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EatFoodResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EatFoodResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldBuffDBInfo> FieldBuffInfo => fieldBuffInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EatFoodResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EatFoodResponse(EatFoodResponse other)
		: this()
	{
		charInfo_ = other.charInfo_.Clone();
		fieldBuffInfo_ = other.fieldBuffInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EatFoodResponse Clone()
	{
		return new EatFoodResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EatFoodResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EatFoodResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charInfo_.Equals(other.charInfo_) && fieldBuffInfo_.Equals(other.fieldBuffInfo_))
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
		num ^= charInfo_.GetHashCode();
		num ^= fieldBuffInfo_.GetHashCode();
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
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		fieldBuffInfo_.WriteTo(ref output, _repeated_fieldBuffInfo_codec);
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
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += fieldBuffInfo_.CalculateSize(_repeated_fieldBuffInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EatFoodResponse other)
	{
		if (other != null)
		{
			charInfo_.Add(other.charInfo_);
			fieldBuffInfo_.Add(other.fieldBuffInfo_);
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
				fieldBuffInfo_.AddEntriesFrom(ref input, _repeated_fieldBuffInfo_codec);
				break;
			case 10u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			}
		}
	}
}
