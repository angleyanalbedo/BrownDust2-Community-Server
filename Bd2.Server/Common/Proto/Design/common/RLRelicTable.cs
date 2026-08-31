using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLRelicTable : IMessage<RLRelicTable>, IMessage, IEquatable<RLRelicTable>, IDeepCloneable<RLRelicTable>, IBufferMessage
{
	private static readonly MessageParser<RLRelicTable> _parser = new MessageParser<RLRelicTable>(() => new RLRelicTable());

	private UnknownFieldSet _unknownFields;

	public const int GradeFieldNumber = 1;

	private int grade_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int RelicBuffFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_relicBuff_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> relicBuff_ = new RepeatedField<int>();

	public const int RelicDescTextIdFieldNumber = 4;

	private int relicDescTextId_;

	public const int RelicIconFieldNumber = 5;

	private string relicIcon_ = "";

	public const int RelicIconTypeFieldNumber = 6;

	private int relicIconType_;

	public const int RelicNameTextIdFieldNumber = 7;

	private int relicNameTextId_;

	public const int RelicPriceFieldNumber = 8;

	private int relicPrice_;

	public const int RelicTypeFieldNumber = 9;

	private int relicType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RLRelicTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => RLRelicTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Grade
	{
		get
		{
			return grade_;
		}
		set
		{
			grade_ = value;
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
	public RepeatedField<int> RelicBuff => relicBuff_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RelicDescTextId
	{
		get
		{
			return relicDescTextId_;
		}
		set
		{
			relicDescTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string RelicIcon
	{
		get
		{
			return relicIcon_;
		}
		set
		{
			relicIcon_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RelicIconType
	{
		get
		{
			return relicIconType_;
		}
		set
		{
			relicIconType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RelicNameTextId
	{
		get
		{
			return relicNameTextId_;
		}
		set
		{
			relicNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RelicPrice
	{
		get
		{
			return relicPrice_;
		}
		set
		{
			relicPrice_ = value;
		}
	}

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
	public RLRelicTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLRelicTable(RLRelicTable other)
		: this()
	{
		grade_ = other.grade_;
		id_ = other.id_;
		relicBuff_ = other.relicBuff_.Clone();
		relicDescTextId_ = other.relicDescTextId_;
		relicIcon_ = other.relicIcon_;
		relicIconType_ = other.relicIconType_;
		relicNameTextId_ = other.relicNameTextId_;
		relicPrice_ = other.relicPrice_;
		relicType_ = other.relicType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLRelicTable Clone()
	{
		return new RLRelicTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as RLRelicTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RLRelicTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Grade == other.Grade && Id == other.Id && relicBuff_.Equals(other.relicBuff_) && RelicDescTextId == other.RelicDescTextId && !(RelicIcon != other.RelicIcon) && RelicIconType == other.RelicIconType && RelicNameTextId == other.RelicNameTextId && RelicPrice == other.RelicPrice && RelicType == other.RelicType)
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
		if (Grade != 0)
		{
			num ^= Grade.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= relicBuff_.GetHashCode();
		if (RelicDescTextId != 0)
		{
			num ^= RelicDescTextId.GetHashCode();
		}
		if (RelicIcon.Length != 0)
		{
			num ^= RelicIcon.GetHashCode();
		}
		if (RelicIconType != 0)
		{
			num ^= RelicIconType.GetHashCode();
		}
		if (RelicNameTextId != 0)
		{
			num ^= RelicNameTextId.GetHashCode();
		}
		if (RelicPrice != 0)
		{
			num ^= RelicPrice.GetHashCode();
		}
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
		if (Grade != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Grade);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		relicBuff_.WriteTo(ref output, _repeated_relicBuff_codec);
		if (RelicDescTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RelicDescTextId);
		}
		if (RelicIcon.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(RelicIcon);
		}
		if (RelicIconType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RelicIconType);
		}
		if (RelicNameTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(RelicNameTextId);
		}
		if (RelicPrice != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(RelicPrice);
		}
		if (RelicType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(RelicType);
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
		if (Grade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Grade);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += relicBuff_.CalculateSize(_repeated_relicBuff_codec);
		if (RelicDescTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RelicDescTextId);
		}
		if (RelicIcon.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RelicIcon);
		}
		if (RelicIconType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RelicIconType);
		}
		if (RelicNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RelicNameTextId);
		}
		if (RelicPrice != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RelicPrice);
		}
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RLRelicTable other)
	{
		if (other != null)
		{
			if (other.Grade != 0)
			{
				Grade = other.Grade;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			relicBuff_.Add(other.relicBuff_);
			if (other.RelicDescTextId != 0)
			{
				RelicDescTextId = other.RelicDescTextId;
			}
			if (other.RelicIcon.Length != 0)
			{
				RelicIcon = other.RelicIcon;
			}
			if (other.RelicIconType != 0)
			{
				RelicIconType = other.RelicIconType;
			}
			if (other.RelicNameTextId != 0)
			{
				RelicNameTextId = other.RelicNameTextId;
			}
			if (other.RelicPrice != 0)
			{
				RelicPrice = other.RelicPrice;
			}
			if (other.RelicType != 0)
			{
				RelicType = other.RelicType;
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
				Grade = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				relicBuff_.AddEntriesFrom(ref input, _repeated_relicBuff_codec);
				break;
			case 32u:
				RelicDescTextId = input.ReadInt32();
				break;
			case 42u:
				RelicIcon = input.ReadString();
				break;
			case 48u:
				RelicIconType = input.ReadInt32();
				break;
			case 56u:
				RelicNameTextId = input.ReadInt32();
				break;
			case 64u:
				RelicPrice = input.ReadInt32();
				break;
			case 72u:
				RelicType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
