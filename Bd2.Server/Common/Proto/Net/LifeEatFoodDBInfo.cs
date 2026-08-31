using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200460A RID: 17930
	public sealed class LifeEatFoodDBInfo : IMessage<LifeEatFoodDBInfo>, IMessage, IEquatable<LifeEatFoodDBInfo>, IDeepCloneable<LifeEatFoodDBInfo>, IBufferMessage
	{
		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0601C009 RID: 114697 RVA: 0x007DE8A0 File Offset: 0x007DCAA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LifeEatFoodDBInfo> Parser
		{
			get
			{
				return LifeEatFoodDBInfo._parser;
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0601C00A RID: 114698 RVA: 0x007DE8A7 File Offset: 0x007DCAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeEatFoodDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0601C00B RID: 114699 RVA: 0x007DE8B9 File Offset: 0x007DCAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeEatFoodDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C00C RID: 114700 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeEatFoodDBInfo()
		{
		}

		// Token: 0x0601C00D RID: 114701 RVA: 0x007DE8C0 File Offset: 0x007DCAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeEatFoodDBInfo(LifeEatFoodDBInfo other)
			: this()
		{
			this.itemId_ = other.itemId_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C00E RID: 114702 RVA: 0x007DE8F1 File Offset: 0x007DCAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeEatFoodDBInfo Clone()
		{
			return new LifeEatFoodDBInfo(this);
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0601C00F RID: 114703 RVA: 0x007DE8F9 File Offset: 0x007DCAF9
		// (set) Token: 0x0601C010 RID: 114704 RVA: 0x007DE901 File Offset: 0x007DCB01
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x0601C011 RID: 114705 RVA: 0x007DE90A File Offset: 0x007DCB0A
		// (set) Token: 0x0601C012 RID: 114706 RVA: 0x007DE912 File Offset: 0x007DCB12
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x0601C013 RID: 114707 RVA: 0x007DE91B File Offset: 0x007DCB1B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeEatFoodDBInfo);
		}

		// Token: 0x0601C014 RID: 114708 RVA: 0x007DE929 File Offset: 0x007DCB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifeEatFoodDBInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C015 RID: 114709 RVA: 0x007DE968 File Offset: 0x007DCB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C016 RID: 114710 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C017 RID: 114711 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C018 RID: 114712 RVA: 0x007DE9C0 File Offset: 0x007DCBC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C019 RID: 114713 RVA: 0x007DEA18 File Offset: 0x007DCC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C01A RID: 114714 RVA: 0x007DEA70 File Offset: 0x007DCC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeEatFoodDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C01B RID: 114715 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C01C RID: 114716 RVA: 0x007DEAC0 File Offset: 0x007DCCC0
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
						this.EndTime = input.ReadInt64();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<LifeEatFoodDBInfo> _parser = new MessageParser<LifeEatFoodDBInfo>(() => new LifeEatFoodDBInfo());

		// Token: 0x0401585A RID: 88154
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401585B RID: 88155
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0401585C RID: 88156
		private int itemId_;

		// Token: 0x0401585D RID: 88157
		public const int EndTimeFieldNumber = 2;

		// Token: 0x0401585E RID: 88158
		private long endTime_;
	}
}
