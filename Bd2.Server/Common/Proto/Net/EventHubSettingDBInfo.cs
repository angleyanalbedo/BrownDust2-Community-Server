using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventHubSettingDBInfo : IMessage<EventHubSettingDBInfo>, IMessage, IEquatable<EventHubSettingDBInfo>, IDeepCloneable<EventHubSettingDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EventHubSettingDBInfo> _parser = new MessageParser<EventHubSettingDBInfo>(() => new EventHubSettingDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int SlotFieldNumber = 1;

	private int slot_;

	public const int HubContentTypeFieldNumber = 2;

	private int hubContentType_;

	public const int EventUidFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_eventUid_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> eventUid_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventHubSettingDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EventHubSettingDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HubContentType
	{
		get
		{
			return hubContentType_;
		}
		set
		{
			hubContentType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> EventUid => eventUid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventHubSettingDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventHubSettingDBInfo(EventHubSettingDBInfo other)
		: this()
	{
		slot_ = other.slot_;
		hubContentType_ = other.hubContentType_;
		eventUid_ = other.eventUid_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventHubSettingDBInfo Clone()
	{
		return new EventHubSettingDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventHubSettingDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventHubSettingDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Slot == other.Slot && HubContentType == other.HubContentType && eventUid_.Equals(other.eventUid_))
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
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (HubContentType != 0)
		{
			num ^= HubContentType.GetHashCode();
		}
		num ^= eventUid_.GetHashCode();
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
		if (Slot != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Slot);
		}
		if (HubContentType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(HubContentType);
		}
		eventUid_.WriteTo(ref output, _repeated_eventUid_codec);
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
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Slot);
		}
		if (HubContentType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HubContentType);
		}
		num += eventUid_.CalculateSize(_repeated_eventUid_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventHubSettingDBInfo other)
	{
		if (other != null)
		{
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			if (other.HubContentType != 0)
			{
				HubContentType = other.HubContentType;
			}
			eventUid_.Add(other.eventUid_);
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
				Slot = input.ReadInt32();
				break;
			case 16u:
				HubContentType = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				eventUid_.AddEntriesFrom(ref input, _repeated_eventUid_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
