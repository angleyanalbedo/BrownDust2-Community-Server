using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventRewardHistoryDBInfo : IMessage<EventRewardHistoryDBInfo>, IMessage, IEquatable<EventRewardHistoryDBInfo>, IDeepCloneable<EventRewardHistoryDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EventRewardHistoryDBInfo> _parser = new MessageParser<EventRewardHistoryDBInfo>(() => new EventRewardHistoryDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int EventScheduleIdFieldNumber = 1;

	private int eventScheduleId_;

	public const int EventGroupIdFieldNumber = 2;

	private int eventGroupId_;

	public const int RewardIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventRewardHistoryDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventRewardHistoryDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventGroupId
	{
		get
		{
			return eventGroupId_;
		}
		set
		{
			eventGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId => rewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventRewardHistoryDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventRewardHistoryDBInfo(EventRewardHistoryDBInfo other)
		: this()
	{
		eventScheduleId_ = other.eventScheduleId_;
		eventGroupId_ = other.eventGroupId_;
		rewardId_ = other.rewardId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventRewardHistoryDBInfo Clone()
	{
		return new EventRewardHistoryDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventRewardHistoryDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EventRewardHistoryDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventScheduleId == other.EventScheduleId && EventGroupId == other.EventGroupId && rewardId_.Equals(other.rewardId_))
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
		if (EventGroupId != 0)
		{
			num ^= EventGroupId.GetHashCode();
		}
		num ^= rewardId_.GetHashCode();
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
		if (EventGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventGroupId);
		}
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
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
		if (EventGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventGroupId);
		}
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EventRewardHistoryDBInfo other)
	{
		if (other != null)
		{
			if (other.EventScheduleId != 0)
			{
				EventScheduleId = other.EventScheduleId;
			}
			if (other.EventGroupId != 0)
			{
				EventGroupId = other.EventGroupId;
			}
			rewardId_.Add(other.rewardId_);
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
			case 8u:
				EventScheduleId = input.ReadInt32();
				break;
			case 16u:
				EventGroupId = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
