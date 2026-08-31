using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class GuildRaidBossBattleEnterResponse : IMessage<GuildRaidBossBattleEnterResponse>, IMessage, IEquatable<GuildRaidBossBattleEnterResponse>, IDeepCloneable<GuildRaidBossBattleEnterResponse>, IBufferMessage
{
	private static readonly MessageParser<GuildRaidBossBattleEnterResponse> _parser = new MessageParser<GuildRaidBossBattleEnterResponse>(() => new GuildRaidBossBattleEnterResponse());

	private UnknownFieldSet _unknownFields;

	public const int EventScheduleInfoFieldNumber = 1;

	private EventScheduleDBInfo eventScheduleInfo_;

	public const int BuffStatInfoFieldNumber = 2;

	private static readonly FieldCodec<PictorialBuffStatDBInfo> _repeated_buffStatInfo_codec = FieldCodec.ForMessage(18u, PictorialBuffStatDBInfo.Parser);

	private readonly RepeatedField<PictorialBuffStatDBInfo> buffStatInfo_ = new RepeatedField<PictorialBuffStatDBInfo>();

	public const int SupporterCharInfoFieldNumber = 3;

	private static readonly FieldCodec<GuildSupporterBattleCharInfo> _repeated_supporterCharInfo_codec = FieldCodec.ForMessage(26u, GuildSupporterBattleCharInfo.Parser);

	private readonly RepeatedField<GuildSupporterBattleCharInfo> supporterCharInfo_ = new RepeatedField<GuildSupporterBattleCharInfo>();

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildRaidBossBattleEnterResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => GuildRaidBossBattleEnterResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EventScheduleDBInfo EventScheduleInfo
	{
		get
		{
			return eventScheduleInfo_;
		}
		set
		{
			eventScheduleInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PictorialBuffStatDBInfo> BuffStatInfo => buffStatInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GuildSupporterBattleCharInfo> SupporterCharInfo => supporterCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidBossBattleEnterResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidBossBattleEnterResponse(GuildRaidBossBattleEnterResponse other)
		: this()
	{
		eventScheduleInfo_ = ((other.eventScheduleInfo_ != null) ? other.eventScheduleInfo_.Clone() : null);
		buffStatInfo_ = other.buffStatInfo_.Clone();
		supporterCharInfo_ = other.supporterCharInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildRaidBossBattleEnterResponse Clone()
	{
		return new GuildRaidBossBattleEnterResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GuildRaidBossBattleEnterResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildRaidBossBattleEnterResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(EventScheduleInfo, other.EventScheduleInfo) && buffStatInfo_.Equals(other.buffStatInfo_) && supporterCharInfo_.Equals(other.supporterCharInfo_))
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
		if (eventScheduleInfo_ != null)
		{
			num ^= EventScheduleInfo.GetHashCode();
		}
		num ^= buffStatInfo_.GetHashCode();
		num ^= supporterCharInfo_.GetHashCode();
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
		if (eventScheduleInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(EventScheduleInfo);
		}
		buffStatInfo_.WriteTo(ref output, _repeated_buffStatInfo_codec);
		supporterCharInfo_.WriteTo(ref output, _repeated_supporterCharInfo_codec);
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
		if (eventScheduleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EventScheduleInfo);
		}
		num += buffStatInfo_.CalculateSize(_repeated_buffStatInfo_codec);
		num += supporterCharInfo_.CalculateSize(_repeated_supporterCharInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildRaidBossBattleEnterResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eventScheduleInfo_ != null)
		{
			if (eventScheduleInfo_ == null)
			{
				EventScheduleInfo = new EventScheduleDBInfo();
			}
			EventScheduleInfo.MergeFrom(other.EventScheduleInfo);
		}
		buffStatInfo_.Add(other.buffStatInfo_);
		supporterCharInfo_.Add(other.supporterCharInfo_);
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
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				supporterCharInfo_.AddEntriesFrom(ref input, _repeated_supporterCharInfo_codec);
				break;
			case 18u:
				buffStatInfo_.AddEntriesFrom(ref input, _repeated_buffStatInfo_codec);
				break;
			case 10u:
				if (eventScheduleInfo_ == null)
				{
					EventScheduleInfo = new EventScheduleDBInfo();
				}
				input.ReadMessage(EventScheduleInfo);
				break;
			}
		}
	}
}
