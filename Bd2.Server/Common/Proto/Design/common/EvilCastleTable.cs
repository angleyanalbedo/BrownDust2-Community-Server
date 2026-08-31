using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EvilCastleTable : IMessage<EvilCastleTable>, IMessage, IEquatable<EvilCastleTable>, IDeepCloneable<EvilCastleTable>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleTable> _parser = new MessageParser<EvilCastleTable>(() => new EvilCastleTable());

	private UnknownFieldSet _unknownFields;

	public const int PointPositionIdFieldNumber = 1;

	private int pointPositionId_;

	public const int RewardCountFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int BattlePowerFieldNumber = 5;

	private int battlePower_;

	public const int BestRecordTimelineFieldNumber = 6;

	private string bestRecordTimeline_ = "";

	public const int BossDescLocalTextIdFieldNumber = 7;

	private int bossDescLocalTextId_;

	public const int BossIdFieldNumber = 8;

	private int bossId_;

	public const int BossNameTextIdFieldNumber = 9;

	private int bossNameTextId_;

	public const int BossTargetLocalTextFieldNumber = 10;

	private int bossTargetLocalText_;

	public const int ClearDescLocalTextIdFieldNumber = 11;

	private int clearDescLocalTextId_;

	public const int FieldMonsterIdsFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_fieldMonsterIds_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> fieldMonsterIds_ = new RepeatedField<int>();

	public const int FloorDescLocalTextIdFieldNumber = 13;

	private int floorDescLocalTextId_;

	public const int FloorNameLocalTextIdFieldNumber = 14;

	private int floorNameLocalTextId_;

	public const int IconSpriteNameFieldNumber = 15;

	private string iconSpriteName_ = "";

	public const int IdFieldNumber = 16;

	private int id_;

	public const int MapIdFieldNumber = 17;

	private int mapId_;

	public const int MonsterIdFieldNumber = 18;

	private static readonly FieldCodec<int> _repeated_monsterId_codec = FieldCodec.ForInt32(146u);

	private readonly RepeatedField<int> monsterId_ = new RepeatedField<int>();

	public const int NormalDescLocalTextIdFieldNumber = 19;

	private int normalDescLocalTextId_;

	public const int NormalTargetLocalTextFieldNumber = 20;

	private int normalTargetLocalText_;

	public const int RecordUpdateTimelineFieldNumber = 21;

	private string recordUpdateTimeline_ = "";

	public const int TimeAttackIdFieldNumber = 22;

	private int timeAttackId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<int> RewardCount => rewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardId => rewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardType => rewardType_;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BestRecordTimeline
	{
		get
		{
			return bestRecordTimeline_;
		}
		set
		{
			bestRecordTimeline_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BossDescLocalTextId
	{
		get
		{
			return bossDescLocalTextId_;
		}
		set
		{
			bossDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BossNameTextId
	{
		get
		{
			return bossNameTextId_;
		}
		set
		{
			bossNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BossTargetLocalText
	{
		get
		{
			return bossTargetLocalText_;
		}
		set
		{
			bossTargetLocalText_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ClearDescLocalTextId
	{
		get
		{
			return clearDescLocalTextId_;
		}
		set
		{
			clearDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> FieldMonsterIds => fieldMonsterIds_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FloorDescLocalTextId
	{
		get
		{
			return floorDescLocalTextId_;
		}
		set
		{
			floorDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FloorNameLocalTextId
	{
		get
		{
			return floorNameLocalTextId_;
		}
		set
		{
			floorNameLocalTextId_ = value;
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
	public RepeatedField<int> MonsterId => monsterId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NormalDescLocalTextId
	{
		get
		{
			return normalDescLocalTextId_;
		}
		set
		{
			normalDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NormalTargetLocalText
	{
		get
		{
			return normalTargetLocalText_;
		}
		set
		{
			normalTargetLocalText_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RecordUpdateTimeline
	{
		get
		{
			return recordUpdateTimeline_;
		}
		set
		{
			recordUpdateTimeline_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TimeAttackId
	{
		get
		{
			return timeAttackId_;
		}
		set
		{
			timeAttackId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleTable(EvilCastleTable other)
		: this()
	{
		pointPositionId_ = other.pointPositionId_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		battlePower_ = other.battlePower_;
		bestRecordTimeline_ = other.bestRecordTimeline_;
		bossDescLocalTextId_ = other.bossDescLocalTextId_;
		bossId_ = other.bossId_;
		bossNameTextId_ = other.bossNameTextId_;
		bossTargetLocalText_ = other.bossTargetLocalText_;
		clearDescLocalTextId_ = other.clearDescLocalTextId_;
		fieldMonsterIds_ = other.fieldMonsterIds_.Clone();
		floorDescLocalTextId_ = other.floorDescLocalTextId_;
		floorNameLocalTextId_ = other.floorNameLocalTextId_;
		iconSpriteName_ = other.iconSpriteName_;
		id_ = other.id_;
		mapId_ = other.mapId_;
		monsterId_ = other.monsterId_.Clone();
		normalDescLocalTextId_ = other.normalDescLocalTextId_;
		normalTargetLocalText_ = other.normalTargetLocalText_;
		recordUpdateTimeline_ = other.recordUpdateTimeline_;
		timeAttackId_ = other.timeAttackId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTable Clone()
	{
		return new EvilCastleTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (PointPositionId == other.PointPositionId && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_) && BattlePower == other.BattlePower && !(BestRecordTimeline != other.BestRecordTimeline) && BossDescLocalTextId == other.BossDescLocalTextId && BossId == other.BossId && BossNameTextId == other.BossNameTextId && BossTargetLocalText == other.BossTargetLocalText && ClearDescLocalTextId == other.ClearDescLocalTextId && fieldMonsterIds_.Equals(other.fieldMonsterIds_) && FloorDescLocalTextId == other.FloorDescLocalTextId && FloorNameLocalTextId == other.FloorNameLocalTextId && !(IconSpriteName != other.IconSpriteName) && Id == other.Id && MapId == other.MapId && monsterId_.Equals(other.monsterId_) && NormalDescLocalTextId == other.NormalDescLocalTextId && NormalTargetLocalText == other.NormalTargetLocalText && !(RecordUpdateTimeline != other.RecordUpdateTimeline) && TimeAttackId == other.TimeAttackId)
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
		if (PointPositionId != 0)
		{
			num ^= PointPositionId.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
		if (BattlePower != 0)
		{
			num ^= BattlePower.GetHashCode();
		}
		if (BestRecordTimeline.Length != 0)
		{
			num ^= BestRecordTimeline.GetHashCode();
		}
		if (BossDescLocalTextId != 0)
		{
			num ^= BossDescLocalTextId.GetHashCode();
		}
		if (BossId != 0)
		{
			num ^= BossId.GetHashCode();
		}
		if (BossNameTextId != 0)
		{
			num ^= BossNameTextId.GetHashCode();
		}
		if (BossTargetLocalText != 0)
		{
			num ^= BossTargetLocalText.GetHashCode();
		}
		if (ClearDescLocalTextId != 0)
		{
			num ^= ClearDescLocalTextId.GetHashCode();
		}
		num ^= fieldMonsterIds_.GetHashCode();
		if (FloorDescLocalTextId != 0)
		{
			num ^= FloorDescLocalTextId.GetHashCode();
		}
		if (FloorNameLocalTextId != 0)
		{
			num ^= FloorNameLocalTextId.GetHashCode();
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
		num ^= monsterId_.GetHashCode();
		if (NormalDescLocalTextId != 0)
		{
			num ^= NormalDescLocalTextId.GetHashCode();
		}
		if (NormalTargetLocalText != 0)
		{
			num ^= NormalTargetLocalText.GetHashCode();
		}
		if (RecordUpdateTimeline.Length != 0)
		{
			num ^= RecordUpdateTimeline.GetHashCode();
		}
		if (TimeAttackId != 0)
		{
			num ^= TimeAttackId.GetHashCode();
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
		if (PointPositionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PointPositionId);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		if (BattlePower != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BattlePower);
		}
		if (BestRecordTimeline.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(BestRecordTimeline);
		}
		if (BossDescLocalTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(BossDescLocalTextId);
		}
		if (BossId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(BossId);
		}
		if (BossNameTextId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(BossNameTextId);
		}
		if (BossTargetLocalText != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(BossTargetLocalText);
		}
		if (ClearDescLocalTextId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ClearDescLocalTextId);
		}
		fieldMonsterIds_.WriteTo(ref output, _repeated_fieldMonsterIds_codec);
		if (FloorDescLocalTextId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(FloorDescLocalTextId);
		}
		if (FloorNameLocalTextId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(FloorNameLocalTextId);
		}
		if (IconSpriteName.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(IconSpriteName);
		}
		if (Id != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(Id);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(MapId);
		}
		monsterId_.WriteTo(ref output, _repeated_monsterId_codec);
		if (NormalDescLocalTextId != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(NormalDescLocalTextId);
		}
		if (NormalTargetLocalText != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(NormalTargetLocalText);
		}
		if (RecordUpdateTimeline.Length != 0)
		{
			output.WriteRawTag(170, 1);
			output.WriteString(RecordUpdateTimeline);
		}
		if (TimeAttackId != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(TimeAttackId);
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
		if (PointPositionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PointPositionId);
		}
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		if (BattlePower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattlePower);
		}
		if (BestRecordTimeline.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BestRecordTimeline);
		}
		if (BossDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossDescLocalTextId);
		}
		if (BossId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossId);
		}
		if (BossNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossNameTextId);
		}
		if (BossTargetLocalText != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossTargetLocalText);
		}
		if (ClearDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearDescLocalTextId);
		}
		num += fieldMonsterIds_.CalculateSize(_repeated_fieldMonsterIds_codec);
		if (FloorDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FloorDescLocalTextId);
		}
		if (FloorNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FloorNameLocalTextId);
		}
		if (IconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconSpriteName);
		}
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MapId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		num += monsterId_.CalculateSize(_repeated_monsterId_codec);
		if (NormalDescLocalTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NormalDescLocalTextId);
		}
		if (NormalTargetLocalText != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NormalTargetLocalText);
		}
		if (RecordUpdateTimeline.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(RecordUpdateTimeline);
		}
		if (TimeAttackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TimeAttackId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleTable other)
	{
		if (other != null)
		{
			if (other.PointPositionId != 0)
			{
				PointPositionId = other.PointPositionId;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
			if (other.BattlePower != 0)
			{
				BattlePower = other.BattlePower;
			}
			if (other.BestRecordTimeline.Length != 0)
			{
				BestRecordTimeline = other.BestRecordTimeline;
			}
			if (other.BossDescLocalTextId != 0)
			{
				BossDescLocalTextId = other.BossDescLocalTextId;
			}
			if (other.BossId != 0)
			{
				BossId = other.BossId;
			}
			if (other.BossNameTextId != 0)
			{
				BossNameTextId = other.BossNameTextId;
			}
			if (other.BossTargetLocalText != 0)
			{
				BossTargetLocalText = other.BossTargetLocalText;
			}
			if (other.ClearDescLocalTextId != 0)
			{
				ClearDescLocalTextId = other.ClearDescLocalTextId;
			}
			fieldMonsterIds_.Add(other.fieldMonsterIds_);
			if (other.FloorDescLocalTextId != 0)
			{
				FloorDescLocalTextId = other.FloorDescLocalTextId;
			}
			if (other.FloorNameLocalTextId != 0)
			{
				FloorNameLocalTextId = other.FloorNameLocalTextId;
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
			monsterId_.Add(other.monsterId_);
			if (other.NormalDescLocalTextId != 0)
			{
				NormalDescLocalTextId = other.NormalDescLocalTextId;
			}
			if (other.NormalTargetLocalText != 0)
			{
				NormalTargetLocalText = other.NormalTargetLocalText;
			}
			if (other.RecordUpdateTimeline.Length != 0)
			{
				RecordUpdateTimeline = other.RecordUpdateTimeline;
			}
			if (other.TimeAttackId != 0)
			{
				TimeAttackId = other.TimeAttackId;
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
				PointPositionId = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 24u:
			case 26u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 40u:
				BattlePower = input.ReadInt32();
				break;
			case 50u:
				BestRecordTimeline = input.ReadString();
				break;
			case 56u:
				BossDescLocalTextId = input.ReadInt32();
				break;
			case 64u:
				BossId = input.ReadInt32();
				break;
			case 72u:
				BossNameTextId = input.ReadInt32();
				break;
			case 80u:
				BossTargetLocalText = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			case 88u:
				ClearDescLocalTextId = input.ReadInt32();
				break;
			case 96u:
			case 98u:
				fieldMonsterIds_.AddEntriesFrom(ref input, _repeated_fieldMonsterIds_codec);
				break;
			case 104u:
				FloorDescLocalTextId = input.ReadInt32();
				break;
			case 112u:
				FloorNameLocalTextId = input.ReadInt32();
				break;
			case 122u:
				IconSpriteName = input.ReadString();
				break;
			case 128u:
				Id = input.ReadInt32();
				break;
			case 136u:
				MapId = input.ReadInt32();
				break;
			case 144u:
			case 146u:
				monsterId_.AddEntriesFrom(ref input, _repeated_monsterId_codec);
				break;
			case 152u:
				NormalDescLocalTextId = input.ReadInt32();
				break;
			case 160u:
				NormalTargetLocalText = input.ReadInt32();
				break;
			case 170u:
				RecordUpdateTimeline = input.ReadString();
				break;
			case 176u:
				TimeAttackId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
