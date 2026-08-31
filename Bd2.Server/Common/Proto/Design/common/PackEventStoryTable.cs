using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackEventStoryTable : IMessage<PackEventStoryTable>, IMessage, IEquatable<PackEventStoryTable>, IDeepCloneable<PackEventStoryTable>, IBufferMessage
{
	private static readonly MessageParser<PackEventStoryTable> _parser = new MessageParser<PackEventStoryTable>(() => new PackEventStoryTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int MapIdFieldNumber = 3;

	private int mapId_;

	public const int PackIdFieldNumber = 4;

	private int packId_;

	public const int QuestConditionQuestTextIdFieldNumber = 5;

	private int questConditionQuestTextId_;

	public const int QuestGroupIdFieldNumber = 6;

	private int questGroupId_;

	public const int QuestNameQuestTextIdFieldNumber = 7;

	private int questNameQuestTextId_;

	public const int QuestTitleQuestTextIdFieldNumber = 8;

	private int questTitleQuestTextId_;

	public const int RewardCountFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int TimelineNameFieldNumber = 12;

	private string timelineName_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackEventStoryTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PackEventStoryTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestTitleQuestTextId
	{
		get
		{
			return questTitleQuestTextId_;
		}
		set
		{
			questTitleQuestTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCount => rewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId => rewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardType => rewardType_;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackEventStoryTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventStoryTable(PackEventStoryTable other)
		: this()
	{
		groupId_ = other.groupId_;
		id_ = other.id_;
		mapId_ = other.mapId_;
		packId_ = other.packId_;
		questConditionQuestTextId_ = other.questConditionQuestTextId_;
		questGroupId_ = other.questGroupId_;
		questNameQuestTextId_ = other.questNameQuestTextId_;
		questTitleQuestTextId_ = other.questTitleQuestTextId_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		timelineName_ = other.timelineName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventStoryTable Clone()
	{
		return new PackEventStoryTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PackEventStoryTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackEventStoryTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && Id == other.Id && MapId == other.MapId && PackId == other.PackId && QuestConditionQuestTextId == other.QuestConditionQuestTextId && QuestGroupId == other.QuestGroupId && QuestNameQuestTextId == other.QuestNameQuestTextId && QuestTitleQuestTextId == other.QuestTitleQuestTextId && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_) && !(TimelineName != other.TimelineName))
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (QuestGroupId != 0)
		{
			num ^= QuestGroupId.GetHashCode();
		}
		if (QuestNameQuestTextId != 0)
		{
			num ^= QuestNameQuestTextId.GetHashCode();
		}
		if (QuestTitleQuestTextId != 0)
		{
			num ^= QuestTitleQuestTextId.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
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
		if (QuestGroupId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(QuestGroupId);
		}
		if (QuestNameQuestTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(QuestNameQuestTextId);
		}
		if (QuestTitleQuestTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(QuestTitleQuestTextId);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
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
		if (QuestGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestGroupId);
		}
		if (QuestNameQuestTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestNameQuestTextId);
		}
		if (QuestTitleQuestTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestTitleQuestTextId);
		}
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PackEventStoryTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			if (other.QuestGroupId != 0)
			{
				QuestGroupId = other.QuestGroupId;
			}
			if (other.QuestNameQuestTextId != 0)
			{
				QuestNameQuestTextId = other.QuestNameQuestTextId;
			}
			if (other.QuestTitleQuestTextId != 0)
			{
				QuestTitleQuestTextId = other.QuestTitleQuestTextId;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
			if (other.TimelineName.Length != 0)
			{
				TimelineName = other.TimelineName;
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
			case 64u:
				QuestTitleQuestTextId = input.ReadInt32();
				break;
			case 72u:
			case 74u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 98u:
				TimelineName = input.ReadString();
				break;
			case 88u:
			case 90u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			case 80u:
			case 82u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 8u:
				GroupId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
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
				QuestGroupId = input.ReadInt32();
				break;
			case 56u:
				QuestNameQuestTextId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
