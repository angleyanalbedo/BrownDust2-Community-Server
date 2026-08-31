using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AF3 RID: 19187
	public sealed class FriendshipSpecialEpisodeClearRequest : IMessage<FriendshipSpecialEpisodeClearRequest>, IMessage, IEquatable<FriendshipSpecialEpisodeClearRequest>, IDeepCloneable<FriendshipSpecialEpisodeClearRequest>, IBufferMessage
	{
		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0601EDDE RID: 126430 RVA: 0x008490ED File Offset: 0x008472ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendshipSpecialEpisodeClearRequest> Parser
		{
			get
			{
				return FriendshipSpecialEpisodeClearRequest._parser;
			}
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0601EDDF RID: 126431 RVA: 0x008490F4 File Offset: 0x008472F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeClearRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0601EDE0 RID: 126432 RVA: 0x00849106 File Offset: 0x00847306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeClearRequest.Descriptor;
			}
		}

		// Token: 0x0601EDE1 RID: 126433 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipSpecialEpisodeClearRequest()
		{
		}

		// Token: 0x0601EDE2 RID: 126434 RVA: 0x0084910D File Offset: 0x0084730D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipSpecialEpisodeClearRequest(FriendshipSpecialEpisodeClearRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601EDE3 RID: 126435 RVA: 0x0084914A File Offset: 0x0084734A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipSpecialEpisodeClearRequest Clone()
		{
			return new FriendshipSpecialEpisodeClearRequest(this);
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0601EDE4 RID: 126436 RVA: 0x00849152 File Offset: 0x00847352
		// (set) Token: 0x0601EDE5 RID: 126437 RVA: 0x0084915A File Offset: 0x0084735A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Seq
		{
			get
			{
				return this.seq_;
			}
			set
			{
				this.seq_ = value;
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0601EDE6 RID: 126438 RVA: 0x00849163 File Offset: 0x00847363
		// (set) Token: 0x0601EDE7 RID: 126439 RVA: 0x0084916B File Offset: 0x0084736B
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

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0601EDE8 RID: 126440 RVA: 0x00849174 File Offset: 0x00847374
		// (set) Token: 0x0601EDE9 RID: 126441 RVA: 0x0084917C File Offset: 0x0084737C
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

		// Token: 0x0601EDEA RID: 126442 RVA: 0x00849185 File Offset: 0x00847385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipSpecialEpisodeClearRequest);
		}

		// Token: 0x0601EDEB RID: 126443 RVA: 0x00849194 File Offset: 0x00847394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipSpecialEpisodeClearRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && this.GroupId == other.GroupId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601EDEC RID: 126444 RVA: 0x008491F0 File Offset: 0x008473F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Seq != 0)
			{
				num ^= this.Seq.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601EDED RID: 126445 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601EDEE RID: 126446 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601EDEF RID: 126447 RVA: 0x00849264 File Offset: 0x00847464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Seq != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Seq);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601EDF0 RID: 126448 RVA: 0x008492D8 File Offset: 0x008474D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Seq != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seq);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601EDF1 RID: 126449 RVA: 0x00849348 File Offset: 0x00847548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipSpecialEpisodeClearRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Seq != 0)
			{
				this.Seq = other.Seq;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601EDF2 RID: 126450 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601EDF3 RID: 126451 RVA: 0x008493AC File Offset: 0x008475AC
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
							this.Id = input.ReadInt32();
						}
					}
					else
					{
						this.GroupId = input.ReadInt32();
					}
				}
				else
				{
					this.Seq = input.ReadInt32();
				}
			}
		}

		// Token: 0x04016BFB RID: 93179
		private static readonly MessageParser<FriendshipSpecialEpisodeClearRequest> _parser = new MessageParser<FriendshipSpecialEpisodeClearRequest>(() => new FriendshipSpecialEpisodeClearRequest());

		// Token: 0x04016BFC RID: 93180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016BFD RID: 93181
		public const int SeqFieldNumber = 1;

		// Token: 0x04016BFE RID: 93182
		private int seq_;

		// Token: 0x04016BFF RID: 93183
		public const int GroupIdFieldNumber = 2;

		// Token: 0x04016C00 RID: 93184
		private int groupId_;

		// Token: 0x04016C01 RID: 93185
		public const int IdFieldNumber = 3;

		// Token: 0x04016C02 RID: 93186
		private int id_;
	}
}
