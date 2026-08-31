using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class AttendanceAlwaysInfo : IMessage<AttendanceAlwaysInfo>, IMessage, IEquatable<AttendanceAlwaysInfo>, IDeepCloneable<AttendanceAlwaysInfo>, IBufferMessage
{
	private static readonly MessageParser<AttendanceAlwaysInfo> _parser = new MessageParser<AttendanceAlwaysInfo>(() => new AttendanceAlwaysInfo());

	private UnknownFieldSet _unknownFields;

	public const int EventScheduleIdFieldNumber = 1;

	private int eventScheduleId_;

	public const int AttendanceGroupIdFieldNumber = 2;

	private int attendanceGroupId_;

	public const int AttendanceCountFieldNumber = 3;

	private int attendanceCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AttendanceAlwaysInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AttendanceEventInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventScheduleId
	{
		get
		{
			return eventScheduleId_;
		}
		set
		{
			eventScheduleId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AttendanceGroupId
	{
		get
		{
			return attendanceGroupId_;
		}
		set
		{
			attendanceGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AttendanceCount
	{
		get
		{
			return attendanceCount_;
		}
		set
		{
			attendanceCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysInfo(AttendanceAlwaysInfo other)
		: this()
	{
		eventScheduleId_ = other.eventScheduleId_;
		attendanceGroupId_ = other.attendanceGroupId_;
		attendanceCount_ = other.attendanceCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysInfo Clone()
	{
		return new AttendanceAlwaysInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AttendanceAlwaysInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AttendanceAlwaysInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventScheduleId == other.EventScheduleId && AttendanceGroupId == other.AttendanceGroupId && AttendanceCount == other.AttendanceCount)
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
		if (EventScheduleId != 0)
		{
			num ^= EventScheduleId.GetHashCode();
		}
		if (AttendanceGroupId != 0)
		{
			num ^= AttendanceGroupId.GetHashCode();
		}
		if (AttendanceCount != 0)
		{
			num ^= AttendanceCount.GetHashCode();
		}
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
		if (EventScheduleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventScheduleId);
		}
		if (AttendanceGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttendanceGroupId);
		}
		if (AttendanceCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AttendanceCount);
		}
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
		if (EventScheduleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventScheduleId);
		}
		if (AttendanceGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttendanceGroupId);
		}
		if (AttendanceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttendanceCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AttendanceAlwaysInfo other)
	{
		if (other != null)
		{
			if (other.EventScheduleId != 0)
			{
				EventScheduleId = other.EventScheduleId;
			}
			if (other.AttendanceGroupId != 0)
			{
				AttendanceGroupId = other.AttendanceGroupId;
			}
			if (other.AttendanceCount != 0)
			{
				AttendanceCount = other.AttendanceCount;
			}
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
			case 24u:
				AttendanceCount = input.ReadInt32();
				break;
			case 16u:
				AttendanceGroupId = input.ReadInt32();
				break;
			case 8u:
				EventScheduleId = input.ReadInt32();
				break;
			}
		}
	}
}
