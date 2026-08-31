using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020048F5 RID: 18677
	public sealed class ColosseumUserInfoRequest : IMessage<ColosseumUserInfoRequest>, IMessage, IEquatable<ColosseumUserInfoRequest>, IDeepCloneable<ColosseumUserInfoRequest>, IBufferMessage
	{
		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0601DC0E RID: 121870 RVA: 0x0082389C File Offset: 0x00821A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ColosseumUserInfoRequest> Parser
		{
			get
			{
				return ColosseumUserInfoRequest._parser;
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0601DC0F RID: 121871 RVA: 0x008238A3 File Offset: 0x00821AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ColosseumUserInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0601DC10 RID: 121872 RVA: 0x008238B5 File Offset: 0x00821AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ColosseumUserInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601DC11 RID: 121873 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColosseumUserInfoRequest()
		{
		}

		// Token: 0x0601DC12 RID: 121874 RVA: 0x008238BC File Offset: 0x00821ABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ColosseumUserInfoRequest(ColosseumUserInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC13 RID: 121875 RVA: 0x008238E1 File Offset: 0x00821AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ColosseumUserInfoRequest Clone()
		{
			return new ColosseumUserInfoRequest(this);
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0601DC14 RID: 121876 RVA: 0x008238E9 File Offset: 0x00821AE9
		// (set) Token: 0x0601DC15 RID: 121877 RVA: 0x008238F1 File Offset: 0x00821AF1
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

		// Token: 0x0601DC16 RID: 121878 RVA: 0x008238FA File Offset: 0x00821AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ColosseumUserInfoRequest);
		}

		// Token: 0x0601DC17 RID: 121879 RVA: 0x00823908 File Offset: 0x00821B08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(ColosseumUserInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC18 RID: 121880 RVA: 0x00823938 File Offset: 0x00821B38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0601DC19 RID: 121881 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601DC1A RID: 121882 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC1B RID: 121883 RVA: 0x00823977 File Offset: 0x00821B77
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0601DC1C RID: 121884 RVA: 0x008239A8 File Offset: 0x00821BA8
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

		// Token: 0x0601DC1D RID: 121885 RVA: 0x008239E6 File Offset: 0x00821BE6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(ColosseumUserInfoRequest other)
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

		// Token: 0x0601DC1E RID: 121886 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC1F RID: 121887 RVA: 0x00823A18 File Offset: 0x00821C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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
		private static readonly MessageParser<ColosseumUserInfoRequest> _parser = new MessageParser<ColosseumUserInfoRequest>(() => new ColosseumUserInfoRequest());

		// Token: 0x040165DE RID: 91614
		private UnknownFieldSet _unknownFields;

		// Token: 0x040165DF RID: 91615
		public const int SeqFieldNumber = 1;

		// Token: 0x040165E0 RID: 91616
		private int seq_;
	}
}
