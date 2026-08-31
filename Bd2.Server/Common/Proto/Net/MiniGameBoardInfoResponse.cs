using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameBoardInfoResponse : IMessage<MiniGameBoardInfoResponse>, IMessage, IEquatable<MiniGameBoardInfoResponse>, IDeepCloneable<MiniGameBoardInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBoardInfoResponse> _parser = new MessageParser<MiniGameBoardInfoResponse>(() => new MiniGameBoardInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MiniGameBoardInfoFieldNumber = 1;

	private static readonly FieldCodec<MiniGameBoardDBInfo> _repeated_miniGameBoardInfo_codec = FieldCodec.ForMessage(10u, MiniGameBoardDBInfo.Parser);

	private readonly RepeatedField<MiniGameBoardDBInfo> miniGameBoardInfo_ = new RepeatedField<MiniGameBoardDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameBoardInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameBoardInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MiniGameBoardDBInfo> MiniGameBoardInfo => miniGameBoardInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBoardInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardInfoResponse(MiniGameBoardInfoResponse other)
		: this()
	{
		miniGameBoardInfo_ = other.miniGameBoardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBoardInfoResponse Clone()
	{
		return new MiniGameBoardInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBoardInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameBoardInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (miniGameBoardInfo_.Equals(other.miniGameBoardInfo_))
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
		num ^= miniGameBoardInfo_.GetHashCode();
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
		miniGameBoardInfo_.WriteTo(ref output, _repeated_miniGameBoardInfo_codec);
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
		num += miniGameBoardInfo_.CalculateSize(_repeated_miniGameBoardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameBoardInfoResponse other)
	{
		if (other != null)
		{
			miniGameBoardInfo_.Add(other.miniGameBoardInfo_);
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
				miniGameBoardInfo_.AddEntriesFrom(ref input, _repeated_miniGameBoardInfo_codec);
			}
		}
	}
}
