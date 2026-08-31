using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class LobbySettingItemTable : IMessage<LobbySettingItemTable>, IMessage, IEquatable<LobbySettingItemTable>, IDeepCloneable<LobbySettingItemTable>, IBufferMessage
{
	private static readonly MessageParser<LobbySettingItemTable> _parser = new MessageParser<LobbySettingItemTable>(() => new LobbySettingItemTable());

	private UnknownFieldSet _unknownFields;

	public const int IconSpriteNameFieldNumber = 1;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 2;

	private int id_;

	public const int ItemNameTextIdFieldNumber = 3;

	private int itemNameTextId_;

	public const int ItemPathFieldNumber = 4;

	private string itemPath_ = "";

	public const int PackIdFieldNumber = 5;

	private int packId_;

	public const int TypeFieldNumber = 6;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbySettingItemTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => LobbySettingItemTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IconSpriteName
	{
		get
		{
			return iconSpriteName_;
		}
		set
		{
			iconSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ItemNameTextId
	{
		get
		{
			return itemNameTextId_;
		}
		set
		{
			itemNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string ItemPath
	{
		get
		{
			return itemPath_;
		}
		set
		{
			itemPath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbySettingItemTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbySettingItemTable(LobbySettingItemTable other)
		: this()
	{
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		itemNameTextId_ = other.itemNameTextId_;
		itemPath_ = other.itemPath_;
		packId_ = other.packId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbySettingItemTable Clone()
	{
		return new LobbySettingItemTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as LobbySettingItemTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbySettingItemTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(IconSpriteName != other.IconSpriteName) && Id == other.Id && ItemNameTextId == other.ItemNameTextId && !(ItemPath != other.ItemPath) && PackId == other.PackId && Type == other.Type)
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
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ItemNameTextId != 0)
		{
			num ^= ItemNameTextId.GetHashCode();
		}
		if (ItemPath.Length != 0)
		{
			num ^= ItemPath.GetHashCode();
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
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (ItemNameTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ItemNameTextId);
		}
		if (ItemPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ItemPath);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PackId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(48);
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
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ItemNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemNameTextId);
		}
		if (ItemPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ItemPath);
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
	public void MergeFrom(LobbySettingItemTable other)
	{
		if (other != null)
		{
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemNameTextId != 0)
			{
				ItemNameTextId = other.ItemNameTextId;
			}
			if (other.ItemPath.Length != 0)
			{
				ItemPath = other.ItemPath;
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
			case 10u:
				IconSpriteName = input.ReadString();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				ItemNameTextId = input.ReadInt32();
				break;
			case 34u:
				ItemPath = input.ReadString();
				break;
			case 40u:
				PackId = input.ReadInt32();
				break;
			case 48u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
