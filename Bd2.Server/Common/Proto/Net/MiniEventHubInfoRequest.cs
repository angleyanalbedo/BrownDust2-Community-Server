using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004C9E RID: 19614
	public sealed class MiniEventHubInfoRequest : IMessage<MiniEventHubInfoRequest>, IMessage, IEquatable<MiniEventHubInfoRequest>, IDeepCloneable<MiniEventHubInfoRequest>, IBufferMessage
	{
		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x0601FCB7 RID: 130231 RVA: 0x00868E88 File Offset: 0x00867088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniEventHubInfoRequest> Parser
		{
			get
			{
				return MiniEventHubInfoRequest._parser;
			}
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x0601FCB8 RID: 130232 RVA: 0x00868E8F File Offset: 0x0086708F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MiniEventHubInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x0601FCB9 RID: 130233 RVA: 0x00868EA1 File Offset: 0x008670A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniEventHubInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601FCBA RID: 130234 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniEventHubInfoRequest()
		{
		}

		// Token: 0x0601FCBB RID: 130235 RVA: 0x00868EA8 File Offset: 0x008670A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniEventHubInfoRequest(MiniEventHubInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601FCBC RID: 130236 RVA: 0x00868ECD File Offset: 0x008670CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniEventHubInfoRequest Clone()
		{
			return new MiniEventHubInfoRequest(this);
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x0601FCBD RID: 130237 RVA: 0x00868ED5 File Offset: 0x008670D5
		// (set) Token: 0x0601FCBE RID: 130238 RVA: 0x00868EDD File Offset: 0x008670DD
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

		// Token: 0x0601FCBF RID: 130239 RVA: 0x00868EE6 File Offset: 0x008670E6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniEventHubInfoRequest);
		}

		// Token: 0x0601FCC0 RID: 130240 RVA: 0x00868EF4 File Offset: 0x008670F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(MiniEventHubInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601FCC1 RID: 130241 RVA: 0x00868F24 File Offset: 0x00867124
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

		// Token: 0x0601FCC2 RID: 130242 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601FCC3 RID: 130243 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601FCC4 RID: 130244 RVA: 0x00868F63 File Offset: 0x00867163
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

		// Token: 0x0601FCC5 RID: 130245 RVA: 0x00868F94 File Offset: 0x00867194
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

		// Token: 0x0601FCC6 RID: 130246 RVA: 0x00868FD2 File Offset: 0x008671D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniEventHubInfoRequest other)
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

		// Token: 0x0601FCC7 RID: 130247 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601FCC8 RID: 130248 RVA: 0x00869004 File Offset: 0x00867204
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
		private static readonly MessageParser<MiniEventHubInfoRequest> _parser = new MessageParser<MiniEventHubInfoRequest>(() => new MiniEventHubInfoRequest());

		// Token: 0x04017105 RID: 94469
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017106 RID: 94470
		public const int SeqFieldNumber = 1;

		// Token: 0x04017107 RID: 94471
		private int seq_;
	}
}
