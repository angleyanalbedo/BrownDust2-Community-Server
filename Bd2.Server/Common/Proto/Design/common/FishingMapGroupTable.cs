using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C9A RID: 31898
	public sealed class FishingMapGroupTable : IMessage<FishingMapGroupTable>, IMessage, IEquatable<FishingMapGroupTable>, IDeepCloneable<FishingMapGroupTable>, IBufferMessage
	{
		// Token: 0x1701123C RID: 70204
		// (get) Token: 0x06046CDB RID: 290011 RVA: 0x01137EF0 File Offset: 0x011360F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingMapGroupTable> Parser
		{
			get
			{
				return FishingMapGroupTable._parser;
			}
		}

		// Token: 0x1701123D RID: 70205
		// (get) Token: 0x06046CDC RID: 290012 RVA: 0x01137EF7 File Offset: 0x011360F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingMapGroupTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1701123E RID: 70206
		// (get) Token: 0x06046CDD RID: 290013 RVA: 0x01137F09 File Offset: 0x01136109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingMapGroupTable.Descriptor;
			}
		}

		// Token: 0x06046CDE RID: 290014 RVA: 0x01137F10 File Offset: 0x01136110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingMapGroupTable()
		{
		}

		// Token: 0x06046CDF RID: 290015 RVA: 0x01137F30 File Offset: 0x01136130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingMapGroupTable(FishingMapGroupTable other)
			: this()
		{
			this.costCount_ = other.costCount_;
			this.costId_ = other.costId_;
			this.costType_ = other.costType_;
			this.descLocalTextId_ = other.descLocalTextId_;
			this.id_ = other.id_;
			this.mapBackGround_ = other.mapBackGround_;
			this.mapIcon_ = other.mapIcon_;
			this.nameTextId_ = other.nameTextId_;
			this.recommendFishingLevel_ = other.recommendFishingLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046CE0 RID: 290016 RVA: 0x01137FC0 File Offset: 0x011361C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingMapGroupTable Clone()
		{
			return new FishingMapGroupTable(this);
		}

		// Token: 0x1701123F RID: 70207
		// (get) Token: 0x06046CE1 RID: 290017 RVA: 0x01137FC8 File Offset: 0x011361C8
		// (set) Token: 0x06046CE2 RID: 290018 RVA: 0x01137FD0 File Offset: 0x011361D0
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

		// Token: 0x17011240 RID: 70208
		// (get) Token: 0x06046CE3 RID: 290019 RVA: 0x01137FD9 File Offset: 0x011361D9
		// (set) Token: 0x06046CE4 RID: 290020 RVA: 0x01137FE1 File Offset: 0x011361E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17011241 RID: 70209
		// (get) Token: 0x06046CE5 RID: 290021 RVA: 0x01137FEA File Offset: 0x011361EA
		// (set) Token: 0x06046CE6 RID: 290022 RVA: 0x01137FF2 File Offset: 0x011361F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17011242 RID: 70210
		// (get) Token: 0x06046CE7 RID: 290023 RVA: 0x01137FFB File Offset: 0x011361FB
		// (set) Token: 0x06046CE8 RID: 290024 RVA: 0x01138003 File Offset: 0x01136203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DescLocalTextId
		{
			get
			{
				return this.descLocalTextId_;
			}
			set
			{
				this.descLocalTextId_ = value;
			}
		}

		// Token: 0x17011243 RID: 70211
		// (get) Token: 0x06046CE9 RID: 290025 RVA: 0x0113800C File Offset: 0x0113620C
		// (set) Token: 0x06046CEA RID: 290026 RVA: 0x01138014 File Offset: 0x01136214
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

		// Token: 0x17011244 RID: 70212
		// (get) Token: 0x06046CEB RID: 290027 RVA: 0x0113801D File Offset: 0x0113621D
		// (set) Token: 0x06046CEC RID: 290028 RVA: 0x01138025 File Offset: 0x01136225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MapBackGround
		{
			get
			{
				return this.mapBackGround_;
			}
			set
			{
				this.mapBackGround_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011245 RID: 70213
		// (get) Token: 0x06046CED RID: 290029 RVA: 0x01138038 File Offset: 0x01136238
		// (set) Token: 0x06046CEE RID: 290030 RVA: 0x01138040 File Offset: 0x01136240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MapIcon
		{
			get
			{
				return this.mapIcon_;
			}
			set
			{
				this.mapIcon_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011246 RID: 70214
		// (get) Token: 0x06046CEF RID: 290031 RVA: 0x01138053 File Offset: 0x01136253
		// (set) Token: 0x06046CF0 RID: 290032 RVA: 0x0113805B File Offset: 0x0113625B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NameTextId
		{
			get
			{
				return this.nameTextId_;
			}
			set
			{
				this.nameTextId_ = value;
			}
		}

		// Token: 0x17011247 RID: 70215
		// (get) Token: 0x06046CF1 RID: 290033 RVA: 0x01138064 File Offset: 0x01136264
		// (set) Token: 0x06046CF2 RID: 290034 RVA: 0x0113806C File Offset: 0x0113626C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecommendFishingLevel
		{
			get
			{
				return this.recommendFishingLevel_;
			}
			set
			{
				this.recommendFishingLevel_ = value;
			}
		}

		// Token: 0x06046CF3 RID: 290035 RVA: 0x01138075 File Offset: 0x01136275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingMapGroupTable);
		}

		// Token: 0x06046CF4 RID: 290036 RVA: 0x01138084 File Offset: 0x01136284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingMapGroupTable other)
		{
			return other != null && (other == this || (this.CostCount == other.CostCount && this.CostId == other.CostId && this.CostType == other.CostType && this.DescLocalTextId == other.DescLocalTextId && this.Id == other.Id && !(this.MapBackGround != other.MapBackGround) && !(this.MapIcon != other.MapIcon) && this.NameTextId == other.NameTextId && this.RecommendFishingLevel == other.RecommendFishingLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046CF5 RID: 290037 RVA: 0x01138148 File Offset: 0x01136348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
			if (this.DescLocalTextId != 0)
			{
				num ^= this.DescLocalTextId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MapBackGround.Length != 0)
			{
				num ^= this.MapBackGround.GetHashCode();
			}
			if (this.MapIcon.Length != 0)
			{
				num ^= this.MapIcon.GetHashCode();
			}
			if (this.NameTextId != 0)
			{
				num ^= this.NameTextId.GetHashCode();
			}
			if (this.RecommendFishingLevel != 0)
			{
				num ^= this.RecommendFishingLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046CF6 RID: 290038 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046CF7 RID: 290039 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046CF8 RID: 290040 RVA: 0x01138254 File Offset: 0x01136454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
			if (this.DescLocalTextId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DescLocalTextId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this.MapBackGround.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.MapBackGround);
			}
			if (this.MapIcon.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.MapIcon);
			}
			if (this.NameTextId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.NameTextId);
			}
			if (this.RecommendFishingLevel != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RecommendFishingLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046CF9 RID: 290041 RVA: 0x0113837C File Offset: 0x0113657C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
			if (this.DescLocalTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DescLocalTextId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MapBackGround.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MapBackGround);
			}
			if (this.MapIcon.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MapIcon);
			}
			if (this.NameTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NameTextId);
			}
			if (this.RecommendFishingLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecommendFishingLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046CFA RID: 290042 RVA: 0x01138484 File Offset: 0x01136684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingMapGroupTable other)
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
			if (other.DescLocalTextId != 0)
			{
				this.DescLocalTextId = other.DescLocalTextId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MapBackGround.Length != 0)
			{
				this.MapBackGround = other.MapBackGround;
			}
			if (other.MapIcon.Length != 0)
			{
				this.MapIcon = other.MapIcon;
			}
			if (other.NameTextId != 0)
			{
				this.NameTextId = other.NameTextId;
			}
			if (other.RecommendFishingLevel != 0)
			{
				this.RecommendFishingLevel = other.RecommendFishingLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046CFB RID: 290043 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046CFC RID: 290044 RVA: 0x0113856C File Offset: 0x0113676C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
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
							this.DescLocalTextId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.MapBackGround = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.MapIcon = input.ReadString();
						continue;
					}
					if (num == 64U)
					{
						this.NameTextId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.RecommendFishingLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EB1A RID: 191258
		private static readonly MessageParser<FishingMapGroupTable> _parser = new MessageParser<FishingMapGroupTable>(() => new FishingMapGroupTable());

		// Token: 0x0402EB1B RID: 191259
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EB1C RID: 191260
		public const int CostCountFieldNumber = 1;

		// Token: 0x0402EB1D RID: 191261
		private int costCount_;

		// Token: 0x0402EB1E RID: 191262
		public const int CostIdFieldNumber = 2;

		// Token: 0x0402EB1F RID: 191263
		private int costId_;

		// Token: 0x0402EB20 RID: 191264
		public const int CostTypeFieldNumber = 3;

		// Token: 0x0402EB21 RID: 191265
		private int costType_;

		// Token: 0x0402EB22 RID: 191266
		public const int DescLocalTextIdFieldNumber = 4;

		// Token: 0x0402EB23 RID: 191267
		private int descLocalTextId_;

		// Token: 0x0402EB24 RID: 191268
		public const int IdFieldNumber = 5;

		// Token: 0x0402EB25 RID: 191269
		private int id_;

		// Token: 0x0402EB26 RID: 191270
		public const int MapBackGroundFieldNumber = 6;

		// Token: 0x0402EB27 RID: 191271
		private string mapBackGround_ = "";

		// Token: 0x0402EB28 RID: 191272
		public const int MapIconFieldNumber = 7;

		// Token: 0x0402EB29 RID: 191273
		private string mapIcon_ = "";

		// Token: 0x0402EB2A RID: 191274
		public const int NameTextIdFieldNumber = 8;

		// Token: 0x0402EB2B RID: 191275
		private int nameTextId_;

		// Token: 0x0402EB2C RID: 191276
		public const int RecommendFishingLevelFieldNumber = 9;

		// Token: 0x0402EB2D RID: 191277
		private int recommendFishingLevel_;
	}
}
