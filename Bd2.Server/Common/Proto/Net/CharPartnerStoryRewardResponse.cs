using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class CharPartnerStoryRewardResponse : IMessage<CharPartnerStoryRewardResponse>, IMessage, IEquatable<CharPartnerStoryRewardResponse>, IDeepCloneable<CharPartnerStoryRewardResponse>, IBufferMessage
{
	private static readonly MessageParser<CharPartnerStoryRewardResponse> _parser = new MessageParser<CharPartnerStoryRewardResponse>(() => new CharPartnerStoryRewardResponse());

	private UnknownFieldSet _unknownFields;

	public const int ItemInfoFieldNumber = 1;

	private static readonly FieldCodec<ItemDBInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(10u, ItemDBInfo.Parser);

	private readonly RepeatedField<ItemDBInfo> itemInfo_ = new RepeatedField<ItemDBInfo>();

	public const int RewardCharInfoFieldNumber = 2;

	private static readonly FieldCodec<CharDBInfo> _repeated_rewardCharInfo_codec = FieldCodec.ForMessage(18u, CharDBInfo.Parser);

	private readonly RepeatedField<CharDBInfo> rewardCharInfo_ = new RepeatedField<CharDBInfo>();

	public const int EquipInfoFieldNumber = 3;

	private static readonly FieldCodec<EquipDBInfo> _repeated_equipInfo_codec = FieldCodec.ForMessage(26u, EquipDBInfo.Parser);

	private readonly RepeatedField<EquipDBInfo> equipInfo_ = new RepeatedField<EquipDBInfo>();

	public const int CostumeInfoFieldNumber = 4;

	private static readonly FieldCodec<CostumeDBInfo> _repeated_costumeInfo_codec = FieldCodec.ForMessage(34u, CostumeDBInfo.Parser);

	private readonly RepeatedField<CostumeDBInfo> costumeInfo_ = new RepeatedField<CostumeDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharPartnerStoryRewardResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharPartnerStoryRewardResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ItemDBInfo> ItemInfo => itemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CharDBInfo> RewardCharInfo => rewardCharInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<EquipDBInfo> EquipInfo => equipInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<CostumeDBInfo> CostumeInfo => costumeInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharPartnerStoryRewardResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharPartnerStoryRewardResponse(CharPartnerStoryRewardResponse other)
		: this()
	{
		itemInfo_ = other.itemInfo_.Clone();
		rewardCharInfo_ = other.rewardCharInfo_.Clone();
		equipInfo_ = other.equipInfo_.Clone();
		costumeInfo_ = other.costumeInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharPartnerStoryRewardResponse Clone()
	{
		return new CharPartnerStoryRewardResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CharPartnerStoryRewardResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharPartnerStoryRewardResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (itemInfo_.Equals(other.itemInfo_) && rewardCharInfo_.Equals(other.rewardCharInfo_) && equipInfo_.Equals(other.equipInfo_) && costumeInfo_.Equals(other.costumeInfo_))
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
		num ^= rewardCharInfo_.GetHashCode();
		num ^= equipInfo_.GetHashCode();
		num ^= costumeInfo_.GetHashCode();
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
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
		rewardCharInfo_.WriteTo(ref output, _repeated_rewardCharInfo_codec);
		equipInfo_.WriteTo(ref output, _repeated_equipInfo_codec);
		costumeInfo_.WriteTo(ref output, _repeated_costumeInfo_codec);
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
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		num += rewardCharInfo_.CalculateSize(_repeated_rewardCharInfo_codec);
		num += equipInfo_.CalculateSize(_repeated_equipInfo_codec);
		num += costumeInfo_.CalculateSize(_repeated_costumeInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharPartnerStoryRewardResponse other)
	{
		if (other != null)
		{
			itemInfo_.Add(other.itemInfo_);
			rewardCharInfo_.Add(other.rewardCharInfo_);
			equipInfo_.Add(other.equipInfo_);
			costumeInfo_.Add(other.costumeInfo_);
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
			case 10u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			case 18u:
				rewardCharInfo_.AddEntriesFrom(ref input, _repeated_rewardCharInfo_codec);
				break;
			case 26u:
				equipInfo_.AddEntriesFrom(ref input, _repeated_equipInfo_codec);
				break;
			case 34u:
				costumeInfo_.AddEntriesFrom(ref input, _repeated_costumeInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
