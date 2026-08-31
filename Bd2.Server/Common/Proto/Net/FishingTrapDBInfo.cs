using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004586 RID: 17798
	public sealed class FishingTrapDBInfo : IMessage<FishingTrapDBInfo>, IMessage, IEquatable<FishingTrapDBInfo>, IDeepCloneable<FishingTrapDBInfo>, IBufferMessage
	{
		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0601BA62 RID: 113250 RVA: 0x007CE44C File Offset: 0x007CC64C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingTrapDBInfo> Parser
		{
			get
			{
				return FishingTrapDBInfo._parser;
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0601BA63 RID: 113251 RVA: 0x007CE453 File Offset: 0x007CC653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingTrapDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0601BA64 RID: 113252 RVA: 0x007CE465 File Offset: 0x007CC665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTrapDBInfo.Descriptor;
			}
		}

		// Token: 0x0601BA65 RID: 113253 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingTrapDBInfo()
		{
		}

		// Token: 0x0601BA66 RID: 113254 RVA: 0x007CE46C File Offset: 0x007CC66C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingTrapDBInfo(FishingTrapDBInfo other)
			: this()
		{
			this.fishId_ = other.fishId_;
			this.size_ = other.size_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA67 RID: 113255 RVA: 0x007CE49D File Offset: 0x007CC69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTrapDBInfo Clone()
		{
			return new FishingTrapDBInfo(this);
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0601BA68 RID: 113256 RVA: 0x007CE4A5 File Offset: 0x007CC6A5
		// (set) Token: 0x0601BA69 RID: 113257 RVA: 0x007CE4AD File Offset: 0x007CC6AD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FishId
		{
			get
			{
				return this.fishId_;
			}
			set
			{
				this.fishId_ = value;
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0601BA6A RID: 113258 RVA: 0x007CE4B6 File Offset: 0x007CC6B6
		// (set) Token: 0x0601BA6B RID: 113259 RVA: 0x007CE4BE File Offset: 0x007CC6BE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Size
		{
			get
			{
				return this.size_;
			}
			set
			{
				this.size_ = value;
			}
		}

		// Token: 0x0601BA6C RID: 113260 RVA: 0x007CE4C7 File Offset: 0x007CC6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTrapDBInfo);
		}

		// Token: 0x0601BA6D RID: 113261 RVA: 0x007CE4D5 File Offset: 0x007CC6D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTrapDBInfo other)
		{
			return other != null && (other == this || (this.FishId == other.FishId && this.Size == other.Size && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA6E RID: 113262 RVA: 0x007CE514 File Offset: 0x007CC714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FishId != 0)
			{
				num ^= this.FishId.GetHashCode();
			}
			if (this.Size != 0)
			{
				num ^= this.Size.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA6F RID: 113263 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BA70 RID: 113264 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA71 RID: 113265 RVA: 0x007CE56C File Offset: 0x007CC76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FishId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FishId);
			}
			if (this.Size != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Size);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA72 RID: 113266 RVA: 0x007CE5C4 File Offset: 0x007CC7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FishId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishId);
			}
			if (this.Size != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Size);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA73 RID: 113267 RVA: 0x007CE61C File Offset: 0x007CC81C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingTrapDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FishId != 0)
			{
				this.FishId = other.FishId;
			}
			if (other.Size != 0)
			{
				this.Size = other.Size;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA74 RID: 113268 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA75 RID: 113269 RVA: 0x007CE66C File Offset: 0x007CC86C
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
						this.Size = input.ReadInt32();
					}
				}
				else
				{
					this.FishId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<FishingTrapDBInfo> _parser = new MessageParser<FishingTrapDBInfo>(() => new FishingTrapDBInfo());

		// Token: 0x040155B5 RID: 87477
		private UnknownFieldSet _unknownFields;

		// Token: 0x040155B6 RID: 87478
		public const int FishIdFieldNumber = 1;

		// Token: 0x040155B7 RID: 87479
		private int fishId_;

		// Token: 0x040155B8 RID: 87480
		public const int SizeFieldNumber = 2;

		// Token: 0x040155B9 RID: 87481
		private int size_;
	}
}
