using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CharacterPictorialBookTable : IMessage<CharacterPictorialBookTable>, IMessage, IEquatable<CharacterPictorialBookTable>, IDeepCloneable<CharacterPictorialBookTable>, IBufferMessage
{
	private static readonly MessageParser<CharacterPictorialBookTable> _parser = new MessageParser<CharacterPictorialBookTable>(() => new CharacterPictorialBookTable());

	private UnknownFieldSet _unknownFields;

	public const int CharIdFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_charId_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> charId_ = new RepeatedField<int>();

	public const int CollectionBuffIdFieldNumber = 2;

	private int collectionBuffId_;

	public const int GroupDescLocalTextIdFieldNumber = 3;

	private int groupDescLocalTextId_;

	public const int GroupLocalTextIdFieldNumber = 4;

	private int groupLocalTextId_;

	public const int IdFieldNumber = 5;

	private int id_;

	public const int TabTypeFieldNumber = 6;

	private int tabType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterPictorialBookTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => CharacterPictorialBookTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CharId => charId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CollectionBuffId
	{
		get
		{
			return collectionBuffId_;
		}
		set
		{
			collectionBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupDescLocalTextId
	{
		get
		{
			return groupDescLocalTextId_;
		}
		set
		{
			groupDescLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GroupLocalTextId
	{
		get
		{
			return groupLocalTextId_;
		}
		set
		{
			groupLocalTextId_ = value;
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
	public int TabType
	{
		get
		{
			return tabType_;
		}
		set
		{
			tabType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPictorialBookTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPictorialBookTable(CharacterPictorialBookTable other)
		: this()
	{
		charId_ = other.charId_.Clone();
		collectionBuffId_ = other.collectionBuffId_;
		groupDescLocalTextId_ = other.groupDescLocalTextId_;
		groupLocalTextId_ = other.groupLocalTextId_;
		id_ = other.id_;
		tabType_ = other.tabType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPictorialBookTable Clone()
	{
		return new CharacterPictorialBookTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as CharacterPictorialBookTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterPictorialBookTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (charId_.Equals(other.charId_) && CollectionBuffId == other.CollectionBuffId && GroupDescLocalTextId == other.GroupDescLocalTextId && GroupLocalTextId == other.GroupLocalTextId && Id == other.Id && TabType == other.TabType)
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
		num ^= charId_.GetHashCode();
		if (CollectionBuffId != 0)
		{
			num ^= CollectionBuffId.GetHashCode();
		}
		if (GroupDescLocalTextId != 0)
		{
			num ^= GroupDescLocalTextId.GetHashCode();
		}
		if (GroupLocalTextId != 0)
		{
			num ^= GroupLocalTextId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TabType != 0)
		{
			num ^= TabType.GetHashCode();
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
		charId_.WriteTo(ref output, _repeated_charId_codec);
		if (CollectionBuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CollectionBuffId);
		}
		if (GroupDescLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupDescLocalTextId);
		}
		if (GroupLocalTextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupLocalTextId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (TabType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TabType);
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
		num += charId_.CalculateSize(_repeated_charId_codec);
		if (CollectionBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectionBuffId);
		}
		if (GroupDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupDescLocalTextId);
		}
		if (GroupLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupLocalTextId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (TabType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TabType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterPictorialBookTable other)
	{
		if (other != null)
		{
			charId_.Add(other.charId_);
			if (other.CollectionBuffId != 0)
			{
				CollectionBuffId = other.CollectionBuffId;
			}
			if (other.GroupDescLocalTextId != 0)
			{
				GroupDescLocalTextId = other.GroupDescLocalTextId;
			}
			if (other.GroupLocalTextId != 0)
			{
				GroupLocalTextId = other.GroupLocalTextId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TabType != 0)
			{
				TabType = other.TabType;
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
			case 8u:
			case 10u:
				charId_.AddEntriesFrom(ref input, _repeated_charId_codec);
				break;
			case 16u:
				CollectionBuffId = input.ReadInt32();
				break;
			case 24u:
				GroupDescLocalTextId = input.ReadInt32();
				break;
			case 32u:
				GroupLocalTextId = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			case 48u:
				TabType = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
