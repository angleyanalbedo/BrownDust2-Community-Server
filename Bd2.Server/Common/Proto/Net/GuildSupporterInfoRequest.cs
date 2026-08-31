using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildSupporterInfoRequest : IMessage<GuildSupporterInfoRequest>, IMessage, IEquatable<GuildSupporterInfoRequest>, IDeepCloneable<GuildSupporterInfoRequest>, IBufferMessage
{
	private static readonly MessageParser<GuildSupporterInfoRequest> _parser = new MessageParser<GuildSupporterInfoRequest>(() => new GuildSupporterInfoRequest());

	private UnknownFieldSet _unknownFields;

	public const int SeqFieldNumber = 1;

	private int seq_;

	public const int MemberOwnerIndexFieldNumber = 2;

	private long memberOwnerIndex_;

	public const int SlotIndexFieldNumber = 3;

	private int slotIndex_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildSupporterInfoRequest> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildSupporterInfoRequestReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MemberOwnerIndex
	{
		get
		{
			return memberOwnerIndex_;
		}
		set
		{
			memberOwnerIndex_ = value;
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfoRequest()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfoRequest(GuildSupporterInfoRequest other)
		: this()
	{
		seq_ = other.seq_;
		memberOwnerIndex_ = other.memberOwnerIndex_;
		slotIndex_ = other.slotIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfoRequest Clone()
	{
		return new GuildSupporterInfoRequest(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildSupporterInfoRequest);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildSupporterInfoRequest other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (Seq == other.Seq && MemberOwnerIndex == other.MemberOwnerIndex && SlotIndex == other.SlotIndex)
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
		if (MemberOwnerIndex != 0L)
		{
			num ^= MemberOwnerIndex.GetHashCode();
		}
		if (SlotIndex != 0)
		{
			num ^= SlotIndex.GetHashCode();
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
		if (MemberOwnerIndex != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(MemberOwnerIndex);
		}
		if (SlotIndex != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SlotIndex);
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
		if (MemberOwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(MemberOwnerIndex);
		}
		if (SlotIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SlotIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildSupporterInfoRequest other)
	{
		if (other != null)
		{
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.MemberOwnerIndex != 0L)
			{
				MemberOwnerIndex = other.MemberOwnerIndex;
			}
			if (other.SlotIndex != 0)
			{
				SlotIndex = other.SlotIndex;
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
				SlotIndex = input.ReadInt32();
				break;
			case 16u:
				MemberOwnerIndex = input.ReadInt64();
				break;
			case 8u:
				Seq = input.ReadInt32();
				break;
			}
		}
	}
}
