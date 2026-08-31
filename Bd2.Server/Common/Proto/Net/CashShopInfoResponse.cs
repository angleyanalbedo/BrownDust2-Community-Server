using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CashShopInfoResponse : IMessage<CashShopInfoResponse>, IMessage, IEquatable<CashShopInfoResponse>, IDeepCloneable<CashShopInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<CashShopInfoResponse> _parser = new MessageParser<CashShopInfoResponse>(() => new CashShopInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int ProductInfoFieldNumber = 1;

	private static readonly FieldCodec<CashProductDBInfo> _repeated_productInfo_codec = FieldCodec.ForMessage(10u, CashProductDBInfo.Parser);

	private readonly RepeatedField<CashProductDBInfo> productInfo_ = new RepeatedField<CashProductDBInfo>();

	public const int DailyResetTimeFieldNumber = 2;

	private long dailyResetTime_;

	public const int WeeklyResetTimeFieldNumber = 3;

	private long weeklyResetTime_;

	public const int MonthlyResetTimeFieldNumber = 4;

	private long monthlyResetTime_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CashShopInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CashShopInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CashProductDBInfo> ProductInfo => productInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DailyResetTime
	{
		get
		{
			return dailyResetTime_;
		}
		set
		{
			dailyResetTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long WeeklyResetTime
	{
		get
		{
			return weeklyResetTime_;
		}
		set
		{
			weeklyResetTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MonthlyResetTime
	{
		get
		{
			return monthlyResetTime_;
		}
		set
		{
			monthlyResetTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashShopInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CashShopInfoResponse(CashShopInfoResponse other)
		: this()
	{
		productInfo_ = other.productInfo_.Clone();
		dailyResetTime_ = other.dailyResetTime_;
		weeklyResetTime_ = other.weeklyResetTime_;
		monthlyResetTime_ = other.monthlyResetTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CashShopInfoResponse Clone()
	{
		return new CashShopInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CashShopInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CashShopInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (productInfo_.Equals(other.productInfo_) && DailyResetTime == other.DailyResetTime && WeeklyResetTime == other.WeeklyResetTime && MonthlyResetTime == other.MonthlyResetTime)
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
		num ^= productInfo_.GetHashCode();
		if (DailyResetTime != 0L)
		{
			num ^= DailyResetTime.GetHashCode();
		}
		if (WeeklyResetTime != 0L)
		{
			num ^= WeeklyResetTime.GetHashCode();
		}
		if (MonthlyResetTime != 0L)
		{
			num ^= MonthlyResetTime.GetHashCode();
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
		productInfo_.WriteTo(ref output, _repeated_productInfo_codec);
		if (DailyResetTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(DailyResetTime);
		}
		if (WeeklyResetTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(WeeklyResetTime);
		}
		if (MonthlyResetTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(MonthlyResetTime);
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
		num += productInfo_.CalculateSize(_repeated_productInfo_codec);
		if (DailyResetTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DailyResetTime);
		}
		if (WeeklyResetTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(WeeklyResetTime);
		}
		if (MonthlyResetTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(MonthlyResetTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CashShopInfoResponse other)
	{
		if (other != null)
		{
			productInfo_.Add(other.productInfo_);
			if (other.DailyResetTime != 0L)
			{
				DailyResetTime = other.DailyResetTime;
			}
			if (other.WeeklyResetTime != 0L)
			{
				WeeklyResetTime = other.WeeklyResetTime;
			}
			if (other.MonthlyResetTime != 0L)
			{
				MonthlyResetTime = other.MonthlyResetTime;
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
			case 10u:
				productInfo_.AddEntriesFrom(ref input, _repeated_productInfo_codec);
				break;
			case 16u:
				DailyResetTime = input.ReadInt64();
				break;
			case 24u:
				WeeklyResetTime = input.ReadInt64();
				break;
			case 32u:
				MonthlyResetTime = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
