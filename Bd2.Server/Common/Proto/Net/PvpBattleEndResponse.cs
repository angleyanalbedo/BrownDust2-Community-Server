using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PvpBattleEndResponse : IMessage<PvpBattleEndResponse>, IMessage, IEquatable<PvpBattleEndResponse>, IDeepCloneable<PvpBattleEndResponse>, IBufferMessage
{
	private static readonly MessageParser<PvpBattleEndResponse> _parser = new MessageParser<PvpBattleEndResponse>(() => new PvpBattleEndResponse());

	private UnknownFieldSet _unknownFields;

	public const int BattleResultFieldNumber = 1;

	private int battleResult_;

	public const int ItemInfoFieldNumber = 2;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(18u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int CharPartnerInfoFieldNumber = 3;

	private static readonly FieldCodec<CharPartnerDBInfo> _repeated_charPartnerInfo_codec = FieldCodec.ForMessage(26u, CharPartnerDBInfo.Parser);

	private readonly RepeatedField<CharPartnerDBInfo> charPartnerInfo_ = new RepeatedField<CharPartnerDBInfo>();

	public const int ChangeVpFieldNumber = 4;

	private int changeVp_;

	public const int ContinueWinVpFieldNumber = 5;

	private int continueWinVp_;

	public const int BattleStatisticsInfoFieldNumber = 6;

	private BattleStatisticsDBInfo battleStatisticsInfo_;

	public const int OnceRewardInfoFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_onceRewardInfo_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> onceRewardInfo_ = new RepeatedField<int>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PvpBattleEndResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PvpBattleEndResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharPartnerDBInfo> CharPartnerInfo => charPartnerInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BattleStatisticsDBInfo BattleStatisticsInfo
	{
		get
		{
			return battleStatisticsInfo_;
		}
		set
		{
			battleStatisticsInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> OnceRewardInfo => onceRewardInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleEndResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleEndResponse(PvpBattleEndResponse other)
		: this()
	{
		battleResult_ = other.battleResult_;
		itemInfo_ = other.itemInfo_.Clone();
		charPartnerInfo_ = other.charPartnerInfo_.Clone();
		changeVp_ = other.changeVp_;
		continueWinVp_ = other.continueWinVp_;
		battleStatisticsInfo_ = ((other.battleStatisticsInfo_ != null) ? other.battleStatisticsInfo_.Clone() : null);
		onceRewardInfo_ = other.onceRewardInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PvpBattleEndResponse Clone()
	{
		return new PvpBattleEndResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PvpBattleEndResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PvpBattleEndResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleResult == other.BattleResult && itemInfo_.Equals(other.itemInfo_) && charPartnerInfo_.Equals(other.charPartnerInfo_) && ChangeVp == other.ChangeVp && ContinueWinVp == other.ContinueWinVp && object.Equals(BattleStatisticsInfo, other.BattleStatisticsInfo) && onceRewardInfo_.Equals(other.onceRewardInfo_))
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
		if (BattleResult != 0)
		{
			num ^= BattleResult.GetHashCode();
		}
		num ^= itemInfo_.GetHashCode();
		num ^= charPartnerInfo_.GetHashCode();
		if (ChangeVp != 0)
		{
			num ^= ChangeVp.GetHashCode();
		}
		if (ContinueWinVp != 0)
		{
			num ^= ContinueWinVp.GetHashCode();
		}
		if (battleStatisticsInfo_ != null)
		{
			num ^= BattleStatisticsInfo.GetHashCode();
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
		if (BattleResult != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleResult);
		}
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
		charPartnerInfo_.WriteTo(ref output, _repeated_charPartnerInfo_codec);
		if (ChangeVp != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ChangeVp);
		}
		if (ContinueWinVp != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ContinueWinVp);
		}
		if (battleStatisticsInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BattleStatisticsInfo);
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
		if (BattleResult != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleResult);
		}
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		num += charPartnerInfo_.CalculateSize(_repeated_charPartnerInfo_codec);
		if (ChangeVp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChangeVp);
		}
		if (ContinueWinVp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ContinueWinVp);
		}
		if (battleStatisticsInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleStatisticsInfo);
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
	public void MergeFrom(PvpBattleEndResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BattleResult != 0)
		{
			BattleResult = other.BattleResult;
		}
		itemInfo_.Add(other.itemInfo_);
		charPartnerInfo_.Add(other.charPartnerInfo_);
		if (other.ChangeVp != 0)
		{
			ChangeVp = other.ChangeVp;
		}
		if (other.ContinueWinVp != 0)
		{
			ContinueWinVp = other.ContinueWinVp;
		}
		if (other.battleStatisticsInfo_ != null)
		{
			if (battleStatisticsInfo_ == null)
			{
				BattleStatisticsInfo = new BattleStatisticsDBInfo();
			}
			BattleStatisticsInfo.MergeFrom(other.BattleStatisticsInfo);
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
				BattleResult = input.ReadInt32();
				break;
			case 18u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			case 26u:
				charPartnerInfo_.AddEntriesFrom(ref input, _repeated_charPartnerInfo_codec);
				break;
			case 32u:
				ChangeVp = input.ReadInt32();
				break;
			case 40u:
				ContinueWinVp = input.ReadInt32();
				break;
			case 50u:
				if (battleStatisticsInfo_ == null)
				{
					BattleStatisticsInfo = new BattleStatisticsDBInfo();
				}
				input.ReadMessage(BattleStatisticsInfo);
				break;
			case 56u:
			case 58u:
				onceRewardInfo_.AddEntriesFrom(ref input, _repeated_onceRewardInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
