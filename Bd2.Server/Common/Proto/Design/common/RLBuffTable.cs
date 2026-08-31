using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLBuffTable : IMessage<RLBuffTable>, IMessage, IEquatable<RLBuffTable>, IDeepCloneable<RLBuffTable>, IBufferMessage
{
	private static readonly MessageParser<RLBuffTable> _parser = new MessageParser<RLBuffTable>(() => new RLBuffTable());

	private UnknownFieldSet _unknownFields;

	public const int ConditionTimingFieldNumber = 1;

	private int conditionTiming_;

	public const int ConditionTypeFieldNumber = 2;

	private int conditionType_;

	public const int ConditionValueFieldNumber = 3;

	private int conditionValue_;

	public const int EffectApplyTypeFieldNumber = 4;

	private int effectApplyType_;

	public const int EffectApplyValueFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_effectApplyValue_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> effectApplyValue_ = new RepeatedField<int>();

	public const int EffectTypeFieldNumber = 6;

	private int effectType_;

	public const int EffectValueFieldNumber = 7;

	private double effectValue_;

	public const int IdFieldNumber = 8;

	private int id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RLBuffTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => RLBuffTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ConditionTiming
	{
		get
		{
			return conditionTiming_;
		}
		set
		{
			conditionTiming_ = value;
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
	public int ConditionValue
	{
		get
		{
			return conditionValue_;
		}
		set
		{
			conditionValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EffectApplyType
	{
		get
		{
			return effectApplyType_;
		}
		set
		{
			effectApplyType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> EffectApplyValue => effectApplyValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EffectType
	{
		get
		{
			return effectType_;
		}
		set
		{
			effectType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double EffectValue
	{
		get
		{
			return effectValue_;
		}
		set
		{
			effectValue_ = value;
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
	public RLBuffTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLBuffTable(RLBuffTable other)
		: this()
	{
		conditionTiming_ = other.conditionTiming_;
		conditionType_ = other.conditionType_;
		conditionValue_ = other.conditionValue_;
		effectApplyType_ = other.effectApplyType_;
		effectApplyValue_ = other.effectApplyValue_.Clone();
		effectType_ = other.effectType_;
		effectValue_ = other.effectValue_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLBuffTable Clone()
	{
		return new RLBuffTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLBuffTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RLBuffTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ConditionTiming == other.ConditionTiming && ConditionType == other.ConditionType && ConditionValue == other.ConditionValue && EffectApplyType == other.EffectApplyType && effectApplyValue_.Equals(other.effectApplyValue_) && EffectType == other.EffectType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(EffectValue, other.EffectValue) && Id == other.Id)
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
		if (ConditionTiming != 0)
		{
			num ^= ConditionTiming.GetHashCode();
		}
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (ConditionValue != 0)
		{
			num ^= ConditionValue.GetHashCode();
		}
		if (EffectApplyType != 0)
		{
			num ^= EffectApplyType.GetHashCode();
		}
		num ^= effectApplyValue_.GetHashCode();
		if (EffectType != 0)
		{
			num ^= EffectType.GetHashCode();
		}
		if (EffectValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(EffectValue);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (ConditionTiming != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionTiming);
		}
		if (ConditionType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ConditionType);
		}
		if (ConditionValue != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ConditionValue);
		}
		if (EffectApplyType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EffectApplyType);
		}
		effectApplyValue_.WriteTo(ref output, _repeated_effectApplyValue_codec);
		if (EffectType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EffectType);
		}
		if (EffectValue != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(EffectValue);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
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
		if (ConditionTiming != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionTiming);
		}
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (ConditionValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionValue);
		}
		if (EffectApplyType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectApplyType);
		}
		num += effectApplyValue_.CalculateSize(_repeated_effectApplyValue_codec);
		if (EffectType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectType);
		}
		if (EffectValue != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(RLBuffTable other)
	{
		if (other != null)
		{
			if (other.ConditionTiming != 0)
			{
				ConditionTiming = other.ConditionTiming;
			}
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.ConditionValue != 0)
			{
				ConditionValue = other.ConditionValue;
			}
			if (other.EffectApplyType != 0)
			{
				EffectApplyType = other.EffectApplyType;
			}
			effectApplyValue_.Add(other.effectApplyValue_);
			if (other.EffectType != 0)
			{
				EffectType = other.EffectType;
			}
			if (other.EffectValue != 0.0)
			{
				EffectValue = other.EffectValue;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
				ConditionTiming = input.ReadInt32();
				break;
			case 16u:
				ConditionType = input.ReadInt32();
				break;
			case 24u:
				ConditionValue = input.ReadInt32();
				break;
			case 32u:
				EffectApplyType = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				effectApplyValue_.AddEntriesFrom(ref input, _repeated_effectApplyValue_codec);
				break;
			case 48u:
				EffectType = input.ReadInt32();
				break;
			case 57u:
				EffectValue = input.ReadDouble();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
