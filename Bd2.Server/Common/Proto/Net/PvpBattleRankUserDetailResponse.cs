using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleRankUserDetailResponse : IMessage<PvpBattleRankUserDetailResponse>, IMessage, IEquatable<PvpBattleRankUserDetailResponse>, IDeepCloneable<PvpBattleRankUserDetailResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleRankUserDetailResponse> _parser = new MessageParser<PvpBattleRankUserDetailResponse>(() => new PvpBattleRankUserDetailResponse());

	private UnknownFieldSet _unknownFields;

	public const int OwnerIndexFieldNumber = 1;

	private long ownerIndex_;

	public const int WinCountFieldNumber = 2;

	private int winCount_;

	public const int LoseCountFieldNumber = 3;

	private int loseCount_;

	public const int AttackDeckInfoFieldNumber = 4;

	private PvpBattleUserDeckFullInfo attackDeckInfo_;

	public const int DefenceDeckInfoFieldNumber = 5;

	private PvpBattleUserDeckFullInfo defenceDeckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PvpBattleRankUserDetailResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PvpBattleRankUserDetailResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OwnerIndex
	{
		get
		{
			return ownerIndex_;
		}
		set
		{
			ownerIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WinCount
	{
		get
		{
			return winCount_;
		}
		set
		{
			winCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int LoseCount
	{
		get
		{
			return loseCount_;
		}
		set
		{
			loseCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleUserDeckFullInfo AttackDeckInfo
	{
		get
		{
			return attackDeckInfo_;
		}
		set
		{
			attackDeckInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleUserDeckFullInfo DefenceDeckInfo
	{
		get
		{
			return defenceDeckInfo_;
		}
		set
		{
			defenceDeckInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleRankUserDetailResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleRankUserDetailResponse(PvpBattleRankUserDetailResponse other)
		: this()
	{
		ownerIndex_ = other.ownerIndex_;
		winCount_ = other.winCount_;
		loseCount_ = other.loseCount_;
		attackDeckInfo_ = ((other.attackDeckInfo_ != null) ? other.attackDeckInfo_.Clone() : null);
		defenceDeckInfo_ = ((other.defenceDeckInfo_ != null) ? other.defenceDeckInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PvpBattleRankUserDetailResponse Clone()
	{
		return new PvpBattleRankUserDetailResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleRankUserDetailResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleRankUserDetailResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OwnerIndex == other.OwnerIndex && WinCount == other.WinCount && LoseCount == other.LoseCount && object.Equals(AttackDeckInfo, other.AttackDeckInfo) && object.Equals(DefenceDeckInfo, other.DefenceDeckInfo))
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
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (WinCount != 0)
		{
			num ^= WinCount.GetHashCode();
		}
		if (LoseCount != 0)
		{
			num ^= LoseCount.GetHashCode();
		}
		if (attackDeckInfo_ != null)
		{
			num ^= AttackDeckInfo.GetHashCode();
		}
		if (defenceDeckInfo_ != null)
		{
			num ^= DefenceDeckInfo.GetHashCode();
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
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(OwnerIndex);
		}
		if (WinCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(WinCount);
		}
		if (LoseCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LoseCount);
		}
		if (attackDeckInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AttackDeckInfo);
		}
		if (defenceDeckInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(DefenceDeckInfo);
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
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (WinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WinCount);
		}
		if (LoseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LoseCount);
		}
		if (attackDeckInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AttackDeckInfo);
		}
		if (defenceDeckInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DefenceDeckInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PvpBattleRankUserDetailResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OwnerIndex != 0L)
		{
			OwnerIndex = other.OwnerIndex;
		}
		if (other.WinCount != 0)
		{
			WinCount = other.WinCount;
		}
		if (other.LoseCount != 0)
		{
			LoseCount = other.LoseCount;
		}
		if (other.attackDeckInfo_ != null)
		{
			if (attackDeckInfo_ == null)
			{
				AttackDeckInfo = new PvpBattleUserDeckFullInfo();
			}
			AttackDeckInfo.MergeFrom(other.AttackDeckInfo);
		}
		if (other.defenceDeckInfo_ != null)
		{
			if (defenceDeckInfo_ == null)
			{
				DefenceDeckInfo = new PvpBattleUserDeckFullInfo();
			}
			DefenceDeckInfo.MergeFrom(other.DefenceDeckInfo);
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
			case 8u:
				OwnerIndex = input.ReadInt64();
				break;
			case 16u:
				WinCount = input.ReadInt32();
				break;
			case 24u:
				LoseCount = input.ReadInt32();
				break;
			case 34u:
				if (attackDeckInfo_ == null)
				{
					AttackDeckInfo = new PvpBattleUserDeckFullInfo();
				}
				input.ReadMessage(AttackDeckInfo);
				break;
			case 42u:
				if (defenceDeckInfo_ == null)
				{
					DefenceDeckInfo = new PvpBattleUserDeckFullInfo();
				}
				input.ReadMessage(DefenceDeckInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
