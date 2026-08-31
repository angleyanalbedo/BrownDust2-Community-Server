using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200457D RID: 17789
	public sealed class FishingRodDBInfo : IMessage<FishingRodDBInfo>, IMessage, IEquatable<FishingRodDBInfo>, IDeepCloneable<FishingRodDBInfo>, IBufferMessage
	{
		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0601BA0C RID: 113164 RVA: 0x007CD80C File Offset: 0x007CBA0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingRodDBInfo> Parser
		{
			get
			{
				return FishingRodDBInfo._parser;
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0601BA0D RID: 113165 RVA: 0x007CD813 File Offset: 0x007CBA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingRodDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0601BA0E RID: 113166 RVA: 0x007CD825 File Offset: 0x007CBA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingRodDBInfo.Descriptor;
			}
		}

		// Token: 0x0601BA0F RID: 113167 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingRodDBInfo()
		{
		}

		// Token: 0x0601BA10 RID: 113168 RVA: 0x007CD82C File Offset: 0x007CBA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingRodDBInfo(FishingRodDBInfo other)
			: this()
		{
			this.invenIndex_ = other.invenIndex_;
			this.id_ = other.id_;
			this.timeValue_ = other.timeValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA11 RID: 113169 RVA: 0x007CD869 File Offset: 0x007CBA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingRodDBInfo Clone()
		{
			return new FishingRodDBInfo(this);
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0601BA12 RID: 113170 RVA: 0x007CD871 File Offset: 0x007CBA71
		// (set) Token: 0x0601BA13 RID: 113171 RVA: 0x007CD879 File Offset: 0x007CBA79
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long InvenIndex
		{
			get
			{
				return this.invenIndex_;
			}
			set
			{
				this.invenIndex_ = value;
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0601BA14 RID: 113172 RVA: 0x007CD882 File Offset: 0x007CBA82
		// (set) Token: 0x0601BA15 RID: 113173 RVA: 0x007CD88A File Offset: 0x007CBA8A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0601BA16 RID: 113174 RVA: 0x007CD893 File Offset: 0x007CBA93
		// (set) Token: 0x0601BA17 RID: 113175 RVA: 0x007CD89B File Offset: 0x007CBA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TimeValue
		{
			get
			{
				return this.timeValue_;
			}
			set
			{
				this.timeValue_ = value;
			}
		}

		// Token: 0x0601BA18 RID: 113176 RVA: 0x007CD8A4 File Offset: 0x007CBAA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingRodDBInfo);
		}

		// Token: 0x0601BA19 RID: 113177 RVA: 0x007CD8B4 File Offset: 0x007CBAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingRodDBInfo other)
		{
			return other != null && (other == this || (this.InvenIndex == other.InvenIndex && this.Id == other.Id && this.TimeValue == other.TimeValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA1A RID: 113178 RVA: 0x007CD910 File Offset: 0x007CBB10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InvenIndex != 0L)
			{
				num ^= this.InvenIndex.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.TimeValue != 0L)
			{
				num ^= this.TimeValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA1B RID: 113179 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BA1C RID: 113180 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA1D RID: 113181 RVA: 0x007CD984 File Offset: 0x007CBB84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InvenIndex != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.InvenIndex);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.TimeValue != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TimeValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA1E RID: 113182 RVA: 0x007CD9F8 File Offset: 0x007CBBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InvenIndex != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InvenIndex);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.TimeValue != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TimeValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA1F RID: 113183 RVA: 0x007CDA68 File Offset: 0x007CBC68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingRodDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InvenIndex != 0L)
			{
				this.InvenIndex = other.InvenIndex;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.TimeValue != 0L)
			{
				this.TimeValue = other.TimeValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA20 RID: 113184 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA21 RID: 113185 RVA: 0x007CDACC File Offset: 0x007CBCCC
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TimeValue = input.ReadInt64();
						}
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.InvenIndex = input.ReadInt64();
				}
			}
		}
		private static readonly MessageParser<FishingRodDBInfo> _parser = new MessageParser<FishingRodDBInfo>(() => new FishingRodDBInfo());

		// Token: 0x04015595 RID: 87445
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015596 RID: 87446
		public const int InvenIndexFieldNumber = 1;

		// Token: 0x04015597 RID: 87447
		private long invenIndex_;

		// Token: 0x04015598 RID: 87448
		public const int IdFieldNumber = 2;

		// Token: 0x04015599 RID: 87449
		private int id_;

		// Token: 0x0401559A RID: 87450
		public const int TimeValueFieldNumber = 3;

		// Token: 0x0401559B RID: 87451
		private long timeValue_;
	}
}
