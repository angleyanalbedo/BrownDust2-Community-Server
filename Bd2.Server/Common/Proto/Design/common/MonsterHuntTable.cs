using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MonsterHuntTable : IMessage<MonsterHuntTable>, IMessage, IEquatable<MonsterHuntTable>, IDeepCloneable<MonsterHuntTable>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntTable> _parser = new MessageParser<MonsterHuntTable>(() => new MonsterHuntTable());

	private UnknownFieldSet _unknownFields;

	public const int BattleDeckIdFieldNumber = 1;

	private int battleDeckId_;

	public const int BossTip2LocalTextIdFieldNumber = 2;

	private int bossTip2LocalTextId_;

	public const int BossTipLocalTextIdFieldNumber = 3;

	private int bossTipLocalTextId_;

	public const int BossUpTimelineFieldNumber = 4;

	private string bossUpTimeline_ = "";

	public const int DescTextIdFieldNumber = 5;

	private int descTextId_;

	public const int FirstBossTimelineFieldNumber = 6;

	private string firstBossTimeline_ = "";

	public const int FixCriticalChainFieldNumber = 7;

	private int fixCriticalChain_;

	public const int IdFieldNumber = 8;

	private int id_;

	public const int LevelUpDamageRateFieldNumber = 9;

	private double levelUpDamageRate_;

	public const int LevelUpDamageSlopeFieldNumber = 10;

	private double levelUpDamageSlope_;

	public const int LevelUpHealthRateFieldNumber = 11;

	private double levelUpHealthRate_;

	public const int LevelUpHealthSlopeFieldNumber = 12;

	private double levelUpHealthSlope_;

	public const int MapIdFieldNumber = 13;

	private int mapId_;

	public const int MonsterIdFieldNumber = 14;

	private int monsterId_;

	public const int OpenLevelValueFieldNumber = 15;

	private int openLevelValue_;

	public const int PackIdFieldNumber = 16;

	private int packId_;

	public const int PartsGroupIdFieldNumber = 17;

	private int partsGroupId_;

	public const int PointIdFieldNumber = 18;

	private int pointId_;

	public const int PositionScaleFieldNumber = 19;

	private double positionScale_;

	public const int RewardGroupIdFieldNumber = 20;

	private int rewardGroupId_;

	public const int RewardLevelFieldNumber = 21;

	private int rewardLevel_;

	public const int StartTimelineFieldNumber = 22;

	private string startTimeline_ = "";

	public const int StatuePackIdFieldNumber = 23;

	private int statuePackId_;

	public const int TeamOpenLevelFieldNumber = 24;

	private static readonly FieldCodec<int> _repeated_teamOpenLevel_codec = FieldCodec.ForInt32(194u);

	private readonly RepeatedField<int> teamOpenLevel_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterHuntTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleDeckId
	{
		get
		{
			return battleDeckId_;
		}
		set
		{
			battleDeckId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BossTip2LocalTextId
	{
		get
		{
			return bossTip2LocalTextId_;
		}
		set
		{
			bossTip2LocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BossTipLocalTextId
	{
		get
		{
			return bossTipLocalTextId_;
		}
		set
		{
			bossTipLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BossUpTimeline
	{
		get
		{
			return bossUpTimeline_;
		}
		set
		{
			bossUpTimeline_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DescTextId
	{
		get
		{
			return descTextId_;
		}
		set
		{
			descTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string FirstBossTimeline
	{
		get
		{
			return firstBossTimeline_;
		}
		set
		{
			firstBossTimeline_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FixCriticalChain
	{
		get
		{
			return fixCriticalChain_;
		}
		set
		{
			fixCriticalChain_ = value;
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
	public double LevelUpDamageRate
	{
		get
		{
			return levelUpDamageRate_;
		}
		set
		{
			levelUpDamageRate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double LevelUpDamageSlope
	{
		get
		{
			return levelUpDamageSlope_;
		}
		set
		{
			levelUpDamageSlope_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double LevelUpHealthRate
	{
		get
		{
			return levelUpHealthRate_;
		}
		set
		{
			levelUpHealthRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double LevelUpHealthSlope
	{
		get
		{
			return levelUpHealthSlope_;
		}
		set
		{
			levelUpHealthSlope_ = value;
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
	public int MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OpenLevelValue
	{
		get
		{
			return openLevelValue_;
		}
		set
		{
			openLevelValue_ = value;
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
	public int PartsGroupId
	{
		get
		{
			return partsGroupId_;
		}
		set
		{
			partsGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PointId
	{
		get
		{
			return pointId_;
		}
		set
		{
			pointId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double PositionScale
	{
		get
		{
			return positionScale_;
		}
		set
		{
			positionScale_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardLevel
	{
		get
		{
			return rewardLevel_;
		}
		set
		{
			rewardLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string StartTimeline
	{
		get
		{
			return startTimeline_;
		}
		set
		{
			startTimeline_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StatuePackId
	{
		get
		{
			return statuePackId_;
		}
		set
		{
			statuePackId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> TeamOpenLevel => teamOpenLevel_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntTable(MonsterHuntTable other)
		: this()
	{
		battleDeckId_ = other.battleDeckId_;
		bossTip2LocalTextId_ = other.bossTip2LocalTextId_;
		bossTipLocalTextId_ = other.bossTipLocalTextId_;
		bossUpTimeline_ = other.bossUpTimeline_;
		descTextId_ = other.descTextId_;
		firstBossTimeline_ = other.firstBossTimeline_;
		fixCriticalChain_ = other.fixCriticalChain_;
		id_ = other.id_;
		levelUpDamageRate_ = other.levelUpDamageRate_;
		levelUpDamageSlope_ = other.levelUpDamageSlope_;
		levelUpHealthRate_ = other.levelUpHealthRate_;
		levelUpHealthSlope_ = other.levelUpHealthSlope_;
		mapId_ = other.mapId_;
		monsterId_ = other.monsterId_;
		openLevelValue_ = other.openLevelValue_;
		packId_ = other.packId_;
		partsGroupId_ = other.partsGroupId_;
		pointId_ = other.pointId_;
		positionScale_ = other.positionScale_;
		rewardGroupId_ = other.rewardGroupId_;
		rewardLevel_ = other.rewardLevel_;
		startTimeline_ = other.startTimeline_;
		statuePackId_ = other.statuePackId_;
		teamOpenLevel_ = other.teamOpenLevel_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntTable Clone()
	{
		return new MonsterHuntTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleDeckId == other.BattleDeckId && BossTip2LocalTextId == other.BossTip2LocalTextId && BossTipLocalTextId == other.BossTipLocalTextId && !(BossUpTimeline != other.BossUpTimeline) && DescTextId == other.DescTextId && !(FirstBossTimeline != other.FirstBossTimeline) && FixCriticalChain == other.FixCriticalChain && Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LevelUpDamageRate, other.LevelUpDamageRate) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LevelUpDamageSlope, other.LevelUpDamageSlope) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LevelUpHealthRate, other.LevelUpHealthRate) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LevelUpHealthSlope, other.LevelUpHealthSlope) && MapId == other.MapId && MonsterId == other.MonsterId && OpenLevelValue == other.OpenLevelValue && PackId == other.PackId && PartsGroupId == other.PartsGroupId && PointId == other.PointId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PositionScale, other.PositionScale) && RewardGroupId == other.RewardGroupId && RewardLevel == other.RewardLevel && !(StartTimeline != other.StartTimeline) && StatuePackId == other.StatuePackId && teamOpenLevel_.Equals(other.teamOpenLevel_))
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
		if (BattleDeckId != 0)
		{
			num ^= BattleDeckId.GetHashCode();
		}
		if (BossTip2LocalTextId != 0)
		{
			num ^= BossTip2LocalTextId.GetHashCode();
		}
		if (BossTipLocalTextId != 0)
		{
			num ^= BossTipLocalTextId.GetHashCode();
		}
		if (BossUpTimeline.Length != 0)
		{
			num ^= BossUpTimeline.GetHashCode();
		}
		if (DescTextId != 0)
		{
			num ^= DescTextId.GetHashCode();
		}
		if (FirstBossTimeline.Length != 0)
		{
			num ^= FirstBossTimeline.GetHashCode();
		}
		if (FixCriticalChain != 0)
		{
			num ^= FixCriticalChain.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LevelUpDamageRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LevelUpDamageRate);
		}
		if (LevelUpDamageSlope != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LevelUpDamageSlope);
		}
		if (LevelUpHealthRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LevelUpHealthRate);
		}
		if (LevelUpHealthSlope != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LevelUpHealthSlope);
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (OpenLevelValue != 0)
		{
			num ^= OpenLevelValue.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (PartsGroupId != 0)
		{
			num ^= PartsGroupId.GetHashCode();
		}
		if (PointId != 0)
		{
			num ^= PointId.GetHashCode();
		}
		if (PositionScale != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PositionScale);
		}
		if (RewardGroupId != 0)
		{
			num ^= RewardGroupId.GetHashCode();
		}
		if (RewardLevel != 0)
		{
			num ^= RewardLevel.GetHashCode();
		}
		if (StartTimeline.Length != 0)
		{
			num ^= StartTimeline.GetHashCode();
		}
		if (StatuePackId != 0)
		{
			num ^= StatuePackId.GetHashCode();
		}
		num ^= teamOpenLevel_.GetHashCode();
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
		if (BattleDeckId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleDeckId);
		}
		if (BossTip2LocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BossTip2LocalTextId);
		}
		if (BossTipLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BossTipLocalTextId);
		}
		if (BossUpTimeline.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BossUpTimeline);
		}
		if (DescTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DescTextId);
		}
		if (FirstBossTimeline.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(FirstBossTimeline);
		}
		if (FixCriticalChain != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(FixCriticalChain);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (LevelUpDamageRate != 0.0)
		{
			output.WriteRawTag(73);
			output.WriteDouble(LevelUpDamageRate);
		}
		if (LevelUpDamageSlope != 0.0)
		{
			output.WriteRawTag(81);
			output.WriteDouble(LevelUpDamageSlope);
		}
		if (LevelUpHealthRate != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(LevelUpHealthRate);
		}
		if (LevelUpHealthSlope != 0.0)
		{
			output.WriteRawTag(97);
			output.WriteDouble(LevelUpHealthSlope);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(MapId);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(MonsterId);
		}
		if (OpenLevelValue != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(OpenLevelValue);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(PackId);
		}
		if (PartsGroupId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(PartsGroupId);
		}
		if (PointId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(PointId);
		}
		if (PositionScale != 0.0)
		{
			output.WriteRawTag(153, 1);
			output.WriteDouble(PositionScale);
		}
		if (RewardGroupId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(RewardGroupId);
		}
		if (RewardLevel != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(RewardLevel);
		}
		if (StartTimeline.Length != 0)
		{
			output.WriteRawTag(178, 1);
			output.WriteString(StartTimeline);
		}
		if (StatuePackId != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(StatuePackId);
		}
		teamOpenLevel_.WriteTo(ref output, _repeated_teamOpenLevel_codec);
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
		if (BattleDeckId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDeckId);
		}
		if (BossTip2LocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossTip2LocalTextId);
		}
		if (BossTipLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossTipLocalTextId);
		}
		if (BossUpTimeline.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BossUpTimeline);
		}
		if (DescTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DescTextId);
		}
		if (FirstBossTimeline.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FirstBossTimeline);
		}
		if (FixCriticalChain != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FixCriticalChain);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LevelUpDamageRate != 0.0)
		{
			num += 9;
		}
		if (LevelUpDamageSlope != 0.0)
		{
			num += 9;
		}
		if (LevelUpHealthRate != 0.0)
		{
			num += 9;
		}
		if (LevelUpHealthSlope != 0.0)
		{
			num += 9;
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterId);
		}
		if (OpenLevelValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OpenLevelValue);
		}
		if (PackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (PartsGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PartsGroupId);
		}
		if (PointId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PointId);
		}
		if (PositionScale != 0.0)
		{
			num += 10;
		}
		if (RewardGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RewardGroupId);
		}
		if (RewardLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RewardLevel);
		}
		if (StartTimeline.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(StartTimeline);
		}
		if (StatuePackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StatuePackId);
		}
		num += teamOpenLevel_.CalculateSize(_repeated_teamOpenLevel_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterHuntTable other)
	{
		if (other != null)
		{
			if (other.BattleDeckId != 0)
			{
				BattleDeckId = other.BattleDeckId;
			}
			if (other.BossTip2LocalTextId != 0)
			{
				BossTip2LocalTextId = other.BossTip2LocalTextId;
			}
			if (other.BossTipLocalTextId != 0)
			{
				BossTipLocalTextId = other.BossTipLocalTextId;
			}
			if (other.BossUpTimeline.Length != 0)
			{
				BossUpTimeline = other.BossUpTimeline;
			}
			if (other.DescTextId != 0)
			{
				DescTextId = other.DescTextId;
			}
			if (other.FirstBossTimeline.Length != 0)
			{
				FirstBossTimeline = other.FirstBossTimeline;
			}
			if (other.FixCriticalChain != 0)
			{
				FixCriticalChain = other.FixCriticalChain;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LevelUpDamageRate != 0.0)
			{
				LevelUpDamageRate = other.LevelUpDamageRate;
			}
			if (other.LevelUpDamageSlope != 0.0)
			{
				LevelUpDamageSlope = other.LevelUpDamageSlope;
			}
			if (other.LevelUpHealthRate != 0.0)
			{
				LevelUpHealthRate = other.LevelUpHealthRate;
			}
			if (other.LevelUpHealthSlope != 0.0)
			{
				LevelUpHealthSlope = other.LevelUpHealthSlope;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.OpenLevelValue != 0)
			{
				OpenLevelValue = other.OpenLevelValue;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.PartsGroupId != 0)
			{
				PartsGroupId = other.PartsGroupId;
			}
			if (other.PointId != 0)
			{
				PointId = other.PointId;
			}
			if (other.PositionScale != 0.0)
			{
				PositionScale = other.PositionScale;
			}
			if (other.RewardGroupId != 0)
			{
				RewardGroupId = other.RewardGroupId;
			}
			if (other.RewardLevel != 0)
			{
				RewardLevel = other.RewardLevel;
			}
			if (other.StartTimeline.Length != 0)
			{
				StartTimeline = other.StartTimeline;
			}
			if (other.StatuePackId != 0)
			{
				StatuePackId = other.StatuePackId;
			}
			teamOpenLevel_.Add(other.teamOpenLevel_);
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
				BattleDeckId = input.ReadInt32();
				break;
			case 16u:
				BossTip2LocalTextId = input.ReadInt32();
				break;
			case 24u:
				BossTipLocalTextId = input.ReadInt32();
				break;
			case 34u:
				BossUpTimeline = input.ReadString();
				break;
			case 40u:
				DescTextId = input.ReadInt32();
				break;
			case 50u:
				FirstBossTimeline = input.ReadString();
				break;
			case 56u:
				FixCriticalChain = input.ReadInt32();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 73u:
				LevelUpDamageRate = input.ReadDouble();
				break;
			case 81u:
				LevelUpDamageSlope = input.ReadDouble();
				break;
			case 89u:
				LevelUpHealthRate = input.ReadDouble();
				break;
			case 97u:
				LevelUpHealthSlope = input.ReadDouble();
				break;
			case 104u:
				MapId = input.ReadInt32();
				break;
			case 112u:
				MonsterId = input.ReadInt32();
				break;
			case 120u:
				OpenLevelValue = input.ReadInt32();
				break;
			case 128u:
				PackId = input.ReadInt32();
				break;
			case 136u:
				PartsGroupId = input.ReadInt32();
				break;
			case 144u:
				PointId = input.ReadInt32();
				break;
			case 153u:
				PositionScale = input.ReadDouble();
				break;
			case 160u:
				RewardGroupId = input.ReadInt32();
				break;
			case 168u:
				RewardLevel = input.ReadInt32();
				break;
			case 178u:
				StartTimeline = input.ReadString();
				break;
			case 184u:
				StatuePackId = input.ReadInt32();
				break;
			case 192u:
			case 194u:
				teamOpenLevel_.AddEntriesFrom(ref input, _repeated_teamOpenLevel_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
