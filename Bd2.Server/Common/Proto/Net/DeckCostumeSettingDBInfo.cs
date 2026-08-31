using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004443 RID: 17475
	public sealed class DeckCostumeSettingDBInfo : IMessage<DeckCostumeSettingDBInfo>, IMessage, IEquatable<DeckCostumeSettingDBInfo>, IDeepCloneable<DeckCostumeSettingDBInfo>, IBufferMessage
	{
		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x0601B414 RID: 111636 RVA: 0x007BB65C File Offset: 0x007B985C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeckCostumeSettingDBInfo> Parser
		{
			get
			{
				return DeckCostumeSettingDBInfo._parser;
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0601B415 RID: 111637 RVA: 0x007BB663 File Offset: 0x007B9863
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeckCostumeSettingDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x0601B416 RID: 111638 RVA: 0x007BB675 File Offset: 0x007B9875
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeckCostumeSettingDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B417 RID: 111639 RVA: 0x007BB67C File Offset: 0x007B987C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeckCostumeSettingDBInfo()
		{
		}

		// Token: 0x0601B418 RID: 111640 RVA: 0x007BB68F File Offset: 0x007B988F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DeckCostumeSettingDBInfo(DeckCostumeSettingDBInfo other)
			: this()
		{
			this.charInvenIndex_ = other.charInvenIndex_;
			this.costumeSeq_ = other.costumeSeq_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B419 RID: 111641 RVA: 0x007BB6C5 File Offset: 0x007B98C5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DeckCostumeSettingDBInfo Clone()
		{
			return new DeckCostumeSettingDBInfo(this);
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x0601B41A RID: 111642 RVA: 0x007BB6CD File Offset: 0x007B98CD
		// (set) Token: 0x0601B41B RID: 111643 RVA: 0x007BB6D5 File Offset: 0x007B98D5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CharInvenIndex
		{
			get
			{
				return this.charInvenIndex_;
			}
			set
			{
				this.charInvenIndex_ = value;
			}
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x0601B41C RID: 111644 RVA: 0x007BB6DE File Offset: 0x007B98DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DeckCostumeSettingSeqInfo> CostumeSeq
		{
			get
			{
				return this.costumeSeq_;
			}
		}

		// Token: 0x0601B41D RID: 111645 RVA: 0x007BB6E6 File Offset: 0x007B98E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeckCostumeSettingDBInfo);
		}

		// Token: 0x0601B41E RID: 111646 RVA: 0x007BB6F4 File Offset: 0x007B98F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(DeckCostumeSettingDBInfo other)
		{
			return other != null && (other == this || (this.CharInvenIndex == other.CharInvenIndex && this.costumeSeq_.Equals(other.costumeSeq_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B41F RID: 111647 RVA: 0x007BB744 File Offset: 0x007B9944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CharInvenIndex != 0L)
			{
				num ^= this.CharInvenIndex.GetHashCode();
			}
			num ^= this.costumeSeq_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B420 RID: 111648 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B421 RID: 111649 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B422 RID: 111650 RVA: 0x007BB794 File Offset: 0x007B9994
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CharInvenIndex != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CharInvenIndex);
			}
			this.costumeSeq_.WriteTo(ref output, DeckCostumeSettingDBInfo._repeated_costumeSeq_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B423 RID: 111651 RVA: 0x007BB7E4 File Offset: 0x007B99E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CharInvenIndex != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CharInvenIndex);
			}
			num += this.costumeSeq_.CalculateSize(DeckCostumeSettingDBInfo._repeated_costumeSeq_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B424 RID: 111652 RVA: 0x007BB838 File Offset: 0x007B9A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeckCostumeSettingDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CharInvenIndex != 0L)
			{
				this.CharInvenIndex = other.CharInvenIndex;
			}
			this.costumeSeq_.Add(other.costumeSeq_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B425 RID: 111653 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B426 RID: 111654 RVA: 0x007BB888 File Offset: 0x007B9A88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.costumeSeq_.AddEntriesFrom(ref input, DeckCostumeSettingDBInfo._repeated_costumeSeq_codec);
					}
				}
				else
				{
					this.CharInvenIndex = input.ReadInt64();
				}
			}
		}
		private static readonly MessageParser<DeckCostumeSettingDBInfo> _parser = new MessageParser<DeckCostumeSettingDBInfo>(() => new DeckCostumeSettingDBInfo());

		// Token: 0x04014D5D RID: 85341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014D5E RID: 85342
		public const int CharInvenIndexFieldNumber = 1;

		// Token: 0x04014D5F RID: 85343
		private long charInvenIndex_;

		// Token: 0x04014D60 RID: 85344
		public const int CostumeSeqFieldNumber = 2;

		// Token: 0x04014D61 RID: 85345
		private static readonly FieldCodec<DeckCostumeSettingSeqInfo> _repeated_costumeSeq_codec = FieldCodec.ForMessage<DeckCostumeSettingSeqInfo>(18U, DeckCostumeSettingSeqInfo.Parser);

		// Token: 0x04014D62 RID: 85346
		private readonly RepeatedField<DeckCostumeSettingSeqInfo> costumeSeq_ = new RepeatedField<DeckCostumeSettingSeqInfo>();
	}
}
