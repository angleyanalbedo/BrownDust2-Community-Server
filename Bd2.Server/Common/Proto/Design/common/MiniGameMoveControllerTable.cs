using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MiniGameMoveControllerTable : IMessage<MiniGameMoveControllerTable>, IMessage, IEquatable<MiniGameMoveControllerTable>, IDeepCloneable<MiniGameMoveControllerTable>, IBufferMessage
{
	private static readonly MessageParser<MiniGameMoveControllerTable> _parser = new MessageParser<MiniGameMoveControllerTable>(() => new MiniGameMoveControllerTable());

	private UnknownFieldSet _unknownFields;

	public const int ControllerResourceNameFieldNumber = 1;

	private string controllerResourceName_ = "";

	public const int GroupIdFieldNumber = 2;

	private int groupId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int MoveMaxCountFieldNumber = 4;

	private int moveMaxCount_;

	public const int MoveMinCountFieldNumber = 5;

	private int moveMinCount_;

	public const int TypeFieldNumber = 6;

	private int type_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameMoveControllerTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameMoveControllerTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ControllerResourceName
	{
		get
		{
			return controllerResourceName_;
		}
		set
		{
			controllerResourceName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MoveMaxCount
	{
		get
		{
			return moveMaxCount_;
		}
		set
		{
			moveMaxCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MoveMinCount
	{
		get
		{
			return moveMinCount_;
		}
		set
		{
			moveMinCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameMoveControllerTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameMoveControllerTable(MiniGameMoveControllerTable other)
		: this()
	{
		controllerResourceName_ = other.controllerResourceName_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		moveMaxCount_ = other.moveMaxCount_;
		moveMinCount_ = other.moveMinCount_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameMoveControllerTable Clone()
	{
		return new MiniGameMoveControllerTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameMoveControllerTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameMoveControllerTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(ControllerResourceName != other.ControllerResourceName) && GroupId == other.GroupId && Id == other.Id && MoveMaxCount == other.MoveMaxCount && MoveMinCount == other.MoveMinCount && Type == other.Type)
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
		if (ControllerResourceName.Length != 0)
		{
			num ^= ControllerResourceName.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MoveMaxCount != 0)
		{
			num ^= MoveMaxCount.GetHashCode();
		}
		if (MoveMinCount != 0)
		{
			num ^= MoveMinCount.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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
		if (ControllerResourceName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ControllerResourceName);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (MoveMaxCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MoveMaxCount);
		}
		if (MoveMinCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MoveMinCount);
		}
		if (Type != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Type);
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
		if (ControllerResourceName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ControllerResourceName);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MoveMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MoveMaxCount);
		}
		if (MoveMinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MoveMinCount);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MiniGameMoveControllerTable other)
	{
		if (other != null)
		{
			if (other.ControllerResourceName.Length != 0)
			{
				ControllerResourceName = other.ControllerResourceName;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MoveMaxCount != 0)
			{
				MoveMaxCount = other.MoveMaxCount;
			}
			if (other.MoveMinCount != 0)
			{
				MoveMinCount = other.MoveMinCount;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
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
			case 10u:
				ControllerResourceName = input.ReadString();
				break;
			case 16u:
				GroupId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				MoveMaxCount = input.ReadInt32();
				break;
			case 40u:
				MoveMinCount = input.ReadInt32();
				break;
			case 48u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
