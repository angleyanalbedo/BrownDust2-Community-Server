using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CAC RID: 31916
	public sealed class FishingTimeTable : IMessage<FishingTimeTable>, IMessage, IEquatable<FishingTimeTable>, IDeepCloneable<FishingTimeTable>, IBufferMessage
	{
		// Token: 0x1701127B RID: 70267
		// (get) Token: 0x06046DA8 RID: 290216 RVA: 0x0113A68F File Offset: 0x0113888F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingTimeTable> Parser
		{
			get
			{
				return FishingTimeTable._parser;
			}
		}

		// Token: 0x1701127C RID: 70268
		// (get) Token: 0x06046DA9 RID: 290217 RVA: 0x0113A696 File Offset: 0x01138896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingTimeTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1701127D RID: 70269
		// (get) Token: 0x06046DAA RID: 290218 RVA: 0x0113A6A8 File Offset: 0x011388A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTimeTable.Descriptor;
			}
		}

		// Token: 0x06046DAB RID: 290219 RVA: 0x0113A6AF File Offset: 0x011388AF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingTimeTable()
		{
		}

		// Token: 0x06046DAC RID: 290220 RVA: 0x0113A6C2 File Offset: 0x011388C2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingTimeTable(FishingTimeTable other)
			: this()
		{
			this.id_ = other.id_;
			this.startTime_ = other.startTime_;
			this.timeNameTextId_ = other.timeNameTextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046DAD RID: 290221 RVA: 0x0113A6FF File Offset: 0x011388FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTimeTable Clone()
		{
			return new FishingTimeTable(this);
		}

		// Token: 0x1701127E RID: 70270
		// (get) Token: 0x06046DAE RID: 290222 RVA: 0x0113A707 File Offset: 0x01138907
		// (set) Token: 0x06046DAF RID: 290223 RVA: 0x0113A70F File Offset: 0x0113890F
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

		// Token: 0x1701127F RID: 70271
		// (get) Token: 0x06046DB0 RID: 290224 RVA: 0x0113A718 File Offset: 0x01138918
		// (set) Token: 0x06046DB1 RID: 290225 RVA: 0x0113A720 File Offset: 0x01138920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011280 RID: 70272
		// (get) Token: 0x06046DB2 RID: 290226 RVA: 0x0113A733 File Offset: 0x01138933
		// (set) Token: 0x06046DB3 RID: 290227 RVA: 0x0113A73B File Offset: 0x0113893B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TimeNameTextId
		{
			get
			{
				return this.timeNameTextId_;
			}
			set
			{
				this.timeNameTextId_ = value;
			}
		}

		// Token: 0x06046DB4 RID: 290228 RVA: 0x0113A744 File Offset: 0x01138944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTimeTable);
		}

		// Token: 0x06046DB5 RID: 290229 RVA: 0x0113A754 File Offset: 0x01138954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingTimeTable other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.StartTime != other.StartTime) && this.TimeNameTextId == other.TimeNameTextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046DB6 RID: 290230 RVA: 0x0113A7B4 File Offset: 0x011389B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.StartTime.Length != 0)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.TimeNameTextId != 0)
			{
				num ^= this.TimeNameTextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046DB7 RID: 290231 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046DB8 RID: 290232 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046DB9 RID: 290233 RVA: 0x0113A828 File Offset: 0x01138A28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.StartTime.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.StartTime);
			}
			if (this.TimeNameTextId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TimeNameTextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046DBA RID: 290234 RVA: 0x0113A8A4 File Offset: 0x01138AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.StartTime.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StartTime);
			}
			if (this.TimeNameTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeNameTextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046DBB RID: 290235 RVA: 0x0113A918 File Offset: 0x01138B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTimeTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.StartTime.Length != 0)
			{
				this.StartTime = other.StartTime;
			}
			if (other.TimeNameTextId != 0)
			{
				this.TimeNameTextId = other.TimeNameTextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046DBC RID: 290236 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046DBD RID: 290237 RVA: 0x0113A984 File Offset: 0x01138B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TimeNameTextId = input.ReadInt32();
						}
					}
					else
					{
						this.StartTime = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0402EB85 RID: 191365
		private static readonly MessageParser<FishingTimeTable> _parser = new MessageParser<FishingTimeTable>(() => new FishingTimeTable());

		// Token: 0x0402EB86 RID: 191366
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EB87 RID: 191367
		public const int IdFieldNumber = 1;

		// Token: 0x0402EB88 RID: 191368
		private int id_;

		// Token: 0x0402EB89 RID: 191369
		public const int StartTimeFieldNumber = 2;

		// Token: 0x0402EB8A RID: 191370
		private string startTime_ = "";

		// Token: 0x0402EB8B RID: 191371
		public const int TimeNameTextIdFieldNumber = 3;

		// Token: 0x0402EB8C RID: 191372
		private int timeNameTextId_;
	}
}
