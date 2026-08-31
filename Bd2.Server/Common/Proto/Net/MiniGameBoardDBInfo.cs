using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameBoardDBInfo : IMessage<MiniGameBoardDBInfo>, IMessage, IEquatable<MiniGameBoardDBInfo>, IDeepCloneable<MiniGameBoardDBInfo>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBoardDBInfo> _parser = new MessageParser<MiniGameBoardDBInfo>(() => new MiniGameBoardDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int EventScheduleIdFieldNumber = 1;

	private int eventScheduleId_;

	public const int ScaffoldGroupIdFieldNumber = 2;

	private int scaffoldGroupId_;

	public const int ScaffoldIdFieldNumber = 3;

	private int scaffoldId_;

	public const int CompleteCountFieldNumber = 4;

	private int completeCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameBoardDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameBoardDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int ScaffoldGroupId
	{
		get
		{
			return scaffoldGroupId_;
		}
		set
		{
			scaffoldGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScaffoldId
	{
		get
		{
			return scaffoldId_;
		}
		set
		{
			scaffoldId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CompleteCount
	{
		get
		{
			return completeCount_;
		}
		set
		{
			completeCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBoardDBInfo(MiniGameBoardDBInfo other)
		: this()
	{
		eventScheduleId_ = other.eventScheduleId_;
		scaffoldGroupId_ = other.scaffoldGroupId_;
		scaffoldId_ = other.scaffoldId_;
		completeCount_ = other.completeCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardDBInfo Clone()
	{
		return new MiniGameBoardDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBoardDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameBoardDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventScheduleId == other.EventScheduleId && ScaffoldGroupId == other.ScaffoldGroupId && ScaffoldId == other.ScaffoldId && CompleteCount == other.CompleteCount)
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
		if (EventScheduleId != 0)
		{
			num ^= EventScheduleId.GetHashCode();
		}
		if (ScaffoldGroupId != 0)
		{
			num ^= ScaffoldGroupId.GetHashCode();
		}
		if (ScaffoldId != 0)
		{
			num ^= ScaffoldId.GetHashCode();
		}
		if (CompleteCount != 0)
		{
			num ^= CompleteCount.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (EventScheduleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventScheduleId);
		}
		if (ScaffoldGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ScaffoldGroupId);
		}
		if (ScaffoldId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ScaffoldId);
		}
		if (CompleteCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CompleteCount);
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
		if (ScaffoldGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScaffoldGroupId);
		}
		if (ScaffoldId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScaffoldId);
		}
		if (CompleteCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompleteCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameBoardDBInfo other)
	{
		if (other != null)
		{
			if (other.EventScheduleId != 0)
			{
				EventScheduleId = other.EventScheduleId;
			}
			if (other.ScaffoldGroupId != 0)
			{
				ScaffoldGroupId = other.ScaffoldGroupId;
			}
			if (other.ScaffoldId != 0)
			{
				ScaffoldId = other.ScaffoldId;
			}
			if (other.CompleteCount != 0)
			{
				CompleteCount = other.CompleteCount;
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
				EventScheduleId = input.ReadInt32();
				break;
			case 16u:
				ScaffoldGroupId = input.ReadInt32();
				break;
			case 24u:
				ScaffoldId = input.ReadInt32();
				break;
			case 32u:
				CompleteCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
