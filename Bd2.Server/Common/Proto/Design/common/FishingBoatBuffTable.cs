using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C6A RID: 31850
	public sealed class FishingBoatBuffTable : IMessage<FishingBoatBuffTable>, IMessage, IEquatable<FishingBoatBuffTable>, IDeepCloneable<FishingBoatBuffTable>, IBufferMessage
	{
		// Token: 0x1701115F RID: 69983
		// (get) Token: 0x06046A50 RID: 289360 RVA: 0x0112E8F7 File Offset: 0x0112CAF7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingBoatBuffTable> Parser
		{
			get
			{
				return FishingBoatBuffTable._parser;
			}
		}

		// Token: 0x17011160 RID: 69984
		// (get) Token: 0x06046A51 RID: 289361 RVA: 0x0112E8FE File Offset: 0x0112CAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingBoatBuffTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011161 RID: 69985
		// (get) Token: 0x06046A52 RID: 289362 RVA: 0x0112E910 File Offset: 0x0112CB10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingBoatBuffTable.Descriptor;
			}
		}

		// Token: 0x06046A53 RID: 289363 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatBuffTable()
		{
		}

		// Token: 0x06046A54 RID: 289364 RVA: 0x0112E917 File Offset: 0x0112CB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatBuffTable(FishingBoatBuffTable other)
			: this()
		{
			this.buffId_ = other.buffId_;
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046A55 RID: 289365 RVA: 0x0112E954 File Offset: 0x0112CB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatBuffTable Clone()
		{
			return new FishingBoatBuffTable(this);
		}

		// Token: 0x17011162 RID: 69986
		// (get) Token: 0x06046A56 RID: 289366 RVA: 0x0112E95C File Offset: 0x0112CB5C
		// (set) Token: 0x06046A57 RID: 289367 RVA: 0x0112E964 File Offset: 0x0112CB64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17011163 RID: 69987
		// (get) Token: 0x06046A58 RID: 289368 RVA: 0x0112E96D File Offset: 0x0112CB6D
		// (set) Token: 0x06046A59 RID: 289369 RVA: 0x0112E975 File Offset: 0x0112CB75
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17011164 RID: 69988
		// (get) Token: 0x06046A5A RID: 289370 RVA: 0x0112E97E File Offset: 0x0112CB7E
		// (set) Token: 0x06046A5B RID: 289371 RVA: 0x0112E986 File Offset: 0x0112CB86
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

		// Token: 0x06046A5C RID: 289372 RVA: 0x0112E98F File Offset: 0x0112CB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingBoatBuffTable);
		}

		// Token: 0x06046A5D RID: 289373 RVA: 0x0112E9A0 File Offset: 0x0112CBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingBoatBuffTable other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.GroupId == other.GroupId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046A5E RID: 289374 RVA: 0x0112E9FC File Offset: 0x0112CBFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0)
			{
				num ^= this.BuffId.GetHashCode();
			}
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

		// Token: 0x06046A5F RID: 289375 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046A60 RID: 289376 RVA: 0x001D568A File Offset: 0x001D388A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046A61 RID: 289377 RVA: 0x0112EA70 File Offset: 0x0112CC70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffId);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046A62 RID: 289378 RVA: 0x0112EAE4 File Offset: 0x0112CCE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffId);
			}
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

		// Token: 0x06046A63 RID: 289379 RVA: 0x0112EB54 File Offset: 0x0112CD54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingBoatBuffTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0)
			{
				this.BuffId = other.BuffId;
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

		// Token: 0x06046A64 RID: 289380 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046A65 RID: 289381 RVA: 0x0112EBB8 File Offset: 0x0112CDB8
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
							this.Id = input.ReadInt32();
						}
					}
					else
					{
						this.GroupId = input.ReadInt32();
					}
				}
				else
				{
					this.BuffId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0402E994 RID: 190868
		private static readonly MessageParser<FishingBoatBuffTable> _parser = new MessageParser<FishingBoatBuffTable>(() => new FishingBoatBuffTable());

		// Token: 0x0402E995 RID: 190869
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402E996 RID: 190870
		public const int BuffIdFieldNumber = 1;

		// Token: 0x0402E997 RID: 190871
		private int buffId_;

		// Token: 0x0402E998 RID: 190872
		public const int GroupIdFieldNumber = 2;

		// Token: 0x0402E999 RID: 190873
		private int groupId_;

		// Token: 0x0402E99A RID: 190874
		public const int IdFieldNumber = 3;

		// Token: 0x0402E99B RID: 190875
		private int id_;
	}
}
