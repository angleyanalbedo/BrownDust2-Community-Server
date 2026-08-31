using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004FA5 RID: 20389
	public sealed class AvatarShopWishListInfoResponse : IMessage<AvatarShopWishListInfoResponse>, IMessage, IEquatable<AvatarShopWishListInfoResponse>, IDeepCloneable<AvatarShopWishListInfoResponse>, IBufferMessage
	{
		// Token: 0x170045E7 RID: 17895
		// (get) Token: 0x060217D5 RID: 137173 RVA: 0x008A24D0 File Offset: 0x008A06D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AvatarShopWishListInfoResponse> Parser
		{
			get
			{
				return AvatarShopWishListInfoResponse._parser;
			}
		}

		// Token: 0x170045E8 RID: 17896
		// (get) Token: 0x060217D6 RID: 137174 RVA: 0x008A24D7 File Offset: 0x008A06D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarShopWishListInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x060217D7 RID: 137175 RVA: 0x008A24E9 File Offset: 0x008A06E9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarShopWishListInfoResponse.Descriptor;
			}
		}

		// Token: 0x060217D8 RID: 137176 RVA: 0x008A24F0 File Offset: 0x008A06F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarShopWishListInfoResponse()
		{
		}

		// Token: 0x060217D9 RID: 137177 RVA: 0x008A2503 File Offset: 0x008A0703
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AvatarShopWishListInfoResponse(AvatarShopWishListInfoResponse other)
			: this()
		{
			this.shopId_ = other.shopId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060217DA RID: 137178 RVA: 0x008A252D File Offset: 0x008A072D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AvatarShopWishListInfoResponse Clone()
		{
			return new AvatarShopWishListInfoResponse(this);
		}

		// Token: 0x170045EA RID: 17898
		// (get) Token: 0x060217DB RID: 137179 RVA: 0x008A2535 File Offset: 0x008A0735
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> ShopId
		{
			get
			{
				return this.shopId_;
			}
		}

		// Token: 0x060217DC RID: 137180 RVA: 0x008A253D File Offset: 0x008A073D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarShopWishListInfoResponse);
		}

		// Token: 0x060217DD RID: 137181 RVA: 0x008A254B File Offset: 0x008A074B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(AvatarShopWishListInfoResponse other)
		{
			return other != null && (other == this || (this.shopId_.Equals(other.shopId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060217DE RID: 137182 RVA: 0x008A2580 File Offset: 0x008A0780
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shopId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060217DF RID: 137183 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060217E0 RID: 137184 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060217E1 RID: 137185 RVA: 0x008A25B4 File Offset: 0x008A07B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shopId_.WriteTo(ref output, AvatarShopWishListInfoResponse._repeated_shopId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060217E2 RID: 137186 RVA: 0x008A25DC File Offset: 0x008A07DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shopId_.CalculateSize(AvatarShopWishListInfoResponse._repeated_shopId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060217E3 RID: 137187 RVA: 0x008A2615 File Offset: 0x008A0815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarShopWishListInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.shopId_.Add(other.shopId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060217E4 RID: 137188 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060217E5 RID: 137189 RVA: 0x008A2644 File Offset: 0x008A0844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.shopId_.AddEntriesFrom(ref input, AvatarShopWishListInfoResponse._repeated_shopId_codec);
				}
			}
		}
		private static readonly MessageParser<AvatarShopWishListInfoResponse> _parser = new MessageParser<AvatarShopWishListInfoResponse>(() => new AvatarShopWishListInfoResponse());

		// Token: 0x04017A60 RID: 96864
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017A61 RID: 96865
		public const int ShopIdFieldNumber = 1;

		// Token: 0x04017A62 RID: 96866
		private static readonly FieldCodec<int> _repeated_shopId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04017A63 RID: 96867
		private readonly RepeatedField<int> shopId_ = new RepeatedField<int>();
	}
}
