using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipClearInfo : IMessage<EquipClearInfo>, IMessage, IEquatable<EquipClearInfo>, IDeepCloneable<EquipClearInfo>, IBufferMessage
{
	private static readonly MessageParser<EquipClearInfo> _parser = new MessageParser<EquipClearInfo>(() => new EquipClearInfo());

	private UnknownFieldSet _unknownFields;

	public const int CharInvenIndexFieldNumber = 1;

	private long charInvenIndex_;

	public const int EquipInvenIndexFieldNumber = 2;

	private static readonly FieldCodec<long> _repeated_equipInvenIndex_codec = FieldCodec.ForInt64(18u);

	private readonly RepeatedField<long> equipInvenIndex_ = new RepeatedField<long>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipClearInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipsClearRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
	public EquipClearInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipClearInfo(EquipClearInfo other)
		: this()
	{
		charInvenIndex_ = other.charInvenIndex_;
		equipInvenIndex_ = other.equipInvenIndex_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipClearInfo Clone()
	{
		return new EquipClearInfo(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as EquipClearInfo);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipClearInfo other)
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EquipClearInfo other)
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
