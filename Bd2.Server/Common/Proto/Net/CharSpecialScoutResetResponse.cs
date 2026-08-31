using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharSpecialScoutResetResponse : IMessage<CharSpecialScoutResetResponse>, IMessage, IEquatable<CharSpecialScoutResetResponse>, IDeepCloneable<CharSpecialScoutResetResponse>, IBufferMessage
{
	private static readonly MessageParser<CharSpecialScoutResetResponse> _parser = new MessageParser<CharSpecialScoutResetResponse>(() => new CharSpecialScoutResetResponse());

	private UnknownFieldSet _unknownFields;

	public const int AppearCharIdFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_appearCharId_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> appearCharId_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharSpecialScoutResetResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharSpecialScoutResetResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> AppearCharId => appearCharId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharSpecialScoutResetResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharSpecialScoutResetResponse(CharSpecialScoutResetResponse other)
		: this()
	{
		appearCharId_ = other.appearCharId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharSpecialScoutResetResponse Clone()
	{
		return new CharSpecialScoutResetResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CharSpecialScoutResetResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharSpecialScoutResetResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (appearCharId_.Equals(other.appearCharId_))
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
		num ^= appearCharId_.GetHashCode();
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
		appearCharId_.WriteTo(ref output, _repeated_appearCharId_codec);
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
		num += appearCharId_.CalculateSize(_repeated_appearCharId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharSpecialScoutResetResponse other)
	{
		if (other != null)
		{
			appearCharId_.Add(other.appearCharId_);
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
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				appearCharId_.AddEntriesFrom(ref input, _repeated_appearCharId_codec);
			}
		}
	}
}
