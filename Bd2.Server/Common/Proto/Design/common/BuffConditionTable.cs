using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class BuffConditionTable : IMessage<BuffConditionTable>, IMessage, IEquatable<BuffConditionTable>, IDeepCloneable<BuffConditionTable>, IBufferMessage
{
	private static readonly MessageParser<BuffConditionTable> _parser = new MessageParser<BuffConditionTable>(() => new BuffConditionTable());

	private UnknownFieldSet _unknownFields;

	public const int AttackTypeFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_attackType_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> attackType_ = new RepeatedField<int>();

	public const int BuffGroupFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_buffGroup_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> buffGroup_ = new RepeatedField<int>();

	public const int ChainLessFieldNumber = 3;

	private int chainLess_;

	public const int ChainMoreFieldNumber = 4;

	private int chainMore_;

	public const int ChainMultipleFieldNumber = 5;

	private int chainMultiple_;

	public const int ElementFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_element_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> element_ = new RepeatedField<int>();

	public const int IdFieldNumber = 7;

	private int id_;

	public const int LogicalTypeFieldNumber = 8;

	private int logicalType_;

	public const int MainTargetFieldNumber = 9;

	private int mainTarget_;

	public const int SubTargetFieldNumber = 10;

	private int subTarget_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BuffConditionTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuffConditionTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> AttackType => attackType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> BuffGroup => buffGroup_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ChainLess
	{
		get
		{
			return chainLess_;
		}
		set
		{
			chainLess_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChainMore
	{
		get
		{
			return chainMore_;
		}
		set
		{
			chainMore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChainMultiple
	{
		get
		{
			return chainMultiple_;
		}
		set
		{
			chainMultiple_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Element => element_;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LogicalType
	{
		get
		{
			return logicalType_;
		}
		set
		{
			logicalType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MainTarget
	{
		get
		{
			return mainTarget_;
		}
		set
		{
			mainTarget_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SubTarget
	{
		get
		{
			return subTarget_;
		}
		set
		{
			subTarget_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffConditionTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BuffConditionTable(BuffConditionTable other)
		: this()
	{
		attackType_ = other.attackType_.Clone();
		buffGroup_ = other.buffGroup_.Clone();
		chainLess_ = other.chainLess_;
		chainMore_ = other.chainMore_;
		chainMultiple_ = other.chainMultiple_;
		element_ = other.element_.Clone();
		id_ = other.id_;
		logicalType_ = other.logicalType_;
		mainTarget_ = other.mainTarget_;
		subTarget_ = other.subTarget_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BuffConditionTable Clone()
	{
		return new BuffConditionTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BuffConditionTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BuffConditionTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (attackType_.Equals(other.attackType_) && buffGroup_.Equals(other.buffGroup_) && ChainLess == other.ChainLess && ChainMore == other.ChainMore && ChainMultiple == other.ChainMultiple && element_.Equals(other.element_) && Id == other.Id && LogicalType == other.LogicalType && MainTarget == other.MainTarget && SubTarget == other.SubTarget)
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
		num ^= attackType_.GetHashCode();
		num ^= buffGroup_.GetHashCode();
		if (ChainLess != 0)
		{
			num ^= ChainLess.GetHashCode();
		}
		if (ChainMore != 0)
		{
			num ^= ChainMore.GetHashCode();
		}
		if (ChainMultiple != 0)
		{
			num ^= ChainMultiple.GetHashCode();
		}
		num ^= element_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LogicalType != 0)
		{
			num ^= LogicalType.GetHashCode();
		}
		if (MainTarget != 0)
		{
			num ^= MainTarget.GetHashCode();
		}
		if (SubTarget != 0)
		{
			num ^= SubTarget.GetHashCode();
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
		attackType_.WriteTo(ref output, _repeated_attackType_codec);
		buffGroup_.WriteTo(ref output, _repeated_buffGroup_codec);
		if (ChainLess != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ChainLess);
		}
		if (ChainMore != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ChainMore);
		}
		if (ChainMultiple != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ChainMultiple);
		}
		element_.WriteTo(ref output, _repeated_element_codec);
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		if (LogicalType != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LogicalType);
		}
		if (MainTarget != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MainTarget);
		}
		if (SubTarget != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(SubTarget);
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
		num += attackType_.CalculateSize(_repeated_attackType_codec);
		num += buffGroup_.CalculateSize(_repeated_buffGroup_codec);
		if (ChainLess != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChainLess);
		}
		if (ChainMore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChainMore);
		}
		if (ChainMultiple != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChainMultiple);
		}
		num += element_.CalculateSize(_repeated_element_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LogicalType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LogicalType);
		}
		if (MainTarget != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MainTarget);
		}
		if (SubTarget != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubTarget);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BuffConditionTable other)
	{
		if (other != null)
		{
			attackType_.Add(other.attackType_);
			buffGroup_.Add(other.buffGroup_);
			if (other.ChainLess != 0)
			{
				ChainLess = other.ChainLess;
			}
			if (other.ChainMore != 0)
			{
				ChainMore = other.ChainMore;
			}
			if (other.ChainMultiple != 0)
			{
				ChainMultiple = other.ChainMultiple;
			}
			element_.Add(other.element_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LogicalType != 0)
			{
				LogicalType = other.LogicalType;
			}
			if (other.MainTarget != 0)
			{
				MainTarget = other.MainTarget;
			}
			if (other.SubTarget != 0)
			{
				SubTarget = other.SubTarget;
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
			case 10u:
				attackType_.AddEntriesFrom(ref input, _repeated_attackType_codec);
				break;
			case 24u:
				ChainLess = input.ReadInt32();
				break;
			case 32u:
				ChainMore = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				buffGroup_.AddEntriesFrom(ref input, _repeated_buffGroup_codec);
				break;
			case 40u:
				ChainMultiple = input.ReadInt32();
				break;
			case 48u:
			case 50u:
				element_.AddEntriesFrom(ref input, _repeated_element_codec);
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 64u:
				LogicalType = input.ReadInt32();
				break;
			case 72u:
				MainTarget = input.ReadInt32();
				break;
			case 80u:
				SubTarget = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
