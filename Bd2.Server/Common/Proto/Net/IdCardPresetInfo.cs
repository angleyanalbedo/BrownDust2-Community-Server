using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020045EE RID: 17902
	public sealed class IdCardPresetInfo : IMessage<IdCardPresetInfo>, IMessage, IEquatable<IdCardPresetInfo>, IDeepCloneable<IdCardPresetInfo>, IBufferMessage
	{
		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0601BEF3 RID: 114419 RVA: 0x007DBB41 File Offset: 0x007D9D41
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<IdCardPresetInfo> Parser
		{
			get
			{
				return IdCardPresetInfo._parser;
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x0601BEF4 RID: 114420 RVA: 0x007DBB48 File Offset: 0x007D9D48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IdCardPresetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0601BEF5 RID: 114421 RVA: 0x007DBB5A File Offset: 0x007D9D5A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IdCardPresetInfo.Descriptor;
			}
		}

		// Token: 0x0601BEF6 RID: 114422 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardPresetInfo()
		{
		}

		// Token: 0x0601BEF7 RID: 114423 RVA: 0x007DBB64 File Offset: 0x007D9D64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardPresetInfo(IdCardPresetInfo other)
			: this()
		{
			this.id_ = other.id_;
			this.idCardInfo_ = ((other.idCardInfo_ != null) ? other.idCardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEF8 RID: 114424 RVA: 0x007DBBB0 File Offset: 0x007D9DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IdCardPresetInfo Clone()
		{
			return new IdCardPresetInfo(this);
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0601BEF9 RID: 114425 RVA: 0x007DBBB8 File Offset: 0x007D9DB8
		// (set) Token: 0x0601BEFA RID: 114426 RVA: 0x007DBBC0 File Offset: 0x007D9DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x0601BEFB RID: 114427 RVA: 0x007DBBC9 File Offset: 0x007D9DC9
		// (set) Token: 0x0601BEFC RID: 114428 RVA: 0x007DBBD1 File Offset: 0x007D9DD1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardInfo IdCardInfo
		{
			get
			{
				return this.idCardInfo_;
			}
			set
			{
				this.idCardInfo_ = value;
			}
		}

		// Token: 0x0601BEFD RID: 114429 RVA: 0x007DBBDA File Offset: 0x007D9DDA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IdCardPresetInfo);
		}

		// Token: 0x0601BEFE RID: 114430 RVA: 0x007DBBE8 File Offset: 0x007D9DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(IdCardPresetInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this.IdCardInfo, other.IdCardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEFF RID: 114431 RVA: 0x007DBC38 File Offset: 0x007D9E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.idCardInfo_ != null)
			{
				num ^= this.IdCardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF00 RID: 114432 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BF01 RID: 114433 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF02 RID: 114434 RVA: 0x007DBC90 File Offset: 0x007D9E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.idCardInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.IdCardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF03 RID: 114435 RVA: 0x007DBCE8 File Offset: 0x007D9EE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.idCardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IdCardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF04 RID: 114436 RVA: 0x007DBD40 File Offset: 0x007D9F40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(IdCardPresetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.idCardInfo_ != null)
			{
				if (this.idCardInfo_ == null)
				{
					this.IdCardInfo = new IdCardInfo();
				}
				this.IdCardInfo.MergeFrom(other.IdCardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF05 RID: 114437 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF06 RID: 114438 RVA: 0x007DBDA8 File Offset: 0x007D9FA8
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
						if (this.idCardInfo_ == null)
						{
							this.IdCardInfo = new IdCardInfo();
						}
						input.ReadMessage(this.IdCardInfo);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<IdCardPresetInfo> _parser = new MessageParser<IdCardPresetInfo>(() => new IdCardPresetInfo());

		// Token: 0x040157E7 RID: 88039
		private UnknownFieldSet _unknownFields;

		// Token: 0x040157E8 RID: 88040
		public const int IdFieldNumber = 1;

		// Token: 0x040157E9 RID: 88041
		private int id_;

		// Token: 0x040157EA RID: 88042
		public const int IdCardInfoFieldNumber = 2;

		// Token: 0x040157EB RID: 88043
		private IdCardInfo idCardInfo_;
	}
}
