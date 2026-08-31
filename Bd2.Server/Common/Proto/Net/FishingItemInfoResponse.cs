using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005265 RID: 21093
	public sealed class FishingItemInfoResponse : IMessage<FishingItemInfoResponse>, IMessage, IEquatable<FishingItemInfoResponse>, IDeepCloneable<FishingItemInfoResponse>, IBufferMessage
	{
		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x06023031 RID: 143409 RVA: 0x008DCD5B File Offset: 0x008DAF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingItemInfoResponse> Parser
		{
			get
			{
				return FishingItemInfoResponse._parser;
			}
		}

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x06023032 RID: 143410 RVA: 0x008DCD62 File Offset: 0x008DAF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingItemInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x06023033 RID: 143411 RVA: 0x008DCD74 File Offset: 0x008DAF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingItemInfoResponse.Descriptor;
			}
		}

		// Token: 0x06023034 RID: 143412 RVA: 0x008DCD7B File Offset: 0x008DAF7B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingItemInfoResponse()
		{
		}

		// Token: 0x06023035 RID: 143413 RVA: 0x008DCDA4 File Offset: 0x008DAFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemInfoResponse(FishingItemInfoResponse other)
			: this()
		{
			this.fishInfo_ = other.fishInfo_.Clone();
			this.rodInfo_ = other.rodInfo_.Clone();
			this.itemInfo_ = other.itemInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06023036 RID: 143414 RVA: 0x008DCDFB File Offset: 0x008DAFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemInfoResponse Clone()
		{
			return new FishingItemInfoResponse(this);
		}

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x06023037 RID: 143415 RVA: 0x008DCE03 File Offset: 0x008DB003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingFishDBInfo> FishInfo
		{
			get
			{
				return this.fishInfo_;
			}
		}

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x06023038 RID: 143416 RVA: 0x008DCE0B File Offset: 0x008DB00B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FishingRodDBInfo> RodInfo
		{
			get
			{
				return this.rodInfo_;
			}
		}

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x06023039 RID: 143417 RVA: 0x008DCE13 File Offset: 0x008DB013
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FishingItemDBInfo> ItemInfo
		{
			get
			{
				return this.itemInfo_;
			}
		}

		// Token: 0x0602303A RID: 143418 RVA: 0x008DCE1B File Offset: 0x008DB01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingItemInfoResponse);
		}

		// Token: 0x0602303B RID: 143419 RVA: 0x008DCE2C File Offset: 0x008DB02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingItemInfoResponse other)
		{
			return other != null && (other == this || (this.fishInfo_.Equals(other.fishInfo_) && this.rodInfo_.Equals(other.rodInfo_) && this.itemInfo_.Equals(other.itemInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0602303C RID: 143420 RVA: 0x008DCE94 File Offset: 0x008DB094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fishInfo_.GetHashCode();
			num ^= this.rodInfo_.GetHashCode();
			num ^= this.itemInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0602303D RID: 143421 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0602303E RID: 143422 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0602303F RID: 143423 RVA: 0x008DCEE4 File Offset: 0x008DB0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fishInfo_.WriteTo(ref output, FishingItemInfoResponse._repeated_fishInfo_codec);
			this.rodInfo_.WriteTo(ref output, FishingItemInfoResponse._repeated_rodInfo_codec);
			this.itemInfo_.WriteTo(ref output, FishingItemInfoResponse._repeated_itemInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06023040 RID: 143424 RVA: 0x008DCF38 File Offset: 0x008DB138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fishInfo_.CalculateSize(FishingItemInfoResponse._repeated_fishInfo_codec);
			num += this.rodInfo_.CalculateSize(FishingItemInfoResponse._repeated_rodInfo_codec);
			num += this.itemInfo_.CalculateSize(FishingItemInfoResponse._repeated_itemInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06023041 RID: 143425 RVA: 0x008DCF98 File Offset: 0x008DB198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingItemInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.fishInfo_.Add(other.fishInfo_);
			this.rodInfo_.Add(other.rodInfo_);
			this.itemInfo_.Add(other.itemInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023042 RID: 143426 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06023043 RID: 143427 RVA: 0x008DCFF4 File Offset: 0x008DB1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemInfo_.AddEntriesFrom(ref input, FishingItemInfoResponse._repeated_itemInfo_codec);
						}
					}
					else
					{
						this.rodInfo_.AddEntriesFrom(ref input, FishingItemInfoResponse._repeated_rodInfo_codec);
					}
				}
				else
				{
					this.fishInfo_.AddEntriesFrom(ref input, FishingItemInfoResponse._repeated_fishInfo_codec);
				}
			}
		}
		private static readonly MessageParser<FishingItemInfoResponse> _parser = new MessageParser<FishingItemInfoResponse>(() => new FishingItemInfoResponse());

		// Token: 0x040183A9 RID: 99241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040183AA RID: 99242
		public const int FishInfoFieldNumber = 1;

		// Token: 0x040183AB RID: 99243
		private static readonly FieldCodec<FishingFishDBInfo> _repeated_fishInfo_codec = FieldCodec.ForMessage<FishingFishDBInfo>(10U, FishingFishDBInfo.Parser);

		// Token: 0x040183AC RID: 99244
		private readonly RepeatedField<FishingFishDBInfo> fishInfo_ = new RepeatedField<FishingFishDBInfo>();

		// Token: 0x040183AD RID: 99245
		public const int RodInfoFieldNumber = 2;

		// Token: 0x040183AE RID: 99246
		private static readonly FieldCodec<FishingRodDBInfo> _repeated_rodInfo_codec = FieldCodec.ForMessage<FishingRodDBInfo>(18U, FishingRodDBInfo.Parser);

		// Token: 0x040183AF RID: 99247
		private readonly RepeatedField<FishingRodDBInfo> rodInfo_ = new RepeatedField<FishingRodDBInfo>();

		// Token: 0x040183B0 RID: 99248
		public const int ItemInfoFieldNumber = 3;

		// Token: 0x040183B1 RID: 99249
		private static readonly FieldCodec<FishingItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage<FishingItemDBInfo>(26U, FishingItemDBInfo.Parser);

		// Token: 0x040183B2 RID: 99250
		private readonly RepeatedField<FishingItemDBInfo> itemInfo_ = new RepeatedField<FishingItemDBInfo>();
	}
}
