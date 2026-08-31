using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CA3 RID: 31907
	public sealed class FishingRodTable : IMessage<FishingRodTable>, IMessage, IEquatable<FishingRodTable>, IDeepCloneable<FishingRodTable>, IBufferMessage
	{
		// Token: 0x1701125B RID: 70235
		// (get) Token: 0x06046D40 RID: 290112 RVA: 0x0113928B File Offset: 0x0113748B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FishingRodTable> Parser
		{
			get
			{
				return FishingRodTable._parser;
			}
		}

		// Token: 0x1701125C RID: 70236
		// (get) Token: 0x06046D41 RID: 290113 RVA: 0x01139292 File Offset: 0x01137492
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingRodTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1701125D RID: 70237
		// (get) Token: 0x06046D42 RID: 290114 RVA: 0x011392A4 File Offset: 0x011374A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingRodTable.Descriptor;
			}
		}

		// Token: 0x06046D43 RID: 290115 RVA: 0x011392AB File Offset: 0x011374AB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingRodTable()
		{
		}

		// Token: 0x06046D44 RID: 290116 RVA: 0x011392CC File Offset: 0x011374CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingRodTable(FishingRodTable other)
			: this()
		{
			this.avatarItemId_ = other.avatarItemId_;
			this.buffId_ = other.buffId_.Clone();
			this.descLocalTextId_ = other.descLocalTextId_;
			this.iconSpriteName_ = other.iconSpriteName_;
			this.id_ = other.id_;
			this.nameTextId_ = other.nameTextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046D45 RID: 290117 RVA: 0x0113933D File Offset: 0x0113753D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingRodTable Clone()
		{
			return new FishingRodTable(this);
		}

		// Token: 0x1701125E RID: 70238
		// (get) Token: 0x06046D46 RID: 290118 RVA: 0x01139345 File Offset: 0x01137545
		// (set) Token: 0x06046D47 RID: 290119 RVA: 0x0113934D File Offset: 0x0113754D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AvatarItemId
		{
			get
			{
				return this.avatarItemId_;
			}
			set
			{
				this.avatarItemId_ = value;
			}
		}

		// Token: 0x1701125F RID: 70239
		// (get) Token: 0x06046D48 RID: 290120 RVA: 0x01139356 File Offset: 0x01137556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffId
		{
			get
			{
				return this.buffId_;
			}
		}

		// Token: 0x17011260 RID: 70240
		// (get) Token: 0x06046D49 RID: 290121 RVA: 0x0113935E File Offset: 0x0113755E
		// (set) Token: 0x06046D4A RID: 290122 RVA: 0x01139366 File Offset: 0x01137566
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

		// Token: 0x17011261 RID: 70241
		// (get) Token: 0x06046D4B RID: 290123 RVA: 0x0113936F File Offset: 0x0113756F
		// (set) Token: 0x06046D4C RID: 290124 RVA: 0x01139377 File Offset: 0x01137577
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

		// Token: 0x17011262 RID: 70242
		// (get) Token: 0x06046D4D RID: 290125 RVA: 0x0113938A File Offset: 0x0113758A
		// (set) Token: 0x06046D4E RID: 290126 RVA: 0x01139392 File Offset: 0x01137592
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

		// Token: 0x17011263 RID: 70243
		// (get) Token: 0x06046D4F RID: 290127 RVA: 0x0113939B File Offset: 0x0113759B
		// (set) Token: 0x06046D50 RID: 290128 RVA: 0x011393A3 File Offset: 0x011375A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06046D51 RID: 290129 RVA: 0x011393AC File Offset: 0x011375AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingRodTable);
		}

		// Token: 0x06046D52 RID: 290130 RVA: 0x011393BC File Offset: 0x011375BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingRodTable other)
		{
			return other != null && (other == this || (this.AvatarItemId == other.AvatarItemId && this.buffId_.Equals(other.buffId_) && this.DescLocalTextId == other.DescLocalTextId && !(this.IconSpriteName != other.IconSpriteName) && this.Id == other.Id && this.NameTextId == other.NameTextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046D53 RID: 290131 RVA: 0x01139450 File Offset: 0x01137650
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarItemId != 0)
			{
				num ^= this.AvatarItemId.GetHashCode();
			}
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046D54 RID: 290132 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046D55 RID: 290133 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046D56 RID: 290134 RVA: 0x01139504 File Offset: 0x01137704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AvatarItemId);
			}
			this.buffId_.WriteTo(ref output, FishingRodTable._repeated_buffId_codec);
			if (this.DescLocalTextId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DescLocalTextId);
			}
			if (this.IconSpriteName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.IconSpriteName);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this.NameTextId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NameTextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046D57 RID: 290135 RVA: 0x011395C8 File Offset: 0x011377C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AvatarItemId);
			}
			num += this.buffId_.CalculateSize(FishingRodTable._repeated_buffId_codec);
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046D58 RID: 290136 RVA: 0x01139680 File Offset: 0x01137880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingRodTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarItemId != 0)
			{
				this.AvatarItemId = other.AvatarItemId;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046D59 RID: 290137 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046D5A RID: 290138 RVA: 0x01139724 File Offset: 0x01137924
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.AvatarItemId = input.ReadInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.buffId_.AddEntriesFrom(ref input, FishingRodTable._repeated_buffId_codec);
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 24U)
					{
						this.DescLocalTextId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.IconSpriteName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.NameTextId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EB4F RID: 191311
		private static readonly MessageParser<FishingRodTable> _parser = new MessageParser<FishingRodTable>(() => new FishingRodTable());

		// Token: 0x0402EB50 RID: 191312
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EB51 RID: 191313
		public const int AvatarItemIdFieldNumber = 1;

		// Token: 0x0402EB52 RID: 191314
		private int avatarItemId_;

		// Token: 0x0402EB53 RID: 191315
		public const int BuffIdFieldNumber = 2;

		// Token: 0x0402EB54 RID: 191316
		private static readonly FieldCodec<int> _repeated_buffId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0402EB55 RID: 191317
		private readonly RepeatedField<int> buffId_ = new RepeatedField<int>();

		// Token: 0x0402EB56 RID: 191318
		public const int DescLocalTextIdFieldNumber = 3;

		// Token: 0x0402EB57 RID: 191319
		private int descLocalTextId_;

		// Token: 0x0402EB58 RID: 191320
		public const int IconSpriteNameFieldNumber = 4;

		// Token: 0x0402EB59 RID: 191321
		private string iconSpriteName_ = "";

		// Token: 0x0402EB5A RID: 191322
		public const int IdFieldNumber = 5;

		// Token: 0x0402EB5B RID: 191323
		private int id_;

		// Token: 0x0402EB5C RID: 191324
		public const int NameTextIdFieldNumber = 6;

		// Token: 0x0402EB5D RID: 191325
		private int nameTextId_;
	}
}
