using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackRewardObjectCountResponse : IMessage<PackRewardObjectCountResponse>, IMessage, IEquatable<PackRewardObjectCountResponse>, IDeepCloneable<PackRewardObjectCountResponse>, IBufferMessage
{
	private static readonly MessageParser<PackRewardObjectCountResponse> _parser = new MessageParser<PackRewardObjectCountResponse>(() => new PackRewardObjectCountResponse());

	private UnknownFieldSet _unknownFields;

	public const int CountInfoFieldNumber = 1;

	private static readonly FieldCodec<PackRewardObjectCountInfo> _repeated_countInfo_codec = FieldCodec.ForMessage(10u, PackRewardObjectCountInfo.Parser);

	private readonly RepeatedField<PackRewardObjectCountInfo> countInfo_ = new RepeatedField<PackRewardObjectCountInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackRewardObjectCountResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackRewardObjectCountResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PackRewardObjectCountInfo> CountInfo => countInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackRewardObjectCountResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackRewardObjectCountResponse(PackRewardObjectCountResponse other)
		: this()
	{
		countInfo_ = other.countInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackRewardObjectCountResponse Clone()
	{
		return new PackRewardObjectCountResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackRewardObjectCountResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackRewardObjectCountResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (countInfo_.Equals(other.countInfo_))
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
		num ^= countInfo_.GetHashCode();
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
		countInfo_.WriteTo(ref output, _repeated_countInfo_codec);
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
		num += countInfo_.CalculateSize(_repeated_countInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackRewardObjectCountResponse other)
	{
		if (other != null)
		{
			countInfo_.Add(other.countInfo_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				countInfo_.AddEntriesFrom(ref input, _repeated_countInfo_codec);
			}
		}
	}
}
