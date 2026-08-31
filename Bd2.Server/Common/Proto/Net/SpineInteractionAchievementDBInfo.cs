using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200477A RID: 18298
	public sealed class SpineInteractionAchievementDBInfo : IMessage<SpineInteractionAchievementDBInfo>, IMessage, IEquatable<SpineInteractionAchievementDBInfo>, IDeepCloneable<SpineInteractionAchievementDBInfo>, IBufferMessage
	{
		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0601CE84 RID: 118404 RVA: 0x00805660 File Offset: 0x00803860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpineInteractionAchievementDBInfo> Parser
		{
			get
			{
				return SpineInteractionAchievementDBInfo._parser;
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0601CE85 RID: 118405 RVA: 0x00805667 File Offset: 0x00803867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpineInteractionAchievementDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0601CE86 RID: 118406 RVA: 0x00805679 File Offset: 0x00803879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpineInteractionAchievementDBInfo.Descriptor;
			}
		}

		// Token: 0x0601CE87 RID: 118407 RVA: 0x00805680 File Offset: 0x00803880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpineInteractionAchievementDBInfo()
		{
		}

		// Token: 0x0601CE88 RID: 118408 RVA: 0x008056A0 File Offset: 0x008038A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SpineInteractionAchievementDBInfo(SpineInteractionAchievementDBInfo other)
			: this()
		{
			this.interactionGroupId_ = other.interactionGroupId_;
			this.groupId_ = other.groupId_;
			this.pointInfo_ = other.pointInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CE89 RID: 118409 RVA: 0x008056ED File Offset: 0x008038ED
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SpineInteractionAchievementDBInfo Clone()
		{
			return new SpineInteractionAchievementDBInfo(this);
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0601CE8A RID: 118410 RVA: 0x008056F5 File Offset: 0x008038F5
		// (set) Token: 0x0601CE8B RID: 118411 RVA: 0x008056FD File Offset: 0x008038FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InteractionGroupId
		{
			get
			{
				return this.interactionGroupId_;
			}
			set
			{
				this.interactionGroupId_ = value;
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0601CE8C RID: 118412 RVA: 0x00805706 File Offset: 0x00803906
		// (set) Token: 0x0601CE8D RID: 118413 RVA: 0x0080570E File Offset: 0x0080390E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0601CE8E RID: 118414 RVA: 0x00805717 File Offset: 0x00803917
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<SpineInteractionAchievementPointDBInfo> PointInfo
		{
			get
			{
				return this.pointInfo_;
			}
		}

		// Token: 0x0601CE8F RID: 118415 RVA: 0x0080571F File Offset: 0x0080391F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpineInteractionAchievementDBInfo);
		}

		// Token: 0x0601CE90 RID: 118416 RVA: 0x00805730 File Offset: 0x00803930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpineInteractionAchievementDBInfo other)
		{
			return other != null && (other == this || (this.InteractionGroupId == other.InteractionGroupId && this.GroupId == other.GroupId && this.pointInfo_.Equals(other.pointInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE91 RID: 118417 RVA: 0x00805790 File Offset: 0x00803990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractionGroupId != 0)
			{
				num ^= this.InteractionGroupId.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			num ^= this.pointInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CE92 RID: 118418 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601CE93 RID: 118419 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE94 RID: 118420 RVA: 0x008057F8 File Offset: 0x008039F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractionGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InteractionGroupId);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupId);
			}
			this.pointInfo_.WriteTo(ref output, SpineInteractionAchievementDBInfo._repeated_pointInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CE95 RID: 118421 RVA: 0x00805864 File Offset: 0x00803A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractionGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InteractionGroupId);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			num += this.pointInfo_.CalculateSize(SpineInteractionAchievementDBInfo._repeated_pointInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CE96 RID: 118422 RVA: 0x008058D0 File Offset: 0x00803AD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(SpineInteractionAchievementDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractionGroupId != 0)
			{
				this.InteractionGroupId = other.InteractionGroupId;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			this.pointInfo_.Add(other.pointInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CE97 RID: 118423 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE98 RID: 118424 RVA: 0x00805934 File Offset: 0x00803B34
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.pointInfo_.AddEntriesFrom(ref input, SpineInteractionAchievementDBInfo._repeated_pointInfo_codec);
						}
					}
					else
					{
						this.GroupId = input.ReadInt32();
					}
				}
				else
				{
					this.InteractionGroupId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<SpineInteractionAchievementDBInfo> _parser = new MessageParser<SpineInteractionAchievementDBInfo>(() => new SpineInteractionAchievementDBInfo());

		// Token: 0x040160F2 RID: 90354
		private UnknownFieldSet _unknownFields;

		// Token: 0x040160F3 RID: 90355
		public const int InteractionGroupIdFieldNumber = 1;

		// Token: 0x040160F4 RID: 90356
		private int interactionGroupId_;

		// Token: 0x040160F5 RID: 90357
		public const int GroupIdFieldNumber = 2;

		// Token: 0x040160F6 RID: 90358
		private int groupId_;

		// Token: 0x040160F7 RID: 90359
		public const int PointInfoFieldNumber = 3;

		// Token: 0x040160F8 RID: 90360
		private static readonly FieldCodec<SpineInteractionAchievementPointDBInfo> _repeated_pointInfo_codec = FieldCodec.ForMessage<SpineInteractionAchievementPointDBInfo>(26U, SpineInteractionAchievementPointDBInfo.Parser);

		// Token: 0x040160F9 RID: 90361
		private readonly RepeatedField<SpineInteractionAchievementPointDBInfo> pointInfo_ = new RepeatedField<SpineInteractionAchievementPointDBInfo>();

		// Token: 0x040160FA RID: 90362
		public List<SpineInteractionAchievementPointDBInfo> NeedSavePointDBInfo = new List<SpineInteractionAchievementPointDBInfo>();
	}
}
