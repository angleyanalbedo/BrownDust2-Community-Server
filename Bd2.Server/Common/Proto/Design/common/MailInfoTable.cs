using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MailInfoTable : IMessage<MailInfoTable>, IMessage, IEquatable<MailInfoTable>, IDeepCloneable<MailInfoTable>, IBufferMessage
{
	private static readonly MessageParser<MailInfoTable> _parser = new MessageParser<MailInfoTable>(() => new MailInfoTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int MessageLocalTextIdFieldNumber = 2;

	private int messageLocalTextId_;

	public const int PeriodDateFieldNumber = 3;

	private int periodDate_;

	public const int SenderLocalTextIdFieldNumber = 4;

	private int senderLocalTextId_;

	public const int TitleLocalTextIdFieldNumber = 5;

	private int titleLocalTextId_;

	public const int TypeFieldNumber = 6;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MailInfoTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MailInfoTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int MessageLocalTextId
	{
		get
		{
			return messageLocalTextId_;
		}
		set
		{
			messageLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PeriodDate
	{
		get
		{
			return periodDate_;
		}
		set
		{
			periodDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SenderLocalTextId
	{
		get
		{
			return senderLocalTextId_;
		}
		set
		{
			senderLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TitleLocalTextId
	{
		get
		{
			return titleLocalTextId_;
		}
		set
		{
			titleLocalTextId_ = value;
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
	public MailInfoTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MailInfoTable(MailInfoTable other)
		: this()
	{
		id_ = other.id_;
		messageLocalTextId_ = other.messageLocalTextId_;
		periodDate_ = other.periodDate_;
		senderLocalTextId_ = other.senderLocalTextId_;
		titleLocalTextId_ = other.titleLocalTextId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MailInfoTable Clone()
	{
		return new MailInfoTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MailInfoTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MailInfoTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && MessageLocalTextId == other.MessageLocalTextId && PeriodDate == other.PeriodDate && SenderLocalTextId == other.SenderLocalTextId && TitleLocalTextId == other.TitleLocalTextId && Type == other.Type)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MessageLocalTextId != 0)
		{
			num ^= MessageLocalTextId.GetHashCode();
		}
		if (PeriodDate != 0)
		{
			num ^= PeriodDate.GetHashCode();
		}
		if (SenderLocalTextId != 0)
		{
			num ^= SenderLocalTextId.GetHashCode();
		}
		if (TitleLocalTextId != 0)
		{
			num ^= TitleLocalTextId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (MessageLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MessageLocalTextId);
		}
		if (PeriodDate != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PeriodDate);
		}
		if (SenderLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SenderLocalTextId);
		}
		if (TitleLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TitleLocalTextId);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MessageLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MessageLocalTextId);
		}
		if (PeriodDate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PeriodDate);
		}
		if (SenderLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SenderLocalTextId);
		}
		if (TitleLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleLocalTextId);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MailInfoTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MessageLocalTextId != 0)
			{
				MessageLocalTextId = other.MessageLocalTextId;
			}
			if (other.PeriodDate != 0)
			{
				PeriodDate = other.PeriodDate;
			}
			if (other.SenderLocalTextId != 0)
			{
				SenderLocalTextId = other.SenderLocalTextId;
			}
			if (other.TitleLocalTextId != 0)
			{
				TitleLocalTextId = other.TitleLocalTextId;
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
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
				MessageLocalTextId = input.ReadInt32();
				break;
			case 24u:
				PeriodDate = input.ReadInt32();
				break;
			case 32u:
				SenderLocalTextId = input.ReadInt32();
				break;
			case 40u:
				TitleLocalTextId = input.ReadInt32();
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
