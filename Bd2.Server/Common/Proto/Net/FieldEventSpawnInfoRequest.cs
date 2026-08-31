using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004A48 RID: 19016
	public sealed class FieldEventSpawnInfoRequest : IMessage<FieldEventSpawnInfoRequest>, IMessage, IEquatable<FieldEventSpawnInfoRequest>, IDeepCloneable<FieldEventSpawnInfoRequest>, IBufferMessage
	{
		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x0601E809 RID: 124937 RVA: 0x0083D81C File Offset: 0x0083BA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldEventSpawnInfoRequest> Parser
		{
			get
			{
				return FieldEventSpawnInfoRequest._parser;
			}
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0601E80A RID: 124938 RVA: 0x0083D823 File Offset: 0x0083BA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldEventSpawnInfoRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x0601E80B RID: 124939 RVA: 0x0083D835 File Offset: 0x0083BA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldEventSpawnInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601E80C RID: 124940 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FieldEventSpawnInfoRequest()
		{
		}

		// Token: 0x0601E80D RID: 124941 RVA: 0x0083D83C File Offset: 0x0083BA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldEventSpawnInfoRequest(FieldEventSpawnInfoRequest other)
			: this()
		{
			this.seq_ = other.seq_;
			this.eventScheduleId_ = other.eventScheduleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601E80E RID: 124942 RVA: 0x0083D86D File Offset: 0x0083BA6D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FieldEventSpawnInfoRequest Clone()
		{
			return new FieldEventSpawnInfoRequest(this);
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x0601E80F RID: 124943 RVA: 0x0083D875 File Offset: 0x0083BA75
		// (set) Token: 0x0601E810 RID: 124944 RVA: 0x0083D87D File Offset: 0x0083BA7D
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

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0601E811 RID: 124945 RVA: 0x0083D886 File Offset: 0x0083BA86
		// (set) Token: 0x0601E812 RID: 124946 RVA: 0x0083D88E File Offset: 0x0083BA8E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int EventScheduleId
		{
			get
			{
				return this.eventScheduleId_;
			}
			set
			{
				this.eventScheduleId_ = value;
			}
		}

		// Token: 0x0601E813 RID: 124947 RVA: 0x0083D897 File Offset: 0x0083BA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldEventSpawnInfoRequest);
		}

		// Token: 0x0601E814 RID: 124948 RVA: 0x0083D8A5 File Offset: 0x0083BAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldEventSpawnInfoRequest other)
		{
			return other != null && (other == this || (this.Seq == other.Seq && this.EventScheduleId == other.EventScheduleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601E815 RID: 124949 RVA: 0x0083D8E4 File Offset: 0x0083BAE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Seq != 0)
			{
				num ^= this.Seq.GetHashCode();
			}
			if (this.EventScheduleId != 0)
			{
				num ^= this.EventScheduleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601E816 RID: 124950 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601E817 RID: 124951 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601E818 RID: 124952 RVA: 0x0083D93C File Offset: 0x0083BB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Seq != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Seq);
			}
			if (this.EventScheduleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventScheduleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601E819 RID: 124953 RVA: 0x0083D994 File Offset: 0x0083BB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Seq != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seq);
			}
			if (this.EventScheduleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventScheduleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601E81A RID: 124954 RVA: 0x0083D9EC File Offset: 0x0083BBEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(FieldEventSpawnInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Seq != 0)
			{
				this.Seq = other.Seq;
			}
			if (other.EventScheduleId != 0)
			{
				this.EventScheduleId = other.EventScheduleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601E81B RID: 124955 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601E81C RID: 124956 RVA: 0x0083DA3C File Offset: 0x0083BC3C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EventScheduleId = input.ReadInt32();
					}
				}
				else
				{
					this.Seq = input.ReadInt32();
				}
			}
		}
		private static readonly MessageParser<FieldEventSpawnInfoRequest> _parser = new MessageParser<FieldEventSpawnInfoRequest>(() => new FieldEventSpawnInfoRequest());

		// Token: 0x04016A1F RID: 92703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04016A20 RID: 92704
		public const int SeqFieldNumber = 1;

		// Token: 0x04016A21 RID: 92705
		private int seq_;

		// Token: 0x04016A22 RID: 92706
		public const int EventScheduleIdFieldNumber = 2;

		// Token: 0x04016A23 RID: 92707
		private int eventScheduleId_;
	}
}
