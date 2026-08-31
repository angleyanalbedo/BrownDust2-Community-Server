using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class TitleItemTable : IMessage<TitleItemTable>, IMessage, IEquatable<TitleItemTable>, IDeepCloneable<TitleItemTable>, IBufferMessage
{
	private static readonly MessageParser<TitleItemTable> _parser = new MessageParser<TitleItemTable>(() => new TitleItemTable());

	private UnknownFieldSet _unknownFields;

	public const int GradeFieldNumber = 1;

	private int grade_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int TitleItemNameFieldNumber = 3;

	private string titleItemName_ = "";

	public const int TitleMissionTextIdFieldNumber = 4;

	private int titleMissionTextId_;

	public const int TitleNameTextIdFieldNumber = 5;

	private string titleNameTextId_ = "";

	public const int TitleSortNumberFieldNumber = 6;

	private int titleSortNumber_;

	public const int TypeFieldNumber = 7;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TitleItemTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TitleItemTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Grade
	{
		get
		{
			return grade_;
		}
		set
		{
			grade_ = value;
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
	public string TitleItemName
	{
		get
		{
			return titleItemName_;
		}
		set
		{
			titleItemName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TitleMissionTextId
	{
		get
		{
			return titleMissionTextId_;
		}
		set
		{
			titleMissionTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TitleNameTextId
	{
		get
		{
			return titleNameTextId_;
		}
		set
		{
			titleNameTextId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TitleSortNumber
	{
		get
		{
			return titleSortNumber_;
		}
		set
		{
			titleSortNumber_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public TitleItemTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleItemTable(TitleItemTable other)
		: this()
	{
		grade_ = other.grade_;
		id_ = other.id_;
		titleItemName_ = other.titleItemName_;
		titleMissionTextId_ = other.titleMissionTextId_;
		titleNameTextId_ = other.titleNameTextId_;
		titleSortNumber_ = other.titleSortNumber_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitleItemTable Clone()
	{
		return new TitleItemTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TitleItemTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TitleItemTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Grade == other.Grade && Id == other.Id && !(TitleItemName != other.TitleItemName) && TitleMissionTextId == other.TitleMissionTextId && !(TitleNameTextId != other.TitleNameTextId) && TitleSortNumber == other.TitleSortNumber && Type == other.Type)
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
		if (Grade != 0)
		{
			num ^= Grade.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TitleItemName.Length != 0)
		{
			num ^= TitleItemName.GetHashCode();
		}
		if (TitleMissionTextId != 0)
		{
			num ^= TitleMissionTextId.GetHashCode();
		}
		if (TitleNameTextId.Length != 0)
		{
			num ^= TitleNameTextId.GetHashCode();
		}
		if (TitleSortNumber != 0)
		{
			num ^= TitleSortNumber.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Grade != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Grade);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (TitleItemName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TitleItemName);
		}
		if (TitleMissionTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TitleMissionTextId);
		}
		if (TitleNameTextId.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(TitleNameTextId);
		}
		if (TitleSortNumber != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TitleSortNumber);
		}
		if (Type != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Type);
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
		if (Grade != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Grade);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (TitleItemName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TitleItemName);
		}
		if (TitleMissionTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleMissionTextId);
		}
		if (TitleNameTextId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TitleNameTextId);
		}
		if (TitleSortNumber != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TitleSortNumber);
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
	public void MergeFrom(TitleItemTable other)
	{
		if (other != null)
		{
			if (other.Grade != 0)
			{
				Grade = other.Grade;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TitleItemName.Length != 0)
			{
				TitleItemName = other.TitleItemName;
			}
			if (other.TitleMissionTextId != 0)
			{
				TitleMissionTextId = other.TitleMissionTextId;
			}
			if (other.TitleNameTextId.Length != 0)
			{
				TitleNameTextId = other.TitleNameTextId;
			}
			if (other.TitleSortNumber != 0)
			{
				TitleSortNumber = other.TitleSortNumber;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
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
			case 8u:
				Grade = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 26u:
				TitleItemName = input.ReadString();
				break;
			case 32u:
				TitleMissionTextId = input.ReadInt32();
				break;
			case 42u:
				TitleNameTextId = input.ReadString();
				break;
			case 48u:
				TitleSortNumber = input.ReadInt32();
				break;
			case 56u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
