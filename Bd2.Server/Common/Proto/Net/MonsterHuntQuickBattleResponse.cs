using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntQuickBattleResponse : IMessage<MonsterHuntQuickBattleResponse>, IMessage, IEquatable<MonsterHuntQuickBattleResponse>, IDeepCloneable<MonsterHuntQuickBattleResponse>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntQuickBattleResponse> _parser = new MessageParser<MonsterHuntQuickBattleResponse>(() => new MonsterHuntQuickBattleResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterHuntUserInfoFieldNumber = 1;

	private MonsterHuntUserDBInfo monsterHuntUserInfo_;

	public const int MonsterHuntRewardBundleFieldNumber = 2;

	private RewardDBInfoBundle monsterHuntRewardBundle_;

	public const int MonsterHuntDailyRewardBundleFieldNumber = 3;

	private RewardDBInfoBundle monsterHuntDailyRewardBundle_;

	public const int RankFieldNumber = 4;

	private int rank_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntQuickBattleResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterHuntQuickBattleResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntUserDBInfo MonsterHuntUserInfo
	{
		get
		{
			return monsterHuntUserInfo_;
		}
		set
		{
			monsterHuntUserInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle MonsterHuntRewardBundle
	{
		get
		{
			return monsterHuntRewardBundle_;
		}
		set
		{
			monsterHuntRewardBundle_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RewardDBInfoBundle MonsterHuntDailyRewardBundle
	{
		get
		{
			return monsterHuntDailyRewardBundle_;
		}
		set
		{
			monsterHuntDailyRewardBundle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntQuickBattleResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntQuickBattleResponse(MonsterHuntQuickBattleResponse other)
		: this()
	{
		monsterHuntUserInfo_ = ((other.monsterHuntUserInfo_ != null) ? other.monsterHuntUserInfo_.Clone() : null);
		monsterHuntRewardBundle_ = ((other.monsterHuntRewardBundle_ != null) ? other.monsterHuntRewardBundle_.Clone() : null);
		monsterHuntDailyRewardBundle_ = ((other.monsterHuntDailyRewardBundle_ != null) ? other.monsterHuntDailyRewardBundle_.Clone() : null);
		rank_ = other.rank_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntQuickBattleResponse Clone()
	{
		return new MonsterHuntQuickBattleResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntQuickBattleResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntQuickBattleResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(MonsterHuntUserInfo, other.MonsterHuntUserInfo) && object.Equals(MonsterHuntRewardBundle, other.MonsterHuntRewardBundle) && object.Equals(MonsterHuntDailyRewardBundle, other.MonsterHuntDailyRewardBundle) && Rank == other.Rank)
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
		if (monsterHuntUserInfo_ != null)
		{
			num ^= MonsterHuntUserInfo.GetHashCode();
		}
		if (monsterHuntRewardBundle_ != null)
		{
			num ^= MonsterHuntRewardBundle.GetHashCode();
		}
		if (monsterHuntDailyRewardBundle_ != null)
		{
			num ^= MonsterHuntDailyRewardBundle.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
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
		if (monsterHuntUserInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MonsterHuntUserInfo);
		}
		if (monsterHuntRewardBundle_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MonsterHuntRewardBundle);
		}
		if (monsterHuntDailyRewardBundle_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MonsterHuntDailyRewardBundle);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Rank);
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
		if (monsterHuntUserInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntUserInfo);
		}
		if (monsterHuntRewardBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntRewardBundle);
		}
		if (monsterHuntDailyRewardBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntDailyRewardBundle);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MonsterHuntQuickBattleResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.monsterHuntUserInfo_ != null)
		{
			if (monsterHuntUserInfo_ == null)
			{
				MonsterHuntUserInfo = new MonsterHuntUserDBInfo();
			}
			MonsterHuntUserInfo.MergeFrom(other.MonsterHuntUserInfo);
		}
		if (other.monsterHuntRewardBundle_ != null)
		{
			if (monsterHuntRewardBundle_ == null)
			{
				MonsterHuntRewardBundle = new RewardDBInfoBundle();
			}
			MonsterHuntRewardBundle.MergeFrom(other.MonsterHuntRewardBundle);
		}
		if (other.monsterHuntDailyRewardBundle_ != null)
		{
			if (monsterHuntDailyRewardBundle_ == null)
			{
				MonsterHuntDailyRewardBundle = new RewardDBInfoBundle();
			}
			MonsterHuntDailyRewardBundle.MergeFrom(other.MonsterHuntDailyRewardBundle);
		}
		if (other.Rank != 0)
		{
			Rank = other.Rank;
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
				if (monsterHuntUserInfo_ == null)
				{
					MonsterHuntUserInfo = new MonsterHuntUserDBInfo();
				}
				input.ReadMessage(MonsterHuntUserInfo);
				break;
			case 18u:
				if (monsterHuntRewardBundle_ == null)
				{
					MonsterHuntRewardBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(MonsterHuntRewardBundle);
				break;
			case 26u:
				if (monsterHuntDailyRewardBundle_ == null)
				{
					MonsterHuntDailyRewardBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(MonsterHuntDailyRewardBundle);
				break;
			case 32u:
				Rank = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
