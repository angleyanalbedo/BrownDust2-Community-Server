using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CostumeNodeGroupTable : IMessage<CostumeNodeGroupTable>, IMessage, IEquatable<CostumeNodeGroupTable>, IDeepCloneable<CostumeNodeGroupTable>, IBufferMessage
{
	private static readonly MessageParser<CostumeNodeGroupTable> _parser = new MessageParser<CostumeNodeGroupTable>(() => new CostumeNodeGroupTable());

	private UnknownFieldSet _unknownFields;

	public const int CharUniqueIdFieldNumber = 1;

	private int charUniqueId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int IsActiveFieldNumber = 3;

	private int isActive_;

	public const int NodeUIPrefabFieldNumber = 4;

	private string nodeUIPrefab_ = "";

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CostumeNodeGroupTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CostumeNodeGroupTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CharUniqueId
	{
		get
		{
			return charUniqueId_;
		}
		set
		{
			charUniqueId_ = value;
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
	public int IsActive
	{
		get
		{
			return isActive_;
		}
		set
		{
			isActive_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string NodeUIPrefab
	{
		get
		{
			return nodeUIPrefab_;
		}
		set
		{
			nodeUIPrefab_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeNodeGroupTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeNodeGroupTable(CostumeNodeGroupTable other)
		: this()
	{
		charUniqueId_ = other.charUniqueId_;
		id_ = other.id_;
		isActive_ = other.isActive_;
		nodeUIPrefab_ = other.nodeUIPrefab_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeNodeGroupTable Clone()
	{
		return new CostumeNodeGroupTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CostumeNodeGroupTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CostumeNodeGroupTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CharUniqueId == other.CharUniqueId && Id == other.Id && IsActive == other.IsActive && !(NodeUIPrefab != other.NodeUIPrefab))
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
		if (CharUniqueId != 0)
		{
			num ^= CharUniqueId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsActive != 0)
		{
			num ^= IsActive.GetHashCode();
		}
		if (NodeUIPrefab.Length != 0)
		{
			num ^= NodeUIPrefab.GetHashCode();
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
		if (CharUniqueId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CharUniqueId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (IsActive != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(IsActive);
		}
		if (NodeUIPrefab.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(NodeUIPrefab);
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
		if (CharUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharUniqueId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (IsActive != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsActive);
		}
		if (NodeUIPrefab.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NodeUIPrefab);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CostumeNodeGroupTable other)
	{
		if (other != null)
		{
			if (other.CharUniqueId != 0)
			{
				CharUniqueId = other.CharUniqueId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsActive != 0)
			{
				IsActive = other.IsActive;
			}
			if (other.NodeUIPrefab.Length != 0)
			{
				NodeUIPrefab = other.NodeUIPrefab;
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
				CharUniqueId = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				IsActive = input.ReadInt32();
				break;
			case 34u:
				NodeUIPrefab = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
