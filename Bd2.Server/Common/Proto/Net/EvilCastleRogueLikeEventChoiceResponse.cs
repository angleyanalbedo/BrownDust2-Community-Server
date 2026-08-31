using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeEventChoiceResponse : IMessage<EvilCastleRogueLikeEventChoiceResponse>, IMessage, IEquatable<EvilCastleRogueLikeEventChoiceResponse>, IDeepCloneable<EvilCastleRogueLikeEventChoiceResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeEventChoiceResponse> _parser = new MessageParser<EvilCastleRogueLikeEventChoiceResponse>(() => new EvilCastleRogueLikeEventChoiceResponse());

	private UnknownFieldSet _unknownFields;

	public const int StateInfoFieldNumber = 1;

	private EvilCastleRogueLikeStateInfo stateInfo_;

	public const int EventResultFieldNumber = 2;

	private int eventResult_;

	public const int ClearFloorFieldNumber = 3;

	private int clearFloor_;

	public const int EventRewardInfoFieldNumber = 4;

	private EvilCastleRogueLikeEventReward eventRewardInfo_;

	public const int ClearRoomInfoFieldNumber = 5;

	private EvilCastleRogueLikeRoomInfo clearRoomInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeEventChoiceResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeEventChoiceResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventResult
	{
		get
		{
			return eventResult_;
		}
		set
		{
			eventResult_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public EvilCastleRogueLikeEventReward EventRewardInfo
	{
		get
		{
			return eventRewardInfo_;
		}
		set
		{
			eventRewardInfo_ = value;
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
	public EvilCastleRogueLikeEventChoiceResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeEventChoiceResponse(EvilCastleRogueLikeEventChoiceResponse other)
		: this()
	{
		stateInfo_ = ((other.stateInfo_ != null) ? other.stateInfo_.Clone() : null);
		eventResult_ = other.eventResult_;
		clearFloor_ = other.clearFloor_;
		eventRewardInfo_ = ((other.eventRewardInfo_ != null) ? other.eventRewardInfo_.Clone() : null);
		clearRoomInfo_ = ((other.clearRoomInfo_ != null) ? other.clearRoomInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeEventChoiceResponse Clone()
	{
		return new EvilCastleRogueLikeEventChoiceResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeEventChoiceResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeEventChoiceResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(StateInfo, other.StateInfo) && EventResult == other.EventResult && ClearFloor == other.ClearFloor && object.Equals(EventRewardInfo, other.EventRewardInfo) && object.Equals(ClearRoomInfo, other.ClearRoomInfo))
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
		if (EventResult != 0)
		{
			num ^= EventResult.GetHashCode();
		}
		if (ClearFloor != 0)
		{
			num ^= ClearFloor.GetHashCode();
		}
		if (eventRewardInfo_ != null)
		{
			num ^= EventRewardInfo.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
		if (EventResult != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventResult);
		}
		if (ClearFloor != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ClearFloor);
		}
		if (eventRewardInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(EventRewardInfo);
		}
		if (clearRoomInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ClearRoomInfo);
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
		if (stateInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StateInfo);
		}
		if (EventResult != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventResult);
		}
		if (ClearFloor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearFloor);
		}
		if (eventRewardInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EventRewardInfo);
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeEventChoiceResponse other)
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
		if (other.EventResult != 0)
		{
			EventResult = other.EventResult;
		}
		if (other.ClearFloor != 0)
		{
			ClearFloor = other.ClearFloor;
		}
		if (other.eventRewardInfo_ != null)
		{
			if (eventRewardInfo_ == null)
			{
				EventRewardInfo = new EvilCastleRogueLikeEventReward();
			}
			EventRewardInfo.MergeFrom(other.EventRewardInfo);
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 10u:
				if (stateInfo_ == null)
				{
					StateInfo = new EvilCastleRogueLikeStateInfo();
				}
				input.ReadMessage(StateInfo);
				break;
			case 16u:
				EventResult = input.ReadInt32();
				break;
			case 24u:
				ClearFloor = input.ReadInt32();
				break;
			case 34u:
				if (eventRewardInfo_ == null)
				{
					EventRewardInfo = new EvilCastleRogueLikeEventReward();
				}
				input.ReadMessage(EventRewardInfo);
				break;
			case 42u:
				if (clearRoomInfo_ == null)
				{
					ClearRoomInfo = new EvilCastleRogueLikeRoomInfo();
				}
				input.ReadMessage(ClearRoomInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
