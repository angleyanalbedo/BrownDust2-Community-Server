using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ScheduleInfoResponse : IMessage<ScheduleInfoResponse>, IMessage, IEquatable<ScheduleInfoResponse>, IDeepCloneable<ScheduleInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<ScheduleInfoResponse> _parser = new MessageParser<ScheduleInfoResponse>(() => new ScheduleInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int ScheduleCalculateMileSecondsFieldNumber = 1;

	private int scheduleCalculateMileSeconds_;

	public const int ScheduleInfoFieldNumber = 2;

	private static readonly FieldCodec<ScheduleDBInfo> _repeated_scheduleInfo_codec = FieldCodec.ForMessage(18u, ScheduleDBInfo.Parser);

	private readonly RepeatedField<ScheduleDBInfo> scheduleInfo_ = new RepeatedField<ScheduleDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ScheduleInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ScheduleInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScheduleCalculateMileSeconds
	{
		get
		{
			return scheduleCalculateMileSeconds_;
		}
		set
		{
			scheduleCalculateMileSeconds_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ScheduleDBInfo> ScheduleInfo => scheduleInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScheduleInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScheduleInfoResponse(ScheduleInfoResponse other)
		: this()
	{
		scheduleCalculateMileSeconds_ = other.scheduleCalculateMileSeconds_;
		scheduleInfo_ = other.scheduleInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ScheduleInfoResponse Clone()
	{
		return new ScheduleInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ScheduleInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ScheduleInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ScheduleCalculateMileSeconds == other.ScheduleCalculateMileSeconds && scheduleInfo_.Equals(other.scheduleInfo_))
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
		if (ScheduleCalculateMileSeconds != 0)
		{
			num ^= ScheduleCalculateMileSeconds.GetHashCode();
		}
		num ^= scheduleInfo_.GetHashCode();
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
		if (ScheduleCalculateMileSeconds != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ScheduleCalculateMileSeconds);
		}
		scheduleInfo_.WriteTo(ref output, _repeated_scheduleInfo_codec);
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
		if (ScheduleCalculateMileSeconds != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScheduleCalculateMileSeconds);
		}
		num += scheduleInfo_.CalculateSize(_repeated_scheduleInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ScheduleInfoResponse other)
	{
		if (other != null)
		{
			if (other.ScheduleCalculateMileSeconds != 0)
			{
				ScheduleCalculateMileSeconds = other.ScheduleCalculateMileSeconds;
			}
			scheduleInfo_.Add(other.scheduleInfo_);
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
				scheduleInfo_.AddEntriesFrom(ref input, _repeated_scheduleInfo_codec);
				break;
			case 8u:
				ScheduleCalculateMileSeconds = input.ReadInt32();
				break;
			}
		}
	}
}
