using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CookingPictorialBookTable : IMessage<CookingPictorialBookTable>, IMessage, IEquatable<CookingPictorialBookTable>, IDeepCloneable<CookingPictorialBookTable>, IBufferMessage
{
	private static readonly MessageParser<CookingPictorialBookTable> _parser = new MessageParser<CookingPictorialBookTable>(() => new CookingPictorialBookTable());

	private UnknownFieldSet _unknownFields;

	public const int CollectionBuffIdFieldNumber = 1;

	private int collectionBuffId_;

	public const int CookingIdFieldNumber = 2;

	private int cookingId_;

	public const int IdFieldNumber = 3;

	private int id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CookingPictorialBookTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CookingPictorialBookTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CollectionBuffId
	{
		get
		{
			return collectionBuffId_;
		}
		set
		{
			collectionBuffId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CookingId
	{
		get
		{
			return cookingId_;
		}
		set
		{
			cookingId_ = value;
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
	public CookingPictorialBookTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CookingPictorialBookTable(CookingPictorialBookTable other)
		: this()
	{
		collectionBuffId_ = other.collectionBuffId_;
		cookingId_ = other.cookingId_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingPictorialBookTable Clone()
	{
		return new CookingPictorialBookTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CookingPictorialBookTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CookingPictorialBookTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CollectionBuffId == other.CollectionBuffId && CookingId == other.CookingId && Id == other.Id)
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
		if (CollectionBuffId != 0)
		{
			num ^= CollectionBuffId.GetHashCode();
		}
		if (CookingId != 0)
		{
			num ^= CookingId.GetHashCode();
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
		if (CollectionBuffId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CollectionBuffId);
		}
		if (CookingId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CookingId);
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		int num = 0;
		if (CollectionBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectionBuffId);
		}
		if (CookingId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CookingId);
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
	public void MergeFrom(CookingPictorialBookTable other)
	{
		if (other != null)
		{
			if (other.CollectionBuffId != 0)
			{
				CollectionBuffId = other.CollectionBuffId;
			}
			if (other.CookingId != 0)
			{
				CookingId = other.CookingId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 24u:
				Id = input.ReadInt32();
				break;
			case 16u:
				CookingId = input.ReadInt32();
				break;
			case 8u:
				CollectionBuffId = input.ReadInt32();
				break;
			}
		}
	}
}
