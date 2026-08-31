using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052A7 RID: 21159
	public sealed class FriendshipCounselingResponse : IMessage<FriendshipCounselingResponse>, IMessage, IEquatable<FriendshipCounselingResponse>, IDeepCloneable<FriendshipCounselingResponse>, IBufferMessage
	{
		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x0602324F RID: 143951 RVA: 0x008E0E77 File Offset: 0x008DF077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendshipCounselingResponse> Parser
		{
			get
			{
				return FriendshipCounselingResponse._parser;
			}
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x06023250 RID: 143952 RVA: 0x008E0E7E File Offset: 0x008DF07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipCounselingResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x06023251 RID: 143953 RVA: 0x008E0E90 File Offset: 0x008DF090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipCounselingResponse.Descriptor;
			}
		}

		// Token: 0x06023252 RID: 143954 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipCounselingResponse()
		{
		}

		// Token: 0x06023253 RID: 143955 RVA: 0x008E0E98 File Offset: 0x008DF098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipCounselingResponse(FriendshipCounselingResponse other)
			: this()
		{
			this.rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
			this.friendshipInfo_ = ((other.friendshipInfo_ != null) ? other.friendshipInfo_.Clone() : null);
			this.isCorrect_ = other.isCorrect_;
			this.gainedExp_ = other.gainedExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06023254 RID: 143956 RVA: 0x008E0F0C File Offset: 0x008DF10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipCounselingResponse Clone()
		{
			return new FriendshipCounselingResponse(this);
		}

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x06023255 RID: 143957 RVA: 0x008E0F14 File Offset: 0x008DF114
		// (set) Token: 0x06023256 RID: 143958 RVA: 0x008E0F1C File Offset: 0x008DF11C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RewardDBInfoBundle RewardInfoBundle
		{
			get
			{
				return this.rewardInfoBundle_;
			}
			set
			{
				this.rewardInfoBundle_ = value;
			}
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x06023257 RID: 143959 RVA: 0x008E0F25 File Offset: 0x008DF125
		// (set) Token: 0x06023258 RID: 143960 RVA: 0x008E0F2D File Offset: 0x008DF12D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipDBInfo FriendshipInfo
		{
			get
			{
				return this.friendshipInfo_;
			}
			set
			{
				this.friendshipInfo_ = value;
			}
		}

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x06023259 RID: 143961 RVA: 0x008E0F36 File Offset: 0x008DF136
		// (set) Token: 0x0602325A RID: 143962 RVA: 0x008E0F3E File Offset: 0x008DF13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCorrect
		{
			get
			{
				return this.isCorrect_;
			}
			set
			{
				this.isCorrect_ = value;
			}
		}

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x0602325B RID: 143963 RVA: 0x008E0F47 File Offset: 0x008DF147
		// (set) Token: 0x0602325C RID: 143964 RVA: 0x008E0F4F File Offset: 0x008DF14F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GainedExp
		{
			get
			{
				return this.gainedExp_;
			}
			set
			{
				this.gainedExp_ = value;
			}
		}

		// Token: 0x0602325D RID: 143965 RVA: 0x008E0F58 File Offset: 0x008DF158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipCounselingResponse);
		}

		// Token: 0x0602325E RID: 143966 RVA: 0x008E0F68 File Offset: 0x008DF168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipCounselingResponse other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfoBundle, other.RewardInfoBundle) && object.Equals(this.FriendshipInfo, other.FriendshipInfo) && this.IsCorrect == other.IsCorrect && this.GainedExp == other.GainedExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0602325F RID: 143967 RVA: 0x008E0FDC File Offset: 0x008DF1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardInfoBundle_ != null)
			{
				num ^= this.RewardInfoBundle.GetHashCode();
			}
			if (this.friendshipInfo_ != null)
			{
				num ^= this.FriendshipInfo.GetHashCode();
			}
			if (this.IsCorrect)
			{
				num ^= this.IsCorrect.GetHashCode();
			}
			if (this.GainedExp != 0)
			{
				num ^= this.GainedExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06023260 RID: 143968 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06023261 RID: 143969 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06023262 RID: 143970 RVA: 0x008E1060 File Offset: 0x008DF260
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardInfoBundle_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RewardInfoBundle);
			}
			if (this.friendshipInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FriendshipInfo);
			}
			if (this.IsCorrect)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsCorrect);
			}
			if (this.GainedExp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GainedExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06023263 RID: 143971 RVA: 0x008E10F4 File Offset: 0x008DF2F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardInfoBundle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardInfoBundle);
			}
			if (this.friendshipInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FriendshipInfo);
			}
			if (this.IsCorrect)
			{
				num += 2;
			}
			if (this.GainedExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GainedExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06023264 RID: 143972 RVA: 0x008E1170 File Offset: 0x008DF370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FriendshipCounselingResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardInfoBundle_ != null)
			{
				if (this.rewardInfoBundle_ == null)
				{
					this.RewardInfoBundle = new RewardDBInfoBundle();
				}
				this.RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
			}
			if (other.friendshipInfo_ != null)
			{
				if (this.friendshipInfo_ == null)
				{
					this.FriendshipInfo = new FriendshipDBInfo();
				}
				this.FriendshipInfo.MergeFrom(other.FriendshipInfo);
			}
			if (other.IsCorrect)
			{
				this.IsCorrect = other.IsCorrect;
			}
			if (other.GainedExp != 0)
			{
				this.GainedExp = other.GainedExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023265 RID: 143973 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06023266 RID: 143974 RVA: 0x008E1218 File Offset: 0x008DF418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.rewardInfoBundle_ == null)
						{
							this.RewardInfoBundle = new RewardDBInfoBundle();
						}
						input.ReadMessage(this.RewardInfoBundle);
						continue;
					}
					if (num == 18U)
					{
						if (this.friendshipInfo_ == null)
						{
							this.FriendshipInfo = new FriendshipDBInfo();
						}
						input.ReadMessage(this.FriendshipInfo);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsCorrect = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.GainedExp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04018452 RID: 99410
		private static readonly MessageParser<FriendshipCounselingResponse> _parser = new MessageParser<FriendshipCounselingResponse>(() => new FriendshipCounselingResponse());

		// Token: 0x04018453 RID: 99411
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018454 RID: 99412
		public const int RewardInfoBundleFieldNumber = 1;

		// Token: 0x04018455 RID: 99413
		private RewardDBInfoBundle rewardInfoBundle_;

		// Token: 0x04018456 RID: 99414
		public const int FriendshipInfoFieldNumber = 2;

		// Token: 0x04018457 RID: 99415
		private FriendshipDBInfo friendshipInfo_;

		// Token: 0x04018458 RID: 99416
		public const int IsCorrectFieldNumber = 3;

		// Token: 0x04018459 RID: 99417
		private bool isCorrect_;

		// Token: 0x0401845A RID: 99418
		public const int GainedExpFieldNumber = 4;

		// Token: 0x0401845B RID: 99419
		private int gainedExp_;
	}
}
