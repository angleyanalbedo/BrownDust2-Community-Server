using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidSupporterDeckDBInfo : IMessage<GuildRaidSupporterDeckDBInfo>, IMessage, IEquatable<GuildRaidSupporterDeckDBInfo>, IDeepCloneable<GuildRaidSupporterDeckDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidSupporterDeckDBInfo> _parser = new MessageParser<GuildRaidSupporterDeckDBInfo>(() => new GuildRaidSupporterDeckDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int OwnerIndexFieldNumber = 1;

	private long ownerIndex_;

	public const int SlotIndexFieldNumber = 2;

	private int slotIndex_;

	public const int PositionFieldNumber = 3;

	private int position_;

	public const int SequenceFieldNumber = 4;

	private int sequence_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildRaidSupporterDeckDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidSupporterDeckDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OwnerIndex
	{
		get
		{
			return ownerIndex_;
		}
		set
		{
			ownerIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SlotIndex
	{
		get
		{
			return slotIndex_;
		}
		set
		{
			slotIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Sequence
	{
		get
		{
			return sequence_;
		}
		set
		{
			sequence_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidSupporterDeckDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidSupporterDeckDBInfo(GuildRaidSupporterDeckDBInfo other)
		: this()
	{
		ownerIndex_ = other.ownerIndex_;
		slotIndex_ = other.slotIndex_;
		position_ = other.position_;
		sequence_ = other.sequence_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidSupporterDeckDBInfo Clone()
	{
		return new GuildRaidSupporterDeckDBInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidSupporterDeckDBInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildRaidSupporterDeckDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OwnerIndex == other.OwnerIndex && SlotIndex == other.SlotIndex && Position == other.Position && Sequence == other.Sequence)
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
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (SlotIndex != 0)
		{
			num ^= SlotIndex.GetHashCode();
		}
		if (Position != 0)
		{
			num ^= Position.GetHashCode();
		}
		if (Sequence != 0)
		{
			num ^= Sequence.GetHashCode();
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
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(OwnerIndex);
		}
		if (SlotIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SlotIndex);
		}
		if (Position != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Position);
		}
		if (Sequence != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Sequence);
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
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (SlotIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SlotIndex);
		}
		if (Position != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Position);
		}
		if (Sequence != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Sequence);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRaidSupporterDeckDBInfo other)
	{
		if (other != null)
		{
			if (other.OwnerIndex != 0L)
			{
				OwnerIndex = other.OwnerIndex;
			}
			if (other.SlotIndex != 0)
			{
				SlotIndex = other.SlotIndex;
			}
			if (other.Position != 0)
			{
				Position = other.Position;
			}
			if (other.Sequence != 0)
			{
				Sequence = other.Sequence;
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
				OwnerIndex = input.ReadInt64();
				break;
			case 16u:
				SlotIndex = input.ReadInt32();
				break;
			case 24u:
				Position = input.ReadInt32();
				break;
			case 32u:
				Sequence = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
