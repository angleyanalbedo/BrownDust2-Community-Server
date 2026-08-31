using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004897 RID: 18583
	public sealed class CharVoteInfoRequest : IMessage<CharVoteInfoRequest>, IMessage, IEquatable<CharVoteInfoRequest>, IDeepCloneable<CharVoteInfoRequest>, IBufferMessage
	{
		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0601D8D2 RID: 121042 RVA: 0x0081CFAF File Offset: 0x0081B1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharVoteInfoRequest> Parser
		{
			get
			{
				return CharVoteInfoRequest._parser;
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0601D8D3 RID: 121043 RVA: 0x0081CFB6 File Offset: 0x0081B1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharVoteInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0601D8D4 RID: 121044 RVA: 0x0081CFC8 File Offset: 0x0081B1C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharVoteInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D8D5 RID: 121045 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharVoteInfoRequest()
		{
		}

		// Token: 0x0601D8D6 RID: 121046 RVA: 0x0081CFCF File Offset: 0x0081B1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharVoteInfoRequest(CharVoteInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D8D7 RID: 121047 RVA: 0x0081CFF4 File Offset: 0x0081B1F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharVoteInfoRequest Clone()
		{
			return new CharVoteInfoRequest(this);
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0601D8D8 RID: 121048 RVA: 0x0081CFFC File Offset: 0x0081B1FC
		// (set) Token: 0x0601D8D9 RID: 121049 RVA: 0x0081D004 File Offset: 0x0081B204
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

		// Token: 0x0601D8DA RID: 121050 RVA: 0x0081D00D File Offset: 0x0081B20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharVoteInfoRequest);
		}

		// Token: 0x0601D8DB RID: 121051 RVA: 0x0081D01B File Offset: 0x0081B21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharVoteInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D8DC RID: 121052 RVA: 0x0081D04C File Offset: 0x0081B24C
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

		// Token: 0x0601D8DD RID: 121053 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601D8DE RID: 121054 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D8DF RID: 121055 RVA: 0x0081D08B File Offset: 0x0081B28B
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

		// Token: 0x0601D8E0 RID: 121056 RVA: 0x0081D0BC File Offset: 0x0081B2BC
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

		// Token: 0x0601D8E1 RID: 121057 RVA: 0x0081D0FA File Offset: 0x0081B2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharVoteInfoRequest other)
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

		// Token: 0x0601D8E2 RID: 121058 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D8E3 RID: 121059 RVA: 0x0081D12C File Offset: 0x0081B32C
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
		private static readonly MessageParser<CharVoteInfoRequest> _parser = new MessageParser<CharVoteInfoRequest>(() => new CharVoteInfoRequest());

		// Token: 0x040164D0 RID: 91344
		private UnknownFieldSet _unknownFields;

		// Token: 0x040164D1 RID: 91345
		public const int SeqFieldNumber = 1;

		// Token: 0x040164D2 RID: 91346
		private int seq_;
	}
}
