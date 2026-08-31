using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004755 RID: 18261
	public sealed class RoomChatPenaltyDBInfo : IMessage<RoomChatPenaltyDBInfo>, IMessage, IEquatable<RoomChatPenaltyDBInfo>, IDeepCloneable<RoomChatPenaltyDBInfo>, IBufferMessage
	{
		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0601CCF7 RID: 118007 RVA: 0x008019D9 File Offset: 0x007FFBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoomChatPenaltyDBInfo> Parser
		{
			get
			{
				return RoomChatPenaltyDBInfo._parser;
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0601CCF8 RID: 118008 RVA: 0x008019E0 File Offset: 0x007FFBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RoomChatPenaltyDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0601CCF9 RID: 118009 RVA: 0x008019F2 File Offset: 0x007FFBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoomChatPenaltyDBInfo.Descriptor;
			}
		}

		// Token: 0x0601CCFA RID: 118010 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RoomChatPenaltyDBInfo()
		{
		}

		// Token: 0x0601CCFB RID: 118011 RVA: 0x008019F9 File Offset: 0x007FFBF9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RoomChatPenaltyDBInfo(RoomChatPenaltyDBInfo other)
			: this()
		{
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this.reportId_ = other.reportId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CCFC RID: 118012 RVA: 0x00801A36 File Offset: 0x007FFC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoomChatPenaltyDBInfo Clone()
		{
			return new RoomChatPenaltyDBInfo(this);
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0601CCFD RID: 118013 RVA: 0x00801A3E File Offset: 0x007FFC3E
		// (set) Token: 0x0601CCFE RID: 118014 RVA: 0x00801A46 File Offset: 0x007FFC46
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

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0601CCFF RID: 118015 RVA: 0x00801A4F File Offset: 0x007FFC4F
		// (set) Token: 0x0601CD00 RID: 118016 RVA: 0x00801A57 File Offset: 0x007FFC57
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0601CD01 RID: 118017 RVA: 0x00801A60 File Offset: 0x007FFC60
		// (set) Token: 0x0601CD02 RID: 118018 RVA: 0x00801A68 File Offset: 0x007FFC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReportId
		{
			get
			{
				return this.reportId_;
			}
			set
			{
				this.reportId_ = value;
			}
		}

		// Token: 0x0601CD03 RID: 118019 RVA: 0x00801A71 File Offset: 0x007FFC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoomChatPenaltyDBInfo);
		}

		// Token: 0x0601CD04 RID: 118020 RVA: 0x00801A80 File Offset: 0x007FFC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoomChatPenaltyDBInfo other)
		{
			return other != null && (other == this || (this.StartTime == other.StartTime && this.EndTime == other.EndTime && this.ReportId == other.ReportId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD05 RID: 118021 RVA: 0x00801ADC File Offset: 0x007FFCDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.ReportId != 0)
			{
				num ^= this.ReportId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CD06 RID: 118022 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601CD07 RID: 118023 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD08 RID: 118024 RVA: 0x00801B50 File Offset: 0x007FFD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EndTime);
			}
			if (this.ReportId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ReportId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CD09 RID: 118025 RVA: 0x00801BC4 File Offset: 0x007FFDC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.ReportId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReportId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CD0A RID: 118026 RVA: 0x00801C34 File Offset: 0x007FFE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoomChatPenaltyDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.ReportId != 0)
			{
				this.ReportId = other.ReportId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CD0B RID: 118027 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD0C RID: 118028 RVA: 0x00801C98 File Offset: 0x007FFE98
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ReportId = input.ReadInt32();
						}
					}
					else
					{
						this.EndTime = input.ReadInt64();
					}
				}
				else
				{
					this.StartTime = input.ReadInt64();
				}
			}
		}
		private static readonly MessageParser<RoomChatPenaltyDBInfo> _parser = new MessageParser<RoomChatPenaltyDBInfo>(() => new RoomChatPenaltyDBInfo());

		// Token: 0x04016053 RID: 90195
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016054 RID: 90196
		public const int StartTimeFieldNumber = 1;

		// Token: 0x04016055 RID: 90197
		private long startTime_;

		// Token: 0x04016056 RID: 90198
		public const int EndTimeFieldNumber = 2;

		// Token: 0x04016057 RID: 90199
		private long endTime_;

		// Token: 0x04016058 RID: 90200
		public const int ReportIdFieldNumber = 3;

		// Token: 0x04016059 RID: 90201
		private int reportId_;
	}
}
