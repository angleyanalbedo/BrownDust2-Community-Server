using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004410 RID: 17424
	public sealed class CharVoteUserDBInfo : IMessage<CharVoteUserDBInfo>, IMessage, IEquatable<CharVoteUserDBInfo>, IDeepCloneable<CharVoteUserDBInfo>, IBufferMessage
	{
		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0601B21A RID: 111130 RVA: 0x007B5BFB File Offset: 0x007B3DFB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharVoteUserDBInfo> Parser
		{
			get
			{
				return CharVoteUserDBInfo._parser;
			}
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x0601B21B RID: 111131 RVA: 0x007B5C02 File Offset: 0x007B3E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharVoteUserDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x0601B21C RID: 111132 RVA: 0x007B5C14 File Offset: 0x007B3E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharVoteUserDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B21D RID: 111133 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharVoteUserDBInfo()
		{
		}

		// Token: 0x0601B21E RID: 111134 RVA: 0x007B5C1C File Offset: 0x007B3E1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharVoteUserDBInfo(CharVoteUserDBInfo other)
			: this()
		{
			this.round_ = other.round_;
			this.candidateId_ = other.candidateId_;
			this.totalCount_ = other.totalCount_;
			this.normalCount_ = other.normalCount_;
			this.additionalCount_ = other.additionalCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B21F RID: 111135 RVA: 0x007B5C7C File Offset: 0x007B3E7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharVoteUserDBInfo Clone()
		{
			return new CharVoteUserDBInfo(this);
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x0601B220 RID: 111136 RVA: 0x007B5C84 File Offset: 0x007B3E84
		// (set) Token: 0x0601B221 RID: 111137 RVA: 0x007B5C8C File Offset: 0x007B3E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Round
		{
			get
			{
				return this.round_;
			}
			set
			{
				this.round_ = value;
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0601B222 RID: 111138 RVA: 0x007B5C95 File Offset: 0x007B3E95
		// (set) Token: 0x0601B223 RID: 111139 RVA: 0x007B5C9D File Offset: 0x007B3E9D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CandidateId
		{
			get
			{
				return this.candidateId_;
			}
			set
			{
				this.candidateId_ = value;
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x0601B224 RID: 111140 RVA: 0x007B5CA6 File Offset: 0x007B3EA6
		// (set) Token: 0x0601B225 RID: 111141 RVA: 0x007B5CAE File Offset: 0x007B3EAE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0601B226 RID: 111142 RVA: 0x007B5CB7 File Offset: 0x007B3EB7
		// (set) Token: 0x0601B227 RID: 111143 RVA: 0x007B5CBF File Offset: 0x007B3EBF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NormalCount
		{
			get
			{
				return this.normalCount_;
			}
			set
			{
				this.normalCount_ = value;
			}
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x0601B228 RID: 111144 RVA: 0x007B5CC8 File Offset: 0x007B3EC8
		// (set) Token: 0x0601B229 RID: 111145 RVA: 0x007B5CD0 File Offset: 0x007B3ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AdditionalCount
		{
			get
			{
				return this.additionalCount_;
			}
			set
			{
				this.additionalCount_ = value;
			}
		}

		// Token: 0x0601B22A RID: 111146 RVA: 0x007B5CD9 File Offset: 0x007B3ED9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharVoteUserDBInfo);
		}

		// Token: 0x0601B22B RID: 111147 RVA: 0x007B5CE8 File Offset: 0x007B3EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharVoteUserDBInfo other)
		{
			return other != null && (other == this || (this.Round == other.Round && this.CandidateId == other.CandidateId && this.TotalCount == other.TotalCount && this.NormalCount == other.NormalCount && this.AdditionalCount == other.AdditionalCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B22C RID: 111148 RVA: 0x007B5D64 File Offset: 0x007B3F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Round != 0)
			{
				num ^= this.Round.GetHashCode();
			}
			if (this.CandidateId != 0)
			{
				num ^= this.CandidateId.GetHashCode();
			}
			if (this.TotalCount != 0)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this.NormalCount != 0)
			{
				num ^= this.NormalCount.GetHashCode();
			}
			if (this.AdditionalCount != 0)
			{
				num ^= this.AdditionalCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B22D RID: 111149 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B22E RID: 111150 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B22F RID: 111151 RVA: 0x007B5E08 File Offset: 0x007B4008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Round != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Round);
			}
			if (this.CandidateId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CandidateId);
			}
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalCount);
			}
			if (this.NormalCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NormalCount);
			}
			if (this.AdditionalCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AdditionalCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B230 RID: 111152 RVA: 0x007B5EB4 File Offset: 0x007B40B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Round != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Round);
			}
			if (this.CandidateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CandidateId);
			}
			if (this.TotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCount);
			}
			if (this.NormalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NormalCount);
			}
			if (this.AdditionalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdditionalCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B231 RID: 111153 RVA: 0x007B5F54 File Offset: 0x007B4154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CharVoteUserDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Round != 0)
			{
				this.Round = other.Round;
			}
			if (other.CandidateId != 0)
			{
				this.CandidateId = other.CandidateId;
			}
			if (other.TotalCount != 0)
			{
				this.TotalCount = other.TotalCount;
			}
			if (other.NormalCount != 0)
			{
				this.NormalCount = other.NormalCount;
			}
			if (other.AdditionalCount != 0)
			{
				this.AdditionalCount = other.AdditionalCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B232 RID: 111154 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B233 RID: 111155 RVA: 0x007B5FE0 File Offset: 0x007B41E0
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
						this.Round = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CandidateId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TotalCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.NormalCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.AdditionalCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<CharVoteUserDBInfo> _parser = new MessageParser<CharVoteUserDBInfo>(() => new CharVoteUserDBInfo());

		// Token: 0x04014C68 RID: 85096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014C69 RID: 85097
		public const int RoundFieldNumber = 1;

		// Token: 0x04014C6A RID: 85098
		private int round_;

		// Token: 0x04014C6B RID: 85099
		public const int CandidateIdFieldNumber = 2;

		// Token: 0x04014C6C RID: 85100
		private int candidateId_;

		// Token: 0x04014C6D RID: 85101
		public const int TotalCountFieldNumber = 3;

		// Token: 0x04014C6E RID: 85102
		private int totalCount_;

		// Token: 0x04014C6F RID: 85103
		public const int NormalCountFieldNumber = 4;

		// Token: 0x04014C70 RID: 85104
		private int normalCount_;

		// Token: 0x04014C71 RID: 85105
		public const int AdditionalCountFieldNumber = 5;

		// Token: 0x04014C72 RID: 85106
		private int additionalCount_;
	}
}
