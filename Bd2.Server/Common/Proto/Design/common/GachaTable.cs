using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GachaTable : IMessage<GachaTable>, IMessage, IEquatable<GachaTable>, IDeepCloneable<GachaTable>, IBufferMessage
{
	private static readonly MessageParser<GachaTable> _parser = new MessageParser<GachaTable>(() => new GachaTable());

	private UnknownFieldSet _unknownFields;

	public const int DailyPayGachaCountFieldNumber = 1;

	private int dailyPayGachaCount_;

	public const int DailyPayGachaPriceCountFieldNumber = 2;

	private int dailyPayGachaPriceCount_;

	public const int FreeCountDayFieldNumber = 3;

	private int freeCountDay_;

	public const int GachaCountFieldNumber = 4;

	private int gachaCount_;

	public const int GachaLocalTextIdFieldNumber = 5;

	private int gachaLocalTextId_;

	public const int GachaRewardIdFieldNumber = 6;

	private int gachaRewardId_;

	public const int GachaTicketIdFieldNumber = 7;

	private int gachaTicketId_;

	public const int IdFieldNumber = 8;

	private int id_;

	public const int PriceCountFieldNumber = 9;

	private int priceCount_;

	public const int PriceIdFieldNumber = 10;

	private int priceId_;

	public const int PriceTypeFieldNumber = 11;

	private int priceType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GachaTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int DailyPayGachaCount
	{
		get
		{
			return dailyPayGachaCount_;
		}
		set
		{
			dailyPayGachaCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DailyPayGachaPriceCount
	{
		get
		{
			return dailyPayGachaPriceCount_;
		}
		set
		{
			dailyPayGachaPriceCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FreeCountDay
	{
		get
		{
			return freeCountDay_;
		}
		set
		{
			freeCountDay_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GachaCount
	{
		get
		{
			return gachaCount_;
		}
		set
		{
			gachaCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GachaLocalTextId
	{
		get
		{
			return gachaLocalTextId_;
		}
		set
		{
			gachaLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GachaRewardId
	{
		get
		{
			return gachaRewardId_;
		}
		set
		{
			gachaRewardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GachaTicketId
	{
		get
		{
			return gachaTicketId_;
		}
		set
		{
			gachaTicketId_ = value;
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
	public int PriceCount
	{
		get
		{
			return priceCount_;
		}
		set
		{
			priceCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PriceId
	{
		get
		{
			return priceId_;
		}
		set
		{
			priceId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PriceType
	{
		get
		{
			return priceType_;
		}
		set
		{
			priceType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaTable(GachaTable other)
		: this()
	{
		dailyPayGachaCount_ = other.dailyPayGachaCount_;
		dailyPayGachaPriceCount_ = other.dailyPayGachaPriceCount_;
		freeCountDay_ = other.freeCountDay_;
		gachaCount_ = other.gachaCount_;
		gachaLocalTextId_ = other.gachaLocalTextId_;
		gachaRewardId_ = other.gachaRewardId_;
		gachaTicketId_ = other.gachaTicketId_;
		id_ = other.id_;
		priceCount_ = other.priceCount_;
		priceId_ = other.priceId_;
		priceType_ = other.priceType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaTable Clone()
	{
		return new GachaTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (DailyPayGachaCount == other.DailyPayGachaCount && DailyPayGachaPriceCount == other.DailyPayGachaPriceCount && FreeCountDay == other.FreeCountDay && GachaCount == other.GachaCount && GachaLocalTextId == other.GachaLocalTextId && GachaRewardId == other.GachaRewardId && GachaTicketId == other.GachaTicketId && Id == other.Id && PriceCount == other.PriceCount && PriceId == other.PriceId && PriceType == other.PriceType)
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
		if (DailyPayGachaCount != 0)
		{
			num ^= DailyPayGachaCount.GetHashCode();
		}
		if (DailyPayGachaPriceCount != 0)
		{
			num ^= DailyPayGachaPriceCount.GetHashCode();
		}
		if (FreeCountDay != 0)
		{
			num ^= FreeCountDay.GetHashCode();
		}
		if (GachaCount != 0)
		{
			num ^= GachaCount.GetHashCode();
		}
		if (GachaLocalTextId != 0)
		{
			num ^= GachaLocalTextId.GetHashCode();
		}
		if (GachaRewardId != 0)
		{
			num ^= GachaRewardId.GetHashCode();
		}
		if (GachaTicketId != 0)
		{
			num ^= GachaTicketId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PriceCount != 0)
		{
			num ^= PriceCount.GetHashCode();
		}
		if (PriceId != 0)
		{
			num ^= PriceId.GetHashCode();
		}
		if (PriceType != 0)
		{
			num ^= PriceType.GetHashCode();
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
		if (DailyPayGachaCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DailyPayGachaCount);
		}
		if (DailyPayGachaPriceCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DailyPayGachaPriceCount);
		}
		if (FreeCountDay != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(FreeCountDay);
		}
		if (GachaCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GachaCount);
		}
		if (GachaLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GachaLocalTextId);
		}
		if (GachaRewardId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(GachaRewardId);
		}
		if (GachaTicketId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GachaTicketId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Id);
		}
		if (PriceCount != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PriceCount);
		}
		if (PriceId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PriceId);
		}
		if (PriceType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(PriceType);
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
		if (DailyPayGachaCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DailyPayGachaCount);
		}
		if (DailyPayGachaPriceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DailyPayGachaPriceCount);
		}
		if (FreeCountDay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreeCountDay);
		}
		if (GachaCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaCount);
		}
		if (GachaLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaLocalTextId);
		}
		if (GachaRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaRewardId);
		}
		if (GachaTicketId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaTicketId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PriceCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceCount);
		}
		if (PriceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceId);
		}
		if (PriceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriceType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaTable other)
	{
		if (other != null)
		{
			if (other.DailyPayGachaCount != 0)
			{
				DailyPayGachaCount = other.DailyPayGachaCount;
			}
			if (other.DailyPayGachaPriceCount != 0)
			{
				DailyPayGachaPriceCount = other.DailyPayGachaPriceCount;
			}
			if (other.FreeCountDay != 0)
			{
				FreeCountDay = other.FreeCountDay;
			}
			if (other.GachaCount != 0)
			{
				GachaCount = other.GachaCount;
			}
			if (other.GachaLocalTextId != 0)
			{
				GachaLocalTextId = other.GachaLocalTextId;
			}
			if (other.GachaRewardId != 0)
			{
				GachaRewardId = other.GachaRewardId;
			}
			if (other.GachaTicketId != 0)
			{
				GachaTicketId = other.GachaTicketId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PriceCount != 0)
			{
				PriceCount = other.PriceCount;
			}
			if (other.PriceId != 0)
			{
				PriceId = other.PriceId;
			}
			if (other.PriceType != 0)
			{
				PriceType = other.PriceType;
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
				DailyPayGachaCount = input.ReadInt32();
				break;
			case 16u:
				DailyPayGachaPriceCount = input.ReadInt32();
				break;
			case 24u:
				FreeCountDay = input.ReadInt32();
				break;
			case 32u:
				GachaCount = input.ReadInt32();
				break;
			case 40u:
				GachaLocalTextId = input.ReadInt32();
				break;
			case 48u:
				GachaRewardId = input.ReadInt32();
				break;
			case 56u:
				GachaTicketId = input.ReadInt32();
				break;
			case 64u:
				Id = input.ReadInt32();
				break;
			case 72u:
				PriceCount = input.ReadInt32();
				break;
			case 80u:
				PriceId = input.ReadInt32();
				break;
			case 88u:
				PriceType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
