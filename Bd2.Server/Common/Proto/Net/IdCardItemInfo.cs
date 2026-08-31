using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020045EB RID: 17899
	public sealed class IdCardItemInfo : IMessage<IdCardItemInfo>, IMessage, IEquatable<IdCardItemInfo>, IDeepCloneable<IdCardItemInfo>, IBufferMessage
	{
		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0601BECD RID: 114381 RVA: 0x007DB3BF File Offset: 0x007D95BF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<IdCardItemInfo> Parser
		{
			get
			{
				return IdCardItemInfo._parser;
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0601BECE RID: 114382 RVA: 0x007DB3C6 File Offset: 0x007D95C6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IdCardItemInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x0601BECF RID: 114383 RVA: 0x007DB3D8 File Offset: 0x007D95D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IdCardItemInfo.Descriptor;
			}
		}

		// Token: 0x0601BED0 RID: 114384 RVA: 0x007DB3DF File Offset: 0x007D95DF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardItemInfo()
		{
		}

		// Token: 0x0601BED1 RID: 114385 RVA: 0x007DB3F4 File Offset: 0x007D95F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardItemInfo(IdCardItemInfo other)
			: this()
		{
			this.invenIndex_ = other.invenIndex_;
			this.id_ = other.id_;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.rotate_ = other.rotate_;
			this.scale_ = other.scale_;
			this.layer_ = other.layer_;
			this.color_ = other.color_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BED2 RID: 114386 RVA: 0x007DB478 File Offset: 0x007D9678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardItemInfo Clone()
		{
			return new IdCardItemInfo(this);
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x0601BED3 RID: 114387 RVA: 0x007DB480 File Offset: 0x007D9680
		// (set) Token: 0x0601BED4 RID: 114388 RVA: 0x007DB488 File Offset: 0x007D9688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long InvenIndex
		{
			get
			{
				return this.invenIndex_;
			}
			set
			{
				this.invenIndex_ = value;
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x0601BED5 RID: 114389 RVA: 0x007DB491 File Offset: 0x007D9691
		// (set) Token: 0x0601BED6 RID: 114390 RVA: 0x007DB499 File Offset: 0x007D9699
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

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x0601BED7 RID: 114391 RVA: 0x007DB4A2 File Offset: 0x007D96A2
		// (set) Token: 0x0601BED8 RID: 114392 RVA: 0x007DB4AA File Offset: 0x007D96AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x0601BED9 RID: 114393 RVA: 0x007DB4B3 File Offset: 0x007D96B3
		// (set) Token: 0x0601BEDA RID: 114394 RVA: 0x007DB4BB File Offset: 0x007D96BB
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

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0601BEDB RID: 114395 RVA: 0x007DB4C4 File Offset: 0x007D96C4
		// (set) Token: 0x0601BEDC RID: 114396 RVA: 0x007DB4CC File Offset: 0x007D96CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Rotate
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

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0601BEDD RID: 114397 RVA: 0x007DB4D5 File Offset: 0x007D96D5
		// (set) Token: 0x0601BEDE RID: 114398 RVA: 0x007DB4DD File Offset: 0x007D96DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Scale
		{
			get
			{
				return this.scale_;
			}
			set
			{
				this.scale_ = value;
			}
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0601BEDF RID: 114399 RVA: 0x007DB4E6 File Offset: 0x007D96E6
		// (set) Token: 0x0601BEE0 RID: 114400 RVA: 0x007DB4EE File Offset: 0x007D96EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Layer
		{
			get
			{
				return this.layer_;
			}
			set
			{
				this.layer_ = value;
			}
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0601BEE1 RID: 114401 RVA: 0x007DB4F7 File Offset: 0x007D96F7
		// (set) Token: 0x0601BEE2 RID: 114402 RVA: 0x007DB4FF File Offset: 0x007D96FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Color
		{
			get
			{
				return this.color_;
			}
			set
			{
				this.color_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601BEE3 RID: 114403 RVA: 0x007DB512 File Offset: 0x007D9712
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IdCardItemInfo);
		}

		// Token: 0x0601BEE4 RID: 114404 RVA: 0x007DB520 File Offset: 0x007D9720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IdCardItemInfo other)
		{
			return other != null && (other == this || (this.InvenIndex == other.InvenIndex && this.Id == other.Id && this.X == other.X && this.Y == other.Y && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Rotate, other.Rotate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Scale, other.Scale) && this.Layer == other.Layer && !(this.Color != other.Color) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEE5 RID: 114405 RVA: 0x007DB5E4 File Offset: 0x007D97E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InvenIndex != 0L)
			{
				num ^= this.InvenIndex.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this.Rotate != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Rotate);
			}
			if (this.Scale != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Scale);
			}
			if (this.Layer != 0)
			{
				num ^= this.Layer.GetHashCode();
			}
			if (this.Color.Length != 0)
			{
				num ^= this.Color.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BEE6 RID: 114406 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BEE7 RID: 114407 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEE8 RID: 114408 RVA: 0x007DB6E4 File Offset: 0x007D98E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InvenIndex != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.InvenIndex);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.X != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Y);
			}
			if (this.Rotate != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.Rotate);
			}
			if (this.Scale != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.Scale);
			}
			if (this.Layer != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Layer);
			}
			if (this.Color.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Color);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEE9 RID: 114409 RVA: 0x007DB7F4 File Offset: 0x007D99F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InvenIndex != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InvenIndex);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this.Rotate != 0f)
			{
				num += 5;
			}
			if (this.Scale != 0f)
			{
				num += 5;
			}
			if (this.Layer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Layer);
			}
			if (this.Color.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Color);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BEEA RID: 114410 RVA: 0x007DB8D4 File Offset: 0x007D9AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IdCardItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InvenIndex != 0L)
			{
				this.InvenIndex = other.InvenIndex;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			if (other.Rotate != 0f)
			{
				this.Rotate = other.Rotate;
			}
			if (other.Scale != 0f)
			{
				this.Scale = other.Scale;
			}
			if (other.Layer != 0)
			{
				this.Layer = other.Layer;
			}
			if (other.Color.Length != 0)
			{
				this.Color = other.Color;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BEEB RID: 114411 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEEC RID: 114412 RVA: 0x007DB9AC File Offset: 0x007D9BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
							this.InvenIndex = input.ReadInt64();
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
							this.X = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Y = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 53U)
				{
					if (num == 45U)
					{
						this.Rotate = input.ReadFloat();
						continue;
					}
					if (num == 53U)
					{
						this.Scale = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Layer = input.ReadInt32();
						continue;
					}
					if (num == 66U)
					{
						this.Color = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<IdCardItemInfo> _parser = new MessageParser<IdCardItemInfo>(() => new IdCardItemInfo());

		// Token: 0x040157D3 RID: 88019
		private UnknownFieldSet _unknownFields;

		// Token: 0x040157D4 RID: 88020
		public const int InvenIndexFieldNumber = 1;

		// Token: 0x040157D5 RID: 88021
		private long invenIndex_;

		// Token: 0x040157D6 RID: 88022
		public const int IdFieldNumber = 2;

		// Token: 0x040157D7 RID: 88023
		private int id_;

		// Token: 0x040157D8 RID: 88024
		public const int XFieldNumber = 3;

		// Token: 0x040157D9 RID: 88025
		private int x_;

		// Token: 0x040157DA RID: 88026
		public const int YFieldNumber = 4;

		// Token: 0x040157DB RID: 88027
		private int y_;

		// Token: 0x040157DC RID: 88028
		public const int RotateFieldNumber = 5;

		// Token: 0x040157DD RID: 88029
		private float rotate_;

		// Token: 0x040157DE RID: 88030
		public const int ScaleFieldNumber = 6;

		// Token: 0x040157DF RID: 88031
		private float scale_;

		// Token: 0x040157E0 RID: 88032
		public const int LayerFieldNumber = 7;

		// Token: 0x040157E1 RID: 88033
		private int layer_;

		// Token: 0x040157E2 RID: 88034
		public const int ColorFieldNumber = 8;

		// Token: 0x040157E3 RID: 88035
		private string color_ = "";
	}
}
