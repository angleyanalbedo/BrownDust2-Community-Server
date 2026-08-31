using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class EquipmentOptionRerollTable : IMessage<EquipmentOptionRerollTable>, IMessage, IEquatable<EquipmentOptionRerollTable>, IDeepCloneable<EquipmentOptionRerollTable>, IBufferMessage
{
	private static readonly MessageParser<EquipmentOptionRerollTable> _parser = new MessageParser<EquipmentOptionRerollTable>(() => new EquipmentOptionRerollTable());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private int id_;

	public const int LockItemCountFieldNumber = 2;

	private static readonly FieldCodec<int> _repeated_lockItemCount_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> lockItemCount_ = new RepeatedField<int>();

	public const int RerollItemCountFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_rerollItemCount_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> rerollItemCount_ = new RepeatedField<int>();

	public const int RerollItemIdFieldNumber = 4;

	private static readonly FieldCodec<int> _repeated_rerollItemId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> rerollItemId_ = new RepeatedField<int>();

	public const int RerollItemTypeFieldNumber = 5;

	private static readonly FieldCodec<int> _repeated_rerollItemType_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> rerollItemType_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipmentOptionRerollTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipmentOptionRerollTableReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<int> LockItemCount => lockItemCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RerollItemCount => rerollItemCount_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> RerollItemId => rerollItemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> RerollItemType => rerollItemType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentOptionRerollTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentOptionRerollTable(EquipmentOptionRerollTable other)
		: this()
	{
		id_ = other.id_;
		lockItemCount_ = other.lockItemCount_.Clone();
		rerollItemCount_ = other.rerollItemCount_.Clone();
		rerollItemId_ = other.rerollItemId_.Clone();
		rerollItemType_ = other.rerollItemType_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipmentOptionRerollTable Clone()
	{
		return new EquipmentOptionRerollTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipmentOptionRerollTable);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipmentOptionRerollTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Id == other.Id && lockItemCount_.Equals(other.lockItemCount_) && rerollItemCount_.Equals(other.rerollItemCount_) && rerollItemId_.Equals(other.rerollItemId_) && rerollItemType_.Equals(other.rerollItemType_))
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
		num ^= lockItemCount_.GetHashCode();
		num ^= rerollItemCount_.GetHashCode();
		num ^= rerollItemId_.GetHashCode();
		num ^= rerollItemType_.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		lockItemCount_.WriteTo(ref output, _repeated_lockItemCount_codec);
		rerollItemCount_.WriteTo(ref output, _repeated_rerollItemCount_codec);
		rerollItemId_.WriteTo(ref output, _repeated_rerollItemId_codec);
		rerollItemType_.WriteTo(ref output, _repeated_rerollItemType_codec);
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
		num += lockItemCount_.CalculateSize(_repeated_lockItemCount_codec);
		num += rerollItemCount_.CalculateSize(_repeated_rerollItemCount_codec);
		num += rerollItemId_.CalculateSize(_repeated_rerollItemId_codec);
		num += rerollItemType_.CalculateSize(_repeated_rerollItemType_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EquipmentOptionRerollTable other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			lockItemCount_.Add(other.lockItemCount_);
			rerollItemCount_.Add(other.rerollItemCount_);
			rerollItemId_.Add(other.rerollItemId_);
			rerollItemType_.Add(other.rerollItemType_);
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
				lockItemCount_.AddEntriesFrom(ref input, _repeated_lockItemCount_codec);
				break;
			case 40u:
			case 42u:
				rerollItemType_.AddEntriesFrom(ref input, _repeated_rerollItemType_codec);
				break;
			case 32u:
			case 34u:
				rerollItemId_.AddEntriesFrom(ref input, _repeated_rerollItemId_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				rerollItemCount_.AddEntriesFrom(ref input, _repeated_rerollItemCount_codec);
				break;
			}
		}
	}
}
