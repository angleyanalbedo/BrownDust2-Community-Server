using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PresetDBInfo : IMessage<PresetDBInfo>, IMessage, IEquatable<PresetDBInfo>, IDeepCloneable<PresetDBInfo>, IBufferMessage
{
	private static readonly MessageParser<PresetDBInfo> _parser = new MessageParser<PresetDBInfo>(() => new PresetDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int PresetNameFieldNumber = 1;

	private string presetName_ = "";

	public const int PresetResourceIdFieldNumber = 2;

	private int presetResourceId_;

	public const int PresetResourceColorFieldNumber = 3;

	private int presetResourceColor_;

	public const int SlotFieldNumber = 4;

	private int slot_;

	public const int DeckInfoFieldNumber = 5;

	private static readonly FieldCodec<PresetDeckDBInfo> _repeated_deckInfo_codec = FieldCodec.ForMessage(42u, PresetDeckDBInfo.Parser);

	private readonly RepeatedField<PresetDeckDBInfo> deckInfo_ = new RepeatedField<PresetDeckDBInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PresetDBInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PresetDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PresetResourceId
	{
		get
		{
			return presetResourceId_;
		}
		set
		{
			presetResourceId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PresetResourceColor
	{
		get
		{
			return presetResourceColor_;
		}
		set
		{
			presetResourceColor_ = value;
		}
	}

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
	public RepeatedField<PresetDeckDBInfo> DeckInfo => deckInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDBInfo(PresetDBInfo other)
		: this()
	{
		presetName_ = other.presetName_;
		presetResourceId_ = other.presetResourceId_;
		presetResourceColor_ = other.presetResourceColor_;
		slot_ = other.slot_;
		deckInfo_ = other.deckInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetDBInfo Clone()
	{
		return new PresetDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PresetDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(PresetName != other.PresetName) && PresetResourceId == other.PresetResourceId && PresetResourceColor == other.PresetResourceColor && Slot == other.Slot && deckInfo_.Equals(other.deckInfo_))
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
		if (PresetName.Length != 0)
		{
			num ^= PresetName.GetHashCode();
		}
		if (PresetResourceId != 0)
		{
			num ^= PresetResourceId.GetHashCode();
		}
		if (PresetResourceColor != 0)
		{
			num ^= PresetResourceColor.GetHashCode();
		}
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
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
		if (PresetName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PresetName);
		}
		if (PresetResourceId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PresetResourceId);
		}
		if (PresetResourceColor != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PresetResourceColor);
		}
		if (Slot != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Slot);
		}
		deckInfo_.WriteTo(ref output, _repeated_deckInfo_codec);
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
		if (PresetName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PresetName);
		}
		if (PresetResourceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PresetResourceId);
		}
		if (PresetResourceColor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PresetResourceColor);
		}
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Slot);
		}
		num += deckInfo_.CalculateSize(_repeated_deckInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PresetDBInfo other)
	{
		if (other != null)
		{
			if (other.PresetName.Length != 0)
			{
				PresetName = other.PresetName;
			}
			if (other.PresetResourceId != 0)
			{
				PresetResourceId = other.PresetResourceId;
			}
			if (other.PresetResourceColor != 0)
			{
				PresetResourceColor = other.PresetResourceColor;
			}
			if (other.Slot != 0)
			{
				Slot = other.Slot;
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			case 10u:
				PresetName = input.ReadString();
				break;
			case 16u:
				PresetResourceId = input.ReadInt32();
				break;
			case 24u:
				PresetResourceColor = input.ReadInt32();
				break;
			case 32u:
				Slot = input.ReadInt32();
				break;
			case 42u:
				deckInfo_.AddEntriesFrom(ref input, _repeated_deckInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
