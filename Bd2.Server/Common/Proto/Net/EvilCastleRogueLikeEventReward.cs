using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeEventReward : IMessage<EvilCastleRogueLikeEventReward>, IMessage, IEquatable<EvilCastleRogueLikeEventReward>, IDeepCloneable<EvilCastleRogueLikeEventReward>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeEventReward> _parser = new MessageParser<EvilCastleRogueLikeEventReward>(() => new EvilCastleRogueLikeEventReward());

	private UnknownFieldSet _unknownFields;

	public const int RogueLikeGoldFieldNumber = 1;

	private int rogueLikeGold_;

	public const int CharInfoFieldNumber = 2;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(18u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int AddRelicInfoFieldNumber = 3;

	private static readonly FieldCodec<RelicDBInfo> _repeated_addRelicInfo_codec = FieldCodec.ForMessage(26u, RelicDBInfo.Parser);

	private readonly RepeatedField<RelicDBInfo> addRelicInfo_ = new RepeatedField<RelicDBInfo>();

	public const int RemoveRelicInfoFieldNumber = 4;

	private static readonly FieldCodec<RelicDBInfo> _repeated_removeRelicInfo_codec = FieldCodec.ForMessage(34u, RelicDBInfo.Parser);

	private readonly RepeatedField<RelicDBInfo> removeRelicInfo_ = new RepeatedField<RelicDBInfo>();

	public const int ChoiceInfoFieldNumber = 5;

	private EvilCastleRogueLikeChoiceInfo choiceInfo_;

	public const int BattleLevelFieldNumber = 6;

	private int battleLevel_;

	public const int HealRateFieldNumber = 7;

	private int healRate_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleRogueLikeEventReward> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeEventRewardReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RogueLikeGold
	{
		get
		{
			return rogueLikeGold_;
		}
		set
		{
			rogueLikeGold_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<RelicDBInfo> AddRelicInfo => addRelicInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<RelicDBInfo> RemoveRelicInfo => removeRelicInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeChoiceInfo ChoiceInfo
	{
		get
		{
			return choiceInfo_;
		}
		set
		{
			choiceInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleLevel
	{
		get
		{
			return battleLevel_;
		}
		set
		{
			battleLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HealRate
	{
		get
		{
			return healRate_;
		}
		set
		{
			healRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeEventReward()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeEventReward(EvilCastleRogueLikeEventReward other)
		: this()
	{
		rogueLikeGold_ = other.rogueLikeGold_;
		charInfo_ = other.charInfo_.Clone();
		addRelicInfo_ = other.addRelicInfo_.Clone();
		removeRelicInfo_ = other.removeRelicInfo_.Clone();
		choiceInfo_ = ((other.choiceInfo_ != null) ? other.choiceInfo_.Clone() : null);
		battleLevel_ = other.battleLevel_;
		healRate_ = other.healRate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeEventReward Clone()
	{
		return new EvilCastleRogueLikeEventReward(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeEventReward);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EvilCastleRogueLikeEventReward other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (RogueLikeGold == other.RogueLikeGold && charInfo_.Equals(other.charInfo_) && addRelicInfo_.Equals(other.addRelicInfo_) && removeRelicInfo_.Equals(other.removeRelicInfo_) && object.Equals(ChoiceInfo, other.ChoiceInfo) && BattleLevel == other.BattleLevel && HealRate == other.HealRate)
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
		if (RogueLikeGold != 0)
		{
			num ^= RogueLikeGold.GetHashCode();
		}
		num ^= charInfo_.GetHashCode();
		num ^= addRelicInfo_.GetHashCode();
		num ^= removeRelicInfo_.GetHashCode();
		if (choiceInfo_ != null)
		{
			num ^= ChoiceInfo.GetHashCode();
		}
		if (BattleLevel != 0)
		{
			num ^= BattleLevel.GetHashCode();
		}
		if (HealRate != 0)
		{
			num ^= HealRate.GetHashCode();
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
		if (RogueLikeGold != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RogueLikeGold);
		}
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		addRelicInfo_.WriteTo(ref output, _repeated_addRelicInfo_codec);
		removeRelicInfo_.WriteTo(ref output, _repeated_removeRelicInfo_codec);
		if (choiceInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ChoiceInfo);
		}
		if (BattleLevel != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BattleLevel);
		}
		if (HealRate != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(HealRate);
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
		if (RogueLikeGold != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RogueLikeGold);
		}
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += addRelicInfo_.CalculateSize(_repeated_addRelicInfo_codec);
		num += removeRelicInfo_.CalculateSize(_repeated_removeRelicInfo_codec);
		if (choiceInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChoiceInfo);
		}
		if (BattleLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleLevel);
		}
		if (HealRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HealRate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeEventReward other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RogueLikeGold != 0)
		{
			RogueLikeGold = other.RogueLikeGold;
		}
		charInfo_.Add(other.charInfo_);
		addRelicInfo_.Add(other.addRelicInfo_);
		removeRelicInfo_.Add(other.removeRelicInfo_);
		if (other.choiceInfo_ != null)
		{
			if (choiceInfo_ == null)
			{
				ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
			}
			ChoiceInfo.MergeFrom(other.ChoiceInfo);
		}
		if (other.BattleLevel != 0)
		{
			BattleLevel = other.BattleLevel;
		}
		if (other.HealRate != 0)
		{
			HealRate = other.HealRate;
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
			case 8u:
				RogueLikeGold = input.ReadInt32();
				break;
			case 18u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 26u:
				addRelicInfo_.AddEntriesFrom(ref input, _repeated_addRelicInfo_codec);
				break;
			case 34u:
				removeRelicInfo_.AddEntriesFrom(ref input, _repeated_removeRelicInfo_codec);
				break;
			case 42u:
				if (choiceInfo_ == null)
				{
					ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
				}
				input.ReadMessage(ChoiceInfo);
				break;
			case 48u:
				BattleLevel = input.ReadInt32();
				break;
			case 56u:
				HealRate = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
