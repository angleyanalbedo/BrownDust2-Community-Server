using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class UserAlterTable : IMessage<UserAlterTable>, IMessage, IEquatable<UserAlterTable>, IDeepCloneable<UserAlterTable>, IBufferMessage
{
	private static readonly MessageParser<UserAlterTable> _parser = new MessageParser<UserAlterTable>(() => new UserAlterTable());

	private UnknownFieldSet _unknownFields;

	public const int ConditionTypeFieldNumber = 1;

	private int conditionType_;

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ItemCountFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_itemCount_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> itemCount_ = new RepeatedField<int>();

	public const int ItemIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_itemId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> itemId_ = new RepeatedField<int>();

	public const int ItemTypeFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_itemType_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> itemType_ = new RepeatedField<int>();

	public const int PackIdFieldNumber = 7;

	private int packId_;

	public const int QuestIdFieldNumber = 8;

	private int questId_;

	public const int QuestLevelFieldNumber = 9;

	private int questLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UserAlterTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => UserAlterTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ItemCount => itemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ItemId => itemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ItemType => itemType_;

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
	public UserAlterTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UserAlterTable(UserAlterTable other)
		: this()
	{
		conditionType_ = other.conditionType_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		itemCount_ = other.itemCount_.Clone();
		itemId_ = other.itemId_.Clone();
		itemType_ = other.itemType_.Clone();
		packId_ = other.packId_;
		questId_ = other.questId_;
		questLevel_ = other.questLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserAlterTable Clone()
	{
		return new UserAlterTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UserAlterTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UserAlterTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ConditionType == other.ConditionType && GroupId == other.GroupId && Id == other.Id && itemCount_.Equals(other.itemCount_) && itemId_.Equals(other.itemId_) && itemType_.Equals(other.itemType_) && PackId == other.PackId && QuestId == other.QuestId && QuestLevel == other.QuestLevel)
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
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= itemCount_.GetHashCode();
		num ^= itemId_.GetHashCode();
		num ^= itemType_.GetHashCode();
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
		}
		if (QuestLevel != 0)
		{
			num ^= QuestLevel.GetHashCode();
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
		if (ConditionType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionType);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		itemCount_.WriteTo(ref output, _repeated_itemCount_codec);
		itemId_.WriteTo(ref output, _repeated_itemId_codec);
		itemType_.WriteTo(ref output, _repeated_itemType_codec);
		if (PackId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(PackId);
		}
		if (QuestId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(QuestId);
		}
		if (QuestLevel != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(QuestLevel);
		}
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
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += itemCount_.CalculateSize(_repeated_itemCount_codec);
		num += itemId_.CalculateSize(_repeated_itemId_codec);
		num += itemType_.CalculateSize(_repeated_itemType_codec);
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestId);
		}
		if (QuestLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(UserAlterTable other)
	{
		if (other != null)
		{
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			itemCount_.Add(other.itemCount_);
			itemId_.Add(other.itemId_);
			itemType_.Add(other.itemType_);
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			if (other.QuestLevel != 0)
			{
				QuestLevel = other.QuestLevel;
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
				ConditionType = input.ReadInt32();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				itemCount_.AddEntriesFrom(ref input, _repeated_itemCount_codec);
				break;
			case 48u:
			case 50u:
				itemType_.AddEntriesFrom(ref input, _repeated_itemType_codec);
				break;
			case 56u:
				PackId = input.ReadInt32();
				break;
			case 64u:
				QuestId = input.ReadInt32();
				break;
			case 72u:
				QuestLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 40u:
			case 42u:
				itemId_.AddEntriesFrom(ref input, _repeated_itemId_codec);
				break;
			}
		}
	}
}
