using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200541B RID: 21531
	public sealed class LifeUserInfoResponse : IMessage<LifeUserInfoResponse>, IMessage, IEquatable<LifeUserInfoResponse>, IDeepCloneable<LifeUserInfoResponse>, IBufferMessage
	{
		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x06023E5D RID: 147037 RVA: 0x008F94E3 File Offset: 0x008F76E3
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<LifeUserInfoResponse> Parser
		{
			get
			{
				return LifeUserInfoResponse._parser;
			}
		}

		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x06023E5E RID: 147038 RVA: 0x008F94EA File Offset: 0x008F76EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeUserInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x06023E5F RID: 147039 RVA: 0x008F94FC File Offset: 0x008F76FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeUserInfoResponse.Descriptor;
			}
		}

		// Token: 0x06023E60 RID: 147040 RVA: 0x008F9503 File Offset: 0x008F7703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeUserInfoResponse()
		{
		}

		// Token: 0x06023E61 RID: 147041 RVA: 0x008F9524 File Offset: 0x008F7724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeUserInfoResponse(LifeUserInfoResponse other)
			: this()
		{
			this.lifeUserInfo_ = ((other.lifeUserInfo_ != null) ? other.lifeUserInfo_.Clone() : null);
			this.lifeCitizenList_ = other.lifeCitizenList_.Clone();
			this.helperInfo_ = other.helperInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06023E62 RID: 147042 RVA: 0x008F9586 File Offset: 0x008F7786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeUserInfoResponse Clone()
		{
			return new LifeUserInfoResponse(this);
		}

		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x06023E63 RID: 147043 RVA: 0x008F958E File Offset: 0x008F778E
		// (set) Token: 0x06023E64 RID: 147044 RVA: 0x008F9596 File Offset: 0x008F7796
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

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x06023E65 RID: 147045 RVA: 0x008F959F File Offset: 0x008F779F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifeCitizenDBInfo> LifeCitizenList
		{
			get
			{
				return this.lifeCitizenList_;
			}
		}

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x06023E66 RID: 147046 RVA: 0x008F95A7 File Offset: 0x008F77A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LifeHelperDBInfo> HelperInfo
		{
			get
			{
				return this.helperInfo_;
			}
		}

		// Token: 0x06023E67 RID: 147047 RVA: 0x008F95AF File Offset: 0x008F77AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeUserInfoResponse);
		}

		// Token: 0x06023E68 RID: 147048 RVA: 0x008F95C0 File Offset: 0x008F77C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(LifeUserInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.LifeUserInfo, other.LifeUserInfo) && this.lifeCitizenList_.Equals(other.lifeCitizenList_) && this.helperInfo_.Equals(other.helperInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06023E69 RID: 147049 RVA: 0x008F9628 File Offset: 0x008F7828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lifeUserInfo_ != null)
			{
				num ^= this.LifeUserInfo.GetHashCode();
			}
			num ^= this.lifeCitizenList_.GetHashCode();
			num ^= this.helperInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06023E6A RID: 147050 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06023E6B RID: 147051 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06023E6C RID: 147052 RVA: 0x008F9680 File Offset: 0x008F7880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lifeUserInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.LifeUserInfo);
			}
			this.lifeCitizenList_.WriteTo(ref output, LifeUserInfoResponse._repeated_lifeCitizenList_codec);
			this.helperInfo_.WriteTo(ref output, LifeUserInfoResponse._repeated_helperInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06023E6D RID: 147053 RVA: 0x008F96E0 File Offset: 0x008F78E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lifeUserInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LifeUserInfo);
			}
			num += this.lifeCitizenList_.CalculateSize(LifeUserInfoResponse._repeated_lifeCitizenList_codec);
			num += this.helperInfo_.CalculateSize(LifeUserInfoResponse._repeated_helperInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06023E6E RID: 147054 RVA: 0x008F9744 File Offset: 0x008F7944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeUserInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lifeUserInfo_ != null)
			{
				if (this.lifeUserInfo_ == null)
				{
					this.LifeUserInfo = new LifeUserDBInfo();
				}
				this.LifeUserInfo.MergeFrom(other.LifeUserInfo);
			}
			this.lifeCitizenList_.Add(other.lifeCitizenList_);
			this.helperInfo_.Add(other.helperInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06023E6F RID: 147055 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06023E70 RID: 147056 RVA: 0x008F97BC File Offset: 0x008F79BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 26U)
					{
						if (num != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.helperInfo_.AddEntriesFrom(ref input, LifeUserInfoResponse._repeated_helperInfo_codec);
						}
					}
					else
					{
						this.lifeCitizenList_.AddEntriesFrom(ref input, LifeUserInfoResponse._repeated_lifeCitizenList_codec);
					}
				}
				else
				{
					if (this.lifeUserInfo_ == null)
					{
						this.LifeUserInfo = new LifeUserDBInfo();
					}
					input.ReadMessage(this.LifeUserInfo);
				}
			}
		}
		private static readonly MessageParser<LifeUserInfoResponse> _parser = new MessageParser<LifeUserInfoResponse>(() => new LifeUserInfoResponse());

		// Token: 0x0401883E RID: 100414
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401883F RID: 100415
		public const int LifeUserInfoFieldNumber = 2;

		// Token: 0x04018840 RID: 100416
		private LifeUserDBInfo lifeUserInfo_;

		// Token: 0x04018841 RID: 100417
		public const int LifeCitizenListFieldNumber = 3;

		// Token: 0x04018842 RID: 100418
		private static readonly FieldCodec<LifeCitizenDBInfo> _repeated_lifeCitizenList_codec = FieldCodec.ForMessage<LifeCitizenDBInfo>(26U, LifeCitizenDBInfo.Parser);

		// Token: 0x04018843 RID: 100419
		private readonly RepeatedField<LifeCitizenDBInfo> lifeCitizenList_ = new RepeatedField<LifeCitizenDBInfo>();

		// Token: 0x04018844 RID: 100420
		public const int HelperInfoFieldNumber = 4;

		// Token: 0x04018845 RID: 100421
		private static readonly FieldCodec<LifeHelperDBInfo> _repeated_helperInfo_codec = FieldCodec.ForMessage<LifeHelperDBInfo>(34U, LifeHelperDBInfo.Parser);

		// Token: 0x04018846 RID: 100422
		private readonly RepeatedField<LifeHelperDBInfo> helperInfo_ = new RepeatedField<LifeHelperDBInfo>();
	}
}
