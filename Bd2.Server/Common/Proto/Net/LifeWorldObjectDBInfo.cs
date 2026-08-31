using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200461F RID: 17951
	public sealed class LifeWorldObjectDBInfo : IMessage<LifeWorldObjectDBInfo>, IMessage, IEquatable<LifeWorldObjectDBInfo>, IDeepCloneable<LifeWorldObjectDBInfo>, IBufferMessage
	{
		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0601C0CF RID: 114895 RVA: 0x007E076C File Offset: 0x007DE96C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LifeWorldObjectDBInfo> Parser
		{
			get
			{
				return LifeWorldObjectDBInfo._parser;
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0601C0D0 RID: 114896 RVA: 0x007E0773 File Offset: 0x007DE973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeWorldObjectDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0601C0D1 RID: 114897 RVA: 0x007E0785 File Offset: 0x007DE985
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeWorldObjectDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C0D2 RID: 114898 RVA: 0x007E078C File Offset: 0x007DE98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeWorldObjectDBInfo()
		{
		}

		// Token: 0x0601C0D3 RID: 114899 RVA: 0x007E07A0 File Offset: 0x007DE9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeWorldObjectDBInfo(LifeWorldObjectDBInfo other)
			: this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.rotate_ = other.rotate_;
			this.index_ = other.index_;
			this.objectId_ = other.objectId_;
			this.status_ = other.status_;
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this.innerObject_ = other.innerObject_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0D4 RID: 114900 RVA: 0x007E0835 File Offset: 0x007DEA35
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeWorldObjectDBInfo Clone()
		{
			return new LifeWorldObjectDBInfo(this);
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x0601C0D5 RID: 114901 RVA: 0x007E083D File Offset: 0x007DEA3D
		// (set) Token: 0x0601C0D6 RID: 114902 RVA: 0x007E0845 File Offset: 0x007DEA45
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x0601C0D7 RID: 114903 RVA: 0x007E084E File Offset: 0x007DEA4E
		// (set) Token: 0x0601C0D8 RID: 114904 RVA: 0x007E0856 File Offset: 0x007DEA56
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0601C0D9 RID: 114905 RVA: 0x007E085F File Offset: 0x007DEA5F
		// (set) Token: 0x0601C0DA RID: 114906 RVA: 0x007E0867 File Offset: 0x007DEA67
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Rotate
		{
			get
			{
				return this.rotate_;
			}
			set
			{
				this.rotate_ = value;
			}
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0601C0DB RID: 114907 RVA: 0x007E0870 File Offset: 0x007DEA70
		// (set) Token: 0x0601C0DC RID: 114908 RVA: 0x007E0878 File Offset: 0x007DEA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0601C0DD RID: 114909 RVA: 0x007E0881 File Offset: 0x007DEA81
		// (set) Token: 0x0601C0DE RID: 114910 RVA: 0x007E0889 File Offset: 0x007DEA89
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectId
		{
			get
			{
				return this.objectId_;
			}
			set
			{
				this.objectId_ = value;
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0601C0DF RID: 114911 RVA: 0x007E0892 File Offset: 0x007DEA92
		// (set) Token: 0x0601C0E0 RID: 114912 RVA: 0x007E089A File Offset: 0x007DEA9A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0601C0E1 RID: 114913 RVA: 0x007E08A3 File Offset: 0x007DEAA3
		// (set) Token: 0x0601C0E2 RID: 114914 RVA: 0x007E08AB File Offset: 0x007DEAAB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0601C0E3 RID: 114915 RVA: 0x007E08B4 File Offset: 0x007DEAB4
		// (set) Token: 0x0601C0E4 RID: 114916 RVA: 0x007E08BC File Offset: 0x007DEABC
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

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0601C0E5 RID: 114917 RVA: 0x007E08C5 File Offset: 0x007DEAC5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<LifeWorldObjectDBInfo> InnerObject
		{
			get
			{
				return this.innerObject_;
			}
		}

		// Token: 0x0601C0E6 RID: 114918 RVA: 0x007E08CD File Offset: 0x007DEACD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeWorldObjectDBInfo);
		}

		// Token: 0x0601C0E7 RID: 114919 RVA: 0x007E08DC File Offset: 0x007DEADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifeWorldObjectDBInfo other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && this.Rotate == other.Rotate && this.Index == other.Index && this.ObjectId == other.ObjectId && this.Status == other.Status && this.StartTime == other.StartTime && this.EndTime == other.EndTime && this.innerObject_.Equals(other.innerObject_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0E8 RID: 114920 RVA: 0x007E099C File Offset: 0x007DEB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this.Rotate != 0)
			{
				num ^= this.Rotate.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.ObjectId != 0)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.innerObject_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0E9 RID: 114921 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C0EA RID: 114922 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0EB RID: 114923 RVA: 0x007E0A98 File Offset: 0x007DEC98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Y);
			}
			if (this.Rotate != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Rotate);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			if (this.ObjectId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ObjectId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Status);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EndTime);
			}
			this.innerObject_.WriteTo(ref output, LifeWorldObjectDBInfo._repeated_innerObject_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0EC RID: 114924 RVA: 0x007E0BAC File Offset: 0x007DEDAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this.Rotate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rotate);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.ObjectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ObjectId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.innerObject_.CalculateSize(LifeWorldObjectDBInfo._repeated_innerObject_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0ED RID: 114925 RVA: 0x007E0CA8 File Offset: 0x007DEEA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(LifeWorldObjectDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			if (other.Rotate != 0)
			{
				this.Rotate = other.Rotate;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.ObjectId != 0)
			{
				this.ObjectId = other.ObjectId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.innerObject_.Add(other.innerObject_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0EE RID: 114926 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0EF RID: 114927 RVA: 0x007E0D84 File Offset: 0x007DEF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.X = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Y = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Rotate = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Index = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.ObjectId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Status = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 82U)
					{
						this.innerObject_.AddEntriesFrom(ref input, LifeWorldObjectDBInfo._repeated_innerObject_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<LifeWorldObjectDBInfo> _parser = new MessageParser<LifeWorldObjectDBInfo>(() => new LifeWorldObjectDBInfo());

		// Token: 0x040158A6 RID: 88230
		private UnknownFieldSet _unknownFields;

		// Token: 0x040158A7 RID: 88231
		public const int XFieldNumber = 1;

		// Token: 0x040158A8 RID: 88232
		private int x_;

		// Token: 0x040158A9 RID: 88233
		public const int YFieldNumber = 2;

		// Token: 0x040158AA RID: 88234
		private int y_;

		// Token: 0x040158AB RID: 88235
		public const int RotateFieldNumber = 3;

		// Token: 0x040158AC RID: 88236
		private int rotate_;

		// Token: 0x040158AD RID: 88237
		public const int IndexFieldNumber = 4;

		// Token: 0x040158AE RID: 88238
		private int index_;

		// Token: 0x040158AF RID: 88239
		public const int ObjectIdFieldNumber = 6;

		// Token: 0x040158B0 RID: 88240
		private int objectId_;

		// Token: 0x040158B1 RID: 88241
		public const int StatusFieldNumber = 7;

		// Token: 0x040158B2 RID: 88242
		private int status_;

		// Token: 0x040158B3 RID: 88243
		public const int StartTimeFieldNumber = 8;

		// Token: 0x040158B4 RID: 88244
		private long startTime_;

		// Token: 0x040158B5 RID: 88245
		public const int EndTimeFieldNumber = 9;

		// Token: 0x040158B6 RID: 88246
		private long endTime_;

		// Token: 0x040158B7 RID: 88247
		public const int InnerObjectFieldNumber = 10;

		// Token: 0x040158B8 RID: 88248
		private static readonly FieldCodec<LifeWorldObjectDBInfo> _repeated_innerObject_codec = FieldCodec.ForMessage<LifeWorldObjectDBInfo>(82U, LifeWorldObjectDBInfo.Parser);

		// Token: 0x040158B9 RID: 88249
		private readonly RepeatedField<LifeWorldObjectDBInfo> innerObject_ = new RepeatedField<LifeWorldObjectDBInfo>();
	}
}
