using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ContentOpenTable : IMessage<ContentOpenTable>, IMessage, IEquatable<ContentOpenTable>, IDeepCloneable<ContentOpenTable>, IBufferMessage
{
	private static readonly MessageParser<ContentOpenTable> _parser = new MessageParser<ContentOpenTable>(() => new ContentOpenTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int OpenHelpLocalTextIdFieldNumber = 3;

	private int openHelpLocalTextId_;

	public const int OpenTutorialIdFieldNumber = 4;

	private int openTutorialId_;

	public const int SquadLevelFieldNumber = 5;

	private int squadLevel_;

	public const int TicketIdFieldNumber = 6;

	private int ticketId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContentOpenTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => ContentOpenTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int OpenHelpLocalTextId
	{
		get
		{
			return openHelpLocalTextId_;
		}
		set
		{
			openHelpLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OpenTutorialId
	{
		get
		{
			return openTutorialId_;
		}
		set
		{
			openTutorialId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SquadLevel
	{
		get
		{
			return squadLevel_;
		}
		set
		{
			squadLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TicketId
	{
		get
		{
			return ticketId_;
		}
		set
		{
			ticketId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentOpenTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentOpenTable(ContentOpenTable other)
		: this()
	{
		groupId_ = other.groupId_;
		id_ = other.id_;
		openHelpLocalTextId_ = other.openHelpLocalTextId_;
		openTutorialId_ = other.openTutorialId_;
		squadLevel_ = other.squadLevel_;
		ticketId_ = other.ticketId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentOpenTable Clone()
	{
		return new ContentOpenTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ContentOpenTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContentOpenTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && Id == other.Id && OpenHelpLocalTextId == other.OpenHelpLocalTextId && OpenTutorialId == other.OpenTutorialId && SquadLevel == other.SquadLevel && TicketId == other.TicketId)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (OpenHelpLocalTextId != 0)
		{
			num ^= OpenHelpLocalTextId.GetHashCode();
		}
		if (OpenTutorialId != 0)
		{
			num ^= OpenTutorialId.GetHashCode();
		}
		if (SquadLevel != 0)
		{
			num ^= SquadLevel.GetHashCode();
		}
		if (TicketId != 0)
		{
			num ^= TicketId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (OpenHelpLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(OpenHelpLocalTextId);
		}
		if (OpenTutorialId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(OpenTutorialId);
		}
		if (SquadLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SquadLevel);
		}
		if (TicketId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TicketId);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (OpenHelpLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OpenHelpLocalTextId);
		}
		if (OpenTutorialId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OpenTutorialId);
		}
		if (SquadLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SquadLevel);
		}
		if (TicketId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TicketId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContentOpenTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.OpenHelpLocalTextId != 0)
			{
				OpenHelpLocalTextId = other.OpenHelpLocalTextId;
			}
			if (other.OpenTutorialId != 0)
			{
				OpenTutorialId = other.OpenTutorialId;
			}
			if (other.SquadLevel != 0)
			{
				SquadLevel = other.SquadLevel;
			}
			if (other.TicketId != 0)
			{
				TicketId = other.TicketId;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				OpenHelpLocalTextId = input.ReadInt32();
				break;
			case 32u:
				OpenTutorialId = input.ReadInt32();
				break;
			case 40u:
				SquadLevel = input.ReadInt32();
				break;
			case 48u:
				TicketId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
