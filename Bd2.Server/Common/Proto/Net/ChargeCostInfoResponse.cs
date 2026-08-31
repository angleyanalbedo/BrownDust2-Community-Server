using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ChargeCostInfoResponse : IMessage<ChargeCostInfoResponse>, IMessage, IEquatable<ChargeCostInfoResponse>, IDeepCloneable<ChargeCostInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<ChargeCostInfoResponse> _parser = new MessageParser<ChargeCostInfoResponse>(() => new ChargeCostInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int CostTimeInfoFieldNumber = 1;

	private static readonly FieldCodec<CostTimeDBInfo> _repeated_costTimeInfo_codec = FieldCodec.ForMessage(10u, CostTimeDBInfo.Parser);

	private readonly RepeatedField<CostTimeDBInfo> costTimeInfo_ = new RepeatedField<CostTimeDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChargeCostInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ChargeCostInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CostTimeDBInfo> CostTimeInfo => costTimeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChargeCostInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChargeCostInfoResponse(ChargeCostInfoResponse other)
		: this()
	{
		costTimeInfo_ = other.costTimeInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChargeCostInfoResponse Clone()
	{
		return new ChargeCostInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChargeCostInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChargeCostInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (costTimeInfo_.Equals(other.costTimeInfo_))
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
		num ^= costTimeInfo_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		costTimeInfo_.WriteTo(ref output, _repeated_costTimeInfo_codec);
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
		num += costTimeInfo_.CalculateSize(_repeated_costTimeInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChargeCostInfoResponse other)
	{
		if (other != null)
		{
			costTimeInfo_.Add(other.costTimeInfo_);
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
				costTimeInfo_.AddEntriesFrom(ref input, _repeated_costTimeInfo_codec);
			}
		}
	}
}
