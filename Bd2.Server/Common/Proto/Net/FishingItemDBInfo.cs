using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004577 RID: 17783
	public sealed class FishingItemDBInfo : IMessage<FishingItemDBInfo>, IMessage, IEquatable<FishingItemDBInfo>, IDeepCloneable<FishingItemDBInfo>, IBufferMessage
	{
		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0601B9CE RID: 113102 RVA: 0x007CCE15 File Offset: 0x007CB015
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingItemDBInfo> Parser
		{
			get
			{
				return FishingItemDBInfo._parser;
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x0601B9CF RID: 113103 RVA: 0x007CCE1C File Offset: 0x007CB01C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingItemDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0601B9D0 RID: 113104 RVA: 0x007CCE2E File Offset: 0x007CB02E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingItemDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B9D1 RID: 113105 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemDBInfo()
		{
		}

		// Token: 0x0601B9D2 RID: 113106 RVA: 0x007CCE38 File Offset: 0x007CB038
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingItemDBInfo(FishingItemDBInfo other)
			: this()
		{
			this.invenIndex_ = other.invenIndex_;
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.count_ = other.count_;
			this.timeValue_ = other.timeValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9D3 RID: 113107 RVA: 0x007CCE98 File Offset: 0x007CB098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingItemDBInfo Clone()
		{
			return new FishingItemDBInfo(this);
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0601B9D4 RID: 113108 RVA: 0x007CCEA0 File Offset: 0x007CB0A0
		// (set) Token: 0x0601B9D5 RID: 113109 RVA: 0x007CCEA8 File Offset: 0x007CB0A8
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

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0601B9D6 RID: 113110 RVA: 0x007CCEB1 File Offset: 0x007CB0B1
		// (set) Token: 0x0601B9D7 RID: 113111 RVA: 0x007CCEB9 File Offset: 0x007CB0B9
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

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x0601B9D8 RID: 113112 RVA: 0x007CCEC2 File Offset: 0x007CB0C2
		// (set) Token: 0x0601B9D9 RID: 113113 RVA: 0x007CCECA File Offset: 0x007CB0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0601B9DA RID: 113114 RVA: 0x007CCED3 File Offset: 0x007CB0D3
		// (set) Token: 0x0601B9DB RID: 113115 RVA: 0x007CCEDB File Offset: 0x007CB0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0601B9DC RID: 113116 RVA: 0x007CCEE4 File Offset: 0x007CB0E4
		// (set) Token: 0x0601B9DD RID: 113117 RVA: 0x007CCEEC File Offset: 0x007CB0EC
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

		// Token: 0x0601B9DE RID: 113118 RVA: 0x007CCEF5 File Offset: 0x007CB0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingItemDBInfo);
		}

		// Token: 0x0601B9DF RID: 113119 RVA: 0x007CCF04 File Offset: 0x007CB104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingItemDBInfo other)
		{
			return other != null && (other == this || (this.InvenIndex == other.InvenIndex && this.Id == other.Id && this.Type == other.Type && this.Count == other.Count && this.TimeValue == other.TimeValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9E0 RID: 113120 RVA: 0x007CCF80 File Offset: 0x007CB180
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.TimeValue != 0L)
			{
				num ^= this.TimeValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9E1 RID: 113121 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B9E2 RID: 113122 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9E3 RID: 113123 RVA: 0x007CD024 File Offset: 0x007CB224
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
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Count);
			}
			if (this.TimeValue != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TimeValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9E4 RID: 113124 RVA: 0x007CD0D0 File Offset: 0x007CB2D0
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
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.TimeValue != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TimeValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9E5 RID: 113125 RVA: 0x007CD170 File Offset: 0x007CB370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingItemDBInfo other)
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
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.TimeValue != 0L)
			{
				this.TimeValue = other.TimeValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9E6 RID: 113126 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9E7 RID: 113127 RVA: 0x007CD1FC File Offset: 0x007CB3FC
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
						this.Type = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TimeValue = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<FishingItemDBInfo> _parser = new MessageParser<FishingItemDBInfo>(() => new FishingItemDBInfo());

		// Token: 0x0401557B RID: 87419
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401557C RID: 87420
		public const int InvenIndexFieldNumber = 1;

		// Token: 0x0401557D RID: 87421
		private long invenIndex_;

		// Token: 0x0401557E RID: 87422
		public const int IdFieldNumber = 2;

		// Token: 0x0401557F RID: 87423
		private int id_;

		// Token: 0x04015580 RID: 87424
		public const int TypeFieldNumber = 3;

		// Token: 0x04015581 RID: 87425
		private int type_;

		// Token: 0x04015582 RID: 87426
		public const int CountFieldNumber = 4;

		// Token: 0x04015583 RID: 87427
		private int count_;

		// Token: 0x04015584 RID: 87428
		public const int TimeValueFieldNumber = 5;

		// Token: 0x04015585 RID: 87429
		private long timeValue_;
	}
}
