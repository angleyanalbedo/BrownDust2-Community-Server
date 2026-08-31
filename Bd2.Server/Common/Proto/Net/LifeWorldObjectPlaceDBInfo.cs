using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004622 RID: 17954
	public sealed class LifeWorldObjectPlaceDBInfo : IMessage<LifeWorldObjectPlaceDBInfo>, IMessage, IEquatable<LifeWorldObjectPlaceDBInfo>, IDeepCloneable<LifeWorldObjectPlaceDBInfo>, IBufferMessage
	{
		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0601C0F6 RID: 114934 RVA: 0x007E0F67 File Offset: 0x007DF167
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LifeWorldObjectPlaceDBInfo> Parser
		{
			get
			{
				return LifeWorldObjectPlaceDBInfo._parser;
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0601C0F7 RID: 114935 RVA: 0x007E0F6E File Offset: 0x007DF16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeWorldObjectPlaceDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0601C0F8 RID: 114936 RVA: 0x007E0F80 File Offset: 0x007DF180
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeWorldObjectPlaceDBInfo.Descriptor;
			}
		}

		// Token: 0x0601C0F9 RID: 114937 RVA: 0x007E0F87 File Offset: 0x007DF187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeWorldObjectPlaceDBInfo()
		{
		}

		// Token: 0x0601C0FA RID: 114938 RVA: 0x007E0F9A File Offset: 0x007DF19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeWorldObjectPlaceDBInfo(LifeWorldObjectPlaceDBInfo other)
			: this()
		{
			this.chunkId_ = other.chunkId_;
			this.object_ = other.object_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0FB RID: 114939 RVA: 0x007E0FD0 File Offset: 0x007DF1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeWorldObjectPlaceDBInfo Clone()
		{
			return new LifeWorldObjectPlaceDBInfo(this);
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0601C0FC RID: 114940 RVA: 0x007E0FD8 File Offset: 0x007DF1D8
		// (set) Token: 0x0601C0FD RID: 114941 RVA: 0x007E0FE0 File Offset: 0x007DF1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChunkId
		{
			get
			{
				return this.chunkId_;
			}
			set
			{
				this.chunkId_ = value;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0601C0FE RID: 114942 RVA: 0x007E0FE9 File Offset: 0x007DF1E9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<LifeWorldObjectDBInfo> Object
		{
			get
			{
				return this.object_;
			}
		}

		// Token: 0x0601C0FF RID: 114943 RVA: 0x007E0FF1 File Offset: 0x007DF1F1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeWorldObjectPlaceDBInfo);
		}

		// Token: 0x0601C100 RID: 114944 RVA: 0x007E1000 File Offset: 0x007DF200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifeWorldObjectPlaceDBInfo other)
		{
			return other != null && (other == this || (this.ChunkId == other.ChunkId && this.object_.Equals(other.object_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C101 RID: 114945 RVA: 0x007E1050 File Offset: 0x007DF250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChunkId != 0)
			{
				num ^= this.ChunkId.GetHashCode();
			}
			num ^= this.object_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C102 RID: 114946 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601C103 RID: 114947 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C104 RID: 114948 RVA: 0x007E10A0 File Offset: 0x007DF2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChunkId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChunkId);
			}
			this.object_.WriteTo(ref output, LifeWorldObjectPlaceDBInfo._repeated_object_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C105 RID: 114949 RVA: 0x007E10F0 File Offset: 0x007DF2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChunkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChunkId);
			}
			num += this.object_.CalculateSize(LifeWorldObjectPlaceDBInfo._repeated_object_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C106 RID: 114950 RVA: 0x007E1144 File Offset: 0x007DF344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeWorldObjectPlaceDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChunkId != 0)
			{
				this.ChunkId = other.ChunkId;
			}
			this.object_.Add(other.object_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C107 RID: 114951 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C108 RID: 114952 RVA: 0x007E1194 File Offset: 0x007DF394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.object_.AddEntriesFrom(ref input, LifeWorldObjectPlaceDBInfo._repeated_object_codec);
					}
				}
				else
				{
					this.ChunkId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<LifeWorldObjectPlaceDBInfo> _parser = new MessageParser<LifeWorldObjectPlaceDBInfo>(() => new LifeWorldObjectPlaceDBInfo());

		// Token: 0x040158BD RID: 88253
		private UnknownFieldSet _unknownFields;

		// Token: 0x040158BE RID: 88254
		public const int ChunkIdFieldNumber = 1;

		// Token: 0x040158BF RID: 88255
		private int chunkId_;

		// Token: 0x040158C0 RID: 88256
		public const int ObjectFieldNumber = 2;

		// Token: 0x040158C1 RID: 88257
		private static readonly FieldCodec<LifeWorldObjectDBInfo> _repeated_object_codec = FieldCodec.ForMessage<LifeWorldObjectDBInfo>(18U, LifeWorldObjectDBInfo.Parser);

		// Token: 0x040158C2 RID: 88258
		private readonly RepeatedField<LifeWorldObjectDBInfo> object_ = new RepeatedField<LifeWorldObjectDBInfo>();
	}
}
