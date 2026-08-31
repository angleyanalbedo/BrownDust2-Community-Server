using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020050EC RID: 20716
	public sealed class DatingInfoResponse : IMessage<DatingInfoResponse>, IMessage, IEquatable<DatingInfoResponse>, IDeepCloneable<DatingInfoResponse>, IBufferMessage
	{
		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x0602236B RID: 140139 RVA: 0x008BF350 File Offset: 0x008BD550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DatingInfoResponse> Parser
		{
			get
			{
				return DatingInfoResponse._parser;
			}
		}

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x0602236C RID: 140140 RVA: 0x008BF357 File Offset: 0x008BD557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DatingInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x0602236D RID: 140141 RVA: 0x008BF369 File Offset: 0x008BD569
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DatingInfoResponse.Descriptor;
			}
		}

		// Token: 0x0602236E RID: 140142 RVA: 0x008BF370 File Offset: 0x008BD570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingInfoResponse()
		{
		}

		// Token: 0x0602236F RID: 140143 RVA: 0x008BF39C File Offset: 0x008BD59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingInfoResponse(DatingInfoResponse other)
			: this()
		{
			this.episodeInfo_ = other.episodeInfo_.Clone();
			this.messageChoiceInfo_ = other.messageChoiceInfo_.Clone();
			this.rewardInfo_ = other.rewardInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06022370 RID: 140144 RVA: 0x008BF3F3 File Offset: 0x008BD5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingInfoResponse Clone()
		{
			return new DatingInfoResponse(this);
		}

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x06022371 RID: 140145 RVA: 0x008BF3FB File Offset: 0x008BD5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DatingEpisodeDBInfo> EpisodeInfo
		{
			get
			{
				return this.episodeInfo_;
			}
		}

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x06022372 RID: 140146 RVA: 0x008BF403 File Offset: 0x008BD603
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<DatingMessageChoiceDBInfo> MessageChoiceInfo
		{
			get
			{
				return this.messageChoiceInfo_;
			}
		}

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x06022373 RID: 140147 RVA: 0x008BF40B File Offset: 0x008BD60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DatingMessageRewardInfo> RewardInfo
		{
			get
			{
				return this.rewardInfo_;
			}
		}

		// Token: 0x06022374 RID: 140148 RVA: 0x008BF413 File Offset: 0x008BD613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DatingInfoResponse);
		}

		// Token: 0x06022375 RID: 140149 RVA: 0x008BF424 File Offset: 0x008BD624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DatingInfoResponse other)
		{
			return other != null && (other == this || (this.episodeInfo_.Equals(other.episodeInfo_) && this.messageChoiceInfo_.Equals(other.messageChoiceInfo_) && this.rewardInfo_.Equals(other.rewardInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06022376 RID: 140150 RVA: 0x008BF48C File Offset: 0x008BD68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.episodeInfo_.GetHashCode();
			num ^= this.messageChoiceInfo_.GetHashCode();
			num ^= this.rewardInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06022377 RID: 140151 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06022378 RID: 140152 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06022379 RID: 140153 RVA: 0x008BF4DC File Offset: 0x008BD6DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.episodeInfo_.WriteTo(ref output, DatingInfoResponse._repeated_episodeInfo_codec);
			this.messageChoiceInfo_.WriteTo(ref output, DatingInfoResponse._repeated_messageChoiceInfo_codec);
			this.rewardInfo_.WriteTo(ref output, DatingInfoResponse._repeated_rewardInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0602237A RID: 140154 RVA: 0x008BF530 File Offset: 0x008BD730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.episodeInfo_.CalculateSize(DatingInfoResponse._repeated_episodeInfo_codec);
			num += this.messageChoiceInfo_.CalculateSize(DatingInfoResponse._repeated_messageChoiceInfo_codec);
			num += this.rewardInfo_.CalculateSize(DatingInfoResponse._repeated_rewardInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0602237B RID: 140155 RVA: 0x008BF590 File Offset: 0x008BD790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(DatingInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.episodeInfo_.Add(other.episodeInfo_);
			this.messageChoiceInfo_.Add(other.messageChoiceInfo_);
			this.rewardInfo_.Add(other.rewardInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0602237C RID: 140156 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0602237D RID: 140157 RVA: 0x008BF5EC File Offset: 0x008BD7EC
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.rewardInfo_.AddEntriesFrom(ref input, DatingInfoResponse._repeated_rewardInfo_codec);
						}
					}
					else
					{
						this.messageChoiceInfo_.AddEntriesFrom(ref input, DatingInfoResponse._repeated_messageChoiceInfo_codec);
					}
				}
				else
				{
					this.episodeInfo_.AddEntriesFrom(ref input, DatingInfoResponse._repeated_episodeInfo_codec);
				}
			}
		}
		private static readonly MessageParser<DatingInfoResponse> _parser = new MessageParser<DatingInfoResponse>(() => new DatingInfoResponse());

		// Token: 0x04017EFD RID: 98045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017EFE RID: 98046
		public const int EpisodeInfoFieldNumber = 1;

		// Token: 0x04017EFF RID: 98047
		private static readonly FieldCodec<DatingEpisodeDBInfo> _repeated_episodeInfo_codec = FieldCodec.ForMessage<DatingEpisodeDBInfo>(10U, DatingEpisodeDBInfo.Parser);

		// Token: 0x04017F00 RID: 98048
		private readonly RepeatedField<DatingEpisodeDBInfo> episodeInfo_ = new RepeatedField<DatingEpisodeDBInfo>();

		// Token: 0x04017F01 RID: 98049
		public const int MessageChoiceInfoFieldNumber = 2;

		// Token: 0x04017F02 RID: 98050
		private static readonly FieldCodec<DatingMessageChoiceDBInfo> _repeated_messageChoiceInfo_codec = FieldCodec.ForMessage<DatingMessageChoiceDBInfo>(18U, DatingMessageChoiceDBInfo.Parser);

		// Token: 0x04017F03 RID: 98051
		private readonly RepeatedField<DatingMessageChoiceDBInfo> messageChoiceInfo_ = new RepeatedField<DatingMessageChoiceDBInfo>();

		// Token: 0x04017F04 RID: 98052
		public const int RewardInfoFieldNumber = 3;

		// Token: 0x04017F05 RID: 98053
		private static readonly FieldCodec<DatingMessageRewardInfo> _repeated_rewardInfo_codec = FieldCodec.ForMessage<DatingMessageRewardInfo>(26U, DatingMessageRewardInfo.Parser);

		// Token: 0x04017F06 RID: 98054
		private readonly RepeatedField<DatingMessageRewardInfo> rewardInfo_ = new RepeatedField<DatingMessageRewardInfo>();
	}
}
