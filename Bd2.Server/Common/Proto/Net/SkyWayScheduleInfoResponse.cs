using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SkyWayScheduleInfoResponse : IMessage<SkyWayScheduleInfoResponse>, IMessage, IEquatable<SkyWayScheduleInfoResponse>, IDeepCloneable<SkyWayScheduleInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<SkyWayScheduleInfoResponse> _parser = new MessageParser<SkyWayScheduleInfoResponse>(() => new SkyWayScheduleInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int ScheduleInfoFieldNumber = 1;

	private static readonly FieldCodec<SkyWayScheduleDBInfo> _repeated_scheduleInfo_codec = FieldCodec.ForMessage(10u, SkyWayScheduleDBInfo.Parser);

	private readonly RepeatedField<SkyWayScheduleDBInfo> scheduleInfo_ = new RepeatedField<SkyWayScheduleDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SkyWayScheduleInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => SkyWayScheduleInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SkyWayScheduleDBInfo> ScheduleInfo => scheduleInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SkyWayScheduleInfoResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SkyWayScheduleInfoResponse(SkyWayScheduleInfoResponse other)
		: this()
	{
		scheduleInfo_ = other.scheduleInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayScheduleInfoResponse Clone()
	{
		return new SkyWayScheduleInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SkyWayScheduleInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SkyWayScheduleInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (scheduleInfo_.Equals(other.scheduleInfo_))
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
		num ^= scheduleInfo_.GetHashCode();
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
		scheduleInfo_.WriteTo(ref output, _repeated_scheduleInfo_codec);
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
		num += scheduleInfo_.CalculateSize(_repeated_scheduleInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SkyWayScheduleInfoResponse other)
	{
		if (other != null)
		{
			scheduleInfo_.Add(other.scheduleInfo_);
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
				scheduleInfo_.AddEntriesFrom(ref input, _repeated_scheduleInfo_codec);
			}
		}
	}
}
