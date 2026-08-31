using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackTable : IMessage<PackTable>, IMessage, IEquatable<PackTable>, IDeepCloneable<PackTable>, IBufferMessage
{
	private static readonly MessageParser<PackTable> _parser = new MessageParser<PackTable>(() => new PackTable());

	private UnknownFieldSet _unknownFields;

	public const int BadgeFieldNumber = 1;

	private int badge_;

	public const int BgmNameFieldNumber = 2;

	private string bgmName_ = "";

	public const int BgmSoundIdFieldNumber = 3;

	private int bgmSoundId_;

	public const int BgmTitleLocalTextIdFieldNumber = 4;

	private int bgmTitleLocalTextId_;

	public const int BundleLabelFieldNumber = 5;

	private string bundleLabel_ = "";

	public const int BuyDescLocalTextIdFieldNumber = 6;

	private int buyDescLocalTextId_;

	public const int BuyPriceFieldNumber = 7;

	private int buyPrice_;

	public const int BuyRewardCountFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_buyRewardCount_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> buyRewardCount_ = new RepeatedField<int>();

	public const int BuyRewardIdFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_buyRewardId_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> buyRewardId_ = new RepeatedField<int>();

	public const int BuyRewardTypeFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_buyRewardType_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> buyRewardType_ = new RepeatedField<int>();

	public const int BuyTypeFieldNumber = 11;

	private int buyType_;

	public const int CaseBackTextureNameFieldNumber = 12;

	private string caseBackTextureName_ = "";

	public const int CaseBackThumbnailTextureNameFieldNumber = 13;

	private string caseBackThumbnailTextureName_ = "";

	public const int CaseFrontPrefabNameFieldNumber = 14;

	private string caseFrontPrefabName_ = "";

	public const int ContentTypeTextIdFieldNumber = 15;

	private int contentTypeTextId_;

	public const int DockingOnceFieldNumber = 16;

	private int dockingOnce_;

	public const int EpilogImageNameFieldNumber = 17;

	private string epilogImageName_ = "";

	public const int EpilogLocalTextIdFieldNumber = 18;

	private int epilogLocalTextId_;

	public const int EpilogueBGMFieldNumber = 19;

	private string epilogueBGM_ = "";

	public const int FieldMapIdFieldNumber = 20;

	private static readonly FieldCodec<int> _repeated_fieldMapId_codec = FieldCodec.ForInt32(162u);

	private readonly RepeatedField<int> fieldMapId_ = new RepeatedField<int>();

	public const int FieldMonsterGroupIdFieldNumber = 21;

	private static readonly FieldCodec<int> _repeated_fieldMonsterGroupId_codec = FieldCodec.ForInt32(170u);

	private readonly RepeatedField<int> fieldMonsterGroupId_ = new RepeatedField<int>();

	public const int FieldObjectGroupIdFieldNumber = 22;

	private static readonly FieldCodec<int> _repeated_fieldObjectGroupId_codec = FieldCodec.ForInt32(178u);

	private readonly RepeatedField<int> fieldObjectGroupId_ = new RepeatedField<int>();

	public const int FieldTrapGroupIdFieldNumber = 23;

	private static readonly FieldCodec<int> _repeated_fieldTrapGroupId_codec = FieldCodec.ForInt32(186u);

	private readonly RepeatedField<int> fieldTrapGroupId_ = new RepeatedField<int>();

	public const int IdFieldNumber = 24;

	private int id_;

	public const int IsNewPackFieldNumber = 25;

	private int isNewPack_;

	public const int IsSkipPackInsertDirectionFieldNumber = 26;

	private int isSkipPackInsertDirection_;

	public const int LogTypeFieldNumber = 27;

	private int logType_;

	public const int MainQuestRewardCountFieldNumber = 28;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardCount_codec = FieldCodec.ForInt32(226u);

	private readonly RepeatedField<int> mainQuestRewardCount_ = new RepeatedField<int>();

	public const int MainQuestRewardCount1FieldNumber = 29;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardCount1_codec = FieldCodec.ForInt32(234u);

	private readonly RepeatedField<int> mainQuestRewardCount1_ = new RepeatedField<int>();

	public const int MainQuestRewardCount2FieldNumber = 30;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardCount2_codec = FieldCodec.ForInt32(242u);

	private readonly RepeatedField<int> mainQuestRewardCount2_ = new RepeatedField<int>();

	public const int MainQuestRewardCount3FieldNumber = 31;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardCount3_codec = FieldCodec.ForInt32(250u);

	private readonly RepeatedField<int> mainQuestRewardCount3_ = new RepeatedField<int>();

	public const int MainQuestRewardCount4FieldNumber = 32;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardCount4_codec = FieldCodec.ForInt32(258u);

	private readonly RepeatedField<int> mainQuestRewardCount4_ = new RepeatedField<int>();

	public const int MainQuestRewardIdFieldNumber = 33;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardId_codec = FieldCodec.ForInt32(266u);

	private readonly RepeatedField<int> mainQuestRewardId_ = new RepeatedField<int>();

	public const int MainQuestRewardId1FieldNumber = 34;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardId1_codec = FieldCodec.ForInt32(274u);

	private readonly RepeatedField<int> mainQuestRewardId1_ = new RepeatedField<int>();

	public const int MainQuestRewardId2FieldNumber = 35;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardId2_codec = FieldCodec.ForInt32(282u);

	private readonly RepeatedField<int> mainQuestRewardId2_ = new RepeatedField<int>();

	public const int MainQuestRewardId3FieldNumber = 36;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardId3_codec = FieldCodec.ForInt32(290u);

	private readonly RepeatedField<int> mainQuestRewardId3_ = new RepeatedField<int>();

	public const int MainQuestRewardId4FieldNumber = 37;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardId4_codec = FieldCodec.ForInt32(298u);

	private readonly RepeatedField<int> mainQuestRewardId4_ = new RepeatedField<int>();

	public const int MainQuestRewardTypeFieldNumber = 38;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardType_codec = FieldCodec.ForInt32(306u);

	private readonly RepeatedField<int> mainQuestRewardType_ = new RepeatedField<int>();

	public const int MainQuestRewardType1FieldNumber = 39;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardType1_codec = FieldCodec.ForInt32(314u);

	private readonly RepeatedField<int> mainQuestRewardType1_ = new RepeatedField<int>();

	public const int MainQuestRewardType2FieldNumber = 40;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardType2_codec = FieldCodec.ForInt32(322u);

	private readonly RepeatedField<int> mainQuestRewardType2_ = new RepeatedField<int>();

	public const int MainQuestRewardType3FieldNumber = 41;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardType3_codec = FieldCodec.ForInt32(330u);

	private readonly RepeatedField<int> mainQuestRewardType3_ = new RepeatedField<int>();

	public const int MainQuestRewardType4FieldNumber = 42;

	private static readonly FieldCodec<int> _repeated_mainQuestRewardType4_codec = FieldCodec.ForInt32(338u);

	private readonly RepeatedField<int> mainQuestRewardType4_ = new RepeatedField<int>();

	public const int MarketCodeFieldNumber = 43;

	private int marketCode_;

	public const int NextPackIdFieldNumber = 44;

	private int nextPackId_;

	public const int PackDescNameTextIdFieldNumber = 45;

	private int packDescNameTextId_;

	public const int PackHideFieldNumber = 46;

	private int packHide_;

	public const int PackLoadingPrefabNameFieldNumber = 47;

	private string packLoadingPrefabName_ = "";

	public const int PackNameTextIdFieldNumber = 48;

	private int packNameTextId_;

	public const int PackPeriodFieldNumber = 49;

	private int packPeriod_;

	public const int PackPreviewNameFieldNumber = 50;

	private static readonly FieldCodec<string> _repeated_packPreviewName_codec = FieldCodec.ForString(402u);

	private readonly RepeatedField<string> packPreviewName_ = new RepeatedField<string>();

	public const int PackPreviewSpriteNameFieldNumber = 51;

	private static readonly FieldCodec<string> _repeated_packPreviewSpriteName_codec = FieldCodec.ForString(410u);

	private readonly RepeatedField<string> packPreviewSpriteName_ = new RepeatedField<string>();

	public const int PackSpriteNameFieldNumber = 52;

	private string packSpriteName_ = "";

	public const int PackTypeFieldNumber = 53;

	private int packType_;

	public const int PackUnopenedResourceNameFieldNumber = 54;

	private string packUnopenedResourceName_ = "";

	public const int PriorPackIndexFieldNumber = 55;

	private int priorPackIndex_;

	public const int PrologImageNameFieldNumber = 56;

	private string prologImageName_ = "";

	public const int PrologLocalTextIdFieldNumber = 57;

	private int prologLocalTextId_;

	public const int PrologueBGMFieldNumber = 58;

	private string prologueBGM_ = "";

	public const int SalePriceFieldNumber = 59;

	private int salePrice_;

	public const int StartPositionPathFieldNumber = 60;

	private string startPositionPath_ = "";

	public const int UseScheduleFieldNumber = 61;

	private int useSchedule_;

	public const int WaypointPriceTypeFieldNumber = 62;

	private int waypointPriceType_;

	public const int WaypointPriceUnitCountFieldNumber = 63;

	private int waypointPriceUnitCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Badge
	{
		get
		{
			return badge_;
		}
		set
		{
			badge_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BgmName
	{
		get
		{
			return bgmName_;
		}
		set
		{
			bgmName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BgmSoundId
	{
		get
		{
			return bgmSoundId_;
		}
		set
		{
			bgmSoundId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BgmTitleLocalTextId
	{
		get
		{
			return bgmTitleLocalTextId_;
		}
		set
		{
			bgmTitleLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BundleLabel
	{
		get
		{
			return bundleLabel_;
		}
		set
		{
			bundleLabel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuyDescLocalTextId
	{
		get
		{
			return buyDescLocalTextId_;
		}
		set
		{
			buyDescLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuyPrice
	{
		get
		{
			return buyPrice_;
		}
		set
		{
			buyPrice_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BuyRewardCount => buyRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> BuyRewardId => buyRewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BuyRewardType => buyRewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuyType
	{
		get
		{
			return buyType_;
		}
		set
		{
			buyType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CaseBackTextureName
	{
		get
		{
			return caseBackTextureName_;
		}
		set
		{
			caseBackTextureName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CaseBackThumbnailTextureName
	{
		get
		{
			return caseBackThumbnailTextureName_;
		}
		set
		{
			caseBackThumbnailTextureName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CaseFrontPrefabName
	{
		get
		{
			return caseFrontPrefabName_;
		}
		set
		{
			caseFrontPrefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ContentTypeTextId
	{
		get
		{
			return contentTypeTextId_;
		}
		set
		{
			contentTypeTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DockingOnce
	{
		get
		{
			return dockingOnce_;
		}
		set
		{
			dockingOnce_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string EpilogImageName
	{
		get
		{
			return epilogImageName_;
		}
		set
		{
			epilogImageName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EpilogLocalTextId
	{
		get
		{
			return epilogLocalTextId_;
		}
		set
		{
			epilogLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EpilogueBGM
	{
		get
		{
			return epilogueBGM_;
		}
		set
		{
			epilogueBGM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> FieldMapId => fieldMapId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> FieldMonsterGroupId => fieldMonsterGroupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> FieldObjectGroupId => fieldObjectGroupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> FieldTrapGroupId => fieldTrapGroupId_;

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
	public int IsNewPack
	{
		get
		{
			return isNewPack_;
		}
		set
		{
			isNewPack_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IsSkipPackInsertDirection
	{
		get
		{
			return isSkipPackInsertDirection_;
		}
		set
		{
			isSkipPackInsertDirection_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LogType
	{
		get
		{
			return logType_;
		}
		set
		{
			logType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MainQuestRewardCount => mainQuestRewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardCount1 => mainQuestRewardCount1_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardCount2 => mainQuestRewardCount2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardCount3 => mainQuestRewardCount3_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardCount4 => mainQuestRewardCount4_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MainQuestRewardId => mainQuestRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardId1 => mainQuestRewardId1_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardId2 => mainQuestRewardId2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardId3 => mainQuestRewardId3_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MainQuestRewardId4 => mainQuestRewardId4_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardType => mainQuestRewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> MainQuestRewardType1 => mainQuestRewardType1_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardType2 => mainQuestRewardType2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardType3 => mainQuestRewardType3_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MainQuestRewardType4 => mainQuestRewardType4_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MarketCode
	{
		get
		{
			return marketCode_;
		}
		set
		{
			marketCode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NextPackId
	{
		get
		{
			return nextPackId_;
		}
		set
		{
			nextPackId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PackDescNameTextId
	{
		get
		{
			return packDescNameTextId_;
		}
		set
		{
			packDescNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackHide
	{
		get
		{
			return packHide_;
		}
		set
		{
			packHide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PackLoadingPrefabName
	{
		get
		{
			return packLoadingPrefabName_;
		}
		set
		{
			packLoadingPrefabName_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public int PackPeriod
	{
		get
		{
			return packPeriod_;
		}
		set
		{
			packPeriod_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> PackPreviewName => packPreviewName_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> PackPreviewSpriteName => packPreviewSpriteName_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PackSpriteName
	{
		get
		{
			return packSpriteName_;
		}
		set
		{
			packSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackType
	{
		get
		{
			return packType_;
		}
		set
		{
			packType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PackUnopenedResourceName
	{
		get
		{
			return packUnopenedResourceName_;
		}
		set
		{
			packUnopenedResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PriorPackIndex
	{
		get
		{
			return priorPackIndex_;
		}
		set
		{
			priorPackIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PrologImageName
	{
		get
		{
			return prologImageName_;
		}
		set
		{
			prologImageName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PrologLocalTextId
	{
		get
		{
			return prologLocalTextId_;
		}
		set
		{
			prologLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PrologueBGM
	{
		get
		{
			return prologueBGM_;
		}
		set
		{
			prologueBGM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SalePrice
	{
		get
		{
			return salePrice_;
		}
		set
		{
			salePrice_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string StartPositionPath
	{
		get
		{
			return startPositionPath_;
		}
		set
		{
			startPositionPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int UseSchedule
	{
		get
		{
			return useSchedule_;
		}
		set
		{
			useSchedule_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WaypointPriceType
	{
		get
		{
			return waypointPriceType_;
		}
		set
		{
			waypointPriceType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WaypointPriceUnitCount
	{
		get
		{
			return waypointPriceUnitCount_;
		}
		set
		{
			waypointPriceUnitCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackTable(PackTable other)
		: this()
	{
		badge_ = other.badge_;
		bgmName_ = other.bgmName_;
		bgmSoundId_ = other.bgmSoundId_;
		bgmTitleLocalTextId_ = other.bgmTitleLocalTextId_;
		bundleLabel_ = other.bundleLabel_;
		buyDescLocalTextId_ = other.buyDescLocalTextId_;
		buyPrice_ = other.buyPrice_;
		buyRewardCount_ = other.buyRewardCount_.Clone();
		buyRewardId_ = other.buyRewardId_.Clone();
		buyRewardType_ = other.buyRewardType_.Clone();
		buyType_ = other.buyType_;
		caseBackTextureName_ = other.caseBackTextureName_;
		caseBackThumbnailTextureName_ = other.caseBackThumbnailTextureName_;
		caseFrontPrefabName_ = other.caseFrontPrefabName_;
		contentTypeTextId_ = other.contentTypeTextId_;
		dockingOnce_ = other.dockingOnce_;
		epilogImageName_ = other.epilogImageName_;
		epilogLocalTextId_ = other.epilogLocalTextId_;
		epilogueBGM_ = other.epilogueBGM_;
		fieldMapId_ = other.fieldMapId_.Clone();
		fieldMonsterGroupId_ = other.fieldMonsterGroupId_.Clone();
		fieldObjectGroupId_ = other.fieldObjectGroupId_.Clone();
		fieldTrapGroupId_ = other.fieldTrapGroupId_.Clone();
		id_ = other.id_;
		isNewPack_ = other.isNewPack_;
		isSkipPackInsertDirection_ = other.isSkipPackInsertDirection_;
		logType_ = other.logType_;
		mainQuestRewardCount_ = other.mainQuestRewardCount_.Clone();
		mainQuestRewardCount1_ = other.mainQuestRewardCount1_.Clone();
		mainQuestRewardCount2_ = other.mainQuestRewardCount2_.Clone();
		mainQuestRewardCount3_ = other.mainQuestRewardCount3_.Clone();
		mainQuestRewardCount4_ = other.mainQuestRewardCount4_.Clone();
		mainQuestRewardId_ = other.mainQuestRewardId_.Clone();
		mainQuestRewardId1_ = other.mainQuestRewardId1_.Clone();
		mainQuestRewardId2_ = other.mainQuestRewardId2_.Clone();
		mainQuestRewardId3_ = other.mainQuestRewardId3_.Clone();
		mainQuestRewardId4_ = other.mainQuestRewardId4_.Clone();
		mainQuestRewardType_ = other.mainQuestRewardType_.Clone();
		mainQuestRewardType1_ = other.mainQuestRewardType1_.Clone();
		mainQuestRewardType2_ = other.mainQuestRewardType2_.Clone();
		mainQuestRewardType3_ = other.mainQuestRewardType3_.Clone();
		mainQuestRewardType4_ = other.mainQuestRewardType4_.Clone();
		marketCode_ = other.marketCode_;
		nextPackId_ = other.nextPackId_;
		packDescNameTextId_ = other.packDescNameTextId_;
		packHide_ = other.packHide_;
		packLoadingPrefabName_ = other.packLoadingPrefabName_;
		packNameTextId_ = other.packNameTextId_;
		packPeriod_ = other.packPeriod_;
		packPreviewName_ = other.packPreviewName_.Clone();
		packPreviewSpriteName_ = other.packPreviewSpriteName_.Clone();
		packSpriteName_ = other.packSpriteName_;
		packType_ = other.packType_;
		packUnopenedResourceName_ = other.packUnopenedResourceName_;
		priorPackIndex_ = other.priorPackIndex_;
		prologImageName_ = other.prologImageName_;
		prologLocalTextId_ = other.prologLocalTextId_;
		prologueBGM_ = other.prologueBGM_;
		salePrice_ = other.salePrice_;
		startPositionPath_ = other.startPositionPath_;
		useSchedule_ = other.useSchedule_;
		waypointPriceType_ = other.waypointPriceType_;
		waypointPriceUnitCount_ = other.waypointPriceUnitCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackTable Clone()
	{
		return new PackTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Badge == other.Badge && !(BgmName != other.BgmName) && BgmSoundId == other.BgmSoundId && BgmTitleLocalTextId == other.BgmTitleLocalTextId && !(BundleLabel != other.BundleLabel) && BuyDescLocalTextId == other.BuyDescLocalTextId && BuyPrice == other.BuyPrice && buyRewardCount_.Equals(other.buyRewardCount_) && buyRewardId_.Equals(other.buyRewardId_) && buyRewardType_.Equals(other.buyRewardType_) && BuyType == other.BuyType && !(CaseBackTextureName != other.CaseBackTextureName) && !(CaseBackThumbnailTextureName != other.CaseBackThumbnailTextureName) && !(CaseFrontPrefabName != other.CaseFrontPrefabName) && ContentTypeTextId == other.ContentTypeTextId && DockingOnce == other.DockingOnce && !(EpilogImageName != other.EpilogImageName) && EpilogLocalTextId == other.EpilogLocalTextId && !(EpilogueBGM != other.EpilogueBGM) && fieldMapId_.Equals(other.fieldMapId_) && fieldMonsterGroupId_.Equals(other.fieldMonsterGroupId_) && fieldObjectGroupId_.Equals(other.fieldObjectGroupId_) && fieldTrapGroupId_.Equals(other.fieldTrapGroupId_) && Id == other.Id && IsNewPack == other.IsNewPack && IsSkipPackInsertDirection == other.IsSkipPackInsertDirection && LogType == other.LogType && mainQuestRewardCount_.Equals(other.mainQuestRewardCount_) && mainQuestRewardCount1_.Equals(other.mainQuestRewardCount1_) && mainQuestRewardCount2_.Equals(other.mainQuestRewardCount2_) && mainQuestRewardCount3_.Equals(other.mainQuestRewardCount3_) && mainQuestRewardCount4_.Equals(other.mainQuestRewardCount4_) && mainQuestRewardId_.Equals(other.mainQuestRewardId_) && mainQuestRewardId1_.Equals(other.mainQuestRewardId1_) && mainQuestRewardId2_.Equals(other.mainQuestRewardId2_) && mainQuestRewardId3_.Equals(other.mainQuestRewardId3_) && mainQuestRewardId4_.Equals(other.mainQuestRewardId4_) && mainQuestRewardType_.Equals(other.mainQuestRewardType_) && mainQuestRewardType1_.Equals(other.mainQuestRewardType1_) && mainQuestRewardType2_.Equals(other.mainQuestRewardType2_) && mainQuestRewardType3_.Equals(other.mainQuestRewardType3_) && mainQuestRewardType4_.Equals(other.mainQuestRewardType4_) && MarketCode == other.MarketCode && NextPackId == other.NextPackId && PackDescNameTextId == other.PackDescNameTextId && PackHide == other.PackHide && !(PackLoadingPrefabName != other.PackLoadingPrefabName) && PackNameTextId == other.PackNameTextId && PackPeriod == other.PackPeriod && packPreviewName_.Equals(other.packPreviewName_) && packPreviewSpriteName_.Equals(other.packPreviewSpriteName_) && !(PackSpriteName != other.PackSpriteName) && PackType == other.PackType && !(PackUnopenedResourceName != other.PackUnopenedResourceName) && PriorPackIndex == other.PriorPackIndex && !(PrologImageName != other.PrologImageName) && PrologLocalTextId == other.PrologLocalTextId && !(PrologueBGM != other.PrologueBGM) && SalePrice == other.SalePrice && !(StartPositionPath != other.StartPositionPath) && UseSchedule == other.UseSchedule && WaypointPriceType == other.WaypointPriceType && WaypointPriceUnitCount == other.WaypointPriceUnitCount)
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
		if (Badge != 0)
		{
			num ^= Badge.GetHashCode();
		}
		if (BgmName.Length != 0)
		{
			num ^= BgmName.GetHashCode();
		}
		if (BgmSoundId != 0)
		{
			num ^= BgmSoundId.GetHashCode();
		}
		if (BgmTitleLocalTextId != 0)
		{
			num ^= BgmTitleLocalTextId.GetHashCode();
		}
		if (BundleLabel.Length != 0)
		{
			num ^= BundleLabel.GetHashCode();
		}
		if (BuyDescLocalTextId != 0)
		{
			num ^= BuyDescLocalTextId.GetHashCode();
		}
		if (BuyPrice != 0)
		{
			num ^= BuyPrice.GetHashCode();
		}
		num ^= buyRewardCount_.GetHashCode();
		num ^= buyRewardId_.GetHashCode();
		num ^= buyRewardType_.GetHashCode();
		if (BuyType != 0)
		{
			num ^= BuyType.GetHashCode();
		}
		if (CaseBackTextureName.Length != 0)
		{
			num ^= CaseBackTextureName.GetHashCode();
		}
		if (CaseBackThumbnailTextureName.Length != 0)
		{
			num ^= CaseBackThumbnailTextureName.GetHashCode();
		}
		if (CaseFrontPrefabName.Length != 0)
		{
			num ^= CaseFrontPrefabName.GetHashCode();
		}
		if (ContentTypeTextId != 0)
		{
			num ^= ContentTypeTextId.GetHashCode();
		}
		if (DockingOnce != 0)
		{
			num ^= DockingOnce.GetHashCode();
		}
		if (EpilogImageName.Length != 0)
		{
			num ^= EpilogImageName.GetHashCode();
		}
		if (EpilogLocalTextId != 0)
		{
			num ^= EpilogLocalTextId.GetHashCode();
		}
		if (EpilogueBGM.Length != 0)
		{
			num ^= EpilogueBGM.GetHashCode();
		}
		num ^= fieldMapId_.GetHashCode();
		num ^= fieldMonsterGroupId_.GetHashCode();
		num ^= fieldObjectGroupId_.GetHashCode();
		num ^= fieldTrapGroupId_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsNewPack != 0)
		{
			num ^= IsNewPack.GetHashCode();
		}
		if (IsSkipPackInsertDirection != 0)
		{
			num ^= IsSkipPackInsertDirection.GetHashCode();
		}
		if (LogType != 0)
		{
			num ^= LogType.GetHashCode();
		}
		num ^= mainQuestRewardCount_.GetHashCode();
		num ^= mainQuestRewardCount1_.GetHashCode();
		num ^= mainQuestRewardCount2_.GetHashCode();
		num ^= mainQuestRewardCount3_.GetHashCode();
		num ^= mainQuestRewardCount4_.GetHashCode();
		num ^= mainQuestRewardId_.GetHashCode();
		num ^= mainQuestRewardId1_.GetHashCode();
		num ^= mainQuestRewardId2_.GetHashCode();
		num ^= mainQuestRewardId3_.GetHashCode();
		num ^= mainQuestRewardId4_.GetHashCode();
		num ^= mainQuestRewardType_.GetHashCode();
		num ^= mainQuestRewardType1_.GetHashCode();
		num ^= mainQuestRewardType2_.GetHashCode();
		num ^= mainQuestRewardType3_.GetHashCode();
		num ^= mainQuestRewardType4_.GetHashCode();
		if (MarketCode != 0)
		{
			num ^= MarketCode.GetHashCode();
		}
		if (NextPackId != 0)
		{
			num ^= NextPackId.GetHashCode();
		}
		if (PackDescNameTextId != 0)
		{
			num ^= PackDescNameTextId.GetHashCode();
		}
		if (PackHide != 0)
		{
			num ^= PackHide.GetHashCode();
		}
		if (PackLoadingPrefabName.Length != 0)
		{
			num ^= PackLoadingPrefabName.GetHashCode();
		}
		if (PackNameTextId != 0)
		{
			num ^= PackNameTextId.GetHashCode();
		}
		if (PackPeriod != 0)
		{
			num ^= PackPeriod.GetHashCode();
		}
		num ^= packPreviewName_.GetHashCode();
		num ^= packPreviewSpriteName_.GetHashCode();
		if (PackSpriteName.Length != 0)
		{
			num ^= PackSpriteName.GetHashCode();
		}
		if (PackType != 0)
		{
			num ^= PackType.GetHashCode();
		}
		if (PackUnopenedResourceName.Length != 0)
		{
			num ^= PackUnopenedResourceName.GetHashCode();
		}
		if (PriorPackIndex != 0)
		{
			num ^= PriorPackIndex.GetHashCode();
		}
		if (PrologImageName.Length != 0)
		{
			num ^= PrologImageName.GetHashCode();
		}
		if (PrologLocalTextId != 0)
		{
			num ^= PrologLocalTextId.GetHashCode();
		}
		if (PrologueBGM.Length != 0)
		{
			num ^= PrologueBGM.GetHashCode();
		}
		if (SalePrice != 0)
		{
			num ^= SalePrice.GetHashCode();
		}
		if (StartPositionPath.Length != 0)
		{
			num ^= StartPositionPath.GetHashCode();
		}
		if (UseSchedule != 0)
		{
			num ^= UseSchedule.GetHashCode();
		}
		if (WaypointPriceType != 0)
		{
			num ^= WaypointPriceType.GetHashCode();
		}
		if (WaypointPriceUnitCount != 0)
		{
			num ^= WaypointPriceUnitCount.GetHashCode();
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
		if (Badge != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Badge);
		}
		if (BgmName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BgmName);
		}
		if (BgmSoundId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BgmSoundId);
		}
		if (BgmTitleLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BgmTitleLocalTextId);
		}
		if (BundleLabel.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(BundleLabel);
		}
		if (BuyDescLocalTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BuyDescLocalTextId);
		}
		if (BuyPrice != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(BuyPrice);
		}
		buyRewardCount_.WriteTo(ref output, _repeated_buyRewardCount_codec);
		buyRewardId_.WriteTo(ref output, _repeated_buyRewardId_codec);
		buyRewardType_.WriteTo(ref output, _repeated_buyRewardType_codec);
		if (BuyType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(BuyType);
		}
		if (CaseBackTextureName.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(CaseBackTextureName);
		}
		if (CaseBackThumbnailTextureName.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(CaseBackThumbnailTextureName);
		}
		if (CaseFrontPrefabName.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(CaseFrontPrefabName);
		}
		if (ContentTypeTextId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ContentTypeTextId);
		}
		if (DockingOnce != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(DockingOnce);
		}
		if (EpilogImageName.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(EpilogImageName);
		}
		if (EpilogLocalTextId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(EpilogLocalTextId);
		}
		if (EpilogueBGM.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(EpilogueBGM);
		}
		fieldMapId_.WriteTo(ref output, _repeated_fieldMapId_codec);
		fieldMonsterGroupId_.WriteTo(ref output, _repeated_fieldMonsterGroupId_codec);
		fieldObjectGroupId_.WriteTo(ref output, _repeated_fieldObjectGroupId_codec);
		fieldTrapGroupId_.WriteTo(ref output, _repeated_fieldTrapGroupId_codec);
		if (Id != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(Id);
		}
		if (IsNewPack != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(IsNewPack);
		}
		if (IsSkipPackInsertDirection != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(IsSkipPackInsertDirection);
		}
		if (LogType != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(LogType);
		}
		mainQuestRewardCount_.WriteTo(ref output, _repeated_mainQuestRewardCount_codec);
		mainQuestRewardCount1_.WriteTo(ref output, _repeated_mainQuestRewardCount1_codec);
		mainQuestRewardCount2_.WriteTo(ref output, _repeated_mainQuestRewardCount2_codec);
		mainQuestRewardCount3_.WriteTo(ref output, _repeated_mainQuestRewardCount3_codec);
		mainQuestRewardCount4_.WriteTo(ref output, _repeated_mainQuestRewardCount4_codec);
		mainQuestRewardId_.WriteTo(ref output, _repeated_mainQuestRewardId_codec);
		mainQuestRewardId1_.WriteTo(ref output, _repeated_mainQuestRewardId1_codec);
		mainQuestRewardId2_.WriteTo(ref output, _repeated_mainQuestRewardId2_codec);
		mainQuestRewardId3_.WriteTo(ref output, _repeated_mainQuestRewardId3_codec);
		mainQuestRewardId4_.WriteTo(ref output, _repeated_mainQuestRewardId4_codec);
		mainQuestRewardType_.WriteTo(ref output, _repeated_mainQuestRewardType_codec);
		mainQuestRewardType1_.WriteTo(ref output, _repeated_mainQuestRewardType1_codec);
		mainQuestRewardType2_.WriteTo(ref output, _repeated_mainQuestRewardType2_codec);
		mainQuestRewardType3_.WriteTo(ref output, _repeated_mainQuestRewardType3_codec);
		mainQuestRewardType4_.WriteTo(ref output, _repeated_mainQuestRewardType4_codec);
		if (MarketCode != 0)
		{
			output.WriteRawTag(216, 2);
			output.WriteInt32(MarketCode);
		}
		if (NextPackId != 0)
		{
			output.WriteRawTag(224, 2);
			output.WriteInt32(NextPackId);
		}
		if (PackDescNameTextId != 0)
		{
			output.WriteRawTag(232, 2);
			output.WriteInt32(PackDescNameTextId);
		}
		if (PackHide != 0)
		{
			output.WriteRawTag(240, 2);
			output.WriteInt32(PackHide);
		}
		if (PackLoadingPrefabName.Length != 0)
		{
			output.WriteRawTag(250, 2);
			output.WriteString(PackLoadingPrefabName);
		}
		if (PackNameTextId != 0)
		{
			output.WriteRawTag(128, 3);
			output.WriteInt32(PackNameTextId);
		}
		if (PackPeriod != 0)
		{
			output.WriteRawTag(136, 3);
			output.WriteInt32(PackPeriod);
		}
		packPreviewName_.WriteTo(ref output, _repeated_packPreviewName_codec);
		packPreviewSpriteName_.WriteTo(ref output, _repeated_packPreviewSpriteName_codec);
		if (PackSpriteName.Length != 0)
		{
			output.WriteRawTag(162, 3);
			output.WriteString(PackSpriteName);
		}
		if (PackType != 0)
		{
			output.WriteRawTag(168, 3);
			output.WriteInt32(PackType);
		}
		if (PackUnopenedResourceName.Length != 0)
		{
			output.WriteRawTag(178, 3);
			output.WriteString(PackUnopenedResourceName);
		}
		if (PriorPackIndex != 0)
		{
			output.WriteRawTag(184, 3);
			output.WriteInt32(PriorPackIndex);
		}
		if (PrologImageName.Length != 0)
		{
			output.WriteRawTag(194, 3);
			output.WriteString(PrologImageName);
		}
		if (PrologLocalTextId != 0)
		{
			output.WriteRawTag(200, 3);
			output.WriteInt32(PrologLocalTextId);
		}
		if (PrologueBGM.Length != 0)
		{
			output.WriteRawTag(210, 3);
			output.WriteString(PrologueBGM);
		}
		if (SalePrice != 0)
		{
			output.WriteRawTag(216, 3);
			output.WriteInt32(SalePrice);
		}
		if (StartPositionPath.Length != 0)
		{
			output.WriteRawTag(226, 3);
			output.WriteString(StartPositionPath);
		}
		if (UseSchedule != 0)
		{
			output.WriteRawTag(232, 3);
			output.WriteInt32(UseSchedule);
		}
		if (WaypointPriceType != 0)
		{
			output.WriteRawTag(240, 3);
			output.WriteInt32(WaypointPriceType);
		}
		if (WaypointPriceUnitCount != 0)
		{
			output.WriteRawTag(248, 3);
			output.WriteInt32(WaypointPriceUnitCount);
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
		if (Badge != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Badge);
		}
		if (BgmName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BgmName);
		}
		if (BgmSoundId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BgmSoundId);
		}
		if (BgmTitleLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BgmTitleLocalTextId);
		}
		if (BundleLabel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BundleLabel);
		}
		if (BuyDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyDescLocalTextId);
		}
		if (BuyPrice != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyPrice);
		}
		num += buyRewardCount_.CalculateSize(_repeated_buyRewardCount_codec);
		num += buyRewardId_.CalculateSize(_repeated_buyRewardId_codec);
		num += buyRewardType_.CalculateSize(_repeated_buyRewardType_codec);
		if (BuyType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyType);
		}
		if (CaseBackTextureName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CaseBackTextureName);
		}
		if (CaseBackThumbnailTextureName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CaseBackThumbnailTextureName);
		}
		if (CaseFrontPrefabName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CaseFrontPrefabName);
		}
		if (ContentTypeTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentTypeTextId);
		}
		if (DockingOnce != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DockingOnce);
		}
		if (EpilogImageName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(EpilogImageName);
		}
		if (EpilogLocalTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EpilogLocalTextId);
		}
		if (EpilogueBGM.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(EpilogueBGM);
		}
		num += fieldMapId_.CalculateSize(_repeated_fieldMapId_codec);
		num += fieldMonsterGroupId_.CalculateSize(_repeated_fieldMonsterGroupId_codec);
		num += fieldObjectGroupId_.CalculateSize(_repeated_fieldObjectGroupId_codec);
		num += fieldTrapGroupId_.CalculateSize(_repeated_fieldTrapGroupId_codec);
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsNewPack != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IsNewPack);
		}
		if (IsSkipPackInsertDirection != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IsSkipPackInsertDirection);
		}
		if (LogType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LogType);
		}
		num += mainQuestRewardCount_.CalculateSize(_repeated_mainQuestRewardCount_codec);
		num += mainQuestRewardCount1_.CalculateSize(_repeated_mainQuestRewardCount1_codec);
		num += mainQuestRewardCount2_.CalculateSize(_repeated_mainQuestRewardCount2_codec);
		num += mainQuestRewardCount3_.CalculateSize(_repeated_mainQuestRewardCount3_codec);
		num += mainQuestRewardCount4_.CalculateSize(_repeated_mainQuestRewardCount4_codec);
		num += mainQuestRewardId_.CalculateSize(_repeated_mainQuestRewardId_codec);
		num += mainQuestRewardId1_.CalculateSize(_repeated_mainQuestRewardId1_codec);
		num += mainQuestRewardId2_.CalculateSize(_repeated_mainQuestRewardId2_codec);
		num += mainQuestRewardId3_.CalculateSize(_repeated_mainQuestRewardId3_codec);
		num += mainQuestRewardId4_.CalculateSize(_repeated_mainQuestRewardId4_codec);
		num += mainQuestRewardType_.CalculateSize(_repeated_mainQuestRewardType_codec);
		num += mainQuestRewardType1_.CalculateSize(_repeated_mainQuestRewardType1_codec);
		num += mainQuestRewardType2_.CalculateSize(_repeated_mainQuestRewardType2_codec);
		num += mainQuestRewardType3_.CalculateSize(_repeated_mainQuestRewardType3_codec);
		num += mainQuestRewardType4_.CalculateSize(_repeated_mainQuestRewardType4_codec);
		if (MarketCode != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MarketCode);
		}
		if (NextPackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NextPackId);
		}
		if (PackDescNameTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackDescNameTextId);
		}
		if (PackHide != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackHide);
		}
		if (PackLoadingPrefabName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PackLoadingPrefabName);
		}
		if (PackNameTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackNameTextId);
		}
		if (PackPeriod != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackPeriod);
		}
		num += packPreviewName_.CalculateSize(_repeated_packPreviewName_codec);
		num += packPreviewSpriteName_.CalculateSize(_repeated_packPreviewSpriteName_codec);
		if (PackSpriteName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PackSpriteName);
		}
		if (PackType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackType);
		}
		if (PackUnopenedResourceName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PackUnopenedResourceName);
		}
		if (PriorPackIndex != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PriorPackIndex);
		}
		if (PrologImageName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PrologImageName);
		}
		if (PrologLocalTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PrologLocalTextId);
		}
		if (PrologueBGM.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PrologueBGM);
		}
		if (SalePrice != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SalePrice);
		}
		if (StartPositionPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(StartPositionPath);
		}
		if (UseSchedule != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseSchedule);
		}
		if (WaypointPriceType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WaypointPriceType);
		}
		if (WaypointPriceUnitCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WaypointPriceUnitCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PackTable other)
	{
		if (other != null)
		{
			if (other.Badge != 0)
			{
				Badge = other.Badge;
			}
			if (other.BgmName.Length != 0)
			{
				BgmName = other.BgmName;
			}
			if (other.BgmSoundId != 0)
			{
				BgmSoundId = other.BgmSoundId;
			}
			if (other.BgmTitleLocalTextId != 0)
			{
				BgmTitleLocalTextId = other.BgmTitleLocalTextId;
			}
			if (other.BundleLabel.Length != 0)
			{
				BundleLabel = other.BundleLabel;
			}
			if (other.BuyDescLocalTextId != 0)
			{
				BuyDescLocalTextId = other.BuyDescLocalTextId;
			}
			if (other.BuyPrice != 0)
			{
				BuyPrice = other.BuyPrice;
			}
			buyRewardCount_.Add(other.buyRewardCount_);
			buyRewardId_.Add(other.buyRewardId_);
			buyRewardType_.Add(other.buyRewardType_);
			if (other.BuyType != 0)
			{
				BuyType = other.BuyType;
			}
			if (other.CaseBackTextureName.Length != 0)
			{
				CaseBackTextureName = other.CaseBackTextureName;
			}
			if (other.CaseBackThumbnailTextureName.Length != 0)
			{
				CaseBackThumbnailTextureName = other.CaseBackThumbnailTextureName;
			}
			if (other.CaseFrontPrefabName.Length != 0)
			{
				CaseFrontPrefabName = other.CaseFrontPrefabName;
			}
			if (other.ContentTypeTextId != 0)
			{
				ContentTypeTextId = other.ContentTypeTextId;
			}
			if (other.DockingOnce != 0)
			{
				DockingOnce = other.DockingOnce;
			}
			if (other.EpilogImageName.Length != 0)
			{
				EpilogImageName = other.EpilogImageName;
			}
			if (other.EpilogLocalTextId != 0)
			{
				EpilogLocalTextId = other.EpilogLocalTextId;
			}
			if (other.EpilogueBGM.Length != 0)
			{
				EpilogueBGM = other.EpilogueBGM;
			}
			fieldMapId_.Add(other.fieldMapId_);
			fieldMonsterGroupId_.Add(other.fieldMonsterGroupId_);
			fieldObjectGroupId_.Add(other.fieldObjectGroupId_);
			fieldTrapGroupId_.Add(other.fieldTrapGroupId_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsNewPack != 0)
			{
				IsNewPack = other.IsNewPack;
			}
			if (other.IsSkipPackInsertDirection != 0)
			{
				IsSkipPackInsertDirection = other.IsSkipPackInsertDirection;
			}
			if (other.LogType != 0)
			{
				LogType = other.LogType;
			}
			mainQuestRewardCount_.Add(other.mainQuestRewardCount_);
			mainQuestRewardCount1_.Add(other.mainQuestRewardCount1_);
			mainQuestRewardCount2_.Add(other.mainQuestRewardCount2_);
			mainQuestRewardCount3_.Add(other.mainQuestRewardCount3_);
			mainQuestRewardCount4_.Add(other.mainQuestRewardCount4_);
			mainQuestRewardId_.Add(other.mainQuestRewardId_);
			mainQuestRewardId1_.Add(other.mainQuestRewardId1_);
			mainQuestRewardId2_.Add(other.mainQuestRewardId2_);
			mainQuestRewardId3_.Add(other.mainQuestRewardId3_);
			mainQuestRewardId4_.Add(other.mainQuestRewardId4_);
			mainQuestRewardType_.Add(other.mainQuestRewardType_);
			mainQuestRewardType1_.Add(other.mainQuestRewardType1_);
			mainQuestRewardType2_.Add(other.mainQuestRewardType2_);
			mainQuestRewardType3_.Add(other.mainQuestRewardType3_);
			mainQuestRewardType4_.Add(other.mainQuestRewardType4_);
			if (other.MarketCode != 0)
			{
				MarketCode = other.MarketCode;
			}
			if (other.NextPackId != 0)
			{
				NextPackId = other.NextPackId;
			}
			if (other.PackDescNameTextId != 0)
			{
				PackDescNameTextId = other.PackDescNameTextId;
			}
			if (other.PackHide != 0)
			{
				PackHide = other.PackHide;
			}
			if (other.PackLoadingPrefabName.Length != 0)
			{
				PackLoadingPrefabName = other.PackLoadingPrefabName;
			}
			if (other.PackNameTextId != 0)
			{
				PackNameTextId = other.PackNameTextId;
			}
			if (other.PackPeriod != 0)
			{
				PackPeriod = other.PackPeriod;
			}
			packPreviewName_.Add(other.packPreviewName_);
			packPreviewSpriteName_.Add(other.packPreviewSpriteName_);
			if (other.PackSpriteName.Length != 0)
			{
				PackSpriteName = other.PackSpriteName;
			}
			if (other.PackType != 0)
			{
				PackType = other.PackType;
			}
			if (other.PackUnopenedResourceName.Length != 0)
			{
				PackUnopenedResourceName = other.PackUnopenedResourceName;
			}
			if (other.PriorPackIndex != 0)
			{
				PriorPackIndex = other.PriorPackIndex;
			}
			if (other.PrologImageName.Length != 0)
			{
				PrologImageName = other.PrologImageName;
			}
			if (other.PrologLocalTextId != 0)
			{
				PrologLocalTextId = other.PrologLocalTextId;
			}
			if (other.PrologueBGM.Length != 0)
			{
				PrologueBGM = other.PrologueBGM;
			}
			if (other.SalePrice != 0)
			{
				SalePrice = other.SalePrice;
			}
			if (other.StartPositionPath.Length != 0)
			{
				StartPositionPath = other.StartPositionPath;
			}
			if (other.UseSchedule != 0)
			{
				UseSchedule = other.UseSchedule;
			}
			if (other.WaypointPriceType != 0)
			{
				WaypointPriceType = other.WaypointPriceType;
			}
			if (other.WaypointPriceUnitCount != 0)
			{
				WaypointPriceUnitCount = other.WaypointPriceUnitCount;
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
			case 288u:
			case 290u:
				mainQuestRewardId3_.AddEntriesFrom(ref input, _repeated_mainQuestRewardId3_codec);
				break;
			case 280u:
			case 282u:
				mainQuestRewardId2_.AddEntriesFrom(ref input, _repeated_mainQuestRewardId2_codec);
				break;
			case 256u:
			case 258u:
				mainQuestRewardCount4_.AddEntriesFrom(ref input, _repeated_mainQuestRewardCount4_codec);
				break;
			case 264u:
			case 266u:
				mainQuestRewardId_.AddEntriesFrom(ref input, _repeated_mainQuestRewardId_codec);
				break;
			case 272u:
			case 274u:
				mainQuestRewardId1_.AddEntriesFrom(ref input, _repeated_mainQuestRewardId1_codec);
				break;
			case 296u:
			case 298u:
				mainQuestRewardId4_.AddEntriesFrom(ref input, _repeated_mainQuestRewardId4_codec);
				break;
			case 304u:
			case 306u:
				mainQuestRewardType_.AddEntriesFrom(ref input, _repeated_mainQuestRewardType_codec);
				break;
			case 320u:
			case 322u:
				mainQuestRewardType2_.AddEntriesFrom(ref input, _repeated_mainQuestRewardType2_codec);
				break;
			case 328u:
			case 330u:
				mainQuestRewardType3_.AddEntriesFrom(ref input, _repeated_mainQuestRewardType3_codec);
				break;
			case 312u:
			case 314u:
				mainQuestRewardType1_.AddEntriesFrom(ref input, _repeated_mainQuestRewardType1_codec);
				break;
			case 344u:
				MarketCode = input.ReadInt32();
				break;
			case 352u:
				NextPackId = input.ReadInt32();
				break;
			case 360u:
				PackDescNameTextId = input.ReadInt32();
				break;
			case 368u:
				PackHide = input.ReadInt32();
				break;
			case 378u:
				PackLoadingPrefabName = input.ReadString();
				break;
			case 384u:
				PackNameTextId = input.ReadInt32();
				break;
			case 392u:
				PackPeriod = input.ReadInt32();
				break;
			case 402u:
				packPreviewName_.AddEntriesFrom(ref input, _repeated_packPreviewName_codec);
				break;
			case 410u:
				packPreviewSpriteName_.AddEntriesFrom(ref input, _repeated_packPreviewSpriteName_codec);
				break;
			case 418u:
				PackSpriteName = input.ReadString();
				break;
			case 424u:
				PackType = input.ReadInt32();
				break;
			case 434u:
				PackUnopenedResourceName = input.ReadString();
				break;
			case 440u:
				PriorPackIndex = input.ReadInt32();
				break;
			case 450u:
				PrologImageName = input.ReadString();
				break;
			case 456u:
				PrologLocalTextId = input.ReadInt32();
				break;
			case 466u:
				PrologueBGM = input.ReadString();
				break;
			case 472u:
				SalePrice = input.ReadInt32();
				break;
			case 482u:
				StartPositionPath = input.ReadString();
				break;
			case 488u:
				UseSchedule = input.ReadInt32();
				break;
			case 496u:
				WaypointPriceType = input.ReadInt32();
				break;
			case 504u:
				WaypointPriceUnitCount = input.ReadInt32();
				break;
			case 336u:
			case 338u:
				mainQuestRewardType4_.AddEntriesFrom(ref input, _repeated_mainQuestRewardType4_codec);
				break;
			case 8u:
				Badge = input.ReadInt32();
				break;
			case 18u:
				BgmName = input.ReadString();
				break;
			case 24u:
				BgmSoundId = input.ReadInt32();
				break;
			case 32u:
				BgmTitleLocalTextId = input.ReadInt32();
				break;
			case 42u:
				BundleLabel = input.ReadString();
				break;
			case 48u:
				BuyDescLocalTextId = input.ReadInt32();
				break;
			case 56u:
				BuyPrice = input.ReadInt32();
				break;
			case 64u:
			case 66u:
				buyRewardCount_.AddEntriesFrom(ref input, _repeated_buyRewardCount_codec);
				break;
			case 88u:
				BuyType = input.ReadInt32();
				break;
			case 98u:
				CaseBackTextureName = input.ReadString();
				break;
			case 80u:
			case 82u:
				buyRewardType_.AddEntriesFrom(ref input, _repeated_buyRewardType_codec);
				break;
			case 106u:
				CaseBackThumbnailTextureName = input.ReadString();
				break;
			case 114u:
				CaseFrontPrefabName = input.ReadString();
				break;
			case 120u:
				ContentTypeTextId = input.ReadInt32();
				break;
			case 128u:
				DockingOnce = input.ReadInt32();
				break;
			case 138u:
				EpilogImageName = input.ReadString();
				break;
			case 144u:
				EpilogLocalTextId = input.ReadInt32();
				break;
			case 72u:
			case 74u:
				buyRewardId_.AddEntriesFrom(ref input, _repeated_buyRewardId_codec);
				break;
			case 154u:
				EpilogueBGM = input.ReadString();
				break;
			case 168u:
			case 170u:
				fieldMonsterGroupId_.AddEntriesFrom(ref input, _repeated_fieldMonsterGroupId_codec);
				break;
			case 160u:
			case 162u:
				fieldMapId_.AddEntriesFrom(ref input, _repeated_fieldMapId_codec);
				break;
			case 176u:
			case 178u:
				fieldObjectGroupId_.AddEntriesFrom(ref input, _repeated_fieldObjectGroupId_codec);
				break;
			case 184u:
			case 186u:
				fieldTrapGroupId_.AddEntriesFrom(ref input, _repeated_fieldTrapGroupId_codec);
				break;
			case 192u:
				Id = input.ReadInt32();
				break;
			case 232u:
			case 234u:
				mainQuestRewardCount1_.AddEntriesFrom(ref input, _repeated_mainQuestRewardCount1_codec);
				break;
			case 248u:
			case 250u:
				mainQuestRewardCount3_.AddEntriesFrom(ref input, _repeated_mainQuestRewardCount3_codec);
				break;
			case 240u:
			case 242u:
				mainQuestRewardCount2_.AddEntriesFrom(ref input, _repeated_mainQuestRewardCount2_codec);
				break;
			case 200u:
				IsNewPack = input.ReadInt32();
				break;
			case 208u:
				IsSkipPackInsertDirection = input.ReadInt32();
				break;
			case 216u:
				LogType = input.ReadInt32();
				break;
			case 224u:
			case 226u:
				mainQuestRewardCount_.AddEntriesFrom(ref input, _repeated_mainQuestRewardCount_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
