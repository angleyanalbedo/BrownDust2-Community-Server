using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004F4F RID: 20303
	public sealed class UpdateAgeGateRequest : IMessage<UpdateAgeGateRequest>, IMessage, IEquatable<UpdateAgeGateRequest>, IDeepCloneable<UpdateAgeGateRequest>, IBufferMessage
	{
		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x060214F0 RID: 136432 RVA: 0x0089C4F1 File Offset: 0x0089A6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateAgeGateRequest> Parser
		{
			get
			{
				return UpdateAgeGateRequest._parser;
			}
		}

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x060214F1 RID: 136433 RVA: 0x0089C4F8 File Offset: 0x0089A6F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateAgeGateRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x060214F2 RID: 136434 RVA: 0x0089C50A File Offset: 0x0089A70A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateAgeGateRequest.Descriptor;
			}
		}

		// Token: 0x060214F3 RID: 136435 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateAgeGateRequest()
		{
		}

		// Token: 0x060214F4 RID: 136436 RVA: 0x0089C514 File Offset: 0x0089A714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateAgeGateRequest(UpdateAgeGateRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this.isJp_ = other.isJp_;
			this.year_ = other.year_;
			this.month_ = other.month_;
			this.day_ = other.day_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060214F5 RID: 136437 RVA: 0x0089C574 File Offset: 0x0089A774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateAgeGateRequest Clone()
		{
			return new UpdateAgeGateRequest(this);
		}

		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x060214F6 RID: 136438 RVA: 0x0089C57C File Offset: 0x0089A77C
		// (set) Token: 0x060214F7 RID: 136439 RVA: 0x0089C584 File Offset: 0x0089A784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Seq
		{
			get
			{
				return this.seq_;
			}
			set
			{
				this.seq_ = value;
			}
		}

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x060214F8 RID: 136440 RVA: 0x0089C58D File Offset: 0x0089A78D
		// (set) Token: 0x060214F9 RID: 136441 RVA: 0x0089C595 File Offset: 0x0089A795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsJp
		{
			get
			{
				return this.isJp_;
			}
			set
			{
				this.isJp_ = value;
			}
		}

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x060214FA RID: 136442 RVA: 0x0089C59E File Offset: 0x0089A79E
		// (set) Token: 0x060214FB RID: 136443 RVA: 0x0089C5A6 File Offset: 0x0089A7A6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Year
		{
			get
			{
				return this.year_;
			}
			set
			{
				this.year_ = value;
			}
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x060214FC RID: 136444 RVA: 0x0089C5AF File Offset: 0x0089A7AF
		// (set) Token: 0x060214FD RID: 136445 RVA: 0x0089C5B7 File Offset: 0x0089A7B7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Month
		{
			get
			{
				return this.month_;
			}
			set
			{
				this.month_ = value;
			}
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x060214FE RID: 136446 RVA: 0x0089C5C0 File Offset: 0x0089A7C0
		// (set) Token: 0x060214FF RID: 136447 RVA: 0x0089C5C8 File Offset: 0x0089A7C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Day
		{
			get
			{
				return this.day_;
			}
			set
			{
				this.day_ = value;
			}
		}

		// Token: 0x06021500 RID: 136448 RVA: 0x0089C5D1 File Offset: 0x0089A7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateAgeGateRequest);
		}

		// Token: 0x06021501 RID: 136449 RVA: 0x0089C5E0 File Offset: 0x0089A7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateAgeGateRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && this.IsJp == other.IsJp && this.Year == other.Year && this.Month == other.Month && this.Day == other.Day && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06021502 RID: 136450 RVA: 0x0089C65C File Offset: 0x0089A85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Seq != 0)
			{
				num ^= this.Seq.GetHashCode();
			}
			if (this.IsJp)
			{
				num ^= this.IsJp.GetHashCode();
			}
			if (this.Year != 0)
			{
				num ^= this.Year.GetHashCode();
			}
			if (this.Month != 0)
			{
				num ^= this.Month.GetHashCode();
			}
			if (this.Day != 0)
			{
				num ^= this.Day.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06021503 RID: 136451 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06021504 RID: 136452 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06021505 RID: 136453 RVA: 0x0089C700 File Offset: 0x0089A900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Seq != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Seq);
			}
			if (this.IsJp)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsJp);
			}
			if (this.Year != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Year);
			}
			if (this.Month != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Month);
			}
			if (this.Day != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Day);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06021506 RID: 136454 RVA: 0x0089C7AC File Offset: 0x0089A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Seq != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seq);
			}
			if (this.IsJp)
			{
				num += 2;
			}
			if (this.Year != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Year);
			}
			if (this.Month != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Month);
			}
			if (this.Day != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Day);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06021507 RID: 136455 RVA: 0x0089C840 File Offset: 0x0089AA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateAgeGateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Seq != 0)
			{
				this.Seq = other.Seq;
			}
			if (other.IsJp)
			{
				this.IsJp = other.IsJp;
			}
			if (other.Year != 0)
			{
				this.Year = other.Year;
			}
			if (other.Month != 0)
			{
				this.Month = other.Month;
			}
			if (other.Day != 0)
			{
				this.Day = other.Day;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06021508 RID: 136456 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06021509 RID: 136457 RVA: 0x0089C8CC File Offset: 0x0089AACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Seq = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsJp = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Year = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Month = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Day = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04017961 RID: 96609
		private static readonly MessageParser<UpdateAgeGateRequest> _parser = new MessageParser<UpdateAgeGateRequest>(() => new UpdateAgeGateRequest());

		// Token: 0x04017962 RID: 96610
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017963 RID: 96611
		public const int SeqFieldNumber = 1;

		// Token: 0x04017964 RID: 96612
		private int seq_;

		// Token: 0x04017965 RID: 96613
		public const int IsJpFieldNumber = 2;

		// Token: 0x04017966 RID: 96614
		private bool isJp_;

		// Token: 0x04017967 RID: 96615
		public const int YearFieldNumber = 3;

		// Token: 0x04017968 RID: 96616
		private int year_;

		// Token: 0x04017969 RID: 96617
		public const int MonthFieldNumber = 4;

		// Token: 0x0401796A RID: 96618
		private int month_;

		// Token: 0x0401796B RID: 96619
		public const int DayFieldNumber = 5;

		// Token: 0x0401796C RID: 96620
		private int day_;
	}
}
