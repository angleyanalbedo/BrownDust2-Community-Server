using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020055D2 RID: 21970
	public sealed class PrestigeSkinInfoResponse : IMessage<PrestigeSkinInfoResponse>, IMessage, IEquatable<PrestigeSkinInfoResponse>, IDeepCloneable<PrestigeSkinInfoResponse>, IBufferMessage
	{
		// Token: 0x170052C9 RID: 21193
		// (get) Token: 0x06024D18 RID: 150808 RVA: 0x0091A247 File Offset: 0x00918447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrestigeSkinInfoResponse> Parser
		{
			get
			{
				return PrestigeSkinInfoResponse._parser;
			}
		}

		// Token: 0x170052CA RID: 21194
		// (get) Token: 0x06024D19 RID: 150809 RVA: 0x0091A24E File Offset: 0x0091844E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PrestigeSkinInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170052CB RID: 21195
		// (get) Token: 0x06024D1A RID: 150810 RVA: 0x0091A260 File Offset: 0x00918460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrestigeSkinInfoResponse.Descriptor;
			}
		}

		// Token: 0x06024D1B RID: 150811 RVA: 0x0091A267 File Offset: 0x00918467
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrestigeSkinInfoResponse()
		{
		}

		// Token: 0x06024D1C RID: 150812 RVA: 0x0091A27A File Offset: 0x0091847A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrestigeSkinInfoResponse(PrestigeSkinInfoResponse other)
			: this()
		{
			this.prestigeSkinInfo_ = other.prestigeSkinInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06024D1D RID: 150813 RVA: 0x0091A2A4 File Offset: 0x009184A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrestigeSkinInfoResponse Clone()
		{
			return new PrestigeSkinInfoResponse(this);
		}

		// Token: 0x170052CC RID: 21196
		// (get) Token: 0x06024D1E RID: 150814 RVA: 0x0091A2AC File Offset: 0x009184AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<PrestigeSkinDBInfo> PrestigeSkinInfo
		{
			get
			{
				return this.prestigeSkinInfo_;
			}
		}

		// Token: 0x06024D1F RID: 150815 RVA: 0x0091A2B4 File Offset: 0x009184B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrestigeSkinInfoResponse);
		}

		// Token: 0x06024D20 RID: 150816 RVA: 0x0091A2C2 File Offset: 0x009184C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrestigeSkinInfoResponse other)
		{
			return other != null && (other == this || (this.prestigeSkinInfo_.Equals(other.prestigeSkinInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06024D21 RID: 150817 RVA: 0x0091A2F8 File Offset: 0x009184F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.prestigeSkinInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06024D22 RID: 150818 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06024D23 RID: 150819 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06024D24 RID: 150820 RVA: 0x0091A32C File Offset: 0x0091852C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.prestigeSkinInfo_.WriteTo(ref output, PrestigeSkinInfoResponse._repeated_prestigeSkinInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06024D25 RID: 150821 RVA: 0x0091A354 File Offset: 0x00918554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.prestigeSkinInfo_.CalculateSize(PrestigeSkinInfoResponse._repeated_prestigeSkinInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06024D26 RID: 150822 RVA: 0x0091A38D File Offset: 0x0091858D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrestigeSkinInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.prestigeSkinInfo_.Add(other.prestigeSkinInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06024D27 RID: 150823 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06024D28 RID: 150824 RVA: 0x0091A3BC File Offset: 0x009185BC
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
					this.prestigeSkinInfo_.AddEntriesFrom(ref input, PrestigeSkinInfoResponse._repeated_prestigeSkinInfo_codec);
				}
			}
		}
		private static readonly MessageParser<PrestigeSkinInfoResponse> _parser = new MessageParser<PrestigeSkinInfoResponse>(() => new PrestigeSkinInfoResponse());

		// Token: 0x04018D7D RID: 101757
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018D7E RID: 101758
		public const int PrestigeSkinInfoFieldNumber = 1;

		// Token: 0x04018D7F RID: 101759
		private static readonly FieldCodec<PrestigeSkinDBInfo> _repeated_prestigeSkinInfo_codec = FieldCodec.ForMessage<PrestigeSkinDBInfo>(10U, PrestigeSkinDBInfo.Parser);

		// Token: 0x04018D80 RID: 101760
		private readonly RepeatedField<PrestigeSkinDBInfo> prestigeSkinInfo_ = new RepeatedField<PrestigeSkinDBInfo>();
	}
}
