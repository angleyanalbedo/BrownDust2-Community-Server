using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C76 RID: 31862
	public sealed class FishingBuyItemTable : IMessage<FishingBuyItemTable>, IMessage, IEquatable<FishingBuyItemTable>, IDeepCloneable<FishingBuyItemTable>, IBufferMessage
	{
		// Token: 0x1701118A RID: 70026
		// (get) Token: 0x06046ADB RID: 289499 RVA: 0x011303F7 File Offset: 0x0112E5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingBuyItemTable> Parser
		{
			get
			{
				return FishingBuyItemTable._parser;
			}
		}

		// Token: 0x1701118B RID: 70027
		// (get) Token: 0x06046ADC RID: 289500 RVA: 0x011303FE File Offset: 0x0112E5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingBuyItemTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1701118C RID: 70028
		// (get) Token: 0x06046ADD RID: 289501 RVA: 0x01130410 File Offset: 0x0112E610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingBuyItemTable.Descriptor;
			}
		}

		// Token: 0x06046ADE RID: 289502 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBuyItemTable()
		{
		}

		// Token: 0x06046ADF RID: 289503 RVA: 0x01130418 File Offset: 0x0112E618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBuyItemTable(FishingBuyItemTable other)
			: this()
		{
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this.itemCount_ = other.itemCount_;
			this.itemId_ = other.itemId_;
			this.itemType_ = other.itemType_;
			this.priceCount_ = other.priceCount_;
			this.priceId_ = other.priceId_;
			this.priceType_ = other.priceType_;
			this.purchaseLimitCount_ = other.purchaseLimitCount_;
			this.purchaseLimitType_ = other.purchaseLimitType_;
			this.sortId_ = other.sortId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046AE0 RID: 289504 RVA: 0x011304C0 File Offset: 0x0112E6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBuyItemTable Clone()
		{
			return new FishingBuyItemTable(this);
		}

		// Token: 0x1701118D RID: 70029
		// (get) Token: 0x06046AE1 RID: 289505 RVA: 0x011304C8 File Offset: 0x0112E6C8
		// (set) Token: 0x06046AE2 RID: 289506 RVA: 0x011304D0 File Offset: 0x0112E6D0
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

		// Token: 0x1701118E RID: 70030
		// (get) Token: 0x06046AE3 RID: 289507 RVA: 0x011304D9 File Offset: 0x0112E6D9
		// (set) Token: 0x06046AE4 RID: 289508 RVA: 0x011304E1 File Offset: 0x0112E6E1
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

		// Token: 0x1701118F RID: 70031
		// (get) Token: 0x06046AE5 RID: 289509 RVA: 0x011304EA File Offset: 0x0112E6EA
		// (set) Token: 0x06046AE6 RID: 289510 RVA: 0x011304F2 File Offset: 0x0112E6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x17011190 RID: 70032
		// (get) Token: 0x06046AE7 RID: 289511 RVA: 0x011304FB File Offset: 0x0112E6FB
		// (set) Token: 0x06046AE8 RID: 289512 RVA: 0x01130503 File Offset: 0x0112E703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17011191 RID: 70033
		// (get) Token: 0x06046AE9 RID: 289513 RVA: 0x0113050C File Offset: 0x0112E70C
		// (set) Token: 0x06046AEA RID: 289514 RVA: 0x01130514 File Offset: 0x0112E714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemType
		{
			get
			{
				return this.itemType_;
			}
			set
			{
				this.itemType_ = value;
			}
		}

		// Token: 0x17011192 RID: 70034
		// (get) Token: 0x06046AEB RID: 289515 RVA: 0x0113051D File Offset: 0x0112E71D
		// (set) Token: 0x06046AEC RID: 289516 RVA: 0x01130525 File Offset: 0x0112E725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PriceCount
		{
			get
			{
				return this.priceCount_;
			}
			set
			{
				this.priceCount_ = value;
			}
		}

		// Token: 0x17011193 RID: 70035
		// (get) Token: 0x06046AED RID: 289517 RVA: 0x0113052E File Offset: 0x0112E72E
		// (set) Token: 0x06046AEE RID: 289518 RVA: 0x01130536 File Offset: 0x0112E736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PriceId
		{
			get
			{
				return this.priceId_;
			}
			set
			{
				this.priceId_ = value;
			}
		}

		// Token: 0x17011194 RID: 70036
		// (get) Token: 0x06046AEF RID: 289519 RVA: 0x0113053F File Offset: 0x0112E73F
		// (set) Token: 0x06046AF0 RID: 289520 RVA: 0x01130547 File Offset: 0x0112E747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PriceType
		{
			get
			{
				return this.priceType_;
			}
			set
			{
				this.priceType_ = value;
			}
		}

		// Token: 0x17011195 RID: 70037
		// (get) Token: 0x06046AF1 RID: 289521 RVA: 0x01130550 File Offset: 0x0112E750
		// (set) Token: 0x06046AF2 RID: 289522 RVA: 0x01130558 File Offset: 0x0112E758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PurchaseLimitCount
		{
			get
			{
				return this.purchaseLimitCount_;
			}
			set
			{
				this.purchaseLimitCount_ = value;
			}
		}

		// Token: 0x17011196 RID: 70038
		// (get) Token: 0x06046AF3 RID: 289523 RVA: 0x01130561 File Offset: 0x0112E761
		// (set) Token: 0x06046AF4 RID: 289524 RVA: 0x01130569 File Offset: 0x0112E769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PurchaseLimitType
		{
			get
			{
				return this.purchaseLimitType_;
			}
			set
			{
				this.purchaseLimitType_ = value;
			}
		}

		// Token: 0x17011197 RID: 70039
		// (get) Token: 0x06046AF5 RID: 289525 RVA: 0x01130572 File Offset: 0x0112E772
		// (set) Token: 0x06046AF6 RID: 289526 RVA: 0x0113057A File Offset: 0x0112E77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SortId
		{
			get
			{
				return this.sortId_;
			}
			set
			{
				this.sortId_ = value;
			}
		}

		// Token: 0x06046AF7 RID: 289527 RVA: 0x01130583 File Offset: 0x0112E783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingBuyItemTable);
		}

		// Token: 0x06046AF8 RID: 289528 RVA: 0x01130594 File Offset: 0x0112E794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingBuyItemTable other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Id == other.Id && this.ItemCount == other.ItemCount && this.ItemId == other.ItemId && this.ItemType == other.ItemType && this.PriceCount == other.PriceCount && this.PriceId == other.PriceId && this.PriceType == other.PriceType && this.PurchaseLimitCount == other.PurchaseLimitCount && this.PurchaseLimitType == other.PurchaseLimitType && this.SortId == other.SortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046AF9 RID: 289529 RVA: 0x01130670 File Offset: 0x0112E870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemType != 0)
			{
				num ^= this.ItemType.GetHashCode();
			}
			if (this.PriceCount != 0)
			{
				num ^= this.PriceCount.GetHashCode();
			}
			if (this.PriceId != 0)
			{
				num ^= this.PriceId.GetHashCode();
			}
			if (this.PriceType != 0)
			{
				num ^= this.PriceType.GetHashCode();
			}
			if (this.PurchaseLimitCount != 0)
			{
				num ^= this.PurchaseLimitCount.GetHashCode();
			}
			if (this.PurchaseLimitType != 0)
			{
				num ^= this.PurchaseLimitType.GetHashCode();
			}
			if (this.SortId != 0)
			{
				num ^= this.SortId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046AFA RID: 289530 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046AFB RID: 289531 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046AFC RID: 289532 RVA: 0x011307AC File Offset: 0x0112E9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemCount);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ItemType);
			}
			if (this.PriceCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PriceCount);
			}
			if (this.PriceId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PriceId);
			}
			if (this.PriceType != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PriceType);
			}
			if (this.PurchaseLimitCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PurchaseLimitCount);
			}
			if (this.PurchaseLimitType != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PurchaseLimitType);
			}
			if (this.SortId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046AFD RID: 289533 RVA: 0x01130900 File Offset: 0x0112EB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemType);
			}
			if (this.PriceCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PriceCount);
			}
			if (this.PriceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PriceId);
			}
			if (this.PriceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PriceType);
			}
			if (this.PurchaseLimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PurchaseLimitCount);
			}
			if (this.PurchaseLimitType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PurchaseLimitType);
			}
			if (this.SortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SortId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046AFE RID: 289534 RVA: 0x01130A30 File Offset: 0x0112EC30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingBuyItemTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemType != 0)
			{
				this.ItemType = other.ItemType;
			}
			if (other.PriceCount != 0)
			{
				this.PriceCount = other.PriceCount;
			}
			if (other.PriceId != 0)
			{
				this.PriceId = other.PriceId;
			}
			if (other.PriceType != 0)
			{
				this.PriceType = other.PriceType;
			}
			if (other.PurchaseLimitCount != 0)
			{
				this.PurchaseLimitCount = other.PurchaseLimitCount;
			}
			if (other.PurchaseLimitType != 0)
			{
				this.PurchaseLimitType = other.PurchaseLimitType;
			}
			if (other.SortId != 0)
			{
				this.SortId = other.SortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046AFF RID: 289535 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046B00 RID: 289536 RVA: 0x01130B34 File Offset: 0x0112ED34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.GroupId = input.ReadInt32();
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
							this.ItemCount = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.ItemId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.ItemType = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.PriceCount = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PriceId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.PriceType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.PurchaseLimitCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.PurchaseLimitType = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.SortId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402E9DA RID: 190938
		private static readonly MessageParser<FishingBuyItemTable> _parser = new MessageParser<FishingBuyItemTable>(() => new FishingBuyItemTable());

		// Token: 0x0402E9DB RID: 190939
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402E9DC RID: 190940
		public const int GroupIdFieldNumber = 1;

		// Token: 0x0402E9DD RID: 190941
		private int groupId_;

		// Token: 0x0402E9DE RID: 190942
		public const int IdFieldNumber = 2;

		// Token: 0x0402E9DF RID: 190943
		private int id_;

		// Token: 0x0402E9E0 RID: 190944
		public const int ItemCountFieldNumber = 3;

		// Token: 0x0402E9E1 RID: 190945
		private int itemCount_;

		// Token: 0x0402E9E2 RID: 190946
		public const int ItemIdFieldNumber = 4;

		// Token: 0x0402E9E3 RID: 190947
		private int itemId_;

		// Token: 0x0402E9E4 RID: 190948
		public const int ItemTypeFieldNumber = 5;

		// Token: 0x0402E9E5 RID: 190949
		private int itemType_;

		// Token: 0x0402E9E6 RID: 190950
		public const int PriceCountFieldNumber = 6;

		// Token: 0x0402E9E7 RID: 190951
		private int priceCount_;

		// Token: 0x0402E9E8 RID: 190952
		public const int PriceIdFieldNumber = 7;

		// Token: 0x0402E9E9 RID: 190953
		private int priceId_;

		// Token: 0x0402E9EA RID: 190954
		public const int PriceTypeFieldNumber = 8;

		// Token: 0x0402E9EB RID: 190955
		private int priceType_;

		// Token: 0x0402E9EC RID: 190956
		public const int PurchaseLimitCountFieldNumber = 9;

		// Token: 0x0402E9ED RID: 190957
		private int purchaseLimitCount_;

		// Token: 0x0402E9EE RID: 190958
		public const int PurchaseLimitTypeFieldNumber = 10;

		// Token: 0x0402E9EF RID: 190959
		private int purchaseLimitType_;

		// Token: 0x0402E9F0 RID: 190960
		public const int SortIdFieldNumber = 11;

		// Token: 0x0402E9F1 RID: 190961
		private int sortId_;
	}
}
