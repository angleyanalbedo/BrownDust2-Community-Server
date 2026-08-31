using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MyRoomTrophyItemTable : IMessage<MyRoomTrophyItemTable>, IMessage, IEquatable<MyRoomTrophyItemTable>, IDeepCloneable<MyRoomTrophyItemTable>, IBufferMessage
{
	private static readonly MessageParser<MyRoomTrophyItemTable> _parser = new MessageParser<MyRoomTrophyItemTable>(() => new MyRoomTrophyItemTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int ItemSpriteNameFieldNumber = 2;

	private string itemSpriteName_ = "";

	public const int ObjectDescNameTextIdFieldNumber = 3;

	private int objectDescNameTextId_;

	public const int ObjectNameTextIdFieldNumber = 4;

	private int objectNameTextId_;

	public const int PrefabNameFieldNumber = 5;

	private string prefabName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomTrophyItemTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MyRoomTrophyItemTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public string ItemSpriteName
	{
		get
		{
			return itemSpriteName_;
		}
		set
		{
			itemSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectDescNameTextId
	{
		get
		{
			return objectDescNameTextId_;
		}
		set
		{
			objectDescNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectNameTextId
	{
		get
		{
			return objectNameTextId_;
		}
		set
		{
			objectNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public MyRoomTrophyItemTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomTrophyItemTable(MyRoomTrophyItemTable other)
		: this()
	{
		id_ = other.id_;
		itemSpriteName_ = other.itemSpriteName_;
		objectDescNameTextId_ = other.objectDescNameTextId_;
		objectNameTextId_ = other.objectNameTextId_;
		prefabName_ = other.prefabName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MyRoomTrophyItemTable Clone()
	{
		return new MyRoomTrophyItemTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomTrophyItemTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MyRoomTrophyItemTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && !(ItemSpriteName != other.ItemSpriteName) && ObjectDescNameTextId == other.ObjectDescNameTextId && ObjectNameTextId == other.ObjectNameTextId && !(PrefabName != other.PrefabName))
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
		if (ItemSpriteName.Length != 0)
		{
			num ^= ItemSpriteName.GetHashCode();
		}
		if (ObjectDescNameTextId != 0)
		{
			num ^= ObjectDescNameTextId.GetHashCode();
		}
		if (ObjectNameTextId != 0)
		{
			num ^= ObjectNameTextId.GetHashCode();
		}
		if (PrefabName.Length != 0)
		{
			num ^= PrefabName.GetHashCode();
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
		if (ItemSpriteName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ItemSpriteName);
		}
		if (ObjectDescNameTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ObjectDescNameTextId);
		}
		if (ObjectNameTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ObjectNameTextId);
		}
		if (PrefabName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PrefabName);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ItemSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ItemSpriteName);
		}
		if (ObjectDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObjectDescNameTextId);
		}
		if (ObjectNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObjectNameTextId);
		}
		if (PrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PrefabName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MyRoomTrophyItemTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemSpriteName.Length != 0)
			{
				ItemSpriteName = other.ItemSpriteName;
			}
			if (other.ObjectDescNameTextId != 0)
			{
				ObjectDescNameTextId = other.ObjectDescNameTextId;
			}
			if (other.ObjectNameTextId != 0)
			{
				ObjectNameTextId = other.ObjectNameTextId;
			}
			if (other.PrefabName.Length != 0)
			{
				PrefabName = other.PrefabName;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				ItemSpriteName = input.ReadString();
				break;
			case 24u:
				ObjectDescNameTextId = input.ReadInt32();
				break;
			case 32u:
				ObjectNameTextId = input.ReadInt32();
				break;
			case 42u:
				PrefabName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
