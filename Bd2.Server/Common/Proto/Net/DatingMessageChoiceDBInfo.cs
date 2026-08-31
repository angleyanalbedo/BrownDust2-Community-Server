using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200443D RID: 17469
	public sealed class DatingMessageChoiceDBInfo : IMessage<DatingMessageChoiceDBInfo>, IMessage, IEquatable<DatingMessageChoiceDBInfo>, IDeepCloneable<DatingMessageChoiceDBInfo>, IBufferMessage
	{
		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x0601B3DE RID: 111582 RVA: 0x007BAF19 File Offset: 0x007B9119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DatingMessageChoiceDBInfo> Parser
		{
			get
			{
				return DatingMessageChoiceDBInfo._parser;
			}
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x0601B3DF RID: 111583 RVA: 0x007BAF20 File Offset: 0x007B9120
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DatingMessageChoiceDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x0601B3E0 RID: 111584 RVA: 0x007BAF32 File Offset: 0x007B9132
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DatingMessageChoiceDBInfo.Descriptor;
			}
		}

		// Token: 0x0601B3E1 RID: 111585 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingMessageChoiceDBInfo()
		{
		}

		// Token: 0x0601B3E2 RID: 111586 RVA: 0x007BAF39 File Offset: 0x007B9139
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DatingMessageChoiceDBInfo(DatingMessageChoiceDBInfo other)
			: this()
		{
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this.selectTextId_ = other.selectTextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3E3 RID: 111587 RVA: 0x007BAF76 File Offset: 0x007B9176
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DatingMessageChoiceDBInfo Clone()
		{
			return new DatingMessageChoiceDBInfo(this);
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x0601B3E4 RID: 111588 RVA: 0x007BAF7E File Offset: 0x007B917E
		// (set) Token: 0x0601B3E5 RID: 111589 RVA: 0x007BAF86 File Offset: 0x007B9186
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

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x0601B3E6 RID: 111590 RVA: 0x007BAF8F File Offset: 0x007B918F
		// (set) Token: 0x0601B3E7 RID: 111591 RVA: 0x007BAF97 File Offset: 0x007B9197
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

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x0601B3E8 RID: 111592 RVA: 0x007BAFA0 File Offset: 0x007B91A0
		// (set) Token: 0x0601B3E9 RID: 111593 RVA: 0x007BAFA8 File Offset: 0x007B91A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectTextId
		{
			get
			{
				return this.selectTextId_;
			}
			set
			{
				this.selectTextId_ = value;
			}
		}

		// Token: 0x0601B3EA RID: 111594 RVA: 0x007BAFB1 File Offset: 0x007B91B1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DatingMessageChoiceDBInfo);
		}

		// Token: 0x0601B3EB RID: 111595 RVA: 0x007BAFC0 File Offset: 0x007B91C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DatingMessageChoiceDBInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Id == other.Id && this.SelectTextId == other.SelectTextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3EC RID: 111596 RVA: 0x007BB01C File Offset: 0x007B921C
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
			if (this.SelectTextId != 0)
			{
				num ^= this.SelectTextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B3ED RID: 111597 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B3EE RID: 111598 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3EF RID: 111599 RVA: 0x007BB090 File Offset: 0x007B9290
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
			if (this.SelectTextId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SelectTextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3F0 RID: 111600 RVA: 0x007BB104 File Offset: 0x007B9304
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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
			if (this.SelectTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectTextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B3F1 RID: 111601 RVA: 0x007BB174 File Offset: 0x007B9374
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(DatingMessageChoiceDBInfo other)
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
			if (other.SelectTextId != 0)
			{
				this.SelectTextId = other.SelectTextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B3F2 RID: 111602 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3F3 RID: 111603 RVA: 0x007BB1D8 File Offset: 0x007B93D8
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
							this.SelectTextId = input.ReadInt32();
						}
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
		private static readonly MessageParser<DatingMessageChoiceDBInfo> _parser = new MessageParser<DatingMessageChoiceDBInfo>(() => new DatingMessageChoiceDBInfo());

		// Token: 0x04014D4B RID: 85323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014D4C RID: 85324
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04014D4D RID: 85325
		private int groupId_;

		// Token: 0x04014D4E RID: 85326
		public const int IdFieldNumber = 2;

		// Token: 0x04014D4F RID: 85327
		private int id_;

		// Token: 0x04014D50 RID: 85328
		public const int SelectTextIdFieldNumber = 3;

		// Token: 0x04014D51 RID: 85329
		private int selectTextId_;
	}
}
