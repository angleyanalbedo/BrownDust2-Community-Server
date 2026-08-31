using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AA5 RID: 19109
	public sealed class FishingInfoRequest : IMessage<FishingInfoRequest>, IMessage, IEquatable<FishingInfoRequest>, IDeepCloneable<FishingInfoRequest>, IBufferMessage
	{
		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0601EB43 RID: 125763 RVA: 0x008441BF File Offset: 0x008423BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingInfoRequest> Parser
		{
			get
			{
				return FishingInfoRequest._parser;
			}
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x0601EB44 RID: 125764 RVA: 0x008441C6 File Offset: 0x008423C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x0601EB45 RID: 125765 RVA: 0x008441D8 File Offset: 0x008423D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601EB46 RID: 125766 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest()
		{
		}

		// Token: 0x0601EB47 RID: 125767 RVA: 0x008441DF File Offset: 0x008423DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest(FishingInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601EB48 RID: 125768 RVA: 0x00844204 File Offset: 0x00842404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest Clone()
		{
			return new FishingInfoRequest(this);
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0601EB49 RID: 125769 RVA: 0x0084420C File Offset: 0x0084240C
		// (set) Token: 0x0601EB4A RID: 125770 RVA: 0x00844214 File Offset: 0x00842414
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

		// Token: 0x0601EB4B RID: 125771 RVA: 0x0084421D File Offset: 0x0084241D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfoRequest);
		}

		// Token: 0x0601EB4C RID: 125772 RVA: 0x0084422B File Offset: 0x0084242B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601EB4D RID: 125773 RVA: 0x0084425C File Offset: 0x0084245C
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

		// Token: 0x0601EB4E RID: 125774 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601EB4F RID: 125775 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601EB50 RID: 125776 RVA: 0x0084429B File Offset: 0x0084249B
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

		// Token: 0x0601EB51 RID: 125777 RVA: 0x008442CC File Offset: 0x008424CC
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

		// Token: 0x0601EB52 RID: 125778 RVA: 0x0084430A File Offset: 0x0084250A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfoRequest other)
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

		// Token: 0x0601EB53 RID: 125779 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601EB54 RID: 125780 RVA: 0x0084433C File Offset: 0x0084253C
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
		private static readonly MessageParser<FishingInfoRequest> _parser = new MessageParser<FishingInfoRequest>(() => new FishingInfoRequest());

		// Token: 0x04016B2F RID: 92975
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016B30 RID: 92976
		public const int SeqFieldNumber = 1;

		// Token: 0x04016B31 RID: 92977
		private int seq_;
	}
}
