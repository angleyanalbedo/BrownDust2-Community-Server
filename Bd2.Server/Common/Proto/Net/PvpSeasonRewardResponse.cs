using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpSeasonRewardResponse : IMessage<PvpSeasonRewardResponse>, IMessage, IEquatable<PvpSeasonRewardResponse>, IDeepCloneable<PvpSeasonRewardResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpSeasonRewardResponse> _parser = new MessageParser<PvpSeasonRewardResponse>(() => new PvpSeasonRewardResponse());

	private UnknownFieldSet _unknownFields;

	public const int RankFieldNumber = 1;

	private int rank_;

	public const int VpFieldNumber = 2;

	private int vp_;

	public const int RewardInfoBundleFieldNumber = 3;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int RewardSeasonFieldNumber = 4;

	private int rewardSeason_;

	public const int OnceRewardInfoFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_onceRewardInfo_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> onceRewardInfo_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpSeasonRewardResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PvpSeasonRewardResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Vp
	{
		get
		{
			return vp_;
		}
		set
		{
			vp_ = value;
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
	public int RewardSeason
	{
		get
		{
			return rewardSeason_;
		}
		set
		{
			rewardSeason_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> OnceRewardInfo => onceRewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpSeasonRewardResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpSeasonRewardResponse(PvpSeasonRewardResponse other)
		: this()
	{
		rank_ = other.rank_;
		vp_ = other.vp_;
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		rewardSeason_ = other.rewardSeason_;
		onceRewardInfo_ = other.onceRewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpSeasonRewardResponse Clone()
	{
		return new PvpSeasonRewardResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpSeasonRewardResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpSeasonRewardResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Rank == other.Rank && Vp == other.Vp && object.Equals(RewardInfoBundle, other.RewardInfoBundle) && RewardSeason == other.RewardSeason && onceRewardInfo_.Equals(other.onceRewardInfo_))
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
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (Vp != 0)
		{
			num ^= Vp.GetHashCode();
		}
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		if (RewardSeason != 0)
		{
			num ^= RewardSeason.GetHashCode();
		}
		num ^= onceRewardInfo_.GetHashCode();
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
		if (Rank != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Rank);
		}
		if (Vp != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Vp);
		}
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RewardInfoBundle);
		}
		if (RewardSeason != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RewardSeason);
		}
		onceRewardInfo_.WriteTo(ref output, _repeated_onceRewardInfo_codec);
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
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (Vp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Vp);
		}
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		if (RewardSeason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardSeason);
		}
		num += onceRewardInfo_.CalculateSize(_repeated_onceRewardInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PvpSeasonRewardResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Rank != 0)
		{
			Rank = other.Rank;
		}
		if (other.Vp != 0)
		{
			Vp = other.Vp;
		}
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		if (other.RewardSeason != 0)
		{
			RewardSeason = other.RewardSeason;
		}
		onceRewardInfo_.Add(other.onceRewardInfo_);
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
				Rank = input.ReadInt32();
				break;
			case 16u:
				Vp = input.ReadInt32();
				break;
			case 26u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 32u:
				RewardSeason = input.ReadInt32();
				break;
			case 40u:
			case 42u:
				onceRewardInfo_.AddEntriesFrom(ref input, _repeated_onceRewardInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
