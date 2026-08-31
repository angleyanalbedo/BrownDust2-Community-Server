using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PackMemberTable : IMessage<PackMemberTable>, IMessage, IEquatable<PackMemberTable>, IDeepCloneable<PackMemberTable>, IBufferMessage
{
	private static readonly MessageParser<PackMemberTable> _parser = new MessageParser<PackMemberTable>(() => new PackMemberTable());

	private UnknownFieldSet _unknownFields;

	public const int ChangeTypeFieldNumber = 1;

	private int changeType_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int PackTypeFieldNumber = 3;

	private int packType_;

	public const int SubMemberTypeFieldNumber = 4;

	private int subMemberType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PackMemberTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PackMemberTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChangeType
	{
		get
		{
			return changeType_;
		}
		set
		{
			changeType_ = value;
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
	public int PackType
	{
		get
		{
			return packType_;
		}
		set
		{
			packType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SubMemberType
	{
		get
		{
			return subMemberType_;
		}
		set
		{
			subMemberType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PackMemberTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackMemberTable(PackMemberTable other)
		: this()
	{
		changeType_ = other.changeType_;
		id_ = other.id_;
		packType_ = other.packType_;
		subMemberType_ = other.subMemberType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PackMemberTable Clone()
	{
		return new PackMemberTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PackMemberTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PackMemberTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ChangeType == other.ChangeType && Id == other.Id && PackType == other.PackType && SubMemberType == other.SubMemberType)
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
		if (ChangeType != 0)
		{
			num ^= ChangeType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PackType != 0)
		{
			num ^= PackType.GetHashCode();
		}
		if (SubMemberType != 0)
		{
			num ^= SubMemberType.GetHashCode();
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
		if (ChangeType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ChangeType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (PackType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PackType);
		}
		if (SubMemberType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SubMemberType);
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
		if (ChangeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChangeType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PackType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackType);
		}
		if (SubMemberType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubMemberType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PackMemberTable other)
	{
		if (other != null)
		{
			if (other.ChangeType != 0)
			{
				ChangeType = other.ChangeType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PackType != 0)
			{
				PackType = other.PackType;
			}
			if (other.SubMemberType != 0)
			{
				SubMemberType = other.SubMemberType;
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
				ChangeType = input.ReadInt32();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				PackType = input.ReadInt32();
				break;
			case 32u:
				SubMemberType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
