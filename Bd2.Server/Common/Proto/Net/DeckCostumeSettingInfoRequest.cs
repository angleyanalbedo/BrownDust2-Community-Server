using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200493B RID: 18747
	public sealed class DeckCostumeSettingInfoRequest : IMessage<DeckCostumeSettingInfoRequest>, IMessage, IEquatable<DeckCostumeSettingInfoRequest>, IDeepCloneable<DeckCostumeSettingInfoRequest>, IBufferMessage
	{
		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0601DE93 RID: 122515 RVA: 0x008290D4 File Offset: 0x008272D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeckCostumeSettingInfoRequest> Parser
		{
			get
			{
				return DeckCostumeSettingInfoRequest._parser;
			}
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0601DE94 RID: 122516 RVA: 0x008290DB File Offset: 0x008272DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeckCostumeSettingInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0601DE95 RID: 122517 RVA: 0x008290ED File Offset: 0x008272ED
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeckCostumeSettingInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601DE96 RID: 122518 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeckCostumeSettingInfoRequest()
		{
		}

		// Token: 0x0601DE97 RID: 122519 RVA: 0x008290F4 File Offset: 0x008272F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DeckCostumeSettingInfoRequest(DeckCostumeSettingInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DE98 RID: 122520 RVA: 0x00829119 File Offset: 0x00827319
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DeckCostumeSettingInfoRequest Clone()
		{
			return new DeckCostumeSettingInfoRequest(this);
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0601DE99 RID: 122521 RVA: 0x00829121 File Offset: 0x00827321
		// (set) Token: 0x0601DE9A RID: 122522 RVA: 0x00829129 File Offset: 0x00827329
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

		// Token: 0x0601DE9B RID: 122523 RVA: 0x00829132 File Offset: 0x00827332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeckCostumeSettingInfoRequest);
		}

		// Token: 0x0601DE9C RID: 122524 RVA: 0x00829140 File Offset: 0x00827340
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(DeckCostumeSettingInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DE9D RID: 122525 RVA: 0x00829170 File Offset: 0x00827370
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

		// Token: 0x0601DE9E RID: 122526 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601DE9F RID: 122527 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DEA0 RID: 122528 RVA: 0x008291AF File Offset: 0x008273AF
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

		// Token: 0x0601DEA1 RID: 122529 RVA: 0x008291E0 File Offset: 0x008273E0
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

		// Token: 0x0601DEA2 RID: 122530 RVA: 0x0082921E File Offset: 0x0082741E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeckCostumeSettingInfoRequest other)
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

		// Token: 0x0601DEA3 RID: 122531 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DEA4 RID: 122532 RVA: 0x00829250 File Offset: 0x00827450
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
		private static readonly MessageParser<DeckCostumeSettingInfoRequest> _parser = new MessageParser<DeckCostumeSettingInfoRequest>(() => new DeckCostumeSettingInfoRequest());

		// Token: 0x040166C7 RID: 91847
		private UnknownFieldSet _unknownFields;

		// Token: 0x040166C8 RID: 91848
		public const int SeqFieldNumber = 1;

		// Token: 0x040166C9 RID: 91849
		private int seq_;
	}
}
