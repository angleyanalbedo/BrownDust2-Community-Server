using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MapTable : IMessage<MapTable>, IMessage, IEquatable<MapTable>, IDeepCloneable<MapTable>, IBufferMessage
{
	private static readonly MessageParser<MapTable> _parser = new MessageParser<MapTable>(() => new MapTable());

	private UnknownFieldSet _unknownFields;

	public const int AccelerationSpeedFieldNumber = 1;

	private double accelerationSpeed_;

	public const int AdvantCharElementFieldNumber = 2;

	private int advantCharElement_;

	public const int AmbienceNameFieldNumber = 3;

	private string ambienceName_ = "";

	public const int AudioCrossfadeFieldNumber = 4;

	private int audioCrossfade_;

	public const int BattleDeckIdFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_battleDeckId_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> battleDeckId_ = new RepeatedField<int>();

	public const int CommonSoundIdFieldNumber = 6;

	private int commonSoundId_;

	public const int EncounteSafeValueFieldNumber = 7;

	private int encounteSafeValue_;

	public const int EncounterMaxValueFieldNumber = 8;

	private int encounterMaxValue_;

	public const int EnvEffectResourceNameFieldNumber = 9;

	private string envEffectResourceName_ = "";

	public const int FlashlightResouceNameFieldNumber = 10;

	private string flashlightResouceName_ = "";

	public const int FootStepSoundTypeFieldNumber = 11;

	private int footStepSoundType_;

	public const int GateIdFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_gateId_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> gateId_ = new RepeatedField<int>();

	public const int IdFieldNumber = 13;

	private int id_;

	public const int IsInsideMapFieldNumber = 14;

	private int isInsideMap_;

	public const int MapEffectFieldNumber = 15;

	private int mapEffect_;

	public const int MapEffectFreqMaxFieldNumber = 16;

	private int mapEffectFreqMax_;

	public const int MapEffectFreqMinFieldNumber = 17;

	private int mapEffectFreqMin_;

	public const int MapGroupIdFieldNumber = 18;

	private int mapGroupId_;

	public const int MapNameTextIdFieldNumber = 19;

	private int mapNameTextId_;

	public const int MapScaleFieldNumber = 20;

	private int mapScale_;

	public const int MapScenePathFieldNumber = 21;

	private string mapScenePath_ = "";

	public const int MapTypeFieldNumber = 22;

	private int mapType_;

	public const int MaxSpeedFieldNumber = 23;

	private double maxSpeed_;

	public const int MinimapSizeFieldNumber = 24;

	private string minimapSize_ = "";

	public const int MinimapSpriteNameFieldNumber = 25;

	private string minimapSpriteName_ = "";

	public const int MonsterElementFieldNumber = 26;

	private int monsterElement_;

	public const int OffsetFieldNumber = 27;

	private string offset_ = "";

	public const int PackIdFieldNumber = 28;

	private int packId_;

	public const int ShowHpUiFieldNumber = 29;

	private int showHpUi_;

	public const int ShowQuestIdFieldNumber = 30;

	private int showQuestId_;

	public const int TimeLineEffectUseFieldNumber = 31;

	private int timeLineEffectUse_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MapTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double AccelerationSpeed
	{
		get
		{
			return accelerationSpeed_;
		}
		set
		{
			accelerationSpeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AdvantCharElement
	{
		get
		{
			return advantCharElement_;
		}
		set
		{
			advantCharElement_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AmbienceName
	{
		get
		{
			return ambienceName_;
		}
		set
		{
			ambienceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AudioCrossfade
	{
		get
		{
			return audioCrossfade_;
		}
		set
		{
			audioCrossfade_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BattleDeckId => battleDeckId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CommonSoundId
	{
		get
		{
			return commonSoundId_;
		}
		set
		{
			commonSoundId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EncounteSafeValue
	{
		get
		{
			return encounteSafeValue_;
		}
		set
		{
			encounteSafeValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EncounterMaxValue
	{
		get
		{
			return encounterMaxValue_;
		}
		set
		{
			encounterMaxValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EnvEffectResourceName
	{
		get
		{
			return envEffectResourceName_;
		}
		set
		{
			envEffectResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string FlashlightResouceName
	{
		get
		{
			return flashlightResouceName_;
		}
		set
		{
			flashlightResouceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FootStepSoundType
	{
		get
		{
			return footStepSoundType_;
		}
		set
		{
			footStepSoundType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GateId => gateId_;

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
	public int IsInsideMap
	{
		get
		{
			return isInsideMap_;
		}
		set
		{
			isInsideMap_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MapEffect
	{
		get
		{
			return mapEffect_;
		}
		set
		{
			mapEffect_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapEffectFreqMax
	{
		get
		{
			return mapEffectFreqMax_;
		}
		set
		{
			mapEffectFreqMax_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MapEffectFreqMin
	{
		get
		{
			return mapEffectFreqMin_;
		}
		set
		{
			mapEffectFreqMin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapGroupId
	{
		get
		{
			return mapGroupId_;
		}
		set
		{
			mapGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int MapScale
	{
		get
		{
			return mapScale_;
		}
		set
		{
			mapScale_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MapScenePath
	{
		get
		{
			return mapScenePath_;
		}
		set
		{
			mapScenePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapType
	{
		get
		{
			return mapType_;
		}
		set
		{
			mapType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MaxSpeed
	{
		get
		{
			return maxSpeed_;
		}
		set
		{
			maxSpeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MinimapSize
	{
		get
		{
			return minimapSize_;
		}
		set
		{
			minimapSize_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MinimapSpriteName
	{
		get
		{
			return minimapSpriteName_;
		}
		set
		{
			minimapSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MonsterElement
	{
		get
		{
			return monsterElement_;
		}
		set
		{
			monsterElement_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Offset
	{
		get
		{
			return offset_;
		}
		set
		{
			offset_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public int ShowHpUi
	{
		get
		{
			return showHpUi_;
		}
		set
		{
			showHpUi_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShowQuestId
	{
		get
		{
			return showQuestId_;
		}
		set
		{
			showQuestId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TimeLineEffectUse
	{
		get
		{
			return timeLineEffectUse_;
		}
		set
		{
			timeLineEffectUse_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapTable(MapTable other)
		: this()
	{
		accelerationSpeed_ = other.accelerationSpeed_;
		advantCharElement_ = other.advantCharElement_;
		ambienceName_ = other.ambienceName_;
		audioCrossfade_ = other.audioCrossfade_;
		battleDeckId_ = other.battleDeckId_.Clone();
		commonSoundId_ = other.commonSoundId_;
		encounteSafeValue_ = other.encounteSafeValue_;
		encounterMaxValue_ = other.encounterMaxValue_;
		envEffectResourceName_ = other.envEffectResourceName_;
		flashlightResouceName_ = other.flashlightResouceName_;
		footStepSoundType_ = other.footStepSoundType_;
		gateId_ = other.gateId_.Clone();
		id_ = other.id_;
		isInsideMap_ = other.isInsideMap_;
		mapEffect_ = other.mapEffect_;
		mapEffectFreqMax_ = other.mapEffectFreqMax_;
		mapEffectFreqMin_ = other.mapEffectFreqMin_;
		mapGroupId_ = other.mapGroupId_;
		mapNameTextId_ = other.mapNameTextId_;
		mapScale_ = other.mapScale_;
		mapScenePath_ = other.mapScenePath_;
		mapType_ = other.mapType_;
		maxSpeed_ = other.maxSpeed_;
		minimapSize_ = other.minimapSize_;
		minimapSpriteName_ = other.minimapSpriteName_;
		monsterElement_ = other.monsterElement_;
		offset_ = other.offset_;
		packId_ = other.packId_;
		showHpUi_ = other.showHpUi_;
		showQuestId_ = other.showQuestId_;
		timeLineEffectUse_ = other.timeLineEffectUse_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapTable Clone()
	{
		return new MapTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MapTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MapTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AccelerationSpeed, other.AccelerationSpeed) && AdvantCharElement == other.AdvantCharElement && !(AmbienceName != other.AmbienceName) && AudioCrossfade == other.AudioCrossfade && battleDeckId_.Equals(other.battleDeckId_) && CommonSoundId == other.CommonSoundId && EncounteSafeValue == other.EncounteSafeValue && EncounterMaxValue == other.EncounterMaxValue && !(EnvEffectResourceName != other.EnvEffectResourceName) && !(FlashlightResouceName != other.FlashlightResouceName) && FootStepSoundType == other.FootStepSoundType && gateId_.Equals(other.gateId_) && Id == other.Id && IsInsideMap == other.IsInsideMap && MapEffect == other.MapEffect && MapEffectFreqMax == other.MapEffectFreqMax && MapEffectFreqMin == other.MapEffectFreqMin && MapGroupId == other.MapGroupId && MapNameTextId == other.MapNameTextId && MapScale == other.MapScale && !(MapScenePath != other.MapScenePath) && MapType == other.MapType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxSpeed, other.MaxSpeed) && !(MinimapSize != other.MinimapSize) && !(MinimapSpriteName != other.MinimapSpriteName) && MonsterElement == other.MonsterElement && !(Offset != other.Offset) && PackId == other.PackId && ShowHpUi == other.ShowHpUi && ShowQuestId == other.ShowQuestId && TimeLineEffectUse == other.TimeLineEffectUse)
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
		if (AccelerationSpeed != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AccelerationSpeed);
		}
		if (AdvantCharElement != 0)
		{
			num ^= AdvantCharElement.GetHashCode();
		}
		if (AmbienceName.Length != 0)
		{
			num ^= AmbienceName.GetHashCode();
		}
		if (AudioCrossfade != 0)
		{
			num ^= AudioCrossfade.GetHashCode();
		}
		num ^= battleDeckId_.GetHashCode();
		if (CommonSoundId != 0)
		{
			num ^= CommonSoundId.GetHashCode();
		}
		if (EncounteSafeValue != 0)
		{
			num ^= EncounteSafeValue.GetHashCode();
		}
		if (EncounterMaxValue != 0)
		{
			num ^= EncounterMaxValue.GetHashCode();
		}
		if (EnvEffectResourceName.Length != 0)
		{
			num ^= EnvEffectResourceName.GetHashCode();
		}
		if (FlashlightResouceName.Length != 0)
		{
			num ^= FlashlightResouceName.GetHashCode();
		}
		if (FootStepSoundType != 0)
		{
			num ^= FootStepSoundType.GetHashCode();
		}
		num ^= gateId_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsInsideMap != 0)
		{
			num ^= IsInsideMap.GetHashCode();
		}
		if (MapEffect != 0)
		{
			num ^= MapEffect.GetHashCode();
		}
		if (MapEffectFreqMax != 0)
		{
			num ^= MapEffectFreqMax.GetHashCode();
		}
		if (MapEffectFreqMin != 0)
		{
			num ^= MapEffectFreqMin.GetHashCode();
		}
		if (MapGroupId != 0)
		{
			num ^= MapGroupId.GetHashCode();
		}
		if (MapNameTextId != 0)
		{
			num ^= MapNameTextId.GetHashCode();
		}
		if (MapScale != 0)
		{
			num ^= MapScale.GetHashCode();
		}
		if (MapScenePath.Length != 0)
		{
			num ^= MapScenePath.GetHashCode();
		}
		if (MapType != 0)
		{
			num ^= MapType.GetHashCode();
		}
		if (MaxSpeed != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxSpeed);
		}
		if (MinimapSize.Length != 0)
		{
			num ^= MinimapSize.GetHashCode();
		}
		if (MinimapSpriteName.Length != 0)
		{
			num ^= MinimapSpriteName.GetHashCode();
		}
		if (MonsterElement != 0)
		{
			num ^= MonsterElement.GetHashCode();
		}
		if (Offset.Length != 0)
		{
			num ^= Offset.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (ShowHpUi != 0)
		{
			num ^= ShowHpUi.GetHashCode();
		}
		if (ShowQuestId != 0)
		{
			num ^= ShowQuestId.GetHashCode();
		}
		if (TimeLineEffectUse != 0)
		{
			num ^= TimeLineEffectUse.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AccelerationSpeed != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(AccelerationSpeed);
		}
		if (AdvantCharElement != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AdvantCharElement);
		}
		if (AmbienceName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AmbienceName);
		}
		if (AudioCrossfade != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AudioCrossfade);
		}
		battleDeckId_.WriteTo(ref output, _repeated_battleDeckId_codec);
		if (CommonSoundId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CommonSoundId);
		}
		if (EncounteSafeValue != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(EncounteSafeValue);
		}
		if (EncounterMaxValue != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(EncounterMaxValue);
		}
		if (EnvEffectResourceName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(EnvEffectResourceName);
		}
		if (FlashlightResouceName.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(FlashlightResouceName);
		}
		if (FootStepSoundType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(FootStepSoundType);
		}
		gateId_.WriteTo(ref output, _repeated_gateId_codec);
		if (Id != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(Id);
		}
		if (IsInsideMap != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(IsInsideMap);
		}
		if (MapEffect != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(MapEffect);
		}
		if (MapEffectFreqMax != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(MapEffectFreqMax);
		}
		if (MapEffectFreqMin != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(MapEffectFreqMin);
		}
		if (MapGroupId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(MapGroupId);
		}
		if (MapNameTextId != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(MapNameTextId);
		}
		if (MapScale != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(MapScale);
		}
		if (MapScenePath.Length != 0)
		{
			output.WriteRawTag(170, 1);
			output.WriteString(MapScenePath);
		}
		if (MapType != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(MapType);
		}
		if (MaxSpeed != 0.0)
		{
			output.WriteRawTag(185, 1);
			output.WriteDouble(MaxSpeed);
		}
		if (MinimapSize.Length != 0)
		{
			output.WriteRawTag(194, 1);
			output.WriteString(MinimapSize);
		}
		if (MinimapSpriteName.Length != 0)
		{
			output.WriteRawTag(202, 1);
			output.WriteString(MinimapSpriteName);
		}
		if (MonsterElement != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(MonsterElement);
		}
		if (Offset.Length != 0)
		{
			output.WriteRawTag(218, 1);
			output.WriteString(Offset);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(PackId);
		}
		if (ShowHpUi != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(ShowHpUi);
		}
		if (ShowQuestId != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(ShowQuestId);
		}
		if (TimeLineEffectUse != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(TimeLineEffectUse);
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
		if (AccelerationSpeed != 0.0)
		{
			num += 9;
		}
		if (AdvantCharElement != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AdvantCharElement);
		}
		if (AmbienceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AmbienceName);
		}
		if (AudioCrossfade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AudioCrossfade);
		}
		num += battleDeckId_.CalculateSize(_repeated_battleDeckId_codec);
		if (CommonSoundId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CommonSoundId);
		}
		if (EncounteSafeValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EncounteSafeValue);
		}
		if (EncounterMaxValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EncounterMaxValue);
		}
		if (EnvEffectResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnvEffectResourceName);
		}
		if (FlashlightResouceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FlashlightResouceName);
		}
		if (FootStepSoundType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FootStepSoundType);
		}
		num += gateId_.CalculateSize(_repeated_gateId_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsInsideMap != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsInsideMap);
		}
		if (MapEffect != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapEffect);
		}
		if (MapEffectFreqMax != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapEffectFreqMax);
		}
		if (MapEffectFreqMin != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapEffectFreqMin);
		}
		if (MapGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapGroupId);
		}
		if (MapNameTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapNameTextId);
		}
		if (MapScale != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapScale);
		}
		if (MapScenePath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MapScenePath);
		}
		if (MapType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapType);
		}
		if (MaxSpeed != 0.0)
		{
			num += 10;
		}
		if (MinimapSize.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MinimapSize);
		}
		if (MinimapSpriteName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MinimapSpriteName);
		}
		if (MonsterElement != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MonsterElement);
		}
		if (Offset.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Offset);
		}
		if (PackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (ShowHpUi != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShowHpUi);
		}
		if (ShowQuestId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShowQuestId);
		}
		if (TimeLineEffectUse != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TimeLineEffectUse);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MapTable other)
	{
		if (other != null)
		{
			if (other.AccelerationSpeed != 0.0)
			{
				AccelerationSpeed = other.AccelerationSpeed;
			}
			if (other.AdvantCharElement != 0)
			{
				AdvantCharElement = other.AdvantCharElement;
			}
			if (other.AmbienceName.Length != 0)
			{
				AmbienceName = other.AmbienceName;
			}
			if (other.AudioCrossfade != 0)
			{
				AudioCrossfade = other.AudioCrossfade;
			}
			battleDeckId_.Add(other.battleDeckId_);
			if (other.CommonSoundId != 0)
			{
				CommonSoundId = other.CommonSoundId;
			}
			if (other.EncounteSafeValue != 0)
			{
				EncounteSafeValue = other.EncounteSafeValue;
			}
			if (other.EncounterMaxValue != 0)
			{
				EncounterMaxValue = other.EncounterMaxValue;
			}
			if (other.EnvEffectResourceName.Length != 0)
			{
				EnvEffectResourceName = other.EnvEffectResourceName;
			}
			if (other.FlashlightResouceName.Length != 0)
			{
				FlashlightResouceName = other.FlashlightResouceName;
			}
			if (other.FootStepSoundType != 0)
			{
				FootStepSoundType = other.FootStepSoundType;
			}
			gateId_.Add(other.gateId_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsInsideMap != 0)
			{
				IsInsideMap = other.IsInsideMap;
			}
			if (other.MapEffect != 0)
			{
				MapEffect = other.MapEffect;
			}
			if (other.MapEffectFreqMax != 0)
			{
				MapEffectFreqMax = other.MapEffectFreqMax;
			}
			if (other.MapEffectFreqMin != 0)
			{
				MapEffectFreqMin = other.MapEffectFreqMin;
			}
			if (other.MapGroupId != 0)
			{
				MapGroupId = other.MapGroupId;
			}
			if (other.MapNameTextId != 0)
			{
				MapNameTextId = other.MapNameTextId;
			}
			if (other.MapScale != 0)
			{
				MapScale = other.MapScale;
			}
			if (other.MapScenePath.Length != 0)
			{
				MapScenePath = other.MapScenePath;
			}
			if (other.MapType != 0)
			{
				MapType = other.MapType;
			}
			if (other.MaxSpeed != 0.0)
			{
				MaxSpeed = other.MaxSpeed;
			}
			if (other.MinimapSize.Length != 0)
			{
				MinimapSize = other.MinimapSize;
			}
			if (other.MinimapSpriteName.Length != 0)
			{
				MinimapSpriteName = other.MinimapSpriteName;
			}
			if (other.MonsterElement != 0)
			{
				MonsterElement = other.MonsterElement;
			}
			if (other.Offset.Length != 0)
			{
				Offset = other.Offset;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.ShowHpUi != 0)
			{
				ShowHpUi = other.ShowHpUi;
			}
			if (other.ShowQuestId != 0)
			{
				ShowQuestId = other.ShowQuestId;
			}
			if (other.TimeLineEffectUse != 0)
			{
				TimeLineEffectUse = other.TimeLineEffectUse;
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
			case 9u:
				AccelerationSpeed = input.ReadDouble();
				break;
			case 16u:
				AdvantCharElement = input.ReadInt32();
				break;
			case 26u:
				AmbienceName = input.ReadString();
				break;
			case 32u:
				AudioCrossfade = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				battleDeckId_.AddEntriesFrom(ref input, _repeated_battleDeckId_codec);
				break;
			case 48u:
				CommonSoundId = input.ReadInt32();
				break;
			case 56u:
				EncounteSafeValue = input.ReadInt32();
				break;
			case 64u:
				EncounterMaxValue = input.ReadInt32();
				break;
			case 74u:
				EnvEffectResourceName = input.ReadString();
				break;
			case 82u:
				FlashlightResouceName = input.ReadString();
				break;
			case 88u:
				FootStepSoundType = input.ReadInt32();
				break;
			case 96u:
			case 98u:
				gateId_.AddEntriesFrom(ref input, _repeated_gateId_codec);
				break;
			case 104u:
				Id = input.ReadInt32();
				break;
			case 112u:
				IsInsideMap = input.ReadInt32();
				break;
			case 120u:
				MapEffect = input.ReadInt32();
				break;
			case 128u:
				MapEffectFreqMax = input.ReadInt32();
				break;
			case 136u:
				MapEffectFreqMin = input.ReadInt32();
				break;
			case 144u:
				MapGroupId = input.ReadInt32();
				break;
			case 152u:
				MapNameTextId = input.ReadInt32();
				break;
			case 160u:
				MapScale = input.ReadInt32();
				break;
			case 170u:
				MapScenePath = input.ReadString();
				break;
			case 176u:
				MapType = input.ReadInt32();
				break;
			case 185u:
				MaxSpeed = input.ReadDouble();
				break;
			case 194u:
				MinimapSize = input.ReadString();
				break;
			case 202u:
				MinimapSpriteName = input.ReadString();
				break;
			case 208u:
				MonsterElement = input.ReadInt32();
				break;
			case 218u:
				Offset = input.ReadString();
				break;
			case 224u:
				PackId = input.ReadInt32();
				break;
			case 232u:
				ShowHpUi = input.ReadInt32();
				break;
			case 240u:
				ShowQuestId = input.ReadInt32();
				break;
			case 248u:
				TimeLineEffectUse = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
