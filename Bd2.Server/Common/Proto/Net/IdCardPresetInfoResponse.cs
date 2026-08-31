using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005395 RID: 21397
	public sealed class IdCardPresetInfoResponse : IMessage<IdCardPresetInfoResponse>, IMessage, IEquatable<IdCardPresetInfoResponse>, IDeepCloneable<IdCardPresetInfoResponse>, IBufferMessage
	{
		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x06023A30 RID: 145968 RVA: 0x008F1B99 File Offset: 0x008EFD99
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<IdCardPresetInfoResponse> Parser
		{
			get
			{
				return IdCardPresetInfoResponse._parser;
			}
		}

		// Token: 0x17004E5B RID: 20059
		// (get) Token: 0x06023A31 RID: 145969 RVA: 0x008F1BA0 File Offset: 0x008EFDA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IdCardPresetInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004E5C RID: 20060
		// (get) Token: 0x06023A32 RID: 145970 RVA: 0x008F1BB2 File Offset: 0x008EFDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IdCardPresetInfoResponse.Descriptor;
			}
		}

		// Token: 0x06023A33 RID: 145971 RVA: 0x008F1BB9 File Offset: 0x008EFDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IdCardPresetInfoResponse()
		{
		}

		// Token: 0x06023A34 RID: 145972 RVA: 0x008F1BCC File Offset: 0x008EFDCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardPresetInfoResponse(IdCardPresetInfoResponse other)
			: this()
		{
			this.presetInfo_ = other.presetInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06023A35 RID: 145973 RVA: 0x008F1BF6 File Offset: 0x008EFDF6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardPresetInfoResponse Clone()
		{
			return new IdCardPresetInfoResponse(this);
		}

		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x06023A36 RID: 145974 RVA: 0x008F1BFE File Offset: 0x008EFDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IdCardPresetInfo> PresetInfo
		{
			get
			{
				return this.presetInfo_;
			}
		}

		// Token: 0x06023A37 RID: 145975 RVA: 0x008F1C06 File Offset: 0x008EFE06
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IdCardPresetInfoResponse);
		}

		// Token: 0x06023A38 RID: 145976 RVA: 0x008F1C14 File Offset: 0x008EFE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IdCardPresetInfoResponse other)
		{
			return other != null && (other == this || (this.presetInfo_.Equals(other.presetInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06023A39 RID: 145977 RVA: 0x008F1C48 File Offset: 0x008EFE48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.presetInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06023A3A RID: 145978 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06023A3B RID: 145979 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06023A3C RID: 145980 RVA: 0x008F1C7C File Offset: 0x008EFE7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.presetInfo_.WriteTo(ref output, IdCardPresetInfoResponse._repeated_presetInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06023A3D RID: 145981 RVA: 0x008F1CA4 File Offset: 0x008EFEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.presetInfo_.CalculateSize(IdCardPresetInfoResponse._repeated_presetInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06023A3E RID: 145982 RVA: 0x008F1CDD File Offset: 0x008EFEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IdCardPresetInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.presetInfo_.Add(other.presetInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023A3F RID: 145983 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06023A40 RID: 145984 RVA: 0x008F1D0C File Offset: 0x008EFF0C
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
					this.presetInfo_.AddEntriesFrom(ref input, IdCardPresetInfoResponse._repeated_presetInfo_codec);
				}
			}
		}
		private static readonly MessageParser<IdCardPresetInfoResponse> _parser = new MessageParser<IdCardPresetInfoResponse>(() => new IdCardPresetInfoResponse());

		// Token: 0x0401870C RID: 100108
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401870D RID: 100109
		public const int PresetInfoFieldNumber = 1;

		// Token: 0x0401870E RID: 100110
		private static readonly FieldCodec<IdCardPresetInfo> _repeated_presetInfo_codec = FieldCodec.ForMessage<IdCardPresetInfo>(10U, IdCardPresetInfo.Parser);

		// Token: 0x0401870F RID: 100111
		private readonly RepeatedField<IdCardPresetInfo> presetInfo_ = new RepeatedField<IdCardPresetInfo>();
	}
}
