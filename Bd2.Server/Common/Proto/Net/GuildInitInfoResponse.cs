using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildInitInfoResponse : IMessage<GuildInitInfoResponse>, IMessage, IEquatable<GuildInitInfoResponse>, IDeepCloneable<GuildInitInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildInitInfoResponse> _parser = new MessageParser<GuildInitInfoResponse>(() => new GuildInitInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int JoinRecvInfoFieldNumber = 1;

	private static readonly FieldCodec<UserBaseDBInfo> _repeated_joinRecvInfo_codec = FieldCodec.ForMessage(10u, UserBaseDBInfo.Parser);

	private readonly RepeatedField<UserBaseDBInfo> joinRecvInfo_ = new RepeatedField<UserBaseDBInfo>();

	public const int ActionInfoFieldNumber = 2;

	private static readonly FieldCodec<GuildActionDBInfo> _repeated_actionInfo_codec = FieldCodec.ForMessage(18u, GuildActionDBInfo.Parser);

	private readonly RepeatedField<GuildActionDBInfo> actionInfo_ = new RepeatedField<GuildActionDBInfo>();

	public const int IsRewardFieldNumber = 3;

	private bool isReward_;

	public const int RaidPlayInfoFieldNumber = 4;

	private GuildRaidPlayDBInfo raidPlayInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildInitInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildInitInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UserBaseDBInfo> JoinRecvInfo => joinRecvInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GuildActionDBInfo> ActionInfo => actionInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsReward
	{
		get
		{
			return isReward_;
		}
		set
		{
			isReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
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
	public GuildInitInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInitInfoResponse(GuildInitInfoResponse other)
		: this()
	{
		joinRecvInfo_ = other.joinRecvInfo_.Clone();
		actionInfo_ = other.actionInfo_.Clone();
		isReward_ = other.isReward_;
		raidPlayInfo_ = ((other.raidPlayInfo_ != null) ? other.raidPlayInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInitInfoResponse Clone()
	{
		return new GuildInitInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildInitInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildInitInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (joinRecvInfo_.Equals(other.joinRecvInfo_) && actionInfo_.Equals(other.actionInfo_) && IsReward == other.IsReward && object.Equals(RaidPlayInfo, other.RaidPlayInfo))
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
		num ^= joinRecvInfo_.GetHashCode();
		num ^= actionInfo_.GetHashCode();
		if (IsReward)
		{
			num ^= IsReward.GetHashCode();
		}
		if (raidPlayInfo_ != null)
		{
			num ^= RaidPlayInfo.GetHashCode();
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
		joinRecvInfo_.WriteTo(ref output, _repeated_joinRecvInfo_codec);
		actionInfo_.WriteTo(ref output, _repeated_actionInfo_codec);
		if (IsReward)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsReward);
		}
		if (raidPlayInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RaidPlayInfo);
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
		num += joinRecvInfo_.CalculateSize(_repeated_joinRecvInfo_codec);
		num += actionInfo_.CalculateSize(_repeated_actionInfo_codec);
		if (IsReward)
		{
			num += 2;
		}
		if (raidPlayInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RaidPlayInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildInitInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		joinRecvInfo_.Add(other.joinRecvInfo_);
		actionInfo_.Add(other.actionInfo_);
		if (other.IsReward)
		{
			IsReward = other.IsReward;
		}
		if (other.raidPlayInfo_ != null)
		{
			if (raidPlayInfo_ == null)
			{
				RaidPlayInfo = new GuildRaidPlayDBInfo();
			}
			RaidPlayInfo.MergeFrom(other.RaidPlayInfo);
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
				joinRecvInfo_.AddEntriesFrom(ref input, _repeated_joinRecvInfo_codec);
				break;
			case 18u:
				actionInfo_.AddEntriesFrom(ref input, _repeated_actionInfo_codec);
				break;
			case 24u:
				IsReward = input.ReadBool();
				break;
			case 34u:
				if (raidPlayInfo_ == null)
				{
					RaidPlayInfo = new GuildRaidPlayDBInfo();
				}
				input.ReadMessage(RaidPlayInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
