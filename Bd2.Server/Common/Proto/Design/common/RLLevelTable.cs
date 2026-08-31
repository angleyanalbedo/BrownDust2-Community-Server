using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLLevelTable : IMessage<RLLevelTable>, IMessage, IEquatable<RLLevelTable>, IDeepCloneable<RLLevelTable>, IBufferMessage
{
	private static readonly MessageParser<RLLevelTable> _parser = new MessageParser<RLLevelTable>(() => new RLLevelTable());

	private UnknownFieldSet _unknownFields;

	public const int CharApplyBuffIdFieldNumber = 1;

	private int charApplyBuffId_;

	public const int EnemyDamageRateFieldNumber = 2;

	private double enemyDamageRate_;

	public const int EnemyHealthRateFieldNumber = 3;

	private double enemyHealthRate_;

	public const int GetGoldRateFieldNumber = 4;

	private double getGoldRate_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int RewardCountFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int ScoreBonusRateFieldNumber = 9;

	private double scoreBonusRate_;

	public const int ShopDiscountChanceFieldNumber = 10;

	private double shopDiscountChance_;

	public const int SpStartCountFieldNumber = 11;

	private int spStartCount_;

	public const int SpTurnAddCountFieldNumber = 12;

	private int spTurnAddCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RLLevelTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RLLevelTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CharApplyBuffId
	{
		get
		{
			return charApplyBuffId_;
		}
		set
		{
			charApplyBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double EnemyDamageRate
	{
		get
		{
			return enemyDamageRate_;
		}
		set
		{
			enemyDamageRate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double EnemyHealthRate
	{
		get
		{
			return enemyHealthRate_;
		}
		set
		{
			enemyHealthRate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double GetGoldRate
	{
		get
		{
			return getGoldRate_;
		}
		set
		{
			getGoldRate_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardCount => rewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardId => rewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardType => rewardType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ScoreBonusRate
	{
		get
		{
			return scoreBonusRate_;
		}
		set
		{
			scoreBonusRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ShopDiscountChance
	{
		get
		{
			return shopDiscountChance_;
		}
		set
		{
			shopDiscountChance_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpStartCount
	{
		get
		{
			return spStartCount_;
		}
		set
		{
			spStartCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpTurnAddCount
	{
		get
		{
			return spTurnAddCount_;
		}
		set
		{
			spTurnAddCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLLevelTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLLevelTable(RLLevelTable other)
		: this()
	{
		charApplyBuffId_ = other.charApplyBuffId_;
		enemyDamageRate_ = other.enemyDamageRate_;
		enemyHealthRate_ = other.enemyHealthRate_;
		getGoldRate_ = other.getGoldRate_;
		id_ = other.id_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		scoreBonusRate_ = other.scoreBonusRate_;
		shopDiscountChance_ = other.shopDiscountChance_;
		spStartCount_ = other.spStartCount_;
		spTurnAddCount_ = other.spTurnAddCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLLevelTable Clone()
	{
		return new RLLevelTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLLevelTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RLLevelTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CharApplyBuffId == other.CharApplyBuffId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(EnemyDamageRate, other.EnemyDamageRate) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(EnemyHealthRate, other.EnemyHealthRate) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GetGoldRate, other.GetGoldRate) && Id == other.Id && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ScoreBonusRate, other.ScoreBonusRate) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ShopDiscountChance, other.ShopDiscountChance) && SpStartCount == other.SpStartCount && SpTurnAddCount == other.SpTurnAddCount)
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
		if (CharApplyBuffId != 0)
		{
			num ^= CharApplyBuffId.GetHashCode();
		}
		if (EnemyDamageRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(EnemyDamageRate);
		}
		if (EnemyHealthRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(EnemyHealthRate);
		}
		if (GetGoldRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GetGoldRate);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
		if (ScoreBonusRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ScoreBonusRate);
		}
		if (ShopDiscountChance != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ShopDiscountChance);
		}
		if (SpStartCount != 0)
		{
			num ^= SpStartCount.GetHashCode();
		}
		if (SpTurnAddCount != 0)
		{
			num ^= SpTurnAddCount.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (CharApplyBuffId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CharApplyBuffId);
		}
		if (EnemyDamageRate != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(EnemyDamageRate);
		}
		if (EnemyHealthRate != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(EnemyHealthRate);
		}
		if (GetGoldRate != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(GetGoldRate);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		if (ScoreBonusRate != 0.0)
		{
			output.WriteRawTag(73);
			output.WriteDouble(ScoreBonusRate);
		}
		if (ShopDiscountChance != 0.0)
		{
			output.WriteRawTag(81);
			output.WriteDouble(ShopDiscountChance);
		}
		if (SpStartCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(SpStartCount);
		}
		if (SpTurnAddCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(SpTurnAddCount);
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
		if (CharApplyBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharApplyBuffId);
		}
		if (EnemyDamageRate != 0.0)
		{
			num += 9;
		}
		if (EnemyHealthRate != 0.0)
		{
			num += 9;
		}
		if (GetGoldRate != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		if (ScoreBonusRate != 0.0)
		{
			num += 9;
		}
		if (ShopDiscountChance != 0.0)
		{
			num += 9;
		}
		if (SpStartCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpStartCount);
		}
		if (SpTurnAddCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpTurnAddCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RLLevelTable other)
	{
		if (other != null)
		{
			if (other.CharApplyBuffId != 0)
			{
				CharApplyBuffId = other.CharApplyBuffId;
			}
			if (other.EnemyDamageRate != 0.0)
			{
				EnemyDamageRate = other.EnemyDamageRate;
			}
			if (other.EnemyHealthRate != 0.0)
			{
				EnemyHealthRate = other.EnemyHealthRate;
			}
			if (other.GetGoldRate != 0.0)
			{
				GetGoldRate = other.GetGoldRate;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
			if (other.ScoreBonusRate != 0.0)
			{
				ScoreBonusRate = other.ScoreBonusRate;
			}
			if (other.ShopDiscountChance != 0.0)
			{
				ShopDiscountChance = other.ShopDiscountChance;
			}
			if (other.SpStartCount != 0)
			{
				SpStartCount = other.SpStartCount;
			}
			if (other.SpTurnAddCount != 0)
			{
				SpTurnAddCount = other.SpTurnAddCount;
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
			case 8u:
				CharApplyBuffId = input.ReadInt32();
				break;
			case 17u:
				EnemyDamageRate = input.ReadDouble();
				break;
			case 25u:
				EnemyHealthRate = input.ReadDouble();
				break;
			case 33u:
				GetGoldRate = input.ReadDouble();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			case 56u:
			case 58u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 64u:
			case 66u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			case 73u:
				ScoreBonusRate = input.ReadDouble();
				break;
			case 81u:
				ShopDiscountChance = input.ReadDouble();
				break;
			case 88u:
				SpStartCount = input.ReadInt32();
				break;
			case 96u:
				SpTurnAddCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
