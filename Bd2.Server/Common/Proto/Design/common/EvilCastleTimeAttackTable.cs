using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EvilCastleTimeAttackTable : IMessage<EvilCastleTimeAttackTable>, IMessage, IEquatable<EvilCastleTimeAttackTable>, IDeepCloneable<EvilCastleTimeAttackTable>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleTimeAttackTable> _parser = new MessageParser<EvilCastleTimeAttackTable>(() => new EvilCastleTimeAttackTable());

	private UnknownFieldSet _unknownFields;

	public const int DeductPointFieldNumber = 1;

	private int deductPoint_;

	public const int DeductTimeFieldNumber = 2;

	private int deductTime_;

	public const int DefaultPointFieldNumber = 3;

	private int defaultPoint_;

	public const int LimitPointFieldNumber = 4;

	private int limitPoint_;

	public const int BattleDefaultPointFieldNumber = 5;

	private int battleDefaultPoint_;

	public const int BossExtraPointsFieldNumber = 6;

	private double bossExtraPoints_;

	public const int DamageAddPointFieldNumber = 7;

	private int damageAddPoint_;

	public const int DamageMaxLimitFieldNumber = 8;

	private int damageMaxLimit_;

	public const int IdFieldNumber = 9;

	private int id_;

	public const int RetryDeductPointFieldNumber = 10;

	private int retryDeductPoint_;

	public const int SurvivalAddPointFieldNumber = 11;

	private int survivalAddPoint_;

	public const int TurnAddPointFieldNumber = 12;

	private int turnAddPoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleTimeAttackTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleTimeAttackTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DeductPoint
	{
		get
		{
			return deductPoint_;
		}
		set
		{
			deductPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DeductTime
	{
		get
		{
			return deductTime_;
		}
		set
		{
			deductTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DefaultPoint
	{
		get
		{
			return defaultPoint_;
		}
		set
		{
			defaultPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LimitPoint
	{
		get
		{
			return limitPoint_;
		}
		set
		{
			limitPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleDefaultPoint
	{
		get
		{
			return battleDefaultPoint_;
		}
		set
		{
			battleDefaultPoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double BossExtraPoints
	{
		get
		{
			return bossExtraPoints_;
		}
		set
		{
			bossExtraPoints_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DamageAddPoint
	{
		get
		{
			return damageAddPoint_;
		}
		set
		{
			damageAddPoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DamageMaxLimit
	{
		get
		{
			return damageMaxLimit_;
		}
		set
		{
			damageMaxLimit_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int RetryDeductPoint
	{
		get
		{
			return retryDeductPoint_;
		}
		set
		{
			retryDeductPoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SurvivalAddPoint
	{
		get
		{
			return survivalAddPoint_;
		}
		set
		{
			survivalAddPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TurnAddPoint
	{
		get
		{
			return turnAddPoint_;
		}
		set
		{
			turnAddPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleTimeAttackTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleTimeAttackTable(EvilCastleTimeAttackTable other)
		: this()
	{
		deductPoint_ = other.deductPoint_;
		deductTime_ = other.deductTime_;
		defaultPoint_ = other.defaultPoint_;
		limitPoint_ = other.limitPoint_;
		battleDefaultPoint_ = other.battleDefaultPoint_;
		bossExtraPoints_ = other.bossExtraPoints_;
		damageAddPoint_ = other.damageAddPoint_;
		damageMaxLimit_ = other.damageMaxLimit_;
		id_ = other.id_;
		retryDeductPoint_ = other.retryDeductPoint_;
		survivalAddPoint_ = other.survivalAddPoint_;
		turnAddPoint_ = other.turnAddPoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleTimeAttackTable Clone()
	{
		return new EvilCastleTimeAttackTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleTimeAttackTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleTimeAttackTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DeductPoint == other.DeductPoint && DeductTime == other.DeductTime && DefaultPoint == other.DefaultPoint && LimitPoint == other.LimitPoint && BattleDefaultPoint == other.BattleDefaultPoint && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BossExtraPoints, other.BossExtraPoints) && DamageAddPoint == other.DamageAddPoint && DamageMaxLimit == other.DamageMaxLimit && Id == other.Id && RetryDeductPoint == other.RetryDeductPoint && SurvivalAddPoint == other.SurvivalAddPoint && TurnAddPoint == other.TurnAddPoint)
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
		if (DeductPoint != 0)
		{
			num ^= DeductPoint.GetHashCode();
		}
		if (DeductTime != 0)
		{
			num ^= DeductTime.GetHashCode();
		}
		if (DefaultPoint != 0)
		{
			num ^= DefaultPoint.GetHashCode();
		}
		if (LimitPoint != 0)
		{
			num ^= LimitPoint.GetHashCode();
		}
		if (BattleDefaultPoint != 0)
		{
			num ^= BattleDefaultPoint.GetHashCode();
		}
		if (BossExtraPoints != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BossExtraPoints);
		}
		if (DamageAddPoint != 0)
		{
			num ^= DamageAddPoint.GetHashCode();
		}
		if (DamageMaxLimit != 0)
		{
			num ^= DamageMaxLimit.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RetryDeductPoint != 0)
		{
			num ^= RetryDeductPoint.GetHashCode();
		}
		if (SurvivalAddPoint != 0)
		{
			num ^= SurvivalAddPoint.GetHashCode();
		}
		if (TurnAddPoint != 0)
		{
			num ^= TurnAddPoint.GetHashCode();
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
		if (DeductPoint != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DeductPoint);
		}
		if (DeductTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DeductTime);
		}
		if (DefaultPoint != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DefaultPoint);
		}
		if (LimitPoint != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LimitPoint);
		}
		if (BattleDefaultPoint != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BattleDefaultPoint);
		}
		if (BossExtraPoints != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(BossExtraPoints);
		}
		if (DamageAddPoint != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DamageAddPoint);
		}
		if (DamageMaxLimit != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(DamageMaxLimit);
		}
		if (Id != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Id);
		}
		if (RetryDeductPoint != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(RetryDeductPoint);
		}
		if (SurvivalAddPoint != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(SurvivalAddPoint);
		}
		if (TurnAddPoint != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(TurnAddPoint);
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
		if (DeductPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DeductPoint);
		}
		if (DeductTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DeductTime);
		}
		if (DefaultPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultPoint);
		}
		if (LimitPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitPoint);
		}
		if (BattleDefaultPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDefaultPoint);
		}
		if (BossExtraPoints != 0.0)
		{
			num += 9;
		}
		if (DamageAddPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DamageAddPoint);
		}
		if (DamageMaxLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DamageMaxLimit);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RetryDeductPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RetryDeductPoint);
		}
		if (SurvivalAddPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SurvivalAddPoint);
		}
		if (TurnAddPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TurnAddPoint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleTimeAttackTable other)
	{
		if (other != null)
		{
			if (other.DeductPoint != 0)
			{
				DeductPoint = other.DeductPoint;
			}
			if (other.DeductTime != 0)
			{
				DeductTime = other.DeductTime;
			}
			if (other.DefaultPoint != 0)
			{
				DefaultPoint = other.DefaultPoint;
			}
			if (other.LimitPoint != 0)
			{
				LimitPoint = other.LimitPoint;
			}
			if (other.BattleDefaultPoint != 0)
			{
				BattleDefaultPoint = other.BattleDefaultPoint;
			}
			if (other.BossExtraPoints != 0.0)
			{
				BossExtraPoints = other.BossExtraPoints;
			}
			if (other.DamageAddPoint != 0)
			{
				DamageAddPoint = other.DamageAddPoint;
			}
			if (other.DamageMaxLimit != 0)
			{
				DamageMaxLimit = other.DamageMaxLimit;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RetryDeductPoint != 0)
			{
				RetryDeductPoint = other.RetryDeductPoint;
			}
			if (other.SurvivalAddPoint != 0)
			{
				SurvivalAddPoint = other.SurvivalAddPoint;
			}
			if (other.TurnAddPoint != 0)
			{
				TurnAddPoint = other.TurnAddPoint;
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
				DeductPoint = input.ReadInt32();
				break;
			case 16u:
				DeductTime = input.ReadInt32();
				break;
			case 24u:
				DefaultPoint = input.ReadInt32();
				break;
			case 32u:
				LimitPoint = input.ReadInt32();
				break;
			case 40u:
				BattleDefaultPoint = input.ReadInt32();
				break;
			case 49u:
				BossExtraPoints = input.ReadDouble();
				break;
			case 56u:
				DamageAddPoint = input.ReadInt32();
				break;
			case 64u:
				DamageMaxLimit = input.ReadInt32();
				break;
			case 72u:
				Id = input.ReadInt32();
				break;
			case 80u:
				RetryDeductPoint = input.ReadInt32();
				break;
			case 88u:
				SurvivalAddPoint = input.ReadInt32();
				break;
			case 96u:
				TurnAddPoint = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
