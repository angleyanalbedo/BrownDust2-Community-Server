using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005638 RID: 22072
	public sealed class RoomChatReportAndBlockInfoResponse : IMessage<RoomChatReportAndBlockInfoResponse>, IMessage, IEquatable<RoomChatReportAndBlockInfoResponse>, IDeepCloneable<RoomChatReportAndBlockInfoResponse>, IBufferMessage
	{
		// Token: 0x170053C1 RID: 21441
		// (get) Token: 0x060250BA RID: 151738 RVA: 0x009238E8 File Offset: 0x00921AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoomChatReportAndBlockInfoResponse> Parser
		{
			get
			{
				return RoomChatReportAndBlockInfoResponse._parser;
			}
		}

		// Token: 0x170053C2 RID: 21442
		// (get) Token: 0x060250BB RID: 151739 RVA: 0x009238EF File Offset: 0x00921AEF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RoomChatReportAndBlockInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170053C3 RID: 21443
		// (get) Token: 0x060250BC RID: 151740 RVA: 0x00923901 File Offset: 0x00921B01
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoomChatReportAndBlockInfoResponse.Descriptor;
			}
		}

		// Token: 0x060250BD RID: 151741 RVA: 0x00923908 File Offset: 0x00921B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoomChatReportAndBlockInfoResponse()
		{
		}

		// Token: 0x060250BE RID: 151742 RVA: 0x0092391C File Offset: 0x00921B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoomChatReportAndBlockInfoResponse(RoomChatReportAndBlockInfoResponse other)
			: this()
		{
			this.chatBlockInfo_ = other.chatBlockInfo_.Clone();
			this.reportUserInfo_ = ((other.reportUserInfo_ != null) ? other.reportUserInfo_.Clone() : null);
			this.penaltyInfo_ = ((other.penaltyInfo_ != null) ? other.penaltyInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060250BF RID: 151743 RVA: 0x00923989 File Offset: 0x00921B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoomChatReportAndBlockInfoResponse Clone()
		{
			return new RoomChatReportAndBlockInfoResponse(this);
		}

		// Token: 0x170053C4 RID: 21444
		// (get) Token: 0x060250C0 RID: 151744 RVA: 0x00923991 File Offset: 0x00921B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoomChatBlockDBInfo> ChatBlockInfo
		{
			get
			{
				return this.chatBlockInfo_;
			}
		}

		// Token: 0x170053C5 RID: 21445
		// (get) Token: 0x060250C1 RID: 151745 RVA: 0x00923999 File Offset: 0x00921B99
		// (set) Token: 0x060250C2 RID: 151746 RVA: 0x009239A1 File Offset: 0x00921BA1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RoomChatReportUserDBInfo ReportUserInfo
		{
			get
			{
				return this.reportUserInfo_;
			}
			set
			{
				this.reportUserInfo_ = value;
			}
		}

		// Token: 0x170053C6 RID: 21446
		// (get) Token: 0x060250C3 RID: 151747 RVA: 0x009239AA File Offset: 0x00921BAA
		// (set) Token: 0x060250C4 RID: 151748 RVA: 0x009239B2 File Offset: 0x00921BB2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RoomChatPenaltyDBInfo PenaltyInfo
		{
			get
			{
				return this.penaltyInfo_;
			}
			set
			{
				this.penaltyInfo_ = value;
			}
		}

		// Token: 0x060250C5 RID: 151749 RVA: 0x009239BB File Offset: 0x00921BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoomChatReportAndBlockInfoResponse);
		}

		// Token: 0x060250C6 RID: 151750 RVA: 0x009239CC File Offset: 0x00921BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoomChatReportAndBlockInfoResponse other)
		{
			return other != null && (other == this || (this.chatBlockInfo_.Equals(other.chatBlockInfo_) && object.Equals(this.ReportUserInfo, other.ReportUserInfo) && object.Equals(this.PenaltyInfo, other.PenaltyInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060250C7 RID: 151751 RVA: 0x00923A34 File Offset: 0x00921C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chatBlockInfo_.GetHashCode();
			if (this.reportUserInfo_ != null)
			{
				num ^= this.ReportUserInfo.GetHashCode();
			}
			if (this.penaltyInfo_ != null)
			{
				num ^= this.PenaltyInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060250C8 RID: 151752 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060250C9 RID: 151753 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060250CA RID: 151754 RVA: 0x00923A94 File Offset: 0x00921C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chatBlockInfo_.WriteTo(ref output, RoomChatReportAndBlockInfoResponse._repeated_chatBlockInfo_codec);
			if (this.reportUserInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ReportUserInfo);
			}
			if (this.penaltyInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PenaltyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060250CB RID: 151755 RVA: 0x00923B00 File Offset: 0x00921D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chatBlockInfo_.CalculateSize(RoomChatReportAndBlockInfoResponse._repeated_chatBlockInfo_codec);
			if (this.reportUserInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReportUserInfo);
			}
			if (this.penaltyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PenaltyInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060250CC RID: 151756 RVA: 0x00923B6C File Offset: 0x00921D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoomChatReportAndBlockInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.chatBlockInfo_.Add(other.chatBlockInfo_);
			if (other.reportUserInfo_ != null)
			{
				if (this.reportUserInfo_ == null)
				{
					this.ReportUserInfo = new RoomChatReportUserDBInfo();
				}
				this.ReportUserInfo.MergeFrom(other.ReportUserInfo);
			}
			if (other.penaltyInfo_ != null)
			{
				if (this.penaltyInfo_ == null)
				{
					this.PenaltyInfo = new RoomChatPenaltyDBInfo();
				}
				this.PenaltyInfo.MergeFrom(other.PenaltyInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060250CD RID: 151757 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060250CE RID: 151758 RVA: 0x00923C00 File Offset: 0x00921E00
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.penaltyInfo_ == null)
							{
								this.PenaltyInfo = new RoomChatPenaltyDBInfo();
							}
							input.ReadMessage(this.PenaltyInfo);
						}
					}
					else
					{
						if (this.reportUserInfo_ == null)
						{
							this.ReportUserInfo = new RoomChatReportUserDBInfo();
						}
						input.ReadMessage(this.ReportUserInfo);
					}
				}
				else
				{
					this.chatBlockInfo_.AddEntriesFrom(ref input, RoomChatReportAndBlockInfoResponse._repeated_chatBlockInfo_codec);
				}
			}
		}
		private static readonly MessageParser<RoomChatReportAndBlockInfoResponse> _parser = new MessageParser<RoomChatReportAndBlockInfoResponse>(() => new RoomChatReportAndBlockInfoResponse());

		// Token: 0x04018F0F RID: 102159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018F10 RID: 102160
		public const int ChatBlockInfoFieldNumber = 1;

		// Token: 0x04018F11 RID: 102161
		private static readonly FieldCodec<RoomChatBlockDBInfo> _repeated_chatBlockInfo_codec = FieldCodec.ForMessage<RoomChatBlockDBInfo>(10U, RoomChatBlockDBInfo.Parser);

		// Token: 0x04018F12 RID: 102162
		private readonly RepeatedField<RoomChatBlockDBInfo> chatBlockInfo_ = new RepeatedField<RoomChatBlockDBInfo>();

		// Token: 0x04018F13 RID: 102163
		public const int ReportUserInfoFieldNumber = 2;

		// Token: 0x04018F14 RID: 102164
		private RoomChatReportUserDBInfo reportUserInfo_;

		// Token: 0x04018F15 RID: 102165
		public const int PenaltyInfoFieldNumber = 3;

		// Token: 0x04018F16 RID: 102166
		private RoomChatPenaltyDBInfo penaltyInfo_;
	}
}
