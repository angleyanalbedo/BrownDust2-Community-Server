using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeMoveFloorResponse : IMessage<EvilCastleRogueLikeMoveFloorResponse>, IMessage, IEquatable<EvilCastleRogueLikeMoveFloorResponse>, IDeepCloneable<EvilCastleRogueLikeMoveFloorResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeMoveFloorResponse> _parser = new MessageParser<EvilCastleRogueLikeMoveFloorResponse>(() => new EvilCastleRogueLikeMoveFloorResponse());

	private UnknownFieldSet _unknownFields;

	public const int StateInfoFieldNumber = 1;

	private EvilCastleRogueLikeStateInfo stateInfo_;

	public const int ClearFloorFieldNumber = 2;

	private int clearFloor_;

	public const int ClearRoomInfoFieldNumber = 3;

	private EvilCastleRogueLikeRoomInfo clearRoomInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeMoveFloorResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeMoveFloorResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeStateInfo StateInfo
	{
		get
		{
			return stateInfo_;
		}
		set
		{
			stateInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ClearFloor
	{
		get
		{
			return clearFloor_;
		}
		set
		{
			clearFloor_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeRoomInfo ClearRoomInfo
	{
		get
		{
			return clearRoomInfo_;
		}
		set
		{
			clearRoomInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeMoveFloorResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeMoveFloorResponse(EvilCastleRogueLikeMoveFloorResponse other)
		: this()
	{
		stateInfo_ = ((other.stateInfo_ != null) ? other.stateInfo_.Clone() : null);
		clearFloor_ = other.clearFloor_;
		clearRoomInfo_ = ((other.clearRoomInfo_ != null) ? other.clearRoomInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeMoveFloorResponse Clone()
	{
		return new EvilCastleRogueLikeMoveFloorResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeMoveFloorResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeMoveFloorResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(StateInfo, other.StateInfo) && ClearFloor == other.ClearFloor && object.Equals(ClearRoomInfo, other.ClearRoomInfo))
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
		if (stateInfo_ != null)
		{
			num ^= StateInfo.GetHashCode();
		}
		if (ClearFloor != 0)
		{
			num ^= ClearFloor.GetHashCode();
		}
		if (clearRoomInfo_ != null)
		{
			num ^= ClearRoomInfo.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (stateInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(StateInfo);
		}
		if (ClearFloor != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ClearFloor);
		}
		if (clearRoomInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ClearRoomInfo);
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
		if (stateInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StateInfo);
		}
		if (ClearFloor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearFloor);
		}
		if (clearRoomInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ClearRoomInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeMoveFloorResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.stateInfo_ != null)
		{
			if (stateInfo_ == null)
			{
				StateInfo = new EvilCastleRogueLikeStateInfo();
			}
			StateInfo.MergeFrom(other.StateInfo);
		}
		if (other.ClearFloor != 0)
		{
			ClearFloor = other.ClearFloor;
		}
		if (other.clearRoomInfo_ != null)
		{
			if (clearRoomInfo_ == null)
			{
				ClearRoomInfo = new EvilCastleRogueLikeRoomInfo();
			}
			ClearRoomInfo.MergeFrom(other.ClearRoomInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 26u:
				if (clearRoomInfo_ == null)
				{
					ClearRoomInfo = new EvilCastleRogueLikeRoomInfo();
				}
				input.ReadMessage(ClearRoomInfo);
				break;
			case 16u:
				ClearFloor = input.ReadInt32();
				break;
			case 10u:
				if (stateInfo_ == null)
				{
					StateInfo = new EvilCastleRogueLikeStateInfo();
				}
				input.ReadMessage(StateInfo);
				break;
			}
		}
	}
}
