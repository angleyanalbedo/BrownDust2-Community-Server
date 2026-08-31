using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C85 RID: 31877
	public sealed class FishingFishPoolTable : IMessage<FishingFishPoolTable>, IMessage, IEquatable<FishingFishPoolTable>, IDeepCloneable<FishingFishPoolTable>, IBufferMessage
	{
		// Token: 0x170111E6 RID: 70118
		// (get) Token: 0x06046BD6 RID: 289750 RVA: 0x011345BB File Offset: 0x011327BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingFishPoolTable> Parser
		{
			get
			{
				return FishingFishPoolTable._parser;
			}
		}

		// Token: 0x170111E7 RID: 70119
		// (get) Token: 0x06046BD7 RID: 289751 RVA: 0x011345C2 File Offset: 0x011327C2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingFishPoolTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170111E8 RID: 70120
		// (get) Token: 0x06046BD8 RID: 289752 RVA: 0x011345D4 File Offset: 0x011327D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingFishPoolTable.Descriptor;
			}
		}

		// Token: 0x06046BD9 RID: 289753 RVA: 0x011345DB File Offset: 0x011327DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishPoolTable()
		{
		}

		// Token: 0x06046BDA RID: 289754 RVA: 0x011345FC File Offset: 0x011327FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingFishPoolTable(FishingFishPoolTable other)
			: this()
		{
			this.fishId_ = other.fishId_.Clone();
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this.ratio_ = other.ratio_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046BDB RID: 289755 RVA: 0x0113465A File Offset: 0x0113285A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishPoolTable Clone()
		{
			return new FishingFishPoolTable(this);
		}

		// Token: 0x170111E9 RID: 70121
		// (get) Token: 0x06046BDC RID: 289756 RVA: 0x01134662 File Offset: 0x01132862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FishId
		{
			get
			{
				return this.fishId_;
			}
		}

		// Token: 0x170111EA RID: 70122
		// (get) Token: 0x06046BDD RID: 289757 RVA: 0x0113466A File Offset: 0x0113286A
		// (set) Token: 0x06046BDE RID: 289758 RVA: 0x01134672 File Offset: 0x01132872
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

		// Token: 0x170111EB RID: 70123
		// (get) Token: 0x06046BDF RID: 289759 RVA: 0x0113467B File Offset: 0x0113287B
		// (set) Token: 0x06046BE0 RID: 289760 RVA: 0x01134683 File Offset: 0x01132883
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

		// Token: 0x170111EC RID: 70124
		// (get) Token: 0x06046BE1 RID: 289761 RVA: 0x0113468C File Offset: 0x0113288C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ratio
		{
			get
			{
				return this.ratio_;
			}
		}

		// Token: 0x06046BE2 RID: 289762 RVA: 0x01134694 File Offset: 0x01132894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingFishPoolTable);
		}

		// Token: 0x06046BE3 RID: 289763 RVA: 0x011346A4 File Offset: 0x011328A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingFishPoolTable other)
		{
			return other != null && (other == this || (this.fishId_.Equals(other.fishId_) && this.GroupId == other.GroupId && this.Id == other.Id && this.ratio_.Equals(other.ratio_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046BE4 RID: 289764 RVA: 0x01134718 File Offset: 0x01132918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fishId_.GetHashCode();
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.ratio_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046BE5 RID: 289765 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046BE6 RID: 289766 RVA: 0x001D568A File Offset: 0x001D388A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046BE7 RID: 289767 RVA: 0x0113478C File Offset: 0x0113298C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fishId_.WriteTo(ref output, FishingFishPoolTable._repeated_fishId_codec);
			if (this.GroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			this.ratio_.WriteTo(ref output, FishingFishPoolTable._repeated_ratio_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046BE8 RID: 289768 RVA: 0x01134808 File Offset: 0x01132A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fishId_.CalculateSize(FishingFishPoolTable._repeated_fishId_codec);
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.ratio_.CalculateSize(FishingFishPoolTable._repeated_ratio_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046BE9 RID: 289769 RVA: 0x01134884 File Offset: 0x01132A84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingFishPoolTable other)
		{
			if (other == null)
			{
				return;
			}
			this.fishId_.Add(other.fishId_);
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.ratio_.Add(other.ratio_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046BEA RID: 289770 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046BEB RID: 289771 RVA: 0x011348F8 File Offset: 0x01132AF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.fishId_.AddEntriesFrom(ref input, FishingFishPoolTable._repeated_fishId_codec);
						continue;
					}
					if (num == 16U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.ratio_.AddEntriesFrom(ref input, FishingFishPoolTable._repeated_ratio_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EA81 RID: 191105
		private static readonly MessageParser<FishingFishPoolTable> _parser = new MessageParser<FishingFishPoolTable>(() => new FishingFishPoolTable());

		// Token: 0x0402EA82 RID: 191106
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EA83 RID: 191107
		public const int FishIdFieldNumber = 1;

		// Token: 0x0402EA84 RID: 191108
		private static readonly FieldCodec<int> _repeated_fishId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0402EA85 RID: 191109
		private readonly RepeatedField<int> fishId_ = new RepeatedField<int>();

		// Token: 0x0402EA86 RID: 191110
		public const int GroupIdFieldNumber = 2;

		// Token: 0x0402EA87 RID: 191111
		private int groupId_;

		// Token: 0x0402EA88 RID: 191112
		public const int IdFieldNumber = 3;

		// Token: 0x0402EA89 RID: 191113
		private int id_;

		// Token: 0x0402EA8A RID: 191114
		public const int RatioFieldNumber = 4;

		// Token: 0x0402EA8B RID: 191115
		private static readonly FieldCodec<int> _repeated_ratio_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0402EA8C RID: 191116
		private readonly RepeatedField<int> ratio_ = new RepeatedField<int>();
	}
}
