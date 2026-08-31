using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackEventMiniGameTable : IMessage<PackEventMiniGameTable>, IMessage, IEquatable<PackEventMiniGameTable>, IDeepCloneable<PackEventMiniGameTable>, IBufferMessage
{
	private static readonly MessageParser<PackEventMiniGameTable> _parser = new MessageParser<PackEventMiniGameTable>(() => new PackEventMiniGameTable());

	private UnknownFieldSet _unknownFields;

	public const int EventClearSubTypeFieldNumber = 1;

	private int eventClearSubType_;

	public const int EventClearTypeFieldNumber = 2;

	private int eventClearType_;

	public const int EventClearValueFieldNumber = 3;

	private int eventClearValue_;

	public const int EventDescLocalTextIdFieldNumber = 4;

	private int eventDescLocalTextId_;

	public const int EventNameLocalTextIdFieldNumber = 5;

	private int eventNameLocalTextId_;

	public const int IdFieldNumber = 6;

	private int id_;

	public const int MapIdFieldNumber = 7;

	private int mapId_;

	public const int MiniGameRewardGroupIdFieldNumber = 8;

	private int miniGameRewardGroupId_;

	public const int PackIdFieldNumber = 9;

	private int packId_;

	public const int PointPositionIdFieldNumber = 10;

	private int pointPositionId_;

	public const int PrefabNameFieldNumber = 11;

	private string prefabName_ = "";

	public const int StaticCostumeIdFieldNumber = 12;

	private int staticCostumeId_;

	public const int StaticCostumePathFieldNumber = 13;

	private string staticCostumePath_ = "";

	public const int StaticCostumeTypeFieldNumber = 14;

	private int staticCostumeType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PackEventMiniGameTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackEventMiniGameTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventClearSubType
	{
		get
		{
			return eventClearSubType_;
		}
		set
		{
			eventClearSubType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventClearType
	{
		get
		{
			return eventClearType_;
		}
		set
		{
			eventClearType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventClearValue
	{
		get
		{
			return eventClearValue_;
		}
		set
		{
			eventClearValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventDescLocalTextId
	{
		get
		{
			return eventDescLocalTextId_;
		}
		set
		{
			eventDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventNameLocalTextId
	{
		get
		{
			return eventNameLocalTextId_;
		}
		set
		{
			eventNameLocalTextId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MiniGameRewardGroupId
	{
		get
		{
			return miniGameRewardGroupId_;
		}
		set
		{
			miniGameRewardGroupId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PointPositionId
	{
		get
		{
			return pointPositionId_;
		}
		set
		{
			pointPositionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PrefabName
	{
		get
		{
			return prefabName_;
		}
		set
		{
			prefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StaticCostumeId
	{
		get
		{
			return staticCostumeId_;
		}
		set
		{
			staticCostumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string StaticCostumePath
	{
		get
		{
			return staticCostumePath_;
		}
		set
		{
			staticCostumePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StaticCostumeType
	{
		get
		{
			return staticCostumeType_;
		}
		set
		{
			staticCostumeType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventMiniGameTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackEventMiniGameTable(PackEventMiniGameTable other)
		: this()
	{
		eventClearSubType_ = other.eventClearSubType_;
		eventClearType_ = other.eventClearType_;
		eventClearValue_ = other.eventClearValue_;
		eventDescLocalTextId_ = other.eventDescLocalTextId_;
		eventNameLocalTextId_ = other.eventNameLocalTextId_;
		id_ = other.id_;
		mapId_ = other.mapId_;
		miniGameRewardGroupId_ = other.miniGameRewardGroupId_;
		packId_ = other.packId_;
		pointPositionId_ = other.pointPositionId_;
		prefabName_ = other.prefabName_;
		staticCostumeId_ = other.staticCostumeId_;
		staticCostumePath_ = other.staticCostumePath_;
		staticCostumeType_ = other.staticCostumeType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackEventMiniGameTable Clone()
	{
		return new PackEventMiniGameTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PackEventMiniGameTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PackEventMiniGameTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventClearSubType == other.EventClearSubType && EventClearType == other.EventClearType && EventClearValue == other.EventClearValue && EventDescLocalTextId == other.EventDescLocalTextId && EventNameLocalTextId == other.EventNameLocalTextId && Id == other.Id && MapId == other.MapId && MiniGameRewardGroupId == other.MiniGameRewardGroupId && PackId == other.PackId && PointPositionId == other.PointPositionId && !(PrefabName != other.PrefabName) && StaticCostumeId == other.StaticCostumeId && !(StaticCostumePath != other.StaticCostumePath) && StaticCostumeType == other.StaticCostumeType)
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
		if (EventClearSubType != 0)
		{
			num ^= EventClearSubType.GetHashCode();
		}
		if (EventClearType != 0)
		{
			num ^= EventClearType.GetHashCode();
		}
		if (EventClearValue != 0)
		{
			num ^= EventClearValue.GetHashCode();
		}
		if (EventDescLocalTextId != 0)
		{
			num ^= EventDescLocalTextId.GetHashCode();
		}
		if (EventNameLocalTextId != 0)
		{
			num ^= EventNameLocalTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (MiniGameRewardGroupId != 0)
		{
			num ^= MiniGameRewardGroupId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (PointPositionId != 0)
		{
			num ^= PointPositionId.GetHashCode();
		}
		if (PrefabName.Length != 0)
		{
			num ^= PrefabName.GetHashCode();
		}
		if (StaticCostumeId != 0)
		{
			num ^= StaticCostumeId.GetHashCode();
		}
		if (StaticCostumePath.Length != 0)
		{
			num ^= StaticCostumePath.GetHashCode();
		}
		if (StaticCostumeType != 0)
		{
			num ^= StaticCostumeType.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (EventClearSubType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventClearSubType);
		}
		if (EventClearType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventClearType);
		}
		if (EventClearValue != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EventClearValue);
		}
		if (EventDescLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EventDescLocalTextId);
		}
		if (EventNameLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EventNameLocalTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(MapId);
		}
		if (MiniGameRewardGroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(MiniGameRewardGroupId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PackId);
		}
		if (PointPositionId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PointPositionId);
		}
		if (PrefabName.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(PrefabName);
		}
		if (StaticCostumeId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(StaticCostumeId);
		}
		if (StaticCostumePath.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(StaticCostumePath);
		}
		if (StaticCostumeType != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(StaticCostumeType);
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
		if (EventClearSubType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventClearSubType);
		}
		if (EventClearType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventClearType);
		}
		if (EventClearValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventClearValue);
		}
		if (EventDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventDescLocalTextId);
		}
		if (EventNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventNameLocalTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (MiniGameRewardGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MiniGameRewardGroupId);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (PointPositionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PointPositionId);
		}
		if (PrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PrefabName);
		}
		if (StaticCostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StaticCostumeId);
		}
		if (StaticCostumePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StaticCostumePath);
		}
		if (StaticCostumeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StaticCostumeType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackEventMiniGameTable other)
	{
		if (other != null)
		{
			if (other.EventClearSubType != 0)
			{
				EventClearSubType = other.EventClearSubType;
			}
			if (other.EventClearType != 0)
			{
				EventClearType = other.EventClearType;
			}
			if (other.EventClearValue != 0)
			{
				EventClearValue = other.EventClearValue;
			}
			if (other.EventDescLocalTextId != 0)
			{
				EventDescLocalTextId = other.EventDescLocalTextId;
			}
			if (other.EventNameLocalTextId != 0)
			{
				EventNameLocalTextId = other.EventNameLocalTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.MiniGameRewardGroupId != 0)
			{
				MiniGameRewardGroupId = other.MiniGameRewardGroupId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.PointPositionId != 0)
			{
				PointPositionId = other.PointPositionId;
			}
			if (other.PrefabName.Length != 0)
			{
				PrefabName = other.PrefabName;
			}
			if (other.StaticCostumeId != 0)
			{
				StaticCostumeId = other.StaticCostumeId;
			}
			if (other.StaticCostumePath.Length != 0)
			{
				StaticCostumePath = other.StaticCostumePath;
			}
			if (other.StaticCostumeType != 0)
			{
				StaticCostumeType = other.StaticCostumeType;
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
				EventClearSubType = input.ReadInt32();
				break;
			case 16u:
				EventClearType = input.ReadInt32();
				break;
			case 24u:
				EventClearValue = input.ReadInt32();
				break;
			case 32u:
				EventDescLocalTextId = input.ReadInt32();
				break;
			case 40u:
				EventNameLocalTextId = input.ReadInt32();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 56u:
				MapId = input.ReadInt32();
				break;
			case 64u:
				MiniGameRewardGroupId = input.ReadInt32();
				break;
			case 72u:
				PackId = input.ReadInt32();
				break;
			case 80u:
				PointPositionId = input.ReadInt32();
				break;
			case 90u:
				PrefabName = input.ReadString();
				break;
			case 96u:
				StaticCostumeId = input.ReadInt32();
				break;
			case 106u:
				StaticCostumePath = input.ReadString();
				break;
			case 112u:
				StaticCostumeType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
