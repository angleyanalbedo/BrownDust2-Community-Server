using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TalentSkillTable : IMessage<TalentSkillTable>, IMessage, IEquatable<TalentSkillTable>, IDeepCloneable<TalentSkillTable>, IBufferMessage
{
	private static readonly MessageParser<TalentSkillTable> _parser = new MessageParser<TalentSkillTable>(() => new TalentSkillTable());

	private UnknownFieldSet _unknownFields;

	public const int CatalystValueFieldNumber = 1;

	private int catalystValue_;

	public const int ClassTypeFieldNumber = 2;

	private int classType_;

	public const int CostumeIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_costumeId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> costumeId_ = new RepeatedField<int>();

	public const int GetExpFieldNumber = 4;

	private int getExp_;

	public const int GroupIdFieldNumber = 5;

	private int groupId_;

	public const int IdFieldNumber = 6;

	private int id_;

	public const int ResetTypeFieldNumber = 7;

	private int resetType_;

	public const int TalentSkillDescLocalTextIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_talentSkillDescLocalTextId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> talentSkillDescLocalTextId_ = new RepeatedField<int>();

	public const int TalentSkillIconSpriteNameFieldNumber = 9;

	private string talentSkillIconSpriteName_ = "";

	public const int TalentSkillNameLocalTextIdFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_talentSkillNameLocalTextId_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> talentSkillNameLocalTextId_ = new RepeatedField<int>();

	public const int TalentSkillReputationFieldNumber = 11;

	private int talentSkillReputation_;

	public const int TargetTypeFieldNumber = 12;

	private int targetType_;

	public const int ValueListFieldNumber = 13;

	private static readonly FieldCodec<float> _repeated_valueList_codec = FieldCodec.ForFloat(106u);

	private readonly RepeatedField<float> valueList_ = new RepeatedField<float>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TalentSkillTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TalentSkillTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CatalystValue
	{
		get
		{
			return catalystValue_;
		}
		set
		{
			catalystValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClassType
	{
		get
		{
			return classType_;
		}
		set
		{
			classType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> CostumeId => costumeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GetExp
	{
		get
		{
			return getExp_;
		}
		set
		{
			getExp_ = value;
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
	public int ResetType
	{
		get
		{
			return resetType_;
		}
		set
		{
			resetType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> TalentSkillDescLocalTextId => talentSkillDescLocalTextId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TalentSkillIconSpriteName
	{
		get
		{
			return talentSkillIconSpriteName_;
		}
		set
		{
			talentSkillIconSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> TalentSkillNameLocalTextId => talentSkillNameLocalTextId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TalentSkillReputation
	{
		get
		{
			return talentSkillReputation_;
		}
		set
		{
			talentSkillReputation_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TargetType
	{
		get
		{
			return targetType_;
		}
		set
		{
			targetType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<float> ValueList => valueList_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentSkillTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentSkillTable(TalentSkillTable other)
		: this()
	{
		catalystValue_ = other.catalystValue_;
		classType_ = other.classType_;
		costumeId_ = other.costumeId_.Clone();
		getExp_ = other.getExp_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		resetType_ = other.resetType_;
		talentSkillDescLocalTextId_ = other.talentSkillDescLocalTextId_.Clone();
		talentSkillIconSpriteName_ = other.talentSkillIconSpriteName_;
		talentSkillNameLocalTextId_ = other.talentSkillNameLocalTextId_.Clone();
		talentSkillReputation_ = other.talentSkillReputation_;
		targetType_ = other.targetType_;
		valueList_ = other.valueList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TalentSkillTable Clone()
	{
		return new TalentSkillTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TalentSkillTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TalentSkillTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CatalystValue == other.CatalystValue && ClassType == other.ClassType && costumeId_.Equals(other.costumeId_) && GetExp == other.GetExp && GroupId == other.GroupId && Id == other.Id && ResetType == other.ResetType && talentSkillDescLocalTextId_.Equals(other.talentSkillDescLocalTextId_) && !(TalentSkillIconSpriteName != other.TalentSkillIconSpriteName) && talentSkillNameLocalTextId_.Equals(other.talentSkillNameLocalTextId_) && TalentSkillReputation == other.TalentSkillReputation && TargetType == other.TargetType && valueList_.Equals(other.valueList_))
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
		if (CatalystValue != 0)
		{
			num ^= CatalystValue.GetHashCode();
		}
		if (ClassType != 0)
		{
			num ^= ClassType.GetHashCode();
		}
		num ^= costumeId_.GetHashCode();
		if (GetExp != 0)
		{
			num ^= GetExp.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ResetType != 0)
		{
			num ^= ResetType.GetHashCode();
		}
		num ^= talentSkillDescLocalTextId_.GetHashCode();
		if (TalentSkillIconSpriteName.Length != 0)
		{
			num ^= TalentSkillIconSpriteName.GetHashCode();
		}
		num ^= talentSkillNameLocalTextId_.GetHashCode();
		if (TalentSkillReputation != 0)
		{
			num ^= TalentSkillReputation.GetHashCode();
		}
		if (TargetType != 0)
		{
			num ^= TargetType.GetHashCode();
		}
		num ^= valueList_.GetHashCode();
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
		if (CatalystValue != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CatalystValue);
		}
		if (ClassType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ClassType);
		}
		costumeId_.WriteTo(ref output, _repeated_costumeId_codec);
		if (GetExp != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GetExp);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (ResetType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ResetType);
		}
		talentSkillDescLocalTextId_.WriteTo(ref output, _repeated_talentSkillDescLocalTextId_codec);
		if (TalentSkillIconSpriteName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(TalentSkillIconSpriteName);
		}
		talentSkillNameLocalTextId_.WriteTo(ref output, _repeated_talentSkillNameLocalTextId_codec);
		if (TalentSkillReputation != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(TalentSkillReputation);
		}
		if (TargetType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(TargetType);
		}
		valueList_.WriteTo(ref output, _repeated_valueList_codec);
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
		if (CatalystValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CatalystValue);
		}
		if (ClassType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClassType);
		}
		num += costumeId_.CalculateSize(_repeated_costumeId_codec);
		if (GetExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GetExp);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ResetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResetType);
		}
		num += talentSkillDescLocalTextId_.CalculateSize(_repeated_talentSkillDescLocalTextId_codec);
		if (TalentSkillIconSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TalentSkillIconSpriteName);
		}
		num += talentSkillNameLocalTextId_.CalculateSize(_repeated_talentSkillNameLocalTextId_codec);
		if (TalentSkillReputation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentSkillReputation);
		}
		if (TargetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetType);
		}
		num += valueList_.CalculateSize(_repeated_valueList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TalentSkillTable other)
	{
		if (other != null)
		{
			if (other.CatalystValue != 0)
			{
				CatalystValue = other.CatalystValue;
			}
			if (other.ClassType != 0)
			{
				ClassType = other.ClassType;
			}
			costumeId_.Add(other.costumeId_);
			if (other.GetExp != 0)
			{
				GetExp = other.GetExp;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ResetType != 0)
			{
				ResetType = other.ResetType;
			}
			talentSkillDescLocalTextId_.Add(other.talentSkillDescLocalTextId_);
			if (other.TalentSkillIconSpriteName.Length != 0)
			{
				TalentSkillIconSpriteName = other.TalentSkillIconSpriteName;
			}
			talentSkillNameLocalTextId_.Add(other.talentSkillNameLocalTextId_);
			if (other.TalentSkillReputation != 0)
			{
				TalentSkillReputation = other.TalentSkillReputation;
			}
			if (other.TargetType != 0)
			{
				TargetType = other.TargetType;
			}
			valueList_.Add(other.valueList_);
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
			case 64u:
			case 66u:
				talentSkillDescLocalTextId_.AddEntriesFrom(ref input, _repeated_talentSkillDescLocalTextId_codec);
				break;
			case 74u:
				TalentSkillIconSpriteName = input.ReadString();
				break;
			case 88u:
				TalentSkillReputation = input.ReadInt32();
				break;
			case 96u:
				TargetType = input.ReadInt32();
				break;
			case 106u:
			case 109u:
				valueList_.AddEntriesFrom(ref input, _repeated_valueList_codec);
				break;
			case 80u:
			case 82u:
				talentSkillNameLocalTextId_.AddEntriesFrom(ref input, _repeated_talentSkillNameLocalTextId_codec);
				break;
			case 8u:
				CatalystValue = input.ReadInt32();
				break;
			case 16u:
				ClassType = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				costumeId_.AddEntriesFrom(ref input, _repeated_costumeId_codec);
				break;
			case 32u:
				GetExp = input.ReadInt32();
				break;
			case 40u:
				GroupId = input.ReadInt32();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 56u:
				ResetType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
