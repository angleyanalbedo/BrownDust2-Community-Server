using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MonsterHuntScheduleInfoResponse : IMessage<MonsterHuntScheduleInfoResponse>, IMessage, IEquatable<MonsterHuntScheduleInfoResponse>, IDeepCloneable<MonsterHuntScheduleInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MonsterHuntScheduleInfoResponse> _parser = new MessageParser<MonsterHuntScheduleInfoResponse>(() => new MonsterHuntScheduleInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MonsterHuntScheduleInfoFieldNumber = 1;

	private MonsterHuntScheduleInfo monsterHuntScheduleInfo_;

	public const int StartRegularSeasonFieldNumber = 2;

	private int startRegularSeason_;

	public const int SeasonHistoryFieldNumber = 3;

	private static readonly FieldCodec<MonsterHuntScheduleHistory> _repeated_seasonHistory_codec = FieldCodec.ForMessage(26u, MonsterHuntScheduleHistory.Parser);

	private readonly RepeatedField<MonsterHuntScheduleHistory> seasonHistory_ = new RepeatedField<MonsterHuntScheduleHistory>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonsterHuntScheduleInfoResponse> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonsterHuntScheduleInfoResponseReflection.Descriptor.MessageTypes[0];

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterHuntScheduleInfo MonsterHuntScheduleInfo
	{
		get
		{
			return monsterHuntScheduleInfo_;
		}
		set
		{
			monsterHuntScheduleInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StartRegularSeason
	{
		get
		{
			return startRegularSeason_;
		}
		set
		{
			startRegularSeason_ = value;
		}
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterHuntScheduleHistory> SeasonHistory => seasonHistory_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntScheduleInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntScheduleInfoResponse(MonsterHuntScheduleInfoResponse other)
		: this()
	{
		monsterHuntScheduleInfo_ = ((other.monsterHuntScheduleInfo_ != null) ? other.monsterHuntScheduleInfo_.Clone() : null);
		startRegularSeason_ = other.startRegularSeason_;
		seasonHistory_ = other.seasonHistory_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterHuntScheduleInfoResponse Clone()
	{
		return new MonsterHuntScheduleInfoResponse(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonsterHuntScheduleInfoResponse);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonsterHuntScheduleInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (object.Equals(MonsterHuntScheduleInfo, other.MonsterHuntScheduleInfo) && StartRegularSeason == other.StartRegularSeason && seasonHistory_.Equals(other.seasonHistory_))
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
		if (monsterHuntScheduleInfo_ != null)
		{
			num ^= MonsterHuntScheduleInfo.GetHashCode();
		}
		if (StartRegularSeason != 0)
		{
			num ^= StartRegularSeason.GetHashCode();
		}
		num ^= seasonHistory_.GetHashCode();
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
		if (monsterHuntScheduleInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MonsterHuntScheduleInfo);
		}
		if (StartRegularSeason != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(StartRegularSeason);
		}
		seasonHistory_.WriteTo(ref output, _repeated_seasonHistory_codec);
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
		if (monsterHuntScheduleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MonsterHuntScheduleInfo);
		}
		if (StartRegularSeason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StartRegularSeason);
		}
		num += seasonHistory_.CalculateSize(_repeated_seasonHistory_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MonsterHuntScheduleInfoResponse other)
	{
		if (other == null)
		{
			return;
		}
		if (other.monsterHuntScheduleInfo_ != null)
		{
			if (monsterHuntScheduleInfo_ == null)
			{
				MonsterHuntScheduleInfo = new MonsterHuntScheduleInfo();
			}
			MonsterHuntScheduleInfo.MergeFrom(other.MonsterHuntScheduleInfo);
		}
		if (other.StartRegularSeason != 0)
		{
			StartRegularSeason = other.StartRegularSeason;
		}
		seasonHistory_.Add(other.seasonHistory_);
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
			case 26u:
				seasonHistory_.AddEntriesFrom(ref input, _repeated_seasonHistory_codec);
				break;
			case 16u:
				StartRegularSeason = input.ReadInt32();
				break;
			case 10u:
				if (monsterHuntScheduleInfo_ == null)
				{
					MonsterHuntScheduleInfo = new MonsterHuntScheduleInfo();
				}
				input.ReadMessage(MonsterHuntScheduleInfo);
				break;
			}
		}
	}
}
