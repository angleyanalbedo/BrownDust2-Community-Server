using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C88 RID: 31880
	public sealed class FishingFishSizePoolTable : IMessage<FishingFishSizePoolTable>, IMessage, IEquatable<FishingFishSizePoolTable>, IDeepCloneable<FishingFishSizePoolTable>, IBufferMessage
	{
		// Token: 0x170111EE RID: 70126
		// (get) Token: 0x06046BF2 RID: 289778 RVA: 0x01134A97 File Offset: 0x01132C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingFishSizePoolTable> Parser
		{
			get
			{
				return FishingFishSizePoolTable._parser;
			}
		}

		// Token: 0x170111EF RID: 70127
		// (get) Token: 0x06046BF3 RID: 289779 RVA: 0x01134A9E File Offset: 0x01132C9E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingFishSizePoolTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170111F0 RID: 70128
		// (get) Token: 0x06046BF4 RID: 289780 RVA: 0x01134AB0 File Offset: 0x01132CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingFishSizePoolTable.Descriptor;
			}
		}

		// Token: 0x06046BF5 RID: 289781 RVA: 0x01134AB7 File Offset: 0x01132CB7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingFishSizePoolTable()
		{
		}

		// Token: 0x06046BF6 RID: 289782 RVA: 0x01134AE0 File Offset: 0x01132CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishSizePoolTable(FishingFishSizePoolTable other)
			: this()
		{
			this.buffValue_ = other.buffValue_;
			this.id_ = other.id_;
			this.maxSizeRatio_ = other.maxSizeRatio_.Clone();
			this.minSizeRatio_ = other.minSizeRatio_.Clone();
			this.ratio_ = other.ratio_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046BF7 RID: 289783 RVA: 0x01134B4F File Offset: 0x01132D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishSizePoolTable Clone()
		{
			return new FishingFishSizePoolTable(this);
		}

		// Token: 0x170111F1 RID: 70129
		// (get) Token: 0x06046BF8 RID: 289784 RVA: 0x01134B57 File Offset: 0x01132D57
		// (set) Token: 0x06046BF9 RID: 289785 RVA: 0x01134B5F File Offset: 0x01132D5F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BuffValue
		{
			get
			{
				return this.buffValue_;
			}
			set
			{
				this.buffValue_ = value;
			}
		}

		// Token: 0x170111F2 RID: 70130
		// (get) Token: 0x06046BFA RID: 289786 RVA: 0x01134B68 File Offset: 0x01132D68
		// (set) Token: 0x06046BFB RID: 289787 RVA: 0x01134B70 File Offset: 0x01132D70
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

		// Token: 0x170111F3 RID: 70131
		// (get) Token: 0x06046BFC RID: 289788 RVA: 0x01134B79 File Offset: 0x01132D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MaxSizeRatio
		{
			get
			{
				return this.maxSizeRatio_;
			}
		}

		// Token: 0x170111F4 RID: 70132
		// (get) Token: 0x06046BFD RID: 289789 RVA: 0x01134B81 File Offset: 0x01132D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MinSizeRatio
		{
			get
			{
				return this.minSizeRatio_;
			}
		}

		// Token: 0x170111F5 RID: 70133
		// (get) Token: 0x06046BFE RID: 289790 RVA: 0x01134B89 File Offset: 0x01132D89
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Ratio
		{
			get
			{
				return this.ratio_;
			}
		}

		// Token: 0x06046BFF RID: 289791 RVA: 0x01134B91 File Offset: 0x01132D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingFishSizePoolTable);
		}

		// Token: 0x06046C00 RID: 289792 RVA: 0x01134BA0 File Offset: 0x01132DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingFishSizePoolTable other)
		{
			return other != null && (other == this || (this.BuffValue == other.BuffValue && this.Id == other.Id && this.maxSizeRatio_.Equals(other.maxSizeRatio_) && this.minSizeRatio_.Equals(other.minSizeRatio_) && this.ratio_.Equals(other.ratio_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046C01 RID: 289793 RVA: 0x01134C28 File Offset: 0x01132E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffValue != 0)
			{
				num ^= this.BuffValue.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.maxSizeRatio_.GetHashCode();
			num ^= this.minSizeRatio_.GetHashCode();
			num ^= this.ratio_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046C02 RID: 289794 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046C03 RID: 289795 RVA: 0x001D568A File Offset: 0x001D388A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046C04 RID: 289796 RVA: 0x01134CAC File Offset: 0x01132EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffValue != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffValue);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			this.maxSizeRatio_.WriteTo(ref output, FishingFishSizePoolTable._repeated_maxSizeRatio_codec);
			this.minSizeRatio_.WriteTo(ref output, FishingFishSizePoolTable._repeated_minSizeRatio_codec);
			this.ratio_.WriteTo(ref output, FishingFishSizePoolTable._repeated_ratio_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046C05 RID: 289797 RVA: 0x01134D38 File Offset: 0x01132F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffValue);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.maxSizeRatio_.CalculateSize(FishingFishSizePoolTable._repeated_maxSizeRatio_codec);
			num += this.minSizeRatio_.CalculateSize(FishingFishSizePoolTable._repeated_minSizeRatio_codec);
			num += this.ratio_.CalculateSize(FishingFishSizePoolTable._repeated_ratio_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046C06 RID: 289798 RVA: 0x01134DC8 File Offset: 0x01132FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingFishSizePoolTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffValue != 0)
			{
				this.BuffValue = other.BuffValue;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.maxSizeRatio_.Add(other.maxSizeRatio_);
			this.minSizeRatio_.Add(other.minSizeRatio_);
			this.ratio_.Add(other.ratio_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046C07 RID: 289799 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046C08 RID: 289800 RVA: 0x01134E4C File Offset: 0x0113304C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.BuffValue = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
					}
					else if (num == 24U || num == 26U)
					{
						this.maxSizeRatio_.AddEntriesFrom(ref input, FishingFishSizePoolTable._repeated_maxSizeRatio_codec);
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.minSizeRatio_.AddEntriesFrom(ref input, FishingFishSizePoolTable._repeated_minSizeRatio_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.ratio_.AddEntriesFrom(ref input, FishingFishSizePoolTable._repeated_ratio_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EA8F RID: 191119
		private static readonly MessageParser<FishingFishSizePoolTable> _parser = new MessageParser<FishingFishSizePoolTable>(() => new FishingFishSizePoolTable());

		// Token: 0x0402EA90 RID: 191120
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EA91 RID: 191121
		public const int BuffValueFieldNumber = 1;

		// Token: 0x0402EA92 RID: 191122
		private int buffValue_;

		// Token: 0x0402EA93 RID: 191123
		public const int IdFieldNumber = 2;

		// Token: 0x0402EA94 RID: 191124
		private int id_;

		// Token: 0x0402EA95 RID: 191125
		public const int MaxSizeRatioFieldNumber = 3;

		// Token: 0x0402EA96 RID: 191126
		private static readonly FieldCodec<int> _repeated_maxSizeRatio_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0402EA97 RID: 191127
		private readonly RepeatedField<int> maxSizeRatio_ = new RepeatedField<int>();

		// Token: 0x0402EA98 RID: 191128
		public const int MinSizeRatioFieldNumber = 4;

		// Token: 0x0402EA99 RID: 191129
		private static readonly FieldCodec<int> _repeated_minSizeRatio_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0402EA9A RID: 191130
		private readonly RepeatedField<int> minSizeRatio_ = new RepeatedField<int>();

		// Token: 0x0402EA9B RID: 191131
		public const int RatioFieldNumber = 5;

		// Token: 0x0402EA9C RID: 191132
		private static readonly FieldCodec<int> _repeated_ratio_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0402EA9D RID: 191133
		private readonly RepeatedField<int> ratio_ = new RepeatedField<int>();
	}
}
