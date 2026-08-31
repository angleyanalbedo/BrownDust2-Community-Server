using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLEventEffectTypeTable : IMessage<RLEventEffectTypeTable>, IMessage, IEquatable<RLEventEffectTypeTable>, IDeepCloneable<RLEventEffectTypeTable>, IBufferMessage
{
	private static readonly MessageParser<RLEventEffectTypeTable> _parser = new MessageParser<RLEventEffectTypeTable>(() => new RLEventEffectTypeTable());

	private UnknownFieldSet _unknownFields;

	public const int EffectTypeFieldNumber = 1;

	private int effectType_;

	public const int EffectValue1FieldNumber = 2;

	private int effectValue1_;

	public const int EffectValue2FieldNumber = 3;

	private int effectValue2_;

	public const int EventEffectNameTextIdFieldNumber = 4;

	private int eventEffectNameTextId_;

	public const int IdFieldNumber = 5;

	private int id_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<RLEventEffectTypeTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RLEventEffectTypeTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int EffectValue1
	{
		get
		{
			return effectValue1_;
		}
		set
		{
			effectValue1_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EffectValue2
	{
		get
		{
			return effectValue2_;
		}
		set
		{
			effectValue2_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventEffectNameTextId
	{
		get
		{
			return eventEffectNameTextId_;
		}
		set
		{
			eventEffectNameTextId_ = value;
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
	public RLEventEffectTypeTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLEventEffectTypeTable(RLEventEffectTypeTable other)
		: this()
	{
		effectType_ = other.effectType_;
		effectValue1_ = other.effectValue1_;
		effectValue2_ = other.effectValue2_;
		eventEffectNameTextId_ = other.eventEffectNameTextId_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLEventEffectTypeTable Clone()
	{
		return new RLEventEffectTypeTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLEventEffectTypeTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RLEventEffectTypeTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EffectType == other.EffectType && EffectValue1 == other.EffectValue1 && EffectValue2 == other.EffectValue2 && EventEffectNameTextId == other.EventEffectNameTextId && Id == other.Id)
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
		if (EffectType != 0)
		{
			num ^= EffectType.GetHashCode();
		}
		if (EffectValue1 != 0)
		{
			num ^= EffectValue1.GetHashCode();
		}
		if (EffectValue2 != 0)
		{
			num ^= EffectValue2.GetHashCode();
		}
		if (EventEffectNameTextId != 0)
		{
			num ^= EventEffectNameTextId.GetHashCode();
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
		if (EffectType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EffectType);
		}
		if (EffectValue1 != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EffectValue1);
		}
		if (EffectValue2 != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EffectValue2);
		}
		if (EventEffectNameTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EventEffectNameTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
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
		if (EffectType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectType);
		}
		if (EffectValue1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectValue1);
		}
		if (EffectValue2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectValue2);
		}
		if (EventEffectNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventEffectNameTextId);
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
	public void MergeFrom(RLEventEffectTypeTable other)
	{
		if (other != null)
		{
			if (other.EffectType != 0)
			{
				EffectType = other.EffectType;
			}
			if (other.EffectValue1 != 0)
			{
				EffectValue1 = other.EffectValue1;
			}
			if (other.EffectValue2 != 0)
			{
				EffectValue2 = other.EffectValue2;
			}
			if (other.EventEffectNameTextId != 0)
			{
				EventEffectNameTextId = other.EventEffectNameTextId;
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
				EffectType = input.ReadInt32();
				break;
			case 16u:
				EffectValue1 = input.ReadInt32();
				break;
			case 24u:
				EffectValue2 = input.ReadInt32();
				break;
			case 32u:
				EventEffectNameTextId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
