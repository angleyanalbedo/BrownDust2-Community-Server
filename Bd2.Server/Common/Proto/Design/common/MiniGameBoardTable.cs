using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class MiniGameBoardTable : IMessage<MiniGameBoardTable>, IMessage, IEquatable<MiniGameBoardTable>, IDeepCloneable<MiniGameBoardTable>, IBufferMessage
{
	private static readonly MessageParser<MiniGameBoardTable> _parser = new MessageParser<MiniGameBoardTable>(() => new MiniGameBoardTable());

	private UnknownFieldSet _unknownFields;

	public const int BoardUiPrefabFieldNumber = 1;

	private string boardUiPrefab_ = "";

	public const int CharSpriteResourceFieldNumber = 2;

	private int charSpriteResource_;

	public const int IdFieldNumber = 3;

	private int id_;

	public const int ItemCountFieldNumber = 4;

	private int itemCount_;

	public const int ItemIdFieldNumber = 5;

	private int itemId_;

	public const int ItemTypeFieldNumber = 6;

	private int itemType_;

	public const int MiniGameCompleteRewardGroupIdFieldNumber = 7;

	private int miniGameCompleteRewardGroupId_;

	public const int MiniGameTitleLocalTextIdFieldNumber = 8;

	private int miniGameTitleLocalTextId_;

	public const int MoveControllerGroupIdFieldNumber = 9;

	private int moveControllerGroupId_;

	public const int PlaySpeedFieldNumber = 10;

	private int playSpeed_;

	public const int ScaffoldGroupIdFieldNumber = 11;

	private int scaffoldGroupId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MiniGameBoardTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MiniGameBoardTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BoardUiPrefab
	{
		get
		{
			return boardUiPrefab_;
		}
		set
		{
			boardUiPrefab_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CharSpriteResource
	{
		get
		{
			return charSpriteResource_;
		}
		set
		{
			charSpriteResource_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int MiniGameCompleteRewardGroupId
	{
		get
		{
			return miniGameCompleteRewardGroupId_;
		}
		set
		{
			miniGameCompleteRewardGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MiniGameTitleLocalTextId
	{
		get
		{
			return miniGameTitleLocalTextId_;
		}
		set
		{
			miniGameTitleLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MoveControllerGroupId
	{
		get
		{
			return moveControllerGroupId_;
		}
		set
		{
			moveControllerGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PlaySpeed
	{
		get
		{
			return playSpeed_;
		}
		set
		{
			playSpeed_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ScaffoldGroupId
	{
		get
		{
			return scaffoldGroupId_;
		}
		set
		{
			scaffoldGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardTable(MiniGameBoardTable other)
		: this()
	{
		boardUiPrefab_ = other.boardUiPrefab_;
		charSpriteResource_ = other.charSpriteResource_;
		id_ = other.id_;
		itemCount_ = other.itemCount_;
		itemId_ = other.itemId_;
		itemType_ = other.itemType_;
		miniGameCompleteRewardGroupId_ = other.miniGameCompleteRewardGroupId_;
		miniGameTitleLocalTextId_ = other.miniGameTitleLocalTextId_;
		moveControllerGroupId_ = other.moveControllerGroupId_;
		playSpeed_ = other.playSpeed_;
		scaffoldGroupId_ = other.scaffoldGroupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MiniGameBoardTable Clone()
	{
		return new MiniGameBoardTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MiniGameBoardTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MiniGameBoardTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(BoardUiPrefab != other.BoardUiPrefab) && CharSpriteResource == other.CharSpriteResource && Id == other.Id && ItemCount == other.ItemCount && ItemId == other.ItemId && ItemType == other.ItemType && MiniGameCompleteRewardGroupId == other.MiniGameCompleteRewardGroupId && MiniGameTitleLocalTextId == other.MiniGameTitleLocalTextId && MoveControllerGroupId == other.MoveControllerGroupId && PlaySpeed == other.PlaySpeed && ScaffoldGroupId == other.ScaffoldGroupId)
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
		if (BoardUiPrefab.Length != 0)
		{
			num ^= BoardUiPrefab.GetHashCode();
		}
		if (CharSpriteResource != 0)
		{
			num ^= CharSpriteResource.GetHashCode();
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
		if (MiniGameCompleteRewardGroupId != 0)
		{
			num ^= MiniGameCompleteRewardGroupId.GetHashCode();
		}
		if (MiniGameTitleLocalTextId != 0)
		{
			num ^= MiniGameTitleLocalTextId.GetHashCode();
		}
		if (MoveControllerGroupId != 0)
		{
			num ^= MoveControllerGroupId.GetHashCode();
		}
		if (PlaySpeed != 0)
		{
			num ^= PlaySpeed.GetHashCode();
		}
		if (ScaffoldGroupId != 0)
		{
			num ^= ScaffoldGroupId.GetHashCode();
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
		if (BoardUiPrefab.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BoardUiPrefab);
		}
		if (CharSpriteResource != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CharSpriteResource);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (ItemCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ItemCount);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ItemId);
		}
		if (ItemType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ItemType);
		}
		if (MiniGameCompleteRewardGroupId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(MiniGameCompleteRewardGroupId);
		}
		if (MiniGameTitleLocalTextId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(MiniGameTitleLocalTextId);
		}
		if (MoveControllerGroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MoveControllerGroupId);
		}
		if (PlaySpeed != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PlaySpeed);
		}
		if (ScaffoldGroupId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ScaffoldGroupId);
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
		if (BoardUiPrefab.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BoardUiPrefab);
		}
		if (CharSpriteResource != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CharSpriteResource);
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
		if (MiniGameCompleteRewardGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MiniGameCompleteRewardGroupId);
		}
		if (MiniGameTitleLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MiniGameTitleLocalTextId);
		}
		if (MoveControllerGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MoveControllerGroupId);
		}
		if (PlaySpeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlaySpeed);
		}
		if (ScaffoldGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScaffoldGroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MiniGameBoardTable other)
	{
		if (other != null)
		{
			if (other.BoardUiPrefab.Length != 0)
			{
				BoardUiPrefab = other.BoardUiPrefab;
			}
			if (other.CharSpriteResource != 0)
			{
				CharSpriteResource = other.CharSpriteResource;
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
			if (other.MiniGameCompleteRewardGroupId != 0)
			{
				MiniGameCompleteRewardGroupId = other.MiniGameCompleteRewardGroupId;
			}
			if (other.MiniGameTitleLocalTextId != 0)
			{
				MiniGameTitleLocalTextId = other.MiniGameTitleLocalTextId;
			}
			if (other.MoveControllerGroupId != 0)
			{
				MoveControllerGroupId = other.MoveControllerGroupId;
			}
			if (other.PlaySpeed != 0)
			{
				PlaySpeed = other.PlaySpeed;
			}
			if (other.ScaffoldGroupId != 0)
			{
				ScaffoldGroupId = other.ScaffoldGroupId;
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
			case 10u:
				BoardUiPrefab = input.ReadString();
				break;
			case 16u:
				CharSpriteResource = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				ItemCount = input.ReadInt32();
				break;
			case 40u:
				ItemId = input.ReadInt32();
				break;
			case 48u:
				ItemType = input.ReadInt32();
				break;
			case 56u:
				MiniGameCompleteRewardGroupId = input.ReadInt32();
				break;
			case 64u:
				MiniGameTitleLocalTextId = input.ReadInt32();
				break;
			case 72u:
				MoveControllerGroupId = input.ReadInt32();
				break;
			case 80u:
				PlaySpeed = input.ReadInt32();
				break;
			case 88u:
				ScaffoldGroupId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
