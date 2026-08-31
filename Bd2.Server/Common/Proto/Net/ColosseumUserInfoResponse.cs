using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020050B4 RID: 20660
	public sealed class ColosseumUserInfoResponse : IMessage<ColosseumUserInfoResponse>, IMessage, IEquatable<ColosseumUserInfoResponse>, IDeepCloneable<ColosseumUserInfoResponse>, IBufferMessage
	{
		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x060221A2 RID: 139682 RVA: 0x008BBFFF File Offset: 0x008BA1FF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ColosseumUserInfoResponse> Parser
		{
			get
			{
				return ColosseumUserInfoResponse._parser;
			}
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x060221A3 RID: 139683 RVA: 0x008BC006 File Offset: 0x008BA206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ColosseumUserInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x060221A4 RID: 139684 RVA: 0x008BC018 File Offset: 0x008BA218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ColosseumUserInfoResponse.Descriptor;
			}
		}

		// Token: 0x060221A5 RID: 139685 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumUserInfoResponse()
		{
		}

		// Token: 0x060221A6 RID: 139686 RVA: 0x008BC020 File Offset: 0x008BA220
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColosseumUserInfoResponse(ColosseumUserInfoResponse other)
			: this()
		{
			this.season_ = other.season_;
			this.regularSeason_ = other.regularSeason_;
			this.rankTableChangeSeason_ = other.rankTableChangeSeason_;
			this.baseInfo_ = ((other.baseInfo_ != null) ? other.baseInfo_.Clone() : null);
			this.isSeasonReward_ = other.isSeasonReward_;
			this.apBuyCount_ = other.apBuyCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060221A7 RID: 139687 RVA: 0x008BC09C File Offset: 0x008BA29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumUserInfoResponse Clone()
		{
			return new ColosseumUserInfoResponse(this);
		}

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x060221A8 RID: 139688 RVA: 0x008BC0A4 File Offset: 0x008BA2A4
		// (set) Token: 0x060221A9 RID: 139689 RVA: 0x008BC0AC File Offset: 0x008BA2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Season
		{
			get
			{
				return this.season_;
			}
			set
			{
				this.season_ = value;
			}
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x060221AA RID: 139690 RVA: 0x008BC0B5 File Offset: 0x008BA2B5
		// (set) Token: 0x060221AB RID: 139691 RVA: 0x008BC0BD File Offset: 0x008BA2BD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RegularSeason
		{
			get
			{
				return this.regularSeason_;
			}
			set
			{
				this.regularSeason_ = value;
			}
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x060221AC RID: 139692 RVA: 0x008BC0C6 File Offset: 0x008BA2C6
		// (set) Token: 0x060221AD RID: 139693 RVA: 0x008BC0CE File Offset: 0x008BA2CE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RankTableChangeSeason
		{
			get
			{
				return this.rankTableChangeSeason_;
			}
			set
			{
				this.rankTableChangeSeason_ = value;
			}
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x060221AE RID: 139694 RVA: 0x008BC0D7 File Offset: 0x008BA2D7
		// (set) Token: 0x060221AF RID: 139695 RVA: 0x008BC0DF File Offset: 0x008BA2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumUserBaseInfo BaseInfo
		{
			get
			{
				return this.baseInfo_;
			}
			set
			{
				this.baseInfo_ = value;
			}
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x060221B0 RID: 139696 RVA: 0x008BC0E8 File Offset: 0x008BA2E8
		// (set) Token: 0x060221B1 RID: 139697 RVA: 0x008BC0F0 File Offset: 0x008BA2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSeasonReward
		{
			get
			{
				return this.isSeasonReward_;
			}
			set
			{
				this.isSeasonReward_ = value;
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x060221B2 RID: 139698 RVA: 0x008BC0F9 File Offset: 0x008BA2F9
		// (set) Token: 0x060221B3 RID: 139699 RVA: 0x008BC101 File Offset: 0x008BA301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ApBuyCount
		{
			get
			{
				return this.apBuyCount_;
			}
			set
			{
				this.apBuyCount_ = value;
			}
		}

		// Token: 0x060221B4 RID: 139700 RVA: 0x008BC10A File Offset: 0x008BA30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ColosseumUserInfoResponse);
		}

		// Token: 0x060221B5 RID: 139701 RVA: 0x008BC118 File Offset: 0x008BA318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(ColosseumUserInfoResponse other)
		{
			return other != null && (other == this || (this.Season == other.Season && this.RegularSeason == other.RegularSeason && this.RankTableChangeSeason == other.RankTableChangeSeason && object.Equals(this.BaseInfo, other.BaseInfo) && this.IsSeasonReward == other.IsSeasonReward && this.ApBuyCount == other.ApBuyCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060221B6 RID: 139702 RVA: 0x008BC1A8 File Offset: 0x008BA3A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Season != 0)
			{
				num ^= this.Season.GetHashCode();
			}
			if (this.RegularSeason != 0)
			{
				num ^= this.RegularSeason.GetHashCode();
			}
			if (this.RankTableChangeSeason != 0)
			{
				num ^= this.RankTableChangeSeason.GetHashCode();
			}
			if (this.baseInfo_ != null)
			{
				num ^= this.BaseInfo.GetHashCode();
			}
			if (this.IsSeasonReward)
			{
				num ^= this.IsSeasonReward.GetHashCode();
			}
			if (this.ApBuyCount != 0)
			{
				num ^= this.ApBuyCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060221B7 RID: 139703 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060221B8 RID: 139704 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060221B9 RID: 139705 RVA: 0x008BC264 File Offset: 0x008BA464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Season != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Season);
			}
			if (this.RegularSeason != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RegularSeason);
			}
			if (this.RankTableChangeSeason != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RankTableChangeSeason);
			}
			if (this.baseInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BaseInfo);
			}
			if (this.IsSeasonReward)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsSeasonReward);
			}
			if (this.ApBuyCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ApBuyCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060221BA RID: 139706 RVA: 0x008BC32C File Offset: 0x008BA52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Season != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Season);
			}
			if (this.RegularSeason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RegularSeason);
			}
			if (this.RankTableChangeSeason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RankTableChangeSeason);
			}
			if (this.baseInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BaseInfo);
			}
			if (this.IsSeasonReward)
			{
				num += 2;
			}
			if (this.ApBuyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ApBuyCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060221BB RID: 139707 RVA: 0x008BC3D8 File Offset: 0x008BA5D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(ColosseumUserInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Season != 0)
			{
				this.Season = other.Season;
			}
			if (other.RegularSeason != 0)
			{
				this.RegularSeason = other.RegularSeason;
			}
			if (other.RankTableChangeSeason != 0)
			{
				this.RankTableChangeSeason = other.RankTableChangeSeason;
			}
			if (other.baseInfo_ != null)
			{
				if (this.baseInfo_ == null)
				{
					this.BaseInfo = new ColosseumUserBaseInfo();
				}
				this.BaseInfo.MergeFrom(other.BaseInfo);
			}
			if (other.IsSeasonReward)
			{
				this.IsSeasonReward = other.IsSeasonReward;
			}
			if (other.ApBuyCount != 0)
			{
				this.ApBuyCount = other.ApBuyCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060221BC RID: 139708 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060221BD RID: 139709 RVA: 0x008BC490 File Offset: 0x008BA690
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
						this.Season = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RegularSeason = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.RankTableChangeSeason = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.baseInfo_ == null)
						{
							this.BaseInfo = new ColosseumUserBaseInfo();
						}
						input.ReadMessage(this.BaseInfo);
						continue;
					}
					if (num == 40U)
					{
						this.IsSeasonReward = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.ApBuyCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<ColosseumUserInfoResponse> _parser = new MessageParser<ColosseumUserInfoResponse>(() => new ColosseumUserInfoResponse());

		// Token: 0x04017E7F RID: 97919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017E80 RID: 97920
		public const int SeasonFieldNumber = 1;

		// Token: 0x04017E81 RID: 97921
		private int season_;

		// Token: 0x04017E82 RID: 97922
		public const int RegularSeasonFieldNumber = 2;

		// Token: 0x04017E83 RID: 97923
		private int regularSeason_;

		// Token: 0x04017E84 RID: 97924
		public const int RankTableChangeSeasonFieldNumber = 3;

		// Token: 0x04017E85 RID: 97925
		private int rankTableChangeSeason_;

		// Token: 0x04017E86 RID: 97926
		public const int BaseInfoFieldNumber = 4;

		// Token: 0x04017E87 RID: 97927
		private ColosseumUserBaseInfo baseInfo_;

		// Token: 0x04017E88 RID: 97928
		public const int IsSeasonRewardFieldNumber = 5;

		// Token: 0x04017E89 RID: 97929
		private bool isSeasonReward_;

		// Token: 0x04017E8A RID: 97930
		public const int ApBuyCountFieldNumber = 6;

		// Token: 0x04017E8B RID: 97931
		private int apBuyCount_;
	}
}
