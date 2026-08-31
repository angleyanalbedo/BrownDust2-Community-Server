using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200443A RID: 17466
	public sealed class DatingEpisodeDBInfo : IMessage<DatingEpisodeDBInfo>, IMessage, IEquatable<DatingEpisodeDBInfo>, IDeepCloneable<DatingEpisodeDBInfo>, IBufferMessage
	{
		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x0601B3BA RID: 111546 RVA: 0x007BA937 File Offset: 0x007B8B37
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DatingEpisodeDBInfo> Parser
		{
			get
			{
				return DatingEpisodeDBInfo._parser;
			}
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x0601B3BB RID: 111547 RVA: 0x007BA93E File Offset: 0x007B8B3E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DatingEpisodeDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x0601B3BC RID: 111548 RVA: 0x007BA950 File Offset: 0x007B8B50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DatingEpisodeDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B3BD RID: 111549 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingEpisodeDBInfo()
		{
		}

		// Token: 0x0601B3BE RID: 111550 RVA: 0x007BA958 File Offset: 0x007B8B58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DatingEpisodeDBInfo(DatingEpisodeDBInfo other)
			: this()
		{
			this.groupId_ = other.groupId_;
			this.datingPoint_ = other.datingPoint_;
			this.lastClearId_ = other.lastClearId_;
			this.lastMessageGroupId_ = other.lastMessageGroupId_;
			this.lastMessageId_ = other.lastMessageId_;
			this.lastMessageUpdateTime_ = other.lastMessageUpdateTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3BF RID: 111551 RVA: 0x007BA9C4 File Offset: 0x007B8BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingEpisodeDBInfo Clone()
		{
			return new DatingEpisodeDBInfo(this);
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x0601B3C0 RID: 111552 RVA: 0x007BA9CC File Offset: 0x007B8BCC
		// (set) Token: 0x0601B3C1 RID: 111553 RVA: 0x007BA9D4 File Offset: 0x007B8BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x0601B3C2 RID: 111554 RVA: 0x007BA9DD File Offset: 0x007B8BDD
		// (set) Token: 0x0601B3C3 RID: 111555 RVA: 0x007BA9E5 File Offset: 0x007B8BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DatingPoint
		{
			get
			{
				return this.datingPoint_;
			}
			set
			{
				this.datingPoint_ = value;
			}
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x0601B3C4 RID: 111556 RVA: 0x007BA9EE File Offset: 0x007B8BEE
		// (set) Token: 0x0601B3C5 RID: 111557 RVA: 0x007BA9F6 File Offset: 0x007B8BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastClearId
		{
			get
			{
				return this.lastClearId_;
			}
			set
			{
				this.lastClearId_ = value;
			}
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x0601B3C6 RID: 111558 RVA: 0x007BA9FF File Offset: 0x007B8BFF
		// (set) Token: 0x0601B3C7 RID: 111559 RVA: 0x007BAA07 File Offset: 0x007B8C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastMessageGroupId
		{
			get
			{
				return this.lastMessageGroupId_;
			}
			set
			{
				this.lastMessageGroupId_ = value;
			}
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x0601B3C8 RID: 111560 RVA: 0x007BAA10 File Offset: 0x007B8C10
		// (set) Token: 0x0601B3C9 RID: 111561 RVA: 0x007BAA18 File Offset: 0x007B8C18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LastMessageId
		{
			get
			{
				return this.lastMessageId_;
			}
			set
			{
				this.lastMessageId_ = value;
			}
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x0601B3CA RID: 111562 RVA: 0x007BAA21 File Offset: 0x007B8C21
		// (set) Token: 0x0601B3CB RID: 111563 RVA: 0x007BAA29 File Offset: 0x007B8C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastMessageUpdateTime
		{
			get
			{
				return this.lastMessageUpdateTime_;
			}
			set
			{
				this.lastMessageUpdateTime_ = value;
			}
		}

		// Token: 0x0601B3CC RID: 111564 RVA: 0x007BAA32 File Offset: 0x007B8C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DatingEpisodeDBInfo);
		}

		// Token: 0x0601B3CD RID: 111565 RVA: 0x007BAA40 File Offset: 0x007B8C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DatingEpisodeDBInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.DatingPoint == other.DatingPoint && this.LastClearId == other.LastClearId && this.LastMessageGroupId == other.LastMessageGroupId && this.LastMessageId == other.LastMessageId && this.LastMessageUpdateTime == other.LastMessageUpdateTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3CE RID: 111566 RVA: 0x007BAACC File Offset: 0x007B8CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.DatingPoint != 0)
			{
				num ^= this.DatingPoint.GetHashCode();
			}
			if (this.LastClearId != 0)
			{
				num ^= this.LastClearId.GetHashCode();
			}
			if (this.LastMessageGroupId != 0)
			{
				num ^= this.LastMessageGroupId.GetHashCode();
			}
			if (this.LastMessageId != 0)
			{
				num ^= this.LastMessageId.GetHashCode();
			}
			if (this.LastMessageUpdateTime != 0L)
			{
				num ^= this.LastMessageUpdateTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B3CF RID: 111567 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B3D0 RID: 111568 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3D1 RID: 111569 RVA: 0x007BAB88 File Offset: 0x007B8D88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.DatingPoint != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DatingPoint);
			}
			if (this.LastClearId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LastClearId);
			}
			if (this.LastMessageGroupId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LastMessageGroupId);
			}
			if (this.LastMessageId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LastMessageId);
			}
			if (this.LastMessageUpdateTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LastMessageUpdateTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3D2 RID: 111570 RVA: 0x007BAC50 File Offset: 0x007B8E50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.DatingPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DatingPoint);
			}
			if (this.LastClearId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastClearId);
			}
			if (this.LastMessageGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastMessageGroupId);
			}
			if (this.LastMessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastMessageId);
			}
			if (this.LastMessageUpdateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastMessageUpdateTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B3D3 RID: 111571 RVA: 0x007BAD08 File Offset: 0x007B8F08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(DatingEpisodeDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.DatingPoint != 0)
			{
				this.DatingPoint = other.DatingPoint;
			}
			if (other.LastClearId != 0)
			{
				this.LastClearId = other.LastClearId;
			}
			if (other.LastMessageGroupId != 0)
			{
				this.LastMessageGroupId = other.LastMessageGroupId;
			}
			if (other.LastMessageId != 0)
			{
				this.LastMessageId = other.LastMessageId;
			}
			if (other.LastMessageUpdateTime != 0L)
			{
				this.LastMessageUpdateTime = other.LastMessageUpdateTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B3D4 RID: 111572 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3D5 RID: 111573 RVA: 0x007BADA8 File Offset: 0x007B8FA8
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
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DatingPoint = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LastClearId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.LastMessageGroupId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LastMessageId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.LastMessageUpdateTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<DatingEpisodeDBInfo> _parser = new MessageParser<DatingEpisodeDBInfo>(() => new DatingEpisodeDBInfo());

		// Token: 0x04014D3A RID: 85306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014D3B RID: 85307
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04014D3C RID: 85308
		private int groupId_;

		// Token: 0x04014D3D RID: 85309
		public const int DatingPointFieldNumber = 2;

		// Token: 0x04014D3E RID: 85310
		private int datingPoint_;

		// Token: 0x04014D3F RID: 85311
		public const int LastClearIdFieldNumber = 3;

		// Token: 0x04014D40 RID: 85312
		private int lastClearId_;

		// Token: 0x04014D41 RID: 85313
		public const int LastMessageGroupIdFieldNumber = 4;

		// Token: 0x04014D42 RID: 85314
		private int lastMessageGroupId_;

		// Token: 0x04014D43 RID: 85315
		public const int LastMessageIdFieldNumber = 5;

		// Token: 0x04014D44 RID: 85316
		private int lastMessageId_;

		// Token: 0x04014D45 RID: 85317
		public const int LastMessageUpdateTimeFieldNumber = 6;

		// Token: 0x04014D46 RID: 85318
		private long lastMessageUpdateTime_;
	}
}
