using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004656 RID: 18006
	public sealed class MiniGameHubDBInfo : IMessage<MiniGameHubDBInfo>, IMessage, IEquatable<MiniGameHubDBInfo>, IDeepCloneable<MiniGameHubDBInfo>, IBufferMessage
	{
		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x0601C31F RID: 115487 RVA: 0x007E6CD0 File Offset: 0x007E4ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniGameHubDBInfo> Parser
		{
			get
			{
				return MiniGameHubDBInfo._parser;
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x0601C320 RID: 115488 RVA: 0x007E6CD7 File Offset: 0x007E4ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniGameHubDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x0601C321 RID: 115489 RVA: 0x007E6CE9 File Offset: 0x007E4EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniGameHubDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C322 RID: 115490 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniGameHubDBInfo()
		{
		}

		// Token: 0x0601C323 RID: 115491 RVA: 0x007E6CF0 File Offset: 0x007E4EF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MiniGameHubDBInfo(MiniGameHubDBInfo other)
			: this()
		{
			this.slot_ = other.slot_;
			this.eventUid_ = other.eventUid_;
			this.progressType_ = other.progressType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C324 RID: 115492 RVA: 0x007E6D2D File Offset: 0x007E4F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameHubDBInfo Clone()
		{
			return new MiniGameHubDBInfo(this);
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x0601C325 RID: 115493 RVA: 0x007E6D35 File Offset: 0x007E4F35
		// (set) Token: 0x0601C326 RID: 115494 RVA: 0x007E6D3D File Offset: 0x007E4F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x0601C327 RID: 115495 RVA: 0x007E6D46 File Offset: 0x007E4F46
		// (set) Token: 0x0601C328 RID: 115496 RVA: 0x007E6D4E File Offset: 0x007E4F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventUid
		{
			get
			{
				return this.eventUid_;
			}
			set
			{
				this.eventUid_ = value;
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0601C329 RID: 115497 RVA: 0x007E6D57 File Offset: 0x007E4F57
		// (set) Token: 0x0601C32A RID: 115498 RVA: 0x007E6D5F File Offset: 0x007E4F5F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ProgressType
		{
			get
			{
				return this.progressType_;
			}
			set
			{
				this.progressType_ = value;
			}
		}

		// Token: 0x0601C32B RID: 115499 RVA: 0x007E6D68 File Offset: 0x007E4F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniGameHubDBInfo);
		}

		// Token: 0x0601C32C RID: 115500 RVA: 0x007E6D78 File Offset: 0x007E4F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniGameHubDBInfo other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && this.EventUid == other.EventUid && this.ProgressType == other.ProgressType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C32D RID: 115501 RVA: 0x007E6DD4 File Offset: 0x007E4FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.EventUid != 0)
			{
				num ^= this.EventUid.GetHashCode();
			}
			if (this.ProgressType != 0)
			{
				num ^= this.ProgressType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C32E RID: 115502 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C32F RID: 115503 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C330 RID: 115504 RVA: 0x007E6E48 File Offset: 0x007E5048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Slot);
			}
			if (this.EventUid != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventUid);
			}
			if (this.ProgressType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ProgressType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C331 RID: 115505 RVA: 0x007E6EBC File Offset: 0x007E50BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Slot);
			}
			if (this.EventUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventUid);
			}
			if (this.ProgressType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProgressType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C332 RID: 115506 RVA: 0x007E6F2C File Offset: 0x007E512C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(MiniGameHubDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0)
			{
				this.Slot = other.Slot;
			}
			if (other.EventUid != 0)
			{
				this.EventUid = other.EventUid;
			}
			if (other.ProgressType != 0)
			{
				this.ProgressType = other.ProgressType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C333 RID: 115507 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C334 RID: 115508 RVA: 0x007E6F90 File Offset: 0x007E5190
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
							this.ProgressType = input.ReadInt32();
						}
					}
					else
					{
						this.EventUid = input.ReadInt32();
					}
				}
				else
				{
					this.Slot = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<MiniGameHubDBInfo> _parser = new MessageParser<MiniGameHubDBInfo>(() => new MiniGameHubDBInfo());

		// Token: 0x040159AC RID: 88492
		private UnknownFieldSet _unknownFields;

		// Token: 0x040159AD RID: 88493
		public const int SlotFieldNumber = 1;

		// Token: 0x040159AE RID: 88494
		private int slot_;

		// Token: 0x040159AF RID: 88495
		public const int EventUidFieldNumber = 2;

		// Token: 0x040159B0 RID: 88496
		private int eventUid_;

		// Token: 0x040159B1 RID: 88497
		public const int ProgressTypeFieldNumber = 3;

		// Token: 0x040159B2 RID: 88498
		private int progressType_;
	}
}
