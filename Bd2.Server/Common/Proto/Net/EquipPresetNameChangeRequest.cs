using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class EquipPresetNameChangeRequest : IMessage<EquipPresetNameChangeRequest>, IMessage, IEquatable<EquipPresetNameChangeRequest>, IDeepCloneable<EquipPresetNameChangeRequest>, IBufferMessage
{
	private static readonly MessageParser<EquipPresetNameChangeRequest> _parser = new MessageParser<EquipPresetNameChangeRequest>(() => new EquipPresetNameChangeRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int CharInvenIndexFieldNumber = 2;

	private long charInvenIndex_;

	public const int SlotFieldNumber = 3;

	private int slot_;

	public const int PresetNameFieldNumber = 4;

	private string presetName_ = "";

	public const int PresetResourceIdFieldNumber = 5;

	private int presetResourceId_;

	public const int PresetResourceColorFieldNumber = 6;

	private int presetResourceColor_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EquipPresetNameChangeRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EquipPresetNameChangeRequestReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public EquipPresetNameChangeRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipPresetNameChangeRequest(EquipPresetNameChangeRequest other)
		: this()
	{
		seq_ = other.seq_;
		charInvenIndex_ = other.charInvenIndex_;
		slot_ = other.slot_;
		presetName_ = other.presetName_;
		presetResourceId_ = other.presetResourceId_;
		presetResourceColor_ = other.presetResourceColor_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EquipPresetNameChangeRequest Clone()
	{
		return new EquipPresetNameChangeRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EquipPresetNameChangeRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(EquipPresetNameChangeRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && CharInvenIndex == other.CharInvenIndex && Slot == other.Slot && !(PresetName != other.PresetName) && PresetResourceId == other.PresetResourceId && PresetResourceColor == other.PresetResourceColor)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (CharInvenIndex != 0L)
		{
			num ^= CharInvenIndex.GetHashCode();
		}
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (CharInvenIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(CharInvenIndex);
		}
		if (Slot != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Slot);
		}
		if (PresetName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(PresetName);
		}
		if (PresetResourceId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PresetResourceId);
		}
		if (PresetResourceColor != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PresetResourceColor);
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
		}
		if (CharInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CharInvenIndex);
		}
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Slot);
		}
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(EquipPresetNameChangeRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.CharInvenIndex != 0L)
			{
				CharInvenIndex = other.CharInvenIndex;
			}
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
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
			case 8u:
				Seq = input.ReadInt32();
				break;
			case 16u:
				CharInvenIndex = input.ReadInt64();
				break;
			case 24u:
				Slot = input.ReadInt32();
				break;
			case 34u:
				PresetName = input.ReadString();
				break;
			case 40u:
				PresetResourceId = input.ReadInt32();
				break;
			case 48u:
				PresetResourceColor = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
