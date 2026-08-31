using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C82 RID: 31874
	public sealed class FishingDefaultTable : IMessage<FishingDefaultTable>, IMessage, IEquatable<FishingDefaultTable>, IDeepCloneable<FishingDefaultTable>, IBufferMessage
	{
		// Token: 0x170111B0 RID: 70064
		// (get) Token: 0x06046B5F RID: 289631 RVA: 0x01131DDE File Offset: 0x0112FFDE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingDefaultTable> Parser
		{
			get
			{
				return FishingDefaultTable._parser;
			}
		}

		// Token: 0x170111B1 RID: 70065
		// (get) Token: 0x06046B60 RID: 289632 RVA: 0x01131DE5 File Offset: 0x0112FFE5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingDefaultTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170111B2 RID: 70066
		// (get) Token: 0x06046B61 RID: 289633 RVA: 0x01131DF7 File Offset: 0x0112FFF7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingDefaultTable.Descriptor;
			}
		}

		// Token: 0x06046B62 RID: 289634 RVA: 0x01131E00 File Offset: 0x01130000
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingDefaultTable()
		{
		}

		// Token: 0x06046B63 RID: 289635 RVA: 0x01131E98 File Offset: 0x01130098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingDefaultTable(FishingDefaultTable other)
			: this()
		{
			this.actionPointCount_ = other.actionPointCount_;
			this.aquariumBgmPath_ = other.aquariumBgmPath_;
			this.aquariumMapGroupId_ = other.aquariumMapGroupId_;
			this.aquariumTrackingSound_ = other.aquariumTrackingSound_;
			this.autoBiteTime_ = other.autoBiteTime_;
			this.autoFishingButtonOff_ = other.autoFishingButtonOff_;
			this.autoFishingButtonOn_ = other.autoFishingButtonOn_;
			this.autoFishingOpenCondition_ = other.autoFishingOpenCondition_;
			this.autoGradePoolId_ = other.autoGradePoolId_;
			this.autoStartCount_ = other.autoStartCount_;
			this.criticalMultiplier_ = other.criticalMultiplier_;
			this.defaultItemCount_ = other.defaultItemCount_.Clone();
			this.defaultItemId_ = other.defaultItemId_.Clone();
			this.defaultItemType_ = other.defaultItemType_.Clone();
			this.defaultMapId_ = other.defaultMapId_;
			this.finishAlert_ = other.finishAlert_;
			this.fishTrapFishPoolId_ = other.fishTrapFishPoolId_;
			this.fishTrapGradePoolId_ = other.fishTrapGradePoolId_;
			this.fishTrapMaxTime_ = other.fishTrapMaxTime_;
			this.fishTrapOpenCondition_ = other.fishTrapOpenCondition_;
			this.fishTrapOpenContentTicket_ = other.fishTrapOpenContentTicket_;
			this.fishingBaseTime_ = other.fishingBaseTime_;
			this.gaugeCharge_ = other.gaugeCharge_;
			this.guideEventMissionGroupId_ = other.guideEventMissionGroupId_;
			this.id_ = other.id_;
			this.loadingLimit_ = other.loadingLimit_;
			this.lobbyAmbienceName_ = other.lobbyAmbienceName_;
			this.lobbySceneBgm_ = other.lobbySceneBgm_;
			this.lobbySceneName_ = other.lobbySceneName_;
			this.maxBaitTime_ = other.maxBaitTime_;
			this.maxBigLuck_ = other.maxBigLuck_;
			this.maxCharLevel_ = other.maxCharLevel_;
			this.maxRareLuck_ = other.maxRareLuck_;
			this.minBaitTime_ = other.minBaitTime_;
			this.multiOpenCondition_ = other.multiOpenCondition_;
			this.multiSearchTime_ = other.multiSearchTime_;
			this.openMapUiObjectId_ = other.openMapUiObjectId_;
			this.questNameTextId_ = other.questNameTextId_;
			this.questSkipTextId_ = other.questSkipTextId_;
			this.questTitleQuestTextId_ = other.questTitleQuestTextId_;
			this.reconnectTimeout_ = other.reconnectTimeout_;
			this.roomDuration_ = other.roomDuration_;
			this.roomListCount_ = other.roomListCount_;
			this.roomRerollInterval_ = other.roomRerollInterval_;
			this.skillHitzoneSize_ = other.skillHitzoneSize_;
			this.skinOpenCondition_ = other.skinOpenCondition_;
			this.staminaDevider_ = other.staminaDevider_;
			this.startTimelineName_ = other.startTimelineName_;
			this.startVisualNovelDialogId_ = other.startVisualNovelDialogId_;
			this.weekEventMissionGroupId_ = other.weekEventMissionGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046B64 RID: 289636 RVA: 0x01132123 File Offset: 0x01130323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingDefaultTable Clone()
		{
			return new FishingDefaultTable(this);
		}

		// Token: 0x170111B3 RID: 70067
		// (get) Token: 0x06046B65 RID: 289637 RVA: 0x0113212B File Offset: 0x0113032B
		// (set) Token: 0x06046B66 RID: 289638 RVA: 0x01132133 File Offset: 0x01130333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionPointCount
		{
			get
			{
				return this.actionPointCount_;
			}
			set
			{
				this.actionPointCount_ = value;
			}
		}

		// Token: 0x170111B4 RID: 70068
		// (get) Token: 0x06046B67 RID: 289639 RVA: 0x0113213C File Offset: 0x0113033C
		// (set) Token: 0x06046B68 RID: 289640 RVA: 0x01132144 File Offset: 0x01130344
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AquariumBgmPath
		{
			get
			{
				return this.aquariumBgmPath_;
			}
			set
			{
				this.aquariumBgmPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111B5 RID: 70069
		// (get) Token: 0x06046B69 RID: 289641 RVA: 0x01132157 File Offset: 0x01130357
		// (set) Token: 0x06046B6A RID: 289642 RVA: 0x0113215F File Offset: 0x0113035F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AquariumMapGroupId
		{
			get
			{
				return this.aquariumMapGroupId_;
			}
			set
			{
				this.aquariumMapGroupId_ = value;
			}
		}

		// Token: 0x170111B6 RID: 70070
		// (get) Token: 0x06046B6B RID: 289643 RVA: 0x01132168 File Offset: 0x01130368
		// (set) Token: 0x06046B6C RID: 289644 RVA: 0x01132170 File Offset: 0x01130370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AquariumTrackingSound
		{
			get
			{
				return this.aquariumTrackingSound_;
			}
			set
			{
				this.aquariumTrackingSound_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111B7 RID: 70071
		// (get) Token: 0x06046B6D RID: 289645 RVA: 0x01132183 File Offset: 0x01130383
		// (set) Token: 0x06046B6E RID: 289646 RVA: 0x0113218B File Offset: 0x0113038B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double AutoBiteTime
		{
			get
			{
				return this.autoBiteTime_;
			}
			set
			{
				this.autoBiteTime_ = value;
			}
		}

		// Token: 0x170111B8 RID: 70072
		// (get) Token: 0x06046B6F RID: 289647 RVA: 0x01132194 File Offset: 0x01130394
		// (set) Token: 0x06046B70 RID: 289648 RVA: 0x0113219C File Offset: 0x0113039C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AutoFishingButtonOff
		{
			get
			{
				return this.autoFishingButtonOff_;
			}
			set
			{
				this.autoFishingButtonOff_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111B9 RID: 70073
		// (get) Token: 0x06046B71 RID: 289649 RVA: 0x011321AF File Offset: 0x011303AF
		// (set) Token: 0x06046B72 RID: 289650 RVA: 0x011321B7 File Offset: 0x011303B7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AutoFishingButtonOn
		{
			get
			{
				return this.autoFishingButtonOn_;
			}
			set
			{
				this.autoFishingButtonOn_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111BA RID: 70074
		// (get) Token: 0x06046B73 RID: 289651 RVA: 0x011321CA File Offset: 0x011303CA
		// (set) Token: 0x06046B74 RID: 289652 RVA: 0x011321D2 File Offset: 0x011303D2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AutoFishingOpenCondition
		{
			get
			{
				return this.autoFishingOpenCondition_;
			}
			set
			{
				this.autoFishingOpenCondition_ = value;
			}
		}

		// Token: 0x170111BB RID: 70075
		// (get) Token: 0x06046B75 RID: 289653 RVA: 0x011321DB File Offset: 0x011303DB
		// (set) Token: 0x06046B76 RID: 289654 RVA: 0x011321E3 File Offset: 0x011303E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AutoGradePoolId
		{
			get
			{
				return this.autoGradePoolId_;
			}
			set
			{
				this.autoGradePoolId_ = value;
			}
		}

		// Token: 0x170111BC RID: 70076
		// (get) Token: 0x06046B77 RID: 289655 RVA: 0x011321EC File Offset: 0x011303EC
		// (set) Token: 0x06046B78 RID: 289656 RVA: 0x011321F4 File Offset: 0x011303F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double AutoStartCount
		{
			get
			{
				return this.autoStartCount_;
			}
			set
			{
				this.autoStartCount_ = value;
			}
		}

		// Token: 0x170111BD RID: 70077
		// (get) Token: 0x06046B79 RID: 289657 RVA: 0x011321FD File Offset: 0x011303FD
		// (set) Token: 0x06046B7A RID: 289658 RVA: 0x01132205 File Offset: 0x01130405
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double CriticalMultiplier
		{
			get
			{
				return this.criticalMultiplier_;
			}
			set
			{
				this.criticalMultiplier_ = value;
			}
		}

		// Token: 0x170111BE RID: 70078
		// (get) Token: 0x06046B7B RID: 289659 RVA: 0x0113220E File Offset: 0x0113040E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DefaultItemCount
		{
			get
			{
				return this.defaultItemCount_;
			}
		}

		// Token: 0x170111BF RID: 70079
		// (get) Token: 0x06046B7C RID: 289660 RVA: 0x01132216 File Offset: 0x01130416
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> DefaultItemId
		{
			get
			{
				return this.defaultItemId_;
			}
		}

		// Token: 0x170111C0 RID: 70080
		// (get) Token: 0x06046B7D RID: 289661 RVA: 0x0113221E File Offset: 0x0113041E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> DefaultItemType
		{
			get
			{
				return this.defaultItemType_;
			}
		}

		// Token: 0x170111C1 RID: 70081
		// (get) Token: 0x06046B7E RID: 289662 RVA: 0x01132226 File Offset: 0x01130426
		// (set) Token: 0x06046B7F RID: 289663 RVA: 0x0113222E File Offset: 0x0113042E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DefaultMapId
		{
			get
			{
				return this.defaultMapId_;
			}
			set
			{
				this.defaultMapId_ = value;
			}
		}

		// Token: 0x170111C2 RID: 70082
		// (get) Token: 0x06046B80 RID: 289664 RVA: 0x01132237 File Offset: 0x01130437
		// (set) Token: 0x06046B81 RID: 289665 RVA: 0x0113223F File Offset: 0x0113043F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double FinishAlert
		{
			get
			{
				return this.finishAlert_;
			}
			set
			{
				this.finishAlert_ = value;
			}
		}

		// Token: 0x170111C3 RID: 70083
		// (get) Token: 0x06046B82 RID: 289666 RVA: 0x01132248 File Offset: 0x01130448
		// (set) Token: 0x06046B83 RID: 289667 RVA: 0x01132250 File Offset: 0x01130450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishTrapFishPoolId
		{
			get
			{
				return this.fishTrapFishPoolId_;
			}
			set
			{
				this.fishTrapFishPoolId_ = value;
			}
		}

		// Token: 0x170111C4 RID: 70084
		// (get) Token: 0x06046B84 RID: 289668 RVA: 0x01132259 File Offset: 0x01130459
		// (set) Token: 0x06046B85 RID: 289669 RVA: 0x01132261 File Offset: 0x01130461
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FishTrapGradePoolId
		{
			get
			{
				return this.fishTrapGradePoolId_;
			}
			set
			{
				this.fishTrapGradePoolId_ = value;
			}
		}

		// Token: 0x170111C5 RID: 70085
		// (get) Token: 0x06046B86 RID: 289670 RVA: 0x0113226A File Offset: 0x0113046A
		// (set) Token: 0x06046B87 RID: 289671 RVA: 0x01132272 File Offset: 0x01130472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishTrapMaxTime
		{
			get
			{
				return this.fishTrapMaxTime_;
			}
			set
			{
				this.fishTrapMaxTime_ = value;
			}
		}

		// Token: 0x170111C6 RID: 70086
		// (get) Token: 0x06046B88 RID: 289672 RVA: 0x0113227B File Offset: 0x0113047B
		// (set) Token: 0x06046B89 RID: 289673 RVA: 0x01132283 File Offset: 0x01130483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishTrapOpenCondition
		{
			get
			{
				return this.fishTrapOpenCondition_;
			}
			set
			{
				this.fishTrapOpenCondition_ = value;
			}
		}

		// Token: 0x170111C7 RID: 70087
		// (get) Token: 0x06046B8A RID: 289674 RVA: 0x0113228C File Offset: 0x0113048C
		// (set) Token: 0x06046B8B RID: 289675 RVA: 0x01132294 File Offset: 0x01130494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishTrapOpenContentTicket
		{
			get
			{
				return this.fishTrapOpenContentTicket_;
			}
			set
			{
				this.fishTrapOpenContentTicket_ = value;
			}
		}

		// Token: 0x170111C8 RID: 70088
		// (get) Token: 0x06046B8C RID: 289676 RVA: 0x0113229D File Offset: 0x0113049D
		// (set) Token: 0x06046B8D RID: 289677 RVA: 0x011322A5 File Offset: 0x011304A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double FishingBaseTime
		{
			get
			{
				return this.fishingBaseTime_;
			}
			set
			{
				this.fishingBaseTime_ = value;
			}
		}

		// Token: 0x170111C9 RID: 70089
		// (get) Token: 0x06046B8E RID: 289678 RVA: 0x011322AE File Offset: 0x011304AE
		// (set) Token: 0x06046B8F RID: 289679 RVA: 0x011322B6 File Offset: 0x011304B6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string GaugeCharge
		{
			get
			{
				return this.gaugeCharge_;
			}
			set
			{
				this.gaugeCharge_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111CA RID: 70090
		// (get) Token: 0x06046B90 RID: 289680 RVA: 0x011322C9 File Offset: 0x011304C9
		// (set) Token: 0x06046B91 RID: 289681 RVA: 0x011322D1 File Offset: 0x011304D1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GuideEventMissionGroupId
		{
			get
			{
				return this.guideEventMissionGroupId_;
			}
			set
			{
				this.guideEventMissionGroupId_ = value;
			}
		}

		// Token: 0x170111CB RID: 70091
		// (get) Token: 0x06046B92 RID: 289682 RVA: 0x011322DA File Offset: 0x011304DA
		// (set) Token: 0x06046B93 RID: 289683 RVA: 0x011322E2 File Offset: 0x011304E2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170111CC RID: 70092
		// (get) Token: 0x06046B94 RID: 289684 RVA: 0x011322EB File Offset: 0x011304EB
		// (set) Token: 0x06046B95 RID: 289685 RVA: 0x011322F3 File Offset: 0x011304F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadingLimit
		{
			get
			{
				return this.loadingLimit_;
			}
			set
			{
				this.loadingLimit_ = value;
			}
		}

		// Token: 0x170111CD RID: 70093
		// (get) Token: 0x06046B96 RID: 289686 RVA: 0x011322FC File Offset: 0x011304FC
		// (set) Token: 0x06046B97 RID: 289687 RVA: 0x01132304 File Offset: 0x01130504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LobbyAmbienceName
		{
			get
			{
				return this.lobbyAmbienceName_;
			}
			set
			{
				this.lobbyAmbienceName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111CE RID: 70094
		// (get) Token: 0x06046B98 RID: 289688 RVA: 0x01132317 File Offset: 0x01130517
		// (set) Token: 0x06046B99 RID: 289689 RVA: 0x0113231F File Offset: 0x0113051F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LobbySceneBgm
		{
			get
			{
				return this.lobbySceneBgm_;
			}
			set
			{
				this.lobbySceneBgm_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111CF RID: 70095
		// (get) Token: 0x06046B9A RID: 289690 RVA: 0x01132332 File Offset: 0x01130532
		// (set) Token: 0x06046B9B RID: 289691 RVA: 0x0113233A File Offset: 0x0113053A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LobbySceneName
		{
			get
			{
				return this.lobbySceneName_;
			}
			set
			{
				this.lobbySceneName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111D0 RID: 70096
		// (get) Token: 0x06046B9C RID: 289692 RVA: 0x0113234D File Offset: 0x0113054D
		// (set) Token: 0x06046B9D RID: 289693 RVA: 0x01132355 File Offset: 0x01130555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double MaxBaitTime
		{
			get
			{
				return this.maxBaitTime_;
			}
			set
			{
				this.maxBaitTime_ = value;
			}
		}

		// Token: 0x170111D1 RID: 70097
		// (get) Token: 0x06046B9E RID: 289694 RVA: 0x0113235E File Offset: 0x0113055E
		// (set) Token: 0x06046B9F RID: 289695 RVA: 0x01132366 File Offset: 0x01130566
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double MaxBigLuck
		{
			get
			{
				return this.maxBigLuck_;
			}
			set
			{
				this.maxBigLuck_ = value;
			}
		}

		// Token: 0x170111D2 RID: 70098
		// (get) Token: 0x06046BA0 RID: 289696 RVA: 0x0113236F File Offset: 0x0113056F
		// (set) Token: 0x06046BA1 RID: 289697 RVA: 0x01132377 File Offset: 0x01130577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxCharLevel
		{
			get
			{
				return this.maxCharLevel_;
			}
			set
			{
				this.maxCharLevel_ = value;
			}
		}

		// Token: 0x170111D3 RID: 70099
		// (get) Token: 0x06046BA2 RID: 289698 RVA: 0x01132380 File Offset: 0x01130580
		// (set) Token: 0x06046BA3 RID: 289699 RVA: 0x01132388 File Offset: 0x01130588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxRareLuck
		{
			get
			{
				return this.maxRareLuck_;
			}
			set
			{
				this.maxRareLuck_ = value;
			}
		}

		// Token: 0x170111D4 RID: 70100
		// (get) Token: 0x06046BA4 RID: 289700 RVA: 0x01132391 File Offset: 0x01130591
		// (set) Token: 0x06046BA5 RID: 289701 RVA: 0x01132399 File Offset: 0x01130599
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double MinBaitTime
		{
			get
			{
				return this.minBaitTime_;
			}
			set
			{
				this.minBaitTime_ = value;
			}
		}

		// Token: 0x170111D5 RID: 70101
		// (get) Token: 0x06046BA6 RID: 289702 RVA: 0x011323A2 File Offset: 0x011305A2
		// (set) Token: 0x06046BA7 RID: 289703 RVA: 0x011323AA File Offset: 0x011305AA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MultiOpenCondition
		{
			get
			{
				return this.multiOpenCondition_;
			}
			set
			{
				this.multiOpenCondition_ = value;
			}
		}

		// Token: 0x170111D6 RID: 70102
		// (get) Token: 0x06046BA8 RID: 289704 RVA: 0x011323B3 File Offset: 0x011305B3
		// (set) Token: 0x06046BA9 RID: 289705 RVA: 0x011323BB File Offset: 0x011305BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MultiSearchTime
		{
			get
			{
				return this.multiSearchTime_;
			}
			set
			{
				this.multiSearchTime_ = value;
			}
		}

		// Token: 0x170111D7 RID: 70103
		// (get) Token: 0x06046BAA RID: 289706 RVA: 0x011323C4 File Offset: 0x011305C4
		// (set) Token: 0x06046BAB RID: 289707 RVA: 0x011323CC File Offset: 0x011305CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int OpenMapUiObjectId
		{
			get
			{
				return this.openMapUiObjectId_;
			}
			set
			{
				this.openMapUiObjectId_ = value;
			}
		}

		// Token: 0x170111D8 RID: 70104
		// (get) Token: 0x06046BAC RID: 289708 RVA: 0x011323D5 File Offset: 0x011305D5
		// (set) Token: 0x06046BAD RID: 289709 RVA: 0x011323DD File Offset: 0x011305DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestNameTextId
		{
			get
			{
				return this.questNameTextId_;
			}
			set
			{
				this.questNameTextId_ = value;
			}
		}

		// Token: 0x170111D9 RID: 70105
		// (get) Token: 0x06046BAE RID: 289710 RVA: 0x011323E6 File Offset: 0x011305E6
		// (set) Token: 0x06046BAF RID: 289711 RVA: 0x011323EE File Offset: 0x011305EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestSkipTextId
		{
			get
			{
				return this.questSkipTextId_;
			}
			set
			{
				this.questSkipTextId_ = value;
			}
		}

		// Token: 0x170111DA RID: 70106
		// (get) Token: 0x06046BB0 RID: 289712 RVA: 0x011323F7 File Offset: 0x011305F7
		// (set) Token: 0x06046BB1 RID: 289713 RVA: 0x011323FF File Offset: 0x011305FF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int QuestTitleQuestTextId
		{
			get
			{
				return this.questTitleQuestTextId_;
			}
			set
			{
				this.questTitleQuestTextId_ = value;
			}
		}

		// Token: 0x170111DB RID: 70107
		// (get) Token: 0x06046BB2 RID: 289714 RVA: 0x01132408 File Offset: 0x01130608
		// (set) Token: 0x06046BB3 RID: 289715 RVA: 0x01132410 File Offset: 0x01130610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double ReconnectTimeout
		{
			get
			{
				return this.reconnectTimeout_;
			}
			set
			{
				this.reconnectTimeout_ = value;
			}
		}

		// Token: 0x170111DC RID: 70108
		// (get) Token: 0x06046BB4 RID: 289716 RVA: 0x01132419 File Offset: 0x01130619
		// (set) Token: 0x06046BB5 RID: 289717 RVA: 0x01132421 File Offset: 0x01130621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double RoomDuration
		{
			get
			{
				return this.roomDuration_;
			}
			set
			{
				this.roomDuration_ = value;
			}
		}

		// Token: 0x170111DD RID: 70109
		// (get) Token: 0x06046BB6 RID: 289718 RVA: 0x0113242A File Offset: 0x0113062A
		// (set) Token: 0x06046BB7 RID: 289719 RVA: 0x01132432 File Offset: 0x01130632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomListCount
		{
			get
			{
				return this.roomListCount_;
			}
			set
			{
				this.roomListCount_ = value;
			}
		}

		// Token: 0x170111DE RID: 70110
		// (get) Token: 0x06046BB8 RID: 289720 RVA: 0x0113243B File Offset: 0x0113063B
		// (set) Token: 0x06046BB9 RID: 289721 RVA: 0x01132443 File Offset: 0x01130643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double RoomRerollInterval
		{
			get
			{
				return this.roomRerollInterval_;
			}
			set
			{
				this.roomRerollInterval_ = value;
			}
		}

		// Token: 0x170111DF RID: 70111
		// (get) Token: 0x06046BBA RID: 289722 RVA: 0x0113244C File Offset: 0x0113064C
		// (set) Token: 0x06046BBB RID: 289723 RVA: 0x01132454 File Offset: 0x01130654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillHitzoneSize
		{
			get
			{
				return this.skillHitzoneSize_;
			}
			set
			{
				this.skillHitzoneSize_ = value;
			}
		}

		// Token: 0x170111E0 RID: 70112
		// (get) Token: 0x06046BBC RID: 289724 RVA: 0x0113245D File Offset: 0x0113065D
		// (set) Token: 0x06046BBD RID: 289725 RVA: 0x01132465 File Offset: 0x01130665
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SkinOpenCondition
		{
			get
			{
				return this.skinOpenCondition_;
			}
			set
			{
				this.skinOpenCondition_ = value;
			}
		}

		// Token: 0x170111E1 RID: 70113
		// (get) Token: 0x06046BBE RID: 289726 RVA: 0x0113246E File Offset: 0x0113066E
		// (set) Token: 0x06046BBF RID: 289727 RVA: 0x01132476 File Offset: 0x01130676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StaminaDevider
		{
			get
			{
				return this.staminaDevider_;
			}
			set
			{
				this.staminaDevider_ = value;
			}
		}

		// Token: 0x170111E2 RID: 70114
		// (get) Token: 0x06046BC0 RID: 289728 RVA: 0x0113247F File Offset: 0x0113067F
		// (set) Token: 0x06046BC1 RID: 289729 RVA: 0x01132487 File Offset: 0x01130687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StartTimelineName
		{
			get
			{
				return this.startTimelineName_;
			}
			set
			{
				this.startTimelineName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170111E3 RID: 70115
		// (get) Token: 0x06046BC2 RID: 289730 RVA: 0x0113249A File Offset: 0x0113069A
		// (set) Token: 0x06046BC3 RID: 289731 RVA: 0x011324A2 File Offset: 0x011306A2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int StartVisualNovelDialogId
		{
			get
			{
				return this.startVisualNovelDialogId_;
			}
			set
			{
				this.startVisualNovelDialogId_ = value;
			}
		}

		// Token: 0x170111E4 RID: 70116
		// (get) Token: 0x06046BC4 RID: 289732 RVA: 0x011324AB File Offset: 0x011306AB
		// (set) Token: 0x06046BC5 RID: 289733 RVA: 0x011324B3 File Offset: 0x011306B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekEventMissionGroupId
		{
			get
			{
				return this.weekEventMissionGroupId_;
			}
			set
			{
				this.weekEventMissionGroupId_ = value;
			}
		}

		// Token: 0x06046BC6 RID: 289734 RVA: 0x011324BC File Offset: 0x011306BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingDefaultTable);
		}

		// Token: 0x06046BC7 RID: 289735 RVA: 0x011324CC File Offset: 0x011306CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingDefaultTable other)
		{
			return other != null && (other == this || (this.ActionPointCount == other.ActionPointCount && !(this.AquariumBgmPath != other.AquariumBgmPath) && this.AquariumMapGroupId == other.AquariumMapGroupId && !(this.AquariumTrackingSound != other.AquariumTrackingSound) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.AutoBiteTime, other.AutoBiteTime) && !(this.AutoFishingButtonOff != other.AutoFishingButtonOff) && !(this.AutoFishingButtonOn != other.AutoFishingButtonOn) && this.AutoFishingOpenCondition == other.AutoFishingOpenCondition && this.AutoGradePoolId == other.AutoGradePoolId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.AutoStartCount, other.AutoStartCount) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.CriticalMultiplier, other.CriticalMultiplier) && this.defaultItemCount_.Equals(other.defaultItemCount_) && this.defaultItemId_.Equals(other.defaultItemId_) && this.defaultItemType_.Equals(other.defaultItemType_) && this.DefaultMapId == other.DefaultMapId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.FinishAlert, other.FinishAlert) && this.FishTrapFishPoolId == other.FishTrapFishPoolId && this.FishTrapGradePoolId == other.FishTrapGradePoolId && this.FishTrapMaxTime == other.FishTrapMaxTime && this.FishTrapOpenCondition == other.FishTrapOpenCondition && this.FishTrapOpenContentTicket == other.FishTrapOpenContentTicket && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.FishingBaseTime, other.FishingBaseTime) && !(this.GaugeCharge != other.GaugeCharge) && this.GuideEventMissionGroupId == other.GuideEventMissionGroupId && this.Id == other.Id && this.LoadingLimit == other.LoadingLimit && !(this.LobbyAmbienceName != other.LobbyAmbienceName) && !(this.LobbySceneBgm != other.LobbySceneBgm) && !(this.LobbySceneName != other.LobbySceneName) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxBaitTime, other.MaxBaitTime) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxBigLuck, other.MaxBigLuck) && this.MaxCharLevel == other.MaxCharLevel && this.MaxRareLuck == other.MaxRareLuck && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MinBaitTime, other.MinBaitTime) && this.MultiOpenCondition == other.MultiOpenCondition && this.MultiSearchTime == other.MultiSearchTime && this.OpenMapUiObjectId == other.OpenMapUiObjectId && this.QuestNameTextId == other.QuestNameTextId && this.QuestSkipTextId == other.QuestSkipTextId && this.QuestTitleQuestTextId == other.QuestTitleQuestTextId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ReconnectTimeout, other.ReconnectTimeout) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.RoomDuration, other.RoomDuration) && this.RoomListCount == other.RoomListCount && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.RoomRerollInterval, other.RoomRerollInterval) && this.SkillHitzoneSize == other.SkillHitzoneSize && this.SkinOpenCondition == other.SkinOpenCondition && this.StaminaDevider == other.StaminaDevider && !(this.StartTimelineName != other.StartTimelineName) && this.StartVisualNovelDialogId == other.StartVisualNovelDialogId && this.WeekEventMissionGroupId == other.WeekEventMissionGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046BC8 RID: 289736 RVA: 0x011328C0 File Offset: 0x01130AC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionPointCount != 0)
			{
				num ^= this.ActionPointCount.GetHashCode();
			}
			if (this.AquariumBgmPath.Length != 0)
			{
				num ^= this.AquariumBgmPath.GetHashCode();
			}
			if (this.AquariumMapGroupId != 0)
			{
				num ^= this.AquariumMapGroupId.GetHashCode();
			}
			if (this.AquariumTrackingSound.Length != 0)
			{
				num ^= this.AquariumTrackingSound.GetHashCode();
			}
			if (this.AutoBiteTime != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.AutoBiteTime);
			}
			if (this.AutoFishingButtonOff.Length != 0)
			{
				num ^= this.AutoFishingButtonOff.GetHashCode();
			}
			if (this.AutoFishingButtonOn.Length != 0)
			{
				num ^= this.AutoFishingButtonOn.GetHashCode();
			}
			if (this.AutoFishingOpenCondition != 0)
			{
				num ^= this.AutoFishingOpenCondition.GetHashCode();
			}
			if (this.AutoGradePoolId != 0)
			{
				num ^= this.AutoGradePoolId.GetHashCode();
			}
			if (this.AutoStartCount != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.AutoStartCount);
			}
			if (this.CriticalMultiplier != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.CriticalMultiplier);
			}
			num ^= this.defaultItemCount_.GetHashCode();
			num ^= this.defaultItemId_.GetHashCode();
			num ^= this.defaultItemType_.GetHashCode();
			if (this.DefaultMapId != 0)
			{
				num ^= this.DefaultMapId.GetHashCode();
			}
			if (this.FinishAlert != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.FinishAlert);
			}
			if (this.FishTrapFishPoolId != 0)
			{
				num ^= this.FishTrapFishPoolId.GetHashCode();
			}
			if (this.FishTrapGradePoolId != 0)
			{
				num ^= this.FishTrapGradePoolId.GetHashCode();
			}
			if (this.FishTrapMaxTime != 0)
			{
				num ^= this.FishTrapMaxTime.GetHashCode();
			}
			if (this.FishTrapOpenCondition != 0)
			{
				num ^= this.FishTrapOpenCondition.GetHashCode();
			}
			if (this.FishTrapOpenContentTicket != 0)
			{
				num ^= this.FishTrapOpenContentTicket.GetHashCode();
			}
			if (this.FishingBaseTime != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.FishingBaseTime);
			}
			if (this.GaugeCharge.Length != 0)
			{
				num ^= this.GaugeCharge.GetHashCode();
			}
			if (this.GuideEventMissionGroupId != 0)
			{
				num ^= this.GuideEventMissionGroupId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LoadingLimit != 0)
			{
				num ^= this.LoadingLimit.GetHashCode();
			}
			if (this.LobbyAmbienceName.Length != 0)
			{
				num ^= this.LobbyAmbienceName.GetHashCode();
			}
			if (this.LobbySceneBgm.Length != 0)
			{
				num ^= this.LobbySceneBgm.GetHashCode();
			}
			if (this.LobbySceneName.Length != 0)
			{
				num ^= this.LobbySceneName.GetHashCode();
			}
			if (this.MaxBaitTime != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxBaitTime);
			}
			if (this.MaxBigLuck != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxBigLuck);
			}
			if (this.MaxCharLevel != 0)
			{
				num ^= this.MaxCharLevel.GetHashCode();
			}
			if (this.MaxRareLuck != 0)
			{
				num ^= this.MaxRareLuck.GetHashCode();
			}
			if (this.MinBaitTime != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MinBaitTime);
			}
			if (this.MultiOpenCondition != 0)
			{
				num ^= this.MultiOpenCondition.GetHashCode();
			}
			if (this.MultiSearchTime != 0)
			{
				num ^= this.MultiSearchTime.GetHashCode();
			}
			if (this.OpenMapUiObjectId != 0)
			{
				num ^= this.OpenMapUiObjectId.GetHashCode();
			}
			if (this.QuestNameTextId != 0)
			{
				num ^= this.QuestNameTextId.GetHashCode();
			}
			if (this.QuestSkipTextId != 0)
			{
				num ^= this.QuestSkipTextId.GetHashCode();
			}
			if (this.QuestTitleQuestTextId != 0)
			{
				num ^= this.QuestTitleQuestTextId.GetHashCode();
			}
			if (this.ReconnectTimeout != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ReconnectTimeout);
			}
			if (this.RoomDuration != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.RoomDuration);
			}
			if (this.RoomListCount != 0)
			{
				num ^= this.RoomListCount.GetHashCode();
			}
			if (this.RoomRerollInterval != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.RoomRerollInterval);
			}
			if (this.SkillHitzoneSize != 0)
			{
				num ^= this.SkillHitzoneSize.GetHashCode();
			}
			if (this.SkinOpenCondition != 0)
			{
				num ^= this.SkinOpenCondition.GetHashCode();
			}
			if (this.StaminaDevider != 0)
			{
				num ^= this.StaminaDevider.GetHashCode();
			}
			if (this.StartTimelineName.Length != 0)
			{
				num ^= this.StartTimelineName.GetHashCode();
			}
			if (this.StartVisualNovelDialogId != 0)
			{
				num ^= this.StartVisualNovelDialogId.GetHashCode();
			}
			if (this.WeekEventMissionGroupId != 0)
			{
				num ^= this.WeekEventMissionGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046BC9 RID: 289737 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046BCA RID: 289738 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046BCB RID: 289739 RVA: 0x01132E34 File Offset: 0x01131034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionPointCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActionPointCount);
			}
			if (this.AquariumBgmPath.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.AquariumBgmPath);
			}
			if (this.AquariumMapGroupId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AquariumMapGroupId);
			}
			if (this.AquariumTrackingSound.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.AquariumTrackingSound);
			}
			if (this.AutoBiteTime != 0.0)
			{
				output.WriteRawTag(41);
				output.WriteDouble(this.AutoBiteTime);
			}
			if (this.AutoFishingButtonOff.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.AutoFishingButtonOff);
			}
			if (this.AutoFishingButtonOn.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.AutoFishingButtonOn);
			}
			if (this.AutoFishingOpenCondition != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.AutoFishingOpenCondition);
			}
			if (this.AutoGradePoolId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AutoGradePoolId);
			}
			if (this.AutoStartCount != 0.0)
			{
				output.WriteRawTag(81);
				output.WriteDouble(this.AutoStartCount);
			}
			if (this.CriticalMultiplier != 0.0)
			{
				output.WriteRawTag(89);
				output.WriteDouble(this.CriticalMultiplier);
			}
			this.defaultItemCount_.WriteTo(ref output, FishingDefaultTable._repeated_defaultItemCount_codec);
			this.defaultItemId_.WriteTo(ref output, FishingDefaultTable._repeated_defaultItemId_codec);
			this.defaultItemType_.WriteTo(ref output, FishingDefaultTable._repeated_defaultItemType_codec);
			if (this.DefaultMapId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.DefaultMapId);
			}
			if (this.FinishAlert != 0.0)
			{
				output.WriteRawTag(129, 1);
				output.WriteDouble(this.FinishAlert);
			}
			if (this.FishTrapFishPoolId != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.FishTrapFishPoolId);
			}
			if (this.FishTrapGradePoolId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.FishTrapGradePoolId);
			}
			if (this.FishTrapMaxTime != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.FishTrapMaxTime);
			}
			if (this.FishTrapOpenCondition != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.FishTrapOpenCondition);
			}
			if (this.FishTrapOpenContentTicket != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.FishTrapOpenContentTicket);
			}
			if (this.FishingBaseTime != 0.0)
			{
				output.WriteRawTag(177, 1);
				output.WriteDouble(this.FishingBaseTime);
			}
			if (this.GaugeCharge.Length != 0)
			{
				output.WriteRawTag(186, 1);
				output.WriteString(this.GaugeCharge);
			}
			if (this.GuideEventMissionGroupId != 0)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt32(this.GuideEventMissionGroupId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(200, 1);
				output.WriteInt32(this.Id);
			}
			if (this.LoadingLimit != 0)
			{
				output.WriteRawTag(208, 1);
				output.WriteInt32(this.LoadingLimit);
			}
			if (this.LobbyAmbienceName.Length != 0)
			{
				output.WriteRawTag(218, 1);
				output.WriteString(this.LobbyAmbienceName);
			}
			if (this.LobbySceneBgm.Length != 0)
			{
				output.WriteRawTag(226, 1);
				output.WriteString(this.LobbySceneBgm);
			}
			if (this.LobbySceneName.Length != 0)
			{
				output.WriteRawTag(234, 1);
				output.WriteString(this.LobbySceneName);
			}
			if (this.MaxBaitTime != 0.0)
			{
				output.WriteRawTag(241, 1);
				output.WriteDouble(this.MaxBaitTime);
			}
			if (this.MaxBigLuck != 0.0)
			{
				output.WriteRawTag(249, 1);
				output.WriteDouble(this.MaxBigLuck);
			}
			if (this.MaxCharLevel != 0)
			{
				output.WriteRawTag(128, 2);
				output.WriteInt32(this.MaxCharLevel);
			}
			if (this.MaxRareLuck != 0)
			{
				output.WriteRawTag(136, 2);
				output.WriteInt32(this.MaxRareLuck);
			}
			if (this.MinBaitTime != 0.0)
			{
				output.WriteRawTag(145, 2);
				output.WriteDouble(this.MinBaitTime);
			}
			if (this.MultiOpenCondition != 0)
			{
				output.WriteRawTag(152, 2);
				output.WriteInt32(this.MultiOpenCondition);
			}
			if (this.MultiSearchTime != 0)
			{
				output.WriteRawTag(160, 2);
				output.WriteInt32(this.MultiSearchTime);
			}
			if (this.OpenMapUiObjectId != 0)
			{
				output.WriteRawTag(168, 2);
				output.WriteInt32(this.OpenMapUiObjectId);
			}
			if (this.QuestNameTextId != 0)
			{
				output.WriteRawTag(176, 2);
				output.WriteInt32(this.QuestNameTextId);
			}
			if (this.QuestSkipTextId != 0)
			{
				output.WriteRawTag(184, 2);
				output.WriteInt32(this.QuestSkipTextId);
			}
			if (this.QuestTitleQuestTextId != 0)
			{
				output.WriteRawTag(192, 2);
				output.WriteInt32(this.QuestTitleQuestTextId);
			}
			if (this.ReconnectTimeout != 0.0)
			{
				output.WriteRawTag(201, 2);
				output.WriteDouble(this.ReconnectTimeout);
			}
			if (this.RoomDuration != 0.0)
			{
				output.WriteRawTag(209, 2);
				output.WriteDouble(this.RoomDuration);
			}
			if (this.RoomListCount != 0)
			{
				output.WriteRawTag(216, 2);
				output.WriteInt32(this.RoomListCount);
			}
			if (this.RoomRerollInterval != 0.0)
			{
				output.WriteRawTag(225, 2);
				output.WriteDouble(this.RoomRerollInterval);
			}
			if (this.SkillHitzoneSize != 0)
			{
				output.WriteRawTag(232, 2);
				output.WriteInt32(this.SkillHitzoneSize);
			}
			if (this.SkinOpenCondition != 0)
			{
				output.WriteRawTag(240, 2);
				output.WriteInt32(this.SkinOpenCondition);
			}
			if (this.StaminaDevider != 0)
			{
				output.WriteRawTag(248, 2);
				output.WriteInt32(this.StaminaDevider);
			}
			if (this.StartTimelineName.Length != 0)
			{
				output.WriteRawTag(130, 3);
				output.WriteString(this.StartTimelineName);
			}
			if (this.StartVisualNovelDialogId != 0)
			{
				output.WriteRawTag(136, 3);
				output.WriteInt32(this.StartVisualNovelDialogId);
			}
			if (this.WeekEventMissionGroupId != 0)
			{
				output.WriteRawTag(144, 3);
				output.WriteInt32(this.WeekEventMissionGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046BCC RID: 289740 RVA: 0x011334C8 File Offset: 0x011316C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionPointCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionPointCount);
			}
			if (this.AquariumBgmPath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AquariumBgmPath);
			}
			if (this.AquariumMapGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AquariumMapGroupId);
			}
			if (this.AquariumTrackingSound.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AquariumTrackingSound);
			}
			if (this.AutoBiteTime != 0.0)
			{
				num += 9;
			}
			if (this.AutoFishingButtonOff.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AutoFishingButtonOff);
			}
			if (this.AutoFishingButtonOn.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AutoFishingButtonOn);
			}
			if (this.AutoFishingOpenCondition != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AutoFishingOpenCondition);
			}
			if (this.AutoGradePoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AutoGradePoolId);
			}
			if (this.AutoStartCount != 0.0)
			{
				num += 9;
			}
			if (this.CriticalMultiplier != 0.0)
			{
				num += 9;
			}
			num += this.defaultItemCount_.CalculateSize(FishingDefaultTable._repeated_defaultItemCount_codec);
			num += this.defaultItemId_.CalculateSize(FishingDefaultTable._repeated_defaultItemId_codec);
			num += this.defaultItemType_.CalculateSize(FishingDefaultTable._repeated_defaultItemType_codec);
			if (this.DefaultMapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DefaultMapId);
			}
			if (this.FinishAlert != 0.0)
			{
				num += 10;
			}
			if (this.FishTrapFishPoolId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FishTrapFishPoolId);
			}
			if (this.FishTrapGradePoolId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FishTrapGradePoolId);
			}
			if (this.FishTrapMaxTime != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FishTrapMaxTime);
			}
			if (this.FishTrapOpenCondition != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FishTrapOpenCondition);
			}
			if (this.FishTrapOpenContentTicket != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FishTrapOpenContentTicket);
			}
			if (this.FishingBaseTime != 0.0)
			{
				num += 10;
			}
			if (this.GaugeCharge.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.GaugeCharge);
			}
			if (this.GuideEventMissionGroupId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.GuideEventMissionGroupId);
			}
			if (this.Id != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LoadingLimit != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.LoadingLimit);
			}
			if (this.LobbyAmbienceName.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LobbyAmbienceName);
			}
			if (this.LobbySceneBgm.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LobbySceneBgm);
			}
			if (this.LobbySceneName.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.LobbySceneName);
			}
			if (this.MaxBaitTime != 0.0)
			{
				num += 10;
			}
			if (this.MaxBigLuck != 0.0)
			{
				num += 10;
			}
			if (this.MaxCharLevel != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxCharLevel);
			}
			if (this.MaxRareLuck != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxRareLuck);
			}
			if (this.MinBaitTime != 0.0)
			{
				num += 10;
			}
			if (this.MultiOpenCondition != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MultiOpenCondition);
			}
			if (this.MultiSearchTime != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MultiSearchTime);
			}
			if (this.OpenMapUiObjectId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.OpenMapUiObjectId);
			}
			if (this.QuestNameTextId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.QuestNameTextId);
			}
			if (this.QuestSkipTextId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.QuestSkipTextId);
			}
			if (this.QuestTitleQuestTextId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.QuestTitleQuestTextId);
			}
			if (this.ReconnectTimeout != 0.0)
			{
				num += 10;
			}
			if (this.RoomDuration != 0.0)
			{
				num += 10;
			}
			if (this.RoomListCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoomListCount);
			}
			if (this.RoomRerollInterval != 0.0)
			{
				num += 10;
			}
			if (this.SkillHitzoneSize != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkillHitzoneSize);
			}
			if (this.SkinOpenCondition != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkinOpenCondition);
			}
			if (this.StaminaDevider != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.StaminaDevider);
			}
			if (this.StartTimelineName.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.StartTimelineName);
			}
			if (this.StartVisualNovelDialogId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.StartVisualNovelDialogId);
			}
			if (this.WeekEventMissionGroupId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.WeekEventMissionGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046BCD RID: 289741 RVA: 0x011339A8 File Offset: 0x01131BA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingDefaultTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionPointCount != 0)
			{
				this.ActionPointCount = other.ActionPointCount;
			}
			if (other.AquariumBgmPath.Length != 0)
			{
				this.AquariumBgmPath = other.AquariumBgmPath;
			}
			if (other.AquariumMapGroupId != 0)
			{
				this.AquariumMapGroupId = other.AquariumMapGroupId;
			}
			if (other.AquariumTrackingSound.Length != 0)
			{
				this.AquariumTrackingSound = other.AquariumTrackingSound;
			}
			if (other.AutoBiteTime != 0.0)
			{
				this.AutoBiteTime = other.AutoBiteTime;
			}
			if (other.AutoFishingButtonOff.Length != 0)
			{
				this.AutoFishingButtonOff = other.AutoFishingButtonOff;
			}
			if (other.AutoFishingButtonOn.Length != 0)
			{
				this.AutoFishingButtonOn = other.AutoFishingButtonOn;
			}
			if (other.AutoFishingOpenCondition != 0)
			{
				this.AutoFishingOpenCondition = other.AutoFishingOpenCondition;
			}
			if (other.AutoGradePoolId != 0)
			{
				this.AutoGradePoolId = other.AutoGradePoolId;
			}
			if (other.AutoStartCount != 0.0)
			{
				this.AutoStartCount = other.AutoStartCount;
			}
			if (other.CriticalMultiplier != 0.0)
			{
				this.CriticalMultiplier = other.CriticalMultiplier;
			}
			this.defaultItemCount_.Add(other.defaultItemCount_);
			this.defaultItemId_.Add(other.defaultItemId_);
			this.defaultItemType_.Add(other.defaultItemType_);
			if (other.DefaultMapId != 0)
			{
				this.DefaultMapId = other.DefaultMapId;
			}
			if (other.FinishAlert != 0.0)
			{
				this.FinishAlert = other.FinishAlert;
			}
			if (other.FishTrapFishPoolId != 0)
			{
				this.FishTrapFishPoolId = other.FishTrapFishPoolId;
			}
			if (other.FishTrapGradePoolId != 0)
			{
				this.FishTrapGradePoolId = other.FishTrapGradePoolId;
			}
			if (other.FishTrapMaxTime != 0)
			{
				this.FishTrapMaxTime = other.FishTrapMaxTime;
			}
			if (other.FishTrapOpenCondition != 0)
			{
				this.FishTrapOpenCondition = other.FishTrapOpenCondition;
			}
			if (other.FishTrapOpenContentTicket != 0)
			{
				this.FishTrapOpenContentTicket = other.FishTrapOpenContentTicket;
			}
			if (other.FishingBaseTime != 0.0)
			{
				this.FishingBaseTime = other.FishingBaseTime;
			}
			if (other.GaugeCharge.Length != 0)
			{
				this.GaugeCharge = other.GaugeCharge;
			}
			if (other.GuideEventMissionGroupId != 0)
			{
				this.GuideEventMissionGroupId = other.GuideEventMissionGroupId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LoadingLimit != 0)
			{
				this.LoadingLimit = other.LoadingLimit;
			}
			if (other.LobbyAmbienceName.Length != 0)
			{
				this.LobbyAmbienceName = other.LobbyAmbienceName;
			}
			if (other.LobbySceneBgm.Length != 0)
			{
				this.LobbySceneBgm = other.LobbySceneBgm;
			}
			if (other.LobbySceneName.Length != 0)
			{
				this.LobbySceneName = other.LobbySceneName;
			}
			if (other.MaxBaitTime != 0.0)
			{
				this.MaxBaitTime = other.MaxBaitTime;
			}
			if (other.MaxBigLuck != 0.0)
			{
				this.MaxBigLuck = other.MaxBigLuck;
			}
			if (other.MaxCharLevel != 0)
			{
				this.MaxCharLevel = other.MaxCharLevel;
			}
			if (other.MaxRareLuck != 0)
			{
				this.MaxRareLuck = other.MaxRareLuck;
			}
			if (other.MinBaitTime != 0.0)
			{
				this.MinBaitTime = other.MinBaitTime;
			}
			if (other.MultiOpenCondition != 0)
			{
				this.MultiOpenCondition = other.MultiOpenCondition;
			}
			if (other.MultiSearchTime != 0)
			{
				this.MultiSearchTime = other.MultiSearchTime;
			}
			if (other.OpenMapUiObjectId != 0)
			{
				this.OpenMapUiObjectId = other.OpenMapUiObjectId;
			}
			if (other.QuestNameTextId != 0)
			{
				this.QuestNameTextId = other.QuestNameTextId;
			}
			if (other.QuestSkipTextId != 0)
			{
				this.QuestSkipTextId = other.QuestSkipTextId;
			}
			if (other.QuestTitleQuestTextId != 0)
			{
				this.QuestTitleQuestTextId = other.QuestTitleQuestTextId;
			}
			if (other.ReconnectTimeout != 0.0)
			{
				this.ReconnectTimeout = other.ReconnectTimeout;
			}
			if (other.RoomDuration != 0.0)
			{
				this.RoomDuration = other.RoomDuration;
			}
			if (other.RoomListCount != 0)
			{
				this.RoomListCount = other.RoomListCount;
			}
			if (other.RoomRerollInterval != 0.0)
			{
				this.RoomRerollInterval = other.RoomRerollInterval;
			}
			if (other.SkillHitzoneSize != 0)
			{
				this.SkillHitzoneSize = other.SkillHitzoneSize;
			}
			if (other.SkinOpenCondition != 0)
			{
				this.SkinOpenCondition = other.SkinOpenCondition;
			}
			if (other.StaminaDevider != 0)
			{
				this.StaminaDevider = other.StaminaDevider;
			}
			if (other.StartTimelineName.Length != 0)
			{
				this.StartTimelineName = other.StartTimelineName;
			}
			if (other.StartVisualNovelDialogId != 0)
			{
				this.StartVisualNovelDialogId = other.StartVisualNovelDialogId;
			}
			if (other.WeekEventMissionGroupId != 0)
			{
				this.WeekEventMissionGroupId = other.WeekEventMissionGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046BCE RID: 289742 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046BCF RID: 289743 RVA: 0x01133E40 File Offset: 0x01132040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 186U)
				{
					if (num <= 98U)
					{
						if (num <= 50U)
						{
							if (num <= 24U)
							{
								if (num == 8U)
								{
									this.ActionPointCount = input.ReadInt32();
									continue;
								}
								if (num == 18U)
								{
									this.AquariumBgmPath = input.ReadString();
									continue;
								}
								if (num == 24U)
								{
									this.AquariumMapGroupId = input.ReadInt32();
									continue;
								}
							}
							else
							{
								if (num == 34U)
								{
									this.AquariumTrackingSound = input.ReadString();
									continue;
								}
								if (num == 41U)
								{
									this.AutoBiteTime = input.ReadDouble();
									continue;
								}
								if (num == 50U)
								{
									this.AutoFishingButtonOff = input.ReadString();
									continue;
								}
							}
						}
						else if (num <= 72U)
						{
							if (num == 58U)
							{
								this.AutoFishingButtonOn = input.ReadString();
								continue;
							}
							if (num == 64U)
							{
								this.AutoFishingOpenCondition = input.ReadInt32();
								continue;
							}
							if (num == 72U)
							{
								this.AutoGradePoolId = input.ReadInt32();
								continue;
							}
						}
						else if (num <= 89U)
						{
							if (num == 81U)
							{
								this.AutoStartCount = input.ReadDouble();
								continue;
							}
							if (num == 89U)
							{
								this.CriticalMultiplier = input.ReadDouble();
								continue;
							}
						}
						else if (num == 96U || num == 98U)
						{
							this.defaultItemCount_.AddEntriesFrom(ref input, FishingDefaultTable._repeated_defaultItemCount_codec);
							continue;
						}
					}
					else
					{
						if (num <= 129U)
						{
							if (num <= 112U)
							{
								if (num == 104U || num == 106U)
								{
									this.defaultItemId_.AddEntriesFrom(ref input, FishingDefaultTable._repeated_defaultItemId_codec);
									continue;
								}
								if (num != 112U)
								{
									goto IL_0304;
								}
							}
							else if (num != 114U)
							{
								if (num == 120U)
								{
									this.DefaultMapId = input.ReadInt32();
									continue;
								}
								if (num != 129U)
								{
									goto IL_0304;
								}
								this.FinishAlert = input.ReadDouble();
								continue;
							}
							this.defaultItemType_.AddEntriesFrom(ref input, FishingDefaultTable._repeated_defaultItemType_codec);
							continue;
						}
						if (num <= 152U)
						{
							if (num == 136U)
							{
								this.FishTrapFishPoolId = input.ReadInt32();
								continue;
							}
							if (num == 144U)
							{
								this.FishTrapGradePoolId = input.ReadInt32();
								continue;
							}
							if (num == 152U)
							{
								this.FishTrapMaxTime = input.ReadInt32();
								continue;
							}
						}
						else if (num <= 168U)
						{
							if (num == 160U)
							{
								this.FishTrapOpenCondition = input.ReadInt32();
								continue;
							}
							if (num == 168U)
							{
								this.FishTrapOpenContentTicket = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 177U)
							{
								this.FishingBaseTime = input.ReadDouble();
								continue;
							}
							if (num == 186U)
							{
								this.GaugeCharge = input.ReadString();
								continue;
							}
						}
					}
				}
				else if (num <= 288U)
				{
					if (num <= 234U)
					{
						if (num <= 208U)
						{
							if (num == 192U)
							{
								this.GuideEventMissionGroupId = input.ReadInt32();
								continue;
							}
							if (num == 200U)
							{
								this.Id = input.ReadInt32();
								continue;
							}
							if (num == 208U)
							{
								this.LoadingLimit = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 218U)
							{
								this.LobbyAmbienceName = input.ReadString();
								continue;
							}
							if (num == 226U)
							{
								this.LobbySceneBgm = input.ReadString();
								continue;
							}
							if (num == 234U)
							{
								this.LobbySceneName = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 256U)
					{
						if (num == 241U)
						{
							this.MaxBaitTime = input.ReadDouble();
							continue;
						}
						if (num == 249U)
						{
							this.MaxBigLuck = input.ReadDouble();
							continue;
						}
						if (num == 256U)
						{
							this.MaxCharLevel = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 273U)
					{
						if (num == 264U)
						{
							this.MaxRareLuck = input.ReadInt32();
							continue;
						}
						if (num == 273U)
						{
							this.MinBaitTime = input.ReadDouble();
							continue;
						}
					}
					else
					{
						if (num == 280U)
						{
							this.MultiOpenCondition = input.ReadInt32();
							continue;
						}
						if (num == 288U)
						{
							this.MultiSearchTime = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 344U)
				{
					if (num <= 312U)
					{
						if (num == 296U)
						{
							this.OpenMapUiObjectId = input.ReadInt32();
							continue;
						}
						if (num == 304U)
						{
							this.QuestNameTextId = input.ReadInt32();
							continue;
						}
						if (num == 312U)
						{
							this.QuestSkipTextId = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 329U)
					{
						if (num == 320U)
						{
							this.QuestTitleQuestTextId = input.ReadInt32();
							continue;
						}
						if (num == 329U)
						{
							this.ReconnectTimeout = input.ReadDouble();
							continue;
						}
					}
					else
					{
						if (num == 337U)
						{
							this.RoomDuration = input.ReadDouble();
							continue;
						}
						if (num == 344U)
						{
							this.RoomListCount = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 368U)
				{
					if (num == 353U)
					{
						this.RoomRerollInterval = input.ReadDouble();
						continue;
					}
					if (num == 360U)
					{
						this.SkillHitzoneSize = input.ReadInt32();
						continue;
					}
					if (num == 368U)
					{
						this.SkinOpenCondition = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 386U)
				{
					if (num == 376U)
					{
						this.StaminaDevider = input.ReadInt32();
						continue;
					}
					if (num == 386U)
					{
						this.StartTimelineName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 392U)
					{
						this.StartVisualNovelDialogId = input.ReadInt32();
						continue;
					}
					if (num == 400U)
					{
						this.WeekEventMissionGroupId = input.ReadInt32();
						continue;
					}
				}
				IL_0304:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EA16 RID: 190998
		private static readonly MessageParser<FishingDefaultTable> _parser = new MessageParser<FishingDefaultTable>(() => new FishingDefaultTable());

		// Token: 0x0402EA17 RID: 190999
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EA18 RID: 191000
		public const int ActionPointCountFieldNumber = 1;

		// Token: 0x0402EA19 RID: 191001
		private int actionPointCount_;

		// Token: 0x0402EA1A RID: 191002
		public const int AquariumBgmPathFieldNumber = 2;

		// Token: 0x0402EA1B RID: 191003
		private string aquariumBgmPath_ = "";

		// Token: 0x0402EA1C RID: 191004
		public const int AquariumMapGroupIdFieldNumber = 3;

		// Token: 0x0402EA1D RID: 191005
		private int aquariumMapGroupId_;

		// Token: 0x0402EA1E RID: 191006
		public const int AquariumTrackingSoundFieldNumber = 4;

		// Token: 0x0402EA1F RID: 191007
		private string aquariumTrackingSound_ = "";

		// Token: 0x0402EA20 RID: 191008
		public const int AutoBiteTimeFieldNumber = 5;

		// Token: 0x0402EA21 RID: 191009
		private double autoBiteTime_;

		// Token: 0x0402EA22 RID: 191010
		public const int AutoFishingButtonOffFieldNumber = 6;

		// Token: 0x0402EA23 RID: 191011
		private string autoFishingButtonOff_ = "";

		// Token: 0x0402EA24 RID: 191012
		public const int AutoFishingButtonOnFieldNumber = 7;

		// Token: 0x0402EA25 RID: 191013
		private string autoFishingButtonOn_ = "";

		// Token: 0x0402EA26 RID: 191014
		public const int AutoFishingOpenConditionFieldNumber = 8;

		// Token: 0x0402EA27 RID: 191015
		private int autoFishingOpenCondition_;

		// Token: 0x0402EA28 RID: 191016
		public const int AutoGradePoolIdFieldNumber = 9;

		// Token: 0x0402EA29 RID: 191017
		private int autoGradePoolId_;

		// Token: 0x0402EA2A RID: 191018
		public const int AutoStartCountFieldNumber = 10;

		// Token: 0x0402EA2B RID: 191019
		private double autoStartCount_;

		// Token: 0x0402EA2C RID: 191020
		public const int CriticalMultiplierFieldNumber = 11;

		// Token: 0x0402EA2D RID: 191021
		private double criticalMultiplier_;

		// Token: 0x0402EA2E RID: 191022
		public const int DefaultItemCountFieldNumber = 12;

		// Token: 0x0402EA2F RID: 191023
		private static readonly FieldCodec<int> _repeated_defaultItemCount_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0402EA30 RID: 191024
		private readonly RepeatedField<int> defaultItemCount_ = new RepeatedField<int>();

		// Token: 0x0402EA31 RID: 191025
		public const int DefaultItemIdFieldNumber = 13;

		// Token: 0x0402EA32 RID: 191026
		private static readonly FieldCodec<int> _repeated_defaultItemId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0402EA33 RID: 191027
		private readonly RepeatedField<int> defaultItemId_ = new RepeatedField<int>();

		// Token: 0x0402EA34 RID: 191028
		public const int DefaultItemTypeFieldNumber = 14;

		// Token: 0x0402EA35 RID: 191029
		private static readonly FieldCodec<int> _repeated_defaultItemType_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0402EA36 RID: 191030
		private readonly RepeatedField<int> defaultItemType_ = new RepeatedField<int>();

		// Token: 0x0402EA37 RID: 191031
		public const int DefaultMapIdFieldNumber = 15;

		// Token: 0x0402EA38 RID: 191032
		private int defaultMapId_;

		// Token: 0x0402EA39 RID: 191033
		public const int FinishAlertFieldNumber = 16;

		// Token: 0x0402EA3A RID: 191034
		private double finishAlert_;

		// Token: 0x0402EA3B RID: 191035
		public const int FishTrapFishPoolIdFieldNumber = 17;

		// Token: 0x0402EA3C RID: 191036
		private int fishTrapFishPoolId_;

		// Token: 0x0402EA3D RID: 191037
		public const int FishTrapGradePoolIdFieldNumber = 18;

		// Token: 0x0402EA3E RID: 191038
		private int fishTrapGradePoolId_;

		// Token: 0x0402EA3F RID: 191039
		public const int FishTrapMaxTimeFieldNumber = 19;

		// Token: 0x0402EA40 RID: 191040
		private int fishTrapMaxTime_;

		// Token: 0x0402EA41 RID: 191041
		public const int FishTrapOpenConditionFieldNumber = 20;

		// Token: 0x0402EA42 RID: 191042
		private int fishTrapOpenCondition_;

		// Token: 0x0402EA43 RID: 191043
		public const int FishTrapOpenContentTicketFieldNumber = 21;

		// Token: 0x0402EA44 RID: 191044
		private int fishTrapOpenContentTicket_;

		// Token: 0x0402EA45 RID: 191045
		public const int FishingBaseTimeFieldNumber = 22;

		// Token: 0x0402EA46 RID: 191046
		private double fishingBaseTime_;

		// Token: 0x0402EA47 RID: 191047
		public const int GaugeChargeFieldNumber = 23;

		// Token: 0x0402EA48 RID: 191048
		private string gaugeCharge_ = "";

		// Token: 0x0402EA49 RID: 191049
		public const int GuideEventMissionGroupIdFieldNumber = 24;

		// Token: 0x0402EA4A RID: 191050
		private int guideEventMissionGroupId_;

		// Token: 0x0402EA4B RID: 191051
		public const int IdFieldNumber = 25;

		// Token: 0x0402EA4C RID: 191052
		private int id_;

		// Token: 0x0402EA4D RID: 191053
		public const int LoadingLimitFieldNumber = 26;

		// Token: 0x0402EA4E RID: 191054
		private int loadingLimit_;

		// Token: 0x0402EA4F RID: 191055
		public const int LobbyAmbienceNameFieldNumber = 27;

		// Token: 0x0402EA50 RID: 191056
		private string lobbyAmbienceName_ = "";

		// Token: 0x0402EA51 RID: 191057
		public const int LobbySceneBgmFieldNumber = 28;

		// Token: 0x0402EA52 RID: 191058
		private string lobbySceneBgm_ = "";

		// Token: 0x0402EA53 RID: 191059
		public const int LobbySceneNameFieldNumber = 29;

		// Token: 0x0402EA54 RID: 191060
		private string lobbySceneName_ = "";

		// Token: 0x0402EA55 RID: 191061
		public const int MaxBaitTimeFieldNumber = 30;

		// Token: 0x0402EA56 RID: 191062
		private double maxBaitTime_;

		// Token: 0x0402EA57 RID: 191063
		public const int MaxBigLuckFieldNumber = 31;

		// Token: 0x0402EA58 RID: 191064
		private double maxBigLuck_;

		// Token: 0x0402EA59 RID: 191065
		public const int MaxCharLevelFieldNumber = 32;

		// Token: 0x0402EA5A RID: 191066
		private int maxCharLevel_;

		// Token: 0x0402EA5B RID: 191067
		public const int MaxRareLuckFieldNumber = 33;

		// Token: 0x0402EA5C RID: 191068
		private int maxRareLuck_;

		// Token: 0x0402EA5D RID: 191069
		public const int MinBaitTimeFieldNumber = 34;

		// Token: 0x0402EA5E RID: 191070
		private double minBaitTime_;

		// Token: 0x0402EA5F RID: 191071
		public const int MultiOpenConditionFieldNumber = 35;

		// Token: 0x0402EA60 RID: 191072
		private int multiOpenCondition_;

		// Token: 0x0402EA61 RID: 191073
		public const int MultiSearchTimeFieldNumber = 36;

		// Token: 0x0402EA62 RID: 191074
		private int multiSearchTime_;

		// Token: 0x0402EA63 RID: 191075
		public const int OpenMapUiObjectIdFieldNumber = 37;

		// Token: 0x0402EA64 RID: 191076
		private int openMapUiObjectId_;

		// Token: 0x0402EA65 RID: 191077
		public const int QuestNameTextIdFieldNumber = 38;

		// Token: 0x0402EA66 RID: 191078
		private int questNameTextId_;

		// Token: 0x0402EA67 RID: 191079
		public const int QuestSkipTextIdFieldNumber = 39;

		// Token: 0x0402EA68 RID: 191080
		private int questSkipTextId_;

		// Token: 0x0402EA69 RID: 191081
		public const int QuestTitleQuestTextIdFieldNumber = 40;

		// Token: 0x0402EA6A RID: 191082
		private int questTitleQuestTextId_;

		// Token: 0x0402EA6B RID: 191083
		public const int ReconnectTimeoutFieldNumber = 41;

		// Token: 0x0402EA6C RID: 191084
		private double reconnectTimeout_;

		// Token: 0x0402EA6D RID: 191085
		public const int RoomDurationFieldNumber = 42;

		// Token: 0x0402EA6E RID: 191086
		private double roomDuration_;

		// Token: 0x0402EA6F RID: 191087
		public const int RoomListCountFieldNumber = 43;

		// Token: 0x0402EA70 RID: 191088
		private int roomListCount_;

		// Token: 0x0402EA71 RID: 191089
		public const int RoomRerollIntervalFieldNumber = 44;

		// Token: 0x0402EA72 RID: 191090
		private double roomRerollInterval_;

		// Token: 0x0402EA73 RID: 191091
		public const int SkillHitzoneSizeFieldNumber = 45;

		// Token: 0x0402EA74 RID: 191092
		private int skillHitzoneSize_;

		// Token: 0x0402EA75 RID: 191093
		public const int SkinOpenConditionFieldNumber = 46;

		// Token: 0x0402EA76 RID: 191094
		private int skinOpenCondition_;

		// Token: 0x0402EA77 RID: 191095
		public const int StaminaDeviderFieldNumber = 47;

		// Token: 0x0402EA78 RID: 191096
		private int staminaDevider_;

		// Token: 0x0402EA79 RID: 191097
		public const int StartTimelineNameFieldNumber = 48;

		// Token: 0x0402EA7A RID: 191098
		private string startTimelineName_ = "";

		// Token: 0x0402EA7B RID: 191099
		public const int StartVisualNovelDialogIdFieldNumber = 49;

		// Token: 0x0402EA7C RID: 191100
		private int startVisualNovelDialogId_;

		// Token: 0x0402EA7D RID: 191101
		public const int WeekEventMissionGroupIdFieldNumber = 50;

		// Token: 0x0402EA7E RID: 191102
		private int weekEventMissionGroupId_;
	}
}
