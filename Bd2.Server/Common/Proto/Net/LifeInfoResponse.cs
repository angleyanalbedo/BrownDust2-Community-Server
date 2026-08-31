using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005406 RID: 21510
	public sealed class LifeInfoResponse : IMessage<LifeInfoResponse>, IMessage, IEquatable<LifeInfoResponse>, IDeepCloneable<LifeInfoResponse>, IBufferMessage
	{
		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x06023DA8 RID: 146856 RVA: 0x008F79F5 File Offset: 0x008F5BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifeInfoResponse> Parser
		{
			get
			{
				return LifeInfoResponse._parser;
			}
		}

		// Token: 0x17004F13 RID: 20243
		// (get) Token: 0x06023DA9 RID: 146857 RVA: 0x008F79FC File Offset: 0x008F5BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004F14 RID: 20244
		// (get) Token: 0x06023DAA RID: 146858 RVA: 0x008F7A0E File Offset: 0x008F5C0E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeInfoResponse.Descriptor;
			}
		}

		// Token: 0x06023DAB RID: 146859 RVA: 0x008F7A18 File Offset: 0x008F5C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeInfoResponse()
		{
		}

		// Token: 0x06023DAC RID: 146860 RVA: 0x008F7A90 File Offset: 0x008F5C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeInfoResponse(LifeInfoResponse other)
			: this()
		{
			this.objectPlaceInfo_ = other.objectPlaceInfo_.Clone();
			this.lifeUserInfo_ = ((other.lifeUserInfo_ != null) ? other.lifeUserInfo_.Clone() : null);
			this.lifeItemInfo_ = other.lifeItemInfo_.Clone();
			this.lifeFurnishingsInfo_ = other.lifeFurnishingsInfo_.Clone();
			this.lifeToolInfo_ = other.lifeToolInfo_.Clone();
			this.lifeDurationBuffInfo_ = other.lifeDurationBuffInfo_.Clone();
			this.lifeCitizenList_ = other.lifeCitizenList_.Clone();
			this.lifeCollectionId_ = other.lifeCollectionId_.Clone();
			this.helperInfo_ = other.helperInfo_.Clone();
			this.helperGachaInfo_ = other.helperGachaInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06023DAD RID: 146861 RVA: 0x008F7B69 File Offset: 0x008F5D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeInfoResponse Clone()
		{
			return new LifeInfoResponse(this);
		}

		// Token: 0x17004F15 RID: 20245
		// (get) Token: 0x06023DAE RID: 146862 RVA: 0x008F7B71 File Offset: 0x008F5D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifeWorldObjectPlaceDBInfo> ObjectPlaceInfo
		{
			get
			{
				return this.objectPlaceInfo_;
			}
		}

		// Token: 0x17004F16 RID: 20246
		// (get) Token: 0x06023DAF RID: 146863 RVA: 0x008F7B79 File Offset: 0x008F5D79
		// (set) Token: 0x06023DB0 RID: 146864 RVA: 0x008F7B81 File Offset: 0x008F5D81
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LifeUserDBInfo LifeUserInfo
		{
			get
			{
				return this.lifeUserInfo_;
			}
			set
			{
				this.lifeUserInfo_ = value;
			}
		}

		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x06023DB1 RID: 146865 RVA: 0x008F7B8A File Offset: 0x008F5D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemDBInfo> LifeItemInfo
		{
			get
			{
				return this.lifeItemInfo_;
			}
		}

		// Token: 0x17004F18 RID: 20248
		// (get) Token: 0x06023DB2 RID: 146866 RVA: 0x008F7B92 File Offset: 0x008F5D92
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ItemDBInfo> LifeFurnishingsInfo
		{
			get
			{
				return this.lifeFurnishingsInfo_;
			}
		}

		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x06023DB3 RID: 146867 RVA: 0x008F7B9A File Offset: 0x008F5D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifeToolDBInfo> LifeToolInfo
		{
			get
			{
				return this.lifeToolInfo_;
			}
		}

		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x06023DB4 RID: 146868 RVA: 0x008F7BA2 File Offset: 0x008F5DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifeEatFoodDBInfo> LifeDurationBuffInfo
		{
			get
			{
				return this.lifeDurationBuffInfo_;
			}
		}

		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x06023DB5 RID: 146869 RVA: 0x008F7BAA File Offset: 0x008F5DAA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<LifeCitizenDBInfo> LifeCitizenList
		{
			get
			{
				return this.lifeCitizenList_;
			}
		}

		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x06023DB6 RID: 146870 RVA: 0x008F7BB2 File Offset: 0x008F5DB2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> LifeCollectionId
		{
			get
			{
				return this.lifeCollectionId_;
			}
		}

		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x06023DB7 RID: 146871 RVA: 0x008F7BBA File Offset: 0x008F5DBA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<LifeHelperDBInfo> HelperInfo
		{
			get
			{
				return this.helperInfo_;
			}
		}

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x06023DB8 RID: 146872 RVA: 0x008F7BC2 File Offset: 0x008F5DC2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<LifeHelperGachaDBInfo> HelperGachaInfo
		{
			get
			{
				return this.helperGachaInfo_;
			}
		}

		// Token: 0x06023DB9 RID: 146873 RVA: 0x008F7BCA File Offset: 0x008F5DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeInfoResponse);
		}

		// Token: 0x06023DBA RID: 146874 RVA: 0x008F7BD8 File Offset: 0x008F5DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifeInfoResponse other)
		{
			return other != null && (other == this || (this.objectPlaceInfo_.Equals(other.objectPlaceInfo_) && object.Equals(this.LifeUserInfo, other.LifeUserInfo) && this.lifeItemInfo_.Equals(other.lifeItemInfo_) && this.lifeFurnishingsInfo_.Equals(other.lifeFurnishingsInfo_) && this.lifeToolInfo_.Equals(other.lifeToolInfo_) && this.lifeDurationBuffInfo_.Equals(other.lifeDurationBuffInfo_) && this.lifeCitizenList_.Equals(other.lifeCitizenList_) && this.lifeCollectionId_.Equals(other.lifeCollectionId_) && this.helperInfo_.Equals(other.helperInfo_) && this.helperGachaInfo_.Equals(other.helperGachaInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06023DBB RID: 146875 RVA: 0x008F7CD4 File Offset: 0x008F5ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.objectPlaceInfo_.GetHashCode();
			if (this.lifeUserInfo_ != null)
			{
				num ^= this.LifeUserInfo.GetHashCode();
			}
			num ^= this.lifeItemInfo_.GetHashCode();
			num ^= this.lifeFurnishingsInfo_.GetHashCode();
			num ^= this.lifeToolInfo_.GetHashCode();
			num ^= this.lifeDurationBuffInfo_.GetHashCode();
			num ^= this.lifeCitizenList_.GetHashCode();
			num ^= this.lifeCollectionId_.GetHashCode();
			num ^= this.helperInfo_.GetHashCode();
			num ^= this.helperGachaInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06023DBC RID: 146876 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06023DBD RID: 146877 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06023DBE RID: 146878 RVA: 0x008F7D90 File Offset: 0x008F5F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.objectPlaceInfo_.WriteTo(ref output, LifeInfoResponse._repeated_objectPlaceInfo_codec);
			if (this.lifeUserInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.LifeUserInfo);
			}
			this.lifeItemInfo_.WriteTo(ref output, LifeInfoResponse._repeated_lifeItemInfo_codec);
			this.lifeFurnishingsInfo_.WriteTo(ref output, LifeInfoResponse._repeated_lifeFurnishingsInfo_codec);
			this.lifeToolInfo_.WriteTo(ref output, LifeInfoResponse._repeated_lifeToolInfo_codec);
			this.lifeDurationBuffInfo_.WriteTo(ref output, LifeInfoResponse._repeated_lifeDurationBuffInfo_codec);
			this.lifeCitizenList_.WriteTo(ref output, LifeInfoResponse._repeated_lifeCitizenList_codec);
			this.lifeCollectionId_.WriteTo(ref output, LifeInfoResponse._repeated_lifeCollectionId_codec);
			this.helperInfo_.WriteTo(ref output, LifeInfoResponse._repeated_helperInfo_codec);
			this.helperGachaInfo_.WriteTo(ref output, LifeInfoResponse._repeated_helperGachaInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06023DBF RID: 146879 RVA: 0x008F7E68 File Offset: 0x008F6068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.objectPlaceInfo_.CalculateSize(LifeInfoResponse._repeated_objectPlaceInfo_codec);
			if (this.lifeUserInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LifeUserInfo);
			}
			num += this.lifeItemInfo_.CalculateSize(LifeInfoResponse._repeated_lifeItemInfo_codec);
			num += this.lifeFurnishingsInfo_.CalculateSize(LifeInfoResponse._repeated_lifeFurnishingsInfo_codec);
			num += this.lifeToolInfo_.CalculateSize(LifeInfoResponse._repeated_lifeToolInfo_codec);
			num += this.lifeDurationBuffInfo_.CalculateSize(LifeInfoResponse._repeated_lifeDurationBuffInfo_codec);
			num += this.lifeCitizenList_.CalculateSize(LifeInfoResponse._repeated_lifeCitizenList_codec);
			num += this.lifeCollectionId_.CalculateSize(LifeInfoResponse._repeated_lifeCollectionId_codec);
			num += this.helperInfo_.CalculateSize(LifeInfoResponse._repeated_helperInfo_codec);
			num += this.helperGachaInfo_.CalculateSize(LifeInfoResponse._repeated_helperGachaInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06023DC0 RID: 146880 RVA: 0x008F7F54 File Offset: 0x008F6154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.objectPlaceInfo_.Add(other.objectPlaceInfo_);
			if (other.lifeUserInfo_ != null)
			{
				if (this.lifeUserInfo_ == null)
				{
					this.LifeUserInfo = new LifeUserDBInfo();
				}
				this.LifeUserInfo.MergeFrom(other.LifeUserInfo);
			}
			this.lifeItemInfo_.Add(other.lifeItemInfo_);
			this.lifeFurnishingsInfo_.Add(other.lifeFurnishingsInfo_);
			this.lifeToolInfo_.Add(other.lifeToolInfo_);
			this.lifeDurationBuffInfo_.Add(other.lifeDurationBuffInfo_);
			this.lifeCitizenList_.Add(other.lifeCitizenList_);
			this.lifeCollectionId_.Add(other.lifeCollectionId_);
			this.helperInfo_.Add(other.helperInfo_);
			this.helperGachaInfo_.Add(other.helperGachaInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023DC1 RID: 146881 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06023DC2 RID: 146882 RVA: 0x008F8044 File Offset: 0x008F6244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 42U)
				{
					if (num <= 64U)
					{
						if (num == 50U)
						{
							this.lifeDurationBuffInfo_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_lifeDurationBuffInfo_codec);
							continue;
						}
						if (num == 58U)
						{
							this.lifeCitizenList_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_lifeCitizenList_codec);
							continue;
						}
						if (num != 64U)
						{
							goto IL_006F;
						}
					}
					else if (num != 66U)
					{
						if (num == 74U)
						{
							this.helperInfo_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_helperInfo_codec);
							continue;
						}
						if (num != 82U)
						{
							goto IL_006F;
						}
						this.helperGachaInfo_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_helperGachaInfo_codec);
						continue;
					}
					this.lifeCollectionId_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_lifeCollectionId_codec);
					continue;
				}
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.objectPlaceInfo_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_objectPlaceInfo_codec);
						continue;
					}
					if (num == 18U)
					{
						if (this.lifeUserInfo_ == null)
						{
							this.LifeUserInfo = new LifeUserDBInfo();
						}
						input.ReadMessage(this.LifeUserInfo);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.lifeItemInfo_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_lifeItemInfo_codec);
						continue;
					}
					if (num == 34U)
					{
						this.lifeFurnishingsInfo_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_lifeFurnishingsInfo_codec);
						continue;
					}
					if (num == 42U)
					{
						this.lifeToolInfo_.AddEntriesFrom(ref input, LifeInfoResponse._repeated_lifeToolInfo_codec);
						continue;
					}
				}
				IL_006F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<LifeInfoResponse> _parser = new MessageParser<LifeInfoResponse>(() => new LifeInfoResponse());

		// Token: 0x040187F1 RID: 100337
		private UnknownFieldSet _unknownFields;

		// Token: 0x040187F2 RID: 100338
		public const int ObjectPlaceInfoFieldNumber = 1;

		// Token: 0x040187F3 RID: 100339
		private static readonly FieldCodec<LifeWorldObjectPlaceDBInfo> _repeated_objectPlaceInfo_codec = FieldCodec.ForMessage<LifeWorldObjectPlaceDBInfo>(10U, LifeWorldObjectPlaceDBInfo.Parser);

		// Token: 0x040187F4 RID: 100340
		private readonly RepeatedField<LifeWorldObjectPlaceDBInfo> objectPlaceInfo_ = new RepeatedField<LifeWorldObjectPlaceDBInfo>();

		// Token: 0x040187F5 RID: 100341
		public const int LifeUserInfoFieldNumber = 2;

		// Token: 0x040187F6 RID: 100342
		private LifeUserDBInfo lifeUserInfo_;

		// Token: 0x040187F7 RID: 100343
		public const int LifeItemInfoFieldNumber = 3;

		// Token: 0x040187F8 RID: 100344
		private static readonly FieldCodec<ItemDBInfo> _repeated_lifeItemInfo_codec = FieldCodec.ForMessage<ItemDBInfo>(26U, ItemDBInfo.Parser);

		// Token: 0x040187F9 RID: 100345
		private readonly RepeatedField<ItemDBInfo> lifeItemInfo_ = new RepeatedField<ItemDBInfo>();

		// Token: 0x040187FA RID: 100346
		public const int LifeFurnishingsInfoFieldNumber = 4;

		// Token: 0x040187FB RID: 100347
		private static readonly FieldCodec<ItemDBInfo> _repeated_lifeFurnishingsInfo_codec = FieldCodec.ForMessage<ItemDBInfo>(34U, ItemDBInfo.Parser);

		// Token: 0x040187FC RID: 100348
		private readonly RepeatedField<ItemDBInfo> lifeFurnishingsInfo_ = new RepeatedField<ItemDBInfo>();

		// Token: 0x040187FD RID: 100349
		public const int LifeToolInfoFieldNumber = 5;

		// Token: 0x040187FE RID: 100350
		private static readonly FieldCodec<LifeToolDBInfo> _repeated_lifeToolInfo_codec = FieldCodec.ForMessage<LifeToolDBInfo>(42U, LifeToolDBInfo.Parser);

		// Token: 0x040187FF RID: 100351
		private readonly RepeatedField<LifeToolDBInfo> lifeToolInfo_ = new RepeatedField<LifeToolDBInfo>();

		// Token: 0x04018800 RID: 100352
		public const int LifeDurationBuffInfoFieldNumber = 6;

		// Token: 0x04018801 RID: 100353
		private static readonly FieldCodec<LifeEatFoodDBInfo> _repeated_lifeDurationBuffInfo_codec = FieldCodec.ForMessage<LifeEatFoodDBInfo>(50U, LifeEatFoodDBInfo.Parser);

		// Token: 0x04018802 RID: 100354
		private readonly RepeatedField<LifeEatFoodDBInfo> lifeDurationBuffInfo_ = new RepeatedField<LifeEatFoodDBInfo>();

		// Token: 0x04018803 RID: 100355
		public const int LifeCitizenListFieldNumber = 7;

		// Token: 0x04018804 RID: 100356
		private static readonly FieldCodec<LifeCitizenDBInfo> _repeated_lifeCitizenList_codec = FieldCodec.ForMessage<LifeCitizenDBInfo>(58U, LifeCitizenDBInfo.Parser);

		// Token: 0x04018805 RID: 100357
		private readonly RepeatedField<LifeCitizenDBInfo> lifeCitizenList_ = new RepeatedField<LifeCitizenDBInfo>();

		// Token: 0x04018806 RID: 100358
		public const int LifeCollectionIdFieldNumber = 8;

		// Token: 0x04018807 RID: 100359
		private static readonly FieldCodec<int> _repeated_lifeCollectionId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04018808 RID: 100360
		private readonly RepeatedField<int> lifeCollectionId_ = new RepeatedField<int>();

		// Token: 0x04018809 RID: 100361
		public const int HelperInfoFieldNumber = 9;

		// Token: 0x0401880A RID: 100362
		private static readonly FieldCodec<LifeHelperDBInfo> _repeated_helperInfo_codec = FieldCodec.ForMessage<LifeHelperDBInfo>(74U, LifeHelperDBInfo.Parser);

		// Token: 0x0401880B RID: 100363
		private readonly RepeatedField<LifeHelperDBInfo> helperInfo_ = new RepeatedField<LifeHelperDBInfo>();

		// Token: 0x0401880C RID: 100364
		public const int HelperGachaInfoFieldNumber = 10;

		// Token: 0x0401880D RID: 100365
		private static readonly FieldCodec<LifeHelperGachaDBInfo> _repeated_helperGachaInfo_codec = FieldCodec.ForMessage<LifeHelperGachaDBInfo>(82U, LifeHelperGachaDBInfo.Parser);

		// Token: 0x0401880E RID: 100366
		private readonly RepeatedField<LifeHelperGachaDBInfo> helperGachaInfo_ = new RepeatedField<LifeHelperGachaDBInfo>();
	}
}
