using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C9D RID: 31901
	public sealed class FishingMapTable : IMessage<FishingMapTable>, IMessage, IEquatable<FishingMapTable>, IDeepCloneable<FishingMapTable>, IBufferMessage
	{
		// Token: 0x17011249 RID: 70217
		// (get) Token: 0x06046D03 RID: 290051 RVA: 0x0113875B File Offset: 0x0113695B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingMapTable> Parser
		{
			get
			{
				return FishingMapTable._parser;
			}
		}

		// Token: 0x1701124A RID: 70218
		// (get) Token: 0x06046D04 RID: 290052 RVA: 0x01138762 File Offset: 0x01136962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingMapTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1701124B RID: 70219
		// (get) Token: 0x06046D05 RID: 290053 RVA: 0x01138774 File Offset: 0x01136974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingMapTable.Descriptor;
			}
		}

		// Token: 0x06046D06 RID: 290054 RVA: 0x0113877B File Offset: 0x0113697B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingMapTable()
		{
		}

		// Token: 0x06046D07 RID: 290055 RVA: 0x01138790 File Offset: 0x01136990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingMapTable(FishingMapTable other)
			: this()
		{
			this.fishPoolGroupId_ = other.fishPoolGroupId_;
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this.mainUIName_ = other.mainUIName_;
			this.mapId_ = other.mapId_;
			this.mapType_ = other.mapType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046D08 RID: 290056 RVA: 0x011387FC File Offset: 0x011369FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingMapTable Clone()
		{
			return new FishingMapTable(this);
		}

		// Token: 0x1701124C RID: 70220
		// (get) Token: 0x06046D09 RID: 290057 RVA: 0x01138804 File Offset: 0x01136A04
		// (set) Token: 0x06046D0A RID: 290058 RVA: 0x0113880C File Offset: 0x01136A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishPoolGroupId
		{
			get
			{
				return this.fishPoolGroupId_;
			}
			set
			{
				this.fishPoolGroupId_ = value;
			}
		}

		// Token: 0x1701124D RID: 70221
		// (get) Token: 0x06046D0B RID: 290059 RVA: 0x01138815 File Offset: 0x01136A15
		// (set) Token: 0x06046D0C RID: 290060 RVA: 0x0113881D File Offset: 0x01136A1D
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

		// Token: 0x1701124E RID: 70222
		// (get) Token: 0x06046D0D RID: 290061 RVA: 0x01138826 File Offset: 0x01136A26
		// (set) Token: 0x06046D0E RID: 290062 RVA: 0x0113882E File Offset: 0x01136A2E
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

		// Token: 0x1701124F RID: 70223
		// (get) Token: 0x06046D0F RID: 290063 RVA: 0x01138837 File Offset: 0x01136A37
		// (set) Token: 0x06046D10 RID: 290064 RVA: 0x0113883F File Offset: 0x01136A3F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string MainUIName
		{
			get
			{
				return this.mainUIName_;
			}
			set
			{
				this.mainUIName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011250 RID: 70224
		// (get) Token: 0x06046D11 RID: 290065 RVA: 0x01138852 File Offset: 0x01136A52
		// (set) Token: 0x06046D12 RID: 290066 RVA: 0x0113885A File Offset: 0x01136A5A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17011251 RID: 70225
		// (get) Token: 0x06046D13 RID: 290067 RVA: 0x01138863 File Offset: 0x01136A63
		// (set) Token: 0x06046D14 RID: 290068 RVA: 0x0113886B File Offset: 0x01136A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapType
		{
			get
			{
				return this.mapType_;
			}
			set
			{
				this.mapType_ = value;
			}
		}

		// Token: 0x06046D15 RID: 290069 RVA: 0x01138874 File Offset: 0x01136A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingMapTable);
		}

		// Token: 0x06046D16 RID: 290070 RVA: 0x01138884 File Offset: 0x01136A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingMapTable other)
		{
			return other != null && (other == this || (this.FishPoolGroupId == other.FishPoolGroupId && this.GroupId == other.GroupId && this.Id == other.Id && !(this.MainUIName != other.MainUIName) && this.MapId == other.MapId && this.MapType == other.MapType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046D17 RID: 290071 RVA: 0x01138914 File Offset: 0x01136B14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FishPoolGroupId != 0)
			{
				num ^= this.FishPoolGroupId.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MainUIName.Length != 0)
			{
				num ^= this.MainUIName.GetHashCode();
			}
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.MapType != 0)
			{
				num ^= this.MapType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046D18 RID: 290072 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046D19 RID: 290073 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046D1A RID: 290074 RVA: 0x011389D4 File Offset: 0x01136BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FishPoolGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FishPoolGroupId);
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
			if (this.MainUIName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.MainUIName);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MapId);
			}
			if (this.MapType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MapType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046D1B RID: 290075 RVA: 0x01138AA4 File Offset: 0x01136CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FishPoolGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishPoolGroupId);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MainUIName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MainUIName);
			}
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this.MapType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046D1C RID: 290076 RVA: 0x01138B60 File Offset: 0x01136D60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingMapTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FishPoolGroupId != 0)
			{
				this.FishPoolGroupId = other.FishPoolGroupId;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MainUIName.Length != 0)
			{
				this.MainUIName = other.MainUIName;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			if (other.MapType != 0)
			{
				this.MapType = other.MapType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046D1D RID: 290077 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046D1E RID: 290078 RVA: 0x01138C08 File Offset: 0x01136E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.FishPoolGroupId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.MainUIName = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.MapType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EB30 RID: 191280
		private static readonly MessageParser<FishingMapTable> _parser = new MessageParser<FishingMapTable>(() => new FishingMapTable());

		// Token: 0x0402EB31 RID: 191281
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EB32 RID: 191282
		public const int FishPoolGroupIdFieldNumber = 1;

		// Token: 0x0402EB33 RID: 191283
		private int fishPoolGroupId_;

		// Token: 0x0402EB34 RID: 191284
		public const int GroupIdFieldNumber = 2;

		// Token: 0x0402EB35 RID: 191285
		private int groupId_;

		// Token: 0x0402EB36 RID: 191286
		public const int IdFieldNumber = 3;

		// Token: 0x0402EB37 RID: 191287
		private int id_;

		// Token: 0x0402EB38 RID: 191288
		public const int MainUINameFieldNumber = 4;

		// Token: 0x0402EB39 RID: 191289
		private string mainUIName_ = "";

		// Token: 0x0402EB3A RID: 191290
		public const int MapIdFieldNumber = 5;

		// Token: 0x0402EB3B RID: 191291
		private int mapId_;

		// Token: 0x0402EB3C RID: 191292
		public const int MapTypeFieldNumber = 6;

		// Token: 0x0402EB3D RID: 191293
		private int mapType_;
	}
}
