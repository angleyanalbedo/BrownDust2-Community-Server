using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackDBInfo : IMessage<PackDBInfo>, IMessage, IEquatable<PackDBInfo>, IDeepCloneable<PackDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PackDBInfo> _parser = new MessageParser<PackDBInfo>(() => new PackDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int ClearQuestCountFieldNumber = 2;

	private int clearQuestCount_;

	public const int IsPackCompleteFieldNumber = 3;

	private bool isPackComplete_;

	public const int QuestLevelFieldNumber = 4;

	private int questLevel_;

	public const int QuestOptFieldNumber = 5;

	private int questOpt_;

	public const int SubQuestCountFieldNumber = 6;

	private int subQuestCount_;

	public const int ActiveTimeFieldNumber = 7;

	private long activeTime_;

	public bool IsNew { get; set; }

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClearQuestCount
	{
		get
		{
			return clearQuestCount_;
		}
		set
		{
			clearQuestCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsPackComplete
	{
		get
		{
			return isPackComplete_;
		}
		set
		{
			isPackComplete_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestLevel
	{
		get
		{
			return questLevel_;
		}
		set
		{
			questLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestOpt
	{
		get
		{
			return questOpt_;
		}
		set
		{
			questOpt_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SubQuestCount
	{
		get
		{
			return subQuestCount_;
		}
		set
		{
			subQuestCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ActiveTime
	{
		get
		{
			return activeTime_;
		}
		set
		{
			activeTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackDBInfo(PackDBInfo other)
		: this()
	{
		id_ = other.id_;
		clearQuestCount_ = other.clearQuestCount_;
		isPackComplete_ = other.isPackComplete_;
		questLevel_ = other.questLevel_;
		questOpt_ = other.questOpt_;
		subQuestCount_ = other.subQuestCount_;
		activeTime_ = other.activeTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackDBInfo Clone()
	{
		return new PackDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && ClearQuestCount == other.ClearQuestCount && IsPackComplete == other.IsPackComplete && QuestLevel == other.QuestLevel && QuestOpt == other.QuestOpt && SubQuestCount == other.SubQuestCount && ActiveTime == other.ActiveTime)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ClearQuestCount != 0)
		{
			num ^= ClearQuestCount.GetHashCode();
		}
		if (IsPackComplete)
		{
			num ^= IsPackComplete.GetHashCode();
		}
		if (QuestLevel != 0)
		{
			num ^= QuestLevel.GetHashCode();
		}
		if (QuestOpt != 0)
		{
			num ^= QuestOpt.GetHashCode();
		}
		if (SubQuestCount != 0)
		{
			num ^= SubQuestCount.GetHashCode();
		}
		if (ActiveTime != 0L)
		{
			num ^= ActiveTime.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ClearQuestCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ClearQuestCount);
		}
		if (IsPackComplete)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsPackComplete);
		}
		if (QuestLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(QuestLevel);
		}
		if (QuestOpt != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(QuestOpt);
		}
		if (SubQuestCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SubQuestCount);
		}
		if (ActiveTime != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(ActiveTime);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ClearQuestCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearQuestCount);
		}
		if (IsPackComplete)
		{
			num += 2;
		}
		if (QuestLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestLevel);
		}
		if (QuestOpt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestOpt);
		}
		if (SubQuestCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubQuestCount);
		}
		if (ActiveTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ActiveTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackDBInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ClearQuestCount != 0)
			{
				ClearQuestCount = other.ClearQuestCount;
			}
			if (other.IsPackComplete)
			{
				IsPackComplete = other.IsPackComplete;
			}
			if (other.QuestLevel != 0)
			{
				QuestLevel = other.QuestLevel;
			}
			if (other.QuestOpt != 0)
			{
				QuestOpt = other.QuestOpt;
			}
			if (other.SubQuestCount != 0)
			{
				SubQuestCount = other.SubQuestCount;
			}
			if (other.ActiveTime != 0L)
			{
				ActiveTime = other.ActiveTime;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				ClearQuestCount = input.ReadInt32();
				break;
			case 24u:
				IsPackComplete = input.ReadBool();
				break;
			case 32u:
				QuestLevel = input.ReadInt32();
				break;
			case 40u:
				QuestOpt = input.ReadInt32();
				break;
			case 48u:
				SubQuestCount = input.ReadInt32();
				break;
			case 56u:
				ActiveTime = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
