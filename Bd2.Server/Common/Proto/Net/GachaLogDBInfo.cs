using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GachaLogDBInfo : IMessage<GachaLogDBInfo>, IMessage, IEquatable<GachaLogDBInfo>, IDeepCloneable<GachaLogDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GachaLogDBInfo> _parser = new MessageParser<GachaLogDBInfo>(() => new GachaLogDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int GachaGroupIdFieldNumber = 1;

	private int gachaGroupId_;

	public const int GachaIdFieldNumber = 2;

	private int gachaId_;

	public const int BuyTypeFieldNumber = 3;

	private Define_GachaBuyType buyType_;

	public const int GachaCountFieldNumber = 4;

	private int gachaCount_;

	public const int GetPointFieldNumber = 5;

	private int getPoint_;

	public const int GachaTypeFieldNumber = 6;

	private Define_GachaType gachaType_;

	public const int PickupItemIdFieldNumber = 7;

	private int pickupItemId_;

	public const int GachaFixedInfoFieldNumber = 8;

	private static readonly FieldCodec<GachaFixedDBInfo> _repeated_gachaFixedInfo_codec = FieldCodec.ForMessage(66u, GachaFixedDBInfo.Parser);

	private readonly RepeatedField<GachaFixedDBInfo> gachaFixedInfo_ = new RepeatedField<GachaFixedDBInfo>();

	public const int RewardInfoBundleFieldNumber = 9;

	private RewardDBInfoBundle rewardInfoBundle_;

	public const int NewSortFieldNumber = 10;

	private static readonly FieldCodec<int> _repeated_newSort_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> newSort_ = new RepeatedField<int>();

	public const int SelectionSortFieldNumber = 11;

	private static readonly FieldCodec<int> _repeated_selectionSort_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> selectionSort_ = new RepeatedField<int>();

	public const int DecreaseItemInfoFieldNumber = 12;

	private static readonly FieldCodec<ItemMaterialInfo> _repeated_decreaseItemInfo_codec = FieldCodec.ForMessage(98u, ItemMaterialInfo.Parser);

	private readonly RepeatedField<ItemMaterialInfo> decreaseItemInfo_ = new RepeatedField<ItemMaterialInfo>();

	public const int LogTimeFieldNumber = 13;

	private long logTime_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GachaLogDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GachaLogDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GachaGroupId
	{
		get
		{
			return gachaGroupId_;
		}
		set
		{
			gachaGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Define_GachaBuyType BuyType
	{
		get
		{
			return buyType_;
		}
		set
		{
			buyType_ = value;
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
	public int GetPoint
	{
		get
		{
			return getPoint_;
		}
		set
		{
			getPoint_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Define_GachaType GachaType
	{
		get
		{
			return gachaType_;
		}
		set
		{
			gachaType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PickupItemId
	{
		get
		{
			return pickupItemId_;
		}
		set
		{
			pickupItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GachaFixedDBInfo> GachaFixedInfo => gachaFixedInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle RewardInfoBundle
	{
		get
		{
			return rewardInfoBundle_;
		}
		set
		{
			rewardInfoBundle_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> NewSort => newSort_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SelectionSort => selectionSort_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemMaterialInfo> DecreaseItemInfo => decreaseItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long LogTime
	{
		get
		{
			return logTime_;
		}
		set
		{
			logTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaLogDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GachaLogDBInfo(GachaLogDBInfo other)
		: this()
	{
		gachaGroupId_ = other.gachaGroupId_;
		gachaId_ = other.gachaId_;
		buyType_ = other.buyType_;
		gachaCount_ = other.gachaCount_;
		getPoint_ = other.getPoint_;
		gachaType_ = other.gachaType_;
		pickupItemId_ = other.pickupItemId_;
		gachaFixedInfo_ = other.gachaFixedInfo_.Clone();
		rewardInfoBundle_ = ((other.rewardInfoBundle_ != null) ? other.rewardInfoBundle_.Clone() : null);
		newSort_ = other.newSort_.Clone();
		selectionSort_ = other.selectionSort_.Clone();
		decreaseItemInfo_ = other.decreaseItemInfo_.Clone();
		logTime_ = other.logTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GachaLogDBInfo Clone()
	{
		return new GachaLogDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GachaLogDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GachaLogDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GachaGroupId == other.GachaGroupId && GachaId == other.GachaId && BuyType == other.BuyType && GachaCount == other.GachaCount && GetPoint == other.GetPoint && GachaType == other.GachaType && PickupItemId == other.PickupItemId && gachaFixedInfo_.Equals(other.gachaFixedInfo_) && object.Equals(RewardInfoBundle, other.RewardInfoBundle) && newSort_.Equals(other.newSort_) && selectionSort_.Equals(other.selectionSort_) && decreaseItemInfo_.Equals(other.decreaseItemInfo_) && LogTime == other.LogTime)
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
		if (GachaGroupId != 0)
		{
			num ^= GachaGroupId.GetHashCode();
		}
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		if (BuyType != Define_GachaBuyType.GbFree)
		{
			num ^= BuyType.GetHashCode();
		}
		if (GachaCount != 0)
		{
			num ^= GachaCount.GetHashCode();
		}
		if (GetPoint != 0)
		{
			num ^= GetPoint.GetHashCode();
		}
		if (GachaType != Define_GachaType.GtUnion)
		{
			num ^= GachaType.GetHashCode();
		}
		if (PickupItemId != 0)
		{
			num ^= PickupItemId.GetHashCode();
		}
		num ^= gachaFixedInfo_.GetHashCode();
		if (rewardInfoBundle_ != null)
		{
			num ^= RewardInfoBundle.GetHashCode();
		}
		num ^= newSort_.GetHashCode();
		num ^= selectionSort_.GetHashCode();
		num ^= decreaseItemInfo_.GetHashCode();
		if (LogTime != 0L)
		{
			num ^= LogTime.GetHashCode();
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
		if (GachaGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GachaGroupId);
		}
		if (GachaId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GachaId);
		}
		if (BuyType != Define_GachaBuyType.GbFree)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)BuyType);
		}
		if (GachaCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GachaCount);
		}
		if (GetPoint != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GetPoint);
		}
		if (GachaType != Define_GachaType.GtUnion)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)GachaType);
		}
		if (PickupItemId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(PickupItemId);
		}
		gachaFixedInfo_.WriteTo(ref output, _repeated_gachaFixedInfo_codec);
		if (rewardInfoBundle_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(RewardInfoBundle);
		}
		newSort_.WriteTo(ref output, _repeated_newSort_codec);
		selectionSort_.WriteTo(ref output, _repeated_selectionSort_codec);
		decreaseItemInfo_.WriteTo(ref output, _repeated_decreaseItemInfo_codec);
		if (LogTime != 0L)
		{
			output.WriteRawTag(104);
			output.WriteInt64(LogTime);
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
		if (GachaGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaGroupId);
		}
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaId);
		}
		if (BuyType != Define_GachaBuyType.GbFree)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BuyType);
		}
		if (GachaCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GachaCount);
		}
		if (GetPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GetPoint);
		}
		if (GachaType != Define_GachaType.GtUnion)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GachaType);
		}
		if (PickupItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PickupItemId);
		}
		num += gachaFixedInfo_.CalculateSize(_repeated_gachaFixedInfo_codec);
		if (rewardInfoBundle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardInfoBundle);
		}
		num += newSort_.CalculateSize(_repeated_newSort_codec);
		num += selectionSort_.CalculateSize(_repeated_selectionSort_codec);
		num += decreaseItemInfo_.CalculateSize(_repeated_decreaseItemInfo_codec);
		if (LogTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(LogTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GachaLogDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GachaGroupId != 0)
		{
			GachaGroupId = other.GachaGroupId;
		}
		if (other.GachaId != 0)
		{
			GachaId = other.GachaId;
		}
		if (other.BuyType != Define_GachaBuyType.GbFree)
		{
			BuyType = other.BuyType;
		}
		if (other.GachaCount != 0)
		{
			GachaCount = other.GachaCount;
		}
		if (other.GetPoint != 0)
		{
			GetPoint = other.GetPoint;
		}
		if (other.GachaType != Define_GachaType.GtUnion)
		{
			GachaType = other.GachaType;
		}
		if (other.PickupItemId != 0)
		{
			PickupItemId = other.PickupItemId;
		}
		gachaFixedInfo_.Add(other.gachaFixedInfo_);
		if (other.rewardInfoBundle_ != null)
		{
			if (rewardInfoBundle_ == null)
			{
				RewardInfoBundle = new RewardDBInfoBundle();
			}
			RewardInfoBundle.MergeFrom(other.RewardInfoBundle);
		}
		newSort_.Add(other.newSort_);
		selectionSort_.Add(other.selectionSort_);
		decreaseItemInfo_.Add(other.decreaseItemInfo_);
		if (other.LogTime != 0L)
		{
			LogTime = other.LogTime;
		}
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
				GachaGroupId = input.ReadInt32();
				break;
			case 16u:
				GachaId = input.ReadInt32();
				break;
			case 24u:
				BuyType = (Define_GachaBuyType)input.ReadEnum();
				break;
			case 32u:
				GachaCount = input.ReadInt32();
				break;
			case 40u:
				GetPoint = input.ReadInt32();
				break;
			case 48u:
				GachaType = (Define_GachaType)input.ReadEnum();
				break;
			case 56u:
				PickupItemId = input.ReadInt32();
				break;
			case 66u:
				gachaFixedInfo_.AddEntriesFrom(ref input, _repeated_gachaFixedInfo_codec);
				break;
			case 74u:
				if (rewardInfoBundle_ == null)
				{
					RewardInfoBundle = new RewardDBInfoBundle();
				}
				input.ReadMessage(RewardInfoBundle);
				break;
			case 80u:
			case 82u:
				newSort_.AddEntriesFrom(ref input, _repeated_newSort_codec);
				break;
			case 88u:
			case 90u:
				selectionSort_.AddEntriesFrom(ref input, _repeated_selectionSort_codec);
				break;
			case 98u:
				decreaseItemInfo_.AddEntriesFrom(ref input, _repeated_decreaseItemInfo_codec);
				break;
			case 104u:
				LogTime = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
