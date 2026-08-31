using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004638 RID: 17976
	public sealed class MiniEventHubSlotDBInfo : IMessage<MiniEventHubSlotDBInfo>, IMessage, IEquatable<MiniEventHubSlotDBInfo>, IDeepCloneable<MiniEventHubSlotDBInfo>, IBufferMessage
	{
		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0601C1DB RID: 115163 RVA: 0x007E3933 File Offset: 0x007E1B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniEventHubSlotDBInfo> Parser
		{
			get
			{
				return MiniEventHubSlotDBInfo._parser;
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0601C1DC RID: 115164 RVA: 0x007E393A File Offset: 0x007E1B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniEventHubSlotDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0601C1DD RID: 115165 RVA: 0x007E394C File Offset: 0x007E1B4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniEventHubSlotDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C1DE RID: 115166 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniEventHubSlotDBInfo()
		{
		}

		// Token: 0x0601C1DF RID: 115167 RVA: 0x007E3954 File Offset: 0x007E1B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniEventHubSlotDBInfo(MiniEventHubSlotDBInfo other)
			: this()
		{
			this.id_ = other.id_;
			this.hubContentType_ = other.hubContentType_;
			this.hubContentId_ = other.hubContentId_;
			this.eventUid_ = other.eventUid_;
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1E0 RID: 115168 RVA: 0x007E39C0 File Offset: 0x007E1BC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniEventHubSlotDBInfo Clone()
		{
			return new MiniEventHubSlotDBInfo(this);
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0601C1E1 RID: 115169 RVA: 0x007E39C8 File Offset: 0x007E1BC8
		// (set) Token: 0x0601C1E2 RID: 115170 RVA: 0x007E39D0 File Offset: 0x007E1BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0601C1E3 RID: 115171 RVA: 0x007E39D9 File Offset: 0x007E1BD9
		// (set) Token: 0x0601C1E4 RID: 115172 RVA: 0x007E39E1 File Offset: 0x007E1BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HubContentType
		{
			get
			{
				return this.hubContentType_;
			}
			set
			{
				this.hubContentType_ = value;
			}
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0601C1E5 RID: 115173 RVA: 0x007E39EA File Offset: 0x007E1BEA
		// (set) Token: 0x0601C1E6 RID: 115174 RVA: 0x007E39F2 File Offset: 0x007E1BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HubContentId
		{
			get
			{
				return this.hubContentId_;
			}
			set
			{
				this.hubContentId_ = value;
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x0601C1E7 RID: 115175 RVA: 0x007E39FB File Offset: 0x007E1BFB
		// (set) Token: 0x0601C1E8 RID: 115176 RVA: 0x007E3A03 File Offset: 0x007E1C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventUid
		{
			get
			{
				return this.eventUid_;
			}
			set
			{
				this.eventUid_ = value;
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x0601C1E9 RID: 115177 RVA: 0x007E3A0C File Offset: 0x007E1C0C
		// (set) Token: 0x0601C1EA RID: 115178 RVA: 0x007E3A14 File Offset: 0x007E1C14
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

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x0601C1EB RID: 115179 RVA: 0x007E3A1D File Offset: 0x007E1C1D
		// (set) Token: 0x0601C1EC RID: 115180 RVA: 0x007E3A25 File Offset: 0x007E1C25
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

		// Token: 0x0601C1ED RID: 115181 RVA: 0x007E3A2E File Offset: 0x007E1C2E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniEventHubSlotDBInfo);
		}

		// Token: 0x0601C1EE RID: 115182 RVA: 0x007E3A3C File Offset: 0x007E1C3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(MiniEventHubSlotDBInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.HubContentType == other.HubContentType && this.HubContentId == other.HubContentId && this.EventUid == other.EventUid && this.StartTime == other.StartTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C1EF RID: 115183 RVA: 0x007E3AC8 File Offset: 0x007E1CC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.HubContentType != 0)
			{
				num ^= this.HubContentType.GetHashCode();
			}
			if (this.HubContentId != 0)
			{
				num ^= this.HubContentId.GetHashCode();
			}
			if (this.EventUid != 0)
			{
				num ^= this.EventUid.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C1F0 RID: 115184 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C1F1 RID: 115185 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1F2 RID: 115186 RVA: 0x007E3B84 File Offset: 0x007E1D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.HubContentType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HubContentType);
			}
			if (this.HubContentId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HubContentId);
			}
			if (this.EventUid != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EventUid);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C1F3 RID: 115187 RVA: 0x007E3C4C File Offset: 0x007E1E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.HubContentType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HubContentType);
			}
			if (this.HubContentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HubContentId);
			}
			if (this.EventUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventUid);
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C1F4 RID: 115188 RVA: 0x007E3D04 File Offset: 0x007E1F04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(MiniEventHubSlotDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.HubContentType != 0)
			{
				this.HubContentType = other.HubContentType;
			}
			if (other.HubContentId != 0)
			{
				this.HubContentId = other.HubContentId;
			}
			if (other.EventUid != 0)
			{
				this.EventUid = other.EventUid;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C1F5 RID: 115189 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1F6 RID: 115190 RVA: 0x007E3DA4 File Offset: 0x007E1FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HubContentType = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.HubContentId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.EventUid = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<MiniEventHubSlotDBInfo> _parser = new MessageParser<MiniEventHubSlotDBInfo>(() => new MiniEventHubSlotDBInfo());

		// Token: 0x04015928 RID: 88360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015929 RID: 88361
		public const int IdFieldNumber = 1;

		// Token: 0x0401592A RID: 88362
		private int id_;

		// Token: 0x0401592B RID: 88363
		public const int HubContentTypeFieldNumber = 2;

		// Token: 0x0401592C RID: 88364
		private int hubContentType_;

		// Token: 0x0401592D RID: 88365
		public const int HubContentIdFieldNumber = 3;

		// Token: 0x0401592E RID: 88366
		private int hubContentId_;

		// Token: 0x0401592F RID: 88367
		public const int EventUidFieldNumber = 4;

		// Token: 0x04015930 RID: 88368
		private int eventUid_;

		// Token: 0x04015931 RID: 88369
		public const int StartTimeFieldNumber = 5;

		// Token: 0x04015932 RID: 88370
		private long startTime_;

		// Token: 0x04015933 RID: 88371
		public const int EndTimeFieldNumber = 6;

		// Token: 0x04015934 RID: 88372
		private long endTime_;
	}
}
