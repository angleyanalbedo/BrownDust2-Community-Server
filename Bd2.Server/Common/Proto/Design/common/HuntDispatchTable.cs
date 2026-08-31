using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class HuntDispatchTable : IMessage<HuntDispatchTable>, IMessage, IEquatable<HuntDispatchTable>, IDeepCloneable<HuntDispatchTable>, IBufferMessage
{
	private static readonly MessageParser<HuntDispatchTable> _parser = new MessageParser<HuntDispatchTable>(() => new HuntDispatchTable());

	private UnknownFieldSet _unknownFields;

	public const int ApPerTimeFieldNumber = 1;

	private int apPerTime_;

	public const int BattleCountBossFieldNumber = 2;

	private int battleCountBoss_;

	public const int BattleCountMonsterFieldNumber = 3;

	private int battleCountMonster_;

	public const int ClearTimeFieldNumber = 4;

	private int clearTime_;

	public const int DifficultyFieldNumber = 5;

	private int difficulty_;

	public const int DispatchNameTextIdFieldNumber = 6;

	private int dispatchNameTextId_;

	public const int GroupIdFieldNumber = 7;

	private int groupId_;

	public const int IdFieldNumber = 8;

	private int id_;

	public const int MapUiObjectIdFieldNumber = 9;

	private int mapUiObjectId_;

	public const int PackIdFieldNumber = 10;

	private int packId_;

	public const int PackNameTextIdFieldNumber = 11;

	private int packNameTextId_;

	public const int RewardGrowthRateFieldNumber = 12;

	private int rewardGrowthRate_;

	public const int TypeGroupIdFieldNumber = 13;

	private int typeGroupId_;

	public const int TypeIdFieldNumber = 14;

	private int typeId_;

	public const int VisualItemIdFieldNumber = 15;

	private static readonly FieldCodec<int> _repeated_visualItemId_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> visualItemId_ = new RepeatedField<int>();

	public const int VisualItemTypeFieldNumber = 16;

	private static readonly FieldCodec<int> _repeated_visualItemType_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> visualItemType_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HuntDispatchTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => HuntDispatchTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ApPerTime
	{
		get
		{
			return apPerTime_;
		}
		set
		{
			apPerTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleCountBoss
	{
		get
		{
			return battleCountBoss_;
		}
		set
		{
			battleCountBoss_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleCountMonster
	{
		get
		{
			return battleCountMonster_;
		}
		set
		{
			battleCountMonster_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ClearTime
	{
		get
		{
			return clearTime_;
		}
		set
		{
			clearTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Difficulty
	{
		get
		{
			return difficulty_;
		}
		set
		{
			difficulty_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DispatchNameTextId
	{
		get
		{
			return dispatchNameTextId_;
		}
		set
		{
			dispatchNameTextId_ = value;
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
	public int MapUiObjectId
	{
		get
		{
			return mapUiObjectId_;
		}
		set
		{
			mapUiObjectId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackNameTextId
	{
		get
		{
			return packNameTextId_;
		}
		set
		{
			packNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardGrowthRate
	{
		get
		{
			return rewardGrowthRate_;
		}
		set
		{
			rewardGrowthRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TypeGroupId
	{
		get
		{
			return typeGroupId_;
		}
		set
		{
			typeGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TypeId
	{
		get
		{
			return typeId_;
		}
		set
		{
			typeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> VisualItemId => visualItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> VisualItemType => visualItemType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntDispatchTable(HuntDispatchTable other)
		: this()
	{
		apPerTime_ = other.apPerTime_;
		battleCountBoss_ = other.battleCountBoss_;
		battleCountMonster_ = other.battleCountMonster_;
		clearTime_ = other.clearTime_;
		difficulty_ = other.difficulty_;
		dispatchNameTextId_ = other.dispatchNameTextId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		mapUiObjectId_ = other.mapUiObjectId_;
		packId_ = other.packId_;
		packNameTextId_ = other.packNameTextId_;
		rewardGrowthRate_ = other.rewardGrowthRate_;
		typeGroupId_ = other.typeGroupId_;
		typeId_ = other.typeId_;
		visualItemId_ = other.visualItemId_.Clone();
		visualItemType_ = other.visualItemType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HuntDispatchTable Clone()
	{
		return new HuntDispatchTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as HuntDispatchTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HuntDispatchTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ApPerTime == other.ApPerTime && BattleCountBoss == other.BattleCountBoss && BattleCountMonster == other.BattleCountMonster && ClearTime == other.ClearTime && Difficulty == other.Difficulty && DispatchNameTextId == other.DispatchNameTextId && GroupId == other.GroupId && Id == other.Id && MapUiObjectId == other.MapUiObjectId && PackId == other.PackId && PackNameTextId == other.PackNameTextId && RewardGrowthRate == other.RewardGrowthRate && TypeGroupId == other.TypeGroupId && TypeId == other.TypeId && visualItemId_.Equals(other.visualItemId_) && visualItemType_.Equals(other.visualItemType_))
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
		if (ApPerTime != 0)
		{
			num ^= ApPerTime.GetHashCode();
		}
		if (BattleCountBoss != 0)
		{
			num ^= BattleCountBoss.GetHashCode();
		}
		if (BattleCountMonster != 0)
		{
			num ^= BattleCountMonster.GetHashCode();
		}
		if (ClearTime != 0)
		{
			num ^= ClearTime.GetHashCode();
		}
		if (Difficulty != 0)
		{
			num ^= Difficulty.GetHashCode();
		}
		if (DispatchNameTextId != 0)
		{
			num ^= DispatchNameTextId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MapUiObjectId != 0)
		{
			num ^= MapUiObjectId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (PackNameTextId != 0)
		{
			num ^= PackNameTextId.GetHashCode();
		}
		if (RewardGrowthRate != 0)
		{
			num ^= RewardGrowthRate.GetHashCode();
		}
		if (TypeGroupId != 0)
		{
			num ^= TypeGroupId.GetHashCode();
		}
		if (TypeId != 0)
		{
			num ^= TypeId.GetHashCode();
		}
		num ^= visualItemId_.GetHashCode();
		num ^= visualItemType_.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (ApPerTime != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ApPerTime);
		}
		if (BattleCountBoss != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleCountBoss);
		}
		if (BattleCountMonster != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleCountMonster);
		}
		if (ClearTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ClearTime);
		}
		if (Difficulty != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Difficulty);
		}
		if (DispatchNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DispatchNameTextId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (MapUiObjectId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MapUiObjectId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PackId);
		}
		if (PackNameTextId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(PackNameTextId);
		}
		if (RewardGrowthRate != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(RewardGrowthRate);
		}
		if (TypeGroupId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(TypeGroupId);
		}
		if (TypeId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(TypeId);
		}
		visualItemId_.WriteTo(ref output, _repeated_visualItemId_codec);
		visualItemType_.WriteTo(ref output, _repeated_visualItemType_codec);
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
		if (ApPerTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ApPerTime);
		}
		if (BattleCountBoss != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleCountBoss);
		}
		if (BattleCountMonster != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleCountMonster);
		}
		if (ClearTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearTime);
		}
		if (Difficulty != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Difficulty);
		}
		if (DispatchNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DispatchNameTextId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MapUiObjectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapUiObjectId);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (PackNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackNameTextId);
		}
		if (RewardGrowthRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardGrowthRate);
		}
		if (TypeGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TypeGroupId);
		}
		if (TypeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TypeId);
		}
		num += visualItemId_.CalculateSize(_repeated_visualItemId_codec);
		num += visualItemType_.CalculateSize(_repeated_visualItemType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HuntDispatchTable other)
	{
		if (other != null)
		{
			if (other.ApPerTime != 0)
			{
				ApPerTime = other.ApPerTime;
			}
			if (other.BattleCountBoss != 0)
			{
				BattleCountBoss = other.BattleCountBoss;
			}
			if (other.BattleCountMonster != 0)
			{
				BattleCountMonster = other.BattleCountMonster;
			}
			if (other.ClearTime != 0)
			{
				ClearTime = other.ClearTime;
			}
			if (other.Difficulty != 0)
			{
				Difficulty = other.Difficulty;
			}
			if (other.DispatchNameTextId != 0)
			{
				DispatchNameTextId = other.DispatchNameTextId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MapUiObjectId != 0)
			{
				MapUiObjectId = other.MapUiObjectId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.PackNameTextId != 0)
			{
				PackNameTextId = other.PackNameTextId;
			}
			if (other.RewardGrowthRate != 0)
			{
				RewardGrowthRate = other.RewardGrowthRate;
			}
			if (other.TypeGroupId != 0)
			{
				TypeGroupId = other.TypeGroupId;
			}
			if (other.TypeId != 0)
			{
				TypeId = other.TypeId;
			}
			visualItemId_.Add(other.visualItemId_);
			visualItemType_.Add(other.visualItemType_);
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
				ApPerTime = input.ReadInt32();
				break;
			case 16u:
				BattleCountBoss = input.ReadInt32();
				break;
			case 24u:
				BattleCountMonster = input.ReadInt32();
				break;
			case 32u:
				ClearTime = input.ReadInt32();
				break;
			case 40u:
				Difficulty = input.ReadInt32();
				break;
			case 48u:
				DispatchNameTextId = input.ReadInt32();
				break;
			case 56u:
				GroupId = input.ReadInt32();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 72u:
				MapUiObjectId = input.ReadInt32();
				break;
			case 112u:
				TypeId = input.ReadInt32();
				break;
			case 128u:
			case 130u:
				visualItemType_.AddEntriesFrom(ref input, _repeated_visualItemType_codec);
				break;
			case 120u:
			case 122u:
				visualItemId_.AddEntriesFrom(ref input, _repeated_visualItemId_codec);
				break;
			case 80u:
				PackId = input.ReadInt32();
				break;
			case 88u:
				PackNameTextId = input.ReadInt32();
				break;
			case 96u:
				RewardGrowthRate = input.ReadInt32();
				break;
			case 104u:
				TypeGroupId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
