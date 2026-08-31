using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004437 RID: 17463
	public sealed class CounselingDBInfo : IMessage<CounselingDBInfo>, IMessage, IEquatable<CounselingDBInfo>, IDeepCloneable<CounselingDBInfo>, IBufferMessage
	{
		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x0601B3A1 RID: 111521 RVA: 0x007BA5B4 File Offset: 0x007B87B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CounselingDBInfo> Parser
		{
			get
			{
				return CounselingDBInfo._parser;
			}
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x0601B3A2 RID: 111522 RVA: 0x007BA5BB File Offset: 0x007B87BB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CounselingDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x0601B3A3 RID: 111523 RVA: 0x007BA5CD File Offset: 0x007B87CD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CounselingDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B3A4 RID: 111524 RVA: 0x007BA5D4 File Offset: 0x007B87D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CounselingDBInfo()
		{
		}

		// Token: 0x0601B3A5 RID: 111525 RVA: 0x007BA5E7 File Offset: 0x007B87E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CounselingDBInfo(CounselingDBInfo other)
			: this()
		{
			this.friendshipCostumeId_ = other.friendshipCostumeId_;
			this.counselingSessionId_ = other.counselingSessionId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3A6 RID: 111526 RVA: 0x007BA61D File Offset: 0x007B881D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CounselingDBInfo Clone()
		{
			return new CounselingDBInfo(this);
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x0601B3A7 RID: 111527 RVA: 0x007BA625 File Offset: 0x007B8825
		// (set) Token: 0x0601B3A8 RID: 111528 RVA: 0x007BA62D File Offset: 0x007B882D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FriendshipCostumeId
		{
			get
			{
				return this.friendshipCostumeId_;
			}
			set
			{
				this.friendshipCostumeId_ = value;
			}
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x0601B3A9 RID: 111529 RVA: 0x007BA636 File Offset: 0x007B8836
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> CounselingSessionId
		{
			get
			{
				return this.counselingSessionId_;
			}
		}

		// Token: 0x0601B3AA RID: 111530 RVA: 0x007BA63E File Offset: 0x007B883E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CounselingDBInfo);
		}

		// Token: 0x0601B3AB RID: 111531 RVA: 0x007BA64C File Offset: 0x007B884C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(CounselingDBInfo other)
		{
			return other != null && (other == this || (this.FriendshipCostumeId == other.FriendshipCostumeId && this.counselingSessionId_.Equals(other.counselingSessionId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3AC RID: 111532 RVA: 0x007BA69C File Offset: 0x007B889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FriendshipCostumeId != 0)
			{
				num ^= this.FriendshipCostumeId.GetHashCode();
			}
			num ^= this.counselingSessionId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B3AD RID: 111533 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B3AE RID: 111534 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3AF RID: 111535 RVA: 0x007BA6EC File Offset: 0x007B88EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FriendshipCostumeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FriendshipCostumeId);
			}
			this.counselingSessionId_.WriteTo(ref output, CounselingDBInfo._repeated_counselingSessionId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3B0 RID: 111536 RVA: 0x007BA73C File Offset: 0x007B893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FriendshipCostumeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FriendshipCostumeId);
			}
			num += this.counselingSessionId_.CalculateSize(CounselingDBInfo._repeated_counselingSessionId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B3B1 RID: 111537 RVA: 0x007BA790 File Offset: 0x007B8990
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CounselingDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FriendshipCostumeId != 0)
			{
				this.FriendshipCostumeId = other.FriendshipCostumeId;
			}
			this.counselingSessionId_.Add(other.counselingSessionId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B3B2 RID: 111538 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3B3 RID: 111539 RVA: 0x007BA7E0 File Offset: 0x007B89E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.counselingSessionId_.AddEntriesFrom(ref input, CounselingDBInfo._repeated_counselingSessionId_codec);
					}
				}
				else
				{
					this.FriendshipCostumeId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<CounselingDBInfo> _parser = new MessageParser<CounselingDBInfo>(() => new CounselingDBInfo());

		// Token: 0x04014D31 RID: 85297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014D32 RID: 85298
		public const int FriendshipCostumeIdFieldNumber = 1;

		// Token: 0x04014D33 RID: 85299
		private int friendshipCostumeId_;

		// Token: 0x04014D34 RID: 85300
		public const int CounselingSessionIdFieldNumber = 2;

		// Token: 0x04014D35 RID: 85301
		private static readonly FieldCodec<int> _repeated_counselingSessionId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04014D36 RID: 85302
		private readonly RepeatedField<int> counselingSessionId_ = new RepeatedField<int>();
	}
}
