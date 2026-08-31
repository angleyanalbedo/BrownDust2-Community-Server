using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005256 RID: 21078
	public sealed class FishingCollectionInfoResponse : IMessage<FishingCollectionInfoResponse>, IMessage, IEquatable<FishingCollectionInfoResponse>, IDeepCloneable<FishingCollectionInfoResponse>, IBufferMessage
	{
		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x06022FB0 RID: 143280 RVA: 0x008DBB3B File Offset: 0x008D9D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingCollectionInfoResponse> Parser
		{
			get
			{
				return FishingCollectionInfoResponse._parser;
			}
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x06022FB1 RID: 143281 RVA: 0x008DBB42 File Offset: 0x008D9D42
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingCollectionInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004BE4 RID: 19428
		// (get) Token: 0x06022FB2 RID: 143282 RVA: 0x008DBB54 File Offset: 0x008D9D54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCollectionInfoResponse.Descriptor;
			}
		}

		// Token: 0x06022FB3 RID: 143283 RVA: 0x008DBB5B File Offset: 0x008D9D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCollectionInfoResponse()
		{
		}

		// Token: 0x06022FB4 RID: 143284 RVA: 0x008DBB6E File Offset: 0x008D9D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCollectionInfoResponse(FishingCollectionInfoResponse other)
			: this()
		{
			this.collectionInfo_ = other.collectionInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06022FB5 RID: 143285 RVA: 0x008DBB98 File Offset: 0x008D9D98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingCollectionInfoResponse Clone()
		{
			return new FishingCollectionInfoResponse(this);
		}

		// Token: 0x17004BE5 RID: 19429
		// (get) Token: 0x06022FB6 RID: 143286 RVA: 0x008DBBA0 File Offset: 0x008D9DA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FishingCollectionDBInfo> CollectionInfo
		{
			get
			{
				return this.collectionInfo_;
			}
		}

		// Token: 0x06022FB7 RID: 143287 RVA: 0x008DBBA8 File Offset: 0x008D9DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCollectionInfoResponse);
		}

		// Token: 0x06022FB8 RID: 143288 RVA: 0x008DBBB6 File Offset: 0x008D9DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCollectionInfoResponse other)
		{
			return other != null && (other == this || (this.collectionInfo_.Equals(other.collectionInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06022FB9 RID: 143289 RVA: 0x008DBBEC File Offset: 0x008D9DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.collectionInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06022FBA RID: 143290 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06022FBB RID: 143291 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06022FBC RID: 143292 RVA: 0x008DBC20 File Offset: 0x008D9E20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.collectionInfo_.WriteTo(ref output, FishingCollectionInfoResponse._repeated_collectionInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06022FBD RID: 143293 RVA: 0x008DBC48 File Offset: 0x008D9E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.collectionInfo_.CalculateSize(FishingCollectionInfoResponse._repeated_collectionInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06022FBE RID: 143294 RVA: 0x008DBC81 File Offset: 0x008D9E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCollectionInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.collectionInfo_.Add(other.collectionInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06022FBF RID: 143295 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06022FC0 RID: 143296 RVA: 0x008DBCB0 File Offset: 0x008D9EB0
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
					this.collectionInfo_.AddEntriesFrom(ref input, FishingCollectionInfoResponse._repeated_collectionInfo_codec);
				}
			}
		}
		private static readonly MessageParser<FishingCollectionInfoResponse> _parser = new MessageParser<FishingCollectionInfoResponse>(() => new FishingCollectionInfoResponse());

		// Token: 0x0401837C RID: 99196
		private UnknownFieldSet _unknownFields;

		// Token: 0x0401837D RID: 99197
		public const int CollectionInfoFieldNumber = 1;

		// Token: 0x0401837E RID: 99198
		private static readonly FieldCodec<FishingCollectionDBInfo> _repeated_collectionInfo_codec = FieldCodec.ForMessage<FishingCollectionDBInfo>(10U, FishingCollectionDBInfo.Parser);

		// Token: 0x0401837F RID: 99199
		private readonly RepeatedField<FishingCollectionDBInfo> collectionInfo_ = new RepeatedField<FishingCollectionDBInfo>();
	}
}
