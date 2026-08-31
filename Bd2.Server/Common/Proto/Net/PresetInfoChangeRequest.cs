using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class PresetInfoChangeRequest : IMessage<PresetInfoChangeRequest>, IMessage, IEquatable<PresetInfoChangeRequest>, IDeepCloneable<PresetInfoChangeRequest>, IBufferMessage
{
	private static readonly MessageParser<PresetInfoChangeRequest> _parser = new MessageParser<PresetInfoChangeRequest>(() => new PresetInfoChangeRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int PresetNameFieldNumber = 2;

	private string presetName_ = "";

	public const int PresetResourceIdFieldNumber = 3;

	private int presetResourceId_;

	public const int PresetResourceColorFieldNumber = 4;

	private int presetResourceColor_;

	public const int SlotFieldNumber = 5;

	private int slot_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetInfoChangeRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => PresetInfoChangeRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetInfoChangeRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetInfoChangeRequest(PresetInfoChangeRequest other)
		: this()
	{
		seq_ = other.seq_;
		presetName_ = other.presetName_;
		presetResourceId_ = other.presetResourceId_;
		presetResourceColor_ = other.presetResourceColor_;
		slot_ = other.slot_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetInfoChangeRequest Clone()
	{
		return new PresetInfoChangeRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as PresetInfoChangeRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PresetInfoChangeRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && !(PresetName != other.PresetName) && PresetResourceId == other.PresetResourceId && PresetResourceColor == other.PresetResourceColor && Slot == other.Slot)
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
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
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
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
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
		if (Seq != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Seq);
		}
		if (PresetName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(PresetName);
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
		if (Slot != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Slot);
		}
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
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Seq);
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
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Slot);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetInfoChangeRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
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
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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
				Seq = input.ReadInt32();
				break;
			case 18u:
				PresetName = input.ReadString();
				break;
			case 24u:
				PresetResourceId = input.ReadInt32();
				break;
			case 32u:
				PresetResourceColor = input.ReadInt32();
				break;
			case 40u:
				Slot = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
