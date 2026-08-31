using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004C45 RID: 19525
	public sealed class LifeInfoRequest : IMessage<LifeInfoRequest>, IMessage, IEquatable<LifeInfoRequest>, IDeepCloneable<LifeInfoRequest>, IBufferMessage
	{
		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x0601F989 RID: 129417 RVA: 0x0086188F File Offset: 0x0085FA8F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LifeInfoRequest> Parser
		{
			get
			{
				return LifeInfoRequest._parser;
			}
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0601F98A RID: 129418 RVA: 0x00861896 File Offset: 0x0085FA96
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x0601F98B RID: 129419 RVA: 0x008618A8 File Offset: 0x0085FAA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601F98C RID: 129420 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeInfoRequest()
		{
		}

		// Token: 0x0601F98D RID: 129421 RVA: 0x008618AF File Offset: 0x0085FAAF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeInfoRequest(LifeInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601F98E RID: 129422 RVA: 0x008618D4 File Offset: 0x0085FAD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeInfoRequest Clone()
		{
			return new LifeInfoRequest(this);
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x0601F98F RID: 129423 RVA: 0x008618DC File Offset: 0x0085FADC
		// (set) Token: 0x0601F990 RID: 129424 RVA: 0x008618E4 File Offset: 0x0085FAE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0601F991 RID: 129425 RVA: 0x008618ED File Offset: 0x0085FAED
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeInfoRequest);
		}

		// Token: 0x0601F992 RID: 129426 RVA: 0x008618FB File Offset: 0x0085FAFB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(LifeInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601F993 RID: 129427 RVA: 0x0086192C File Offset: 0x0085FB2C
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

		// Token: 0x0601F994 RID: 129428 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601F995 RID: 129429 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601F996 RID: 129430 RVA: 0x0086196B File Offset: 0x0085FB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0601F997 RID: 129431 RVA: 0x0086199C File Offset: 0x0085FB9C
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

		// Token: 0x0601F998 RID: 129432 RVA: 0x008619DA File Offset: 0x0085FBDA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(LifeInfoRequest other)
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

		// Token: 0x0601F999 RID: 129433 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601F99A RID: 129434 RVA: 0x00861A0C File Offset: 0x0085FC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
		private static readonly MessageParser<LifeInfoRequest> _parser = new MessageParser<LifeInfoRequest>(() => new LifeInfoRequest());

		// Token: 0x04016FDA RID: 94170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016FDB RID: 94171
		public const int SeqFieldNumber = 1;

		// Token: 0x04016FDC RID: 94172
		private int seq_;
	}
}
