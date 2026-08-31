using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200460D RID: 17933
	public sealed class LifeHelperDBInfo : IMessage<LifeHelperDBInfo>, IMessage, IEquatable<LifeHelperDBInfo>, IDeepCloneable<LifeHelperDBInfo>, IBufferMessage
	{
		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0601C023 RID: 114723 RVA: 0x007DEC23 File Offset: 0x007DCE23
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LifeHelperDBInfo> Parser
		{
			get
			{
				return LifeHelperDBInfo._parser;
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x0601C024 RID: 114724 RVA: 0x007DEC2A File Offset: 0x007DCE2A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeHelperDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x0601C025 RID: 114725 RVA: 0x007DEC3C File Offset: 0x007DCE3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeHelperDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C026 RID: 114726 RVA: 0x007DEC43 File Offset: 0x007DCE43
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeHelperDBInfo()
		{
		}

		// Token: 0x0601C027 RID: 114727 RVA: 0x007DEC58 File Offset: 0x007DCE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeHelperDBInfo(LifeHelperDBInfo other)
			: this()
		{
			this.helperIndex_ = other.helperIndex_;
			this.helperId_ = other.helperId_;
			this.helperSlotId_ = other.helperSlotId_;
			this.helperName_ = other.helperName_;
			this.avatarInfo_ = ((other.avatarInfo_ != null) ? other.avatarInfo_.Clone() : null);
			this.workType_ = other.workType_;
			this.workId_ = other.workId_;
			this.assignDate_ = other.assignDate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C028 RID: 114728 RVA: 0x007DECEC File Offset: 0x007DCEEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeHelperDBInfo Clone()
		{
			return new LifeHelperDBInfo(this);
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0601C029 RID: 114729 RVA: 0x007DECF4 File Offset: 0x007DCEF4
		// (set) Token: 0x0601C02A RID: 114730 RVA: 0x007DECFC File Offset: 0x007DCEFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int HelperIndex
		{
			get
			{
				return this.helperIndex_;
			}
			set
			{
				this.helperIndex_ = value;
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0601C02B RID: 114731 RVA: 0x007DED05 File Offset: 0x007DCF05
		// (set) Token: 0x0601C02C RID: 114732 RVA: 0x007DED0D File Offset: 0x007DCF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HelperId
		{
			get
			{
				return this.helperId_;
			}
			set
			{
				this.helperId_ = value;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0601C02D RID: 114733 RVA: 0x007DED16 File Offset: 0x007DCF16
		// (set) Token: 0x0601C02E RID: 114734 RVA: 0x007DED1E File Offset: 0x007DCF1E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int HelperSlotId
		{
			get
			{
				return this.helperSlotId_;
			}
			set
			{
				this.helperSlotId_ = value;
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x0601C02F RID: 114735 RVA: 0x007DED27 File Offset: 0x007DCF27
		// (set) Token: 0x0601C030 RID: 114736 RVA: 0x007DED2F File Offset: 0x007DCF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HelperName
		{
			get
			{
				return this.helperName_;
			}
			set
			{
				this.helperName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0601C031 RID: 114737 RVA: 0x007DED42 File Offset: 0x007DCF42
		// (set) Token: 0x0601C032 RID: 114738 RVA: 0x007DED4A File Offset: 0x007DCF4A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AvatarUseDBInfo AvatarInfo
		{
			get
			{
				return this.avatarInfo_;
			}
			set
			{
				this.avatarInfo_ = value;
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x0601C033 RID: 114739 RVA: 0x007DED53 File Offset: 0x007DCF53
		// (set) Token: 0x0601C034 RID: 114740 RVA: 0x007DED5B File Offset: 0x007DCF5B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int WorkType
		{
			get
			{
				return this.workType_;
			}
			set
			{
				this.workType_ = value;
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x0601C035 RID: 114741 RVA: 0x007DED64 File Offset: 0x007DCF64
		// (set) Token: 0x0601C036 RID: 114742 RVA: 0x007DED6C File Offset: 0x007DCF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorkId
		{
			get
			{
				return this.workId_;
			}
			set
			{
				this.workId_ = value;
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0601C037 RID: 114743 RVA: 0x007DED75 File Offset: 0x007DCF75
		// (set) Token: 0x0601C038 RID: 114744 RVA: 0x007DED7D File Offset: 0x007DCF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AssignDate
		{
			get
			{
				return this.assignDate_;
			}
			set
			{
				this.assignDate_ = value;
			}
		}

		// Token: 0x0601C039 RID: 114745 RVA: 0x007DED86 File Offset: 0x007DCF86
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeHelperDBInfo);
		}

		// Token: 0x0601C03A RID: 114746 RVA: 0x007DED94 File Offset: 0x007DCF94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(LifeHelperDBInfo other)
		{
			return other != null && (other == this || (this.HelperIndex == other.HelperIndex && this.HelperId == other.HelperId && this.HelperSlotId == other.HelperSlotId && !(this.HelperName != other.HelperName) && object.Equals(this.AvatarInfo, other.AvatarInfo) && this.WorkType == other.WorkType && this.WorkId == other.WorkId && this.AssignDate == other.AssignDate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C03B RID: 114747 RVA: 0x007DEE48 File Offset: 0x007DD048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HelperIndex != 0)
			{
				num ^= this.HelperIndex.GetHashCode();
			}
			if (this.HelperId != 0)
			{
				num ^= this.HelperId.GetHashCode();
			}
			if (this.HelperSlotId != 0)
			{
				num ^= this.HelperSlotId.GetHashCode();
			}
			if (this.HelperName.Length != 0)
			{
				num ^= this.HelperName.GetHashCode();
			}
			if (this.avatarInfo_ != null)
			{
				num ^= this.AvatarInfo.GetHashCode();
			}
			if (this.WorkType != 0)
			{
				num ^= this.WorkType.GetHashCode();
			}
			if (this.WorkId != 0)
			{
				num ^= this.WorkId.GetHashCode();
			}
			if (this.AssignDate != 0L)
			{
				num ^= this.AssignDate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C03C RID: 114748 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C03D RID: 114749 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C03E RID: 114750 RVA: 0x007DEF38 File Offset: 0x007DD138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HelperIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HelperIndex);
			}
			if (this.HelperId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HelperId);
			}
			if (this.HelperSlotId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HelperSlotId);
			}
			if (this.HelperName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.HelperName);
			}
			if (this.avatarInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.AvatarInfo);
			}
			if (this.WorkType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WorkType);
			}
			if (this.WorkId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.WorkId);
			}
			if (this.AssignDate != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.AssignDate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C03F RID: 114751 RVA: 0x007DF040 File Offset: 0x007DD240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HelperIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HelperIndex);
			}
			if (this.HelperId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HelperId);
			}
			if (this.HelperSlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HelperSlotId);
			}
			if (this.HelperName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HelperName);
			}
			if (this.avatarInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AvatarInfo);
			}
			if (this.WorkType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorkType);
			}
			if (this.WorkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorkId);
			}
			if (this.AssignDate != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AssignDate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C040 RID: 114752 RVA: 0x007DF12C File Offset: 0x007DD32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeHelperDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HelperIndex != 0)
			{
				this.HelperIndex = other.HelperIndex;
			}
			if (other.HelperId != 0)
			{
				this.HelperId = other.HelperId;
			}
			if (other.HelperSlotId != 0)
			{
				this.HelperSlotId = other.HelperSlotId;
			}
			if (other.HelperName.Length != 0)
			{
				this.HelperName = other.HelperName;
			}
			if (other.avatarInfo_ != null)
			{
				if (this.avatarInfo_ == null)
				{
					this.AvatarInfo = new AvatarUseDBInfo();
				}
				this.AvatarInfo.MergeFrom(other.AvatarInfo);
			}
			if (other.WorkType != 0)
			{
				this.WorkType = other.WorkType;
			}
			if (other.WorkId != 0)
			{
				this.WorkId = other.WorkId;
			}
			if (other.AssignDate != 0L)
			{
				this.AssignDate = other.AssignDate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C041 RID: 114753 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C042 RID: 114754 RVA: 0x007DF214 File Offset: 0x007DD414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.HelperIndex = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.HelperId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.HelperSlotId = input.ReadInt32();
							continue;
						}
						if (num == 34U)
						{
							this.HelperName = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 42U)
					{
						if (this.avatarInfo_ == null)
						{
							this.AvatarInfo = new AvatarUseDBInfo();
						}
						input.ReadMessage(this.AvatarInfo);
						continue;
					}
					if (num == 48U)
					{
						this.WorkType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.WorkId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.AssignDate = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<LifeHelperDBInfo> _parser = new MessageParser<LifeHelperDBInfo>(() => new LifeHelperDBInfo());

		// Token: 0x04015862 RID: 88162
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015863 RID: 88163
		public const int HelperIndexFieldNumber = 1;

		// Token: 0x04015864 RID: 88164
		private int helperIndex_;

		// Token: 0x04015865 RID: 88165
		public const int HelperIdFieldNumber = 2;

		// Token: 0x04015866 RID: 88166
		private int helperId_;

		// Token: 0x04015867 RID: 88167
		public const int HelperSlotIdFieldNumber = 3;

		// Token: 0x04015868 RID: 88168
		private int helperSlotId_;

		// Token: 0x04015869 RID: 88169
		public const int HelperNameFieldNumber = 4;

		// Token: 0x0401586A RID: 88170
		private string helperName_ = "";

		// Token: 0x0401586B RID: 88171
		public const int AvatarInfoFieldNumber = 5;

		// Token: 0x0401586C RID: 88172
		private AvatarUseDBInfo avatarInfo_;

		// Token: 0x0401586D RID: 88173
		public const int WorkTypeFieldNumber = 6;

		// Token: 0x0401586E RID: 88174
		private int workType_;

		// Token: 0x0401586F RID: 88175
		public const int WorkIdFieldNumber = 7;

		// Token: 0x04015870 RID: 88176
		private int workId_;

		// Token: 0x04015871 RID: 88177
		public const int AssignDateFieldNumber = 8;

		// Token: 0x04015872 RID: 88178
		private long assignDate_;
	}
}
