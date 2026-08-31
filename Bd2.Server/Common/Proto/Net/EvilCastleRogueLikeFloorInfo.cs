using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeFloorInfo : IMessage<EvilCastleRogueLikeFloorInfo>, IMessage, IEquatable<EvilCastleRogueLikeFloorInfo>, IDeepCloneable<EvilCastleRogueLikeFloorInfo>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeFloorInfo> _parser = new MessageParser<EvilCastleRogueLikeFloorInfo>(() => new EvilCastleRogueLikeFloorInfo());

	private UnknownFieldSet _unknownFields;

	public const int NumberFieldNumber = 1;

	private int number_;

	public const int RoomInfoFieldNumber = 2;

	private static readonly FieldCodec<EvilCastleRogueLikeRoomInfo> _repeated_roomInfo_codec = FieldCodec.ForMessage(18u, EvilCastleRogueLikeRoomInfo.Parser);

	private readonly RepeatedField<EvilCastleRogueLikeRoomInfo> roomInfo_ = new RepeatedField<EvilCastleRogueLikeRoomInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeFloorInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeFloorInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Number
	{
		get
		{
			return number_;
		}
		set
		{
			number_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EvilCastleRogueLikeRoomInfo> RoomInfo => roomInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeFloorInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeFloorInfo(EvilCastleRogueLikeFloorInfo other)
		: this()
	{
		number_ = other.number_;
		roomInfo_ = other.roomInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeFloorInfo Clone()
	{
		return new EvilCastleRogueLikeFloorInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeFloorInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeFloorInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Number == other.Number && roomInfo_.Equals(other.roomInfo_))
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
		if (Number != 0)
		{
			num ^= Number.GetHashCode();
		}
		num ^= roomInfo_.GetHashCode();
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
		if (Number != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Number);
		}
		roomInfo_.WriteTo(ref output, _repeated_roomInfo_codec);
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
		if (Number != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Number);
		}
		num += roomInfo_.CalculateSize(_repeated_roomInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeFloorInfo other)
	{
		if (other != null)
		{
			if (other.Number != 0)
			{
				Number = other.Number;
			}
			roomInfo_.Add(other.roomInfo_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				roomInfo_.AddEntriesFrom(ref input, _repeated_roomInfo_codec);
				break;
			case 8u:
				Number = input.ReadInt32();
				break;
			}
		}
	}
}
