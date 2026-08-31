using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020045FE RID: 17918
	public sealed class LifeCharLevelDBInfo : IMessage<LifeCharLevelDBInfo>, IMessage, IEquatable<LifeCharLevelDBInfo>, IDeepCloneable<LifeCharLevelDBInfo>, IBufferMessage
	{
		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0601BF8D RID: 114573 RVA: 0x007DD45F File Offset: 0x007DB65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LifeCharLevelDBInfo> Parser
		{
			get
			{
				return LifeCharLevelDBInfo._parser;
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x0601BF8E RID: 114574 RVA: 0x007DD466 File Offset: 0x007DB666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LifeCharLevelDBInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0601BF8F RID: 114575 RVA: 0x007DD478 File Offset: 0x007DB678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifeCharLevelDBInfo.Descriptor;
			}
		}

		// Token: 0x0601BF90 RID: 114576 RVA: 0x000022D6 File Offset: 0x000004D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeCharLevelDBInfo()
		{
		}

		// Token: 0x0601BF91 RID: 114577 RVA: 0x007DD480 File Offset: 0x007DB680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeCharLevelDBInfo(LifeCharLevelDBInfo other)
			: this()
		{
			this.loggingLevel_ = other.loggingLevel_;
			this.loggingExp_ = other.loggingExp_;
			this.miningLevel_ = other.miningLevel_;
			this.miningExp_ = other.miningExp_;
			this.farmingLevel_ = other.farmingLevel_;
			this.farmingExp_ = other.farmingExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF92 RID: 114578 RVA: 0x007DD4EC File Offset: 0x007DB6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifeCharLevelDBInfo Clone()
		{
			return new LifeCharLevelDBInfo(this);
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0601BF93 RID: 114579 RVA: 0x007DD4F4 File Offset: 0x007DB6F4
		// (set) Token: 0x0601BF94 RID: 114580 RVA: 0x007DD4FC File Offset: 0x007DB6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoggingLevel
		{
			get
			{
				return this.loggingLevel_;
			}
			set
			{
				this.loggingLevel_ = value;
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x0601BF95 RID: 114581 RVA: 0x007DD505 File Offset: 0x007DB705
		// (set) Token: 0x0601BF96 RID: 114582 RVA: 0x007DD50D File Offset: 0x007DB70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoggingExp
		{
			get
			{
				return this.loggingExp_;
			}
			set
			{
				this.loggingExp_ = value;
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0601BF97 RID: 114583 RVA: 0x007DD516 File Offset: 0x007DB716
		// (set) Token: 0x0601BF98 RID: 114584 RVA: 0x007DD51E File Offset: 0x007DB71E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MiningLevel
		{
			get
			{
				return this.miningLevel_;
			}
			set
			{
				this.miningLevel_ = value;
			}
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0601BF99 RID: 114585 RVA: 0x007DD527 File Offset: 0x007DB727
		// (set) Token: 0x0601BF9A RID: 114586 RVA: 0x007DD52F File Offset: 0x007DB72F
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MiningExp
		{
			get
			{
				return this.miningExp_;
			}
			set
			{
				this.miningExp_ = value;
			}
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0601BF9B RID: 114587 RVA: 0x007DD538 File Offset: 0x007DB738
		// (set) Token: 0x0601BF9C RID: 114588 RVA: 0x007DD540 File Offset: 0x007DB740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FarmingLevel
		{
			get
			{
				return this.farmingLevel_;
			}
			set
			{
				this.farmingLevel_ = value;
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x0601BF9D RID: 114589 RVA: 0x007DD549 File Offset: 0x007DB749
		// (set) Token: 0x0601BF9E RID: 114590 RVA: 0x007DD551 File Offset: 0x007DB751
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FarmingExp
		{
			get
			{
				return this.farmingExp_;
			}
			set
			{
				this.farmingExp_ = value;
			}
		}

		// Token: 0x0601BF9F RID: 114591 RVA: 0x007DD55A File Offset: 0x007DB75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifeCharLevelDBInfo);
		}

		// Token: 0x0601BFA0 RID: 114592 RVA: 0x007DD568 File Offset: 0x007DB768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifeCharLevelDBInfo other)
		{
			return other != null && (other == this || (this.LoggingLevel == other.LoggingLevel && this.LoggingExp == other.LoggingExp && this.MiningLevel == other.MiningLevel && this.MiningExp == other.MiningExp && this.FarmingLevel == other.FarmingLevel && this.FarmingExp == other.FarmingExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFA1 RID: 114593 RVA: 0x007DD5F4 File Offset: 0x007DB7F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoggingLevel != 0)
			{
				num ^= this.LoggingLevel.GetHashCode();
			}
			if (this.LoggingExp != 0)
			{
				num ^= this.LoggingExp.GetHashCode();
			}
			if (this.MiningLevel != 0)
			{
				num ^= this.MiningLevel.GetHashCode();
			}
			if (this.MiningExp != 0)
			{
				num ^= this.MiningExp.GetHashCode();
			}
			if (this.FarmingLevel != 0)
			{
				num ^= this.FarmingLevel.GetHashCode();
			}
			if (this.FarmingExp != 0)
			{
				num ^= this.FarmingExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BFA2 RID: 114594 RVA: 0x001DA70E File Offset: 0x001D890E
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0601BFA3 RID: 114595 RVA: 0x001DA716 File Offset: 0x001D8916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFA4 RID: 114596 RVA: 0x007DD6B0 File Offset: 0x007DB8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoggingLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LoggingLevel);
			}
			if (this.LoggingExp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LoggingExp);
			}
			if (this.MiningLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MiningLevel);
			}
			if (this.MiningExp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MiningExp);
			}
			if (this.FarmingLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FarmingLevel);
			}
			if (this.FarmingExp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FarmingExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BFA5 RID: 114597 RVA: 0x007DD778 File Offset: 0x007DB978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoggingLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoggingLevel);
			}
			if (this.LoggingExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoggingExp);
			}
			if (this.MiningLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MiningLevel);
			}
			if (this.MiningExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MiningExp);
			}
			if (this.FarmingLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FarmingLevel);
			}
			if (this.FarmingExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FarmingExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BFA6 RID: 114598 RVA: 0x007DD830 File Offset: 0x007DBA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifeCharLevelDBInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoggingLevel != 0)
			{
				this.LoggingLevel = other.LoggingLevel;
			}
			if (other.LoggingExp != 0)
			{
				this.LoggingExp = other.LoggingExp;
			}
			if (other.MiningLevel != 0)
			{
				this.MiningLevel = other.MiningLevel;
			}
			if (other.MiningExp != 0)
			{
				this.MiningExp = other.MiningExp;
			}
			if (other.FarmingLevel != 0)
			{
				this.FarmingLevel = other.FarmingLevel;
			}
			if (other.FarmingExp != 0)
			{
				this.FarmingExp = other.FarmingExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BFA7 RID: 114599 RVA: 0x001DA8B0 File Offset: 0x001D8AB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFA8 RID: 114600 RVA: 0x007DD8D0 File Offset: 0x007DBAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.LoggingLevel = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LoggingExp = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.MiningLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.MiningExp = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.FarmingLevel = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.FarmingExp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}
		private static readonly MessageParser<LifeCharLevelDBInfo> _parser = new MessageParser<LifeCharLevelDBInfo>(() => new LifeCharLevelDBInfo());

		// Token: 0x04015826 RID: 88102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04015827 RID: 88103
		public const int LoggingLevelFieldNumber = 1;

		// Token: 0x04015828 RID: 88104
		private int loggingLevel_;

		// Token: 0x04015829 RID: 88105
		public const int LoggingExpFieldNumber = 2;

		// Token: 0x0401582A RID: 88106
		private int loggingExp_;

		// Token: 0x0401582B RID: 88107
		public const int MiningLevelFieldNumber = 3;

		// Token: 0x0401582C RID: 88108
		private int miningLevel_;

		// Token: 0x0401582D RID: 88109
		public const int MiningExpFieldNumber = 4;

		// Token: 0x0401582E RID: 88110
		private int miningExp_;

		// Token: 0x0401582F RID: 88111
		public const int FarmingLevelFieldNumber = 5;

		// Token: 0x04015830 RID: 88112
		private int farmingLevel_;

		// Token: 0x04015831 RID: 88113
		public const int FarmingExpFieldNumber = 6;

		// Token: 0x04015832 RID: 88114
		private int farmingExp_;
	}
}
