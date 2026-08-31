using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C7C RID: 31868
	public sealed class FishingCharTable : IMessage<FishingCharTable>, IMessage, IEquatable<FishingCharTable>, IDeepCloneable<FishingCharTable>, IBufferMessage
	{
		// Token: 0x170111A1 RID: 70049
		// (get) Token: 0x06046B25 RID: 289573 RVA: 0x0113124F File Offset: 0x0112F44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingCharTable> Parser
		{
			get
			{
				return FishingCharTable._parser;
			}
		}

		// Token: 0x170111A2 RID: 70050
		// (get) Token: 0x06046B26 RID: 289574 RVA: 0x01131256 File Offset: 0x0112F456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingCharTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170111A3 RID: 70051
		// (get) Token: 0x06046B27 RID: 289575 RVA: 0x01131268 File Offset: 0x0112F468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCharTable.Descriptor;
			}
		}

		// Token: 0x06046B28 RID: 289576 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCharTable()
		{
		}

		// Token: 0x06046B29 RID: 289577 RVA: 0x01131270 File Offset: 0x0112F470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCharTable(FishingCharTable other)
			: this()
		{
			this.id_ = other.id_;
			this.levelupExp_ = other.levelupExp_;
			this.power_ = other.power_;
			this.stamina_ = other.stamina_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046B2A RID: 289578 RVA: 0x011312C4 File Offset: 0x0112F4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCharTable Clone()
		{
			return new FishingCharTable(this);
		}

		// Token: 0x170111A4 RID: 70052
		// (get) Token: 0x06046B2B RID: 289579 RVA: 0x011312CC File Offset: 0x0112F4CC
		// (set) Token: 0x06046B2C RID: 289580 RVA: 0x011312D4 File Offset: 0x0112F4D4
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

		// Token: 0x170111A5 RID: 70053
		// (get) Token: 0x06046B2D RID: 289581 RVA: 0x011312DD File Offset: 0x0112F4DD
		// (set) Token: 0x06046B2E RID: 289582 RVA: 0x011312E5 File Offset: 0x0112F4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelupExp
		{
			get
			{
				return this.levelupExp_;
			}
			set
			{
				this.levelupExp_ = value;
			}
		}

		// Token: 0x170111A6 RID: 70054
		// (get) Token: 0x06046B2F RID: 289583 RVA: 0x011312EE File Offset: 0x0112F4EE
		// (set) Token: 0x06046B30 RID: 289584 RVA: 0x011312F6 File Offset: 0x0112F4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Power
		{
			get
			{
				return this.power_;
			}
			set
			{
				this.power_ = value;
			}
		}

		// Token: 0x170111A7 RID: 70055
		// (get) Token: 0x06046B31 RID: 289585 RVA: 0x011312FF File Offset: 0x0112F4FF
		// (set) Token: 0x06046B32 RID: 289586 RVA: 0x01131307 File Offset: 0x0112F507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Stamina
		{
			get
			{
				return this.stamina_;
			}
			set
			{
				this.stamina_ = value;
			}
		}

		// Token: 0x06046B33 RID: 289587 RVA: 0x01131310 File Offset: 0x0112F510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCharTable);
		}

		// Token: 0x06046B34 RID: 289588 RVA: 0x01131320 File Offset: 0x0112F520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCharTable other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LevelupExp == other.LevelupExp && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Power, other.Power) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Stamina, other.Stamina) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046B35 RID: 289589 RVA: 0x011313A0 File Offset: 0x0112F5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LevelupExp != 0)
			{
				num ^= this.LevelupExp.GetHashCode();
			}
			if (this.Power != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Power);
			}
			if (this.Stamina != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Stamina);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046B36 RID: 289590 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046B37 RID: 289591 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046B38 RID: 289592 RVA: 0x01131440 File Offset: 0x0112F640
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.LevelupExp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelupExp);
			}
			if (this.Power != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.Power);
			}
			if (this.Stamina != 0.0)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.Stamina);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046B39 RID: 289593 RVA: 0x011314E4 File Offset: 0x0112F6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LevelupExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelupExp);
			}
			if (this.Power != 0.0)
			{
				num += 9;
			}
			if (this.Stamina != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046B3A RID: 289594 RVA: 0x01131568 File Offset: 0x0112F768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCharTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LevelupExp != 0)
			{
				this.LevelupExp = other.LevelupExp;
			}
			if (other.Power != 0.0)
			{
				this.Power = other.Power;
			}
			if (other.Stamina != 0.0)
			{
				this.Stamina = other.Stamina;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046B3B RID: 289595 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046B3C RID: 289596 RVA: 0x011315F4 File Offset: 0x0112F7F4
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LevelupExp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 25U)
					{
						this.Power = input.ReadDouble();
						continue;
					}
					if (num == 33U)
					{
						this.Stamina = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EA00 RID: 190976
		private static readonly MessageParser<FishingCharTable> _parser = new MessageParser<FishingCharTable>(() => new FishingCharTable());

		// Token: 0x0402EA01 RID: 190977
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EA02 RID: 190978
		public const int IdFieldNumber = 1;

		// Token: 0x0402EA03 RID: 190979
		private int id_;

		// Token: 0x0402EA04 RID: 190980
		public const int LevelupExpFieldNumber = 2;

		// Token: 0x0402EA05 RID: 190981
		private int levelupExp_;

		// Token: 0x0402EA06 RID: 190982
		public const int PowerFieldNumber = 3;

		// Token: 0x0402EA07 RID: 190983
		private double power_;

		// Token: 0x0402EA08 RID: 190984
		public const int StaminaFieldNumber = 4;

		// Token: 0x0402EA09 RID: 190985
		private double stamina_;
	}
}
