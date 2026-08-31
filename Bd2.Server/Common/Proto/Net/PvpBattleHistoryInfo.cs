using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleHistoryInfo : IMessage<PvpBattleHistoryInfo>, IMessage, IEquatable<PvpBattleHistoryInfo>, IDeepCloneable<PvpBattleHistoryInfo>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleHistoryInfo> _parser = new MessageParser<PvpBattleHistoryInfo>(() => new PvpBattleHistoryInfo());

	private UnknownFieldSet _unknownFields;

	public const int BattleIndexFieldNumber = 1;

	private long battleIndex_;

	public const int BattleResultFieldNumber = 2;

	private int battleResult_;

	public const int EnemyOwnerIndexFieldNumber = 3;

	private long enemyOwnerIndex_;

	public const int EnemyUserIdFieldNumber = 4;

	private string enemyUserId_ = "";

	public const int EnemyVpFieldNumber = 5;

	private int enemyVp_;

	public const int EnemyRankFieldNumber = 6;

	private int enemyRank_;

	public const int EnemyCostumeIdFieldNumber = 7;

	private static readonly FieldCodec<long> _repeated_enemyCostumeId_codec = FieldCodec.ForInt64(58u);

	private readonly RepeatedField<long> enemyCostumeId_ = new RepeatedField<long>();

	public const int ChangeVpFieldNumber = 8;

	private int changeVp_;

	public const int ContinueWinVpFieldNumber = 9;

	private int continueWinVp_;

	public const int TimeValueFieldNumber = 10;

	private long timeValue_;

	public const int IsNoGameFieldNumber = 11;

	private bool isNoGame_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleHistoryInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleHistoryInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long BattleIndex
	{
		get
		{
			return battleIndex_;
		}
		set
		{
			battleIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleResult
	{
		get
		{
			return battleResult_;
		}
		set
		{
			battleResult_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EnemyOwnerIndex
	{
		get
		{
			return enemyOwnerIndex_;
		}
		set
		{
			enemyOwnerIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string EnemyUserId
	{
		get
		{
			return enemyUserId_;
		}
		set
		{
			enemyUserId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EnemyVp
	{
		get
		{
			return enemyVp_;
		}
		set
		{
			enemyVp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EnemyRank
	{
		get
		{
			return enemyRank_;
		}
		set
		{
			enemyRank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> EnemyCostumeId => enemyCostumeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChangeVp
	{
		get
		{
			return changeVp_;
		}
		set
		{
			changeVp_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContinueWinVp
	{
		get
		{
			return continueWinVp_;
		}
		set
		{
			continueWinVp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TimeValue
	{
		get
		{
			return timeValue_;
		}
		set
		{
			timeValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsNoGame
	{
		get
		{
			return isNoGame_;
		}
		set
		{
			isNoGame_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleHistoryInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleHistoryInfo(PvpBattleHistoryInfo other)
		: this()
	{
		battleIndex_ = other.battleIndex_;
		battleResult_ = other.battleResult_;
		enemyOwnerIndex_ = other.enemyOwnerIndex_;
		enemyUserId_ = other.enemyUserId_;
		enemyVp_ = other.enemyVp_;
		enemyRank_ = other.enemyRank_;
		enemyCostumeId_ = other.enemyCostumeId_.Clone();
		changeVp_ = other.changeVp_;
		continueWinVp_ = other.continueWinVp_;
		timeValue_ = other.timeValue_;
		isNoGame_ = other.isNoGame_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleHistoryInfo Clone()
	{
		return new PvpBattleHistoryInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleHistoryInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleHistoryInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleIndex == other.BattleIndex && BattleResult == other.BattleResult && EnemyOwnerIndex == other.EnemyOwnerIndex && !(EnemyUserId != other.EnemyUserId) && EnemyVp == other.EnemyVp && EnemyRank == other.EnemyRank && enemyCostumeId_.Equals(other.enemyCostumeId_) && ChangeVp == other.ChangeVp && ContinueWinVp == other.ContinueWinVp && TimeValue == other.TimeValue && IsNoGame == other.IsNoGame)
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
		if (BattleIndex != 0L)
		{
			num ^= BattleIndex.GetHashCode();
		}
		if (BattleResult != 0)
		{
			num ^= BattleResult.GetHashCode();
		}
		if (EnemyOwnerIndex != 0L)
		{
			num ^= EnemyOwnerIndex.GetHashCode();
		}
		if (EnemyUserId.Length != 0)
		{
			num ^= EnemyUserId.GetHashCode();
		}
		if (EnemyVp != 0)
		{
			num ^= EnemyVp.GetHashCode();
		}
		if (EnemyRank != 0)
		{
			num ^= EnemyRank.GetHashCode();
		}
		num ^= enemyCostumeId_.GetHashCode();
		if (ChangeVp != 0)
		{
			num ^= ChangeVp.GetHashCode();
		}
		if (ContinueWinVp != 0)
		{
			num ^= ContinueWinVp.GetHashCode();
		}
		if (TimeValue != 0L)
		{
			num ^= TimeValue.GetHashCode();
		}
		if (IsNoGame)
		{
			num ^= IsNoGame.GetHashCode();
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
		if (BattleIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(BattleIndex);
		}
		if (BattleResult != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleResult);
		}
		if (EnemyOwnerIndex != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(EnemyOwnerIndex);
		}
		if (EnemyUserId.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(EnemyUserId);
		}
		if (EnemyVp != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EnemyVp);
		}
		if (EnemyRank != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EnemyRank);
		}
		enemyCostumeId_.WriteTo(ref output, _repeated_enemyCostumeId_codec);
		if (ChangeVp != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ChangeVp);
		}
		if (ContinueWinVp != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ContinueWinVp);
		}
		if (TimeValue != 0L)
		{
			output.WriteRawTag(80);
			output.WriteInt64(TimeValue);
		}
		if (IsNoGame)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsNoGame);
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
		if (BattleIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BattleIndex);
		}
		if (BattleResult != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleResult);
		}
		if (EnemyOwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EnemyOwnerIndex);
		}
		if (EnemyUserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnemyUserId);
		}
		if (EnemyVp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EnemyVp);
		}
		if (EnemyRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EnemyRank);
		}
		num += enemyCostumeId_.CalculateSize(_repeated_enemyCostumeId_codec);
		if (ChangeVp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChangeVp);
		}
		if (ContinueWinVp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContinueWinVp);
		}
		if (TimeValue != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(TimeValue);
		}
		if (IsNoGame)
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
	public void MergeFrom(PvpBattleHistoryInfo other)
	{
		if (other != null)
		{
			if (other.BattleIndex != 0L)
			{
				BattleIndex = other.BattleIndex;
			}
			if (other.BattleResult != 0)
			{
				BattleResult = other.BattleResult;
			}
			if (other.EnemyOwnerIndex != 0L)
			{
				EnemyOwnerIndex = other.EnemyOwnerIndex;
			}
			if (other.EnemyUserId.Length != 0)
			{
				EnemyUserId = other.EnemyUserId;
			}
			if (other.EnemyVp != 0)
			{
				EnemyVp = other.EnemyVp;
			}
			if (other.EnemyRank != 0)
			{
				EnemyRank = other.EnemyRank;
			}
			enemyCostumeId_.Add(other.enemyCostumeId_);
			if (other.ChangeVp != 0)
			{
				ChangeVp = other.ChangeVp;
			}
			if (other.ContinueWinVp != 0)
			{
				ContinueWinVp = other.ContinueWinVp;
			}
			if (other.TimeValue != 0L)
			{
				TimeValue = other.TimeValue;
			}
			if (other.IsNoGame)
			{
				IsNoGame = other.IsNoGame;
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
			case 8u:
				BattleIndex = input.ReadInt64();
				break;
			case 16u:
				BattleResult = input.ReadInt32();
				break;
			case 24u:
				EnemyOwnerIndex = input.ReadInt64();
				break;
			case 34u:
				EnemyUserId = input.ReadString();
				break;
			case 40u:
				EnemyVp = input.ReadInt32();
				break;
			case 48u:
				EnemyRank = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				enemyCostumeId_.AddEntriesFrom(ref input, _repeated_enemyCostumeId_codec);
				break;
			case 64u:
				ChangeVp = input.ReadInt32();
				break;
			case 72u:
				ContinueWinVp = input.ReadInt32();
				break;
			case 80u:
				TimeValue = input.ReadInt64();
				break;
			case 88u:
				IsNoGame = input.ReadBool();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
