using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class FieldBuffTable : IMessage<FieldBuffTable>, IMessage, IEquatable<FieldBuffTable>, IDeepCloneable<FieldBuffTable>, IBufferMessage
{
	private static readonly MessageParser<FieldBuffTable> _parser = new MessageParser<FieldBuffTable>(() => new FieldBuffTable());

	private UnknownFieldSet _unknownFields;

	public const int BuffDescLocalTextIdFieldNumber = 1;

	private int buffDescLocalTextId_;

	public const int BuffLargeIconFieldNumber = 2;

	private string buffLargeIcon_ = "";

	public const int BuffNameLocalTextIdFieldNumber = 3;

	private int buffNameLocalTextId_;

	public const int BuffSmallIconFieldNumber = 4;

	private string buffSmallIcon_ = "";

	public const int BuffTimeFieldNumber = 5;

	private double buffTime_;

	public const int BuffTypeFieldNumber = 6;

	private int buffType_;

	public const int DisappearTimeFieldNumber = 7;

	private double disappearTime_;

	public const int FieldDescLocalTextIdFieldNumber = 8;

	private int fieldDescLocalTextId_;

	public const int IdFieldNumber = 9;

	private int id_;

	public const int KnockBackFieldNumber = 10;

	private int knockBack_;

	public const int RenderTypeFieldNumber = 11;

	private int renderType_;

	public const int SelectBuffFieldNumber = 12;

	private int selectBuff_;

	public const int TargetTypeFieldNumber = 13;

	private int targetType_;

	public const int ValueFieldNumber = 14;

	private double value_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FieldBuffTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => FieldBuffTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffDescLocalTextId
	{
		get
		{
			return buffDescLocalTextId_;
		}
		set
		{
			buffDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BuffLargeIcon
	{
		get
		{
			return buffLargeIcon_;
		}
		set
		{
			buffLargeIcon_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffNameLocalTextId
	{
		get
		{
			return buffNameLocalTextId_;
		}
		set
		{
			buffNameLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BuffSmallIcon
	{
		get
		{
			return buffSmallIcon_;
		}
		set
		{
			buffSmallIcon_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double BuffTime
	{
		get
		{
			return buffTime_;
		}
		set
		{
			buffTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffType
	{
		get
		{
			return buffType_;
		}
		set
		{
			buffType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double DisappearTime
	{
		get
		{
			return disappearTime_;
		}
		set
		{
			disappearTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FieldDescLocalTextId
	{
		get
		{
			return fieldDescLocalTextId_;
		}
		set
		{
			fieldDescLocalTextId_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int KnockBack
	{
		get
		{
			return knockBack_;
		}
		set
		{
			knockBack_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RenderType
	{
		get
		{
			return renderType_;
		}
		set
		{
			renderType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SelectBuff
	{
		get
		{
			return selectBuff_;
		}
		set
		{
			selectBuff_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldBuffTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldBuffTable(FieldBuffTable other)
		: this()
	{
		buffDescLocalTextId_ = other.buffDescLocalTextId_;
		buffLargeIcon_ = other.buffLargeIcon_;
		buffNameLocalTextId_ = other.buffNameLocalTextId_;
		buffSmallIcon_ = other.buffSmallIcon_;
		buffTime_ = other.buffTime_;
		buffType_ = other.buffType_;
		disappearTime_ = other.disappearTime_;
		fieldDescLocalTextId_ = other.fieldDescLocalTextId_;
		id_ = other.id_;
		knockBack_ = other.knockBack_;
		renderType_ = other.renderType_;
		selectBuff_ = other.selectBuff_;
		targetType_ = other.targetType_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldBuffTable Clone()
	{
		return new FieldBuffTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FieldBuffTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FieldBuffTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BuffDescLocalTextId == other.BuffDescLocalTextId && !(BuffLargeIcon != other.BuffLargeIcon) && BuffNameLocalTextId == other.BuffNameLocalTextId && !(BuffSmallIcon != other.BuffSmallIcon) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BuffTime, other.BuffTime) && BuffType == other.BuffType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DisappearTime, other.DisappearTime) && FieldDescLocalTextId == other.FieldDescLocalTextId && Id == other.Id && KnockBack == other.KnockBack && RenderType == other.RenderType && SelectBuff == other.SelectBuff && TargetType == other.TargetType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Value, other.Value))
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
		if (BuffDescLocalTextId != 0)
		{
			num ^= BuffDescLocalTextId.GetHashCode();
		}
		if (BuffLargeIcon.Length != 0)
		{
			num ^= BuffLargeIcon.GetHashCode();
		}
		if (BuffNameLocalTextId != 0)
		{
			num ^= BuffNameLocalTextId.GetHashCode();
		}
		if (BuffSmallIcon.Length != 0)
		{
			num ^= BuffSmallIcon.GetHashCode();
		}
		if (BuffTime != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BuffTime);
		}
		if (BuffType != 0)
		{
			num ^= BuffType.GetHashCode();
		}
		if (DisappearTime != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DisappearTime);
		}
		if (FieldDescLocalTextId != 0)
		{
			num ^= FieldDescLocalTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (KnockBack != 0)
		{
			num ^= KnockBack.GetHashCode();
		}
		if (RenderType != 0)
		{
			num ^= RenderType.GetHashCode();
		}
		if (SelectBuff != 0)
		{
			num ^= SelectBuff.GetHashCode();
		}
		if (TargetType != 0)
		{
			num ^= TargetType.GetHashCode();
		}
		if (Value != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Value);
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
		if (BuffDescLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffDescLocalTextId);
		}
		if (BuffLargeIcon.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BuffLargeIcon);
		}
		if (BuffNameLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuffNameLocalTextId);
		}
		if (BuffSmallIcon.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BuffSmallIcon);
		}
		if (BuffTime != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(BuffTime);
		}
		if (BuffType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BuffType);
		}
		if (DisappearTime != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(DisappearTime);
		}
		if (FieldDescLocalTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(FieldDescLocalTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Id);
		}
		if (KnockBack != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(KnockBack);
		}
		if (RenderType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(RenderType);
		}
		if (SelectBuff != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(SelectBuff);
		}
		if (TargetType != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(TargetType);
		}
		if (Value != 0.0)
		{
			output.WriteRawTag(113);
			output.WriteDouble(Value);
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
		if (BuffDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffDescLocalTextId);
		}
		if (BuffLargeIcon.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuffLargeIcon);
		}
		if (BuffNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffNameLocalTextId);
		}
		if (BuffSmallIcon.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuffSmallIcon);
		}
		if (BuffTime != 0.0)
		{
			num += 9;
		}
		if (BuffType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffType);
		}
		if (DisappearTime != 0.0)
		{
			num += 9;
		}
		if (FieldDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FieldDescLocalTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (KnockBack != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KnockBack);
		}
		if (RenderType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RenderType);
		}
		if (SelectBuff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SelectBuff);
		}
		if (TargetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetType);
		}
		if (Value != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FieldBuffTable other)
	{
		if (other != null)
		{
			if (other.BuffDescLocalTextId != 0)
			{
				BuffDescLocalTextId = other.BuffDescLocalTextId;
			}
			if (other.BuffLargeIcon.Length != 0)
			{
				BuffLargeIcon = other.BuffLargeIcon;
			}
			if (other.BuffNameLocalTextId != 0)
			{
				BuffNameLocalTextId = other.BuffNameLocalTextId;
			}
			if (other.BuffSmallIcon.Length != 0)
			{
				BuffSmallIcon = other.BuffSmallIcon;
			}
			if (other.BuffTime != 0.0)
			{
				BuffTime = other.BuffTime;
			}
			if (other.BuffType != 0)
			{
				BuffType = other.BuffType;
			}
			if (other.DisappearTime != 0.0)
			{
				DisappearTime = other.DisappearTime;
			}
			if (other.FieldDescLocalTextId != 0)
			{
				FieldDescLocalTextId = other.FieldDescLocalTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.KnockBack != 0)
			{
				KnockBack = other.KnockBack;
			}
			if (other.RenderType != 0)
			{
				RenderType = other.RenderType;
			}
			if (other.SelectBuff != 0)
			{
				SelectBuff = other.SelectBuff;
			}
			if (other.TargetType != 0)
			{
				TargetType = other.TargetType;
			}
			if (other.Value != 0.0)
			{
				Value = other.Value;
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
				BuffDescLocalTextId = input.ReadInt32();
				break;
			case 18u:
				BuffLargeIcon = input.ReadString();
				break;
			case 24u:
				BuffNameLocalTextId = input.ReadInt32();
				break;
			case 34u:
				BuffSmallIcon = input.ReadString();
				break;
			case 41u:
				BuffTime = input.ReadDouble();
				break;
			case 48u:
				BuffType = input.ReadInt32();
				break;
			case 57u:
				DisappearTime = input.ReadDouble();
				break;
			case 64u:
				FieldDescLocalTextId = input.ReadInt32();
				break;
			case 72u:
				Id = input.ReadInt32();
				break;
			case 80u:
				KnockBack = input.ReadInt32();
				break;
			case 88u:
				RenderType = input.ReadInt32();
				break;
			case 96u:
				SelectBuff = input.ReadInt32();
				break;
			case 104u:
				TargetType = input.ReadInt32();
				break;
			case 113u:
				Value = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
