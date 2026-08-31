using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildSupporterInfo : IMessage<GuildSupporterInfo>, IMessage, IEquatable<GuildSupporterInfo>, IDeepCloneable<GuildSupporterInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildSupporterInfo> _parser = new MessageParser<GuildSupporterInfo>(() => new GuildSupporterInfo());

	private UnknownFieldSet _unknownFields;

	public const int OwnerIndexFieldNumber = 1;

	private long ownerIndex_;

	public const int SlotIndexFieldNumber = 2;

	private int slotIndex_;

	public const int UserIdFieldNumber = 3;

	private string userId_ = "";

	public const int BattleUseCountFieldNumber = 4;

	private int battleUseCount_;

	public const int SupporterCharInfoProtoFieldNumber = 5;

	private string supporterCharInfoProto_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildSupporterInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildSupporterInfoReflection.Descriptor.MessageTypes[1];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long OwnerIndex
	{
		get
		{
			return ownerIndex_;
		}
		set
		{
			ownerIndex_ = value;
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
	public string UserId
	{
		get
		{
			return userId_;
		}
		set
		{
			userId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleUseCount
	{
		get
		{
			return battleUseCount_;
		}
		set
		{
			battleUseCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string SupporterCharInfoProto
	{
		get
		{
			return supporterCharInfoProto_;
		}
		set
		{
			supporterCharInfoProto_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfo(GuildSupporterInfo other)
		: this()
	{
		ownerIndex_ = other.ownerIndex_;
		slotIndex_ = other.slotIndex_;
		userId_ = other.userId_;
		battleUseCount_ = other.battleUseCount_;
		supporterCharInfoProto_ = other.supporterCharInfoProto_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSupporterInfo Clone()
	{
		return new GuildSupporterInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildSupporterInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildSupporterInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (OwnerIndex == other.OwnerIndex && SlotIndex == other.SlotIndex && !(UserId != other.UserId) && BattleUseCount == other.BattleUseCount && !(SupporterCharInfoProto != other.SupporterCharInfoProto))
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
		if (OwnerIndex != 0L)
		{
			num ^= OwnerIndex.GetHashCode();
		}
		if (SlotIndex != 0)
		{
			num ^= SlotIndex.GetHashCode();
		}
		if (UserId.Length != 0)
		{
			num ^= UserId.GetHashCode();
		}
		if (BattleUseCount != 0)
		{
			num ^= BattleUseCount.GetHashCode();
		}
		if (SupporterCharInfoProto.Length != 0)
		{
			num ^= SupporterCharInfoProto.GetHashCode();
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
		if (OwnerIndex != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(OwnerIndex);
		}
		if (SlotIndex != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SlotIndex);
		}
		if (UserId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(UserId);
		}
		if (BattleUseCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BattleUseCount);
		}
		if (SupporterCharInfoProto.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(SupporterCharInfoProto);
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
		if (OwnerIndex != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(OwnerIndex);
		}
		if (SlotIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SlotIndex);
		}
		if (UserId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserId);
		}
		if (BattleUseCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleUseCount);
		}
		if (SupporterCharInfoProto.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SupporterCharInfoProto);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildSupporterInfo other)
	{
		if (other != null)
		{
			if (other.OwnerIndex != 0L)
			{
				OwnerIndex = other.OwnerIndex;
			}
			if (other.SlotIndex != 0)
			{
				SlotIndex = other.SlotIndex;
			}
			if (other.UserId.Length != 0)
			{
				UserId = other.UserId;
			}
			if (other.BattleUseCount != 0)
			{
				BattleUseCount = other.BattleUseCount;
			}
			if (other.SupporterCharInfoProto.Length != 0)
			{
				SupporterCharInfoProto = other.SupporterCharInfoProto;
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
				OwnerIndex = input.ReadInt64();
				break;
			case 16u:
				SlotIndex = input.ReadInt32();
				break;
			case 26u:
				UserId = input.ReadString();
				break;
			case 32u:
				BattleUseCount = input.ReadInt32();
				break;
			case 42u:
				SupporterCharInfoProto = input.ReadString();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
