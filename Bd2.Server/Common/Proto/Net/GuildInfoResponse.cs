using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildInfoResponse : IMessage<GuildInfoResponse>, IMessage, IEquatable<GuildInfoResponse>, IDeepCloneable<GuildInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildInfoResponse> _parser = new MessageParser<GuildInfoResponse>(() => new GuildInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int GuildInfoFieldNumber = 1;

	private GuildDBInfo guildInfo_;

	public const int MemberInfoFieldNumber = 2;

	private static readonly FieldCodec<GuildMemberDBInfo> _repeated_memberInfo_codec = FieldCodec.ForMessage(18u, GuildMemberDBInfo.Parser);

	private readonly RepeatedField<GuildMemberDBInfo> memberInfo_ = new RepeatedField<GuildMemberDBInfo>();

	public const int JoinRecvInfoFieldNumber = 3;

	private static readonly FieldCodec<UserBaseDBInfo> _repeated_joinRecvInfo_codec = FieldCodec.ForMessage(26u, UserBaseDBInfo.Parser);

	private readonly RepeatedField<UserBaseDBInfo> joinRecvInfo_ = new RepeatedField<UserBaseDBInfo>();

	public const int ActionInfoFieldNumber = 4;

	private static readonly FieldCodec<GuildActionDBInfo> _repeated_actionInfo_codec = FieldCodec.ForMessage(34u, GuildActionDBInfo.Parser);

	private readonly RepeatedField<GuildActionDBInfo> actionInfo_ = new RepeatedField<GuildActionDBInfo>();

	public const int IsAttendanceFieldNumber = 5;

	private bool isAttendance_;

	public const int RaidPlayInfoFieldNumber = 6;

	private GuildRaidPlayDBInfo raidPlayInfo_;

	public const int BanTimeFieldNumber = 7;

	private long banTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildDBInfo GuildInfo
	{
		get
		{
			return guildInfo_;
		}
		set
		{
			guildInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GuildMemberDBInfo> MemberInfo => memberInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<UserBaseDBInfo> JoinRecvInfo => joinRecvInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GuildActionDBInfo> ActionInfo => actionInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsAttendance
	{
		get
		{
			return isAttendance_;
		}
		set
		{
			isAttendance_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidPlayDBInfo RaidPlayInfo
	{
		get
		{
			return raidPlayInfo_;
		}
		set
		{
			raidPlayInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BanTime
	{
		get
		{
			return banTime_;
		}
		set
		{
			banTime_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInfoResponse(GuildInfoResponse other)
		: this()
	{
		guildInfo_ = ((other.guildInfo_ != null) ? other.guildInfo_.Clone() : null);
		memberInfo_ = other.memberInfo_.Clone();
		joinRecvInfo_ = other.joinRecvInfo_.Clone();
		actionInfo_ = other.actionInfo_.Clone();
		isAttendance_ = other.isAttendance_;
		raidPlayInfo_ = ((other.raidPlayInfo_ != null) ? other.raidPlayInfo_.Clone() : null);
		banTime_ = other.banTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInfoResponse Clone()
	{
		return new GuildInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(GuildInfo, other.GuildInfo) && memberInfo_.Equals(other.memberInfo_) && joinRecvInfo_.Equals(other.joinRecvInfo_) && actionInfo_.Equals(other.actionInfo_) && IsAttendance == other.IsAttendance && object.Equals(RaidPlayInfo, other.RaidPlayInfo) && BanTime == other.BanTime)
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
		if (guildInfo_ != null)
		{
			num ^= GuildInfo.GetHashCode();
		}
		num ^= memberInfo_.GetHashCode();
		num ^= joinRecvInfo_.GetHashCode();
		num ^= actionInfo_.GetHashCode();
		if (IsAttendance)
		{
			num ^= IsAttendance.GetHashCode();
		}
		if (raidPlayInfo_ != null)
		{
			num ^= RaidPlayInfo.GetHashCode();
		}
		if (BanTime != 0L)
		{
			num ^= BanTime.GetHashCode();
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
		if (guildInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GuildInfo);
		}
		memberInfo_.WriteTo(ref output, _repeated_memberInfo_codec);
		joinRecvInfo_.WriteTo(ref output, _repeated_joinRecvInfo_codec);
		actionInfo_.WriteTo(ref output, _repeated_actionInfo_codec);
		if (IsAttendance)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsAttendance);
		}
		if (raidPlayInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(RaidPlayInfo);
		}
		if (BanTime != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(BanTime);
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
		if (guildInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuildInfo);
		}
		num += memberInfo_.CalculateSize(_repeated_memberInfo_codec);
		num += joinRecvInfo_.CalculateSize(_repeated_joinRecvInfo_codec);
		num += actionInfo_.CalculateSize(_repeated_actionInfo_codec);
		if (IsAttendance)
		{
			num += 2;
		}
		if (raidPlayInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RaidPlayInfo);
		}
		if (BanTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BanTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.guildInfo_ != null)
		{
			if (guildInfo_ == null)
			{
				GuildInfo = new GuildDBInfo();
			}
			GuildInfo.MergeFrom(other.GuildInfo);
		}
		memberInfo_.Add(other.memberInfo_);
		joinRecvInfo_.Add(other.joinRecvInfo_);
		actionInfo_.Add(other.actionInfo_);
		if (other.IsAttendance)
		{
			IsAttendance = other.IsAttendance;
		}
		if (other.raidPlayInfo_ != null)
		{
			if (raidPlayInfo_ == null)
			{
				RaidPlayInfo = new GuildRaidPlayDBInfo();
			}
			RaidPlayInfo.MergeFrom(other.RaidPlayInfo);
		}
		if (other.BanTime != 0L)
		{
			BanTime = other.BanTime;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (guildInfo_ == null)
				{
					GuildInfo = new GuildDBInfo();
				}
				input.ReadMessage(GuildInfo);
				break;
			case 18u:
				memberInfo_.AddEntriesFrom(ref input, _repeated_memberInfo_codec);
				break;
			case 26u:
				joinRecvInfo_.AddEntriesFrom(ref input, _repeated_joinRecvInfo_codec);
				break;
			case 34u:
				actionInfo_.AddEntriesFrom(ref input, _repeated_actionInfo_codec);
				break;
			case 40u:
				IsAttendance = input.ReadBool();
				break;
			case 50u:
				if (raidPlayInfo_ == null)
				{
					RaidPlayInfo = new GuildRaidPlayDBInfo();
				}
				input.ReadMessage(RaidPlayInfo);
				break;
			case 56u:
				BanTime = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
