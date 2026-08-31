using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidSeasonRewardResponse : IMessage<GuildRaidSeasonRewardResponse>, IMessage, IEquatable<GuildRaidSeasonRewardResponse>, IDeepCloneable<GuildRaidSeasonRewardResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidSeasonRewardResponse> _parser = new MessageParser<GuildRaidSeasonRewardResponse>(() => new GuildRaidSeasonRewardResponse());

	private UnknownFieldSet _unknownFields;

	public const int RewardInfoBundleFieldNumber = 1;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int IsReceivedRewardFieldNumber = 2;

	private bool isReceivedReward_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRaidSeasonRewardResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildRaidSeasonRewardResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public bool IsReceivedReward
	{
		get
		{
			return isReceivedReward_;
		}
		set
		{
			isReceivedReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidSeasonRewardResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidSeasonRewardResponse(GuildRaidSeasonRewardResponse other)
		: this()
	{
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		isReceivedReward_ = other.isReceivedReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidSeasonRewardResponse Clone()
	{
		return new GuildRaidSeasonRewardResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidSeasonRewardResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRaidSeasonRewardResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(RewardInfoBundle, other.RewardInfoBundle) && IsReceivedReward == other.IsReceivedReward)
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
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		if (IsReceivedReward)
		{
			num ^= IsReceivedReward.GetHashCode();
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
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RewardInfoBundle);
		}
		if (IsReceivedReward)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsReceivedReward);
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
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (IsReceivedReward)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildRaidSeasonRewardResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		if (other.IsReceivedReward)
		{
			IsReceivedReward = other.IsReceivedReward;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				IsReceivedReward = input.ReadBool();
				break;
			case 10u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			}
		}
	}
}
