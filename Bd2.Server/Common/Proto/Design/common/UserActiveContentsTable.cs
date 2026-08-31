using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class UserActiveContentsTable : IMessage<UserActiveContentsTable>, IMessage, IEquatable<UserActiveContentsTable>, IDeepCloneable<UserActiveContentsTable>, IBufferMessage
{
	private static readonly MessageParser<UserActiveContentsTable> _parser = new MessageParser<UserActiveContentsTable>(() => new UserActiveContentsTable());

	private UnknownFieldSet _unknownFields;

	public const int ActiveDayFieldNumber = 1;

	private int activeDay_;

	public const int ContentTicketIdFieldNumber = 2;

	private int contentTicketId_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int TypeFieldNumber = 4;

	private int type_;

	public const int TypeGroupIdFieldNumber = 5;

	private int typeGroupId_;

	public const int TypeIdFieldNumber = 6;

	private int typeId_;

	public const int UserTypeFieldNumber = 7;

	private int userType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UserActiveContentsTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => UserActiveContentsTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ActiveDay
	{
		get
		{
			return activeDay_;
		}
		set
		{
			activeDay_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContentTicketId
	{
		get
		{
			return contentTicketId_;
		}
		set
		{
			contentTicketId_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TypeGroupId
	{
		get
		{
			return typeGroupId_;
		}
		set
		{
			typeGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TypeId
	{
		get
		{
			return typeId_;
		}
		set
		{
			typeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UserType
	{
		get
		{
			return userType_;
		}
		set
		{
			userType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UserActiveContentsTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserActiveContentsTable(UserActiveContentsTable other)
		: this()
	{
		activeDay_ = other.activeDay_;
		contentTicketId_ = other.contentTicketId_;
		id_ = other.id_;
		type_ = other.type_;
		typeGroupId_ = other.typeGroupId_;
		typeId_ = other.typeId_;
		userType_ = other.userType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UserActiveContentsTable Clone()
	{
		return new UserActiveContentsTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as UserActiveContentsTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UserActiveContentsTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ActiveDay == other.ActiveDay && ContentTicketId == other.ContentTicketId && Id == other.Id && Type == other.Type && TypeGroupId == other.TypeGroupId && TypeId == other.TypeId && UserType == other.UserType)
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
		if (ActiveDay != 0)
		{
			num ^= ActiveDay.GetHashCode();
		}
		if (ContentTicketId != 0)
		{
			num ^= ContentTicketId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (TypeGroupId != 0)
		{
			num ^= TypeGroupId.GetHashCode();
		}
		if (TypeId != 0)
		{
			num ^= TypeId.GetHashCode();
		}
		if (UserType != 0)
		{
			num ^= UserType.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (ActiveDay != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ActiveDay);
		}
		if (ContentTicketId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ContentTicketId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (Type != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Type);
		}
		if (TypeGroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TypeGroupId);
		}
		if (TypeId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TypeId);
		}
		if (UserType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(UserType);
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
		if (ActiveDay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ActiveDay);
		}
		if (ContentTicketId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContentTicketId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (TypeGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TypeGroupId);
		}
		if (TypeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TypeId);
		}
		if (UserType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UserType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UserActiveContentsTable other)
	{
		if (other != null)
		{
			if (other.ActiveDay != 0)
			{
				ActiveDay = other.ActiveDay;
			}
			if (other.ContentTicketId != 0)
			{
				ContentTicketId = other.ContentTicketId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.TypeGroupId != 0)
			{
				TypeGroupId = other.TypeGroupId;
			}
			if (other.TypeId != 0)
			{
				TypeId = other.TypeId;
			}
			if (other.UserType != 0)
			{
				UserType = other.UserType;
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
				ActiveDay = input.ReadInt32();
				break;
			case 16u:
				ContentTicketId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				Type = input.ReadInt32();
				break;
			case 40u:
				TypeGroupId = input.ReadInt32();
				break;
			case 48u:
				TypeId = input.ReadInt32();
				break;
			case 56u:
				UserType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
