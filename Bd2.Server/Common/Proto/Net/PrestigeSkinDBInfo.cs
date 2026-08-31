using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004710 RID: 18192
	public sealed class PrestigeSkinDBInfo : IMessage<PrestigeSkinDBInfo>, IMessage, IEquatable<PrestigeSkinDBInfo>, IDeepCloneable<PrestigeSkinDBInfo>, IBufferMessage
	{
		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0601CA63 RID: 117347 RVA: 0x007FA65D File Offset: 0x007F885D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrestigeSkinDBInfo> Parser
		{
			get
			{
				return PrestigeSkinDBInfo._parser;
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0601CA64 RID: 117348 RVA: 0x007FA664 File Offset: 0x007F8864
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PrestigeSkinDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0601CA65 RID: 117349 RVA: 0x007FA676 File Offset: 0x007F8876
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrestigeSkinDBInfo.Descriptor;
			}
		}

		// Token: 0x0601CA66 RID: 117350 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrestigeSkinDBInfo()
		{
		}

		// Token: 0x0601CA67 RID: 117351 RVA: 0x007FA67D File Offset: 0x007F887D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrestigeSkinDBInfo(PrestigeSkinDBInfo other)
			: this()
		{
			this.costumeId_ = other.costumeId_;
			this.costumeDesignId_ = other.costumeDesignId_;
			this.isSet_ = other.isSet_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA68 RID: 117352 RVA: 0x007FA6BA File Offset: 0x007F88BA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PrestigeSkinDBInfo Clone()
		{
			return new PrestigeSkinDBInfo(this);
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0601CA69 RID: 117353 RVA: 0x007FA6C2 File Offset: 0x007F88C2
		// (set) Token: 0x0601CA6A RID: 117354 RVA: 0x007FA6CA File Offset: 0x007F88CA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CostumeId
		{
			get
			{
				return this.costumeId_;
			}
			set
			{
				this.costumeId_ = value;
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0601CA6B RID: 117355 RVA: 0x007FA6D3 File Offset: 0x007F88D3
		// (set) Token: 0x0601CA6C RID: 117356 RVA: 0x007FA6DB File Offset: 0x007F88DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostumeDesignId
		{
			get
			{
				return this.costumeDesignId_;
			}
			set
			{
				this.costumeDesignId_ = value;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0601CA6D RID: 117357 RVA: 0x007FA6E4 File Offset: 0x007F88E4
		// (set) Token: 0x0601CA6E RID: 117358 RVA: 0x007FA6EC File Offset: 0x007F88EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSet
		{
			get
			{
				return this.isSet_;
			}
			set
			{
				this.isSet_ = value;
			}
		}

		// Token: 0x0601CA6F RID: 117359 RVA: 0x007FA6F5 File Offset: 0x007F88F5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrestigeSkinDBInfo);
		}

		// Token: 0x0601CA70 RID: 117360 RVA: 0x007FA704 File Offset: 0x007F8904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(PrestigeSkinDBInfo other)
		{
			return other != null && (other == this || (this.CostumeId == other.CostumeId && this.CostumeDesignId == other.CostumeDesignId && this.IsSet == other.IsSet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA71 RID: 117361 RVA: 0x007FA760 File Offset: 0x007F8960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CostumeId != 0)
			{
				num ^= this.CostumeId.GetHashCode();
			}
			if (this.CostumeDesignId != 0)
			{
				num ^= this.CostumeDesignId.GetHashCode();
			}
			if (this.IsSet)
			{
				num ^= this.IsSet.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CA72 RID: 117362 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601CA73 RID: 117363 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA74 RID: 117364 RVA: 0x007FA7D4 File Offset: 0x007F89D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CostumeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CostumeId);
			}
			if (this.CostumeDesignId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CostumeDesignId);
			}
			if (this.IsSet)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsSet);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA75 RID: 117365 RVA: 0x007FA848 File Offset: 0x007F8A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CostumeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostumeId);
			}
			if (this.CostumeDesignId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostumeDesignId);
			}
			if (this.IsSet)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CA76 RID: 117366 RVA: 0x007FA8AC File Offset: 0x007F8AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrestigeSkinDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CostumeId != 0)
			{
				this.CostumeId = other.CostumeId;
			}
			if (other.CostumeDesignId != 0)
			{
				this.CostumeDesignId = other.CostumeDesignId;
			}
			if (other.IsSet)
			{
				this.IsSet = other.IsSet;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CA77 RID: 117367 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA78 RID: 117368 RVA: 0x007FA910 File Offset: 0x007F8B10
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
							this.IsSet = input.ReadBool();
						}
					}
					else
					{
						this.CostumeDesignId = input.ReadInt32();
					}
				}
				else
				{
					this.CostumeId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<PrestigeSkinDBInfo> _parser = new MessageParser<PrestigeSkinDBInfo>(() => new PrestigeSkinDBInfo());

		// Token: 0x04015F1A RID: 89882
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015F1B RID: 89883
		public const int CostumeIdFieldNumber = 1;

		// Token: 0x04015F1C RID: 89884
		private int costumeId_;

		// Token: 0x04015F1D RID: 89885
		public const int CostumeDesignIdFieldNumber = 2;

		// Token: 0x04015F1E RID: 89886
		private int costumeDesignId_;

		// Token: 0x04015F1F RID: 89887
		public const int IsSetFieldNumber = 3;

		// Token: 0x04015F20 RID: 89888
		private bool isSet_;
	}
}
