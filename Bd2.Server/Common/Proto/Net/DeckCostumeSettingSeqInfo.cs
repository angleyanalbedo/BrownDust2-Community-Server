using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004368 RID: 17256
	public sealed class DeckCostumeSettingSeqInfo : IMessage<DeckCostumeSettingSeqInfo>, IMessage, IEquatable<DeckCostumeSettingSeqInfo>, IDeepCloneable<DeckCostumeSettingSeqInfo>, IBufferMessage
	{
		// Token: 0x0601A8E7 RID: 108775 RVA: 0x0079919E File Offset: 0x0079739E
		public bool Equal(long costumeInvenIndex)
		{
			return this.costumeInvenIndex_ == costumeInvenIndex;
		}

		// Token: 0x0601A8E8 RID: 108776 RVA: 0x007991A9 File Offset: 0x007973A9
		public DeckCostumeSettingSeqInfo(long costumeInvenIndex, int burstLevel = 0)
		{
			this.costumeInvenIndex_ = costumeInvenIndex;
			this.burstLevel_ = burstLevel;
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x0601A8E9 RID: 108777 RVA: 0x007991BF File Offset: 0x007973BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeckCostumeSettingSeqInfo> Parser
		{
			get
			{
				return DeckCostumeSettingSeqInfo._parser;
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x0601A8EA RID: 108778 RVA: 0x007991C6 File Offset: 0x007973C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeckCostumeSettingDBInfoReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0601A8EB RID: 108779 RVA: 0x007991D8 File Offset: 0x007973D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeckCostumeSettingSeqInfo.Descriptor;
			}
		}

		// Token: 0x0601A8EC RID: 108780 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeckCostumeSettingSeqInfo()
		{
		}

		// Token: 0x0601A8ED RID: 108781 RVA: 0x007991DF File Offset: 0x007973DF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DeckCostumeSettingSeqInfo(DeckCostumeSettingSeqInfo other)
			: this()
		{
			this.costumeInvenIndex_ = other.costumeInvenIndex_;
			this.burstLevel_ = other.burstLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8EE RID: 108782 RVA: 0x00799210 File Offset: 0x00797410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DeckCostumeSettingSeqInfo Clone()
		{
			return new DeckCostumeSettingSeqInfo(this);
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x0601A8EF RID: 108783 RVA: 0x00799218 File Offset: 0x00797418
		// (set) Token: 0x0601A8F0 RID: 108784 RVA: 0x00799220 File Offset: 0x00797420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CostumeInvenIndex
		{
			get
			{
				return this.costumeInvenIndex_;
			}
			set
			{
				this.costumeInvenIndex_ = value;
			}
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x0601A8F1 RID: 108785 RVA: 0x00799229 File Offset: 0x00797429
		// (set) Token: 0x0601A8F2 RID: 108786 RVA: 0x00799231 File Offset: 0x00797431
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BurstLevel
		{
			get
			{
				return this.burstLevel_;
			}
			set
			{
				this.burstLevel_ = value;
			}
		}

		// Token: 0x0601A8F3 RID: 108787 RVA: 0x0079923A File Offset: 0x0079743A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeckCostumeSettingSeqInfo);
		}

		// Token: 0x0601A8F4 RID: 108788 RVA: 0x00799248 File Offset: 0x00797448
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(DeckCostumeSettingSeqInfo other)
		{
			return other != null && (other == this || (this.CostumeInvenIndex == other.CostumeInvenIndex && this.BurstLevel == other.BurstLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8F5 RID: 108789 RVA: 0x00799288 File Offset: 0x00797488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CostumeInvenIndex != 0L)
			{
				num ^= this.CostumeInvenIndex.GetHashCode();
			}
			if (this.BurstLevel != 0)
			{
				num ^= this.BurstLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8F6 RID: 108790 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601A8F7 RID: 108791 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8F8 RID: 108792 RVA: 0x007992E0 File Offset: 0x007974E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CostumeInvenIndex != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CostumeInvenIndex);
			}
			if (this.BurstLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BurstLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8F9 RID: 108793 RVA: 0x00799338 File Offset: 0x00797538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CostumeInvenIndex != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CostumeInvenIndex);
			}
			if (this.BurstLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BurstLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A8FA RID: 108794 RVA: 0x00799390 File Offset: 0x00797590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(DeckCostumeSettingSeqInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CostumeInvenIndex != 0L)
			{
				this.CostumeInvenIndex = other.CostumeInvenIndex;
			}
			if (other.BurstLevel != 0)
			{
				this.BurstLevel = other.BurstLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8FB RID: 108795 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8FC RID: 108796 RVA: 0x007993E0 File Offset: 0x007975E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
						this.BurstLevel = input.ReadInt32();
					}
				}
				else
				{
					this.CostumeInvenIndex = input.ReadInt64();
				}
			}
		}
		private static readonly MessageParser<DeckCostumeSettingSeqInfo> _parser = new MessageParser<DeckCostumeSettingSeqInfo>(() => new DeckCostumeSettingSeqInfo());

		// Token: 0x04014773 RID: 83827
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014774 RID: 83828
		public const int CostumeInvenIndexFieldNumber = 1;

		// Token: 0x04014775 RID: 83829
		private long costumeInvenIndex_;

		// Token: 0x04014776 RID: 83830
		public const int BurstLevelFieldNumber = 2;

		// Token: 0x04014777 RID: 83831
		private int burstLevel_;
	}
}
