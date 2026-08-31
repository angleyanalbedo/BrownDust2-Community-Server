using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ItemAcquireTable : IMessage<ItemAcquireTable>, IMessage, IEquatable<ItemAcquireTable>, IDeepCloneable<ItemAcquireTable>, IBufferMessage
{
	private static readonly MessageParser<ItemAcquireTable> _parser = new MessageParser<ItemAcquireTable>(() => new ItemAcquireTable());

	private UnknownFieldSet _unknownFields;

	public const int AcquireDescTextIdFieldNumber = 1;

	private int acquireDescTextId_;

	public const int AcquireIconNameFieldNumber = 2;

	private string acquireIconName_ = "";

	public const int AcquireTitleTextIdFieldNumber = 3;

	private int acquireTitleTextId_;

	public const int IdFieldNumber = 4;

	private int id_;

	public const int ShortCutIdFieldNumber = 5;

	private int shortCutId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ItemAcquireTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ItemAcquireTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AcquireDescTextId
	{
		get
		{
			return acquireDescTextId_;
		}
		set
		{
			acquireDescTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AcquireIconName
	{
		get
		{
			return acquireIconName_;
		}
		set
		{
			acquireIconName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AcquireTitleTextId
	{
		get
		{
			return acquireTitleTextId_;
		}
		set
		{
			acquireTitleTextId_ = value;
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
	public int ShortCutId
	{
		get
		{
			return shortCutId_;
		}
		set
		{
			shortCutId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemAcquireTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ItemAcquireTable(ItemAcquireTable other)
		: this()
	{
		acquireDescTextId_ = other.acquireDescTextId_;
		acquireIconName_ = other.acquireIconName_;
		acquireTitleTextId_ = other.acquireTitleTextId_;
		id_ = other.id_;
		shortCutId_ = other.shortCutId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemAcquireTable Clone()
	{
		return new ItemAcquireTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ItemAcquireTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ItemAcquireTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (AcquireDescTextId == other.AcquireDescTextId && !(AcquireIconName != other.AcquireIconName) && AcquireTitleTextId == other.AcquireTitleTextId && Id == other.Id && ShortCutId == other.ShortCutId)
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
		if (AcquireDescTextId != 0)
		{
			num ^= AcquireDescTextId.GetHashCode();
		}
		if (AcquireIconName.Length != 0)
		{
			num ^= AcquireIconName.GetHashCode();
		}
		if (AcquireTitleTextId != 0)
		{
			num ^= AcquireTitleTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ShortCutId != 0)
		{
			num ^= ShortCutId.GetHashCode();
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
		if (AcquireDescTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AcquireDescTextId);
		}
		if (AcquireIconName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AcquireIconName);
		}
		if (AcquireTitleTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AcquireTitleTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Id);
		}
		if (ShortCutId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ShortCutId);
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
		if (AcquireDescTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AcquireDescTextId);
		}
		if (AcquireIconName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AcquireIconName);
		}
		if (AcquireTitleTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AcquireTitleTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ShortCutId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShortCutId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ItemAcquireTable other)
	{
		if (other != null)
		{
			if (other.AcquireDescTextId != 0)
			{
				AcquireDescTextId = other.AcquireDescTextId;
			}
			if (other.AcquireIconName.Length != 0)
			{
				AcquireIconName = other.AcquireIconName;
			}
			if (other.AcquireTitleTextId != 0)
			{
				AcquireTitleTextId = other.AcquireTitleTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ShortCutId != 0)
			{
				ShortCutId = other.ShortCutId;
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
				AcquireDescTextId = input.ReadInt32();
				break;
			case 18u:
				AcquireIconName = input.ReadString();
				break;
			case 24u:
				AcquireTitleTextId = input.ReadInt32();
				break;
			case 32u:
				Id = input.ReadInt32();
				break;
			case 40u:
				ShortCutId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
