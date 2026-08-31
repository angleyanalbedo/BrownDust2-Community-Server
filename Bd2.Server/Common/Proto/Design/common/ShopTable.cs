using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ShopTable : IMessage<ShopTable>, IMessage, IEquatable<ShopTable>, IDeepCloneable<ShopTable>, IBufferMessage
{
	private static readonly MessageParser<ShopTable> _parser = new MessageParser<ShopTable>(() => new ShopTable());

	private UnknownFieldSet _unknownFields;

	public const int BargainLocalTextIdFieldNumber = 1;

	private int bargainLocalTextId_;

	public const int GroupBadMessageLocalTextIdFieldNumber = 2;

	private int groupBadMessageLocalTextId_;

	public const int GroupBadNoticeLocalTextIdFieldNumber = 3;

	private int groupBadNoticeLocalTextId_;

	public const int GroupGoodMessageLocalTextIdFieldNumber = 4;

	private int groupGoodMessageLocalTextId_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int MapNameTextIdFieldNumber = 6;

	private int mapNameTextId_;

	public const int NpcLocalTextIdFieldNumber = 7;

	private int npcLocalTextId_;

	public const int PackIdFieldNumber = 8;

	private int packId_;

	public const int PriceIdFieldNumber = 9;

	private static readonly FieldCodec<int> _repeated_priceId_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> priceId_ = new RepeatedField<int>();

	public const int PriceTypeFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_priceType_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> priceType_ = new RepeatedField<int>();

	public const int ResetCountFieldNumber = 11;

	private int resetCount_;

	public const int ResetTermTypeFieldNumber = 12;

	private int resetTermType_;

	public const int ShopTypeFieldNumber = 13;

	private int shopType_;

	public const int StartDayFieldNumber = 14;

	private int startDay_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShopTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ShopTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BargainLocalTextId
	{
		get
		{
			return bargainLocalTextId_;
		}
		set
		{
			bargainLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupBadMessageLocalTextId
	{
		get
		{
			return groupBadMessageLocalTextId_;
		}
		set
		{
			groupBadMessageLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupBadNoticeLocalTextId
	{
		get
		{
			return groupBadNoticeLocalTextId_;
		}
		set
		{
			groupBadNoticeLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GroupGoodMessageLocalTextId
	{
		get
		{
			return groupGoodMessageLocalTextId_;
		}
		set
		{
			groupGoodMessageLocalTextId_ = value;
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
	public int MapNameTextId
	{
		get
		{
			return mapNameTextId_;
		}
		set
		{
			mapNameTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int NpcLocalTextId
	{
		get
		{
			return npcLocalTextId_;
		}
		set
		{
			npcLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PackId
	{
		get
		{
			return packId_;
		}
		set
		{
			packId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> PriceId => priceId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PriceType => priceType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResetCount
	{
		get
		{
			return resetCount_;
		}
		set
		{
			resetCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResetTermType
	{
		get
		{
			return resetTermType_;
		}
		set
		{
			resetTermType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShopType
	{
		get
		{
			return shopType_;
		}
		set
		{
			shopType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int StartDay
	{
		get
		{
			return startDay_;
		}
		set
		{
			startDay_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShopTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShopTable(ShopTable other)
		: this()
	{
		bargainLocalTextId_ = other.bargainLocalTextId_;
		groupBadMessageLocalTextId_ = other.groupBadMessageLocalTextId_;
		groupBadNoticeLocalTextId_ = other.groupBadNoticeLocalTextId_;
		groupGoodMessageLocalTextId_ = other.groupGoodMessageLocalTextId_;
		id_ = other.id_;
		mapNameTextId_ = other.mapNameTextId_;
		npcLocalTextId_ = other.npcLocalTextId_;
		packId_ = other.packId_;
		priceId_ = other.priceId_.Clone();
		priceType_ = other.priceType_.Clone();
		resetCount_ = other.resetCount_;
		resetTermType_ = other.resetTermType_;
		shopType_ = other.shopType_;
		startDay_ = other.startDay_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShopTable Clone()
	{
		return new ShopTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ShopTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShopTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BargainLocalTextId == other.BargainLocalTextId && GroupBadMessageLocalTextId == other.GroupBadMessageLocalTextId && GroupBadNoticeLocalTextId == other.GroupBadNoticeLocalTextId && GroupGoodMessageLocalTextId == other.GroupGoodMessageLocalTextId && Id == other.Id && MapNameTextId == other.MapNameTextId && NpcLocalTextId == other.NpcLocalTextId && PackId == other.PackId && priceId_.Equals(other.priceId_) && priceType_.Equals(other.priceType_) && ResetCount == other.ResetCount && ResetTermType == other.ResetTermType && ShopType == other.ShopType && StartDay == other.StartDay)
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
		if (BargainLocalTextId != 0)
		{
			num ^= BargainLocalTextId.GetHashCode();
		}
		if (GroupBadMessageLocalTextId != 0)
		{
			num ^= GroupBadMessageLocalTextId.GetHashCode();
		}
		if (GroupBadNoticeLocalTextId != 0)
		{
			num ^= GroupBadNoticeLocalTextId.GetHashCode();
		}
		if (GroupGoodMessageLocalTextId != 0)
		{
			num ^= GroupGoodMessageLocalTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MapNameTextId != 0)
		{
			num ^= MapNameTextId.GetHashCode();
		}
		if (NpcLocalTextId != 0)
		{
			num ^= NpcLocalTextId.GetHashCode();
		}
		if (PackId != 0)
		{
			num ^= PackId.GetHashCode();
		}
		num ^= priceId_.GetHashCode();
		num ^= priceType_.GetHashCode();
		if (ResetCount != 0)
		{
			num ^= ResetCount.GetHashCode();
		}
		if (ResetTermType != 0)
		{
			num ^= ResetTermType.GetHashCode();
		}
		if (ShopType != 0)
		{
			num ^= ShopType.GetHashCode();
		}
		if (StartDay != 0)
		{
			num ^= StartDay.GetHashCode();
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
		if (BargainLocalTextId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BargainLocalTextId);
		}
		if (GroupBadMessageLocalTextId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GroupBadMessageLocalTextId);
		}
		if (GroupBadNoticeLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupBadNoticeLocalTextId);
		}
		if (GroupGoodMessageLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupGoodMessageLocalTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (MapNameTextId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MapNameTextId);
		}
		if (NpcLocalTextId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(NpcLocalTextId);
		}
		if (PackId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PackId);
		}
		priceId_.WriteTo(ref output, _repeated_priceId_codec);
		priceType_.WriteTo(ref output, _repeated_priceType_codec);
		if (ResetCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ResetCount);
		}
		if (ResetTermType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(ResetTermType);
		}
		if (ShopType != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(ShopType);
		}
		if (StartDay != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(StartDay);
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
		if (BargainLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BargainLocalTextId);
		}
		if (GroupBadMessageLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupBadMessageLocalTextId);
		}
		if (GroupBadNoticeLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupBadNoticeLocalTextId);
		}
		if (GroupGoodMessageLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupGoodMessageLocalTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MapNameTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapNameTextId);
		}
		if (NpcLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NpcLocalTextId);
		}
		if (PackId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PackId);
		}
		num += priceId_.CalculateSize(_repeated_priceId_codec);
		num += priceType_.CalculateSize(_repeated_priceType_codec);
		if (ResetCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResetCount);
		}
		if (ResetTermType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResetTermType);
		}
		if (ShopType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopType);
		}
		if (StartDay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StartDay);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShopTable other)
	{
		if (other != null)
		{
			if (other.BargainLocalTextId != 0)
			{
				BargainLocalTextId = other.BargainLocalTextId;
			}
			if (other.GroupBadMessageLocalTextId != 0)
			{
				GroupBadMessageLocalTextId = other.GroupBadMessageLocalTextId;
			}
			if (other.GroupBadNoticeLocalTextId != 0)
			{
				GroupBadNoticeLocalTextId = other.GroupBadNoticeLocalTextId;
			}
			if (other.GroupGoodMessageLocalTextId != 0)
			{
				GroupGoodMessageLocalTextId = other.GroupGoodMessageLocalTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MapNameTextId != 0)
			{
				MapNameTextId = other.MapNameTextId;
			}
			if (other.NpcLocalTextId != 0)
			{
				NpcLocalTextId = other.NpcLocalTextId;
			}
			if (other.PackId != 0)
			{
				PackId = other.PackId;
			}
			priceId_.Add(other.priceId_);
			priceType_.Add(other.priceType_);
			if (other.ResetCount != 0)
			{
				ResetCount = other.ResetCount;
			}
			if (other.ResetTermType != 0)
			{
				ResetTermType = other.ResetTermType;
			}
			if (other.ShopType != 0)
			{
				ShopType = other.ShopType;
			}
			if (other.StartDay != 0)
			{
				StartDay = other.StartDay;
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
			case 8u:
				BargainLocalTextId = input.ReadInt32();
				break;
			case 16u:
				GroupBadMessageLocalTextId = input.ReadInt32();
				break;
			case 24u:
				GroupBadNoticeLocalTextId = input.ReadInt32();
				break;
			case 32u:
				GroupGoodMessageLocalTextId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				MapNameTextId = input.ReadInt32();
				break;
			case 56u:
				NpcLocalTextId = input.ReadInt32();
				break;
			case 64u:
				PackId = input.ReadInt32();
				break;
			case 72u:
			case 74u:
				priceId_.AddEntriesFrom(ref input, _repeated_priceId_codec);
				break;
			case 80u:
			case 82u:
				priceType_.AddEntriesFrom(ref input, _repeated_priceType_codec);
				break;
			case 88u:
				ResetCount = input.ReadInt32();
				break;
			case 96u:
				ResetTermType = input.ReadInt32();
				break;
			case 104u:
				ShopType = input.ReadInt32();
				break;
			case 112u:
				StartDay = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
