using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004604 RID: 17924
	public sealed class LifeCitizenDBInfo : IMessage<LifeCitizenDBInfo>, IMessage, IEquatable<LifeCitizenDBInfo>, IDeepCloneable<LifeCitizenDBInfo>, IBufferMessage
	{
		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x0601BFD1 RID: 114641 RVA: 0x007DE0AF File Offset: 0x007DC2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifeCitizenDBInfo> Parser
		{
			get
			{
				return LifeCitizenDBInfo._parser;
			}
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0601BFD2 RID: 114642 RVA: 0x007DE0B6 File Offset: 0x007DC2B6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeCitizenDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0601BFD3 RID: 114643 RVA: 0x007DE0C8 File Offset: 0x007DC2C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeCitizenDBInfo.Descriptor;
			}
		}

		// Token: 0x0601BFD4 RID: 114644 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeCitizenDBInfo()
		{
		}

		// Token: 0x0601BFD5 RID: 114645 RVA: 0x007DE0D0 File Offset: 0x007DC2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeCitizenDBInfo(LifeCitizenDBInfo other)
			: this()
		{
			this.citizenIndex_ = other.citizenIndex_;
			this.citizenSlotId_ = other.citizenSlotId_;
			this.avatarInfo_ = ((other.avatarInfo_ != null) ? other.avatarInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFD6 RID: 114646 RVA: 0x007DE128 File Offset: 0x007DC328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeCitizenDBInfo Clone()
		{
			return new LifeCitizenDBInfo(this);
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0601BFD7 RID: 114647 RVA: 0x007DE130 File Offset: 0x007DC330
		// (set) Token: 0x0601BFD8 RID: 114648 RVA: 0x007DE138 File Offset: 0x007DC338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CitizenIndex
		{
			get
			{
				return this.citizenIndex_;
			}
			set
			{
				this.citizenIndex_ = value;
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x0601BFD9 RID: 114649 RVA: 0x007DE141 File Offset: 0x007DC341
		// (set) Token: 0x0601BFDA RID: 114650 RVA: 0x007DE149 File Offset: 0x007DC349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CitizenSlotId
		{
			get
			{
				return this.citizenSlotId_;
			}
			set
			{
				this.citizenSlotId_ = value;
			}
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x0601BFDB RID: 114651 RVA: 0x007DE152 File Offset: 0x007DC352
		// (set) Token: 0x0601BFDC RID: 114652 RVA: 0x007DE15A File Offset: 0x007DC35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarUseDBInfo AvatarInfo
		{
			get
			{
				return this.avatarInfo_;
			}
			set
			{
				this.avatarInfo_ = value;
			}
		}

		// Token: 0x0601BFDD RID: 114653 RVA: 0x007DE163 File Offset: 0x007DC363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeCitizenDBInfo);
		}

		// Token: 0x0601BFDE RID: 114654 RVA: 0x007DE174 File Offset: 0x007DC374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifeCitizenDBInfo other)
		{
			return other != null && (other == this || (this.CitizenIndex == other.CitizenIndex && this.CitizenSlotId == other.CitizenSlotId && object.Equals(this.AvatarInfo, other.AvatarInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFDF RID: 114655 RVA: 0x007DE1D4 File Offset: 0x007DC3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CitizenIndex != 0)
			{
				num ^= this.CitizenIndex.GetHashCode();
			}
			if (this.CitizenSlotId != 0)
			{
				num ^= this.CitizenSlotId.GetHashCode();
			}
			if (this.avatarInfo_ != null)
			{
				num ^= this.AvatarInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BFE0 RID: 114656 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BFE1 RID: 114657 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFE2 RID: 114658 RVA: 0x007DE244 File Offset: 0x007DC444
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CitizenIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CitizenIndex);
			}
			if (this.CitizenSlotId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CitizenSlotId);
			}
			if (this.avatarInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AvatarInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BFE3 RID: 114659 RVA: 0x007DE2B8 File Offset: 0x007DC4B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CitizenIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CitizenIndex);
			}
			if (this.CitizenSlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CitizenSlotId);
			}
			if (this.avatarInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AvatarInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BFE4 RID: 114660 RVA: 0x007DE328 File Offset: 0x007DC528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeCitizenDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CitizenIndex != 0)
			{
				this.CitizenIndex = other.CitizenIndex;
			}
			if (other.CitizenSlotId != 0)
			{
				this.CitizenSlotId = other.CitizenSlotId;
			}
			if (other.avatarInfo_ != null)
			{
				if (this.avatarInfo_ == null)
				{
					this.AvatarInfo = new AvatarUseDBInfo();
				}
				this.AvatarInfo.MergeFrom(other.AvatarInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BFE5 RID: 114661 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFE6 RID: 114662 RVA: 0x007DE3A4 File Offset: 0x007DC5A4
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.avatarInfo_ == null)
							{
								this.AvatarInfo = new AvatarUseDBInfo();
							}
							input.ReadMessage(this.AvatarInfo);
						}
					}
					else
					{
						this.CitizenSlotId = input.ReadInt32();
					}
				}
				else
				{
					this.CitizenIndex = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<LifeCitizenDBInfo> _parser = new MessageParser<LifeCitizenDBInfo>(() => new LifeCitizenDBInfo());

		// Token: 0x04015846 RID: 88134
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015847 RID: 88135
		public const int CitizenIndexFieldNumber = 1;

		// Token: 0x04015848 RID: 88136
		private int citizenIndex_;

		// Token: 0x04015849 RID: 88137
		public const int CitizenSlotIdFieldNumber = 2;

		// Token: 0x0401584A RID: 88138
		private int citizenSlotId_;

		// Token: 0x0401584B RID: 88139
		public const int AvatarInfoFieldNumber = 3;

		// Token: 0x0401584C RID: 88140
		private AvatarUseDBInfo avatarInfo_;
	}
}
