using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200461C RID: 17948
	public sealed class LifeUserDBInfo : IMessage<LifeUserDBInfo>, IMessage, IEquatable<LifeUserDBInfo>, IDeepCloneable<LifeUserDBInfo>, IBufferMessage
	{
		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0601C0B2 RID: 114866 RVA: 0x007E0237 File Offset: 0x007DE437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifeUserDBInfo> Parser
		{
			get
			{
				return LifeUserDBInfo._parser;
			}
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x0601C0B3 RID: 114867 RVA: 0x007E023E File Offset: 0x007DE43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeUserDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x0601C0B4 RID: 114868 RVA: 0x007E0250 File Offset: 0x007DE450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeUserDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C0B5 RID: 114869 RVA: 0x007E0257 File Offset: 0x007DE457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeUserDBInfo()
		{
		}

		// Token: 0x0601C0B6 RID: 114870 RVA: 0x007E026C File Offset: 0x007DE46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeUserDBInfo(LifeUserDBInfo other)
			: this()
		{
			this.lifeCoin_ = other.lifeCoin_;
			this.lifeWorldId_ = other.lifeWorldId_;
			this.lifeCharLevelInfo_ = ((other.lifeCharLevelInfo_ != null) ? other.lifeCharLevelInfo_.Clone() : null);
			this.chunkId_ = other.chunkId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0B7 RID: 114871 RVA: 0x007E02D5 File Offset: 0x007DE4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeUserDBInfo Clone()
		{
			return new LifeUserDBInfo(this);
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x0601C0B8 RID: 114872 RVA: 0x007E02DD File Offset: 0x007DE4DD
		// (set) Token: 0x0601C0B9 RID: 114873 RVA: 0x007E02E5 File Offset: 0x007DE4E5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LifeCoin
		{
			get
			{
				return this.lifeCoin_;
			}
			set
			{
				this.lifeCoin_ = value;
			}
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0601C0BA RID: 114874 RVA: 0x007E02EE File Offset: 0x007DE4EE
		// (set) Token: 0x0601C0BB RID: 114875 RVA: 0x007E02F6 File Offset: 0x007DE4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifeWorldId
		{
			get
			{
				return this.lifeWorldId_;
			}
			set
			{
				this.lifeWorldId_ = value;
			}
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0601C0BC RID: 114876 RVA: 0x007E02FF File Offset: 0x007DE4FF
		// (set) Token: 0x0601C0BD RID: 114877 RVA: 0x007E0307 File Offset: 0x007DE507
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeCharLevelDBInfo LifeCharLevelInfo
		{
			get
			{
				return this.lifeCharLevelInfo_;
			}
			set
			{
				this.lifeCharLevelInfo_ = value;
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0601C0BE RID: 114878 RVA: 0x007E0310 File Offset: 0x007DE510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> ChunkId
		{
			get
			{
				return this.chunkId_;
			}
		}

		// Token: 0x0601C0BF RID: 114879 RVA: 0x007E0318 File Offset: 0x007DE518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeUserDBInfo);
		}

		// Token: 0x0601C0C0 RID: 114880 RVA: 0x007E0328 File Offset: 0x007DE528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifeUserDBInfo other)
		{
			return other != null && (other == this || (this.LifeCoin == other.LifeCoin && this.LifeWorldId == other.LifeWorldId && object.Equals(this.LifeCharLevelInfo, other.LifeCharLevelInfo) && this.chunkId_.Equals(other.chunkId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0C1 RID: 114881 RVA: 0x007E039C File Offset: 0x007DE59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LifeCoin != 0)
			{
				num ^= this.LifeCoin.GetHashCode();
			}
			if (this.LifeWorldId != 0)
			{
				num ^= this.LifeWorldId.GetHashCode();
			}
			if (this.lifeCharLevelInfo_ != null)
			{
				num ^= this.LifeCharLevelInfo.GetHashCode();
			}
			num ^= this.chunkId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0C2 RID: 114882 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C0C3 RID: 114883 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0C4 RID: 114884 RVA: 0x007E0418 File Offset: 0x007DE618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LifeCoin != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LifeCoin);
			}
			if (this.LifeWorldId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LifeWorldId);
			}
			if (this.lifeCharLevelInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LifeCharLevelInfo);
			}
			this.chunkId_.WriteTo(ref output, LifeUserDBInfo._repeated_chunkId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0C5 RID: 114885 RVA: 0x007E04A0 File Offset: 0x007DE6A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LifeCoin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeCoin);
			}
			if (this.LifeWorldId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeWorldId);
			}
			if (this.lifeCharLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LifeCharLevelInfo);
			}
			num += this.chunkId_.CalculateSize(LifeUserDBInfo._repeated_chunkId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0C6 RID: 114886 RVA: 0x007E0524 File Offset: 0x007DE724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeUserDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LifeCoin != 0)
			{
				this.LifeCoin = other.LifeCoin;
			}
			if (other.LifeWorldId != 0)
			{
				this.LifeWorldId = other.LifeWorldId;
			}
			if (other.lifeCharLevelInfo_ != null)
			{
				if (this.lifeCharLevelInfo_ == null)
				{
					this.LifeCharLevelInfo = new LifeCharLevelDBInfo();
				}
				this.LifeCharLevelInfo.MergeFrom(other.LifeCharLevelInfo);
			}
			this.chunkId_.Add(other.chunkId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0C7 RID: 114887 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0C8 RID: 114888 RVA: 0x007E05B4 File Offset: 0x007DE7B4
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
						this.LifeCoin = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LifeWorldId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.lifeCharLevelInfo_ == null)
						{
							this.LifeCharLevelInfo = new LifeCharLevelDBInfo();
						}
						input.ReadMessage(this.LifeCharLevelInfo);
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.chunkId_.AddEntriesFrom(ref input, LifeUserDBInfo._repeated_chunkId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<LifeUserDBInfo> _parser = new MessageParser<LifeUserDBInfo>(() => new LifeUserDBInfo());

		// Token: 0x04015899 RID: 88217
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401589A RID: 88218
		public const int LifeCoinFieldNumber = 1;

		// Token: 0x0401589B RID: 88219
		private int lifeCoin_;

		// Token: 0x0401589C RID: 88220
		public const int LifeWorldIdFieldNumber = 2;

		// Token: 0x0401589D RID: 88221
		private int lifeWorldId_;

		// Token: 0x0401589E RID: 88222
		public const int LifeCharLevelInfoFieldNumber = 3;

		// Token: 0x0401589F RID: 88223
		private LifeCharLevelDBInfo lifeCharLevelInfo_;

		// Token: 0x040158A0 RID: 88224
		public const int ChunkIdFieldNumber = 4;

		// Token: 0x040158A1 RID: 88225
		private static readonly FieldCodec<int> _repeated_chunkId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040158A2 RID: 88226
		private readonly RepeatedField<int> chunkId_ = new RepeatedField<int>();
	}
}
