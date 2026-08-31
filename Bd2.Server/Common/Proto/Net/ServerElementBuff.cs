using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ServerElementBuff : IMessage<ServerElementBuff>, IMessage, IEquatable<ServerElementBuff>, IDeepCloneable<ServerElementBuff>, IBufferMessage
{
	private static readonly MessageParser<ServerElementBuff> _parser = new MessageParser<ServerElementBuff>(() => new ServerElementBuff());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int TurnCountFieldNumber = 2;

	private int turnCount_;

	public const int OwnerUniqueIdFieldNumber = 3;

	private long ownerUniqueId_;

	public const int CreatorUniqueIdFieldNumber = 4;

	private long creatorUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerElementBuff> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuffListInfoReflection.Descriptor.MessageTypes[4];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public ServerElementBuff()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerElementBuff(ServerElementBuff other)
		: this()
	{
		id_ = other.id_;
		turnCount_ = other.turnCount_;
		ownerUniqueId_ = other.ownerUniqueId_;
		creatorUniqueId_ = other.creatorUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerElementBuff Clone()
	{
		return new ServerElementBuff(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ServerElementBuff);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerElementBuff other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && TurnCount == other.TurnCount && OwnerUniqueId == other.OwnerUniqueId && CreatorUniqueId == other.CreatorUniqueId)
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ServerElementBuff other)
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
