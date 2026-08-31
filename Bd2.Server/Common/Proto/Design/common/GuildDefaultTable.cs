using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public sealed class GuildDefaultTable : IMessage<GuildDefaultTable>, IMessage, IEquatable<GuildDefaultTable>, IDeepCloneable<GuildDefaultTable>, IBufferMessage
{
	private static readonly MessageParser<GuildDefaultTable> _parser = new MessageParser<GuildDefaultTable>(() => new GuildDefaultTable());

	private UnknownFieldSet _unknownFields;

	public const int ChatDeleteCountFieldNumber = 1;

	private int chatDeleteCount_;

	public const int ChatDeleteTimeFieldNumber = 2;

	private int chatDeleteTime_;

	public const int GuildAttendanceRewardCountFieldNumber = 3;

	private int guildAttendanceRewardCount_;

	public const int GuildAttendanceRewardIdFieldNumber = 4;

	private int guildAttendanceRewardId_;

	public const int GuildAttendanceRewardTypeFieldNumber = 5;

	private int guildAttendanceRewardType_;

	public const int GuildCreateItemCountFieldNumber = 6;

	private int guildCreateItemCount_;

	public const int GuildCreateItemIdFieldNumber = 7;

	private int guildCreateItemId_;

	public const int GuildCreateItemTypeFieldNumber = 8;

	private int guildCreateItemType_;

	public const int GuildDeleteCancelTimeFieldNumber = 9;

	private int guildDeleteCancelTime_;

	public const int GuildGuideIdFieldNumber = 10;

	private int guildGuideId_;

	public const int GuildListCountFieldNumber = 11;

	private int guildListCount_;

	public const int GuildMaxMemberCountFieldNumber = 12;

	private int guildMaxMemberCount_;

	public const int GuildSignDelayTimeFieldNumber = 13;

	private int guildSignDelayTime_;

	public const int GuildSignListCountFieldNumber = 14;

	private int guildSignListCount_;

	public const int GuildSignRequestExpireTimeFieldNumber = 15;

	private int guildSignRequestExpireTime_;

	public const int IdFieldNumber = 16;

	private int id_;

	public const int PreGuildGuideIdFieldNumber = 17;

	private int preGuildGuideId_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildDefaultTable> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildDefaultTableReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ChatDeleteCount
	{
		get
		{
			return chatDeleteCount_;
		}
		set
		{
			chatDeleteCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ChatDeleteTime
	{
		get
		{
			return chatDeleteTime_;
		}
		set
		{
			chatDeleteTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildAttendanceRewardCount
	{
		get
		{
			return guildAttendanceRewardCount_;
		}
		set
		{
			guildAttendanceRewardCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildAttendanceRewardId
	{
		get
		{
			return guildAttendanceRewardId_;
		}
		set
		{
			guildAttendanceRewardId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildAttendanceRewardType
	{
		get
		{
			return guildAttendanceRewardType_;
		}
		set
		{
			guildAttendanceRewardType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildCreateItemCount
	{
		get
		{
			return guildCreateItemCount_;
		}
		set
		{
			guildCreateItemCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildCreateItemId
	{
		get
		{
			return guildCreateItemId_;
		}
		set
		{
			guildCreateItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildCreateItemType
	{
		get
		{
			return guildCreateItemType_;
		}
		set
		{
			guildCreateItemType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildDeleteCancelTime
	{
		get
		{
			return guildDeleteCancelTime_;
		}
		set
		{
			guildDeleteCancelTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildGuideId
	{
		get
		{
			return guildGuideId_;
		}
		set
		{
			guildGuideId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildListCount
	{
		get
		{
			return guildListCount_;
		}
		set
		{
			guildListCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildMaxMemberCount
	{
		get
		{
			return guildMaxMemberCount_;
		}
		set
		{
			guildMaxMemberCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildSignDelayTime
	{
		get
		{
			return guildSignDelayTime_;
		}
		set
		{
			guildSignDelayTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildSignListCount
	{
		get
		{
			return guildSignListCount_;
		}
		set
		{
			guildSignListCount_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int GuildSignRequestExpireTime
	{
		get
		{
			return guildSignRequestExpireTime_;
		}
		set
		{
			guildSignRequestExpireTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int PreGuildGuideId
	{
		get
		{
			return preGuildGuideId_;
		}
		set
		{
			preGuildGuideId_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildDefaultTable()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildDefaultTable(GuildDefaultTable other)
		: this()
	{
		chatDeleteCount_ = other.chatDeleteCount_;
		chatDeleteTime_ = other.chatDeleteTime_;
		guildAttendanceRewardCount_ = other.guildAttendanceRewardCount_;
		guildAttendanceRewardId_ = other.guildAttendanceRewardId_;
		guildAttendanceRewardType_ = other.guildAttendanceRewardType_;
		guildCreateItemCount_ = other.guildCreateItemCount_;
		guildCreateItemId_ = other.guildCreateItemId_;
		guildCreateItemType_ = other.guildCreateItemType_;
		guildDeleteCancelTime_ = other.guildDeleteCancelTime_;
		guildGuideId_ = other.guildGuideId_;
		guildListCount_ = other.guildListCount_;
		guildMaxMemberCount_ = other.guildMaxMemberCount_;
		guildSignDelayTime_ = other.guildSignDelayTime_;
		guildSignListCount_ = other.guildSignListCount_;
		guildSignRequestExpireTime_ = other.guildSignRequestExpireTime_;
		id_ = other.id_;
		preGuildGuideId_ = other.preGuildGuideId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildDefaultTable Clone()
	{
		return new GuildDefaultTable(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildDefaultTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildDefaultTable other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (ChatDeleteCount == other.ChatDeleteCount && ChatDeleteTime == other.ChatDeleteTime && GuildAttendanceRewardCount == other.GuildAttendanceRewardCount && GuildAttendanceRewardId == other.GuildAttendanceRewardId && GuildAttendanceRewardType == other.GuildAttendanceRewardType && GuildCreateItemCount == other.GuildCreateItemCount && GuildCreateItemId == other.GuildCreateItemId && GuildCreateItemType == other.GuildCreateItemType && GuildDeleteCancelTime == other.GuildDeleteCancelTime && GuildGuideId == other.GuildGuideId && GuildListCount == other.GuildListCount && GuildMaxMemberCount == other.GuildMaxMemberCount && GuildSignDelayTime == other.GuildSignDelayTime && GuildSignListCount == other.GuildSignListCount && GuildSignRequestExpireTime == other.GuildSignRequestExpireTime && Id == other.Id && PreGuildGuideId == other.PreGuildGuideId)
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
		if (ChatDeleteCount != 0)
		{
			num ^= ChatDeleteCount.GetHashCode();
		}
		if (ChatDeleteTime != 0)
		{
			num ^= ChatDeleteTime.GetHashCode();
		}
		if (GuildAttendanceRewardCount != 0)
		{
			num ^= GuildAttendanceRewardCount.GetHashCode();
		}
		if (GuildAttendanceRewardId != 0)
		{
			num ^= GuildAttendanceRewardId.GetHashCode();
		}
		if (GuildAttendanceRewardType != 0)
		{
			num ^= GuildAttendanceRewardType.GetHashCode();
		}
		if (GuildCreateItemCount != 0)
		{
			num ^= GuildCreateItemCount.GetHashCode();
		}
		if (GuildCreateItemId != 0)
		{
			num ^= GuildCreateItemId.GetHashCode();
		}
		if (GuildCreateItemType != 0)
		{
			num ^= GuildCreateItemType.GetHashCode();
		}
		if (GuildDeleteCancelTime != 0)
		{
			num ^= GuildDeleteCancelTime.GetHashCode();
		}
		if (GuildGuideId != 0)
		{
			num ^= GuildGuideId.GetHashCode();
		}
		if (GuildListCount != 0)
		{
			num ^= GuildListCount.GetHashCode();
		}
		if (GuildMaxMemberCount != 0)
		{
			num ^= GuildMaxMemberCount.GetHashCode();
		}
		if (GuildSignDelayTime != 0)
		{
			num ^= GuildSignDelayTime.GetHashCode();
		}
		if (GuildSignListCount != 0)
		{
			num ^= GuildSignListCount.GetHashCode();
		}
		if (GuildSignRequestExpireTime != 0)
		{
			num ^= GuildSignRequestExpireTime.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PreGuildGuideId != 0)
		{
			num ^= PreGuildGuideId.GetHashCode();
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
		if (ChatDeleteCount != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ChatDeleteCount);
		}
		if (ChatDeleteTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ChatDeleteTime);
		}
		if (GuildAttendanceRewardCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GuildAttendanceRewardCount);
		}
		if (GuildAttendanceRewardId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GuildAttendanceRewardId);
		}
		if (GuildAttendanceRewardType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(GuildAttendanceRewardType);
		}
		if (GuildCreateItemCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(GuildCreateItemCount);
		}
		if (GuildCreateItemId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GuildCreateItemId);
		}
		if (GuildCreateItemType != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(GuildCreateItemType);
		}
		if (GuildDeleteCancelTime != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(GuildDeleteCancelTime);
		}
		if (GuildGuideId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(GuildGuideId);
		}
		if (GuildListCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(GuildListCount);
		}
		if (GuildMaxMemberCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(GuildMaxMemberCount);
		}
		if (GuildSignDelayTime != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(GuildSignDelayTime);
		}
		if (GuildSignListCount != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(GuildSignListCount);
		}
		if (GuildSignRequestExpireTime != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(GuildSignRequestExpireTime);
		}
		if (Id != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(Id);
		}
		if (PreGuildGuideId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(PreGuildGuideId);
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
		if (ChatDeleteCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChatDeleteCount);
		}
		if (ChatDeleteTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChatDeleteTime);
		}
		if (GuildAttendanceRewardCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildAttendanceRewardCount);
		}
		if (GuildAttendanceRewardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildAttendanceRewardId);
		}
		if (GuildAttendanceRewardType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildAttendanceRewardType);
		}
		if (GuildCreateItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildCreateItemCount);
		}
		if (GuildCreateItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildCreateItemId);
		}
		if (GuildCreateItemType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildCreateItemType);
		}
		if (GuildDeleteCancelTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildDeleteCancelTime);
		}
		if (GuildGuideId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildGuideId);
		}
		if (GuildListCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildListCount);
		}
		if (GuildMaxMemberCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildMaxMemberCount);
		}
		if (GuildSignDelayTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildSignDelayTime);
		}
		if (GuildSignListCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildSignListCount);
		}
		if (GuildSignRequestExpireTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GuildSignRequestExpireTime);
		}
		if (Id != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (PreGuildGuideId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PreGuildGuideId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildDefaultTable other)
	{
		if (other != null)
		{
			if (other.ChatDeleteCount != 0)
			{
				ChatDeleteCount = other.ChatDeleteCount;
			}
			if (other.ChatDeleteTime != 0)
			{
				ChatDeleteTime = other.ChatDeleteTime;
			}
			if (other.GuildAttendanceRewardCount != 0)
			{
				GuildAttendanceRewardCount = other.GuildAttendanceRewardCount;
			}
			if (other.GuildAttendanceRewardId != 0)
			{
				GuildAttendanceRewardId = other.GuildAttendanceRewardId;
			}
			if (other.GuildAttendanceRewardType != 0)
			{
				GuildAttendanceRewardType = other.GuildAttendanceRewardType;
			}
			if (other.GuildCreateItemCount != 0)
			{
				GuildCreateItemCount = other.GuildCreateItemCount;
			}
			if (other.GuildCreateItemId != 0)
			{
				GuildCreateItemId = other.GuildCreateItemId;
			}
			if (other.GuildCreateItemType != 0)
			{
				GuildCreateItemType = other.GuildCreateItemType;
			}
			if (other.GuildDeleteCancelTime != 0)
			{
				GuildDeleteCancelTime = other.GuildDeleteCancelTime;
			}
			if (other.GuildGuideId != 0)
			{
				GuildGuideId = other.GuildGuideId;
			}
			if (other.GuildListCount != 0)
			{
				GuildListCount = other.GuildListCount;
			}
			if (other.GuildMaxMemberCount != 0)
			{
				GuildMaxMemberCount = other.GuildMaxMemberCount;
			}
			if (other.GuildSignDelayTime != 0)
			{
				GuildSignDelayTime = other.GuildSignDelayTime;
			}
			if (other.GuildSignListCount != 0)
			{
				GuildSignListCount = other.GuildSignListCount;
			}
			if (other.GuildSignRequestExpireTime != 0)
			{
				GuildSignRequestExpireTime = other.GuildSignRequestExpireTime;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.PreGuildGuideId != 0)
			{
				PreGuildGuideId = other.PreGuildGuideId;
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
				ChatDeleteCount = input.ReadInt32();
				break;
			case 16u:
				ChatDeleteTime = input.ReadInt32();
				break;
			case 24u:
				GuildAttendanceRewardCount = input.ReadInt32();
				break;
			case 32u:
				GuildAttendanceRewardId = input.ReadInt32();
				break;
			case 40u:
				GuildAttendanceRewardType = input.ReadInt32();
				break;
			case 48u:
				GuildCreateItemCount = input.ReadInt32();
				break;
			case 56u:
				GuildCreateItemId = input.ReadInt32();
				break;
			case 64u:
				GuildCreateItemType = input.ReadInt32();
				break;
			case 72u:
				GuildDeleteCancelTime = input.ReadInt32();
				break;
			case 80u:
				GuildGuideId = input.ReadInt32();
				break;
			case 88u:
				GuildListCount = input.ReadInt32();
				break;
			case 96u:
				GuildMaxMemberCount = input.ReadInt32();
				break;
			case 104u:
				GuildSignDelayTime = input.ReadInt32();
				break;
			case 112u:
				GuildSignListCount = input.ReadInt32();
				break;
			case 120u:
				GuildSignRequestExpireTime = input.ReadInt32();
				break;
			case 128u:
				Id = input.ReadInt32();
				break;
			case 136u:
				PreGuildGuideId = input.ReadInt32();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
