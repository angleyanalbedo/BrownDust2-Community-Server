using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EventMissionGroupTable : IMessage<EventMissionGroupTable>, IMessage, IEquatable<EventMissionGroupTable>, IDeepCloneable<EventMissionGroupTable>, IBufferMessage
{
	private static readonly MessageParser<EventMissionGroupTable> _parser = new MessageParser<EventMissionGroupTable>(() => new EventMissionGroupTable());

	private UnknownFieldSet _unknownFields;

	public const int EventMissionTypeFieldNumber = 1;

	private int eventMissionType_;

	public const int EventNameTextIdFieldNumber = 2;

	private int eventNameTextId_;

	public const int GuideDescLocalTextIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_guideDescLocalTextId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> guideDescLocalTextId_ = new RepeatedField<int>();

	public const int GuideTitleLocalTextIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_guideTitleLocalTextId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> guideTitleLocalTextId_ = new RepeatedField<int>();

	public const int IdFieldNumber = 5;

	private int id_;

	public const int MissionGroupIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_missionGroupId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> missionGroupId_ = new RepeatedField<int>();

	public const int ScheduleTypeFieldNumber = 7;

	private int scheduleType_;

	public const int SortIdFieldNumber = 8;

	private int sortId_;

	public const int UsePassFieldNumber = 9;

	private int usePass_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EventMissionGroupTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EventMissionGroupTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventMissionType
	{
		get
		{
			return eventMissionType_;
		}
		set
		{
			eventMissionType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventNameTextId
	{
		get
		{
			return eventNameTextId_;
		}
		set
		{
			eventNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GuideDescLocalTextId => guideDescLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GuideTitleLocalTextId => guideTitleLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MissionGroupId => missionGroupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ScheduleType
	{
		get
		{
			return scheduleType_;
		}
		set
		{
			scheduleType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UsePass
	{
		get
		{
			return usePass_;
		}
		set
		{
			usePass_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventMissionGroupTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventMissionGroupTable(EventMissionGroupTable other)
		: this()
	{
		eventMissionType_ = other.eventMissionType_;
		eventNameTextId_ = other.eventNameTextId_;
		guideDescLocalTextId_ = other.guideDescLocalTextId_.Clone();
		guideTitleLocalTextId_ = other.guideTitleLocalTextId_.Clone();
		id_ = other.id_;
		missionGroupId_ = other.missionGroupId_.Clone();
		scheduleType_ = other.scheduleType_;
		sortId_ = other.sortId_;
		usePass_ = other.usePass_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventMissionGroupTable Clone()
	{
		return new EventMissionGroupTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventMissionGroupTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EventMissionGroupTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventMissionType == other.EventMissionType && EventNameTextId == other.EventNameTextId && guideDescLocalTextId_.Equals(other.guideDescLocalTextId_) && guideTitleLocalTextId_.Equals(other.guideTitleLocalTextId_) && Id == other.Id && missionGroupId_.Equals(other.missionGroupId_) && ScheduleType == other.ScheduleType && SortId == other.SortId && UsePass == other.UsePass)
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
		if (EventMissionType != 0)
		{
			num ^= EventMissionType.GetHashCode();
		}
		if (EventNameTextId != 0)
		{
			num ^= EventNameTextId.GetHashCode();
		}
		num ^= guideDescLocalTextId_.GetHashCode();
		num ^= guideTitleLocalTextId_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= missionGroupId_.GetHashCode();
		if (ScheduleType != 0)
		{
			num ^= ScheduleType.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (UsePass != 0)
		{
			num ^= UsePass.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (EventMissionType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventMissionType);
		}
		if (EventNameTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventNameTextId);
		}
		guideDescLocalTextId_.WriteTo(ref output, _repeated_guideDescLocalTextId_codec);
		guideTitleLocalTextId_.WriteTo(ref output, _repeated_guideTitleLocalTextId_codec);
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		missionGroupId_.WriteTo(ref output, _repeated_missionGroupId_codec);
		if (ScheduleType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ScheduleType);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SortId);
		}
		if (UsePass != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(UsePass);
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
		if (EventMissionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventMissionType);
		}
		if (EventNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventNameTextId);
		}
		num += guideDescLocalTextId_.CalculateSize(_repeated_guideDescLocalTextId_codec);
		num += guideTitleLocalTextId_.CalculateSize(_repeated_guideTitleLocalTextId_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += missionGroupId_.CalculateSize(_repeated_missionGroupId_codec);
		if (ScheduleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScheduleType);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (UsePass != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UsePass);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventMissionGroupTable other)
	{
		if (other != null)
		{
			if (other.EventMissionType != 0)
			{
				EventMissionType = other.EventMissionType;
			}
			if (other.EventNameTextId != 0)
			{
				EventNameTextId = other.EventNameTextId;
			}
			guideDescLocalTextId_.Add(other.guideDescLocalTextId_);
			guideTitleLocalTextId_.Add(other.guideTitleLocalTextId_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			missionGroupId_.Add(other.missionGroupId_);
			if (other.ScheduleType != 0)
			{
				ScheduleType = other.ScheduleType;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.UsePass != 0)
			{
				UsePass = other.UsePass;
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
				EventMissionType = input.ReadInt32();
				break;
			case 16u:
				EventNameTextId = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				guideTitleLocalTextId_.AddEntriesFrom(ref input, _repeated_guideTitleLocalTextId_codec);
				break;
			case 24u:
			case 26u:
				guideDescLocalTextId_.AddEntriesFrom(ref input, _repeated_guideDescLocalTextId_codec);
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				missionGroupId_.AddEntriesFrom(ref input, _repeated_missionGroupId_codec);
				break;
			case 56u:
				ScheduleType = input.ReadInt32();
				break;
			case 64u:
				SortId = input.ReadInt32();
				break;
			case 72u:
				UsePass = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
