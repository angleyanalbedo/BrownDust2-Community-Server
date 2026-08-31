using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class NewAccountSupplyItemTable : IMessage<NewAccountSupplyItemTable>, IMessage, IEquatable<NewAccountSupplyItemTable>, IDeepCloneable<NewAccountSupplyItemTable>, IBufferMessage
{
	private static readonly MessageParser<NewAccountSupplyItemTable> _parser = new MessageParser<NewAccountSupplyItemTable>(() => new NewAccountSupplyItemTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int SupplyItemCountFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_supplyItemCount_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> supplyItemCount_ = new RepeatedField<int>();

	public const int SupplyItemIdFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_supplyItemId_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> supplyItemId_ = new RepeatedField<int>();

	public const int SupplyItemTypeFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_supplyItemType_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> supplyItemType_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NewAccountSupplyItemTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NewAccountSupplyItemTableReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<int> SupplyItemCount => supplyItemCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SupplyItemId => supplyItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> SupplyItemType => supplyItemType_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NewAccountSupplyItemTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public NewAccountSupplyItemTable(NewAccountSupplyItemTable other)
		: this()
	{
		id_ = other.id_;
		supplyItemCount_ = other.supplyItemCount_.Clone();
		supplyItemId_ = other.supplyItemId_.Clone();
		supplyItemType_ = other.supplyItemType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NewAccountSupplyItemTable Clone()
	{
		return new NewAccountSupplyItemTable(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as NewAccountSupplyItemTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NewAccountSupplyItemTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && supplyItemCount_.Equals(other.supplyItemCount_) && supplyItemId_.Equals(other.supplyItemId_) && supplyItemType_.Equals(other.supplyItemType_))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= supplyItemCount_.GetHashCode();
		num ^= supplyItemId_.GetHashCode();
		num ^= supplyItemType_.GetHashCode();
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		supplyItemCount_.WriteTo(ref output, _repeated_supplyItemCount_codec);
		supplyItemId_.WriteTo(ref output, _repeated_supplyItemId_codec);
		supplyItemType_.WriteTo(ref output, _repeated_supplyItemType_codec);
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
		num += supplyItemCount_.CalculateSize(_repeated_supplyItemCount_codec);
		num += supplyItemId_.CalculateSize(_repeated_supplyItemId_codec);
		num += supplyItemType_.CalculateSize(_repeated_supplyItemType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NewAccountSupplyItemTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			supplyItemCount_.Add(other.supplyItemCount_);
			supplyItemId_.Add(other.supplyItemId_);
			supplyItemType_.Add(other.supplyItemType_);
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
			case 18u:
				supplyItemCount_.AddEntriesFrom(ref input, _repeated_supplyItemCount_codec);
				break;
			case 24u:
			case 26u:
				supplyItemId_.AddEntriesFrom(ref input, _repeated_supplyItemId_codec);
				break;
			case 32u:
			case 34u:
				supplyItemType_.AddEntriesFrom(ref input, _repeated_supplyItemType_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
