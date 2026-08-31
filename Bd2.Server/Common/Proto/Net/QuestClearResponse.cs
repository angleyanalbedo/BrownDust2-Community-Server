using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class QuestClearResponse : IMessage<QuestClearResponse>, IMessage, IEquatable<QuestClearResponse>, IDeepCloneable<QuestClearResponse>, IBufferMessage
{
	private static readonly MessageParser<QuestClearResponse> _parser = new MessageParser<QuestClearResponse>(() => new QuestClearResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardInfoBundleFieldNumber = 1;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int QuestInfoFieldNumber = 2;

	private QuestDBInfo questInfo_;

	public const int ClearQuestIdFieldNumber = 3;

	private int clearQuestId_;

	public const int DeckInfoFieldNumber = 4;

	private static readonly FieldCodec<DeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(34u, DeckDBInfo.Parser);

	private readonly RepeatedField<DeckDBInfo> deckInfo_ = new RepeatedField<DeckDBInfo>();

	public const int CharInfoFieldNumber = 5;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(42u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int GiveQuestItemFieldNumber = 6;

	private static readonly FieldCodec<ItemDBInfo> _repeated_giveQuestItem_codec = FieldCodec.ForMessage(50u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> giveQuestItem_ = new RepeatedField<ItemDBInfo>();

	public const int RemoveQuestItemFieldNumber = 7;

	private static readonly FieldCodec<ItemDBInfo> _repeated_removeQuestItem_codec = FieldCodec.ForMessage(58u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> removeQuestItem_ = new RepeatedField<ItemDBInfo>();

	public const int ReputationInfoFieldNumber = 8;

	private static readonly FieldCodec<ReputationDBInfo> _repeated_reputationInfo_codec = FieldCodec.ForMessage(66u, ReputationDBInfo.Parser);

	private readonly RepeatedField<ReputationDBInfo> reputationInfo_ = new RepeatedField<ReputationDBInfo>();

	public const int QuestLevelInfoFieldNumber = 9;

	private QuestLevelDBInfo questLevelInfo_;

	public const int DeleteCharInvenIndexFieldNumber = 10;

	private static readonly FieldCodec<long> _repeated_deleteCharInvenIndex_codec = FieldCodec.ForInt64(82u);

	private readonly RepeatedField<long> deleteCharInvenIndex_ = new RepeatedField<long>();

	public const int PackInfoFieldNumber = 11;

	private static readonly FieldCodec<PackDBInfo> _repeated_packInfo_codec = FieldCodec.ForMessage(90u, PackDBInfo.Parser);

	private readonly RepeatedField<PackDBInfo> packInfo_ = new RepeatedField<PackDBInfo>();

	public const int EndingRewardInfoBundleFieldNumber = 12;

	private RewardDBInfoBundle endingRewardInfoBundle_;

	public const int ImmortalRewardInfoBundleFieldNumber = 13;

	private RewardDBInfoBundle immortalRewardInfoBundle_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<QuestClearResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestClearResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle RewardInfoBundle
	{
		get
		{
			return rewardInfoBundle_;
		}
		set
		{
			rewardInfoBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestDBInfo QuestInfo
	{
		get
		{
			return questInfo_;
		}
		set
		{
			questInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClearQuestId
	{
		get
		{
			return clearQuestId_;
		}
		set
		{
			clearQuestId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<DeckDBInfo> DeckInfo => deckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> GiveQuestItem => giveQuestItem_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> RemoveQuestItem => removeQuestItem_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ReputationDBInfo> ReputationInfo => reputationInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public QuestLevelDBInfo QuestLevelInfo
	{
		get
		{
			return questLevelInfo_;
		}
		set
		{
			questLevelInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> DeleteCharInvenIndex => deleteCharInvenIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PackDBInfo> PackInfo => packInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle EndingRewardInfoBundle
	{
		get
		{
			return endingRewardInfoBundle_;
		}
		set
		{
			endingRewardInfoBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle ImmortalRewardInfoBundle
	{
		get
		{
			return immortalRewardInfoBundle_;
		}
		set
		{
			immortalRewardInfoBundle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestClearResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestClearResponse(QuestClearResponse other)
		: this()
	{
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		questInfo_ = ((other.questInfo_ != null) ? other.questInfo_.Clone() : null);
		clearQuestId_ = other.clearQuestId_;
		deckInfo_ = other.deckInfo_.Clone();
		charInfo_ = other.charInfo_.Clone();
		giveQuestItem_ = other.giveQuestItem_.Clone();
		removeQuestItem_ = other.removeQuestItem_.Clone();
		reputationInfo_ = other.reputationInfo_.Clone();
		questLevelInfo_ = ((other.questLevelInfo_ != null) ? other.questLevelInfo_.Clone() : null);
		deleteCharInvenIndex_ = other.deleteCharInvenIndex_.Clone();
		packInfo_ = other.packInfo_.Clone();
		endingRewardInfoBundle_ = ((other.endingRewardInfoBundle_ != null) ? other.endingRewardInfoBundle_.Clone() : null);
		immortalRewardInfoBundle_ = ((other.immortalRewardInfoBundle_ != null) ? other.immortalRewardInfoBundle_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestClearResponse Clone()
	{
		return new QuestClearResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestClearResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(QuestClearResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(RewardInfoBundle, other.RewardInfoBundle) && object.Equals(QuestInfo, other.QuestInfo) && ClearQuestId == other.ClearQuestId && deckInfo_.Equals(other.deckInfo_) && charInfo_.Equals(other.charInfo_) && giveQuestItem_.Equals(other.giveQuestItem_) && removeQuestItem_.Equals(other.removeQuestItem_) && reputationInfo_.Equals(other.reputationInfo_) && object.Equals(QuestLevelInfo, other.QuestLevelInfo) && deleteCharInvenIndex_.Equals(other.deleteCharInvenIndex_) && packInfo_.Equals(other.packInfo_) && object.Equals(EndingRewardInfoBundle, other.EndingRewardInfoBundle) && object.Equals(ImmortalRewardInfoBundle, other.ImmortalRewardInfoBundle))
				{
					return object.Equals(_unknownFields, other._unknownFields);
				}
				return false;
			}
			return true;
		}
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		if (questInfo_ != null)
		{
			num ^= QuestInfo.GetHashCode();
		}
		if (ClearQuestId != 0)
		{
			num ^= ClearQuestId.GetHashCode();
		}
		num ^= deckInfo_.GetHashCode();
		num ^= charInfo_.GetHashCode();
		num ^= giveQuestItem_.GetHashCode();
		num ^= removeQuestItem_.GetHashCode();
		num ^= reputationInfo_.GetHashCode();
		if (questLevelInfo_ != null)
		{
			num ^= QuestLevelInfo.GetHashCode();
		}
		num ^= deleteCharInvenIndex_.GetHashCode();
		num ^= packInfo_.GetHashCode();
		if (endingRewardInfoBundle_ != null)
		{
			num ^= EndingRewardInfoBundle.GetHashCode();
		}
		if (immortalRewardInfoBundle_ != null)
		{
			num ^= ImmortalRewardInfoBundle.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RewardInfoBundle);
		}
		if (questInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(QuestInfo);
		}
		if (ClearQuestId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ClearQuestId);
		}
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		giveQuestItem_.WriteTo(ref output, _repeated_giveQuestItem_codec);
		removeQuestItem_.WriteTo(ref output, _repeated_removeQuestItem_codec);
		reputationInfo_.WriteTo(ref output, _repeated_reputationInfo_codec);
		if (questLevelInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(QuestLevelInfo);
		}
		deleteCharInvenIndex_.WriteTo(ref output, _repeated_deleteCharInvenIndex_codec);
		packInfo_.WriteTo(ref output, _repeated_packInfo_codec);
		if (endingRewardInfoBundle_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(EndingRewardInfoBundle);
		}
		if (immortalRewardInfoBundle_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ImmortalRewardInfoBundle);
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
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (questInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QuestInfo);
		}
		if (ClearQuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearQuestId);
		}
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += giveQuestItem_.CalculateSize(_repeated_giveQuestItem_codec);
		num += removeQuestItem_.CalculateSize(_repeated_removeQuestItem_codec);
		num += reputationInfo_.CalculateSize(_repeated_reputationInfo_codec);
		if (questLevelInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QuestLevelInfo);
		}
		num += deleteCharInvenIndex_.CalculateSize(_repeated_deleteCharInvenIndex_codec);
		num += packInfo_.CalculateSize(_repeated_packInfo_codec);
		if (endingRewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EndingRewardInfoBundle);
		}
		if (immortalRewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ImmortalRewardInfoBundle);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestClearResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		if (other.questInfo_ != null)
		{
			if (questInfo_ == null)
			{
				QuestInfo = new QuestDBInfo();
			}
			QuestInfo.MergeFrom(other.QuestInfo);
		}
		if (other.ClearQuestId != 0)
		{
			ClearQuestId = other.ClearQuestId;
		}
		deckInfo_.Add(other.deckInfo_);
		charInfo_.Add(other.charInfo_);
		giveQuestItem_.Add(other.giveQuestItem_);
		removeQuestItem_.Add(other.removeQuestItem_);
		reputationInfo_.Add(other.reputationInfo_);
		if (other.questLevelInfo_ != null)
		{
			if (questLevelInfo_ == null)
			{
				QuestLevelInfo = new QuestLevelDBInfo();
			}
			QuestLevelInfo.MergeFrom(other.QuestLevelInfo);
		}
		deleteCharInvenIndex_.Add(other.deleteCharInvenIndex_);
		packInfo_.Add(other.packInfo_);
		if (other.endingRewardInfoBundle_ != null)
		{
			if (endingRewardInfoBundle_ == null)
			{
				EndingRewardInfoBundle = new RewardDBInfoBundle();
			}
			EndingRewardInfoBundle.MergeFrom(other.EndingRewardInfoBundle);
		}
		if (other.immortalRewardInfoBundle_ != null)
		{
			if (immortalRewardInfoBundle_ == null)
			{
				ImmortalRewardInfoBundle = new RewardDBInfoBundle();
			}
			ImmortalRewardInfoBundle.MergeFrom(other.ImmortalRewardInfoBundle);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 66u:
				reputationInfo_.AddEntriesFrom(ref input, _repeated_reputationInfo_codec);
				break;
			case 74u:
				if (questLevelInfo_ == null)
				{
					QuestLevelInfo = new QuestLevelDBInfo();
				}
				input.ReadMessage(QuestLevelInfo);
				break;
			case 90u:
				packInfo_.AddEntriesFrom(ref input, _repeated_packInfo_codec);
				break;
			case 98u:
				if (endingRewardInfoBundle_ == null)
				{
					EndingRewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(EndingRewardInfoBundle);
				break;
			case 106u:
				if (immortalRewardInfoBundle_ == null)
				{
					ImmortalRewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(ImmortalRewardInfoBundle);
				break;
			case 80u:
			case 82u:
				deleteCharInvenIndex_.AddEntriesFrom(ref input, _repeated_deleteCharInvenIndex_codec);
				break;
			case 10u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 18u:
				if (questInfo_ == null)
				{
					QuestInfo = new QuestDBInfo();
				}
				input.ReadMessage(QuestInfo);
				break;
			case 24u:
				ClearQuestId = input.ReadInt32();
				break;
			case 34u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 42u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 50u:
				giveQuestItem_.AddEntriesFrom(ref input, _repeated_giveQuestItem_codec);
				break;
			case 58u:
				removeQuestItem_.AddEntriesFrom(ref input, _repeated_removeQuestItem_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
