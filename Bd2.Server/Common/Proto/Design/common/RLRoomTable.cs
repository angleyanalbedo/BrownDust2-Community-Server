using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLRoomTable : IMessage<RLRoomTable>, IMessage, IEquatable<RLRoomTable>, IDeepCloneable<RLRoomTable>, IBufferMessage
{
	private static readonly MessageParser<RLRoomTable> _parser = new MessageParser<RLRoomTable>(() => new RLRoomTable());

	private UnknownFieldSet _unknownFields;

	public const int BattleDeckIdFieldNumber = 1;

	private int battleDeckId_;

	public const int BattleRecoveryRateFieldNumber = 2;

	private double battleRecoveryRate_;

	public const int BattleRewardPointFieldNumber = 3;

	private int battleRewardPoint_;

	public const int CostumeChoiceCountFieldNumber = 4;

	private int costumeChoiceCount_;

	public const int EventChoiceIdFieldNumber = 5;

	private int eventChoiceId_;

	public const int GroupIdFieldNumber = 6;

	private int groupId_;

	public const int IdFieldNumber = 7;

	private int id_;

	public const int RewardRelicIdFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_rewardRelicId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> rewardRelicId_ = new RepeatedField<int>();

	public const int ShopTableIdFieldNumber = 9;

	private int shopTableId_;

	public const int TypeFieldNumber = 10;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RLRoomTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => RLRoomTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleDeckId
	{
		get
		{
			return battleDeckId_;
		}
		set
		{
			battleDeckId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double BattleRecoveryRate
	{
		get
		{
			return battleRecoveryRate_;
		}
		set
		{
			battleRecoveryRate_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleRewardPoint
	{
		get
		{
			return battleRewardPoint_;
		}
		set
		{
			battleRewardPoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CostumeChoiceCount
	{
		get
		{
			return costumeChoiceCount_;
		}
		set
		{
			costumeChoiceCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventChoiceId
	{
		get
		{
			return eventChoiceId_;
		}
		set
		{
			eventChoiceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardRelicId => rewardRelicId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ShopTableId
	{
		get
		{
			return shopTableId_;
		}
		set
		{
			shopTableId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLRoomTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLRoomTable(RLRoomTable other)
		: this()
	{
		battleDeckId_ = other.battleDeckId_;
		battleRecoveryRate_ = other.battleRecoveryRate_;
		battleRewardPoint_ = other.battleRewardPoint_;
		costumeChoiceCount_ = other.costumeChoiceCount_;
		eventChoiceId_ = other.eventChoiceId_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		rewardRelicId_ = other.rewardRelicId_.Clone();
		shopTableId_ = other.shopTableId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RLRoomTable Clone()
	{
		return new RLRoomTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLRoomTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RLRoomTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleDeckId == other.BattleDeckId && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BattleRecoveryRate, other.BattleRecoveryRate) && BattleRewardPoint == other.BattleRewardPoint && CostumeChoiceCount == other.CostumeChoiceCount && EventChoiceId == other.EventChoiceId && GroupId == other.GroupId && Id == other.Id && rewardRelicId_.Equals(other.rewardRelicId_) && ShopTableId == other.ShopTableId && Type == other.Type)
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
		if (BattleDeckId != 0)
		{
			num ^= BattleDeckId.GetHashCode();
		}
		if (BattleRecoveryRate != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BattleRecoveryRate);
		}
		if (BattleRewardPoint != 0)
		{
			num ^= BattleRewardPoint.GetHashCode();
		}
		if (CostumeChoiceCount != 0)
		{
			num ^= CostumeChoiceCount.GetHashCode();
		}
		if (EventChoiceId != 0)
		{
			num ^= EventChoiceId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= rewardRelicId_.GetHashCode();
		if (ShopTableId != 0)
		{
			num ^= ShopTableId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (BattleDeckId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleDeckId);
		}
		if (BattleRecoveryRate != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(BattleRecoveryRate);
		}
		if (BattleRewardPoint != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleRewardPoint);
		}
		if (CostumeChoiceCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CostumeChoiceCount);
		}
		if (EventChoiceId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EventChoiceId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Id);
		}
		rewardRelicId_.WriteTo(ref output, _repeated_rewardRelicId_codec);
		if (ShopTableId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ShopTableId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Type);
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
		if (BattleDeckId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDeckId);
		}
		if (BattleRecoveryRate != 0.0)
		{
			num += 9;
		}
		if (BattleRewardPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleRewardPoint);
		}
		if (CostumeChoiceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CostumeChoiceCount);
		}
		if (EventChoiceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventChoiceId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += rewardRelicId_.CalculateSize(_repeated_rewardRelicId_codec);
		if (ShopTableId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopTableId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RLRoomTable other)
	{
		if (other != null)
		{
			if (other.BattleDeckId != 0)
			{
				BattleDeckId = other.BattleDeckId;
			}
			if (other.BattleRecoveryRate != 0.0)
			{
				BattleRecoveryRate = other.BattleRecoveryRate;
			}
			if (other.BattleRewardPoint != 0)
			{
				BattleRewardPoint = other.BattleRewardPoint;
			}
			if (other.CostumeChoiceCount != 0)
			{
				CostumeChoiceCount = other.CostumeChoiceCount;
			}
			if (other.EventChoiceId != 0)
			{
				EventChoiceId = other.EventChoiceId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			rewardRelicId_.Add(other.rewardRelicId_);
			if (other.ShopTableId != 0)
			{
				ShopTableId = other.ShopTableId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 48u:
				GroupId = input.ReadInt32();
				break;
			case 56u:
				Id = input.ReadInt32();
				break;
			case 72u:
				ShopTableId = input.ReadInt32();
				break;
			case 80u:
				Type = input.ReadInt32();
				break;
			case 64u:
			case 66u:
				rewardRelicId_.AddEntriesFrom(ref input, _repeated_rewardRelicId_codec);
				break;
			case 8u:
				BattleDeckId = input.ReadInt32();
				break;
			case 17u:
				BattleRecoveryRate = input.ReadDouble();
				break;
			case 24u:
				BattleRewardPoint = input.ReadInt32();
				break;
			case 32u:
				CostumeChoiceCount = input.ReadInt32();
				break;
			case 40u:
				EventChoiceId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
