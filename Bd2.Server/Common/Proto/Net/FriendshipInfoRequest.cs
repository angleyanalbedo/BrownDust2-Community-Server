using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AF0 RID: 19184
	public sealed class FriendshipInfoRequest : IMessage<FriendshipInfoRequest>, IMessage, IEquatable<FriendshipInfoRequest>, IDeepCloneable<FriendshipInfoRequest>, IBufferMessage
	{
		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0601EDC6 RID: 126406 RVA: 0x00848E7C File Offset: 0x0084707C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FriendshipInfoRequest> Parser
		{
			get
			{
				return FriendshipInfoRequest._parser;
			}
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0601EDC7 RID: 126407 RVA: 0x00848E83 File Offset: 0x00847083
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0601EDC8 RID: 126408 RVA: 0x00848E95 File Offset: 0x00847095
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601EDC9 RID: 126409 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipInfoRequest()
		{
		}

		// Token: 0x0601EDCA RID: 126410 RVA: 0x00848E9C File Offset: 0x0084709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipInfoRequest(FriendshipInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601EDCB RID: 126411 RVA: 0x00848EC1 File Offset: 0x008470C1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipInfoRequest Clone()
		{
			return new FriendshipInfoRequest(this);
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0601EDCC RID: 126412 RVA: 0x00848EC9 File Offset: 0x008470C9
		// (set) Token: 0x0601EDCD RID: 126413 RVA: 0x00848ED1 File Offset: 0x008470D1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0601EDCE RID: 126414 RVA: 0x00848EDA File Offset: 0x008470DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipInfoRequest);
		}

		// Token: 0x0601EDCF RID: 126415 RVA: 0x00848EE8 File Offset: 0x008470E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendshipInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601EDD0 RID: 126416 RVA: 0x00848F18 File Offset: 0x00847118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Seq != 0)
			{
				num ^= this.Seq.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601EDD1 RID: 126417 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601EDD2 RID: 126418 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601EDD3 RID: 126419 RVA: 0x00848F57 File Offset: 0x00847157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Seq != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Seq);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601EDD4 RID: 126420 RVA: 0x00848F88 File Offset: 0x00847188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Seq != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seq);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601EDD5 RID: 126421 RVA: 0x00848FC6 File Offset: 0x008471C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Seq != 0)
			{
				this.Seq = other.Seq;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601EDD6 RID: 126422 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601EDD7 RID: 126423 RVA: 0x00848FF8 File Offset: 0x008471F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Seq = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<FriendshipInfoRequest> _parser = new MessageParser<FriendshipInfoRequest>(() => new FriendshipInfoRequest());

		// Token: 0x04016BF6 RID: 93174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016BF7 RID: 93175
		public const int SeqFieldNumber = 1;

		// Token: 0x04016BF8 RID: 93176
		private int seq_;
	}
}
