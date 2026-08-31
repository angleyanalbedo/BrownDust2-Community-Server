using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class WorldBuffTable : IMessage<WorldBuffTable>, IMessage, IEquatable<WorldBuffTable>, IDeepCloneable<WorldBuffTable>, IBufferMessage
{
	private static readonly MessageParser<WorldBuffTable> _parser = new MessageParser<WorldBuffTable>(() => new WorldBuffTable());

	private UnknownFieldSet _unknownFields;

	public const int BuffIconFieldNumber = 1;

	private string buffIcon_ = "";

	public const int BuffTitleLocalTextIdFieldNumber = 2;

	private int buffTitleLocalTextId_;

	public const int BuffValueFieldNumber = 3;

	private double buffValue_;

	public const int BuffdescLocalTextIdFieldNumber = 4;

	private int buffdescLocalTextId_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int StatTypeFieldNumber = 6;

	private int statType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<WorldBuffTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => WorldBuffTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BuffIcon
	{
		get
		{
			return buffIcon_;
		}
		set
		{
			buffIcon_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuffTitleLocalTextId
	{
		get
		{
			return buffTitleLocalTextId_;
		}
		set
		{
			buffTitleLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double BuffValue
	{
		get
		{
			return buffValue_;
		}
		set
		{
			buffValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffdescLocalTextId
	{
		get
		{
			return buffdescLocalTextId_;
		}
		set
		{
			buffdescLocalTextId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WorldBuffTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WorldBuffTable(WorldBuffTable other)
		: this()
	{
		buffIcon_ = other.buffIcon_;
		buffTitleLocalTextId_ = other.buffTitleLocalTextId_;
		buffValue_ = other.buffValue_;
		buffdescLocalTextId_ = other.buffdescLocalTextId_;
		id_ = other.id_;
		statType_ = other.statType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WorldBuffTable Clone()
	{
		return new WorldBuffTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as WorldBuffTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(WorldBuffTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(BuffIcon != other.BuffIcon) && BuffTitleLocalTextId == other.BuffTitleLocalTextId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BuffValue, other.BuffValue) && BuffdescLocalTextId == other.BuffdescLocalTextId && Id == other.Id && StatType == other.StatType)
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
		if (BuffIcon.Length != 0)
		{
			num ^= BuffIcon.GetHashCode();
		}
		if (BuffTitleLocalTextId != 0)
		{
			num ^= BuffTitleLocalTextId.GetHashCode();
		}
		if (BuffValue != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BuffValue);
		}
		if (BuffdescLocalTextId != 0)
		{
			num ^= BuffdescLocalTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (StatType != 0)
		{
			num ^= StatType.GetHashCode();
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
		if (BuffIcon.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BuffIcon);
		}
		if (BuffTitleLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffTitleLocalTextId);
		}
		if (BuffValue != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(BuffValue);
		}
		if (BuffdescLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BuffdescLocalTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (StatType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(StatType);
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
		if (BuffIcon.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuffIcon);
		}
		if (BuffTitleLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffTitleLocalTextId);
		}
		if (BuffValue != 0.0)
		{
			num += 9;
		}
		if (BuffdescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffdescLocalTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (StatType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StatType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WorldBuffTable other)
	{
		if (other != null)
		{
			if (other.BuffIcon.Length != 0)
			{
				BuffIcon = other.BuffIcon;
			}
			if (other.BuffTitleLocalTextId != 0)
			{
				BuffTitleLocalTextId = other.BuffTitleLocalTextId;
			}
			if (other.BuffValue != 0.0)
			{
				BuffValue = other.BuffValue;
			}
			if (other.BuffdescLocalTextId != 0)
			{
				BuffdescLocalTextId = other.BuffdescLocalTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.StatType != 0)
			{
				StatType = other.StatType;
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
			case 10u:
				BuffIcon = input.ReadString();
				break;
			case 16u:
				BuffTitleLocalTextId = input.ReadInt32();
				break;
			case 25u:
				BuffValue = input.ReadDouble();
				break;
			case 32u:
				BuffdescLocalTextId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				StatType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
