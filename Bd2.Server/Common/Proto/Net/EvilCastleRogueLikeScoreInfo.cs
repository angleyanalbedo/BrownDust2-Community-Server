using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EvilCastleRogueLikeScoreInfo : IMessage<EvilCastleRogueLikeScoreInfo>, IMessage, IEquatable<EvilCastleRogueLikeScoreInfo>, IDeepCloneable<EvilCastleRogueLikeScoreInfo>, IBufferMessage
{
	private static readonly MessageParser<EvilCastleRogueLikeScoreInfo> _parser = new MessageParser<EvilCastleRogueLikeScoreInfo>(() => new EvilCastleRogueLikeScoreInfo());

	private UnknownFieldSet _unknownFields;

	public const int ScoreItemInfoFieldNumber = 1;

	private static readonly FieldCodec<EvilCastleRogueLikeScoreItem> _repeated_scoreItemInfo_codec = FieldCodec.ForMessage(10u, EvilCastleRogueLikeScoreItem.Parser);

	private readonly RepeatedField<EvilCastleRogueLikeScoreItem> scoreItemInfo_ = new RepeatedField<EvilCastleRogueLikeScoreItem>();

	public const int TotalScoreFieldNumber = 2;

	private int totalScore_;

	public const int ObsidianFieldNumber = 3;

	private int obsidian_;

	public const int AllUserTotalScoreFieldNumber = 4;

	private long allUserTotalScore_;

	public const int MaxTryLevelFieldNumber = 5;

	private int maxTryLevel_;

	public const int MaxRewardLevelFieldNumber = 6;

	private int maxRewardLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EvilCastleRogueLikeScoreInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EvilCastleRogueLikeScoreInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EvilCastleRogueLikeScoreItem> ScoreItemInfo => scoreItemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TotalScore
	{
		get
		{
			return totalScore_;
		}
		set
		{
			totalScore_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Obsidian
	{
		get
		{
			return obsidian_;
		}
		set
		{
			obsidian_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AllUserTotalScore
	{
		get
		{
			return allUserTotalScore_;
		}
		set
		{
			allUserTotalScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxTryLevel
	{
		get
		{
			return maxTryLevel_;
		}
		set
		{
			maxTryLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxRewardLevel
	{
		get
		{
			return maxRewardLevel_;
		}
		set
		{
			maxRewardLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeScoreInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeScoreInfo(EvilCastleRogueLikeScoreInfo other)
		: this()
	{
		scoreItemInfo_ = other.scoreItemInfo_.Clone();
		totalScore_ = other.totalScore_;
		obsidian_ = other.obsidian_;
		allUserTotalScore_ = other.allUserTotalScore_;
		maxTryLevel_ = other.maxTryLevel_;
		maxRewardLevel_ = other.maxRewardLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EvilCastleRogueLikeScoreInfo Clone()
	{
		return new EvilCastleRogueLikeScoreInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EvilCastleRogueLikeScoreInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EvilCastleRogueLikeScoreInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (scoreItemInfo_.Equals(other.scoreItemInfo_) && TotalScore == other.TotalScore && Obsidian == other.Obsidian && AllUserTotalScore == other.AllUserTotalScore && MaxTryLevel == other.MaxTryLevel && MaxRewardLevel == other.MaxRewardLevel)
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
		num ^= scoreItemInfo_.GetHashCode();
		if (TotalScore != 0)
		{
			num ^= TotalScore.GetHashCode();
		}
		if (Obsidian != 0)
		{
			num ^= Obsidian.GetHashCode();
		}
		if (AllUserTotalScore != 0L)
		{
			num ^= AllUserTotalScore.GetHashCode();
		}
		if (MaxTryLevel != 0)
		{
			num ^= MaxTryLevel.GetHashCode();
		}
		if (MaxRewardLevel != 0)
		{
			num ^= MaxRewardLevel.GetHashCode();
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
		scoreItemInfo_.WriteTo(ref output, _repeated_scoreItemInfo_codec);
		if (TotalScore != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TotalScore);
		}
		if (Obsidian != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Obsidian);
		}
		if (AllUserTotalScore != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(AllUserTotalScore);
		}
		if (MaxTryLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MaxTryLevel);
		}
		if (MaxRewardLevel != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MaxRewardLevel);
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
		num += scoreItemInfo_.CalculateSize(_repeated_scoreItemInfo_codec);
		if (TotalScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalScore);
		}
		if (Obsidian != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Obsidian);
		}
		if (AllUserTotalScore != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(AllUserTotalScore);
		}
		if (MaxTryLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxTryLevel);
		}
		if (MaxRewardLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxRewardLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EvilCastleRogueLikeScoreInfo other)
	{
		if (other != null)
		{
			scoreItemInfo_.Add(other.scoreItemInfo_);
			if (other.TotalScore != 0)
			{
				TotalScore = other.TotalScore;
			}
			if (other.Obsidian != 0)
			{
				Obsidian = other.Obsidian;
			}
			if (other.AllUserTotalScore != 0L)
			{
				AllUserTotalScore = other.AllUserTotalScore;
			}
			if (other.MaxTryLevel != 0)
			{
				MaxTryLevel = other.MaxTryLevel;
			}
			if (other.MaxRewardLevel != 0)
			{
				MaxRewardLevel = other.MaxRewardLevel;
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
				scoreItemInfo_.AddEntriesFrom(ref input, _repeated_scoreItemInfo_codec);
				break;
			case 16u:
				TotalScore = input.ReadInt32();
				break;
			case 24u:
				Obsidian = input.ReadInt32();
				break;
			case 32u:
				AllUserTotalScore = input.ReadInt64();
				break;
			case 40u:
				MaxTryLevel = input.ReadInt32();
				break;
			case 48u:
				MaxRewardLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
