using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CA9 RID: 31913
	public sealed class FishingShopTable : IMessage<FishingShopTable>, IMessage, IEquatable<FishingShopTable>, IDeepCloneable<FishingShopTable>, IBufferMessage
	{
		// Token: 0x17011270 RID: 70256
		// (get) Token: 0x06046D85 RID: 290181 RVA: 0x01139FB7 File Offset: 0x011381B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingShopTable> Parser
		{
			get
			{
				return FishingShopTable._parser;
			}
		}

		// Token: 0x17011271 RID: 70257
		// (get) Token: 0x06046D86 RID: 290182 RVA: 0x01139FBE File Offset: 0x011381BE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingShopTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011272 RID: 70258
		// (get) Token: 0x06046D87 RID: 290183 RVA: 0x01139FD0 File Offset: 0x011381D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShopTable.Descriptor;
			}
		}

		// Token: 0x06046D88 RID: 290184 RVA: 0x01139FD7 File Offset: 0x011381D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShopTable()
		{
		}

		// Token: 0x06046D89 RID: 290185 RVA: 0x01139FF8 File Offset: 0x011381F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShopTable(FishingShopTable other)
			: this()
		{
			this.currencyType_ = other.currencyType_.Clone();
			this.dialougeTextId_ = other.dialougeTextId_;
			this.id_ = other.id_;
			this.illustName_ = other.illustName_;
			this.npcNameTextId_ = other.npcNameTextId_;
			this.shopItemId_ = other.shopItemId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046D8A RID: 290186 RVA: 0x0113A075 File Offset: 0x01138275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShopTable Clone()
		{
			return new FishingShopTable(this);
		}

		// Token: 0x17011273 RID: 70259
		// (get) Token: 0x06046D8B RID: 290187 RVA: 0x0113A07D File Offset: 0x0113827D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> CurrencyType
		{
			get
			{
				return this.currencyType_;
			}
		}

		// Token: 0x17011274 RID: 70260
		// (get) Token: 0x06046D8C RID: 290188 RVA: 0x0113A085 File Offset: 0x01138285
		// (set) Token: 0x06046D8D RID: 290189 RVA: 0x0113A08D File Offset: 0x0113828D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int DialougeTextId
		{
			get
			{
				return this.dialougeTextId_;
			}
			set
			{
				this.dialougeTextId_ = value;
			}
		}

		// Token: 0x17011275 RID: 70261
		// (get) Token: 0x06046D8E RID: 290190 RVA: 0x0113A096 File Offset: 0x01138296
		// (set) Token: 0x06046D8F RID: 290191 RVA: 0x0113A09E File Offset: 0x0113829E
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

		// Token: 0x17011276 RID: 70262
		// (get) Token: 0x06046D90 RID: 290192 RVA: 0x0113A0A7 File Offset: 0x011382A7
		// (set) Token: 0x06046D91 RID: 290193 RVA: 0x0113A0AF File Offset: 0x011382AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IllustName
		{
			get
			{
				return this.illustName_;
			}
			set
			{
				this.illustName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011277 RID: 70263
		// (get) Token: 0x06046D92 RID: 290194 RVA: 0x0113A0C2 File Offset: 0x011382C2
		// (set) Token: 0x06046D93 RID: 290195 RVA: 0x0113A0CA File Offset: 0x011382CA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NpcNameTextId
		{
			get
			{
				return this.npcNameTextId_;
			}
			set
			{
				this.npcNameTextId_ = value;
			}
		}

		// Token: 0x17011278 RID: 70264
		// (get) Token: 0x06046D94 RID: 290196 RVA: 0x0113A0D3 File Offset: 0x011382D3
		// (set) Token: 0x06046D95 RID: 290197 RVA: 0x0113A0DB File Offset: 0x011382DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopItemId
		{
			get
			{
				return this.shopItemId_;
			}
			set
			{
				this.shopItemId_ = value;
			}
		}

		// Token: 0x17011279 RID: 70265
		// (get) Token: 0x06046D96 RID: 290198 RVA: 0x0113A0E4 File Offset: 0x011382E4
		// (set) Token: 0x06046D97 RID: 290199 RVA: 0x0113A0EC File Offset: 0x011382EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06046D98 RID: 290200 RVA: 0x0113A0F5 File Offset: 0x011382F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShopTable);
		}

		// Token: 0x06046D99 RID: 290201 RVA: 0x0113A104 File Offset: 0x01138304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShopTable other)
		{
			return other != null && (other == this || (this.currencyType_.Equals(other.currencyType_) && this.DialougeTextId == other.DialougeTextId && this.Id == other.Id && !(this.IllustName != other.IllustName) && this.NpcNameTextId == other.NpcNameTextId && this.ShopItemId == other.ShopItemId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046D9A RID: 290202 RVA: 0x0113A1A8 File Offset: 0x011383A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.currencyType_.GetHashCode();
			if (this.DialougeTextId != 0)
			{
				num ^= this.DialougeTextId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IllustName.Length != 0)
			{
				num ^= this.IllustName.GetHashCode();
			}
			if (this.NpcNameTextId != 0)
			{
				num ^= this.NpcNameTextId.GetHashCode();
			}
			if (this.ShopItemId != 0)
			{
				num ^= this.ShopItemId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046D9B RID: 290203 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046D9C RID: 290204 RVA: 0x001D568A File Offset: 0x001D388A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046D9D RID: 290205 RVA: 0x0113A274 File Offset: 0x01138474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.currencyType_.WriteTo(ref output, FishingShopTable._repeated_currencyType_codec);
			if (this.DialougeTextId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DialougeTextId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.IllustName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.IllustName);
			}
			if (this.NpcNameTextId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.NpcNameTextId);
			}
			if (this.ShopItemId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ShopItemId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046D9E RID: 290206 RVA: 0x0113A354 File Offset: 0x01138554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.currencyType_.CalculateSize(FishingShopTable._repeated_currencyType_codec);
			if (this.DialougeTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DialougeTextId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IllustName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IllustName);
			}
			if (this.NpcNameTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcNameTextId);
			}
			if (this.ShopItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopItemId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046D9F RID: 290207 RVA: 0x0113A424 File Offset: 0x01138624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShopTable other)
		{
			if (other == null)
			{
				return;
			}
			this.currencyType_.Add(other.currencyType_);
			if (other.DialougeTextId != 0)
			{
				this.DialougeTextId = other.DialougeTextId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IllustName.Length != 0)
			{
				this.IllustName = other.IllustName;
			}
			if (other.NpcNameTextId != 0)
			{
				this.NpcNameTextId = other.NpcNameTextId;
			}
			if (other.ShopItemId != 0)
			{
				this.ShopItemId = other.ShopItemId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046DA0 RID: 290208 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046DA1 RID: 290209 RVA: 0x0113A4DC File Offset: 0x011386DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.currencyType_.AddEntriesFrom(ref input, FishingShopTable._repeated_currencyType_codec);
							continue;
						}
					}
					else
					{
						if (num == 16U)
						{
							this.DialougeTextId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 40U)
				{
					if (num == 34U)
					{
						this.IllustName = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.NpcNameTextId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ShopItemId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Type = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EB72 RID: 191346
		private static readonly MessageParser<FishingShopTable> _parser = new MessageParser<FishingShopTable>(() => new FishingShopTable());

		// Token: 0x0402EB73 RID: 191347
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EB74 RID: 191348
		public const int CurrencyTypeFieldNumber = 1;

		// Token: 0x0402EB75 RID: 191349
		private static readonly FieldCodec<int> _repeated_currencyType_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0402EB76 RID: 191350
		private readonly RepeatedField<int> currencyType_ = new RepeatedField<int>();

		// Token: 0x0402EB77 RID: 191351
		public const int DialougeTextIdFieldNumber = 2;

		// Token: 0x0402EB78 RID: 191352
		private int dialougeTextId_;

		// Token: 0x0402EB79 RID: 191353
		public const int IdFieldNumber = 3;

		// Token: 0x0402EB7A RID: 191354
		private int id_;

		// Token: 0x0402EB7B RID: 191355
		public const int IllustNameFieldNumber = 4;

		// Token: 0x0402EB7C RID: 191356
		private string illustName_ = "";

		// Token: 0x0402EB7D RID: 191357
		public const int NpcNameTextIdFieldNumber = 5;

		// Token: 0x0402EB7E RID: 191358
		private int npcNameTextId_;

		// Token: 0x0402EB7F RID: 191359
		public const int ShopItemIdFieldNumber = 6;

		// Token: 0x0402EB80 RID: 191360
		private int shopItemId_;

		// Token: 0x0402EB81 RID: 191361
		public const int TypeFieldNumber = 7;

		// Token: 0x0402EB82 RID: 191362
		private int type_;
	}
}
