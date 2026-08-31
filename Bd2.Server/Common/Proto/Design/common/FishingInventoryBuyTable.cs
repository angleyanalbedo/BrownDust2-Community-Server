using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C94 RID: 31892
	public sealed class FishingInventoryBuyTable : IMessage<FishingInventoryBuyTable>, IMessage, IEquatable<FishingInventoryBuyTable>, IDeepCloneable<FishingInventoryBuyTable>, IBufferMessage
	{
		// Token: 0x17011229 RID: 70185
		// (get) Token: 0x06046C9A RID: 289946 RVA: 0x01137303 File Offset: 0x01135503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingInventoryBuyTable> Parser
		{
			get
			{
				return FishingInventoryBuyTable._parser;
			}
		}

		// Token: 0x1701122A RID: 70186
		// (get) Token: 0x06046C9B RID: 289947 RVA: 0x0113730A File Offset: 0x0113550A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingInventoryBuyTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1701122B RID: 70187
		// (get) Token: 0x06046C9C RID: 289948 RVA: 0x0113731C File Offset: 0x0113551C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInventoryBuyTable.Descriptor;
			}
		}

		// Token: 0x06046C9D RID: 289949 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInventoryBuyTable()
		{
		}

		// Token: 0x06046C9E RID: 289950 RVA: 0x01137324 File Offset: 0x01135524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingInventoryBuyTable(FishingInventoryBuyTable other)
			: this()
		{
			this.costCount_ = other.costCount_;
			this.costId_ = other.costId_;
			this.costType_ = other.costType_;
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046C9F RID: 289951 RVA: 0x01137384 File Offset: 0x01135584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingInventoryBuyTable Clone()
		{
			return new FishingInventoryBuyTable(this);
		}

		// Token: 0x1701122C RID: 70188
		// (get) Token: 0x06046CA0 RID: 289952 RVA: 0x0113738C File Offset: 0x0113558C
		// (set) Token: 0x06046CA1 RID: 289953 RVA: 0x01137394 File Offset: 0x01135594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CostCount
		{
			get
			{
				return this.costCount_;
			}
			set
			{
				this.costCount_ = value;
			}
		}

		// Token: 0x1701122D RID: 70189
		// (get) Token: 0x06046CA2 RID: 289954 RVA: 0x0113739D File Offset: 0x0113559D
		// (set) Token: 0x06046CA3 RID: 289955 RVA: 0x011373A5 File Offset: 0x011355A5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CostId
		{
			get
			{
				return this.costId_;
			}
			set
			{
				this.costId_ = value;
			}
		}

		// Token: 0x1701122E RID: 70190
		// (get) Token: 0x06046CA4 RID: 289956 RVA: 0x011373AE File Offset: 0x011355AE
		// (set) Token: 0x06046CA5 RID: 289957 RVA: 0x011373B6 File Offset: 0x011355B6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CostType
		{
			get
			{
				return this.costType_;
			}
			set
			{
				this.costType_ = value;
			}
		}

		// Token: 0x1701122F RID: 70191
		// (get) Token: 0x06046CA6 RID: 289958 RVA: 0x011373BF File Offset: 0x011355BF
		// (set) Token: 0x06046CA7 RID: 289959 RVA: 0x011373C7 File Offset: 0x011355C7
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

		// Token: 0x17011230 RID: 70192
		// (get) Token: 0x06046CA8 RID: 289960 RVA: 0x011373D0 File Offset: 0x011355D0
		// (set) Token: 0x06046CA9 RID: 289961 RVA: 0x011373D8 File Offset: 0x011355D8
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

		// Token: 0x06046CAA RID: 289962 RVA: 0x011373E1 File Offset: 0x011355E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInventoryBuyTable);
		}

		// Token: 0x06046CAB RID: 289963 RVA: 0x011373F0 File Offset: 0x011355F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInventoryBuyTable other)
		{
			return other != null && (other == this || (this.CostCount == other.CostCount && this.CostId == other.CostId && this.CostType == other.CostType && this.GroupId == other.GroupId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046CAC RID: 289964 RVA: 0x0113746C File Offset: 0x0113566C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CostCount != 0)
			{
				num ^= this.CostCount.GetHashCode();
			}
			if (this.CostId != 0)
			{
				num ^= this.CostId.GetHashCode();
			}
			if (this.CostType != 0)
			{
				num ^= this.CostType.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046CAD RID: 289965 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046CAE RID: 289966 RVA: 0x001D568A File Offset: 0x001D388A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046CAF RID: 289967 RVA: 0x01137510 File Offset: 0x01135710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CostCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CostCount);
			}
			if (this.CostId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CostId);
			}
			if (this.CostType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CostType);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GroupId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046CB0 RID: 289968 RVA: 0x011375BC File Offset: 0x011357BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CostCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostCount);
			}
			if (this.CostId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostId);
			}
			if (this.CostType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostType);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046CB1 RID: 289969 RVA: 0x0113765C File Offset: 0x0113585C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInventoryBuyTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CostCount != 0)
			{
				this.CostCount = other.CostCount;
			}
			if (other.CostId != 0)
			{
				this.CostId = other.CostId;
			}
			if (other.CostType != 0)
			{
				this.CostType = other.CostType;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046CB2 RID: 289970 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046CB3 RID: 289971 RVA: 0x011376E8 File Offset: 0x011358E8
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
						this.CostCount = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CostId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CostType = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EAFB RID: 191227
		private static readonly MessageParser<FishingInventoryBuyTable> _parser = new MessageParser<FishingInventoryBuyTable>(() => new FishingInventoryBuyTable());

		// Token: 0x0402EAFC RID: 191228
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EAFD RID: 191229
		public const int CostCountFieldNumber = 1;

		// Token: 0x0402EAFE RID: 191230
		private int costCount_;

		// Token: 0x0402EAFF RID: 191231
		public const int CostIdFieldNumber = 2;

		// Token: 0x0402EB00 RID: 191232
		private int costId_;

		// Token: 0x0402EB01 RID: 191233
		public const int CostTypeFieldNumber = 3;

		// Token: 0x0402EB02 RID: 191234
		private int costType_;

		// Token: 0x0402EB03 RID: 191235
		public const int GroupIdFieldNumber = 4;

		// Token: 0x0402EB04 RID: 191236
		private int groupId_;

		// Token: 0x0402EB05 RID: 191237
		public const int IdFieldNumber = 5;

		// Token: 0x0402EB06 RID: 191238
		private int id_;
	}
}
