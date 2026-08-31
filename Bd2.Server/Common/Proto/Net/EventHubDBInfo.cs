using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventHubDBInfo : IMessage<EventHubDBInfo>, IMessage, IEquatable<EventHubDBInfo>, IDeepCloneable<EventHubDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EventHubDBInfo> _parser = new MessageParser<EventHubDBInfo>(() => new EventHubDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 1;

	private int uid_;

	public const int HubIdFieldNumber = 2;

	private int hubId_;

	public const int StartTimeFieldNumber = 3;

	private long startTime_;

	public const int PlayEndTimeFieldNumber = 4;

	private long playEndTime_;

	public const int EndTimeFieldNumber = 5;

	private long endTime_;

	public const int SettingInfoFieldNumber = 6;

	private static readonly FieldCodec<EventHubSettingDBInfo> _repeated_settingInfo_codec = FieldCodec.ForMessage(50u, EventHubSettingDBInfo.Parser);

	private readonly RepeatedField<EventHubSettingDBInfo> settingInfo_ = new RepeatedField<EventHubSettingDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventHubDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventHubDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HubId
	{
		get
		{
			return hubId_;
		}
		set
		{
			hubId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long StartTime
	{
		get
		{
			return startTime_;
		}
		set
		{
			startTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayEndTime
	{
		get
		{
			return playEndTime_;
		}
		set
		{
			playEndTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EventHubSettingDBInfo> SettingInfo => settingInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventHubDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EventHubDBInfo(EventHubDBInfo other)
		: this()
	{
		uid_ = other.uid_;
		hubId_ = other.hubId_;
		startTime_ = other.startTime_;
		playEndTime_ = other.playEndTime_;
		endTime_ = other.endTime_;
		settingInfo_ = other.settingInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventHubDBInfo Clone()
	{
		return new EventHubDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventHubDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventHubDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Uid == other.Uid && HubId == other.HubId && StartTime == other.StartTime && PlayEndTime == other.PlayEndTime && EndTime == other.EndTime && settingInfo_.Equals(other.settingInfo_))
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
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (HubId != 0)
		{
			num ^= HubId.GetHashCode();
		}
		if (StartTime != 0L)
		{
			num ^= StartTime.GetHashCode();
		}
		if (PlayEndTime != 0L)
		{
			num ^= PlayEndTime.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		num ^= settingInfo_.GetHashCode();
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
		if (Uid != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Uid);
		}
		if (HubId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(HubId);
		}
		if (StartTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(StartTime);
		}
		if (PlayEndTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(PlayEndTime);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(EndTime);
		}
		settingInfo_.WriteTo(ref output, _repeated_settingInfo_codec);
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
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Uid);
		}
		if (HubId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HubId);
		}
		if (StartTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StartTime);
		}
		if (PlayEndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(PlayEndTime);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		num += settingInfo_.CalculateSize(_repeated_settingInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventHubDBInfo other)
	{
		if (other != null)
		{
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.HubId != 0)
			{
				HubId = other.HubId;
			}
			if (other.StartTime != 0L)
			{
				StartTime = other.StartTime;
			}
			if (other.PlayEndTime != 0L)
			{
				PlayEndTime = other.PlayEndTime;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			settingInfo_.Add(other.settingInfo_);
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
				Uid = input.ReadInt32();
				break;
			case 16u:
				HubId = input.ReadInt32();
				break;
			case 24u:
				StartTime = input.ReadInt64();
				break;
			case 32u:
				PlayEndTime = input.ReadInt64();
				break;
			case 40u:
				EndTime = input.ReadInt64();
				break;
			case 50u:
				settingInfo_.AddEntriesFrom(ref input, _repeated_settingInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
