using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class RewardDBInfoBundle : IMessage<RewardDBInfoBundle>, IMessage, IEquatable<RewardDBInfoBundle>, IDeepCloneable<RewardDBInfoBundle>, IBufferMessage
{
	private static readonly MessageParser<RewardDBInfoBundle> _parser = new MessageParser<RewardDBInfoBundle>(() => new RewardDBInfoBundle());

	private UnknownFieldSet _unknownFields;

	public const int ItemInfoFieldNumber = 1;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(10u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int CharInfoFieldNumber = 2;

	private static readonly FieldCodec<CharDBInfo> _repeated_charInfo_codec = FieldCodec.ForMessage(18u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> charInfo_ = new RepeatedField<CharDBInfo>();

	public const int CostumeInfoFieldNumber = 3;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_costumeInfo_codec = FieldCodec.ForMessage(26u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> costumeInfo_ = new RepeatedField<CostumeDBInfo>();

	public const int EquipInfoFieldNumber = 4;

	private static readonly FieldCodec<EquipDBInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage(34u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> equipInfo_ = new RepeatedField<EquipDBInfo>();

	public const int MyRoomTrophyInfoFieldNumber = 5;

	private static readonly FieldCodec<MyRoomTrophyDBInfo> _repeated_myRoomTrophyInfo_codec = FieldCodec.ForMessage(42u, MyRoomTrophyDBInfo.Parser);

	private readonly RepeatedField<MyRoomTrophyDBInfo> myRoomTrophyInfo_ = new RepeatedField<MyRoomTrophyDBInfo>();

	public const int ViewItemInfoFieldNumber = 6;

	private static readonly FieldCodec<ItemDBInfo> _repeated_viewItemInfo_codec = FieldCodec.ForMessage(50u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> viewItemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int OriginalItemInfoFieldNumber = 7;

	private static readonly FieldCodec<ItemDBInfo> _repeated_originalItemInfo_codec = FieldCodec.ForMessage(58u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> originalItemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int ItemAutoExchangeInfoFieldNumber = 8;

	private static readonly FieldCodec<ItemAutoExchangeInfo> _repeated_itemAutoExchangeInfo_codec = FieldCodec.ForMessage(66u, Bd2.Server.Common.Proto.Net.ItemAutoExchangeInfo.Parser);

	private readonly RepeatedField<ItemAutoExchangeInfo> itemAutoExchangeInfo_ = new RepeatedField<ItemAutoExchangeInfo>();

	public const int ItemAutoUpgradeInfoFieldNumber = 9;

	private static readonly FieldCodec<ItemAutoUpgradeInfo> _repeated_itemAutoUpgradeInfo_codec = FieldCodec.ForMessage(74u, Bd2.Server.Common.Proto.Net.ItemAutoUpgradeInfo.Parser);

	private readonly RepeatedField<ItemAutoUpgradeInfo> itemAutoUpgradeInfo_ = new RepeatedField<ItemAutoUpgradeInfo>();

	public const int RepaidCurrencyFieldNumber = 10;

	private static readonly FieldCodec<RewardDBInfo> _repeated_repaidCurrency_codec = FieldCodec.ForMessage(82u, RewardDBInfo.Parser);

	private readonly RepeatedField<RewardDBInfo> repaidCurrency_ = new RepeatedField<RewardDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RewardDBInfoBundle> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RewardDBInfoBundleReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CharDBInfo> CharInfo => charInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CostumeDBInfo> CostumeInfo => costumeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipDBInfo> EquipInfo => equipInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MyRoomTrophyDBInfo> MyRoomTrophyInfo => myRoomTrophyInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> ViewItemInfo => viewItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemDBInfo> OriginalItemInfo => originalItemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemAutoExchangeInfo> ItemAutoExchangeInfo => itemAutoExchangeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ItemAutoUpgradeInfo> ItemAutoUpgradeInfo => itemAutoUpgradeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<RewardDBInfo> RepaidCurrency => repaidCurrency_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle(RewardDBInfoBundle other)
		: this()
	{
		itemInfo_ = other.itemInfo_.Clone();
		charInfo_ = other.charInfo_.Clone();
		costumeInfo_ = other.costumeInfo_.Clone();
		equipInfo_ = other.equipInfo_.Clone();
		myRoomTrophyInfo_ = other.myRoomTrophyInfo_.Clone();
		viewItemInfo_ = other.viewItemInfo_.Clone();
		originalItemInfo_ = other.originalItemInfo_.Clone();
		itemAutoExchangeInfo_ = other.itemAutoExchangeInfo_.Clone();
		itemAutoUpgradeInfo_ = other.itemAutoUpgradeInfo_.Clone();
		repaidCurrency_ = other.repaidCurrency_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RewardDBInfoBundle Clone()
	{
		return new RewardDBInfoBundle(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RewardDBInfoBundle);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RewardDBInfoBundle other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (itemInfo_.Equals(other.itemInfo_) && charInfo_.Equals(other.charInfo_) && costumeInfo_.Equals(other.costumeInfo_) && equipInfo_.Equals(other.equipInfo_) && myRoomTrophyInfo_.Equals(other.myRoomTrophyInfo_) && viewItemInfo_.Equals(other.viewItemInfo_) && originalItemInfo_.Equals(other.originalItemInfo_) && itemAutoExchangeInfo_.Equals(other.itemAutoExchangeInfo_) && itemAutoUpgradeInfo_.Equals(other.itemAutoUpgradeInfo_) && repaidCurrency_.Equals(other.repaidCurrency_))
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
		num ^= itemInfo_.GetHashCode();
		num ^= charInfo_.GetHashCode();
		num ^= costumeInfo_.GetHashCode();
		num ^= equipInfo_.GetHashCode();
		num ^= myRoomTrophyInfo_.GetHashCode();
		num ^= viewItemInfo_.GetHashCode();
		num ^= originalItemInfo_.GetHashCode();
		num ^= itemAutoExchangeInfo_.GetHashCode();
		num ^= itemAutoUpgradeInfo_.GetHashCode();
		num ^= repaidCurrency_.GetHashCode();
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
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
		charInfo_.WriteTo(ref output, _repeated_charInfo_codec);
		costumeInfo_.WriteTo(ref output, _repeated_costumeInfo_codec);
		equipInfo_.WriteTo(ref output, _repeated_equipInfo_codec);
		myRoomTrophyInfo_.WriteTo(ref output, _repeated_myRoomTrophyInfo_codec);
		viewItemInfo_.WriteTo(ref output, _repeated_viewItemInfo_codec);
		originalItemInfo_.WriteTo(ref output, _repeated_originalItemInfo_codec);
		itemAutoExchangeInfo_.WriteTo(ref output, _repeated_itemAutoExchangeInfo_codec);
		itemAutoUpgradeInfo_.WriteTo(ref output, _repeated_itemAutoUpgradeInfo_codec);
		repaidCurrency_.WriteTo(ref output, _repeated_repaidCurrency_codec);
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
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		num += charInfo_.CalculateSize(_repeated_charInfo_codec);
		num += costumeInfo_.CalculateSize(_repeated_costumeInfo_codec);
		num += equipInfo_.CalculateSize(_repeated_equipInfo_codec);
		num += myRoomTrophyInfo_.CalculateSize(_repeated_myRoomTrophyInfo_codec);
		num += viewItemInfo_.CalculateSize(_repeated_viewItemInfo_codec);
		num += originalItemInfo_.CalculateSize(_repeated_originalItemInfo_codec);
		num += itemAutoExchangeInfo_.CalculateSize(_repeated_itemAutoExchangeInfo_codec);
		num += itemAutoUpgradeInfo_.CalculateSize(_repeated_itemAutoUpgradeInfo_codec);
		num += repaidCurrency_.CalculateSize(_repeated_repaidCurrency_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RewardDBInfoBundle other)
	{
		if (other != null)
		{
			itemInfo_.Add(other.itemInfo_);
			charInfo_.Add(other.charInfo_);
			costumeInfo_.Add(other.costumeInfo_);
			equipInfo_.Add(other.equipInfo_);
			myRoomTrophyInfo_.Add(other.myRoomTrophyInfo_);
			viewItemInfo_.Add(other.viewItemInfo_);
			originalItemInfo_.Add(other.originalItemInfo_);
			itemAutoExchangeInfo_.Add(other.itemAutoExchangeInfo_);
			itemAutoUpgradeInfo_.Add(other.itemAutoUpgradeInfo_);
			repaidCurrency_.Add(other.repaidCurrency_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			case 18u:
				charInfo_.AddEntriesFrom(ref input, _repeated_charInfo_codec);
				break;
			case 26u:
				costumeInfo_.AddEntriesFrom(ref input, _repeated_costumeInfo_codec);
				break;
			case 34u:
				equipInfo_.AddEntriesFrom(ref input, _repeated_equipInfo_codec);
				break;
			case 42u:
				myRoomTrophyInfo_.AddEntriesFrom(ref input, _repeated_myRoomTrophyInfo_codec);
				break;
			case 50u:
				viewItemInfo_.AddEntriesFrom(ref input, _repeated_viewItemInfo_codec);
				break;
			case 58u:
				originalItemInfo_.AddEntriesFrom(ref input, _repeated_originalItemInfo_codec);
				break;
			case 66u:
				itemAutoExchangeInfo_.AddEntriesFrom(ref input, _repeated_itemAutoExchangeInfo_codec);
				break;
			case 74u:
				itemAutoUpgradeInfo_.AddEntriesFrom(ref input, _repeated_itemAutoUpgradeInfo_codec);
				break;
			case 82u:
				repaidCurrency_.AddEntriesFrom(ref input, _repeated_repaidCurrency_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
