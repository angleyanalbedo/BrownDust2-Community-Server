using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TotalWarDeckPresetDBInfo : IMessage<TotalWarDeckPresetDBInfo>, IMessage, IEquatable<TotalWarDeckPresetDBInfo>, IDeepCloneable<TotalWarDeckPresetDBInfo>, IBufferMessage
{
	private static readonly MessageParser<TotalWarDeckPresetDBInfo> _parser = new MessageParser<TotalWarDeckPresetDBInfo>(() => new TotalWarDeckPresetDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int SlotFieldNumber = 1;

	private int slot_;

	public const int PresetNameFieldNumber = 2;

	private string presetName_ = "";

	public const int DeckInfoFieldNumber = 3;

	private static readonly FieldCodec<TotalWarDeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(26u, TotalWarDeckDBInfo.Parser);

	private readonly RepeatedField<TotalWarDeckDBInfo> deckInfo_ = new RepeatedField<TotalWarDeckDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TotalWarDeckPresetDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TotalWarDeckPresetDBInfoReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PresetName
	{
		get
		{
			return presetName_;
		}
		set
		{
			presetName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<TotalWarDeckDBInfo> DeckInfo => deckInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TotalWarDeckPresetDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TotalWarDeckPresetDBInfo(TotalWarDeckPresetDBInfo other)
		: this()
	{
		slot_ = other.slot_;
		presetName_ = other.presetName_;
		deckInfo_ = other.deckInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TotalWarDeckPresetDBInfo Clone()
	{
		return new TotalWarDeckPresetDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarDeckPresetDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TotalWarDeckPresetDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Slot == other.Slot && !(PresetName != other.PresetName) && deckInfo_.Equals(other.deckInfo_))
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
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (PresetName.Length != 0)
		{
			num ^= PresetName.GetHashCode();
		}
		num ^= deckInfo_.GetHashCode();
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
		if (Slot != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Slot);
		}
		if (PresetName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(PresetName);
		}
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
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
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Slot);
		}
		if (PresetName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PresetName);
		}
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TotalWarDeckPresetDBInfo other)
	{
		if (other != null)
		{
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			if (other.PresetName.Length != 0)
			{
				PresetName = other.PresetName;
			}
			deckInfo_.Add(other.deckInfo_);
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
			case 26u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			case 18u:
				PresetName = input.ReadString();
				break;
			case 8u:
				Slot = input.ReadInt32();
				break;
			}
		}
	}
}
