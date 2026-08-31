using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class SubscribeAttendanceInfo : IMessage<SubscribeAttendanceInfo>, IMessage, IEquatable<SubscribeAttendanceInfo>, IDeepCloneable<SubscribeAttendanceInfo>, IBufferMessage
{
	private static readonly MessageParser<SubscribeAttendanceInfo> _parser = new MessageParser<SubscribeAttendanceInfo>(() => new SubscribeAttendanceInfo());

	private UnknownFieldSet _unknownFields;

	public const int TicketIdFieldNumber = 1;

	private int ticketId_;

	public const int ReservedDateFieldNumber = 2;

	private long reservedDate_;

	public const int ExpiryDateFieldNumber = 3;

	private long expiryDate_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SubscribeAttendanceInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AttendanceEventInfoReflection.Descriptor.MessageTypes[3];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TicketId
	{
		get
		{
			return ticketId_;
		}
		set
		{
			ticketId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ReservedDate
	{
		get
		{
			return reservedDate_;
		}
		set
		{
			reservedDate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ExpiryDate
	{
		get
		{
			return expiryDate_;
		}
		set
		{
			expiryDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeAttendanceInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeAttendanceInfo(SubscribeAttendanceInfo other)
		: this()
	{
		ticketId_ = other.ticketId_;
		reservedDate_ = other.reservedDate_;
		expiryDate_ = other.expiryDate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeAttendanceInfo Clone()
	{
		return new SubscribeAttendanceInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SubscribeAttendanceInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SubscribeAttendanceInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (TicketId == other.TicketId && ReservedDate == other.ReservedDate && ExpiryDate == other.ExpiryDate)
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
		if (TicketId != 0)
		{
			num ^= TicketId.GetHashCode();
		}
		if (ReservedDate != 0L)
		{
			num ^= ReservedDate.GetHashCode();
		}
		if (ExpiryDate != 0L)
		{
			num ^= ExpiryDate.GetHashCode();
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
		if (TicketId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TicketId);
		}
		if (ReservedDate != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(ReservedDate);
		}
		if (ExpiryDate != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(ExpiryDate);
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
		if (TicketId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TicketId);
		}
		if (ReservedDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ReservedDate);
		}
		if (ExpiryDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ExpiryDate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubscribeAttendanceInfo other)
	{
		if (other != null)
		{
			if (other.TicketId != 0)
			{
				TicketId = other.TicketId;
			}
			if (other.ReservedDate != 0L)
			{
				ReservedDate = other.ReservedDate;
			}
			if (other.ExpiryDate != 0L)
			{
				ExpiryDate = other.ExpiryDate;
			}
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				ExpiryDate = input.ReadInt64();
				break;
			case 16u:
				ReservedDate = input.ReadInt64();
				break;
			case 8u:
				TicketId = input.ReadInt32();
				break;
			}
		}
	}
}
