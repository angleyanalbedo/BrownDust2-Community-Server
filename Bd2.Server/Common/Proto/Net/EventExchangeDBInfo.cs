using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EventExchangeDBInfo : IMessage<EventExchangeDBInfo>, IMessage, IEquatable<EventExchangeDBInfo>, IDeepCloneable<EventExchangeDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EventExchangeDBInfo> _parser = new MessageParser<EventExchangeDBInfo>(() => new EventExchangeDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int EventUidFieldNumber = 1;

	private int eventUid_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int PageFieldNumber = 3;

	private int page_;

	public const int KeyCountFieldNumber = 4;

	private int keyCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventExchangeDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EventExchangeDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventUid
	{
		get
		{
			return eventUid_;
		}
		set
		{
			eventUid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Page
	{
		get
		{
			return page_;
		}
		set
		{
			page_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int KeyCount
	{
		get
		{
			return keyCount_;
		}
		set
		{
			keyCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeDBInfo(EventExchangeDBInfo other)
		: this()
	{
		eventUid_ = other.eventUid_;
		groupId_ = other.groupId_;
		page_ = other.page_;
		keyCount_ = other.keyCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventExchangeDBInfo Clone()
	{
		return new EventExchangeDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EventExchangeDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventExchangeDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventUid == other.EventUid && GroupId == other.GroupId && Page == other.Page && KeyCount == other.KeyCount)
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
		if (EventUid != 0)
		{
			num ^= EventUid.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Page != 0)
		{
			num ^= Page.GetHashCode();
		}
		if (KeyCount != 0)
		{
			num ^= KeyCount.GetHashCode();
		}
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (EventUid != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventUid);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (Page != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Page);
		}
		if (KeyCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(KeyCount);
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
		if (EventUid != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventUid);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Page != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Page);
		}
		if (KeyCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KeyCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventExchangeDBInfo other)
	{
		if (other != null)
		{
			if (other.EventUid != 0)
			{
				EventUid = other.EventUid;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Page != 0)
			{
				Page = other.Page;
			}
			if (other.KeyCount != 0)
			{
				KeyCount = other.KeyCount;
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
			case 8u:
				EventUid = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				Page = input.ReadInt32();
				break;
			case 32u:
				KeyCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
