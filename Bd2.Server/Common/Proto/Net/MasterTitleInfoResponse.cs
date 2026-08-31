using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005455 RID: 21589
	public sealed class MasterTitleInfoResponse : IMessage<MasterTitleInfoResponse>, IMessage, IEquatable<MasterTitleInfoResponse>, IDeepCloneable<MasterTitleInfoResponse>, IBufferMessage
	{
		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x06024076 RID: 147574 RVA: 0x008FE6A8 File Offset: 0x008FC8A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MasterTitleInfoResponse> Parser
		{
			get
			{
				return MasterTitleInfoResponse._parser;
			}
		}

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x06024077 RID: 147575 RVA: 0x008FE6AF File Offset: 0x008FC8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MasterTitleInfoResponseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x06024078 RID: 147576 RVA: 0x008FE6C1 File Offset: 0x008FC8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MasterTitleInfoResponse.Descriptor;
			}
		}

		// Token: 0x06024079 RID: 147577 RVA: 0x008FE6C8 File Offset: 0x008FC8C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MasterTitleInfoResponse()
		{
		}

		// Token: 0x0602407A RID: 147578 RVA: 0x008FE6DB File Offset: 0x008FC8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MasterTitleInfoResponse(MasterTitleInfoResponse other)
			: this()
		{
			this.name_ = other.name_;
			this.month_ = other.month_;
			this.day_ = other.day_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0602407B RID: 147579 RVA: 0x008FE718 File Offset: 0x008FC918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MasterTitleInfoResponse Clone()
		{
			return new MasterTitleInfoResponse(this);
		}

		// Token: 0x17004FCA RID: 20426
		// (get) Token: 0x0602407C RID: 147580 RVA: 0x008FE720 File Offset: 0x008FC920
		// (set) Token: 0x0602407D RID: 147581 RVA: 0x008FE728 File Offset: 0x008FC928
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x0602407E RID: 147582 RVA: 0x008FE73B File Offset: 0x008FC93B
		// (set) Token: 0x0602407F RID: 147583 RVA: 0x008FE743 File Offset: 0x008FC943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Month
		{
			get
			{
				return this.month_;
			}
			set
			{
				this.month_ = value;
			}
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x06024080 RID: 147584 RVA: 0x008FE74C File Offset: 0x008FC94C
		// (set) Token: 0x06024081 RID: 147585 RVA: 0x008FE754 File Offset: 0x008FC954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Day
		{
			get
			{
				return this.day_;
			}
			set
			{
				this.day_ = value;
			}
		}

		// Token: 0x06024082 RID: 147586 RVA: 0x008FE75D File Offset: 0x008FC95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MasterTitleInfoResponse);
		}

		// Token: 0x06024083 RID: 147587 RVA: 0x008FE76C File Offset: 0x008FC96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MasterTitleInfoResponse other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.Month == other.Month && this.Day == other.Day && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06024084 RID: 147588 RVA: 0x008FE7CC File Offset: 0x008FC9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Month != 0)
			{
				num ^= this.Month.GetHashCode();
			}
			if (this.Day != 0)
			{
				num ^= this.Day.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06024085 RID: 147589 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06024086 RID: 147590 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06024087 RID: 147591 RVA: 0x008FE840 File Offset: 0x008FCA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this.Month != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Month);
			}
			if (this.Day != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Day);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06024088 RID: 147592 RVA: 0x008FE8BC File Offset: 0x008FCABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Month != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Month);
			}
			if (this.Day != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Day);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06024089 RID: 147593 RVA: 0x008FE930 File Offset: 0x008FCB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MasterTitleInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Month != 0)
			{
				this.Month = other.Month;
			}
			if (other.Day != 0)
			{
				this.Day = other.Day;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0602408A RID: 147594 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0602408B RID: 147595 RVA: 0x008FE99C File Offset: 0x008FCB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Day = input.ReadInt32();
						}
					}
					else
					{
						this.Month = input.ReadInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}
		private static readonly MessageParser<MasterTitleInfoResponse> _parser = new MessageParser<MasterTitleInfoResponse>(() => new MasterTitleInfoResponse());

		// Token: 0x04018907 RID: 100615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04018908 RID: 100616
		public const int NameFieldNumber = 1;

		// Token: 0x04018909 RID: 100617
		private string name_ = "";

		// Token: 0x0401890A RID: 100618
		public const int MonthFieldNumber = 2;

		// Token: 0x0401890B RID: 100619
		private int month_;

		// Token: 0x0401890C RID: 100620
		public const int DayFieldNumber = 3;

		// Token: 0x0401890D RID: 100621
		private int day_;
	}
}
