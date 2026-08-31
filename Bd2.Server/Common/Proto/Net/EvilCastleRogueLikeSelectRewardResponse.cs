using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeSelectRewardResponse : IMessage<EvilCastleRogueLikeSelectRewardResponse>, IMessage, IEquatable<EvilCastleRogueLikeSelectRewardResponse>, IDeepCloneable<EvilCastleRogueLikeSelectRewardResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeSelectRewardResponse> _parser = new MessageParser<EvilCastleRogueLikeSelectRewardResponse>(() => new EvilCastleRogueLikeSelectRewardResponse());

	private UnknownFieldSet _unknownFields;

	public const int StateInfoFieldNumber = 1;

	private EvilCastleRogueLikeStateInfo stateInfo_;

	public const int ChoiceInfoFieldNumber = 2;

	private EvilCastleRogueLikeChoiceInfo choiceInfo_;

	public const int CharInfoFieldNumber = 3;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(26u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int CostumeInfoFieldNumber = 4;

	private CostumeDBInfo costumeInfo_;

	public const int RelicInfoFieldNumber = 5;

	private RelicDBInfo relicInfo_;

	public const int ClearFloorFieldNumber = 6;

	private int clearFloor_;

	public const int ClearRoomInfoFieldNumber = 7;

	private EvilCastleRogueLikeRoomInfo clearRoomInfo_;

	public const int RogueLikeGoldFieldNumber = 8;

	private int rogueLikeGold_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeSelectRewardResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeSelectRewardResponseReflection.Descriptor.MessageTypes[0];

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CostumeDBInfo CostumeInfo
	{
		get
		{
			return costumeInfo_;
		}
		set
		{
			costumeInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicDBInfo RelicInfo
	{
		get
		{
			return relicInfo_;
		}
		set
		{
			relicInfo_ = value;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeSelectRewardResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeSelectRewardResponse(EvilCastleRogueLikeSelectRewardResponse other)
		: this()
	{
		stateInfo_ = ((other.stateInfo_ != null) ? other.stateInfo_.Clone() : null);
		choiceInfo_ = ((other.choiceInfo_ != null) ? other.choiceInfo_.Clone() : null);
		charInfo_ = other.charInfo_.Clone();
		costumeInfo_ = ((other.costumeInfo_ != null) ? other.costumeInfo_.Clone() : null);
		relicInfo_ = ((other.relicInfo_ != null) ? other.relicInfo_.Clone() : null);
		clearFloor_ = other.clearFloor_;
		clearRoomInfo_ = ((other.clearRoomInfo_ != null) ? other.clearRoomInfo_.Clone() : null);
		rogueLikeGold_ = other.rogueLikeGold_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeSelectRewardResponse Clone()
	{
		return new EvilCastleRogueLikeSelectRewardResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeSelectRewardResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeSelectRewardResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(StateInfo, other.StateInfo) && object.Equals(ChoiceInfo, other.ChoiceInfo) && charInfo_.Equals(other.charInfo_) && object.Equals(CostumeInfo, other.CostumeInfo) && object.Equals(RelicInfo, other.RelicInfo) && ClearFloor == other.ClearFloor && object.Equals(ClearRoomInfo, other.ClearRoomInfo) && RogueLikeGold == other.RogueLikeGold)
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
		if (choiceInfo_ != null)
		{
			num ^= ChoiceInfo.GetHashCode();
		}
		num ^= charInfo_.GetHashCode();
		if (costumeInfo_ != null)
		{
			num ^= CostumeInfo.GetHashCode();
		}
		if (relicInfo_ != null)
		{
			num ^= RelicInfo.GetHashCode();
		}
		if (ClearFloor != 0)
		{
			num ^= ClearFloor.GetHashCode();
		}
		if (clearRoomInfo_ != null)
		{
			num ^= ClearRoomInfo.GetHashCode();
		}
		if (RogueLikeGold != 0)
		{
			num ^= RogueLikeGold.GetHashCode();
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
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		if (costumeInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CostumeInfo);
		}
		if (relicInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(RelicInfo);
		}
		if (ClearFloor != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ClearFloor);
		}
		if (clearRoomInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ClearRoomInfo);
		}
		if (RogueLikeGold != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(RogueLikeGold);
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
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		if (costumeInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostumeInfo);
		}
		if (relicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RelicInfo);
		}
		if (ClearFloor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClearFloor);
		}
		if (clearRoomInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ClearRoomInfo);
		}
		if (RogueLikeGold != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RogueLikeGold);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeSelectRewardResponse other)
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
		charInfo_.Add(other.charInfo_);
		if (other.costumeInfo_ != null)
		{
			if (costumeInfo_ == null)
			{
				CostumeInfo = new CostumeDBInfo();
			}
			CostumeInfo.MergeFrom(other.CostumeInfo);
		}
		if (other.relicInfo_ != null)
		{
			if (relicInfo_ == null)
			{
				RelicInfo = new RelicDBInfo();
			}
			RelicInfo.MergeFrom(other.RelicInfo);
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
		if (other.RogueLikeGold != 0)
		{
			RogueLikeGold = other.RogueLikeGold;
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
			case 18u:
				if (choiceInfo_ == null)
				{
					ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
				}
				input.ReadMessage(ChoiceInfo);
				break;
			case 26u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 34u:
				if (costumeInfo_ == null)
				{
					CostumeInfo = new CostumeDBInfo();
				}
				input.ReadMessage(CostumeInfo);
				break;
			case 42u:
				if (relicInfo_ == null)
				{
					RelicInfo = new RelicDBInfo();
				}
				input.ReadMessage(RelicInfo);
				break;
			case 48u:
				ClearFloor = input.ReadInt32();
				break;
			case 58u:
				if (clearRoomInfo_ == null)
				{
					ClearRoomInfo = new EvilCastleRogueLikeRoomInfo();
				}
				input.ReadMessage(ClearRoomInfo);
				break;
			case 64u:
				RogueLikeGold = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
