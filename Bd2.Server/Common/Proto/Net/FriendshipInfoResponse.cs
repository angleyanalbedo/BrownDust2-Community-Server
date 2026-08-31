using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052AD RID: 21165
	public sealed class FriendshipInfoResponse : IMessage<FriendshipInfoResponse>, IMessage, IEquatable<FriendshipInfoResponse>, IDeepCloneable<FriendshipInfoResponse>, IBufferMessage
	{
		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x06023289 RID: 144009 RVA: 0x008E183F File Offset: 0x008DFA3F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipInfoResponse> Parser
		{
			get
			{
				return FriendshipInfoResponse._parser;
			}
		}

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x0602328A RID: 144010 RVA: 0x008E1846 File Offset: 0x008DFA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x0602328B RID: 144011 RVA: 0x008E1858 File Offset: 0x008DFA58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipInfoResponse.Descriptor;
			}
		}

		// Token: 0x0602328C RID: 144012 RVA: 0x008E185F File Offset: 0x008DFA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipInfoResponse()
		{
		}

		// Token: 0x0602328D RID: 144013 RVA: 0x008E187D File Offset: 0x008DFA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipInfoResponse(FriendshipInfoResponse other)
			: this()
		{
			this.friendshipInfo_ = other.friendshipInfo_.Clone();
			this.counselingInfo_ = other.counselingInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0602328E RID: 144014 RVA: 0x008E18B8 File Offset: 0x008DFAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipInfoResponse Clone()
		{
			return new FriendshipInfoResponse(this);
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x0602328F RID: 144015 RVA: 0x008E18C0 File Offset: 0x008DFAC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FriendshipDBInfo> FriendshipInfo
		{
			get
			{
				return this.friendshipInfo_;
			}
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x06023290 RID: 144016 RVA: 0x008E18C8 File Offset: 0x008DFAC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CounselingDBInfo> CounselingInfo
		{
			get
			{
				return this.counselingInfo_;
			}
		}

		// Token: 0x06023291 RID: 144017 RVA: 0x008E18D0 File Offset: 0x008DFAD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipInfoResponse);
		}

		// Token: 0x06023292 RID: 144018 RVA: 0x008E18E0 File Offset: 0x008DFAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipInfoResponse other)
		{
			return other != null && (other == this || (this.friendshipInfo_.Equals(other.friendshipInfo_) && this.counselingInfo_.Equals(other.counselingInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06023293 RID: 144019 RVA: 0x008E1934 File Offset: 0x008DFB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.friendshipInfo_.GetHashCode();
			num ^= this.counselingInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06023294 RID: 144020 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06023295 RID: 144021 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06023296 RID: 144022 RVA: 0x008E1976 File Offset: 0x008DFB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friendshipInfo_.WriteTo(ref output, FriendshipInfoResponse._repeated_friendshipInfo_codec);
			this.counselingInfo_.WriteTo(ref output, FriendshipInfoResponse._repeated_counselingInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06023297 RID: 144023 RVA: 0x008E19B0 File Offset: 0x008DFBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.friendshipInfo_.CalculateSize(FriendshipInfoResponse._repeated_friendshipInfo_codec);
			num += this.counselingInfo_.CalculateSize(FriendshipInfoResponse._repeated_counselingInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06023298 RID: 144024 RVA: 0x008E19FC File Offset: 0x008DFBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.friendshipInfo_.Add(other.friendshipInfo_);
			this.counselingInfo_.Add(other.counselingInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023299 RID: 144025 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0602329A RID: 144026 RVA: 0x008E1A3C File Offset: 0x008DFC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.counselingInfo_.AddEntriesFrom(ref input, FriendshipInfoResponse._repeated_counselingInfo_codec);
					}
				}
				else
				{
					this.friendshipInfo_.AddEntriesFrom(ref input, FriendshipInfoResponse._repeated_friendshipInfo_codec);
				}
			}
		}
		private static readonly MessageParser<FriendshipInfoResponse> _parser = new MessageParser<FriendshipInfoResponse>(() => new FriendshipInfoResponse());

		// Token: 0x04018469 RID: 99433
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401846A RID: 99434
		public const int FriendshipInfoFieldNumber = 1;

		// Token: 0x0401846B RID: 99435
		private static readonly FieldCodec<FriendshipDBInfo> _repeated_friendshipInfo_codec = FieldCodec.ForMessage<FriendshipDBInfo>(10U, FriendshipDBInfo.Parser);

		// Token: 0x0401846C RID: 99436
		private readonly RepeatedField<FriendshipDBInfo> friendshipInfo_ = new RepeatedField<FriendshipDBInfo>();

		// Token: 0x0401846D RID: 99437
		public const int CounselingInfoFieldNumber = 2;

		// Token: 0x0401846E RID: 99438
		private static readonly FieldCodec<CounselingDBInfo> _repeated_counselingInfo_codec = FieldCodec.ForMessage<CounselingDBInfo>(18U, CounselingDBInfo.Parser);

		// Token: 0x0401846F RID: 99439
		private readonly RepeatedField<CounselingDBInfo> counselingInfo_ = new RepeatedField<CounselingDBInfo>();
	}
}
