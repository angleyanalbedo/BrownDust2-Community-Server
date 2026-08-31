using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043F1 RID: 17393
	public sealed class CafeteriaPartTimeManagerDBInfo : IMessage<CafeteriaPartTimeManagerDBInfo>, IMessage, IEquatable<CafeteriaPartTimeManagerDBInfo>, IDeepCloneable<CafeteriaPartTimeManagerDBInfo>, IBufferMessage
	{
		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x0601B0ED RID: 110829 RVA: 0x007B2CD4 File Offset: 0x007B0ED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CafeteriaPartTimeManagerDBInfo> Parser
		{
			get
			{
				return CafeteriaPartTimeManagerDBInfo._parser;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x0601B0EE RID: 110830 RVA: 0x007B2CDB File Offset: 0x007B0EDB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CafeteriaPartTimeManagerDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x0601B0EF RID: 110831 RVA: 0x007B2CED File Offset: 0x007B0EED
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CafeteriaPartTimeManagerDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B0F0 RID: 110832 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaPartTimeManagerDBInfo()
		{
		}

		// Token: 0x0601B0F1 RID: 110833 RVA: 0x007B2CF4 File Offset: 0x007B0EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CafeteriaPartTimeManagerDBInfo(CafeteriaPartTimeManagerDBInfo other)
			: this()
		{
			this.partTimeManagerId_ = other.partTimeManagerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0F2 RID: 110834 RVA: 0x007B2D19 File Offset: 0x007B0F19
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CafeteriaPartTimeManagerDBInfo Clone()
		{
			return new CafeteriaPartTimeManagerDBInfo(this);
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x0601B0F3 RID: 110835 RVA: 0x007B2D21 File Offset: 0x007B0F21
		// (set) Token: 0x0601B0F4 RID: 110836 RVA: 0x007B2D29 File Offset: 0x007B0F29
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PartTimeManagerId
		{
			get
			{
				return this.partTimeManagerId_;
			}
			set
			{
				this.partTimeManagerId_ = value;
			}
		}

		// Token: 0x0601B0F5 RID: 110837 RVA: 0x007B2D32 File Offset: 0x007B0F32
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CafeteriaPartTimeManagerDBInfo);
		}

		// Token: 0x0601B0F6 RID: 110838 RVA: 0x007B2D40 File Offset: 0x007B0F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CafeteriaPartTimeManagerDBInfo other)
		{
			return other != null && (other == this || (this.PartTimeManagerId == other.PartTimeManagerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0F7 RID: 110839 RVA: 0x007B2D70 File Offset: 0x007B0F70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PartTimeManagerId != 0)
			{
				num ^= this.PartTimeManagerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B0F8 RID: 110840 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B0F9 RID: 110841 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0FA RID: 110842 RVA: 0x007B2DAF File Offset: 0x007B0FAF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PartTimeManagerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PartTimeManagerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0FB RID: 110843 RVA: 0x007B2DE0 File Offset: 0x007B0FE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PartTimeManagerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartTimeManagerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B0FC RID: 110844 RVA: 0x007B2E1E File Offset: 0x007B101E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CafeteriaPartTimeManagerDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PartTimeManagerId != 0)
			{
				this.PartTimeManagerId = other.PartTimeManagerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B0FD RID: 110845 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0FE RID: 110846 RVA: 0x007B2E50 File Offset: 0x007B1050
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
					this.PartTimeManagerId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<CafeteriaPartTimeManagerDBInfo> _parser = new MessageParser<CafeteriaPartTimeManagerDBInfo>(() => new CafeteriaPartTimeManagerDBInfo());

		// Token: 0x04014BEE RID: 84974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014BEF RID: 84975
		public const int PartTimeManagerIdFieldNumber = 1;

		// Token: 0x04014BF0 RID: 84976
		private int partTimeManagerId_;
	}
}
