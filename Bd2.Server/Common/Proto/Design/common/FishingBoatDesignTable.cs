using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C6D RID: 31853
	public sealed class FishingBoatDesignTable : IMessage<FishingBoatDesignTable>, IMessage, IEquatable<FishingBoatDesignTable>, IDeepCloneable<FishingBoatDesignTable>, IBufferMessage
	{
		// Token: 0x17011166 RID: 69990
		// (get) Token: 0x06046A6C RID: 289388 RVA: 0x0112ED41 File Offset: 0x0112CF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingBoatDesignTable> Parser
		{
			get
			{
				return FishingBoatDesignTable._parser;
			}
		}

		// Token: 0x17011167 RID: 69991
		// (get) Token: 0x06046A6D RID: 289389 RVA: 0x0112ED48 File Offset: 0x0112CF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingBoatDesignTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011168 RID: 69992
		// (get) Token: 0x06046A6E RID: 289390 RVA: 0x0112ED5A File Offset: 0x0112CF5A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingBoatDesignTable.Descriptor;
			}
		}

		// Token: 0x06046A6F RID: 289391 RVA: 0x0112ED61 File Offset: 0x0112CF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDesignTable()
		{
		}

		// Token: 0x06046A70 RID: 289392 RVA: 0x0112ED8C File Offset: 0x0112CF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDesignTable(FishingBoatDesignTable other)
			: this()
		{
			this.boatIconSpriteName_ = other.boatIconSpriteName_;
			this.id_ = other.id_;
			this.nameTextId_ = other.nameTextId_;
			this.prefabName_ = other.prefabName_;
			this.priceCount_ = other.priceCount_;
			this.priceId_ = other.priceId_;
			this.priceType_ = other.priceType_;
			this.skinIconSpriteName_ = other.skinIconSpriteName_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046A71 RID: 289393 RVA: 0x0112EE1C File Offset: 0x0112D01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDesignTable Clone()
		{
			return new FishingBoatDesignTable(this);
		}

		// Token: 0x17011169 RID: 69993
		// (get) Token: 0x06046A72 RID: 289394 RVA: 0x0112EE24 File Offset: 0x0112D024
		// (set) Token: 0x06046A73 RID: 289395 RVA: 0x0112EE2C File Offset: 0x0112D02C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string BoatIconSpriteName
		{
			get
			{
				return this.boatIconSpriteName_;
			}
			set
			{
				this.boatIconSpriteName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1701116A RID: 69994
		// (get) Token: 0x06046A74 RID: 289396 RVA: 0x0112EE3F File Offset: 0x0112D03F
		// (set) Token: 0x06046A75 RID: 289397 RVA: 0x0112EE47 File Offset: 0x0112D047
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

		// Token: 0x1701116B RID: 69995
		// (get) Token: 0x06046A76 RID: 289398 RVA: 0x0112EE50 File Offset: 0x0112D050
		// (set) Token: 0x06046A77 RID: 289399 RVA: 0x0112EE58 File Offset: 0x0112D058
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

		// Token: 0x1701116C RID: 69996
		// (get) Token: 0x06046A78 RID: 289400 RVA: 0x0112EE61 File Offset: 0x0112D061
		// (set) Token: 0x06046A79 RID: 289401 RVA: 0x0112EE69 File Offset: 0x0112D069
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PrefabName
		{
			get
			{
				return this.prefabName_;
			}
			set
			{
				this.prefabName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1701116D RID: 69997
		// (get) Token: 0x06046A7A RID: 289402 RVA: 0x0112EE7C File Offset: 0x0112D07C
		// (set) Token: 0x06046A7B RID: 289403 RVA: 0x0112EE84 File Offset: 0x0112D084
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PriceCount
		{
			get
			{
				return this.priceCount_;
			}
			set
			{
				this.priceCount_ = value;
			}
		}

		// Token: 0x1701116E RID: 69998
		// (get) Token: 0x06046A7C RID: 289404 RVA: 0x0112EE8D File Offset: 0x0112D08D
		// (set) Token: 0x06046A7D RID: 289405 RVA: 0x0112EE95 File Offset: 0x0112D095
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PriceId
		{
			get
			{
				return this.priceId_;
			}
			set
			{
				this.priceId_ = value;
			}
		}

		// Token: 0x1701116F RID: 69999
		// (get) Token: 0x06046A7E RID: 289406 RVA: 0x0112EE9E File Offset: 0x0112D09E
		// (set) Token: 0x06046A7F RID: 289407 RVA: 0x0112EEA6 File Offset: 0x0112D0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PriceType
		{
			get
			{
				return this.priceType_;
			}
			set
			{
				this.priceType_ = value;
			}
		}

		// Token: 0x17011170 RID: 70000
		// (get) Token: 0x06046A80 RID: 289408 RVA: 0x0112EEAF File Offset: 0x0112D0AF
		// (set) Token: 0x06046A81 RID: 289409 RVA: 0x0112EEB7 File Offset: 0x0112D0B7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string SkinIconSpriteName
		{
			get
			{
				return this.skinIconSpriteName_;
			}
			set
			{
				this.skinIconSpriteName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011171 RID: 70001
		// (get) Token: 0x06046A82 RID: 289410 RVA: 0x0112EECA File Offset: 0x0112D0CA
		// (set) Token: 0x06046A83 RID: 289411 RVA: 0x0112EED2 File Offset: 0x0112D0D2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06046A84 RID: 289412 RVA: 0x0112EEDB File Offset: 0x0112D0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingBoatDesignTable);
		}

		// Token: 0x06046A85 RID: 289413 RVA: 0x0112EEEC File Offset: 0x0112D0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingBoatDesignTable other)
		{
			return other != null && (other == this || (!(this.BoatIconSpriteName != other.BoatIconSpriteName) && this.Id == other.Id && this.NameTextId == other.NameTextId && !(this.PrefabName != other.PrefabName) && this.PriceCount == other.PriceCount && this.PriceId == other.PriceId && this.PriceType == other.PriceType && !(this.SkinIconSpriteName != other.SkinIconSpriteName) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046A86 RID: 289414 RVA: 0x0112EFB4 File Offset: 0x0112D1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BoatIconSpriteName.Length != 0)
			{
				num ^= this.BoatIconSpriteName.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.NameTextId != 0)
			{
				num ^= this.NameTextId.GetHashCode();
			}
			if (this.PrefabName.Length != 0)
			{
				num ^= this.PrefabName.GetHashCode();
			}
			if (this.PriceCount != 0)
			{
				num ^= this.PriceCount.GetHashCode();
			}
			if (this.PriceId != 0)
			{
				num ^= this.PriceId.GetHashCode();
			}
			if (this.PriceType != 0)
			{
				num ^= this.PriceType.GetHashCode();
			}
			if (this.SkinIconSpriteName.Length != 0)
			{
				num ^= this.SkinIconSpriteName.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046A87 RID: 289415 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046A88 RID: 289416 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046A89 RID: 289417 RVA: 0x0112F0C4 File Offset: 0x0112D2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoatIconSpriteName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.BoatIconSpriteName);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.NameTextId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NameTextId);
			}
			if (this.PrefabName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.PrefabName);
			}
			if (this.PriceCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PriceCount);
			}
			if (this.PriceId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PriceId);
			}
			if (this.PriceType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PriceType);
			}
			if (this.SkinIconSpriteName.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.SkinIconSpriteName);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046A8A RID: 289418 RVA: 0x0112F1F0 File Offset: 0x0112D3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BoatIconSpriteName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BoatIconSpriteName);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.NameTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NameTextId);
			}
			if (this.PrefabName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PrefabName);
			}
			if (this.PriceCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PriceCount);
			}
			if (this.PriceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PriceId);
			}
			if (this.PriceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PriceType);
			}
			if (this.SkinIconSpriteName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SkinIconSpriteName);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046A8B RID: 289419 RVA: 0x0112F300 File Offset: 0x0112D500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingBoatDesignTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BoatIconSpriteName.Length != 0)
			{
				this.BoatIconSpriteName = other.BoatIconSpriteName;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.NameTextId != 0)
			{
				this.NameTextId = other.NameTextId;
			}
			if (other.PrefabName.Length != 0)
			{
				this.PrefabName = other.PrefabName;
			}
			if (other.PriceCount != 0)
			{
				this.PriceCount = other.PriceCount;
			}
			if (other.PriceId != 0)
			{
				this.PriceId = other.PriceId;
			}
			if (other.PriceType != 0)
			{
				this.PriceType = other.PriceType;
			}
			if (other.SkinIconSpriteName.Length != 0)
			{
				this.SkinIconSpriteName = other.SkinIconSpriteName;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046A8C RID: 289420 RVA: 0x001D5824 File Offset: 0x001D3A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046A8D RID: 289421 RVA: 0x0112F3EC File Offset: 0x0112D5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.BoatIconSpriteName = input.ReadString();
							continue;
						}
						if (num == 16U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.NameTextId = input.ReadInt32();
							continue;
						}
						if (num == 34U)
						{
							this.PrefabName = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.PriceCount = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.PriceId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.PriceType = input.ReadInt32();
						continue;
					}
					if (num == 66U)
					{
						this.SkinIconSpriteName = input.ReadString();
						continue;
					}
					if (num == 72U)
					{
						this.Type = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402E99E RID: 190878
		private static readonly MessageParser<FishingBoatDesignTable> _parser = new MessageParser<FishingBoatDesignTable>(() => new FishingBoatDesignTable());

		// Token: 0x0402E99F RID: 190879
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402E9A0 RID: 190880
		public const int BoatIconSpriteNameFieldNumber = 1;

		// Token: 0x0402E9A1 RID: 190881
		private string boatIconSpriteName_ = "";

		// Token: 0x0402E9A2 RID: 190882
		public const int IdFieldNumber = 2;

		// Token: 0x0402E9A3 RID: 190883
		private int id_;

		// Token: 0x0402E9A4 RID: 190884
		public const int NameTextIdFieldNumber = 3;

		// Token: 0x0402E9A5 RID: 190885
		private int nameTextId_;

		// Token: 0x0402E9A6 RID: 190886
		public const int PrefabNameFieldNumber = 4;

		// Token: 0x0402E9A7 RID: 190887
		private string prefabName_ = "";

		// Token: 0x0402E9A8 RID: 190888
		public const int PriceCountFieldNumber = 5;

		// Token: 0x0402E9A9 RID: 190889
		private int priceCount_;

		// Token: 0x0402E9AA RID: 190890
		public const int PriceIdFieldNumber = 6;

		// Token: 0x0402E9AB RID: 190891
		private int priceId_;

		// Token: 0x0402E9AC RID: 190892
		public const int PriceTypeFieldNumber = 7;

		// Token: 0x0402E9AD RID: 190893
		private int priceType_;

		// Token: 0x0402E9AE RID: 190894
		public const int SkinIconSpriteNameFieldNumber = 8;

		// Token: 0x0402E9AF RID: 190895
		private string skinIconSpriteName_ = "";

		// Token: 0x0402E9B0 RID: 190896
		public const int TypeFieldNumber = 9;

		// Token: 0x0402E9B1 RID: 190897
		private int type_;
	}
}
