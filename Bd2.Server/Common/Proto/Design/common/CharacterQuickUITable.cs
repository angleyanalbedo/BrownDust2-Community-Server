using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CharacterQuickUITable : IMessage<CharacterQuickUITable>, IMessage, IEquatable<CharacterQuickUITable>, IDeepCloneable<CharacterQuickUITable>, IBufferMessage
{
	private static readonly MessageParser<CharacterQuickUITable> _parser = new MessageParser<CharacterQuickUITable>(() => new CharacterQuickUITable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int QuickUiFieldNumber = 2;

	private int quickUi_;

	public const int QuickUiLocalTextIdFieldNumber = 3;

	private int quickUiLocalTextId_;

	public const int QuickUiSpriteNameFieldNumber = 4;

	private string quickUiSpriteName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterQuickUITable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CharacterQuickUITableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int QuickUi
	{
		get
		{
			return quickUi_;
		}
		set
		{
			quickUi_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int QuickUiLocalTextId
	{
		get
		{
			return quickUiLocalTextId_;
		}
		set
		{
			quickUiLocalTextId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string QuickUiSpriteName
	{
		get
		{
			return quickUiSpriteName_;
		}
		set
		{
			quickUiSpriteName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterQuickUITable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterQuickUITable(CharacterQuickUITable other)
		: this()
	{
		id_ = other.id_;
		quickUi_ = other.quickUi_;
		quickUiLocalTextId_ = other.quickUiLocalTextId_;
		quickUiSpriteName_ = other.quickUiSpriteName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterQuickUITable Clone()
	{
		return new CharacterQuickUITable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CharacterQuickUITable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterQuickUITable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && QuickUi == other.QuickUi && QuickUiLocalTextId == other.QuickUiLocalTextId && !(QuickUiSpriteName != other.QuickUiSpriteName))
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
		if (QuickUi != 0)
		{
			num ^= QuickUi.GetHashCode();
		}
		if (QuickUiLocalTextId != 0)
		{
			num ^= QuickUiLocalTextId.GetHashCode();
		}
		if (QuickUiSpriteName.Length != 0)
		{
			num ^= QuickUiSpriteName.GetHashCode();
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
		if (QuickUi != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(QuickUi);
		}
		if (QuickUiLocalTextId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(QuickUiLocalTextId);
		}
		if (QuickUiSpriteName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(QuickUiSpriteName);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (QuickUi != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuickUi);
		}
		if (QuickUiLocalTextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuickUiLocalTextId);
		}
		if (QuickUiSpriteName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(QuickUiSpriteName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterQuickUITable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.QuickUi != 0)
			{
				QuickUi = other.QuickUi;
			}
			if (other.QuickUiLocalTextId != 0)
			{
				QuickUiLocalTextId = other.QuickUiLocalTextId;
			}
			if (other.QuickUiSpriteName.Length != 0)
			{
				QuickUiSpriteName = other.QuickUiSpriteName;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				QuickUi = input.ReadInt32();
				break;
			case 24u:
				QuickUiLocalTextId = input.ReadInt32();
				break;
			case 34u:
				QuickUiSpriteName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
