using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004440 RID: 17472
	public sealed class DatingMessageRewardInfo : IMessage<DatingMessageRewardInfo>, IMessage, IEquatable<DatingMessageRewardInfo>, IDeepCloneable<DatingMessageRewardInfo>, IBufferMessage
	{
		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0601B3FA RID: 111610 RVA: 0x007BB2E8 File Offset: 0x007B94E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DatingMessageRewardInfo> Parser
		{
			get
			{
				return DatingMessageRewardInfo._parser;
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0601B3FB RID: 111611 RVA: 0x007BB2EF File Offset: 0x007B94EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DatingMessageRewardInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0601B3FC RID: 111612 RVA: 0x007BB301 File Offset: 0x007B9501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DatingMessageRewardInfo.Descriptor;
			}
		}

		// Token: 0x0601B3FD RID: 111613 RVA: 0x000022D6 File Offset: 0x000004D6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DatingMessageRewardInfo()
		{
		}

		// Token: 0x0601B3FE RID: 111614 RVA: 0x007BB308 File Offset: 0x007B9508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DatingMessageRewardInfo(DatingMessageRewardInfo other)
			: this()
		{
			this.groupId_ = other.groupId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3FF RID: 111615 RVA: 0x007BB339 File Offset: 0x007B9539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DatingMessageRewardInfo Clone()
		{
			return new DatingMessageRewardInfo(this);
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x0601B400 RID: 111616 RVA: 0x007BB341 File Offset: 0x007B9541
		// (set) Token: 0x0601B401 RID: 111617 RVA: 0x007BB349 File Offset: 0x007B9549
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

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x0601B402 RID: 111618 RVA: 0x007BB352 File Offset: 0x007B9552
		// (set) Token: 0x0601B403 RID: 111619 RVA: 0x007BB35A File Offset: 0x007B955A
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

		// Token: 0x0601B404 RID: 111620 RVA: 0x007BB363 File Offset: 0x007B9563
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DatingMessageRewardInfo);
		}

		// Token: 0x0601B405 RID: 111621 RVA: 0x007BB371 File Offset: 0x007B9571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DatingMessageRewardInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B406 RID: 111622 RVA: 0x007BB3B0 File Offset: 0x007B95B0
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

		// Token: 0x0601B407 RID: 111623 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601B408 RID: 111624 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B409 RID: 111625 RVA: 0x007BB408 File Offset: 0x007B9608
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0601B40A RID: 111626 RVA: 0x007BB460 File Offset: 0x007B9660
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

		// Token: 0x0601B40B RID: 111627 RVA: 0x007BB4B8 File Offset: 0x007B96B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(DatingMessageRewardInfo other)
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

		// Token: 0x0601B40C RID: 111628 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B40D RID: 111629 RVA: 0x007BB508 File Offset: 0x007B9708
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
		private static readonly MessageParser<DatingMessageRewardInfo> _parser = new MessageParser<DatingMessageRewardInfo>(() => new DatingMessageRewardInfo());

		// Token: 0x04014D55 RID: 85333
		private UnknownFieldSet _unknownFields;

		// Token: 0x04014D56 RID: 85334
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04014D57 RID: 85335
		private int groupId_;

		// Token: 0x04014D58 RID: 85336
		public const int IdFieldNumber = 2;

		// Token: 0x04014D59 RID: 85337
		private int id_;
	}
}
