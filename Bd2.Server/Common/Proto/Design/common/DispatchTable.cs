using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class DispatchTable : IMessage<DispatchTable>, IMessage, IEquatable<DispatchTable>, IDeepCloneable<DispatchTable>, IBufferMessage
{
	private static readonly MessageParser<DispatchTable> _parser = new MessageParser<DispatchTable>(() => new DispatchTable());

	private UnknownFieldSet _unknownFields;

	public const int DispatchEndLocalTextIdFieldNumber = 1;

	private int dispatchEndLocalTextId_;

	public const int DispatchLevelFieldNumber = 2;

	private int dispatchLevel_;

	public const int DispatchLocalTextIdFieldNumber = 3;

	private int dispatchLocalTextId_;

	public const int DispatchTimeFieldNumber = 4;

	private int dispatchTime_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int NameTextIdFieldNumber = 6;

	private int nameTextId_;

	public const int PrefabNameFieldNumber = 7;

	private string prefabName_ = "";

	public const int RewardGroupIdFieldNumber = 8;

	private int rewardGroupId_;

	public const int SpriteNameFieldNumber = 9;

	private string spriteName_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DispatchTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => DispatchTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DispatchEndLocalTextId
	{
		get
		{
			return dispatchEndLocalTextId_;
		}
		set
		{
			dispatchEndLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DispatchLevel
	{
		get
		{
			return dispatchLevel_;
		}
		set
		{
			dispatchLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DispatchLocalTextId
	{
		get
		{
			return dispatchLocalTextId_;
		}
		set
		{
			dispatchLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DispatchTime
	{
		get
		{
			return dispatchTime_;
		}
		set
		{
			dispatchTime_ = value;
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
	public int NameTextId
	{
		get
		{
			return nameTextId_;
		}
		set
		{
			nameTextId_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardGroupId
	{
		get
		{
			return rewardGroupId_;
		}
		set
		{
			rewardGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string SpriteName
	{
		get
		{
			return spriteName_;
		}
		set
		{
			spriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DispatchTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DispatchTable(DispatchTable other)
		: this()
	{
		dispatchEndLocalTextId_ = other.dispatchEndLocalTextId_;
		dispatchLevel_ = other.dispatchLevel_;
		dispatchLocalTextId_ = other.dispatchLocalTextId_;
		dispatchTime_ = other.dispatchTime_;
		id_ = other.id_;
		nameTextId_ = other.nameTextId_;
		prefabName_ = other.prefabName_;
		rewardGroupId_ = other.rewardGroupId_;
		spriteName_ = other.spriteName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DispatchTable Clone()
	{
		return new DispatchTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DispatchTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DispatchTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DispatchEndLocalTextId == other.DispatchEndLocalTextId && DispatchLevel == other.DispatchLevel && DispatchLocalTextId == other.DispatchLocalTextId && DispatchTime == other.DispatchTime && Id == other.Id && NameTextId == other.NameTextId && !(PrefabName != other.PrefabName) && RewardGroupId == other.RewardGroupId && !(SpriteName != other.SpriteName))
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
		if (DispatchEndLocalTextId != 0)
		{
			num ^= DispatchEndLocalTextId.GetHashCode();
		}
		if (DispatchLevel != 0)
		{
			num ^= DispatchLevel.GetHashCode();
		}
		if (DispatchLocalTextId != 0)
		{
			num ^= DispatchLocalTextId.GetHashCode();
		}
		if (DispatchTime != 0)
		{
			num ^= DispatchTime.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NameTextId != 0)
		{
			num ^= NameTextId.GetHashCode();
		}
		if (PrefabName.Length != 0)
		{
			num ^= PrefabName.GetHashCode();
		}
		if (RewardGroupId != 0)
		{
			num ^= RewardGroupId.GetHashCode();
		}
		if (SpriteName.Length != 0)
		{
			num ^= SpriteName.GetHashCode();
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
		if (DispatchEndLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DispatchEndLocalTextId);
		}
		if (DispatchLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DispatchLevel);
		}
		if (DispatchLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DispatchLocalTextId);
		}
		if (DispatchTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DispatchTime);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (NameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(NameTextId);
		}
		if (PrefabName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(PrefabName);
		}
		if (RewardGroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(RewardGroupId);
		}
		if (SpriteName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(SpriteName);
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
		if (DispatchEndLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DispatchEndLocalTextId);
		}
		if (DispatchLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DispatchLevel);
		}
		if (DispatchLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DispatchLocalTextId);
		}
		if (DispatchTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DispatchTime);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NameTextId);
		}
		if (PrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PrefabName);
		}
		if (RewardGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardGroupId);
		}
		if (SpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SpriteName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DispatchTable other)
	{
		if (other != null)
		{
			if (other.DispatchEndLocalTextId != 0)
			{
				DispatchEndLocalTextId = other.DispatchEndLocalTextId;
			}
			if (other.DispatchLevel != 0)
			{
				DispatchLevel = other.DispatchLevel;
			}
			if (other.DispatchLocalTextId != 0)
			{
				DispatchLocalTextId = other.DispatchLocalTextId;
			}
			if (other.DispatchTime != 0)
			{
				DispatchTime = other.DispatchTime;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NameTextId != 0)
			{
				NameTextId = other.NameTextId;
			}
			if (other.PrefabName.Length != 0)
			{
				PrefabName = other.PrefabName;
			}
			if (other.RewardGroupId != 0)
			{
				RewardGroupId = other.RewardGroupId;
			}
			if (other.SpriteName.Length != 0)
			{
				SpriteName = other.SpriteName;
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
				DispatchEndLocalTextId = input.ReadInt32();
				break;
			case 16u:
				DispatchLevel = input.ReadInt32();
				break;
			case 24u:
				DispatchLocalTextId = input.ReadInt32();
				break;
			case 32u:
				DispatchTime = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				NameTextId = input.ReadInt32();
				break;
			case 58u:
				PrefabName = input.ReadString();
				break;
			case 64u:
				RewardGroupId = input.ReadInt32();
				break;
			case 74u:
				SpriteName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
