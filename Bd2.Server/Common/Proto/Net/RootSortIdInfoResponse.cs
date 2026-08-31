using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005640 RID: 22080
	public sealed class RootSortIdInfoResponse : IMessage<RootSortIdInfoResponse>, IMessage, IEquatable<RootSortIdInfoResponse>, IDeepCloneable<RootSortIdInfoResponse>, IBufferMessage
	{
		// Token: 0x170053D2 RID: 21458
		// (get) Token: 0x06025105 RID: 151813 RVA: 0x0092428A File Offset: 0x0092248A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RootSortIdInfoResponse> Parser
		{
			get
			{
				return RootSortIdInfoResponse._parser;
			}
		}

		// Token: 0x170053D3 RID: 21459
		// (get) Token: 0x06025106 RID: 151814 RVA: 0x00924291 File Offset: 0x00922491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RootSortIdInfoResponseReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170053D4 RID: 21460
		// (get) Token: 0x06025107 RID: 151815 RVA: 0x009242A3 File Offset: 0x009224A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RootSortIdInfoResponse.Descriptor;
			}
		}

		// Token: 0x06025108 RID: 151816 RVA: 0x009242AA File Offset: 0x009224AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RootSortIdInfoResponse()
		{
		}

		// Token: 0x06025109 RID: 151817 RVA: 0x009242BD File Offset: 0x009224BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RootSortIdInfoResponse(RootSortIdInfoResponse other)
			: this()
		{
			this.rootSortInfo_ = other.rootSortInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0602510A RID: 151818 RVA: 0x009242E7 File Offset: 0x009224E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RootSortIdInfoResponse Clone()
		{
			return new RootSortIdInfoResponse(this);
		}

		// Token: 0x170053D5 RID: 21461
		// (get) Token: 0x0602510B RID: 151819 RVA: 0x009242EF File Offset: 0x009224EF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<RootSortIdInfo> RootSortInfo
		{
			get
			{
				return this.rootSortInfo_;
			}
		}

		// Token: 0x0602510C RID: 151820 RVA: 0x009242F7 File Offset: 0x009224F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RootSortIdInfoResponse);
		}

		// Token: 0x0602510D RID: 151821 RVA: 0x00924305 File Offset: 0x00922505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RootSortIdInfoResponse other)
		{
			return other != null && (other == this || (this.rootSortInfo_.Equals(other.rootSortInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0602510E RID: 151822 RVA: 0x00924338 File Offset: 0x00922538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rootSortInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0602510F RID: 151823 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06025110 RID: 151824 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06025111 RID: 151825 RVA: 0x0092436C File Offset: 0x0092256C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rootSortInfo_.WriteTo(ref output, RootSortIdInfoResponse._repeated_rootSortInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06025112 RID: 151826 RVA: 0x00924394 File Offset: 0x00922594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rootSortInfo_.CalculateSize(RootSortIdInfoResponse._repeated_rootSortInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06025113 RID: 151827 RVA: 0x009243CD File Offset: 0x009225CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RootSortIdInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.rootSortInfo_.Add(other.rootSortInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06025114 RID: 151828 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06025115 RID: 151829 RVA: 0x009243FC File Offset: 0x009225FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
					this.rootSortInfo_.AddEntriesFrom(ref input, RootSortIdInfoResponse._repeated_rootSortInfo_codec);
				}
			}
		}
		private static readonly MessageParser<RootSortIdInfoResponse> _parser = new MessageParser<RootSortIdInfoResponse>(() => new RootSortIdInfoResponse());

		// Token: 0x04018F27 RID: 102183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018F28 RID: 102184
		public const int RootSortInfoFieldNumber = 1;

		// Token: 0x04018F29 RID: 102185
		private static readonly FieldCodec<RootSortIdInfo> _repeated_rootSortInfo_codec = FieldCodec.ForMessage<RootSortIdInfo>(10U, RootSortIdInfo.Parser);

		// Token: 0x04018F2A RID: 102186
		private readonly RepeatedField<RootSortIdInfo> rootSortInfo_ = new RepeatedField<RootSortIdInfo>();
	}
}
