using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200563E RID: 22078
	public sealed class RootSortIdInfo : IMessage<RootSortIdInfo>, IMessage, IEquatable<RootSortIdInfo>, IDeepCloneable<RootSortIdInfo>, IBufferMessage
	{
		// Token: 0x170053CC RID: 21452
		// (get) Token: 0x060250EB RID: 151787 RVA: 0x00923F38 File Offset: 0x00922138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RootSortIdInfo> Parser
		{
			get
			{
				return RootSortIdInfo._parser;
			}
		}

		// Token: 0x170053CD RID: 21453
		// (get) Token: 0x060250EC RID: 151788 RVA: 0x00923F3F File Offset: 0x0092213F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RootSortIdInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170053CE RID: 21454
		// (get) Token: 0x060250ED RID: 151789 RVA: 0x00923F51 File Offset: 0x00922151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RootSortIdInfo.Descriptor;
			}
		}

		// Token: 0x060250EE RID: 151790 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RootSortIdInfo()
		{
		}

		// Token: 0x060250EF RID: 151791 RVA: 0x00923F58 File Offset: 0x00922158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RootSortIdInfo(RootSortIdInfo other)
			: this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this.sortId_ = other.sortId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060250F0 RID: 151792 RVA: 0x00923F95 File Offset: 0x00922195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RootSortIdInfo Clone()
		{
			return new RootSortIdInfo(this);
		}

		// Token: 0x170053CF RID: 21455
		// (get) Token: 0x060250F1 RID: 151793 RVA: 0x00923F9D File Offset: 0x0092219D
		// (set) Token: 0x060250F2 RID: 151794 RVA: 0x00923FA5 File Offset: 0x009221A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170053D0 RID: 21456
		// (get) Token: 0x060250F3 RID: 151795 RVA: 0x00923FAE File Offset: 0x009221AE
		// (set) Token: 0x060250F4 RID: 151796 RVA: 0x00923FB6 File Offset: 0x009221B6
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

		// Token: 0x170053D1 RID: 21457
		// (get) Token: 0x060250F5 RID: 151797 RVA: 0x00923FBF File Offset: 0x009221BF
		// (set) Token: 0x060250F6 RID: 151798 RVA: 0x00923FC7 File Offset: 0x009221C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SortId
		{
			get
			{
				return this.sortId_;
			}
			set
			{
				this.sortId_ = value;
			}
		}

		// Token: 0x060250F7 RID: 151799 RVA: 0x00923FD0 File Offset: 0x009221D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RootSortIdInfo);
		}

		// Token: 0x060250F8 RID: 151800 RVA: 0x00923FE0 File Offset: 0x009221E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(RootSortIdInfo other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && this.SortId == other.SortId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060250F9 RID: 151801 RVA: 0x0092403C File Offset: 0x0092223C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.SortId != 0)
			{
				num ^= this.SortId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060250FA RID: 151802 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060250FB RID: 151803 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060250FC RID: 151804 RVA: 0x009240B0 File Offset: 0x009222B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.SortId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SortId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060250FD RID: 151805 RVA: 0x00924124 File Offset: 0x00922324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.SortId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SortId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060250FE RID: 151806 RVA: 0x00924194 File Offset: 0x00922394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RootSortIdInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.SortId != 0)
			{
				this.SortId = other.SortId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060250FF RID: 151807 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06025100 RID: 151808 RVA: 0x009241F8 File Offset: 0x009223F8
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SortId = input.ReadInt32();
						}
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Type = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<RootSortIdInfo> _parser = new MessageParser<RootSortIdInfo>(() => new RootSortIdInfo());

		// Token: 0x04018F1E RID: 102174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018F1F RID: 102175
		public const int TypeFieldNumber = 1;

		// Token: 0x04018F20 RID: 102176
		private int type_;

		// Token: 0x04018F21 RID: 102177
		public const int IdFieldNumber = 2;

		// Token: 0x04018F22 RID: 102178
		private int id_;

		// Token: 0x04018F23 RID: 102179
		public const int SortIdFieldNumber = 3;

		// Token: 0x04018F24 RID: 102180
		private int sortId_;
	}
}
