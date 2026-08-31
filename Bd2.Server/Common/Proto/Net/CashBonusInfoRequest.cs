using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004840 RID: 18496
	public sealed class CashBonusInfoRequest : IMessage<CashBonusInfoRequest>, IMessage, IEquatable<CashBonusInfoRequest>, IDeepCloneable<CashBonusInfoRequest>, IBufferMessage
	{
		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0601D5B9 RID: 120249 RVA: 0x0081643C File Offset: 0x0081463C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CashBonusInfoRequest> Parser
		{
			get
			{
				return CashBonusInfoRequest._parser;
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0601D5BA RID: 120250 RVA: 0x00816443 File Offset: 0x00814643
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CashBonusInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0601D5BB RID: 120251 RVA: 0x00816455 File Offset: 0x00814655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CashBonusInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D5BC RID: 120252 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CashBonusInfoRequest()
		{
		}

		// Token: 0x0601D5BD RID: 120253 RVA: 0x0081645C File Offset: 0x0081465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CashBonusInfoRequest(CashBonusInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D5BE RID: 120254 RVA: 0x00816481 File Offset: 0x00814681
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CashBonusInfoRequest Clone()
		{
			return new CashBonusInfoRequest(this);
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0601D5BF RID: 120255 RVA: 0x00816489 File Offset: 0x00814689
		// (set) Token: 0x0601D5C0 RID: 120256 RVA: 0x00816491 File Offset: 0x00814691
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

		// Token: 0x0601D5C1 RID: 120257 RVA: 0x0081649A File Offset: 0x0081469A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CashBonusInfoRequest);
		}

		// Token: 0x0601D5C2 RID: 120258 RVA: 0x008164A8 File Offset: 0x008146A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(CashBonusInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D5C3 RID: 120259 RVA: 0x008164D8 File Offset: 0x008146D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Seq != 0)
			{
				num ^= this.Seq.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D5C4 RID: 120260 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601D5C5 RID: 120261 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D5C6 RID: 120262 RVA: 0x00816517 File Offset: 0x00814717
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Seq != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Seq);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D5C7 RID: 120263 RVA: 0x00816548 File Offset: 0x00814748
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Seq != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seq);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D5C8 RID: 120264 RVA: 0x00816586 File Offset: 0x00814786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CashBonusInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Seq != 0)
			{
				this.Seq = other.Seq;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D5C9 RID: 120265 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D5CA RID: 120266 RVA: 0x008165B8 File Offset: 0x008147B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Seq = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<CashBonusInfoRequest> _parser = new MessageParser<CashBonusInfoRequest>(() => new CashBonusInfoRequest());

		// Token: 0x040163B6 RID: 91062
		private UnknownFieldSet _unknownFields;

		// Token: 0x040163B7 RID: 91063
		public const int SeqFieldNumber = 1;

		// Token: 0x040163B8 RID: 91064
		private int seq_;
	}
}
