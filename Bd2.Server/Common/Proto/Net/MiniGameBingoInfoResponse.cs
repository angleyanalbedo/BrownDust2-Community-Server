using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameBingoInfoResponse : IMessage<MiniGameBingoInfoResponse>, IMessage, IEquatable<MiniGameBingoInfoResponse>, IDeepCloneable<MiniGameBingoInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBingoInfoResponse> _parser = new MessageParser<MiniGameBingoInfoResponse>(() => new MiniGameBingoInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MiniGameBingoInfoFieldNumber = 1;

	private static readonly FieldCodec<MiniGameBingoDBInfo> _repeated_miniGameBingoInfo_codec = FieldCodec.ForMessage(10u, MiniGameBingoDBInfo.Parser);

	private readonly RepeatedField<MiniGameBingoDBInfo> miniGameBingoInfo_ = new RepeatedField<MiniGameBingoDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameBingoInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameBingoInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MiniGameBingoDBInfo> MiniGameBingoInfo => miniGameBingoInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBingoInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoInfoResponse(MiniGameBingoInfoResponse other)
		: this()
	{
		miniGameBingoInfo_ = other.miniGameBingoInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoInfoResponse Clone()
	{
		return new MiniGameBingoInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBingoInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameBingoInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (miniGameBingoInfo_.Equals(other.miniGameBingoInfo_))
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
		num ^= miniGameBingoInfo_.GetHashCode();
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
		miniGameBingoInfo_.WriteTo(ref output, _repeated_miniGameBingoInfo_codec);
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
		num += miniGameBingoInfo_.CalculateSize(_repeated_miniGameBingoInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MiniGameBingoInfoResponse other)
	{
		if (other != null)
		{
			miniGameBingoInfo_.Add(other.miniGameBingoInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
				miniGameBingoInfo_.AddEntriesFrom(ref input, _repeated_miniGameBingoInfo_codec);
			}
		}
	}
}
