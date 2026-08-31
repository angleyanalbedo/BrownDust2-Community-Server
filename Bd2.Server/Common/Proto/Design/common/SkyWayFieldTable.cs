using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class SkyWayFieldTable : IMessage<SkyWayFieldTable>, IMessage, IEquatable<SkyWayFieldTable>, IDeepCloneable<SkyWayFieldTable>, IBufferMessage
{
	private static readonly MessageParser<SkyWayFieldTable> _parser = new MessageParser<SkyWayFieldTable>(() => new SkyWayFieldTable());

	private UnknownFieldSet _unknownFields;

	public const int ApTypeFieldNumber = 1;

	private int apType_;

	public const int BattlePowerFieldNumber = 2;

	private int battlePower_;

	public const int BossApFieldNumber = 3;

	private int bossAp_;

	public const int BossIdFieldNumber = 4;

	private int bossId_;

	public const int DescLocalTextIdFieldNumber = 5;

	private int descLocalTextId_;

	public const int DifficultyFieldNumber = 6;

	private int difficulty_;

	public const int DisplayRewardCountFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_displayRewardCount_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> displayRewardCount_ = new RepeatedField<int>();

	public const int DisplayRewardIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_displayRewardId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> displayRewardId_ = new RepeatedField<int>();

	public const int DisplayRewardTypeFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_displayRewardType_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> displayRewardType_ = new RepeatedField<int>();

	public const int GroupIdFieldNumber = 10;

	private int groupId_;

	public const int IconSpriteNameFieldNumber = 11;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 12;

	private int id_;

	public const int MapIdFieldNumber = 13;

	private int mapId_;

	public const int MonsterApFieldNumber = 14;

	private static readonly FieldCodec<int> _repeated_monsterAp_codec = FieldCodec.ForInt32(114u);

	private readonly RepeatedField<int> monsterAp_ = new RepeatedField<int>();

	public const int MonsterIdFieldNumber = 15;

	private static readonly FieldCodec<int> _repeated_monsterId_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> monsterId_ = new RepeatedField<int>();

	public const int NameLocalTextIdFieldNumber = 16;

	private int nameLocalTextId_;

	public const int PointPositionIdFieldNumber = 17;

	private int pointPositionId_;

	public const int PositionGroupFieldNumber = 18;

	private int positionGroup_;

	public const int WorldMapPinIdFieldNumber = 19;

	private int worldMapPinId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SkyWayFieldTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SkyWayFieldTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ApType
	{
		get
		{
			return apType_;
		}
		set
		{
			apType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattlePower
	{
		get
		{
			return battlePower_;
		}
		set
		{
			battlePower_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BossAp
	{
		get
		{
			return bossAp_;
		}
		set
		{
			bossAp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BossId
	{
		get
		{
			return bossId_;
		}
		set
		{
			bossId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DescLocalTextId
	{
		get
		{
			return descLocalTextId_;
		}
		set
		{
			descLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public RepeatedField<int> DisplayRewardCount => displayRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DisplayRewardId => displayRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DisplayRewardType => displayRewardType_;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public RepeatedField<int> MonsterAp => monsterAp_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MonsterId => monsterId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NameLocalTextId
	{
		get
		{
			return nameLocalTextId_;
		}
		set
		{
			nameLocalTextId_ = value;
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
	public int PositionGroup
	{
		get
		{
			return positionGroup_;
		}
		set
		{
			positionGroup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WorldMapPinId
	{
		get
		{
			return worldMapPinId_;
		}
		set
		{
			worldMapPinId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayFieldTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayFieldTable(SkyWayFieldTable other)
		: this()
	{
		apType_ = other.apType_;
		battlePower_ = other.battlePower_;
		bossAp_ = other.bossAp_;
		bossId_ = other.bossId_;
		descLocalTextId_ = other.descLocalTextId_;
		difficulty_ = other.difficulty_;
		displayRewardCount_ = other.displayRewardCount_.Clone();
		displayRewardId_ = other.displayRewardId_.Clone();
		displayRewardType_ = other.displayRewardType_.Clone();
		groupId_ = other.groupId_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		mapId_ = other.mapId_;
		monsterAp_ = other.monsterAp_.Clone();
		monsterId_ = other.monsterId_.Clone();
		nameLocalTextId_ = other.nameLocalTextId_;
		pointPositionId_ = other.pointPositionId_;
		positionGroup_ = other.positionGroup_;
		worldMapPinId_ = other.worldMapPinId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SkyWayFieldTable Clone()
	{
		return new SkyWayFieldTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as SkyWayFieldTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SkyWayFieldTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ApType == other.ApType && BattlePower == other.BattlePower && BossAp == other.BossAp && BossId == other.BossId && DescLocalTextId == other.DescLocalTextId && Difficulty == other.Difficulty && displayRewardCount_.Equals(other.displayRewardCount_) && displayRewardId_.Equals(other.displayRewardId_) && displayRewardType_.Equals(other.displayRewardType_) && GroupId == other.GroupId && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && MapId == other.MapId && monsterAp_.Equals(other.monsterAp_) && monsterId_.Equals(other.monsterId_) && NameLocalTextId == other.NameLocalTextId && PointPositionId == other.PointPositionId && PositionGroup == other.PositionGroup && WorldMapPinId == other.WorldMapPinId)
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
		if (ApType != 0)
		{
			num ^= ApType.GetHashCode();
		}
		if (BattlePower != 0)
		{
			num ^= BattlePower.GetHashCode();
		}
		if (BossAp != 0)
		{
			num ^= BossAp.GetHashCode();
		}
		if (BossId != 0)
		{
			num ^= BossId.GetHashCode();
		}
		if (DescLocalTextId != 0)
		{
			num ^= DescLocalTextId.GetHashCode();
		}
		if (Difficulty != 0)
		{
			num ^= Difficulty.GetHashCode();
		}
		num ^= displayRewardCount_.GetHashCode();
		num ^= displayRewardId_.GetHashCode();
		num ^= displayRewardType_.GetHashCode();
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (IconSpriteName.Length != 0)
		{
			num ^= IconSpriteName.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		num ^= monsterAp_.GetHashCode();
		num ^= monsterId_.GetHashCode();
		if (NameLocalTextId != 0)
		{
			num ^= NameLocalTextId.GetHashCode();
		}
		if (PointPositionId != 0)
		{
			num ^= PointPositionId.GetHashCode();
		}
		if (PositionGroup != 0)
		{
			num ^= PositionGroup.GetHashCode();
		}
		if (WorldMapPinId != 0)
		{
			num ^= WorldMapPinId.GetHashCode();
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
		if (ApType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ApType);
		}
		if (BattlePower != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattlePower);
		}
		if (BossAp != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BossAp);
		}
		if (BossId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BossId);
		}
		if (DescLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DescLocalTextId);
		}
		if (Difficulty != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Difficulty);
		}
		displayRewardCount_.WriteTo(ref output, _repeated_displayRewardCount_codec);
		displayRewardId_.WriteTo(ref output, _repeated_displayRewardId_codec);
		displayRewardType_.WriteTo(ref output, _repeated_displayRewardType_codec);
		if (GroupId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(GroupId);
		}
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Id);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(MapId);
		}
		monsterAp_.WriteTo(ref output, _repeated_monsterAp_codec);
		monsterId_.WriteTo(ref output, _repeated_monsterId_codec);
		if (NameLocalTextId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(NameLocalTextId);
		}
		if (PointPositionId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(PointPositionId);
		}
		if (PositionGroup != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(PositionGroup);
		}
		if (WorldMapPinId != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(WorldMapPinId);
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
		if (ApType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ApType);
		}
		if (BattlePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattlePower);
		}
		if (BossAp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossAp);
		}
		if (BossId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossId);
		}
		if (DescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DescLocalTextId);
		}
		if (Difficulty != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Difficulty);
		}
		num += displayRewardCount_.CalculateSize(_repeated_displayRewardCount_codec);
		num += displayRewardId_.CalculateSize(_repeated_displayRewardId_codec);
		num += displayRewardType_.CalculateSize(_repeated_displayRewardType_codec);
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		num += monsterAp_.CalculateSize(_repeated_monsterAp_codec);
		num += monsterId_.CalculateSize(_repeated_monsterId_codec);
		if (NameLocalTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NameLocalTextId);
		}
		if (PointPositionId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PointPositionId);
		}
		if (PositionGroup != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PositionGroup);
		}
		if (WorldMapPinId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WorldMapPinId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SkyWayFieldTable other)
	{
		if (other != null)
		{
			if (other.ApType != 0)
			{
				ApType = other.ApType;
			}
			if (other.BattlePower != 0)
			{
				BattlePower = other.BattlePower;
			}
			if (other.BossAp != 0)
			{
				BossAp = other.BossAp;
			}
			if (other.BossId != 0)
			{
				BossId = other.BossId;
			}
			if (other.DescLocalTextId != 0)
			{
				DescLocalTextId = other.DescLocalTextId;
			}
			if (other.Difficulty != 0)
			{
				Difficulty = other.Difficulty;
			}
			displayRewardCount_.Add(other.displayRewardCount_);
			displayRewardId_.Add(other.displayRewardId_);
			displayRewardType_.Add(other.displayRewardType_);
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.IconSpriteName.Length != 0)
			{
				IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			monsterAp_.Add(other.monsterAp_);
			monsterId_.Add(other.monsterId_);
			if (other.NameLocalTextId != 0)
			{
				NameLocalTextId = other.NameLocalTextId;
			}
			if (other.PointPositionId != 0)
			{
				PointPositionId = other.PointPositionId;
			}
			if (other.PositionGroup != 0)
			{
				PositionGroup = other.PositionGroup;
			}
			if (other.WorldMapPinId != 0)
			{
				WorldMapPinId = other.WorldMapPinId;
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
			case 56u:
			case 58u:
				displayRewardCount_.AddEntriesFrom(ref input, _repeated_displayRewardCount_codec);
				break;
			case 72u:
			case 74u:
				displayRewardType_.AddEntriesFrom(ref input, _repeated_displayRewardType_codec);
				break;
			case 64u:
			case 66u:
				displayRewardId_.AddEntriesFrom(ref input, _repeated_displayRewardId_codec);
				break;
			case 8u:
				ApType = input.ReadInt32();
				break;
			case 16u:
				BattlePower = input.ReadInt32();
				break;
			case 24u:
				BossAp = input.ReadInt32();
				break;
			case 32u:
				BossId = input.ReadInt32();
				break;
			case 40u:
				DescLocalTextId = input.ReadInt32();
				break;
			case 48u:
				Difficulty = input.ReadInt32();
				break;
			case 80u:
				GroupId = input.ReadInt32();
				break;
			case 90u:
				IconSpriteName = input.ReadString();
				break;
			case 96u:
				Id = input.ReadInt32();
				break;
			case 104u:
				MapId = input.ReadInt32();
				break;
			case 112u:
			case 114u:
				monsterAp_.AddEntriesFrom(ref input, _repeated_monsterAp_codec);
				break;
			case 120u:
			case 122u:
				monsterId_.AddEntriesFrom(ref input, _repeated_monsterId_codec);
				break;
			case 128u:
				NameLocalTextId = input.ReadInt32();
				break;
			case 136u:
				PointPositionId = input.ReadInt32();
				break;
			case 144u:
				PositionGroup = input.ReadInt32();
				break;
			case 152u:
				WorldMapPinId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
