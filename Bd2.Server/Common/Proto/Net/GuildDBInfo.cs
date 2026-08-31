using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildDBInfo : IMessage<GuildDBInfo>, IMessage, IEquatable<GuildDBInfo>, IDeepCloneable<GuildDBInfo>, IBufferMessage
{
	private static readonly MessageParser<GuildDBInfo> _parser = new MessageParser<GuildDBInfo>(() => new GuildDBInfo());

	private UnknownFieldSet _unknownFields;

	public const int GuildBaseInfoFieldNumber = 1;

	private GuildBaseDBInfo guildBaseInfo_;

	public const int JoinTypeFieldNumber = 2;

	private Define_GuildJoinType joinType_;

	public const int MessageFieldNumber = 3;

	private string message_ = "";

	public const int UpdateDateFieldNumber = 4;

	private long updateDate_;

	public const int DateFieldNumber = 5;

	private long date_;

	public const int MemberCountFieldNumber = 6;

	private int memberCount_;

	public const int DeleteRemainingTimeFieldNumber = 7;

	private long deleteRemainingTime_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildDBInfo> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildDBInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildBaseDBInfo GuildBaseInfo
	{
		get
		{
			return guildBaseInfo_;
		}
		set
		{
			guildBaseInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_GuildJoinType JoinType
	{
		get
		{
			return joinType_;
		}
		set
		{
			joinType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Message
	{
		get
		{
			return message_;
		}
		set
		{
			message_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long UpdateDate
	{
		get
		{
			return updateDate_;
		}
		set
		{
			updateDate_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Date
	{
		get
		{
			return date_;
		}
		set
		{
			date_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MemberCount
	{
		get
		{
			return memberCount_;
		}
		set
		{
			memberCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DeleteRemainingTime
	{
		get
		{
			return deleteRemainingTime_;
		}
		set
		{
			deleteRemainingTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildDBInfo()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildDBInfo(GuildDBInfo other)
		: this()
	{
		guildBaseInfo_ = ((other.guildBaseInfo_ != null) ? other.guildBaseInfo_.Clone() : null);
		joinType_ = other.joinType_;
		message_ = other.message_;
		updateDate_ = other.updateDate_;
		date_ = other.date_;
		memberCount_ = other.memberCount_;
		deleteRemainingTime_ = other.deleteRemainingTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildDBInfo Clone()
	{
		return new GuildDBInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildDBInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildDBInfo other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(GuildBaseInfo, other.GuildBaseInfo) && JoinType == other.JoinType && !(Message != other.Message) && UpdateDate == other.UpdateDate && Date == other.Date && MemberCount == other.MemberCount && DeleteRemainingTime == other.DeleteRemainingTime)
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
		if (guildBaseInfo_ != null)
		{
			num ^= GuildBaseInfo.GetHashCode();
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			num ^= JoinType.GetHashCode();
		}
		if (Message.Length != 0)
		{
			num ^= Message.GetHashCode();
		}
		if (UpdateDate != 0L)
		{
			num ^= UpdateDate.GetHashCode();
		}
		if (Date != 0L)
		{
			num ^= Date.GetHashCode();
		}
		if (MemberCount != 0)
		{
			num ^= MemberCount.GetHashCode();
		}
		if (DeleteRemainingTime != 0L)
		{
			num ^= DeleteRemainingTime.GetHashCode();
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
		if (guildBaseInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GuildBaseInfo);
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)JoinType);
		}
		if (Message.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Message);
		}
		if (UpdateDate != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(UpdateDate);
		}
		if (Date != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(Date);
		}
		if (MemberCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MemberCount);
		}
		if (DeleteRemainingTime != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(DeleteRemainingTime);
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
		if (guildBaseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuildBaseInfo);
		}
		if (JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)JoinType);
		}
		if (Message.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Message);
		}
		if (UpdateDate != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(UpdateDate);
		}
		if (Date != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Date);
		}
		if (MemberCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MemberCount);
		}
		if (DeleteRemainingTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DeleteRemainingTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildDBInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.guildBaseInfo_ != null)
		{
			if (guildBaseInfo_ == null)
			{
				GuildBaseInfo = new GuildBaseDBInfo();
			}
			GuildBaseInfo.MergeFrom(other.GuildBaseInfo);
		}
		if (other.JoinType != Define_GuildJoinType.GuildTypeNone)
		{
			JoinType = other.JoinType;
		}
		if (other.Message.Length != 0)
		{
			Message = other.Message;
		}
		if (other.UpdateDate != 0L)
		{
			UpdateDate = other.UpdateDate;
		}
		if (other.Date != 0L)
		{
			Date = other.Date;
		}
		if (other.MemberCount != 0)
		{
			MemberCount = other.MemberCount;
		}
		if (other.DeleteRemainingTime != 0L)
		{
			DeleteRemainingTime = other.DeleteRemainingTime;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (guildBaseInfo_ == null)
				{
					GuildBaseInfo = new GuildBaseDBInfo();
				}
				input.ReadMessage(GuildBaseInfo);
				break;
			case 16u:
				JoinType = (Define_GuildJoinType)input.ReadEnum();
				break;
			case 26u:
				Message = input.ReadString();
				break;
			case 32u:
				UpdateDate = input.ReadInt64();
				break;
			case 40u:
				Date = input.ReadInt64();
				break;
			case 48u:
				MemberCount = input.ReadInt32();
				break;
			case 56u:
				DeleteRemainingTime = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
