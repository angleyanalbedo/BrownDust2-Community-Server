using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005262 RID: 21090
	public sealed class FishingInfoResponse : IMessage<FishingInfoResponse>, IMessage, IEquatable<FishingInfoResponse>, IDeepCloneable<FishingInfoResponse>, IBufferMessage
	{
		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x06023015 RID: 143381 RVA: 0x008DC7EF File Offset: 0x008DA9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingInfoResponse> Parser
		{
			get
			{
				return FishingInfoResponse._parser;
			}
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x06023016 RID: 143382 RVA: 0x008DC7F6 File Offset: 0x008DA9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x06023017 RID: 143383 RVA: 0x008DC808 File Offset: 0x008DAA08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfoResponse.Descriptor;
			}
		}

		// Token: 0x06023018 RID: 143384 RVA: 0x008DC80F File Offset: 0x008DAA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoResponse()
		{
		}

		// Token: 0x06023019 RID: 143385 RVA: 0x008DC830 File Offset: 0x008DAA30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingInfoResponse(FishingInfoResponse other)
			: this()
		{
			this.fishInfo_ = ((other.fishInfo_ != null) ? other.fishInfo_.Clone() : null);
			this.mapId_ = other.mapId_.Clone();
			this.boatSkinId_ = other.boatSkinId_.Clone();
			this.rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0602301A RID: 143386 RVA: 0x008DC8AE File Offset: 0x008DAAAE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingInfoResponse Clone()
		{
			return new FishingInfoResponse(this);
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x0602301B RID: 143387 RVA: 0x008DC8B6 File Offset: 0x008DAAB6
		// (set) Token: 0x0602301C RID: 143388 RVA: 0x008DC8BE File Offset: 0x008DAABE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingDBInfo FishInfo
		{
			get
			{
				return this.fishInfo_;
			}
			set
			{
				this.fishInfo_ = value;
			}
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x0602301D RID: 143389 RVA: 0x008DC8C7 File Offset: 0x008DAAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MapId
		{
			get
			{
				return this.mapId_;
			}
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x0602301E RID: 143390 RVA: 0x008DC8CF File Offset: 0x008DAACF
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> BoatSkinId
		{
			get
			{
				return this.boatSkinId_;
			}
		}

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x0602301F RID: 143391 RVA: 0x008DC8D7 File Offset: 0x008DAAD7
		// (set) Token: 0x06023020 RID: 143392 RVA: 0x008DC8DF File Offset: 0x008DAADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardDBInfoBundle RewardInfoBundle
		{
			get
			{
				return this.rewardInfoBundle_;
			}
			set
			{
				this.rewardInfoBundle_ = value;
			}
		}

		// Token: 0x06023021 RID: 143393 RVA: 0x008DC8E8 File Offset: 0x008DAAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfoResponse);
		}

		// Token: 0x06023022 RID: 143394 RVA: 0x008DC8F8 File Offset: 0x008DAAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.FishInfo, other.FishInfo) && this.mapId_.Equals(other.mapId_) && this.boatSkinId_.Equals(other.boatSkinId_) && object.Equals(this.RewardInfoBundle, other.RewardInfoBundle) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06023023 RID: 143395 RVA: 0x008DC978 File Offset: 0x008DAB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fishInfo_ != null)
			{
				num ^= this.FishInfo.GetHashCode();
			}
			num ^= this.mapId_.GetHashCode();
			num ^= this.boatSkinId_.GetHashCode();
			if (this.rewardInfoBundle_ != null)
			{
				num ^= this.RewardInfoBundle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06023024 RID: 143396 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06023025 RID: 143397 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06023026 RID: 143398 RVA: 0x008DC9E8 File Offset: 0x008DABE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FishInfo);
			}
			this.mapId_.WriteTo(ref output, FishingInfoResponse._repeated_mapId_codec);
			this.boatSkinId_.WriteTo(ref output, FishingInfoResponse._repeated_boatSkinId_codec);
			if (this.rewardInfoBundle_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RewardInfoBundle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06023027 RID: 143399 RVA: 0x008DCA64 File Offset: 0x008DAC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishInfo);
			}
			num += this.mapId_.CalculateSize(FishingInfoResponse._repeated_mapId_codec);
			num += this.boatSkinId_.CalculateSize(FishingInfoResponse._repeated_boatSkinId_codec);
			if (this.rewardInfoBundle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardInfoBundle);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06023028 RID: 143400 RVA: 0x008DCAE0 File Offset: 0x008DACE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fishInfo_ != null)
			{
				if (this.fishInfo_ == null)
				{
					this.FishInfo = new FishingDBInfo();
				}
				this.FishInfo.MergeFrom(other.FishInfo);
			}
			this.mapId_.Add(other.mapId_);
			this.boatSkinId_.Add(other.boatSkinId_);
			if (other.rewardInfoBundle_ != null)
			{
				if (this.rewardInfoBundle_ == null)
				{
					this.RewardInfoBundle = new RewardDBInfoBundle();
				}
				this.RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023029 RID: 143401 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0602302A RID: 143402 RVA: 0x008DCB84 File Offset: 0x008DAD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.fishInfo_ == null)
						{
							this.FishInfo = new FishingDBInfo();
						}
						input.ReadMessage(this.FishInfo);
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.mapId_.AddEntriesFrom(ref input, FishingInfoResponse._repeated_mapId_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.boatSkinId_.AddEntriesFrom(ref input, FishingInfoResponse._repeated_boatSkinId_codec);
						continue;
					}
					if (num == 34U)
					{
						if (this.rewardInfoBundle_ == null)
						{
							this.RewardInfoBundle = new RewardDBInfoBundle();
						}
						input.ReadMessage(this.RewardInfoBundle);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<FishingInfoResponse> _parser = new MessageParser<FishingInfoResponse>(() => new FishingInfoResponse());

		// Token: 0x0401839B RID: 99227
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401839C RID: 99228
		public const int FishInfoFieldNumber = 1;

		// Token: 0x0401839D RID: 99229
		private FishingDBInfo fishInfo_;

		// Token: 0x0401839E RID: 99230
		public const int MapIdFieldNumber = 2;

		// Token: 0x0401839F RID: 99231
		private static readonly FieldCodec<int> _repeated_mapId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040183A0 RID: 99232
		private readonly RepeatedField<int> mapId_ = new RepeatedField<int>();

		// Token: 0x040183A1 RID: 99233
		public const int BoatSkinIdFieldNumber = 3;

		// Token: 0x040183A2 RID: 99234
		private static readonly FieldCodec<int> _repeated_boatSkinId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040183A3 RID: 99235
		private readonly RepeatedField<int> boatSkinId_ = new RepeatedField<int>();

		// Token: 0x040183A4 RID: 99236
		public const int RewardInfoBundleFieldNumber = 4;

		// Token: 0x040183A5 RID: 99237
		private RewardDBInfoBundle rewardInfoBundle_;
	}
}
