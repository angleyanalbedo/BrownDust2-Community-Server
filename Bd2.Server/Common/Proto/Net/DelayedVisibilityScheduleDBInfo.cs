using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class DelayedVisibilityScheduleDBInfo : IMessage<DelayedVisibilityScheduleDBInfo>, IMessage, IEquatable<DelayedVisibilityScheduleDBInfo>, IDeepCloneable<DelayedVisibilityScheduleDBInfo>, IBufferMessage
{
	private static readonly MessageParser<DelayedVisibilityScheduleDBInfo> _parser = new MessageParser<DelayedVisibilityScheduleDBInfo>(() => new DelayedVisibilityScheduleDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private Define_DelayedVisibilityType type_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int TableIdFieldNumber = 3;

	private int tableId_;

	public const int OpenDateFieldNumber = 4;

	private long openDate_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DelayedVisibilityScheduleDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DelayedVisibilityScheduleDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Define_DelayedVisibilityType Type
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
	public int TableId
	{
		get
		{
			return tableId_;
		}
		set
		{
			tableId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OpenDate
	{
		get
		{
			return openDate_;
		}
		set
		{
			openDate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedVisibilityScheduleDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedVisibilityScheduleDBInfo(DelayedVisibilityScheduleDBInfo other)
		: this()
	{
		type_ = other.type_;
		id_ = other.id_;
		tableId_ = other.tableId_;
		openDate_ = other.openDate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DelayedVisibilityScheduleDBInfo Clone()
	{
		return new DelayedVisibilityScheduleDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DelayedVisibilityScheduleDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DelayedVisibilityScheduleDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Type == other.Type && Id == other.Id && TableId == other.TableId && OpenDate == other.OpenDate)
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
		if (Type != Define_DelayedVisibilityType.DbtNone)
		{
			num ^= Type.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TableId != 0)
		{
			num ^= TableId.GetHashCode();
		}
		if (OpenDate != 0L)
		{
			num ^= OpenDate.GetHashCode();
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
		if (Type != Define_DelayedVisibilityType.DbtNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (TableId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TableId);
		}
		if (OpenDate != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(OpenDate);
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
		if (Type != Define_DelayedVisibilityType.DbtNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (TableId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TableId);
		}
		if (OpenDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OpenDate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(DelayedVisibilityScheduleDBInfo other)
	{
		if (other != null)
		{
			if (other.Type != Define_DelayedVisibilityType.DbtNone)
			{
				Type = other.Type;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TableId != 0)
			{
				TableId = other.TableId;
			}
			if (other.OpenDate != 0L)
			{
				OpenDate = other.OpenDate;
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
				Type = (Define_DelayedVisibilityType)input.ReadEnum();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				TableId = input.ReadInt32();
				break;
			case 32u:
				OpenDate = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
