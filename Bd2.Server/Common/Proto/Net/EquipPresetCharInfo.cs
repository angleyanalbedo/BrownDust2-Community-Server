using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipPresetCharInfo : IMessage<EquipPresetCharInfo>, IMessage, IEquatable<EquipPresetCharInfo>, IDeepCloneable<EquipPresetCharInfo>, IBufferMessage
{
	private static readonly MessageParser<EquipPresetCharInfo> _parser = new MessageParser<EquipPresetCharInfo>(() => new EquipPresetCharInfo());

	private UnknownFieldSet _unknownFields;

	public const int CharInvenIndexFieldNumber = 1;

	private long charInvenIndex_;

	public const int PresetInfoFieldNumber = 2;

	private static readonly FieldCodec<EquipPresetDBInfo> _repeated_presetInfo_codec = FieldCodec.ForMessage(18u, EquipPresetDBInfo.Parser);

	private readonly RepeatedField<EquipPresetDBInfo> presetInfo_ = new RepeatedField<EquipPresetDBInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipPresetCharInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipPresetCharInfoReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<EquipPresetDBInfo> PresetInfo => presetInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipPresetCharInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipPresetCharInfo(EquipPresetCharInfo other)
		: this()
	{
		charInvenIndex_ = other.charInvenIndex_;
		presetInfo_ = other.presetInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipPresetCharInfo Clone()
	{
		return new EquipPresetCharInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipPresetCharInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipPresetCharInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (CharInvenIndex == other.CharInvenIndex && presetInfo_.Equals(other.presetInfo_))
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
		num ^= presetInfo_.GetHashCode();
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
		presetInfo_.WriteTo(ref output, _repeated_presetInfo_codec);
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
		num += presetInfo_.CalculateSize(_repeated_presetInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipPresetCharInfo other)
	{
		if (other != null)
		{
			if (other.CharInvenIndex != 0L)
			{
				CharInvenIndex = other.CharInvenIndex;
			}
			presetInfo_.Add(other.presetInfo_);
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
			case 18u:
				presetInfo_.AddEntriesFrom(ref input, _repeated_presetInfo_codec);
				break;
			case 8u:
				CharInvenIndex = input.ReadInt64();
				break;
			}
		}
	}
}
