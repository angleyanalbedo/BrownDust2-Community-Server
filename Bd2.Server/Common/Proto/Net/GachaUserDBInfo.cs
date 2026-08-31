using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaUserDBInfo : IMessage<GachaUserDBInfo>, IMessage, IEquatable<GachaUserDBInfo>, IDeepCloneable<GachaUserDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GachaUserDBInfo> _parser = new MessageParser<GachaUserDBInfo>(() => new GachaUserDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int PointFieldNumber = 2;

	private int point_;

	public const int TotalBuyCountFieldNumber = 3;

	private int totalBuyCount_;

	public const int OneFreePickCountFieldNumber = 4;

	private int oneFreePickCount_;

	public const int OneCashPickCountFieldNumber = 5;

	private int oneCashPickCount_;

	public const int TenFreePickCountFieldNumber = 6;

	private int tenFreePickCount_;

	public const int TenCashPickCountFieldNumber = 7;

	private int tenCashPickCount_;

	public const int ExchangeItemCountFieldNumber = 8;

	private int exchangeItemCount_;

	public const int ExchangeMileageCountFieldNumber = 9;

	private int exchangeMileageCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GachaUserDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GachaUserDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int Point
	{
		get
		{
			return point_;
		}
		set
		{
			point_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TotalBuyCount
	{
		get
		{
			return totalBuyCount_;
		}
		set
		{
			totalBuyCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OneFreePickCount
	{
		get
		{
			return oneFreePickCount_;
		}
		set
		{
			oneFreePickCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OneCashPickCount
	{
		get
		{
			return oneCashPickCount_;
		}
		set
		{
			oneCashPickCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TenFreePickCount
	{
		get
		{
			return tenFreePickCount_;
		}
		set
		{
			tenFreePickCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TenCashPickCount
	{
		get
		{
			return tenCashPickCount_;
		}
		set
		{
			tenCashPickCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ExchangeItemCount
	{
		get
		{
			return exchangeItemCount_;
		}
		set
		{
			exchangeItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ExchangeMileageCount
	{
		get
		{
			return exchangeMileageCount_;
		}
		set
		{
			exchangeMileageCount_ = value;
		}
	}

	public int BeforePoint { get; set; }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaUserDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaUserDBInfo(GachaUserDBInfo other)
		: this()
	{
		groupId_ = other.groupId_;
		point_ = other.point_;
		totalBuyCount_ = other.totalBuyCount_;
		oneFreePickCount_ = other.oneFreePickCount_;
		oneCashPickCount_ = other.oneCashPickCount_;
		tenFreePickCount_ = other.tenFreePickCount_;
		tenCashPickCount_ = other.tenCashPickCount_;
		exchangeItemCount_ = other.exchangeItemCount_;
		exchangeMileageCount_ = other.exchangeMileageCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaUserDBInfo Clone()
	{
		return new GachaUserDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaUserDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaUserDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && Point == other.Point && TotalBuyCount == other.TotalBuyCount && OneFreePickCount == other.OneFreePickCount && OneCashPickCount == other.OneCashPickCount && TenFreePickCount == other.TenFreePickCount && TenCashPickCount == other.TenCashPickCount && ExchangeItemCount == other.ExchangeItemCount && ExchangeMileageCount == other.ExchangeMileageCount)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Point != 0)
		{
			num ^= Point.GetHashCode();
		}
		if (TotalBuyCount != 0)
		{
			num ^= TotalBuyCount.GetHashCode();
		}
		if (OneFreePickCount != 0)
		{
			num ^= OneFreePickCount.GetHashCode();
		}
		if (OneCashPickCount != 0)
		{
			num ^= OneCashPickCount.GetHashCode();
		}
		if (TenFreePickCount != 0)
		{
			num ^= TenFreePickCount.GetHashCode();
		}
		if (TenCashPickCount != 0)
		{
			num ^= TenCashPickCount.GetHashCode();
		}
		if (ExchangeItemCount != 0)
		{
			num ^= ExchangeItemCount.GetHashCode();
		}
		if (ExchangeMileageCount != 0)
		{
			num ^= ExchangeMileageCount.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (Point != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Point);
		}
		if (TotalBuyCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TotalBuyCount);
		}
		if (OneFreePickCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(OneFreePickCount);
		}
		if (OneCashPickCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(OneCashPickCount);
		}
		if (TenFreePickCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TenFreePickCount);
		}
		if (TenCashPickCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TenCashPickCount);
		}
		if (ExchangeItemCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ExchangeItemCount);
		}
		if (ExchangeMileageCount != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ExchangeMileageCount);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Point != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Point);
		}
		if (TotalBuyCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalBuyCount);
		}
		if (OneFreePickCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OneFreePickCount);
		}
		if (OneCashPickCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OneCashPickCount);
		}
		if (TenFreePickCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TenFreePickCount);
		}
		if (TenCashPickCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TenCashPickCount);
		}
		if (ExchangeItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExchangeItemCount);
		}
		if (ExchangeMileageCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExchangeMileageCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaUserDBInfo other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Point != 0)
			{
				Point = other.Point;
			}
			if (other.TotalBuyCount != 0)
			{
				TotalBuyCount = other.TotalBuyCount;
			}
			if (other.OneFreePickCount != 0)
			{
				OneFreePickCount = other.OneFreePickCount;
			}
			if (other.OneCashPickCount != 0)
			{
				OneCashPickCount = other.OneCashPickCount;
			}
			if (other.TenFreePickCount != 0)
			{
				TenFreePickCount = other.TenFreePickCount;
			}
			if (other.TenCashPickCount != 0)
			{
				TenCashPickCount = other.TenCashPickCount;
			}
			if (other.ExchangeItemCount != 0)
			{
				ExchangeItemCount = other.ExchangeItemCount;
			}
			if (other.ExchangeMileageCount != 0)
			{
				ExchangeMileageCount = other.ExchangeMileageCount;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
				Point = input.ReadInt32();
				break;
			case 24u:
				TotalBuyCount = input.ReadInt32();
				break;
			case 32u:
				OneFreePickCount = input.ReadInt32();
				break;
			case 40u:
				OneCashPickCount = input.ReadInt32();
				break;
			case 48u:
				TenFreePickCount = input.ReadInt32();
				break;
			case 56u:
				TenCashPickCount = input.ReadInt32();
				break;
			case 64u:
				ExchangeItemCount = input.ReadInt32();
				break;
			case 72u:
				ExchangeMileageCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
