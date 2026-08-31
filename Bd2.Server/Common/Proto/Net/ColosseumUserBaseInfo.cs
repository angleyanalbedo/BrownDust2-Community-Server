using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004421 RID: 17441
	public sealed class ColosseumUserBaseInfo : IMessage<ColosseumUserBaseInfo>, IMessage, IEquatable<ColosseumUserBaseInfo>, IDeepCloneable<ColosseumUserBaseInfo>, IBufferMessage
	{
		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x0601B2C6 RID: 111302 RVA: 0x007B8231 File Offset: 0x007B6431
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ColosseumUserBaseInfo> Parser
		{
			get
			{
				return ColosseumUserBaseInfo._parser;
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x0601B2C7 RID: 111303 RVA: 0x007B8238 File Offset: 0x007B6438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ColosseumUserBaseInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0601B2C8 RID: 111304 RVA: 0x007B824A File Offset: 0x007B644A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ColosseumUserBaseInfo.Descriptor;
			}
		}

		// Token: 0x0601B2C9 RID: 111305 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColosseumUserBaseInfo()
		{
		}

		// Token: 0x0601B2CA RID: 111306 RVA: 0x007B8254 File Offset: 0x007B6454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColosseumUserBaseInfo(ColosseumUserBaseInfo other)
			: this()
		{
			this.vp_ = other.vp_;
			this.rank_ = other.rank_;
			this.winCount_ = other.winCount_;
			this.loseCount_ = other.loseCount_;
			this.topPercent_ = other.topPercent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2CB RID: 111307 RVA: 0x007B82B4 File Offset: 0x007B64B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumUserBaseInfo Clone()
		{
			return new ColosseumUserBaseInfo(this);
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0601B2CC RID: 111308 RVA: 0x007B82BC File Offset: 0x007B64BC
		// (set) Token: 0x0601B2CD RID: 111309 RVA: 0x007B82C4 File Offset: 0x007B64C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Vp
		{
			get
			{
				return this.vp_;
			}
			set
			{
				this.vp_ = value;
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0601B2CE RID: 111310 RVA: 0x007B82CD File Offset: 0x007B64CD
		// (set) Token: 0x0601B2CF RID: 111311 RVA: 0x007B82D5 File Offset: 0x007B64D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0601B2D0 RID: 111312 RVA: 0x007B82DE File Offset: 0x007B64DE
		// (set) Token: 0x0601B2D1 RID: 111313 RVA: 0x007B82E6 File Offset: 0x007B64E6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int WinCount
		{
			get
			{
				return this.winCount_;
			}
			set
			{
				this.winCount_ = value;
			}
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x0601B2D2 RID: 111314 RVA: 0x007B82EF File Offset: 0x007B64EF
		// (set) Token: 0x0601B2D3 RID: 111315 RVA: 0x007B82F7 File Offset: 0x007B64F7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LoseCount
		{
			get
			{
				return this.loseCount_;
			}
			set
			{
				this.loseCount_ = value;
			}
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x0601B2D4 RID: 111316 RVA: 0x007B8300 File Offset: 0x007B6500
		// (set) Token: 0x0601B2D5 RID: 111317 RVA: 0x007B8308 File Offset: 0x007B6508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double TopPercent
		{
			get
			{
				return this.topPercent_;
			}
			set
			{
				this.topPercent_ = value;
			}
		}

		// Token: 0x0601B2D6 RID: 111318 RVA: 0x007B8311 File Offset: 0x007B6511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ColosseumUserBaseInfo);
		}

		// Token: 0x0601B2D7 RID: 111319 RVA: 0x007B8320 File Offset: 0x007B6520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(ColosseumUserBaseInfo other)
		{
			return other != null && (other == this || (this.Vp == other.Vp && this.Rank == other.Rank && this.WinCount == other.WinCount && this.LoseCount == other.LoseCount && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TopPercent, other.TopPercent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2D8 RID: 111320 RVA: 0x007B83A4 File Offset: 0x007B65A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Vp != 0)
			{
				num ^= this.Vp.GetHashCode();
			}
			if (this.Rank != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.WinCount != 0)
			{
				num ^= this.WinCount.GetHashCode();
			}
			if (this.LoseCount != 0)
			{
				num ^= this.LoseCount.GetHashCode();
			}
			if (this.TopPercent != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TopPercent);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B2D9 RID: 111321 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B2DA RID: 111322 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2DB RID: 111323 RVA: 0x007B8454 File Offset: 0x007B6654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Vp != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Vp);
			}
			if (this.Rank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Rank);
			}
			if (this.WinCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WinCount);
			}
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LoseCount);
			}
			if (this.TopPercent != 0.0)
			{
				output.WriteRawTag(41);
				output.WriteDouble(this.TopPercent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2DC RID: 111324 RVA: 0x007B850C File Offset: 0x007B670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Vp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Vp);
			}
			if (this.Rank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
			}
			if (this.WinCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WinCount);
			}
			if (this.LoseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoseCount);
			}
			if (this.TopPercent != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B2DD RID: 111325 RVA: 0x007B85A8 File Offset: 0x007B67A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ColosseumUserBaseInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Vp != 0)
			{
				this.Vp = other.Vp;
			}
			if (other.Rank != 0)
			{
				this.Rank = other.Rank;
			}
			if (other.WinCount != 0)
			{
				this.WinCount = other.WinCount;
			}
			if (other.LoseCount != 0)
			{
				this.LoseCount = other.LoseCount;
			}
			if (other.TopPercent != 0.0)
			{
				this.TopPercent = other.TopPercent;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B2DE RID: 111326 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2DF RID: 111327 RVA: 0x007B8640 File Offset: 0x007B6840
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
						this.Vp = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Rank = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.WinCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.LoseCount = input.ReadInt32();
						continue;
					}
					if (num == 41U)
					{
						this.TopPercent = input.ReadDouble();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<ColosseumUserBaseInfo> _parser = new MessageParser<ColosseumUserBaseInfo>(() => new ColosseumUserBaseInfo());

		// Token: 0x04014CD0 RID: 85200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014CD1 RID: 85201
		public const int VpFieldNumber = 1;

		// Token: 0x04014CD2 RID: 85202
		private int vp_;

		// Token: 0x04014CD3 RID: 85203
		public const int RankFieldNumber = 2;

		// Token: 0x04014CD4 RID: 85204
		private int rank_;

		// Token: 0x04014CD5 RID: 85205
		public const int WinCountFieldNumber = 3;

		// Token: 0x04014CD6 RID: 85206
		private int winCount_;

		// Token: 0x04014CD7 RID: 85207
		public const int LoseCountFieldNumber = 4;

		// Token: 0x04014CD8 RID: 85208
		private int loseCount_;

		// Token: 0x04014CD9 RID: 85209
		public const int TopPercentFieldNumber = 5;

		// Token: 0x04014CDA RID: 85210
		private double topPercent_;
	}
}
