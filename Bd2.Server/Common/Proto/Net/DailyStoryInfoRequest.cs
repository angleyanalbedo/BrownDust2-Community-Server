using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004929 RID: 18729
	public sealed class DailyStoryInfoRequest : IMessage<DailyStoryInfoRequest>, IMessage, IEquatable<DailyStoryInfoRequest>, IDeepCloneable<DailyStoryInfoRequest>, IBufferMessage
	{
		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0601DDF3 RID: 122355 RVA: 0x00827CB8 File Offset: 0x00825EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyStoryInfoRequest> Parser
		{
			get
			{
				return DailyStoryInfoRequest._parser;
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0601DDF4 RID: 122356 RVA: 0x00827CBF File Offset: 0x00825EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyStoryInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0601DDF5 RID: 122357 RVA: 0x00827CD1 File Offset: 0x00825ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyStoryInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601DDF6 RID: 122358 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DailyStoryInfoRequest()
		{
		}

		// Token: 0x0601DDF7 RID: 122359 RVA: 0x00827CD8 File Offset: 0x00825ED8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DailyStoryInfoRequest(DailyStoryInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DDF8 RID: 122360 RVA: 0x00827CFD File Offset: 0x00825EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyStoryInfoRequest Clone()
		{
			return new DailyStoryInfoRequest(this);
		}

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0601DDF9 RID: 122361 RVA: 0x00827D05 File Offset: 0x00825F05
		// (set) Token: 0x0601DDFA RID: 122362 RVA: 0x00827D0D File Offset: 0x00825F0D
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

		// Token: 0x0601DDFB RID: 122363 RVA: 0x00827D16 File Offset: 0x00825F16
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyStoryInfoRequest);
		}

		// Token: 0x0601DDFC RID: 122364 RVA: 0x00827D24 File Offset: 0x00825F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyStoryInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DDFD RID: 122365 RVA: 0x00827D54 File Offset: 0x00825F54
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

		// Token: 0x0601DDFE RID: 122366 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601DDFF RID: 122367 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DE00 RID: 122368 RVA: 0x00827D93 File Offset: 0x00825F93
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

		// Token: 0x0601DE01 RID: 122369 RVA: 0x00827DC4 File Offset: 0x00825FC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0601DE02 RID: 122370 RVA: 0x00827E02 File Offset: 0x00826002
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(DailyStoryInfoRequest other)
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

		// Token: 0x0601DE03 RID: 122371 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DE04 RID: 122372 RVA: 0x00827E34 File Offset: 0x00826034
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
		private static readonly MessageParser<DailyStoryInfoRequest> _parser = new MessageParser<DailyStoryInfoRequest>(() => new DailyStoryInfoRequest());

		// Token: 0x04016693 RID: 91795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016694 RID: 91796
		public const int SeqFieldNumber = 1;

		// Token: 0x04016695 RID: 91797
		private int seq_;
	}
}
