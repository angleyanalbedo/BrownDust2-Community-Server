using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildJoinResponse : IMessage<GuildJoinResponse>, IMessage, IEquatable<GuildJoinResponse>, IDeepCloneable<GuildJoinResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildJoinResponse> _parser = new MessageParser<GuildJoinResponse>(() => new GuildJoinResponse());

	private UnknownFieldSet _unknownFields;

	public const int GuildInfoFieldNumber = 1;

	private GuildDBInfo guildInfo_;

	public const int MemberInfoFieldNumber = 2;

	private static readonly FieldCodec<GuildMemberDBInfo> _repeated_memberInfo_codec = FieldCodec.ForMessage(18u, GuildMemberDBInfo.Parser);

	private readonly RepeatedField<GuildMemberDBInfo> memberInfo_ = new RepeatedField<GuildMemberDBInfo>();

	public const int BanTimeFieldNumber = 3;

	private long banTime_;

	public const int ResultTypeFieldNumber = 4;

	private Define_JoinResultType resultType_;

	public const int TopPercentFieldNumber = 5;

	private double topPercent_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildJoinResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildJoinResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Define_JoinResultType ResultType
	{
		get
		{
			return resultType_;
		}
		set
		{
			resultType_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public double TopPercent
	{
		get
		{
			return topPercent_;
		}
		set
		{
			topPercent_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildJoinResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildJoinResponse(GuildJoinResponse other)
		: this()
	{
		guildInfo_ = ((other.guildInfo_ != null) ? other.guildInfo_.Clone() : null);
		memberInfo_ = other.memberInfo_.Clone();
		banTime_ = other.banTime_;
		resultType_ = other.resultType_;
		topPercent_ = other.topPercent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildJoinResponse Clone()
	{
		return new GuildJoinResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildJoinResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildJoinResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(GuildInfo, other.GuildInfo) && memberInfo_.Equals(other.memberInfo_) && BanTime == other.BanTime && ResultType == other.ResultType && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TopPercent, other.TopPercent))
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
		if (BanTime != 0L)
		{
			num ^= BanTime.GetHashCode();
		}
		if (ResultType != Define_JoinResultType.GuildJoinSuccess)
		{
			num ^= ResultType.GetHashCode();
		}
		if (TopPercent != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TopPercent);
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
		if (guildInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(GuildInfo);
		}
		memberInfo_.WriteTo(ref output, _repeated_memberInfo_codec);
		if (BanTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(BanTime);
		}
		if (ResultType != Define_JoinResultType.GuildJoinSuccess)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ResultType);
		}
		if (TopPercent != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(TopPercent);
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
		if (guildInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GuildInfo);
		}
		num += memberInfo_.CalculateSize(_repeated_memberInfo_codec);
		if (BanTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BanTime);
		}
		if (ResultType != Define_JoinResultType.GuildJoinSuccess)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResultType);
		}
		if (TopPercent != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildJoinResponse other)
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
		if (other.BanTime != 0L)
		{
			BanTime = other.BanTime;
		}
		if (other.ResultType != Define_JoinResultType.GuildJoinSuccess)
		{
			ResultType = other.ResultType;
		}
		if (other.TopPercent != 0.0)
		{
			TopPercent = other.TopPercent;
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
				if (guildInfo_ == null)
				{
					GuildInfo = new GuildDBInfo();
				}
				input.ReadMessage(GuildInfo);
				break;
			case 18u:
				memberInfo_.AddEntriesFrom(ref input, _repeated_memberInfo_codec);
				break;
			case 24u:
				BanTime = input.ReadInt64();
				break;
			case 32u:
				ResultType = (Define_JoinResultType)input.ReadEnum();
				break;
			case 41u:
				TopPercent = input.ReadDouble();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
