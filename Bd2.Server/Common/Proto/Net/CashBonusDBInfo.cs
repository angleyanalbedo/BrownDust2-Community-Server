using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043F7 RID: 17399
	public sealed class CashBonusDBInfo : IMessage<CashBonusDBInfo>, IMessage, IEquatable<CashBonusDBInfo>, IDeepCloneable<CashBonusDBInfo>, IBufferMessage
	{
		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x0601B121 RID: 110881 RVA: 0x007B331D File Offset: 0x007B151D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CashBonusDBInfo> Parser
		{
			get
			{
				return CashBonusDBInfo._parser;
			}
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x0601B122 RID: 110882 RVA: 0x007B3324 File Offset: 0x007B1524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CashBonusDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x0601B123 RID: 110883 RVA: 0x007B3336 File Offset: 0x007B1536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CashBonusDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B124 RID: 110884 RVA: 0x007B333D File Offset: 0x007B153D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CashBonusDBInfo()
		{
		}

		// Token: 0x0601B125 RID: 110885 RVA: 0x007B3350 File Offset: 0x007B1550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CashBonusDBInfo(CashBonusDBInfo other)
			: this()
		{
			this.groupId_ = other.groupId_;
			this.contentsGroupId_ = other.contentsGroupId_;
			this.buyCount_ = other.buyCount_;
			this.rewardedId_ = other.rewardedId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B126 RID: 110886 RVA: 0x007B33A9 File Offset: 0x007B15A9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CashBonusDBInfo Clone()
		{
			return new CashBonusDBInfo(this);
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x0601B127 RID: 110887 RVA: 0x007B33B1 File Offset: 0x007B15B1
		// (set) Token: 0x0601B128 RID: 110888 RVA: 0x007B33B9 File Offset: 0x007B15B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x0601B129 RID: 110889 RVA: 0x007B33C2 File Offset: 0x007B15C2
		// (set) Token: 0x0601B12A RID: 110890 RVA: 0x007B33CA File Offset: 0x007B15CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ContentsGroupId
		{
			get
			{
				return this.contentsGroupId_;
			}
			set
			{
				this.contentsGroupId_ = value;
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x0601B12B RID: 110891 RVA: 0x007B33D3 File Offset: 0x007B15D3
		// (set) Token: 0x0601B12C RID: 110892 RVA: 0x007B33DB File Offset: 0x007B15DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuyCount
		{
			get
			{
				return this.buyCount_;
			}
			set
			{
				this.buyCount_ = value;
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x0601B12D RID: 110893 RVA: 0x007B33E4 File Offset: 0x007B15E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> RewardedId
		{
			get
			{
				return this.rewardedId_;
			}
		}

		// Token: 0x0601B12E RID: 110894 RVA: 0x007B33EC File Offset: 0x007B15EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CashBonusDBInfo);
		}

		// Token: 0x0601B12F RID: 110895 RVA: 0x007B33FC File Offset: 0x007B15FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CashBonusDBInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.ContentsGroupId == other.ContentsGroupId && this.BuyCount == other.BuyCount && this.rewardedId_.Equals(other.rewardedId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B130 RID: 110896 RVA: 0x007B346C File Offset: 0x007B166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.ContentsGroupId != 0)
			{
				num ^= this.ContentsGroupId.GetHashCode();
			}
			if (this.BuyCount != 0)
			{
				num ^= this.BuyCount.GetHashCode();
			}
			num ^= this.rewardedId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B131 RID: 110897 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B132 RID: 110898 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B133 RID: 110899 RVA: 0x007B34EC File Offset: 0x007B16EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.ContentsGroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ContentsGroupId);
			}
			if (this.BuyCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BuyCount);
			}
			this.rewardedId_.WriteTo(ref output, CashBonusDBInfo._repeated_rewardedId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B134 RID: 110900 RVA: 0x007B3574 File Offset: 0x007B1774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.ContentsGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ContentsGroupId);
			}
			if (this.BuyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuyCount);
			}
			num += this.rewardedId_.CalculateSize(CashBonusDBInfo._repeated_rewardedId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B135 RID: 110901 RVA: 0x007B35F8 File Offset: 0x007B17F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CashBonusDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.ContentsGroupId != 0)
			{
				this.ContentsGroupId = other.ContentsGroupId;
			}
			if (other.BuyCount != 0)
			{
				this.BuyCount = other.BuyCount;
			}
			this.rewardedId_.Add(other.rewardedId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B136 RID: 110902 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B137 RID: 110903 RVA: 0x007B3670 File Offset: 0x007B1870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ContentsGroupId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BuyCount = input.ReadInt32();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.rewardedId_.AddEntriesFrom(ref input, CashBonusDBInfo._repeated_rewardedId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<CashBonusDBInfo> _parser = new MessageParser<CashBonusDBInfo>(() => new CashBonusDBInfo());

		// Token: 0x04014BFE RID: 84990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014BFF RID: 84991
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04014C00 RID: 84992
		private int groupId_;

		// Token: 0x04014C01 RID: 84993
		public const int ContentsGroupIdFieldNumber = 2;

		// Token: 0x04014C02 RID: 84994
		private int contentsGroupId_;

		// Token: 0x04014C03 RID: 84995
		public const int BuyCountFieldNumber = 3;

		// Token: 0x04014C04 RID: 84996
		private int buyCount_;

		// Token: 0x04014C05 RID: 84997
		public const int RewardedIdFieldNumber = 4;

		// Token: 0x04014C06 RID: 84998
		private static readonly FieldCodec<int> _repeated_rewardedId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04014C07 RID: 84999
		private readonly RepeatedField<int> rewardedId_ = new RepeatedField<int>();
	}
}
