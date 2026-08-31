using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005058 RID: 20568
	public sealed class CharVoteInfoResponse : IMessage<CharVoteInfoResponse>, IMessage, IEquatable<CharVoteInfoResponse>, IDeepCloneable<CharVoteInfoResponse>, IBufferMessage
	{
		// Token: 0x170047B1 RID: 18353
		// (get) Token: 0x06021E6F RID: 138863 RVA: 0x008B4942 File Offset: 0x008B2B42
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharVoteInfoResponse> Parser
		{
			get
			{
				return CharVoteInfoResponse._parser;
			}
		}

		// Token: 0x170047B2 RID: 18354
		// (get) Token: 0x06021E70 RID: 138864 RVA: 0x008B4949 File Offset: 0x008B2B49
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharVoteInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170047B3 RID: 18355
		// (get) Token: 0x06021E71 RID: 138865 RVA: 0x008B495B File Offset: 0x008B2B5B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharVoteInfoResponse.Descriptor;
			}
		}

		// Token: 0x06021E72 RID: 138866 RVA: 0x008B4964 File Offset: 0x008B2B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharVoteInfoResponse()
		{
		}

		// Token: 0x06021E73 RID: 138867 RVA: 0x008B49BC File Offset: 0x008B2BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharVoteInfoResponse(CharVoteInfoResponse other)
			: this()
		{
			this.currentRound_ = other.currentRound_;
			this.candidateId_ = other.candidateId_.Clone();
			this.voteInfo_ = other.voteInfo_.Clone();
			this.rewardInfo_ = other.rewardInfo_.Clone();
			this.favoriteCandidateId_ = other.favoriteCandidateId_.Clone();
			this.normalVoteCandidateId_ = other.normalVoteCandidateId_.Clone();
			this.nextDailyResetTime_ = other.nextDailyResetTime_;
			this.isDailyReset_ = other.isDailyReset_;
			this.roundScheduleInfo_ = other.roundScheduleInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06021E74 RID: 138868 RVA: 0x008B4A6A File Offset: 0x008B2C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharVoteInfoResponse Clone()
		{
			return new CharVoteInfoResponse(this);
		}

		// Token: 0x170047B4 RID: 18356
		// (get) Token: 0x06021E75 RID: 138869 RVA: 0x008B4A72 File Offset: 0x008B2C72
		// (set) Token: 0x06021E76 RID: 138870 RVA: 0x008B4A7A File Offset: 0x008B2C7A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CurrentRound
		{
			get
			{
				return this.currentRound_;
			}
			set
			{
				this.currentRound_ = value;
			}
		}

		// Token: 0x170047B5 RID: 18357
		// (get) Token: 0x06021E77 RID: 138871 RVA: 0x008B4A83 File Offset: 0x008B2C83
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> CandidateId
		{
			get
			{
				return this.candidateId_;
			}
		}

		// Token: 0x170047B6 RID: 18358
		// (get) Token: 0x06021E78 RID: 138872 RVA: 0x008B4A8B File Offset: 0x008B2C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharVoteUserDBInfo> VoteInfo
		{
			get
			{
				return this.voteInfo_;
			}
		}

		// Token: 0x170047B7 RID: 18359
		// (get) Token: 0x06021E79 RID: 138873 RVA: 0x008B4A93 File Offset: 0x008B2C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharVoteCountRewardDBInfo> RewardInfo
		{
			get
			{
				return this.rewardInfo_;
			}
		}

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x06021E7A RID: 138874 RVA: 0x008B4A9B File Offset: 0x008B2C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FavoriteCandidateId
		{
			get
			{
				return this.favoriteCandidateId_;
			}
		}

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x06021E7B RID: 138875 RVA: 0x008B4AA3 File Offset: 0x008B2CA3
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> NormalVoteCandidateId
		{
			get
			{
				return this.normalVoteCandidateId_;
			}
		}

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x06021E7C RID: 138876 RVA: 0x008B4AAB File Offset: 0x008B2CAB
		// (set) Token: 0x06021E7D RID: 138877 RVA: 0x008B4AB3 File Offset: 0x008B2CB3
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long NextDailyResetTime
		{
			get
			{
				return this.nextDailyResetTime_;
			}
			set
			{
				this.nextDailyResetTime_ = value;
			}
		}

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x06021E7E RID: 138878 RVA: 0x008B4ABC File Offset: 0x008B2CBC
		// (set) Token: 0x06021E7F RID: 138879 RVA: 0x008B4AC4 File Offset: 0x008B2CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDailyReset
		{
			get
			{
				return this.isDailyReset_;
			}
			set
			{
				this.isDailyReset_ = value;
			}
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x06021E80 RID: 138880 RVA: 0x008B4ACD File Offset: 0x008B2CCD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CharVoteRoundScheduleDBInfo> RoundScheduleInfo
		{
			get
			{
				return this.roundScheduleInfo_;
			}
		}

		// Token: 0x06021E81 RID: 138881 RVA: 0x008B4AD5 File Offset: 0x008B2CD5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharVoteInfoResponse);
		}

		// Token: 0x06021E82 RID: 138882 RVA: 0x008B4AE4 File Offset: 0x008B2CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharVoteInfoResponse other)
		{
			return other != null && (other == this || (this.CurrentRound == other.CurrentRound && this.candidateId_.Equals(other.candidateId_) && this.voteInfo_.Equals(other.voteInfo_) && this.rewardInfo_.Equals(other.rewardInfo_) && this.favoriteCandidateId_.Equals(other.favoriteCandidateId_) && this.normalVoteCandidateId_.Equals(other.normalVoteCandidateId_) && this.NextDailyResetTime == other.NextDailyResetTime && this.IsDailyReset == other.IsDailyReset && this.roundScheduleInfo_.Equals(other.roundScheduleInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06021E83 RID: 138883 RVA: 0x008B4BBC File Offset: 0x008B2DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurrentRound != 0)
			{
				num ^= this.CurrentRound.GetHashCode();
			}
			num ^= this.candidateId_.GetHashCode();
			num ^= this.voteInfo_.GetHashCode();
			num ^= this.rewardInfo_.GetHashCode();
			num ^= this.favoriteCandidateId_.GetHashCode();
			num ^= this.normalVoteCandidateId_.GetHashCode();
			if (this.NextDailyResetTime != 0L)
			{
				num ^= this.NextDailyResetTime.GetHashCode();
			}
			if (this.IsDailyReset)
			{
				num ^= this.IsDailyReset.GetHashCode();
			}
			num ^= this.roundScheduleInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06021E84 RID: 138884 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06021E85 RID: 138885 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06021E86 RID: 138886 RVA: 0x008B4C84 File Offset: 0x008B2E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrentRound != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurrentRound);
			}
			this.candidateId_.WriteTo(ref output, CharVoteInfoResponse._repeated_candidateId_codec);
			this.voteInfo_.WriteTo(ref output, CharVoteInfoResponse._repeated_voteInfo_codec);
			this.rewardInfo_.WriteTo(ref output, CharVoteInfoResponse._repeated_rewardInfo_codec);
			this.favoriteCandidateId_.WriteTo(ref output, CharVoteInfoResponse._repeated_favoriteCandidateId_codec);
			this.normalVoteCandidateId_.WriteTo(ref output, CharVoteInfoResponse._repeated_normalVoteCandidateId_codec);
			if (this.NextDailyResetTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.NextDailyResetTime);
			}
			if (this.IsDailyReset)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsDailyReset);
			}
			this.roundScheduleInfo_.WriteTo(ref output, CharVoteInfoResponse._repeated_roundScheduleInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06021E87 RID: 138887 RVA: 0x008B4D60 File Offset: 0x008B2F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurrentRound != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentRound);
			}
			num += this.candidateId_.CalculateSize(CharVoteInfoResponse._repeated_candidateId_codec);
			num += this.voteInfo_.CalculateSize(CharVoteInfoResponse._repeated_voteInfo_codec);
			num += this.rewardInfo_.CalculateSize(CharVoteInfoResponse._repeated_rewardInfo_codec);
			num += this.favoriteCandidateId_.CalculateSize(CharVoteInfoResponse._repeated_favoriteCandidateId_codec);
			num += this.normalVoteCandidateId_.CalculateSize(CharVoteInfoResponse._repeated_normalVoteCandidateId_codec);
			if (this.NextDailyResetTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextDailyResetTime);
			}
			if (this.IsDailyReset)
			{
				num += 2;
			}
			num += this.roundScheduleInfo_.CalculateSize(CharVoteInfoResponse._repeated_roundScheduleInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06021E88 RID: 138888 RVA: 0x008B4E34 File Offset: 0x008B3034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CharVoteInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurrentRound != 0)
			{
				this.CurrentRound = other.CurrentRound;
			}
			this.candidateId_.Add(other.candidateId_);
			this.voteInfo_.Add(other.voteInfo_);
			this.rewardInfo_.Add(other.rewardInfo_);
			this.favoriteCandidateId_.Add(other.favoriteCandidateId_);
			this.normalVoteCandidateId_.Add(other.normalVoteCandidateId_);
			if (other.NextDailyResetTime != 0L)
			{
				this.NextDailyResetTime = other.NextDailyResetTime;
			}
			if (other.IsDailyReset)
			{
				this.IsDailyReset = other.IsDailyReset;
			}
			this.roundScheduleInfo_.Add(other.roundScheduleInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06021E89 RID: 138889 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06021E8A RID: 138890 RVA: 0x008B4F00 File Offset: 0x008B3100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.CurrentRound = input.ReadInt32();
							continue;
						}
						if (num == 16U || num == 18U)
						{
							this.candidateId_.AddEntriesFrom(ref input, CharVoteInfoResponse._repeated_candidateId_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.voteInfo_.AddEntriesFrom(ref input, CharVoteInfoResponse._repeated_voteInfo_codec);
							continue;
						}
						if (num == 34U)
						{
							this.rewardInfo_.AddEntriesFrom(ref input, CharVoteInfoResponse._repeated_rewardInfo_codec);
							continue;
						}
						if (num == 40U)
						{
							goto IL_00D4;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 42U)
					{
						goto IL_00D4;
					}
					if (num == 48U || num == 50U)
					{
						this.normalVoteCandidateId_.AddEntriesFrom(ref input, CharVoteInfoResponse._repeated_normalVoteCandidateId_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.NextDailyResetTime = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.IsDailyReset = input.ReadBool();
						continue;
					}
					if (num == 74U)
					{
						this.roundScheduleInfo_.AddEntriesFrom(ref input, CharVoteInfoResponse._repeated_roundScheduleInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_00D4:
				this.favoriteCandidateId_.AddEntriesFrom(ref input, CharVoteInfoResponse._repeated_favoriteCandidateId_codec);
			}
		}
		private static readonly MessageParser<CharVoteInfoResponse> _parser = new MessageParser<CharVoteInfoResponse>(() => new CharVoteInfoResponse());

		// Token: 0x04017D47 RID: 97607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017D48 RID: 97608
		public const int CurrentRoundFieldNumber = 1;

		// Token: 0x04017D49 RID: 97609
		private int currentRound_;

		// Token: 0x04017D4A RID: 97610
		public const int CandidateIdFieldNumber = 2;

		// Token: 0x04017D4B RID: 97611
		private static readonly FieldCodec<int> _repeated_candidateId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04017D4C RID: 97612
		private readonly RepeatedField<int> candidateId_ = new RepeatedField<int>();

		// Token: 0x04017D4D RID: 97613
		public const int VoteInfoFieldNumber = 3;

		// Token: 0x04017D4E RID: 97614
		private static readonly FieldCodec<CharVoteUserDBInfo> _repeated_voteInfo_codec = FieldCodec.ForMessage<CharVoteUserDBInfo>(26U, CharVoteUserDBInfo.Parser);

		// Token: 0x04017D4F RID: 97615
		private readonly RepeatedField<CharVoteUserDBInfo> voteInfo_ = new RepeatedField<CharVoteUserDBInfo>();

		// Token: 0x04017D50 RID: 97616
		public const int RewardInfoFieldNumber = 4;

		// Token: 0x04017D51 RID: 97617
		private static readonly FieldCodec<CharVoteCountRewardDBInfo> _repeated_rewardInfo_codec = FieldCodec.ForMessage<CharVoteCountRewardDBInfo>(34U, CharVoteCountRewardDBInfo.Parser);

		// Token: 0x04017D52 RID: 97618
		private readonly RepeatedField<CharVoteCountRewardDBInfo> rewardInfo_ = new RepeatedField<CharVoteCountRewardDBInfo>();

		// Token: 0x04017D53 RID: 97619
		public const int FavoriteCandidateIdFieldNumber = 5;

		// Token: 0x04017D54 RID: 97620
		private static readonly FieldCodec<int> _repeated_favoriteCandidateId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04017D55 RID: 97621
		private readonly RepeatedField<int> favoriteCandidateId_ = new RepeatedField<int>();

		// Token: 0x04017D56 RID: 97622
		public const int NormalVoteCandidateIdFieldNumber = 6;

		// Token: 0x04017D57 RID: 97623
		private static readonly FieldCodec<int> _repeated_normalVoteCandidateId_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04017D58 RID: 97624
		private readonly RepeatedField<int> normalVoteCandidateId_ = new RepeatedField<int>();

		// Token: 0x04017D59 RID: 97625
		public const int NextDailyResetTimeFieldNumber = 7;

		// Token: 0x04017D5A RID: 97626
		private long nextDailyResetTime_;

		// Token: 0x04017D5B RID: 97627
		public const int IsDailyResetFieldNumber = 8;

		// Token: 0x04017D5C RID: 97628
		private bool isDailyReset_;

		// Token: 0x04017D5D RID: 97629
		public const int RoundScheduleInfoFieldNumber = 9;

		// Token: 0x04017D5E RID: 97630
		private static readonly FieldCodec<CharVoteRoundScheduleDBInfo> _repeated_roundScheduleInfo_codec = FieldCodec.ForMessage<CharVoteRoundScheduleDBInfo>(74U, CharVoteRoundScheduleDBInfo.Parser);

		// Token: 0x04017D5F RID: 97631
		private readonly RepeatedField<CharVoteRoundScheduleDBInfo> roundScheduleInfo_ = new RepeatedField<CharVoteRoundScheduleDBInfo>();
	}
}
