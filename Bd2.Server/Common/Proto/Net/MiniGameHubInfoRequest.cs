using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004CEB RID: 19691
	public sealed class MiniGameHubInfoRequest : IMessage<MiniGameHubInfoRequest>, IMessage, IEquatable<MiniGameHubInfoRequest>, IDeepCloneable<MiniGameHubInfoRequest>, IBufferMessage
	{
		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x0601FFA3 RID: 130979 RVA: 0x0086FB3C File Offset: 0x0086DD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniGameHubInfoRequest> Parser
		{
			get
			{
				return MiniGameHubInfoRequest._parser;
			}
		}

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x0601FFA4 RID: 130980 RVA: 0x0086FB43 File Offset: 0x0086DD43
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniGameHubInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x0601FFA5 RID: 130981 RVA: 0x0086FB55 File Offset: 0x0086DD55
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniGameHubInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601FFA6 RID: 130982 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameHubInfoRequest()
		{
		}

		// Token: 0x0601FFA7 RID: 130983 RVA: 0x0086FB5C File Offset: 0x0086DD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameHubInfoRequest(MiniGameHubInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601FFA8 RID: 130984 RVA: 0x0086FB81 File Offset: 0x0086DD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniGameHubInfoRequest Clone()
		{
			return new MiniGameHubInfoRequest(this);
		}

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x0601FFA9 RID: 130985 RVA: 0x0086FB89 File Offset: 0x0086DD89
		// (set) Token: 0x0601FFAA RID: 130986 RVA: 0x0086FB91 File Offset: 0x0086DD91
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

		// Token: 0x0601FFAB RID: 130987 RVA: 0x0086FB9A File Offset: 0x0086DD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniGameHubInfoRequest);
		}

		// Token: 0x0601FFAC RID: 130988 RVA: 0x0086FBA8 File Offset: 0x0086DDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniGameHubInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601FFAD RID: 130989 RVA: 0x0086FBD8 File Offset: 0x0086DDD8
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

		// Token: 0x0601FFAE RID: 130990 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601FFAF RID: 130991 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601FFB0 RID: 130992 RVA: 0x0086FC17 File Offset: 0x0086DE17
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

		// Token: 0x0601FFB1 RID: 130993 RVA: 0x0086FC48 File Offset: 0x0086DE48
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

		// Token: 0x0601FFB2 RID: 130994 RVA: 0x0086FC86 File Offset: 0x0086DE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniGameHubInfoRequest other)
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

		// Token: 0x0601FFB3 RID: 130995 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601FFB4 RID: 130996 RVA: 0x0086FCB8 File Offset: 0x0086DEB8
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
		private static readonly MessageParser<MiniGameHubInfoRequest> _parser = new MessageParser<MiniGameHubInfoRequest>(() => new MiniGameHubInfoRequest());

		// Token: 0x04017223 RID: 94755
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017224 RID: 94756
		public const int SeqFieldNumber = 1;

		// Token: 0x04017225 RID: 94757
		private int seq_;
	}
}
