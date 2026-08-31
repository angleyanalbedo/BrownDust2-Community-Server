using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200527D RID: 21117
	public sealed class FishingTrapInfoResponse : IMessage<FishingTrapInfoResponse>, IMessage, IEquatable<FishingTrapInfoResponse>, IDeepCloneable<FishingTrapInfoResponse>, IBufferMessage
	{
		// Token: 0x17004C31 RID: 19505
		// (get) Token: 0x060230FC RID: 143612 RVA: 0x008DE817 File Offset: 0x008DCA17
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingTrapInfoResponse> Parser
		{
			get
			{
				return FishingTrapInfoResponse._parser;
			}
		}

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x060230FD RID: 143613 RVA: 0x008DE81E File Offset: 0x008DCA1E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingTrapInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x060230FE RID: 143614 RVA: 0x008DE830 File Offset: 0x008DCA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTrapInfoResponse.Descriptor;
			}
		}

		// Token: 0x060230FF RID: 143615 RVA: 0x008DE837 File Offset: 0x008DCA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTrapInfoResponse()
		{
		}

		// Token: 0x06023100 RID: 143616 RVA: 0x008DE84C File Offset: 0x008DCA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTrapInfoResponse(FishingTrapInfoResponse other)
			: this()
		{
			this.trapRewardReceiptTime_ = other.trapRewardReceiptTime_;
			this.fishTrapInfo_ = other.fishTrapInfo_.Clone();
			this.totalAddExp_ = other.totalAddExp_;
			this.afterLevel_ = other.afterLevel_;
			this.afterExp_ = other.afterExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06023101 RID: 143617 RVA: 0x008DE8B1 File Offset: 0x008DCAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTrapInfoResponse Clone()
		{
			return new FishingTrapInfoResponse(this);
		}

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x06023102 RID: 143618 RVA: 0x008DE8B9 File Offset: 0x008DCAB9
		// (set) Token: 0x06023103 RID: 143619 RVA: 0x008DE8C1 File Offset: 0x008DCAC1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TrapRewardReceiptTime
		{
			get
			{
				return this.trapRewardReceiptTime_;
			}
			set
			{
				this.trapRewardReceiptTime_ = value;
			}
		}

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x06023104 RID: 143620 RVA: 0x008DE8CA File Offset: 0x008DCACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingTrapDBInfo> FishTrapInfo
		{
			get
			{
				return this.fishTrapInfo_;
			}
		}

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x06023105 RID: 143621 RVA: 0x008DE8D2 File Offset: 0x008DCAD2
		// (set) Token: 0x06023106 RID: 143622 RVA: 0x008DE8DA File Offset: 0x008DCADA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TotalAddExp
		{
			get
			{
				return this.totalAddExp_;
			}
			set
			{
				this.totalAddExp_ = value;
			}
		}

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x06023107 RID: 143623 RVA: 0x008DE8E3 File Offset: 0x008DCAE3
		// (set) Token: 0x06023108 RID: 143624 RVA: 0x008DE8EB File Offset: 0x008DCAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterLevel
		{
			get
			{
				return this.afterLevel_;
			}
			set
			{
				this.afterLevel_ = value;
			}
		}

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x06023109 RID: 143625 RVA: 0x008DE8F4 File Offset: 0x008DCAF4
		// (set) Token: 0x0602310A RID: 143626 RVA: 0x008DE8FC File Offset: 0x008DCAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterExp
		{
			get
			{
				return this.afterExp_;
			}
			set
			{
				this.afterExp_ = value;
			}
		}

		// Token: 0x0602310B RID: 143627 RVA: 0x008DE905 File Offset: 0x008DCB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTrapInfoResponse);
		}

		// Token: 0x0602310C RID: 143628 RVA: 0x008DE914 File Offset: 0x008DCB14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingTrapInfoResponse other)
		{
			return other != null && (other == this || (this.TrapRewardReceiptTime == other.TrapRewardReceiptTime && this.fishTrapInfo_.Equals(other.fishTrapInfo_) && this.TotalAddExp == other.TotalAddExp && this.AfterLevel == other.AfterLevel && this.AfterExp == other.AfterExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0602310D RID: 143629 RVA: 0x008DE994 File Offset: 0x008DCB94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrapRewardReceiptTime != 0L)
			{
				num ^= this.TrapRewardReceiptTime.GetHashCode();
			}
			num ^= this.fishTrapInfo_.GetHashCode();
			if (this.TotalAddExp != 0)
			{
				num ^= this.TotalAddExp.GetHashCode();
			}
			if (this.AfterLevel != 0)
			{
				num ^= this.AfterLevel.GetHashCode();
			}
			if (this.AfterExp != 0)
			{
				num ^= this.AfterExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0602310E RID: 143630 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0602310F RID: 143631 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06023110 RID: 143632 RVA: 0x008DEA2C File Offset: 0x008DCC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrapRewardReceiptTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TrapRewardReceiptTime);
			}
			this.fishTrapInfo_.WriteTo(ref output, FishingTrapInfoResponse._repeated_fishTrapInfo_codec);
			if (this.TotalAddExp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalAddExp);
			}
			if (this.AfterLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AfterLevel);
			}
			if (this.AfterExp != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AfterExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06023111 RID: 143633 RVA: 0x008DEAD0 File Offset: 0x008DCCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrapRewardReceiptTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TrapRewardReceiptTime);
			}
			num += this.fishTrapInfo_.CalculateSize(FishingTrapInfoResponse._repeated_fishTrapInfo_codec);
			if (this.TotalAddExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalAddExp);
			}
			if (this.AfterLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterLevel);
			}
			if (this.AfterExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06023112 RID: 143634 RVA: 0x008DEB6C File Offset: 0x008DCD6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingTrapInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrapRewardReceiptTime != 0L)
			{
				this.TrapRewardReceiptTime = other.TrapRewardReceiptTime;
			}
			this.fishTrapInfo_.Add(other.fishTrapInfo_);
			if (other.TotalAddExp != 0)
			{
				this.TotalAddExp = other.TotalAddExp;
			}
			if (other.AfterLevel != 0)
			{
				this.AfterLevel = other.AfterLevel;
			}
			if (other.AfterExp != 0)
			{
				this.AfterExp = other.AfterExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023113 RID: 143635 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06023114 RID: 143636 RVA: 0x008DEBF8 File Offset: 0x008DCDF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.TrapRewardReceiptTime = input.ReadInt64();
						continue;
					}
					if (num == 18U)
					{
						this.fishTrapInfo_.AddEntriesFrom(ref input, FishingTrapInfoResponse._repeated_fishTrapInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TotalAddExp = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.AfterLevel = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.AfterExp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<FishingTrapInfoResponse> _parser = new MessageParser<FishingTrapInfoResponse>(() => new FishingTrapInfoResponse());

		// Token: 0x040183EE RID: 99310
		private UnknownFieldSet _unknownFields;

		// Token: 0x040183EF RID: 99311
		public const int TrapRewardReceiptTimeFieldNumber = 1;

		// Token: 0x040183F0 RID: 99312
		private long trapRewardReceiptTime_;

		// Token: 0x040183F1 RID: 99313
		public const int FishTrapInfoFieldNumber = 2;

		// Token: 0x040183F2 RID: 99314
		private static readonly FieldCodec<FishingTrapDBInfo> _repeated_fishTrapInfo_codec = FieldCodec.ForMessage<FishingTrapDBInfo>(18U, FishingTrapDBInfo.Parser);

		// Token: 0x040183F3 RID: 99315
		private readonly RepeatedField<FishingTrapDBInfo> fishTrapInfo_ = new RepeatedField<FishingTrapDBInfo>();

		// Token: 0x040183F4 RID: 99316
		public const int TotalAddExpFieldNumber = 3;

		// Token: 0x040183F5 RID: 99317
		private int totalAddExp_;

		// Token: 0x040183F6 RID: 99318
		public const int AfterLevelFieldNumber = 4;

		// Token: 0x040183F7 RID: 99319
		private int afterLevel_;

		// Token: 0x040183F8 RID: 99320
		public const int AfterExpFieldNumber = 5;

		// Token: 0x040183F9 RID: 99321
		private int afterExp_;
	}
}
