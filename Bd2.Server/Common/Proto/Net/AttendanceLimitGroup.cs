using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class AttendanceLimitGroup : IMessage<AttendanceLimitGroup>, IMessage, IEquatable<AttendanceLimitGroup>, IDeepCloneable<AttendanceLimitGroup>, IBufferMessage
{
	private static readonly MessageParser<AttendanceLimitGroup> _parser = new MessageParser<AttendanceLimitGroup>(() => new AttendanceLimitGroup());

	private UnknownFieldSet _unknownFields;

	public const int LimitEventScheduleIdFieldNumber = 1;

	private int limitEventScheduleId_;

	public const int AttendanceLimitInfoFieldNumber = 2;

	private static readonly FieldCodec<AttendanceLimitInfo> _repeated_attendanceLimitInfo_codec = FieldCodec.ForMessage(18u, Bd2.Server.Common.Proto.Net.AttendanceLimitInfo.Parser);

	private readonly RepeatedField<AttendanceLimitInfo> attendanceLimitInfo_ = new RepeatedField<AttendanceLimitInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AttendanceLimitGroup> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AttendanceEventInfoReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LimitEventScheduleId
	{
		get
		{
			return limitEventScheduleId_;
		}
		set
		{
			limitEventScheduleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AttendanceLimitInfo> AttendanceLimitInfo => attendanceLimitInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceLimitGroup()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AttendanceLimitGroup(AttendanceLimitGroup other)
		: this()
	{
		limitEventScheduleId_ = other.limitEventScheduleId_;
		attendanceLimitInfo_ = other.attendanceLimitInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AttendanceLimitGroup Clone()
	{
		return new AttendanceLimitGroup(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as AttendanceLimitGroup);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AttendanceLimitGroup other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (LimitEventScheduleId == other.LimitEventScheduleId && attendanceLimitInfo_.Equals(other.attendanceLimitInfo_))
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
		if (LimitEventScheduleId != 0)
		{
			num ^= LimitEventScheduleId.GetHashCode();
		}
		num ^= attendanceLimitInfo_.GetHashCode();
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
		if (LimitEventScheduleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LimitEventScheduleId);
		}
		attendanceLimitInfo_.WriteTo(ref output, _repeated_attendanceLimitInfo_codec);
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
		if (LimitEventScheduleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitEventScheduleId);
		}
		num += attendanceLimitInfo_.CalculateSize(_repeated_attendanceLimitInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AttendanceLimitGroup other)
	{
		if (other != null)
		{
			if (other.LimitEventScheduleId != 0)
			{
				LimitEventScheduleId = other.LimitEventScheduleId;
			}
			attendanceLimitInfo_.Add(other.attendanceLimitInfo_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				attendanceLimitInfo_.AddEntriesFrom(ref input, _repeated_attendanceLimitInfo_codec);
				break;
			case 8u:
				LimitEventScheduleId = input.ReadInt32();
				break;
			}
		}
	}
}
