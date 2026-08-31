using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005205 RID: 20997
	public sealed class FieldEventSpawnInfoResponse : IMessage<FieldEventSpawnInfoResponse>, IMessage, IEquatable<FieldEventSpawnInfoResponse>, IDeepCloneable<FieldEventSpawnInfoResponse>, IBufferMessage
	{
		// Token: 0x17004B4E RID: 19278
		// (get) Token: 0x06022D1F RID: 142623 RVA: 0x008D6A4B File Offset: 0x008D4C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FieldEventSpawnInfoResponse> Parser
		{
			get
			{
				return FieldEventSpawnInfoResponse._parser;
			}
		}

		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x06022D20 RID: 142624 RVA: 0x008D6A52 File Offset: 0x008D4C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldEventSpawnInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x06022D21 RID: 142625 RVA: 0x008D6A64 File Offset: 0x008D4C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldEventSpawnInfoResponse.Descriptor;
			}
		}

		// Token: 0x06022D22 RID: 142626 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldEventSpawnInfoResponse()
		{
		}

		// Token: 0x06022D23 RID: 142627 RVA: 0x008D6A6C File Offset: 0x008D4C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldEventSpawnInfoResponse(FieldEventSpawnInfoResponse other)
			: this()
		{
			this.currentProgress_ = ((other.currentProgress_ != null) ? other.currentProgress_.Clone() : null);
			this.dailyNormalCount_ = other.dailyNormalCount_;
			this.dailySpecialCount_ = other.dailySpecialCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06022D24 RID: 142628 RVA: 0x008D6AC4 File Offset: 0x008D4CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FieldEventSpawnInfoResponse Clone()
		{
			return new FieldEventSpawnInfoResponse(this);
		}

		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x06022D25 RID: 142629 RVA: 0x008D6ACC File Offset: 0x008D4CCC
		// (set) Token: 0x06022D26 RID: 142630 RVA: 0x008D6AD4 File Offset: 0x008D4CD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FieldEventSpawnProgressInfo CurrentProgress
		{
			get
			{
				return this.currentProgress_;
			}
			set
			{
				this.currentProgress_ = value;
			}
		}

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x06022D27 RID: 142631 RVA: 0x008D6ADD File Offset: 0x008D4CDD
		// (set) Token: 0x06022D28 RID: 142632 RVA: 0x008D6AE5 File Offset: 0x008D4CE5
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int DailyNormalCount
		{
			get
			{
				return this.dailyNormalCount_;
			}
			set
			{
				this.dailyNormalCount_ = value;
			}
		}

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x06022D29 RID: 142633 RVA: 0x008D6AEE File Offset: 0x008D4CEE
		// (set) Token: 0x06022D2A RID: 142634 RVA: 0x008D6AF6 File Offset: 0x008D4CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DailySpecialCount
		{
			get
			{
				return this.dailySpecialCount_;
			}
			set
			{
				this.dailySpecialCount_ = value;
			}
		}

		// Token: 0x06022D2B RID: 142635 RVA: 0x008D6AFF File Offset: 0x008D4CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldEventSpawnInfoResponse);
		}

		// Token: 0x06022D2C RID: 142636 RVA: 0x008D6B10 File Offset: 0x008D4D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FieldEventSpawnInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.CurrentProgress, other.CurrentProgress) && this.DailyNormalCount == other.DailyNormalCount && this.DailySpecialCount == other.DailySpecialCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06022D2D RID: 142637 RVA: 0x008D6B70 File Offset: 0x008D4D70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.currentProgress_ != null)
			{
				num ^= this.CurrentProgress.GetHashCode();
			}
			if (this.DailyNormalCount != 0)
			{
				num ^= this.DailyNormalCount.GetHashCode();
			}
			if (this.DailySpecialCount != 0)
			{
				num ^= this.DailySpecialCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06022D2E RID: 142638 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06022D2F RID: 142639 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06022D30 RID: 142640 RVA: 0x008D6BE0 File Offset: 0x008D4DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.currentProgress_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CurrentProgress);
			}
			if (this.DailyNormalCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DailyNormalCount);
			}
			if (this.DailySpecialCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DailySpecialCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06022D31 RID: 142641 RVA: 0x008D6C58 File Offset: 0x008D4E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.currentProgress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrentProgress);
			}
			if (this.DailyNormalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailyNormalCount);
			}
			if (this.DailySpecialCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailySpecialCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06022D32 RID: 142642 RVA: 0x008D6CC8 File Offset: 0x008D4EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FieldEventSpawnInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.currentProgress_ != null)
			{
				if (this.currentProgress_ == null)
				{
					this.CurrentProgress = new FieldEventSpawnProgressInfo();
				}
				this.CurrentProgress.MergeFrom(other.CurrentProgress);
			}
			if (other.DailyNormalCount != 0)
			{
				this.DailyNormalCount = other.DailyNormalCount;
			}
			if (other.DailySpecialCount != 0)
			{
				this.DailySpecialCount = other.DailySpecialCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06022D33 RID: 142643 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06022D34 RID: 142644 RVA: 0x008D6D44 File Offset: 0x008D4F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DailySpecialCount = input.ReadInt32();
						}
					}
					else
					{
						this.DailyNormalCount = input.ReadInt32();
					}
				}
				else
				{
					if (this.currentProgress_ == null)
					{
						this.CurrentProgress = new FieldEventSpawnProgressInfo();
					}
					input.ReadMessage(this.CurrentProgress);
				}
			}
		}
		private static readonly MessageParser<FieldEventSpawnInfoResponse> _parser = new MessageParser<FieldEventSpawnInfoResponse>(() => new FieldEventSpawnInfoResponse());

		// Token: 0x040182AF RID: 98991
		private UnknownFieldSet _unknownFields;

		// Token: 0x040182B0 RID: 98992
		public const int CurrentProgressFieldNumber = 1;

		// Token: 0x040182B1 RID: 98993
		private FieldEventSpawnProgressInfo currentProgress_;

		// Token: 0x040182B2 RID: 98994
		public const int DailyNormalCountFieldNumber = 2;

		// Token: 0x040182B3 RID: 98995
		private int dailyNormalCount_;

		// Token: 0x040182B4 RID: 98996
		public const int DailySpecialCountFieldNumber = 3;

		// Token: 0x040182B5 RID: 98997
		private int dailySpecialCount_;
	}
}
