using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C70 RID: 31856
	public sealed class FishingBoatTable : IMessage<FishingBoatTable>, IMessage, IEquatable<FishingBoatTable>, IDeepCloneable<FishingBoatTable>, IBufferMessage
	{
		// Token: 0x17011173 RID: 70003
		// (get) Token: 0x06046A94 RID: 289428 RVA: 0x0112F5FC File Offset: 0x0112D7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingBoatTable> Parser
		{
			get
			{
				return FishingBoatTable._parser;
			}
		}

		// Token: 0x17011174 RID: 70004
		// (get) Token: 0x06046A95 RID: 289429 RVA: 0x0112F603 File Offset: 0x0112D803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingBoatTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011175 RID: 70005
		// (get) Token: 0x06046A96 RID: 289430 RVA: 0x0112F615 File Offset: 0x0112D815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingBoatTable.Descriptor;
			}
		}

		// Token: 0x06046A97 RID: 289431 RVA: 0x0112F61C File Offset: 0x0112D81C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingBoatTable()
		{
		}

		// Token: 0x06046A98 RID: 289432 RVA: 0x0112F63C File Offset: 0x0112D83C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingBoatTable(FishingBoatTable other)
			: this()
		{
			this.boatBuffGroupId_ = other.boatBuffGroupId_.Clone();
			this.costCount_ = other.costCount_;
			this.costId_ = other.costId_;
			this.costType_ = other.costType_;
			this.designId_ = other.designId_.Clone();
			this.fishTrapFrequency_ = other.fishTrapFrequency_;
			this.fishTrapLevel_ = other.fishTrapLevel_;
			this.id_ = other.id_;
			this.multiCapacity_ = other.multiCapacity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046A99 RID: 289433 RVA: 0x0112F6D6 File Offset: 0x0112D8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatTable Clone()
		{
			return new FishingBoatTable(this);
		}

		// Token: 0x17011176 RID: 70006
		// (get) Token: 0x06046A9A RID: 289434 RVA: 0x0112F6DE File Offset: 0x0112D8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BoatBuffGroupId
		{
			get
			{
				return this.boatBuffGroupId_;
			}
		}

		// Token: 0x17011177 RID: 70007
		// (get) Token: 0x06046A9B RID: 289435 RVA: 0x0112F6E6 File Offset: 0x0112D8E6
		// (set) Token: 0x06046A9C RID: 289436 RVA: 0x0112F6EE File Offset: 0x0112D8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17011178 RID: 70008
		// (get) Token: 0x06046A9D RID: 289437 RVA: 0x0112F6F7 File Offset: 0x0112D8F7
		// (set) Token: 0x06046A9E RID: 289438 RVA: 0x0112F6FF File Offset: 0x0112D8FF
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

		// Token: 0x17011179 RID: 70009
		// (get) Token: 0x06046A9F RID: 289439 RVA: 0x0112F708 File Offset: 0x0112D908
		// (set) Token: 0x06046AA0 RID: 289440 RVA: 0x0112F710 File Offset: 0x0112D910
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

		// Token: 0x1701117A RID: 70010
		// (get) Token: 0x06046AA1 RID: 289441 RVA: 0x0112F719 File Offset: 0x0112D919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DesignId
		{
			get
			{
				return this.designId_;
			}
		}

		// Token: 0x1701117B RID: 70011
		// (get) Token: 0x06046AA2 RID: 289442 RVA: 0x0112F721 File Offset: 0x0112D921
		// (set) Token: 0x06046AA3 RID: 289443 RVA: 0x0112F729 File Offset: 0x0112D929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishTrapFrequency
		{
			get
			{
				return this.fishTrapFrequency_;
			}
			set
			{
				this.fishTrapFrequency_ = value;
			}
		}

		// Token: 0x1701117C RID: 70012
		// (get) Token: 0x06046AA4 RID: 289444 RVA: 0x0112F732 File Offset: 0x0112D932
		// (set) Token: 0x06046AA5 RID: 289445 RVA: 0x0112F73A File Offset: 0x0112D93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishTrapLevel
		{
			get
			{
				return this.fishTrapLevel_;
			}
			set
			{
				this.fishTrapLevel_ = value;
			}
		}

		// Token: 0x1701117D RID: 70013
		// (get) Token: 0x06046AA6 RID: 289446 RVA: 0x0112F743 File Offset: 0x0112D943
		// (set) Token: 0x06046AA7 RID: 289447 RVA: 0x0112F74B File Offset: 0x0112D94B
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

		// Token: 0x1701117E RID: 70014
		// (get) Token: 0x06046AA8 RID: 289448 RVA: 0x0112F754 File Offset: 0x0112D954
		// (set) Token: 0x06046AA9 RID: 289449 RVA: 0x0112F75C File Offset: 0x0112D95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MultiCapacity
		{
			get
			{
				return this.multiCapacity_;
			}
			set
			{
				this.multiCapacity_ = value;
			}
		}

		// Token: 0x06046AAA RID: 289450 RVA: 0x0112F765 File Offset: 0x0112D965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingBoatTable);
		}

		// Token: 0x06046AAB RID: 289451 RVA: 0x0112F774 File Offset: 0x0112D974
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingBoatTable other)
		{
			return other != null && (other == this || (this.boatBuffGroupId_.Equals(other.boatBuffGroupId_) && this.CostCount == other.CostCount && this.CostId == other.CostId && this.CostType == other.CostType && this.designId_.Equals(other.designId_) && this.FishTrapFrequency == other.FishTrapFrequency && this.FishTrapLevel == other.FishTrapLevel && this.Id == other.Id && this.MultiCapacity == other.MultiCapacity && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046AAC RID: 289452 RVA: 0x0112F838 File Offset: 0x0112DA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.boatBuffGroupId_.GetHashCode();
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
			num ^= this.designId_.GetHashCode();
			if (this.FishTrapFrequency != 0)
			{
				num ^= this.FishTrapFrequency.GetHashCode();
			}
			if (this.FishTrapLevel != 0)
			{
				num ^= this.FishTrapLevel.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MultiCapacity != 0)
			{
				num ^= this.MultiCapacity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046AAD RID: 289453 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046AAE RID: 289454 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046AAF RID: 289455 RVA: 0x0112F92C File Offset: 0x0112DB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.boatBuffGroupId_.WriteTo(ref output, FishingBoatTable._repeated_boatBuffGroupId_codec);
			if (this.CostCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CostCount);
			}
			if (this.CostId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CostId);
			}
			if (this.CostType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CostType);
			}
			this.designId_.WriteTo(ref output, FishingBoatTable._repeated_designId_codec);
			if (this.FishTrapFrequency != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FishTrapFrequency);
			}
			if (this.FishTrapLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FishTrapLevel);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this.MultiCapacity != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MultiCapacity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046AB0 RID: 289456 RVA: 0x0112FA34 File Offset: 0x0112DC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.boatBuffGroupId_.CalculateSize(FishingBoatTable._repeated_boatBuffGroupId_codec);
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
			num += this.designId_.CalculateSize(FishingBoatTable._repeated_designId_codec);
			if (this.FishTrapFrequency != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishTrapFrequency);
			}
			if (this.FishTrapLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishTrapLevel);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MultiCapacity != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MultiCapacity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046AB1 RID: 289457 RVA: 0x0112FB28 File Offset: 0x0112DD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingBoatTable other)
		{
			if (other == null)
			{
				return;
			}
			this.boatBuffGroupId_.Add(other.boatBuffGroupId_);
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
			this.designId_.Add(other.designId_);
			if (other.FishTrapFrequency != 0)
			{
				this.FishTrapFrequency = other.FishTrapFrequency;
			}
			if (other.FishTrapLevel != 0)
			{
				this.FishTrapLevel = other.FishTrapLevel;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MultiCapacity != 0)
			{
				this.MultiCapacity = other.MultiCapacity;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046AB2 RID: 289458 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046AB3 RID: 289459 RVA: 0x0112FC00 File Offset: 0x0112DE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.boatBuffGroupId_.AddEntriesFrom(ref input, FishingBoatTable._repeated_boatBuffGroupId_codec);
							continue;
						}
					}
					else
					{
						if (num == 16U)
						{
							this.CostCount = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.CostId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.CostType = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U || num == 42U)
					{
						this.designId_.AddEntriesFrom(ref input, FishingBoatTable._repeated_designId_codec);
						continue;
					}
					if (num == 48U)
					{
						this.FishTrapFrequency = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.FishTrapLevel = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.MultiCapacity = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x1701117F RID: 70015
		// (get) Token: 0x06046AB4 RID: 289460 RVA: 0x0112FD13 File Offset: 0x0112DF13
		public int Capacity
		{
			get
			{
				return this.MultiCapacity + 1;
			}
		}

		// Token: 0x0402E9B4 RID: 190900
		private static readonly MessageParser<FishingBoatTable> _parser = new MessageParser<FishingBoatTable>(() => new FishingBoatTable());

		// Token: 0x0402E9B5 RID: 190901
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402E9B6 RID: 190902
		public const int BoatBuffGroupIdFieldNumber = 1;

		// Token: 0x0402E9B7 RID: 190903
		private static readonly FieldCodec<int> _repeated_boatBuffGroupId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0402E9B8 RID: 190904
		private readonly RepeatedField<int> boatBuffGroupId_ = new RepeatedField<int>();

		// Token: 0x0402E9B9 RID: 190905
		public const int CostCountFieldNumber = 2;

		// Token: 0x0402E9BA RID: 190906
		private int costCount_;

		// Token: 0x0402E9BB RID: 190907
		public const int CostIdFieldNumber = 3;

		// Token: 0x0402E9BC RID: 190908
		private int costId_;

		// Token: 0x0402E9BD RID: 190909
		public const int CostTypeFieldNumber = 4;

		// Token: 0x0402E9BE RID: 190910
		private int costType_;

		// Token: 0x0402E9BF RID: 190911
		public const int DesignIdFieldNumber = 5;

		// Token: 0x0402E9C0 RID: 190912
		private static readonly FieldCodec<int> _repeated_designId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0402E9C1 RID: 190913
		private readonly RepeatedField<int> designId_ = new RepeatedField<int>();

		// Token: 0x0402E9C2 RID: 190914
		public const int FishTrapFrequencyFieldNumber = 6;

		// Token: 0x0402E9C3 RID: 190915
		private int fishTrapFrequency_;

		// Token: 0x0402E9C4 RID: 190916
		public const int FishTrapLevelFieldNumber = 7;

		// Token: 0x0402E9C5 RID: 190917
		private int fishTrapLevel_;

		// Token: 0x0402E9C6 RID: 190918
		public const int IdFieldNumber = 8;

		// Token: 0x0402E9C7 RID: 190919
		private int id_;

		// Token: 0x0402E9C8 RID: 190920
		public const int MultiCapacityFieldNumber = 9;

		// Token: 0x0402E9C9 RID: 190921
		private int multiCapacity_;
	}
}
