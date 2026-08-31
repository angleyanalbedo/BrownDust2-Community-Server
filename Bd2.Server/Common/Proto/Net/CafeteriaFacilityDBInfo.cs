using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043EE RID: 17390
	public sealed class CafeteriaFacilityDBInfo : IMessage<CafeteriaFacilityDBInfo>, IMessage, IEquatable<CafeteriaFacilityDBInfo>, IDeepCloneable<CafeteriaFacilityDBInfo>, IBufferMessage
	{
		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x0601B0D5 RID: 110805 RVA: 0x007B2A78 File Offset: 0x007B0C78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CafeteriaFacilityDBInfo> Parser
		{
			get
			{
				return CafeteriaFacilityDBInfo._parser;
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0601B0D6 RID: 110806 RVA: 0x007B2A7F File Offset: 0x007B0C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CafeteriaFacilityDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0601B0D7 RID: 110807 RVA: 0x007B2A91 File Offset: 0x007B0C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CafeteriaFacilityDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B0D8 RID: 110808 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaFacilityDBInfo()
		{
		}

		// Token: 0x0601B0D9 RID: 110809 RVA: 0x007B2A98 File Offset: 0x007B0C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaFacilityDBInfo(CafeteriaFacilityDBInfo other)
			: this()
		{
			this.facilityId_ = other.facilityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0DA RID: 110810 RVA: 0x007B2ABD File Offset: 0x007B0CBD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CafeteriaFacilityDBInfo Clone()
		{
			return new CafeteriaFacilityDBInfo(this);
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0601B0DB RID: 110811 RVA: 0x007B2AC5 File Offset: 0x007B0CC5
		// (set) Token: 0x0601B0DC RID: 110812 RVA: 0x007B2ACD File Offset: 0x007B0CCD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FacilityId
		{
			get
			{
				return this.facilityId_;
			}
			set
			{
				this.facilityId_ = value;
			}
		}

		// Token: 0x0601B0DD RID: 110813 RVA: 0x007B2AD6 File Offset: 0x007B0CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CafeteriaFacilityDBInfo);
		}

		// Token: 0x0601B0DE RID: 110814 RVA: 0x007B2AE4 File Offset: 0x007B0CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CafeteriaFacilityDBInfo other)
		{
			return other != null && (other == this || (this.FacilityId == other.FacilityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0DF RID: 110815 RVA: 0x007B2B14 File Offset: 0x007B0D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FacilityId != 0)
			{
				num ^= this.FacilityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B0E0 RID: 110816 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B0E1 RID: 110817 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0E2 RID: 110818 RVA: 0x007B2B53 File Offset: 0x007B0D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FacilityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FacilityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0E3 RID: 110819 RVA: 0x007B2B84 File Offset: 0x007B0D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FacilityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FacilityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B0E4 RID: 110820 RVA: 0x007B2BC2 File Offset: 0x007B0DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CafeteriaFacilityDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FacilityId != 0)
			{
				this.FacilityId = other.FacilityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B0E5 RID: 110821 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0E6 RID: 110822 RVA: 0x007B2BF4 File Offset: 0x007B0DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FacilityId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<CafeteriaFacilityDBInfo> _parser = new MessageParser<CafeteriaFacilityDBInfo>(() => new CafeteriaFacilityDBInfo());

		// Token: 0x04014BE8 RID: 84968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014BE9 RID: 84969
		public const int FacilityIdFieldNumber = 1;

		// Token: 0x04014BEA RID: 84970
		private int facilityId_;
	}
}
