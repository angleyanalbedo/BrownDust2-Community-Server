using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CostumeNodeTable : IMessage<CostumeNodeTable>, IMessage, IEquatable<CostumeNodeTable>, IDeepCloneable<CostumeNodeTable>, IBufferMessage
{
	private static readonly MessageParser<CostumeNodeTable> _parser = new MessageParser<CostumeNodeTable>(() => new CostumeNodeTable());

	private UnknownFieldSet _unknownFields;

	public const int ActiveItemCountFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_activeItemCount_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> activeItemCount_ = new RepeatedField<int>();

	public const int ActiveItemIdFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_activeItemId_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> activeItemId_ = new RepeatedField<int>();

	public const int ActiveItemTypeFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_activeItemType_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> activeItemType_ = new RepeatedField<int>();

	public const int AddBuffIdFieldNumber = 4;

	private int addBuffId_;

	public const int AddBuffModifyBuffMagicValueFieldNumber = 5;

	private double addBuffModifyBuffMagicValue_;

	public const int AddBuffModifyBuffOrderFieldNumber = 6;

	private int addBuffModifyBuffOrder_;

	public const int AddBuffModifyBuffTurnFieldNumber = 7;

	private int addBuffModifyBuffTurn_;

	public const int AddBuffModifyBuffValueFieldNumber = 8;

	private double addBuffModifyBuffValue_;

	public const int AddBuffOrderFieldNumber = 9;

	private int addBuffOrder_;

	public const int AddBuffTextOrderFieldNumber = 10;

	private int addBuffTextOrder_;

	public const int AttackRangeFieldNumber = 11;

	private int attackRange_;

	public const int AttackRangeCountFieldNumber = 12;

	private int attackRangeCount_;

	public const int ConditionAddBuffModifyBuffMagicValueFieldNumber = 13;

	private double conditionAddBuffModifyBuffMagicValue_;

	public const int ConditionAddBuffModifyBuffOrderFieldNumber = 14;

	private int conditionAddBuffModifyBuffOrder_;

	public const int ConditionAddBuffModifyBuffTurnFieldNumber = 15;

	private int conditionAddBuffModifyBuffTurn_;

	public const int ConditionAddBuffModifyBuffValueFieldNumber = 16;

	private double conditionAddBuffModifyBuffValue_;

	public const int ConditionGradeFieldNumber = 17;

	private int conditionGrade_;

	public const int ConditionNodeIdFieldNumber = 18;

	private static readonly FieldCodec<int> _repeated_conditionNodeId_codec = FieldCodec.ForInt32(146u);

	private readonly RepeatedField<int> conditionNodeId_ = new RepeatedField<int>();

	public const int CooldownDecreaseValueFieldNumber = 19;

	private int cooldownDecreaseValue_;

	public const int GroupIdFieldNumber = 20;

	private int groupId_;

	public const int IdFieldNumber = 21;

	private int id_;

	public const int ModifyBuffMagicValueFieldNumber = 22;

	private double modifyBuffMagicValue_;

	public const int ModifyBuffOrderFieldNumber = 23;

	private int modifyBuffOrder_;

	public const int ModifyBuffTurnFieldNumber = 24;

	private int modifyBuffTurn_;

	public const int ModifyBuffValueFieldNumber = 25;

	private double modifyBuffValue_;

	public const int NodeGroupTypeFieldNumber = 26;

	private int nodeGroupType_;

	public const int NodeTypeFieldNumber = 27;

	private int nodeType_;

	public const int SpDecreaseValueFieldNumber = 28;

	private int spDecreaseValue_;

	public const int StatTypeFieldNumber = 29;

	private int statType_;

	public const int StatValueFieldNumber = 30;

	private double statValue_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CostumeNodeTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumeNodeTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ActiveItemCount => activeItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> ActiveItemId => activeItemId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ActiveItemType => activeItemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AddBuffId
	{
		get
		{
			return addBuffId_;
		}
		set
		{
			addBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double AddBuffModifyBuffMagicValue
	{
		get
		{
			return addBuffModifyBuffMagicValue_;
		}
		set
		{
			addBuffModifyBuffMagicValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AddBuffModifyBuffOrder
	{
		get
		{
			return addBuffModifyBuffOrder_;
		}
		set
		{
			addBuffModifyBuffOrder_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AddBuffModifyBuffTurn
	{
		get
		{
			return addBuffModifyBuffTurn_;
		}
		set
		{
			addBuffModifyBuffTurn_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double AddBuffModifyBuffValue
	{
		get
		{
			return addBuffModifyBuffValue_;
		}
		set
		{
			addBuffModifyBuffValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AddBuffOrder
	{
		get
		{
			return addBuffOrder_;
		}
		set
		{
			addBuffOrder_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AddBuffTextOrder
	{
		get
		{
			return addBuffTextOrder_;
		}
		set
		{
			addBuffTextOrder_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackRange
	{
		get
		{
			return attackRange_;
		}
		set
		{
			attackRange_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackRangeCount
	{
		get
		{
			return attackRangeCount_;
		}
		set
		{
			attackRangeCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ConditionAddBuffModifyBuffMagicValue
	{
		get
		{
			return conditionAddBuffModifyBuffMagicValue_;
		}
		set
		{
			conditionAddBuffModifyBuffMagicValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ConditionAddBuffModifyBuffOrder
	{
		get
		{
			return conditionAddBuffModifyBuffOrder_;
		}
		set
		{
			conditionAddBuffModifyBuffOrder_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionAddBuffModifyBuffTurn
	{
		get
		{
			return conditionAddBuffModifyBuffTurn_;
		}
		set
		{
			conditionAddBuffModifyBuffTurn_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ConditionAddBuffModifyBuffValue
	{
		get
		{
			return conditionAddBuffModifyBuffValue_;
		}
		set
		{
			conditionAddBuffModifyBuffValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ConditionGrade
	{
		get
		{
			return conditionGrade_;
		}
		set
		{
			conditionGrade_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ConditionNodeId => conditionNodeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CooldownDecreaseValue
	{
		get
		{
			return cooldownDecreaseValue_;
		}
		set
		{
			cooldownDecreaseValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public double ModifyBuffMagicValue
	{
		get
		{
			return modifyBuffMagicValue_;
		}
		set
		{
			modifyBuffMagicValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ModifyBuffOrder
	{
		get
		{
			return modifyBuffOrder_;
		}
		set
		{
			modifyBuffOrder_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ModifyBuffTurn
	{
		get
		{
			return modifyBuffTurn_;
		}
		set
		{
			modifyBuffTurn_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double ModifyBuffValue
	{
		get
		{
			return modifyBuffValue_;
		}
		set
		{
			modifyBuffValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NodeGroupType
	{
		get
		{
			return nodeGroupType_;
		}
		set
		{
			nodeGroupType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NodeType
	{
		get
		{
			return nodeType_;
		}
		set
		{
			nodeType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpDecreaseValue
	{
		get
		{
			return spDecreaseValue_;
		}
		set
		{
			spDecreaseValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StatType
	{
		get
		{
			return statType_;
		}
		set
		{
			statType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double StatValue
	{
		get
		{
			return statValue_;
		}
		set
		{
			statValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeNodeTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeNodeTable(CostumeNodeTable other)
		: this()
	{
		activeItemCount_ = other.activeItemCount_.Clone();
		activeItemId_ = other.activeItemId_.Clone();
		activeItemType_ = other.activeItemType_.Clone();
		addBuffId_ = other.addBuffId_;
		addBuffModifyBuffMagicValue_ = other.addBuffModifyBuffMagicValue_;
		addBuffModifyBuffOrder_ = other.addBuffModifyBuffOrder_;
		addBuffModifyBuffTurn_ = other.addBuffModifyBuffTurn_;
		addBuffModifyBuffValue_ = other.addBuffModifyBuffValue_;
		addBuffOrder_ = other.addBuffOrder_;
		addBuffTextOrder_ = other.addBuffTextOrder_;
		attackRange_ = other.attackRange_;
		attackRangeCount_ = other.attackRangeCount_;
		conditionAddBuffModifyBuffMagicValue_ = other.conditionAddBuffModifyBuffMagicValue_;
		conditionAddBuffModifyBuffOrder_ = other.conditionAddBuffModifyBuffOrder_;
		conditionAddBuffModifyBuffTurn_ = other.conditionAddBuffModifyBuffTurn_;
		conditionAddBuffModifyBuffValue_ = other.conditionAddBuffModifyBuffValue_;
		conditionGrade_ = other.conditionGrade_;
		conditionNodeId_ = other.conditionNodeId_.Clone();
		cooldownDecreaseValue_ = other.cooldownDecreaseValue_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		modifyBuffMagicValue_ = other.modifyBuffMagicValue_;
		modifyBuffOrder_ = other.modifyBuffOrder_;
		modifyBuffTurn_ = other.modifyBuffTurn_;
		modifyBuffValue_ = other.modifyBuffValue_;
		nodeGroupType_ = other.nodeGroupType_;
		nodeType_ = other.nodeType_;
		spDecreaseValue_ = other.spDecreaseValue_;
		statType_ = other.statType_;
		statValue_ = other.statValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CostumeNodeTable Clone()
	{
		return new CostumeNodeTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeNodeTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CostumeNodeTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (activeItemCount_.Equals(other.activeItemCount_) && activeItemId_.Equals(other.activeItemId_) && activeItemType_.Equals(other.activeItemType_) && AddBuffId == other.AddBuffId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AddBuffModifyBuffMagicValue, other.AddBuffModifyBuffMagicValue) && AddBuffModifyBuffOrder == other.AddBuffModifyBuffOrder && AddBuffModifyBuffTurn == other.AddBuffModifyBuffTurn && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AddBuffModifyBuffValue, other.AddBuffModifyBuffValue) && AddBuffOrder == other.AddBuffOrder && AddBuffTextOrder == other.AddBuffTextOrder && AttackRange == other.AttackRange && AttackRangeCount == other.AttackRangeCount && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ConditionAddBuffModifyBuffMagicValue, other.ConditionAddBuffModifyBuffMagicValue) && ConditionAddBuffModifyBuffOrder == other.ConditionAddBuffModifyBuffOrder && ConditionAddBuffModifyBuffTurn == other.ConditionAddBuffModifyBuffTurn && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ConditionAddBuffModifyBuffValue, other.ConditionAddBuffModifyBuffValue) && ConditionGrade == other.ConditionGrade && conditionNodeId_.Equals(other.conditionNodeId_) && CooldownDecreaseValue == other.CooldownDecreaseValue && GroupId == other.GroupId && Id == other.Id && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ModifyBuffMagicValue, other.ModifyBuffMagicValue) && ModifyBuffOrder == other.ModifyBuffOrder && ModifyBuffTurn == other.ModifyBuffTurn && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ModifyBuffValue, other.ModifyBuffValue) && NodeGroupType == other.NodeGroupType && NodeType == other.NodeType && SpDecreaseValue == other.SpDecreaseValue && StatType == other.StatType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(StatValue, other.StatValue))
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
		num ^= activeItemCount_.GetHashCode();
		num ^= activeItemId_.GetHashCode();
		num ^= activeItemType_.GetHashCode();
		if (AddBuffId != 0)
		{
			num ^= AddBuffId.GetHashCode();
		}
		if (AddBuffModifyBuffMagicValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AddBuffModifyBuffMagicValue);
		}
		if (AddBuffModifyBuffOrder != 0)
		{
			num ^= AddBuffModifyBuffOrder.GetHashCode();
		}
		if (AddBuffModifyBuffTurn != 0)
		{
			num ^= AddBuffModifyBuffTurn.GetHashCode();
		}
		if (AddBuffModifyBuffValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AddBuffModifyBuffValue);
		}
		if (AddBuffOrder != 0)
		{
			num ^= AddBuffOrder.GetHashCode();
		}
		if (AddBuffTextOrder != 0)
		{
			num ^= AddBuffTextOrder.GetHashCode();
		}
		if (AttackRange != 0)
		{
			num ^= AttackRange.GetHashCode();
		}
		if (AttackRangeCount != 0)
		{
			num ^= AttackRangeCount.GetHashCode();
		}
		if (ConditionAddBuffModifyBuffMagicValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ConditionAddBuffModifyBuffMagicValue);
		}
		if (ConditionAddBuffModifyBuffOrder != 0)
		{
			num ^= ConditionAddBuffModifyBuffOrder.GetHashCode();
		}
		if (ConditionAddBuffModifyBuffTurn != 0)
		{
			num ^= ConditionAddBuffModifyBuffTurn.GetHashCode();
		}
		if (ConditionAddBuffModifyBuffValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ConditionAddBuffModifyBuffValue);
		}
		if (ConditionGrade != 0)
		{
			num ^= ConditionGrade.GetHashCode();
		}
		num ^= conditionNodeId_.GetHashCode();
		if (CooldownDecreaseValue != 0)
		{
			num ^= CooldownDecreaseValue.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ModifyBuffMagicValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ModifyBuffMagicValue);
		}
		if (ModifyBuffOrder != 0)
		{
			num ^= ModifyBuffOrder.GetHashCode();
		}
		if (ModifyBuffTurn != 0)
		{
			num ^= ModifyBuffTurn.GetHashCode();
		}
		if (ModifyBuffValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ModifyBuffValue);
		}
		if (NodeGroupType != 0)
		{
			num ^= NodeGroupType.GetHashCode();
		}
		if (NodeType != 0)
		{
			num ^= NodeType.GetHashCode();
		}
		if (SpDecreaseValue != 0)
		{
			num ^= SpDecreaseValue.GetHashCode();
		}
		if (StatType != 0)
		{
			num ^= StatType.GetHashCode();
		}
		if (StatValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(StatValue);
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
		activeItemCount_.WriteTo(ref output, _repeated_activeItemCount_codec);
		activeItemId_.WriteTo(ref output, _repeated_activeItemId_codec);
		activeItemType_.WriteTo(ref output, _repeated_activeItemType_codec);
		if (AddBuffId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AddBuffId);
		}
		if (AddBuffModifyBuffMagicValue != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(AddBuffModifyBuffMagicValue);
		}
		if (AddBuffModifyBuffOrder != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(AddBuffModifyBuffOrder);
		}
		if (AddBuffModifyBuffTurn != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(AddBuffModifyBuffTurn);
		}
		if (AddBuffModifyBuffValue != 0.0)
		{
			output.WriteRawTag(65);
			output.WriteDouble(AddBuffModifyBuffValue);
		}
		if (AddBuffOrder != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(AddBuffOrder);
		}
		if (AddBuffTextOrder != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(AddBuffTextOrder);
		}
		if (AttackRange != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(AttackRange);
		}
		if (AttackRangeCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(AttackRangeCount);
		}
		if (ConditionAddBuffModifyBuffMagicValue != 0.0)
		{
			output.WriteRawTag(105);
			output.WriteDouble(ConditionAddBuffModifyBuffMagicValue);
		}
		if (ConditionAddBuffModifyBuffOrder != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(ConditionAddBuffModifyBuffOrder);
		}
		if (ConditionAddBuffModifyBuffTurn != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ConditionAddBuffModifyBuffTurn);
		}
		if (ConditionAddBuffModifyBuffValue != 0.0)
		{
			output.WriteRawTag(129, 1);
			output.WriteDouble(ConditionAddBuffModifyBuffValue);
		}
		if (ConditionGrade != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(ConditionGrade);
		}
		conditionNodeId_.WriteTo(ref output, _repeated_conditionNodeId_codec);
		if (CooldownDecreaseValue != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(CooldownDecreaseValue);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(Id);
		}
		if (ModifyBuffMagicValue != 0.0)
		{
			output.WriteRawTag(177, 1);
			output.WriteDouble(ModifyBuffMagicValue);
		}
		if (ModifyBuffOrder != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(ModifyBuffOrder);
		}
		if (ModifyBuffTurn != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(ModifyBuffTurn);
		}
		if (ModifyBuffValue != 0.0)
		{
			output.WriteRawTag(201, 1);
			output.WriteDouble(ModifyBuffValue);
		}
		if (NodeGroupType != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(NodeGroupType);
		}
		if (NodeType != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(NodeType);
		}
		if (SpDecreaseValue != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(SpDecreaseValue);
		}
		if (StatType != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(StatType);
		}
		if (StatValue != 0.0)
		{
			output.WriteRawTag(241, 1);
			output.WriteDouble(StatValue);
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
		num += activeItemCount_.CalculateSize(_repeated_activeItemCount_codec);
		num += activeItemId_.CalculateSize(_repeated_activeItemId_codec);
		num += activeItemType_.CalculateSize(_repeated_activeItemType_codec);
		if (AddBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddBuffId);
		}
		if (AddBuffModifyBuffMagicValue != 0.0)
		{
			num += 9;
		}
		if (AddBuffModifyBuffOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddBuffModifyBuffOrder);
		}
		if (AddBuffModifyBuffTurn != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddBuffModifyBuffTurn);
		}
		if (AddBuffModifyBuffValue != 0.0)
		{
			num += 9;
		}
		if (AddBuffOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddBuffOrder);
		}
		if (AddBuffTextOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddBuffTextOrder);
		}
		if (AttackRange != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackRange);
		}
		if (AttackRangeCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackRangeCount);
		}
		if (ConditionAddBuffModifyBuffMagicValue != 0.0)
		{
			num += 9;
		}
		if (ConditionAddBuffModifyBuffOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionAddBuffModifyBuffOrder);
		}
		if (ConditionAddBuffModifyBuffTurn != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionAddBuffModifyBuffTurn);
		}
		if (ConditionAddBuffModifyBuffValue != 0.0)
		{
			num += 10;
		}
		if (ConditionGrade != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ConditionGrade);
		}
		num += conditionNodeId_.CalculateSize(_repeated_conditionNodeId_codec);
		if (CooldownDecreaseValue != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CooldownDecreaseValue);
		}
		if (GroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ModifyBuffMagicValue != 0.0)
		{
			num += 10;
		}
		if (ModifyBuffOrder != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ModifyBuffOrder);
		}
		if (ModifyBuffTurn != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ModifyBuffTurn);
		}
		if (ModifyBuffValue != 0.0)
		{
			num += 10;
		}
		if (NodeGroupType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NodeGroupType);
		}
		if (NodeType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NodeType);
		}
		if (SpDecreaseValue != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpDecreaseValue);
		}
		if (StatType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StatType);
		}
		if (StatValue != 0.0)
		{
			num += 10;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CostumeNodeTable other)
	{
		if (other != null)
		{
			activeItemCount_.Add(other.activeItemCount_);
			activeItemId_.Add(other.activeItemId_);
			activeItemType_.Add(other.activeItemType_);
			if (other.AddBuffId != 0)
			{
				AddBuffId = other.AddBuffId;
			}
			if (other.AddBuffModifyBuffMagicValue != 0.0)
			{
				AddBuffModifyBuffMagicValue = other.AddBuffModifyBuffMagicValue;
			}
			if (other.AddBuffModifyBuffOrder != 0)
			{
				AddBuffModifyBuffOrder = other.AddBuffModifyBuffOrder;
			}
			if (other.AddBuffModifyBuffTurn != 0)
			{
				AddBuffModifyBuffTurn = other.AddBuffModifyBuffTurn;
			}
			if (other.AddBuffModifyBuffValue != 0.0)
			{
				AddBuffModifyBuffValue = other.AddBuffModifyBuffValue;
			}
			if (other.AddBuffOrder != 0)
			{
				AddBuffOrder = other.AddBuffOrder;
			}
			if (other.AddBuffTextOrder != 0)
			{
				AddBuffTextOrder = other.AddBuffTextOrder;
			}
			if (other.AttackRange != 0)
			{
				AttackRange = other.AttackRange;
			}
			if (other.AttackRangeCount != 0)
			{
				AttackRangeCount = other.AttackRangeCount;
			}
			if (other.ConditionAddBuffModifyBuffMagicValue != 0.0)
			{
				ConditionAddBuffModifyBuffMagicValue = other.ConditionAddBuffModifyBuffMagicValue;
			}
			if (other.ConditionAddBuffModifyBuffOrder != 0)
			{
				ConditionAddBuffModifyBuffOrder = other.ConditionAddBuffModifyBuffOrder;
			}
			if (other.ConditionAddBuffModifyBuffTurn != 0)
			{
				ConditionAddBuffModifyBuffTurn = other.ConditionAddBuffModifyBuffTurn;
			}
			if (other.ConditionAddBuffModifyBuffValue != 0.0)
			{
				ConditionAddBuffModifyBuffValue = other.ConditionAddBuffModifyBuffValue;
			}
			if (other.ConditionGrade != 0)
			{
				ConditionGrade = other.ConditionGrade;
			}
			conditionNodeId_.Add(other.conditionNodeId_);
			if (other.CooldownDecreaseValue != 0)
			{
				CooldownDecreaseValue = other.CooldownDecreaseValue;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ModifyBuffMagicValue != 0.0)
			{
				ModifyBuffMagicValue = other.ModifyBuffMagicValue;
			}
			if (other.ModifyBuffOrder != 0)
			{
				ModifyBuffOrder = other.ModifyBuffOrder;
			}
			if (other.ModifyBuffTurn != 0)
			{
				ModifyBuffTurn = other.ModifyBuffTurn;
			}
			if (other.ModifyBuffValue != 0.0)
			{
				ModifyBuffValue = other.ModifyBuffValue;
			}
			if (other.NodeGroupType != 0)
			{
				NodeGroupType = other.NodeGroupType;
			}
			if (other.NodeType != 0)
			{
				NodeType = other.NodeType;
			}
			if (other.SpDecreaseValue != 0)
			{
				SpDecreaseValue = other.SpDecreaseValue;
			}
			if (other.StatType != 0)
			{
				StatType = other.StatType;
			}
			if (other.StatValue != 0.0)
			{
				StatValue = other.StatValue;
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
				activeItemCount_.AddEntriesFrom(ref input, _repeated_activeItemCount_codec);
				break;
			case 16u:
			case 18u:
				activeItemId_.AddEntriesFrom(ref input, _repeated_activeItemId_codec);
				break;
			case 24u:
			case 26u:
				activeItemType_.AddEntriesFrom(ref input, _repeated_activeItemType_codec);
				break;
			case 32u:
				AddBuffId = input.ReadInt32();
				break;
			case 41u:
				AddBuffModifyBuffMagicValue = input.ReadDouble();
				break;
			case 48u:
				AddBuffModifyBuffOrder = input.ReadInt32();
				break;
			case 56u:
				AddBuffModifyBuffTurn = input.ReadInt32();
				break;
			case 65u:
				AddBuffModifyBuffValue = input.ReadDouble();
				break;
			case 72u:
				AddBuffOrder = input.ReadInt32();
				break;
			case 80u:
				AddBuffTextOrder = input.ReadInt32();
				break;
			case 88u:
				AttackRange = input.ReadInt32();
				break;
			case 96u:
				AttackRangeCount = input.ReadInt32();
				break;
			case 105u:
				ConditionAddBuffModifyBuffMagicValue = input.ReadDouble();
				break;
			case 112u:
				ConditionAddBuffModifyBuffOrder = input.ReadInt32();
				break;
			case 120u:
				ConditionAddBuffModifyBuffTurn = input.ReadInt32();
				break;
			case 129u:
				ConditionAddBuffModifyBuffValue = input.ReadDouble();
				break;
			case 136u:
				ConditionGrade = input.ReadInt32();
				break;
			case 152u:
				CooldownDecreaseValue = input.ReadInt32();
				break;
			case 160u:
				GroupId = input.ReadInt32();
				break;
			case 168u:
				Id = input.ReadInt32();
				break;
			case 144u:
			case 146u:
				conditionNodeId_.AddEntriesFrom(ref input, _repeated_conditionNodeId_codec);
				break;
			case 177u:
				ModifyBuffMagicValue = input.ReadDouble();
				break;
			case 184u:
				ModifyBuffOrder = input.ReadInt32();
				break;
			case 192u:
				ModifyBuffTurn = input.ReadInt32();
				break;
			case 201u:
				ModifyBuffValue = input.ReadDouble();
				break;
			case 208u:
				NodeGroupType = input.ReadInt32();
				break;
			case 216u:
				NodeType = input.ReadInt32();
				break;
			case 224u:
				SpDecreaseValue = input.ReadInt32();
				break;
			case 232u:
				StatType = input.ReadInt32();
				break;
			case 241u:
				StatValue = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
