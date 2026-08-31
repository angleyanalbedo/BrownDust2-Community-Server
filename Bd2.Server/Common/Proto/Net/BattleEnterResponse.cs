using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class BattleEnterResponse : IMessage<BattleEnterResponse>, IMessage, IEquatable<BattleEnterResponse>, IDeepCloneable<BattleEnterResponse>, IBufferMessage
{
	private static readonly MessageParser<BattleEnterResponse> _parser = new MessageParser<BattleEnterResponse>(() => new BattleEnterResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterInfoFieldNumber = 1;

	private MonsterDBInfo monsterInfo_;

	public const int BattleDeckFieldNumber = 2;

	private int battleDeck_;

	public const int EventScheduleInfoFieldNumber = 3;

	private EventScheduleDBInfo eventScheduleInfo_;

	public const int BuffStatInfoFieldNumber = 4;

	private static readonly FieldCodec<PictorialBuffStatDBInfo> _repeated_buffStatInfo_codec = FieldCodec.ForMessage(34u, PictorialBuffStatDBInfo.Parser);

	private readonly RepeatedField<PictorialBuffStatDBInfo> buffStatInfo_ = new RepeatedField<PictorialBuffStatDBInfo>();

	public const int MonsterHuntUserInfoFieldNumber = 5;

	private MonsterHuntUserDBInfo monsterHuntUserInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<BattleEnterResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleEnterResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterDBInfo MonsterInfo
	{
		get
		{
			return monsterInfo_;
		}
		set
		{
			monsterInfo_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BattleDeck
	{
		get
		{
			return battleDeck_;
		}
		set
		{
			battleDeck_ = value;
		}
	}

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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<PictorialBuffStatDBInfo> BuffStatInfo => buffStatInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntUserDBInfo MonsterHuntUserInfo
	{
		get
		{
			return monsterHuntUserInfo_;
		}
		set
		{
			monsterHuntUserInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEnterResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEnterResponse(BattleEnterResponse other)
		: this()
	{
		monsterInfo_ = ((other.monsterInfo_ != null) ? other.monsterInfo_.Clone() : null);
		battleDeck_ = other.battleDeck_;
		eventScheduleInfo_ = ((other.eventScheduleInfo_ != null) ? other.eventScheduleInfo_.Clone() : null);
		buffStatInfo_ = other.buffStatInfo_.Clone();
		monsterHuntUserInfo_ = ((other.monsterHuntUserInfo_ != null) ? other.monsterHuntUserInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleEnterResponse Clone()
	{
		return new BattleEnterResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as BattleEnterResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleEnterResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(MonsterInfo, other.MonsterInfo) && BattleDeck == other.BattleDeck && object.Equals(EventScheduleInfo, other.EventScheduleInfo) && buffStatInfo_.Equals(other.buffStatInfo_) && object.Equals(MonsterHuntUserInfo, other.MonsterHuntUserInfo))
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
		if (monsterInfo_ != null)
		{
			num ^= MonsterInfo.GetHashCode();
		}
		if (BattleDeck != 0)
		{
			num ^= BattleDeck.GetHashCode();
		}
		if (eventScheduleInfo_ != null)
		{
			num ^= EventScheduleInfo.GetHashCode();
		}
		num ^= buffStatInfo_.GetHashCode();
		if (monsterHuntUserInfo_ != null)
		{
			num ^= MonsterHuntUserInfo.GetHashCode();
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

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (monsterInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MonsterInfo);
		}
		if (BattleDeck != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleDeck);
		}
		if (eventScheduleInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EventScheduleInfo);
		}
		buffStatInfo_.WriteTo(ref output, _repeated_buffStatInfo_codec);
		if (monsterHuntUserInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MonsterHuntUserInfo);
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
		if (monsterInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterInfo);
		}
		if (BattleDeck != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDeck);
		}
		if (eventScheduleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EventScheduleInfo);
		}
		num += buffStatInfo_.CalculateSize(_repeated_buffStatInfo_codec);
		if (monsterHuntUserInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntUserInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleEnterResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.monsterInfo_ != null)
		{
			if (monsterInfo_ == null)
			{
				MonsterInfo = new MonsterDBInfo();
			}
			MonsterInfo.MergeFrom(other.MonsterInfo);
		}
		if (other.BattleDeck != 0)
		{
			BattleDeck = other.BattleDeck;
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
		if (other.monsterHuntUserInfo_ != null)
		{
			if (monsterHuntUserInfo_ == null)
			{
				MonsterHuntUserInfo = new MonsterHuntUserDBInfo();
			}
			MonsterHuntUserInfo.MergeFrom(other.MonsterHuntUserInfo);
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
			case 10u:
				if (monsterInfo_ == null)
				{
					MonsterInfo = new MonsterDBInfo();
				}
				input.ReadMessage(MonsterInfo);
				break;
			case 16u:
				BattleDeck = input.ReadInt32();
				break;
			case 26u:
				if (eventScheduleInfo_ == null)
				{
					EventScheduleInfo = new EventScheduleDBInfo();
				}
				input.ReadMessage(EventScheduleInfo);
				break;
			case 34u:
				buffStatInfo_.AddEntriesFrom(ref input, _repeated_buffStatInfo_codec);
				break;
			case 42u:
				if (monsterHuntUserInfo_ == null)
				{
					MonsterHuntUserInfo = new MonsterHuntUserDBInfo();
				}
				input.ReadMessage(MonsterHuntUserInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
