using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeRoomEnterResponse : IMessage<EvilCastleRogueLikeRoomEnterResponse>, IMessage, IEquatable<EvilCastleRogueLikeRoomEnterResponse>, IDeepCloneable<EvilCastleRogueLikeRoomEnterResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeRoomEnterResponse> _parser = new MessageParser<EvilCastleRogueLikeRoomEnterResponse>(() => new EvilCastleRogueLikeRoomEnterResponse());

	private UnknownFieldSet _unknownFields;

	public const int StateInfoFieldNumber = 1;

	private EvilCastleRogueLikeStateInfo stateInfo_;

	public const int ChoiceInfoFieldNumber = 2;

	private EvilCastleRogueLikeChoiceInfo choiceInfo_;

	public const int EventInfoFieldNumber = 3;

	private EvilCastleRogueLikeEventInfo eventInfo_;

	public const int ShopInfoFieldNumber = 4;

	private EvilCastleRogueLikeShopDBInfo shopInfo_;

	public const int BattleLevelFieldNumber = 5;

	private int battleLevel_;

	public const int RogueLikeGoldFieldNumber = 6;

	private int rogueLikeGold_;

	public const int ClearFloorFieldNumber = 7;

	private int clearFloor_;

	public const int ClearRoomInfoFieldNumber = 8;

	private EvilCastleRogueLikeRoomInfo clearRoomInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeRoomEnterResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeRoomEnterResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public EvilCastleRogueLikeChoiceInfo ChoiceInfo
	{
		get
		{
			return choiceInfo_;
		}
		set
		{
			choiceInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeEventInfo EventInfo
	{
		get
		{
			return eventInfo_;
		}
		set
		{
			eventInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeShopDBInfo ShopInfo
	{
		get
		{
			return shopInfo_;
		}
		set
		{
			shopInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleLevel
	{
		get
		{
			return battleLevel_;
		}
		set
		{
			battleLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RogueLikeGold
	{
		get
		{
			return rogueLikeGold_;
		}
		set
		{
			rogueLikeGold_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeRoomEnterResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeRoomEnterResponse(EvilCastleRogueLikeRoomEnterResponse other)
		: this()
	{
		stateInfo_ = ((other.stateInfo_ != null) ? other.stateInfo_.Clone() : null);
		choiceInfo_ = ((other.choiceInfo_ != null) ? other.choiceInfo_.Clone() : null);
		eventInfo_ = ((other.eventInfo_ != null) ? other.eventInfo_.Clone() : null);
		shopInfo_ = ((other.shopInfo_ != null) ? other.shopInfo_.Clone() : null);
		battleLevel_ = other.battleLevel_;
		rogueLikeGold_ = other.rogueLikeGold_;
		clearFloor_ = other.clearFloor_;
		clearRoomInfo_ = ((other.clearRoomInfo_ != null) ? other.clearRoomInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeRoomEnterResponse Clone()
	{
		return new EvilCastleRogueLikeRoomEnterResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeRoomEnterResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeRoomEnterResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(StateInfo, other.StateInfo) && object.Equals(ChoiceInfo, other.ChoiceInfo) && object.Equals(EventInfo, other.EventInfo) && object.Equals(ShopInfo, other.ShopInfo) && BattleLevel == other.BattleLevel && RogueLikeGold == other.RogueLikeGold && ClearFloor == other.ClearFloor && object.Equals(ClearRoomInfo, other.ClearRoomInfo))
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
		if (stateInfo_ != null)
		{
			num ^= StateInfo.GetHashCode();
		}
		if (choiceInfo_ != null)
		{
			num ^= ChoiceInfo.GetHashCode();
		}
		if (eventInfo_ != null)
		{
			num ^= EventInfo.GetHashCode();
		}
		if (shopInfo_ != null)
		{
			num ^= ShopInfo.GetHashCode();
		}
		if (BattleLevel != 0)
		{
			num ^= BattleLevel.GetHashCode();
		}
		if (RogueLikeGold != 0)
		{
			num ^= RogueLikeGold.GetHashCode();
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
		if (stateInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(StateInfo);
		}
		if (choiceInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ChoiceInfo);
		}
		if (eventInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EventInfo);
		}
		if (shopInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ShopInfo);
		}
		if (BattleLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BattleLevel);
		}
		if (RogueLikeGold != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RogueLikeGold);
		}
		if (ClearFloor != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ClearFloor);
		}
		if (clearRoomInfo_ != null)
		{
			output.WriteRawTag(66);
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
		if (choiceInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChoiceInfo);
		}
		if (eventInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EventInfo);
		}
		if (shopInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShopInfo);
		}
		if (BattleLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleLevel);
		}
		if (RogueLikeGold != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RogueLikeGold);
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeRoomEnterResponse other)
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
		if (other.choiceInfo_ != null)
		{
			if (choiceInfo_ == null)
			{
				ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
			}
			ChoiceInfo.MergeFrom(other.ChoiceInfo);
		}
		if (other.eventInfo_ != null)
		{
			if (eventInfo_ == null)
			{
				EventInfo = new EvilCastleRogueLikeEventInfo();
			}
			EventInfo.MergeFrom(other.EventInfo);
		}
		if (other.shopInfo_ != null)
		{
			if (shopInfo_ == null)
			{
				ShopInfo = new EvilCastleRogueLikeShopDBInfo();
			}
			ShopInfo.MergeFrom(other.ShopInfo);
		}
		if (other.BattleLevel != 0)
		{
			BattleLevel = other.BattleLevel;
		}
		if (other.RogueLikeGold != 0)
		{
			RogueLikeGold = other.RogueLikeGold;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
			case 10u:
				if (stateInfo_ == null)
				{
					StateInfo = new EvilCastleRogueLikeStateInfo();
				}
				input.ReadMessage(StateInfo);
				break;
			case 18u:
				if (choiceInfo_ == null)
				{
					ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
				}
				input.ReadMessage(ChoiceInfo);
				break;
			case 26u:
				if (eventInfo_ == null)
				{
					EventInfo = new EvilCastleRogueLikeEventInfo();
				}
				input.ReadMessage(EventInfo);
				break;
			case 34u:
				if (shopInfo_ == null)
				{
					ShopInfo = new EvilCastleRogueLikeShopDBInfo();
				}
				input.ReadMessage(ShopInfo);
				break;
			case 40u:
				BattleLevel = input.ReadInt32();
				break;
			case 48u:
				RogueLikeGold = input.ReadInt32();
				break;
			case 56u:
				ClearFloor = input.ReadInt32();
				break;
			case 66u:
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
