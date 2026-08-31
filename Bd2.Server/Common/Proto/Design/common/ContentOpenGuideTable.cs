using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ContentOpenGuideTable : IMessage<ContentOpenGuideTable>, IMessage, IEquatable<ContentOpenGuideTable>, IDeepCloneable<ContentOpenGuideTable>, IBufferMessage
{
	private static readonly MessageParser<ContentOpenGuideTable> _parser = new MessageParser<ContentOpenGuideTable>(() => new ContentOpenGuideTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int MagicValueFieldNumber = 2;

	private int magicValue_;

	public const int OpenDescLocalTextIdFieldNumber = 3;

	private int openDescLocalTextId_;

	public const int OpenIconNameFieldNumber = 4;

	private string openIconName_ = "";

	public const int OpenTitleLocalTextIdFieldNumber = 5;

	private int openTitleLocalTextId_;

	public const int ShortCutIdFieldNumber = 6;

	private int shortCutId_;

	public const int TypeFieldNumber = 7;

	private int type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContentOpenGuideTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ContentOpenGuideTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int MagicValue
	{
		get
		{
			return magicValue_;
		}
		set
		{
			magicValue_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OpenDescLocalTextId
	{
		get
		{
			return openDescLocalTextId_;
		}
		set
		{
			openDescLocalTextId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string OpenIconName
	{
		get
		{
			return openIconName_;
		}
		set
		{
			openIconName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int OpenTitleLocalTextId
	{
		get
		{
			return openTitleLocalTextId_;
		}
		set
		{
			openTitleLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ShortCutId
	{
		get
		{
			return shortCutId_;
		}
		set
		{
			shortCutId_ = value;
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
	public ContentOpenGuideTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContentOpenGuideTable(ContentOpenGuideTable other)
		: this()
	{
		id_ = other.id_;
		magicValue_ = other.magicValue_;
		openDescLocalTextId_ = other.openDescLocalTextId_;
		openIconName_ = other.openIconName_;
		openTitleLocalTextId_ = other.openTitleLocalTextId_;
		shortCutId_ = other.shortCutId_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContentOpenGuideTable Clone()
	{
		return new ContentOpenGuideTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ContentOpenGuideTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContentOpenGuideTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && MagicValue == other.MagicValue && OpenDescLocalTextId == other.OpenDescLocalTextId && !(OpenIconName != other.OpenIconName) && OpenTitleLocalTextId == other.OpenTitleLocalTextId && ShortCutId == other.ShortCutId && Type == other.Type)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MagicValue != 0)
		{
			num ^= MagicValue.GetHashCode();
		}
		if (OpenDescLocalTextId != 0)
		{
			num ^= OpenDescLocalTextId.GetHashCode();
		}
		if (OpenIconName.Length != 0)
		{
			num ^= OpenIconName.GetHashCode();
		}
		if (OpenTitleLocalTextId != 0)
		{
			num ^= OpenTitleLocalTextId.GetHashCode();
		}
		if (ShortCutId != 0)
		{
			num ^= ShortCutId.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (MagicValue != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MagicValue);
		}
		if (OpenDescLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(OpenDescLocalTextId);
		}
		if (OpenIconName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(OpenIconName);
		}
		if (OpenTitleLocalTextId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(OpenTitleLocalTextId);
		}
		if (ShortCutId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ShortCutId);
		}
		if (Type != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Type);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (MagicValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MagicValue);
		}
		if (OpenDescLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OpenDescLocalTextId);
		}
		if (OpenIconName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OpenIconName);
		}
		if (OpenTitleLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OpenTitleLocalTextId);
		}
		if (ShortCutId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShortCutId);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContentOpenGuideTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MagicValue != 0)
			{
				MagicValue = other.MagicValue;
			}
			if (other.OpenDescLocalTextId != 0)
			{
				OpenDescLocalTextId = other.OpenDescLocalTextId;
			}
			if (other.OpenIconName.Length != 0)
			{
				OpenIconName = other.OpenIconName;
			}
			if (other.OpenTitleLocalTextId != 0)
			{
				OpenTitleLocalTextId = other.OpenTitleLocalTextId;
			}
			if (other.ShortCutId != 0)
			{
				ShortCutId = other.ShortCutId;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				MagicValue = input.ReadInt32();
				break;
			case 24u:
				OpenDescLocalTextId = input.ReadInt32();
				break;
			case 34u:
				OpenIconName = input.ReadString();
				break;
			case 40u:
				OpenTitleLocalTextId = input.ReadInt32();
				break;
			case 48u:
				ShortCutId = input.ReadInt32();
				break;
			case 56u:
				Type = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
