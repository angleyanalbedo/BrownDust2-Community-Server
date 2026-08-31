using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleRetryPreviousTurnResponse : IMessage<BattleRetryPreviousTurnResponse>, IMessage, IEquatable<BattleRetryPreviousTurnResponse>, IDeepCloneable<BattleRetryPreviousTurnResponse>, IBufferMessage
{
	private static readonly MessageParser<BattleRetryPreviousTurnResponse> _parser = new MessageParser<BattleRetryPreviousTurnResponse>(() => new BattleRetryPreviousTurnResponse());

	private UnknownFieldSet _unknownFields;

	public const int BattleResultFieldNumber = 1;

	private string battleResult_ = "";

	public const int BlueTeamSkillBubbleCountFieldNumber = 2;

	private int blueTeamSkillBubbleCount_;

	public const int RedTeamSkillBubbleCountFieldNumber = 3;

	private int redTeamSkillBubbleCount_;

	public const int MonsterHuntTeamFieldNumber = 4;

	private int monsterHuntTeam_;

	public const int MonsterHuntSkillHistoryFieldNumber = 5;

	private static readonly FieldCodec<MonsterHuntSkillData> _repeated_monsterHuntSkillHistory_codec = FieldCodec.ForMessage(42u, MonsterHuntSkillData.Parser);

	private readonly RepeatedField<MonsterHuntSkillData> monsterHuntSkillHistory_ = new RepeatedField<MonsterHuntSkillData>();

	public const int MonsterHuntBeforeTeamInfoFieldNumber = 6;

	private static readonly FieldCodec<MonsterHuntTeamProtoInfo> _repeated_monsterHuntBeforeTeamInfo_codec = FieldCodec.ForMessage(50u, MonsterHuntTeamProtoInfo.Parser);

	private readonly RepeatedField<MonsterHuntTeamProtoInfo> monsterHuntBeforeTeamInfo_ = new RepeatedField<MonsterHuntTeamProtoInfo>();

	public const int TurnCountFieldNumber = 7;

	private int turnCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleRetryPreviousTurnResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleRetryPreviousTurnResponseReflection.Descriptor.MessageTypes[2];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BattleResult
	{
		get
		{
			return battleResult_;
		}
		set
		{
			battleResult_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BlueTeamSkillBubbleCount
	{
		get
		{
			return blueTeamSkillBubbleCount_;
		}
		set
		{
			blueTeamSkillBubbleCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RedTeamSkillBubbleCount
	{
		get
		{
			return redTeamSkillBubbleCount_;
		}
		set
		{
			redTeamSkillBubbleCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MonsterHuntTeam
	{
		get
		{
			return monsterHuntTeam_;
		}
		set
		{
			monsterHuntTeam_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterHuntSkillData> MonsterHuntSkillHistory => monsterHuntSkillHistory_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MonsterHuntTeamProtoInfo> MonsterHuntBeforeTeamInfo => monsterHuntBeforeTeamInfo_;

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
	public BattleRetryPreviousTurnResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRetryPreviousTurnResponse(BattleRetryPreviousTurnResponse other)
		: this()
	{
		battleResult_ = other.battleResult_;
		blueTeamSkillBubbleCount_ = other.blueTeamSkillBubbleCount_;
		redTeamSkillBubbleCount_ = other.redTeamSkillBubbleCount_;
		monsterHuntTeam_ = other.monsterHuntTeam_;
		monsterHuntSkillHistory_ = other.monsterHuntSkillHistory_.Clone();
		monsterHuntBeforeTeamInfo_ = other.monsterHuntBeforeTeamInfo_.Clone();
		turnCount_ = other.turnCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRetryPreviousTurnResponse Clone()
	{
		return new BattleRetryPreviousTurnResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as BattleRetryPreviousTurnResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BattleRetryPreviousTurnResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(BattleResult != other.BattleResult) && BlueTeamSkillBubbleCount == other.BlueTeamSkillBubbleCount && RedTeamSkillBubbleCount == other.RedTeamSkillBubbleCount && MonsterHuntTeam == other.MonsterHuntTeam && monsterHuntSkillHistory_.Equals(other.monsterHuntSkillHistory_) && monsterHuntBeforeTeamInfo_.Equals(other.monsterHuntBeforeTeamInfo_) && TurnCount == other.TurnCount)
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
		if (BattleResult.Length != 0)
		{
			num ^= BattleResult.GetHashCode();
		}
		if (BlueTeamSkillBubbleCount != 0)
		{
			num ^= BlueTeamSkillBubbleCount.GetHashCode();
		}
		if (RedTeamSkillBubbleCount != 0)
		{
			num ^= RedTeamSkillBubbleCount.GetHashCode();
		}
		if (MonsterHuntTeam != 0)
		{
			num ^= MonsterHuntTeam.GetHashCode();
		}
		num ^= monsterHuntSkillHistory_.GetHashCode();
		num ^= monsterHuntBeforeTeamInfo_.GetHashCode();
		if (TurnCount != 0)
		{
			num ^= TurnCount.GetHashCode();
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
		if (BattleResult.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BattleResult);
		}
		if (BlueTeamSkillBubbleCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BlueTeamSkillBubbleCount);
		}
		if (RedTeamSkillBubbleCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RedTeamSkillBubbleCount);
		}
		if (MonsterHuntTeam != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MonsterHuntTeam);
		}
		monsterHuntSkillHistory_.WriteTo(ref output, _repeated_monsterHuntSkillHistory_codec);
		monsterHuntBeforeTeamInfo_.WriteTo(ref output, _repeated_monsterHuntBeforeTeamInfo_codec);
		if (TurnCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TurnCount);
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
		if (BattleResult.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BattleResult);
		}
		if (BlueTeamSkillBubbleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BlueTeamSkillBubbleCount);
		}
		if (RedTeamSkillBubbleCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RedTeamSkillBubbleCount);
		}
		if (MonsterHuntTeam != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MonsterHuntTeam);
		}
		num += monsterHuntSkillHistory_.CalculateSize(_repeated_monsterHuntSkillHistory_codec);
		num += monsterHuntBeforeTeamInfo_.CalculateSize(_repeated_monsterHuntBeforeTeamInfo_codec);
		if (TurnCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TurnCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleRetryPreviousTurnResponse other)
	{
		if (other != null)
		{
			if (other.BattleResult.Length != 0)
			{
				BattleResult = other.BattleResult;
			}
			if (other.BlueTeamSkillBubbleCount != 0)
			{
				BlueTeamSkillBubbleCount = other.BlueTeamSkillBubbleCount;
			}
			if (other.RedTeamSkillBubbleCount != 0)
			{
				RedTeamSkillBubbleCount = other.RedTeamSkillBubbleCount;
			}
			if (other.MonsterHuntTeam != 0)
			{
				MonsterHuntTeam = other.MonsterHuntTeam;
			}
			monsterHuntSkillHistory_.Add(other.monsterHuntSkillHistory_);
			monsterHuntBeforeTeamInfo_.Add(other.monsterHuntBeforeTeamInfo_);
			if (other.TurnCount != 0)
			{
				TurnCount = other.TurnCount;
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
			case 10u:
				BattleResult = input.ReadString();
				break;
			case 16u:
				BlueTeamSkillBubbleCount = input.ReadInt32();
				break;
			case 24u:
				RedTeamSkillBubbleCount = input.ReadInt32();
				break;
			case 32u:
				MonsterHuntTeam = input.ReadInt32();
				break;
			case 42u:
				monsterHuntSkillHistory_.AddEntriesFrom(ref input, _repeated_monsterHuntSkillHistory_codec);
				break;
			case 50u:
				monsterHuntBeforeTeamInfo_.AddEntriesFrom(ref input, _repeated_monsterHuntBeforeTeamInfo_codec);
				break;
			case 56u:
				TurnCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
