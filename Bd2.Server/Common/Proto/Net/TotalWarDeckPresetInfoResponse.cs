using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TotalWarDeckPresetInfoResponse : IMessage<TotalWarDeckPresetInfoResponse>, IMessage, IEquatable<TotalWarDeckPresetInfoResponse>, IDeepCloneable<TotalWarDeckPresetInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<TotalWarDeckPresetInfoResponse> _parser = new MessageParser<TotalWarDeckPresetInfoResponse>(() => new TotalWarDeckPresetInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int PresetInfoFieldNumber = 1;

	private static readonly FieldCodec<TotalWarDeckPresetDBInfo> _repeated_presetInfo_codec = FieldCodec.ForMessage(10u, TotalWarDeckPresetDBInfo.Parser);

	private readonly RepeatedField<TotalWarDeckPresetDBInfo> presetInfo_ = new RepeatedField<TotalWarDeckPresetDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TotalWarDeckPresetInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TotalWarDeckPresetInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<TotalWarDeckPresetDBInfo> PresetInfo => presetInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarDeckPresetInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarDeckPresetInfoResponse(TotalWarDeckPresetInfoResponse other)
		: this()
	{
		presetInfo_ = other.presetInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarDeckPresetInfoResponse Clone()
	{
		return new TotalWarDeckPresetInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarDeckPresetInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TotalWarDeckPresetInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (presetInfo_.Equals(other.presetInfo_))
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
		num ^= presetInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		presetInfo_.WriteTo(ref output, _repeated_presetInfo_codec);
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
		num += presetInfo_.CalculateSize(_repeated_presetInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TotalWarDeckPresetInfoResponse other)
	{
		if (other != null)
		{
			presetInfo_.Add(other.presetInfo_);
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
				presetInfo_.AddEntriesFrom(ref input, _repeated_presetInfo_codec);
			}
		}
	}
}
