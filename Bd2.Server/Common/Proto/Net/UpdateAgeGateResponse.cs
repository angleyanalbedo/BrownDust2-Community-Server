using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200570C RID: 22284
	public sealed class UpdateAgeGateResponse : IMessage<UpdateAgeGateResponse>, IMessage, IEquatable<UpdateAgeGateResponse>, IDeepCloneable<UpdateAgeGateResponse>, IBufferMessage
	{
		// Token: 0x1700554E RID: 21838
		// (get) Token: 0x06025782 RID: 153474 RVA: 0x00931046 File Offset: 0x0092F246
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<UpdateAgeGateResponse> Parser
		{
			get
			{
				return UpdateAgeGateResponse._parser;
			}
		}

		// Token: 0x1700554F RID: 21839
		// (get) Token: 0x06025783 RID: 153475 RVA: 0x0093104D File Offset: 0x0092F24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateAgeGateResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17005550 RID: 21840
		// (get) Token: 0x06025784 RID: 153476 RVA: 0x0093105F File Offset: 0x0092F25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateAgeGateResponse.Descriptor;
			}
		}

		// Token: 0x06025785 RID: 153477 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateAgeGateResponse()
		{
		}

		// Token: 0x06025786 RID: 153478 RVA: 0x00931066 File Offset: 0x0092F266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateAgeGateResponse(UpdateAgeGateResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06025787 RID: 153479 RVA: 0x0093107F File Offset: 0x0092F27F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public UpdateAgeGateResponse Clone()
		{
			return new UpdateAgeGateResponse(this);
		}

		// Token: 0x06025788 RID: 153480 RVA: 0x00931087 File Offset: 0x0092F287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateAgeGateResponse);
		}

		// Token: 0x06025789 RID: 153481 RVA: 0x00931095 File Offset: 0x0092F295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateAgeGateResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0602578A RID: 153482 RVA: 0x009310B4 File Offset: 0x0092F2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0602578B RID: 153483 RVA: 0x001DA70E File Offset: 0x001D890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0602578C RID: 153484 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0602578D RID: 153485 RVA: 0x009310DA File Offset: 0x0092F2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0602578E RID: 153486 RVA: 0x009310F0 File Offset: 0x0092F2F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0602578F RID: 153487 RVA: 0x00931116 File Offset: 0x0092F316
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateAgeGateResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06025790 RID: 153488 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06025791 RID: 153489 RVA: 0x00931133 File Offset: 0x0092F333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04019142 RID: 102722
		private static readonly MessageParser<UpdateAgeGateResponse> _parser = new MessageParser<UpdateAgeGateResponse>(() => new UpdateAgeGateResponse());

		// Token: 0x04019143 RID: 102723
		private UnknownFieldSet _unknownFields;
	}
}
