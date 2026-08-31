using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005232 RID: 21042
	public sealed class FireWorksInfoResponse : IMessage<FireWorksInfoResponse>, IMessage, IEquatable<FireWorksInfoResponse>, IDeepCloneable<FireWorksInfoResponse>, IBufferMessage
	{
		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x06022E8F RID: 142991 RVA: 0x008D9BA4 File Offset: 0x008D7DA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FireWorksInfoResponse> Parser
		{
			get
			{
				return FireWorksInfoResponse._parser;
			}
		}

		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x06022E90 RID: 142992 RVA: 0x008D9BAB File Offset: 0x008D7DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FireWorksInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x06022E91 RID: 142993 RVA: 0x008D9BBD File Offset: 0x008D7DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FireWorksInfoResponse.Descriptor;
			}
		}

		// Token: 0x06022E92 RID: 142994 RVA: 0x008D9BC4 File Offset: 0x008D7DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FireWorksInfoResponse()
		{
		}

		// Token: 0x06022E93 RID: 142995 RVA: 0x008D9BD7 File Offset: 0x008D7DD7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FireWorksInfoResponse(FireWorksInfoResponse other)
			: this()
		{
			this.rewardedGroupId_ = other.rewardedGroupId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06022E94 RID: 142996 RVA: 0x008D9C01 File Offset: 0x008D7E01
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FireWorksInfoResponse Clone()
		{
			return new FireWorksInfoResponse(this);
		}

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x06022E95 RID: 142997 RVA: 0x008D9C09 File Offset: 0x008D7E09
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> RewardedGroupId
		{
			get
			{
				return this.rewardedGroupId_;
			}
		}

		// Token: 0x06022E96 RID: 142998 RVA: 0x008D9C11 File Offset: 0x008D7E11
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FireWorksInfoResponse);
		}

		// Token: 0x06022E97 RID: 142999 RVA: 0x008D9C1F File Offset: 0x008D7E1F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FireWorksInfoResponse other)
		{
			return other != null && (other == this || (this.rewardedGroupId_.Equals(other.rewardedGroupId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06022E98 RID: 143000 RVA: 0x008D9C54 File Offset: 0x008D7E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardedGroupId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06022E99 RID: 143001 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06022E9A RID: 143002 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06022E9B RID: 143003 RVA: 0x008D9C88 File Offset: 0x008D7E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardedGroupId_.WriteTo(ref output, FireWorksInfoResponse._repeated_rewardedGroupId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06022E9C RID: 143004 RVA: 0x008D9CB0 File Offset: 0x008D7EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardedGroupId_.CalculateSize(FireWorksInfoResponse._repeated_rewardedGroupId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06022E9D RID: 143005 RVA: 0x008D9CE9 File Offset: 0x008D7EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FireWorksInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardedGroupId_.Add(other.rewardedGroupId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06022E9E RID: 143006 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06022E9F RID: 143007 RVA: 0x008D9D18 File Offset: 0x008D7F18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardedGroupId_.AddEntriesFrom(ref input, FireWorksInfoResponse._repeated_rewardedGroupId_codec);
				}
			}
		}
		private static readonly MessageParser<FireWorksInfoResponse> _parser = new MessageParser<FireWorksInfoResponse>(() => new FireWorksInfoResponse());

		// Token: 0x04018331 RID: 99121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018332 RID: 99122
		public const int RewardedGroupIdFieldNumber = 1;

		// Token: 0x04018333 RID: 99123
		private static readonly FieldCodec<int> _repeated_rewardedGroupId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04018334 RID: 99124
		private readonly RepeatedField<int> rewardedGroupId_ = new RepeatedField<int>();
	}
}
