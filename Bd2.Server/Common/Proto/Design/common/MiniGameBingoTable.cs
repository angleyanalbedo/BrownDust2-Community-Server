using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MiniGameBingoTable : IMessage<MiniGameBingoTable>, IMessage, IEquatable<MiniGameBingoTable>, IDeepCloneable<MiniGameBingoTable>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBingoTable> _parser = new MessageParser<MiniGameBingoTable>(() => new MiniGameBingoTable());

	private UnknownFieldSet _unknownFields;

	public const int BingoCompleteRewardGroupIdFieldNumber = 1;

	private int bingoCompleteRewardGroupId_;

	public const int BingoLineRewardGroupIdFieldNumber = 2;

	private int bingoLineRewardGroupId_;

	public const int BingoRewardGroupIdFieldNumber = 3;

	private int bingoRewardGroupId_;

	public const int BingoUiPrefabFieldNumber = 4;

	private string bingoUiPrefab_ = "";

	public const int ColumnCountFieldNumber = 5;

	private int columnCount_;

	public const int IdFieldNumber = 6;

	private int id_;

	public const int ItemCountFieldNumber = 7;

	private int itemCount_;

	public const int ItemIdFieldNumber = 8;

	private int itemId_;

	public const int ItemTypeFieldNumber = 9;

	private int itemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameBingoTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameBingoTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BingoCompleteRewardGroupId
	{
		get
		{
			return bingoCompleteRewardGroupId_;
		}
		set
		{
			bingoCompleteRewardGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BingoLineRewardGroupId
	{
		get
		{
			return bingoLineRewardGroupId_;
		}
		set
		{
			bingoLineRewardGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BingoRewardGroupId
	{
		get
		{
			return bingoRewardGroupId_;
		}
		set
		{
			bingoRewardGroupId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string BingoUiPrefab
	{
		get
		{
			return bingoUiPrefab_;
		}
		set
		{
			bingoUiPrefab_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ColumnCount
	{
		get
		{
			return columnCount_;
		}
		set
		{
			columnCount_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ItemCount
	{
		get
		{
			return itemCount_;
		}
		set
		{
			itemCount_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MiniGameBingoTable(MiniGameBingoTable other)
		: this()
	{
		bingoCompleteRewardGroupId_ = other.bingoCompleteRewardGroupId_;
		bingoLineRewardGroupId_ = other.bingoLineRewardGroupId_;
		bingoRewardGroupId_ = other.bingoRewardGroupId_;
		bingoUiPrefab_ = other.bingoUiPrefab_;
		columnCount_ = other.columnCount_;
		id_ = other.id_;
		itemCount_ = other.itemCount_;
		itemId_ = other.itemId_;
		itemType_ = other.itemType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBingoTable Clone()
	{
		return new MiniGameBingoTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBingoTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameBingoTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BingoCompleteRewardGroupId == other.BingoCompleteRewardGroupId && BingoLineRewardGroupId == other.BingoLineRewardGroupId && BingoRewardGroupId == other.BingoRewardGroupId && !(BingoUiPrefab != other.BingoUiPrefab) && ColumnCount == other.ColumnCount && Id == other.Id && ItemCount == other.ItemCount && ItemId == other.ItemId && ItemType == other.ItemType)
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
		if (BingoCompleteRewardGroupId != 0)
		{
			num ^= BingoCompleteRewardGroupId.GetHashCode();
		}
		if (BingoLineRewardGroupId != 0)
		{
			num ^= BingoLineRewardGroupId.GetHashCode();
		}
		if (BingoRewardGroupId != 0)
		{
			num ^= BingoRewardGroupId.GetHashCode();
		}
		if (BingoUiPrefab.Length != 0)
		{
			num ^= BingoUiPrefab.GetHashCode();
		}
		if (ColumnCount != 0)
		{
			num ^= ColumnCount.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ItemCount != 0)
		{
			num ^= ItemCount.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (ItemType != 0)
		{
			num ^= ItemType.GetHashCode();
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
		if (BingoCompleteRewardGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BingoCompleteRewardGroupId);
		}
		if (BingoLineRewardGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BingoLineRewardGroupId);
		}
		if (BingoRewardGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BingoRewardGroupId);
		}
		if (BingoUiPrefab.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BingoUiPrefab);
		}
		if (ColumnCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ColumnCount);
		}
		if (Id != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Id);
		}
		if (ItemCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ItemCount);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ItemId);
		}
		if (ItemType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ItemType);
		}
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
		if (BingoCompleteRewardGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BingoCompleteRewardGroupId);
		}
		if (BingoLineRewardGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BingoLineRewardGroupId);
		}
		if (BingoRewardGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BingoRewardGroupId);
		}
		if (BingoUiPrefab.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BingoUiPrefab);
		}
		if (ColumnCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ColumnCount);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemCount);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (ItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameBingoTable other)
	{
		if (other != null)
		{
			if (other.BingoCompleteRewardGroupId != 0)
			{
				BingoCompleteRewardGroupId = other.BingoCompleteRewardGroupId;
			}
			if (other.BingoLineRewardGroupId != 0)
			{
				BingoLineRewardGroupId = other.BingoLineRewardGroupId;
			}
			if (other.BingoRewardGroupId != 0)
			{
				BingoRewardGroupId = other.BingoRewardGroupId;
			}
			if (other.BingoUiPrefab.Length != 0)
			{
				BingoUiPrefab = other.BingoUiPrefab;
			}
			if (other.ColumnCount != 0)
			{
				ColumnCount = other.ColumnCount;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemCount != 0)
			{
				ItemCount = other.ItemCount;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.ItemType != 0)
			{
				ItemType = other.ItemType;
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
				BingoCompleteRewardGroupId = input.ReadInt32();
				break;
			case 16u:
				BingoLineRewardGroupId = input.ReadInt32();
				break;
			case 24u:
				BingoRewardGroupId = input.ReadInt32();
				break;
			case 34u:
				BingoUiPrefab = input.ReadString();
				break;
			case 40u:
				ColumnCount = input.ReadInt32();
				break;
			case 48u:
				Id = input.ReadInt32();
				break;
			case 56u:
				ItemCount = input.ReadInt32();
				break;
			case 64u:
				ItemId = input.ReadInt32();
				break;
			case 72u:
				ItemType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
