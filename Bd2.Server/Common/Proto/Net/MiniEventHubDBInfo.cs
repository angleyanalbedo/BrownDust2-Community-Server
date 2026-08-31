using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004634 RID: 17972
	public sealed class MiniEventHubDBInfo : IMessage<MiniEventHubDBInfo>, IMessage, IEquatable<MiniEventHubDBInfo>, IDeepCloneable<MiniEventHubDBInfo>, IBufferMessage
	{
		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0601C1AF RID: 115119 RVA: 0x007E3073 File Offset: 0x007E1273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniEventHubDBInfo> Parser
		{
			get
			{
				return MiniEventHubDBInfo._parser;
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0601C1B0 RID: 115120 RVA: 0x007E307A File Offset: 0x007E127A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniEventHubDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0601C1B1 RID: 115121 RVA: 0x007E308C File Offset: 0x007E128C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniEventHubDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C1B2 RID: 115122 RVA: 0x007E3093 File Offset: 0x007E1293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniEventHubDBInfo()
		{
		}

		// Token: 0x0601C1B3 RID: 115123 RVA: 0x007E30A8 File Offset: 0x007E12A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniEventHubDBInfo(MiniEventHubDBInfo other)
			: this()
		{
			this.uid_ = other.uid_;
			this.hubId_ = other.hubId_;
			this.startTime_ = other.startTime_;
			this.playEndTime_ = other.playEndTime_;
			this.endTime_ = other.endTime_;
			this.slotInfo_ = other.slotInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1B4 RID: 115124 RVA: 0x007E3119 File Offset: 0x007E1319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniEventHubDBInfo Clone()
		{
			return new MiniEventHubDBInfo(this);
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0601C1B5 RID: 115125 RVA: 0x007E3121 File Offset: 0x007E1321
		// (set) Token: 0x0601C1B6 RID: 115126 RVA: 0x007E3129 File Offset: 0x007E1329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0601C1B7 RID: 115127 RVA: 0x007E3132 File Offset: 0x007E1332
		// (set) Token: 0x0601C1B8 RID: 115128 RVA: 0x007E313A File Offset: 0x007E133A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HubId
		{
			get
			{
				return this.hubId_;
			}
			set
			{
				this.hubId_ = value;
			}
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0601C1B9 RID: 115129 RVA: 0x007E3143 File Offset: 0x007E1343
		// (set) Token: 0x0601C1BA RID: 115130 RVA: 0x007E314B File Offset: 0x007E134B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0601C1BB RID: 115131 RVA: 0x007E3154 File Offset: 0x007E1354
		// (set) Token: 0x0601C1BC RID: 115132 RVA: 0x007E315C File Offset: 0x007E135C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayEndTime
		{
			get
			{
				return this.playEndTime_;
			}
			set
			{
				this.playEndTime_ = value;
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0601C1BD RID: 115133 RVA: 0x007E3165 File Offset: 0x007E1365
		// (set) Token: 0x0601C1BE RID: 115134 RVA: 0x007E316D File Offset: 0x007E136D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0601C1BF RID: 115135 RVA: 0x007E3176 File Offset: 0x007E1376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MiniEventHubSlotDBInfo> SlotInfo
		{
			get
			{
				return this.slotInfo_;
			}
		}

		// Token: 0x0601C1C0 RID: 115136 RVA: 0x007E317E File Offset: 0x007E137E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniEventHubDBInfo);
		}

		// Token: 0x0601C1C1 RID: 115137 RVA: 0x007E318C File Offset: 0x007E138C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniEventHubDBInfo other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.HubId == other.HubId && this.StartTime == other.StartTime && this.PlayEndTime == other.PlayEndTime && this.EndTime == other.EndTime && this.slotInfo_.Equals(other.slotInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C1C2 RID: 115138 RVA: 0x007E321C File Offset: 0x007E141C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.HubId != 0)
			{
				num ^= this.HubId.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.PlayEndTime != 0L)
			{
				num ^= this.PlayEndTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.slotInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C1C3 RID: 115139 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C1C4 RID: 115140 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1C5 RID: 115141 RVA: 0x007E32D0 File Offset: 0x007E14D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Uid);
			}
			if (this.HubId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HubId);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.StartTime);
			}
			if (this.PlayEndTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.PlayEndTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EndTime);
			}
			this.slotInfo_.WriteTo(ref output, MiniEventHubDBInfo._repeated_slotInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C1C6 RID: 115142 RVA: 0x007E3390 File Offset: 0x007E1590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Uid);
			}
			if (this.HubId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HubId);
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.PlayEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PlayEndTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.slotInfo_.CalculateSize(MiniEventHubDBInfo._repeated_slotInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C1C7 RID: 115143 RVA: 0x007E3444 File Offset: 0x007E1644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniEventHubDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0)
			{
				this.Uid = other.Uid;
			}
			if (other.HubId != 0)
			{
				this.HubId = other.HubId;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.PlayEndTime != 0L)
			{
				this.PlayEndTime = other.PlayEndTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.slotInfo_.Add(other.slotInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C1C8 RID: 115144 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1C9 RID: 115145 RVA: 0x007E34E4 File Offset: 0x007E16E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Uid = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HubId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.PlayEndTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 50U)
					{
						this.slotInfo_.AddEntriesFrom(ref input, MiniEventHubDBInfo._repeated_slotInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<MiniEventHubDBInfo> _parser = new MessageParser<MiniEventHubDBInfo>(() => new MiniEventHubDBInfo());

		// Token: 0x04015914 RID: 88340
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015915 RID: 88341
		public const int UidFieldNumber = 1;

		// Token: 0x04015916 RID: 88342
		private int uid_;

		// Token: 0x04015917 RID: 88343
		public const int HubIdFieldNumber = 2;

		// Token: 0x04015918 RID: 88344
		private int hubId_;

		// Token: 0x04015919 RID: 88345
		public const int StartTimeFieldNumber = 3;

		// Token: 0x0401591A RID: 88346
		private long startTime_;

		// Token: 0x0401591B RID: 88347
		public const int PlayEndTimeFieldNumber = 4;

		// Token: 0x0401591C RID: 88348
		private long playEndTime_;

		// Token: 0x0401591D RID: 88349
		public const int EndTimeFieldNumber = 5;

		// Token: 0x0401591E RID: 88350
		private long endTime_;

		// Token: 0x0401591F RID: 88351
		public const int SlotInfoFieldNumber = 6;

		// Token: 0x04015920 RID: 88352
		private static readonly FieldCodec<MiniEventHubSlotDBInfo> _repeated_slotInfo_codec = FieldCodec.ForMessage<MiniEventHubSlotDBInfo>(50U, MiniEventHubSlotDBInfo.Parser);

		// Token: 0x04015921 RID: 88353
		private readonly RepeatedField<MiniEventHubSlotDBInfo> slotInfo_ = new RepeatedField<MiniEventHubSlotDBInfo>();
	}
}
