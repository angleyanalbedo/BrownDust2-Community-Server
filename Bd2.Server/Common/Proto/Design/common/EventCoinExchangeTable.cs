using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EventCoinExchangeTable : IMessage<EventCoinExchangeTable>, IMessage, IEquatable<EventCoinExchangeTable>, IDeepCloneable<EventCoinExchangeTable>, IBufferMessage
{
	private static readonly MessageParser<EventCoinExchangeTable> _parser = new MessageParser<EventCoinExchangeTable>(() => new EventCoinExchangeTable());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 1;

	private int groupId_;

	public const int IdFieldNumber = 2;

	private int id_;

	public const int KeyTypeFieldNumber = 3;

	private int keyType_;

	public const int PageIdFieldNumber = 4;

	private int pageId_;

	public const int RatioFieldNumber = 5;

	private int ratio_;

	public const int RewardItemCountFieldNumber = 6;

	private int rewardItemCount_;

	public const int RewardItemIdFieldNumber = 7;

	private int rewardItemId_;

	public const int RewardItemTypeFieldNumber = 8;

	private int rewardItemType_;

	public const int SetCountFieldNumber = 9;

	private int setCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EventCoinExchangeTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EventCoinExchangeTableReflection.Descriptor.MessageTypes[0];

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int KeyType
	{
		get
		{
			return keyType_;
		}
		set
		{
			keyType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PageId
	{
		get
		{
			return pageId_;
		}
		set
		{
			pageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Ratio
	{
		get
		{
			return ratio_;
		}
		set
		{
			ratio_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RewardItemCount
	{
		get
		{
			return rewardItemCount_;
		}
		set
		{
			rewardItemCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardItemId
	{
		get
		{
			return rewardItemId_;
		}
		set
		{
			rewardItemId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RewardItemType
	{
		get
		{
			return rewardItemType_;
		}
		set
		{
			rewardItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SetCount
	{
		get
		{
			return setCount_;
		}
		set
		{
			setCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventCoinExchangeTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventCoinExchangeTable(EventCoinExchangeTable other)
		: this()
	{
		groupId_ = other.groupId_;
		id_ = other.id_;
		keyType_ = other.keyType_;
		pageId_ = other.pageId_;
		ratio_ = other.ratio_;
		rewardItemCount_ = other.rewardItemCount_;
		rewardItemId_ = other.rewardItemId_;
		rewardItemType_ = other.rewardItemType_;
		setCount_ = other.setCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventCoinExchangeTable Clone()
	{
		return new EventCoinExchangeTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EventCoinExchangeTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EventCoinExchangeTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (GroupId == other.GroupId && Id == other.Id && KeyType == other.KeyType && PageId == other.PageId && Ratio == other.Ratio && RewardItemCount == other.RewardItemCount && RewardItemId == other.RewardItemId && RewardItemType == other.RewardItemType && SetCount == other.SetCount)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (KeyType != 0)
		{
			num ^= KeyType.GetHashCode();
		}
		if (PageId != 0)
		{
			num ^= PageId.GetHashCode();
		}
		if (Ratio != 0)
		{
			num ^= Ratio.GetHashCode();
		}
		if (RewardItemCount != 0)
		{
			num ^= RewardItemCount.GetHashCode();
		}
		if (RewardItemId != 0)
		{
			num ^= RewardItemId.GetHashCode();
		}
		if (RewardItemType != 0)
		{
			num ^= RewardItemType.GetHashCode();
		}
		if (SetCount != 0)
		{
			num ^= SetCount.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (KeyType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(KeyType);
		}
		if (PageId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PageId);
		}
		if (Ratio != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Ratio);
		}
		if (RewardItemCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(RewardItemCount);
		}
		if (RewardItemId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(RewardItemId);
		}
		if (RewardItemType != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(RewardItemType);
		}
		if (SetCount != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(SetCount);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (KeyType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KeyType);
		}
		if (PageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PageId);
		}
		if (Ratio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Ratio);
		}
		if (RewardItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemCount);
		}
		if (RewardItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemId);
		}
		if (RewardItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RewardItemType);
		}
		if (SetCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SetCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EventCoinExchangeTable other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.KeyType != 0)
			{
				KeyType = other.KeyType;
			}
			if (other.PageId != 0)
			{
				PageId = other.PageId;
			}
			if (other.Ratio != 0)
			{
				Ratio = other.Ratio;
			}
			if (other.RewardItemCount != 0)
			{
				RewardItemCount = other.RewardItemCount;
			}
			if (other.RewardItemId != 0)
			{
				RewardItemId = other.RewardItemId;
			}
			if (other.RewardItemType != 0)
			{
				RewardItemType = other.RewardItemType;
			}
			if (other.SetCount != 0)
			{
				SetCount = other.SetCount;
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
				Id = input.ReadInt32();
				break;
			case 24u:
				KeyType = input.ReadInt32();
				break;
			case 32u:
				PageId = input.ReadInt32();
				break;
			case 40u:
				Ratio = input.ReadInt32();
				break;
			case 48u:
				RewardItemCount = input.ReadInt32();
				break;
			case 56u:
				RewardItemId = input.ReadInt32();
				break;
			case 64u:
				RewardItemType = input.ReadInt32();
				break;
			case 72u:
				SetCount = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
