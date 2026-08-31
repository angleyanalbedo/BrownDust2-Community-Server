using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TodayQuestTable : IMessage<TodayQuestTable>, IMessage, IEquatable<TodayQuestTable>, IDeepCloneable<TodayQuestTable>, IBufferMessage
{
	private static readonly MessageParser<TodayQuestTable> _parser = new MessageParser<TodayQuestTable>(() => new TodayQuestTable());

	private UnknownFieldSet _unknownFields;

	public const int AcceptCinemaNameFieldNumber = 1;

	private string acceptCinemaName_ = "";

	public const int AcceptDescQuestTextIdFieldNumber = 2;

	private int acceptDescQuestTextId_;

	public const int AcceptNpcIdFieldNumber = 3;

	private int acceptNpcId_;

	public const int CharGroupIdFieldNumber = 4;

	private int charGroupId_;

	public const int ClearTimeFieldNumber = 5;

	private int clearTime_;

	public const int CollectionIdFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_collectionId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> collectionId_ = new RepeatedField<int>();

	public const int CompleteCinemaNameFieldNumber = 7;

	private string completeCinemaName_ = "";

	public const int CompleteNpcIdFieldNumber = 8;

	private int completeNpcId_;

	public const int ConditionCountFieldNumber = 9;

	private int conditionCount_;

	public const int ConditionTypeFieldNumber = 10;

	private int conditionType_;

	public const int DeckListFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_deckList_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> deckList_ = new RepeatedField<int>();

	public const int DisplayDifficultyFieldNumber = 12;

	private int displayDifficulty_;

	public const int DisplayMapIdFieldNumber = 13;

	private int displayMapId_;

	public const int DisplayRewardCountFieldNumber = 14;

	private static readonly FieldCodec<int> _repeated_displayRewardCount_codec = FieldCodec.ForInt32(114u);

	private readonly RepeatedField<int> displayRewardCount_ = new RepeatedField<int>();

	public const int DisplayRewardIdFieldNumber = 15;

	private static readonly FieldCodec<int> _repeated_displayRewardId_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> displayRewardId_ = new RepeatedField<int>();

	public const int DisplayRewardTypeFieldNumber = 16;

	private static readonly FieldCodec<int> _repeated_displayRewardType_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> displayRewardType_ = new RepeatedField<int>();

	public const int GiveQuestItemIdFieldNumber = 17;

	private static readonly FieldCodec<int> _repeated_giveQuestItemId_codec = FieldCodec.ForInt32(138u);

	private readonly RepeatedField<int> giveQuestItemId_ = new RepeatedField<int>();

	public const int IdFieldNumber = 18;

	private int id_;

	public const int MagicValueFieldNumber = 19;

	private static readonly FieldCodec<int> _repeated_magicValue_codec = FieldCodec.ForInt32(154u);

	private readonly RepeatedField<int> magicValue_ = new RepeatedField<int>();

	public const int MapIdFieldNumber = 20;

	private int mapId_;

	public const int NextQuestIdFieldNumber = 21;

	private int nextQuestId_;

	public const int PackIdFieldNumber = 22;

	private int packId_;

	public const int PriorQuestIdFieldNumber = 23;

	private int priorQuestId_;

	public const int QuestConditionQuestTextIdFieldNumber = 24;

	private int questConditionQuestTextId_;

	public const int QuestDescQuestTextIdFieldNumber = 25;

	private int questDescQuestTextId_;

	public const int QuestNameQuestTextIdFieldNumber = 26;

	private int questNameQuestTextId_;

	public const int ReputationCompleteIdFieldNumber = 27;

	private int reputationCompleteId_;

	public const int RewardCountFieldNumber = 28;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(226u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 29;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(234u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 30;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(242u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int TypeFieldNumber = 31;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TodayQuestTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TodayQuestTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AcceptCinemaName
	{
		get
		{
			return acceptCinemaName_;
		}
		set
		{
			acceptCinemaName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AcceptDescQuestTextId
	{
		get
		{
			return acceptDescQuestTextId_;
		}
		set
		{
			acceptDescQuestTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AcceptNpcId
	{
		get
		{
			return acceptNpcId_;
		}
		set
		{
			acceptNpcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CharGroupId
	{
		get
		{
			return charGroupId_;
		}
		set
		{
			charGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClearTime
	{
		get
		{
			return clearTime_;
		}
		set
		{
			clearTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> CollectionId => collectionId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CompleteCinemaName
	{
		get
		{
			return completeCinemaName_;
		}
		set
		{
			completeCinemaName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CompleteNpcId
	{
		get
		{
			return completeNpcId_;
		}
		set
		{
			completeNpcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionCount
	{
		get
		{
			return conditionCount_;
		}
		set
		{
			conditionCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DeckList => deckList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DisplayDifficulty
	{
		get
		{
			return displayDifficulty_;
		}
		set
		{
			displayDifficulty_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DisplayMapId
	{
		get
		{
			return displayMapId_;
		}
		set
		{
			displayMapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DisplayRewardCount => displayRewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> DisplayRewardId => displayRewardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> DisplayRewardType => displayRewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> GiveQuestItemId => giveQuestItemId_;

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
	public RepeatedField<int> MagicValue => magicValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NextQuestId
	{
		get
		{
			return nextQuestId_;
		}
		set
		{
			nextQuestId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PriorQuestId
	{
		get
		{
			return priorQuestId_;
		}
		set
		{
			priorQuestId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int QuestConditionQuestTextId
	{
		get
		{
			return questConditionQuestTextId_;
		}
		set
		{
			questConditionQuestTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestDescQuestTextId
	{
		get
		{
			return questDescQuestTextId_;
		}
		set
		{
			questDescQuestTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuestNameQuestTextId
	{
		get
		{
			return questNameQuestTextId_;
		}
		set
		{
			questNameQuestTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReputationCompleteId
	{
		get
		{
			return reputationCompleteId_;
		}
		set
		{
			reputationCompleteId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardCount => rewardCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RewardId => rewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardType => rewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TodayQuestTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TodayQuestTable(TodayQuestTable other)
		: this()
	{
		acceptCinemaName_ = other.acceptCinemaName_;
		acceptDescQuestTextId_ = other.acceptDescQuestTextId_;
		acceptNpcId_ = other.acceptNpcId_;
		charGroupId_ = other.charGroupId_;
		clearTime_ = other.clearTime_;
		collectionId_ = other.collectionId_.Clone();
		completeCinemaName_ = other.completeCinemaName_;
		completeNpcId_ = other.completeNpcId_;
		conditionCount_ = other.conditionCount_;
		conditionType_ = other.conditionType_;
		deckList_ = other.deckList_.Clone();
		displayDifficulty_ = other.displayDifficulty_;
		displayMapId_ = other.displayMapId_;
		displayRewardCount_ = other.displayRewardCount_.Clone();
		displayRewardId_ = other.displayRewardId_.Clone();
		displayRewardType_ = other.displayRewardType_.Clone();
		giveQuestItemId_ = other.giveQuestItemId_.Clone();
		id_ = other.id_;
		magicValue_ = other.magicValue_.Clone();
		mapId_ = other.mapId_;
		nextQuestId_ = other.nextQuestId_;
		packId_ = other.packId_;
		priorQuestId_ = other.priorQuestId_;
		questConditionQuestTextId_ = other.questConditionQuestTextId_;
		questDescQuestTextId_ = other.questDescQuestTextId_;
		questNameQuestTextId_ = other.questNameQuestTextId_;
		reputationCompleteId_ = other.reputationCompleteId_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TodayQuestTable Clone()
	{
		return new TodayQuestTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TodayQuestTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TodayQuestTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(AcceptCinemaName != other.AcceptCinemaName) && AcceptDescQuestTextId == other.AcceptDescQuestTextId && AcceptNpcId == other.AcceptNpcId && CharGroupId == other.CharGroupId && ClearTime == other.ClearTime && collectionId_.Equals(other.collectionId_) && !(CompleteCinemaName != other.CompleteCinemaName) && CompleteNpcId == other.CompleteNpcId && ConditionCount == other.ConditionCount && ConditionType == other.ConditionType && deckList_.Equals(other.deckList_) && DisplayDifficulty == other.DisplayDifficulty && DisplayMapId == other.DisplayMapId && displayRewardCount_.Equals(other.displayRewardCount_) && displayRewardId_.Equals(other.displayRewardId_) && displayRewardType_.Equals(other.displayRewardType_) && giveQuestItemId_.Equals(other.giveQuestItemId_) && Id == other.Id && magicValue_.Equals(other.magicValue_) && MapId == other.MapId && NextQuestId == other.NextQuestId && PackId == other.PackId && PriorQuestId == other.PriorQuestId && QuestConditionQuestTextId == other.QuestConditionQuestTextId && QuestDescQuestTextId == other.QuestDescQuestTextId && QuestNameQuestTextId == other.QuestNameQuestTextId && ReputationCompleteId == other.ReputationCompleteId && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_) && Type == other.Type)
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
		if (AcceptCinemaName.Length != 0)
		{
			num ^= AcceptCinemaName.GetHashCode();
		}
		if (AcceptDescQuestTextId != 0)
		{
			num ^= AcceptDescQuestTextId.GetHashCode();
		}
		if (AcceptNpcId != 0)
		{
			num ^= AcceptNpcId.GetHashCode();
		}
		if (CharGroupId != 0)
		{
			num ^= CharGroupId.GetHashCode();
		}
		if (ClearTime != 0)
		{
			num ^= ClearTime.GetHashCode();
		}
		num ^= collectionId_.GetHashCode();
		if (CompleteCinemaName.Length != 0)
		{
			num ^= CompleteCinemaName.GetHashCode();
		}
		if (CompleteNpcId != 0)
		{
			num ^= CompleteNpcId.GetHashCode();
		}
		if (ConditionCount != 0)
		{
			num ^= ConditionCount.GetHashCode();
		}
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		num ^= deckList_.GetHashCode();
		if (DisplayDifficulty != 0)
		{
			num ^= DisplayDifficulty.GetHashCode();
		}
		if (DisplayMapId != 0)
		{
			num ^= DisplayMapId.GetHashCode();
		}
		num ^= displayRewardCount_.GetHashCode();
		num ^= displayRewardId_.GetHashCode();
		num ^= displayRewardType_.GetHashCode();
		num ^= giveQuestItemId_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= magicValue_.GetHashCode();
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (NextQuestId != 0)
		{
			num ^= NextQuestId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		if (PriorQuestId != 0)
		{
			num ^= PriorQuestId.GetHashCode();
		}
		if (QuestConditionQuestTextId != 0)
		{
			num ^= QuestConditionQuestTextId.GetHashCode();
		}
		if (QuestDescQuestTextId != 0)
		{
			num ^= QuestDescQuestTextId.GetHashCode();
		}
		if (QuestNameQuestTextId != 0)
		{
			num ^= QuestNameQuestTextId.GetHashCode();
		}
		if (ReputationCompleteId != 0)
		{
			num ^= ReputationCompleteId.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AcceptCinemaName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AcceptCinemaName);
		}
		if (AcceptDescQuestTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AcceptDescQuestTextId);
		}
		if (AcceptNpcId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AcceptNpcId);
		}
		if (CharGroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CharGroupId);
		}
		if (ClearTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ClearTime);
		}
		collectionId_.WriteTo(ref output, _repeated_collectionId_codec);
		if (CompleteCinemaName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(CompleteCinemaName);
		}
		if (CompleteNpcId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(CompleteNpcId);
		}
		if (ConditionCount != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ConditionCount);
		}
		if (ConditionType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ConditionType);
		}
		deckList_.WriteTo(ref output, _repeated_deckList_codec);
		if (DisplayDifficulty != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(DisplayDifficulty);
		}
		if (DisplayMapId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(DisplayMapId);
		}
		displayRewardCount_.WriteTo(ref output, _repeated_displayRewardCount_codec);
		displayRewardId_.WriteTo(ref output, _repeated_displayRewardId_codec);
		displayRewardType_.WriteTo(ref output, _repeated_displayRewardType_codec);
		giveQuestItemId_.WriteTo(ref output, _repeated_giveQuestItemId_codec);
		if (Id != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(Id);
		}
		magicValue_.WriteTo(ref output, _repeated_magicValue_codec);
		if (MapId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(MapId);
		}
		if (NextQuestId != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(NextQuestId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(PackId);
		}
		if (PriorQuestId != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(PriorQuestId);
		}
		if (QuestConditionQuestTextId != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(QuestConditionQuestTextId);
		}
		if (QuestDescQuestTextId != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(QuestDescQuestTextId);
		}
		if (QuestNameQuestTextId != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(QuestNameQuestTextId);
		}
		if (ReputationCompleteId != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(ReputationCompleteId);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		if (Type != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(Type);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (AcceptCinemaName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AcceptCinemaName);
		}
		if (AcceptDescQuestTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AcceptDescQuestTextId);
		}
		if (AcceptNpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AcceptNpcId);
		}
		if (CharGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharGroupId);
		}
		if (ClearTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearTime);
		}
		num += collectionId_.CalculateSize(_repeated_collectionId_codec);
		if (CompleteCinemaName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CompleteCinemaName);
		}
		if (CompleteNpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompleteNpcId);
		}
		if (ConditionCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionCount);
		}
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		num += deckList_.CalculateSize(_repeated_deckList_codec);
		if (DisplayDifficulty != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DisplayDifficulty);
		}
		if (DisplayMapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DisplayMapId);
		}
		num += displayRewardCount_.CalculateSize(_repeated_displayRewardCount_codec);
		num += displayRewardId_.CalculateSize(_repeated_displayRewardId_codec);
		num += displayRewardType_.CalculateSize(_repeated_displayRewardType_codec);
		num += giveQuestItemId_.CalculateSize(_repeated_giveQuestItemId_codec);
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += magicValue_.CalculateSize(_repeated_magicValue_codec);
		if (MapId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (NextQuestId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NextQuestId);
		}
		if (PackId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		if (PriorQuestId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PriorQuestId);
		}
		if (QuestConditionQuestTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QuestConditionQuestTextId);
		}
		if (QuestDescQuestTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QuestDescQuestTextId);
		}
		if (QuestNameQuestTextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(QuestNameQuestTextId);
		}
		if (ReputationCompleteId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReputationCompleteId);
		}
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		if (Type != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TodayQuestTable other)
	{
		if (other != null)
		{
			if (other.AcceptCinemaName.Length != 0)
			{
				AcceptCinemaName = other.AcceptCinemaName;
			}
			if (other.AcceptDescQuestTextId != 0)
			{
				AcceptDescQuestTextId = other.AcceptDescQuestTextId;
			}
			if (other.AcceptNpcId != 0)
			{
				AcceptNpcId = other.AcceptNpcId;
			}
			if (other.CharGroupId != 0)
			{
				CharGroupId = other.CharGroupId;
			}
			if (other.ClearTime != 0)
			{
				ClearTime = other.ClearTime;
			}
			collectionId_.Add(other.collectionId_);
			if (other.CompleteCinemaName.Length != 0)
			{
				CompleteCinemaName = other.CompleteCinemaName;
			}
			if (other.CompleteNpcId != 0)
			{
				CompleteNpcId = other.CompleteNpcId;
			}
			if (other.ConditionCount != 0)
			{
				ConditionCount = other.ConditionCount;
			}
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			deckList_.Add(other.deckList_);
			if (other.DisplayDifficulty != 0)
			{
				DisplayDifficulty = other.DisplayDifficulty;
			}
			if (other.DisplayMapId != 0)
			{
				DisplayMapId = other.DisplayMapId;
			}
			displayRewardCount_.Add(other.displayRewardCount_);
			displayRewardId_.Add(other.displayRewardId_);
			displayRewardType_.Add(other.displayRewardType_);
			giveQuestItemId_.Add(other.giveQuestItemId_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			magicValue_.Add(other.magicValue_);
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.NextQuestId != 0)
			{
				NextQuestId = other.NextQuestId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			if (other.PriorQuestId != 0)
			{
				PriorQuestId = other.PriorQuestId;
			}
			if (other.QuestConditionQuestTextId != 0)
			{
				QuestConditionQuestTextId = other.QuestConditionQuestTextId;
			}
			if (other.QuestDescQuestTextId != 0)
			{
				QuestDescQuestTextId = other.QuestDescQuestTextId;
			}
			if (other.QuestNameQuestTextId != 0)
			{
				QuestNameQuestTextId = other.QuestNameQuestTextId;
			}
			if (other.ReputationCompleteId != 0)
			{
				ReputationCompleteId = other.ReputationCompleteId;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 10u:
				AcceptCinemaName = input.ReadString();
				break;
			case 16u:
				AcceptDescQuestTextId = input.ReadInt32();
				break;
			case 24u:
				AcceptNpcId = input.ReadInt32();
				break;
			case 32u:
				CharGroupId = input.ReadInt32();
				break;
			case 40u:
				ClearTime = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				collectionId_.AddEntriesFrom(ref input, _repeated_collectionId_codec);
				break;
			case 58u:
				CompleteCinemaName = input.ReadString();
				break;
			case 64u:
				CompleteNpcId = input.ReadInt32();
				break;
			case 72u:
				ConditionCount = input.ReadInt32();
				break;
			case 80u:
				ConditionType = input.ReadInt32();
				break;
			case 96u:
				DisplayDifficulty = input.ReadInt32();
				break;
			case 104u:
				DisplayMapId = input.ReadInt32();
				break;
			case 88u:
			case 90u:
				deckList_.AddEntriesFrom(ref input, _repeated_deckList_codec);
				break;
			case 112u:
			case 114u:
				displayRewardCount_.AddEntriesFrom(ref input, _repeated_displayRewardCount_codec);
				break;
			case 120u:
			case 122u:
				displayRewardId_.AddEntriesFrom(ref input, _repeated_displayRewardId_codec);
				break;
			case 144u:
				Id = input.ReadInt32();
				break;
			case 136u:
			case 138u:
				giveQuestItemId_.AddEntriesFrom(ref input, _repeated_giveQuestItemId_codec);
				break;
			case 160u:
				MapId = input.ReadInt32();
				break;
			case 168u:
				NextQuestId = input.ReadInt32();
				break;
			case 176u:
				PackId = input.ReadInt32();
				break;
			case 184u:
				PriorQuestId = input.ReadInt32();
				break;
			case 152u:
			case 154u:
				magicValue_.AddEntriesFrom(ref input, _repeated_magicValue_codec);
				break;
			case 192u:
				QuestConditionQuestTextId = input.ReadInt32();
				break;
			case 200u:
				QuestDescQuestTextId = input.ReadInt32();
				break;
			case 208u:
				QuestNameQuestTextId = input.ReadInt32();
				break;
			case 216u:
				ReputationCompleteId = input.ReadInt32();
				break;
			case 232u:
			case 234u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 240u:
			case 242u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			case 248u:
				Type = input.ReadInt32();
				break;
			case 224u:
			case 226u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 128u:
			case 130u:
				displayRewardType_.AddEntriesFrom(ref input, _repeated_displayRewardType_codec);
				break;
			}
		}
	}
}
