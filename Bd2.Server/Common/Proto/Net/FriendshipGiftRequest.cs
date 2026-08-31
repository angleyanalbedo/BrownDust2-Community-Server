using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AED RID: 19181
	public sealed class FriendshipGiftRequest : IMessage<FriendshipGiftRequest>, IMessage, IEquatable<FriendshipGiftRequest>, IDeepCloneable<FriendshipGiftRequest>, IBufferMessage
	{
		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0601EDAB RID: 126379 RVA: 0x00848A97 File Offset: 0x00846C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendshipGiftRequest> Parser
		{
			get
			{
				return FriendshipGiftRequest._parser;
			}
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0601EDAC RID: 126380 RVA: 0x00848A9E File Offset: 0x00846C9E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipGiftRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0601EDAD RID: 126381 RVA: 0x00848AB0 File Offset: 0x00846CB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipGiftRequest.Descriptor;
			}
		}

		// Token: 0x0601EDAE RID: 126382 RVA: 0x00848AB7 File Offset: 0x00846CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipGiftRequest()
		{
		}

		// Token: 0x0601EDAF RID: 126383 RVA: 0x00848ACC File Offset: 0x00846CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipGiftRequest(FriendshipGiftRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this.costumeId_ = other.costumeId_;
			this.itemInfo_ = other.itemInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601EDB0 RID: 126384 RVA: 0x00848B19 File Offset: 0x00846D19
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipGiftRequest Clone()
		{
			return new FriendshipGiftRequest(this);
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0601EDB1 RID: 126385 RVA: 0x00848B21 File Offset: 0x00846D21
		// (set) Token: 0x0601EDB2 RID: 126386 RVA: 0x00848B29 File Offset: 0x00846D29
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0601EDB3 RID: 126387 RVA: 0x00848B32 File Offset: 0x00846D32
		// (set) Token: 0x0601EDB4 RID: 126388 RVA: 0x00848B3A File Offset: 0x00846D3A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CostumeId
		{
			get
			{
				return this.costumeId_;
			}
			set
			{
				this.costumeId_ = value;
			}
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0601EDB5 RID: 126389 RVA: 0x00848B43 File Offset: 0x00846D43
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ItemDBInfo> ItemInfo
		{
			get
			{
				return this.itemInfo_;
			}
		}

		// Token: 0x0601EDB6 RID: 126390 RVA: 0x00848B4B File Offset: 0x00846D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipGiftRequest);
		}

		// Token: 0x0601EDB7 RID: 126391 RVA: 0x00848B5C File Offset: 0x00846D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipGiftRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && this.CostumeId == other.CostumeId && this.itemInfo_.Equals(other.itemInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601EDB8 RID: 126392 RVA: 0x00848BBC File Offset: 0x00846DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Seq != 0)
			{
				num ^= this.Seq.GetHashCode();
			}
			if (this.CostumeId != 0)
			{
				num ^= this.CostumeId.GetHashCode();
			}
			num ^= this.itemInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601EDB9 RID: 126393 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601EDBA RID: 126394 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601EDBB RID: 126395 RVA: 0x00848C24 File Offset: 0x00846E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Seq != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Seq);
			}
			if (this.CostumeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CostumeId);
			}
			this.itemInfo_.WriteTo(ref output, FriendshipGiftRequest._repeated_itemInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601EDBC RID: 126396 RVA: 0x00848C90 File Offset: 0x00846E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Seq != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seq);
			}
			if (this.CostumeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostumeId);
			}
			num += this.itemInfo_.CalculateSize(FriendshipGiftRequest._repeated_itemInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601EDBD RID: 126397 RVA: 0x00848CFC File Offset: 0x00846EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipGiftRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Seq != 0)
			{
				this.Seq = other.Seq;
			}
			if (other.CostumeId != 0)
			{
				this.CostumeId = other.CostumeId;
			}
			this.itemInfo_.Add(other.itemInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601EDBE RID: 126398 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601EDBF RID: 126399 RVA: 0x00848D60 File Offset: 0x00846F60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemInfo_.AddEntriesFrom(ref input, FriendshipGiftRequest._repeated_itemInfo_codec);
						}
					}
					else
					{
						this.CostumeId = input.ReadInt32();
					}
				}
				else
				{
					this.Seq = input.ReadInt32();
				}
			}
		}

		// Token: 0x04016BEA RID: 93162
		private static readonly MessageParser<FriendshipGiftRequest> _parser = new MessageParser<FriendshipGiftRequest>(() => new FriendshipGiftRequest());

		// Token: 0x04016BEB RID: 93163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016BEC RID: 93164
		public const int SeqFieldNumber = 1;

		// Token: 0x04016BED RID: 93165
		private int seq_;

		// Token: 0x04016BEE RID: 93166
		public const int CostumeIdFieldNumber = 2;

		// Token: 0x04016BEF RID: 93167
		private int costumeId_;

		// Token: 0x04016BF0 RID: 93168
		public const int ItemInfoFieldNumber = 3;

		// Token: 0x04016BF1 RID: 93169
		private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage<ItemDBInfo>(26U, ItemDBInfo.Parser);

		// Token: 0x04016BF2 RID: 93170
		private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();
	}
}
