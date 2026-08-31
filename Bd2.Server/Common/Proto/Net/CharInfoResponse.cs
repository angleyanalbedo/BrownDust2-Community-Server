using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharInfoResponse : IMessage<CharInfoResponse>, IMessage, IEquatable<CharInfoResponse>, IDeepCloneable<CharInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<CharInfoResponse> _parser = new MessageParser<CharInfoResponse>(() => new CharInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(10u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int FieldCharControlDeckTypeFieldNumber = 2;

	private int fieldCharControlDeckType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FieldCharControlDeckType
	{
		get
		{
			return fieldCharControlDeckType_;
		}
		set
		{
			fieldCharControlDeckType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharInfoResponse(CharInfoResponse other)
		: this()
	{
		charInfo_ = other.charInfo_.Clone();
		fieldCharControlDeckType_ = other.fieldCharControlDeckType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharInfoResponse Clone()
	{
		return new CharInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charInfo_.Equals(other.charInfo_) && FieldCharControlDeckType == other.FieldCharControlDeckType)
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
		if (FieldCharControlDeckType != 0)
		{
			num ^= FieldCharControlDeckType.GetHashCode();
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
		if (FieldCharControlDeckType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(FieldCharControlDeckType);
		}
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
		if (FieldCharControlDeckType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldCharControlDeckType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharInfoResponse other)
	{
		if (other != null)
		{
			charInfo_.Add(other.charInfo_);
			if (other.FieldCharControlDeckType != 0)
			{
				FieldCharControlDeckType = other.FieldCharControlDeckType;
			}
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
			case 16u:
				FieldCharControlDeckType = input.ReadInt32();
				break;
			case 10u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			}
		}
	}
}
