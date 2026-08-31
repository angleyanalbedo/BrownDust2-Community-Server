using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class BattleFieldBuffTable : IMessage<BattleFieldBuffTable>, IMessage, IEquatable<BattleFieldBuffTable>, IDeepCloneable<BattleFieldBuffTable>, IBufferMessage
{
	private static readonly MessageParser<BattleFieldBuffTable> _parser = new MessageParser<BattleFieldBuffTable>(() => new BattleFieldBuffTable());

	private UnknownFieldSet _unknownFields;

	public const int BuffIDFieldNumber = 1;

	private int buffID_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int TeamTypeFieldNumber = 3;

	private int teamType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BattleFieldBuffTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => BattleFieldBuffTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BuffID
	{
		get
		{
			return buffID_;
		}
		set
		{
			buffID_ = value;
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
	public int TeamType
	{
		get
		{
			return teamType_;
		}
		set
		{
			teamType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleFieldBuffTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleFieldBuffTable(BattleFieldBuffTable other)
		: this()
	{
		buffID_ = other.buffID_;
		id_ = other.id_;
		teamType_ = other.teamType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleFieldBuffTable Clone()
	{
		return new BattleFieldBuffTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleFieldBuffTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleFieldBuffTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BuffID == other.BuffID && Id == other.Id && TeamType == other.TeamType)
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
		if (BuffID != 0)
		{
			num ^= BuffID.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TeamType != 0)
		{
			num ^= TeamType.GetHashCode();
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
		if (BuffID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffID);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (TeamType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TeamType);
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
		if (BuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffID);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (TeamType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TeamType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleFieldBuffTable other)
	{
		if (other != null)
		{
			if (other.BuffID != 0)
			{
				BuffID = other.BuffID;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TeamType != 0)
			{
				TeamType = other.TeamType;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				TeamType = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 8u:
				BuffID = input.ReadInt32();
				break;
			}
		}
	}
}
