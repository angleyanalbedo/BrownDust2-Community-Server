using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200458F RID: 17807
	public sealed class FriendshipSpecialEpisodeDBInfo : IMessage<FriendshipSpecialEpisodeDBInfo>, IMessage, IEquatable<FriendshipSpecialEpisodeDBInfo>, IDeepCloneable<FriendshipSpecialEpisodeDBInfo>, IBufferMessage
	{
		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0601BAC2 RID: 113346 RVA: 0x007CF500 File Offset: 0x007CD700
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipSpecialEpisodeDBInfo> Parser
		{
			get
			{
				return FriendshipSpecialEpisodeDBInfo._parser;
			}
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0601BAC3 RID: 113347 RVA: 0x007CF507 File Offset: 0x007CD707
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0601BAC4 RID: 113348 RVA: 0x007CF519 File Offset: 0x007CD719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeDBInfo.Descriptor;
			}
		}

		// Token: 0x0601BAC5 RID: 113349 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipSpecialEpisodeDBInfo()
		{
		}

		// Token: 0x0601BAC6 RID: 113350 RVA: 0x007CF520 File Offset: 0x007CD720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipSpecialEpisodeDBInfo(FriendshipSpecialEpisodeDBInfo other)
			: this()
		{
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BAC7 RID: 113351 RVA: 0x007CF551 File Offset: 0x007CD751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipSpecialEpisodeDBInfo Clone()
		{
			return new FriendshipSpecialEpisodeDBInfo(this);
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x0601BAC8 RID: 113352 RVA: 0x007CF559 File Offset: 0x007CD759
		// (set) Token: 0x0601BAC9 RID: 113353 RVA: 0x007CF561 File Offset: 0x007CD761
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

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0601BACA RID: 113354 RVA: 0x007CF56A File Offset: 0x007CD76A
		// (set) Token: 0x0601BACB RID: 113355 RVA: 0x007CF572 File Offset: 0x007CD772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0601BACC RID: 113356 RVA: 0x007CF57B File Offset: 0x007CD77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipSpecialEpisodeDBInfo);
		}

		// Token: 0x0601BACD RID: 113357 RVA: 0x007CF589 File Offset: 0x007CD789
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FriendshipSpecialEpisodeDBInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BACE RID: 113358 RVA: 0x007CF5C8 File Offset: 0x007CD7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601BACF RID: 113359 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BAD0 RID: 113360 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAD1 RID: 113361 RVA: 0x007CF620 File Offset: 0x007CD820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAD2 RID: 113362 RVA: 0x007CF678 File Offset: 0x007CD878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601BAD3 RID: 113363 RVA: 0x007CF6D0 File Offset: 0x007CD8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipSpecialEpisodeDBInfo other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0601BAD4 RID: 113364 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BAD5 RID: 113365 RVA: 0x007CF720 File Offset: 0x007CD920
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
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<FriendshipSpecialEpisodeDBInfo> _parser = new MessageParser<FriendshipSpecialEpisodeDBInfo>(() => new FriendshipSpecialEpisodeDBInfo());

		// Token: 0x040155E0 RID: 87520
		private UnknownFieldSet _unknownFields;

		// Token: 0x040155E1 RID: 87521
		public const int GroupIdFieldNumber = 1;

		// Token: 0x040155E2 RID: 87522
		private int groupId_;

		// Token: 0x040155E3 RID: 87523
		public const int IdFieldNumber = 2;

		// Token: 0x040155E4 RID: 87524
		private int id_;
	}
}
