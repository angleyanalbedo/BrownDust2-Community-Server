using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class WorldMapPinTable : IMessage<WorldMapPinTable>, IMessage, IEquatable<WorldMapPinTable>, IDeepCloneable<WorldMapPinTable>, IBufferMessage
{
	private static readonly MessageParser<WorldMapPinTable> _parser = new MessageParser<WorldMapPinTable>(() => new WorldMapPinTable());

	private UnknownFieldSet _unknownFields;

	public const int HuntPackIdFieldNumber = 1;

	private int huntPackId_;

	public const int HuntPinIcoSpriteNameFieldNumber = 2;

	private string huntPinIcoSpriteName_ = "";

	public const int HuntTypeGroupIdFieldNumber = 3;

	private int huntTypeGroupId_;

	public const int IdFieldNumber = 4;

	private int id_;

	public const int MapDescNameTextIdFieldNumber = 5;

	private int mapDescNameTextId_;

	public const int MapNameTextIdFieldNumber = 6;

	private int mapNameTextId_;

	public const int MapPinIconSpriteNameFieldNumber = 7;

	private string mapPinIconSpriteName_ = "";

	public const int MapPinThumbSpriteNameFieldNumber = 8;

	private string mapPinThumbSpriteName_ = "";

	public const int PackIdFieldNumber = 9;

	private int packId_;

	public const int TypeFieldNumber = 10;

	private int type_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<WorldMapPinTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => WorldMapPinTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HuntPackId
	{
		get
		{
			return huntPackId_;
		}
		set
		{
			huntPackId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HuntPinIcoSpriteName
	{
		get
		{
			return huntPinIcoSpriteName_;
		}
		set
		{
			huntPinIcoSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HuntTypeGroupId
	{
		get
		{
			return huntTypeGroupId_;
		}
		set
		{
			huntTypeGroupId_ = value;
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
	public int MapDescNameTextId
	{
		get
		{
			return mapDescNameTextId_;
		}
		set
		{
			mapDescNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MapNameTextId
	{
		get
		{
			return mapNameTextId_;
		}
		set
		{
			mapNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MapPinIconSpriteName
	{
		get
		{
			return mapPinIconSpriteName_;
		}
		set
		{
			mapPinIconSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MapPinThumbSpriteName
	{
		get
		{
			return mapPinThumbSpriteName_;
		}
		set
		{
			mapPinThumbSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WorldMapPinTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WorldMapPinTable(WorldMapPinTable other)
		: this()
	{
		huntPackId_ = other.huntPackId_;
		huntPinIcoSpriteName_ = other.huntPinIcoSpriteName_;
		huntTypeGroupId_ = other.huntTypeGroupId_;
		id_ = other.id_;
		mapDescNameTextId_ = other.mapDescNameTextId_;
		mapNameTextId_ = other.mapNameTextId_;
		mapPinIconSpriteName_ = other.mapPinIconSpriteName_;
		mapPinThumbSpriteName_ = other.mapPinThumbSpriteName_;
		packId_ = other.packId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WorldMapPinTable Clone()
	{
		return new WorldMapPinTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as WorldMapPinTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WorldMapPinTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (HuntPackId == other.HuntPackId && !(HuntPinIcoSpriteName != other.HuntPinIcoSpriteName) && HuntTypeGroupId == other.HuntTypeGroupId && Id == other.Id && MapDescNameTextId == other.MapDescNameTextId && MapNameTextId == other.MapNameTextId && !(MapPinIconSpriteName != other.MapPinIconSpriteName) && !(MapPinThumbSpriteName != other.MapPinThumbSpriteName) && PackId == other.PackId && Type == other.Type)
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
		if (HuntPackId != 0)
		{
			num ^= HuntPackId.GetHashCode();
		}
		if (HuntPinIcoSpriteName.Length != 0)
		{
			num ^= HuntPinIcoSpriteName.GetHashCode();
		}
		if (HuntTypeGroupId != 0)
		{
			num ^= HuntTypeGroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MapDescNameTextId != 0)
		{
			num ^= MapDescNameTextId.GetHashCode();
		}
		if (MapNameTextId != 0)
		{
			num ^= MapNameTextId.GetHashCode();
		}
		if (MapPinIconSpriteName.Length != 0)
		{
			num ^= MapPinIconSpriteName.GetHashCode();
		}
		if (MapPinThumbSpriteName.Length != 0)
		{
			num ^= MapPinThumbSpriteName.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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
		if (HuntPackId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(HuntPackId);
		}
		if (HuntPinIcoSpriteName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(HuntPinIcoSpriteName);
		}
		if (HuntTypeGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(HuntTypeGroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		if (MapDescNameTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MapDescNameTextId);
		}
		if (MapNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MapNameTextId);
		}
		if (MapPinIconSpriteName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(MapPinIconSpriteName);
		}
		if (MapPinThumbSpriteName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(MapPinThumbSpriteName);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PackId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Type);
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
		if (HuntPackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HuntPackId);
		}
		if (HuntPinIcoSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HuntPinIcoSpriteName);
		}
		if (HuntTypeGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HuntTypeGroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MapDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapDescNameTextId);
		}
		if (MapNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapNameTextId);
		}
		if (MapPinIconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MapPinIconSpriteName);
		}
		if (MapPinThumbSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MapPinThumbSpriteName);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(WorldMapPinTable other)
	{
		if (other != null)
		{
			if (other.HuntPackId != 0)
			{
				HuntPackId = other.HuntPackId;
			}
			if (other.HuntPinIcoSpriteName.Length != 0)
			{
				HuntPinIcoSpriteName = other.HuntPinIcoSpriteName;
			}
			if (other.HuntTypeGroupId != 0)
			{
				HuntTypeGroupId = other.HuntTypeGroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MapDescNameTextId != 0)
			{
				MapDescNameTextId = other.MapDescNameTextId;
			}
			if (other.MapNameTextId != 0)
			{
				MapNameTextId = other.MapNameTextId;
			}
			if (other.MapPinIconSpriteName.Length != 0)
			{
				MapPinIconSpriteName = other.MapPinIconSpriteName;
			}
			if (other.MapPinThumbSpriteName.Length != 0)
			{
				MapPinThumbSpriteName = other.MapPinThumbSpriteName;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
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
				HuntPackId = input.ReadInt32();
				break;
			case 18u:
				HuntPinIcoSpriteName = input.ReadString();
				break;
			case 24u:
				HuntTypeGroupId = input.ReadInt32();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
				MapDescNameTextId = input.ReadInt32();
				break;
			case 48u:
				MapNameTextId = input.ReadInt32();
				break;
			case 58u:
				MapPinIconSpriteName = input.ReadString();
				break;
			case 66u:
				MapPinThumbSpriteName = input.ReadString();
				break;
			case 72u:
				PackId = input.ReadInt32();
				break;
			case 80u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
