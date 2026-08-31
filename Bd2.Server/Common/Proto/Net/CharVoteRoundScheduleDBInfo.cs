using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200505A RID: 20570
	public sealed class CharVoteRoundScheduleDBInfo : IMessage<CharVoteRoundScheduleDBInfo>, IMessage, IEquatable<CharVoteRoundScheduleDBInfo>, IDeepCloneable<CharVoteRoundScheduleDBInfo>, IBufferMessage
	{
		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x06021E8F RID: 138895 RVA: 0x008B50D5 File Offset: 0x008B32D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharVoteRoundScheduleDBInfo> Parser
		{
			get
			{
				return CharVoteRoundScheduleDBInfo._parser;
			}
		}

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x06021E90 RID: 138896 RVA: 0x008B50DC File Offset: 0x008B32DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharVoteInfoResponseReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x06021E91 RID: 138897 RVA: 0x008B50EE File Offset: 0x008B32EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharVoteRoundScheduleDBInfo.Descriptor;
			}
		}

		// Token: 0x06021E92 RID: 138898 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharVoteRoundScheduleDBInfo()
		{
		}

		// Token: 0x06021E93 RID: 138899 RVA: 0x008B50F5 File Offset: 0x008B32F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharVoteRoundScheduleDBInfo(CharVoteRoundScheduleDBInfo other)
			: this()
		{
			this.round_ = other.round_;
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06021E94 RID: 138900 RVA: 0x008B5132 File Offset: 0x008B3332
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharVoteRoundScheduleDBInfo Clone()
		{
			return new CharVoteRoundScheduleDBInfo(this);
		}

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x06021E95 RID: 138901 RVA: 0x008B513A File Offset: 0x008B333A
		// (set) Token: 0x06021E96 RID: 138902 RVA: 0x008B5142 File Offset: 0x008B3342
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Round
		{
			get
			{
				return this.round_;
			}
			set
			{
				this.round_ = value;
			}
		}

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x06021E97 RID: 138903 RVA: 0x008B514B File Offset: 0x008B334B
		// (set) Token: 0x06021E98 RID: 138904 RVA: 0x008B5153 File Offset: 0x008B3353
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x06021E99 RID: 138905 RVA: 0x008B515C File Offset: 0x008B335C
		// (set) Token: 0x06021E9A RID: 138906 RVA: 0x008B5164 File Offset: 0x008B3364
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

		// Token: 0x06021E9B RID: 138907 RVA: 0x008B516D File Offset: 0x008B336D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharVoteRoundScheduleDBInfo);
		}

		// Token: 0x06021E9C RID: 138908 RVA: 0x008B517C File Offset: 0x008B337C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(CharVoteRoundScheduleDBInfo other)
		{
			return other != null && (other == this || (this.Round == other.Round && this.StartTime == other.StartTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06021E9D RID: 138909 RVA: 0x008B51D8 File Offset: 0x008B33D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Round != 0)
			{
				num ^= this.Round.GetHashCode();
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

		// Token: 0x06021E9E RID: 138910 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06021E9F RID: 138911 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06021EA0 RID: 138912 RVA: 0x008B524C File Offset: 0x008B344C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Round != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Round);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06021EA1 RID: 138913 RVA: 0x008B52C0 File Offset: 0x008B34C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Round != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Round);
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

		// Token: 0x06021EA2 RID: 138914 RVA: 0x008B5330 File Offset: 0x008B3530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CharVoteRoundScheduleDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Round != 0)
			{
				this.Round = other.Round;
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

		// Token: 0x06021EA3 RID: 138915 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06021EA4 RID: 138916 RVA: 0x008B5394 File Offset: 0x008B3594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
							this.EndTime = input.ReadInt64();
						}
					}
					else
					{
						this.StartTime = input.ReadInt64();
					}
				}
				else
				{
					this.Round = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<CharVoteRoundScheduleDBInfo> _parser = new MessageParser<CharVoteRoundScheduleDBInfo>(() => new CharVoteRoundScheduleDBInfo());

		// Token: 0x04017D62 RID: 97634
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017D63 RID: 97635
		public const int RoundFieldNumber = 1;

		// Token: 0x04017D64 RID: 97636
		private int round_;

		// Token: 0x04017D65 RID: 97637
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04017D66 RID: 97638
		private long startTime_;

		// Token: 0x04017D67 RID: 97639
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04017D68 RID: 97640
		private long endTime_;
	}
}
