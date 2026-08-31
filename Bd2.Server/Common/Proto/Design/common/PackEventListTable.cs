using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackEventListTable : IMessage<PackEventListTable>, IMessage, IEquatable<PackEventListTable>, IDeepCloneable<PackEventListTable>, IBufferMessage
{
	private static readonly MessageParser<PackEventListTable> _parser = new MessageParser<PackEventListTable>(() => new PackEventListTable());

	private UnknownFieldSet _unknownFields;

	public const int ActionTypeFieldNumber = 1;

	private string actionType_ = "";

	public const int BgCharIllustNameFieldNumber = 2;

	private string bgCharIllustName_ = "";

	public const int EventHubContentIconNameFieldNumber = 3;

	private string eventHubContentIconName_ = "";

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int HubContentLocalTextIdFieldNumber = 5;

	private int hubContentLocalTextId_;

	public const int HubContentTypeFieldNumber = 6;

	private int hubContentType_;

	public const int IdFieldNumber = 7;

	private int id_;

	public const int SlotIndexFieldNumber = 8;

	private int slotIndex_;

	public const int SortIdFieldNumber = 9;

	private int sortId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackEventListTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackEventListTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ActionType
	{
		get
		{
			return actionType_;
		}
		set
		{
			actionType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BgCharIllustName
	{
		get
		{
			return bgCharIllustName_;
		}
		set
		{
			bgCharIllustName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string EventHubContentIconName
	{
		get
		{
			return eventHubContentIconName_;
		}
		set
		{
			eventHubContentIconName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int HubContentLocalTextId
	{
		get
		{
			return hubContentLocalTextId_;
		}
		set
		{
			hubContentLocalTextId_ = value;
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
	public int SlotIndex
	{
		get
		{
			return slotIndex_;
		}
		set
		{
			slotIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventListTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventListTable(PackEventListTable other)
		: this()
	{
		actionType_ = other.actionType_;
		bgCharIllustName_ = other.bgCharIllustName_;
		eventHubContentIconName_ = other.eventHubContentIconName_;
		groupId_ = other.groupId_;
		hubContentLocalTextId_ = other.hubContentLocalTextId_;
		hubContentType_ = other.hubContentType_;
		id_ = other.id_;
		slotIndex_ = other.slotIndex_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventListTable Clone()
	{
		return new PackEventListTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PackEventListTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PackEventListTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(ActionType != other.ActionType) && !(BgCharIllustName != other.BgCharIllustName) && !(EventHubContentIconName != other.EventHubContentIconName) && GroupId == other.GroupId && HubContentLocalTextId == other.HubContentLocalTextId && HubContentType == other.HubContentType && Id == other.Id && SlotIndex == other.SlotIndex && SortId == other.SortId)
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
		if (ActionType.Length != 0)
		{
			num ^= ActionType.GetHashCode();
		}
		if (BgCharIllustName.Length != 0)
		{
			num ^= BgCharIllustName.GetHashCode();
		}
		if (EventHubContentIconName.Length != 0)
		{
			num ^= EventHubContentIconName.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (HubContentLocalTextId != 0)
		{
			num ^= HubContentLocalTextId.GetHashCode();
		}
		if (HubContentType != 0)
		{
			num ^= HubContentType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (SlotIndex != 0)
		{
			num ^= SlotIndex.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
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
		if (ActionType.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ActionType);
		}
		if (BgCharIllustName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BgCharIllustName);
		}
		if (EventHubContentIconName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(EventHubContentIconName);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (HubContentLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(HubContentLocalTextId);
		}
		if (HubContentType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(HubContentType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		if (SlotIndex != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SlotIndex);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(SortId);
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
		if (ActionType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ActionType);
		}
		if (BgCharIllustName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BgCharIllustName);
		}
		if (EventHubContentIconName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EventHubContentIconName);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (HubContentLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HubContentLocalTextId);
		}
		if (HubContentType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HubContentType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (SlotIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SlotIndex);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackEventListTable other)
	{
		if (other != null)
		{
			if (other.ActionType.Length != 0)
			{
				ActionType = other.ActionType;
			}
			if (other.BgCharIllustName.Length != 0)
			{
				BgCharIllustName = other.BgCharIllustName;
			}
			if (other.EventHubContentIconName.Length != 0)
			{
				EventHubContentIconName = other.EventHubContentIconName;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.HubContentLocalTextId != 0)
			{
				HubContentLocalTextId = other.HubContentLocalTextId;
			}
			if (other.HubContentType != 0)
			{
				HubContentType = other.HubContentType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SlotIndex != 0)
			{
				SlotIndex = other.SlotIndex;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
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
			case 10u:
				ActionType = input.ReadString();
				break;
			case 18u:
				BgCharIllustName = input.ReadString();
				break;
			case 26u:
				EventHubContentIconName = input.ReadString();
				break;
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 40u:
				HubContentLocalTextId = input.ReadInt32();
				break;
			case 48u:
				HubContentType = input.ReadInt32();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 64u:
				SlotIndex = input.ReadInt32();
				break;
			case 72u:
				SortId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
