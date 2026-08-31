using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200456B RID: 17771
	public sealed class FishingDBInfo : IMessage<FishingDBInfo>, IMessage, IEquatable<FishingDBInfo>, IDeepCloneable<FishingDBInfo>, IBufferMessage
	{
		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0601B957 RID: 112983 RVA: 0x007CBCAF File Offset: 0x007C9EAF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingDBInfo> Parser
		{
			get
			{
				return FishingDBInfo._parser;
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0601B958 RID: 112984 RVA: 0x007CBCB6 File Offset: 0x007C9EB6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x0601B959 RID: 112985 RVA: 0x007CBCC8 File Offset: 0x007C9EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B95A RID: 112986 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingDBInfo()
		{
		}

		// Token: 0x0601B95B RID: 112987 RVA: 0x007CBCD0 File Offset: 0x007C9ED0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingDBInfo(FishingDBInfo other)
			: this()
		{
			this.exp_ = other.exp_;
			this.level_ = other.level_;
			this.boatLevel_ = other.boatLevel_;
			this.boatSkinId_ = other.boatSkinId_;
			this.useRodInvenIndex_ = other.useRodInvenIndex_;
			this.multiApResetTime_ = other.multiApResetTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B95C RID: 112988 RVA: 0x007CBD3C File Offset: 0x007C9F3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingDBInfo Clone()
		{
			return new FishingDBInfo(this);
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0601B95D RID: 112989 RVA: 0x007CBD44 File Offset: 0x007C9F44
		// (set) Token: 0x0601B95E RID: 112990 RVA: 0x007CBD4C File Offset: 0x007C9F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0601B95F RID: 112991 RVA: 0x007CBD55 File Offset: 0x007C9F55
		// (set) Token: 0x0601B960 RID: 112992 RVA: 0x007CBD5D File Offset: 0x007C9F5D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0601B961 RID: 112993 RVA: 0x007CBD66 File Offset: 0x007C9F66
		// (set) Token: 0x0601B962 RID: 112994 RVA: 0x007CBD6E File Offset: 0x007C9F6E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BoatLevel
		{
			get
			{
				return this.boatLevel_;
			}
			set
			{
				this.boatLevel_ = value;
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0601B963 RID: 112995 RVA: 0x007CBD77 File Offset: 0x007C9F77
		// (set) Token: 0x0601B964 RID: 112996 RVA: 0x007CBD7F File Offset: 0x007C9F7F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BoatSkinId
		{
			get
			{
				return this.boatSkinId_;
			}
			set
			{
				this.boatSkinId_ = value;
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0601B965 RID: 112997 RVA: 0x007CBD88 File Offset: 0x007C9F88
		// (set) Token: 0x0601B966 RID: 112998 RVA: 0x007CBD90 File Offset: 0x007C9F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UseRodInvenIndex
		{
			get
			{
				return this.useRodInvenIndex_;
			}
			set
			{
				this.useRodInvenIndex_ = value;
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0601B967 RID: 112999 RVA: 0x007CBD99 File Offset: 0x007C9F99
		// (set) Token: 0x0601B968 RID: 113000 RVA: 0x007CBDA1 File Offset: 0x007C9FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MultiApResetTime
		{
			get
			{
				return this.multiApResetTime_;
			}
			set
			{
				this.multiApResetTime_ = value;
			}
		}

		// Token: 0x0601B969 RID: 113001 RVA: 0x007CBDAA File Offset: 0x007C9FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingDBInfo);
		}

		// Token: 0x0601B96A RID: 113002 RVA: 0x007CBDB8 File Offset: 0x007C9FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingDBInfo other)
		{
			return other != null && (other == this || (this.Exp == other.Exp && this.Level == other.Level && this.BoatLevel == other.BoatLevel && this.BoatSkinId == other.BoatSkinId && this.UseRodInvenIndex == other.UseRodInvenIndex && this.MultiApResetTime == other.MultiApResetTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B96B RID: 113003 RVA: 0x007CBE44 File Offset: 0x007CA044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.BoatLevel != 0)
			{
				num ^= this.BoatLevel.GetHashCode();
			}
			if (this.BoatSkinId != 0)
			{
				num ^= this.BoatSkinId.GetHashCode();
			}
			if (this.UseRodInvenIndex != 0L)
			{
				num ^= this.UseRodInvenIndex.GetHashCode();
			}
			if (this.MultiApResetTime != 0L)
			{
				num ^= this.MultiApResetTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B96C RID: 113004 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B96D RID: 113005 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B96E RID: 113006 RVA: 0x007CBF00 File Offset: 0x007CA100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Exp);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.BoatLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BoatLevel);
			}
			if (this.BoatSkinId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BoatSkinId);
			}
			if (this.UseRodInvenIndex != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.UseRodInvenIndex);
			}
			if (this.MultiApResetTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.MultiApResetTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B96F RID: 113007 RVA: 0x007CBFC8 File Offset: 0x007CA1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.BoatLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoatLevel);
			}
			if (this.BoatSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoatSkinId);
			}
			if (this.UseRodInvenIndex != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UseRodInvenIndex);
			}
			if (this.MultiApResetTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MultiApResetTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B970 RID: 113008 RVA: 0x007CC080 File Offset: 0x007CA280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.BoatLevel != 0)
			{
				this.BoatLevel = other.BoatLevel;
			}
			if (other.BoatSkinId != 0)
			{
				this.BoatSkinId = other.BoatSkinId;
			}
			if (other.UseRodInvenIndex != 0L)
			{
				this.UseRodInvenIndex = other.UseRodInvenIndex;
			}
			if (other.MultiApResetTime != 0L)
			{
				this.MultiApResetTime = other.MultiApResetTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B971 RID: 113009 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B972 RID: 113010 RVA: 0x007CC120 File Offset: 0x007CA320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.BoatLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.BoatSkinId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.UseRodInvenIndex = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.MultiApResetTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<FishingDBInfo> _parser = new MessageParser<FishingDBInfo>(() => new FishingDBInfo());

		// Token: 0x0401554D RID: 87373
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401554E RID: 87374
		public const int ExpFieldNumber = 1;

		// Token: 0x0401554F RID: 87375
		private int exp_;

		// Token: 0x04015550 RID: 87376
		public const int LevelFieldNumber = 2;

		// Token: 0x04015551 RID: 87377
		private int level_;

		// Token: 0x04015552 RID: 87378
		public const int BoatLevelFieldNumber = 3;

		// Token: 0x04015553 RID: 87379
		private int boatLevel_;

		// Token: 0x04015554 RID: 87380
		public const int BoatSkinIdFieldNumber = 4;

		// Token: 0x04015555 RID: 87381
		private int boatSkinId_;

		// Token: 0x04015556 RID: 87382
		public const int UseRodInvenIndexFieldNumber = 5;

		// Token: 0x04015557 RID: 87383
		private long useRodInvenIndex_;

		// Token: 0x04015558 RID: 87384
		public const int MultiApResetTimeFieldNumber = 6;

		// Token: 0x04015559 RID: 87385
		private long multiApResetTime_;
	}
}
