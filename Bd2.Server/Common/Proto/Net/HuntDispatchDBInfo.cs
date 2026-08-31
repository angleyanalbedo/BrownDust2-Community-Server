using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class HuntDispatchDBInfo : IMessage<HuntDispatchDBInfo>, IMessage, IEquatable<HuntDispatchDBInfo>, IDeepCloneable<HuntDispatchDBInfo>, IBufferMessage
{
	private static readonly MessageParser<HuntDispatchDBInfo> _parser = new MessageParser<HuntDispatchDBInfo>(() => new HuntDispatchDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int HuntDispatchGroupIdFieldNumber = 1;

	private int huntDispatchGroupId_;

	public const int HuntDispatchIdFieldNumber = 2;

	private int huntDispatchId_;

	public const int CountFieldNumber = 3;

	private int count_;

	public const int StartTimeFieldNumber = 4;

	private long startTime_;

	public const int EndTimeFieldNumber = 5;

	private long endTime_;

	public const int DecreaseFreeApCountFieldNumber = 6;

	private int decreaseFreeApCount_;

	public const int DecreaseCashApCountFieldNumber = 7;

	private int decreaseCashApCount_;

	public int CurrentCount { get; set; }

	public int RemainAP { get; set; }

	public bool IsNotReturnFreeAP { get; set; }

	public bool IsPreview { get; set; }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HuntDispatchDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HuntDispatchDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HuntDispatchGroupId
	{
		get
		{
			return huntDispatchGroupId_;
		}
		set
		{
			huntDispatchGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HuntDispatchId
	{
		get
		{
			return huntDispatchId_;
		}
		set
		{
			huntDispatchId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int DecreaseFreeApCount
	{
		get
		{
			return decreaseFreeApCount_;
		}
		set
		{
			decreaseFreeApCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DecreaseCashApCount
	{
		get
		{
			return decreaseCashApCount_;
		}
		set
		{
			decreaseCashApCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchDBInfo(HuntDispatchDBInfo other)
		: this()
	{
		huntDispatchGroupId_ = other.huntDispatchGroupId_;
		huntDispatchId_ = other.huntDispatchId_;
		count_ = other.count_;
		startTime_ = other.startTime_;
		endTime_ = other.endTime_;
		decreaseFreeApCount_ = other.decreaseFreeApCount_;
		decreaseCashApCount_ = other.decreaseCashApCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntDispatchDBInfo Clone()
	{
		return new HuntDispatchDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HuntDispatchDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HuntDispatchDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (HuntDispatchGroupId == other.HuntDispatchGroupId && HuntDispatchId == other.HuntDispatchId && Count == other.Count && StartTime == other.StartTime && EndTime == other.EndTime && DecreaseFreeApCount == other.DecreaseFreeApCount && DecreaseCashApCount == other.DecreaseCashApCount)
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
		if (HuntDispatchGroupId != 0)
		{
			num ^= HuntDispatchGroupId.GetHashCode();
		}
		if (HuntDispatchId != 0)
		{
			num ^= HuntDispatchId.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (StartTime != 0L)
		{
			num ^= StartTime.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (DecreaseFreeApCount != 0)
		{
			num ^= DecreaseFreeApCount.GetHashCode();
		}
		if (DecreaseCashApCount != 0)
		{
			num ^= DecreaseCashApCount.GetHashCode();
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
		if (HuntDispatchGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(HuntDispatchGroupId);
		}
		if (HuntDispatchId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(HuntDispatchId);
		}
		if (Count != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Count);
		}
		if (StartTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(StartTime);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(EndTime);
		}
		if (DecreaseFreeApCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DecreaseFreeApCount);
		}
		if (DecreaseCashApCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DecreaseCashApCount);
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
		if (HuntDispatchGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HuntDispatchGroupId);
		}
		if (HuntDispatchId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HuntDispatchId);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Count);
		}
		if (StartTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StartTime);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (DecreaseFreeApCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DecreaseFreeApCount);
		}
		if (DecreaseCashApCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DecreaseCashApCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HuntDispatchDBInfo other)
	{
		if (other != null)
		{
			if (other.HuntDispatchGroupId != 0)
			{
				HuntDispatchGroupId = other.HuntDispatchGroupId;
			}
			if (other.HuntDispatchId != 0)
			{
				HuntDispatchId = other.HuntDispatchId;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.StartTime != 0L)
			{
				StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.DecreaseFreeApCount != 0)
			{
				DecreaseFreeApCount = other.DecreaseFreeApCount;
			}
			if (other.DecreaseCashApCount != 0)
			{
				DecreaseCashApCount = other.DecreaseCashApCount;
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
				HuntDispatchGroupId = input.ReadInt32();
				break;
			case 16u:
				HuntDispatchId = input.ReadInt32();
				break;
			case 24u:
				Count = input.ReadInt32();
				break;
			case 32u:
				StartTime = input.ReadInt64();
				break;
			case 40u:
				EndTime = input.ReadInt64();
				break;
			case 48u:
				DecreaseFreeApCount = input.ReadInt32();
				break;
			case 56u:
				DecreaseCashApCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
