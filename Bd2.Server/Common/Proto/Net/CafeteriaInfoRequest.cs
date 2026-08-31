using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004816 RID: 18454
	public sealed class CafeteriaInfoRequest : IMessage<CafeteriaInfoRequest>, IMessage, IEquatable<CafeteriaInfoRequest>, IDeepCloneable<CafeteriaInfoRequest>, IBufferMessage
	{
		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0601D45D RID: 119901 RVA: 0x00813E1C File Offset: 0x0081201C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CafeteriaInfoRequest> Parser
		{
			get
			{
				return CafeteriaInfoRequest._parser;
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0601D45E RID: 119902 RVA: 0x00813E23 File Offset: 0x00812023
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CafeteriaInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0601D45F RID: 119903 RVA: 0x00813E35 File Offset: 0x00812035
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CafeteriaInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D460 RID: 119904 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaInfoRequest()
		{
		}

		// Token: 0x0601D461 RID: 119905 RVA: 0x00813E3C File Offset: 0x0081203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaInfoRequest(CafeteriaInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D462 RID: 119906 RVA: 0x00813E61 File Offset: 0x00812061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaInfoRequest Clone()
		{
			return new CafeteriaInfoRequest(this);
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0601D463 RID: 119907 RVA: 0x00813E69 File Offset: 0x00812069
		// (set) Token: 0x0601D464 RID: 119908 RVA: 0x00813E71 File Offset: 0x00812071
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

		// Token: 0x0601D465 RID: 119909 RVA: 0x00813E7A File Offset: 0x0081207A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CafeteriaInfoRequest);
		}

		// Token: 0x0601D466 RID: 119910 RVA: 0x00813E88 File Offset: 0x00812088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CafeteriaInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D467 RID: 119911 RVA: 0x00813EB8 File Offset: 0x008120B8
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

		// Token: 0x0601D468 RID: 119912 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601D469 RID: 119913 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D46A RID: 119914 RVA: 0x00813EF7 File Offset: 0x008120F7
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

		// Token: 0x0601D46B RID: 119915 RVA: 0x00813F28 File Offset: 0x00812128
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

		// Token: 0x0601D46C RID: 119916 RVA: 0x00813F66 File Offset: 0x00812166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CafeteriaInfoRequest other)
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

		// Token: 0x0601D46D RID: 119917 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D46E RID: 119918 RVA: 0x00813F98 File Offset: 0x00812198
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
		private static readonly MessageParser<CafeteriaInfoRequest> _parser = new MessageParser<CafeteriaInfoRequest>(() => new CafeteriaInfoRequest());

		// Token: 0x04016356 RID: 90966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016357 RID: 90967
		public const int SeqFieldNumber = 1;

		// Token: 0x04016358 RID: 90968
		private int seq_;
	}
}
