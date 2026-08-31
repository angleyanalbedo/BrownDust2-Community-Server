using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AEA RID: 19178
	public sealed class FriendshipCounselingRequest : IMessage<FriendshipCounselingRequest>, IMessage, IEquatable<FriendshipCounselingRequest>, IDeepCloneable<FriendshipCounselingRequest>, IBufferMessage
	{
		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0601ED8B RID: 126347 RVA: 0x0084854F File Offset: 0x0084674F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipCounselingRequest> Parser
		{
			get
			{
				return FriendshipCounselingRequest._parser;
			}
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0601ED8C RID: 126348 RVA: 0x00848556 File Offset: 0x00846756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipCounselingRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0601ED8D RID: 126349 RVA: 0x00848568 File Offset: 0x00846768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipCounselingRequest.Descriptor;
			}
		}

		// Token: 0x0601ED8E RID: 126350 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipCounselingRequest()
		{
		}

		// Token: 0x0601ED8F RID: 126351 RVA: 0x00848570 File Offset: 0x00846770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipCounselingRequest(FriendshipCounselingRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this.costumeId_ = other.costumeId_;
			this.sessionId_ = other.sessionId_;
			this.selectIndex_ = other.selectIndex_;
			this.isQuick_ = other.isQuick_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ED90 RID: 126352 RVA: 0x008485D0 File Offset: 0x008467D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipCounselingRequest Clone()
		{
			return new FriendshipCounselingRequest(this);
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0601ED91 RID: 126353 RVA: 0x008485D8 File Offset: 0x008467D8
		// (set) Token: 0x0601ED92 RID: 126354 RVA: 0x008485E0 File Offset: 0x008467E0
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

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0601ED93 RID: 126355 RVA: 0x008485E9 File Offset: 0x008467E9
		// (set) Token: 0x0601ED94 RID: 126356 RVA: 0x008485F1 File Offset: 0x008467F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostumeId
		{
			get
			{
				return this.costumeId_;
			}
			set
			{
				this.costumeId_ = value;
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0601ED95 RID: 126357 RVA: 0x008485FA File Offset: 0x008467FA
		// (set) Token: 0x0601ED96 RID: 126358 RVA: 0x00848602 File Offset: 0x00846802
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SessionId
		{
			get
			{
				return this.sessionId_;
			}
			set
			{
				this.sessionId_ = value;
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0601ED97 RID: 126359 RVA: 0x0084860B File Offset: 0x0084680B
		// (set) Token: 0x0601ED98 RID: 126360 RVA: 0x00848613 File Offset: 0x00846813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectIndex
		{
			get
			{
				return this.selectIndex_;
			}
			set
			{
				this.selectIndex_ = value;
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0601ED99 RID: 126361 RVA: 0x0084861C File Offset: 0x0084681C
		// (set) Token: 0x0601ED9A RID: 126362 RVA: 0x00848624 File Offset: 0x00846824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsQuick
		{
			get
			{
				return this.isQuick_;
			}
			set
			{
				this.isQuick_ = value;
			}
		}

		// Token: 0x0601ED9B RID: 126363 RVA: 0x0084862D File Offset: 0x0084682D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipCounselingRequest);
		}

		// Token: 0x0601ED9C RID: 126364 RVA: 0x0084863C File Offset: 0x0084683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipCounselingRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && this.CostumeId == other.CostumeId && this.SessionId == other.SessionId && this.SelectIndex == other.SelectIndex && this.IsQuick == other.IsQuick && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ED9D RID: 126365 RVA: 0x008486B8 File Offset: 0x008468B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Seq != 0)
			{
				num ^= this.Seq.GetHashCode();
			}
			if (this.CostumeId != 0)
			{
				num ^= this.CostumeId.GetHashCode();
			}
			if (this.SessionId != 0)
			{
				num ^= this.SessionId.GetHashCode();
			}
			if (this.SelectIndex != 0)
			{
				num ^= this.SelectIndex.GetHashCode();
			}
			if (this.IsQuick)
			{
				num ^= this.IsQuick.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ED9E RID: 126366 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601ED9F RID: 126367 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601EDA0 RID: 126368 RVA: 0x0084875C File Offset: 0x0084695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Seq != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Seq);
			}
			if (this.CostumeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CostumeId);
			}
			if (this.SessionId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SessionId);
			}
			if (this.SelectIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SelectIndex);
			}
			if (this.IsQuick)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsQuick);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601EDA1 RID: 126369 RVA: 0x00848808 File Offset: 0x00846A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Seq != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seq);
			}
			if (this.CostumeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostumeId);
			}
			if (this.SessionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SessionId);
			}
			if (this.SelectIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectIndex);
			}
			if (this.IsQuick)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601EDA2 RID: 126370 RVA: 0x0084889C File Offset: 0x00846A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipCounselingRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Seq != 0)
			{
				this.Seq = other.Seq;
			}
			if (other.CostumeId != 0)
			{
				this.CostumeId = other.CostumeId;
			}
			if (other.SessionId != 0)
			{
				this.SessionId = other.SessionId;
			}
			if (other.SelectIndex != 0)
			{
				this.SelectIndex = other.SelectIndex;
			}
			if (other.IsQuick)
			{
				this.IsQuick = other.IsQuick;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601EDA3 RID: 126371 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601EDA4 RID: 126372 RVA: 0x00848928 File Offset: 0x00846B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Seq = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CostumeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.SessionId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SelectIndex = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.IsQuick = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04016BDC RID: 93148
		private static readonly MessageParser<FriendshipCounselingRequest> _parser = new MessageParser<FriendshipCounselingRequest>(() => new FriendshipCounselingRequest());

		// Token: 0x04016BDD RID: 93149
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016BDE RID: 93150
		public const int SeqFieldNumber = 1;

		// Token: 0x04016BDF RID: 93151
		private int seq_;

		// Token: 0x04016BE0 RID: 93152
		public const int CostumeIdFieldNumber = 2;

		// Token: 0x04016BE1 RID: 93153
		private int costumeId_;

		// Token: 0x04016BE2 RID: 93154
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04016BE3 RID: 93155
		private int sessionId_;

		// Token: 0x04016BE4 RID: 93156
		public const int SelectIndexFieldNumber = 4;

		// Token: 0x04016BE5 RID: 93157
		private int selectIndex_;

		// Token: 0x04016BE6 RID: 93158
		public const int IsQuickFieldNumber = 5;

		// Token: 0x04016BE7 RID: 93159
		private bool isQuick_;
	}
}
