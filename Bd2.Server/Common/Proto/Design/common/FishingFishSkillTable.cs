using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C8B RID: 31883
	public sealed class FishingFishSkillTable : IMessage<FishingFishSkillTable>, IMessage, IEquatable<FishingFishSkillTable>, IDeepCloneable<FishingFishSkillTable>, IBufferMessage
	{
		// Token: 0x170111F7 RID: 70135
		// (get) Token: 0x06046C0F RID: 289807 RVA: 0x0113505E File Offset: 0x0113325E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingFishSkillTable> Parser
		{
			get
			{
				return FishingFishSkillTable._parser;
			}
		}

		// Token: 0x170111F8 RID: 70136
		// (get) Token: 0x06046C10 RID: 289808 RVA: 0x01135065 File Offset: 0x01133265
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingFishSkillTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170111F9 RID: 70137
		// (get) Token: 0x06046C11 RID: 289809 RVA: 0x01135077 File Offset: 0x01133277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingFishSkillTable.Descriptor;
			}
		}

		// Token: 0x06046C12 RID: 289810 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingFishSkillTable()
		{
		}

		// Token: 0x06046C13 RID: 289811 RVA: 0x01135080 File Offset: 0x01133280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingFishSkillTable(FishingFishSkillTable other)
			: this()
		{
			this.duration_ = other.duration_;
			this.id_ = other.id_;
			this.penaltyType_ = other.penaltyType_;
			this.penaltyValue_ = other.penaltyValue_;
			this.removalValue_ = other.removalValue_;
			this.skillCount_ = other.skillCount_;
			this.skillType_ = other.skillType_;
			this.skillValue_ = other.skillValue_;
			this.triggerType_ = other.triggerType_;
			this.triggerValue_ = other.triggerValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046C14 RID: 289812 RVA: 0x0113511C File Offset: 0x0113331C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingFishSkillTable Clone()
		{
			return new FishingFishSkillTable(this);
		}

		// Token: 0x170111FA RID: 70138
		// (get) Token: 0x06046C15 RID: 289813 RVA: 0x01135124 File Offset: 0x01133324
		// (set) Token: 0x06046C16 RID: 289814 RVA: 0x0113512C File Offset: 0x0113332C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x170111FB RID: 70139
		// (get) Token: 0x06046C17 RID: 289815 RVA: 0x01135135 File Offset: 0x01133335
		// (set) Token: 0x06046C18 RID: 289816 RVA: 0x0113513D File Offset: 0x0113333D
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

		// Token: 0x170111FC RID: 70140
		// (get) Token: 0x06046C19 RID: 289817 RVA: 0x01135146 File Offset: 0x01133346
		// (set) Token: 0x06046C1A RID: 289818 RVA: 0x0113514E File Offset: 0x0113334E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PenaltyType
		{
			get
			{
				return this.penaltyType_;
			}
			set
			{
				this.penaltyType_ = value;
			}
		}

		// Token: 0x170111FD RID: 70141
		// (get) Token: 0x06046C1B RID: 289819 RVA: 0x01135157 File Offset: 0x01133357
		// (set) Token: 0x06046C1C RID: 289820 RVA: 0x0113515F File Offset: 0x0113335F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double PenaltyValue
		{
			get
			{
				return this.penaltyValue_;
			}
			set
			{
				this.penaltyValue_ = value;
			}
		}

		// Token: 0x170111FE RID: 70142
		// (get) Token: 0x06046C1D RID: 289821 RVA: 0x01135168 File Offset: 0x01133368
		// (set) Token: 0x06046C1E RID: 289822 RVA: 0x01135170 File Offset: 0x01133370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RemovalValue
		{
			get
			{
				return this.removalValue_;
			}
			set
			{
				this.removalValue_ = value;
			}
		}

		// Token: 0x170111FF RID: 70143
		// (get) Token: 0x06046C1F RID: 289823 RVA: 0x01135179 File Offset: 0x01133379
		// (set) Token: 0x06046C20 RID: 289824 RVA: 0x01135181 File Offset: 0x01133381
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SkillCount
		{
			get
			{
				return this.skillCount_;
			}
			set
			{
				this.skillCount_ = value;
			}
		}

		// Token: 0x17011200 RID: 70144
		// (get) Token: 0x06046C21 RID: 289825 RVA: 0x0113518A File Offset: 0x0113338A
		// (set) Token: 0x06046C22 RID: 289826 RVA: 0x01135192 File Offset: 0x01133392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillType
		{
			get
			{
				return this.skillType_;
			}
			set
			{
				this.skillType_ = value;
			}
		}

		// Token: 0x17011201 RID: 70145
		// (get) Token: 0x06046C23 RID: 289827 RVA: 0x0113519B File Offset: 0x0113339B
		// (set) Token: 0x06046C24 RID: 289828 RVA: 0x011351A3 File Offset: 0x011333A3
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double SkillValue
		{
			get
			{
				return this.skillValue_;
			}
			set
			{
				this.skillValue_ = value;
			}
		}

		// Token: 0x17011202 RID: 70146
		// (get) Token: 0x06046C25 RID: 289829 RVA: 0x011351AC File Offset: 0x011333AC
		// (set) Token: 0x06046C26 RID: 289830 RVA: 0x011351B4 File Offset: 0x011333B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TriggerType
		{
			get
			{
				return this.triggerType_;
			}
			set
			{
				this.triggerType_ = value;
			}
		}

		// Token: 0x17011203 RID: 70147
		// (get) Token: 0x06046C27 RID: 289831 RVA: 0x011351BD File Offset: 0x011333BD
		// (set) Token: 0x06046C28 RID: 289832 RVA: 0x011351C5 File Offset: 0x011333C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TriggerValue
		{
			get
			{
				return this.triggerValue_;
			}
			set
			{
				this.triggerValue_ = value;
			}
		}

		// Token: 0x06046C29 RID: 289833 RVA: 0x011351CE File Offset: 0x011333CE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingFishSkillTable);
		}

		// Token: 0x06046C2A RID: 289834 RVA: 0x011351DC File Offset: 0x011333DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingFishSkillTable other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Duration, other.Duration) && this.Id == other.Id && this.PenaltyType == other.PenaltyType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.PenaltyValue, other.PenaltyValue) && this.RemovalValue == other.RemovalValue && this.SkillCount == other.SkillCount && this.SkillType == other.SkillType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.SkillValue, other.SkillValue) && this.TriggerType == other.TriggerType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TriggerValue, other.TriggerValue) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046C2B RID: 289835 RVA: 0x011352D0 File Offset: 0x011334D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Duration != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PenaltyType != 0)
			{
				num ^= this.PenaltyType.GetHashCode();
			}
			if (this.PenaltyValue != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.PenaltyValue);
			}
			if (this.RemovalValue != 0)
			{
				num ^= this.RemovalValue.GetHashCode();
			}
			if (this.SkillCount != 0)
			{
				num ^= this.SkillCount.GetHashCode();
			}
			if (this.SkillType != 0)
			{
				num ^= this.SkillType.GetHashCode();
			}
			if (this.SkillValue != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.SkillValue);
			}
			if (this.TriggerType != 0)
			{
				num ^= this.TriggerType.GetHashCode();
			}
			if (this.TriggerValue != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TriggerValue);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046C2C RID: 289836 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046C2D RID: 289837 RVA: 0x001D568A File Offset: 0x001D388A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046C2E RID: 289838 RVA: 0x0113541C File Offset: 0x0113361C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0.0)
			{
				output.WriteRawTag(9);
				output.WriteDouble(this.Duration);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.PenaltyType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PenaltyType);
			}
			if (this.PenaltyValue != 0.0)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.PenaltyValue);
			}
			if (this.RemovalValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RemovalValue);
			}
			if (this.SkillCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillCount);
			}
			if (this.SkillType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillType);
			}
			if (this.SkillValue != 0.0)
			{
				output.WriteRawTag(65);
				output.WriteDouble(this.SkillValue);
			}
			if (this.TriggerType != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TriggerType);
			}
			if (this.TriggerValue != 0.0)
			{
				output.WriteRawTag(81);
				output.WriteDouble(this.TriggerValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046C2F RID: 289839 RVA: 0x0113557C File Offset: 0x0113377C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Duration != 0.0)
			{
				num += 9;
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.PenaltyType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PenaltyType);
			}
			if (this.PenaltyValue != 0.0)
			{
				num += 9;
			}
			if (this.RemovalValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemovalValue);
			}
			if (this.SkillCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillCount);
			}
			if (this.SkillType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillType);
			}
			if (this.SkillValue != 0.0)
			{
				num += 9;
			}
			if (this.TriggerType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerType);
			}
			if (this.TriggerValue != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046C30 RID: 289840 RVA: 0x0113568C File Offset: 0x0113388C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingFishSkillTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Duration != 0.0)
			{
				this.Duration = other.Duration;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.PenaltyType != 0)
			{
				this.PenaltyType = other.PenaltyType;
			}
			if (other.PenaltyValue != 0.0)
			{
				this.PenaltyValue = other.PenaltyValue;
			}
			if (other.RemovalValue != 0)
			{
				this.RemovalValue = other.RemovalValue;
			}
			if (other.SkillCount != 0)
			{
				this.SkillCount = other.SkillCount;
			}
			if (other.SkillType != 0)
			{
				this.SkillType = other.SkillType;
			}
			if (other.SkillValue != 0.0)
			{
				this.SkillValue = other.SkillValue;
			}
			if (other.TriggerType != 0)
			{
				this.TriggerType = other.TriggerType;
			}
			if (other.TriggerValue != 0.0)
			{
				this.TriggerValue = other.TriggerValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046C31 RID: 289841 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046C32 RID: 289842 RVA: 0x011357A0 File Offset: 0x011339A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 9U)
						{
							this.Duration = input.ReadDouble();
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
							this.PenaltyType = input.ReadInt32();
							continue;
						}
						if (num == 33U)
						{
							this.PenaltyValue = input.ReadDouble();
							continue;
						}
						if (num == 40U)
						{
							this.RemovalValue = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.SkillCount = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.SkillType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 65U)
					{
						this.SkillValue = input.ReadDouble();
						continue;
					}
					if (num == 72U)
					{
						this.TriggerType = input.ReadInt32();
						continue;
					}
					if (num == 81U)
					{
						this.TriggerValue = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EAA0 RID: 191136
		private static readonly MessageParser<FishingFishSkillTable> _parser = new MessageParser<FishingFishSkillTable>(() => new FishingFishSkillTable());

		// Token: 0x0402EAA1 RID: 191137
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EAA2 RID: 191138
		public const int DurationFieldNumber = 1;

		// Token: 0x0402EAA3 RID: 191139
		private double duration_;

		// Token: 0x0402EAA4 RID: 191140
		public const int IdFieldNumber = 2;

		// Token: 0x0402EAA5 RID: 191141
		private int id_;

		// Token: 0x0402EAA6 RID: 191142
		public const int PenaltyTypeFieldNumber = 3;

		// Token: 0x0402EAA7 RID: 191143
		private int penaltyType_;

		// Token: 0x0402EAA8 RID: 191144
		public const int PenaltyValueFieldNumber = 4;

		// Token: 0x0402EAA9 RID: 191145
		private double penaltyValue_;

		// Token: 0x0402EAAA RID: 191146
		public const int RemovalValueFieldNumber = 5;

		// Token: 0x0402EAAB RID: 191147
		private int removalValue_;

		// Token: 0x0402EAAC RID: 191148
		public const int SkillCountFieldNumber = 6;

		// Token: 0x0402EAAD RID: 191149
		private int skillCount_;

		// Token: 0x0402EAAE RID: 191150
		public const int SkillTypeFieldNumber = 7;

		// Token: 0x0402EAAF RID: 191151
		private int skillType_;

		// Token: 0x0402EAB0 RID: 191152
		public const int SkillValueFieldNumber = 8;

		// Token: 0x0402EAB1 RID: 191153
		private double skillValue_;

		// Token: 0x0402EAB2 RID: 191154
		public const int TriggerTypeFieldNumber = 9;

		// Token: 0x0402EAB3 RID: 191155
		private int triggerType_;

		// Token: 0x0402EAB4 RID: 191156
		public const int TriggerValueFieldNumber = 10;

		// Token: 0x0402EAB5 RID: 191157
		private double triggerValue_;
	}
}
