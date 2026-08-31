using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ServerEnergyGuard : IMessage<ServerEnergyGuard>, IMessage, IEquatable<ServerEnergyGuard>, IDeepCloneable<ServerEnergyGuard>, IBufferMessage
{
	private static readonly MessageParser<ServerEnergyGuard> _parser = new MessageParser<ServerEnergyGuard>(() => new ServerEnergyGuard());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int TurnCountFieldNumber = 2;

	private int turnCount_;

	public const int RemainEnergyFieldNumber = 3;

	private long remainEnergy_;

	public const int OwnerUniqueIdFieldNumber = 4;

	private long ownerUniqueId_;

	public const int CreatorUniqueIdFieldNumber = 5;

	private long creatorUniqueId_;

	public const int MaxRemainEnergyFieldNumber = 6;

	private long maxRemainEnergy_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerEnergyGuard> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BuffListInfoReflection.Descriptor.MessageTypes[6];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public long RemainEnergy
	{
		get
		{
			return remainEnergy_;
		}
		set
		{
			remainEnergy_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public long MaxRemainEnergy
	{
		get
		{
			return maxRemainEnergy_;
		}
		set
		{
			maxRemainEnergy_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerEnergyGuard()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerEnergyGuard(ServerEnergyGuard other)
		: this()
	{
		id_ = other.id_;
		turnCount_ = other.turnCount_;
		remainEnergy_ = other.remainEnergy_;
		ownerUniqueId_ = other.ownerUniqueId_;
		creatorUniqueId_ = other.creatorUniqueId_;
		maxRemainEnergy_ = other.maxRemainEnergy_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerEnergyGuard Clone()
	{
		return new ServerEnergyGuard(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ServerEnergyGuard);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerEnergyGuard other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && TurnCount == other.TurnCount && RemainEnergy == other.RemainEnergy && OwnerUniqueId == other.OwnerUniqueId && CreatorUniqueId == other.CreatorUniqueId && MaxRemainEnergy == other.MaxRemainEnergy)
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
		if (RemainEnergy != 0L)
		{
			num ^= RemainEnergy.GetHashCode();
		}
		if (OwnerUniqueId != 0L)
		{
			num ^= OwnerUniqueId.GetHashCode();
		}
		if (CreatorUniqueId != 0L)
		{
			num ^= CreatorUniqueId.GetHashCode();
		}
		if (MaxRemainEnergy != 0L)
		{
			num ^= MaxRemainEnergy.GetHashCode();
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
		if (RemainEnergy != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(RemainEnergy);
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
		if (MaxRemainEnergy != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(MaxRemainEnergy);
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
		if (RemainEnergy != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(RemainEnergy);
		}
		if (OwnerUniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerUniqueId);
		}
		if (CreatorUniqueId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CreatorUniqueId);
		}
		if (MaxRemainEnergy != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(MaxRemainEnergy);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ServerEnergyGuard other)
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
			if (other.RemainEnergy != 0L)
			{
				RemainEnergy = other.RemainEnergy;
			}
			if (other.OwnerUniqueId != 0L)
			{
				OwnerUniqueId = other.OwnerUniqueId;
			}
			if (other.CreatorUniqueId != 0L)
			{
				CreatorUniqueId = other.CreatorUniqueId;
			}
			if (other.MaxRemainEnergy != 0L)
			{
				MaxRemainEnergy = other.MaxRemainEnergy;
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
				RemainEnergy = input.ReadInt64();
				break;
			case 32u:
				OwnerUniqueId = input.ReadInt64();
				break;
			case 40u:
				CreatorUniqueId = input.ReadInt64();
				break;
			case 48u:
				MaxRemainEnergy = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
