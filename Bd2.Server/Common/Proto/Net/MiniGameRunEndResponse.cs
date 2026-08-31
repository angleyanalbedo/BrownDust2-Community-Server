using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MiniGameRunEndResponse : IMessage<MiniGameRunEndResponse>, IMessage, IEquatable<MiniGameRunEndResponse>, IDeepCloneable<MiniGameRunEndResponse>, IBufferMessage
{
	private static readonly MessageParser<MiniGameRunEndResponse> _parser = new MessageParser<MiniGameRunEndResponse>(() => new MiniGameRunEndResponse());

	private UnknownFieldSet _unknownFields;

	public const int BestRecordValueFieldNumber = 1;

	private int bestRecordValue_;

	public const int LastRewardPointFieldNumber = 2;

	private int lastRewardPoint_;

	public const int RewardInfoBundleFieldNumber = 3;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int IsPossibleQuickRewardFieldNumber = 4;

	private bool isPossibleQuickReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MiniGameRunEndResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MiniGameRunEndResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BestRecordValue
	{
		get
		{
			return bestRecordValue_;
		}
		set
		{
			bestRecordValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameRunEndResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameRunEndResponse(MiniGameRunEndResponse other)
		: this()
	{
		bestRecordValue_ = other.bestRecordValue_;
		lastRewardPoint_ = other.lastRewardPoint_;
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		isPossibleQuickReward_ = other.isPossibleQuickReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameRunEndResponse Clone()
	{
		return new MiniGameRunEndResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameRunEndResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameRunEndResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BestRecordValue == other.BestRecordValue && LastRewardPoint == other.LastRewardPoint && object.Equals(RewardInfoBundle, other.RewardInfoBundle) && IsPossibleQuickReward == other.IsPossibleQuickReward)
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
		if (BestRecordValue != 0)
		{
			num ^= BestRecordValue.GetHashCode();
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
		if (BestRecordValue != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BestRecordValue);
		}
		if (LastRewardPoint != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LastRewardPoint);
		}
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RewardInfoBundle);
		}
		if (IsPossibleQuickReward)
		{
			output.WriteRawTag(32);
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
		if (BestRecordValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BestRecordValue);
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
	public void MergeFrom(MiniGameRunEndResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BestRecordValue != 0)
		{
			BestRecordValue = other.BestRecordValue;
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
				BestRecordValue = input.ReadInt32();
				break;
			case 16u:
				LastRewardPoint = input.ReadInt32();
				break;
			case 26u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 32u:
				IsPossibleQuickReward = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
