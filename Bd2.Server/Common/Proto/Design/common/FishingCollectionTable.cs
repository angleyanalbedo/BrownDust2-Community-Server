using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C7F RID: 31871
	public sealed class FishingCollectionTable : IMessage<FishingCollectionTable>, IMessage, IEquatable<FishingCollectionTable>, IDeepCloneable<FishingCollectionTable>, IBufferMessage
	{
		// Token: 0x170111A9 RID: 70057
		// (get) Token: 0x06046B43 RID: 289603 RVA: 0x0113174B File Offset: 0x0112F94B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingCollectionTable> Parser
		{
			get
			{
				return FishingCollectionTable._parser;
			}
		}

		// Token: 0x170111AA RID: 70058
		// (get) Token: 0x06046B44 RID: 289604 RVA: 0x01131752 File Offset: 0x0112F952
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingCollectionTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170111AB RID: 70059
		// (get) Token: 0x06046B45 RID: 289605 RVA: 0x01131764 File Offset: 0x0112F964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCollectionTable.Descriptor;
			}
		}

		// Token: 0x06046B46 RID: 289606 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCollectionTable()
		{
		}

		// Token: 0x06046B47 RID: 289607 RVA: 0x0113176B File Offset: 0x0112F96B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCollectionTable(FishingCollectionTable other)
			: this()
		{
			this.fishId_ = other.fishId_;
			this.id_ = other.id_;
			this.sortId_ = other.sortId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046B48 RID: 289608 RVA: 0x011317A8 File Offset: 0x0112F9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCollectionTable Clone()
		{
			return new FishingCollectionTable(this);
		}

		// Token: 0x170111AC RID: 70060
		// (get) Token: 0x06046B49 RID: 289609 RVA: 0x011317B0 File Offset: 0x0112F9B0
		// (set) Token: 0x06046B4A RID: 289610 RVA: 0x011317B8 File Offset: 0x0112F9B8
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

		// Token: 0x170111AD RID: 70061
		// (get) Token: 0x06046B4B RID: 289611 RVA: 0x011317C1 File Offset: 0x0112F9C1
		// (set) Token: 0x06046B4C RID: 289612 RVA: 0x011317C9 File Offset: 0x0112F9C9
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

		// Token: 0x170111AE RID: 70062
		// (get) Token: 0x06046B4D RID: 289613 RVA: 0x011317D2 File Offset: 0x0112F9D2
		// (set) Token: 0x06046B4E RID: 289614 RVA: 0x011317DA File Offset: 0x0112F9DA
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

		// Token: 0x06046B4F RID: 289615 RVA: 0x011317E3 File Offset: 0x0112F9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCollectionTable);
		}

		// Token: 0x06046B50 RID: 289616 RVA: 0x011317F4 File Offset: 0x0112F9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCollectionTable other)
		{
			return other != null && (other == this || (this.FishId == other.FishId && this.Id == other.Id && this.SortId == other.SortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046B51 RID: 289617 RVA: 0x01131850 File Offset: 0x0112FA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FishId != 0)
			{
				num ^= this.FishId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
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

		// Token: 0x06046B52 RID: 289618 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046B53 RID: 289619 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046B54 RID: 289620 RVA: 0x011318C4 File Offset: 0x0112FAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FishId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FishId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.SortId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046B55 RID: 289621 RVA: 0x01131938 File Offset: 0x0112FB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FishId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
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

		// Token: 0x06046B56 RID: 289622 RVA: 0x011319A8 File Offset: 0x0112FBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCollectionTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FishId != 0)
			{
				this.FishId = other.FishId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.SortId != 0)
			{
				this.SortId = other.SortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046B57 RID: 289623 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046B58 RID: 289624 RVA: 0x01131A0C File Offset: 0x0112FC0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SortId = input.ReadInt32();
						}
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.FishId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0402EA0C RID: 190988
		private static readonly MessageParser<FishingCollectionTable> _parser = new MessageParser<FishingCollectionTable>(() => new FishingCollectionTable());

		// Token: 0x0402EA0D RID: 190989
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EA0E RID: 190990
		public const int FishIdFieldNumber = 1;

		// Token: 0x0402EA0F RID: 190991
		private int fishId_;

		// Token: 0x0402EA10 RID: 190992
		public const int IdFieldNumber = 2;

		// Token: 0x0402EA11 RID: 190993
		private int id_;

		// Token: 0x0402EA12 RID: 190994
		public const int SortIdFieldNumber = 3;

		// Token: 0x0402EA13 RID: 190995
		private int sortId_;
	}
}
