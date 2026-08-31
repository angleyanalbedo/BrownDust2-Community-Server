using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005007 RID: 20487
	public sealed class CashBonusInfoResponse : IMessage<CashBonusInfoResponse>, IMessage, IEquatable<CashBonusInfoResponse>, IDeepCloneable<CashBonusInfoResponse>, IBufferMessage
	{
		// Token: 0x17004717 RID: 18199
		// (get) Token: 0x06021BDA RID: 138202 RVA: 0x008AF3E9 File Offset: 0x008AD5E9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CashBonusInfoResponse> Parser
		{
			get
			{
				return CashBonusInfoResponse._parser;
			}
		}

		// Token: 0x17004718 RID: 18200
		// (get) Token: 0x06021BDB RID: 138203 RVA: 0x008AF3F0 File Offset: 0x008AD5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CashBonusInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004719 RID: 18201
		// (get) Token: 0x06021BDC RID: 138204 RVA: 0x008AF402 File Offset: 0x008AD602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CashBonusInfoResponse.Descriptor;
			}
		}

		// Token: 0x06021BDD RID: 138205 RVA: 0x008AF409 File Offset: 0x008AD609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CashBonusInfoResponse()
		{
		}

		// Token: 0x06021BDE RID: 138206 RVA: 0x008AF41C File Offset: 0x008AD61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CashBonusInfoResponse(CashBonusInfoResponse other)
			: this()
		{
			this.bonusInfo_ = other.bonusInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06021BDF RID: 138207 RVA: 0x008AF446 File Offset: 0x008AD646
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CashBonusInfoResponse Clone()
		{
			return new CashBonusInfoResponse(this);
		}

		// Token: 0x1700471A RID: 18202
		// (get) Token: 0x06021BE0 RID: 138208 RVA: 0x008AF44E File Offset: 0x008AD64E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CashBonusDBInfo> BonusInfo
		{
			get
			{
				return this.bonusInfo_;
			}
		}

		// Token: 0x06021BE1 RID: 138209 RVA: 0x008AF456 File Offset: 0x008AD656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CashBonusInfoResponse);
		}

		// Token: 0x06021BE2 RID: 138210 RVA: 0x008AF464 File Offset: 0x008AD664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CashBonusInfoResponse other)
		{
			return other != null && (other == this || (this.bonusInfo_.Equals(other.bonusInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06021BE3 RID: 138211 RVA: 0x008AF498 File Offset: 0x008AD698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bonusInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06021BE4 RID: 138212 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06021BE5 RID: 138213 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06021BE6 RID: 138214 RVA: 0x008AF4CC File Offset: 0x008AD6CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bonusInfo_.WriteTo(ref output, CashBonusInfoResponse._repeated_bonusInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06021BE7 RID: 138215 RVA: 0x008AF4F4 File Offset: 0x008AD6F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bonusInfo_.CalculateSize(CashBonusInfoResponse._repeated_bonusInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06021BE8 RID: 138216 RVA: 0x008AF52D File Offset: 0x008AD72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CashBonusInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.bonusInfo_.Add(other.bonusInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06021BE9 RID: 138217 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06021BEA RID: 138218 RVA: 0x008AF55C File Offset: 0x008AD75C
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
					this.bonusInfo_.AddEntriesFrom(ref input, CashBonusInfoResponse._repeated_bonusInfo_codec);
				}
			}
		}
		private static readonly MessageParser<CashBonusInfoResponse> _parser = new MessageParser<CashBonusInfoResponse>(() => new CashBonusInfoResponse());

		// Token: 0x04017C66 RID: 97382
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017C67 RID: 97383
		public const int BonusInfoFieldNumber = 1;

		// Token: 0x04017C68 RID: 97384
		private static readonly FieldCodec<CashBonusDBInfo> _repeated_bonusInfo_codec = FieldCodec.ForMessage<CashBonusDBInfo>(10U, CashBonusDBInfo.Parser);

		// Token: 0x04017C69 RID: 97385
		private readonly RepeatedField<CashBonusDBInfo> bonusInfo_ = new RepeatedField<CashBonusDBInfo>();
	}
}
