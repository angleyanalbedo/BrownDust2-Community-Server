using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200492F RID: 18735
	public sealed class DatingInfoRequest : IMessage<DatingInfoRequest>, IMessage, IEquatable<DatingInfoRequest>, IDeepCloneable<DatingInfoRequest>, IBufferMessage
	{
		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0601DE27 RID: 122407 RVA: 0x008282E7 File Offset: 0x008264E7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DatingInfoRequest> Parser
		{
			get
			{
				return DatingInfoRequest._parser;
			}
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0601DE28 RID: 122408 RVA: 0x008282EE File Offset: 0x008264EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DatingInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0601DE29 RID: 122409 RVA: 0x00828300 File Offset: 0x00826500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DatingInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601DE2A RID: 122410 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingInfoRequest()
		{
		}

		// Token: 0x0601DE2B RID: 122411 RVA: 0x00828307 File Offset: 0x00826507
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DatingInfoRequest(DatingInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DE2C RID: 122412 RVA: 0x0082832C File Offset: 0x0082652C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingInfoRequest Clone()
		{
			return new DatingInfoRequest(this);
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0601DE2D RID: 122413 RVA: 0x00828334 File Offset: 0x00826534
		// (set) Token: 0x0601DE2E RID: 122414 RVA: 0x0082833C File Offset: 0x0082653C
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

		// Token: 0x0601DE2F RID: 122415 RVA: 0x00828345 File Offset: 0x00826545
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DatingInfoRequest);
		}

		// Token: 0x0601DE30 RID: 122416 RVA: 0x00828353 File Offset: 0x00826553
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(DatingInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DE31 RID: 122417 RVA: 0x00828384 File Offset: 0x00826584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0601DE32 RID: 122418 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601DE33 RID: 122419 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DE34 RID: 122420 RVA: 0x008283C3 File Offset: 0x008265C3
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

		// Token: 0x0601DE35 RID: 122421 RVA: 0x008283F4 File Offset: 0x008265F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0601DE36 RID: 122422 RVA: 0x00828432 File Offset: 0x00826632
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(DatingInfoRequest other)
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

		// Token: 0x0601DE37 RID: 122423 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DE38 RID: 122424 RVA: 0x00828464 File Offset: 0x00826664
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
		private static readonly MessageParser<DatingInfoRequest> _parser = new MessageParser<DatingInfoRequest>(() => new DatingInfoRequest());

		// Token: 0x040166A3 RID: 91811
		private UnknownFieldSet _unknownFields;

		// Token: 0x040166A4 RID: 91812
		public const int SeqFieldNumber = 1;

		// Token: 0x040166A5 RID: 91813
		private int seq_;
	}
}
