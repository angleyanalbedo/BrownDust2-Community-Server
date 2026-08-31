using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004568 RID: 17768
	public sealed class FishingCollectionDBInfo : IMessage<FishingCollectionDBInfo>, IMessage, IEquatable<FishingCollectionDBInfo>, IDeepCloneable<FishingCollectionDBInfo>, IBufferMessage
	{
		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0601B937 RID: 112951 RVA: 0x007CB7D1 File Offset: 0x007C99D1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingCollectionDBInfo> Parser
		{
			get
			{
				return FishingCollectionDBInfo._parser;
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0601B938 RID: 112952 RVA: 0x007CB7D8 File Offset: 0x007C99D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingCollectionDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0601B939 RID: 112953 RVA: 0x007CB7EA File Offset: 0x007C99EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCollectionDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B93A RID: 112954 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCollectionDBInfo()
		{
		}

		// Token: 0x0601B93B RID: 112955 RVA: 0x007CB7F4 File Offset: 0x007C99F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCollectionDBInfo(FishingCollectionDBInfo other)
			: this()
		{
			this.fishId_ = other.fishId_;
			this.maxSize_ = other.maxSize_;
			this.minSize_ = other.minSize_;
			this.createTime_ = other.createTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B93C RID: 112956 RVA: 0x007CB848 File Offset: 0x007C9A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCollectionDBInfo Clone()
		{
			return new FishingCollectionDBInfo(this);
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0601B93D RID: 112957 RVA: 0x007CB850 File Offset: 0x007C9A50
		// (set) Token: 0x0601B93E RID: 112958 RVA: 0x007CB858 File Offset: 0x007C9A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishId
		{
			get
			{
				return this.fishId_;
			}
			set
			{
				this.fishId_ = value;
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0601B93F RID: 112959 RVA: 0x007CB861 File Offset: 0x007C9A61
		// (set) Token: 0x0601B940 RID: 112960 RVA: 0x007CB869 File Offset: 0x007C9A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSize
		{
			get
			{
				return this.maxSize_;
			}
			set
			{
				this.maxSize_ = value;
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0601B941 RID: 112961 RVA: 0x007CB872 File Offset: 0x007C9A72
		// (set) Token: 0x0601B942 RID: 112962 RVA: 0x007CB87A File Offset: 0x007C9A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinSize
		{
			get
			{
				return this.minSize_;
			}
			set
			{
				this.minSize_ = value;
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0601B943 RID: 112963 RVA: 0x007CB883 File Offset: 0x007C9A83
		// (set) Token: 0x0601B944 RID: 112964 RVA: 0x007CB88B File Offset: 0x007C9A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x0601B945 RID: 112965 RVA: 0x007CB894 File Offset: 0x007C9A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCollectionDBInfo);
		}

		// Token: 0x0601B946 RID: 112966 RVA: 0x007CB8A4 File Offset: 0x007C9AA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingCollectionDBInfo other)
		{
			return other != null && (other == this || (this.FishId == other.FishId && this.MaxSize == other.MaxSize && this.MinSize == other.MinSize && this.CreateTime == other.CreateTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B947 RID: 112967 RVA: 0x007CB910 File Offset: 0x007C9B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FishId != 0)
			{
				num ^= this.FishId.GetHashCode();
			}
			if (this.MaxSize != 0)
			{
				num ^= this.MaxSize.GetHashCode();
			}
			if (this.MinSize != 0)
			{
				num ^= this.MinSize.GetHashCode();
			}
			if (this.CreateTime != 0L)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B948 RID: 112968 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B949 RID: 112969 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B94A RID: 112970 RVA: 0x007CB99C File Offset: 0x007C9B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FishId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FishId);
			}
			if (this.MaxSize != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxSize);
			}
			if (this.MinSize != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MinSize);
			}
			if (this.CreateTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CreateTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B94B RID: 112971 RVA: 0x007CBA2C File Offset: 0x007C9C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FishId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishId);
			}
			if (this.MaxSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxSize);
			}
			if (this.MinSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinSize);
			}
			if (this.CreateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreateTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B94C RID: 112972 RVA: 0x007CBAB4 File Offset: 0x007C9CB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingCollectionDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FishId != 0)
			{
				this.FishId = other.FishId;
			}
			if (other.MaxSize != 0)
			{
				this.MaxSize = other.MaxSize;
			}
			if (other.MinSize != 0)
			{
				this.MinSize = other.MinSize;
			}
			if (other.CreateTime != 0L)
			{
				this.CreateTime = other.CreateTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B94D RID: 112973 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B94E RID: 112974 RVA: 0x007CBB2C File Offset: 0x007C9D2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.FishId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MaxSize = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MinSize = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CreateTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<FishingCollectionDBInfo> _parser = new MessageParser<FishingCollectionDBInfo>(() => new FishingCollectionDBInfo());

		// Token: 0x04015541 RID: 87361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015542 RID: 87362
		public const int FishIdFieldNumber = 1;

		// Token: 0x04015543 RID: 87363
		private int fishId_;

		// Token: 0x04015544 RID: 87364
		public const int MaxSizeFieldNumber = 2;

		// Token: 0x04015545 RID: 87365
		private int maxSize_;

		// Token: 0x04015546 RID: 87366
		public const int MinSizeFieldNumber = 3;

		// Token: 0x04015547 RID: 87367
		private int minSize_;

		// Token: 0x04015548 RID: 87368
		public const int CreateTimeFieldNumber = 4;

		// Token: 0x04015549 RID: 87369
		private long createTime_;
	}
}
