using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CostumeTable : IMessage<CostumeTable>, IMessage, IEquatable<CostumeTable>, IDeepCloneable<CostumeTable>, IBufferMessage
{
	private static readonly MessageParser<CostumeTable> _parser = new MessageParser<CostumeTable>(() => new CostumeTable());

	private UnknownFieldSet _unknownFields;

	public const int AttackMoveTypeFieldNumber = 1;

	private int attackMoveType_;

	public const int AttackRangeFieldNumber = 2;

	private int attackRange_;

	public const int AttackRangeCountFieldNumber = 3;

	private int attackRangeCount_;

	public const int AttackTypeFieldNumber = 4;

	private int attackType_;

	public const int BuffImmuneGroupIDFieldNumber = 5;

	private int buffImmuneGroupID_;

	public const int CostumeDescNameTextIdFieldNumber = 6;

	private int costumeDescNameTextId_;

	public const int CostumeDesignIdFieldNumber = 7;

	private int costumeDesignId_;

	public const int CostumeDialogFieldNumber = 8;

	private int costumeDialog_;

	public const int CostumeNameTextIdFieldNumber = 9;

	private int costumeNameTextId_;

	public const int GrowthGroupIdFieldNumber = 10;

	private int growthGroupId_;

	public const int IdFieldNumber = 11;

	private int id_;

	public const int ItemAcquireIdFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_itemAcquireId_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> itemAcquireId_ = new RepeatedField<int>();

	public const int JapaneseCharacterVoiceActorNameTextIdFieldNumber = 13;

	private int japaneseCharacterVoiceActorNameTextId_;

	public const int KoreanCharacterVoiceActorNameTextIdFieldNumber = 14;

	private int koreanCharacterVoiceActorNameTextId_;

	public const int MaxLevelFieldNumber = 15;

	private int maxLevel_;

	public const int NorSubAttackBuffIdFieldNumber = 16;

	private int norSubAttackBuffId_;

	public const int NorSubAttackDescSkillTextIdFieldNumber = 17;

	private int norSubAttackDescSkillTextId_;

	public const int NorSubAttackNameSkillTextIdFieldNumber = 18;

	private int norSubAttackNameSkillTextId_;

	public const int NormalAttackDescSkillTextIdFieldNumber = 19;

	private int normalAttackDescSkillTextId_;

	public const int NormalAttackNameSkillTextIdFieldNumber = 20;

	private int normalAttackNameSkillTextId_;

	public const int NotTrashFieldNumber = 21;

	private int notTrash_;

	public const int PackIdFieldNumber = 22;

	private int packId_;

	public const int SkillGroupIdFieldNumber = 23;

	private int skillGroupId_;

	public const int SpAttackAddCountFieldNumber = 24;

	private int spAttackAddCount_;

	public const int TargetTypeFieldNumber = 25;

	private int targetType_;

	public const int UseRoguelikeFieldNumber = 26;

	private int useRoguelike_;

	public const int UseUniqueCharIdFieldNumber = 27;

	private int useUniqueCharId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CostumeTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CostumeTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackMoveType
	{
		get
		{
			return attackMoveType_;
		}
		set
		{
			attackMoveType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackRange
	{
		get
		{
			return attackRange_;
		}
		set
		{
			attackRange_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackRangeCount
	{
		get
		{
			return attackRangeCount_;
		}
		set
		{
			attackRangeCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackType
	{
		get
		{
			return attackType_;
		}
		set
		{
			attackType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffImmuneGroupID
	{
		get
		{
			return buffImmuneGroupID_;
		}
		set
		{
			buffImmuneGroupID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CostumeDescNameTextId
	{
		get
		{
			return costumeDescNameTextId_;
		}
		set
		{
			costumeDescNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeDesignId
	{
		get
		{
			return costumeDesignId_;
		}
		set
		{
			costumeDesignId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeDialog
	{
		get
		{
			return costumeDialog_;
		}
		set
		{
			costumeDialog_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeNameTextId
	{
		get
		{
			return costumeNameTextId_;
		}
		set
		{
			costumeNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GrowthGroupId
	{
		get
		{
			return growthGroupId_;
		}
		set
		{
			growthGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ItemAcquireId => itemAcquireId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int JapaneseCharacterVoiceActorNameTextId
	{
		get
		{
			return japaneseCharacterVoiceActorNameTextId_;
		}
		set
		{
			japaneseCharacterVoiceActorNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int KoreanCharacterVoiceActorNameTextId
	{
		get
		{
			return koreanCharacterVoiceActorNameTextId_;
		}
		set
		{
			koreanCharacterVoiceActorNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxLevel
	{
		get
		{
			return maxLevel_;
		}
		set
		{
			maxLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NorSubAttackBuffId
	{
		get
		{
			return norSubAttackBuffId_;
		}
		set
		{
			norSubAttackBuffId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NorSubAttackDescSkillTextId
	{
		get
		{
			return norSubAttackDescSkillTextId_;
		}
		set
		{
			norSubAttackDescSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NorSubAttackNameSkillTextId
	{
		get
		{
			return norSubAttackNameSkillTextId_;
		}
		set
		{
			norSubAttackNameSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NormalAttackDescSkillTextId
	{
		get
		{
			return normalAttackDescSkillTextId_;
		}
		set
		{
			normalAttackDescSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NormalAttackNameSkillTextId
	{
		get
		{
			return normalAttackNameSkillTextId_;
		}
		set
		{
			normalAttackNameSkillTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NotTrash
	{
		get
		{
			return notTrash_;
		}
		set
		{
			notTrash_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillGroupId
	{
		get
		{
			return skillGroupId_;
		}
		set
		{
			skillGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpAttackAddCount
	{
		get
		{
			return spAttackAddCount_;
		}
		set
		{
			spAttackAddCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TargetType
	{
		get
		{
			return targetType_;
		}
		set
		{
			targetType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UseRoguelike
	{
		get
		{
			return useRoguelike_;
		}
		set
		{
			useRoguelike_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UseUniqueCharId
	{
		get
		{
			return useUniqueCharId_;
		}
		set
		{
			useUniqueCharId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeTable(CostumeTable other)
		: this()
	{
		attackMoveType_ = other.attackMoveType_;
		attackRange_ = other.attackRange_;
		attackRangeCount_ = other.attackRangeCount_;
		attackType_ = other.attackType_;
		buffImmuneGroupID_ = other.buffImmuneGroupID_;
		costumeDescNameTextId_ = other.costumeDescNameTextId_;
		costumeDesignId_ = other.costumeDesignId_;
		costumeDialog_ = other.costumeDialog_;
		costumeNameTextId_ = other.costumeNameTextId_;
		growthGroupId_ = other.growthGroupId_;
		id_ = other.id_;
		itemAcquireId_ = other.itemAcquireId_.Clone();
		japaneseCharacterVoiceActorNameTextId_ = other.japaneseCharacterVoiceActorNameTextId_;
		koreanCharacterVoiceActorNameTextId_ = other.koreanCharacterVoiceActorNameTextId_;
		maxLevel_ = other.maxLevel_;
		norSubAttackBuffId_ = other.norSubAttackBuffId_;
		norSubAttackDescSkillTextId_ = other.norSubAttackDescSkillTextId_;
		norSubAttackNameSkillTextId_ = other.norSubAttackNameSkillTextId_;
		normalAttackDescSkillTextId_ = other.normalAttackDescSkillTextId_;
		normalAttackNameSkillTextId_ = other.normalAttackNameSkillTextId_;
		notTrash_ = other.notTrash_;
		packId_ = other.packId_;
		skillGroupId_ = other.skillGroupId_;
		spAttackAddCount_ = other.spAttackAddCount_;
		targetType_ = other.targetType_;
		useRoguelike_ = other.useRoguelike_;
		useUniqueCharId_ = other.useUniqueCharId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeTable Clone()
	{
		return new CostumeTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumeTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AttackMoveType == other.AttackMoveType && AttackRange == other.AttackRange && AttackRangeCount == other.AttackRangeCount && AttackType == other.AttackType && BuffImmuneGroupID == other.BuffImmuneGroupID && CostumeDescNameTextId == other.CostumeDescNameTextId && CostumeDesignId == other.CostumeDesignId && CostumeDialog == other.CostumeDialog && CostumeNameTextId == other.CostumeNameTextId && GrowthGroupId == other.GrowthGroupId && Id == other.Id && itemAcquireId_.Equals(other.itemAcquireId_) && JapaneseCharacterVoiceActorNameTextId == other.JapaneseCharacterVoiceActorNameTextId && KoreanCharacterVoiceActorNameTextId == other.KoreanCharacterVoiceActorNameTextId && MaxLevel == other.MaxLevel && NorSubAttackBuffId == other.NorSubAttackBuffId && NorSubAttackDescSkillTextId == other.NorSubAttackDescSkillTextId && NorSubAttackNameSkillTextId == other.NorSubAttackNameSkillTextId && NormalAttackDescSkillTextId == other.NormalAttackDescSkillTextId && NormalAttackNameSkillTextId == other.NormalAttackNameSkillTextId && NotTrash == other.NotTrash && PackId == other.PackId && SkillGroupId == other.SkillGroupId && SpAttackAddCount == other.SpAttackAddCount && TargetType == other.TargetType && UseRoguelike == other.UseRoguelike && UseUniqueCharId == other.UseUniqueCharId)
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		int num = 1;
		if (AttackMoveType != 0)
		{
			num ^= AttackMoveType.GetHashCode();
		}
		if (AttackRange != 0)
		{
			num ^= AttackRange.GetHashCode();
		}
		if (AttackRangeCount != 0)
		{
			num ^= AttackRangeCount.GetHashCode();
		}
		if (AttackType != 0)
		{
			num ^= AttackType.GetHashCode();
		}
		if (BuffImmuneGroupID != 0)
		{
			num ^= BuffImmuneGroupID.GetHashCode();
		}
		if (CostumeDescNameTextId != 0)
		{
			num ^= CostumeDescNameTextId.GetHashCode();
		}
		if (CostumeDesignId != 0)
		{
			num ^= CostumeDesignId.GetHashCode();
		}
		if (CostumeDialog != 0)
		{
			num ^= CostumeDialog.GetHashCode();
		}
		if (CostumeNameTextId != 0)
		{
			num ^= CostumeNameTextId.GetHashCode();
		}
		if (GrowthGroupId != 0)
		{
			num ^= GrowthGroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= itemAcquireId_.GetHashCode();
		if (JapaneseCharacterVoiceActorNameTextId != 0)
		{
			num ^= JapaneseCharacterVoiceActorNameTextId.GetHashCode();
		}
		if (KoreanCharacterVoiceActorNameTextId != 0)
		{
			num ^= KoreanCharacterVoiceActorNameTextId.GetHashCode();
		}
		if (MaxLevel != 0)
		{
			num ^= MaxLevel.GetHashCode();
		}
		if (NorSubAttackBuffId != 0)
		{
			num ^= NorSubAttackBuffId.GetHashCode();
		}
		if (NorSubAttackDescSkillTextId != 0)
		{
			num ^= NorSubAttackDescSkillTextId.GetHashCode();
		}
		if (NorSubAttackNameSkillTextId != 0)
		{
			num ^= NorSubAttackNameSkillTextId.GetHashCode();
		}
		if (NormalAttackDescSkillTextId != 0)
		{
			num ^= NormalAttackDescSkillTextId.GetHashCode();
		}
		if (NormalAttackNameSkillTextId != 0)
		{
			num ^= NormalAttackNameSkillTextId.GetHashCode();
		}
		if (NotTrash != 0)
		{
			num ^= NotTrash.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (SkillGroupId != 0)
		{
			num ^= SkillGroupId.GetHashCode();
		}
		if (SpAttackAddCount != 0)
		{
			num ^= SpAttackAddCount.GetHashCode();
		}
		if (TargetType != 0)
		{
			num ^= TargetType.GetHashCode();
		}
		if (UseRoguelike != 0)
		{
			num ^= UseRoguelike.GetHashCode();
		}
		if (UseUniqueCharId != 0)
		{
			num ^= UseUniqueCharId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AttackMoveType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AttackMoveType);
		}
		if (AttackRange != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttackRange);
		}
		if (AttackRangeCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AttackRangeCount);
		}
		if (AttackType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AttackType);
		}
		if (BuffImmuneGroupID != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BuffImmuneGroupID);
		}
		if (CostumeDescNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CostumeDescNameTextId);
		}
		if (CostumeDesignId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CostumeDesignId);
		}
		if (CostumeDialog != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(CostumeDialog);
		}
		if (CostumeNameTextId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(CostumeNameTextId);
		}
		if (GrowthGroupId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(GrowthGroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Id);
		}
		itemAcquireId_.WriteTo(ref output, _repeated_itemAcquireId_codec);
		if (JapaneseCharacterVoiceActorNameTextId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(JapaneseCharacterVoiceActorNameTextId);
		}
		if (KoreanCharacterVoiceActorNameTextId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(KoreanCharacterVoiceActorNameTextId);
		}
		if (MaxLevel != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(MaxLevel);
		}
		if (NorSubAttackBuffId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(NorSubAttackBuffId);
		}
		if (NorSubAttackDescSkillTextId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(NorSubAttackDescSkillTextId);
		}
		if (NorSubAttackNameSkillTextId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(NorSubAttackNameSkillTextId);
		}
		if (NormalAttackDescSkillTextId != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(NormalAttackDescSkillTextId);
		}
		if (NormalAttackNameSkillTextId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(NormalAttackNameSkillTextId);
		}
		if (NotTrash != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(NotTrash);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(PackId);
		}
		if (SkillGroupId != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(SkillGroupId);
		}
		if (SpAttackAddCount != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(SpAttackAddCount);
		}
		if (TargetType != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(TargetType);
		}
		if (UseRoguelike != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(UseRoguelike);
		}
		if (UseUniqueCharId != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(UseUniqueCharId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (AttackMoveType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackMoveType);
		}
		if (AttackRange != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackRange);
		}
		if (AttackRangeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackRangeCount);
		}
		if (AttackType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackType);
		}
		if (BuffImmuneGroupID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffImmuneGroupID);
		}
		if (CostumeDescNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeDescNameTextId);
		}
		if (CostumeDesignId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeDesignId);
		}
		if (CostumeDialog != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeDialog);
		}
		if (CostumeNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeNameTextId);
		}
		if (GrowthGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GrowthGroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += itemAcquireId_.CalculateSize(_repeated_itemAcquireId_codec);
		if (JapaneseCharacterVoiceActorNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(JapaneseCharacterVoiceActorNameTextId);
		}
		if (KoreanCharacterVoiceActorNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KoreanCharacterVoiceActorNameTextId);
		}
		if (MaxLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxLevel);
		}
		if (NorSubAttackBuffId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NorSubAttackBuffId);
		}
		if (NorSubAttackDescSkillTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NorSubAttackDescSkillTextId);
		}
		if (NorSubAttackNameSkillTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NorSubAttackNameSkillTextId);
		}
		if (NormalAttackDescSkillTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NormalAttackDescSkillTextId);
		}
		if (NormalAttackNameSkillTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NormalAttackNameSkillTextId);
		}
		if (NotTrash != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NotTrash);
		}
		if (PackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (SkillGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SkillGroupId);
		}
		if (SpAttackAddCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpAttackAddCount);
		}
		if (TargetType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TargetType);
		}
		if (UseRoguelike != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseRoguelike);
		}
		if (UseUniqueCharId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UseUniqueCharId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CostumeTable other)
	{
		if (other != null)
		{
			if (other.AttackMoveType != 0)
			{
				AttackMoveType = other.AttackMoveType;
			}
			if (other.AttackRange != 0)
			{
				AttackRange = other.AttackRange;
			}
			if (other.AttackRangeCount != 0)
			{
				AttackRangeCount = other.AttackRangeCount;
			}
			if (other.AttackType != 0)
			{
				AttackType = other.AttackType;
			}
			if (other.BuffImmuneGroupID != 0)
			{
				BuffImmuneGroupID = other.BuffImmuneGroupID;
			}
			if (other.CostumeDescNameTextId != 0)
			{
				CostumeDescNameTextId = other.CostumeDescNameTextId;
			}
			if (other.CostumeDesignId != 0)
			{
				CostumeDesignId = other.CostumeDesignId;
			}
			if (other.CostumeDialog != 0)
			{
				CostumeDialog = other.CostumeDialog;
			}
			if (other.CostumeNameTextId != 0)
			{
				CostumeNameTextId = other.CostumeNameTextId;
			}
			if (other.GrowthGroupId != 0)
			{
				GrowthGroupId = other.GrowthGroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			itemAcquireId_.Add(other.itemAcquireId_);
			if (other.JapaneseCharacterVoiceActorNameTextId != 0)
			{
				JapaneseCharacterVoiceActorNameTextId = other.JapaneseCharacterVoiceActorNameTextId;
			}
			if (other.KoreanCharacterVoiceActorNameTextId != 0)
			{
				KoreanCharacterVoiceActorNameTextId = other.KoreanCharacterVoiceActorNameTextId;
			}
			if (other.MaxLevel != 0)
			{
				MaxLevel = other.MaxLevel;
			}
			if (other.NorSubAttackBuffId != 0)
			{
				NorSubAttackBuffId = other.NorSubAttackBuffId;
			}
			if (other.NorSubAttackDescSkillTextId != 0)
			{
				NorSubAttackDescSkillTextId = other.NorSubAttackDescSkillTextId;
			}
			if (other.NorSubAttackNameSkillTextId != 0)
			{
				NorSubAttackNameSkillTextId = other.NorSubAttackNameSkillTextId;
			}
			if (other.NormalAttackDescSkillTextId != 0)
			{
				NormalAttackDescSkillTextId = other.NormalAttackDescSkillTextId;
			}
			if (other.NormalAttackNameSkillTextId != 0)
			{
				NormalAttackNameSkillTextId = other.NormalAttackNameSkillTextId;
			}
			if (other.NotTrash != 0)
			{
				NotTrash = other.NotTrash;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.SkillGroupId != 0)
			{
				SkillGroupId = other.SkillGroupId;
			}
			if (other.SpAttackAddCount != 0)
			{
				SpAttackAddCount = other.SpAttackAddCount;
			}
			if (other.TargetType != 0)
			{
				TargetType = other.TargetType;
			}
			if (other.UseRoguelike != 0)
			{
				UseRoguelike = other.UseRoguelike;
			}
			if (other.UseUniqueCharId != 0)
			{
				UseUniqueCharId = other.UseUniqueCharId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 8u:
				AttackMoveType = input.ReadInt32();
				break;
			case 16u:
				AttackRange = input.ReadInt32();
				break;
			case 24u:
				AttackRangeCount = input.ReadInt32();
				break;
			case 32u:
				AttackType = input.ReadInt32();
				break;
			case 40u:
				BuffImmuneGroupID = input.ReadInt32();
				break;
			case 48u:
				CostumeDescNameTextId = input.ReadInt32();
				break;
			case 56u:
				CostumeDesignId = input.ReadInt32();
				break;
			case 88u:
				Id = input.ReadInt32();
				break;
			case 104u:
				JapaneseCharacterVoiceActorNameTextId = input.ReadInt32();
				break;
			case 96u:
			case 98u:
				itemAcquireId_.AddEntriesFrom(ref input, _repeated_itemAcquireId_codec);
				break;
			case 64u:
				CostumeDialog = input.ReadInt32();
				break;
			case 72u:
				CostumeNameTextId = input.ReadInt32();
				break;
			case 80u:
				GrowthGroupId = input.ReadInt32();
				break;
			case 112u:
				KoreanCharacterVoiceActorNameTextId = input.ReadInt32();
				break;
			case 120u:
				MaxLevel = input.ReadInt32();
				break;
			case 128u:
				NorSubAttackBuffId = input.ReadInt32();
				break;
			case 136u:
				NorSubAttackDescSkillTextId = input.ReadInt32();
				break;
			case 144u:
				NorSubAttackNameSkillTextId = input.ReadInt32();
				break;
			case 152u:
				NormalAttackDescSkillTextId = input.ReadInt32();
				break;
			case 160u:
				NormalAttackNameSkillTextId = input.ReadInt32();
				break;
			case 168u:
				NotTrash = input.ReadInt32();
				break;
			case 176u:
				PackId = input.ReadInt32();
				break;
			case 184u:
				SkillGroupId = input.ReadInt32();
				break;
			case 192u:
				SpAttackAddCount = input.ReadInt32();
				break;
			case 200u:
				TargetType = input.ReadInt32();
				break;
			case 208u:
				UseRoguelike = input.ReadInt32();
				break;
			case 216u:
				UseUniqueCharId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
