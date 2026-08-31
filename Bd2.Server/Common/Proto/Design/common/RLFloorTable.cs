using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class RLFloorTable : IMessage<RLFloorTable>, IMessage, IEquatable<RLFloorTable>, IDeepCloneable<RLFloorTable>, IBufferMessage
{
	private static readonly MessageParser<RLFloorTable> _parser = new MessageParser<RLFloorTable>(() => new RLFloorTable());

	private UnknownFieldSet _unknownFields;

	public const int BossBattleLevelMaxFieldNumber = 1;

	private int bossBattleLevelMax_;

	public const int BossBattleLevelMinFieldNumber = 2;

	private int bossBattleLevelMin_;

	public const int EliteBattleLevelMaxFieldNumber = 3;

	private int eliteBattleLevelMax_;

	public const int EliteBattleLevelMinFieldNumber = 4;

	private int eliteBattleLevelMin_;

	public const int EventBattleLevelMaxFieldNumber = 5;

	private int eventBattleLevelMax_;

	public const int EventBattleLevelMinFieldNumber = 6;

	private int eventBattleLevelMin_;

	public const int GroupIdFieldNumber = 7;

	private int groupId_;

	public const int IdFieldNumber = 8;

	private int id_;

	public const int NormalBattleLevelMaxFieldNumber = 9;

	private int normalBattleLevelMax_;

	public const int NormalBattleLevelMinFieldNumber = 10;

	private int normalBattleLevelMin_;

	public const int RoomGroupIdFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_roomGroupId_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> roomGroupId_ = new RepeatedField<int>();

	public const int RoomRatioFieldNumber = 12;

	private static readonly FieldCodec<int> _repeated_roomRatio_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> roomRatio_ = new RepeatedField<int>();

	public const int ShopRoomCountFieldNumber = 13;

	private int shopRoomCount_;

	public const int TreasureRoomCountFieldNumber = 14;

	private int treasureRoomCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RLFloorTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RLFloorTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BossBattleLevelMax
	{
		get
		{
			return bossBattleLevelMax_;
		}
		set
		{
			bossBattleLevelMax_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BossBattleLevelMin
	{
		get
		{
			return bossBattleLevelMin_;
		}
		set
		{
			bossBattleLevelMin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EliteBattleLevelMax
	{
		get
		{
			return eliteBattleLevelMax_;
		}
		set
		{
			eliteBattleLevelMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EliteBattleLevelMin
	{
		get
		{
			return eliteBattleLevelMin_;
		}
		set
		{
			eliteBattleLevelMin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EventBattleLevelMax
	{
		get
		{
			return eventBattleLevelMax_;
		}
		set
		{
			eventBattleLevelMax_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int EventBattleLevelMin
	{
		get
		{
			return eventBattleLevelMin_;
		}
		set
		{
			eventBattleLevelMin_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public int NormalBattleLevelMax
	{
		get
		{
			return normalBattleLevelMax_;
		}
		set
		{
			normalBattleLevelMax_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NormalBattleLevelMin
	{
		get
		{
			return normalBattleLevelMin_;
		}
		set
		{
			normalBattleLevelMin_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RoomGroupId => roomGroupId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RoomRatio => roomRatio_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShopRoomCount
	{
		get
		{
			return shopRoomCount_;
		}
		set
		{
			shopRoomCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TreasureRoomCount
	{
		get
		{
			return treasureRoomCount_;
		}
		set
		{
			treasureRoomCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLFloorTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLFloorTable(RLFloorTable other)
		: this()
	{
		bossBattleLevelMax_ = other.bossBattleLevelMax_;
		bossBattleLevelMin_ = other.bossBattleLevelMin_;
		eliteBattleLevelMax_ = other.eliteBattleLevelMax_;
		eliteBattleLevelMin_ = other.eliteBattleLevelMin_;
		eventBattleLevelMax_ = other.eventBattleLevelMax_;
		eventBattleLevelMin_ = other.eventBattleLevelMin_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		normalBattleLevelMax_ = other.normalBattleLevelMax_;
		normalBattleLevelMin_ = other.normalBattleLevelMin_;
		roomGroupId_ = other.roomGroupId_.Clone();
		roomRatio_ = other.roomRatio_.Clone();
		shopRoomCount_ = other.shopRoomCount_;
		treasureRoomCount_ = other.treasureRoomCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RLFloorTable Clone()
	{
		return new RLFloorTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RLFloorTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RLFloorTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BossBattleLevelMax == other.BossBattleLevelMax && BossBattleLevelMin == other.BossBattleLevelMin && EliteBattleLevelMax == other.EliteBattleLevelMax && EliteBattleLevelMin == other.EliteBattleLevelMin && EventBattleLevelMax == other.EventBattleLevelMax && EventBattleLevelMin == other.EventBattleLevelMin && GroupId == other.GroupId && Id == other.Id && NormalBattleLevelMax == other.NormalBattleLevelMax && NormalBattleLevelMin == other.NormalBattleLevelMin && roomGroupId_.Equals(other.roomGroupId_) && roomRatio_.Equals(other.roomRatio_) && ShopRoomCount == other.ShopRoomCount && TreasureRoomCount == other.TreasureRoomCount)
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
		if (BossBattleLevelMax != 0)
		{
			num ^= BossBattleLevelMax.GetHashCode();
		}
		if (BossBattleLevelMin != 0)
		{
			num ^= BossBattleLevelMin.GetHashCode();
		}
		if (EliteBattleLevelMax != 0)
		{
			num ^= EliteBattleLevelMax.GetHashCode();
		}
		if (EliteBattleLevelMin != 0)
		{
			num ^= EliteBattleLevelMin.GetHashCode();
		}
		if (EventBattleLevelMax != 0)
		{
			num ^= EventBattleLevelMax.GetHashCode();
		}
		if (EventBattleLevelMin != 0)
		{
			num ^= EventBattleLevelMin.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NormalBattleLevelMax != 0)
		{
			num ^= NormalBattleLevelMax.GetHashCode();
		}
		if (NormalBattleLevelMin != 0)
		{
			num ^= NormalBattleLevelMin.GetHashCode();
		}
		num ^= roomGroupId_.GetHashCode();
		num ^= roomRatio_.GetHashCode();
		if (ShopRoomCount != 0)
		{
			num ^= ShopRoomCount.GetHashCode();
		}
		if (TreasureRoomCount != 0)
		{
			num ^= TreasureRoomCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
		if (BossBattleLevelMax != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BossBattleLevelMax);
		}
		if (BossBattleLevelMin != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BossBattleLevelMin);
		}
		if (EliteBattleLevelMax != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EliteBattleLevelMax);
		}
		if (EliteBattleLevelMin != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(EliteBattleLevelMin);
		}
		if (EventBattleLevelMax != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EventBattleLevelMax);
		}
		if (EventBattleLevelMin != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(EventBattleLevelMin);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (NormalBattleLevelMax != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(NormalBattleLevelMax);
		}
		if (NormalBattleLevelMin != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(NormalBattleLevelMin);
		}
		roomGroupId_.WriteTo(ref output, _repeated_roomGroupId_codec);
		roomRatio_.WriteTo(ref output, _repeated_roomRatio_codec);
		if (ShopRoomCount != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(ShopRoomCount);
		}
		if (TreasureRoomCount != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(TreasureRoomCount);
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
		if (BossBattleLevelMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossBattleLevelMax);
		}
		if (BossBattleLevelMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossBattleLevelMin);
		}
		if (EliteBattleLevelMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EliteBattleLevelMax);
		}
		if (EliteBattleLevelMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EliteBattleLevelMin);
		}
		if (EventBattleLevelMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventBattleLevelMax);
		}
		if (EventBattleLevelMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventBattleLevelMin);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NormalBattleLevelMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NormalBattleLevelMax);
		}
		if (NormalBattleLevelMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NormalBattleLevelMin);
		}
		num += roomGroupId_.CalculateSize(_repeated_roomGroupId_codec);
		num += roomRatio_.CalculateSize(_repeated_roomRatio_codec);
		if (ShopRoomCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopRoomCount);
		}
		if (TreasureRoomCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TreasureRoomCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RLFloorTable other)
	{
		if (other != null)
		{
			if (other.BossBattleLevelMax != 0)
			{
				BossBattleLevelMax = other.BossBattleLevelMax;
			}
			if (other.BossBattleLevelMin != 0)
			{
				BossBattleLevelMin = other.BossBattleLevelMin;
			}
			if (other.EliteBattleLevelMax != 0)
			{
				EliteBattleLevelMax = other.EliteBattleLevelMax;
			}
			if (other.EliteBattleLevelMin != 0)
			{
				EliteBattleLevelMin = other.EliteBattleLevelMin;
			}
			if (other.EventBattleLevelMax != 0)
			{
				EventBattleLevelMax = other.EventBattleLevelMax;
			}
			if (other.EventBattleLevelMin != 0)
			{
				EventBattleLevelMin = other.EventBattleLevelMin;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NormalBattleLevelMax != 0)
			{
				NormalBattleLevelMax = other.NormalBattleLevelMax;
			}
			if (other.NormalBattleLevelMin != 0)
			{
				NormalBattleLevelMin = other.NormalBattleLevelMin;
			}
			roomGroupId_.Add(other.roomGroupId_);
			roomRatio_.Add(other.roomRatio_);
			if (other.ShopRoomCount != 0)
			{
				ShopRoomCount = other.ShopRoomCount;
			}
			if (other.TreasureRoomCount != 0)
			{
				TreasureRoomCount = other.TreasureRoomCount;
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
				BossBattleLevelMax = input.ReadInt32();
				break;
			case 16u:
				BossBattleLevelMin = input.ReadInt32();
				break;
			case 24u:
				EliteBattleLevelMax = input.ReadInt32();
				break;
			case 32u:
				EliteBattleLevelMin = input.ReadInt32();
				break;
			case 40u:
				EventBattleLevelMax = input.ReadInt32();
				break;
			case 48u:
				EventBattleLevelMin = input.ReadInt32();
				break;
			case 56u:
				GroupId = input.ReadInt32();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 72u:
				NormalBattleLevelMax = input.ReadInt32();
				break;
			case 80u:
				NormalBattleLevelMin = input.ReadInt32();
				break;
			case 88u:
			case 90u:
				roomGroupId_.AddEntriesFrom(ref input, _repeated_roomGroupId_codec);
				break;
			case 96u:
			case 98u:
				roomRatio_.AddEntriesFrom(ref input, _repeated_roomRatio_codec);
				break;
			case 104u:
				ShopRoomCount = input.ReadInt32();
				break;
			case 112u:
				TreasureRoomCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
