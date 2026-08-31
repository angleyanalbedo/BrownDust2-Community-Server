using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200477C RID: 18300
	public sealed class SpineInteractionAchievementPointDBInfo : IMessage<SpineInteractionAchievementPointDBInfo>, IMessage, IEquatable<SpineInteractionAchievementPointDBInfo>, IDeepCloneable<SpineInteractionAchievementPointDBInfo>, IBufferMessage
	{
		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0601CEA0 RID: 118432 RVA: 0x00805B40 File Offset: 0x00803D40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SpineInteractionAchievementPointDBInfo> Parser
		{
			get
			{
				return SpineInteractionAchievementPointDBInfo._parser;
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0601CEA1 RID: 118433 RVA: 0x00805B47 File Offset: 0x00803D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpineInteractionAchievementDBInfoReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0601CEA2 RID: 118434 RVA: 0x00805B59 File Offset: 0x00803D59
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpineInteractionAchievementPointDBInfo.Descriptor;
			}
		}

		// Token: 0x0601CEA3 RID: 118435 RVA: 0x00805B60 File Offset: 0x00803D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpineInteractionAchievementPointDBInfo()
		{
		}

		// Token: 0x0601CEA4 RID: 118436 RVA: 0x00805B73 File Offset: 0x00803D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpineInteractionAchievementPointDBInfo(SpineInteractionAchievementPointDBInfo other)
			: this()
		{
			this.pointId_ = other.pointId_;
			this.motionId_ = other.motionId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CEA5 RID: 118437 RVA: 0x00805BA9 File Offset: 0x00803DA9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SpineInteractionAchievementPointDBInfo Clone()
		{
			return new SpineInteractionAchievementPointDBInfo(this);
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0601CEA6 RID: 118438 RVA: 0x00805BB1 File Offset: 0x00803DB1
		// (set) Token: 0x0601CEA7 RID: 118439 RVA: 0x00805BB9 File Offset: 0x00803DB9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PointId
		{
			get
			{
				return this.pointId_;
			}
			set
			{
				this.pointId_ = value;
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0601CEA8 RID: 118440 RVA: 0x00805BC2 File Offset: 0x00803DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MotionId
		{
			get
			{
				return this.motionId_;
			}
		}

		// Token: 0x0601CEA9 RID: 118441 RVA: 0x00805BCA File Offset: 0x00803DCA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpineInteractionAchievementPointDBInfo);
		}

		// Token: 0x0601CEAA RID: 118442 RVA: 0x00805BD8 File Offset: 0x00803DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpineInteractionAchievementPointDBInfo other)
		{
			return other != null && (other == this || (this.PointId == other.PointId && this.motionId_.Equals(other.motionId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEAB RID: 118443 RVA: 0x00805C28 File Offset: 0x00803E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PointId != 0)
			{
				num ^= this.PointId.GetHashCode();
			}
			num ^= this.motionId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CEAC RID: 118444 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601CEAD RID: 118445 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CEAE RID: 118446 RVA: 0x00805C78 File Offset: 0x00803E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PointId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PointId);
			}
			this.motionId_.WriteTo(ref output, SpineInteractionAchievementPointDBInfo._repeated_motionId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CEAF RID: 118447 RVA: 0x00805CC8 File Offset: 0x00803EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PointId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PointId);
			}
			num += this.motionId_.CalculateSize(SpineInteractionAchievementPointDBInfo._repeated_motionId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CEB0 RID: 118448 RVA: 0x00805D1C File Offset: 0x00803F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpineInteractionAchievementPointDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PointId != 0)
			{
				this.PointId = other.PointId;
			}
			this.motionId_.Add(other.motionId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CEB1 RID: 118449 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CEB2 RID: 118450 RVA: 0x00805D6C File Offset: 0x00803F6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.motionId_.AddEntriesFrom(ref input, SpineInteractionAchievementPointDBInfo._repeated_motionId_codec);
					}
				}
				else
				{
					this.PointId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<SpineInteractionAchievementPointDBInfo> _parser = new MessageParser<SpineInteractionAchievementPointDBInfo>(() => new SpineInteractionAchievementPointDBInfo());

		// Token: 0x040160FD RID: 90365
		private UnknownFieldSet _unknownFields;

		// Token: 0x040160FE RID: 90366
		public const int PointIdFieldNumber = 1;

		// Token: 0x040160FF RID: 90367
		private int pointId_;

		// Token: 0x04016100 RID: 90368
		public const int MotionIdFieldNumber = 2;

		// Token: 0x04016101 RID: 90369
		private static readonly FieldCodec<int> _repeated_motionId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04016102 RID: 90370
		private readonly RepeatedField<int> motionId_ = new RepeatedField<int>();
	}
}
