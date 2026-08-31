using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class ShortCutTable : IMessage<ShortCutTable>, IMessage, IEquatable<ShortCutTable>, IDeepCloneable<ShortCutTable>, IBufferMessage
{
	private static readonly MessageParser<ShortCutTable> _parser = new MessageParser<ShortCutTable>(() => new ShortCutTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int MagicValueFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_magicValue_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> magicValue_ = new RepeatedField<int>();

	public const int UiNameFieldNumber = 3;

	private string uiName_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShortCutTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ShortCutTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> MagicValue => magicValue_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string UiName
	{
		get
		{
			return uiName_;
		}
		set
		{
			uiName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortCutTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortCutTable(ShortCutTable other)
		: this()
	{
		id_ = other.id_;
		magicValue_ = other.magicValue_.Clone();
		uiName_ = other.uiName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortCutTable Clone()
	{
		return new ShortCutTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as ShortCutTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShortCutTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && magicValue_.Equals(other.magicValue_) && !(UiName != other.UiName))
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
		num ^= magicValue_.GetHashCode();
		if (UiName.Length != 0)
		{
			num ^= UiName.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		magicValue_.WriteTo(ref output, _repeated_magicValue_codec);
		if (UiName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(UiName);
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
		num += magicValue_.CalculateSize(_repeated_magicValue_codec);
		if (UiName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UiName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ShortCutTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			magicValue_.Add(other.magicValue_);
			if (other.UiName.Length != 0)
			{
				UiName = other.UiName;
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
			case 26u:
				UiName = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				magicValue_.AddEntriesFrom(ref input, _repeated_magicValue_codec);
				break;
			}
		}
	}
}
