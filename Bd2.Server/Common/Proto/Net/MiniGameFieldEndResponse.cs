using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameFieldEndResponse : IMessage<MiniGameFieldEndResponse>, IMessage, IEquatable<MiniGameFieldEndResponse>, IDeepCloneable<MiniGameFieldEndResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameFieldEndResponse> _parser = new MessageParser<MiniGameFieldEndResponse>(() => new MiniGameFieldEndResponse());

	private UnknownFieldSet _unknownFields;

	public const int EventScheduleIdFieldNumber = 1;

	private int eventScheduleId_;

	public const int ScoreFieldNumber = 2;

	private int score_;

	public const int HighestScoreFieldNumber = 3;

	private int highestScore_;

	public const int LastRewardPointFieldNumber = 4;

	private int lastRewardPoint_;

	public const int RewardInfoBundleFieldNumber = 5;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int IsPossibleQuickRewardFieldNumber = 6;

	private bool isPossibleQuickReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameFieldEndResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameFieldEndResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventScheduleId
	{
		get
		{
			return eventScheduleId_;
		}
		set
		{
			eventScheduleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Score
	{
		get
		{
			return score_;
		}
		set
		{
			score_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HighestScore
	{
		get
		{
			return highestScore_;
		}
		set
		{
			highestScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastRewardPoint
	{
		get
		{
			return lastRewardPoint_;
		}
		set
		{
			lastRewardPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle RewardInfoBundle
	{
		get
		{
			return rewardInfoBundle_;
		}
		set
		{
			rewardInfoBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsPossibleQuickReward
	{
		get
		{
			return isPossibleQuickReward_;
		}
		set
		{
			isPossibleQuickReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameFieldEndResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameFieldEndResponse(MiniGameFieldEndResponse other)
		: this()
	{
		eventScheduleId_ = other.eventScheduleId_;
		score_ = other.score_;
		highestScore_ = other.highestScore_;
		lastRewardPoint_ = other.lastRewardPoint_;
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		isPossibleQuickReward_ = other.isPossibleQuickReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameFieldEndResponse Clone()
	{
		return new MiniGameFieldEndResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameFieldEndResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MiniGameFieldEndResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (EventScheduleId == other.EventScheduleId && Score == other.Score && HighestScore == other.HighestScore && LastRewardPoint == other.LastRewardPoint && object.Equals(RewardInfoBundle, other.RewardInfoBundle) && IsPossibleQuickReward == other.IsPossibleQuickReward)
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
		if (EventScheduleId != 0)
		{
			num ^= EventScheduleId.GetHashCode();
		}
		if (Score != 0)
		{
			num ^= Score.GetHashCode();
		}
		if (HighestScore != 0)
		{
			num ^= HighestScore.GetHashCode();
		}
		if (LastRewardPoint != 0)
		{
			num ^= LastRewardPoint.GetHashCode();
		}
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		if (IsPossibleQuickReward)
		{
			num ^= IsPossibleQuickReward.GetHashCode();
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
		if (EventScheduleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventScheduleId);
		}
		if (Score != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Score);
		}
		if (HighestScore != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(HighestScore);
		}
		if (LastRewardPoint != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LastRewardPoint);
		}
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(RewardInfoBundle);
		}
		if (IsPossibleQuickReward)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsPossibleQuickReward);
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
		if (EventScheduleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventScheduleId);
		}
		if (Score != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Score);
		}
		if (HighestScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HighestScore);
		}
		if (LastRewardPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastRewardPoint);
		}
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (IsPossibleQuickReward)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameFieldEndResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EventScheduleId != 0)
		{
			EventScheduleId = other.EventScheduleId;
		}
		if (other.Score != 0)
		{
			Score = other.Score;
		}
		if (other.HighestScore != 0)
		{
			HighestScore = other.HighestScore;
		}
		if (other.LastRewardPoint != 0)
		{
			LastRewardPoint = other.LastRewardPoint;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		if (other.IsPossibleQuickReward)
		{
			IsPossibleQuickReward = other.IsPossibleQuickReward;
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
			case 8u:
				EventScheduleId = input.ReadInt32();
				break;
			case 16u:
				Score = input.ReadInt32();
				break;
			case 24u:
				HighestScore = input.ReadInt32();
				break;
			case 32u:
				LastRewardPoint = input.ReadInt32();
				break;
			case 42u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 48u:
				IsPossibleQuickReward = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
