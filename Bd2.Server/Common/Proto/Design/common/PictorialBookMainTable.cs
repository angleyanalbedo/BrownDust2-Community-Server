using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class PictorialBookMainTable : IMessage<PictorialBookMainTable>, IMessage, IEquatable<PictorialBookMainTable>, IDeepCloneable<PictorialBookMainTable>, IBufferMessage
{
	private static readonly MessageParser<PictorialBookMainTable> _parser = new MessageParser<PictorialBookMainTable>(() => new PictorialBookMainTable());

	private UnknownFieldSet _unknownFields;

	public const int ConditionCharIdFieldNumber = 1;

	private int conditionCharId_;

	public const int ElementTypeFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_elementType_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> elementType_ = new RepeatedField<int>();

	public const int IdFieldNumber = 3;

	private int id_;

	public const int MenuIconFieldNumber = 4;

	private string menuIcon_ = "";

	public const int MenuTitleLocalTextIdFieldNumber = 5;

	private int menuTitleLocalTextId_;

	public const int PictorialOrderFieldNumber = 6;

	private int pictorialOrder_;

	public const int TypeFieldNumber = 7;

	private int type_;

	public const int UseBlindFieldNumber = 8;

	private int useBlind_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PictorialBookMainTable> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PictorialBookMainTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ConditionCharId
	{
		get
		{
			return conditionCharId_;
		}
		set
		{
			conditionCharId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ElementType => elementType_;

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string MenuIcon
	{
		get
		{
			return menuIcon_;
		}
		set
		{
			menuIcon_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MenuTitleLocalTextId
	{
		get
		{
			return menuTitleLocalTextId_;
		}
		set
		{
			menuTitleLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PictorialOrder
	{
		get
		{
			return pictorialOrder_;
		}
		set
		{
			pictorialOrder_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public int UseBlind
	{
		get
		{
			return useBlind_;
		}
		set
		{
			useBlind_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PictorialBookMainTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PictorialBookMainTable(PictorialBookMainTable other)
		: this()
	{
		conditionCharId_ = other.conditionCharId_;
		elementType_ = other.elementType_.Clone();
		id_ = other.id_;
		menuIcon_ = other.menuIcon_;
		menuTitleLocalTextId_ = other.menuTitleLocalTextId_;
		pictorialOrder_ = other.pictorialOrder_;
		type_ = other.type_;
		useBlind_ = other.useBlind_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PictorialBookMainTable Clone()
	{
		return new PictorialBookMainTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PictorialBookMainTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PictorialBookMainTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ConditionCharId == other.ConditionCharId && elementType_.Equals(other.elementType_) && Id == other.Id && !(MenuIcon != other.MenuIcon) && MenuTitleLocalTextId == other.MenuTitleLocalTextId && PictorialOrder == other.PictorialOrder && Type == other.Type && UseBlind == other.UseBlind)
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
		if (ConditionCharId != 0)
		{
			num ^= ConditionCharId.GetHashCode();
		}
		num ^= elementType_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MenuIcon.Length != 0)
		{
			num ^= MenuIcon.GetHashCode();
		}
		if (MenuTitleLocalTextId != 0)
		{
			num ^= MenuTitleLocalTextId.GetHashCode();
		}
		if (PictorialOrder != 0)
		{
			num ^= PictorialOrder.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (UseBlind != 0)
		{
			num ^= UseBlind.GetHashCode();
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
		if (ConditionCharId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionCharId);
		}
		elementType_.WriteTo(ref output, _repeated_elementType_codec);
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (MenuIcon.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(MenuIcon);
		}
		if (MenuTitleLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MenuTitleLocalTextId);
		}
		if (PictorialOrder != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PictorialOrder);
		}
		if (Type != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Type);
		}
		if (UseBlind != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(UseBlind);
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
		if (ConditionCharId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionCharId);
		}
		num += elementType_.CalculateSize(_repeated_elementType_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MenuIcon.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MenuIcon);
		}
		if (MenuTitleLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MenuTitleLocalTextId);
		}
		if (PictorialOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PictorialOrder);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (UseBlind != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UseBlind);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PictorialBookMainTable other)
	{
		if (other != null)
		{
			if (other.ConditionCharId != 0)
			{
				ConditionCharId = other.ConditionCharId;
			}
			elementType_.Add(other.elementType_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MenuIcon.Length != 0)
			{
				MenuIcon = other.MenuIcon;
			}
			if (other.MenuTitleLocalTextId != 0)
			{
				MenuTitleLocalTextId = other.MenuTitleLocalTextId;
			}
			if (other.PictorialOrder != 0)
			{
				PictorialOrder = other.PictorialOrder;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.UseBlind != 0)
			{
				UseBlind = other.UseBlind;
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
				ConditionCharId = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				elementType_.AddEntriesFrom(ref input, _repeated_elementType_codec);
				break;
			case 34u:
				MenuIcon = input.ReadString();
				break;
			case 40u:
				MenuTitleLocalTextId = input.ReadInt32();
				break;
			case 48u:
				PictorialOrder = input.ReadInt32();
				break;
			case 56u:
				Type = input.ReadInt32();
				break;
			case 64u:
				UseBlind = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
