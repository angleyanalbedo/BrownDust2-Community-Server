using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class ItemAutoUpgradeInfo : IMessage<ItemAutoUpgradeInfo>, IMessage, IEquatable<ItemAutoUpgradeInfo>, IDeepCloneable<ItemAutoUpgradeInfo>, IBufferMessage
{
	private static readonly MessageParser<ItemAutoUpgradeInfo> _parser = new MessageParser<ItemAutoUpgradeInfo>(() => new ItemAutoUpgradeInfo());

	private UnknownFieldSet _unknownFields;

	public const int InvenIndexFieldNumber = 1;

	private long invenIndex_;

	public const int ItemTypeFieldNumber = 2;

	private int itemType_;

	public const int ItemIdFieldNumber = 3;

	private int itemId_;

	public const int BeforeLevelFieldNumber = 4;

	private int beforeLevel_;

	public const int AfterLevelFieldNumber = 5;

	private int afterLevel_;

	public const int SortIdFieldNumber = 6;

	private int sortId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ItemAutoUpgradeInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ItemAutoUpgradeInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long InvenIndex
	{
		get
		{
			return invenIndex_;
		}
		set
		{
			invenIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemType
	{
		get
		{
			return itemType_;
		}
		set
		{
			itemType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BeforeLevel
	{
		get
		{
			return beforeLevel_;
		}
		set
		{
			beforeLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AfterLevel
	{
		get
		{
			return afterLevel_;
		}
		set
		{
			afterLevel_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemAutoUpgradeInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemAutoUpgradeInfo(ItemAutoUpgradeInfo other)
		: this()
	{
		invenIndex_ = other.invenIndex_;
		itemType_ = other.itemType_;
		itemId_ = other.itemId_;
		beforeLevel_ = other.beforeLevel_;
		afterLevel_ = other.afterLevel_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemAutoUpgradeInfo Clone()
	{
		return new ItemAutoUpgradeInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ItemAutoUpgradeInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ItemAutoUpgradeInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (InvenIndex == other.InvenIndex && ItemType == other.ItemType && ItemId == other.ItemId && BeforeLevel == other.BeforeLevel && AfterLevel == other.AfterLevel && SortId == other.SortId)
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
		if (InvenIndex != 0L)
		{
			num ^= InvenIndex.GetHashCode();
		}
		if (ItemType != 0)
		{
			num ^= ItemType.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (BeforeLevel != 0)
		{
			num ^= BeforeLevel.GetHashCode();
		}
		if (AfterLevel != 0)
		{
			num ^= AfterLevel.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
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
		if (InvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(InvenIndex);
		}
		if (ItemType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemType);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ItemId);
		}
		if (BeforeLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BeforeLevel);
		}
		if (AfterLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(AfterLevel);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SortId);
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
		if (InvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(InvenIndex);
		}
		if (ItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemType);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (BeforeLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BeforeLevel);
		}
		if (AfterLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AfterLevel);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ItemAutoUpgradeInfo other)
	{
		if (other != null)
		{
			if (other.InvenIndex != 0L)
			{
				InvenIndex = other.InvenIndex;
			}
			if (other.ItemType != 0)
			{
				ItemType = other.ItemType;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.BeforeLevel != 0)
			{
				BeforeLevel = other.BeforeLevel;
			}
			if (other.AfterLevel != 0)
			{
				AfterLevel = other.AfterLevel;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
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
				InvenIndex = input.ReadInt64();
				break;
			case 16u:
				ItemType = input.ReadInt32();
				break;
			case 24u:
				ItemId = input.ReadInt32();
				break;
			case 32u:
				BeforeLevel = input.ReadInt32();
				break;
			case 40u:
				AfterLevel = input.ReadInt32();
				break;
			case 48u:
				SortId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
