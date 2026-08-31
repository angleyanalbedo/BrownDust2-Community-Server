using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020045E8 RID: 17896
	public sealed class IdCardInfo : IMessage<IdCardInfo>, IMessage, IEquatable<IdCardInfo>, IDeepCloneable<IdCardInfo>, IBufferMessage
	{
		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x0601BEAC RID: 114348 RVA: 0x007DAC8F File Offset: 0x007D8E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IdCardInfo> Parser
		{
			get
			{
				return IdCardInfo._parser;
			}
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0601BEAD RID: 114349 RVA: 0x007DAC96 File Offset: 0x007D8E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IdCardInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0601BEAE RID: 114350 RVA: 0x007DACA8 File Offset: 0x007D8EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IdCardInfo.Descriptor;
			}
		}

		// Token: 0x0601BEAF RID: 114351 RVA: 0x007DACAF File Offset: 0x007D8EAF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardInfo()
		{
		}

		// Token: 0x0601BEB0 RID: 114352 RVA: 0x007DACC4 File Offset: 0x007D8EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IdCardInfo(IdCardInfo other)
			: this()
		{
			this.background_ = ((other.background_ != null) ? other.background_.Clone() : null);
			this.subBackground_ = ((other.subBackground_ != null) ? other.subBackground_.Clone() : null);
			this.backgroundEffect_ = ((other.backgroundEffect_ != null) ? other.backgroundEffect_.Clone() : null);
			this.stickers_ = other.stickers_.Clone();
			this.myInfo_ = ((other.myInfo_ != null) ? other.myInfo_.Clone() : null);
			this.rotate_ = other.rotate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEB1 RID: 114353 RVA: 0x007DAD75 File Offset: 0x007D8F75
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardInfo Clone()
		{
			return new IdCardInfo(this);
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0601BEB2 RID: 114354 RVA: 0x007DAD7D File Offset: 0x007D8F7D
		// (set) Token: 0x0601BEB3 RID: 114355 RVA: 0x007DAD85 File Offset: 0x007D8F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IdCardItemInfo Background
		{
			get
			{
				return this.background_;
			}
			set
			{
				this.background_ = value;
			}
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x0601BEB4 RID: 114356 RVA: 0x007DAD8E File Offset: 0x007D8F8E
		// (set) Token: 0x0601BEB5 RID: 114357 RVA: 0x007DAD96 File Offset: 0x007D8F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IdCardItemInfo SubBackground
		{
			get
			{
				return this.subBackground_;
			}
			set
			{
				this.subBackground_ = value;
			}
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x0601BEB6 RID: 114358 RVA: 0x007DAD9F File Offset: 0x007D8F9F
		// (set) Token: 0x0601BEB7 RID: 114359 RVA: 0x007DADA7 File Offset: 0x007D8FA7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public IdCardItemInfo BackgroundEffect
		{
			get
			{
				return this.backgroundEffect_;
			}
			set
			{
				this.backgroundEffect_ = value;
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x0601BEB8 RID: 114360 RVA: 0x007DADB0 File Offset: 0x007D8FB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<IdCardItemInfo> Stickers
		{
			get
			{
				return this.stickers_;
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x0601BEB9 RID: 114361 RVA: 0x007DADB8 File Offset: 0x007D8FB8
		// (set) Token: 0x0601BEBA RID: 114362 RVA: 0x007DADC0 File Offset: 0x007D8FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IdCardItemInfo MyInfo
		{
			get
			{
				return this.myInfo_;
			}
			set
			{
				this.myInfo_ = value;
			}
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x0601BEBB RID: 114363 RVA: 0x007DADC9 File Offset: 0x007D8FC9
		// (set) Token: 0x0601BEBC RID: 114364 RVA: 0x007DADD1 File Offset: 0x007D8FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0601BEBD RID: 114365 RVA: 0x007DADDA File Offset: 0x007D8FDA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IdCardInfo);
		}

		// Token: 0x0601BEBE RID: 114366 RVA: 0x007DADE8 File Offset: 0x007D8FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IdCardInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Background, other.Background) && object.Equals(this.SubBackground, other.SubBackground) && object.Equals(this.BackgroundEffect, other.BackgroundEffect) && this.stickers_.Equals(other.stickers_) && object.Equals(this.MyInfo, other.MyInfo) && this.Rotate == other.Rotate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEBF RID: 114367 RVA: 0x007DAE8C File Offset: 0x007D908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.background_ != null)
			{
				num ^= this.Background.GetHashCode();
			}
			if (this.subBackground_ != null)
			{
				num ^= this.SubBackground.GetHashCode();
			}
			if (this.backgroundEffect_ != null)
			{
				num ^= this.BackgroundEffect.GetHashCode();
			}
			num ^= this.stickers_.GetHashCode();
			if (this.myInfo_ != null)
			{
				num ^= this.MyInfo.GetHashCode();
			}
			if (this.Rotate != 0)
			{
				num ^= this.Rotate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BEC0 RID: 114368 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BEC1 RID: 114369 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEC2 RID: 114370 RVA: 0x007DAF34 File Offset: 0x007D9134
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.background_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Background);
			}
			if (this.subBackground_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SubBackground);
			}
			if (this.backgroundEffect_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BackgroundEffect);
			}
			this.stickers_.WriteTo(ref output, IdCardInfo._repeated_stickers_codec);
			if (this.myInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.MyInfo);
			}
			if (this.Rotate != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Rotate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEC3 RID: 114371 RVA: 0x007DAFF4 File Offset: 0x007D91F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.background_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Background);
			}
			if (this.subBackground_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubBackground);
			}
			if (this.backgroundEffect_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BackgroundEffect);
			}
			num += this.stickers_.CalculateSize(IdCardInfo._repeated_stickers_codec);
			if (this.myInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MyInfo);
			}
			if (this.Rotate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rotate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BEC4 RID: 114372 RVA: 0x007DB0A8 File Offset: 0x007D92A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IdCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.background_ != null)
			{
				if (this.background_ == null)
				{
					this.Background = new IdCardItemInfo();
				}
				this.Background.MergeFrom(other.Background);
			}
			if (other.subBackground_ != null)
			{
				if (this.subBackground_ == null)
				{
					this.SubBackground = new IdCardItemInfo();
				}
				this.SubBackground.MergeFrom(other.SubBackground);
			}
			if (other.backgroundEffect_ != null)
			{
				if (this.backgroundEffect_ == null)
				{
					this.BackgroundEffect = new IdCardItemInfo();
				}
				this.BackgroundEffect.MergeFrom(other.BackgroundEffect);
			}
			this.stickers_.Add(other.stickers_);
			if (other.myInfo_ != null)
			{
				if (this.myInfo_ == null)
				{
					this.MyInfo = new IdCardItemInfo();
				}
				this.MyInfo.MergeFrom(other.MyInfo);
			}
			if (other.Rotate != 0)
			{
				this.Rotate = other.Rotate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BEC5 RID: 114373 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEC6 RID: 114374 RVA: 0x007DB1A8 File Offset: 0x007D93A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 10U)
					{
						if (this.background_ == null)
						{
							this.Background = new IdCardItemInfo();
						}
						input.ReadMessage(this.Background);
						continue;
					}
					if (num == 18U)
					{
						if (this.subBackground_ == null)
						{
							this.SubBackground = new IdCardItemInfo();
						}
						input.ReadMessage(this.SubBackground);
						continue;
					}
					if (num == 26U)
					{
						if (this.backgroundEffect_ == null)
						{
							this.BackgroundEffect = new IdCardItemInfo();
						}
						input.ReadMessage(this.BackgroundEffect);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.stickers_.AddEntriesFrom(ref input, IdCardInfo._repeated_stickers_codec);
						continue;
					}
					if (num == 42U)
					{
						if (this.myInfo_ == null)
						{
							this.MyInfo = new IdCardItemInfo();
						}
						input.ReadMessage(this.MyInfo);
						continue;
					}
					if (num == 48U)
					{
						this.Rotate = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<IdCardInfo> _parser = new MessageParser<IdCardInfo>(() => new IdCardInfo());

		// Token: 0x040157C2 RID: 88002
		private UnknownFieldSet _unknownFields;

		// Token: 0x040157C3 RID: 88003
		public const int BackgroundFieldNumber = 1;

		// Token: 0x040157C4 RID: 88004
		private IdCardItemInfo background_;

		// Token: 0x040157C5 RID: 88005
		public const int SubBackgroundFieldNumber = 2;

		// Token: 0x040157C6 RID: 88006
		private IdCardItemInfo subBackground_;

		// Token: 0x040157C7 RID: 88007
		public const int BackgroundEffectFieldNumber = 3;

		// Token: 0x040157C8 RID: 88008
		private IdCardItemInfo backgroundEffect_;

		// Token: 0x040157C9 RID: 88009
		public const int StickersFieldNumber = 4;

		// Token: 0x040157CA RID: 88010
		private static readonly FieldCodec<IdCardItemInfo> _repeated_stickers_codec = FieldCodec.ForMessage<IdCardItemInfo>(34U, IdCardItemInfo.Parser);

		// Token: 0x040157CB RID: 88011
		private readonly RepeatedField<IdCardItemInfo> stickers_ = new RepeatedField<IdCardItemInfo>();

		// Token: 0x040157CC RID: 88012
		public const int MyInfoFieldNumber = 5;

		// Token: 0x040157CD RID: 88013
		private IdCardItemInfo myInfo_;

		// Token: 0x040157CE RID: 88014
		public const int RotateFieldNumber = 6;

		// Token: 0x040157CF RID: 88015
		private int rotate_;
	}
}
