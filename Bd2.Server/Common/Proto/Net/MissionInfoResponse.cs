using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public sealed class MissionInfoResponse : IMessage<MissionInfoResponse>, IMessage, IEquatable<MissionInfoResponse>, IDeepCloneable<MissionInfoResponse>, IBufferMessage
{
	private static readonly MessageParser<MissionInfoResponse> _parser = new MessageParser<MissionInfoResponse>(() => new MissionInfoResponse());

	private UnknownFieldSet _unknownFields;

	public const int MissionInfoFieldNumber = 1;

	private static readonly FieldCodec<MissionDBInfo> _repeated_missionInfo_codec = FieldCodec.ForMessage(10u, MissionDBInfo.Parser);

	private readonly RepeatedField<MissionDBInfo> missionInfo_ = new RepeatedField<MissionDBInfo>();

	public const int MissionSectionRewardInfoFieldNumber = 2;

	private static readonly FieldCodec<MissionSectionRewardDBInfo> _repeated_missionSectionRewardInfo_codec = FieldCodec.ForMessage(18u, MissionSectionRewardDBInfo.Parser);

	private readonly RepeatedField<MissionSectionRewardDBInfo> missionSectionRewardInfo_ = new RepeatedField<MissionSectionRewardDBInfo>();

	public const int DailyMissionResetTimeFieldNumber = 3;

	private long dailyMissionResetTime_;

	public const int WeeklyMissionResetTimeFieldNumber = 4;

	private long weeklyMissionResetTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionInfoResponse> Parser => _parser;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor => MissionInfoResponseReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MissionDBInfo> MissionInfo => missionInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MissionSectionRewardDBInfo> MissionSectionRewardInfo => missionSectionRewardInfo_;

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long DailyMissionResetTime
	{
		get
		{
			return dailyMissionResetTime_;
		}
		set
		{
			dailyMissionResetTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long WeeklyMissionResetTime
	{
		get
		{
			return weeklyMissionResetTime_;
		}
		set
		{
			weeklyMissionResetTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionInfoResponse()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionInfoResponse(MissionInfoResponse other)
		: this()
	{
		missionInfo_ = other.missionInfo_.Clone();
		missionSectionRewardInfo_ = other.missionSectionRewardInfo_.Clone();
		dailyMissionResetTime_ = other.dailyMissionResetTime_;
		weeklyMissionResetTime_ = other.weeklyMissionResetTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MissionInfoResponse Clone()
	{
		return new MissionInfoResponse(this);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return Equals(other as MissionInfoResponse);
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MissionInfoResponse other)
	{
		if (other != null)
		{
			if (other != this)
			{
				if (missionInfo_.Equals(other.missionInfo_) && missionSectionRewardInfo_.Equals(other.missionSectionRewardInfo_) && DailyMissionResetTime == other.DailyMissionResetTime && WeeklyMissionResetTime == other.WeeklyMissionResetTime)
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
		num ^= missionInfo_.GetHashCode();
		num ^= missionSectionRewardInfo_.GetHashCode();
		if (DailyMissionResetTime != 0L)
		{
			num ^= DailyMissionResetTime.GetHashCode();
		}
		if (WeeklyMissionResetTime != 0L)
		{
			num ^= WeeklyMissionResetTime.GetHashCode();
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
		missionInfo_.WriteTo(ref output, _repeated_missionInfo_codec);
		missionSectionRewardInfo_.WriteTo(ref output, _repeated_missionSectionRewardInfo_codec);
		if (DailyMissionResetTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(DailyMissionResetTime);
		}
		if (WeeklyMissionResetTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(WeeklyMissionResetTime);
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
		num += missionInfo_.CalculateSize(_repeated_missionInfo_codec);
		num += missionSectionRewardInfo_.CalculateSize(_repeated_missionSectionRewardInfo_codec);
		if (DailyMissionResetTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DailyMissionResetTime);
		}
		if (WeeklyMissionResetTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(WeeklyMissionResetTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MissionInfoResponse other)
	{
		if (other != null)
		{
			missionInfo_.Add(other.missionInfo_);
			missionSectionRewardInfo_.Add(other.missionSectionRewardInfo_);
			if (other.DailyMissionResetTime != 0L)
			{
				DailyMissionResetTime = other.DailyMissionResetTime;
			}
			if (other.WeeklyMissionResetTime != 0L)
			{
				WeeklyMissionResetTime = other.WeeklyMissionResetTime;
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
			case 10u:
				missionInfo_.AddEntriesFrom(ref input, _repeated_missionInfo_codec);
				break;
			case 18u:
				missionSectionRewardInfo_.AddEntriesFrom(ref input, _repeated_missionSectionRewardInfo_codec);
				break;
			case 24u:
				DailyMissionResetTime = input.ReadInt64();
				break;
			case 32u:
				WeeklyMissionResetTime = input.ReadInt64();
				break;
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			}
		}
	}
}
