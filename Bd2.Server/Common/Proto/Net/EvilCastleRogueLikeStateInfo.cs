using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeStateInfo : IMessage<EvilCastleRogueLikeStateInfo>, IMessage, IEquatable<EvilCastleRogueLikeStateInfo>, IDeepCloneable<EvilCastleRogueLikeStateInfo>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeStateInfo> _parser = new MessageParser<EvilCastleRogueLikeStateInfo>(() => new EvilCastleRogueLikeStateInfo());

	private UnknownFieldSet _unknownFields;

	public const int FloorFieldNumber = 1;

	private int floor_;

	public const int RoomFieldNumber = 2;

	private int room_;

	public const int StateFieldNumber = 3;

	private int state_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeStateInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeStateInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Floor
	{
		get
		{
			return floor_;
		}
		set
		{
			floor_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Room
	{
		get
		{
			return room_;
		}
		set
		{
			room_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeStateInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeStateInfo(EvilCastleRogueLikeStateInfo other)
		: this()
	{
		floor_ = other.floor_;
		room_ = other.room_;
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeStateInfo Clone()
	{
		return new EvilCastleRogueLikeStateInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeStateInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeStateInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Floor == other.Floor && Room == other.Room && State == other.State)
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
		if (Floor != 0)
		{
			num ^= Floor.GetHashCode();
		}
		if (Room != 0)
		{
			num ^= Room.GetHashCode();
		}
		if (State != 0)
		{
			num ^= State.GetHashCode();
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
		if (Floor != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Floor);
		}
		if (Room != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Room);
		}
		if (State != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(State);
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
		if (Floor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Floor);
		}
		if (Room != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Room);
		}
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeStateInfo other)
	{
		if (other != null)
		{
			if (other.Floor != 0)
			{
				Floor = other.Floor;
			}
			if (other.Room != 0)
			{
				Room = other.Room;
			}
			if (other.State != 0)
			{
				State = other.State;
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
				State = input.ReadInt32();
				break;
			case 16u:
				Room = input.ReadInt32();
				break;
			case 8u:
				Floor = input.ReadInt32();
				break;
			}
		}
	}
}
