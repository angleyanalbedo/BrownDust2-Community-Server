using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043AB RID: 17323
	public sealed class AvatarUseDBInfo : IMessage<AvatarUseDBInfo>, IMessage, IEquatable<AvatarUseDBInfo>, IDeepCloneable<AvatarUseDBInfo>, IBufferMessage
	{
		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x0601ACCE RID: 109774 RVA: 0x007A4BAE File Offset: 0x007A2DAE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AvatarUseDBInfo> Parser
		{
			get
			{
				return AvatarUseDBInfo._parser;
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0601ACCF RID: 109775 RVA: 0x007A4BB5 File Offset: 0x007A2DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarUseDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0601ACD0 RID: 109776 RVA: 0x007A4BC7 File Offset: 0x007A2DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarUseDBInfo.Descriptor;
			}
		}

		// Token: 0x0601ACD1 RID: 109777 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarUseDBInfo()
		{
		}

		// Token: 0x0601ACD2 RID: 109778 RVA: 0x007A4BD0 File Offset: 0x007A2DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarUseDBInfo(AvatarUseDBInfo other)
			: this()
		{
			this.useCharId_ = other.useCharId_;
			this.useHairId_ = other.useHairId_;
			this.useHairAccessoryId_ = other.useHairAccessoryId_;
			this.useFaceAccessoryId_ = other.useFaceAccessoryId_;
			this.useCostumeId_ = other.useCostumeId_;
			this.useBodyAccessoryId_ = other.useBodyAccessoryId_;
			this.useHandAccessoryId_ = other.useHandAccessoryId_;
			this.usePetId_ = other.usePetId_;
			this.useMountId_ = other.useMountId_;
			this.useEffectId_ = other.useEffectId_;
			this.date_ = other.date_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACD3 RID: 109779 RVA: 0x007A4C78 File Offset: 0x007A2E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarUseDBInfo Clone()
		{
			return new AvatarUseDBInfo(this);
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0601ACD4 RID: 109780 RVA: 0x007A4C80 File Offset: 0x007A2E80
		// (set) Token: 0x0601ACD5 RID: 109781 RVA: 0x007A4C88 File Offset: 0x007A2E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseCharId
		{
			get
			{
				return this.useCharId_;
			}
			set
			{
				this.useCharId_ = value;
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0601ACD6 RID: 109782 RVA: 0x007A4C91 File Offset: 0x007A2E91
		// (set) Token: 0x0601ACD7 RID: 109783 RVA: 0x007A4C99 File Offset: 0x007A2E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseHairId
		{
			get
			{
				return this.useHairId_;
			}
			set
			{
				this.useHairId_ = value;
			}
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x0601ACD8 RID: 109784 RVA: 0x007A4CA2 File Offset: 0x007A2EA2
		// (set) Token: 0x0601ACD9 RID: 109785 RVA: 0x007A4CAA File Offset: 0x007A2EAA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int UseHairAccessoryId
		{
			get
			{
				return this.useHairAccessoryId_;
			}
			set
			{
				this.useHairAccessoryId_ = value;
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x0601ACDA RID: 109786 RVA: 0x007A4CB3 File Offset: 0x007A2EB3
		// (set) Token: 0x0601ACDB RID: 109787 RVA: 0x007A4CBB File Offset: 0x007A2EBB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int UseFaceAccessoryId
		{
			get
			{
				return this.useFaceAccessoryId_;
			}
			set
			{
				this.useFaceAccessoryId_ = value;
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x0601ACDC RID: 109788 RVA: 0x007A4CC4 File Offset: 0x007A2EC4
		// (set) Token: 0x0601ACDD RID: 109789 RVA: 0x007A4CCC File Offset: 0x007A2ECC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int UseCostumeId
		{
			get
			{
				return this.useCostumeId_;
			}
			set
			{
				this.useCostumeId_ = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x0601ACDE RID: 109790 RVA: 0x007A4CD5 File Offset: 0x007A2ED5
		// (set) Token: 0x0601ACDF RID: 109791 RVA: 0x007A4CDD File Offset: 0x007A2EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseBodyAccessoryId
		{
			get
			{
				return this.useBodyAccessoryId_;
			}
			set
			{
				this.useBodyAccessoryId_ = value;
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0601ACE0 RID: 109792 RVA: 0x007A4CE6 File Offset: 0x007A2EE6
		// (set) Token: 0x0601ACE1 RID: 109793 RVA: 0x007A4CEE File Offset: 0x007A2EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseHandAccessoryId
		{
			get
			{
				return this.useHandAccessoryId_;
			}
			set
			{
				this.useHandAccessoryId_ = value;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0601ACE2 RID: 109794 RVA: 0x007A4CF7 File Offset: 0x007A2EF7
		// (set) Token: 0x0601ACE3 RID: 109795 RVA: 0x007A4CFF File Offset: 0x007A2EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UsePetId
		{
			get
			{
				return this.usePetId_;
			}
			set
			{
				this.usePetId_ = value;
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0601ACE4 RID: 109796 RVA: 0x007A4D08 File Offset: 0x007A2F08
		// (set) Token: 0x0601ACE5 RID: 109797 RVA: 0x007A4D10 File Offset: 0x007A2F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseMountId
		{
			get
			{
				return this.useMountId_;
			}
			set
			{
				this.useMountId_ = value;
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0601ACE6 RID: 109798 RVA: 0x007A4D19 File Offset: 0x007A2F19
		// (set) Token: 0x0601ACE7 RID: 109799 RVA: 0x007A4D21 File Offset: 0x007A2F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseEffectId
		{
			get
			{
				return this.useEffectId_;
			}
			set
			{
				this.useEffectId_ = value;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0601ACE8 RID: 109800 RVA: 0x007A4D2A File Offset: 0x007A2F2A
		// (set) Token: 0x0601ACE9 RID: 109801 RVA: 0x007A4D32 File Offset: 0x007A2F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Date
		{
			get
			{
				return this.date_;
			}
			set
			{
				this.date_ = value;
			}
		}

		// Token: 0x0601ACEA RID: 109802 RVA: 0x007A4D3B File Offset: 0x007A2F3B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarUseDBInfo);
		}

		// Token: 0x0601ACEB RID: 109803 RVA: 0x007A4D4C File Offset: 0x007A2F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarUseDBInfo other)
		{
			return other != null && (other == this || (this.UseCharId == other.UseCharId && this.UseHairId == other.UseHairId && this.UseHairAccessoryId == other.UseHairAccessoryId && this.UseFaceAccessoryId == other.UseFaceAccessoryId && this.UseCostumeId == other.UseCostumeId && this.UseBodyAccessoryId == other.UseBodyAccessoryId && this.UseHandAccessoryId == other.UseHandAccessoryId && this.UsePetId == other.UsePetId && this.UseMountId == other.UseMountId && this.UseEffectId == other.UseEffectId && this.Date == other.Date && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACEC RID: 109804 RVA: 0x007A4E28 File Offset: 0x007A3028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UseCharId != 0)
			{
				num ^= this.UseCharId.GetHashCode();
			}
			if (this.UseHairId != 0)
			{
				num ^= this.UseHairId.GetHashCode();
			}
			if (this.UseHairAccessoryId != 0)
			{
				num ^= this.UseHairAccessoryId.GetHashCode();
			}
			if (this.UseFaceAccessoryId != 0)
			{
				num ^= this.UseFaceAccessoryId.GetHashCode();
			}
			if (this.UseCostumeId != 0)
			{
				num ^= this.UseCostumeId.GetHashCode();
			}
			if (this.UseBodyAccessoryId != 0)
			{
				num ^= this.UseBodyAccessoryId.GetHashCode();
			}
			if (this.UseHandAccessoryId != 0)
			{
				num ^= this.UseHandAccessoryId.GetHashCode();
			}
			if (this.UsePetId != 0)
			{
				num ^= this.UsePetId.GetHashCode();
			}
			if (this.UseMountId != 0)
			{
				num ^= this.UseMountId.GetHashCode();
			}
			if (this.UseEffectId != 0)
			{
				num ^= this.UseEffectId.GetHashCode();
			}
			if (this.Date != 0L)
			{
				num ^= this.Date.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ACED RID: 109805 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601ACEE RID: 109806 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACEF RID: 109807 RVA: 0x007A4F64 File Offset: 0x007A3164
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseCharId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UseCharId);
			}
			if (this.UseHairId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UseHairId);
			}
			if (this.UseHairAccessoryId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.UseHairAccessoryId);
			}
			if (this.UseFaceAccessoryId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UseFaceAccessoryId);
			}
			if (this.UseCostumeId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.UseCostumeId);
			}
			if (this.UseBodyAccessoryId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UseBodyAccessoryId);
			}
			if (this.UseHandAccessoryId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.UseHandAccessoryId);
			}
			if (this.UsePetId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.UsePetId);
			}
			if (this.UseMountId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.UseMountId);
			}
			if (this.UseEffectId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.UseEffectId);
			}
			if (this.Date != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.Date);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACF0 RID: 109808 RVA: 0x007A50B8 File Offset: 0x007A32B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UseCharId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseCharId);
			}
			if (this.UseHairId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseHairId);
			}
			if (this.UseHairAccessoryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseHairAccessoryId);
			}
			if (this.UseFaceAccessoryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseFaceAccessoryId);
			}
			if (this.UseCostumeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseCostumeId);
			}
			if (this.UseBodyAccessoryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseBodyAccessoryId);
			}
			if (this.UseHandAccessoryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseHandAccessoryId);
			}
			if (this.UsePetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UsePetId);
			}
			if (this.UseMountId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseMountId);
			}
			if (this.UseEffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseEffectId);
			}
			if (this.Date != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Date);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ACF1 RID: 109809 RVA: 0x007A51E8 File Offset: 0x007A33E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarUseDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UseCharId != 0)
			{
				this.UseCharId = other.UseCharId;
			}
			if (other.UseHairId != 0)
			{
				this.UseHairId = other.UseHairId;
			}
			if (other.UseHairAccessoryId != 0)
			{
				this.UseHairAccessoryId = other.UseHairAccessoryId;
			}
			if (other.UseFaceAccessoryId != 0)
			{
				this.UseFaceAccessoryId = other.UseFaceAccessoryId;
			}
			if (other.UseCostumeId != 0)
			{
				this.UseCostumeId = other.UseCostumeId;
			}
			if (other.UseBodyAccessoryId != 0)
			{
				this.UseBodyAccessoryId = other.UseBodyAccessoryId;
			}
			if (other.UseHandAccessoryId != 0)
			{
				this.UseHandAccessoryId = other.UseHandAccessoryId;
			}
			if (other.UsePetId != 0)
			{
				this.UsePetId = other.UsePetId;
			}
			if (other.UseMountId != 0)
			{
				this.UseMountId = other.UseMountId;
			}
			if (other.UseEffectId != 0)
			{
				this.UseEffectId = other.UseEffectId;
			}
			if (other.Date != 0L)
			{
				this.Date = other.Date;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ACF2 RID: 109810 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACF3 RID: 109811 RVA: 0x007A52EC File Offset: 0x007A34EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
							this.UseCharId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.UseHairId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.UseHairAccessoryId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.UseFaceAccessoryId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.UseCostumeId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.UseBodyAccessoryId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.UseHandAccessoryId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.UsePetId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.UseMountId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.UseEffectId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Date = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<AvatarUseDBInfo> _parser = new MessageParser<AvatarUseDBInfo>(() => new AvatarUseDBInfo());

		// Token: 0x04014986 RID: 84358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014987 RID: 84359
		public const int UseCharIdFieldNumber = 1;

		// Token: 0x04014988 RID: 84360
		private int useCharId_;

		// Token: 0x04014989 RID: 84361
		public const int UseHairIdFieldNumber = 2;

		// Token: 0x0401498A RID: 84362
		private int useHairId_;

		// Token: 0x0401498B RID: 84363
		public const int UseHairAccessoryIdFieldNumber = 3;

		// Token: 0x0401498C RID: 84364
		private int useHairAccessoryId_;

		// Token: 0x0401498D RID: 84365
		public const int UseFaceAccessoryIdFieldNumber = 4;

		// Token: 0x0401498E RID: 84366
		private int useFaceAccessoryId_;

		// Token: 0x0401498F RID: 84367
		public const int UseCostumeIdFieldNumber = 5;

		// Token: 0x04014990 RID: 84368
		private int useCostumeId_;

		// Token: 0x04014991 RID: 84369
		public const int UseBodyAccessoryIdFieldNumber = 6;

		// Token: 0x04014992 RID: 84370
		private int useBodyAccessoryId_;

		// Token: 0x04014993 RID: 84371
		public const int UseHandAccessoryIdFieldNumber = 7;

		// Token: 0x04014994 RID: 84372
		private int useHandAccessoryId_;

		// Token: 0x04014995 RID: 84373
		public const int UsePetIdFieldNumber = 8;

		// Token: 0x04014996 RID: 84374
		private int usePetId_;

		// Token: 0x04014997 RID: 84375
		public const int UseMountIdFieldNumber = 9;

		// Token: 0x04014998 RID: 84376
		private int useMountId_;

		// Token: 0x04014999 RID: 84377
		public const int UseEffectIdFieldNumber = 10;

		// Token: 0x0401499A RID: 84378
		private int useEffectId_;

		// Token: 0x0401499B RID: 84379
		public const int DateFieldNumber = 11;

		// Token: 0x0401499C RID: 84380
		private long date_;
	}
}
