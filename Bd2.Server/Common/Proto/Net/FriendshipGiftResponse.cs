using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052AA RID: 21162
	public sealed class FriendshipGiftResponse : IMessage<FriendshipGiftResponse>, IMessage, IEquatable<FriendshipGiftResponse>, IDeepCloneable<FriendshipGiftResponse>, IBufferMessage
	{
		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x0602326D RID: 143981 RVA: 0x008E13B3 File Offset: 0x008DF5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendshipGiftResponse> Parser
		{
			get
			{
				return FriendshipGiftResponse._parser;
			}
		}

		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x0602326E RID: 143982 RVA: 0x008E13BA File Offset: 0x008DF5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipGiftResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x0602326F RID: 143983 RVA: 0x008E13CC File Offset: 0x008DF5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipGiftResponse.Descriptor;
			}
		}

		// Token: 0x06023270 RID: 143984 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipGiftResponse()
		{
		}

		// Token: 0x06023271 RID: 143985 RVA: 0x008E13D4 File Offset: 0x008DF5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipGiftResponse(FriendshipGiftResponse other)
			: this()
		{
			this.rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
			this.friendshipInfo_ = ((other.friendshipInfo_ != null) ? other.friendshipInfo_.Clone() : null);
			this.gainedExp_ = other.gainedExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06023272 RID: 143986 RVA: 0x008E143C File Offset: 0x008DF63C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipGiftResponse Clone()
		{
			return new FriendshipGiftResponse(this);
		}

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x06023273 RID: 143987 RVA: 0x008E1444 File Offset: 0x008DF644
		// (set) Token: 0x06023274 RID: 143988 RVA: 0x008E144C File Offset: 0x008DF64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x06023275 RID: 143989 RVA: 0x008E1455 File Offset: 0x008DF655
		// (set) Token: 0x06023276 RID: 143990 RVA: 0x008E145D File Offset: 0x008DF65D
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

		// Token: 0x17004C89 RID: 19593
		// (get) Token: 0x06023277 RID: 143991 RVA: 0x008E1466 File Offset: 0x008DF666
		// (set) Token: 0x06023278 RID: 143992 RVA: 0x008E146E File Offset: 0x008DF66E
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

		// Token: 0x06023279 RID: 143993 RVA: 0x008E1477 File Offset: 0x008DF677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipGiftResponse);
		}

		// Token: 0x0602327A RID: 143994 RVA: 0x008E1488 File Offset: 0x008DF688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipGiftResponse other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfoBundle, other.RewardInfoBundle) && object.Equals(this.FriendshipInfo, other.FriendshipInfo) && this.GainedExp == other.GainedExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0602327B RID: 143995 RVA: 0x008E14EC File Offset: 0x008DF6EC
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

		// Token: 0x0602327C RID: 143996 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0602327D RID: 143997 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0602327E RID: 143998 RVA: 0x008E1558 File Offset: 0x008DF758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
			if (this.GainedExp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GainedExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0602327F RID: 143999 RVA: 0x008E15D0 File Offset: 0x008DF7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06023280 RID: 144000 RVA: 0x008E1640 File Offset: 0x008DF840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipGiftResponse other)
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
			if (other.GainedExp != 0)
			{
				this.GainedExp = other.GainedExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023281 RID: 144001 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06023282 RID: 144002 RVA: 0x008E16D4 File Offset: 0x008DF8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GainedExp = input.ReadInt32();
						}
					}
					else
					{
						if (this.friendshipInfo_ == null)
						{
							this.FriendshipInfo = new FriendshipDBInfo();
						}
						input.ReadMessage(this.FriendshipInfo);
					}
				}
				else
				{
					if (this.rewardInfoBundle_ == null)
					{
						this.RewardInfoBundle = new RewardDBInfoBundle();
					}
					input.ReadMessage(this.RewardInfoBundle);
				}
			}
		}

		// Token: 0x0401845E RID: 99422
		private static readonly MessageParser<FriendshipGiftResponse> _parser = new MessageParser<FriendshipGiftResponse>(() => new FriendshipGiftResponse());

		// Token: 0x0401845F RID: 99423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018460 RID: 99424
		public const int RewardInfoBundleFieldNumber = 1;

		// Token: 0x04018461 RID: 99425
		private RewardDBInfoBundle rewardInfoBundle_;

		// Token: 0x04018462 RID: 99426
		public const int FriendshipInfoFieldNumber = 2;

		// Token: 0x04018463 RID: 99427
		private FriendshipDBInfo friendshipInfo_;

		// Token: 0x04018464 RID: 99428
		public const int GainedExpFieldNumber = 3;

		// Token: 0x04018465 RID: 99429
		private int gainedExp_;
	}
}
