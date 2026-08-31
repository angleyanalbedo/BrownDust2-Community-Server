using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004752 RID: 18258
	public sealed class RoomChatBlockDBInfo : IMessage<RoomChatBlockDBInfo>, IMessage, IEquatable<RoomChatBlockDBInfo>, IDeepCloneable<RoomChatBlockDBInfo>, IBufferMessage
	{
		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0601CCDB RID: 117979 RVA: 0x008015C9 File Offset: 0x007FF7C9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<RoomChatBlockDBInfo> Parser
		{
			get
			{
				return RoomChatBlockDBInfo._parser;
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0601CCDC RID: 117980 RVA: 0x008015D0 File Offset: 0x007FF7D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RoomChatBlockDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0601CCDD RID: 117981 RVA: 0x008015E2 File Offset: 0x007FF7E2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoomChatBlockDBInfo.Descriptor;
			}
		}

		// Token: 0x0601CCDE RID: 117982 RVA: 0x008015E9 File Offset: 0x007FF7E9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RoomChatBlockDBInfo()
		{
		}

		// Token: 0x0601CCDF RID: 117983 RVA: 0x008015FC File Offset: 0x007FF7FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RoomChatBlockDBInfo(RoomChatBlockDBInfo other)
			: this()
		{
			this.targetOwnerIndex_ = other.targetOwnerIndex_;
			this.targetUserId_ = other.targetUserId_;
			this.blockDate_ = other.blockDate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CCE0 RID: 117984 RVA: 0x00801639 File Offset: 0x007FF839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoomChatBlockDBInfo Clone()
		{
			return new RoomChatBlockDBInfo(this);
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0601CCE1 RID: 117985 RVA: 0x00801641 File Offset: 0x007FF841
		// (set) Token: 0x0601CCE2 RID: 117986 RVA: 0x00801649 File Offset: 0x007FF849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetOwnerIndex
		{
			get
			{
				return this.targetOwnerIndex_;
			}
			set
			{
				this.targetOwnerIndex_ = value;
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0601CCE3 RID: 117987 RVA: 0x00801652 File Offset: 0x007FF852
		// (set) Token: 0x0601CCE4 RID: 117988 RVA: 0x0080165A File Offset: 0x007FF85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TargetUserId
		{
			get
			{
				return this.targetUserId_;
			}
			set
			{
				this.targetUserId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0601CCE5 RID: 117989 RVA: 0x0080166D File Offset: 0x007FF86D
		// (set) Token: 0x0601CCE6 RID: 117990 RVA: 0x00801675 File Offset: 0x007FF875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BlockDate
		{
			get
			{
				return this.blockDate_;
			}
			set
			{
				this.blockDate_ = value;
			}
		}

		// Token: 0x0601CCE7 RID: 117991 RVA: 0x0080167E File Offset: 0x007FF87E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoomChatBlockDBInfo);
		}

		// Token: 0x0601CCE8 RID: 117992 RVA: 0x0080168C File Offset: 0x007FF88C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(RoomChatBlockDBInfo other)
		{
			return other != null && (other == this || (this.TargetOwnerIndex == other.TargetOwnerIndex && !(this.TargetUserId != other.TargetUserId) && this.BlockDate == other.BlockDate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CCE9 RID: 117993 RVA: 0x008016EC File Offset: 0x007FF8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetOwnerIndex != 0L)
			{
				num ^= this.TargetOwnerIndex.GetHashCode();
			}
			if (this.TargetUserId.Length != 0)
			{
				num ^= this.TargetUserId.GetHashCode();
			}
			if (this.BlockDate != 0L)
			{
				num ^= this.BlockDate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CCEA RID: 117994 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601CCEB RID: 117995 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CCEC RID: 117996 RVA: 0x00801760 File Offset: 0x007FF960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetOwnerIndex != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TargetOwnerIndex);
			}
			if (this.TargetUserId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TargetUserId);
			}
			if (this.BlockDate != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BlockDate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CCED RID: 117997 RVA: 0x008017DC File Offset: 0x007FF9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetOwnerIndex != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetOwnerIndex);
			}
			if (this.TargetUserId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetUserId);
			}
			if (this.BlockDate != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BlockDate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CCEE RID: 117998 RVA: 0x00801850 File Offset: 0x007FFA50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(RoomChatBlockDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetOwnerIndex != 0L)
			{
				this.TargetOwnerIndex = other.TargetOwnerIndex;
			}
			if (other.TargetUserId.Length != 0)
			{
				this.TargetUserId = other.TargetUserId;
			}
			if (other.BlockDate != 0L)
			{
				this.BlockDate = other.BlockDate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CCEF RID: 117999 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CCF0 RID: 118000 RVA: 0x008018BC File Offset: 0x007FFABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BlockDate = input.ReadInt64();
						}
					}
					else
					{
						this.TargetUserId = input.ReadString();
					}
				}
				else
				{
					this.TargetOwnerIndex = input.ReadInt64();
				}
			}
		}
		private static readonly MessageParser<RoomChatBlockDBInfo> _parser = new MessageParser<RoomChatBlockDBInfo>(() => new RoomChatBlockDBInfo());

		// Token: 0x04016049 RID: 90185
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401604A RID: 90186
		public const int TargetOwnerIndexFieldNumber = 1;

		// Token: 0x0401604B RID: 90187
		private long targetOwnerIndex_;

		// Token: 0x0401604C RID: 90188
		public const int TargetUserIdFieldNumber = 2;

		// Token: 0x0401604D RID: 90189
		private string targetUserId_ = "";

		// Token: 0x0401604E RID: 90190
		public const int BlockDateFieldNumber = 3;

		// Token: 0x0401604F RID: 90191
		private long blockDate_;
	}
}
