using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004F99 RID: 20377
	public sealed class AvatarInfoResponse : IMessage<AvatarInfoResponse>, IMessage, IEquatable<AvatarInfoResponse>, IDeepCloneable<AvatarInfoResponse>, IBufferMessage
	{
		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x06021776 RID: 137078 RVA: 0x008A1A33 File Offset: 0x0089FC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarInfoResponse> Parser
		{
			get
			{
				return AvatarInfoResponse._parser;
			}
		}

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x06021777 RID: 137079 RVA: 0x008A1A3A File Offset: 0x0089FC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x06021778 RID: 137080 RVA: 0x008A1A4C File Offset: 0x0089FC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarInfoResponse.Descriptor;
			}
		}

		// Token: 0x06021779 RID: 137081 RVA: 0x008A1A53 File Offset: 0x0089FC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarInfoResponse()
		{
		}

		// Token: 0x0602177A RID: 137082 RVA: 0x008A1A68 File Offset: 0x0089FC68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AvatarInfoResponse(AvatarInfoResponse other)
			: this()
		{
			this.avatarUseInfo_ = ((other.avatarUseInfo_ != null) ? other.avatarUseInfo_.Clone() : null);
			this.itemInfo_ = other.itemInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0602177B RID: 137083 RVA: 0x008A1AB9 File Offset: 0x0089FCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarInfoResponse Clone()
		{
			return new AvatarInfoResponse(this);
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x0602177C RID: 137084 RVA: 0x008A1AC1 File Offset: 0x0089FCC1
		// (set) Token: 0x0602177D RID: 137085 RVA: 0x008A1AC9 File Offset: 0x0089FCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarUseDBInfo AvatarUseInfo
		{
			get
			{
				return this.avatarUseInfo_;
			}
			set
			{
				this.avatarUseInfo_ = value;
			}
		}

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x0602177E RID: 137086 RVA: 0x008A1AD2 File Offset: 0x0089FCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemDBInfo> ItemInfo
		{
			get
			{
				return this.itemInfo_;
			}
		}

		// Token: 0x0602177F RID: 137087 RVA: 0x008A1ADA File Offset: 0x0089FCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarInfoResponse);
		}

		// Token: 0x06021780 RID: 137088 RVA: 0x008A1AE8 File Offset: 0x0089FCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.AvatarUseInfo, other.AvatarUseInfo) && this.itemInfo_.Equals(other.itemInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06021781 RID: 137089 RVA: 0x008A1B3C File Offset: 0x0089FD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.avatarUseInfo_ != null)
			{
				num ^= this.AvatarUseInfo.GetHashCode();
			}
			num ^= this.itemInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06021782 RID: 137090 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06021783 RID: 137091 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06021784 RID: 137092 RVA: 0x008A1B88 File Offset: 0x0089FD88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.avatarUseInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AvatarUseInfo);
			}
			this.itemInfo_.WriteTo(ref output, AvatarInfoResponse._repeated_itemInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06021785 RID: 137093 RVA: 0x008A1BD8 File Offset: 0x0089FDD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.avatarUseInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AvatarUseInfo);
			}
			num += this.itemInfo_.CalculateSize(AvatarInfoResponse._repeated_itemInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06021786 RID: 137094 RVA: 0x008A1C2C File Offset: 0x0089FE2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.avatarUseInfo_ != null)
			{
				if (this.avatarUseInfo_ == null)
				{
					this.AvatarUseInfo = new AvatarUseDBInfo();
				}
				this.AvatarUseInfo.MergeFrom(other.AvatarUseInfo);
			}
			this.itemInfo_.Add(other.itemInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06021787 RID: 137095 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06021788 RID: 137096 RVA: 0x008A1C94 File Offset: 0x0089FE94
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemInfo_.AddEntriesFrom(ref input, AvatarInfoResponse._repeated_itemInfo_codec);
					}
				}
				else
				{
					if (this.avatarUseInfo_ == null)
					{
						this.AvatarUseInfo = new AvatarUseDBInfo();
					}
					input.ReadMessage(this.AvatarUseInfo);
				}
			}
		}
		private static readonly MessageParser<AvatarInfoResponse> _parser = new MessageParser<AvatarInfoResponse>(() => new AvatarInfoResponse());

		// Token: 0x04017A47 RID: 96839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017A48 RID: 96840
		public const int AvatarUseInfoFieldNumber = 1;

		// Token: 0x04017A49 RID: 96841
		private AvatarUseDBInfo avatarUseInfo_;

		// Token: 0x04017A4A RID: 96842
		public const int ItemInfoFieldNumber = 2;

		// Token: 0x04017A4B RID: 96843
		private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage<ItemDBInfo>(18U, ItemDBInfo.Parser);

		// Token: 0x04017A4C RID: 96844
		private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();
	}
}
