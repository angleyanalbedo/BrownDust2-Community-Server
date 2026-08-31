using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidMemberRankingResponse : IMessage<GuildRaidMemberRankingResponse>, IMessage, IEquatable<GuildRaidMemberRankingResponse>, IDeepCloneable<GuildRaidMemberRankingResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidMemberRankingResponse> _parser = new MessageParser<GuildRaidMemberRankingResponse>(() => new GuildRaidMemberRankingResponse());

	private UnknownFieldSet _unknownFields;

	public const int RankInfoFieldNumber = 1;

	private static readonly FieldCodec<GuildRaidMemberRankDBInfo> _repeated_rankInfo_codec = FieldCodec.ForMessage(10u, GuildRaidMemberRankDBInfo.Parser);

	private readonly RepeatedField<GuildRaidMemberRankDBInfo> rankInfo_ = new RepeatedField<GuildRaidMemberRankDBInfo>();

	public const int UserRankInfoFieldNumber = 2;

	private GuildRaidMemberRankDBInfo userRankInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRaidMemberRankingResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GuildRaidMemberRankingResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GuildRaidMemberRankDBInfo> RankInfo => rankInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidMemberRankDBInfo UserRankInfo
	{
		get
		{
			return userRankInfo_;
		}
		set
		{
			userRankInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidMemberRankingResponse()
	{
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildRaidMemberRankingResponse(GuildRaidMemberRankingResponse other)
		: this()
	{
		rankInfo_ = other.rankInfo_.Clone();
		userRankInfo_ = ((other.userRankInfo_ != null) ? other.userRankInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidMemberRankingResponse Clone()
	{
		return new GuildRaidMemberRankingResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidMemberRankingResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRaidMemberRankingResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (rankInfo_.Equals(other.rankInfo_) && object.Equals(UserRankInfo, other.UserRankInfo))
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
		num ^= rankInfo_.GetHashCode();
		if (userRankInfo_ != null)
		{
			num ^= UserRankInfo.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		rankInfo_.WriteTo(ref output, _repeated_rankInfo_codec);
		if (userRankInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(UserRankInfo);
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
		num += rankInfo_.CalculateSize(_repeated_rankInfo_codec);
		if (userRankInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserRankInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildRaidMemberRankingResponse other)
	{
		if (other == null)
		{
			return;
		}
		rankInfo_.Add(other.rankInfo_);
		if (other.userRankInfo_ != null)
		{
			if (userRankInfo_ == null)
			{
				UserRankInfo = new GuildRaidMemberRankDBInfo();
			}
			UserRankInfo.MergeFrom(other.UserRankInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				if (userRankInfo_ == null)
				{
					UserRankInfo = new GuildRaidMemberRankDBInfo();
				}
				input.ReadMessage(UserRankInfo);
				break;
			case 10u:
				rankInfo_.AddEntriesFrom(ref input, _repeated_rankInfo_codec);
				break;
			}
		}
	}
}
