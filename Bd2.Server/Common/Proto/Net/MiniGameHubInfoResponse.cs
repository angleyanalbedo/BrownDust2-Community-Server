using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020054A5 RID: 21669
	public sealed class MiniGameHubInfoResponse : IMessage<MiniGameHubInfoResponse>, IMessage, IEquatable<MiniGameHubInfoResponse>, IDeepCloneable<MiniGameHubInfoResponse>, IBufferMessage
	{
		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x06024320 RID: 148256 RVA: 0x0090451F File Offset: 0x0090271F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniGameHubInfoResponse> Parser
		{
			get
			{
				return MiniGameHubInfoResponse._parser;
			}
		}

		// Token: 0x1700506B RID: 20587
		// (get) Token: 0x06024321 RID: 148257 RVA: 0x00904526 File Offset: 0x00902726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniGameHubInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700506C RID: 20588
		// (get) Token: 0x06024322 RID: 148258 RVA: 0x00904538 File Offset: 0x00902738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniGameHubInfoResponse.Descriptor;
			}
		}

		// Token: 0x06024323 RID: 148259 RVA: 0x0090453F File Offset: 0x0090273F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameHubInfoResponse()
		{
		}

		// Token: 0x06024324 RID: 148260 RVA: 0x00904554 File Offset: 0x00902754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniGameHubInfoResponse(MiniGameHubInfoResponse other)
			: this()
		{
			this.miniGameHubInfo_ = other.miniGameHubInfo_.Clone();
			this.nextSettlementSchedule_ = ((other.nextSettlementSchedule_ != null) ? other.nextSettlementSchedule_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06024325 RID: 148261 RVA: 0x009045A5 File Offset: 0x009027A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameHubInfoResponse Clone()
		{
			return new MiniGameHubInfoResponse(this);
		}

		// Token: 0x1700506D RID: 20589
		// (get) Token: 0x06024326 RID: 148262 RVA: 0x009045AD File Offset: 0x009027AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MiniGameHubDBInfo> MiniGameHubInfo
		{
			get
			{
				return this.miniGameHubInfo_;
			}
		}

		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x06024327 RID: 148263 RVA: 0x009045B5 File Offset: 0x009027B5
		// (set) Token: 0x06024328 RID: 148264 RVA: 0x009045BD File Offset: 0x009027BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameRankingScheduleDBInfo NextSettlementSchedule
		{
			get
			{
				return this.nextSettlementSchedule_;
			}
			set
			{
				this.nextSettlementSchedule_ = value;
			}
		}

		// Token: 0x06024329 RID: 148265 RVA: 0x009045C6 File Offset: 0x009027C6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniGameHubInfoResponse);
		}

		// Token: 0x0602432A RID: 148266 RVA: 0x009045D4 File Offset: 0x009027D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(MiniGameHubInfoResponse other)
		{
			return other != null && (other == this || (this.miniGameHubInfo_.Equals(other.miniGameHubInfo_) && object.Equals(this.NextSettlementSchedule, other.NextSettlementSchedule) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0602432B RID: 148267 RVA: 0x00904628 File Offset: 0x00902828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.miniGameHubInfo_.GetHashCode();
			if (this.nextSettlementSchedule_ != null)
			{
				num ^= this.NextSettlementSchedule.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0602432C RID: 148268 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0602432D RID: 148269 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0602432E RID: 148270 RVA: 0x00904674 File Offset: 0x00902874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.miniGameHubInfo_.WriteTo(ref output, MiniGameHubInfoResponse._repeated_miniGameHubInfo_codec);
			if (this.nextSettlementSchedule_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NextSettlementSchedule);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0602432F RID: 148271 RVA: 0x009046C4 File Offset: 0x009028C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.miniGameHubInfo_.CalculateSize(MiniGameHubInfoResponse._repeated_miniGameHubInfo_codec);
			if (this.nextSettlementSchedule_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NextSettlementSchedule);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06024330 RID: 148272 RVA: 0x00904718 File Offset: 0x00902918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniGameHubInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.miniGameHubInfo_.Add(other.miniGameHubInfo_);
			if (other.nextSettlementSchedule_ != null)
			{
				if (this.nextSettlementSchedule_ == null)
				{
					this.NextSettlementSchedule = new MiniGameRankingScheduleDBInfo();
				}
				this.NextSettlementSchedule.MergeFrom(other.NextSettlementSchedule);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06024331 RID: 148273 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06024332 RID: 148274 RVA: 0x00904780 File Offset: 0x00902980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.nextSettlementSchedule_ == null)
						{
							this.NextSettlementSchedule = new MiniGameRankingScheduleDBInfo();
						}
						input.ReadMessage(this.NextSettlementSchedule);
					}
				}
				else
				{
					this.miniGameHubInfo_.AddEntriesFrom(ref input, MiniGameHubInfoResponse._repeated_miniGameHubInfo_codec);
				}
			}
		}
		private static readonly MessageParser<MiniGameHubInfoResponse> _parser = new MessageParser<MiniGameHubInfoResponse>(() => new MiniGameHubInfoResponse());

		// Token: 0x040189F8 RID: 100856
		private UnknownFieldSet _unknownFields;

		// Token: 0x040189F9 RID: 100857
		public const int MiniGameHubInfoFieldNumber = 1;

		// Token: 0x040189FA RID: 100858
		private static readonly FieldCodec<MiniGameHubDBInfo> _repeated_miniGameHubInfo_codec = FieldCodec.ForMessage<MiniGameHubDBInfo>(10U, MiniGameHubDBInfo.Parser);

		// Token: 0x040189FB RID: 100859
		private readonly RepeatedField<MiniGameHubDBInfo> miniGameHubInfo_ = new RepeatedField<MiniGameHubDBInfo>();

		// Token: 0x040189FC RID: 100860
		public const int NextSettlementScheduleFieldNumber = 2;

		// Token: 0x040189FD RID: 100861
		private MiniGameRankingScheduleDBInfo nextSettlementSchedule_;
	}
}
