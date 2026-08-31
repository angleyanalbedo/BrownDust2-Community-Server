using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043EB RID: 17387
	public sealed class CafeteriaDBInfo : IMessage<CafeteriaDBInfo>, IMessage, IEquatable<CafeteriaDBInfo>, IDeepCloneable<CafeteriaDBInfo>, IBufferMessage
	{
		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x0601B0AF RID: 110767 RVA: 0x007B22B0 File Offset: 0x007B04B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CafeteriaDBInfo> Parser
		{
			get
			{
				return CafeteriaDBInfo._parser;
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0601B0B0 RID: 110768 RVA: 0x007B22B7 File Offset: 0x007B04B7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CafeteriaDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x0601B0B1 RID: 110769 RVA: 0x007B22C9 File Offset: 0x007B04C9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CafeteriaDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B0B2 RID: 110770 RVA: 0x007B22D0 File Offset: 0x007B04D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaDBInfo()
		{
		}

		// Token: 0x0601B0B3 RID: 110771 RVA: 0x007B22F0 File Offset: 0x007B04F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CafeteriaDBInfo(CafeteriaDBInfo other)
			: this()
		{
			this.level_ = other.level_;
			this.rewardReceiptTime_ = other.rewardReceiptTime_;
			this.spawnTime_ = other.spawnTime_;
			this.ongoingManageId_ = other.ongoingManageId_;
			this.dailyRegularCostumeId_ = other.dailyRegularCostumeId_.Clone();
			this.rewardedDailyRegularCostumeId_ = other.rewardedDailyRegularCostumeId_.Clone();
			this.dailyConnectionCostumeId_ = other.dailyConnectionCostumeId_;
			this.canGetPhoneNumber_ = other.canGetPhoneNumber_;
			this.dailyNpcRewardCurrencyCount_ = other.dailyNpcRewardCurrencyCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0B4 RID: 110772 RVA: 0x007B238A File Offset: 0x007B058A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CafeteriaDBInfo Clone()
		{
			return new CafeteriaDBInfo(this);
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x0601B0B5 RID: 110773 RVA: 0x007B2392 File Offset: 0x007B0592
		// (set) Token: 0x0601B0B6 RID: 110774 RVA: 0x007B239A File Offset: 0x007B059A
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

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x0601B0B7 RID: 110775 RVA: 0x007B23A3 File Offset: 0x007B05A3
		// (set) Token: 0x0601B0B8 RID: 110776 RVA: 0x007B23AB File Offset: 0x007B05AB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long RewardReceiptTime
		{
			get
			{
				return this.rewardReceiptTime_;
			}
			set
			{
				this.rewardReceiptTime_ = value;
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x0601B0B9 RID: 110777 RVA: 0x007B23B4 File Offset: 0x007B05B4
		// (set) Token: 0x0601B0BA RID: 110778 RVA: 0x007B23BC File Offset: 0x007B05BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long SpawnTime
		{
			get
			{
				return this.spawnTime_;
			}
			set
			{
				this.spawnTime_ = value;
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x0601B0BB RID: 110779 RVA: 0x007B23C5 File Offset: 0x007B05C5
		// (set) Token: 0x0601B0BC RID: 110780 RVA: 0x007B23CD File Offset: 0x007B05CD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int OngoingManageId
		{
			get
			{
				return this.ongoingManageId_;
			}
			set
			{
				this.ongoingManageId_ = value;
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x0601B0BD RID: 110781 RVA: 0x007B23D6 File Offset: 0x007B05D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> DailyRegularCostumeId
		{
			get
			{
				return this.dailyRegularCostumeId_;
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x0601B0BE RID: 110782 RVA: 0x007B23DE File Offset: 0x007B05DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedDailyRegularCostumeId
		{
			get
			{
				return this.rewardedDailyRegularCostumeId_;
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x0601B0BF RID: 110783 RVA: 0x007B23E6 File Offset: 0x007B05E6
		// (set) Token: 0x0601B0C0 RID: 110784 RVA: 0x007B23EE File Offset: 0x007B05EE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int DailyConnectionCostumeId
		{
			get
			{
				return this.dailyConnectionCostumeId_;
			}
			set
			{
				this.dailyConnectionCostumeId_ = value;
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x0601B0C1 RID: 110785 RVA: 0x007B23F7 File Offset: 0x007B05F7
		// (set) Token: 0x0601B0C2 RID: 110786 RVA: 0x007B23FF File Offset: 0x007B05FF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool CanGetPhoneNumber
		{
			get
			{
				return this.canGetPhoneNumber_;
			}
			set
			{
				this.canGetPhoneNumber_ = value;
			}
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x0601B0C3 RID: 110787 RVA: 0x007B2408 File Offset: 0x007B0608
		// (set) Token: 0x0601B0C4 RID: 110788 RVA: 0x007B2410 File Offset: 0x007B0610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DailyNpcRewardCurrencyCount
		{
			get
			{
				return this.dailyNpcRewardCurrencyCount_;
			}
			set
			{
				this.dailyNpcRewardCurrencyCount_ = value;
			}
		}

		// Token: 0x0601B0C5 RID: 110789 RVA: 0x007B2419 File Offset: 0x007B0619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CafeteriaDBInfo);
		}

		// Token: 0x0601B0C6 RID: 110790 RVA: 0x007B2428 File Offset: 0x007B0628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(CafeteriaDBInfo other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.RewardReceiptTime == other.RewardReceiptTime && this.SpawnTime == other.SpawnTime && this.OngoingManageId == other.OngoingManageId && this.dailyRegularCostumeId_.Equals(other.dailyRegularCostumeId_) && this.rewardedDailyRegularCostumeId_.Equals(other.rewardedDailyRegularCostumeId_) && this.DailyConnectionCostumeId == other.DailyConnectionCostumeId && this.CanGetPhoneNumber == other.CanGetPhoneNumber && this.DailyNpcRewardCurrencyCount == other.DailyNpcRewardCurrencyCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0C7 RID: 110791 RVA: 0x007B24EC File Offset: 0x007B06EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.RewardReceiptTime != 0L)
			{
				num ^= this.RewardReceiptTime.GetHashCode();
			}
			if (this.SpawnTime != 0L)
			{
				num ^= this.SpawnTime.GetHashCode();
			}
			if (this.OngoingManageId != 0)
			{
				num ^= this.OngoingManageId.GetHashCode();
			}
			num ^= this.dailyRegularCostumeId_.GetHashCode();
			num ^= this.rewardedDailyRegularCostumeId_.GetHashCode();
			if (this.DailyConnectionCostumeId != 0)
			{
				num ^= this.DailyConnectionCostumeId.GetHashCode();
			}
			if (this.CanGetPhoneNumber)
			{
				num ^= this.CanGetPhoneNumber.GetHashCode();
			}
			if (this.DailyNpcRewardCurrencyCount != 0)
			{
				num ^= this.DailyNpcRewardCurrencyCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B0C8 RID: 110792 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B0C9 RID: 110793 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0CA RID: 110794 RVA: 0x007B25E0 File Offset: 0x007B07E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.RewardReceiptTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.RewardReceiptTime);
			}
			if (this.SpawnTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SpawnTime);
			}
			if (this.OngoingManageId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OngoingManageId);
			}
			this.dailyRegularCostumeId_.WriteTo(ref output, CafeteriaDBInfo._repeated_dailyRegularCostumeId_codec);
			this.rewardedDailyRegularCostumeId_.WriteTo(ref output, CafeteriaDBInfo._repeated_rewardedDailyRegularCostumeId_codec);
			if (this.DailyConnectionCostumeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DailyConnectionCostumeId);
			}
			if (this.CanGetPhoneNumber)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.CanGetPhoneNumber);
			}
			if (this.DailyNpcRewardCurrencyCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DailyNpcRewardCurrencyCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0CB RID: 110795 RVA: 0x007B26E8 File Offset: 0x007B08E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.RewardReceiptTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RewardReceiptTime);
			}
			if (this.SpawnTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SpawnTime);
			}
			if (this.OngoingManageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OngoingManageId);
			}
			num += this.dailyRegularCostumeId_.CalculateSize(CafeteriaDBInfo._repeated_dailyRegularCostumeId_codec);
			num += this.rewardedDailyRegularCostumeId_.CalculateSize(CafeteriaDBInfo._repeated_rewardedDailyRegularCostumeId_codec);
			if (this.DailyConnectionCostumeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailyConnectionCostumeId);
			}
			if (this.CanGetPhoneNumber)
			{
				num += 2;
			}
			if (this.DailyNpcRewardCurrencyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailyNpcRewardCurrencyCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B0CC RID: 110796 RVA: 0x007B27D0 File Offset: 0x007B09D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CafeteriaDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.RewardReceiptTime != 0L)
			{
				this.RewardReceiptTime = other.RewardReceiptTime;
			}
			if (other.SpawnTime != 0L)
			{
				this.SpawnTime = other.SpawnTime;
			}
			if (other.OngoingManageId != 0)
			{
				this.OngoingManageId = other.OngoingManageId;
			}
			this.dailyRegularCostumeId_.Add(other.dailyRegularCostumeId_);
			this.rewardedDailyRegularCostumeId_.Add(other.rewardedDailyRegularCostumeId_);
			if (other.DailyConnectionCostumeId != 0)
			{
				this.DailyConnectionCostumeId = other.DailyConnectionCostumeId;
			}
			if (other.CanGetPhoneNumber)
			{
				this.CanGetPhoneNumber = other.CanGetPhoneNumber;
			}
			if (other.DailyNpcRewardCurrencyCount != 0)
			{
				this.DailyNpcRewardCurrencyCount = other.DailyNpcRewardCurrencyCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B0CD RID: 110797 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0CE RID: 110798 RVA: 0x007B28A8 File Offset: 0x007B0AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.RewardReceiptTime = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SpawnTime = input.ReadInt64();
							continue;
						}
						if (num == 32U)
						{
							this.OngoingManageId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							goto IL_00AE;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 42U)
					{
						goto IL_00AE;
					}
					if (num == 48U || num == 50U)
					{
						this.rewardedDailyRegularCostumeId_.AddEntriesFrom(ref input, CafeteriaDBInfo._repeated_rewardedDailyRegularCostumeId_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.DailyConnectionCostumeId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CanGetPhoneNumber = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.DailyNpcRewardCurrencyCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_00AE:
				this.dailyRegularCostumeId_.AddEntriesFrom(ref input, CafeteriaDBInfo._repeated_dailyRegularCostumeId_codec);
			}
		}
		private static readonly MessageParser<CafeteriaDBInfo> _parser = new MessageParser<CafeteriaDBInfo>(() => new CafeteriaDBInfo());

		// Token: 0x04014BD0 RID: 84944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014BD1 RID: 84945
		public const int LevelFieldNumber = 1;

		// Token: 0x04014BD2 RID: 84946
		private int level_;

		// Token: 0x04014BD3 RID: 84947
		public const int RewardReceiptTimeFieldNumber = 2;

		// Token: 0x04014BD4 RID: 84948
		private long rewardReceiptTime_;

		// Token: 0x04014BD5 RID: 84949
		public const int SpawnTimeFieldNumber = 3;

		// Token: 0x04014BD6 RID: 84950
		private long spawnTime_;

		// Token: 0x04014BD7 RID: 84951
		public const int OngoingManageIdFieldNumber = 4;

		// Token: 0x04014BD8 RID: 84952
		private int ongoingManageId_;

		// Token: 0x04014BD9 RID: 84953
		public const int DailyRegularCostumeIdFieldNumber = 5;

		// Token: 0x04014BDA RID: 84954
		private static readonly FieldCodec<int> _repeated_dailyRegularCostumeId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04014BDB RID: 84955
		private readonly RepeatedField<int> dailyRegularCostumeId_ = new RepeatedField<int>();

		// Token: 0x04014BDC RID: 84956
		public const int RewardedDailyRegularCostumeIdFieldNumber = 6;

		// Token: 0x04014BDD RID: 84957
		private static readonly FieldCodec<int> _repeated_rewardedDailyRegularCostumeId_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04014BDE RID: 84958
		private readonly RepeatedField<int> rewardedDailyRegularCostumeId_ = new RepeatedField<int>();

		// Token: 0x04014BDF RID: 84959
		public const int DailyConnectionCostumeIdFieldNumber = 7;

		// Token: 0x04014BE0 RID: 84960
		private int dailyConnectionCostumeId_;

		// Token: 0x04014BE1 RID: 84961
		public const int CanGetPhoneNumberFieldNumber = 8;

		// Token: 0x04014BE2 RID: 84962
		private bool canGetPhoneNumber_;

		// Token: 0x04014BE3 RID: 84963
		public const int DailyNpcRewardCurrencyCountFieldNumber = 9;

		// Token: 0x04014BE4 RID: 84964
		private int dailyNpcRewardCurrencyCount_;
	}
}
