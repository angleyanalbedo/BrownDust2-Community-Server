using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PassBuyTable : IMessage<PassBuyTable>, IMessage, IEquatable<PassBuyTable>, IDeepCloneable<PassBuyTable>, IBufferMessage
{
	private static readonly MessageParser<PassBuyTable> _parser = new MessageParser<PassBuyTable>(() => new PassBuyTable());

	private UnknownFieldSet _unknownFields;

	public const int BuyItemCountFieldNumber = 1;

	private int buyItemCount_;

	public const int BuyItemIdFieldNumber = 2;

	private int buyItemId_;

	public const int BuyItemTypeFieldNumber = 3;

	private int buyItemType_;

	public const int GroupIdFieldNumber = 4;

	private int groupId_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int RewardCountFieldNumber = 6;

	private static readonly FieldCodec<int> _repeated_rewardCount_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> rewardCount_ = new RepeatedField<int>();

	public const int RewardIdFieldNumber = 7;

	private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

	public const int RewardTypeFieldNumber = 8;

	private static readonly FieldCodec<int> _repeated_rewardType_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> rewardType_ = new RepeatedField<int>();

	public const int TypeFieldNumber = 9;

	private int type_;

	public const int UnlockLevelFieldNumber = 10;

	private int unlockLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PassBuyTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PassBuyTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuyItemCount
	{
		get
		{
			return buyItemCount_;
		}
		set
		{
			buyItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuyItemId
	{
		get
		{
			return buyItemId_;
		}
		set
		{
			buyItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BuyItemType
	{
		get
		{
			return buyItemType_;
		}
		set
		{
			buyItemType_ = value;
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
	public RepeatedField<int> RewardCount => rewardCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardId => rewardId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RewardType => rewardType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UnlockLevel
	{
		get
		{
			return unlockLevel_;
		}
		set
		{
			unlockLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassBuyTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassBuyTable(PassBuyTable other)
		: this()
	{
		buyItemCount_ = other.buyItemCount_;
		buyItemId_ = other.buyItemId_;
		buyItemType_ = other.buyItemType_;
		groupId_ = other.groupId_;
		id_ = other.id_;
		rewardCount_ = other.rewardCount_.Clone();
		rewardId_ = other.rewardId_.Clone();
		rewardType_ = other.rewardType_.Clone();
		type_ = other.type_;
		unlockLevel_ = other.unlockLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PassBuyTable Clone()
	{
		return new PassBuyTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PassBuyTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PassBuyTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BuyItemCount == other.BuyItemCount && BuyItemId == other.BuyItemId && BuyItemType == other.BuyItemType && GroupId == other.GroupId && Id == other.Id && rewardCount_.Equals(other.rewardCount_) && rewardId_.Equals(other.rewardId_) && rewardType_.Equals(other.rewardType_) && Type == other.Type && UnlockLevel == other.UnlockLevel)
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
		if (BuyItemCount != 0)
		{
			num ^= BuyItemCount.GetHashCode();
		}
		if (BuyItemId != 0)
		{
			num ^= BuyItemId.GetHashCode();
		}
		if (BuyItemType != 0)
		{
			num ^= BuyItemType.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= rewardCount_.GetHashCode();
		num ^= rewardId_.GetHashCode();
		num ^= rewardType_.GetHashCode();
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (UnlockLevel != 0)
		{
			num ^= UnlockLevel.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (BuyItemCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuyItemCount);
		}
		if (BuyItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuyItemId);
		}
		if (BuyItemType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuyItemType);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		rewardCount_.WriteTo(ref output, _repeated_rewardCount_codec);
		rewardId_.WriteTo(ref output, _repeated_rewardId_codec);
		rewardType_.WriteTo(ref output, _repeated_rewardType_codec);
		if (Type != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Type);
		}
		if (UnlockLevel != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(UnlockLevel);
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
		if (BuyItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyItemCount);
		}
		if (BuyItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyItemId);
		}
		if (BuyItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyItemType);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += rewardCount_.CalculateSize(_repeated_rewardCount_codec);
		num += rewardId_.CalculateSize(_repeated_rewardId_codec);
		num += rewardType_.CalculateSize(_repeated_rewardType_codec);
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (UnlockLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnlockLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PassBuyTable other)
	{
		if (other != null)
		{
			if (other.BuyItemCount != 0)
			{
				BuyItemCount = other.BuyItemCount;
			}
			if (other.BuyItemId != 0)
			{
				BuyItemId = other.BuyItemId;
			}
			if (other.BuyItemType != 0)
			{
				BuyItemType = other.BuyItemType;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			rewardCount_.Add(other.rewardCount_);
			rewardId_.Add(other.rewardId_);
			rewardType_.Add(other.rewardType_);
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.UnlockLevel != 0)
			{
				UnlockLevel = other.UnlockLevel;
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
				BuyItemCount = input.ReadInt32();
				break;
			case 16u:
				BuyItemId = input.ReadInt32();
				break;
			case 24u:
				BuyItemType = input.ReadInt32();
				break;
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				rewardId_.AddEntriesFrom(ref input, _repeated_rewardId_codec);
				break;
			case 64u:
			case 66u:
				rewardType_.AddEntriesFrom(ref input, _repeated_rewardType_codec);
				break;
			case 72u:
				Type = input.ReadInt32();
				break;
			case 80u:
				UnlockLevel = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 48u:
			case 50u:
				rewardCount_.AddEntriesFrom(ref input, _repeated_rewardCount_codec);
				break;
			}
		}
	}
}
