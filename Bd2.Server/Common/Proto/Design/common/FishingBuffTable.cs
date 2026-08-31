using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C73 RID: 31859
	public sealed class FishingBuffTable : IMessage<FishingBuffTable>, IMessage, IEquatable<FishingBuffTable>, IDeepCloneable<FishingBuffTable>, IBufferMessage
	{
		// Token: 0x17011181 RID: 70017
		// (get) Token: 0x06046ABB RID: 289467 RVA: 0x0112FE1F File Offset: 0x0112E01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingBuffTable> Parser
		{
			get
			{
				return FishingBuffTable._parser;
			}
		}

		// Token: 0x17011182 RID: 70018
		// (get) Token: 0x06046ABC RID: 289468 RVA: 0x0112FE26 File Offset: 0x0112E026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingBuffTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011183 RID: 70019
		// (get) Token: 0x06046ABD RID: 289469 RVA: 0x0112FE38 File Offset: 0x0112E038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingBuffTable.Descriptor;
			}
		}

		// Token: 0x06046ABE RID: 289470 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBuffTable()
		{
		}

		// Token: 0x06046ABF RID: 289471 RVA: 0x0112FE40 File Offset: 0x0112E040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBuffTable(FishingBuffTable other)
			: this()
		{
			this.buffDuration_ = other.buffDuration_;
			this.buffType_ = other.buffType_;
			this.buffValue_ = other.buffValue_;
			this.id_ = other.id_;
			this.nameTextId_ = other.nameTextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046AC0 RID: 289472 RVA: 0x0112FEA0 File Offset: 0x0112E0A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingBuffTable Clone()
		{
			return new FishingBuffTable(this);
		}

		// Token: 0x17011184 RID: 70020
		// (get) Token: 0x06046AC1 RID: 289473 RVA: 0x0112FEA8 File Offset: 0x0112E0A8
		// (set) Token: 0x06046AC2 RID: 289474 RVA: 0x0112FEB0 File Offset: 0x0112E0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffDuration
		{
			get
			{
				return this.buffDuration_;
			}
			set
			{
				this.buffDuration_ = value;
			}
		}

		// Token: 0x17011185 RID: 70021
		// (get) Token: 0x06046AC3 RID: 289475 RVA: 0x0112FEB9 File Offset: 0x0112E0B9
		// (set) Token: 0x06046AC4 RID: 289476 RVA: 0x0112FEC1 File Offset: 0x0112E0C1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BuffType
		{
			get
			{
				return this.buffType_;
			}
			set
			{
				this.buffType_ = value;
			}
		}

		// Token: 0x17011186 RID: 70022
		// (get) Token: 0x06046AC5 RID: 289477 RVA: 0x0112FECA File Offset: 0x0112E0CA
		// (set) Token: 0x06046AC6 RID: 289478 RVA: 0x0112FED2 File Offset: 0x0112E0D2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double BuffValue
		{
			get
			{
				return this.buffValue_;
			}
			set
			{
				this.buffValue_ = value;
			}
		}

		// Token: 0x17011187 RID: 70023
		// (get) Token: 0x06046AC7 RID: 289479 RVA: 0x0112FEDB File Offset: 0x0112E0DB
		// (set) Token: 0x06046AC8 RID: 289480 RVA: 0x0112FEE3 File Offset: 0x0112E0E3
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

		// Token: 0x17011188 RID: 70024
		// (get) Token: 0x06046AC9 RID: 289481 RVA: 0x0112FEEC File Offset: 0x0112E0EC
		// (set) Token: 0x06046ACA RID: 289482 RVA: 0x0112FEF4 File Offset: 0x0112E0F4
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

		// Token: 0x06046ACB RID: 289483 RVA: 0x0112FEFD File Offset: 0x0112E0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingBuffTable);
		}

		// Token: 0x06046ACC RID: 289484 RVA: 0x0112FF0C File Offset: 0x0112E10C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FishingBuffTable other)
		{
			return other != null && (other == this || (this.BuffDuration == other.BuffDuration && this.BuffType == other.BuffType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.BuffValue, other.BuffValue) && this.Id == other.Id && this.NameTextId == other.NameTextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046ACD RID: 289485 RVA: 0x0112FF90 File Offset: 0x0112E190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffDuration != 0)
			{
				num ^= this.BuffDuration.GetHashCode();
			}
			if (this.BuffType != 0)
			{
				num ^= this.BuffType.GetHashCode();
			}
			if (this.BuffValue != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.BuffValue);
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

		// Token: 0x06046ACE RID: 289486 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046ACF RID: 289487 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046AD0 RID: 289488 RVA: 0x01130040 File Offset: 0x0112E240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffDuration != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffDuration);
			}
			if (this.BuffType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BuffType);
			}
			if (this.BuffValue != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.BuffValue);
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046AD1 RID: 289489 RVA: 0x011300F8 File Offset: 0x0112E2F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffDuration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffDuration);
			}
			if (this.BuffType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffType);
			}
			if (this.BuffValue != 0.0)
			{
				num += 9;
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

		// Token: 0x06046AD2 RID: 289490 RVA: 0x01130194 File Offset: 0x0112E394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingBuffTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffDuration != 0)
			{
				this.BuffDuration = other.BuffDuration;
			}
			if (other.BuffType != 0)
			{
				this.BuffType = other.BuffType;
			}
			if (other.BuffValue != 0.0)
			{
				this.BuffValue = other.BuffValue;
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

		// Token: 0x06046AD3 RID: 289491 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046AD4 RID: 289492 RVA: 0x0113022C File Offset: 0x0112E42C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.BuffDuration = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.BuffType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 25U)
					{
						this.BuffValue = input.ReadDouble();
						continue;
					}
					if (num == 32U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.NameTextId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402E9CC RID: 190924
		private static readonly MessageParser<FishingBuffTable> _parser = new MessageParser<FishingBuffTable>(() => new FishingBuffTable());

		// Token: 0x0402E9CD RID: 190925
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402E9CE RID: 190926
		public const int BuffDurationFieldNumber = 1;

		// Token: 0x0402E9CF RID: 190927
		private int buffDuration_;

		// Token: 0x0402E9D0 RID: 190928
		public const int BuffTypeFieldNumber = 2;

		// Token: 0x0402E9D1 RID: 190929
		private int buffType_;

		// Token: 0x0402E9D2 RID: 190930
		public const int BuffValueFieldNumber = 3;

		// Token: 0x0402E9D3 RID: 190931
		private double buffValue_;

		// Token: 0x0402E9D4 RID: 190932
		public const int IdFieldNumber = 4;

		// Token: 0x0402E9D5 RID: 190933
		private int id_;

		// Token: 0x0402E9D6 RID: 190934
		public const int NameTextIdFieldNumber = 5;

		// Token: 0x0402E9D7 RID: 190935
		private int nameTextId_;
	}
}
