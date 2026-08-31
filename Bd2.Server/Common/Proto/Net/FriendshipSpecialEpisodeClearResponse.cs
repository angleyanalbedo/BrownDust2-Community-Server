using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052B0 RID: 21168
	public sealed class FriendshipSpecialEpisodeClearResponse : IMessage<FriendshipSpecialEpisodeClearResponse>, IMessage, IEquatable<FriendshipSpecialEpisodeClearResponse>, IDeepCloneable<FriendshipSpecialEpisodeClearResponse>, IBufferMessage
	{
		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x060232A1 RID: 144033 RVA: 0x008E1BAB File Offset: 0x008DFDAB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipSpecialEpisodeClearResponse> Parser
		{
			get
			{
				return FriendshipSpecialEpisodeClearResponse._parser;
			}
		}

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x060232A2 RID: 144034 RVA: 0x008E1BB2 File Offset: 0x008DFDB2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeClearResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x060232A3 RID: 144035 RVA: 0x008E1BC4 File Offset: 0x008DFDC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeClearResponse.Descriptor;
			}
		}

		// Token: 0x060232A4 RID: 144036 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipSpecialEpisodeClearResponse()
		{
		}

		// Token: 0x060232A5 RID: 144037 RVA: 0x008E1BCC File Offset: 0x008DFDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipSpecialEpisodeClearResponse(FriendshipSpecialEpisodeClearResponse other)
			: this()
		{
			this.rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
			this.clearInfo_ = ((other.clearInfo_ != null) ? other.clearInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060232A6 RID: 144038 RVA: 0x008E1C28 File Offset: 0x008DFE28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipSpecialEpisodeClearResponse Clone()
		{
			return new FriendshipSpecialEpisodeClearResponse(this);
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x060232A7 RID: 144039 RVA: 0x008E1C30 File Offset: 0x008DFE30
		// (set) Token: 0x060232A8 RID: 144040 RVA: 0x008E1C38 File Offset: 0x008DFE38
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

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x060232A9 RID: 144041 RVA: 0x008E1C41 File Offset: 0x008DFE41
		// (set) Token: 0x060232AA RID: 144042 RVA: 0x008E1C49 File Offset: 0x008DFE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipSpecialEpisodeDBInfo ClearInfo
		{
			get
			{
				return this.clearInfo_;
			}
			set
			{
				this.clearInfo_ = value;
			}
		}

		// Token: 0x060232AB RID: 144043 RVA: 0x008E1C52 File Offset: 0x008DFE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipSpecialEpisodeClearResponse);
		}

		// Token: 0x060232AC RID: 144044 RVA: 0x008E1C60 File Offset: 0x008DFE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipSpecialEpisodeClearResponse other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfoBundle, other.RewardInfoBundle) && object.Equals(this.ClearInfo, other.ClearInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060232AD RID: 144045 RVA: 0x008E1CB4 File Offset: 0x008DFEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardInfoBundle_ != null)
			{
				num ^= this.RewardInfoBundle.GetHashCode();
			}
			if (this.clearInfo_ != null)
			{
				num ^= this.ClearInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060232AE RID: 144046 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060232AF RID: 144047 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060232B0 RID: 144048 RVA: 0x008E1D08 File Offset: 0x008DFF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardInfoBundle_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RewardInfoBundle);
			}
			if (this.clearInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ClearInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060232B1 RID: 144049 RVA: 0x008E1D64 File Offset: 0x008DFF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardInfoBundle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardInfoBundle);
			}
			if (this.clearInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClearInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060232B2 RID: 144050 RVA: 0x008E1DBC File Offset: 0x008DFFBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FriendshipSpecialEpisodeClearResponse other)
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
			if (other.clearInfo_ != null)
			{
				if (this.clearInfo_ == null)
				{
					this.ClearInfo = new FriendshipSpecialEpisodeDBInfo();
				}
				this.ClearInfo.MergeFrom(other.ClearInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060232B3 RID: 144051 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060232B4 RID: 144052 RVA: 0x008E1E3C File Offset: 0x008E003C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.clearInfo_ == null)
						{
							this.ClearInfo = new FriendshipSpecialEpisodeDBInfo();
						}
						input.ReadMessage(this.ClearInfo);
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

		// Token: 0x04018472 RID: 99442
		private static readonly MessageParser<FriendshipSpecialEpisodeClearResponse> _parser = new MessageParser<FriendshipSpecialEpisodeClearResponse>(() => new FriendshipSpecialEpisodeClearResponse());

		// Token: 0x04018473 RID: 99443
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018474 RID: 99444
		public const int RewardInfoBundleFieldNumber = 1;

		// Token: 0x04018475 RID: 99445
		private RewardDBInfoBundle rewardInfoBundle_;

		// Token: 0x04018476 RID: 99446
		public const int ClearInfoFieldNumber = 2;

		// Token: 0x04018477 RID: 99447
		private FriendshipSpecialEpisodeDBInfo clearInfo_;
	}
}
