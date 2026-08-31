using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C79 RID: 31865
	public sealed class FishingCastingTable : IMessage<FishingCastingTable>, IMessage, IEquatable<FishingCastingTable>, IDeepCloneable<FishingCastingTable>, IBufferMessage
	{
		// Token: 0x17011199 RID: 70041
		// (get) Token: 0x06046B07 RID: 289543 RVA: 0x01130D4B File Offset: 0x0112EF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingCastingTable> Parser
		{
			get
			{
				return FishingCastingTable._parser;
			}
		}

		// Token: 0x1701119A RID: 70042
		// (get) Token: 0x06046B08 RID: 289544 RVA: 0x01130D52 File Offset: 0x0112EF52
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingCastingTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1701119B RID: 70043
		// (get) Token: 0x06046B09 RID: 289545 RVA: 0x01130D64 File Offset: 0x0112EF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCastingTable.Descriptor;
			}
		}

		// Token: 0x06046B0A RID: 289546 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCastingTable()
		{
		}

		// Token: 0x06046B0B RID: 289547 RVA: 0x01130D6C File Offset: 0x0112EF6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCastingTable(FishingCastingTable other)
			: this()
		{
			this.buffId_ = other.buffId_;
			this.endGaugePercent_ = other.endGaugePercent_;
			this.id_ = other.id_;
			this.startGaugePercent_ = other.startGaugePercent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046B0C RID: 289548 RVA: 0x01130DC0 File Offset: 0x0112EFC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCastingTable Clone()
		{
			return new FishingCastingTable(this);
		}

		// Token: 0x1701119C RID: 70044
		// (get) Token: 0x06046B0D RID: 289549 RVA: 0x01130DC8 File Offset: 0x0112EFC8
		// (set) Token: 0x06046B0E RID: 289550 RVA: 0x01130DD0 File Offset: 0x0112EFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x1701119D RID: 70045
		// (get) Token: 0x06046B0F RID: 289551 RVA: 0x01130DD9 File Offset: 0x0112EFD9
		// (set) Token: 0x06046B10 RID: 289552 RVA: 0x01130DE1 File Offset: 0x0112EFE1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double EndGaugePercent
		{
			get
			{
				return this.endGaugePercent_;
			}
			set
			{
				this.endGaugePercent_ = value;
			}
		}

		// Token: 0x1701119E RID: 70046
		// (get) Token: 0x06046B11 RID: 289553 RVA: 0x01130DEA File Offset: 0x0112EFEA
		// (set) Token: 0x06046B12 RID: 289554 RVA: 0x01130DF2 File Offset: 0x0112EFF2
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

		// Token: 0x1701119F RID: 70047
		// (get) Token: 0x06046B13 RID: 289555 RVA: 0x01130DFB File Offset: 0x0112EFFB
		// (set) Token: 0x06046B14 RID: 289556 RVA: 0x01130E03 File Offset: 0x0112F003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double StartGaugePercent
		{
			get
			{
				return this.startGaugePercent_;
			}
			set
			{
				this.startGaugePercent_ = value;
			}
		}

		// Token: 0x06046B15 RID: 289557 RVA: 0x01130E0C File Offset: 0x0112F00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCastingTable);
		}

		// Token: 0x06046B16 RID: 289558 RVA: 0x01130E1C File Offset: 0x0112F01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCastingTable other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.EndGaugePercent, other.EndGaugePercent) && this.Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.StartGaugePercent, other.StartGaugePercent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046B17 RID: 289559 RVA: 0x01130E9C File Offset: 0x0112F09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.EndGaugePercent != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.EndGaugePercent);
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.StartGaugePercent != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.StartGaugePercent);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046B18 RID: 289560 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046B19 RID: 289561 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046B1A RID: 289562 RVA: 0x01130F3C File Offset: 0x0112F13C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffId);
			}
			if (this.EndGaugePercent != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.EndGaugePercent);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.StartGaugePercent != 0.0)
			{
				output.WriteRawTag(33);
				output.WriteDouble(this.StartGaugePercent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046B1B RID: 289563 RVA: 0x01130FE0 File Offset: 0x0112F1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffId);
			}
			if (this.EndGaugePercent != 0.0)
			{
				num += 9;
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.StartGaugePercent != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046B1C RID: 289564 RVA: 0x01131064 File Offset: 0x0112F264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCastingTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0)
			{
				this.BuffId = other.BuffId;
			}
			if (other.EndGaugePercent != 0.0)
			{
				this.EndGaugePercent = other.EndGaugePercent;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.StartGaugePercent != 0.0)
			{
				this.StartGaugePercent = other.StartGaugePercent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046B1D RID: 289565 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046B1E RID: 289566 RVA: 0x011310F0 File Offset: 0x0112F2F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 17U)
				{
					if (num == 8U)
					{
						this.BuffId = input.ReadInt32();
						continue;
					}
					if (num == 17U)
					{
						this.EndGaugePercent = input.ReadDouble();
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
					if (num == 33U)
					{
						this.StartGaugePercent = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402E9F4 RID: 190964
		private static readonly MessageParser<FishingCastingTable> _parser = new MessageParser<FishingCastingTable>(() => new FishingCastingTable());

		// Token: 0x0402E9F5 RID: 190965
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402E9F6 RID: 190966
		public const int BuffIdFieldNumber = 1;

		// Token: 0x0402E9F7 RID: 190967
		private int buffId_;

		// Token: 0x0402E9F8 RID: 190968
		public const int EndGaugePercentFieldNumber = 2;

		// Token: 0x0402E9F9 RID: 190969
		private double endGaugePercent_;

		// Token: 0x0402E9FA RID: 190970
		public const int IdFieldNumber = 3;

		// Token: 0x0402E9FB RID: 190971
		private int id_;

		// Token: 0x0402E9FC RID: 190972
		public const int StartGaugePercentFieldNumber = 4;

		// Token: 0x0402E9FD RID: 190973
		private double startGaugePercent_;
	}
}
