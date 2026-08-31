using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004610 RID: 17936
	public sealed class LifeHelperGachaDBInfo : IMessage<LifeHelperGachaDBInfo>, IMessage, IEquatable<LifeHelperGachaDBInfo>, IDeepCloneable<LifeHelperGachaDBInfo>, IBufferMessage
	{
		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0601C049 RID: 114761 RVA: 0x007DF3E3 File Offset: 0x007DD5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifeHelperGachaDBInfo> Parser
		{
			get
			{
				return LifeHelperGachaDBInfo._parser;
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0601C04A RID: 114762 RVA: 0x007DF3EA File Offset: 0x007DD5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeHelperGachaDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0601C04B RID: 114763 RVA: 0x007DF3FC File Offset: 0x007DD5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeHelperGachaDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C04C RID: 114764 RVA: 0x007DF403 File Offset: 0x007DD603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeHelperGachaDBInfo()
		{
		}

		// Token: 0x0601C04D RID: 114765 RVA: 0x007DF416 File Offset: 0x007DD616
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeHelperGachaDBInfo(LifeHelperGachaDBInfo other)
			: this()
		{
			this.helperSlotId_ = other.helperSlotId_;
			this.gacha_ = other.gacha_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C04E RID: 114766 RVA: 0x007DF44C File Offset: 0x007DD64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeHelperGachaDBInfo Clone()
		{
			return new LifeHelperGachaDBInfo(this);
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0601C04F RID: 114767 RVA: 0x007DF454 File Offset: 0x007DD654
		// (set) Token: 0x0601C050 RID: 114768 RVA: 0x007DF45C File Offset: 0x007DD65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HelperSlotId
		{
			get
			{
				return this.helperSlotId_;
			}
			set
			{
				this.helperSlotId_ = value;
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x0601C051 RID: 114769 RVA: 0x007DF465 File Offset: 0x007DD665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifeHelperDBInfo> Gacha
		{
			get
			{
				return this.gacha_;
			}
		}

		// Token: 0x0601C052 RID: 114770 RVA: 0x007DF46D File Offset: 0x007DD66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeHelperGachaDBInfo);
		}

		// Token: 0x0601C053 RID: 114771 RVA: 0x007DF47C File Offset: 0x007DD67C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(LifeHelperGachaDBInfo other)
		{
			return other != null && (other == this || (this.HelperSlotId == other.HelperSlotId && this.gacha_.Equals(other.gacha_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C054 RID: 114772 RVA: 0x007DF4CC File Offset: 0x007DD6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HelperSlotId != 0)
			{
				num ^= this.HelperSlotId.GetHashCode();
			}
			num ^= this.gacha_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C055 RID: 114773 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C056 RID: 114774 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C057 RID: 114775 RVA: 0x007DF51C File Offset: 0x007DD71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HelperSlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HelperSlotId);
			}
			this.gacha_.WriteTo(ref output, LifeHelperGachaDBInfo._repeated_gacha_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C058 RID: 114776 RVA: 0x007DF56C File Offset: 0x007DD76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HelperSlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HelperSlotId);
			}
			num += this.gacha_.CalculateSize(LifeHelperGachaDBInfo._repeated_gacha_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C059 RID: 114777 RVA: 0x007DF5C0 File Offset: 0x007DD7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeHelperGachaDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HelperSlotId != 0)
			{
				this.HelperSlotId = other.HelperSlotId;
			}
			this.gacha_.Add(other.gacha_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C05A RID: 114778 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C05B RID: 114779 RVA: 0x007DF610 File Offset: 0x007DD810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
						this.gacha_.AddEntriesFrom(ref input, LifeHelperGachaDBInfo._repeated_gacha_codec);
					}
				}
				else
				{
					this.HelperSlotId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<LifeHelperGachaDBInfo> _parser = new MessageParser<LifeHelperGachaDBInfo>(() => new LifeHelperGachaDBInfo());

		// Token: 0x04015876 RID: 88182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015877 RID: 88183
		public const int HelperSlotIdFieldNumber = 1;

		// Token: 0x04015878 RID: 88184
		private int helperSlotId_;

		// Token: 0x04015879 RID: 88185
		public const int GachaFieldNumber = 2;

		// Token: 0x0401587A RID: 88186
		private static readonly FieldCodec<LifeHelperDBInfo> _repeated_gacha_codec = FieldCodec.ForMessage<LifeHelperDBInfo>(18U, LifeHelperDBInfo.Parser);

		// Token: 0x0401587B RID: 88187
		private readonly RepeatedField<LifeHelperDBInfo> gacha_ = new RepeatedField<LifeHelperDBInfo>();
	}
}
