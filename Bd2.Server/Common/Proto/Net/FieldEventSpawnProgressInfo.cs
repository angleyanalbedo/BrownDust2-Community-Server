using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004556 RID: 17750
	public sealed class FieldEventSpawnProgressInfo : IMessage<FieldEventSpawnProgressInfo>, IMessage, IEquatable<FieldEventSpawnProgressInfo>, IDeepCloneable<FieldEventSpawnProgressInfo>, IBufferMessage
	{
		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0601B88D RID: 112781 RVA: 0x007C9E83 File Offset: 0x007C8083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldEventSpawnProgressInfo> Parser
		{
			get
			{
				return FieldEventSpawnProgressInfo._parser;
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0601B88E RID: 112782 RVA: 0x007C9E8A File Offset: 0x007C808A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldEventSpawnProgressInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0601B88F RID: 112783 RVA: 0x007C9E9C File Offset: 0x007C809C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldEventSpawnProgressInfo.Descriptor;
			}
		}

		// Token: 0x0601B890 RID: 112784 RVA: 0x007C9EA3 File Offset: 0x007C80A3
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FieldEventSpawnProgressInfo()
		{
		}

		// Token: 0x0601B891 RID: 112785 RVA: 0x007C9EB8 File Offset: 0x007C80B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldEventSpawnProgressInfo(FieldEventSpawnProgressInfo other)
			: this()
		{
			this.startTime_ = other.startTime_;
			this.eventScheduleId_ = other.eventScheduleId_;
			this.spawnEventId_ = other.spawnEventId_;
			this.groupId_ = other.groupId_;
			this.caughtInfo_ = other.caughtInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B892 RID: 112786 RVA: 0x007C9F1D File Offset: 0x007C811D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FieldEventSpawnProgressInfo Clone()
		{
			return new FieldEventSpawnProgressInfo(this);
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0601B893 RID: 112787 RVA: 0x007C9F25 File Offset: 0x007C8125
		// (set) Token: 0x0601B894 RID: 112788 RVA: 0x007C9F2D File Offset: 0x007C812D
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

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0601B895 RID: 112789 RVA: 0x007C9F36 File Offset: 0x007C8136
		// (set) Token: 0x0601B896 RID: 112790 RVA: 0x007C9F3E File Offset: 0x007C813E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventScheduleId
		{
			get
			{
				return this.eventScheduleId_;
			}
			set
			{
				this.eventScheduleId_ = value;
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0601B897 RID: 112791 RVA: 0x007C9F47 File Offset: 0x007C8147
		// (set) Token: 0x0601B898 RID: 112792 RVA: 0x007C9F4F File Offset: 0x007C814F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpawnEventId
		{
			get
			{
				return this.spawnEventId_;
			}
			set
			{
				this.spawnEventId_ = value;
			}
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0601B899 RID: 112793 RVA: 0x007C9F58 File Offset: 0x007C8158
		// (set) Token: 0x0601B89A RID: 112794 RVA: 0x007C9F60 File Offset: 0x007C8160
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0601B89B RID: 112795 RVA: 0x007C9F69 File Offset: 0x007C8169
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FieldEventSpawnCaughtInfo> CaughtInfo
		{
			get
			{
				return this.caughtInfo_;
			}
		}

		// Token: 0x0601B89C RID: 112796 RVA: 0x007C9F71 File Offset: 0x007C8171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldEventSpawnProgressInfo);
		}

		// Token: 0x0601B89D RID: 112797 RVA: 0x007C9F80 File Offset: 0x007C8180
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FieldEventSpawnProgressInfo other)
		{
			return other != null && (other == this || (this.StartTime == other.StartTime && this.EventScheduleId == other.EventScheduleId && this.SpawnEventId == other.SpawnEventId && this.GroupId == other.GroupId && this.caughtInfo_.Equals(other.caughtInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B89E RID: 112798 RVA: 0x007CA000 File Offset: 0x007C8200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.EventScheduleId != 0)
			{
				num ^= this.EventScheduleId.GetHashCode();
			}
			if (this.SpawnEventId != 0)
			{
				num ^= this.SpawnEventId.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			num ^= this.caughtInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B89F RID: 112799 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B8A0 RID: 112800 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8A1 RID: 112801 RVA: 0x007CA098 File Offset: 0x007C8298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.StartTime);
			}
			if (this.EventScheduleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventScheduleId);
			}
			if (this.SpawnEventId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SpawnEventId);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GroupId);
			}
			this.caughtInfo_.WriteTo(ref output, FieldEventSpawnProgressInfo._repeated_caughtInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B8A2 RID: 112802 RVA: 0x007CA13C File Offset: 0x007C833C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.EventScheduleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventScheduleId);
			}
			if (this.SpawnEventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnEventId);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			num += this.caughtInfo_.CalculateSize(FieldEventSpawnProgressInfo._repeated_caughtInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B8A3 RID: 112803 RVA: 0x007CA1D8 File Offset: 0x007C83D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FieldEventSpawnProgressInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.EventScheduleId != 0)
			{
				this.EventScheduleId = other.EventScheduleId;
			}
			if (other.SpawnEventId != 0)
			{
				this.SpawnEventId = other.SpawnEventId;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			this.caughtInfo_.Add(other.caughtInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B8A4 RID: 112804 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8A5 RID: 112805 RVA: 0x007CA264 File Offset: 0x007C8464
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
						this.StartTime = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.EventScheduleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.SpawnEventId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.caughtInfo_.AddEntriesFrom(ref input, FieldEventSpawnProgressInfo._repeated_caughtInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<FieldEventSpawnProgressInfo> _parser = new MessageParser<FieldEventSpawnProgressInfo>(() => new FieldEventSpawnProgressInfo());

		// Token: 0x040154FF RID: 87295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015500 RID: 87296
		public const int StartTimeFieldNumber = 1;

		// Token: 0x04015501 RID: 87297
		private long startTime_;

		// Token: 0x04015502 RID: 87298
		public const int EventScheduleIdFieldNumber = 2;

		// Token: 0x04015503 RID: 87299
		private int eventScheduleId_;

		// Token: 0x04015504 RID: 87300
		public const int SpawnEventIdFieldNumber = 3;

		// Token: 0x04015505 RID: 87301
		private int spawnEventId_;

		// Token: 0x04015506 RID: 87302
		public const int GroupIdFieldNumber = 4;

		// Token: 0x04015507 RID: 87303
		private int groupId_;

		// Token: 0x04015508 RID: 87304
		public const int CaughtInfoFieldNumber = 5;

		// Token: 0x04015509 RID: 87305
		private static readonly FieldCodec<FieldEventSpawnCaughtInfo> _repeated_caughtInfo_codec = FieldCodec.ForMessage<FieldEventSpawnCaughtInfo>(42U, FieldEventSpawnCaughtInfo.Parser);

		// Token: 0x0401550A RID: 87306
		private readonly RepeatedField<FieldEventSpawnCaughtInfo> caughtInfo_ = new RepeatedField<FieldEventSpawnCaughtInfo>();
	}
}
