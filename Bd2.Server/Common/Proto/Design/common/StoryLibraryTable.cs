using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class StoryLibraryTable : IMessage<StoryLibraryTable>, IMessage, IEquatable<StoryLibraryTable>, IDeepCloneable<StoryLibraryTable>, IBufferMessage
{
	private static readonly MessageParser<StoryLibraryTable> _parser = new MessageParser<StoryLibraryTable>(() => new StoryLibraryTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int IsPrologFieldNumber = 2;

	private int isProlog_;

	public const int MapIdFieldNumber = 3;

	private int mapId_;

	public const int PackIdFieldNumber = 4;

	private int packId_;

	public const int QuestConditionQuestTextIdFieldNumber = 5;

	private int questConditionQuestTextId_;

	public const int QuestDescQuestTextIdFieldNumber = 6;

	private int questDescQuestTextId_;

	public const int QuestGroupIdFieldNumber = 7;

	private int questGroupId_;

	public const int QuestIdFieldNumber = 8;

	private int questId_;

	public const int QuestNameQuestTextIdFieldNumber = 9;

	private int questNameQuestTextId_;

	public const int QuestTypeIdFieldNumber = 10;

	private int questTypeId_;

	public const int StoryTypeFieldNumber = 11;

	private int storyType_;

	public const int TimelineNameFieldNumber = 12;

	private string timelineName_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<StoryLibraryTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => StoryLibraryTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int IsProlog
	{
		get
		{
			return isProlog_;
		}
		set
		{
			isProlog_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestConditionQuestTextId
	{
		get
		{
			return questConditionQuestTextId_;
		}
		set
		{
			questConditionQuestTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestDescQuestTextId
	{
		get
		{
			return questDescQuestTextId_;
		}
		set
		{
			questDescQuestTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestGroupId
	{
		get
		{
			return questGroupId_;
		}
		set
		{
			questGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestId
	{
		get
		{
			return questId_;
		}
		set
		{
			questId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestNameQuestTextId
	{
		get
		{
			return questNameQuestTextId_;
		}
		set
		{
			questNameQuestTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestTypeId
	{
		get
		{
			return questTypeId_;
		}
		set
		{
			questTypeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StoryType
	{
		get
		{
			return storyType_;
		}
		set
		{
			storyType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TimelineName
	{
		get
		{
			return timelineName_;
		}
		set
		{
			timelineName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StoryLibraryTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public StoryLibraryTable(StoryLibraryTable other)
		: this()
	{
		id_ = other.id_;
		isProlog_ = other.isProlog_;
		mapId_ = other.mapId_;
		packId_ = other.packId_;
		questConditionQuestTextId_ = other.questConditionQuestTextId_;
		questDescQuestTextId_ = other.questDescQuestTextId_;
		questGroupId_ = other.questGroupId_;
		questId_ = other.questId_;
		questNameQuestTextId_ = other.questNameQuestTextId_;
		questTypeId_ = other.questTypeId_;
		storyType_ = other.storyType_;
		timelineName_ = other.timelineName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StoryLibraryTable Clone()
	{
		return new StoryLibraryTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StoryLibraryTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(StoryLibraryTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && IsProlog == other.IsProlog && MapId == other.MapId && PackId == other.PackId && QuestConditionQuestTextId == other.QuestConditionQuestTextId && QuestDescQuestTextId == other.QuestDescQuestTextId && QuestGroupId == other.QuestGroupId && QuestId == other.QuestId && QuestNameQuestTextId == other.QuestNameQuestTextId && QuestTypeId == other.QuestTypeId && StoryType == other.StoryType && !(TimelineName != other.TimelineName))
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
		if (IsProlog != 0)
		{
			num ^= IsProlog.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (QuestConditionQuestTextId != 0)
		{
			num ^= QuestConditionQuestTextId.GetHashCode();
		}
		if (QuestDescQuestTextId != 0)
		{
			num ^= QuestDescQuestTextId.GetHashCode();
		}
		if (QuestGroupId != 0)
		{
			num ^= QuestGroupId.GetHashCode();
		}
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
		}
		if (QuestNameQuestTextId != 0)
		{
			num ^= QuestNameQuestTextId.GetHashCode();
		}
		if (QuestTypeId != 0)
		{
			num ^= QuestTypeId.GetHashCode();
		}
		if (StoryType != 0)
		{
			num ^= StoryType.GetHashCode();
		}
		if (TimelineName.Length != 0)
		{
			num ^= TimelineName.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (IsProlog != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(IsProlog);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MapId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PackId);
		}
		if (QuestConditionQuestTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(QuestConditionQuestTextId);
		}
		if (QuestDescQuestTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(QuestDescQuestTextId);
		}
		if (QuestGroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(QuestGroupId);
		}
		if (QuestId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(QuestId);
		}
		if (QuestNameQuestTextId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(QuestNameQuestTextId);
		}
		if (QuestTypeId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(QuestTypeId);
		}
		if (StoryType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(StoryType);
		}
		if (TimelineName.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(TimelineName);
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
		if (IsProlog != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsProlog);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (QuestConditionQuestTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestConditionQuestTextId);
		}
		if (QuestDescQuestTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestDescQuestTextId);
		}
		if (QuestGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestGroupId);
		}
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestId);
		}
		if (QuestNameQuestTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestNameQuestTextId);
		}
		if (QuestTypeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestTypeId);
		}
		if (StoryType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StoryType);
		}
		if (TimelineName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TimelineName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StoryLibraryTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsProlog != 0)
			{
				IsProlog = other.IsProlog;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.QuestConditionQuestTextId != 0)
			{
				QuestConditionQuestTextId = other.QuestConditionQuestTextId;
			}
			if (other.QuestDescQuestTextId != 0)
			{
				QuestDescQuestTextId = other.QuestDescQuestTextId;
			}
			if (other.QuestGroupId != 0)
			{
				QuestGroupId = other.QuestGroupId;
			}
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			if (other.QuestNameQuestTextId != 0)
			{
				QuestNameQuestTextId = other.QuestNameQuestTextId;
			}
			if (other.QuestTypeId != 0)
			{
				QuestTypeId = other.QuestTypeId;
			}
			if (other.StoryType != 0)
			{
				StoryType = other.StoryType;
			}
			if (other.TimelineName.Length != 0)
			{
				TimelineName = other.TimelineName;
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
				IsProlog = input.ReadInt32();
				break;
			case 24u:
				MapId = input.ReadInt32();
				break;
			case 32u:
				PackId = input.ReadInt32();
				break;
			case 40u:
				QuestConditionQuestTextId = input.ReadInt32();
				break;
			case 48u:
				QuestDescQuestTextId = input.ReadInt32();
				break;
			case 56u:
				QuestGroupId = input.ReadInt32();
				break;
			case 64u:
				QuestId = input.ReadInt32();
				break;
			case 72u:
				QuestNameQuestTextId = input.ReadInt32();
				break;
			case 80u:
				QuestTypeId = input.ReadInt32();
				break;
			case 88u:
				StoryType = input.ReadInt32();
				break;
			case 98u:
				TimelineName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
