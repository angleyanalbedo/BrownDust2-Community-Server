using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EquipmentRankTable : IMessage<EquipmentRankTable>, IMessage, IEquatable<EquipmentRankTable>, IDeepCloneable<EquipmentRankTable>, IBufferMessage
{
	private static readonly MessageParser<EquipmentRankTable> _parser = new MessageParser<EquipmentRankTable>(() => new EquipmentRankTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int GrowthPointFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_growthPoint_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> growthPoint_ = new RepeatedField<int>();

	public const int IdFieldNumber = 3;

	private int id_;

	public const int RankRatioFieldNumber = 4;

	private static readonly FieldCodec<float> _repeated_rankRatio_codec = FieldCodec.ForFloat(34u);

	private readonly RepeatedField<float> rankRatio_ = new RepeatedField<float>();

	public const int RankValueFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_rankValue_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> rankValue_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipmentRankTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipmentRankTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> GrowthPoint => growthPoint_;

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
	public RepeatedField<float> RankRatio => rankRatio_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RankValue => rankValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentRankTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipmentRankTable(EquipmentRankTable other)
		: this()
	{
		groupId_ = other.groupId_;
		growthPoint_ = other.growthPoint_.Clone();
		id_ = other.id_;
		rankRatio_ = other.rankRatio_.Clone();
		rankValue_ = other.rankValue_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentRankTable Clone()
	{
		return new EquipmentRankTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentRankTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipmentRankTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && growthPoint_.Equals(other.growthPoint_) && Id == other.Id && rankRatio_.Equals(other.rankRatio_) && rankValue_.Equals(other.rankValue_))
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= growthPoint_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= rankRatio_.GetHashCode();
		num ^= rankValue_.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		growthPoint_.WriteTo(ref output, _repeated_growthPoint_codec);
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		rankRatio_.WriteTo(ref output, _repeated_rankRatio_codec);
		rankValue_.WriteTo(ref output, _repeated_rankValue_codec);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		num += growthPoint_.CalculateSize(_repeated_growthPoint_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += rankRatio_.CalculateSize(_repeated_rankRatio_codec);
		num += rankValue_.CalculateSize(_repeated_rankValue_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipmentRankTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			growthPoint_.Add(other.growthPoint_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			rankRatio_.Add(other.rankRatio_);
			rankValue_.Add(other.rankValue_);
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
				GroupId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				growthPoint_.AddEntriesFrom(ref input, _repeated_growthPoint_codec);
				break;
			case 34u:
			case 37u:
				rankRatio_.AddEntriesFrom(ref input, _repeated_rankRatio_codec);
				break;
			case 40u:
			case 42u:
				rankValue_.AddEntriesFrom(ref input, _repeated_rankValue_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
