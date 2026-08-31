using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020050E6 RID: 20710
	public sealed class DailyStoryInfoResponse : IMessage<DailyStoryInfoResponse>, IMessage, IEquatable<DailyStoryInfoResponse>, IDeepCloneable<DailyStoryInfoResponse>, IBufferMessage
	{
		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x0602233A RID: 140090 RVA: 0x008BEC88 File Offset: 0x008BCE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyStoryInfoResponse> Parser
		{
			get
			{
				return DailyStoryInfoResponse._parser;
			}
		}

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x0602233B RID: 140091 RVA: 0x008BEC8F File Offset: 0x008BCE8F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DailyStoryInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x0602233C RID: 140092 RVA: 0x008BECA1 File Offset: 0x008BCEA1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyStoryInfoResponse.Descriptor;
			}
		}

		// Token: 0x0602233D RID: 140093 RVA: 0x008BECA8 File Offset: 0x008BCEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyStoryInfoResponse()
		{
		}

		// Token: 0x0602233E RID: 140094 RVA: 0x008BECBB File Offset: 0x008BCEBB
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DailyStoryInfoResponse(DailyStoryInfoResponse other)
			: this()
		{
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0602233F RID: 140095 RVA: 0x008BECE5 File Offset: 0x008BCEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyStoryInfoResponse Clone()
		{
			return new DailyStoryInfoResponse(this);
		}

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x06022340 RID: 140096 RVA: 0x008BECED File Offset: 0x008BCEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06022341 RID: 140097 RVA: 0x008BECF5 File Offset: 0x008BCEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyStoryInfoResponse);
		}

		// Token: 0x06022342 RID: 140098 RVA: 0x008BED03 File Offset: 0x008BCF03
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(DailyStoryInfoResponse other)
		{
			return other != null && (other == this || (this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06022343 RID: 140099 RVA: 0x008BED38 File Offset: 0x008BCF38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.info_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06022344 RID: 140100 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06022345 RID: 140101 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06022346 RID: 140102 RVA: 0x008BED6C File Offset: 0x008BCF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.info_.WriteTo(ref output, DailyStoryInfoResponse._repeated_info_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06022347 RID: 140103 RVA: 0x008BED94 File Offset: 0x008BCF94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.info_.CalculateSize(DailyStoryInfoResponse._repeated_info_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06022348 RID: 140104 RVA: 0x008BEDCD File Offset: 0x008BCFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyStoryInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.info_.Add(other.info_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06022349 RID: 140105 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0602234A RID: 140106 RVA: 0x008BEDFC File Offset: 0x008BCFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.info_.AddEntriesFrom(ref input, DailyStoryInfoResponse._repeated_info_codec);
				}
			}
		}
		private static readonly MessageParser<DailyStoryInfoResponse> _parser = new MessageParser<DailyStoryInfoResponse>(() => new DailyStoryInfoResponse());

		// Token: 0x04017EEE RID: 98030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017EEF RID: 98031
		public const int InfoFieldNumber = 1;

		// Token: 0x04017EF0 RID: 98032
		private static readonly FieldCodec<int> _repeated_info_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04017EF1 RID: 98033
		private readonly RepeatedField<int> info_ = new RepeatedField<int>();
	}
}
