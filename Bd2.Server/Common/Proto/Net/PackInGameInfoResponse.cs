using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PackInGameInfoResponse : IMessage<PackInGameInfoResponse>, IMessage, IEquatable<PackInGameInfoResponse>, IDeepCloneable<PackInGameInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<PackInGameInfoResponse> _parser = new MessageParser<PackInGameInfoResponse>(() => new PackInGameInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int CharInfoFieldNumber = 1;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(10u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int QuestInfoFieldNumber = 2;

	private static readonly FieldCodec<QuestDBInfo> _repeated_questInfo_codec = FieldCodec.ForMessage(18u, QuestDBInfo.Parser);

	private readonly RepeatedField<QuestDBInfo> questInfo_ = new RepeatedField<QuestDBInfo>();

	public const int ClearQuestIdsFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_clearQuestIds_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> clearQuestIds_ = new RepeatedField<int>();

	public const int PositionFieldNumber = 4;

	private string position_ = "";

	public const int TalentNpcInfoFieldNumber = 5;

	private static readonly FieldCodec<TalentNpcDBInfo> _repeated_talentNpcInfo_codec = FieldCodec.ForMessage(42u, TalentNpcDBInfo.Parser);

	private readonly RepeatedField<TalentNpcDBInfo> talentNpcInfo_ = new RepeatedField<TalentNpcDBInfo>();

	public const int MonsterInfoFieldNumber = 6;

	private static readonly FieldCodec<MonsterDBInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage(50u, MonsterDBInfo.Parser);

	private readonly RepeatedField<MonsterDBInfo> monsterInfo_ = new RepeatedField<MonsterDBInfo>();

	public const int TalentObjectInfoFieldNumber = 7;

	private static readonly FieldCodec<TalentObjectDBInfo> _repeated_talentObjectInfo_codec = FieldCodec.ForMessage(58u, TalentObjectDBInfo.Parser);

	private readonly RepeatedField<TalentObjectDBInfo> talentObjectInfo_ = new RepeatedField<TalentObjectDBInfo>();

	public const int FieldBuffInfoFieldNumber = 8;

	private static readonly FieldCodec<FieldBuffDBInfo> _repeated_fieldBuffInfo_codec = FieldCodec.ForMessage(66u, FieldBuffDBInfo.Parser);

	private readonly RepeatedField<FieldBuffDBInfo> fieldBuffInfo_ = new RepeatedField<FieldBuffDBInfo>();

	public const int ReputationInfoFieldNumber = 9;

	private static readonly FieldCodec<ReputationDBInfo> _repeated_reputationInfo_codec = FieldCodec.ForMessage(74u, ReputationDBInfo.Parser);

	private readonly RepeatedField<ReputationDBInfo> reputationInfo_ = new RepeatedField<ReputationDBInfo>();

	public const int MapActiveInfoFieldNumber = 10;

	private static readonly FieldCodec<MapActiveInfo> _repeated_mapActiveInfo_codec = FieldCodec.ForMessage(82u, Bd2.Server.Common.Proto.Net.MapActiveInfo.Parser);

	private readonly RepeatedField<MapActiveInfo> mapActiveInfo_ = new RepeatedField<MapActiveInfo>();

	public const int ResearchObjectIdFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_researchObjectId_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> researchObjectId_ = new RepeatedField<int>();

	public const int HuntingGroundInfoFieldNumber = 12;

	private HuntingGroundDBInfo huntingGroundInfo_;

	public const int TalentSkillInfoFieldNumber = 13;

	private static readonly FieldCodec<TalentSkillDBInfo> _repeated_talentSkillInfo_codec = FieldCodec.ForMessage(106u, TalentSkillDBInfo.Parser);

	private readonly RepeatedField<TalentSkillDBInfo> talentSkillInfo_ = new RepeatedField<TalentSkillDBInfo>();

	public const int StatueInfoFieldNumber = 14;

	private static readonly FieldCodec<StatueDBInfo> _repeated_statueInfo_codec = FieldCodec.ForMessage(114u, StatueDBInfo.Parser);

	private readonly RepeatedField<StatueDBInfo> statueInfo_ = new RepeatedField<StatueDBInfo>();

	public const int StatueRewardObtainIdFieldNumber = 15;

	private static readonly FieldCodec<int> _repeated_statueRewardObtainId_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> statueRewardObtainId_ = new RepeatedField<int>();

	public const int RewardInfoBundleFieldNumber = 16;

	private RewardDBInfoBundle rewardInfoBundle_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackInGameInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackInGameInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<QuestDBInfo> QuestInfo => questInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ClearQuestIds => clearQuestIds_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<TalentNpcDBInfo> TalentNpcInfo => talentNpcInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonsterDBInfo> MonsterInfo => monsterInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TalentObjectDBInfo> TalentObjectInfo => talentObjectInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldBuffDBInfo> FieldBuffInfo => fieldBuffInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ReputationDBInfo> ReputationInfo => reputationInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MapActiveInfo> MapActiveInfo => mapActiveInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ResearchObjectId => researchObjectId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HuntingGroundDBInfo HuntingGroundInfo
	{
		get
		{
			return huntingGroundInfo_;
		}
		set
		{
			huntingGroundInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TalentSkillDBInfo> TalentSkillInfo => talentSkillInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<StatueDBInfo> StatueInfo => statueInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> StatueRewardObtainId => statueRewardObtainId_;

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackInGameInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackInGameInfoResponse(PackInGameInfoResponse other)
		: this()
	{
		charInfo_ = other.charInfo_.Clone();
		questInfo_ = other.questInfo_.Clone();
		clearQuestIds_ = other.clearQuestIds_.Clone();
		position_ = other.position_;
		talentNpcInfo_ = other.talentNpcInfo_.Clone();
		monsterInfo_ = other.monsterInfo_.Clone();
		talentObjectInfo_ = other.talentObjectInfo_.Clone();
		fieldBuffInfo_ = other.fieldBuffInfo_.Clone();
		reputationInfo_ = other.reputationInfo_.Clone();
		mapActiveInfo_ = other.mapActiveInfo_.Clone();
		researchObjectId_ = other.researchObjectId_.Clone();
		huntingGroundInfo_ = ((other.huntingGroundInfo_ != null) ? other.huntingGroundInfo_.Clone() : null);
		talentSkillInfo_ = other.talentSkillInfo_.Clone();
		statueInfo_ = other.statueInfo_.Clone();
		statueRewardObtainId_ = other.statueRewardObtainId_.Clone();
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackInGameInfoResponse Clone()
	{
		return new PackInGameInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackInGameInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PackInGameInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charInfo_.Equals(other.charInfo_) && questInfo_.Equals(other.questInfo_) && clearQuestIds_.Equals(other.clearQuestIds_) && !(Position != other.Position) && talentNpcInfo_.Equals(other.talentNpcInfo_) && monsterInfo_.Equals(other.monsterInfo_) && talentObjectInfo_.Equals(other.talentObjectInfo_) && fieldBuffInfo_.Equals(other.fieldBuffInfo_) && reputationInfo_.Equals(other.reputationInfo_) && mapActiveInfo_.Equals(other.mapActiveInfo_) && researchObjectId_.Equals(other.researchObjectId_) && object.Equals(HuntingGroundInfo, other.HuntingGroundInfo) && talentSkillInfo_.Equals(other.talentSkillInfo_) && statueInfo_.Equals(other.statueInfo_) && statueRewardObtainId_.Equals(other.statueRewardObtainId_) && object.Equals(RewardInfoBundle, other.RewardInfoBundle))
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
		num ^= charInfo_.GetHashCode();
		num ^= questInfo_.GetHashCode();
		num ^= clearQuestIds_.GetHashCode();
		if (Position.Length != 0)
		{
			num ^= Position.GetHashCode();
		}
		num ^= talentNpcInfo_.GetHashCode();
		num ^= monsterInfo_.GetHashCode();
		num ^= talentObjectInfo_.GetHashCode();
		num ^= fieldBuffInfo_.GetHashCode();
		num ^= reputationInfo_.GetHashCode();
		num ^= mapActiveInfo_.GetHashCode();
		num ^= researchObjectId_.GetHashCode();
		if (huntingGroundInfo_ != null)
		{
			num ^= HuntingGroundInfo.GetHashCode();
		}
		num ^= talentSkillInfo_.GetHashCode();
		num ^= statueInfo_.GetHashCode();
		num ^= statueRewardObtainId_.GetHashCode();
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
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
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		questInfo_.WriteTo(ref output, _repeated_questInfo_codec);
		clearQuestIds_.WriteTo(ref output, _repeated_clearQuestIds_codec);
		if (Position.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Position);
		}
		talentNpcInfo_.WriteTo(ref output, _repeated_talentNpcInfo_codec);
		monsterInfo_.WriteTo(ref output, _repeated_monsterInfo_codec);
		talentObjectInfo_.WriteTo(ref output, _repeated_talentObjectInfo_codec);
		fieldBuffInfo_.WriteTo(ref output, _repeated_fieldBuffInfo_codec);
		reputationInfo_.WriteTo(ref output, _repeated_reputationInfo_codec);
		mapActiveInfo_.WriteTo(ref output, _repeated_mapActiveInfo_codec);
		researchObjectId_.WriteTo(ref output, _repeated_researchObjectId_codec);
		if (huntingGroundInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(HuntingGroundInfo);
		}
		talentSkillInfo_.WriteTo(ref output, _repeated_talentSkillInfo_codec);
		statueInfo_.WriteTo(ref output, _repeated_statueInfo_codec);
		statueRewardObtainId_.WriteTo(ref output, _repeated_statueRewardObtainId_codec);
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(RewardInfoBundle);
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
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += questInfo_.CalculateSize(_repeated_questInfo_codec);
		num += clearQuestIds_.CalculateSize(_repeated_clearQuestIds_codec);
		if (Position.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Position);
		}
		num += talentNpcInfo_.CalculateSize(_repeated_talentNpcInfo_codec);
		num += monsterInfo_.CalculateSize(_repeated_monsterInfo_codec);
		num += talentObjectInfo_.CalculateSize(_repeated_talentObjectInfo_codec);
		num += fieldBuffInfo_.CalculateSize(_repeated_fieldBuffInfo_codec);
		num += reputationInfo_.CalculateSize(_repeated_reputationInfo_codec);
		num += mapActiveInfo_.CalculateSize(_repeated_mapActiveInfo_codec);
		num += researchObjectId_.CalculateSize(_repeated_researchObjectId_codec);
		if (huntingGroundInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HuntingGroundInfo);
		}
		num += talentSkillInfo_.CalculateSize(_repeated_talentSkillInfo_codec);
		num += statueInfo_.CalculateSize(_repeated_statueInfo_codec);
		num += statueRewardObtainId_.CalculateSize(_repeated_statueRewardObtainId_codec);
		if (rewardInfoBundle_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackInGameInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		charInfo_.Add(other.charInfo_);
		questInfo_.Add(other.questInfo_);
		clearQuestIds_.Add(other.clearQuestIds_);
		if (other.Position.Length != 0)
		{
			Position = other.Position;
		}
		talentNpcInfo_.Add(other.talentNpcInfo_);
		monsterInfo_.Add(other.monsterInfo_);
		talentObjectInfo_.Add(other.talentObjectInfo_);
		fieldBuffInfo_.Add(other.fieldBuffInfo_);
		reputationInfo_.Add(other.reputationInfo_);
		mapActiveInfo_.Add(other.mapActiveInfo_);
		researchObjectId_.Add(other.researchObjectId_);
		if (other.huntingGroundInfo_ != null)
		{
			if (huntingGroundInfo_ == null)
			{
				HuntingGroundInfo = new HuntingGroundDBInfo();
			}
			HuntingGroundInfo.MergeFrom(other.HuntingGroundInfo);
		}
		talentSkillInfo_.Add(other.talentSkillInfo_);
		statueInfo_.Add(other.statueInfo_);
		statueRewardObtainId_.Add(other.statueRewardObtainId_);
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
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
			case 10u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 18u:
				questInfo_.AddEntriesFrom(ref input, _repeated_questInfo_codec);
				break;
			case 24u:
			case 26u:
				clearQuestIds_.AddEntriesFrom(ref input, _repeated_clearQuestIds_codec);
				break;
			case 34u:
				Position = input.ReadString();
				break;
			case 42u:
				talentNpcInfo_.AddEntriesFrom(ref input, _repeated_talentNpcInfo_codec);
				break;
			case 50u:
				monsterInfo_.AddEntriesFrom(ref input, _repeated_monsterInfo_codec);
				break;
			case 58u:
				talentObjectInfo_.AddEntriesFrom(ref input, _repeated_talentObjectInfo_codec);
				break;
			case 66u:
				fieldBuffInfo_.AddEntriesFrom(ref input, _repeated_fieldBuffInfo_codec);
				break;
			case 74u:
				reputationInfo_.AddEntriesFrom(ref input, _repeated_reputationInfo_codec);
				break;
			case 82u:
				mapActiveInfo_.AddEntriesFrom(ref input, _repeated_mapActiveInfo_codec);
				break;
			case 88u:
			case 90u:
				researchObjectId_.AddEntriesFrom(ref input, _repeated_researchObjectId_codec);
				break;
			case 98u:
				if (huntingGroundInfo_ == null)
				{
					HuntingGroundInfo = new HuntingGroundDBInfo();
				}
				input.ReadMessage(HuntingGroundInfo);
				break;
			case 106u:
				talentSkillInfo_.AddEntriesFrom(ref input, _repeated_talentSkillInfo_codec);
				break;
			case 114u:
				statueInfo_.AddEntriesFrom(ref input, _repeated_statueInfo_codec);
				break;
			case 120u:
			case 122u:
				statueRewardObtainId_.AddEntriesFrom(ref input, _repeated_statueRewardObtainId_codec);
				break;
			case 130u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
