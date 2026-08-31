using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200458C RID: 17804
	public sealed class FriendshipDBInfo : IMessage<FriendshipDBInfo>, IMessage, IEquatable<FriendshipDBInfo>, IDeepCloneable<FriendshipDBInfo>, IBufferMessage
	{
		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0601BAA3 RID: 113315 RVA: 0x007CF041 File Offset: 0x007CD241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendshipDBInfo> Parser
		{
			get
			{
				return FriendshipDBInfo._parser;
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0601BAA4 RID: 113316 RVA: 0x007CF048 File Offset: 0x007CD248
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x0601BAA5 RID: 113317 RVA: 0x007CF05A File Offset: 0x007CD25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipDBInfo.Descriptor;
			}
		}

		// Token: 0x0601BAA6 RID: 113318 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipDBInfo()
		{
		}

		// Token: 0x0601BAA7 RID: 113319 RVA: 0x007CF064 File Offset: 0x007CD264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipDBInfo(FriendshipDBInfo other)
			: this()
		{
			this.friendshipCostumeId_ = other.friendshipCostumeId_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.lastCounselingDate_ = other.lastCounselingDate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BAA8 RID: 113320 RVA: 0x007CF0B8 File Offset: 0x007CD2B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipDBInfo Clone()
		{
			return new FriendshipDBInfo(this);
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x0601BAA9 RID: 113321 RVA: 0x007CF0C0 File Offset: 0x007CD2C0
		// (set) Token: 0x0601BAAA RID: 113322 RVA: 0x007CF0C8 File Offset: 0x007CD2C8
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

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x0601BAAB RID: 113323 RVA: 0x007CF0D1 File Offset: 0x007CD2D1
		// (set) Token: 0x0601BAAC RID: 113324 RVA: 0x007CF0D9 File Offset: 0x007CD2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0601BAAD RID: 113325 RVA: 0x007CF0E2 File Offset: 0x007CD2E2
		// (set) Token: 0x0601BAAE RID: 113326 RVA: 0x007CF0EA File Offset: 0x007CD2EA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0601BAAF RID: 113327 RVA: 0x007CF0F3 File Offset: 0x007CD2F3
		// (set) Token: 0x0601BAB0 RID: 113328 RVA: 0x007CF0FB File Offset: 0x007CD2FB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long LastCounselingDate
		{
			get
			{
				return this.lastCounselingDate_;
			}
			set
			{
				this.lastCounselingDate_ = value;
			}
		}

		// Token: 0x0601BAB1 RID: 113329 RVA: 0x007CF104 File Offset: 0x007CD304
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipDBInfo);
		}

		// Token: 0x0601BAB2 RID: 113330 RVA: 0x007CF114 File Offset: 0x007CD314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipDBInfo other)
		{
			return other != null && (other == this || (this.FriendshipCostumeId == other.FriendshipCostumeId && this.Level == other.Level && this.Exp == other.Exp && this.LastCounselingDate == other.LastCounselingDate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BAB3 RID: 113331 RVA: 0x007CF180 File Offset: 0x007CD380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FriendshipCostumeId != 0)
			{
				num ^= this.FriendshipCostumeId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.LastCounselingDate != 0L)
			{
				num ^= this.LastCounselingDate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BAB4 RID: 113332 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BAB5 RID: 113333 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAB6 RID: 113334 RVA: 0x007CF20C File Offset: 0x007CD40C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FriendshipCostumeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FriendshipCostumeId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Exp);
			}
			if (this.LastCounselingDate != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.LastCounselingDate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAB7 RID: 113335 RVA: 0x007CF29C File Offset: 0x007CD49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FriendshipCostumeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FriendshipCostumeId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.LastCounselingDate != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastCounselingDate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BAB8 RID: 113336 RVA: 0x007CF324 File Offset: 0x007CD524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FriendshipCostumeId != 0)
			{
				this.FriendshipCostumeId = other.FriendshipCostumeId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.LastCounselingDate != 0L)
			{
				this.LastCounselingDate = other.LastCounselingDate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BAB9 RID: 113337 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BABA RID: 113338 RVA: 0x007CF39C File Offset: 0x007CD59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.FriendshipCostumeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.LastCounselingDate = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<FriendshipDBInfo> _parser = new MessageParser<FriendshipDBInfo>(() => new FriendshipDBInfo());

		// Token: 0x040155D4 RID: 87508
		private UnknownFieldSet _unknownFields;

		// Token: 0x040155D5 RID: 87509
		public const int FriendshipCostumeIdFieldNumber = 1;

		// Token: 0x040155D6 RID: 87510
		private int friendshipCostumeId_;

		// Token: 0x040155D7 RID: 87511
		public const int LevelFieldNumber = 2;

		// Token: 0x040155D8 RID: 87512
		private int level_;

		// Token: 0x040155D9 RID: 87513
		public const int ExpFieldNumber = 3;

		// Token: 0x040155DA RID: 87514
		private int exp_;

		// Token: 0x040155DB RID: 87515
		public const int LastCounselingDateFieldNumber = 4;

		// Token: 0x040155DC RID: 87516
		private long lastCounselingDate_;
	}
}
