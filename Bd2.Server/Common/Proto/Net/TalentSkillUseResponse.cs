using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TalentSkillUseResponse : IMessage<TalentSkillUseResponse>, IMessage, IEquatable<TalentSkillUseResponse>, IDeepCloneable<TalentSkillUseResponse>, IBufferMessage
{
	private static readonly MessageParser<TalentSkillUseResponse> _parser = new MessageParser<TalentSkillUseResponse>(() => new TalentSkillUseResponse());

	private UnknownFieldSet _unknownFields;

	public const int TalentSkillInfoFieldNumber = 1;

	private TalentSkillDBInfo talentSkillInfo_;

	public const int TalentNpcInfoFieldNumber = 2;

	private TalentNpcDBInfo talentNpcInfo_;

	public const int ItemInfoFieldNumber = 3;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(26u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int EquipInfoFieldNumber = 4;

	private static readonly FieldCodec<EquipDBInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage(34u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> equipInfo_ = new RepeatedField<EquipDBInfo>();

	public const int RewardCharInfoFieldNumber = 5;

	private static readonly FieldCodec<CharDBInfo> _repeated_rewardCharInfo_codec = FieldCodec.ForMessage(42u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> rewardCharInfo_ = new RepeatedField<CharDBInfo>();

	public const int CostumeInfoFieldNumber = 6;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_costumeInfo_codec = FieldCodec.ForMessage(50u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> costumeInfo_ = new RepeatedField<CostumeDBInfo>();

	public const int ReputationInfoFieldNumber = 7;

	private static readonly FieldCodec<ReputationDBInfo> _repeated_reputationInfo_codec = FieldCodec.ForMessage(58u, ReputationDBInfo.Parser);

	private readonly RepeatedField<ReputationDBInfo> reputationInfo_ = new RepeatedField<ReputationDBInfo>();

	public const int DispatchInfoFieldNumber = 8;

	private static readonly FieldCodec<DispatchDBInfo> _repeated_dispatchInfo_codec = FieldCodec.ForMessage(66u, DispatchDBInfo.Parser);

	private readonly RepeatedField<DispatchDBInfo> dispatchInfo_ = new RepeatedField<DispatchDBInfo>();

	public const int MonsterInfoFieldNumber = 9;

	private static readonly FieldCodec<MonsterDBInfo> _repeated_monsterInfo_codec = FieldCodec.ForMessage(74u, MonsterDBInfo.Parser);

	private readonly RepeatedField<MonsterDBInfo> monsterInfo_ = new RepeatedField<MonsterDBInfo>();

	public const int AddTalentExpFieldNumber = 10;

	private int addTalentExp_;

	public const int IsSuccessFieldNumber = 11;

	private bool isSuccess_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TalentSkillUseResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TalentSkillUseResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentSkillDBInfo TalentSkillInfo
	{
		get
		{
			return talentSkillInfo_;
		}
		set
		{
			talentSkillInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentNpcDBInfo TalentNpcInfo
	{
		get
		{
			return talentNpcInfo_;
		}
		set
		{
			talentNpcInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipDBInfo> EquipInfo => equipInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> RewardCharInfo => rewardCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CostumeDBInfo> CostumeInfo => costumeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ReputationDBInfo> ReputationInfo => reputationInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DispatchDBInfo> DispatchInfo => dispatchInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterDBInfo> MonsterInfo => monsterInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AddTalentExp
	{
		get
		{
			return addTalentExp_;
		}
		set
		{
			addTalentExp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsSuccess
	{
		get
		{
			return isSuccess_;
		}
		set
		{
			isSuccess_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentSkillUseResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentSkillUseResponse(TalentSkillUseResponse other)
		: this()
	{
		talentSkillInfo_ = ((other.talentSkillInfo_ != null) ? other.talentSkillInfo_.Clone() : null);
		talentNpcInfo_ = ((other.talentNpcInfo_ != null) ? other.talentNpcInfo_.Clone() : null);
		itemInfo_ = other.itemInfo_.Clone();
		equipInfo_ = other.equipInfo_.Clone();
		rewardCharInfo_ = other.rewardCharInfo_.Clone();
		costumeInfo_ = other.costumeInfo_.Clone();
		reputationInfo_ = other.reputationInfo_.Clone();
		dispatchInfo_ = other.dispatchInfo_.Clone();
		monsterInfo_ = other.monsterInfo_.Clone();
		addTalentExp_ = other.addTalentExp_;
		isSuccess_ = other.isSuccess_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TalentSkillUseResponse Clone()
	{
		return new TalentSkillUseResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TalentSkillUseResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TalentSkillUseResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(TalentSkillInfo, other.TalentSkillInfo) && object.Equals(TalentNpcInfo, other.TalentNpcInfo) && itemInfo_.Equals(other.itemInfo_) && equipInfo_.Equals(other.equipInfo_) && rewardCharInfo_.Equals(other.rewardCharInfo_) && costumeInfo_.Equals(other.costumeInfo_) && reputationInfo_.Equals(other.reputationInfo_) && dispatchInfo_.Equals(other.dispatchInfo_) && monsterInfo_.Equals(other.monsterInfo_) && AddTalentExp == other.AddTalentExp && IsSuccess == other.IsSuccess)
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
		if (talentSkillInfo_ != null)
		{
			num ^= TalentSkillInfo.GetHashCode();
		}
		if (talentNpcInfo_ != null)
		{
			num ^= TalentNpcInfo.GetHashCode();
		}
		num ^= itemInfo_.GetHashCode();
		num ^= equipInfo_.GetHashCode();
		num ^= rewardCharInfo_.GetHashCode();
		num ^= costumeInfo_.GetHashCode();
		num ^= reputationInfo_.GetHashCode();
		num ^= dispatchInfo_.GetHashCode();
		num ^= monsterInfo_.GetHashCode();
		if (AddTalentExp != 0)
		{
			num ^= AddTalentExp.GetHashCode();
		}
		if (IsSuccess)
		{
			num ^= IsSuccess.GetHashCode();
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
		if (talentSkillInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(TalentSkillInfo);
		}
		if (talentNpcInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(TalentNpcInfo);
		}
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
		equipInfo_.WriteTo(ref output, _repeated_equipInfo_codec);
		rewardCharInfo_.WriteTo(ref output, _repeated_rewardCharInfo_codec);
		costumeInfo_.WriteTo(ref output, _repeated_costumeInfo_codec);
		reputationInfo_.WriteTo(ref output, _repeated_reputationInfo_codec);
		dispatchInfo_.WriteTo(ref output, _repeated_dispatchInfo_codec);
		monsterInfo_.WriteTo(ref output, _repeated_monsterInfo_codec);
		if (AddTalentExp != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(AddTalentExp);
		}
		if (IsSuccess)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsSuccess);
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
		if (talentSkillInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentSkillInfo);
		}
		if (talentNpcInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentNpcInfo);
		}
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		num += equipInfo_.CalculateSize(_repeated_equipInfo_codec);
		num += rewardCharInfo_.CalculateSize(_repeated_rewardCharInfo_codec);
		num += costumeInfo_.CalculateSize(_repeated_costumeInfo_codec);
		num += reputationInfo_.CalculateSize(_repeated_reputationInfo_codec);
		num += dispatchInfo_.CalculateSize(_repeated_dispatchInfo_codec);
		num += monsterInfo_.CalculateSize(_repeated_monsterInfo_codec);
		if (AddTalentExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddTalentExp);
		}
		if (IsSuccess)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TalentSkillUseResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.talentSkillInfo_ != null)
		{
			if (talentSkillInfo_ == null)
			{
				TalentSkillInfo = new TalentSkillDBInfo();
			}
			TalentSkillInfo.MergeFrom(other.TalentSkillInfo);
		}
		if (other.talentNpcInfo_ != null)
		{
			if (talentNpcInfo_ == null)
			{
				TalentNpcInfo = new TalentNpcDBInfo();
			}
			TalentNpcInfo.MergeFrom(other.TalentNpcInfo);
		}
		itemInfo_.Add(other.itemInfo_);
		equipInfo_.Add(other.equipInfo_);
		rewardCharInfo_.Add(other.rewardCharInfo_);
		costumeInfo_.Add(other.costumeInfo_);
		reputationInfo_.Add(other.reputationInfo_);
		dispatchInfo_.Add(other.dispatchInfo_);
		monsterInfo_.Add(other.monsterInfo_);
		if (other.AddTalentExp != 0)
		{
			AddTalentExp = other.AddTalentExp;
		}
		if (other.IsSuccess)
		{
			IsSuccess = other.IsSuccess;
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
				if (talentSkillInfo_ == null)
				{
					TalentSkillInfo = new TalentSkillDBInfo();
				}
				input.ReadMessage(TalentSkillInfo);
				break;
			case 18u:
				if (talentNpcInfo_ == null)
				{
					TalentNpcInfo = new TalentNpcDBInfo();
				}
				input.ReadMessage(TalentNpcInfo);
				break;
			case 26u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			case 34u:
				equipInfo_.AddEntriesFrom(ref input, _repeated_equipInfo_codec);
				break;
			case 42u:
				rewardCharInfo_.AddEntriesFrom(ref input, _repeated_rewardCharInfo_codec);
				break;
			case 50u:
				costumeInfo_.AddEntriesFrom(ref input, _repeated_costumeInfo_codec);
				break;
			case 58u:
				reputationInfo_.AddEntriesFrom(ref input, _repeated_reputationInfo_codec);
				break;
			case 66u:
				dispatchInfo_.AddEntriesFrom(ref input, _repeated_dispatchInfo_codec);
				break;
			case 74u:
				monsterInfo_.AddEntriesFrom(ref input, _repeated_monsterInfo_codec);
				break;
			case 80u:
				AddTalentExp = input.ReadInt32();
				break;
			case 88u:
				IsSuccess = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
