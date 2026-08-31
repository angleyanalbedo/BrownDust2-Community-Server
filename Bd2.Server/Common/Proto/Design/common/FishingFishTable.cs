using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C8E RID: 31886
	public sealed class FishingFishTable : IMessage<FishingFishTable>, IMessage, IEquatable<FishingFishTable>, IDeepCloneable<FishingFishTable>, IBufferMessage
	{
		// Token: 0x17011205 RID: 70149
		// (get) Token: 0x06046C39 RID: 289849 RVA: 0x01135A8D File Offset: 0x01133C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingFishTable> Parser
		{
			get
			{
				return FishingFishTable._parser;
			}
		}

		// Token: 0x17011206 RID: 70150
		// (get) Token: 0x06046C3A RID: 289850 RVA: 0x01135A94 File Offset: 0x01133C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FishingFishTableReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17011207 RID: 70151
		// (get) Token: 0x06046C3B RID: 289851 RVA: 0x01135AA6 File Offset: 0x01133CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingFishTable.Descriptor;
			}
		}

		// Token: 0x06046C3C RID: 289852 RVA: 0x01135AAD File Offset: 0x01133CAD
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FishingFishTable()
		{
		}

		// Token: 0x06046C3D RID: 289853 RVA: 0x01135AEC File Offset: 0x01133CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishTable(FishingFishTable other)
			: this()
		{
			this.aquariumBgmParam_ = other.aquariumBgmParam_;
			this.criticalHitzoneSize_ = other.criticalHitzoneSize_;
			this.descLocalTextId_ = other.descLocalTextId_;
			this.exp_ = other.exp_;
			this.fishSkillId_ = other.fishSkillId_.Clone();
			this.fishTrapPriceCount_ = other.fishTrapPriceCount_;
			this.fishTrapPriceId_ = other.fishTrapPriceId_;
			this.fishTrapPriceType_ = other.fishTrapPriceType_;
			this.grade_ = other.grade_;
			this.habitatGroupId_ = other.habitatGroupId_;
			this.iconSpriteName_ = other.iconSpriteName_;
			this.id_ = other.id_;
			this.lockedIconSprite_ = other.lockedIconSprite_;
			this.maxSize_ = other.maxSize_;
			this.minSize_ = other.minSize_;
			this.nameTextId_ = other.nameTextId_;
			this.normalHitzoneSize_ = other.normalHitzoneSize_;
			this.power_ = other.power_;
			this.prefabName_ = other.prefabName_;
			this.specialMotionSound_ = other.specialMotionSound_;
			this.speedMultiplier_ = other.speedMultiplier_;
			this.stamina_ = other.stamina_;
			this.timeId_ = other.timeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06046C3E RID: 289854 RVA: 0x01135C29 File Offset: 0x01133E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingFishTable Clone()
		{
			return new FishingFishTable(this);
		}

		// Token: 0x17011208 RID: 70152
		// (get) Token: 0x06046C3F RID: 289855 RVA: 0x01135C31 File Offset: 0x01133E31
		// (set) Token: 0x06046C40 RID: 289856 RVA: 0x01135C39 File Offset: 0x01133E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AquariumBgmParam
		{
			get
			{
				return this.aquariumBgmParam_;
			}
			set
			{
				this.aquariumBgmParam_ = value;
			}
		}

		// Token: 0x17011209 RID: 70153
		// (get) Token: 0x06046C41 RID: 289857 RVA: 0x01135C42 File Offset: 0x01133E42
		// (set) Token: 0x06046C42 RID: 289858 RVA: 0x01135C4A File Offset: 0x01133E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CriticalHitzoneSize
		{
			get
			{
				return this.criticalHitzoneSize_;
			}
			set
			{
				this.criticalHitzoneSize_ = value;
			}
		}

		// Token: 0x1701120A RID: 70154
		// (get) Token: 0x06046C43 RID: 289859 RVA: 0x01135C53 File Offset: 0x01133E53
		// (set) Token: 0x06046C44 RID: 289860 RVA: 0x01135C5B File Offset: 0x01133E5B
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int DescLocalTextId
		{
			get
			{
				return this.descLocalTextId_;
			}
			set
			{
				this.descLocalTextId_ = value;
			}
		}

		// Token: 0x1701120B RID: 70155
		// (get) Token: 0x06046C45 RID: 289861 RVA: 0x01135C64 File Offset: 0x01133E64
		// (set) Token: 0x06046C46 RID: 289862 RVA: 0x01135C6C File Offset: 0x01133E6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x1701120C RID: 70156
		// (get) Token: 0x06046C47 RID: 289863 RVA: 0x01135C75 File Offset: 0x01133E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FishSkillId
		{
			get
			{
				return this.fishSkillId_;
			}
		}

		// Token: 0x1701120D RID: 70157
		// (get) Token: 0x06046C48 RID: 289864 RVA: 0x01135C7D File Offset: 0x01133E7D
		// (set) Token: 0x06046C49 RID: 289865 RVA: 0x01135C85 File Offset: 0x01133E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishTrapPriceCount
		{
			get
			{
				return this.fishTrapPriceCount_;
			}
			set
			{
				this.fishTrapPriceCount_ = value;
			}
		}

		// Token: 0x1701120E RID: 70158
		// (get) Token: 0x06046C4A RID: 289866 RVA: 0x01135C8E File Offset: 0x01133E8E
		// (set) Token: 0x06046C4B RID: 289867 RVA: 0x01135C96 File Offset: 0x01133E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FishTrapPriceId
		{
			get
			{
				return this.fishTrapPriceId_;
			}
			set
			{
				this.fishTrapPriceId_ = value;
			}
		}

		// Token: 0x1701120F RID: 70159
		// (get) Token: 0x06046C4C RID: 289868 RVA: 0x01135C9F File Offset: 0x01133E9F
		// (set) Token: 0x06046C4D RID: 289869 RVA: 0x01135CA7 File Offset: 0x01133EA7
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FishTrapPriceType
		{
			get
			{
				return this.fishTrapPriceType_;
			}
			set
			{
				this.fishTrapPriceType_ = value;
			}
		}

		// Token: 0x17011210 RID: 70160
		// (get) Token: 0x06046C4E RID: 289870 RVA: 0x01135CB0 File Offset: 0x01133EB0
		// (set) Token: 0x06046C4F RID: 289871 RVA: 0x01135CB8 File Offset: 0x01133EB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Grade
		{
			get
			{
				return this.grade_;
			}
			set
			{
				this.grade_ = value;
			}
		}

		// Token: 0x17011211 RID: 70161
		// (get) Token: 0x06046C50 RID: 289872 RVA: 0x01135CC1 File Offset: 0x01133EC1
		// (set) Token: 0x06046C51 RID: 289873 RVA: 0x01135CC9 File Offset: 0x01133EC9
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int HabitatGroupId
		{
			get
			{
				return this.habitatGroupId_;
			}
			set
			{
				this.habitatGroupId_ = value;
			}
		}

		// Token: 0x17011212 RID: 70162
		// (get) Token: 0x06046C52 RID: 289874 RVA: 0x01135CD2 File Offset: 0x01133ED2
		// (set) Token: 0x06046C53 RID: 289875 RVA: 0x01135CDA File Offset: 0x01133EDA
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string IconSpriteName
		{
			get
			{
				return this.iconSpriteName_;
			}
			set
			{
				this.iconSpriteName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011213 RID: 70163
		// (get) Token: 0x06046C54 RID: 289876 RVA: 0x01135CED File Offset: 0x01133EED
		// (set) Token: 0x06046C55 RID: 289877 RVA: 0x01135CF5 File Offset: 0x01133EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17011214 RID: 70164
		// (get) Token: 0x06046C56 RID: 289878 RVA: 0x01135CFE File Offset: 0x01133EFE
		// (set) Token: 0x06046C57 RID: 289879 RVA: 0x01135D06 File Offset: 0x01133F06
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string LockedIconSprite
		{
			get
			{
				return this.lockedIconSprite_;
			}
			set
			{
				this.lockedIconSprite_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17011215 RID: 70165
		// (get) Token: 0x06046C58 RID: 289880 RVA: 0x01135D19 File Offset: 0x01133F19
		// (set) Token: 0x06046C59 RID: 289881 RVA: 0x01135D21 File Offset: 0x01133F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double MaxSize
		{
			get
			{
				return this.maxSize_;
			}
			set
			{
				this.maxSize_ = value;
			}
		}

		// Token: 0x17011216 RID: 70166
		// (get) Token: 0x06046C5A RID: 289882 RVA: 0x01135D2A File Offset: 0x01133F2A
		// (set) Token: 0x06046C5B RID: 289883 RVA: 0x01135D32 File Offset: 0x01133F32
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double MinSize
		{
			get
			{
				return this.minSize_;
			}
			set
			{
				this.minSize_ = value;
			}
		}

		// Token: 0x17011217 RID: 70167
		// (get) Token: 0x06046C5C RID: 289884 RVA: 0x01135D3B File Offset: 0x01133F3B
		// (set) Token: 0x06046C5D RID: 289885 RVA: 0x01135D43 File Offset: 0x01133F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NameTextId
		{
			get
			{
				return this.nameTextId_;
			}
			set
			{
				this.nameTextId_ = value;
			}
		}

		// Token: 0x17011218 RID: 70168
		// (get) Token: 0x06046C5E RID: 289886 RVA: 0x01135D4C File Offset: 0x01133F4C
		// (set) Token: 0x06046C5F RID: 289887 RVA: 0x01135D54 File Offset: 0x01133F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NormalHitzoneSize
		{
			get
			{
				return this.normalHitzoneSize_;
			}
			set
			{
				this.normalHitzoneSize_ = value;
			}
		}

		// Token: 0x17011219 RID: 70169
		// (get) Token: 0x06046C60 RID: 289888 RVA: 0x01135D5D File Offset: 0x01133F5D
		// (set) Token: 0x06046C61 RID: 289889 RVA: 0x01135D65 File Offset: 0x01133F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Power
		{
			get
			{
				return this.power_;
			}
			set
			{
				this.power_ = value;
			}
		}

		// Token: 0x1701121A RID: 70170
		// (get) Token: 0x06046C62 RID: 289890 RVA: 0x01135D6E File Offset: 0x01133F6E
		// (set) Token: 0x06046C63 RID: 289891 RVA: 0x01135D76 File Offset: 0x01133F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PrefabName
		{
			get
			{
				return this.prefabName_;
			}
			set
			{
				this.prefabName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1701121B RID: 70171
		// (get) Token: 0x06046C64 RID: 289892 RVA: 0x01135D89 File Offset: 0x01133F89
		// (set) Token: 0x06046C65 RID: 289893 RVA: 0x01135D91 File Offset: 0x01133F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SpecialMotionSound
		{
			get
			{
				return this.specialMotionSound_;
			}
			set
			{
				this.specialMotionSound_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1701121C RID: 70172
		// (get) Token: 0x06046C66 RID: 289894 RVA: 0x01135DA4 File Offset: 0x01133FA4
		// (set) Token: 0x06046C67 RID: 289895 RVA: 0x01135DAC File Offset: 0x01133FAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public double SpeedMultiplier
		{
			get
			{
				return this.speedMultiplier_;
			}
			set
			{
				this.speedMultiplier_ = value;
			}
		}

		// Token: 0x1701121D RID: 70173
		// (get) Token: 0x06046C68 RID: 289896 RVA: 0x01135DB5 File Offset: 0x01133FB5
		// (set) Token: 0x06046C69 RID: 289897 RVA: 0x01135DBD File Offset: 0x01133FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Stamina
		{
			get
			{
				return this.stamina_;
			}
			set
			{
				this.stamina_ = value;
			}
		}

		// Token: 0x1701121E RID: 70174
		// (get) Token: 0x06046C6A RID: 289898 RVA: 0x01135DC6 File Offset: 0x01133FC6
		// (set) Token: 0x06046C6B RID: 289899 RVA: 0x01135DCE File Offset: 0x01133FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeId
		{
			get
			{
				return this.timeId_;
			}
			set
			{
				this.timeId_ = value;
			}
		}

		// Token: 0x06046C6C RID: 289900 RVA: 0x01135DD7 File Offset: 0x01133FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingFishTable);
		}

		// Token: 0x06046C6D RID: 289901 RVA: 0x01135DE8 File Offset: 0x01133FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingFishTable other)
		{
			return other != null && (other == this || (this.AquariumBgmParam == other.AquariumBgmParam && this.CriticalHitzoneSize == other.CriticalHitzoneSize && this.DescLocalTextId == other.DescLocalTextId && this.Exp == other.Exp && this.fishSkillId_.Equals(other.fishSkillId_) && this.FishTrapPriceCount == other.FishTrapPriceCount && this.FishTrapPriceId == other.FishTrapPriceId && this.FishTrapPriceType == other.FishTrapPriceType && this.Grade == other.Grade && this.HabitatGroupId == other.HabitatGroupId && !(this.IconSpriteName != other.IconSpriteName) && this.Id == other.Id && !(this.LockedIconSprite != other.LockedIconSprite) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MaxSize, other.MaxSize) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MinSize, other.MinSize) && this.NameTextId == other.NameTextId && this.NormalHitzoneSize == other.NormalHitzoneSize && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Power, other.Power) && !(this.PrefabName != other.PrefabName) && !(this.SpecialMotionSound != other.SpecialMotionSound) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.SpeedMultiplier, other.SpeedMultiplier) && this.Stamina == other.Stamina && this.TimeId == other.TimeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06046C6E RID: 289902 RVA: 0x01135FC4 File Offset: 0x011341C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AquariumBgmParam != 0)
			{
				num ^= this.AquariumBgmParam.GetHashCode();
			}
			if (this.CriticalHitzoneSize != 0)
			{
				num ^= this.CriticalHitzoneSize.GetHashCode();
			}
			if (this.DescLocalTextId != 0)
			{
				num ^= this.DescLocalTextId.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.fishSkillId_.GetHashCode();
			if (this.FishTrapPriceCount != 0)
			{
				num ^= this.FishTrapPriceCount.GetHashCode();
			}
			if (this.FishTrapPriceId != 0)
			{
				num ^= this.FishTrapPriceId.GetHashCode();
			}
			if (this.FishTrapPriceType != 0)
			{
				num ^= this.FishTrapPriceType.GetHashCode();
			}
			if (this.Grade != 0)
			{
				num ^= this.Grade.GetHashCode();
			}
			if (this.HabitatGroupId != 0)
			{
				num ^= this.HabitatGroupId.GetHashCode();
			}
			if (this.IconSpriteName.Length != 0)
			{
				num ^= this.IconSpriteName.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LockedIconSprite.Length != 0)
			{
				num ^= this.LockedIconSprite.GetHashCode();
			}
			if (this.MaxSize != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MaxSize);
			}
			if (this.MinSize != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MinSize);
			}
			if (this.NameTextId != 0)
			{
				num ^= this.NameTextId.GetHashCode();
			}
			if (this.NormalHitzoneSize != 0)
			{
				num ^= this.NormalHitzoneSize.GetHashCode();
			}
			if (this.Power != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Power);
			}
			if (this.PrefabName.Length != 0)
			{
				num ^= this.PrefabName.GetHashCode();
			}
			if (this.SpecialMotionSound.Length != 0)
			{
				num ^= this.SpecialMotionSound.GetHashCode();
			}
			if (this.SpeedMultiplier != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.SpeedMultiplier);
			}
			if (this.Stamina != 0)
			{
				num ^= this.Stamina.GetHashCode();
			}
			if (this.TimeId != 0)
			{
				num ^= this.TimeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06046C6F RID: 289903 RVA: 0x001D5682 File Offset: 0x001D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06046C70 RID: 289904 RVA: 0x001D568A File Offset: 0x001D388A
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06046C71 RID: 289905 RVA: 0x01136254 File Offset: 0x01134454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AquariumBgmParam != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AquariumBgmParam);
			}
			if (this.CriticalHitzoneSize != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CriticalHitzoneSize);
			}
			if (this.DescLocalTextId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DescLocalTextId);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Exp);
			}
			this.fishSkillId_.WriteTo(ref output, FishingFishTable._repeated_fishSkillId_codec);
			if (this.FishTrapPriceCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FishTrapPriceCount);
			}
			if (this.FishTrapPriceId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FishTrapPriceId);
			}
			if (this.FishTrapPriceType != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FishTrapPriceType);
			}
			if (this.Grade != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Grade);
			}
			if (this.HabitatGroupId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.HabitatGroupId);
			}
			if (this.IconSpriteName.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.IconSpriteName);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this.LockedIconSprite.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.LockedIconSprite);
			}
			if (this.MaxSize != 0.0)
			{
				output.WriteRawTag(113);
				output.WriteDouble(this.MaxSize);
			}
			if (this.MinSize != 0.0)
			{
				output.WriteRawTag(121);
				output.WriteDouble(this.MinSize);
			}
			if (this.NameTextId != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.NameTextId);
			}
			if (this.NormalHitzoneSize != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.NormalHitzoneSize);
			}
			if (this.Power != 0.0)
			{
				output.WriteRawTag(145, 1);
				output.WriteDouble(this.Power);
			}
			if (this.PrefabName.Length != 0)
			{
				output.WriteRawTag(154, 1);
				output.WriteString(this.PrefabName);
			}
			if (this.SpecialMotionSound.Length != 0)
			{
				output.WriteRawTag(162, 1);
				output.WriteString(this.SpecialMotionSound);
			}
			if (this.SpeedMultiplier != 0.0)
			{
				output.WriteRawTag(169, 1);
				output.WriteDouble(this.SpeedMultiplier);
			}
			if (this.Stamina != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.Stamina);
			}
			if (this.TimeId != 0)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.TimeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06046C72 RID: 289906 RVA: 0x01136548 File Offset: 0x01134748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AquariumBgmParam != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AquariumBgmParam);
			}
			if (this.CriticalHitzoneSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CriticalHitzoneSize);
			}
			if (this.DescLocalTextId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DescLocalTextId);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			num += this.fishSkillId_.CalculateSize(FishingFishTable._repeated_fishSkillId_codec);
			if (this.FishTrapPriceCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishTrapPriceCount);
			}
			if (this.FishTrapPriceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishTrapPriceId);
			}
			if (this.FishTrapPriceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FishTrapPriceType);
			}
			if (this.Grade != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Grade);
			}
			if (this.HabitatGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HabitatGroupId);
			}
			if (this.IconSpriteName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IconSpriteName);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LockedIconSprite.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LockedIconSprite);
			}
			if (this.MaxSize != 0.0)
			{
				num += 9;
			}
			if (this.MinSize != 0.0)
			{
				num += 9;
			}
			if (this.NameTextId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.NameTextId);
			}
			if (this.NormalHitzoneSize != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.NormalHitzoneSize);
			}
			if (this.Power != 0.0)
			{
				num += 10;
			}
			if (this.PrefabName.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.PrefabName);
			}
			if (this.SpecialMotionSound.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.SpecialMotionSound);
			}
			if (this.SpeedMultiplier != 0.0)
			{
				num += 10;
			}
			if (this.Stamina != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Stamina);
			}
			if (this.TimeId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TimeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06046C73 RID: 289907 RVA: 0x011367A0 File Offset: 0x011349A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingFishTable other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AquariumBgmParam != 0)
			{
				this.AquariumBgmParam = other.AquariumBgmParam;
			}
			if (other.CriticalHitzoneSize != 0)
			{
				this.CriticalHitzoneSize = other.CriticalHitzoneSize;
			}
			if (other.DescLocalTextId != 0)
			{
				this.DescLocalTextId = other.DescLocalTextId;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			this.fishSkillId_.Add(other.fishSkillId_);
			if (other.FishTrapPriceCount != 0)
			{
				this.FishTrapPriceCount = other.FishTrapPriceCount;
			}
			if (other.FishTrapPriceId != 0)
			{
				this.FishTrapPriceId = other.FishTrapPriceId;
			}
			if (other.FishTrapPriceType != 0)
			{
				this.FishTrapPriceType = other.FishTrapPriceType;
			}
			if (other.Grade != 0)
			{
				this.Grade = other.Grade;
			}
			if (other.HabitatGroupId != 0)
			{
				this.HabitatGroupId = other.HabitatGroupId;
			}
			if (other.IconSpriteName.Length != 0)
			{
				this.IconSpriteName = other.IconSpriteName;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LockedIconSprite.Length != 0)
			{
				this.LockedIconSprite = other.LockedIconSprite;
			}
			if (other.MaxSize != 0.0)
			{
				this.MaxSize = other.MaxSize;
			}
			if (other.MinSize != 0.0)
			{
				this.MinSize = other.MinSize;
			}
			if (other.NameTextId != 0)
			{
				this.NameTextId = other.NameTextId;
			}
			if (other.NormalHitzoneSize != 0)
			{
				this.NormalHitzoneSize = other.NormalHitzoneSize;
			}
			if (other.Power != 0.0)
			{
				this.Power = other.Power;
			}
			if (other.PrefabName.Length != 0)
			{
				this.PrefabName = other.PrefabName;
			}
			if (other.SpecialMotionSound.Length != 0)
			{
				this.SpecialMotionSound = other.SpecialMotionSound;
			}
			if (other.SpeedMultiplier != 0.0)
			{
				this.SpeedMultiplier = other.SpeedMultiplier;
			}
			if (other.Stamina != 0)
			{
				this.Stamina = other.Stamina;
			}
			if (other.TimeId != 0)
			{
				this.TimeId = other.TimeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06046C74 RID: 289908 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06046C75 RID: 289909 RVA: 0x011369CC File Offset: 0x01134BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 90U)
				{
					if (num <= 42U)
					{
						if (num <= 24U)
						{
							if (num == 8U)
							{
								this.AquariumBgmParam = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.CriticalHitzoneSize = input.ReadInt32();
								continue;
							}
							if (num == 24U)
							{
								this.DescLocalTextId = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 32U)
							{
								this.Exp = input.ReadInt32();
								continue;
							}
							if (num == 40U || num == 42U)
							{
								this.fishSkillId_.AddEntriesFrom(ref input, FishingFishTable._repeated_fishSkillId_codec);
								continue;
							}
						}
					}
					else if (num <= 64U)
					{
						if (num == 48U)
						{
							this.FishTrapPriceCount = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.FishTrapPriceId = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.FishTrapPriceType = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 72U)
						{
							this.Grade = input.ReadInt32();
							continue;
						}
						if (num == 80U)
						{
							this.HabitatGroupId = input.ReadInt32();
							continue;
						}
						if (num == 90U)
						{
							this.IconSpriteName = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 136U)
				{
					if (num <= 113U)
					{
						if (num == 96U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 106U)
						{
							this.LockedIconSprite = input.ReadString();
							continue;
						}
						if (num == 113U)
						{
							this.MaxSize = input.ReadDouble();
							continue;
						}
					}
					else
					{
						if (num == 121U)
						{
							this.MinSize = input.ReadDouble();
							continue;
						}
						if (num == 128U)
						{
							this.NameTextId = input.ReadInt32();
							continue;
						}
						if (num == 136U)
						{
							this.NormalHitzoneSize = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 162U)
				{
					if (num == 145U)
					{
						this.Power = input.ReadDouble();
						continue;
					}
					if (num == 154U)
					{
						this.PrefabName = input.ReadString();
						continue;
					}
					if (num == 162U)
					{
						this.SpecialMotionSound = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 169U)
					{
						this.SpeedMultiplier = input.ReadDouble();
						continue;
					}
					if (num == 176U)
					{
						this.Stamina = input.ReadInt32();
						continue;
					}
					if (num == 184U)
					{
						this.TimeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0402EAB8 RID: 191160
		private static readonly MessageParser<FishingFishTable> _parser = new MessageParser<FishingFishTable>(() => new FishingFishTable());

		// Token: 0x0402EAB9 RID: 191161
		private UnknownFieldSet _unknownFields;

		// Token: 0x0402EABA RID: 191162
		public const int AquariumBgmParamFieldNumber = 1;

		// Token: 0x0402EABB RID: 191163
		private int aquariumBgmParam_;

		// Token: 0x0402EABC RID: 191164
		public const int CriticalHitzoneSizeFieldNumber = 2;

		// Token: 0x0402EABD RID: 191165
		private int criticalHitzoneSize_;

		// Token: 0x0402EABE RID: 191166
		public const int DescLocalTextIdFieldNumber = 3;

		// Token: 0x0402EABF RID: 191167
		private int descLocalTextId_;

		// Token: 0x0402EAC0 RID: 191168
		public const int ExpFieldNumber = 4;

		// Token: 0x0402EAC1 RID: 191169
		private int exp_;

		// Token: 0x0402EAC2 RID: 191170
		public const int FishSkillIdFieldNumber = 5;

		// Token: 0x0402EAC3 RID: 191171
		private static readonly FieldCodec<int> _repeated_fishSkillId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0402EAC4 RID: 191172
		private readonly RepeatedField<int> fishSkillId_ = new RepeatedField<int>();

		// Token: 0x0402EAC5 RID: 191173
		public const int FishTrapPriceCountFieldNumber = 6;

		// Token: 0x0402EAC6 RID: 191174
		private int fishTrapPriceCount_;

		// Token: 0x0402EAC7 RID: 191175
		public const int FishTrapPriceIdFieldNumber = 7;

		// Token: 0x0402EAC8 RID: 191176
		private int fishTrapPriceId_;

		// Token: 0x0402EAC9 RID: 191177
		public const int FishTrapPriceTypeFieldNumber = 8;

		// Token: 0x0402EACA RID: 191178
		private int fishTrapPriceType_;

		// Token: 0x0402EACB RID: 191179
		public const int GradeFieldNumber = 9;

		// Token: 0x0402EACC RID: 191180
		private int grade_;

		// Token: 0x0402EACD RID: 191181
		public const int HabitatGroupIdFieldNumber = 10;

		// Token: 0x0402EACE RID: 191182
		private int habitatGroupId_;

		// Token: 0x0402EACF RID: 191183
		public const int IconSpriteNameFieldNumber = 11;

		// Token: 0x0402EAD0 RID: 191184
		private string iconSpriteName_ = "";

		// Token: 0x0402EAD1 RID: 191185
		public const int IdFieldNumber = 12;

		// Token: 0x0402EAD2 RID: 191186
		private int id_;

		// Token: 0x0402EAD3 RID: 191187
		public const int LockedIconSpriteFieldNumber = 13;

		// Token: 0x0402EAD4 RID: 191188
		private string lockedIconSprite_ = "";

		// Token: 0x0402EAD5 RID: 191189
		public const int MaxSizeFieldNumber = 14;

		// Token: 0x0402EAD6 RID: 191190
		private double maxSize_;

		// Token: 0x0402EAD7 RID: 191191
		public const int MinSizeFieldNumber = 15;

		// Token: 0x0402EAD8 RID: 191192
		private double minSize_;

		// Token: 0x0402EAD9 RID: 191193
		public const int NameTextIdFieldNumber = 16;

		// Token: 0x0402EADA RID: 191194
		private int nameTextId_;

		// Token: 0x0402EADB RID: 191195
		public const int NormalHitzoneSizeFieldNumber = 17;

		// Token: 0x0402EADC RID: 191196
		private int normalHitzoneSize_;

		// Token: 0x0402EADD RID: 191197
		public const int PowerFieldNumber = 18;

		// Token: 0x0402EADE RID: 191198
		private double power_;

		// Token: 0x0402EADF RID: 191199
		public const int PrefabNameFieldNumber = 19;

		// Token: 0x0402EAE0 RID: 191200
		private string prefabName_ = "";

		// Token: 0x0402EAE1 RID: 191201
		public const int SpecialMotionSoundFieldNumber = 20;

		// Token: 0x0402EAE2 RID: 191202
		private string specialMotionSound_ = "";

		// Token: 0x0402EAE3 RID: 191203
		public const int SpeedMultiplierFieldNumber = 21;

		// Token: 0x0402EAE4 RID: 191204
		private double speedMultiplier_;

		// Token: 0x0402EAE5 RID: 191205
		public const int StaminaFieldNumber = 22;

		// Token: 0x0402EAE6 RID: 191206
		private int stamina_;

		// Token: 0x0402EAE7 RID: 191207
		public const int TimeIdFieldNumber = 23;

		// Token: 0x0402EAE8 RID: 191208
		private int timeId_;
	}
}
