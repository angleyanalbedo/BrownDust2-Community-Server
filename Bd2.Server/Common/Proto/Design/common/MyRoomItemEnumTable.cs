using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MyRoomItemEnumTable : IMessage<MyRoomItemEnumTable>, IMessage, IEquatable<MyRoomItemEnumTable>, IDeepCloneable<MyRoomItemEnumTable>, IBufferMessage
{
	private static readonly MessageParser<MyRoomItemEnumTable> _parser = new MessageParser<MyRoomItemEnumTable>(() => new MyRoomItemEnumTable());

	private UnknownFieldSet _unknownFields;

	public const int GridXFieldNumber = 1;

	private int gridX_;

	public const int GridYFieldNumber = 2;

	private int gridY_;

	public const int IdFieldNumber = 3;

	private int id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MyRoomItemEnumTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MyRoomItemEnumTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GridX
	{
		get
		{
			return gridX_;
		}
		set
		{
			gridX_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GridY
	{
		get
		{
			return gridY_;
		}
		set
		{
			gridY_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemEnumTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemEnumTable(MyRoomItemEnumTable other)
		: this()
	{
		gridX_ = other.gridX_;
		gridY_ = other.gridY_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MyRoomItemEnumTable Clone()
	{
		return new MyRoomItemEnumTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MyRoomItemEnumTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MyRoomItemEnumTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GridX == other.GridX && GridY == other.GridY && Id == other.Id)
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
		if (GridX != 0)
		{
			num ^= GridX.GetHashCode();
		}
		if (GridY != 0)
		{
			num ^= GridY.GetHashCode();
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
		if (GridX != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GridX);
		}
		if (GridY != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GridY);
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (GridX != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GridX);
		}
		if (GridY != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GridY);
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
	public void MergeFrom(MyRoomItemEnumTable other)
	{
		if (other != null)
		{
			if (other.GridX != 0)
			{
				GridX = other.GridX;
			}
			if (other.GridY != 0)
			{
				GridY = other.GridY;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				GridY = input.ReadInt32();
				break;
			case 8u:
				GridX = input.ReadInt32();
				break;
			}
		}
	}
}
