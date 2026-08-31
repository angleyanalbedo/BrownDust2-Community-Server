using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020047D2 RID: 18386
	public sealed class AvatarInfoRequest : IMessage<AvatarInfoRequest>, IMessage, IEquatable<AvatarInfoRequest>, IDeepCloneable<AvatarInfoRequest>, IBufferMessage
	{
		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0601D1F0 RID: 119280 RVA: 0x0080E74B File Offset: 0x0080C94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarInfoRequest> Parser
		{
			get
			{
				return AvatarInfoRequest._parser;
			}
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0601D1F1 RID: 119281 RVA: 0x0080E752 File Offset: 0x0080C952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0601D1F2 RID: 119282 RVA: 0x0080E764 File Offset: 0x0080C964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601D1F3 RID: 119283 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AvatarInfoRequest()
		{
		}

		// Token: 0x0601D1F4 RID: 119284 RVA: 0x0080E76B File Offset: 0x0080C96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarInfoRequest(AvatarInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1F5 RID: 119285 RVA: 0x0080E790 File Offset: 0x0080C990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarInfoRequest Clone()
		{
			return new AvatarInfoRequest(this);
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0601D1F6 RID: 119286 RVA: 0x0080E798 File Offset: 0x0080C998
		// (set) Token: 0x0601D1F7 RID: 119287 RVA: 0x0080E7A0 File Offset: 0x0080C9A0
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

		// Token: 0x0601D1F8 RID: 119288 RVA: 0x0080E7A9 File Offset: 0x0080C9A9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarInfoRequest);
		}

		// Token: 0x0601D1F9 RID: 119289 RVA: 0x0080E7B7 File Offset: 0x0080C9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1FA RID: 119290 RVA: 0x0080E7E8 File Offset: 0x0080C9E8
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

		// Token: 0x0601D1FB RID: 119291 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601D1FC RID: 119292 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1FD RID: 119293 RVA: 0x0080E827 File Offset: 0x0080CA27
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

		// Token: 0x0601D1FE RID: 119294 RVA: 0x0080E858 File Offset: 0x0080CA58
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

		// Token: 0x0601D1FF RID: 119295 RVA: 0x0080E896 File Offset: 0x0080CA96
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarInfoRequest other)
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

		// Token: 0x0601D200 RID: 119296 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D201 RID: 119297 RVA: 0x0080E8C8 File Offset: 0x0080CAC8
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
		private static readonly MessageParser<AvatarInfoRequest> _parser = new MessageParser<AvatarInfoRequest>(() => new AvatarInfoRequest());

		// Token: 0x04016270 RID: 90736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016271 RID: 90737
		public const int SeqFieldNumber = 1;

		// Token: 0x04016272 RID: 90738
		private int seq_;
	}
}
