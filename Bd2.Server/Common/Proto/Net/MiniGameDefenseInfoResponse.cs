using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200547E RID: 21630
	public sealed class MiniGameDefenseInfoResponse : IMessage<MiniGameDefenseInfoResponse>, IMessage, IEquatable<MiniGameDefenseInfoResponse>, IDeepCloneable<MiniGameDefenseInfoResponse>, IBufferMessage
	{
		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x060241DE RID: 147934 RVA: 0x00901C09 File Offset: 0x008FFE09
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MiniGameDefenseInfoResponse> Parser
		{
			get
			{
				return MiniGameDefenseInfoResponse._parser;
			}
		}

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x060241DF RID: 147935 RVA: 0x00901C10 File Offset: 0x008FFE10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniGameDefenseInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17005021 RID: 20513
		// (get) Token: 0x060241E0 RID: 147936 RVA: 0x00901C22 File Offset: 0x008FFE22
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniGameDefenseInfoResponse.Descriptor;
			}
		}

		// Token: 0x060241E1 RID: 147937 RVA: 0x00901C29 File Offset: 0x008FFE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameDefenseInfoResponse()
		{
		}

		// Token: 0x060241E2 RID: 147938 RVA: 0x00901C3C File Offset: 0x008FFE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameDefenseInfoResponse(MiniGameDefenseInfoResponse other)
			: this()
		{
			this.eventScheduleId_ = other.eventScheduleId_;
			this.rewardInfo_ = other.rewardInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060241E3 RID: 147939 RVA: 0x00901C72 File Offset: 0x008FFE72
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniGameDefenseInfoResponse Clone()
		{
			return new MiniGameDefenseInfoResponse(this);
		}

		// Token: 0x17005022 RID: 20514
		// (get) Token: 0x060241E4 RID: 147940 RVA: 0x00901C7A File Offset: 0x008FFE7A
		// (set) Token: 0x060241E5 RID: 147941 RVA: 0x00901C82 File Offset: 0x008FFE82
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int EventScheduleId
		{
			get
			{
				return this.eventScheduleId_;
			}
			set
			{
				this.eventScheduleId_ = value;
			}
		}

		// Token: 0x17005023 RID: 20515
		// (get) Token: 0x060241E6 RID: 147942 RVA: 0x00901C8B File Offset: 0x008FFE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardInfo
		{
			get
			{
				return this.rewardInfo_;
			}
		}

		// Token: 0x060241E7 RID: 147943 RVA: 0x00901C93 File Offset: 0x008FFE93
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniGameDefenseInfoResponse);
		}

		// Token: 0x060241E8 RID: 147944 RVA: 0x00901CA4 File Offset: 0x008FFEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniGameDefenseInfoResponse other)
		{
			return other != null && (other == this || (this.EventScheduleId == other.EventScheduleId && this.rewardInfo_.Equals(other.rewardInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060241E9 RID: 147945 RVA: 0x00901CF4 File Offset: 0x008FFEF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventScheduleId != 0)
			{
				num ^= this.EventScheduleId.GetHashCode();
			}
			num ^= this.rewardInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060241EA RID: 147946 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060241EB RID: 147947 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060241EC RID: 147948 RVA: 0x00901D44 File Offset: 0x008FFF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventScheduleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventScheduleId);
			}
			this.rewardInfo_.WriteTo(ref output, MiniGameDefenseInfoResponse._repeated_rewardInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060241ED RID: 147949 RVA: 0x00901D94 File Offset: 0x008FFF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventScheduleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventScheduleId);
			}
			num += this.rewardInfo_.CalculateSize(MiniGameDefenseInfoResponse._repeated_rewardInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060241EE RID: 147950 RVA: 0x00901DE8 File Offset: 0x008FFFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniGameDefenseInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventScheduleId != 0)
			{
				this.EventScheduleId = other.EventScheduleId;
			}
			this.rewardInfo_.Add(other.rewardInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060241EF RID: 147951 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060241F0 RID: 147952 RVA: 0x00901E38 File Offset: 0x00900038
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardInfo_.AddEntriesFrom(ref input, MiniGameDefenseInfoResponse._repeated_rewardInfo_codec);
					}
				}
				else
				{
					this.EventScheduleId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<MiniGameDefenseInfoResponse> _parser = new MessageParser<MiniGameDefenseInfoResponse>(() => new MiniGameDefenseInfoResponse());

		// Token: 0x0401898C RID: 100748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401898D RID: 100749
		public const int EventScheduleIdFieldNumber = 1;

		// Token: 0x0401898E RID: 100750
		private int eventScheduleId_;

		// Token: 0x0401898F RID: 100751
		public const int RewardInfoFieldNumber = 2;

		// Token: 0x04018990 RID: 100752
		private static readonly FieldCodec<int> _repeated_rewardInfo_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04018991 RID: 100753
		private readonly RepeatedField<int> rewardInfo_ = new RepeatedField<int>();
	}
}
