using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLRelicChoiceTable : IMessage<RLRelicChoiceTable>, IMessage, IEquatable<RLRelicChoiceTable>, IDeepCloneable<RLRelicChoiceTable>, IBufferMessage
{
	private static readonly MessageParser<RLRelicChoiceTable> _parser = new MessageParser<RLRelicChoiceTable>(() => new RLRelicChoiceTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int RateGradeFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_rateGrade_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> rateGrade_ = new RepeatedField<int>();

	public const int RelicTypeFieldNumber = 3;

	private int relicType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RLRelicChoiceTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => RLRelicChoiceTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<int> RateGrade => rateGrade_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RelicType
	{
		get
		{
			return relicType_;
		}
		set
		{
			relicType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLRelicChoiceTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLRelicChoiceTable(RLRelicChoiceTable other)
		: this()
	{
		id_ = other.id_;
		rateGrade_ = other.rateGrade_.Clone();
		relicType_ = other.relicType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLRelicChoiceTable Clone()
	{
		return new RLRelicChoiceTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as RLRelicChoiceTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RLRelicChoiceTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && rateGrade_.Equals(other.rateGrade_) && RelicType == other.RelicType)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= rateGrade_.GetHashCode();
		if (RelicType != 0)
		{
			num ^= RelicType.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		rateGrade_.WriteTo(ref output, _repeated_rateGrade_codec);
		if (RelicType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RelicType);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += rateGrade_.CalculateSize(_repeated_rateGrade_codec);
		if (RelicType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RelicType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(RLRelicChoiceTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			rateGrade_.Add(other.rateGrade_);
			if (other.RelicType != 0)
			{
				RelicType = other.RelicType;
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
				Id = input.ReadInt32();
				break;
			case 24u:
				RelicType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				rateGrade_.AddEntriesFrom(ref input, _repeated_rateGrade_codec);
				break;
			}
		}
	}
}
