using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildSupporterAddRequest : IMessage<GuildSupporterAddRequest>, IMessage, IEquatable<GuildSupporterAddRequest>, IDeepCloneable<GuildSupporterAddRequest>, IBufferMessage
{
	private static readonly MessageParser<GuildSupporterAddRequest> _parser = new MessageParser<GuildSupporterAddRequest>(() => new GuildSupporterAddRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int SlotIndexFieldNumber = 2;

	private int slotIndex_;

	public const int CharInvenIndexFieldNumber = 3;

	private long charInvenIndex_;

	public const int CostumeInvenIndexFieldNumber = 4;

	private long costumeInvenIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildSupporterAddRequest> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildSupporterAddRequestReflection.Descriptor.MessageTypes[0];

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
	public int SlotIndex
	{
		get
		{
			return slotIndex_;
		}
		set
		{
			slotIndex_ = value;
		}
	}

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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CostumeInvenIndex
	{
		get
		{
			return costumeInvenIndex_;
		}
		set
		{
			costumeInvenIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterAddRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterAddRequest(GuildSupporterAddRequest other)
		: this()
	{
		seq_ = other.seq_;
		slotIndex_ = other.slotIndex_;
		charInvenIndex_ = other.charInvenIndex_;
		costumeInvenIndex_ = other.costumeInvenIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterAddRequest Clone()
	{
		return new GuildSupporterAddRequest(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildSupporterAddRequest);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildSupporterAddRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && SlotIndex == other.SlotIndex && CharInvenIndex == other.CharInvenIndex && CostumeInvenIndex == other.CostumeInvenIndex)
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
		if (SlotIndex != 0)
		{
			num ^= SlotIndex.GetHashCode();
		}
		if (CharInvenIndex != 0L)
		{
			num ^= CharInvenIndex.GetHashCode();
		}
		if (CostumeInvenIndex != 0L)
		{
			num ^= CostumeInvenIndex.GetHashCode();
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
		if (SlotIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SlotIndex);
		}
		if (CharInvenIndex != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(CharInvenIndex);
		}
		if (CostumeInvenIndex != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(CostumeInvenIndex);
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
		if (SlotIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SlotIndex);
		}
		if (CharInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CharInvenIndex);
		}
		if (CostumeInvenIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CostumeInvenIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildSupporterAddRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.SlotIndex != 0)
			{
				SlotIndex = other.SlotIndex;
			}
			if (other.CharInvenIndex != 0L)
			{
				CharInvenIndex = other.CharInvenIndex;
			}
			if (other.CostumeInvenIndex != 0L)
			{
				CostumeInvenIndex = other.CostumeInvenIndex;
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
			case 16u:
				SlotIndex = input.ReadInt32();
				break;
			case 24u:
				CharInvenIndex = input.ReadInt64();
				break;
			case 32u:
				CostumeInvenIndex = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
