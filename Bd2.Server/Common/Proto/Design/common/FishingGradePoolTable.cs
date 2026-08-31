using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C91 RID: 31889
	public sealed class FishingGradePoolTable : IMessage<FishingGradePoolTable>, IMessage, IEquatable<FishingGradePoolTable>, IDeepCloneable<FishingGradePoolTable>, IBufferMessage
	{
		// Token: 0x17011220 RID: 70176
		// (get) Token: 0x06046C7C RID: 289916 RVA: 0x01136D83 File Offset: 0x01134F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingGradePoolTable> Parser
		{
			get
			{
				return FishingGradePoolTable._parser;
			}
		}

		// Token: 0x17011221 RID: 70177
		// (get) Token: 0x06046C7D RID: 289917 RVA: 0x01136D8A File Offset: 0x01134F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingGradePoolTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011222 RID: 70178
		// (get) Token: 0x06046C7E RID: 289918 RVA: 0x01136D9C File Offset: 0x01134F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingGradePoolTable.Descriptor;
			}
		}

		// Token: 0x06046C7F RID: 289919 RVA: 0x01136DA3 File Offset: 0x01134FA3
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingGradePoolTable()
		{
		}

		// Token: 0x06046C80 RID: 289920 RVA: 0x01136DC4 File Offset: 0x01134FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingGradePoolTable(FishingGradePoolTable other)
			: this()
		{
			this.buffValue_ = other.buffValue_;
			this.grade_ = other.grade_.Clone();
			this.id_ = other.id_;
			this.ratio_ = other.ratio_.Clone();
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046C81 RID: 289921 RVA: 0x01136E2E File Offset: 0x0113502E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingGradePoolTable Clone()
		{
			return new FishingGradePoolTable(this);
		}

		// Token: 0x17011223 RID: 70179
		// (get) Token: 0x06046C82 RID: 289922 RVA: 0x01136E36 File Offset: 0x01135036
		// (set) Token: 0x06046C83 RID: 289923 RVA: 0x01136E3E File Offset: 0x0113503E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffValue
		{
			get
			{
				return this.buffValue_;
			}
			set
			{
				this.buffValue_ = value;
			}
		}

		// Token: 0x17011224 RID: 70180
		// (get) Token: 0x06046C84 RID: 289924 RVA: 0x01136E47 File Offset: 0x01135047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Grade
		{
			get
			{
				return this.grade_;
			}
		}

		// Token: 0x17011225 RID: 70181
		// (get) Token: 0x06046C85 RID: 289925 RVA: 0x01136E4F File Offset: 0x0113504F
		// (set) Token: 0x06046C86 RID: 289926 RVA: 0x01136E57 File Offset: 0x01135057
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17011226 RID: 70182
		// (get) Token: 0x06046C87 RID: 289927 RVA: 0x01136E60 File Offset: 0x01135060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ratio
		{
			get
			{
				return this.ratio_;
			}
		}

		// Token: 0x17011227 RID: 70183
		// (get) Token: 0x06046C88 RID: 289928 RVA: 0x01136E68 File Offset: 0x01135068
		// (set) Token: 0x06046C89 RID: 289929 RVA: 0x01136E70 File Offset: 0x01135070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06046C8A RID: 289930 RVA: 0x01136E79 File Offset: 0x01135079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingGradePoolTable);
		}

		// Token: 0x06046C8B RID: 289931 RVA: 0x01136E88 File Offset: 0x01135088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingGradePoolTable other)
		{
			return other != null && (other == this || (this.BuffValue == other.BuffValue && this.grade_.Equals(other.grade_) && this.Id == other.Id && this.ratio_.Equals(other.ratio_) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046C8C RID: 289932 RVA: 0x01136F0C File Offset: 0x0113510C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffValue != 0)
			{
				num ^= this.BuffValue.GetHashCode();
			}
			num ^= this.grade_.GetHashCode();
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.ratio_.GetHashCode();
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046C8D RID: 289933 RVA: 0x001D5682 File Offset: 0x001D3882
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046C8E RID: 289934 RVA: 0x001D568A File Offset: 0x001D388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046C8F RID: 289935 RVA: 0x01136F9C File Offset: 0x0113519C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffValue != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffValue);
			}
			this.grade_.WriteTo(ref output, FishingGradePoolTable._repeated_grade_codec);
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			this.ratio_.WriteTo(ref output, FishingGradePoolTable._repeated_ratio_codec);
			if (this.Type != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046C90 RID: 289936 RVA: 0x01137034 File Offset: 0x01135234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffValue);
			}
			num += this.grade_.CalculateSize(FishingGradePoolTable._repeated_grade_codec);
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.ratio_.CalculateSize(FishingGradePoolTable._repeated_ratio_codec);
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046C91 RID: 289937 RVA: 0x011370C8 File Offset: 0x011352C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingGradePoolTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffValue != 0)
			{
				this.BuffValue = other.BuffValue;
			}
			this.grade_.Add(other.grade_);
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.ratio_.Add(other.ratio_);
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046C92 RID: 289938 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046C93 RID: 289939 RVA: 0x01137150 File Offset: 0x01135350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 18U)
				{
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num != 32U)
						{
							goto IL_0035;
						}
					}
					else if (num != 34U)
					{
						if (num != 40U)
						{
							goto IL_0035;
						}
						this.Type = input.ReadInt32();
						continue;
					}
					this.ratio_.AddEntriesFrom(ref input, FishingGradePoolTable._repeated_ratio_codec);
					continue;
				}
				if (num == 8U)
				{
					this.BuffValue = input.ReadInt32();
					continue;
				}
				if (num == 16U || num == 18U)
				{
					this.grade_.AddEntriesFrom(ref input, FishingGradePoolTable._repeated_grade_codec);
					continue;
				}
				IL_0035:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EAEB RID: 191211
		private static readonly MessageParser<FishingGradePoolTable> _parser = new MessageParser<FishingGradePoolTable>(() => new FishingGradePoolTable());

		// Token: 0x0402EAEC RID: 191212
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EAED RID: 191213
		public const int BuffValueFieldNumber = 1;

		// Token: 0x0402EAEE RID: 191214
		private int buffValue_;

		// Token: 0x0402EAEF RID: 191215
		public const int GradeFieldNumber = 2;

		// Token: 0x0402EAF0 RID: 191216
		private static readonly FieldCodec<int> _repeated_grade_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0402EAF1 RID: 191217
		private readonly RepeatedField<int> grade_ = new RepeatedField<int>();

		// Token: 0x0402EAF2 RID: 191218
		public const int IdFieldNumber = 3;

		// Token: 0x0402EAF3 RID: 191219
		private int id_;

		// Token: 0x0402EAF4 RID: 191220
		public const int RatioFieldNumber = 4;

		// Token: 0x0402EAF5 RID: 191221
		private static readonly FieldCodec<int> _repeated_ratio_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0402EAF6 RID: 191222
		private readonly RepeatedField<int> ratio_ = new RepeatedField<int>();

		// Token: 0x0402EAF7 RID: 191223
		public const int TypeFieldNumber = 5;

		// Token: 0x0402EAF8 RID: 191224
		private int type_;
	}
}
