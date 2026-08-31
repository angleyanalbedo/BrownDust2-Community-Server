using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C97 RID: 31895
	public sealed class FishingItemTable : IMessage<FishingItemTable>, IMessage, IEquatable<FishingItemTable>, IDeepCloneable<FishingItemTable>, IBufferMessage
	{
		// Token: 0x17011232 RID: 70194
		// (get) Token: 0x06046CBA RID: 289978 RVA: 0x01137877 File Offset: 0x01135A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingItemTable> Parser
		{
			get
			{
				return FishingItemTable._parser;
			}
		}

		// Token: 0x17011233 RID: 70195
		// (get) Token: 0x06046CBB RID: 289979 RVA: 0x0113787E File Offset: 0x01135A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingItemTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011234 RID: 70196
		// (get) Token: 0x06046CBC RID: 289980 RVA: 0x01137890 File Offset: 0x01135A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingItemTable.Descriptor;
			}
		}

		// Token: 0x06046CBD RID: 289981 RVA: 0x01137897 File Offset: 0x01135A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemTable()
		{
		}

		// Token: 0x06046CBE RID: 289982 RVA: 0x011378B8 File Offset: 0x01135AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemTable(FishingItemTable other)
			: this()
		{
			this.buffId_ = other.buffId_.Clone();
			this.descLocalTextId_ = other.descLocalTextId_;
			this.iconSpriteName_ = other.iconSpriteName_;
			this.id_ = other.id_;
			this.nameTextId_ = other.nameTextId_;
			this.stackCount_ = other.stackCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046CBF RID: 289983 RVA: 0x01137929 File Offset: 0x01135B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemTable Clone()
		{
			return new FishingItemTable(this);
		}

		// Token: 0x17011235 RID: 70197
		// (get) Token: 0x06046CC0 RID: 289984 RVA: 0x01137931 File Offset: 0x01135B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffId
		{
			get
			{
				return this.buffId_;
			}
		}

		// Token: 0x17011236 RID: 70198
		// (get) Token: 0x06046CC1 RID: 289985 RVA: 0x01137939 File Offset: 0x01135B39
		// (set) Token: 0x06046CC2 RID: 289986 RVA: 0x01137941 File Offset: 0x01135B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DescLocalTextId
		{
			get
			{
				return this.descLocalTextId_;
			}
			set
			{
				this.descLocalTextId_ = value;
			}
		}

		// Token: 0x17011237 RID: 70199
		// (get) Token: 0x06046CC3 RID: 289987 RVA: 0x0113794A File Offset: 0x01135B4A
		// (set) Token: 0x06046CC4 RID: 289988 RVA: 0x01137952 File Offset: 0x01135B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IconSpriteName
		{
			get
			{
				return this.iconSpriteName_;
			}
			set
			{
				this.iconSpriteName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011238 RID: 70200
		// (get) Token: 0x06046CC5 RID: 289989 RVA: 0x01137965 File Offset: 0x01135B65
		// (set) Token: 0x06046CC6 RID: 289990 RVA: 0x0113796D File Offset: 0x01135B6D
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

		// Token: 0x17011239 RID: 70201
		// (get) Token: 0x06046CC7 RID: 289991 RVA: 0x01137976 File Offset: 0x01135B76
		// (set) Token: 0x06046CC8 RID: 289992 RVA: 0x0113797E File Offset: 0x01135B7E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NameTextId
		{
			get
			{
				return this.nameTextId_;
			}
			set
			{
				this.nameTextId_ = value;
			}
		}

		// Token: 0x1701123A RID: 70202
		// (get) Token: 0x06046CC9 RID: 289993 RVA: 0x01137987 File Offset: 0x01135B87
		// (set) Token: 0x06046CCA RID: 289994 RVA: 0x0113798F File Offset: 0x01135B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x06046CCB RID: 289995 RVA: 0x01137998 File Offset: 0x01135B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingItemTable);
		}

		// Token: 0x06046CCC RID: 289996 RVA: 0x011379A8 File Offset: 0x01135BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingItemTable other)
		{
			return other != null && (other == this || (this.buffId_.Equals(other.buffId_) && this.DescLocalTextId == other.DescLocalTextId && !(this.IconSpriteName != other.IconSpriteName) && this.Id == other.Id && this.NameTextId == other.NameTextId && this.StackCount == other.StackCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046CCD RID: 289997 RVA: 0x01137A3C File Offset: 0x01135C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffId_.GetHashCode();
			if (this.DescLocalTextId != 0)
			{
				num ^= this.DescLocalTextId.GetHashCode();
			}
			if (this.IconSpriteName.Length != 0)
			{
				num ^= this.IconSpriteName.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.NameTextId != 0)
			{
				num ^= this.NameTextId.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046CCE RID: 289998 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046CCF RID: 289999 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046CD0 RID: 290000 RVA: 0x01137AF0 File Offset: 0x01135CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffId_.WriteTo(ref output, FishingItemTable._repeated_buffId_codec);
			if (this.DescLocalTextId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DescLocalTextId);
			}
			if (this.IconSpriteName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.IconSpriteName);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this.NameTextId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.NameTextId);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046CD1 RID: 290001 RVA: 0x01137BB4 File Offset: 0x01135DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffId_.CalculateSize(FishingItemTable._repeated_buffId_codec);
			if (this.DescLocalTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DescLocalTextId);
			}
			if (this.IconSpriteName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IconSpriteName);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.NameTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NameTextId);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046CD2 RID: 290002 RVA: 0x01137C6C File Offset: 0x01135E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingItemTable other)
		{
			if (other == null)
			{
				return;
			}
			this.buffId_.Add(other.buffId_);
			if (other.DescLocalTextId != 0)
			{
				this.DescLocalTextId = other.DescLocalTextId;
			}
			if (other.IconSpriteName.Length != 0)
			{
				this.IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.NameTextId != 0)
			{
				this.NameTextId = other.NameTextId;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046CD3 RID: 290003 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046CD4 RID: 290004 RVA: 0x01137D10 File Offset: 0x01135F10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.buffId_.AddEntriesFrom(ref input, FishingItemTable._repeated_buffId_codec);
						continue;
					}
					if (num == 16U)
					{
						this.DescLocalTextId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 32U)
				{
					if (num == 26U)
					{
						this.IconSpriteName = input.ReadString();
						continue;
					}
					if (num == 32U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.NameTextId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EB09 RID: 191241
		private static readonly MessageParser<FishingItemTable> _parser = new MessageParser<FishingItemTable>(() => new FishingItemTable());

		// Token: 0x0402EB0A RID: 191242
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EB0B RID: 191243
		public const int BuffIdFieldNumber = 1;

		// Token: 0x0402EB0C RID: 191244
		private static readonly FieldCodec<int> _repeated_buffId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0402EB0D RID: 191245
		private readonly RepeatedField<int> buffId_ = new RepeatedField<int>();

		// Token: 0x0402EB0E RID: 191246
		public const int DescLocalTextIdFieldNumber = 2;

		// Token: 0x0402EB0F RID: 191247
		private int descLocalTextId_;

		// Token: 0x0402EB10 RID: 191248
		public const int IconSpriteNameFieldNumber = 3;

		// Token: 0x0402EB11 RID: 191249
		private string iconSpriteName_ = "";

		// Token: 0x0402EB12 RID: 191250
		public const int IdFieldNumber = 4;

		// Token: 0x0402EB13 RID: 191251
		private int id_;

		// Token: 0x0402EB14 RID: 191252
		public const int NameTextIdFieldNumber = 5;

		// Token: 0x0402EB15 RID: 191253
		private int nameTextId_;

		// Token: 0x0402EB16 RID: 191254
		public const int StackCountFieldNumber = 6;

		// Token: 0x0402EB17 RID: 191255
		private int stackCount_;
	}
}
