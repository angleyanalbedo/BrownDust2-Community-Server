using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class AttendanceAlwaysTable : IMessage<AttendanceAlwaysTable>, IMessage, IEquatable<AttendanceAlwaysTable>, IDeepCloneable<AttendanceAlwaysTable>, IBufferMessage
{
	private static readonly MessageParser<AttendanceAlwaysTable> _parser = new MessageParser<AttendanceAlwaysTable>(() => new AttendanceAlwaysTable());

	private UnknownFieldSet _unknownFields;

	public const int AlwaysGroupIdFieldNumber = 1;

	private int alwaysGroupId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int TitleLocalTextIdFieldNumber = 3;

	private string titleLocalTextId_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AttendanceAlwaysTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AttendanceAlwaysTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AlwaysGroupId
	{
		get
		{
			return alwaysGroupId_;
		}
		set
		{
			alwaysGroupId_ = value;
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
	public string TitleLocalTextId
	{
		get
		{
			return titleLocalTextId_;
		}
		set
		{
			titleLocalTextId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysTable(AttendanceAlwaysTable other)
		: this()
	{
		alwaysGroupId_ = other.alwaysGroupId_;
		id_ = other.id_;
		titleLocalTextId_ = other.titleLocalTextId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AttendanceAlwaysTable Clone()
	{
		return new AttendanceAlwaysTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AttendanceAlwaysTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AttendanceAlwaysTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AlwaysGroupId == other.AlwaysGroupId && Id == other.Id && !(TitleLocalTextId != other.TitleLocalTextId))
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
		if (AlwaysGroupId != 0)
		{
			num ^= AlwaysGroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TitleLocalTextId.Length != 0)
		{
			num ^= TitleLocalTextId.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (AlwaysGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AlwaysGroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (TitleLocalTextId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TitleLocalTextId);
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
		if (AlwaysGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AlwaysGroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (TitleLocalTextId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TitleLocalTextId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AttendanceAlwaysTable other)
	{
		if (other != null)
		{
			if (other.AlwaysGroupId != 0)
			{
				AlwaysGroupId = other.AlwaysGroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TitleLocalTextId.Length != 0)
			{
				TitleLocalTextId = other.TitleLocalTextId;
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
			case 26u:
				TitleLocalTextId = input.ReadString();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 8u:
				AlwaysGroupId = input.ReadInt32();
				break;
			}
		}
	}
}
