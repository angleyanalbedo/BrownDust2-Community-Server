using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class TotalWarBattleStartResponse : IMessage<TotalWarBattleStartResponse>, IMessage, IEquatable<TotalWarBattleStartResponse>, IDeepCloneable<TotalWarBattleStartResponse>, IBufferMessage
{
	private static readonly MessageParser<TotalWarBattleStartResponse> _parser = new MessageParser<TotalWarBattleStartResponse>(() => new TotalWarBattleStartResponse());

	private UnknownFieldSet _unknownFields;

	public const int BattleRandomSeedFieldNumber = 1;

	private int battleRandomSeed_;

	public const int BlueCharInfoFieldNumber = 2;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_blueCharInfo_codec = FieldCodec.ForMessage(18u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> blueCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int RedCharInfoFieldNumber = 3;

	private static readonly FieldCodec<BattleCharDBInfo> _repeated_redCharInfo_codec = FieldCodec.ForMessage(26u, BattleCharDBInfo.Parser);

	private readonly RepeatedField<BattleCharDBInfo> redCharInfo_ = new RepeatedField<BattleCharDBInfo>();

	public const int BuffStatInfoFieldNumber = 4;

	private static readonly FieldCodec<PictorialBuffStatDBInfo> _repeated_buffStatInfo_codec = FieldCodec.ForMessage(34u, PictorialBuffStatDBInfo.Parser);

	private readonly RepeatedField<PictorialBuffStatDBInfo> buffStatInfo_ = new RepeatedField<PictorialBuffStatDBInfo>();

	public const int EventScheduleInfoFieldNumber = 5;

	private EventScheduleDBInfo eventScheduleInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TotalWarBattleStartResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => TotalWarBattleStartResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BattleRandomSeed
	{
		get
		{
			return battleRandomSeed_;
		}
		set
		{
			battleRandomSeed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> BlueCharInfo => blueCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleCharDBInfo> RedCharInfo => redCharInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PictorialBuffStatDBInfo> BuffStatInfo => buffStatInfo_;

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
	public TotalWarBattleStartResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TotalWarBattleStartResponse(TotalWarBattleStartResponse other)
		: this()
	{
		battleRandomSeed_ = other.battleRandomSeed_;
		blueCharInfo_ = other.blueCharInfo_.Clone();
		redCharInfo_ = other.redCharInfo_.Clone();
		buffStatInfo_ = other.buffStatInfo_.Clone();
		eventScheduleInfo_ = ((other.eventScheduleInfo_ != null) ? other.eventScheduleInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TotalWarBattleStartResponse Clone()
	{
		return new TotalWarBattleStartResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as TotalWarBattleStartResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TotalWarBattleStartResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (BattleRandomSeed == other.BattleRandomSeed && blueCharInfo_.Equals(other.blueCharInfo_) && redCharInfo_.Equals(other.redCharInfo_) && buffStatInfo_.Equals(other.buffStatInfo_) && object.Equals(EventScheduleInfo, other.EventScheduleInfo))
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
		if (BattleRandomSeed != 0)
		{
			num ^= BattleRandomSeed.GetHashCode();
		}
		num ^= blueCharInfo_.GetHashCode();
		num ^= redCharInfo_.GetHashCode();
		num ^= buffStatInfo_.GetHashCode();
		if (eventScheduleInfo_ != null)
		{
			num ^= EventScheduleInfo.GetHashCode();
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
		if (BattleRandomSeed != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BattleRandomSeed);
		}
		blueCharInfo_.WriteTo(ref output, _repeated_blueCharInfo_codec);
		redCharInfo_.WriteTo(ref output, _repeated_redCharInfo_codec);
		buffStatInfo_.WriteTo(ref output, _repeated_buffStatInfo_codec);
		if (eventScheduleInfo_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(EventScheduleInfo);
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
		if (BattleRandomSeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleRandomSeed);
		}
		num += blueCharInfo_.CalculateSize(_repeated_blueCharInfo_codec);
		num += redCharInfo_.CalculateSize(_repeated_redCharInfo_codec);
		num += buffStatInfo_.CalculateSize(_repeated_buffStatInfo_codec);
		if (eventScheduleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EventScheduleInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TotalWarBattleStartResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BattleRandomSeed != 0)
		{
			BattleRandomSeed = other.BattleRandomSeed;
		}
		blueCharInfo_.Add(other.blueCharInfo_);
		redCharInfo_.Add(other.redCharInfo_);
		buffStatInfo_.Add(other.buffStatInfo_);
		if (other.eventScheduleInfo_ != null)
		{
			if (eventScheduleInfo_ == null)
			{
				EventScheduleInfo = new EventScheduleDBInfo();
			}
			EventScheduleInfo.MergeFrom(other.EventScheduleInfo);
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
			case 8u:
				BattleRandomSeed = input.ReadInt32();
				break;
			case 18u:
				blueCharInfo_.AddEntriesFrom(ref input, _repeated_blueCharInfo_codec);
				break;
			case 26u:
				redCharInfo_.AddEntriesFrom(ref input, _repeated_redCharInfo_codec);
				break;
			case 34u:
				buffStatInfo_.AddEntriesFrom(ref input, _repeated_buffStatInfo_codec);
				break;
			case 42u:
				if (eventScheduleInfo_ == null)
				{
					EventScheduleInfo = new EventScheduleDBInfo();
				}
				input.ReadMessage(EventScheduleInfo);
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
