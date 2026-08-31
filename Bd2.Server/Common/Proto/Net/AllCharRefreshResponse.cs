using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class AllCharRefreshResponse : IMessage<AllCharRefreshResponse>, IMessage, IEquatable<AllCharRefreshResponse>, IDeepCloneable<AllCharRefreshResponse>, IBufferMessage
{
	private static readonly MessageParser<AllCharRefreshResponse> _parser = new MessageParser<AllCharRefreshResponse>(() => new AllCharRefreshResponse());

	private UnknownFieldSet _unknownFields;

	public const int BuffStatInfoFieldNumber = 1;

	private static readonly FieldCodec<PictorialBuffStatDBInfo> _repeated_buffStatInfo_codec = FieldCodec.ForMessage(10u, PictorialBuffStatDBInfo.Parser);

	private readonly RepeatedField<PictorialBuffStatDBInfo> buffStatInfo_ = new RepeatedField<PictorialBuffStatDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllCharRefreshResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AllCharRefreshResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PictorialBuffStatDBInfo> BuffStatInfo => buffStatInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllCharRefreshResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllCharRefreshResponse(AllCharRefreshResponse other)
		: this()
	{
		buffStatInfo_ = other.buffStatInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllCharRefreshResponse Clone()
	{
		return new AllCharRefreshResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AllCharRefreshResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllCharRefreshResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (buffStatInfo_.Equals(other.buffStatInfo_))
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
		num ^= buffStatInfo_.GetHashCode();
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
		buffStatInfo_.WriteTo(ref output, _repeated_buffStatInfo_codec);
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
		num += buffStatInfo_.CalculateSize(_repeated_buffStatInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllCharRefreshResponse other)
	{
		if (other != null)
		{
			buffStatInfo_.Add(other.buffStatInfo_);
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
				buffStatInfo_.AddEntriesFrom(ref input, _repeated_buffStatInfo_codec);
			}
		}
	}
}
