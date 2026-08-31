using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CA6 RID: 31910
	public sealed class FishingSellItemTable : IMessage<FishingSellItemTable>, IMessage, IEquatable<FishingSellItemTable>, IDeepCloneable<FishingSellItemTable>, IBufferMessage
	{
		// Token: 0x17011265 RID: 70245
		// (get) Token: 0x06046D61 RID: 290145 RVA: 0x011398EB File Offset: 0x01137AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingSellItemTable> Parser
		{
			get
			{
				return FishingSellItemTable._parser;
			}
		}

		// Token: 0x17011266 RID: 70246
		// (get) Token: 0x06046D62 RID: 290146 RVA: 0x011398F2 File Offset: 0x01137AF2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingSellItemTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011267 RID: 70247
		// (get) Token: 0x06046D63 RID: 290147 RVA: 0x01139904 File Offset: 0x01137B04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellItemTable.Descriptor;
			}
		}

		// Token: 0x06046D64 RID: 290148 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellItemTable()
		{
		}

		// Token: 0x06046D65 RID: 290149 RVA: 0x0113990C File Offset: 0x01137B0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingSellItemTable(FishingSellItemTable other)
			: this()
		{
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this.itemId_ = other.itemId_;
			this.itemType_ = other.itemType_;
			this.priceCount_ = other.priceCount_;
			this.priceId_ = other.priceId_;
			this.priceType_ = other.priceType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046D66 RID: 290150 RVA: 0x01139984 File Offset: 0x01137B84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingSellItemTable Clone()
		{
			return new FishingSellItemTable(this);
		}

		// Token: 0x17011268 RID: 70248
		// (get) Token: 0x06046D67 RID: 290151 RVA: 0x0113998C File Offset: 0x01137B8C
		// (set) Token: 0x06046D68 RID: 290152 RVA: 0x01139994 File Offset: 0x01137B94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17011269 RID: 70249
		// (get) Token: 0x06046D69 RID: 290153 RVA: 0x0113999D File Offset: 0x01137B9D
		// (set) Token: 0x06046D6A RID: 290154 RVA: 0x011399A5 File Offset: 0x01137BA5
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

		// Token: 0x1701126A RID: 70250
		// (get) Token: 0x06046D6B RID: 290155 RVA: 0x011399AE File Offset: 0x01137BAE
		// (set) Token: 0x06046D6C RID: 290156 RVA: 0x011399B6 File Offset: 0x01137BB6
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

		// Token: 0x1701126B RID: 70251
		// (get) Token: 0x06046D6D RID: 290157 RVA: 0x011399BF File Offset: 0x01137BBF
		// (set) Token: 0x06046D6E RID: 290158 RVA: 0x011399C7 File Offset: 0x01137BC7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1701126C RID: 70252
		// (get) Token: 0x06046D6F RID: 290159 RVA: 0x011399D0 File Offset: 0x01137BD0
		// (set) Token: 0x06046D70 RID: 290160 RVA: 0x011399D8 File Offset: 0x01137BD8
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

		// Token: 0x1701126D RID: 70253
		// (get) Token: 0x06046D71 RID: 290161 RVA: 0x011399E1 File Offset: 0x01137BE1
		// (set) Token: 0x06046D72 RID: 290162 RVA: 0x011399E9 File Offset: 0x01137BE9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1701126E RID: 70254
		// (get) Token: 0x06046D73 RID: 290163 RVA: 0x011399F2 File Offset: 0x01137BF2
		// (set) Token: 0x06046D74 RID: 290164 RVA: 0x011399FA File Offset: 0x01137BFA
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

		// Token: 0x06046D75 RID: 290165 RVA: 0x01139A03 File Offset: 0x01137C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellItemTable);
		}

		// Token: 0x06046D76 RID: 290166 RVA: 0x01139A14 File Offset: 0x01137C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellItemTable other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Id == other.Id && this.ItemId == other.ItemId && this.ItemType == other.ItemType && this.PriceCount == other.PriceCount && this.PriceId == other.PriceId && this.PriceType == other.PriceType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046D77 RID: 290167 RVA: 0x01139AB0 File Offset: 0x01137CB0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046D78 RID: 290168 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046D79 RID: 290169 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046D7A RID: 290170 RVA: 0x01139B88 File Offset: 0x01137D88
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
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemType);
			}
			if (this.PriceCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PriceCount);
			}
			if (this.PriceId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PriceId);
			}
			if (this.PriceType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PriceType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046D7B RID: 290171 RVA: 0x01139C6C File Offset: 0x01137E6C
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046D7C RID: 290172 RVA: 0x01139D3C File Offset: 0x01137F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellItemTable other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046D7D RID: 290173 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046D7E RID: 290174 RVA: 0x01139DF0 File Offset: 0x01137FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.ItemType = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.PriceCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.PriceId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PriceType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EB60 RID: 191328
		private static readonly MessageParser<FishingSellItemTable> _parser = new MessageParser<FishingSellItemTable>(() => new FishingSellItemTable());

		// Token: 0x0402EB61 RID: 191329
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EB62 RID: 191330
		public const int GroupIdFieldNumber = 1;

		// Token: 0x0402EB63 RID: 191331
		private int groupId_;

		// Token: 0x0402EB64 RID: 191332
		public const int IdFieldNumber = 2;

		// Token: 0x0402EB65 RID: 191333
		private int id_;

		// Token: 0x0402EB66 RID: 191334
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0402EB67 RID: 191335
		private int itemId_;

		// Token: 0x0402EB68 RID: 191336
		public const int ItemTypeFieldNumber = 4;

		// Token: 0x0402EB69 RID: 191337
		private int itemType_;

		// Token: 0x0402EB6A RID: 191338
		public const int PriceCountFieldNumber = 5;

		// Token: 0x0402EB6B RID: 191339
		private int priceCount_;

		// Token: 0x0402EB6C RID: 191340
		public const int PriceIdFieldNumber = 6;

		// Token: 0x0402EB6D RID: 191341
		private int priceId_;

		// Token: 0x0402EB6E RID: 191342
		public const int PriceTypeFieldNumber = 7;

		// Token: 0x0402EB6F RID: 191343
		private int priceType_;
	}
}
