using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ServerTransformation : IMessage<ServerTransformation>, IMessage, IEquatable<ServerTransformation>, IDeepCloneable<ServerTransformation>, IBufferMessage
{
	private static readonly MessageParser<ServerTransformation> _parser = new MessageParser<ServerTransformation>(() => new ServerTransformation());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int TurnCountFieldNumber = 2;

	private int turnCount_;

	public const int OwnerUniqueIdFieldNumber = 3;

	private long ownerUniqueId_;

	public const int CreatorUniqueIdFieldNumber = 4;

	private long creatorUniqueId_;

	public const int CostumeIdFieldNumber = 5;

	private int costumeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerTransformation> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuffListInfoReflection.Descriptor.MessageTypes[10];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TurnCount
	{
		get
		{
			return turnCount_;
		}
		set
		{
			turnCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long OwnerUniqueId
	{
		get
		{
			return ownerUniqueId_;
		}
		set
		{
			ownerUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CreatorUniqueId
	{
		get
		{
			return creatorUniqueId_;
		}
		set
		{
			creatorUniqueId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CostumeId
	{
		get
		{
			return costumeId_;
		}
		set
		{
			costumeId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerTransformation()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerTransformation(ServerTransformation other)
		: this()
	{
		id_ = other.id_;
		turnCount_ = other.turnCount_;
		ownerUniqueId_ = other.ownerUniqueId_;
		creatorUniqueId_ = other.creatorUniqueId_;
		costumeId_ = other.costumeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerTransformation Clone()
	{
		return new ServerTransformation(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ServerTransformation);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ServerTransformation other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && TurnCount == other.TurnCount && OwnerUniqueId == other.OwnerUniqueId && CreatorUniqueId == other.CreatorUniqueId && CostumeId == other.CostumeId)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TurnCount != 0)
		{
			num ^= TurnCount.GetHashCode();
		}
		if (OwnerUniqueId != 0L)
		{
			num ^= OwnerUniqueId.GetHashCode();
		}
		if (CreatorUniqueId != 0L)
		{
			num ^= CreatorUniqueId.GetHashCode();
		}
		if (CostumeId != 0)
		{
			num ^= CostumeId.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (TurnCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TurnCount);
		}
		if (OwnerUniqueId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(OwnerUniqueId);
		}
		if (CreatorUniqueId != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(CreatorUniqueId);
		}
		if (CostumeId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CostumeId);
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
		if (TurnCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TurnCount);
		}
		if (OwnerUniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerUniqueId);
		}
		if (CreatorUniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CreatorUniqueId);
		}
		if (CostumeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ServerTransformation other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TurnCount != 0)
			{
				TurnCount = other.TurnCount;
			}
			if (other.OwnerUniqueId != 0L)
			{
				OwnerUniqueId = other.OwnerUniqueId;
			}
			if (other.CreatorUniqueId != 0L)
			{
				CreatorUniqueId = other.CreatorUniqueId;
			}
			if (other.CostumeId != 0)
			{
				CostumeId = other.CostumeId;
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
				TurnCount = input.ReadInt32();
				break;
			case 24u:
				OwnerUniqueId = input.ReadInt64();
				break;
			case 32u:
				CreatorUniqueId = input.ReadInt64();
				break;
			case 40u:
				CostumeId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
