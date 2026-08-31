using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PictorialBookInfoResponse : IMessage<PictorialBookInfoResponse>, IMessage, IEquatable<PictorialBookInfoResponse>, IDeepCloneable<PictorialBookInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PictorialBookInfoResponse> _parser = new MessageParser<PictorialBookInfoResponse>(() => new PictorialBookInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int PictorialbookInfoFieldNumber = 1;

	private static readonly FieldCodec<PictorialBookDBInfo> _repeated_pictorialbookInfo_codec = FieldCodec.ForMessage(10u, PictorialBookDBInfo.Parser);

	private readonly RepeatedField<PictorialBookDBInfo> pictorialbookInfo_ = new RepeatedField<PictorialBookDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PictorialBookInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PictorialBookInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PictorialBookDBInfo> PictorialbookInfo => pictorialbookInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PictorialBookInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PictorialBookInfoResponse(PictorialBookInfoResponse other)
		: this()
	{
		pictorialbookInfo_ = other.pictorialbookInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PictorialBookInfoResponse Clone()
	{
		return new PictorialBookInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PictorialBookInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PictorialBookInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (pictorialbookInfo_.Equals(other.pictorialbookInfo_))
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
		num ^= pictorialbookInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		pictorialbookInfo_.WriteTo(ref output, _repeated_pictorialbookInfo_codec);
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
		num += pictorialbookInfo_.CalculateSize(_repeated_pictorialbookInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PictorialBookInfoResponse other)
	{
		if (other != null)
		{
			pictorialbookInfo_.Add(other.pictorialbookInfo_);
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
				pictorialbookInfo_.AddEntriesFrom(ref input, _repeated_pictorialbookInfo_codec);
			}
		}
	}
}
