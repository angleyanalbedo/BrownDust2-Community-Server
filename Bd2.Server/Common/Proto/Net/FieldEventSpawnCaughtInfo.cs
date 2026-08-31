using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004553 RID: 17747
	public sealed class FieldEventSpawnCaughtInfo : IMessage<FieldEventSpawnCaughtInfo>, IMessage, IEquatable<FieldEventSpawnCaughtInfo>, IDeepCloneable<FieldEventSpawnCaughtInfo>, IBufferMessage
	{
		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0601B871 RID: 112753 RVA: 0x007C9A65 File Offset: 0x007C7C65
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FieldEventSpawnCaughtInfo> Parser
		{
			get
			{
				return FieldEventSpawnCaughtInfo._parser;
			}
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0601B872 RID: 112754 RVA: 0x007C9A6C File Offset: 0x007C7C6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldEventSpawnCaughtInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0601B873 RID: 112755 RVA: 0x007C9A7E File Offset: 0x007C7C7E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldEventSpawnCaughtInfo.Descriptor;
			}
		}

		// Token: 0x0601B874 RID: 112756 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldEventSpawnCaughtInfo()
		{
		}

		// Token: 0x0601B875 RID: 112757 RVA: 0x007C9A85 File Offset: 0x007C7C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldEventSpawnCaughtInfo(FieldEventSpawnCaughtInfo other)
			: this()
		{
			this.spawnEventId_ = other.spawnEventId_;
			this.monsterGroupId_ = other.monsterGroupId_;
			this.monsterId_ = other.monsterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B876 RID: 112758 RVA: 0x007C9AC2 File Offset: 0x007C7CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldEventSpawnCaughtInfo Clone()
		{
			return new FieldEventSpawnCaughtInfo(this);
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0601B877 RID: 112759 RVA: 0x007C9ACA File Offset: 0x007C7CCA
		// (set) Token: 0x0601B878 RID: 112760 RVA: 0x007C9AD2 File Offset: 0x007C7CD2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpawnEventId
		{
			get
			{
				return this.spawnEventId_;
			}
			set
			{
				this.spawnEventId_ = value;
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0601B879 RID: 112761 RVA: 0x007C9ADB File Offset: 0x007C7CDB
		// (set) Token: 0x0601B87A RID: 112762 RVA: 0x007C9AE3 File Offset: 0x007C7CE3
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MonsterGroupId
		{
			get
			{
				return this.monsterGroupId_;
			}
			set
			{
				this.monsterGroupId_ = value;
			}
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0601B87B RID: 112763 RVA: 0x007C9AEC File Offset: 0x007C7CEC
		// (set) Token: 0x0601B87C RID: 112764 RVA: 0x007C9AF4 File Offset: 0x007C7CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x0601B87D RID: 112765 RVA: 0x007C9AFD File Offset: 0x007C7CFD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldEventSpawnCaughtInfo);
		}

		// Token: 0x0601B87E RID: 112766 RVA: 0x007C9B0C File Offset: 0x007C7D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldEventSpawnCaughtInfo other)
		{
			return other != null && (other == this || (this.SpawnEventId == other.SpawnEventId && this.MonsterGroupId == other.MonsterGroupId && this.MonsterId == other.MonsterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B87F RID: 112767 RVA: 0x007C9B68 File Offset: 0x007C7D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SpawnEventId != 0)
			{
				num ^= this.SpawnEventId.GetHashCode();
			}
			if (this.MonsterGroupId != 0)
			{
				num ^= this.MonsterGroupId.GetHashCode();
			}
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B880 RID: 112768 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B881 RID: 112769 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B882 RID: 112770 RVA: 0x007C9BDC File Offset: 0x007C7DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpawnEventId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SpawnEventId);
			}
			if (this.MonsterGroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MonsterGroupId);
			}
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B883 RID: 112771 RVA: 0x007C9C50 File Offset: 0x007C7E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SpawnEventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnEventId);
			}
			if (this.MonsterGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterGroupId);
			}
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B884 RID: 112772 RVA: 0x007C9CC0 File Offset: 0x007C7EC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FieldEventSpawnCaughtInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SpawnEventId != 0)
			{
				this.SpawnEventId = other.SpawnEventId;
			}
			if (other.MonsterGroupId != 0)
			{
				this.MonsterGroupId = other.MonsterGroupId;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B885 RID: 112773 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B886 RID: 112774 RVA: 0x007C9D24 File Offset: 0x007C7F24
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MonsterId = input.ReadInt32();
						}
					}
					else
					{
						this.MonsterGroupId = input.ReadInt32();
					}
				}
				else
				{
					this.SpawnEventId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<FieldEventSpawnCaughtInfo> _parser = new MessageParser<FieldEventSpawnCaughtInfo>(() => new FieldEventSpawnCaughtInfo());

		// Token: 0x040154F5 RID: 87285
		private UnknownFieldSet _unknownFields;

		// Token: 0x040154F6 RID: 87286
		public const int SpawnEventIdFieldNumber = 1;

		// Token: 0x040154F7 RID: 87287
		private int spawnEventId_;

		// Token: 0x040154F8 RID: 87288
		public const int MonsterGroupIdFieldNumber = 2;

		// Token: 0x040154F9 RID: 87289
		private int monsterGroupId_;

		// Token: 0x040154FA RID: 87290
		public const int MonsterIdFieldNumber = 3;

		// Token: 0x040154FB RID: 87291
		private int monsterId_;
	}
}
