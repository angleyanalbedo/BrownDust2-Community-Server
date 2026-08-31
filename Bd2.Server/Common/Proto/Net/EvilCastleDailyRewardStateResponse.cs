using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005191 RID: 20881
	public sealed class EvilCastleDailyRewardStateResponse : IMessage<EvilCastleDailyRewardStateResponse>, IMessage, IEquatable<EvilCastleDailyRewardStateResponse>, IDeepCloneable<EvilCastleDailyRewardStateResponse>, IBufferMessage
	{
		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x060228E6 RID: 141542 RVA: 0x008CB945 File Offset: 0x008C9B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvilCastleDailyRewardStateResponse> Parser
		{
			get
			{
				return EvilCastleDailyRewardStateResponse._parser;
			}
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x060228E7 RID: 141543 RVA: 0x008CB94C File Offset: 0x008C9B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvilCastleDailyRewardStateResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x060228E8 RID: 141544 RVA: 0x008CB95E File Offset: 0x008C9B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvilCastleDailyRewardStateResponse.Descriptor;
			}
		}

		// Token: 0x060228E9 RID: 141545 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvilCastleDailyRewardStateResponse()
		{
		}

		// Token: 0x060228EA RID: 141546 RVA: 0x008CB965 File Offset: 0x008C9B65
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EvilCastleDailyRewardStateResponse(EvilCastleDailyRewardStateResponse other)
			: this()
		{
			this.isObtainableDailyReward_ = other.isObtainableDailyReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060228EB RID: 141547 RVA: 0x008CB98A File Offset: 0x008C9B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvilCastleDailyRewardStateResponse Clone()
		{
			return new EvilCastleDailyRewardStateResponse(this);
		}

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x060228EC RID: 141548 RVA: 0x008CB992 File Offset: 0x008C9B92
		// (set) Token: 0x060228ED RID: 141549 RVA: 0x008CB99A File Offset: 0x008C9B9A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsObtainableDailyReward
		{
			get
			{
				return this.isObtainableDailyReward_;
			}
			set
			{
				this.isObtainableDailyReward_ = value;
			}
		}

		// Token: 0x060228EE RID: 141550 RVA: 0x008CB9A3 File Offset: 0x008C9BA3
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvilCastleDailyRewardStateResponse);
		}

		// Token: 0x060228EF RID: 141551 RVA: 0x008CB9B1 File Offset: 0x008C9BB1
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Equals(EvilCastleDailyRewardStateResponse other)
		{
			return other != null && (other == this || (this.IsObtainableDailyReward == other.IsObtainableDailyReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060228F0 RID: 141552 RVA: 0x008CB9E0 File Offset: 0x008C9BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsObtainableDailyReward)
			{
				num ^= this.IsObtainableDailyReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060228F1 RID: 141553 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060228F2 RID: 141554 RVA: 0x001DA716 File Offset: 0x001D8916
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060228F3 RID: 141555 RVA: 0x008CBA1F File Offset: 0x008C9C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsObtainableDailyReward)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsObtainableDailyReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060228F4 RID: 141556 RVA: 0x008CBA50 File Offset: 0x008C9C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsObtainableDailyReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060228F5 RID: 141557 RVA: 0x008CBA82 File Offset: 0x008C9C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvilCastleDailyRewardStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsObtainableDailyReward)
			{
				this.IsObtainableDailyReward = other.IsObtainableDailyReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060228F6 RID: 141558 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060228F7 RID: 141559 RVA: 0x008CBAB4 File Offset: 0x008C9CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsObtainableDailyReward = input.ReadBool();
				}
			}
		}
		private static readonly MessageParser<EvilCastleDailyRewardStateResponse> _parser = new MessageParser<EvilCastleDailyRewardStateResponse>(() => new EvilCastleDailyRewardStateResponse());

		// Token: 0x040180FD RID: 98557
		private UnknownFieldSet _unknownFields;

		// Token: 0x040180FE RID: 98558
		public const int IsObtainableDailyRewardFieldNumber = 1;

		// Token: 0x040180FF RID: 98559
		private bool isObtainableDailyReward_;
	}
}
