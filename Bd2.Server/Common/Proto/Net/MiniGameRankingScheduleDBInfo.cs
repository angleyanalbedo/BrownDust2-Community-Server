using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004666 RID: 18022
	public sealed class MiniGameRankingScheduleDBInfo : IMessage<MiniGameRankingScheduleDBInfo>, IMessage, IEquatable<MiniGameRankingScheduleDBInfo>, IDeepCloneable<MiniGameRankingScheduleDBInfo>, IBufferMessage
	{
		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0601C3D6 RID: 115670 RVA: 0x007E87A5 File Offset: 0x007E69A5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MiniGameRankingScheduleDBInfo> Parser
		{
			get
			{
				return MiniGameRankingScheduleDBInfo._parser;
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0601C3D7 RID: 115671 RVA: 0x007E87AC File Offset: 0x007E69AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniGameRankingScheduleDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0601C3D8 RID: 115672 RVA: 0x007E87BE File Offset: 0x007E69BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniGameRankingScheduleDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C3D9 RID: 115673 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameRankingScheduleDBInfo()
		{
		}

		// Token: 0x0601C3DA RID: 115674 RVA: 0x007E87C8 File Offset: 0x007E69C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameRankingScheduleDBInfo(MiniGameRankingScheduleDBInfo other)
			: this()
		{
			this.id_ = other.id_;
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this.calculateEndTime_ = other.calculateEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3DB RID: 115675 RVA: 0x007E881C File Offset: 0x007E6A1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniGameRankingScheduleDBInfo Clone()
		{
			return new MiniGameRankingScheduleDBInfo(this);
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0601C3DC RID: 115676 RVA: 0x007E8824 File Offset: 0x007E6A24
		// (set) Token: 0x0601C3DD RID: 115677 RVA: 0x007E882C File Offset: 0x007E6A2C
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

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0601C3DE RID: 115678 RVA: 0x007E8835 File Offset: 0x007E6A35
		// (set) Token: 0x0601C3DF RID: 115679 RVA: 0x007E883D File Offset: 0x007E6A3D
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

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0601C3E0 RID: 115680 RVA: 0x007E8846 File Offset: 0x007E6A46
		// (set) Token: 0x0601C3E1 RID: 115681 RVA: 0x007E884E File Offset: 0x007E6A4E
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

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0601C3E2 RID: 115682 RVA: 0x007E8857 File Offset: 0x007E6A57
		// (set) Token: 0x0601C3E3 RID: 115683 RVA: 0x007E885F File Offset: 0x007E6A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CalculateEndTime
		{
			get
			{
				return this.calculateEndTime_;
			}
			set
			{
				this.calculateEndTime_ = value;
			}
		}

		// Token: 0x0601C3E4 RID: 115684 RVA: 0x007E8868 File Offset: 0x007E6A68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniGameRankingScheduleDBInfo);
		}

		// Token: 0x0601C3E5 RID: 115685 RVA: 0x007E8878 File Offset: 0x007E6A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(MiniGameRankingScheduleDBInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.StartTime == other.StartTime && this.EndTime == other.EndTime && this.CalculateEndTime == other.CalculateEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3E6 RID: 115686 RVA: 0x007E88E4 File Offset: 0x007E6AE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.CalculateEndTime != 0L)
			{
				num ^= this.CalculateEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C3E7 RID: 115687 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C3E8 RID: 115688 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3E9 RID: 115689 RVA: 0x007E8970 File Offset: 0x007E6B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
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
			if (this.CalculateEndTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CalculateEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3EA RID: 115690 RVA: 0x007E8A00 File Offset: 0x007E6C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.CalculateEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CalculateEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C3EB RID: 115691 RVA: 0x007E8A88 File Offset: 0x007E6C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniGameRankingScheduleDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.CalculateEndTime != 0L)
			{
				this.CalculateEndTime = other.CalculateEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C3EC RID: 115692 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3ED RID: 115693 RVA: 0x007E8B00 File Offset: 0x007E6D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.CalculateEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<MiniGameRankingScheduleDBInfo> _parser = new MessageParser<MiniGameRankingScheduleDBInfo>(() => new MiniGameRankingScheduleDBInfo());

		// Token: 0x040159EC RID: 88556
		private UnknownFieldSet _unknownFields;

		// Token: 0x040159ED RID: 88557
		public const int IdFieldNumber = 1;

		// Token: 0x040159EE RID: 88558
		private int id_;

		// Token: 0x040159EF RID: 88559
		public const int StartTimeFieldNumber = 2;

		// Token: 0x040159F0 RID: 88560
		private long startTime_;

		// Token: 0x040159F1 RID: 88561
		public const int EndTimeFieldNumber = 3;

		// Token: 0x040159F2 RID: 88562
		private long endTime_;

		// Token: 0x040159F3 RID: 88563
		public const int CalculateEndTimeFieldNumber = 4;

		// Token: 0x040159F4 RID: 88564
		private long calculateEndTime_;
	}
}
