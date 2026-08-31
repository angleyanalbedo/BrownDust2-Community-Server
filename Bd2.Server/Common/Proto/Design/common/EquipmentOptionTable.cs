using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EquipmentOptionTable : IMessage<EquipmentOptionTable>, IMessage, IEquatable<EquipmentOptionTable>, IDeepCloneable<EquipmentOptionTable>, IBufferMessage
{
	private static readonly MessageParser<EquipmentOptionTable> _parser = new MessageParser<EquipmentOptionTable>(() => new EquipmentOptionTable());

	private UnknownFieldSet _unknownFields;

	public const int DefaultValueFieldNumber = 1;

	private double defaultValue_;

	public const int GetRatioFieldNumber = 2;

	private int getRatio_;

	public const int GroupIdFieldNumber = 3;

	private int groupId_;

	public const int GrowthValueFieldNumber = 4;

	private double growthValue_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int LevelValueFieldNumber = 6;

	private static readonly FieldCodec<float> _repeated_levelValue_codec = FieldCodec.ForFloat(50u);

	private readonly RepeatedField<float> levelValue_ = new RepeatedField<float>();

	public const int RankValue1FieldNumber = 7;

	private static readonly FieldCodec<float> _repeated_rankValue1_codec = FieldCodec.ForFloat(58u);

	private readonly RepeatedField<float> rankValue1_ = new RepeatedField<float>();

	public const int RankValue2FieldNumber = 8;

	private static readonly FieldCodec<float> _repeated_rankValue2_codec = FieldCodec.ForFloat(66u);

	private readonly RepeatedField<float> rankValue2_ = new RepeatedField<float>();

	public const int RankValue3FieldNumber = 9;

	private static readonly FieldCodec<float> _repeated_rankValue3_codec = FieldCodec.ForFloat(74u);

	private readonly RepeatedField<float> rankValue3_ = new RepeatedField<float>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipmentOptionTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipmentOptionTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DefaultValue
	{
		get
		{
			return defaultValue_;
		}
		set
		{
			defaultValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GetRatio
	{
		get
		{
			return getRatio_;
		}
		set
		{
			getRatio_ = value;
		}
	}

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
	public double GrowthValue
	{
		get
		{
			return growthValue_;
		}
		set
		{
			growthValue_ = value;
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
	public RepeatedField<float> LevelValue => levelValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<float> RankValue1 => rankValue1_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<float> RankValue2 => rankValue2_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<float> RankValue3 => rankValue3_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentOptionTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentOptionTable(EquipmentOptionTable other)
		: this()
	{
		defaultValue_ = other.defaultValue_;
		getRatio_ = other.getRatio_;
		groupId_ = other.groupId_;
		growthValue_ = other.growthValue_;
		id_ = other.id_;
		levelValue_ = other.levelValue_.Clone();
		rankValue1_ = other.rankValue1_.Clone();
		rankValue2_ = other.rankValue2_.Clone();
		rankValue3_ = other.rankValue3_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipmentOptionTable Clone()
	{
		return new EquipmentOptionTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentOptionTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipmentOptionTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DefaultValue, other.DefaultValue) && GetRatio == other.GetRatio && GroupId == other.GroupId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GrowthValue, other.GrowthValue) && Id == other.Id && levelValue_.Equals(other.levelValue_) && rankValue1_.Equals(other.rankValue1_) && rankValue2_.Equals(other.rankValue2_) && rankValue3_.Equals(other.rankValue3_))
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
		if (DefaultValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DefaultValue);
		}
		if (GetRatio != 0)
		{
			num ^= GetRatio.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (GrowthValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GrowthValue);
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= levelValue_.GetHashCode();
		num ^= rankValue1_.GetHashCode();
		num ^= rankValue2_.GetHashCode();
		num ^= rankValue3_.GetHashCode();
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
		if (DefaultValue != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(DefaultValue);
		}
		if (GetRatio != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GetRatio);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupId);
		}
		if (GrowthValue != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(GrowthValue);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		levelValue_.WriteTo(ref output, _repeated_levelValue_codec);
		rankValue1_.WriteTo(ref output, _repeated_rankValue1_codec);
		rankValue2_.WriteTo(ref output, _repeated_rankValue2_codec);
		rankValue3_.WriteTo(ref output, _repeated_rankValue3_codec);
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
		if (DefaultValue != 0.0)
		{
			num += 9;
		}
		if (GetRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GetRatio);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (GrowthValue != 0.0)
		{
			num += 9;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += levelValue_.CalculateSize(_repeated_levelValue_codec);
		num += rankValue1_.CalculateSize(_repeated_rankValue1_codec);
		num += rankValue2_.CalculateSize(_repeated_rankValue2_codec);
		num += rankValue3_.CalculateSize(_repeated_rankValue3_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipmentOptionTable other)
	{
		if (other != null)
		{
			if (other.DefaultValue != 0.0)
			{
				DefaultValue = other.DefaultValue;
			}
			if (other.GetRatio != 0)
			{
				GetRatio = other.GetRatio;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.GrowthValue != 0.0)
			{
				GrowthValue = other.GrowthValue;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			levelValue_.Add(other.levelValue_);
			rankValue1_.Add(other.rankValue1_);
			rankValue2_.Add(other.rankValue2_);
			rankValue3_.Add(other.rankValue3_);
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
			case 9u:
				DefaultValue = input.ReadDouble();
				break;
			case 16u:
				GetRatio = input.ReadInt32();
				break;
			case 24u:
				GroupId = input.ReadInt32();
				break;
			case 33u:
				GrowthValue = input.ReadDouble();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 58u:
			case 61u:
				rankValue1_.AddEntriesFrom(ref input, _repeated_rankValue1_codec);
				break;
			case 66u:
			case 69u:
				rankValue2_.AddEntriesFrom(ref input, _repeated_rankValue2_codec);
				break;
			case 74u:
			case 77u:
				rankValue3_.AddEntriesFrom(ref input, _repeated_rankValue3_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 50u:
			case 53u:
				levelValue_.AddEntriesFrom(ref input, _repeated_levelValue_codec);
				break;
			}
		}
	}
}
