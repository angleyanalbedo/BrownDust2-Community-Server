using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004407 RID: 17415
	public sealed class CharVoteCountRewardDBInfo : IMessage<CharVoteCountRewardDBInfo>, IMessage, IEquatable<CharVoteCountRewardDBInfo>, IDeepCloneable<CharVoteCountRewardDBInfo>, IBufferMessage
	{
		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x0601B1C4 RID: 111044 RVA: 0x007B4F78 File Offset: 0x007B3178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharVoteCountRewardDBInfo> Parser
		{
			get
			{
				return CharVoteCountRewardDBInfo._parser;
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x0601B1C5 RID: 111045 RVA: 0x007B4F7F File Offset: 0x007B317F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharVoteCountRewardDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x0601B1C6 RID: 111046 RVA: 0x007B4F91 File Offset: 0x007B3191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharVoteCountRewardDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B1C7 RID: 111047 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharVoteCountRewardDBInfo()
		{
		}

		// Token: 0x0601B1C8 RID: 111048 RVA: 0x007B4F98 File Offset: 0x007B3198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharVoteCountRewardDBInfo(CharVoteCountRewardDBInfo other)
			: this()
		{
			this.eventId_ = other.eventId_;
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B1C9 RID: 111049 RVA: 0x007B4FC9 File Offset: 0x007B31C9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharVoteCountRewardDBInfo Clone()
		{
			return new CharVoteCountRewardDBInfo(this);
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x0601B1CA RID: 111050 RVA: 0x007B4FD1 File Offset: 0x007B31D1
		// (set) Token: 0x0601B1CB RID: 111051 RVA: 0x007B4FD9 File Offset: 0x007B31D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x0601B1CC RID: 111052 RVA: 0x007B4FE2 File Offset: 0x007B31E2
		// (set) Token: 0x0601B1CD RID: 111053 RVA: 0x007B4FEA File Offset: 0x007B31EA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x0601B1CE RID: 111054 RVA: 0x007B4FF3 File Offset: 0x007B31F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharVoteCountRewardDBInfo);
		}

		// Token: 0x0601B1CF RID: 111055 RVA: 0x007B5001 File Offset: 0x007B3201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharVoteCountRewardDBInfo other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1D0 RID: 111056 RVA: 0x007B5040 File Offset: 0x007B3240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B1D1 RID: 111057 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B1D2 RID: 111058 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1D3 RID: 111059 RVA: 0x007B5098 File Offset: 0x007B3298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventId);
			}
			if (this.RewardId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B1D4 RID: 111060 RVA: 0x007B50F0 File Offset: 0x007B32F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B1D5 RID: 111061 RVA: 0x007B5148 File Offset: 0x007B3348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharVoteCountRewardDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B1D6 RID: 111062 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B1D7 RID: 111063 RVA: 0x007B5198 File Offset: 0x007B3398
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RewardId = input.ReadInt32();
					}
				}
				else
				{
					this.EventId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<CharVoteCountRewardDBInfo> _parser = new MessageParser<CharVoteCountRewardDBInfo>(() => new CharVoteCountRewardDBInfo());

		// Token: 0x04014C48 RID: 85064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014C49 RID: 85065
		public const int EventIdFieldNumber = 1;

		// Token: 0x04014C4A RID: 85066
		private int eventId_;

		// Token: 0x04014C4B RID: 85067
		public const int RewardIdFieldNumber = 2;

		// Token: 0x04014C4C RID: 85068
		private int rewardId_;
	}
}
