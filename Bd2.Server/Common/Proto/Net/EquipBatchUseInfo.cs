using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipBatchUseInfo : IMessage<EquipBatchUseInfo>, IMessage, IEquatable<EquipBatchUseInfo>, IDeepCloneable<EquipBatchUseInfo>, IBufferMessage
{
	private static readonly MessageParser<EquipBatchUseInfo> _parser = new MessageParser<EquipBatchUseInfo>(() => new EquipBatchUseInfo());

	private UnknownFieldSet _unknownFields;

	public const int CharInvenIndexFieldNumber = 1;

	private long charInvenIndex_;

	public const int EquipInvenIndexFieldNumber = 2;

	private static readonly FieldCodec<long> _repeated_equipInvenIndex_codec = FieldCodec.ForInt64(18u);

	private readonly RepeatedField<long> equipInvenIndex_ = new RepeatedField<long>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipBatchUseInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipBatchUseInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CharInvenIndex
	{
		get
		{
			return charInvenIndex_;
		}
		set
		{
			charInvenIndex_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<long> EquipInvenIndex => equipInvenIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipBatchUseInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipBatchUseInfo(EquipBatchUseInfo other)
		: this()
	{
		charInvenIndex_ = other.charInvenIndex_;
		equipInvenIndex_ = other.equipInvenIndex_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipBatchUseInfo Clone()
	{
		return new EquipBatchUseInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipBatchUseInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipBatchUseInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CharInvenIndex == other.CharInvenIndex && equipInvenIndex_.Equals(other.equipInvenIndex_))
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
		if (CharInvenIndex != 0L)
		{
			num ^= CharInvenIndex.GetHashCode();
		}
		num ^= equipInvenIndex_.GetHashCode();
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
		if (CharInvenIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(CharInvenIndex);
		}
		equipInvenIndex_.WriteTo(ref output, _repeated_equipInvenIndex_codec);
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
		if (CharInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CharInvenIndex);
		}
		num += equipInvenIndex_.CalculateSize(_repeated_equipInvenIndex_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipBatchUseInfo other)
	{
		if (other != null)
		{
			if (other.CharInvenIndex != 0L)
			{
				CharInvenIndex = other.CharInvenIndex;
			}
			equipInvenIndex_.Add(other.equipInvenIndex_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				equipInvenIndex_.AddEntriesFrom(ref input, _repeated_equipInvenIndex_codec);
				break;
			case 8u:
				CharInvenIndex = input.ReadInt64();
				break;
			}
		}
	}
}
