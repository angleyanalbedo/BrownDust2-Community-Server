using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeEnterResponse : IMessage<EvilCastleRogueLikeEnterResponse>, IMessage, IEquatable<EvilCastleRogueLikeEnterResponse>, IDeepCloneable<EvilCastleRogueLikeEnterResponse>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeEnterResponse> _parser = new MessageParser<EvilCastleRogueLikeEnterResponse>(() => new EvilCastleRogueLikeEnterResponse());

	private UnknownFieldSet _unknownFields;

	public const int FloorInfoFieldNumber = 1;

	private static readonly FieldCodec<EvilCastleRogueLikeFloorInfo> _repeated_floorInfo_codec = FieldCodec.ForMessage(10u, EvilCastleRogueLikeFloorInfo.Parser);

	private readonly RepeatedField<EvilCastleRogueLikeFloorInfo> floorInfo_ = new RepeatedField<EvilCastleRogueLikeFloorInfo>();

	public const int ChoiceInfoFieldNumber = 2;

	private EvilCastleRogueLikeChoiceInfo choiceInfo_;

	public const int StateInfoFieldNumber = 3;

	private EvilCastleRogueLikeStateInfo stateInfo_;

	public const int RogueLikeGoldFieldNumber = 4;

	private int rogueLikeGold_;

	public const int ReRollFieldNumber = 5;

	private int reRoll_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EvilCastleRogueLikeEnterResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeEnterResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EvilCastleRogueLikeFloorInfo> FloorInfo => floorInfo_;

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
	public int ReRoll
	{
		get
		{
			return reRoll_;
		}
		set
		{
			reRoll_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeEnterResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeEnterResponse(EvilCastleRogueLikeEnterResponse other)
		: this()
	{
		floorInfo_ = other.floorInfo_.Clone();
		choiceInfo_ = ((other.choiceInfo_ != null) ? other.choiceInfo_.Clone() : null);
		stateInfo_ = ((other.stateInfo_ != null) ? other.stateInfo_.Clone() : null);
		rogueLikeGold_ = other.rogueLikeGold_;
		reRoll_ = other.reRoll_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EvilCastleRogueLikeEnterResponse Clone()
	{
		return new EvilCastleRogueLikeEnterResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeEnterResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeEnterResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (floorInfo_.Equals(other.floorInfo_) && object.Equals(ChoiceInfo, other.ChoiceInfo) && object.Equals(StateInfo, other.StateInfo) && RogueLikeGold == other.RogueLikeGold && ReRoll == other.ReRoll)
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
		num ^= floorInfo_.GetHashCode();
		if (choiceInfo_ != null)
		{
			num ^= ChoiceInfo.GetHashCode();
		}
		if (stateInfo_ != null)
		{
			num ^= StateInfo.GetHashCode();
		}
		if (RogueLikeGold != 0)
		{
			num ^= RogueLikeGold.GetHashCode();
		}
		if (ReRoll != 0)
		{
			num ^= ReRoll.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		floorInfo_.WriteTo(ref output, _repeated_floorInfo_codec);
		if (choiceInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ChoiceInfo);
		}
		if (stateInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(StateInfo);
		}
		if (RogueLikeGold != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RogueLikeGold);
		}
		if (ReRoll != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ReRoll);
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
		num += floorInfo_.CalculateSize(_repeated_floorInfo_codec);
		if (choiceInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChoiceInfo);
		}
		if (stateInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StateInfo);
		}
		if (RogueLikeGold != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RogueLikeGold);
		}
		if (ReRoll != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReRoll);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EvilCastleRogueLikeEnterResponse other)
	{
		if (other == null)
		{
			return;
		}
		floorInfo_.Add(other.floorInfo_);
		if (other.choiceInfo_ != null)
		{
			if (choiceInfo_ == null)
			{
				ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
			}
			ChoiceInfo.MergeFrom(other.ChoiceInfo);
		}
		if (other.stateInfo_ != null)
		{
			if (stateInfo_ == null)
			{
				StateInfo = new EvilCastleRogueLikeStateInfo();
			}
			StateInfo.MergeFrom(other.StateInfo);
		}
		if (other.RogueLikeGold != 0)
		{
			RogueLikeGold = other.RogueLikeGold;
		}
		if (other.ReRoll != 0)
		{
			ReRoll = other.ReRoll;
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
			case 10u:
				floorInfo_.AddEntriesFrom(ref input, _repeated_floorInfo_codec);
				break;
			case 18u:
				if (choiceInfo_ == null)
				{
					ChoiceInfo = new EvilCastleRogueLikeChoiceInfo();
				}
				input.ReadMessage(ChoiceInfo);
				break;
			case 26u:
				if (stateInfo_ == null)
				{
					StateInfo = new EvilCastleRogueLikeStateInfo();
				}
				input.ReadMessage(StateInfo);
				break;
			case 32u:
				RogueLikeGold = input.ReadInt32();
				break;
			case 40u:
				ReRoll = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
