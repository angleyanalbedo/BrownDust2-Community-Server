using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005676 RID: 22134
	public sealed class SpineInteractionAchievementInfoResponse : IMessage<SpineInteractionAchievementInfoResponse>, IMessage, IEquatable<SpineInteractionAchievementInfoResponse>, IDeepCloneable<SpineInteractionAchievementInfoResponse>, IBufferMessage
	{
		// Token: 0x17005438 RID: 21560
		// (get) Token: 0x060252C2 RID: 152258 RVA: 0x00927AD7 File Offset: 0x00925CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpineInteractionAchievementInfoResponse> Parser
		{
			get
			{
				return SpineInteractionAchievementInfoResponse._parser;
			}
		}

		// Token: 0x17005439 RID: 21561
		// (get) Token: 0x060252C3 RID: 152259 RVA: 0x00927ADE File Offset: 0x00925CDE
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpineInteractionAchievementInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700543A RID: 21562
		// (get) Token: 0x060252C4 RID: 152260 RVA: 0x00927AF0 File Offset: 0x00925CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpineInteractionAchievementInfoResponse.Descriptor;
			}
		}

		// Token: 0x060252C5 RID: 152261 RVA: 0x00927AF7 File Offset: 0x00925CF7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SpineInteractionAchievementInfoResponse()
		{
		}

		// Token: 0x060252C6 RID: 152262 RVA: 0x00927B0A File Offset: 0x00925D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpineInteractionAchievementInfoResponse(SpineInteractionAchievementInfoResponse other)
			: this()
		{
			this.spineInteractionAchievementInfo_ = other.spineInteractionAchievementInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060252C7 RID: 152263 RVA: 0x00927B34 File Offset: 0x00925D34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SpineInteractionAchievementInfoResponse Clone()
		{
			return new SpineInteractionAchievementInfoResponse(this);
		}

		// Token: 0x1700543B RID: 21563
		// (get) Token: 0x060252C8 RID: 152264 RVA: 0x00927B3C File Offset: 0x00925D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpineInteractionAchievementDBInfo> SpineInteractionAchievementInfo
		{
			get
			{
				return this.spineInteractionAchievementInfo_;
			}
		}

		// Token: 0x060252C9 RID: 152265 RVA: 0x00927B44 File Offset: 0x00925D44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpineInteractionAchievementInfoResponse);
		}

		// Token: 0x060252CA RID: 152266 RVA: 0x00927B52 File Offset: 0x00925D52
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(SpineInteractionAchievementInfoResponse other)
		{
			return other != null && (other == this || (this.spineInteractionAchievementInfo_.Equals(other.spineInteractionAchievementInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060252CB RID: 152267 RVA: 0x00927B88 File Offset: 0x00925D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.spineInteractionAchievementInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060252CC RID: 152268 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060252CD RID: 152269 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060252CE RID: 152270 RVA: 0x00927BBC File Offset: 0x00925DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.spineInteractionAchievementInfo_.WriteTo(ref output, SpineInteractionAchievementInfoResponse._repeated_spineInteractionAchievementInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060252CF RID: 152271 RVA: 0x00927BE4 File Offset: 0x00925DE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.spineInteractionAchievementInfo_.CalculateSize(SpineInteractionAchievementInfoResponse._repeated_spineInteractionAchievementInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060252D0 RID: 152272 RVA: 0x00927C1D File Offset: 0x00925E1D
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(SpineInteractionAchievementInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.spineInteractionAchievementInfo_.Add(other.spineInteractionAchievementInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060252D1 RID: 152273 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060252D2 RID: 152274 RVA: 0x00927C4C File Offset: 0x00925E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.spineInteractionAchievementInfo_.AddEntriesFrom(ref input, SpineInteractionAchievementInfoResponse._repeated_spineInteractionAchievementInfo_codec);
				}
			}
		}
		private static readonly MessageParser<SpineInteractionAchievementInfoResponse> _parser = new MessageParser<SpineInteractionAchievementInfoResponse>(() => new SpineInteractionAchievementInfoResponse());

		// Token: 0x04018FB7 RID: 102327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018FB8 RID: 102328
		public const int SpineInteractionAchievementInfoFieldNumber = 1;

		// Token: 0x04018FB9 RID: 102329
		private static readonly FieldCodec<SpineInteractionAchievementDBInfo> _repeated_spineInteractionAchievementInfo_codec = FieldCodec.ForMessage<SpineInteractionAchievementDBInfo>(10U, SpineInteractionAchievementDBInfo.Parser);

		// Token: 0x04018FBA RID: 102330
		private readonly RepeatedField<SpineInteractionAchievementDBInfo> spineInteractionAchievementInfo_ = new RepeatedField<SpineInteractionAchievementDBInfo>();
	}
}
