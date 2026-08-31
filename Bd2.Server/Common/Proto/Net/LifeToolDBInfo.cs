using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004619 RID: 17945
	public sealed class LifeToolDBInfo : IMessage<LifeToolDBInfo>, IMessage, IEquatable<LifeToolDBInfo>, IDeepCloneable<LifeToolDBInfo>, IBufferMessage
	{
		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x0601C098 RID: 114840 RVA: 0x007DFEE4 File Offset: 0x007DE0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifeToolDBInfo> Parser
		{
			get
			{
				return LifeToolDBInfo._parser;
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0601C099 RID: 114841 RVA: 0x007DFEEB File Offset: 0x007DE0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeToolDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0601C09A RID: 114842 RVA: 0x007DFEFD File Offset: 0x007DE0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeToolDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C09B RID: 114843 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeToolDBInfo()
		{
		}

		// Token: 0x0601C09C RID: 114844 RVA: 0x007DFF04 File Offset: 0x007DE104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeToolDBInfo(LifeToolDBInfo other)
			: this()
		{
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C09D RID: 114845 RVA: 0x007DFF35 File Offset: 0x007DE135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeToolDBInfo Clone()
		{
			return new LifeToolDBInfo(this);
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0601C09E RID: 114846 RVA: 0x007DFF3D File Offset: 0x007DE13D
		// (set) Token: 0x0601C09F RID: 114847 RVA: 0x007DFF45 File Offset: 0x007DE145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x0601C0A0 RID: 114848 RVA: 0x007DFF4E File Offset: 0x007DE14E
		// (set) Token: 0x0601C0A1 RID: 114849 RVA: 0x007DFF56 File Offset: 0x007DE156
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

		// Token: 0x0601C0A2 RID: 114850 RVA: 0x007DFF5F File Offset: 0x007DE15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeToolDBInfo);
		}

		// Token: 0x0601C0A3 RID: 114851 RVA: 0x007DFF6D File Offset: 0x007DE16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifeToolDBInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0A4 RID: 114852 RVA: 0x007DFFAC File Offset: 0x007DE1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0A5 RID: 114853 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C0A6 RID: 114854 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0A7 RID: 114855 RVA: 0x007E0004 File Offset: 0x007DE204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0A8 RID: 114856 RVA: 0x007E005C File Offset: 0x007DE25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0A9 RID: 114857 RVA: 0x007E00B4 File Offset: 0x007DE2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeToolDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0AA RID: 114858 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0AB RID: 114859 RVA: 0x007E0104 File Offset: 0x007DE304
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
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<LifeToolDBInfo> _parser = new MessageParser<LifeToolDBInfo>(() => new LifeToolDBInfo());

		// Token: 0x04015891 RID: 88209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015892 RID: 88210
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04015893 RID: 88211
		private int groupId_;

		// Token: 0x04015894 RID: 88212
		public const int IdFieldNumber = 2;

		// Token: 0x04015895 RID: 88213
		private int id_;
	}
}
