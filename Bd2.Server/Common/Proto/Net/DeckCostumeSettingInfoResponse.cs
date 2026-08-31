using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020050F8 RID: 20728
	public sealed class DeckCostumeSettingInfoResponse : IMessage<DeckCostumeSettingInfoResponse>, IMessage, IEquatable<DeckCostumeSettingInfoResponse>, IDeepCloneable<DeckCostumeSettingInfoResponse>, IBufferMessage
	{
		// Token: 0x170048FF RID: 18687
		// (get) Token: 0x060223DA RID: 140250 RVA: 0x008C06F3 File Offset: 0x008BE8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeckCostumeSettingInfoResponse> Parser
		{
			get
			{
				return DeckCostumeSettingInfoResponse._parser;
			}
		}

		// Token: 0x17004900 RID: 18688
		// (get) Token: 0x060223DB RID: 140251 RVA: 0x008C06FA File Offset: 0x008BE8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeckCostumeSettingInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x060223DC RID: 140252 RVA: 0x008C070C File Offset: 0x008BE90C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeckCostumeSettingInfoResponse.Descriptor;
			}
		}

		// Token: 0x060223DD RID: 140253 RVA: 0x008C0713 File Offset: 0x008BE913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeckCostumeSettingInfoResponse()
		{
		}

		// Token: 0x060223DE RID: 140254 RVA: 0x008C0726 File Offset: 0x008BE926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeckCostumeSettingInfoResponse(DeckCostumeSettingInfoResponse other)
			: this()
		{
			this.costumeSettingInfo_ = other.costumeSettingInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060223DF RID: 140255 RVA: 0x008C0750 File Offset: 0x008BE950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeckCostumeSettingInfoResponse Clone()
		{
			return new DeckCostumeSettingInfoResponse(this);
		}

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x060223E0 RID: 140256 RVA: 0x008C0758 File Offset: 0x008BE958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DeckCostumeSettingDBInfo> CostumeSettingInfo
		{
			get
			{
				return this.costumeSettingInfo_;
			}
		}

		// Token: 0x060223E1 RID: 140257 RVA: 0x008C0760 File Offset: 0x008BE960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeckCostumeSettingInfoResponse);
		}

		// Token: 0x060223E2 RID: 140258 RVA: 0x008C076E File Offset: 0x008BE96E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(DeckCostumeSettingInfoResponse other)
		{
			return other != null && (other == this || (this.costumeSettingInfo_.Equals(other.costumeSettingInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060223E3 RID: 140259 RVA: 0x008C07A4 File Offset: 0x008BE9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.costumeSettingInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060223E4 RID: 140260 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060223E5 RID: 140261 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060223E6 RID: 140262 RVA: 0x008C07D8 File Offset: 0x008BE9D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.costumeSettingInfo_.WriteTo(ref output, DeckCostumeSettingInfoResponse._repeated_costumeSettingInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060223E7 RID: 140263 RVA: 0x008C0800 File Offset: 0x008BEA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.costumeSettingInfo_.CalculateSize(DeckCostumeSettingInfoResponse._repeated_costumeSettingInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060223E8 RID: 140264 RVA: 0x008C0839 File Offset: 0x008BEA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeckCostumeSettingInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.costumeSettingInfo_.Add(other.costumeSettingInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060223E9 RID: 140265 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060223EA RID: 140266 RVA: 0x008C0868 File Offset: 0x008BEA68
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
					this.costumeSettingInfo_.AddEntriesFrom(ref input, DeckCostumeSettingInfoResponse._repeated_costumeSettingInfo_codec);
				}
			}
		}
		private static readonly MessageParser<DeckCostumeSettingInfoResponse> _parser = new MessageParser<DeckCostumeSettingInfoResponse>(() => new DeckCostumeSettingInfoResponse());

		// Token: 0x04017F32 RID: 98098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017F33 RID: 98099
		public const int CostumeSettingInfoFieldNumber = 1;

		// Token: 0x04017F34 RID: 98100
		private static readonly FieldCodec<DeckCostumeSettingDBInfo> _repeated_costumeSettingInfo_codec = FieldCodec.ForMessage<DeckCostumeSettingDBInfo>(10U, DeckCostumeSettingDBInfo.Parser);

		// Token: 0x04017F35 RID: 98101
		private readonly RepeatedField<DeckCostumeSettingDBInfo> costumeSettingInfo_ = new RepeatedField<DeckCostumeSettingDBInfo>();
	}
}
