using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004758 RID: 18264
	public sealed class RoomChatReportUserDBInfo : IMessage<RoomChatReportUserDBInfo>, IMessage, IEquatable<RoomChatReportUserDBInfo>, IDeepCloneable<RoomChatReportUserDBInfo>, IBufferMessage
	{
		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0601CD13 RID: 118035 RVA: 0x00801DAD File Offset: 0x007FFFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoomChatReportUserDBInfo> Parser
		{
			get
			{
				return RoomChatReportUserDBInfo._parser;
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0601CD14 RID: 118036 RVA: 0x00801DB4 File Offset: 0x007FFFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RoomChatReportUserDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0601CD15 RID: 118037 RVA: 0x00801DC6 File Offset: 0x007FFFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoomChatReportUserDBInfo.Descriptor;
			}
		}

		// Token: 0x0601CD16 RID: 118038 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoomChatReportUserDBInfo()
		{
		}

		// Token: 0x0601CD17 RID: 118039 RVA: 0x00801DCD File Offset: 0x007FFFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoomChatReportUserDBInfo(RoomChatReportUserDBInfo other)
			: this()
		{
			this.reportCount_ = other.reportCount_;
			this.reportCountResetTime_ = other.reportCountResetTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD18 RID: 118040 RVA: 0x00801DFE File Offset: 0x007FFFFE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RoomChatReportUserDBInfo Clone()
		{
			return new RoomChatReportUserDBInfo(this);
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0601CD19 RID: 118041 RVA: 0x00801E06 File Offset: 0x00800006
		// (set) Token: 0x0601CD1A RID: 118042 RVA: 0x00801E0E File Offset: 0x0080000E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReportCount
		{
			get
			{
				return this.reportCount_;
			}
			set
			{
				this.reportCount_ = value;
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0601CD1B RID: 118043 RVA: 0x00801E17 File Offset: 0x00800017
		// (set) Token: 0x0601CD1C RID: 118044 RVA: 0x00801E1F File Offset: 0x0080001F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ReportCountResetTime
		{
			get
			{
				return this.reportCountResetTime_;
			}
			set
			{
				this.reportCountResetTime_ = value;
			}
		}

		// Token: 0x0601CD1D RID: 118045 RVA: 0x00801E28 File Offset: 0x00800028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoomChatReportUserDBInfo);
		}

		// Token: 0x0601CD1E RID: 118046 RVA: 0x00801E36 File Offset: 0x00800036
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(RoomChatReportUserDBInfo other)
		{
			return other != null && (other == this || (this.ReportCount == other.ReportCount && this.ReportCountResetTime == other.ReportCountResetTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD1F RID: 118047 RVA: 0x00801E74 File Offset: 0x00800074
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReportCount != 0)
			{
				num ^= this.ReportCount.GetHashCode();
			}
			if (this.ReportCountResetTime != 0L)
			{
				num ^= this.ReportCountResetTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CD20 RID: 118048 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601CD21 RID: 118049 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD22 RID: 118050 RVA: 0x00801ECC File Offset: 0x008000CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReportCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ReportCount);
			}
			if (this.ReportCountResetTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ReportCountResetTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CD23 RID: 118051 RVA: 0x00801F24 File Offset: 0x00800124
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReportCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReportCount);
			}
			if (this.ReportCountResetTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ReportCountResetTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CD24 RID: 118052 RVA: 0x00801F7C File Offset: 0x0080017C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoomChatReportUserDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReportCount != 0)
			{
				this.ReportCount = other.ReportCount;
			}
			if (other.ReportCountResetTime != 0L)
			{
				this.ReportCountResetTime = other.ReportCountResetTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CD25 RID: 118053 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD26 RID: 118054 RVA: 0x00801FCC File Offset: 0x008001CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReportCountResetTime = input.ReadInt64();
					}
				}
				else
				{
					this.ReportCount = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<RoomChatReportUserDBInfo> _parser = new MessageParser<RoomChatReportUserDBInfo>(() => new RoomChatReportUserDBInfo());

		// Token: 0x0401605D RID: 90205
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401605E RID: 90206
		public const int ReportCountFieldNumber = 1;

		// Token: 0x0401605F RID: 90207
		private int reportCount_;

		// Token: 0x04016060 RID: 90208
		public const int ReportCountResetTimeFieldNumber = 2;

		// Token: 0x04016061 RID: 90209
		private long reportCountResetTime_;
	}
}
