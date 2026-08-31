using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CA0 RID: 31904
	public sealed class FishingPricePremiumDefaultTable : IMessage<FishingPricePremiumDefaultTable>, IMessage, IEquatable<FishingPricePremiumDefaultTable>, IDeepCloneable<FishingPricePremiumDefaultTable>, IBufferMessage
	{
		// Token: 0x17011253 RID: 70227
		// (get) Token: 0x06046D25 RID: 290085 RVA: 0x01138D9B File Offset: 0x01136F9B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingPricePremiumDefaultTable> Parser
		{
			get
			{
				return FishingPricePremiumDefaultTable._parser;
			}
		}

		// Token: 0x17011254 RID: 70228
		// (get) Token: 0x06046D26 RID: 290086 RVA: 0x01138DA2 File Offset: 0x01136FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingPricePremiumDefaultTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011255 RID: 70229
		// (get) Token: 0x06046D27 RID: 290087 RVA: 0x01138DB4 File Offset: 0x01136FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPricePremiumDefaultTable.Descriptor;
			}
		}

		// Token: 0x06046D28 RID: 290088 RVA: 0x01138DBB File Offset: 0x01136FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPricePremiumDefaultTable()
		{
		}

		// Token: 0x06046D29 RID: 290089 RVA: 0x01138DE4 File Offset: 0x01136FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPricePremiumDefaultTable(FishingPricePremiumDefaultTable other)
			: this()
		{
			this.id_ = other.id_;
			this.shopMaxSizeRatio_ = other.shopMaxSizeRatio_.Clone();
			this.shopMinSizeRatio_ = other.shopMinSizeRatio_.Clone();
			this.shopPricePremium_ = other.shopPricePremium_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046D2A RID: 290090 RVA: 0x01138E47 File Offset: 0x01137047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPricePremiumDefaultTable Clone()
		{
			return new FishingPricePremiumDefaultTable(this);
		}

		// Token: 0x17011256 RID: 70230
		// (get) Token: 0x06046D2B RID: 290091 RVA: 0x01138E4F File Offset: 0x0113704F
		// (set) Token: 0x06046D2C RID: 290092 RVA: 0x01138E57 File Offset: 0x01137057
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

		// Token: 0x17011257 RID: 70231
		// (get) Token: 0x06046D2D RID: 290093 RVA: 0x01138E60 File Offset: 0x01137060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> ShopMaxSizeRatio
		{
			get
			{
				return this.shopMaxSizeRatio_;
			}
		}

		// Token: 0x17011258 RID: 70232
		// (get) Token: 0x06046D2E RID: 290094 RVA: 0x01138E68 File Offset: 0x01137068
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> ShopMinSizeRatio
		{
			get
			{
				return this.shopMinSizeRatio_;
			}
		}

		// Token: 0x17011259 RID: 70233
		// (get) Token: 0x06046D2F RID: 290095 RVA: 0x01138E70 File Offset: 0x01137070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<float> ShopPricePremium
		{
			get
			{
				return this.shopPricePremium_;
			}
		}

		// Token: 0x06046D30 RID: 290096 RVA: 0x01138E78 File Offset: 0x01137078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPricePremiumDefaultTable);
		}

		// Token: 0x06046D31 RID: 290097 RVA: 0x01138E88 File Offset: 0x01137088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPricePremiumDefaultTable other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.shopMaxSizeRatio_.Equals(other.shopMaxSizeRatio_) && this.shopMinSizeRatio_.Equals(other.shopMinSizeRatio_) && this.shopPricePremium_.Equals(other.shopPricePremium_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046D32 RID: 290098 RVA: 0x01138F00 File Offset: 0x01137100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.shopMaxSizeRatio_.GetHashCode();
			num ^= this.shopMinSizeRatio_.GetHashCode();
			num ^= this.shopPricePremium_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046D33 RID: 290099 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046D34 RID: 290100 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046D35 RID: 290101 RVA: 0x01138F6C File Offset: 0x0113716C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.shopMaxSizeRatio_.WriteTo(ref output, FishingPricePremiumDefaultTable._repeated_shopMaxSizeRatio_codec);
			this.shopMinSizeRatio_.WriteTo(ref output, FishingPricePremiumDefaultTable._repeated_shopMinSizeRatio_codec);
			this.shopPricePremium_.WriteTo(ref output, FishingPricePremiumDefaultTable._repeated_shopPricePremium_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046D36 RID: 290102 RVA: 0x01138FDC File Offset: 0x011371DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.shopMaxSizeRatio_.CalculateSize(FishingPricePremiumDefaultTable._repeated_shopMaxSizeRatio_codec);
			num += this.shopMinSizeRatio_.CalculateSize(FishingPricePremiumDefaultTable._repeated_shopMinSizeRatio_codec);
			num += this.shopPricePremium_.CalculateSize(FishingPricePremiumDefaultTable._repeated_shopPricePremium_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046D37 RID: 290103 RVA: 0x01139054 File Offset: 0x01137254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingPricePremiumDefaultTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.shopMaxSizeRatio_.Add(other.shopMaxSizeRatio_);
			this.shopMinSizeRatio_.Add(other.shopMinSizeRatio_);
			this.shopPricePremium_.Add(other.shopPricePremium_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046D38 RID: 290104 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046D39 RID: 290105 RVA: 0x011390C4 File Offset: 0x011372C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.shopMaxSizeRatio_.AddEntriesFrom(ref input, FishingPricePremiumDefaultTable._repeated_shopMaxSizeRatio_codec);
						continue;
					}
				}
				else if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.shopMinSizeRatio_.AddEntriesFrom(ref input, FishingPricePremiumDefaultTable._repeated_shopMinSizeRatio_codec);
						continue;
					}
				}
				else if (num == 34U || num == 37U)
				{
					this.shopPricePremium_.AddEntriesFrom(ref input, FishingPricePremiumDefaultTable._repeated_shopPricePremium_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EB40 RID: 191296
		private static readonly MessageParser<FishingPricePremiumDefaultTable> _parser = new MessageParser<FishingPricePremiumDefaultTable>(() => new FishingPricePremiumDefaultTable());

		// Token: 0x0402EB41 RID: 191297
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EB42 RID: 191298
		public const int IdFieldNumber = 1;

		// Token: 0x0402EB43 RID: 191299
		private int id_;

		// Token: 0x0402EB44 RID: 191300
		public const int ShopMaxSizeRatioFieldNumber = 2;

		// Token: 0x0402EB45 RID: 191301
		private static readonly FieldCodec<int> _repeated_shopMaxSizeRatio_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0402EB46 RID: 191302
		private readonly RepeatedField<int> shopMaxSizeRatio_ = new RepeatedField<int>();

		// Token: 0x0402EB47 RID: 191303
		public const int ShopMinSizeRatioFieldNumber = 3;

		// Token: 0x0402EB48 RID: 191304
		private static readonly FieldCodec<int> _repeated_shopMinSizeRatio_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0402EB49 RID: 191305
		private readonly RepeatedField<int> shopMinSizeRatio_ = new RepeatedField<int>();

		// Token: 0x0402EB4A RID: 191306
		public const int ShopPricePremiumFieldNumber = 4;

		// Token: 0x0402EB4B RID: 191307
		private static readonly FieldCodec<float> _repeated_shopPricePremium_codec = FieldCodec.ForFloat(34U);

		// Token: 0x0402EB4C RID: 191308
		private readonly RepeatedField<float> shopPricePremium_ = new RepeatedField<float>();
	}
}
