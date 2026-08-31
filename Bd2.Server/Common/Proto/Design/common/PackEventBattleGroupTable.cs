using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackEventBattleGroupTable : IMessage<PackEventBattleGroupTable>, IMessage, IEquatable<PackEventBattleGroupTable>, IDeepCloneable<PackEventBattleGroupTable>, IBufferMessage
{
	private static readonly MessageParser<PackEventBattleGroupTable> _parser = new MessageParser<PackEventBattleGroupTable>(() => new PackEventBattleGroupTable());

	private UnknownFieldSet _unknownFields;

	public const int BattleNameTextIdFieldNumber = 1;

	private int battleNameTextId_;

	public const int EventNameLocalTextIdFieldNumber = 2;

	private int eventNameLocalTextId_;

	public const int IdFieldNumber = 3;

	private int id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackEventBattleGroupTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackEventBattleGroupTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleNameTextId
	{
		get
		{
			return battleNameTextId_;
		}
		set
		{
			battleNameTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventNameLocalTextId
	{
		get
		{
			return eventNameLocalTextId_;
		}
		set
		{
			eventNameLocalTextId_ = value;
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
	public PackEventBattleGroupTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventBattleGroupTable(PackEventBattleGroupTable other)
		: this()
	{
		battleNameTextId_ = other.battleNameTextId_;
		eventNameLocalTextId_ = other.eventNameLocalTextId_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackEventBattleGroupTable Clone()
	{
		return new PackEventBattleGroupTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackEventBattleGroupTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PackEventBattleGroupTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleNameTextId == other.BattleNameTextId && EventNameLocalTextId == other.EventNameLocalTextId && Id == other.Id)
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
		if (BattleNameTextId != 0)
		{
			num ^= BattleNameTextId.GetHashCode();
		}
		if (EventNameLocalTextId != 0)
		{
			num ^= EventNameLocalTextId.GetHashCode();
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
		if (BattleNameTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleNameTextId);
		}
		if (EventNameLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventNameLocalTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
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
		if (BattleNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleNameTextId);
		}
		if (EventNameLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventNameLocalTextId);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PackEventBattleGroupTable other)
	{
		if (other != null)
		{
			if (other.BattleNameTextId != 0)
			{
				BattleNameTextId = other.BattleNameTextId;
			}
			if (other.EventNameLocalTextId != 0)
			{
				EventNameLocalTextId = other.EventNameLocalTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 16u:
				EventNameLocalTextId = input.ReadInt32();
				break;
			case 8u:
				BattleNameTextId = input.ReadInt32();
				break;
			}
		}
	}
}
