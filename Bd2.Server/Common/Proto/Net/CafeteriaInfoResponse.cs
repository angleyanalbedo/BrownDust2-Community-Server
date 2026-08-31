using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004FDD RID: 20445
	public sealed class CafeteriaInfoResponse : IMessage<CafeteriaInfoResponse>, IMessage, IEquatable<CafeteriaInfoResponse>, IDeepCloneable<CafeteriaInfoResponse>, IBufferMessage
	{
		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x06021A73 RID: 137843 RVA: 0x008AC034 File Offset: 0x008AA234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CafeteriaInfoResponse> Parser
		{
			get
			{
				return CafeteriaInfoResponse._parser;
			}
		}

		// Token: 0x170046C1 RID: 18113
		// (get) Token: 0x06021A74 RID: 137844 RVA: 0x008AC03B File Offset: 0x008AA23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CafeteriaInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x06021A75 RID: 137845 RVA: 0x008AC04D File Offset: 0x008AA24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CafeteriaInfoResponse.Descriptor;
			}
		}

		// Token: 0x06021A76 RID: 137846 RVA: 0x008AC054 File Offset: 0x008AA254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaInfoResponse()
		{
		}

		// Token: 0x06021A77 RID: 137847 RVA: 0x008AC074 File Offset: 0x008AA274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaInfoResponse(CafeteriaInfoResponse other)
			: this()
		{
			this.cafeteriaInfo_ = ((other.cafeteriaInfo_ != null) ? other.cafeteriaInfo_.Clone() : null);
			this.facilityInfo_ = other.facilityInfo_.Clone();
			this.partTimeManagerInfo_ = other.partTimeManagerInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06021A78 RID: 137848 RVA: 0x008AC0D6 File Offset: 0x008AA2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CafeteriaInfoResponse Clone()
		{
			return new CafeteriaInfoResponse(this);
		}

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x06021A79 RID: 137849 RVA: 0x008AC0DE File Offset: 0x008AA2DE
		// (set) Token: 0x06021A7A RID: 137850 RVA: 0x008AC0E6 File Offset: 0x008AA2E6
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CafeteriaDBInfo CafeteriaInfo
		{
			get
			{
				return this.cafeteriaInfo_;
			}
			set
			{
				this.cafeteriaInfo_ = value;
			}
		}

		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x06021A7B RID: 137851 RVA: 0x008AC0EF File Offset: 0x008AA2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CafeteriaFacilityDBInfo> FacilityInfo
		{
			get
			{
				return this.facilityInfo_;
			}
		}

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x06021A7C RID: 137852 RVA: 0x008AC0F7 File Offset: 0x008AA2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CafeteriaPartTimeManagerDBInfo> PartTimeManagerInfo
		{
			get
			{
				return this.partTimeManagerInfo_;
			}
		}

		// Token: 0x06021A7D RID: 137853 RVA: 0x008AC0FF File Offset: 0x008AA2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CafeteriaInfoResponse);
		}

		// Token: 0x06021A7E RID: 137854 RVA: 0x008AC110 File Offset: 0x008AA310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(CafeteriaInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.CafeteriaInfo, other.CafeteriaInfo) && this.facilityInfo_.Equals(other.facilityInfo_) && this.partTimeManagerInfo_.Equals(other.partTimeManagerInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06021A7F RID: 137855 RVA: 0x008AC178 File Offset: 0x008AA378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cafeteriaInfo_ != null)
			{
				num ^= this.CafeteriaInfo.GetHashCode();
			}
			num ^= this.facilityInfo_.GetHashCode();
			num ^= this.partTimeManagerInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06021A80 RID: 137856 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06021A81 RID: 137857 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06021A82 RID: 137858 RVA: 0x008AC1D0 File Offset: 0x008AA3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cafeteriaInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CafeteriaInfo);
			}
			this.facilityInfo_.WriteTo(ref output, CafeteriaInfoResponse._repeated_facilityInfo_codec);
			this.partTimeManagerInfo_.WriteTo(ref output, CafeteriaInfoResponse._repeated_partTimeManagerInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06021A83 RID: 137859 RVA: 0x008AC230 File Offset: 0x008AA430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cafeteriaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CafeteriaInfo);
			}
			num += this.facilityInfo_.CalculateSize(CafeteriaInfoResponse._repeated_facilityInfo_codec);
			num += this.partTimeManagerInfo_.CalculateSize(CafeteriaInfoResponse._repeated_partTimeManagerInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06021A84 RID: 137860 RVA: 0x008AC294 File Offset: 0x008AA494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CafeteriaInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cafeteriaInfo_ != null)
			{
				if (this.cafeteriaInfo_ == null)
				{
					this.CafeteriaInfo = new CafeteriaDBInfo();
				}
				this.CafeteriaInfo.MergeFrom(other.CafeteriaInfo);
			}
			this.facilityInfo_.Add(other.facilityInfo_);
			this.partTimeManagerInfo_.Add(other.partTimeManagerInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06021A85 RID: 137861 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06021A86 RID: 137862 RVA: 0x008AC30C File Offset: 0x008AA50C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.partTimeManagerInfo_.AddEntriesFrom(ref input, CafeteriaInfoResponse._repeated_partTimeManagerInfo_codec);
						}
					}
					else
					{
						this.facilityInfo_.AddEntriesFrom(ref input, CafeteriaInfoResponse._repeated_facilityInfo_codec);
					}
				}
				else
				{
					if (this.cafeteriaInfo_ == null)
					{
						this.CafeteriaInfo = new CafeteriaDBInfo();
					}
					input.ReadMessage(this.CafeteriaInfo);
				}
			}
		}
		private static readonly MessageParser<CafeteriaInfoResponse> _parser = new MessageParser<CafeteriaInfoResponse>(() => new CafeteriaInfoResponse());

		// Token: 0x04017BE5 RID: 97253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04017BE6 RID: 97254
		public const int CafeteriaInfoFieldNumber = 1;

		// Token: 0x04017BE7 RID: 97255
		private CafeteriaDBInfo cafeteriaInfo_;

		// Token: 0x04017BE8 RID: 97256
		public const int FacilityInfoFieldNumber = 2;

		// Token: 0x04017BE9 RID: 97257
		private static readonly FieldCodec<CafeteriaFacilityDBInfo> _repeated_facilityInfo_codec = FieldCodec.ForMessage<CafeteriaFacilityDBInfo>(18U, CafeteriaFacilityDBInfo.Parser);

		// Token: 0x04017BEA RID: 97258
		private readonly RepeatedField<CafeteriaFacilityDBInfo> facilityInfo_ = new RepeatedField<CafeteriaFacilityDBInfo>();

		// Token: 0x04017BEB RID: 97259
		public const int PartTimeManagerInfoFieldNumber = 3;

		// Token: 0x04017BEC RID: 97260
		private static readonly FieldCodec<CafeteriaPartTimeManagerDBInfo> _repeated_partTimeManagerInfo_codec = FieldCodec.ForMessage<CafeteriaPartTimeManagerDBInfo>(26U, CafeteriaPartTimeManagerDBInfo.Parser);

		// Token: 0x04017BED RID: 97261
		private readonly RepeatedField<CafeteriaPartTimeManagerDBInfo> partTimeManagerInfo_ = new RepeatedField<CafeteriaPartTimeManagerDBInfo>();
	}
}
