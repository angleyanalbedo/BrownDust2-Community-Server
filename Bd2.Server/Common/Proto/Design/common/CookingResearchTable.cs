using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class CookingResearchTable : IMessage<CookingResearchTable>, IMessage, IEquatable<CookingResearchTable>, IDeepCloneable<CookingResearchTable>, IBufferMessage
{
	private static readonly MessageParser<CookingResearchTable> _parser = new MessageParser<CookingResearchTable>(() => new CookingResearchTable());

	private UnknownFieldSet _unknownFields;

	public const int CatalystValueFieldNumber = 1;

	private static readonly FieldCodec<int> _repeated_catalystValue_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> catalystValue_ = new RepeatedField<int>();

	public const int FailItemIdFieldNumber = 2;

	private int failItemId_;

	public const int UseSlotCountFieldNumber = 3;

	private static readonly FieldCodec<int> _repeated_useSlotCount_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> useSlotCount_ = new RepeatedField<int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CookingResearchTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CookingResearchTableReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> CatalystValue => catalystValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FailItemId
	{
		get
		{
			return failItemId_;
		}
		set
		{
			failItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> UseSlotCount => useSlotCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResearchTable()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResearchTable(CookingResearchTable other)
		: this()
	{
		catalystValue_ = other.catalystValue_.Clone();
		failItemId_ = other.failItemId_;
		useSlotCount_ = other.useSlotCount_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CookingResearchTable Clone()
	{
		return new CookingResearchTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CookingResearchTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CookingResearchTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (catalystValue_.Equals(other.catalystValue_) && FailItemId == other.FailItemId && useSlotCount_.Equals(other.useSlotCount_))
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
		num ^= catalystValue_.GetHashCode();
		if (FailItemId != 0)
		{
			num ^= FailItemId.GetHashCode();
		}
		num ^= useSlotCount_.GetHashCode();
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
		catalystValue_.WriteTo(ref output, _repeated_catalystValue_codec);
		if (FailItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(FailItemId);
		}
		useSlotCount_.WriteTo(ref output, _repeated_useSlotCount_codec);
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
		num += catalystValue_.CalculateSize(_repeated_catalystValue_codec);
		if (FailItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FailItemId);
		}
		num += useSlotCount_.CalculateSize(_repeated_useSlotCount_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CookingResearchTable other)
	{
		if (other != null)
		{
			catalystValue_.Add(other.catalystValue_);
			if (other.FailItemId != 0)
			{
				FailItemId = other.FailItemId;
			}
			useSlotCount_.Add(other.useSlotCount_);
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
			case 10u:
				catalystValue_.AddEntriesFrom(ref input, _repeated_catalystValue_codec);
				break;
			case 16u:
				FailItemId = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				useSlotCount_.AddEntriesFrom(ref input, _repeated_useSlotCount_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
