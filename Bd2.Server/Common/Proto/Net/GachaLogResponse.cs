using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaLogResponse : IMessage<GachaLogResponse>, IMessage, IEquatable<GachaLogResponse>, IDeepCloneable<GachaLogResponse>, IBufferMessage
{
	private static readonly MessageParser<GachaLogResponse> _parser = new MessageParser<GachaLogResponse>(() => new GachaLogResponse());

	private UnknownFieldSet _unknownFields;

	public const int GachaLogFieldNumber = 1;

	private static readonly FieldCodec<GachaLogDBInfo> _repeated_gachaLog_codec = FieldCodec.ForMessage(10u, GachaLogDBInfo.Parser);

	private readonly RepeatedField<GachaLogDBInfo> gachaLog_ = new RepeatedField<GachaLogDBInfo>();

	public const int GachaTotalCountInfoFieldNumber = 2;

	private static readonly FieldCodec<GachaTotalCountInfo> _repeated_gachaTotalCountInfo_codec = FieldCodec.ForMessage(18u, Bd2.Server.Common.Proto.Net.GachaTotalCountInfo.Parser);

	private readonly RepeatedField<GachaTotalCountInfo> gachaTotalCountInfo_ = new RepeatedField<GachaTotalCountInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaLogResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GachaLogResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GachaLogDBInfo> GachaLog => gachaLog_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaTotalCountInfo> GachaTotalCountInfo => gachaTotalCountInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaLogResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaLogResponse(GachaLogResponse other)
		: this()
	{
		gachaLog_ = other.gachaLog_.Clone();
		gachaTotalCountInfo_ = other.gachaTotalCountInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaLogResponse Clone()
	{
		return new GachaLogResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GachaLogResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaLogResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (gachaLog_.Equals(other.gachaLog_) && gachaTotalCountInfo_.Equals(other.gachaTotalCountInfo_))
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
		num ^= gachaLog_.GetHashCode();
		num ^= gachaTotalCountInfo_.GetHashCode();
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
		gachaLog_.WriteTo(ref output, _repeated_gachaLog_codec);
		gachaTotalCountInfo_.WriteTo(ref output, _repeated_gachaTotalCountInfo_codec);
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
		num += gachaLog_.CalculateSize(_repeated_gachaLog_codec);
		num += gachaTotalCountInfo_.CalculateSize(_repeated_gachaTotalCountInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GachaLogResponse other)
	{
		if (other != null)
		{
			gachaLog_.Add(other.gachaLog_);
			gachaTotalCountInfo_.Add(other.gachaTotalCountInfo_);
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
				gachaTotalCountInfo_.AddEntriesFrom(ref input, _repeated_gachaTotalCountInfo_codec);
				break;
			case 10u:
				gachaLog_.AddEntriesFrom(ref input, _repeated_gachaLog_codec);
				break;
			}
		}
	}
}
