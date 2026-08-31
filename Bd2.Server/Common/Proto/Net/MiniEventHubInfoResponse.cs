using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200545E RID: 21598
	public sealed class MiniEventHubInfoResponse : IMessage<MiniEventHubInfoResponse>, IMessage, IEquatable<MiniEventHubInfoResponse>, IDeepCloneable<MiniEventHubInfoResponse>, IBufferMessage
	{
		// Token: 0x17004FD8 RID: 20440
		// (get) Token: 0x060240C2 RID: 147650 RVA: 0x008FF013 File Offset: 0x008FD213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniEventHubInfoResponse> Parser
		{
			get
			{
				return MiniEventHubInfoResponse._parser;
			}
		}

		// Token: 0x17004FD9 RID: 20441
		// (get) Token: 0x060240C3 RID: 147651 RVA: 0x008FF01A File Offset: 0x008FD21A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniEventHubInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x060240C4 RID: 147652 RVA: 0x008FF02C File Offset: 0x008FD22C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniEventHubInfoResponse.Descriptor;
			}
		}

		// Token: 0x060240C5 RID: 147653 RVA: 0x008FF033 File Offset: 0x008FD233
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniEventHubInfoResponse()
		{
		}

		// Token: 0x060240C6 RID: 147654 RVA: 0x008FF046 File Offset: 0x008FD246
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniEventHubInfoResponse(MiniEventHubInfoResponse other)
			: this()
		{
			this.miniEventHubInfo_ = other.miniEventHubInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060240C7 RID: 147655 RVA: 0x008FF070 File Offset: 0x008FD270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniEventHubInfoResponse Clone()
		{
			return new MiniEventHubInfoResponse(this);
		}

		// Token: 0x17004FDB RID: 20443
		// (get) Token: 0x060240C8 RID: 147656 RVA: 0x008FF078 File Offset: 0x008FD278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MiniEventHubDBInfo> MiniEventHubInfo
		{
			get
			{
				return this.miniEventHubInfo_;
			}
		}

		// Token: 0x060240C9 RID: 147657 RVA: 0x008FF080 File Offset: 0x008FD280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniEventHubInfoResponse);
		}

		// Token: 0x060240CA RID: 147658 RVA: 0x008FF08E File Offset: 0x008FD28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniEventHubInfoResponse other)
		{
			return other != null && (other == this || (this.miniEventHubInfo_.Equals(other.miniEventHubInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060240CB RID: 147659 RVA: 0x008FF0C4 File Offset: 0x008FD2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.miniEventHubInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060240CC RID: 147660 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060240CD RID: 147661 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060240CE RID: 147662 RVA: 0x008FF0F8 File Offset: 0x008FD2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.miniEventHubInfo_.WriteTo(ref output, MiniEventHubInfoResponse._repeated_miniEventHubInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060240CF RID: 147663 RVA: 0x008FF120 File Offset: 0x008FD320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.miniEventHubInfo_.CalculateSize(MiniEventHubInfoResponse._repeated_miniEventHubInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060240D0 RID: 147664 RVA: 0x008FF159 File Offset: 0x008FD359
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(MiniEventHubInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.miniEventHubInfo_.Add(other.miniEventHubInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060240D1 RID: 147665 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060240D2 RID: 147666 RVA: 0x008FF188 File Offset: 0x008FD388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.miniEventHubInfo_.AddEntriesFrom(ref input, MiniEventHubInfoResponse._repeated_miniEventHubInfo_codec);
				}
			}
		}
		private static readonly MessageParser<MiniEventHubInfoResponse> _parser = new MessageParser<MiniEventHubInfoResponse>(() => new MiniEventHubInfoResponse());

		// Token: 0x0401891D RID: 100637
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401891E RID: 100638
		public const int MiniEventHubInfoFieldNumber = 1;

		// Token: 0x0401891F RID: 100639
		private static readonly FieldCodec<MiniEventHubDBInfo> _repeated_miniEventHubInfo_codec = FieldCodec.ForMessage<MiniEventHubDBInfo>(10U, MiniEventHubDBInfo.Parser);

		// Token: 0x04018920 RID: 100640
		private readonly RepeatedField<MiniEventHubDBInfo> miniEventHubInfo_ = new RepeatedField<MiniEventHubDBInfo>();
	}
}
