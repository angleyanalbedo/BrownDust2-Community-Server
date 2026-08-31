using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipPresetDBInfo : IMessage<EquipPresetDBInfo>, IMessage, IEquatable<EquipPresetDBInfo>, IDeepCloneable<EquipPresetDBInfo>, IBufferMessage
{
	private static readonly MessageParser<EquipPresetDBInfo> _parser = new MessageParser<EquipPresetDBInfo>(() => new EquipPresetDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int PresetNameFieldNumber = 1;

	private string presetName_ = "";

	public const int SlotFieldNumber = 2;

	private int slot_;

	public const int PresetResourceIdFieldNumber = 3;

	private int presetResourceId_;

	public const int PresetResourceColorFieldNumber = 4;

	private int presetResourceColor_;

	public const int ItemInfoFieldNumber = 5;

	private static readonly FieldCodec<EquipPresetItemInfo> _repeated_itemInfo_codec = FieldCodec.ForMessage(42u, EquipPresetItemInfo.Parser);

	private readonly RepeatedField<EquipPresetItemInfo> itemInfo_ = new RepeatedField<EquipPresetItemInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EquipPresetDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => EquipPresetDBInfoReflection.Descriptor.MessageTypes[0];

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EquipPresetItemInfo> ItemInfo => itemInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EquipPresetDBInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipPresetDBInfo(EquipPresetDBInfo other)
		: this()
	{
		presetName_ = other.presetName_;
		slot_ = other.slot_;
		presetResourceId_ = other.presetResourceId_;
		presetResourceColor_ = other.presetResourceColor_;
		itemInfo_ = other.itemInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipPresetDBInfo Clone()
	{
		return new EquipPresetDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipPresetDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EquipPresetDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (!(PresetName != other.PresetName) && Slot == other.Slot && PresetResourceId == other.PresetResourceId && PresetResourceColor == other.PresetResourceColor && itemInfo_.Equals(other.itemInfo_))
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
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (PresetResourceId != 0)
		{
			num ^= PresetResourceId.GetHashCode();
		}
		if (PresetResourceColor != 0)
		{
			num ^= PresetResourceColor.GetHashCode();
		}
		num ^= itemInfo_.GetHashCode();
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
		if (PresetName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PresetName);
		}
		if (Slot != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Slot);
		}
		if (PresetResourceId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PresetResourceId);
		}
		if (PresetResourceColor != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PresetResourceColor);
		}
		itemInfo_.WriteTo(ref output, _repeated_itemInfo_codec);
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
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Slot);
		}
		if (PresetResourceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PresetResourceId);
		}
		if (PresetResourceColor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PresetResourceColor);
		}
		num += itemInfo_.CalculateSize(_repeated_itemInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EquipPresetDBInfo other)
	{
		if (other != null)
		{
			if (other.PresetName.Length != 0)
			{
				PresetName = other.PresetName;
			}
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			if (other.PresetResourceId != 0)
			{
				PresetResourceId = other.PresetResourceId;
			}
			if (other.PresetResourceColor != 0)
			{
				PresetResourceColor = other.PresetResourceColor;
			}
			itemInfo_.Add(other.itemInfo_);
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
			case 10u:
				PresetName = input.ReadString();
				break;
			case 16u:
				Slot = input.ReadInt32();
				break;
			case 24u:
				PresetResourceId = input.ReadInt32();
				break;
			case 32u:
				PresetResourceColor = input.ReadInt32();
				break;
			case 42u:
				itemInfo_.AddEntriesFrom(ref input, _repeated_itemInfo_codec);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
