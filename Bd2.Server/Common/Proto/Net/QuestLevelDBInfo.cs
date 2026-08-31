using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestLevelDBInfo : IMessage<QuestLevelDBInfo>, IMessage, IEquatable<QuestLevelDBInfo>, IDeepCloneable<QuestLevelDBInfo>, IBufferMessage
{
	private static readonly MessageParser<QuestLevelDBInfo> _parser = new MessageParser<QuestLevelDBInfo>(() => new QuestLevelDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int PackIdFieldNumber = 1;

	private int packId_;

	public const int QuestLevelFieldNumber = 2;

	private int questLevel_;

	public const int ClearQuestFieldNumber = 3;

	private int clearQuest_;

	public const int QuestOptFieldNumber = 4;

	private int questOpt_;

	public const int IsLevelCompleteFieldNumber = 5;

	private bool isLevelComplete_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestLevelDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestLevelDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ClearQuest
	{
		get
		{
			return clearQuest_;
		}
		set
		{
			clearQuest_ = value;
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
	public bool IsLevelComplete
	{
		get
		{
			return isLevelComplete_;
		}
		set
		{
			isLevelComplete_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestLevelDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestLevelDBInfo(QuestLevelDBInfo other)
		: this()
	{
		packId_ = other.packId_;
		questLevel_ = other.questLevel_;
		clearQuest_ = other.clearQuest_;
		questOpt_ = other.questOpt_;
		isLevelComplete_ = other.isLevelComplete_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestLevelDBInfo Clone()
	{
		return new QuestLevelDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestLevelDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestLevelDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PackId == other.PackId && QuestLevel == other.QuestLevel && ClearQuest == other.ClearQuest && QuestOpt == other.QuestOpt && IsLevelComplete == other.IsLevelComplete)
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
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (QuestLevel != 0)
		{
			num ^= QuestLevel.GetHashCode();
		}
		if (ClearQuest != 0)
		{
			num ^= ClearQuest.GetHashCode();
		}
		if (QuestOpt != 0)
		{
			num ^= QuestOpt.GetHashCode();
		}
		if (IsLevelComplete)
		{
			num ^= IsLevelComplete.GetHashCode();
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
		if (PackId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PackId);
		}
		if (QuestLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(QuestLevel);
		}
		if (ClearQuest != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ClearQuest);
		}
		if (QuestOpt != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(QuestOpt);
		}
		if (IsLevelComplete)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsLevelComplete);
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
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (QuestLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestLevel);
		}
		if (ClearQuest != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearQuest);
		}
		if (QuestOpt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestOpt);
		}
		if (IsLevelComplete)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestLevelDBInfo other)
	{
		if (other != null)
		{
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.QuestLevel != 0)
			{
				QuestLevel = other.QuestLevel;
			}
			if (other.ClearQuest != 0)
			{
				ClearQuest = other.ClearQuest;
			}
			if (other.QuestOpt != 0)
			{
				QuestOpt = other.QuestOpt;
			}
			if (other.IsLevelComplete)
			{
				IsLevelComplete = other.IsLevelComplete;
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
			case 8u:
				PackId = input.ReadInt32();
				break;
			case 16u:
				QuestLevel = input.ReadInt32();
				break;
			case 24u:
				ClearQuest = input.ReadInt32();
				break;
			case 32u:
				QuestOpt = input.ReadInt32();
				break;
			case 40u:
				IsLevelComplete = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
