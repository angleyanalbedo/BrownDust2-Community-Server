using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200456E RID: 17774
	public sealed class FishingFishDBInfo : IMessage<FishingFishDBInfo>, IMessage, IEquatable<FishingFishDBInfo>, IDeepCloneable<FishingFishDBInfo>, IBufferMessage
	{
		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x0601B97A RID: 113018 RVA: 0x007CC2B1 File Offset: 0x007CA4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingFishDBInfo> Parser
		{
			get
			{
				return FishingFishDBInfo._parser;
			}
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0601B97B RID: 113019 RVA: 0x007CC2B8 File Offset: 0x007CA4B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingFishDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0601B97C RID: 113020 RVA: 0x007CC2CA File Offset: 0x007CA4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingFishDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B97D RID: 113021 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishDBInfo()
		{
		}

		// Token: 0x0601B97E RID: 113022 RVA: 0x007CC2D4 File Offset: 0x007CA4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishDBInfo(FishingFishDBInfo other)
			: this()
		{
			this.invenIndex_ = other.invenIndex_;
			this.id_ = other.id_;
			this.size_ = other.size_;
			this.timeValue_ = other.timeValue_;
			this.isLock_ = other.isLock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B97F RID: 113023 RVA: 0x007CC334 File Offset: 0x007CA534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishDBInfo Clone()
		{
			return new FishingFishDBInfo(this);
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0601B980 RID: 113024 RVA: 0x007CC33C File Offset: 0x007CA53C
		// (set) Token: 0x0601B981 RID: 113025 RVA: 0x007CC344 File Offset: 0x007CA544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InvenIndex
		{
			get
			{
				return this.invenIndex_;
			}
			set
			{
				this.invenIndex_ = value;
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0601B982 RID: 113026 RVA: 0x007CC34D File Offset: 0x007CA54D
		// (set) Token: 0x0601B983 RID: 113027 RVA: 0x007CC355 File Offset: 0x007CA555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0601B984 RID: 113028 RVA: 0x007CC35E File Offset: 0x007CA55E
		// (set) Token: 0x0601B985 RID: 113029 RVA: 0x007CC366 File Offset: 0x007CA566
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Size
		{
			get
			{
				return this.size_;
			}
			set
			{
				this.size_ = value;
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0601B986 RID: 113030 RVA: 0x007CC36F File Offset: 0x007CA56F
		// (set) Token: 0x0601B987 RID: 113031 RVA: 0x007CC377 File Offset: 0x007CA577
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TimeValue
		{
			get
			{
				return this.timeValue_;
			}
			set
			{
				this.timeValue_ = value;
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x0601B988 RID: 113032 RVA: 0x007CC380 File Offset: 0x007CA580
		// (set) Token: 0x0601B989 RID: 113033 RVA: 0x007CC388 File Offset: 0x007CA588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLock
		{
			get
			{
				return this.isLock_;
			}
			set
			{
				this.isLock_ = value;
			}
		}

		// Token: 0x0601B98A RID: 113034 RVA: 0x007CC391 File Offset: 0x007CA591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingFishDBInfo);
		}

		// Token: 0x0601B98B RID: 113035 RVA: 0x007CC3A0 File Offset: 0x007CA5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingFishDBInfo other)
		{
			return other != null && (other == this || (this.InvenIndex == other.InvenIndex && this.Id == other.Id && this.Size == other.Size && this.TimeValue == other.TimeValue && this.IsLock == other.IsLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B98C RID: 113036 RVA: 0x007CC41C File Offset: 0x007CA61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InvenIndex != 0L)
			{
				num ^= this.InvenIndex.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Size != 0)
			{
				num ^= this.Size.GetHashCode();
			}
			if (this.TimeValue != 0L)
			{
				num ^= this.TimeValue.GetHashCode();
			}
			if (this.IsLock)
			{
				num ^= this.IsLock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B98D RID: 113037 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B98E RID: 113038 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B98F RID: 113039 RVA: 0x007CC4C0 File Offset: 0x007CA6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InvenIndex != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.InvenIndex);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Size != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Size);
			}
			if (this.TimeValue != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TimeValue);
			}
			if (this.IsLock)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsLock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B990 RID: 113040 RVA: 0x007CC56C File Offset: 0x007CA76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InvenIndex != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InvenIndex);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Size != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Size);
			}
			if (this.TimeValue != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TimeValue);
			}
			if (this.IsLock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B991 RID: 113041 RVA: 0x007CC600 File Offset: 0x007CA800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingFishDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InvenIndex != 0L)
			{
				this.InvenIndex = other.InvenIndex;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Size != 0)
			{
				this.Size = other.Size;
			}
			if (other.TimeValue != 0L)
			{
				this.TimeValue = other.TimeValue;
			}
			if (other.IsLock)
			{
				this.IsLock = other.IsLock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B992 RID: 113042 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B993 RID: 113043 RVA: 0x007CC68C File Offset: 0x007CA88C
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
						this.InvenIndex = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Size = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.TimeValue = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.IsLock = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<FishingFishDBInfo> _parser = new MessageParser<FishingFishDBInfo>(() => new FishingFishDBInfo());

		// Token: 0x0401555D RID: 87389
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401555E RID: 87390
		public const int InvenIndexFieldNumber = 1;

		// Token: 0x0401555F RID: 87391
		private long invenIndex_;

		// Token: 0x04015560 RID: 87392
		public const int IdFieldNumber = 2;

		// Token: 0x04015561 RID: 87393
		private int id_;

		// Token: 0x04015562 RID: 87394
		public const int SizeFieldNumber = 3;

		// Token: 0x04015563 RID: 87395
		private int size_;

		// Token: 0x04015564 RID: 87396
		public const int TimeValueFieldNumber = 4;

		// Token: 0x04015565 RID: 87397
		private long timeValue_;

		// Token: 0x04015566 RID: 87398
		public const int IsLockFieldNumber = 5;

		// Token: 0x04015567 RID: 87399
		private bool isLock_;
	}
}
