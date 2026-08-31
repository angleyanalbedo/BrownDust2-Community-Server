using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SkyWayInfoResponse : IMessage<SkyWayInfoResponse>, IMessage, IEquatable<SkyWayInfoResponse>, IDeepCloneable<SkyWayInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<SkyWayInfoResponse> _parser = new MessageParser<SkyWayInfoResponse>(() => new SkyWayInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int SkyWayInfoFieldNumber = 1;

	private static readonly FieldCodec<SkyWayDBInfo> _repeated_skyWayInfo_codec = FieldCodec.ForMessage(10u, SkyWayDBInfo.Parser);

	private readonly RepeatedField<SkyWayDBInfo> skyWayInfo_ = new RepeatedField<SkyWayDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SkyWayInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SkyWayInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<SkyWayDBInfo> SkyWayInfo => skyWayInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SkyWayInfoResponse(SkyWayInfoResponse other)
		: this()
	{
		skyWayInfo_ = other.skyWayInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayInfoResponse Clone()
	{
		return new SkyWayInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SkyWayInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(SkyWayInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (skyWayInfo_.Equals(other.skyWayInfo_))
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
		num ^= skyWayInfo_.GetHashCode();
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
		skyWayInfo_.WriteTo(ref output, _repeated_skyWayInfo_codec);
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
		num += skyWayInfo_.CalculateSize(_repeated_skyWayInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SkyWayInfoResponse other)
	{
		if (other != null)
		{
			skyWayInfo_.Add(other.skyWayInfo_);
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
				skyWayInfo_.AddEntriesFrom(ref input, _repeated_skyWayInfo_codec);
			}
		}
	}
}
