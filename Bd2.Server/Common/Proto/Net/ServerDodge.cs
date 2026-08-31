using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ServerDodge : IMessage<ServerDodge>, IMessage, IEquatable<ServerDodge>, IDeepCloneable<ServerDodge>, IBufferMessage
{
	private static readonly MessageParser<ServerDodge> _parser = new MessageParser<ServerDodge>(() => new ServerDodge());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int TurnCountFieldNumber = 2;

	private int turnCount_;

	public const int SuccessCountFieldNumber = 3;

	private int successCount_;

	public const int OwnerUniqueIdFieldNumber = 4;

	private long ownerUniqueId_;

	public const int CreatorUniqueIdFieldNumber = 5;

	private long creatorUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerDodge> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuffListInfoReflection.Descriptor.MessageTypes[1];

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
	public int SuccessCount
	{
		get
		{
			return successCount_;
		}
		set
		{
			successCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public ServerDodge()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerDodge(ServerDodge other)
		: this()
	{
		id_ = other.id_;
		turnCount_ = other.turnCount_;
		successCount_ = other.successCount_;
		ownerUniqueId_ = other.ownerUniqueId_;
		creatorUniqueId_ = other.creatorUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerDodge Clone()
	{
		return new ServerDodge(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ServerDodge);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerDodge other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && TurnCount == other.TurnCount && SuccessCount == other.SuccessCount && OwnerUniqueId == other.OwnerUniqueId && CreatorUniqueId == other.CreatorUniqueId)
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
		if (TurnCount != 0)
		{
			num ^= TurnCount.GetHashCode();
		}
		if (SuccessCount != 0)
		{
			num ^= SuccessCount.GetHashCode();
		}
		if (OwnerUniqueId != 0L)
		{
			num ^= OwnerUniqueId.GetHashCode();
		}
		if (CreatorUniqueId != 0L)
		{
			num ^= CreatorUniqueId.GetHashCode();
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
		if (SuccessCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SuccessCount);
		}
		if (OwnerUniqueId != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(OwnerUniqueId);
		}
		if (CreatorUniqueId != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(CreatorUniqueId);
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
		if (SuccessCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuccessCount);
		}
		if (OwnerUniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerUniqueId);
		}
		if (CreatorUniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CreatorUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ServerDodge other)
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
			if (other.SuccessCount != 0)
			{
				SuccessCount = other.SuccessCount;
			}
			if (other.OwnerUniqueId != 0L)
			{
				OwnerUniqueId = other.OwnerUniqueId;
			}
			if (other.CreatorUniqueId != 0L)
			{
				CreatorUniqueId = other.CreatorUniqueId;
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
				SuccessCount = input.ReadInt32();
				break;
			case 32u:
				OwnerUniqueId = input.ReadInt64();
				break;
			case 40u:
				CreatorUniqueId = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
