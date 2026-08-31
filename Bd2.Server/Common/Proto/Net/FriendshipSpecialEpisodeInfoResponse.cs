using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020052B3 RID: 21171
	public sealed class FriendshipSpecialEpisodeInfoResponse : IMessage<FriendshipSpecialEpisodeInfoResponse>, IMessage, IEquatable<FriendshipSpecialEpisodeInfoResponse>, IDeepCloneable<FriendshipSpecialEpisodeInfoResponse>, IBufferMessage
	{
		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x060232BB RID: 144059 RVA: 0x008E1F7F File Offset: 0x008E017F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendshipSpecialEpisodeInfoResponse> Parser
		{
			get
			{
				return FriendshipSpecialEpisodeInfoResponse._parser;
			}
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x060232BC RID: 144060 RVA: 0x008E1F86 File Offset: 0x008E0186
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x060232BD RID: 144061 RVA: 0x008E1F98 File Offset: 0x008E0198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeInfoResponse.Descriptor;
			}
		}

		// Token: 0x060232BE RID: 144062 RVA: 0x008E1F9F File Offset: 0x008E019F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipSpecialEpisodeInfoResponse()
		{
		}

		// Token: 0x060232BF RID: 144063 RVA: 0x008E1FB2 File Offset: 0x008E01B2
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FriendshipSpecialEpisodeInfoResponse(FriendshipSpecialEpisodeInfoResponse other)
			: this()
		{
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060232C0 RID: 144064 RVA: 0x008E1FDC File Offset: 0x008E01DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendshipSpecialEpisodeInfoResponse Clone()
		{
			return new FriendshipSpecialEpisodeInfoResponse(this);
		}

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x060232C1 RID: 144065 RVA: 0x008E1FE4 File Offset: 0x008E01E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FriendshipSpecialEpisodeDBInfo> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x060232C2 RID: 144066 RVA: 0x008E1FEC File Offset: 0x008E01EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendshipSpecialEpisodeInfoResponse);
		}

		// Token: 0x060232C3 RID: 144067 RVA: 0x008E1FFA File Offset: 0x008E01FA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(FriendshipSpecialEpisodeInfoResponse other)
		{
			return other != null && (other == this || (this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060232C4 RID: 144068 RVA: 0x008E2030 File Offset: 0x008E0230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060232C5 RID: 144069 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060232C6 RID: 144070 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060232C7 RID: 144071 RVA: 0x008E2064 File Offset: 0x008E0264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.info_.WriteTo(ref output, FriendshipSpecialEpisodeInfoResponse._repeated_info_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060232C8 RID: 144072 RVA: 0x008E208C File Offset: 0x008E028C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.info_.CalculateSize(FriendshipSpecialEpisodeInfoResponse._repeated_info_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060232C9 RID: 144073 RVA: 0x008E20C5 File Offset: 0x008E02C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendshipSpecialEpisodeInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.info_.Add(other.info_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060232CA RID: 144074 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060232CB RID: 144075 RVA: 0x008E20F4 File Offset: 0x008E02F4
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
					this.info_.AddEntriesFrom(ref input, FriendshipSpecialEpisodeInfoResponse._repeated_info_codec);
				}
			}
		}
		private static readonly MessageParser<FriendshipSpecialEpisodeInfoResponse> _parser = new MessageParser<FriendshipSpecialEpisodeInfoResponse>(() => new FriendshipSpecialEpisodeInfoResponse());

		// Token: 0x0401847B RID: 99451
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401847C RID: 99452
		public const int InfoFieldNumber = 1;

		// Token: 0x0401847D RID: 99453
		private static readonly FieldCodec<FriendshipSpecialEpisodeDBInfo> _repeated_info_codec = FieldCodec.ForMessage<FriendshipSpecialEpisodeDBInfo>(10U, FriendshipSpecialEpisodeDBInfo.Parser);

		// Token: 0x0401847E RID: 99454
		private readonly RepeatedField<FriendshipSpecialEpisodeDBInfo> info_ = new RepeatedField<FriendshipSpecialEpisodeDBInfo>();
	}
}
